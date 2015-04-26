using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
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

namespace DQS.AppViews.Operation.BackManager
{
    public partial class FrmSinglePurchaseBack : DevExpress.XtraEditors.XtraForm
    {
        private int? m_id;

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

        public string alter;
        private void btnSave_Click(object sender, EventArgs e)
        {
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
                            entity.Update();

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
                    }
                    #endregion
                }
                else
                {
                    if (entity.IsNew())
                    {
                        if (!this.ValidateSaleAmount()) return;//验证库存和销售数量

                        if (!this.ValidateLockStatus()) return; //锁定药品不能退回
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
                        entity.Save();

                        //查询出其ID
                        entity.Fetch();

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
                        #endregion

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

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void popupGrid_PopupClosed(object sender, DQS.Controls.CommonCode.PopupFormClosedArgs e)
        {
            string fieldName = "药品ID";
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
                            XtraMessageBox.Show("药品已存在。", "系统提示", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
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
                this.txtDealerName2.Tag =entity.DealerID;
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
                    object priceID = this.popupGrid.PopupView.GetFocusedRowCellValue("药品ID");
                    if (priceID != null && priceID != DBNull.Value)
                    {
                        e.ActiveOperationColumn.PopupForm.Filter = "[药品ID] = " + priceID;
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
                object totalAmout = this.popupGrid.PopupView.GetRowCellValue(i, "库存数量");
                object allInAmout = this.popupGrid.PopupView.GetRowCellValue(i, "入库数量");
                if (totalAmout != null && totalAmout != DBNull.Value)
                {
                    object saleAmount = this.popupGrid.PopupView.GetRowCellValue(i, "数量");
                    if (saleAmount != null && saleAmount != DBNull.Value)
                    {
                        if (Convert.ToInt32(saleAmount) > Convert.ToInt32(totalAmout))
                        {
                            XtraMessageBox.Show(String.Format("表格中第{0}行药品的退货数量不能大于库存数量。", (i + 1)), "系统提示", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            return false;
                        }
                        if (Convert.ToInt32(saleAmount) > Convert.ToInt32(allInAmout))
                        {
                            XtraMessageBox.Show(String.Format("表格中第{0}行药品的退货数量不能大于入库数量。", (i + 1)), "系统提示", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            return false;
                        }
                    }
                }
            }
            return true;
        }

        /// <summary>
        /// 验证药品锁定状态，已锁定药品不能开单
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
                        XtraMessageBox.Show(String.Format("表格中第{0}行药品的已锁定。", (i + 1)), "系统提示", MessageBoxButtons.OK,
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
                int productID = (int)gridview.GetFocusedRowCellValue("药品ID");
                string productName = gridview.GetFocusedRowCellValue("药品名称").ToString();
                string batchNo = gridview.GetFocusedRowCellValue("批号").ToString();
                using (FrmStoreInRecord fsir=new FrmStoreInRecord(productID,productName,batchNo))
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
                XtraMessageBox.Show("请选择药品。", "系统提示", MessageBoxButtons.OK, MessageBoxIcon.Warning);
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