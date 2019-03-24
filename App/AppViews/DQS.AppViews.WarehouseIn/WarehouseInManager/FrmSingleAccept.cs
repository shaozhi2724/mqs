using DevExpress.XtraEditors;
using DevExpress.XtraEditors.Repository;
using DQS.Common;
using DQS.Controls;
using DQS.Module.Entities;
using DQS.Module.Views;
using ORMSCore;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.IO;
using System.Linq;
using System.Windows.Forms;

namespace DQS.AppViews.WarehouseIn.WarehouseInManager
{
    public partial class FrmSingleAccept : DevExpress.XtraEditors.XtraForm
    {
        private int? m_id;
       // private int saveandin = 0;
        public FrmSingleAccept()
        {
            InitializeComponent();
        }
        private void FrmSingleAccept_Load(object sender, EventArgs e)
        {
            this.popupGrid.InitGrid();
            this.popupGrid.PopupView.KeyDown += PopupView_KeyDown;
            this.popupGrid.PopupView.MouseUp += PopupView_MouseUp;

            this.popupGridSampling.InitGrid();
            this.popupGridSampling.PopupView.KeyDown += SamplingPopupView_KeyDown;

            RepositoryItemComboBox cbo = new RepositoryItemComboBox();

            using (SqlConnection conn = new SqlConnection(GlobalItem.g_DbConnectStrings))
            {
                string sql = "SELECT AcceptResult FROM BUS_AcceptDetail GROUP BY AcceptResult";
                SqlDataAdapter sda = new SqlDataAdapter(sql, conn);
                DataSet ds = new DataSet();
                try
                {
                    sda.Fill(ds, "Table");
                    for (int i = 0; i < ds.Tables["Table"].Rows.Count; i++)
                    {
                        cbo.Items.Add(ds.Tables["Table"].Rows[i]["AcceptResult"].ToString());
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.ToString());
                }
                finally
                {
                    conn.Close();
                }
            }

            this.popupGrid.PopupView.Columns["验收结果及处置措施"].ColumnEdit = cbo;

            RepositoryItemComboBox cboresult = new RepositoryItemComboBox();

            using (SqlConnection conn = new SqlConnection(GlobalItem.g_DbConnectStrings))
            {
                string sql = "SELECT DetailRemark FROM BUS_AcceptDetail GROUP BY DetailRemark";
                SqlDataAdapter sda = new SqlDataAdapter(sql, conn);
                DataSet ds = new DataSet();
                try
                {
                    sda.Fill(ds, "Table");
                    for (int i = 0; i < ds.Tables["Table"].Rows.Count; i++)
                    {
                        cboresult.Items.Add(ds.Tables["Table"].Rows[i]["DetailRemark"].ToString());
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.ToString());
                }
                finally
                {
                    conn.Close();
                }
            }
            this.popupGrid.PopupView.Columns["不合格事项"].ColumnEdit = cboresult;

            RepositoryItemComboBox cboSolution = new RepositoryItemComboBox();

            cboSolution.Items.Add("合格区");
            cboSolution.Items.Add("不合格区");
            cboSolution.Items.Add("退货区");

            this.popupGrid.PopupView.Columns["存储库区"].ColumnEdit = cboSolution;

            if (this.Tag != null)
            {
                this.btnSaveAndIn.Enabled = false;
                this.btnReAccept.Enabled = false;
                this.m_id = Convert.ToInt32(this.Tag);

                BUSAcceptEntity entity = new BUSAcceptEntity { AcceptID = m_id.Value };
                entity.Fetch();

                this.ftPanel.SetEntity(entity);

                this.txtAcceptCode.Enabled = false;
                this.txtBillCode.Enabled = false;

                this.CustomGetEntity(entity);

                this.popupGrid.SetGridData(m_id.Value, false);

                this.popupGridSampling.SetGridData(m_id.Value, false);

                popupGrid.IsPurchase = txtBillTypeName.Text == "采购进货" ? true : false;

                bool isback = txtBillTypeName.Text.Trim() == "销售退货" ? true : false;
                if (isback)
                {
                    popupGrid.PopupView.Columns["批号"].OptionsColumn.AllowEdit = false;
                    popupGrid.PopupView.Columns["生产日期"].OptionsColumn.AllowEdit = false;
                    popupGrid.PopupView.Columns["有效期至"].OptionsColumn.AllowEdit = false;
                }
                else
                {
                    popupGrid.PopupView.Columns["批号"].OptionsColumn.AllowEdit = true;
                    popupGrid.PopupView.Columns["生产日期"].OptionsColumn.AllowEdit = true;
                    popupGrid.PopupView.Columns["有效期至"].OptionsColumn.AllowEdit = true;
                }

            }
            else
            {
                this.txtAcceptCode.Text = "YS" + DateTime.Now.ToString("yyyyMMddHHmmss");
                this.txtAcceptCode.Select(this.txtAcceptCode.Text.Length, 0);

                if (GlobalItem.g_CurrentEmployee != null)
                {
                    this.txtAcceptPerson.Text = GlobalItem.g_CurrentEmployee.EmployeeName;
                }
                else
                {
                    this.txtAcceptPerson.Text = GlobalItem.g_CurrentUser.UserName;
                }
                txtAcceptDate.Text = DateTime.Today.ToString("yyyy-MM-dd");
            }
        }

