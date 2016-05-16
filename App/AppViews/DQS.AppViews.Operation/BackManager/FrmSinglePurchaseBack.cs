using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using DevExpress.XtraEditors;
using DevExpress.XtraGrid.Views.Grid;
using DQS.Module.Entities;
using ORMSCore;
using DQS.Common;
using DevExpress.XtraLayout.Utils;
using DQS.AppViews.Operation.Properties;
using DQS.Module;
using DQS.Module.Views;

namespace DQS.AppViews.Operation.BackManager
{
    public partial class FrmSinglePurchaseBack : DevExpress.XtraEditors.XtraForm
    {
        private int? m_id;
        private List<string> _amountErrors;
        List<SaleViewDetail> list = new List<SaleViewDetail>();

        List<UpdateBillDetail> ubdlist = new List<UpdateBillDetail>();
        List<UpdateBillDetail> updatelist = new List<UpdateBillDetail>();
        List<SaleViewDetail> addlist = new List<SaleViewDetail>();
        UpdateBillDetail ubd;
        SaleViewDetail svd;


        public string alter;
        private string dealerCode;
        public FrmSinglePurchaseBack()
        {
            InitializeComponent();
        }

        protected override bool ProcessDialogKey(Keys keyData)
        {
            if(keyData == (Keys.Alt | Keys.F2))
            {
                GlobalMethod.AllowNoStoreInPurchaseBack = true;
                txtDealerName.Properties.ReadOnly = false;
                txtDealerName2.Properties.ReadOnly = false;
                layoutControlItem1.Visibility = LayoutVisibility.Never;
                layDealerName.Visibility = LayoutVisibility.Always;
                popupGrid.PopupView.Columns["入库数量"].OptionsColumn.AllowEdit = true;
                popupGrid.PopupView.Columns["数量"].OptionsColumn.AllowEdit = true;
                popupGrid.PopupView.Columns["单价"].OptionsColumn.AllowEdit = true;
                popupGrid.PopupView.Columns["金额"].OptionsColumn.AllowEdit = true;
                popupGrid.Refresh();
            }
            return base.ProcessDialogKey(keyData);
        }
        private void FrmSinglePurchaseBack_Load(object sender, EventArgs e)
        {
            this.cbxDeliveryType.InitSource();
            this.cbxPaymentType.InitSource();
            this.popupGrid.InitGrid();
            this.popupGrid.PopupView.KeyDown += PopupView_KeyDown;

            if (this.Tag != null)
            {
                this.m_id = Convert.ToInt32(this.Tag);

                btnViewHistory.Visible = true;

                BUSBillEntity entity = new BUSBillEntity { BillID = m_id.Value };
                entity.Fetch();

                this.ftPanel.SetEntity(entity);

                this.txtBillCode.Enabled = false;

                if (entity.BillStatus == 9)
                {
                    this.layoutControlItemDel.Visibility = LayoutVisibility.Always;
                }

                this.CustomGetEntity(entity);

                this.popupGrid.SetGridData(m_id.Value);
                if (entity.BillStatus > 1)
                {
                    this.btnSave.Enabled = false;
                    this.ftPanel.Enabled = false;
                    (this.popupGrid.MainView as GridView).OptionsBehavior.Editable = false;

                    this.popupGrid.PopupView.KeyDown -= PopupView_KeyDown;
                    this.popupGrid.RemoveRowCellClickEvent();
                }
                else
                {
                    btnSave.Enabled = true;
                }
                if (entity.BillStatusName == "已下单")
                {
                    btnSave.Enabled = true;
                }
                else
                {

                    EntityCollection<ATCApproveEntity> approveEntities = new EntityCollection<ATCApproveEntity>();
                    PredicateExpression pe = new PredicateExpression();
                    pe.Add(ATCApproveEntityFields.DocumentCode == "PurchaseBackBill");
                    pe.Add(ATCApproveEntityFields.BillCode == entity.BillCode);
                    pe.Add(ATCApproveEntityFields.IsApprovaled == 1);
                    approveEntities.Fetch(pe);
                    if (approveEntities.Count > 0)
                    {
                        this.btnSave.Enabled = false;
                        this.ftPanel.Enabled = false;
                        (this.popupGrid.MainView as GridView).OptionsBehavior.Editable = false;

                        this.popupGrid.PopupView.KeyDown -= PopupView_KeyDown;
                        this.popupGrid.RemoveRowCellClickEvent();
                        btnSave.Enabled = false;
                    }
                }
            }
            else
            {
                this.txtBillCode.Text = GlobalMethod.GenPurchaseBillCode("JT");
                this.txtBillCode.Select(this.txtBillCode.Text.Length, 0);
            }
        }

