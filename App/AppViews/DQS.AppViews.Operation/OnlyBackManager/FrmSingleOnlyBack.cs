using DevExpress.XtraEditors;
using DevExpress.XtraGrid.Views.Grid;
using DQS.Common;
using DQS.Module.Entities;
using ORMSCore;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace DQS.AppViews.Operation.OnlyBackManager
{
    public partial class FrmSingleOnlyBack : XtraForm
    {

        private int? m_id;
        public FrmSingleOnlyBack()
        {
            InitializeComponent();
        }

        private void FrmSingleOnlyBack_Load(object sender, EventArgs e)
        {

            this.cbxDeliveryType.InitSource();
            this.cbxPaymentType.InitSource();
            this.popupGrid.InitGrid();
            this.popupGrid.PopupView.KeyDown += PopupView_KeyDown;

            if (this.Tag != null)
            {
                this.m_id = Convert.ToInt32(this.Tag);

                BUSOnlyBillEntity entity = new BUSOnlyBillEntity { BillID = m_id.Value };
                entity.Fetch();

                this.ftPanel.SetEntity(entity);

                this.txtBillCode.Enabled = false;

                this.CustomGetEntity(entity);

                this.popupGrid.SetGridData(m_id.Value);

                if (entity.BillStatusName != "已下单")
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

                if (!entity.IsNullField("BillRemark") && entity.BillStatusName == "已下单" && entity.BillRemark == "修改")
                {
                    btnSave.Enabled = true;
                }
                else
                {
                    btnSave.Enabled = false;
                    EntityCollection<ATCApproveEntity> approveEntities = new EntityCollection<ATCApproveEntity>();
                    PredicateExpression pe = new PredicateExpression();
                    pe.Add(ATCApproveEntityFields.DocumentCode == "OnlyBackBill");
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
                    }
                }
            }
            else
            {
                this.txtBillCode.Text = LoadCode();

                if (GlobalItem.g_CurrentEmployee != null)
                {
                    this.txtOperator.Text = GlobalItem.g_CurrentEmployee.EmployeeName;
                }

            }
        }

        private string LoadCode()
        {

            string str = DateTime.Now.ToString("yyyyMMdd");
            string strban = DateTime.Now.ToString("yyyyMM");
            string sql = "SELECT TOP 1 BillCode FROM dbo.BUS_OnlyBill WHERE BillCode LIKE 'ZD" + strban + "%' ORDER BY BillID DESC";


            string No = "";
            using (SqlConnection conn = new SqlConnection(GlobalItem.g_DbConnectStrings))
            {
                conn.Open(); //连接数据库
                //必须为SqlCommand指定数据库连接和登记的事务
                SqlCommand cmd = new SqlCommand(sql, conn);
                try
                {
                    cmd.CommandText = string.Format(sql);
                    object Code = cmd.ExecuteScalar();
                    if (Code == null)
                    {
                        No = "0001";
                    }
                    else
                    {
                        int Num = Convert.ToInt32(Code.ToString().Substring(11, 4)) + 1;
                        if (Num < 10)
                        {
                            No = "000" + Num;
                        }
                        else if (Num >= 10 && Num < 100)
                        {
                            No = "00" + Num;
                        }
                        else if (Num >= 100 && Num < 1000)
                        {
                            No = "0" + Num;
                        }
                        else
                        {
                            No = Num.ToString();
                        }
                    }
                }
                catch (Exception ex)
                {

                }
                finally
                {
                    conn.Close();
                }
            }
            No = "SKD" + str + No;
            return No;
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
                    popupGrid_TotalPriceChanged(null,null);
                }
            }
        }


        /// <summary>
        /// 验证药品中是否有含黄麻碱的药品
        /// </summary>
        /// <returns></returns>
        private bool ProductStyle()
        {

            int rowCount = this.popupGrid.PopupView.RowCount;
            for (int i = 0; i < rowCount; i++)
            {
                object productstyle = this.popupGrid.PopupView.GetRowCellValue(i, "药品类别");

                if (productstyle != null && productstyle != DBNull.Value)
                {
                    if (productstyle.ToString() == "含黄麻碱" || productstyle.ToString() == "含可卡因")
                    {
                        if (this.cbxPaymentType.Text.Trim() == "现金")
                        {
                            XtraMessageBox.Show(String.Format("表格中第{0}行的药品是" + productstyle.ToString() + "药品，不能使用现金交易，无法生成订单，请修改！", (i + 1)), "系统提示", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            return false;
                        }
                    }
                }
            }
            return true;
        }


        /// <summary>
        /// 非文本框取值
        /// </summary>
        /// <param name="entity">实体</param>
        protected virtual void CustomGetEntity(BUSOnlyBillEntity entity)
        {
            if (!entity.IsNullField("PDealerID"))
            {
                this.txtDealerName.Tag = entity.PDealerID;
                this.txtDealerName.Text = entity.PDealerName;
                this.txtDealerAddress.Text = entity.PDealerAddress;
            }
            if (!entity.IsNullField("SDealerID"))
            {
                this.txtSaleDealer.Tag = entity.SDealerID;
                this.txtSaleDealer.Text = entity.SDealerName;
                this.txtSaleDealerAddress.Text = entity.SDealerAddress;
            }

            if (!entity.IsNullField("POperator"))
            {
                this.txtOperator.Text = entity.POperator;
            }
            if (!entity.IsNullField("SOperator"))
            {
                this.txtSOperator.Text = entity.SOperator;
            }
            if (!entity.IsNullField("PaymentTypeID"))
            {
                this.cbxPaymentType.SelectedValue = entity.PaymentTypeID;
            }
            if (!entity.IsNullField("TransportID"))
            {
                this.cbxDeliveryType.SelectedValue = entity.TransportID;
            }
            if (!entity.IsNullField("BillRemark"))
            {
                this.txtBillRemark.Text = entity.BillRemark;
            }
            if (!entity.IsNullField("PTotalPrice"))
            {
                this.txtPTotalPrice.Text = entity.PTotalPrice.ToString();
                this.txtSTotalPrice.Text = entity.STotalPrice.ToString();
            }

        }

        /// <summary>
        /// 非文本框赋值
        /// </summary>
        /// <param name="entity">实体</param>
        protected virtual void CustomSetEntity(BUSOnlyBillEntity entity)
        {

            if (this.txtDealerName.Text != null)
            {
                entity.PDealerID = Convert.ToInt32(this.txtDealerName.Tag);
                entity.PDealerName = this.txtDealerName.Text.Trim();
                entity.PDealerAddress = this.txtDealerAddress.Text.Trim();
            }
            
            if (this.txtSaleDealer.Text != null)
            {
                entity.SDealerID = Convert.ToInt32(this.txtSaleDealer.Tag);
                entity.SDealerName = this.txtSaleDealer.Text.Trim();
                entity.SDealerAddress = this.txtSaleDealerAddress.Text.Trim();
            }
            if (this.txtOperator.Text != null)
            {
                entity.POperator = this.txtOperator.Text.Trim();
            }
            if (this.txtSOperator.Text != null)
            {
                entity.SOperator = this.txtSOperator.Text.Trim();
            }
            if (this.cbxDeliveryType.SelectedValue != null)
            {
                entity.TransportID = Convert.ToInt32(this.cbxDeliveryType.SelectedValue);
                entity.TransportCode = this.cbxDeliveryType.Text.Trim();
            }
            if (this.cbxPaymentType.SelectedValue != null)
            {
                entity.PaymentTypeID = Convert.ToInt32(this.cbxPaymentType.SelectedValue);
                entity.PaymentTypeName = this.cbxPaymentType.Text.Trim();
            }
            if (this.txtPTotalPrice.Text.Trim() != "0")
            {
                entity.PTotalPrice = Convert.ToInt32(this.txtPTotalPrice.Text.Trim());
            }
            if (this.txtSTotalPrice.Text.Trim() != "0")
            {
                entity.STotalPrice = Convert.ToInt32(this.txtSTotalPrice.Text.Trim());
            }
            if (this.txtBillRemark.Text.Trim() != null)
            {
                entity.BillRemark = this.txtBillRemark.Text.Trim();
            }

        }

        private void txtSaleDealer_PopupClosing(object sender, EventArgs e)
        {

            if (this.txtSaleDealer.EditData != null)
            {
                //BindDealerAddress();
                var dataRow = (this.txtSaleDealer.EditData as DataRow);
                if (null != dataRow)
                {
                    this.txtSaleDealer.Tag = dataRow["单位ID"].ToString();
                    this.txtSaleDealerAddress.Text = dataRow["通讯地址"].ToString();
                    //this.txtDealerCode.Text = dataRow["单位编号"].ToString();
                    //popupGrid.Tag = dataRow["单位ID"].ToString() + "$" + dataRow["单位名称"].ToString();
                }
            }
        }

        private void txtDealerName_PopupClosing(object sender, EventArgs e)
        {
            if (this.txtDealerName.EditData != null)
            {
                //BindDealerAddress();
                var dataRow = (this.txtDealerName.EditData as DataRow);
                if (null != dataRow)
                {
                    this.txtDealerName.Tag = dataRow["单位ID"].ToString();
                    this.txtDealerAddress.Text = dataRow["通讯地址"].ToString();
                    //this.txtDealerCode.Text = dataRow["单位编号"].ToString();
                    //popupGrid.Tag = dataRow["单位ID"].ToString() + "$" + dataRow["单位名称"].ToString();
                }
            }
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            try
            {
                if (!this.ftPanel.ValidateIsNullFields()) return;
                if (!this.ProductStyle()) return;//现金交易
                //SaveDealerAddress();
                BUSOnlyBillEntity entity = this.ftPanel.GetEntity() as BUSOnlyBillEntity;

                this.CustomSetEntity(entity);

                int departmentID = 0;

                if (this.m_id != null)
                {
                    #region 修改

                    string changeUserName = null == GlobalItem.g_CurrentEmployee
                        ? GlobalItem.g_CurrentUser.UserName
                        : GlobalItem.g_CurrentEmployee.EmployeeName;

                    List<EntityBase> children = this.popupGrid.GetEntities();
                    BUSOnlyBillEntity bill = new BUSOnlyBillEntity { BillID = m_id.Value };
                    bill.Fetch();

                    Guid billCreateUserId = bill.CreateUserID;
                    if (!bill.IsNullField("BillRemark"))
                    {
                        if (bill.BillStatusName == "已下单" && bill.BillRemark == "修改")
                        {
                            entity.BillRemark = "";
                        }
                    }
                    entity.LastModifyDate = DateTime.Now;
                    entity.LastModifyUserID = GlobalItem.g_CurrentUser.UserID;
                    entity.Update();

                    //先删除
                    BUSOnlyBillDetailEntity childToDelete = new BUSOnlyBillDetailEntity { BillID = m_id.Value };
                    childToDelete.DeleteByCommonly();

                    //后加
                    foreach (EntityBase childEntity in children)
                    {
                        BUSOnlyBillDetailEntity child = childEntity as BUSOnlyBillDetailEntity;
                        child.BillID = m_id.Value;
                        child.Save();
                    }


                    #endregion
                }
                else
                {
                        /*
                    if (entity.IsNew())
                    {
                        if (!this.ValidateBatchNo()) return;
                        if (!this.ValidateDealerRange()) return; //验证客户经营范围
                        if (!this.ValidateDealerQualification()) return; //验证客户的电子档案
                        if (!this.ValidateSaleAmount()) return; //验证库存和销售数量
                        if (!ValidateUnitPrice()) return;

                        if (!this.ValidateBatchDate()) return;
                        if (!this.ValidateValidDate()) return;
                        if (!this.ValidateLockStatus()) return;
                        //新添加，验证特殊药品数量不能超过
                        if (!this.Amount()) return;
                        if (!this.MonthAmount()) return;
                        */
                        #region 新建


                        BFIEmployeeEntity employee = GlobalItem.g_CurrentEmployee;
                        if (null != employee
                            && !employee.IsNullField("DepartmentID"))
                        {
                            departmentID = employee.DepartmentID;
                        }

                        entity.BillTypeName = "直调订单";
                        entity.BillStatusName = "已下单";

                        List<EntityBase> children = this.popupGrid.GetEntities();
                        entity.BillCode = GlobalMethod.GetNewSaleBillCode(txtBillCode.Text.Substring(0, 2),
                            txtBillCode.Text);

                        entity.BillDate = DateTime.Now;
                        entity.CreateDate = DateTime.Now;
                        entity.LastModifyDate = DateTime.Now;
                        entity.CreateUserID = GlobalItem.g_CurrentUser.UserID;
                        entity.LastModifyUserID = GlobalItem.g_CurrentUser.UserID;
                        entity.Save();

                        //查询出其ID
                        entity.Fetch();

                        foreach (EntityBase childEntity in children)
                        {
                            BUSOnlyBillDetailEntity child = childEntity as BUSOnlyBillDetailEntity;
                            child.BillID = entity.BillID;
                            child.Save();

                        }

                        #endregion

                        EntityCollection<ATCUserPageEntity> userPages = new EntityCollection<ATCUserPageEntity>();
                        PredicateExpression pe = new PredicateExpression();
                        pe.Add(ATCUserPageEntityFields.UserID == GlobalItem.g_CurrentUser.UserID);
                        pe.Add(ATCUserPageEntityFields.DocumentCode == "OnlyBackBill");
                        DataTable data = userPages.FetchTable(pe);

                        if (data.Rows.Count > 0)
                        {
                            //按审批顺序排序
                            data.DefaultView.Sort = "ApprovalSort";
                            data = data.DefaultView.ToTable();

                            ATCApproveEntity approveEntity = new ATCApproveEntity();
                            approveEntity.InternalNo = "ZD" + entity.BillCode.Substring(2);
                            approveEntity.DocumentCode = "OnlyBackBill";
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
                                notification.FormClass = "SaleBill";
                                notification.IsRead = false;
                                notification.TargetID = entity.BillID;
                                notification.TargetCode = entity.BillCode;
                                notification.ApproveCode = approveCode;
                                notification.Message = string.Format("{0} 于 {1} 申请药品直调订单（单号 {2}）。请您审批。", userName,
                                    DateTime.Now.ToString("yyyy-MM-dd HH:mm:ss"), entity.BillCode);
                                notification.OwnerUserID = approvalUserId;
                                notification.Save();
                            }
                        }
                        else
                        {
                            entity.BillStatusName = "已审核";
                            entity.Update();
                        }
                    }
                /*
                    else
                    {
                        XtraMessageBox.Show("直调单号已存在。", "警告", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                        return;
                    }
                }
                      */

            }
            catch (Exception ex)
            {
                XtraMessageBox.Show(ex.Message, "错误", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                return;
            }
            this.DialogResult = DialogResult.OK;
        }

        private void popupGrid_TotalPriceChanged(object sender, Controls.CommonCode.TotalPriceChangedArgs e)
        {
            this.txtPTotalPrice.Text = e.TotalPrice + "";
        }

        private void popupGrid_NewOnlySaleTotalPriceChanged(object sender, Controls.CommonCode.TotalPriceChangedArgs e)
        {
            this.txtSTotalPrice.Text = popupGrid.GetOnlySummaryPrice().ToString();
        }
    }
}