        private bool ValidateResultAmount()
        {
            int rowCount = this.popupGrid.PopupView.RowCount;
            for (int i = 0; i < rowCount; i++)
            {
                object acceptAmout = this.popupGrid.PopupView.GetRowCellValue(i, "验收数量");
                if (acceptAmout != null && acceptAmout != DBNull.Value)
                {
                    object rAmount = this.popupGrid.PopupView.GetRowCellValue(i, "验收合格数量");
                    object wAmount = this.popupGrid.PopupView.GetRowCellValue(i, "验收不合格数量");
                    if (rAmount != null && rAmount != DBNull.Value)
                    {
                        if (Convert.ToInt32(rAmount) + Convert.ToInt32(wAmount) != Convert.ToInt32(acceptAmout))
                        {
                            XtraMessageBox.Show(String.Format("表格中第{0}行产品的合格与不合格数量填写有误，请检查后重新填写。", (i + 1)), "系统提示", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            return false;
                        }
                    }
                }
            }
            return true;
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            try
            {
                if (!ValidateResultAmount()) return;
                if (!this.ftPanel.ValidateIsNullFields()) return;

                if (!ValidateDealerQualification()) return;
                if (txtBillTypeName.Text.Trim() != "销售退货")
                {
                    if (!ValidateProductQualification()) return;
                }
                BUSAcceptEntity entity = this.ftPanel.GetEntity() as BUSAcceptEntity;
                this.CustomSetEntity(entity);
                List<EntityBase> children = this.popupGrid.GetEntities();
                List<BUSAcceptDetailEntity> acceptDetails = children.Cast<BUSAcceptDetailEntity>().ToList();
                if (this.m_id != null)
                {
                    #region 修改

                    if (!this.ValidateAmount()) return;
                    if (!this.ValidateBatchNo()) return;
                    if (!this.ValidateBatchDate()) return;
                    if (!this.ValidateSamplingAmount()) return;
                    //List<BUSAcceptDetailEntity> acceptDetailEntities = new List<BUSAcceptDetailEntity>();
                    foreach (var busAcceptDetailEntity in acceptDetails)
                    {
                        if (busAcceptDetailEntity.IsNullField("Amount"))
                        {
                            busAcceptDetailEntity.Amount = 0;
                        }

                        if (busAcceptDetailEntity.IsNullField("ReceiveAmount"))
                        {
                            busAcceptDetailEntity.ReceiveAmount = 0;
                            busAcceptDetailEntity.Reservation2 = "0";
                        }
                        else
                        {
                            busAcceptDetailEntity.Reservation2 = (busAcceptDetailEntity.ReceiveAmount *
                                double.Parse(busAcceptDetailEntity.Reservation1)).ToString();
                        }

                        if (busAcceptDetailEntity.IsNullField("QualifiedAmount"))
                        {
                            busAcceptDetailEntity.QualifiedAmount = 0;
                        }

                        if (busAcceptDetailEntity.IsNullField("UnqualifiedAmount"))
                        {
                            busAcceptDetailEntity.UnqualifiedAmount = 0;
                        }
                    }
                    var deAcceptDetails = from a in acceptDetails
                                               group a by a.ProductID
                                                   into g
                                                   select new
                                                   {
                                                       ProductID = g.Key,
                                                       TotalBillAmount = g.Sum(p => p.Amount),
                                                       TotalReceiveAmount = g.Sum(p => p.ReceiveAmount),
                                                       TotalQualifiedAmount = g.Sum(p => p.QualifiedAmount),
                                                       TotalUnqualifiedAmount = g.Sum(p => p.ReceiveAmount) - g.Sum(p => p.QualifiedAmount),
                                                   };
                    var countedAcceptDetails = from a in acceptDetails
                                               group a by new { a.ProductID, a.BatchNo }
                                                   into g
                                                   select new
                                                   {
                                                       ProductID = g.Key.ProductID,
                                                       BatchNo = g.Key.BatchNo,
                                                       TotalBillAmount = g.Sum(p => p.Amount),
                                                       TotalReceiveAmount = g.Sum(p => p.ReceiveAmount),
                                                       TotalQualifiedAmount = g.Sum(p => p.QualifiedAmount),
                                                       TotalUnqualifiedAmount = g.Sum(p => p.ReceiveAmount) - g.Sum(p => p.QualifiedAmount),
                                                   };
                    var rejectedDetails =
                        deAcceptDetails.Where(p => p.TotalReceiveAmount < p.TotalBillAmount).ToList();
                    var unqualifiedDetails = countedAcceptDetails.Where(p => p.TotalUnqualifiedAmount > 0).ToList();
                    //1 - 收货数 < 订单数: 拒收提示
                    //2 - 不合格品数 > 0: 不合格平入库提示
                    if (rejectedDetails.Any())
                    {
                        var dialogResult = XtraMessageBox.Show("是否生成拒收记录？", "警告", MessageBoxButtons.YesNo, MessageBoxIcon.Exclamation);
                        if (dialogResult == DialogResult.No)
                        {
                            return;
                        }
                        if (dialogResult == DialogResult.Yes)
                        {
                            List<BUSAcceptDetailEntity> rejectedAcceptDetails = new List<BUSAcceptDetailEntity>();
                            foreach (var rejectedDetail in rejectedDetails)
                            {
                                var detail = acceptDetails.FirstOrDefault(p => p.ProductID == rejectedDetail.ProductID);
                                if (null != detail)
                                {
                                    var busAcceptDetailEntity = new BUSAcceptDetailEntity
                                    {
                                        ProductID = detail.ProductID,
                                        Amount = rejectedDetail.TotalBillAmount,
                                        ReceiveAmount = rejectedDetail.TotalReceiveAmount
                                    };
                                    if (!detail.IsNullField("ProduceDate"))
                                    {
                                        busAcceptDetailEntity.ProduceDate = detail.ProduceDate;
                                    }
                                    if (!detail.IsNullField("ValidateDate"))
                                    {
                                        busAcceptDetailEntity.ValidateDate = detail.ValidateDate;
                                    }
                                    if (!detail.IsNullField("BatchNo"))
                                    {
                                        busAcceptDetailEntity.BatchNo = detail.BatchNo;
                                    }
                                    rejectedAcceptDetails.Add(busAcceptDetailEntity);
                                }
                            }
                            if (rejectedAcceptDetails.Any())
                            {
                                GenerateDeclinedBill(entity, rejectedAcceptDetails);
                            }
                        }
                    }
                    else
                    {
                        BUSDeclinedEntity dec = new BUSDeclinedEntity { DeclinedCode = "YSJS-" + entity.AcceptCode };
                        dec.Fetch();
                        if (!dec.IsNullField("DeclinedID"))
                        {
                            //删除拒收明细
                            BUSDeclinedDetailEntity decDelete = new BUSDeclinedDetailEntity { DeclinedID = dec.DeclinedID };
                            decDelete.DeleteByCommonly();
                            //删除拒收单
                            dec.Delete();
                        }
                    }
                    if (unqualifiedDetails.Any())
                    {
                        //如果之前有不合格品单据，在删除前，先把不合格品库存删除
                        BUSStoreBillEntity sbill=new BUSStoreBillEntity{StoreCode = "BRK" + txtBillCode.Text.Substring(2) };
                        sbill.Fetch();
                        if (!sbill.IsNullField("StoreID"))
                        {
                            string sql = @"EXEC sp_DelUnqualifiedStoreDetail {0}";
                            sql = string.Format(sql, sbill.StoreID);
                            using (SqlConnection conn = new SqlConnection(GlobalItem.g_DbConnectStrings))
                            {
                                conn.Open(); //连接数据库
                                //必须为SqlCommand指定数据库连接和登记的事务
                                SqlCommand cmd = new SqlCommand(sql, conn);
                                try
                                {
                                    cmd.ExecuteNonQuery();
                                }
                                catch (Exception ex)
                                {
                                    XtraMessageBox.Show(ex.Message, "系统提示", MessageBoxButtons.OK, MessageBoxIcon.Error);
                                }
                                finally
                                {
                                    conn.Close();
                                }
                            }
                        }


                        List<BUSAcceptDetailEntity> unqualifiedAcceptDetails = new List<BUSAcceptDetailEntity>();
                        foreach (var unqualifiedDetail in unqualifiedDetails)
                        {
                            var detail = acceptDetails.FirstOrDefault(p => p.ProductID == unqualifiedDetail.ProductID && p.BatchNo == unqualifiedDetail.BatchNo && p.UnqualifiedAmount > 0);
                            if (null != detail)
                            {
                                var busAcceptDetailEntity = new BUSAcceptDetailEntity
                                {
                                    ProductID = detail.ProductID,
                                    BatchNo = detail.BatchNo,
                                    Amount = unqualifiedDetail.TotalBillAmount,
                                    ReceiveAmount = unqualifiedDetail.TotalUnqualifiedAmount,
                                    QualifiedAmount = unqualifiedDetail.TotalQualifiedAmount,
                                    UnqualifiedAmount = unqualifiedDetail.TotalUnqualifiedAmount,
                                    AcceptSolution = detail.IsNullField("AcceptSolution") ? "不合格区" : detail.AcceptSolution
                                };
                                if (!detail.IsNullField("ProduceDate"))
                                {
                                    busAcceptDetailEntity.ProduceDate = detail.ProduceDate;
                                }
                                if (!detail.IsNullField("ValidateDate"))
                                {
                                    busAcceptDetailEntity.ValidateDate = detail.ValidateDate;
                                }
                                if (!detail.IsNullField("BatchNo"))
                                {
                                    busAcceptDetailEntity.BatchNo = detail.BatchNo;
                                }
                                unqualifiedAcceptDetails.Add(busAcceptDetailEntity);
                            }
                        }
                        if (unqualifiedAcceptDetails.Any())
                        {
                            GenerateUnqualifiedStoreBill(entity, unqualifiedAcceptDetails);
                        }
                    }
                    else
                    {
                        BUSStoreBillEntity store = new BUSStoreBillEntity { StoreCode = "BRK" + txtBillCode.Text.Substring(2) };
                        store.Fetch();
                        if (!store.IsNullField("StoreID"))
                        {
                            string sql = @"EXEC sp_DelUnqualifiedStoreDetail {0}";
                            sql = string.Format(sql, store.StoreID);
                            using (SqlConnection conn = new SqlConnection(GlobalItem.g_DbConnectStrings))
                            {
                                conn.Open(); //连接数据库
                                //必须为SqlCommand指定数据库连接和登记的事务
                                SqlCommand cmd = new SqlCommand(sql, conn);
                                try
                                {
                                    cmd.ExecuteNonQuery();
                                }
                                catch (Exception ex)
                                {
                                    XtraMessageBox.Show(ex.Message, "系统提示", MessageBoxButtons.OK, MessageBoxIcon.Error);
                                }
                                finally
                                {
                                    conn.Close();
                                }
                            }

                            //删除不合格品入库明细
                            BUSStoreBillDetailEntity storeDelete = new BUSStoreBillDetailEntity { StoreID = store.StoreID };
                            storeDelete.DeleteByCommonly();
                            //删除不合格品入库
                            store.Delete();
                        }
                    }
                    entity.LastModifyDate = DateTime.Now;
                    entity.LastModifyUserID = GlobalItem.g_CurrentUser.UserID;
                    if (!countedAcceptDetails.Any() ||
                        countedAcceptDetails.ToList().TrueForAll(p => p.TotalReceiveAmount == 0))
                    {
                        entity.Reservation3 = "6";
                        entity.Reservation4 = "拒收";
                    }
                    else
                    {
                        entity.Reservation3 = "4";
                        entity.Reservation4 = "已验收";
                    }
                    entity.Update();
                    //先删除
                    BUSAcceptDetailEntity childToDelete = new BUSAcceptDetailEntity { AcceptID = m_id.Value };
                    childToDelete.DeleteByCommonly();

                    //后加
                    foreach (EntityBase childEntity in children)
                    {
                        BUSAcceptDetailEntity child = childEntity as BUSAcceptDetailEntity;
                        child.AcceptID = m_id.Value;
                        child.Save();
                    }
                    entity.Fetch();
                    //更新订单状态
                    BUSBillEntity bill = new BUSBillEntity { BillID = entity.BillID, };
                    bill.Fetch();
                    if (bill.BillStatusName != "验收复查")
                    {
                        if (!deAcceptDetails.Any() ||
                            deAcceptDetails.ToList().TrueForAll(p => p.TotalReceiveAmount == 0))
                        {
                            bill.BillStatus = 6;
                            bill.BillStatusName = "拒收";
                        }
                        else
                        {
                            bill.BillStatus = 4;
                            bill.BillStatusName = "已验收";
                            bill.AcceptID = entity.AcceptID;
                            bill.AcceptCode = entity.AcceptCode;
                        }
                        bill.Update();
                    }
                    //存在则修改
                    if (this.popupGridSampling.PopupView.GetRowCellValue(0, this.popupGridSampling.PopupView.Columns[0]) != null && this.popupGridSampling.PopupView.GetRowCellValue(0, this.popupGridSampling.PopupView.Columns[0]) != DBNull.Value)
                    {
                        //先删除
                        BUSSamplingEntity samplingToDelete = new BUSSamplingEntity() { AcceptID = m_id.Value };
                        samplingToDelete.DeleteByCommonly();

                        //添加抽检记录
                        List<EntityBase> samplings = this.popupGridSampling.GetEntities();
                        foreach (EntityBase samplingEntity in samplings)
                        {
                            BUSSamplingEntity sampling = samplingEntity as BUSSamplingEntity;
                            sampling.SamplingCode = Guid.NewGuid().ToString();
                            sampling.SamplingDate = DateTime.Now;
                            sampling.AcceptID = m_id.Value;
                            sampling.BillCode = entity.BillCode;
                            sampling.BillDate = entity.BillDate;
                            sampling.BillID = entity.BillID;
                            sampling.BillTypeID = entity.BillTypeID;
                            sampling.BillTypeName = entity.BillTypeName;
                            sampling.BillTypeSpell = entity.BillTypeSpell;
                            sampling.DealerID = entity.DealerID;
                            sampling.DealerCode = entity.DealerCode;
                            sampling.DealerName = entity.DealerName;
                            sampling.Inspector = this.txtAcceptPerson.Text.Trim();
                            sampling.InspectorSpell = GlobalMethod.GetAlphabetic(this.txtAcceptPerson.Text.Trim());
                            sampling.Save();
                        }
                    }
                    #endregion
                }
                else
                {
                    if (entity.IsNew(BUSAcceptEntityFields.AcceptCode == entity.AcceptCode))
                    {
                        #region 新建
                        entity.AcceptDate = DateTime.Now;
                        if (!this.ValidateAmount()) return;
                        if (!this.ValidateBatchNo()) return;
                        if (!this.ValidateBatchDate()) return;

                        for (int i = 0; i < this.popupGrid.PopupView.RowCount; i++)
                        {
                            if (!ValidateIsSupervise(i)) return;
                        }
                        if (!this.ValidateSamplingAmount()) return;
                        foreach (var busAcceptDetailEntity in acceptDetails)
                        {
                            if (busAcceptDetailEntity.IsNullField("Amount"))
                            {
                                busAcceptDetailEntity.Amount = 0;
                            }

                            if (busAcceptDetailEntity.IsNullField("ReceiveAmount"))
                            {
                                busAcceptDetailEntity.ReceiveAmount = 0;
                                busAcceptDetailEntity.Reservation2 = "0";
                            }
                            else
                            {
                                busAcceptDetailEntity.Reservation2 = (busAcceptDetailEntity.ReceiveAmount *
                                    double.Parse(busAcceptDetailEntity.Reservation1)).ToString();
                            }

                            if (busAcceptDetailEntity.IsNullField("QualifiedAmount"))
                            {
                                busAcceptDetailEntity.QualifiedAmount = 0;
                            }

                            if (busAcceptDetailEntity.IsNullField("UnqualifiedAmount"))
                            {
                                busAcceptDetailEntity.UnqualifiedAmount = 0;
                            }
                        }
                        if (txtBillTypeName.Text.Trim() == "销售退货")
                        {
                            var countedAcceptDetails = from a in acceptDetails
                                                       group a by new { a.ProductID, a.BatchNo }
                                                           into g
                                                           select new
                                                           {
                                                               ProductID = g.Key.ProductID,
                                                               BatchNo = g.Key.BatchNo,
                                                               TotalBillAmount = g.Sum(p => p.Amount),
                                                               TotalReceiveAmount = g.Sum(p => p.ReceiveAmount),
                                                               TotalQualifiedAmount = g.Sum(p => p.QualifiedAmount),
                                                               TotalUnqualifiedAmount = g.Sum(p => p.ReceiveAmount) - g.Sum(p => p.QualifiedAmount),
                                                           };
                            var rejectedDetails =
                                countedAcceptDetails.Where(p => p.TotalReceiveAmount < p.TotalBillAmount).ToList();
                            var unqualifiedDetails = countedAcceptDetails.Where(p => p.TotalUnqualifiedAmount > 0).ToList();
                            //1 - 收货数 < 订单数: 拒收提示
                            //2 - 不合格品数 > 0: 不合格平入库提示
                            if (rejectedDetails.Any() || unqualifiedDetails.Any())
                            {
                                var message = string.Empty;
                                if (rejectedDetails.Any() && unqualifiedDetails.Any())
                                {
                                    message = "收货数量与验收数量不符，是否生成拒收记录？\n验收合格数量与验收到货数量不符，是否生成不合格品记录？";
                                }
                                else if (rejectedDetails.Any())
                                {
                                    message = "收货数量与验收数量不符，是否生成拒收记录？";
                                }
                                else if (unqualifiedDetails.Any())
                                {
                                    message = "验收合格数量与验收数量不符，是否生成不合格品记录？";
                                }
                                var dialogResult = XtraMessageBox.Show(message, "警告", MessageBoxButtons.YesNo, MessageBoxIcon.Exclamation);
                                if (dialogResult == DialogResult.No)
                                {
                                    return;
                                }
                                if (dialogResult == DialogResult.Yes)
                                {
                                    List<BUSAcceptDetailEntity> rejectedAcceptDetails = new List<BUSAcceptDetailEntity>();
                                    foreach (var rejectedDetail in rejectedDetails)
                                    {
                                        var detail = acceptDetails.FirstOrDefault(p => p.ProductID == rejectedDetail.ProductID);
                                        if (null != detail)
                                        {
                                            var busAcceptDetailEntity = new BUSAcceptDetailEntity
                                            {
                                                ProductID = detail.ProductID,
                                                Amount = rejectedDetail.TotalBillAmount,
                                                ReceiveAmount = rejectedDetail.TotalReceiveAmount
                                            };
                                            if (!detail.IsNullField("ProduceDate"))
                                            {
                                                busAcceptDetailEntity.ProduceDate = detail.ProduceDate;
                                            }
                                            if (!detail.IsNullField("ValidateDate"))
                                            {
                                                busAcceptDetailEntity.ValidateDate = detail.ValidateDate;
                                            }
                                            if (!detail.IsNullField("BatchNo"))
                                            {
                                                busAcceptDetailEntity.BatchNo = detail.BatchNo;
                                            }
                                            rejectedAcceptDetails.Add(busAcceptDetailEntity);
                                        }
                                    }
                                    if (rejectedAcceptDetails.Any())
                                    {
                                        GenerateDeclinedBill(entity, rejectedAcceptDetails);
                                    }

                                    List<BUSAcceptDetailEntity> unqualifiedAcceptDetails = new List<BUSAcceptDetailEntity>();
                                    foreach (var unqualifiedDetail in unqualifiedDetails)
                                    {
                                        var detail = acceptDetails.FirstOrDefault(p => p.ProductID == unqualifiedDetail.ProductID && p.BatchNo == unqualifiedDetail.BatchNo && p.UnqualifiedAmount > 0);
                                        if (null != detail)
                                        {
                                            var busAcceptDetailEntity = new BUSAcceptDetailEntity
                                            {
                                                ProductID = detail.ProductID,
                                                BatchNo = detail.BatchNo,
                                                Amount = unqualifiedDetail.TotalBillAmount,
                                                ReceiveAmount = unqualifiedDetail.TotalUnqualifiedAmount,
                                                QualifiedAmount = unqualifiedDetail.TotalQualifiedAmount,
                                                UnqualifiedAmount = unqualifiedDetail.TotalUnqualifiedAmount,
                                                AcceptSolution = detail.IsNullField("AcceptSolution") ? "不合格区" : detail.AcceptSolution
                                            };
                                            if (!detail.IsNullField("ProduceDate"))
                                            {
                                                busAcceptDetailEntity.ProduceDate = detail.ProduceDate;
                                            }
                                            if (!detail.IsNullField("ValidateDate"))
                                            {
                                                busAcceptDetailEntity.ValidateDate = detail.ValidateDate;
                                            }
                                            if (!detail.IsNullField("BatchNo"))
                                            {
                                                busAcceptDetailEntity.BatchNo = detail.BatchNo;
                                            }
                                            unqualifiedAcceptDetails.Add(busAcceptDetailEntity);
                                        }
                                    }
                                    if (unqualifiedAcceptDetails.Any())
                                    {
                                        GenerateUnqualifiedStoreBill(entity, unqualifiedAcceptDetails);
                                    }
                                }
                            }
                            entity.CreateDate = DateTime.Now;
                            entity.LastModifyDate = DateTime.Now;
                            entity.CreateUserID = GlobalItem.g_CurrentUser.UserID;
                            entity.LastModifyUserID = GlobalItem.g_CurrentUser.UserID;
                            entity.Save();
                            //查询出其ID
                            entity.Fetch();

                            BUSBillEntity bill = new BUSBillEntity { BillID = entity.BillID };
                            if (!countedAcceptDetails.Any() ||
                                countedAcceptDetails.ToList().TrueForAll(p => p.TotalReceiveAmount == 0))
                            {
                                bill.BillStatus = 6;
                                bill.BillStatusName = "拒收";
                            }
                            else
                            {
                                bill.BillStatus = 4;
                                bill.BillStatusName = "已验收";
                                bill.AcceptID = entity.AcceptID;
                                bill.AcceptCode = entity.AcceptCode;
                            }
                            bill.Update();
                            foreach (EntityBase childEntity in children)
                            {
                                BUSAcceptDetailEntity child = childEntity as BUSAcceptDetailEntity;
                                child.AcceptID = entity.AcceptID;
                                child.Save();
                            }
                            //存在则添加
                            if (this.popupGridSampling.PopupView.GetRowCellValue(0, this.popupGridSampling.PopupView.Columns[0]) != null && this.popupGridSampling.PopupView.GetRowCellValue(0, this.popupGridSampling.PopupView.Columns[0]) != DBNull.Value)
                            {
                                List<EntityBase> samplings = this.popupGridSampling.GetEntities();
                                //添加抽检记录
                                foreach (EntityBase samplingEntity in samplings)
                                {
                                    BUSSamplingEntity sampling = samplingEntity as BUSSamplingEntity;
                                    sampling.SamplingCode = Guid.NewGuid().ToString();
                                    sampling.SamplingDate = DateTime.Now;
                                    sampling.AcceptID = entity.AcceptID;
                                    sampling.BillCode = entity.BillCode;
                                    sampling.BillDate = entity.BillDate;
                                    sampling.BillID = entity.BillID;
                                    sampling.BillTypeID = entity.BillTypeID;
                                    sampling.BillTypeName = entity.BillTypeName;
                                    sampling.BillTypeSpell = entity.BillTypeSpell;
                                    sampling.DealerID = entity.DealerID;
                                    sampling.DealerCode = entity.DealerCode;
                                    sampling.DealerName = entity.DealerName;
                                    sampling.Inspector = this.txtAcceptPerson.Text.Trim();
                                    sampling.InspectorSpell = GlobalMethod.GetAlphabetic(this.txtAcceptPerson.Text.Trim());
                                    sampling.Save();
                                }
                            }
                        }
                        else
                        {
                            var countedAcceptDetails = from a in acceptDetails
                                                       group a by a.ProductID
                                                           into g
                                                           select new
                                                           {
                                                               ProductID = g.Key,
                                                               TotalBillAmount = g.Sum(p => p.Amount),
                                                               TotalReceiveAmount = g.Sum(p => p.ReceiveAmount),
                                                               TotalQualifiedAmount = g.Sum(p => p.QualifiedAmount),
                                                               TotalUnqualifiedAmount = g.Sum(p => p.ReceiveAmount) - g.Sum(p => p.QualifiedAmount),
                                                           };
                            var countedAcceptDetailsAll = from a in acceptDetails
                                                          select new
                                                          {
                                                              ProductID = a.ProductID,
                                                              BatchNo = a.BatchNo,
                                                              ReceiveAmount = a.ReceiveAmount,
                                                              QualifiedAmount = a.QualifiedAmount,
                                                              UnqualifiedAmount = a.UnqualifiedAmount
                                                          };

                            var rejectedDetails =
                                countedAcceptDetails.Where(p => p.TotalReceiveAmount < p.TotalBillAmount).ToList();
                            var unqualifiedDetails = countedAcceptDetailsAll.Where(p => p.UnqualifiedAmount > 0).ToList();
                            //1 - 收货数 < 订单数: 拒收提示
                            //2 - 不合格品数 > 0: 不合格平入库提示
                            if (rejectedDetails.Any() || unqualifiedDetails.Any())
                            {
                                var message = string.Empty;
                                if (rejectedDetails.Any() && unqualifiedDetails.Any())
                                {
                                    message = "收货数量与验收数量不符，是否生成拒收记录？\n验收合格数量与验收到货数量不符，是否生成不合格品记录？";
                                }
                                else if (rejectedDetails.Any())
                                {
                                    message = "收货数量与验收数量不符，是否生成拒收记录？";
                                }
                                else if (unqualifiedDetails.Any())
                                {
                                    message = "验收合格数量与验收数量不符，是否生成不合格品记录？";
                                }
                                var dialogResult = XtraMessageBox.Show(message, "警告", MessageBoxButtons.YesNo, MessageBoxIcon.Exclamation);
                                if (dialogResult == DialogResult.No)
                                {
                                    return;
                                }
                                if (dialogResult == DialogResult.Yes)
                                {
                                    List<BUSAcceptDetailEntity> rejectedAcceptDetails = new List<BUSAcceptDetailEntity>();
                                    foreach (var rejectedDetail in rejectedDetails)
                                    {
                                        var detail = acceptDetails.FirstOrDefault(p => p.ProductID == rejectedDetail.ProductID);
                                        if (null != detail)
                                        {
                                            var busAcceptDetailEntity = new BUSAcceptDetailEntity
                                            {
                                                ProductID = detail.ProductID,
                                                Amount = rejectedDetail.TotalBillAmount,
                                                ReceiveAmount = rejectedDetail.TotalReceiveAmount
                                            };
                                            if (!detail.IsNullField("ProduceDate"))
                                            {
                                                busAcceptDetailEntity.ProduceDate = detail.ProduceDate;
                                            }
                                            if (!detail.IsNullField("ValidateDate"))
                                            {
                                                busAcceptDetailEntity.ValidateDate = detail.ValidateDate;
                                            }
                                            if (!detail.IsNullField("BatchNo"))
                                            {
                                                busAcceptDetailEntity.BatchNo = detail.BatchNo;
                                            }
                                            rejectedAcceptDetails.Add(busAcceptDetailEntity);
                                        }
                                    }
                                    if (rejectedAcceptDetails.Any())
                                    {
                                        GenerateDeclinedBill(entity, rejectedAcceptDetails);
                                    }

                                    List<BUSAcceptDetailEntity> unqualifiedAcceptDetails = new List<BUSAcceptDetailEntity>();
                                    foreach (var unqualifiedDetail in unqualifiedDetails)
                                    {
                                        var detail = acceptDetails.FirstOrDefault(p => p.ProductID == unqualifiedDetail.ProductID && p.BatchNo==unqualifiedDetail.BatchNo && p.UnqualifiedAmount > 0);
                                        if (null != detail)
                                        {

                                            var ReceiveAmountList = (from a in acceptDetails.Where(p => p.ProductID==detail.ProductID && p.BatchNo.Equals(detail.BatchNo))
                                                             group a by a.ProductID
                                                                 into g
                                                                 select new
                                                                 {
                                                                     ReceiveAmount = g.Sum(p => p.ReceiveAmount)
                                                                 }).ToList();
                                            var busAcceptDetailEntity = new BUSAcceptDetailEntity
                                            {
                                                ProductID = detail.ProductID,
                                                Amount = unqualifiedDetail.UnqualifiedAmount,
                                                ReceiveAmount = ReceiveAmountList[0].ReceiveAmount,
                                                QualifiedAmount = unqualifiedDetail.QualifiedAmount,
                                                UnqualifiedAmount = unqualifiedDetail.UnqualifiedAmount,
                                                AcceptSolution = detail.IsNullField("AcceptSolution") ? "不合格区" : detail.AcceptSolution
                                            };
                                            if (!detail.IsNullField("ProduceDate"))
                                            {
                                                busAcceptDetailEntity.ProduceDate = detail.ProduceDate;
                                            }
                                            if (!detail.IsNullField("ValidateDate"))
                                            {
                                                busAcceptDetailEntity.ValidateDate = detail.ValidateDate;
                                            }
                                            if (!detail.IsNullField("BatchNo"))
                                            {
                                                busAcceptDetailEntity.BatchNo = detail.BatchNo;
                                            }
                                            unqualifiedAcceptDetails.Add(busAcceptDetailEntity);
                                        }
                                    }
                                    if (unqualifiedAcceptDetails.Any())
                                    {
                                        GenerateUnqualifiedStoreBill(entity, unqualifiedAcceptDetails);
                                    }
                                }
                            }
                            entity.CreateDate = DateTime.Now;
                            entity.LastModifyDate = DateTime.Now;
                            entity.CreateUserID = GlobalItem.g_CurrentUser.UserID;
                            entity.LastModifyUserID = GlobalItem.g_CurrentUser.UserID;
                            entity.Save();
                            //查询出其ID
                            entity.Fetch();

                            BUSBillEntity bill = new BUSBillEntity { BillID = entity.BillID };
                            if (!countedAcceptDetails.Any() ||
                                countedAcceptDetails.ToList().TrueForAll(p => p.TotalReceiveAmount == 0))
                            {
                                bill.BillStatus = 6;
                                bill.BillStatusName = "拒收";
                            }
                            else
                            {
                                bill.BillStatus = 4;
                                bill.BillStatusName = "已验收";
                                bill.AcceptID = entity.AcceptID;
                                bill.AcceptCode = entity.AcceptCode;
                            }
                            bill.Update();
                            foreach (EntityBase childEntity in children)
                            {
                                BUSAcceptDetailEntity child = childEntity as BUSAcceptDetailEntity;
                                child.AcceptID = entity.AcceptID;
                                child.Save();
                            }
                            //存在则添加
                            if (this.popupGridSampling.PopupView.GetRowCellValue(0, this.popupGridSampling.PopupView.Columns[0]) != null && this.popupGridSampling.PopupView.GetRowCellValue(0, this.popupGridSampling.PopupView.Columns[0]) != DBNull.Value)
                            {
                                List<EntityBase> samplings = this.popupGridSampling.GetEntities();
                                //添加抽检记录
                                foreach (EntityBase samplingEntity in samplings)
                                {
                                    BUSSamplingEntity sampling = samplingEntity as BUSSamplingEntity;
                                    sampling.SamplingCode = Guid.NewGuid().ToString();
                                    sampling.SamplingDate = DateTime.Now;
                                    sampling.AcceptID = entity.AcceptID;
                                    sampling.BillCode = entity.BillCode;
                                    sampling.BillDate = entity.BillDate;
                                    sampling.BillID = entity.BillID;
                                    sampling.BillTypeID = entity.BillTypeID;
                                    sampling.BillTypeName = entity.BillTypeName;
                                    sampling.BillTypeSpell = entity.BillTypeSpell;
                                    sampling.DealerID = entity.DealerID;
                                    sampling.DealerCode = entity.DealerCode;
                                    sampling.DealerName = entity.DealerName;
                                    sampling.Inspector = this.txtAcceptPerson.Text.Trim();
                                    sampling.InspectorSpell = GlobalMethod.GetAlphabetic(this.txtAcceptPerson.Text.Trim());
                                    sampling.Save();
                                }
                            }
                        }
                        #endregion
                        /*
                        if (saveandin == 1)
                        {
                            BUSStoreBillEntity storebill = new BUSStoreBillEntity();
                            storebill.StoreCode = "";
                        }
                        */
                    }
                    else
                    {
                        XtraMessageBox.Show("验收单已存在。", "警告", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                        return;
                    }
                }

                string sqlDamaged = @"EXEC sp_AcceptForDamaged '{0}'";
                sqlDamaged = string.Format(sqlDamaged, txtAcceptCode.Text);
                using (SqlConnection conn = new SqlConnection(GlobalItem.g_DbConnectStrings))
                {
                    conn.Open(); //连接数据库
                    //必须为SqlCommand指定数据库连接和登记的事务
                    SqlCommand cmd = new SqlCommand(sqlDamaged, conn);
                    try
                    {
                        cmd.ExecuteNonQuery();
                    }
                    catch (Exception ex)
                    {
                        XtraMessageBox.Show(ex.Message, "系统提示", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                    finally
                    {
                        conn.Close();
                    }
                }
            }
            catch (Exception ex)
            {
                XtraMessageBox.Show(ex.Message, "错误", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                return;
            }

            this.DialogResult = DialogResult.OK;
        }

        public bool ValidateIsSupervise(int i)
        {
            object productID = this.popupGrid.PopupView.GetRowCellValue(i, "产品ID");

            if (productID != null && productID != DBNull.Value)
            {
                BFIProductEntity product = new BFIProductEntity { ProductID = (int)productID };
                product.Fetch();
                if (product.SuperviseSignBar.Trim() != "")
                {
                    DialogResult dr = XtraMessageBox.Show(string.Format("第{0}行产品：{1} 为电子监管产品，是否已经扫描电子监管码？", i + 1, product.ProductName), "系统提示", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                    return dr == DialogResult.Yes;
                }
            }
            return true;
        }

        private void GenerateUnqualifiedStoreBill(BUSAcceptEntity acceptEntity, List<BUSAcceptDetailEntity> unqualifiedAcceptDetails)
        {
            
            string storeKeeper = string.Empty;
            if (GlobalItem.g_CurrentEmployee != null)
            {
                storeKeeper = GlobalItem.g_CurrentEmployee.EmployeeName;
            }

            EntityCollection<BUSStoreBillEntity> storeBills = new EntityCollection<BUSStoreBillEntity>();
            storeBills.Fetch(BUSStoreBillEntityFields.PurchaseBillID == acceptEntity.BillID & BUSStoreBillEntityFields.StoreTypeID == 3);
            BUSStoreBillEntity storeBillEntity = null;
            if (storeBills.Count > 0)
            {
                storeBillEntity = storeBills[0] as BUSStoreBillEntity;
            }
            if (null == storeBillEntity)
            {
                storeBillEntity = new BUSStoreBillEntity();
            }
            storeBillEntity.StoreDate = DateTime.Now;
            storeBillEntity.PurchaseBillID = acceptEntity.BillID;
            storeBillEntity.PurchaseBillCode = acceptEntity.BillCode;
            storeBillEntity.DealerID = acceptEntity.DealerID;
            storeBillEntity.DealerName = acceptEntity.DealerName;
            storeBillEntity.DealerSpell = acceptEntity.DealerSpell;
            storeBillEntity.StoreKeeper = storeKeeper;
            storeBillEntity.StoreTypeID = 3;
            storeBillEntity.StoreTypeName = "不合格品";
            storeBillEntity.CreateDate = DateTime.Now;
            storeBillEntity.CreateUserID = GlobalItem.g_CurrentUser.UserID;
            if (!storeBillEntity.IsNew(BUSStoreBillEntityFields.StoreCode == storeBillEntity.StoreCode))
            {
                storeBillEntity.StoreCode = "BRK" + txtBillCode.Text.Substring(2);
                storeBillEntity.LastModifyDate = DateTime.Now;
                storeBillEntity.LastModifyUserID = GlobalItem.g_CurrentUser.UserID;
                storeBillEntity.Update();
                BUSStoreBillDetailEntity childToDelete = new BUSStoreBillDetailEntity { StoreID = storeBillEntity.StoreID };
                childToDelete.DeleteByCommonly();
            }
            else
            {
                storeBillEntity.StoreCode = "BRK" + txtBillCode.Text.Substring(2);
                storeBillEntity.Save();
            }
            storeBillEntity.Fetch();
            foreach (var unqualifiedAcceptDetail in unqualifiedAcceptDetails)
            {
                var storeBillDetail = new BUSStoreBillDetailEntity()
                {
                    StoreID = storeBillEntity.StoreID,
                    ProductID = unqualifiedAcceptDetail.ProductID,
                    BillAmount = unqualifiedAcceptDetail.ReceiveAmount,
                    QualifiedAmount = unqualifiedAcceptDetail.QualifiedAmount,
                    Amount = unqualifiedAcceptDetail.UnqualifiedAmount,
                    Reservation7 = unqualifiedAcceptDetail.AcceptSolution,
                    CreateUserID = GlobalItem.g_CurrentUser.UserID,
                    CreateDate = DateTime.Now,
                    DetailRemark = string.Format("{0} - 验收不合格品入库 {1} (总数:{2})", acceptEntity.BillCode, unqualifiedAcceptDetail.ProductID, unqualifiedAcceptDetail.UnqualifiedAmount)
                };
                if (!unqualifiedAcceptDetail.IsNullField("ProduceDate"))
                {
                    storeBillDetail.ProduceDate = unqualifiedAcceptDetail.ProduceDate;
                }
                if (!unqualifiedAcceptDetail.IsNullField("ValidateDate"))
                {
                    storeBillDetail.ValidateDate = unqualifiedAcceptDetail.ValidateDate;
                }
                if (!unqualifiedAcceptDetail.IsNullField("BatchNo"))
                {
                    storeBillDetail.BatchNo = unqualifiedAcceptDetail.BatchNo;
                }
                storeBillDetail.Save();
            }

            UpdateUnqualifiedStoreDetail(storeBillEntity.StoreID);

        }

        private void GenerateDeclinedBill(BUSAcceptEntity acceptEntity,
            List<BUSAcceptDetailEntity> acceptDetailEntities)
        {
            var declinedCode = "YSJS-" + acceptEntity.BillCode;
            BUSDeclinedEntity entity = new BUSDeclinedEntity
            {
                BillID = acceptEntity.BillID,
                BillCode = acceptEntity.BillCode,
                BillDate = acceptEntity.BillDate,
                BillTypeID = acceptEntity.BillTypeID,
                BillTypeName = acceptEntity.BillTypeName,
                BillTypeSpell = acceptEntity.BillTypeSpell,
                CarryPerson = acceptEntity.AcceptPerson,
                CarryPersonSpell = acceptEntity.AcceptPersonSpell,
                DealerID = acceptEntity.DealerID,
                DealerCode = acceptEntity.DealerCode,
                DealerName = acceptEntity.DealerName,
                DealerSpell = acceptEntity.DealerSpell,
                CreateDate = DateTime.Now,
                CreateUserID = GlobalItem.g_CurrentUser.UserID,
                DeclinedDate = DateTime.Now,
                DeclinedType = "验收拒收",
                DeclinedCode = declinedCode
            };

            entity.Fetch();
            acceptEntity.AcceptRemark = string.Format("到货数量与收货数量不符，验收拒收单号:{0}", declinedCode);
            if (null != GlobalItem.g_CurrentEmployee)
            {
                entity.DeclinedPerson = GlobalItem.g_CurrentEmployee.EmployeeName;
                entity.DeclinedPersonSpell = GlobalItem.g_CurrentEmployee.EmployeeSpell;
            }

            if (!entity.IsNew(BUSDeclinedEntityFields.DeclinedCode == declinedCode))
            {
                entity.LastModifyDate = DateTime.Now;
                entity.LastModifyUserID = GlobalItem.g_CurrentUser.UserID;
                entity.Update();
                BUSDeclinedDetailEntity childToDelete = new BUSDeclinedDetailEntity { DeclinedID = entity.DeclinedID };
                childToDelete.DeleteByCommonly();
            }
            else
            {
                entity.Save();
            }
            entity.Fetch();
            var receiveDetails = acceptDetailEntities.Where(p => p.ReceiveAmount < p.Amount);
            foreach (var receiveDetail in receiveDetails)
            {
                var declinedDetail = new BUSDeclinedDetailEntity
                {
                    DeclinedID = entity.DeclinedID,
                    ProductID = receiveDetail.ProductID,
                    Amount = receiveDetail.Amount,
                    DeclinedAmount = receiveDetail.Amount - receiveDetail.ReceiveAmount,
                    CreateUserID = GlobalItem.g_CurrentUser.UserID,
                    CreateDate = DateTime.Now,
                    DetailRemark = string.Format("{0} - 验收拒收 {1} (总数:{2}，收货：{3}，拒收：{4})", acceptEntity.BillCode, receiveDetail.ProductID, receiveDetail.Amount, receiveDetail.ReceiveAmount, receiveDetail.Amount - receiveDetail.ReceiveAmount)
                };
                if (!receiveDetail.IsNullField("ProduceDate"))
                {
                    declinedDetail.ProduceDate = receiveDetail.ProduceDate;
                }
                if (!receiveDetail.IsNullField("ValidateDate"))
                {
                    declinedDetail.ValidateDate = receiveDetail.ValidateDate;
                }
                if (!receiveDetail.IsNullField("BatchNo"))
                {
                    declinedDetail.BatchNo = receiveDetail.BatchNo;
                }
                declinedDetail.Save();
            }
        }
        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        /// <summary>
        /// 非文本框取值
        /// </summary>
        /// <param name="entity">实体</param>
        protected virtual void CustomGetEntity(BUSAcceptEntity entity)
        {
            if (!entity.IsNullField("ReceiveID"))
            {
                this.txtBillCode.SetMemberValue(entity.ReceiveID);
            }
            if (!entity.IsNullField("DealerID"))
            {
                this.txtDealerName.Tag = entity.DealerID;
            }

            if (!entity.IsNullField("AcceptPerson"))
            {
                this.txtAcceptPerson.Text = entity.AcceptPerson;
            }

            if (!entity.IsNullField("AcceptDate"))
            {
                this.txtAcceptDate.Text = entity.AcceptDate.ToString("yyyy-MM-dd");
            }
        }

        /// <summary>
        /// 非文本框赋值
        /// </summary>
        /// <param name="entity">实体</param>
        protected virtual void CustomSetEntity(BUSAcceptEntity entity)
        {
            if (this.txtBillCode.SelectedValue != null)
            {
                entity.ReceiveID = Convert.ToInt32(this.txtBillCode.SelectedValue);
                entity.ReceiveCode = this.txtBillCode.Text.Trim();
                entity.BillDate = Convert.ToDateTime((this.txtBillCode.EditData as DataRow)["下单日期"]);

                entity.DealerID = Convert.ToInt32((this.txtBillCode.EditData as DataRow)["往来单位ID"]);
                //entity.DealerName = this.txtDealerName.Text.Trim();
                //entity.DealerSpell = GlobalMethod.GetAlphabetic(entity.DealerName);
                entity.DealerCode = (this.txtBillCode.EditData as DataRow)["往来单位编号"].ToString();

                entity.BillTypeID = Convert.ToInt32((this.txtBillCode.EditData as DataRow)["订单类型ID"]);
                entity.BillTypeName = (this.txtBillCode.EditData as DataRow)["订单类型"].ToString();
                entity.BillTypeSpell = (this.txtBillCode.EditData as DataRow)["订单类型Spell"].ToString();
                int billID = int.Parse((this.txtBillCode.EditData as DataRow)["订单ID"].ToString());
                string billCode = (this.txtBillCode.EditData as DataRow)["订单编号"].ToString();
                entity.BillID = billID;
                entity.BillCode = billCode;
            }

            if (this.txtAcceptPerson.Text.Trim() != "")
            {
                entity.AcceptPerson = this.txtAcceptPerson.Text.Trim();
                entity.AcceptPersonSpell = GlobalMethod.GetAlphabetic(entity.AcceptPerson);
            }

            //this.SetReceiveStatus(entity);
        }

        private void btnOneKeyFinish_Click(object sender, EventArgs e)
        {
            for (int i = 0; i < this.popupGrid.PopupView.RowCount; i++)
            {
                object amount = this.popupGrid.PopupView.GetRowCellValue(i, "验收数量");
                if (amount != null)
                {
                    if (!string.IsNullOrEmpty(amount.ToString()))
                    {
                        this.popupGrid.PopupView.SetRowCellValue(i, "验收合格数量", amount);
                        this.popupGrid.PopupView.SetRowCellValue(i, "验收不合格数量", "0");
                        this.popupGrid.PopupView.SetRowCellValue(i, "验收结果及处置措施", "合格");
                    }
                }
            }
        }
/*
        //验证验收合格和不合格数量必须等于订单数量
        private bool ValidateAmount()
        {
            for (int i = 0; i < this.popupGrid.PopupView.RowCount; i++)
            {
                object amount = this.popupGrid.PopupView.GetRowCellValue(i, "订单数量");
                object productCode = this.popupGrid.PopupView.GetRowCellValue(i, "产品编号");

                if (amount != null && amount != DBNull.Value)
                {
                    //获取所有验收数量
                    int qua = 0, uqua = 0;
                    for (int j = 0; j < this.popupGrid.PopupView.RowCount; j++)
                    {
                        object productCode2 = this.popupGrid.PopupView.GetRowCellValue(j, "产品编号");//同一产品比较
                        if (productCode.ToString().Trim() == productCode2.ToString().Trim())
                        {
                            object quAmount = this.popupGrid.PopupView.GetRowCellValue(j, "收货数量");
                            if (quAmount != null && quAmount != DBNull.Value)
                            {
                                qua += Convert.ToInt32(quAmount);
                            }

                            //object unQuAmount = this.popupGrid.PopupView.GetRowCellValue(j, "验收不合格数量");
                            //if (unQuAmount != null && unQuAmount != DBNull.Value)
                            //{
                            //    uqua += Convert.ToInt32(unQuAmount);
                            //}
                        }
                    }

                    if (qua + uqua != Convert.ToInt32(amount))
                    {
                        XtraMessageBox.Show(String.Format("验收时，产品‘{0}’的总体收货数量和订单数量不符。", productCode), "提示", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                        return false;
                    }
                }
            }

            return true;
        }*/

        //验证验收合格和不合格数量必须等于订单数量
        private bool ValidateAmount()
        {
            for (int i = 0; i < this.popupGrid.PopupView.RowCount; i++)
            {
                object amount = this.popupGrid.PopupView.GetRowCellValue(i, "收货数量");
                object productCode = this.popupGrid.PopupView.GetRowCellValue(i, "产品编号");

                if (amount != null && amount != DBNull.Value)
                {
                    //获取所有验收数量
                    int totalReceiveAmount = 0, totalQualifiedAmount = 0, totalUnqualifiedAmount = 0;

                    if (txtBillTypeName.Text.Trim() == "销售退货")
                    {
                        object receiveAmount = this.popupGrid.PopupView.GetRowCellValue(i, "验收数量");
                        if (receiveAmount != null && receiveAmount != DBNull.Value)
                        {
                            totalReceiveAmount = Convert.ToInt32(receiveAmount);
                        }
                        object qualifiedAmount = this.popupGrid.PopupView.GetRowCellValue(i, "验收合格数量");
                        if (qualifiedAmount != null && qualifiedAmount != DBNull.Value)
                        {
                            totalQualifiedAmount = Convert.ToInt32(qualifiedAmount);
                        }

                        object unQualifiedAmount = this.popupGrid.PopupView.GetRowCellValue(i, "验收不合格数量");
                        if (unQualifiedAmount != null && unQualifiedAmount != DBNull.Value)
                        {
                            totalUnqualifiedAmount = Convert.ToInt32(unQualifiedAmount);
                        }
                    }
                    else
                    {
                    for (int j = 0; j < this.popupGrid.PopupView.RowCount; j++)
                    {
                        object productCode2 = this.popupGrid.PopupView.GetRowCellValue(j, "产品编号");//同一产品比较
                        if (productCode.ToString().Trim() == productCode2.ToString().Trim())
                        {
                            object receiveAmount = this.popupGrid.PopupView.GetRowCellValue(j, "验收数量");
                            if (receiveAmount != null && receiveAmount != DBNull.Value)
                            {
                                totalReceiveAmount += Convert.ToInt32(receiveAmount);
                            }
                            object qualifiedAmount = this.popupGrid.PopupView.GetRowCellValue(j, "验收合格数量");
                            if (qualifiedAmount != null && qualifiedAmount != DBNull.Value)
                            {
                                totalQualifiedAmount += Convert.ToInt32(qualifiedAmount);
                            }

                            object unQualifiedAmount = this.popupGrid.PopupView.GetRowCellValue(j, "验收不合格数量");
                            if (unQualifiedAmount != null && unQualifiedAmount != DBNull.Value)
                            {
                                totalUnqualifiedAmount += Convert.ToInt32(unQualifiedAmount);
                            }
                        }
                    }
                    }
                    totalUnqualifiedAmount = totalReceiveAmount - totalQualifiedAmount;
                    int totalBillAmount = Convert.ToInt32(amount);
                    //收货数 > 订单数， 错误
                    if (totalReceiveAmount > totalBillAmount && totalBillAmount > 0)
                    {
                        XtraMessageBox.Show(String.Format("验收时，产品‘{0}’的总体到货数量和收货数量不符。", productCode), "提示", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                        return false;
                    }
                    //合格品数 > 收货数， 错误
                    if (totalQualifiedAmount > totalReceiveAmount && totalReceiveAmount > 0)
                    {
                        XtraMessageBox.Show(String.Format("验收时，产品‘{0}’的总体到货数量和验收合格数量不符。", productCode), "提示", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                        return false;
                    }
                    //1 - 收货数 < 订单数: 拒收提示
                    //2 - 不合格品数 > 0: 不合格平入库提示
                    //if (totalReceiveAmount < totalBillAmount || totalUnqualifiedAmount > 0)
                    //{
                    //    XtraMessageBox.Show("是否拒收或生成不合格品记录？", "警告", MessageBoxButtons.YesNoCancel, MessageBoxIcon.Exclamation);
                    //    return false;
                    //}
                }
            }

            return true;
        }

        //验证同一产品不可出现相同批号
        private bool ValidateBatchNo()
        {
            for (int i = 0; i < this.popupGrid.PopupView.RowCount; i++)
            {
                object amount = this.popupGrid.PopupView.GetRowCellValue(i, "订单数量");
                object productName = this.popupGrid.PopupView.GetRowCellValue(i, "产品名称");
                object productSpec = this.popupGrid.PopupView.GetRowCellValue(i, "规格型号");
                object packageSpec = this.popupGrid.PopupView.GetRowCellValue(i, "包装规格型号");

                if (amount != null && amount != DBNull.Value)
                {
                    List<string> batchNos = new List<string>();

                    for (int j = 0; j < this.popupGrid.PopupView.RowCount; j++)
                    {
                        object productName2 = this.popupGrid.PopupView.GetRowCellValue(j, "产品名称");//同一产品比较
                        object productSpec2 = this.popupGrid.PopupView.GetRowCellValue(j, "规格型号");
                        object packageSpec2 = this.popupGrid.PopupView.GetRowCellValue(j, "包装规格型号");
                        if (productName.ToString().Trim() == productName2.ToString().Trim()
                            && productSpec.ToString().Trim() == productSpec2.ToString().Trim()
                            && packageSpec.ToString().Trim() == packageSpec2.ToString().Trim())
                        {
                            object batchNo = this.popupGrid.PopupView.GetRowCellValue(j, "批号");
                            if (batchNos.Contains(batchNo.ToString().Trim()))
                            {
                                XtraMessageBox.Show(String.Format("产品‘{0}’存在相同的批号{1}。", productName, batchNo), "提示", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                                return false;
                            }
                            else
                            {
                                batchNos.Add(batchNo.ToString().Trim());
                            }
                        }
                    }
                }
            }

            return true;
        }

        //验证生产日期必须小于有效期至
        private bool ValidateBatchDate()
        {
            for (int i = 0; i < this.popupGrid.PopupView.RowCount; i++)
            {
                object produceDate = this.popupGrid.PopupView.GetRowCellValue(i, "生产日期");
                object validateDate = this.popupGrid.PopupView.GetRowCellValue(i, "有效期至");
                if (produceDate != null && produceDate != DBNull.Value && validateDate != null && validateDate != DBNull.Value)
                {
                    int PID = (int)this.popupGrid.PopupView.GetRowCellValue(i, "产品ID");
                    BFIProductEntity product = new BFIProductEntity { ProductID = PID };
                    product.Fetch();
                    if (Convert.ToDateTime(validateDate) <= Convert.ToDateTime(produceDate))
                    {
                        XtraMessageBox.Show(String.Format("第{0}行，产品的有效期至必须大于生产日期。", (i + 1)), "提示", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                        return false;
                    }

                    if (txtBillTypeName.Text.Trim() != "销售退货")
                    {
                        if (Convert.ToDateTime(validateDate) < DateTime.Today.AddDays(product.BatchPreWarningDays))
                        {
                            XtraMessageBox.Show(String.Format("第{0}行，产品属于近效期不能入库。", (i + 1)), "提示", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                            return false;
                        }
                    }
                    if (Convert.ToDateTime(produceDate) > DateTime.Today)
                    {
                        XtraMessageBox.Show("生产日期不正确，不能超出当前日期，请重新填写！", "提示", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        return false;
                    }
                    if (Convert.ToDateTime(produceDate).Year < 1753 || Convert.ToDateTime(validateDate).Year < 1753)
                    {
                        XtraMessageBox.Show(String.Format("第{0}行，生产日期或有效期不正确，请重新填写！", (i + 1)), "提示", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                        return false;
                    }
                    if (Convert.ToDateTime(validateDate) < DateTime.Today)
                    {
                        //var dialogResult = XtraMessageBox.Show(String.Format("第{0}行，产品已过有效期，属于不合格品，应该按不合格品验收。\n“确定”：操作无误，继续保存。\n“取消”：返回重新填写。", (i + 1)), "提示", MessageBoxButtons.OKCancel, MessageBoxIcon.Exclamation);
                        //return dialogResult == DialogResult.OK;
                        var dialogResult = XtraMessageBox.Show(String.Format("第{0}行，产品已过有效期，属于不合格品，应该按不合格品验收。\n“确定”：操作无误，继续保存。\n“取消”：返回重新填写。", (i + 1)), "提示", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                        return false;
                    }
                }
            }
            return true;
        }

        //验证抽检数量
        private bool ValidateSamplingAmount()
        {
            //抽检数量、合格数量、不合格数量不能为空，且合格数量与不合格数量之和必须等于抽检数量
            for (int i = 0; i < this.popupGridSampling.PopupView.RowCount; i++)
            {
                object productName = this.popupGridSampling.PopupView.GetRowCellValue(i, "产品名称");
                object samplingAmount = this.popupGridSampling.PopupView.GetRowCellValue(i, "抽检数量");
                object qsAmount = this.popupGridSampling.PopupView.GetRowCellValue(i, "抽检合格数量");
                object uqsAmount = this.popupGridSampling.PopupView.GetRowCellValue(i, "抽检不合格数量");
                if (productName != null && productName != DBNull.Value)
                {
                    if (samplingAmount == null || samplingAmount == DBNull.Value)
                    {
                        XtraMessageBox.Show(String.Format("抽检记录，第{0}行抽检数量不能为空！", (i + 1)), "提示", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                        return false;
                    }

                    if (qsAmount == null || qsAmount == DBNull.Value)
                    {
                        XtraMessageBox.Show(String.Format("抽检记录，第{0}行抽检合格数量不能为空！", (i + 1)), "提示", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                        return false;
                    }

                    if (uqsAmount == null || uqsAmount == DBNull.Value)
                    {
                        XtraMessageBox.Show(String.Format("抽检记录，第{0}行抽检不合格数量不能为空！", (i + 1)), "提示", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                        return false;
                    }

                    if (Convert.ToInt32(qsAmount) + Convert.ToInt32(uqsAmount) != Convert.ToInt32(samplingAmount))
                    {
                        XtraMessageBox.Show(String.Format("抽检记录，第{0}行抽检合格数量与不合格数量总和必须等于抽检数量！", (i + 1)), "提示", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                        return false;
                    }
                }
            }

            //所有抽检数量总和不能大于订单数量
            for (int i = 0; i < this.popupGridSampling.PopupView.RowCount; i++)
            {
                object amount = this.popupGridSampling.PopupView.GetRowCellValue(i, "订单数量");
                object productName = this.popupGridSampling.PopupView.GetRowCellValue(i, "产品名称");

                if (amount != null && amount != DBNull.Value)
                {
                    //获取所有抽检数量
                    int samplingAmount = 0;
                    for (int j = 0; j < this.popupGridSampling.PopupView.RowCount; j++)
                    {
                        object productName2 = this.popupGridSampling.PopupView.GetRowCellValue(j, "产品名称");//同一产品比较
                        if (productName.ToString().Trim() == productName2.ToString().Trim())
                        {
                            object sAmount = this.popupGridSampling.PopupView.GetRowCellValue(j, "抽检数量");
                            if (sAmount != null && sAmount != DBNull.Value)
                            {
                                samplingAmount += Convert.ToInt32(sAmount);
                            }
                        }
                    }

                    if (samplingAmount > Convert.ToInt32(amount))
                    {
                        XtraMessageBox.Show(String.Format("抽检时，产品‘{0}’的总体抽检数量不能大于订单数量。", productName), "提示", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                        return false;
                    }
                }
            }
            return true;
        }
        private bool ValidateDealerQualification()
        {
            //获取供货商的过期证书
            if (this.txtDealerName.Tag != null)
            {
                int dealerID = Convert.ToInt32(this.txtDealerName.Tag);
                ViewCollection<AllQualificationView> qualifications = new ViewCollection<AllQualificationView>();

                PredicateExpression pe = new PredicateExpression();
                pe.Add(AllQualificationViewFields.所属表ID == "BFI_Dealer");
                pe.Add(AllQualificationViewFields.所属ID == dealerID);
                pe.Add(AllQualificationViewFields.到期状态 == "已过期");
                qualifications.Fetch(pe);

                if (qualifications.Count > 0)
                {
                    XtraMessageBox.Show(String.Format("往来单位的{0}电子档案已过期，无法生成验收单，请修改！", (qualifications[0] as AllQualificationView).档案名称), "系统提示", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    return false;
                }
            }
            return true;
        }

        /// <summary>
        /// 验证产品的电子档案
        /// </summary>
        /// <returns></returns>
        private bool ValidateProductQualification()
        {
            //获取所有产品的过期证书
            ViewCollection<AllQualificationView> qualifications = new ViewCollection<AllQualificationView>();

            PredicateExpression pe = new PredicateExpression();
            pe.Add(AllQualificationViewFields.所属表ID == "BFI_Product");
            pe.Add(AllQualificationViewFields.到期状态 == "已过期");
            qualifications.Fetch(pe);

            int rowCount = this.popupGrid.PopupView.RowCount;
            for (int i = 0; i < rowCount; i++)
            {
                object id = this.popupGrid.PopupView.GetRowCellValue(i, "产品ID");
                if (id != null && id != DBNull.Value)
                {
                    bool isHava = false;
                    foreach (AllQualificationView q in qualifications)
                    {
                        if (Convert.ToInt32(id) == q.所属ID)
                        {
                            isHava = true;
                            break;
                        }
                    }

                    if (isHava)//存在则产品过期
                    {
                        XtraMessageBox.Show(String.Format("表格中第{0}行产品的电子档案存在已过期档案，无法生成验收单，请修改！", (i + 1)), "系统提示", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        return false;
                    }
                }
            }

            return true;
        }

        //设置类型和往来单位
        private void txtBillCode_PopupClosing(object sender, EventArgs e)
        {
            if (this.txtBillCode.EditData != null)
            {
                this.txtBillTypeName.Text = (this.txtBillCode.EditData as DataRow)["订单类型"].ToString();
                this.txtBillCode.Text = (this.txtBillCode.EditData as DataRow)["收货单号"].ToString();
                this.txtDealerName.Text = (this.txtBillCode.EditData as DataRow)["往来单位名称"].ToString();
                this.txtDealerName.Tag = (this.txtBillCode.EditData as DataRow)["往来单位ID"].ToString();
                this.txtAcceptRemark.Focus();
                bool isback = txtBillTypeName.Text.Trim() == "销售退货" ? true : false;
                if (isback)
                {
                    popupGrid.PopupView.Columns["批号"].OptionsColumn.AllowEdit = false;
                    popupGrid.PopupView.Columns["生产日期"].OptionsColumn.AllowEdit = false;
                    popupGrid.PopupView.Columns["有效期至"].OptionsColumn.AllowEdit = false;
                }
                else
                {
                    popupGrid.PopupView.Columns["批号"].OptionsColumn.AllowEdit = true;
                    popupGrid.PopupView.Columns["生产日期"].OptionsColumn.AllowEdit = true;
                    popupGrid.PopupView.Columns["有效期至"].OptionsColumn.AllowEdit = true;
                }

                object id = (this.txtBillCode.EditData as DataRow)["收货ID"].ToString();

                if (id != null)
                {
                    //根据订单设置表格数据
                    this.popupGrid.SetGridData("vw_AllWarehouseInBillDetailForAccept", "收货ID", id, false);
                    //txtAcceptCode.Text = "YS" + txtBillCode.Text.Substring(2);
                    txtAcceptCode.Text = txtBillCode.Text;
                }
                popupGrid.IsPurchase = txtBillTypeName.Text == "采购进货" ? true : false;
            }
        }

        //弹出的产品窗体必须是列表中的产品
        private void popupGrid_BeforePopupFormShow(object sender, DQS.Controls.CommonCode.BeforePopupFormShowArgs e)
        {
            if (e.ActiveOperationColumn.PopupForm != null)
            {
                if (e.ActiveOperationColumn.PopupForm.Name == "Product")
                {
                    object amount = this.popupGrid.PopupView.GetFocusedRowCellValue("订单数量");
                    if (amount != null && amount != DBNull.Value)
                    {
                        //订单中的原始产品不须弹出窗体进行选择
                        e.Cancel = true;
                    }

                    List<string> productIDs = new List<string>();
                    for (int i = 0; i < this.popupGrid.PopupView.RowCount; i++)
                    {
                        object productID = this.popupGrid.PopupView.GetRowCellValue(i, "产品ID");
                        if (productID != null && productID != DBNull.Value)
                        {
                            productIDs.Add(productID.ToString());
                        }
                    }

                    if (productIDs.Count > 0)
                    {
                        e.ActiveOperationColumn.PopupForm.Filter = String.Format("[产品ID] IN ({0}) ", string.Join(",", productIDs.ToArray()));
                        popupGrid.AcceptCode = txtAcceptCode.Text.Trim();
                        popupGrid.AcceptType = txtBillTypeName.Text.Trim();
                    }
                    else
                    {
                        XtraMessageBox.Show("请先选择订单。", "提示", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                        this.txtBillCode.Focus();
                        e.Cancel = true;
                    }
                }
            }
        }

        //删除列表中多余数据
        private void PopupView_KeyDown(object sender, KeyEventArgs e)
        {

            if (e.KeyCode == Keys.Delete)
            {
                object amount = this.popupGrid.PopupView.GetFocusedRowCellValue("收货数量");
                if (amount != null && amount != DBNull.Value)
                {
                    //订单中的原始产品不可删除
                    return;
                }

                DialogResult dr = XtraMessageBox.Show("确定要删除此行数据吗？", "提示", MessageBoxButtons.OKCancel, MessageBoxIcon.Question);
                if (dr == DialogResult.OK)
                {
                    this.popupGrid.ClearGrid(this.popupGrid.PopupView.FocusedRowHandle);
                }
            }
        }

        //删除抽检列表中多余数据
        private void SamplingPopupView_KeyDown(object sender, KeyEventArgs e)
        {

            if (e.KeyCode == Keys.Delete)
            {
                DialogResult dr = XtraMessageBox.Show("确定要删除此行抽检数据吗？", "提示", MessageBoxButtons.OKCancel, MessageBoxIcon.Question);
                if (dr == DialogResult.OK)
                {
                    this.popupGridSampling.ClearGrid(this.popupGridSampling.PopupView.FocusedRowHandle);
                }
            }
        }

        //有产品才可抽检
        private void PopupView_MouseUp(object sender, MouseEventArgs e)
        {
            DevExpress.XtraGrid.Views.Grid.ViewInfo.GridHitInfo hi = this.popupGrid.PopupView.CalcHitInfo(e.Location);
            if (hi.InRow && e.Button == MouseButtons.Right)
            {
                object productID = this.popupGrid.PopupView.GetFocusedRowCellValue("产品ID");
                if (productID != null && productID != DBNull.Value)//有产品才可抽检
                {
                    this.popupMenuSampling.ShowPopup(Control.MousePosition);
                }
            }
        }

        //抽检
        private void bbiSampling_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            object productID = this.popupGrid.PopupView.GetFocusedRowCellValue("产品ID");
            if (productID != null && productID != DBNull.Value)
            {

                object batchNo = this.popupGrid.PopupView.GetFocusedRowCellValue("批号");
                object produceDate = this.popupGrid.PopupView.GetFocusedRowCellValue("生产日期");
                object validateDate = this.popupGrid.PopupView.GetFocusedRowCellValue("有效期至");
                if (batchNo == null || batchNo == DBNull.Value || produceDate == null || produceDate == DBNull.Value || validateDate == null || validateDate == DBNull.Value)
                {
                    XtraMessageBox.Show("请输入完整的批号，生产日期，有效期至信息！", "提示", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                    return;
                }

                //已抽检的产品无法再次抽检
                for (int i = 0; i < this.popupGridSampling.PopupView.RowCount; i++)
                {
                    object productID2 = this.popupGridSampling.PopupView.GetRowCellValue(i, "产品ID");
                    object batchNo2 = this.popupGridSampling.PopupView.GetRowCellValue(i, "批号");
                    if (productID2 != null && productID2 != DBNull.Value && batchNo2 != null && productID2 != DBNull.Value)
                    {
                        if (productID.ToString().Trim() == productID2.ToString().Trim() && batchNo.ToString().Trim() == batchNo2.ToString().Trim())
                        {
                            XtraMessageBox.Show("该批产品已抽检！", "提示", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                            return;
                        }
                    }
                }

                this.SetSamplingInfo(this.popupGrid.PopupView.FocusedRowHandle);
            }
        }

        //设置抽检信息
        private void SetSamplingInfo(int acceptRowHandle)
        {
            int samplingRow = 0;
            for (int i = 0; i < this.popupGridSampling.PopupView.RowCount; i++)
            {
                object productID = this.popupGridSampling.PopupView.GetRowCellValue(i, "产品ID");
                if (productID == null || productID == DBNull.Value)
                {
                    samplingRow = i;
                    break;
                }
            }

            object value = this.popupGrid.PopupView.GetRowCellValue(acceptRowHandle, "产品ID");
            this.popupGridSampling.PopupView.SetRowCellValue(samplingRow, "产品ID", value);

            value = this.popupGrid.PopupView.GetRowCellValue(acceptRowHandle, "产品编号");
            this.popupGridSampling.PopupView.SetRowCellValue(samplingRow, "产品编号", value);

            value = this.popupGrid.PopupView.GetRowCellValue(acceptRowHandle, "产品名称");
            this.popupGridSampling.PopupView.SetRowCellValue(samplingRow, "产品名称", value);

            value = this.popupGrid.PopupView.GetRowCellValue(acceptRowHandle, "生产厂商");
            this.popupGridSampling.PopupView.SetRowCellValue(samplingRow, "生产厂商", value);

            value = this.popupGrid.PopupView.GetRowCellValue(acceptRowHandle, "规格型号");
            this.popupGridSampling.PopupView.SetRowCellValue(samplingRow, "规格型号", value);

            value = this.popupGrid.PopupView.GetRowCellValue(acceptRowHandle, "剂型");
            this.popupGridSampling.PopupView.SetRowCellValue(samplingRow, "剂型", value);

            value = this.popupGrid.PopupView.GetRowCellValue(acceptRowHandle, "产品类别");
            this.popupGridSampling.PopupView.SetRowCellValue(samplingRow, "产品类别", value);

            value = this.popupGrid.PopupView.GetRowCellValue(acceptRowHandle, "单位");
            this.popupGridSampling.PopupView.SetRowCellValue(samplingRow, "单位", value);

            value = this.popupGrid.PopupView.GetRowCellValue(acceptRowHandle, "批号");
            this.popupGridSampling.PopupView.SetRowCellValue(samplingRow, "批号", value);

            value = this.popupGrid.PopupView.GetRowCellValue(acceptRowHandle, "生产日期");
            this.popupGridSampling.PopupView.SetRowCellValue(samplingRow, "生产日期", value);

            value = this.popupGrid.PopupView.GetRowCellValue(acceptRowHandle, "有效期至");
            this.popupGridSampling.PopupView.SetRowCellValue(samplingRow, "有效期至", value);

            value = this.popupGrid.PopupView.GetRowCellValue(acceptRowHandle, "验收数量");
            this.popupGridSampling.PopupView.SetRowCellValue(samplingRow, "验收数量", value);

            value = this.popupGrid.PopupView.GetRowCellValue(acceptRowHandle, "包装比例");
            this.popupGridSampling.PopupView.SetRowCellValue(samplingRow, "包装比例", value);

            value = this.popupGrid.PopupView.GetRowCellValue(acceptRowHandle, "包装规格型号");
            this.popupGridSampling.PopupView.SetRowCellValue(samplingRow, "包装规格型号", value);

            value = this.popupGrid.PopupView.GetRowCellValue(acceptRowHandle, "注册证号");
            this.popupGridSampling.PopupView.SetRowCellValue(samplingRow, "注册证号", value);
        }

        //无抽检信息无法弹出抽检项目
        private void popupGridSampling_BeforePopupFormShow(object sender, DQS.Controls.CommonCode.BeforePopupFormShowArgs e)
        {
            object productID = this.popupGridSampling.PopupView.GetFocusedRowCellValue("产品ID");
            if (productID == null || productID == DBNull.Value)
            {
                e.Cancel = true;
            }
        }

        private void btnProductQualification_Click(object sender, EventArgs e)
        {
            object id = this.popupGrid.PopupView.GetFocusedRowCellValue("产品ID");
            if (id != null && id != DBNull.Value)
            {
                using (FrmQualification frmQualification = new FrmQualification(Convert.ToInt32(id), "BFI_Product", "ProductID", "ProductCertificate"))
                {
                    frmQualification.VisbleBarItem();
                    frmQualification.ShowDialog();
                }
            }
        }

        private void btnDealerQualification_Click(object sender, EventArgs e)
        {
            if (this.txtDealerName.Tag != null)
            {
                int id = Convert.ToInt32(this.txtDealerName.Tag);
                using (FrmQualification frmQualification = new FrmQualification(id, "BFI_Dealer", "DealerID", "DealerCertificate"))
                {
                    frmQualification.VisbleBarItem();
                    frmQualification.ShowDialog();
                }
            }
        }
        public static void UpdateUnqualifiedStoreDetail(int StoreID)
        {

            string sql = @"EXEC sp_InsertUnqualifiedStoreDetail {0}";
            sql = string.Format(sql, StoreID);
            using (SqlConnection conn = new SqlConnection(GlobalItem.g_DbConnectStrings))
            {
                conn.Open(); //连接数据库
                //必须为SqlCommand指定数据库连接和登记的事务
                SqlCommand cmd = new SqlCommand(sql, conn);
                try
                {
                    cmd.ExecuteNonQuery();
                }
                catch (Exception ex)
                {
                    XtraMessageBox.Show(ex.Message, "系统提示", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                finally
                {
                    conn.Close();
                }
            }
            /*
            BUSUnqualifiedStoreDetailEntity storeDetail = new BUSUnqualifiedStoreDetailEntity { ProductID = billDetail.ProductID, BatchNo = billDetail.BatchNo, DetailRemark = billDetail.Reservation7 };

            if (storeDetail.IsNew(BUSUnqualifiedStoreDetailEntityFields.ProductID == storeDetail.ProductID & BUSUnqualifiedStoreDetailEntityFields.BatchNo == storeDetail.BatchNo & BUSUnqualifiedStoreDetailEntityFields.DetailRemark == storeDetail.DetailRemark))
            {
                //新建不合格品库存
                storeDetail.ProduceDate = billDetail.ProduceDate;
                storeDetail.ValidateDate = billDetail.ValidateDate;
                storeDetail.Amount = billDetail.Amount;
                storeDetail.CreateDate = DateTime.Now;
                storeDetail.LastModifyDate = DateTime.Now;
                storeDetail.LastModifyUserID = GlobalItem.g_CurrentUser.UserID;
                storeDetail.LastCuringDate = DateTime.Now;
                storeDetail.CreateStoreID = billDetail.StoreID;
                storeDetail.LastStoreID = billDetail.StoreID;
                storeDetail.DetailRemark = billDetail.Reservation7;
                storeDetail.Save();

            }
            else
            {
                //更新不合格品库存
                storeDetail.Fetch();
                storeDetail.LastStoreID = billDetail.StoreID;
                storeDetail.LastModifyDate = DateTime.Now;
                storeDetail.LastModifyUserID = GlobalItem.g_CurrentUser.UserID;
                storeDetail.Amount = storeDetail.Amount + billDetail.Amount;
                storeDetail.Update();
            }
            */
        }

        private void btnAttachment_Click(object sender, EventArgs e)
        {
            if (this.m_id != null)
            {
                using (FrmAcceptAttachment frmAcceptAttachment = new FrmAcceptAttachment(m_id.Value))
                {
                    frmAcceptAttachment.ShowDialog();
                }
            }
        }

        private void btnSaveAndIn_Click(object sender, EventArgs e)
        {
            //saveandin = 1;
            //btnSave_Click(null, null);
        }


        private void btnReAccept_Click(object sender, EventArgs e)
        {

            EntityCollection<ATCUserPageEntity> userPages = new EntityCollection<ATCUserPageEntity>();
            PredicateExpression pe = new PredicateExpression();
            pe.Add(ATCUserPageEntityFields.UserID == GlobalItem.g_CurrentUser.UserID);
            pe.Add(ATCUserPageEntityFields.DocumentCode == "AcceptBill");
            DataTable data = userPages.FetchTable(pe);

            if (data.Rows.Count <= 0)
            {
                XtraMessageBox.Show("系统未设置您的审批流程，无法点击复查功能。", "警告", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                return;
            }

            DialogResult dr = XtraMessageBox.Show("是否提交复查？", "提示", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (dr == DialogResult.No)
            {
                return;
            }

            BUSAcceptEntity entity = this.ftPanel.GetEntity() as BUSAcceptEntity;
            this.CustomSetEntity(entity);
            List<EntityBase> children = this.popupGrid.GetEntities();
            List<BUSAcceptDetailEntity> acceptDetails = children.Cast<BUSAcceptDetailEntity>().ToList();

            entity.AcceptDate = DateTime.Now;
            if (!this.ValidateAmount()) return;
            if (!this.ValidateBatchNo()) return;
            if (!this.ValidateBatchDate()) return;
            if (!this.ValidateSamplingAmount()) return;

            //string reason;
            //using (FrmReCheckReason frm = new FrmReCheckReason())
            //{
            //    DialogResult drs = frm.ShowDialog();
            //    if (drs == DialogResult.Yes)
            //    {
            //        reason = frm.reason;
            //    }
            //    else
            //    {
            //        return;
            //    }
            //}

            foreach (var busAcceptDetailEntity in acceptDetails)
            {
                if (busAcceptDetailEntity.IsNullField("Amount"))
                {
                    busAcceptDetailEntity.Amount = 0;
                }

                if (busAcceptDetailEntity.IsNullField("ReceiveAmount"))
                {
                    busAcceptDetailEntity.ReceiveAmount = 0;
                    busAcceptDetailEntity.Reservation2 = "0";
                }
                else
                {
                    busAcceptDetailEntity.Reservation2 = (busAcceptDetailEntity.ReceiveAmount *
                        double.Parse(busAcceptDetailEntity.Reservation1)).ToString();
                }

                if (busAcceptDetailEntity.IsNullField("QualifiedAmount"))
                {
                    busAcceptDetailEntity.QualifiedAmount = 0;
                }

                if (busAcceptDetailEntity.IsNullField("UnqualifiedAmount"))
                {
                    busAcceptDetailEntity.UnqualifiedAmount = 0;
                }
            }
            if (txtBillTypeName.Text.Trim() == "销售退货")
            {
                var countedAcceptDetails = from a in acceptDetails
                                           group a by new { a.ProductID, a.BatchNo }
                                               into g
                                               select new
                                               {
                                                   ProductID = g.Key.ProductID,
                                                   BatchNo = g.Key.BatchNo,
                                                   TotalBillAmount = g.Sum(p => p.Amount),
                                                   TotalReceiveAmount = g.Sum(p => p.ReceiveAmount),
                                                   TotalQualifiedAmount = g.Sum(p => p.QualifiedAmount),
                                                   TotalUnqualifiedAmount = g.Sum(p => p.ReceiveAmount) - g.Sum(p => p.QualifiedAmount),
                                               };
                var rejectedDetails =
                    countedAcceptDetails.Where(p => p.TotalReceiveAmount < p.TotalBillAmount).ToList();
                var unqualifiedDetails = countedAcceptDetails.Where(p => p.TotalUnqualifiedAmount > 0).ToList();
                //1 - 收货数 < 订单数: 拒收提示
                //2 - 不合格品数 > 0: 不合格平入库提示
                if (rejectedDetails.Any() || unqualifiedDetails.Any())
                {
                    var message = string.Empty;
                    if (rejectedDetails.Any() && unqualifiedDetails.Any())
                    {
                        message = "收货数量与验收数量不符，是否生成拒收记录？\n验收合格数量与验收到货数量不符，是否生成不合格品记录？";
                    }
                    else if (rejectedDetails.Any())
                    {
                        message = "收货数量与验收数量不符，是否生成拒收记录？";
                    }
                    else if (unqualifiedDetails.Any())
                    {
                        message = "验收合格数量与验收数量不符，是否生成不合格品记录？";
                    }
                    var dialogResult = XtraMessageBox.Show(message, "警告", MessageBoxButtons.YesNo, MessageBoxIcon.Exclamation);
                    if (dialogResult == DialogResult.No)
                    {
                        return;
                    }
                    if (dialogResult == DialogResult.Yes)
                    {
                        List<BUSAcceptDetailEntity> rejectedAcceptDetails = new List<BUSAcceptDetailEntity>();
                        foreach (var rejectedDetail in rejectedDetails)
                        {
                            var detail = acceptDetails.FirstOrDefault(p => p.ProductID == rejectedDetail.ProductID);
                            if (null != detail)
                            {
                                var busAcceptDetailEntity = new BUSAcceptDetailEntity
                                {
                                    ProductID = detail.ProductID,
                                    Amount = rejectedDetail.TotalBillAmount,
                                    ReceiveAmount = rejectedDetail.TotalReceiveAmount
                                };
                                if (!detail.IsNullField("ProduceDate"))
                                {
                                    busAcceptDetailEntity.ProduceDate = detail.ProduceDate;
                                }
                                if (!detail.IsNullField("ValidateDate"))
                                {
                                    busAcceptDetailEntity.ValidateDate = detail.ValidateDate;
                                }
                                if (!detail.IsNullField("BatchNo"))
                                {
                                    busAcceptDetailEntity.BatchNo = detail.BatchNo;
                                }
                                rejectedAcceptDetails.Add(busAcceptDetailEntity);
                            }
                        }
                        if (rejectedAcceptDetails.Any())
                        {
                            GenerateDeclinedBill(entity, rejectedAcceptDetails);
                        }

                        List<BUSAcceptDetailEntity> unqualifiedAcceptDetails = new List<BUSAcceptDetailEntity>();
                        foreach (var unqualifiedDetail in unqualifiedDetails)
                        {
                            var detail = acceptDetails.FirstOrDefault(p => p.ProductID == unqualifiedDetail.ProductID && p.BatchNo == unqualifiedDetail.BatchNo && p.UnqualifiedAmount > 0);
                            if (null != detail)
                            {
                                var busAcceptDetailEntity = new BUSAcceptDetailEntity
                                {
                                    ProductID = detail.ProductID,
                                    BatchNo = detail.BatchNo,
                                    Amount = unqualifiedDetail.TotalBillAmount,
                                    ReceiveAmount = unqualifiedDetail.TotalUnqualifiedAmount,
                                    QualifiedAmount = unqualifiedDetail.TotalQualifiedAmount,
                                    UnqualifiedAmount = unqualifiedDetail.TotalUnqualifiedAmount,
                                    AcceptSolution = detail.IsNullField("AcceptSolution") ? "不合格区" : detail.AcceptSolution
                                };
                                if (!detail.IsNullField("ProduceDate"))
                                {
                                    busAcceptDetailEntity.ProduceDate = detail.ProduceDate;
                                }
                                if (!detail.IsNullField("ValidateDate"))
                                {
                                    busAcceptDetailEntity.ValidateDate = detail.ValidateDate;
                                }
                                if (!detail.IsNullField("BatchNo"))
                                {
                                    busAcceptDetailEntity.BatchNo = detail.BatchNo;
                                }
                                unqualifiedAcceptDetails.Add(busAcceptDetailEntity);
                            }
                        }
                        if (unqualifiedAcceptDetails.Any())
                        {
                            GenerateUnqualifiedStoreBill(entity, unqualifiedAcceptDetails);
                        }
                    }
                }
                entity.CreateDate = DateTime.Now;
                entity.LastModifyDate = DateTime.Now;
                entity.CreateUserID = GlobalItem.g_CurrentUser.UserID;
                entity.LastModifyUserID = GlobalItem.g_CurrentUser.UserID;
                //entity.Reservation1 = reason;
                entity.Reservation1 = "";
                entity.Reservation10 = "复查单据";
                if (!countedAcceptDetails.Any() ||
                    countedAcceptDetails.ToList().TrueForAll(p => p.TotalReceiveAmount == 0))
                {
                    entity.Reservation3 = "6";
                    entity.Reservation4 = "拒收";
                }
                else
                {
                    entity.Reservation3 = "4";
                    entity.Reservation4 = "已验收";
                }
                entity.Save();
                //查询出其ID
                entity.Fetch();

                BUSBillEntity bill = new BUSBillEntity { BillID = entity.BillID };
                bill.BillStatus = 7;
                bill.BillStatusName = "验收复查";
                bill.AcceptID = entity.AcceptID;
                bill.AcceptCode = entity.AcceptCode;
                bill.Update();
                foreach (EntityBase childEntity in children)
                {
                    BUSAcceptDetailEntity child = childEntity as BUSAcceptDetailEntity;
                    child.AcceptID = entity.AcceptID;
                    child.Save();
                }
                //存在则添加
                if (this.popupGridSampling.PopupView.GetRowCellValue(0, this.popupGridSampling.PopupView.Columns[0]) != null && this.popupGridSampling.PopupView.GetRowCellValue(0, this.popupGridSampling.PopupView.Columns[0]) != DBNull.Value)
                {
                    List<EntityBase> samplings = this.popupGridSampling.GetEntities();
                    //添加抽检记录
                    foreach (EntityBase samplingEntity in samplings)
                    {
                        BUSSamplingEntity sampling = samplingEntity as BUSSamplingEntity;
                        sampling.SamplingCode = Guid.NewGuid().ToString();
                        sampling.SamplingDate = DateTime.Now;
                        sampling.AcceptID = entity.AcceptID;
                        sampling.BillCode = entity.BillCode;
                        sampling.BillDate = entity.BillDate;
                        sampling.BillID = entity.BillID;
                        sampling.BillTypeID = entity.BillTypeID;
                        sampling.BillTypeName = entity.BillTypeName;
                        sampling.BillTypeSpell = entity.BillTypeSpell;
                        sampling.DealerID = entity.DealerID;
                        sampling.DealerCode = entity.DealerCode;
                        sampling.DealerName = entity.DealerName;
                        sampling.Inspector = this.txtAcceptPerson.Text.Trim();
                        sampling.InspectorSpell = GlobalMethod.GetAlphabetic(this.txtAcceptPerson.Text.Trim());
                        sampling.Save();
                    }
                }
            }
            else
            {
                var countedAcceptDetails = from a in acceptDetails
                                           group a by a.ProductID
                                               into g
                                               select new
                                               {
                                                   ProductID = g.Key,
                                                   TotalBillAmount = g.Sum(p => p.Amount),
                                                   TotalReceiveAmount = g.Sum(p => p.ReceiveAmount),
                                                   TotalQualifiedAmount = g.Sum(p => p.QualifiedAmount),
                                                   TotalUnqualifiedAmount = g.Sum(p => p.ReceiveAmount) - g.Sum(p => p.QualifiedAmount),
                                               };
                var countedAcceptDetailsAll = from a in acceptDetails
                                              select new
                                              {
                                                  ProductID = a.ProductID,
                                                  BatchNo = a.BatchNo,
                                                  ReceiveAmount = a.ReceiveAmount,
                                                  QualifiedAmount = a.QualifiedAmount,
                                                  UnqualifiedAmount = a.UnqualifiedAmount
                                              };

                var rejectedDetails =
                    countedAcceptDetails.Where(p => p.TotalReceiveAmount < p.TotalBillAmount).ToList();
                var unqualifiedDetails = countedAcceptDetailsAll.Where(p => p.UnqualifiedAmount > 0).ToList();
                //1 - 收货数 < 订单数: 拒收提示
                //2 - 不合格品数 > 0: 不合格平入库提示
                if (rejectedDetails.Any() || unqualifiedDetails.Any())
                {
                    var message = string.Empty;
                    if (rejectedDetails.Any() && unqualifiedDetails.Any())
                    {
                        message = "收货数量与验收数量不符，是否生成拒收记录？\n验收合格数量与验收到货数量不符，是否生成不合格品记录？";
                    }
                    else if (rejectedDetails.Any())
                    {
                        message = "收货数量与验收数量不符，是否生成拒收记录？";
                    }
                    else if (unqualifiedDetails.Any())
                    {
                        message = "验收合格数量与验收数量不符，是否生成不合格品记录？";
                    }
                    var dialogResult = XtraMessageBox.Show(message, "警告", MessageBoxButtons.YesNo, MessageBoxIcon.Exclamation);
                    if (dialogResult == DialogResult.No)
                    {
                        return;
                    }
                    if (dialogResult == DialogResult.Yes)
                    {
                        List<BUSAcceptDetailEntity> rejectedAcceptDetails = new List<BUSAcceptDetailEntity>();
                        foreach (var rejectedDetail in rejectedDetails)
                        {
                            var detail = acceptDetails.FirstOrDefault(p => p.ProductID == rejectedDetail.ProductID);
                            if (null != detail)
                            {
                                var busAcceptDetailEntity = new BUSAcceptDetailEntity
                                {
                                    ProductID = detail.ProductID,
                                    Amount = rejectedDetail.TotalBillAmount,
                                    ReceiveAmount = rejectedDetail.TotalReceiveAmount
                                };
                                if (!detail.IsNullField("ProduceDate"))
                                {
                                    busAcceptDetailEntity.ProduceDate = detail.ProduceDate;
                                }
                                if (!detail.IsNullField("ValidateDate"))
                                {
                                    busAcceptDetailEntity.ValidateDate = detail.ValidateDate;
                                }
                                if (!detail.IsNullField("BatchNo"))
                                {
                                    busAcceptDetailEntity.BatchNo = detail.BatchNo;
                                }
                                rejectedAcceptDetails.Add(busAcceptDetailEntity);
                            }
                        }
                        if (rejectedAcceptDetails.Any())
                        {
                            GenerateDeclinedBill(entity, rejectedAcceptDetails);
                        }

                        List<BUSAcceptDetailEntity> unqualifiedAcceptDetails = new List<BUSAcceptDetailEntity>();
                        foreach (var unqualifiedDetail in unqualifiedDetails)
                        {
                            var detail = acceptDetails.FirstOrDefault(p => p.ProductID == unqualifiedDetail.ProductID && p.BatchNo == unqualifiedDetail.BatchNo && p.UnqualifiedAmount > 0);
                            if (null != detail)
                            {

                                var ReceiveAmountList = (from a in acceptDetails.Where(p => p.ProductID == detail.ProductID && p.BatchNo.Equals(detail.BatchNo))
                                                         group a by a.ProductID
                                                             into g
                                                             select new
                                                             {
                                                                 ReceiveAmount = g.Sum(p => p.ReceiveAmount)
                                                             }).ToList();
                                var busAcceptDetailEntity = new BUSAcceptDetailEntity
                                {
                                    ProductID = detail.ProductID,
                                    Amount = unqualifiedDetail.UnqualifiedAmount,
                                    ReceiveAmount = ReceiveAmountList[0].ReceiveAmount,
                                    QualifiedAmount = unqualifiedDetail.QualifiedAmount,
                                    UnqualifiedAmount = unqualifiedDetail.UnqualifiedAmount,
                                    AcceptSolution = detail.IsNullField("AcceptSolution") ? "不合格区" : detail.AcceptSolution
                                };
                                if (!detail.IsNullField("ProduceDate"))
                                {
                                    busAcceptDetailEntity.ProduceDate = detail.ProduceDate;
                                }
                                if (!detail.IsNullField("ValidateDate"))
                                {
                                    busAcceptDetailEntity.ValidateDate = detail.ValidateDate;
                                }
                                if (!detail.IsNullField("BatchNo"))
                                {
                                    busAcceptDetailEntity.BatchNo = detail.BatchNo;
                                }
                                unqualifiedAcceptDetails.Add(busAcceptDetailEntity);
                            }
                        }
                        if (unqualifiedAcceptDetails.Any())
                        {
                            GenerateUnqualifiedStoreBill(entity, unqualifiedAcceptDetails);
                        }
                    }
                }
                entity.CreateDate = DateTime.Now;
                entity.LastModifyDate = DateTime.Now;
                entity.CreateUserID = GlobalItem.g_CurrentUser.UserID;
                entity.LastModifyUserID = GlobalItem.g_CurrentUser.UserID;
                //entity.Reservation1 = reason;
                entity.Reservation1 = "";
                entity.Reservation10 = "复查单据";
                if (!countedAcceptDetails.Any() ||
                    countedAcceptDetails.ToList().TrueForAll(p => p.TotalReceiveAmount == 0))
                {
                    entity.Reservation3 = "6";
                    entity.Reservation4 = "拒收";
                }
                else
                {
                    entity.Reservation3 = "4";
                    entity.Reservation4 = "已验收";
                }
                entity.Save();
                //查询出其ID
                entity.Fetch();

                BUSBillEntity bill = new BUSBillEntity { BillID = entity.BillID };
                
                bill.BillStatus = 7;
                bill.BillStatusName = "验收复查";
                bill.AcceptID = entity.AcceptID;
                bill.AcceptCode = entity.AcceptCode;
                bill.Update();
                foreach (EntityBase childEntity in children)
                {
                    BUSAcceptDetailEntity child = childEntity as BUSAcceptDetailEntity;
                    child.AcceptID = entity.AcceptID;
                    child.Save();
                }
                //存在则添加
                if (this.popupGridSampling.PopupView.GetRowCellValue(0, this.popupGridSampling.PopupView.Columns[0]) != null && this.popupGridSampling.PopupView.GetRowCellValue(0, this.popupGridSampling.PopupView.Columns[0]) != DBNull.Value)
                {
                    List<EntityBase> samplings = this.popupGridSampling.GetEntities();
                    //添加抽检记录
                    foreach (EntityBase samplingEntity in samplings)
                    {
                        BUSSamplingEntity sampling = samplingEntity as BUSSamplingEntity;
                        sampling.SamplingCode = Guid.NewGuid().ToString();
                        sampling.SamplingDate = DateTime.Now;
                        sampling.AcceptID = entity.AcceptID;
                        sampling.BillCode = entity.BillCode;
                        sampling.BillDate = entity.BillDate;
                        sampling.BillID = entity.BillID;
                        sampling.BillTypeID = entity.BillTypeID;
                        sampling.BillTypeName = entity.BillTypeName;
                        sampling.BillTypeSpell = entity.BillTypeSpell;
                        sampling.DealerID = entity.DealerID;
                        sampling.DealerCode = entity.DealerCode;
                        sampling.DealerName = entity.DealerName;
                        sampling.Inspector = this.txtAcceptPerson.Text.Trim();
                        sampling.InspectorSpell = GlobalMethod.GetAlphabetic(this.txtAcceptPerson.Text.Trim());
                        sampling.Save();
                    }
                }
            }




            if (data.Rows.Count > 0)
            {
                //按审批顺序排序
                data.DefaultView.Sort = "ApprovalSort";
                data = data.DefaultView.ToTable();

                ATCApproveEntity approveEntity = new ATCApproveEntity();
                approveEntity.InternalNo = "YS" + entity.ReceiveCode.Substring(2);
                approveEntity.DocumentCode = "AcceptBill";
                approveEntity.BillCode = entity.ReceiveCode;
                approveEntity.ApproveTitle = string.Format("{0}--验收，编号：{1}", entity.BillTypeName,
                    entity.ReceiveCode);
                approveEntity.ApprovalContent = String.Format("{0} {1} --验收，申请审批。", entity.BillTypeName,
                    entity.ReceiveCode);
                approveEntity.CreateUserID = GlobalItem.g_CurrentUser.UserID;
                approveEntity.CreateDate = DateTime.Now;
                approveEntity.IsApprovaled = false;
                for (int i = 0; i < data.Rows.Count; i++)
                {
                    var approveCode = approveEntity.InternalNo + (i + 1).ToString("00");
                    approveEntity.ApproveCode = approveCode;
                    approveEntity.IsWhole = Convert.ToBoolean(data.Rows[i]["IsWhole"]);
                    approveEntity.ApproveOrder = Convert.ToInt32(data.Rows[i]["ApprovalSort"]);
                    var approvalUserId = new Guid(data.Rows[i]["ApprovalUserID"].ToString());
                    approveEntity.ApprovalUserID = approvalUserId;
                    approveEntity.Save();

                    //添加消息提醒
                    ATCApproveNotificationEntity notification = new ATCApproveNotificationEntity();
                    notification.CreateUserID = approveEntity.CreateUserID;
                    var userName = GlobalItem.g_CurrentEmployee == null
                        ? GlobalItem.g_CurrentUser.UserName
                        : GlobalItem.g_CurrentEmployee.EmployeeName;
                    notification.CreateUserName = userName;
                    notification.FormClass = "AcceptBill";
                    notification.IsRead = false;
                    notification.TargetID = entity.BillID;
                    notification.TargetCode = entity.BillCode;
                    notification.ApproveCode = approveCode;
                    notification.Message = string.Format("{0} 于 {1} 验收申请（单号 {2}）。请您审批。", userName,
                        DateTime.Now.ToString("yyyy-MM-dd HH:mm:ss"), entity.BillCode);
                    notification.OwnerUserID = approvalUserId;
                    notification.Save();
                }
            }

            DialogResult dia = XtraMessageBox.Show("是否打印报告单？", "提示", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (dia == DialogResult.Yes)
            {
                string fileName = Path.Combine(AppDomain.CurrentDomain.BaseDirectory + "验收报告单.mrt");
                if (File.Exists(fileName))
                {
                    PrintPreviewForm printPreview = new PrintPreviewForm(fileName, Convert.ToInt32(entity.AcceptID));
                    printPreview.ShowDialog(this);
                }
                else
                {
                    XtraMessageBox.Show("找不到文件。", "系统提示", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            this.DialogResult = DialogResult.OK;
        }

        private void btnPrint_BeforePrint(EventArgs e)
        {
            if (txtBillTypeName.Text == "采购进货")
            {
                btnPrint.ReportName = "验收单";
            }
            else
            {
                btnPrint.ReportName = "销退验收单";
            }
        }
    }
}