        private void LoadubdList(int BillID)
        {
            ubdlist.Clear();
            string sql = @"SELECT DetailID,ProductID,BatchNo,Amount,UnitPrice,TotalPrice,TradePrice,RetailPrice FROM dbo.BUS_BillDetail WHERE BillID = " + BillID;
            using (SqlConnection conn = new SqlConnection(GlobalItem.g_DbConnectStrings))
            {
                SqlDataAdapter sdad = new SqlDataAdapter(sql, conn);
                DataSet ds = new DataSet();
                conn.Open();
                try
                {
                    sdad.Fill(ds, "Table");
                    for (int i = 0; i < ds.Tables["Table"].Rows.Count; i++)
                    {
                        ubd = new UpdateBillDetail();
                        int DetailID = Convert.ToInt32(ds.Tables["Table"].Rows[i]["DetailID"]);
                        int ProductID = Convert.ToInt32(ds.Tables["Table"].Rows[i]["ProductID"]);
                        string BatchNo = ds.Tables["Table"].Rows[i]["BatchNo"].ToString();
                        int Amount = Convert.ToInt32(ds.Tables["Table"].Rows[i]["Amount"]);
                        double UnitPrice = Convert.ToDouble(ds.Tables["Table"].Rows[i]["UnitPrice"]);
                        double TotalPrice = Convert.ToDouble(ds.Tables["Table"].Rows[i]["TotalPrice"]);
                        //double TradePrice = Convert.ToDouble(ds.Tables["Table"].Rows[i]["TradePrice"]);
                        //double RetailPrice = Convert.ToDouble(ds.Tables["Table"].Rows[i]["RetailPrice"]);
                        ubd.DetailID = DetailID;
                        ubd.ProductID = ProductID;
                        ubd.BatchNo = BatchNo;
                        ubd.Amount = Amount;
                        ubd.UnitPrice = UnitPrice;
                        ubd.TotalPrice = TotalPrice;
                        //ubd.TradePrice = TradePrice;
                        //ubd.RetailPrice = RetailPrice;
                        ubdlist.Add(ubd);
                    }
                }
                catch (Exception ex)
                {
                    XtraMessageBox.Show(ex.Message.ToString(), "提示", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                finally
                {
                    conn.Close();
                }
            }
        }

        private void UpdateNewDetail()
        {
            string sql;
            using (SqlConnection conn = new SqlConnection(GlobalItem.g_DbConnectStrings))
            {
                conn.Open(); //连接数据库
                try
                {
                    for (int i = 0; i < updatelist.Count; i++)
                    {
                        sql = "EXEC sp_UpdateBillDetail " + updatelist[i].DetailID + "," + updatelist[i].Amount + "," + updatelist[i].UnitPrice + "," + updatelist[i].TradePrice + "," + updatelist[i].RetailPrice;
                        SqlCommand cmd = new SqlCommand(sql, conn);
                        object ret = cmd.ExecuteScalar();
                        if (Convert.ToInt32(ret) == 1)
                        {
                            BFIProductEntity product = new BFIProductEntity { ProductID = updatelist[i].ProductID };
                            product.Fetch();
                            XtraMessageBox.Show(string.Format("产品：{0}，批号：{1} 库存不足。", product.ProductName, updatelist[i].BatchNo), "提示", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            return;
                        }
                    }
                }
                catch (Exception ex)
                {
                    XtraMessageBox.Show(ex.ToString(), "提示", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                finally
                {
                    conn.Close();
                }
            }
        }

        private void delDetail()
        {
            string sql;
            using (SqlConnection conn = new SqlConnection(GlobalItem.g_DbConnectStrings))
            {
                conn.Open(); //连接数据库
                try
                {
                    for (int i = 0; i < ubdlist.Count; i++)
                    {
                        sql = "sp_DelDetail " + ubdlist[i].DetailID;
                        SqlCommand cmd = new SqlCommand(sql, conn);
                        cmd.ExecuteNonQuery();
                    }
                }
                catch (Exception ex)
                {
                    XtraMessageBox.Show(ex.ToString(), "提示", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                finally
                {
                    conn.Close();
                }
            }
        }

        private void AddNewDetail()
        {

        }

        private bool CheckModify(int BillID)
        {
            LoadubdList(BillID);
            addlist.Clear();
            updatelist.Clear();
            int rowCount = this.popupGrid.PopupView.RowCount;
            for (int i = 0; i < rowCount; i++)
            {
                ubd = new UpdateBillDetail();
                svd = new SaleViewDetail();
                object productID = this.popupGrid.PopupView.GetRowCellValue(i, "产品ID");
                if (productID != null && productID != DBNull.Value)
                {
                    int PID = Convert.ToInt32(popupGrid.PopupView.GetDataRow(i)["产品ID"]);
                    string BatchNo = popupGrid.PopupView.GetDataRow(i)["批号"].ToString();
                    DateTime ProduceDate = (DateTime)popupGrid.PopupView.GetDataRow(i)["生产日期"];
                    DateTime ValidateDate = (DateTime)popupGrid.PopupView.GetDataRow(i)["有效期至"];
                    int Amount = Convert.ToInt32(popupGrid.PopupView.GetDataRow(i)["数量"]);
                    double UnitPrice = Convert.ToDouble(popupGrid.PopupView.GetDataRow(i)["单价"]);
                    double TotalPrice = Convert.ToDouble(popupGrid.PopupView.GetDataRow(i)["金额"]);
                    //double TradePrice = Convert.ToDouble(popupGrid.PopupView.GetDataRow(i)["批发价"]);
                    //double RetailPrice = Convert.ToDouble(popupGrid.PopupView.GetDataRow(i)["零售价"]);
                    object detailID = this.popupGrid.PopupView.GetRowCellValue(i, "DetailID");
                    if (detailID != null && detailID != DBNull.Value)
                    {
                        int detID = Convert.ToInt32(popupGrid.PopupView.GetRowCellValue(i, "DetailID"));
                        var data = ubdlist.Where(p => p.DetailID.Equals(detID)).ToList();
                        ubd.DetailID = detID;
                        ubd.ProductID = PID;
                        ubd.BatchNo = BatchNo;
                        ubd.Amount = Amount;
                        ubd.UnitPrice = UnitPrice;
                        //ubd.TradePrice = TradePrice;
                        //ubd.RetailPrice = RetailPrice;
                        if ((PID != data[0].ProductID) || (BatchNo != data[0].BatchNo))
                        {
                            //需要删除、新建
                            int InStoreDetailID = Convert.ToInt32(popupGrid.PopupView.GetDataRow(i)["入库ID"]);
                            if (!Check(i + 1, InStoreDetailID, PID, Amount, BatchNo)) return false;
                            svd.InStoreDetailID = InStoreDetailID;
                            svd.ProductID = PID;
                            svd.BatchNo = BatchNo;
                            svd.ProduceDate = ProduceDate;
                            svd.ValidateDate = ValidateDate;
                            svd.OutAmount = Amount;
                            svd.UnitPrice = UnitPrice;
                            svd.TotalPrice = TotalPrice;
                            //svd.TradePrice = TradePrice;
                            //svd.RetailPrice = RetailPrice;
                            addlist.Add(svd);
                        }
                        else
                        {
                            ubdlist.RemoveAll(p => p.DetailID.Equals(detID));
                            if (Amount != data[0].Amount)
                            {
                                //判断数量
                                if (!CheckAmount(i + 1, detID, PID, Amount, BatchNo)) return false;
                                ubd.NoAmount = Amount - data[0].Amount;
                                updatelist.Add(ubd);
                            }
                            else
                            {
                                if (UnitPrice != data[0].UnitPrice)
                                {
                                    ubd.NoAmount = Amount - data[0].Amount;
                                    updatelist.Add(ubd);
                                }
                            }
                        }
                    }
                    else
                    {
                        //新建判断
                        int InStoreDetailID = Convert.ToInt32(popupGrid.PopupView.GetDataRow(i)["入库ID"]);

                        if (!Check(i + 1, InStoreDetailID, PID, Amount, BatchNo)) return false;

                        svd.InStoreDetailID = InStoreDetailID;
                        svd.ProductID = PID;
                        svd.BatchNo = BatchNo;
                        svd.ProduceDate = ProduceDate;
                        svd.ValidateDate = ValidateDate;
                        svd.OutAmount = Amount;
                        svd.UnitPrice = UnitPrice;
                        svd.TotalPrice = TotalPrice;
                        //svd.TradePrice = TradePrice;
                        //svd.RetailPrice = RetailPrice;
                        addlist.Add(svd);
                    }
                }
            }
            return true;
        }

        //新建判断
        private bool Check(int RowNum, int InStoreID, int productID, int OutAmount, string BatchNo)
        {
            EntityCollection<BUSNEWStoreDetailEntity> esvds = new EntityCollection<BUSNEWStoreDetailEntity>();
            esvds.Fetch(BUSNEWStoreDetailEntityFields.InStoreBillID == InStoreID);
            var data = esvds.Cast<BUSNEWStoreDetailEntity>().Where(p => p.IsNullField("OutStoreBillID")).ToList();
            if (data[0].InAmount < OutAmount)
            {
                BFIProductEntity bp = new BFIProductEntity { ProductID = productID };
                bp.Fetch();
                XtraMessageBox.Show(string.Format("第{0}行，产品-{1}-批号为-{2}-库存数量不足", RowNum, bp.ProductName, BatchNo), "提示", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
            return true;
        }

        //修改数量判断
        private bool CheckAmount(int RowNum, int DetailID, int productID, int OutAmount, string BatchNo)
        {
            EntityCollection<BUSNEWStoreDetailEntity> bns = new EntityCollection<BUSNEWStoreDetailEntity>();
            bns.Fetch(BUSNEWStoreDetailEntityFields.OutStoreBillID == DetailID);
            var instore = bns.Cast<BUSNEWStoreDetailEntity>().Where(p => p.OutStoreBillID.Equals(DetailID)).ToList();
            EntityCollection<BUSNEWStoreDetailEntity> esvds = new EntityCollection<BUSNEWStoreDetailEntity>();
            esvds.Fetch(BUSNEWStoreDetailEntityFields.InStoreBillID == instore[0].InStoreBillID);
            var data = esvds.Cast<BUSNEWStoreDetailEntity>().Where(p => p.IsNullField("OutStoreBillID")).ToList();
            if ((data[0].InAmount + instore[0].OutAmount) < OutAmount)
            {
                BFIProductEntity bp = new BFIProductEntity { ProductID = productID };
                bp.Fetch();
                XtraMessageBox.Show(string.Format("第{0}行，产品-{1}-批号为-{2}-库存数量不足", RowNum, bp.ProductName, BatchNo), "提示", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
            return true;
        }

        //保存前检查库存是不是够开
        private void CheckStoreDetail(int DepartmentID)
        {
            list.Clear();
            int rowCount = this.popupGrid.PopupView.RowCount;
            //EntityCollection<BUSNEWStoreDetailEntity> esvds = new EntityCollection<BUSNEWStoreDetailEntity>();
            for (int i = 0; i < rowCount; i++)
            {
                svd = new SaleViewDetail();
                object productID = this.popupGrid.PopupView.GetRowCellValue(i, "产品ID");
                if (productID != null && productID != DBNull.Value)
                {
                    int InStoreDetailID = Convert.ToInt32(popupGrid.PopupView.GetDataRow(i)["入库ID"]);
                    int ProductID = Convert.ToInt32(popupGrid.PopupView.GetDataRow(i)["产品ID"]);
                    string BatchNo = popupGrid.PopupView.GetDataRow(i)["批号"].ToString();
                    //DateTime ProduceDate = (DateTime)popupGrid.PopupView.GetDataRow(i)["生产日期"];
                    //DateTime ValidateDate = (DateTime)popupGrid.PopupView.GetDataRow(i)["有效期至"];
                    //string SterilizationBatchNo = popupGrid.PopupView.GetDataRow(i)["灭菌批号"].ToString();
                    //object sdate = popupGrid.PopupView.GetDataRow(i)["灭菌日期"];
                    //DateTime SterilizationDate;
                    //if (sdate != null && sdate != DBNull.Value)
                    //{
                    //    SterilizationDate = (DateTime)sdate;
                    //}
                    //else
                    //{
                    //    SterilizationDate = Convert.ToDateTime("1900-01-01");
                    //}
                    int Amount = Convert.ToInt32(popupGrid.PopupView.GetDataRow(i)["数量"]);
                    double UnitPrice = Convert.ToDouble(popupGrid.PopupView.GetDataRow(i)["单价"]);
                    double TotalPrice = Convert.ToDouble(popupGrid.PopupView.GetDataRow(i)["金额"]);
                    svd.InStoreDetailID = InStoreDetailID;
                    svd.ProductID = ProductID;
                    svd.BatchNo = BatchNo;
                    //svd.ProduceDate = ProduceDate;
                    //svd.ValidateDate = ValidateDate;
                    svd.OutAmount = Amount;
                    svd.UnitPrice = UnitPrice;
                    svd.TotalPrice = TotalPrice;
                    svd.TradePrice = 0;
                    svd.RetailPrice = 0;
                    //svd.SterilizationBatchNo = SterilizationBatchNo;
                    //svd.SterilizationDate = SterilizationDate;
                    BFIProductEntity productEntity = new BFIProductEntity
                    {
                        ProductID = ProductID
                    };
                    productEntity.Fetch();
                    if (!CheckNewStoreDetail(InStoreDetailID, Amount, BatchNo))
                    {
                        _amountErrors.Add(String.Format("第{0}行，{1} 批号为{2}库存不足。", i + 1, productEntity.ProductName, BatchNo));
                    }
                    svd.Reservation1 = productEntity.PurchaseTax;
                    list.Add(svd);
                }
            }
        }

        private bool CheckNewStoreDetail(int InStoreID, int Amount, string BatchNo)
        {
            using (SqlConnection conn = new SqlConnection(GlobalItem.g_DbConnectStrings))
            {
                conn.Open(); //连接数据库
                try
                {
                    int returnValue = 0;
                    SqlCommand cmd = new SqlCommand("sp_CheckStoreDetail", conn);

                    cmd.Parameters.Add(new SqlParameter("@InStoreBillID", InStoreID));
                    cmd.Parameters.Add(new SqlParameter("@Amount", Amount));
                    cmd.Parameters.Add(new SqlParameter("@return", SqlDbType.Int, 0, ParameterDirection.ReturnValue,
                      true, 0, 0, string.Empty, DataRowVersion.Default, DBNull.Value));

                    cmd.CommandType = CommandType.StoredProcedure;

                    cmd.ExecuteScalar();
                    returnValue = (int)cmd.Parameters["@return"].Value;
                    if (returnValue == 1)
                    {
                        return false;
                    }
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
            return true;
        }

        private bool UpdateNewStoreDetail(int BillID, string BillCode)
        {
            using (SqlConnection conn = new SqlConnection(GlobalItem.g_DbConnectStrings))
            {
                conn.Open(); //连接数据库
                //必须为SqlCommand指定数据库连接和登记的事务
                try
                {
                    //string sql = "EXEC sp_InsertNewStoreDetail {0},'{1}'";
                    //sql = String.Format(sql, BillID, BillCode);
                    //SqlCommand cmd = new SqlCommand(sql, conn);
                    //cmd.ExecuteNonQuery();

                    int returnValue = 0;
                    SqlCommand cmd = new SqlCommand("sp_InsertNewStoreDetail", conn);

                    cmd.Parameters.Add(new SqlParameter("@BillID", BillID));
                    cmd.Parameters.Add(new SqlParameter("@BillCode", BillCode));
                    cmd.Parameters.Add(new SqlParameter("@return", SqlDbType.Int, 0, ParameterDirection.ReturnValue,
                      true, 0, 0, string.Empty, DataRowVersion.Default, DBNull.Value));

                    cmd.CommandType = CommandType.StoredProcedure;

                    cmd.ExecuteScalar();
                    returnValue = (int)cmd.Parameters["@return"].Value;
                    if (returnValue == 1)
                    {
                        return false;
                    }
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
            return true;
        }
        private void btnSave_Click(object sender, EventArgs e)
        {
            _amountErrors = new List<string>();
            try
            {
                if (!this.ftPanel.ValidateIsNullFields()) return;

                BUSBillEntity entity = this.ftPanel.GetEntity() as BUSBillEntity;

                this.CustomSetEntity(entity);

                int departmentID = 0;

                if (this.m_id != null)
                {
                    #region 修改

                    using (FrmAlter fa = new FrmAlter(this))
                    {
                        if (DialogResult.Yes == fa.ShowDialog())
                        {
                            string sqlString = @"
INSERT INTO dbo.BUS_BillChangeHistory
(
    BillHistoryID,
    BillID,
    BillCode,
    BillDate,
    IsBillIn,
    BillTypeID,
    BillTypeName,
    BillTypeSpell,
    BillStyle,
    BillStatus,
    BillStatusName,
    DealerID,
    DealerCode,
    DealerName,
    DealerSpell,
    DealerAddress,
    BusinessPerson,
    BusinessPersonSpell,
    BusinessPhone,
    DeliveryTypeID,
    DeliveryTypeName,
    TransportID,
    TransportCode,
    PaymentTypeID,
    PaymentTypeName,
    TotalPrice,
    PaymentDate,
    InvoiceTypeID,
    InvoiceTypeName,
    InvoiceTitle,
    InvoiceContent,
    Operator,
    OperatorSpell,
    ContractNo,
    ContractContent,
    SaleBillID,
    SaleBillCode,
    ReviewID,
    ReviewCode,
    StoreOutID,
    StoreOutCode,
    PurchaseBillID,
    PurchaseBillCode,
    ReceiveID,
    ReceiveCode,
    AcceptID,
    AcceptCode,
    StoreInID,
    StoreInCode,
    PickUpPerson,
    PickUpPersonSpell,
    ProductAmount,
    CreateUserID,
    CreateDate,
    LastModifyUserID,
    LastModifyDate,
    BillRemark,
    Reservation1,
    Reservation2,
    Reservation3,
    Reservation4,
    Reservation5,
    Reservation6,
    Reservation7,
    Reservation8,
    Reservation9,
    Reservation10,
    VersionNumber,
    ActionName,
    ChangeUserName,
    ChangeDate
)
SELECT
    '{0}',
    BillID,
    BillCode,
    BillDate,
    IsBillIn,
    BillTypeID,
    BillTypeName,
    BillTypeSpell,
    BillStyle,
    BillStatus,
    BillStatusName,
    DealerID,
    DealerCode,
    DealerName,
    DealerSpell,
    DealerAddress,
    BusinessPerson,
    BusinessPersonSpell,
    BusinessPhone,
    DeliveryTypeID,
    DeliveryTypeName,
    TransportID,
    TransportCode,
    PaymentTypeID,
    PaymentTypeName,
    TotalPrice,
    PaymentDate,
    InvoiceTypeID,
    InvoiceTypeName,
    InvoiceTitle,
    InvoiceContent,
    Operator,
    OperatorSpell,
    ContractNo,
    ContractContent,
    SaleBillID,
    SaleBillCode,
    ReviewID,
    ReviewCode,
    StoreOutID,
    StoreOutCode,
    PurchaseBillID,
    PurchaseBillCode,
    ReceiveID,
    ReceiveCode,
    AcceptID,
    AcceptCode,
    StoreInID,
    StoreInCode,
    PickUpPerson,
    PickUpPersonSpell,
    ProductAmount,
    CreateUserID,
    CreateDate,
    LastModifyUserID,
    LastModifyDate,
    BillRemark,
    Reservation1,
    Reservation2,
    Reservation3,
    '{3}',
    Reservation5,
    Reservation6,
    Reservation7,
    Reservation8,
    Reservation9,
    Reservation10,
    (SELECT ISNULL((SELECT TOP 1 ISNULL(VersionNumber, 0) FROM dbo.BUS_BillChangeHistory WHERE BillID={1} ORDER BY ChangeDate DESC),0)+1),
    '修改',
    '{2}',
    GETDATE()
FROM dbo.BUS_Bill
WHERE BillID={1}


INSERT INTO dbo.BUS_BillDetailChangeHistory
(
    BillHistoryID,
    DetailID,
    BillID,
    ProductID,
    BatchNo,
    ProduceDate,
    ValidateDate,
    Amount,
    UnitPrice,
    TotalPrice,
    TradePrice,
    RetailPrice,
    CreateUserID,
    CreateDate,
    LastModifyUserID,
    LastModifyDate,
    DetailRemark,
    StoreAmount,
    Reservation1,
    Reservation2,
    Reservation3,
    Reservation4,
    Reservation5,
    Reservation6,
    Reservation7,
    Reservation8,
    Reservation9,
    Reservation10
)
SELECT
    '{0}',
    DetailID,
    BillID,
    ProductID,
    BatchNo,
    ProduceDate,
    ValidateDate,
    Amount,
    UnitPrice,
    TotalPrice,
    TradePrice,
    RetailPrice,
    CreateUserID,
    CreateDate,
    LastModifyUserID,
    LastModifyDate,
    DetailRemark,
    StoreAmount,
    Reservation1,
    Reservation2,
    Reservation3,
    Reservation4,
    Reservation5,
    Reservation6,
    Reservation7,
    Reservation8,
    Reservation9,
    Reservation10
FROM dbo.BUS_BillDetail
WHERE BillID={1}
";
                            string changeUserName = null == GlobalItem.g_CurrentEmployee
                            ? GlobalItem.g_CurrentUser.UserName
                            : GlobalItem.g_CurrentEmployee.EmployeeName;
                            string sql = string.Format(sqlString, Guid.NewGuid(), m_id.Value, changeUserName, alter);
                            SqlCommand command = new SqlConnection(GlobalItem.g_DbConnectStrings).CreateCommand();
                            command.CommandType = CommandType.Text;
                            command.CommandText = sql;
                            using (command.Connection)
                            {
                                try
                                {
                                    command.Connection.Open();
                                    command.ExecuteNonQuery();
                                    command.Dispose();
                                }
                                catch (Exception ex)
                                {
                                    throw ex;
                                }
                                finally
                                {
                                    if (command.Connection.State != ConnectionState.Closed)
                                    {
                                        command.Connection.Close();
                                    }
                                }
                            }
                            bool needUpdateStoreAmount = false;
                            List<EntityBase> children = this.popupGrid.GetEntities();

                            BUSBillEntity bill = new BUSBillEntity { BillID = m_id.Value };
                            bill.Fetch();

                            var billCreateUserId = bill.CreateUserID;

                            if (!bill.IsNullField("Reservation10"))
                            {
                                if (bill.BillStatusName == "已下单" && bill.Reservation10 == "反审批")
                                {
                                    needUpdateStoreAmount = true;
                                    entity.Reservation10 = "";
                                    entity.BillStatus = 2;
                                    entity.BillStatusName = "已审核";
                                }
                            }
                            entity.LastModifyDate = DateTime.Now;
                            entity.LastModifyUserID = GlobalItem.g_CurrentUser.UserID;

                            CheckBillModify(m_id.Value);


                            //只要有一条库存错误信息，就不能保存销售单
                            if (_amountErrors.Any())
                            {
                                string message = string.Join("\n", _amountErrors);
                                XtraMessageBox.Show(message, "销售数据错误", MessageBoxButtons.OK, MessageBoxIcon.Error);
                                return;
                            }
                            entity.Update();

                            //if (Settings.Default.IsNewStoreDetail)
                            //{
                                entity.Fetch();
                                //删除所有相关明细
                                DelBill(entity.BillID);
                                //新建明细
                                InsertBillDetail(list, entity.BillID);
                                //新库存
                                if (!UpdateNewStoreDetail(entity.BillID, entity.BillCode))
                                {
                                    CheckStoreDetail(departmentID);
                                }


                                //只要有一条库存错误信息，就不能保存销售单
                                if (_amountErrors.Any())
                                {
                                    string message = string.Join("\n", _amountErrors);
                                    XtraMessageBox.Show(message, "销售数据错误", MessageBoxButtons.OK, MessageBoxIcon.Error);
                                    return;
                                }
                            /*
                            }
                            else
                            {

                                //先删除
                                BUSBillDetailEntity childToDelete = new BUSBillDetailEntity { BillID = m_id.Value };
                                childToDelete.DeleteByCommonly();

                                //后加
                                foreach (EntityBase childEntity in children)
                                {
                                    BUSBillDetailEntity child = childEntity as BUSBillDetailEntity;
                                    child.BillID = m_id.Value;
                                    child.Save();
                                }

                                if (needUpdateStoreAmount)
                                {
                                    ATCUserEntity userEntity = new ATCUserEntity { UserID = billCreateUserId };
                                    userEntity.Fetch();

                                    int billCreateEmployeeId = userEntity.EmployeeID;
                                    BFIEmployeeEntity employee = new BFIEmployeeEntity { EmployeeID = billCreateEmployeeId };
                                    employee.Fetch();

                                    if (!employee.IsNullField("DepartmentID"))
                                    {
                                        departmentID = employee.DepartmentID;
                                    }
                                    //更新库存
                                    foreach (EntityBase childEntity in children)
                                    {
                                        BUSBillDetailEntity child = childEntity as BUSBillDetailEntity;
                                        UpdateStoreDetail(child, departmentID);
                                    }
                                }
                            }
                            */
                        }
                    }
                    #endregion
                }
                else
                {
                    if (entity.IsNew())
                    {
                        if (!this.ValidateSaleAmount()) return;//验证库存和销售数量

                        if (!this.ValidateLockStatus()) return; //锁定产品不能退回
                        #region 新建
                        BFIEmployeeEntity employee = GlobalItem.g_CurrentEmployee;
                        if (null != employee
                            && !employee.IsNullField("DepartmentID"))
                        {
                            departmentID = employee.DepartmentID;
                        }
                        entity.IsBillIn = false;//(采购退货)出库
                        entity.BillTypeID = 2;
                        entity.BillTypeName = "采购退货";
                        entity.BillTypeSpell = "cgth";
                        entity.BillStatus = 1;
                        entity.BillStatusName = "已下单";

                        List<EntityBase> children = this.popupGrid.GetEntities();

                        //entity.BillCode = GlobalMethod.GetNewPurchaseBillCode(entity.BillCode.Substring(0, 2), entity.BillCode);
                        entity.BillDate = DateTime.Now;
                        entity.CreateDate = DateTime.Now;
                        entity.LastModifyDate = DateTime.Now;
                        entity.CreateUserID = GlobalItem.g_CurrentUser.UserID;
                        entity.LastModifyUserID = GlobalItem.g_CurrentUser.UserID;

                        //if (Settings.Default.IsNewStoreDetail)
                        //{
                            CheckStoreDetail(departmentID);
                        //}
                        //只要有一条库存错误信息，就不能保存销售单
                        if (_amountErrors.Any())
                        {
                            string message = string.Join("\n", _amountErrors);
                            XtraMessageBox.Show(message, "销售数据错误", MessageBoxButtons.OK, MessageBoxIcon.Error);
                            return;
                        }
                        entity.Save();

                        //查询出其ID
                        entity.Fetch();

                        //if (Settings.Default.IsNewStoreDetail)
                        //{
                            InsertBillDetail(list, entity.BillID);
                            //新库存
                            if (!UpdateNewStoreDetail(entity.BillID, entity.BillCode))
                            {
                                CheckStoreDetail(departmentID);
                            }
                        /*
                        }
                        else
                        {
                            foreach (EntityBase childEntity in children)
                            {
                                BUSBillDetailEntity child = childEntity as BUSBillDetailEntity;
                                child.BillID = entity.BillID;
                                child.Save();
                            }


                            //更新库存
                            foreach (EntityBase childEntity in children)
                            {
                                BUSBillDetailEntity child = childEntity as BUSBillDetailEntity;
                                UpdateStoreDetail(child, departmentID);
                            }
                        }
                        */
                        #endregion

                        //只要有一条库存错误信息，就不能保存销售单
                        if (_amountErrors.Any())
                        {
                            string message = string.Join("\n", _amountErrors);
                            XtraMessageBox.Show(message, "销售数据错误", MessageBoxButtons.OK, MessageBoxIcon.Error);
                            return;
                        }

                        EntityCollection<ATCUserPageEntity> userPages = new EntityCollection<ATCUserPageEntity>();
                        PredicateExpression pe = new PredicateExpression();
                        pe.Add(ATCUserPageEntityFields.UserID == GlobalItem.g_CurrentUser.UserID);
                        pe.Add(ATCUserPageEntityFields.DocumentCode == "PurchaseBackBill");
                        DataTable data = userPages.FetchTable(pe);

                        if (data.Rows.Count > 0)
                        {

                            //按审批顺序排序
                            data.DefaultView.Sort = "ApprovalSort";
                            data = data.DefaultView.ToTable();

                            ATCApproveEntity approveEntity = new ATCApproveEntity();
                            approveEntity.InternalNo = "CGTH" + entity.BillCode.Substring(2);
                            approveEntity.DocumentCode = "PurchaseBackBill";
                            approveEntity.BillCode = entity.BillCode;
                            approveEntity.ApproveTitle = string.Format("{0}({1})，编号：{2}", entity.BillTypeName,
                                entity.BillStyle, entity.BillCode);
                            approveEntity.ApprovalContent = String.Format("{0}({1}) {2} 申请审批。", entity.BillTypeName,
                                entity.BillStyle, entity.BillCode);
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
                                notification.FormClass = "PurchaseBackBill";
                                notification.IsRead = false;
                                notification.TargetID = entity.BillID;
                                notification.TargetCode = entity.BillCode;
                                notification.ApproveCode = approveCode;
                                notification.Message = string.Format("{0} 于 {1} 申请采购退货（单号 {2}）。请您审批。", userName,
                                    DateTime.Now.ToString("yyyy-MM-dd HH:mm:ss"), entity.BillCode);
                                notification.OwnerUserID = approvalUserId;
                                notification.Save();
                            }
                        }
                        else
                        {
                            entity.BillStatus = 2;
                            entity.BillStatusName = "已审核";
                            entity.Update();
                        }
                    }
                    else
                    {
                        XtraMessageBox.Show("采购退货单号已存在。", "警告", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                        return;
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

        private void DelBill(int BillID)
        {
            string sql = "EXEC sp_DelStoreDetail " + BillID;

            using (SqlConnection conn = new SqlConnection(GlobalItem.g_DbConnectStrings))
            {
                conn.Open(); //连接数据库
                try
                {
                    SqlCommand cmd = new SqlCommand(sql, conn);
                    cmd.ExecuteNonQuery();
                }
                catch (Exception ex)
                {
                    XtraMessageBox.Show(ex.ToString(), "提示", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                finally
                {
                    conn.Close();
                }
            }
        }

        private void CheckBillModify(int BillID)
        {
            list.Clear();
            LoadubdList(BillID);
            using (SqlConnection conn = new SqlConnection(GlobalItem.g_DbConnectStrings))
            {
                conn.Open(); //连接数据库
                //必须为SqlCommand指定数据库连接和登记的事务
                try
                {
                    string sql = "";
                    int rowCount = this.popupGrid.PopupView.RowCount;
                    for (int i = 0; i < rowCount; i++)
                    {
                        svd = new SaleViewDetail();
                        object productID = this.popupGrid.PopupView.GetRowCellValue(i, "产品ID");
                        if (productID != null && productID != DBNull.Value)
                        {
                            int ProductID = Convert.ToInt32(popupGrid.PopupView.GetDataRow(i)["产品ID"]);
                            //DateTime ProduceDate = (DateTime)popupGrid.PopupView.GetDataRow(i)["生产日期"];
                            //DateTime ValidateDate = (DateTime)popupGrid.PopupView.GetDataRow(i)["有效期至"];
                            //string SterilizationBatchNo = popupGrid.PopupView.GetDataRow(i)["灭菌批号"].ToString();
                            //object sdate = popupGrid.PopupView.GetDataRow(i)["灭菌日期"];
                            //DateTime SterilizationDate;
                            //if (sdate != null && sdate != DBNull.Value)
                            //{
                            //    SterilizationDate = (DateTime)sdate;
                            //}
                            //else
                            //{
                            //    SterilizationDate = Convert.ToDateTime("1900-01-01");
                            //}
                            double UnitPrice = Convert.ToDouble(popupGrid.PopupView.GetDataRow(i)["单价"]);
                            double TotalPrice = Convert.ToDouble(popupGrid.PopupView.GetDataRow(i)["金额"]);
                            double TradePrice = Convert.ToDouble(popupGrid.PopupView.GetDataRow(i)["批发价"]);
                            double RetailPrice = Convert.ToDouble(popupGrid.PopupView.GetDataRow(i)["零售价"]);
                            string Reservation1 = popupGrid.PopupView.GetDataRow(i)["销项税"].ToString();
                            int InStoreID = Convert.ToInt32(popupGrid.PopupView.GetRowCellValue(i, "入库ID"));
                            int Amount = Convert.ToInt32(popupGrid.PopupView.GetDataRow(i)["数量"]);
                            string BatchNo = popupGrid.PopupView.GetDataRow(i)["批号"].ToString();

                            BFIProductEntity productEntity = new BFIProductEntity
                            {
                                ProductID = Convert.ToInt32(productID)
                            };
                            productEntity.Fetch();

                            var data = ubdlist.Where(p => p.InStoreID.Equals(InStoreID)).ToList();
                            if (data.Count > 0)
                            {
                                sql = "SELECT dbo.fn_ModifyCheck({0},{1},{2})";
                                sql = String.Format(sql, InStoreID, Amount, data[0].Amount);
                                SqlCommand cmd = new SqlCommand(sql, conn);
                                object result = cmd.ExecuteScalar();
                                if (result.ToString() == "NO")
                                {
                                    _amountErrors.Add(String.Format("第{0}行，{1} 批号为{2}库存不足。", i + 1, productEntity.ProductName, BatchNo));
                                }
                                svd.InStoreDetailID = InStoreID;
                                svd.ProductID = ProductID;
                                svd.BatchNo = BatchNo;
                                //svd.ProduceDate = ProduceDate;
                                //svd.ValidateDate = ValidateDate;
                                svd.OutAmount = Amount;
                                svd.UnitPrice = UnitPrice;
                                svd.TotalPrice = TotalPrice;
                                svd.TradePrice = TradePrice;
                                svd.RetailPrice = RetailPrice;
                                //svd.SterilizationBatchNo = SterilizationBatchNo;
                                //svd.SterilizationDate = SterilizationDate;
                                svd.Reservation1 = Reservation1;
                                list.Add(svd);
                            }
                            else
                            {
                                sql = "SELECT dbo.fn_Check({0},{1})";
                                sql = String.Format(sql, InStoreID, Amount);
                                SqlCommand cmd = new SqlCommand(sql, conn);
                                object result = cmd.ExecuteScalar();
                                if (result == "NO")
                                {
                                    _amountErrors.Add(String.Format("第{0}行，{1} 批号为{2}库存不足。", i + 1, productEntity.ProductName, BatchNo));
                                }
                                svd.InStoreDetailID = InStoreID;
                                svd.ProductID = ProductID;
                                svd.BatchNo = BatchNo;
                                //svd.ProduceDate = ProduceDate;
                                //svd.ValidateDate = ValidateDate;
                                svd.OutAmount = Amount;
                                svd.UnitPrice = UnitPrice;
                                svd.TotalPrice = TotalPrice;
                                svd.TradePrice = TradePrice;
                                svd.RetailPrice = RetailPrice;
                                //svd.SterilizationBatchNo = SterilizationBatchNo;
                                //svd.SterilizationDate = SterilizationDate;
                                svd.Reservation1 = Reservation1;
                                list.Add(svd);
                            }
                        }
                    }
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

        private void InsertBillDetail(List<SaleViewDetail> list, int BillID)
        {
            using (SqlConnection conn = new SqlConnection(GlobalItem.g_DbConnectStrings))
            {
                conn.Open(); //连接数据库
                //必须为SqlCommand指定数据库连接和登记的事务
                try
                {
                    for (int i = 0; i < list.Count; i++)
                    {
                        string sql = "EXEC sp_InsertBillDetail {0},{1},{2},'{3}',{4},'{5}','{6}','{7}','{8}',{9},'{10}'";
                        sql = String.Format(sql, list[i].InStoreDetailID,
                            BillID,
                            list[i].ProductID,
                            list[i].BatchNo,
                            list[i].OutAmount,
                            list[i].UnitPrice,
                            list[i].TotalPrice,
                            list[i].TradePrice,
                            list[i].RetailPrice,
                            list[i].Reservation1,
                            list[i].isPrint);
                        SqlCommand cmd = new SqlCommand(sql, conn);
                        cmd.ExecuteNonQuery();
                    }
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

        private void UpdateOldStoreDetail(int productID, string batchNo, int department, int amount)
        {
            string sql = "UPDATE dbo.BUS_StoreDetail SET Amount = Amount - " + amount + " WHERE ProductID = " + productID + " AND BatchNo = '" + batchNo + "' AND DepartmentID = " + department;

            using (SqlConnection conn = new SqlConnection(GlobalItem.g_DbConnectStrings))
            {
                conn.Open(); //连接数据库
                try
                {
                    SqlCommand cmd = new SqlCommand(sql, conn);
                    cmd.ExecuteNonQuery();
                }
                catch (Exception ex)
                {
                    XtraMessageBox.Show(ex.ToString(), "提示", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                finally
                {
                    conn.Close();
                }
            }
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void popupGrid_PopupClosed(object sender, DQS.Controls.CommonCode.PopupFormClosedArgs e)
        {
            string fieldName = "产品ID";
            string batchNoFieldName = "批号";
            for (int i = 0; i < this.popupGrid.PopupView.RowCount; i++)
            {
                object fieldValue = this.popupGrid.PopupView.GetRowCellValue(i, fieldName);
                object batchNoValue = this.popupGrid.PopupView.GetRowCellValue(i, batchNoFieldName);
                if (fieldValue != null && fieldValue != DBNull.Value)
                {
                    if (e.PopupRow[fieldName] != null && e.PopupRow[fieldName] != DBNull.Value)
                    {
                        if (fieldValue.ToString().Trim() == e.PopupRow[fieldName].ToString().Trim() && batchNoValue.ToString().Trim() == e.PopupRow[batchNoFieldName].ToString().Trim())
                        {
                            XtraMessageBox.Show("产品已存在。", "系统提示", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                            this.popupGrid.PopupView.FocusedRowHandle = i;
                            e.Cancel = true;
                        }
                    }
                }
            }
        }

        private void popupGrid_TotalPriceChanged(object sender, DQS.Controls.CommonCode.TotalPriceChangedArgs e)
        {
            this.txtTotalPrice.Text = e.TotalPrice + "";
        }

        /// <summary>
        /// 非文本框取值
        /// </summary>
        /// <param name="entity">实体</param>
        protected virtual void CustomGetEntity(BUSBillEntity entity)
        {
            if (!entity.IsNullField("DealerID"))
            {
                this.txtDealerName2.Tag = entity.DealerID;
                this.txtDealerName.Tag = entity.DealerID;
                this.txtDealerName.Text = entity.DealerName;
            }
            if (!entity.IsNullField("BusinessPerson"))
            {
                this.txtBusinessPerson.Text = entity.BusinessPerson;
            }
            if (!entity.IsNullField("BusinessPhone"))
            {
                this.txtBusinessPhone.Text = entity.BusinessPhone;
            }

            if (!entity.IsNullField("DeliveryTypeID"))
            {
                this.cbxDeliveryType.SelectedValue = entity.DeliveryTypeID;
            }

            if (!entity.IsNullField("PaymentTypeID"))
            {
                this.cbxPaymentType.SelectedValue = entity.PaymentTypeID;
            }
            if (!entity.IsNullField("BillStyle"))
            {
                var index = rdgBillStyle.Properties.Items.GetItemIndexByValue(entity.BillStyle);
                rdgBillStyle.SelectedIndex = index;
            }
            else
            {
                rdgBillStyle.SelectedIndex = 0;
            }

        }

        /// <summary>
        /// 非文本框赋值
        /// </summary>
        /// <param name="entity">实体</param>
        protected virtual void CustomSetEntity(BUSBillEntity entity)
        {

            if (this.txtDealerName2.Text.Trim() != null)
            {
                entity.DealerID = Convert.ToInt32(this.txtDealerName2.Tag);
                entity.DealerName = this.txtDealerName2.Text.Trim();
                entity.DealerCode = dealerCode;
                entity.DealerSpell = GlobalMethod.GetAlphabetic(entity.DealerName);
            }
            /*
            if (this.txtPurchaseBillCode.Text.Trim() != null)
            {
                entity.PurchaseBillID = (int)this.txtPurchaseBillCode.Tag;
            }
            */

            if (this.cbxDeliveryType.SelectedValue != null)
            {
                entity.DeliveryTypeID = Convert.ToInt32(this.cbxDeliveryType.SelectedValue);
                entity.DeliveryTypeName = this.cbxDeliveryType.Text.Trim();
            }

            if (this.cbxPaymentType.SelectedValue != null)
            {
                entity.PaymentTypeID = Convert.ToInt32(this.cbxPaymentType.SelectedValue);
                entity.PaymentTypeName = this.cbxPaymentType.Text.Trim();
            }

            if (txtBusinessPerson.SelectedValue != null)
            {
                entity.BusinessPerson = txtBusinessPerson.Text.Trim();
                entity.BusinessPhone = txtBusinessPhone.Text.Trim();
            }

            entity.BillStyle = this.rdgBillStyle.Properties.Items[rdgBillStyle.SelectedIndex].Value.ToString();


        }

        private void txtDealerName_PopupClosing(object sender, EventArgs e)
        {
            if (this.txtDealerName.EditData != null)
            {
                this.txtDealerAddress.Text = (this.txtDealerName.EditData as DataRow)["通讯地址"].ToString();
                txtDealerName2.Text = (this.txtDealerName.EditData as DataRow)["单位名称"].ToString();
                txtDealerName2.Tag = Convert.ToInt32((txtDealerName.EditData as DataRow)["单位ID"]);
                dealerCode = (this.txtDealerName.EditData as DataRow)["单位编号"].ToString();
            }
        }

        private void popupGrid_BeforePopupFormShow(object sender, DQS.Controls.CommonCode.BeforePopupFormShowArgs e)
        {
            if (e.ActiveOperationColumn.PopupForm != null)
            {
                if (e.ActiveOperationColumn.PopupForm.Name == "Price")
                {
                    object priceID = this.popupGrid.PopupView.GetFocusedRowCellValue("产品ID");
                    if (priceID != null && priceID != DBNull.Value)
                    {
                        e.ActiveOperationColumn.PopupForm.Filter = "[产品ID] = " + priceID;
                    }
                }
                if (e.ActiveOperationColumn.PopupForm.Name == "Product")
                {
                    int departmentID = 0;
                    if (null == this.m_id)
                    {
                        BFIEmployeeEntity employee = GlobalItem.g_CurrentEmployee;
                        if (null != employee
                            && !employee.IsNullField("DepartmentID"))
                        {
                            departmentID = employee.DepartmentID;
                        }
                    }
                    else
                    {
                        int billCreateEmployeeId = 0;
                        BUSBillEntity billEntity = new BUSBillEntity { BillID = this.m_id.Value };
                        billEntity.Fetch();

                        var billCreateUserId = billEntity.CreateUserID;
                        ATCUserEntity userEntity = new ATCUserEntity { UserID = billCreateUserId };
                        userEntity.Fetch();

                        billCreateEmployeeId = userEntity.EmployeeID;
                        BFIEmployeeEntity employee = new BFIEmployeeEntity { EmployeeID = billCreateEmployeeId };
                        employee.Fetch();

                        if (!employee.IsNullField("DepartmentID"))
                        {
                            departmentID = employee.DepartmentID;
                        }
                    }
                    e.ActiveOperationColumn.PopupForm.Filter = String.Format("[所属部门ID] = {0}", departmentID);
                }
            }
        }

        private bool ValidateSaleAmount()
        {
            int rowCount = this.popupGrid.PopupView.RowCount;
            for (int i = 0; i < rowCount; i++)
            {
                object productID = this.popupGrid.PopupView.GetRowCellValue(i, "产品ID");
                if (productID != null && productID != DBNull.Value)
                {
                    object totalAmout = this.popupGrid.PopupView.GetRowCellValue(i, "库存数量");
                    //if (Settings.Default.IsNewStoreDetail)
                    //{
                    //    int InStoreDetailID = Convert.ToInt32(popupGrid.PopupView.GetRowCellValue(i, "入库ID"));
                    //    EntityCollection<BUSNEWStoreDetailEntity> esvds = new EntityCollection<BUSNEWStoreDetailEntity>();
                    //    esvds.Fetch(BUSNEWStoreDetailEntityFields.InStoreBillID == InStoreDetailID);
                    //    var data = esvds.Cast<BUSNEWStoreDetailEntity>().Where(p => p.IsNullField("OutStoreBillID")).ToList();
                    //    totalAmout = data[0].InAmount;
                    //}
                    //else
                    //{
                    //    totalAmout = this.popupGrid.PopupView.GetRowCellValue(i, "库存数量");
                    //}
                    object allInAmout = this.popupGrid.PopupView.GetRowCellValue(i, "入库数量");
                    object saleAmount = this.popupGrid.PopupView.GetRowCellValue(i, "数量");
                    if (saleAmount != null && saleAmount != DBNull.Value)
                    {
                        if (Convert.ToInt32(saleAmount) > Convert.ToInt32(totalAmout))
                        {
                            XtraMessageBox.Show(String.Format("表格中第{0}行产品的退货数量不能大于库存数量。", (i + 1)), "系统提示", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            return false;
                        }
                        if (Convert.ToInt32(saleAmount) > Convert.ToInt32(allInAmout))
                        {
                            XtraMessageBox.Show(String.Format("表格中第{0}行产品的退货数量不能大于入库数量。", (i + 1)), "系统提示", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            return false;
                        }
                    }
                }
            }
            return true;
        }

        /// <summary>
        /// 验证产品锁定状态，已锁定产品不能开单
        /// </summary>
        /// <returns></returns>
        private bool ValidateLockStatus()
        {
            int rowCount = this.popupGrid.PopupView.RowCount;
            for (int i = 0; i < rowCount; i++)
            {
                object lockStatus = this.popupGrid.PopupView.GetRowCellValue(i, "锁定状态");
                if (lockStatus != null && lockStatus != DBNull.Value)
                {
                    if (lockStatus.ToString() == "已锁定")
                    {
                        XtraMessageBox.Show(String.Format("表格中第{0}行产品的已锁定。", (i + 1)), "系统提示", MessageBoxButtons.OK,
                            MessageBoxIcon.Information);
                        return false;
                    }
                }
            }
            return true;
        }
        private void PopupView_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Delete)
            {
                if (!btnSave.Enabled)
                {
                    return;
                }
                DialogResult dr = XtraMessageBox.Show("确定要删除此行数据吗？", "提示", MessageBoxButtons.OKCancel, MessageBoxIcon.Question);
                if (dr == DialogResult.OK)
                {
                    this.popupGrid.ClearGrid(this.popupGrid.PopupView.FocusedRowHandle);
                    txtTotalPrice.Text = this.popupGrid.GetSummaryPrice().ToString();
                }
            }
        }

        private void txtBusinessPerson_BeforePopupShow(object sender, DQS.Controls.CommonCode.BeforePopupShowArgs e)
        {
            if (this.txtDealerName2.Text.Trim() != null)
            {
                this.txtBusinessPerson.Filter = String.Format("所属单位 = '{0}'", this.txtDealerName2.Text.Trim());
            }
        }

        private void txtBusinessPerson_PopupClosing(object sender, EventArgs e)
        {
            if (this.txtBusinessPerson.EditData != null)
            {
                this.txtBusinessPhone.Text = (this.txtBusinessPerson.EditData as DataRow)["手机"].ToString();
            }
        }

        //更新库存
        public static void UpdateStoreDetail(BUSBillDetailEntity billDetail, int storeDetailBelongDepartmentId)
        {
            EntityCollection<BUSStoreDetailEntity> storeDetails = new EntityCollection<BUSStoreDetailEntity>();
            storeDetails.Fetch(BUSStoreDetailEntityFields.ProductID == billDetail.ProductID
                & BUSStoreDetailEntityFields.BatchNo == billDetail.BatchNo
                & BUSStoreDetailEntityFields.DepartmentID == storeDetailBelongDepartmentId);
            BUSStoreDetailEntity storeDetail = new BUSStoreDetailEntity
            {
                StoreDetailID = (storeDetails[0] as BUSStoreDetailEntity).StoreDetailID
            };
            //更新库存
            storeDetail.Fetch();
            storeDetail.LastStoreID = billDetail.BillID;
            storeDetail.LastModifyDate = DateTime.Now;
            storeDetail.LastModifyUserID = GlobalItem.g_CurrentUser.UserID;
            if (storeDetail.IsNullField("Amount"))
            {
                throw new Exception(String.Format("ID号为{0}的产品没有批号为{1}库存信息。", billDetail.ProductID, billDetail.BatchNo));
            }
            storeDetail.Amount = storeDetail.Amount - billDetail.Amount;
            if (storeDetail.Amount < 0)
            {
                throw new Exception(String.Format("ID号为{0}的产品库存不足。", billDetail.ProductID));
            }
            storeDetail.Update();

        }

        private void btnViewHistory_Click(object sender, EventArgs e)
        {
            FrmSinglePurchaseBackChangeHistory doc = new FrmSinglePurchaseBackChangeHistory();
            doc.Tag = m_id.Value;
            doc.Show(this);
        }

        private void btnStoreInRecord_Click(object sender, EventArgs e)
        {
            var gridview = this.popupGrid.MainView as GridView;
            if (gridview.RowCount > 0)
            {
                var productID = gridview.GetFocusedRowCellValue("产品ID");
                if (null == productID || productID.ToString() == "")
                {
                    XtraMessageBox.Show("请选择产品。", "系统提示", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }
                string productName = gridview.GetFocusedRowCellValue("产品名称").ToString();
                string batchNo = gridview.GetFocusedRowCellValue("批号").ToString();
                using (FrmStoreInRecord fsir=new FrmStoreInRecord((int)productID,productName,batchNo))
                {
                    DialogResult dr = fsir.ShowDialog(this);
                    if (dr == DialogResult.OK)
                    {
                        this.popupGrid.PopupView.SetFocusedRowCellValue("入库数量", fsir.EditRow["数量"]);
                        this.popupGrid.PopupView.SetFocusedRowCellValue("单价", fsir.EditRow["单价"]);

                        this.txtDealerName.Text = fsir.EditBillRow["往来单位名称"].ToString();
                        this.txtDealerName2.Text = fsir.EditBillRow["往来单位名称"].ToString();
                        this.txtDealerName2.Tag = fsir.EditBillRow["往来单位ID"].ToString();
                        dealerCode = fsir.EditBillRow["往来单位编码"].ToString();
                        this.txtDealerAddress.Text = fsir.EditBillRow["往来单位地址"].ToString();
                        this.txtPurchaseBillCode.Text = fsir.EditBillRow["采购单编号"].ToString();
                        this.txtPurchaseBillCode.Tag = fsir.EditBillRow["订单ID"].ToString();

                    }
                }
            }
            else
            {
                XtraMessageBox.Show("请选择产品。", "系统提示", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void btnPrint_BeforePrint(EventArgs e)
        {
            if (Settings.Default.AllowNoCodeStoreOut)
            {
                CheckAndSaveCode(this.txtBillCode.Text);
            }
            else
            {
                return;
            }
        }

        private bool CheckAndSaveCode(string saleCode)
        {
            string issql = "SELECT COUNT(*) FROM dbo.WMS_RegulatoryCode WHERE ReviewCode = '" + saleCode + "'";
            string sql = "SELECT TOP 1 Code FROM dbo.WMS_RegulatoryCode WHERE StatusID = 0 AND StatusName = '未使用'";
            using (SqlConnection conn = new SqlConnection(GlobalItem.g_DbConnectStrings))
            {
                conn.Open(); //连接数据库
                //必须为SqlCommand指定数据库连接和登记的事务
                SqlCommand cmd = new SqlCommand(issql, conn);
                try
                {
                    int count = Convert.ToInt32(cmd.ExecuteScalar());
                    if (count > 0)
                    {
                        return true;
                    }
                    else
                    {
                        cmd = new SqlCommand(sql, conn);
                        object code = cmd.ExecuteScalar();
                        if (code != DBNull.Value && code != null)
                        {
                            WMSRegulatoryCodeEntity wmscode = new WMSRegulatoryCodeEntity { Code = code.ToString() };
                            wmscode.Fetch();
                            wmscode.ReviewCode = saleCode;
                            wmscode.StatusID = 1;
                            wmscode.StatusName = "已关联";
                            wmscode.RelationDate = DateTime.Now;
                            wmscode.Update();
                        }
                        else
                        {
                            XtraMessageBox.Show("没有可用流通监管码，请联系管理员成功导入后再使用。", "系统提示", MessageBoxButtons.OK, MessageBoxIcon.Error);
                            return false;
                        }
                    }
                }
                catch (Exception ex)
                {
                    XtraMessageBox.Show(ex.Message, "系统提示", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return false;
                }
                finally
                {
                    conn.Close();
                }
            }
            return true;
        }
    }
}