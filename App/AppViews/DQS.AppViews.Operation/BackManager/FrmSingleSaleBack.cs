using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using DevExpress.XtraEditors;
using DevExpress.XtraGrid.Columns;
using DevExpress.XtraGrid.Views.Grid;
using DQS.Module.Entities;
using ORMSCore;
using DQS.Common;
using DevExpress.XtraLayout.Utils;
using DevExpress.XtraPrinting.Export;
using DQS.AppViews.Operation.Properties;
using DQS.Controls.CommonCode;

namespace DQS.AppViews.Operation.BackManager
{
    public partial class FrmSingleSaleBack : DevExpress.XtraEditors.XtraForm
    {
        private int? m_id;

        private string _operator;


        protected override bool ProcessDialogKey(Keys keyData)
        {
            if(keyData == (Keys.Alt | Keys.F2))
            {
                GlobalMethod.AllowNoReviewSaleBack = true;
                popupGrid.PopupView.Columns["复核数量"].OptionsColumn.AllowEdit = true;
                popupGrid.PopupView.Columns["金额"].OptionsColumn.AllowEdit = true;
                popupGrid.Refresh();
            }
            return base.ProcessDialogKey(keyData);
        }
        public FrmSingleSaleBack()
        {
            InitializeComponent();
        }

        private void FrmSingleSaleBack_Load(object sender, EventArgs e)
        {
            this.cbxDeliveryType.InitSource();
            this.cbxPaymentType.InitSource();
            this.popupGrid.InitGrid();
            this.popupGrid.PopupView.KeyDown += PopupView_KeyDown;

            if (this.Tag != null)
            {
                btnViewHistory.Visible = true;
                this.m_id = Convert.ToInt32(this.Tag);

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
                    btnSave.Enabled = false;
                    btnChoose.Enabled = false;
                    btnReviewRecord.Enabled = false;
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
                    pe.Add(ATCApproveEntityFields.DocumentCode == "SaleBackBill");
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
                        btnChoose.Enabled = false;
                        btnReviewRecord.Enabled = false;
                    }
                }
            }
            else
            {
                this.txtBillCode.Text = GlobalMethod.GenSaleBillCode("XT");
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

                //全局销退允许不选复核单标记 - 用于非本系统销售数据退货
                if (!GlobalMethod.AllowNoReviewSaleBack)
                {
                    if (!this.ValidateAmount()) return;
                }

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
                            List<EntityBase> children = this.popupGrid.GetEntities();
                            BUSBillEntity bill = new BUSBillEntity { BillID = m_id.Value };
                            bill.Fetch();
                            if (!bill.IsNullField("Reservation10"))
                            {
                                if (bill.BillStatusName == "已下单" && bill.Reservation10 == "反审批")
                                {
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
                        }
                    }
                    #endregion
                }
                else
                {
                    if (entity.IsNew())
                    {

                        #region 新建

                        entity.IsBillIn = true;//(销售退货)入库
                        entity.BillTypeID = 2;
                        entity.BillTypeName = "销售退货";
                        entity.BillTypeSpell = "xsth";
                        entity.BillStatus = 1;
                        entity.BillStatusName = "已下单";
                        entity.Operator = _operator;

                        List<EntityBase> children = this.popupGrid.GetEntities();

                        //entity.BillCode = GlobalMethod.GetNewSaleBillCode(entity.BillCode.Substring(0, 2), entity.BillCode);
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

                        #endregion

                        EntityCollection<ATCUserPageEntity> userPages = new EntityCollection<ATCUserPageEntity>();
                        PredicateExpression pe = new PredicateExpression();
                        pe.Add(ATCUserPageEntityFields.UserID == GlobalItem.g_CurrentUser.UserID);
                        pe.Add(ATCUserPageEntityFields.DocumentCode == "SaleBackBill");
                        DataTable data = userPages.FetchTable(pe);

                        if (data.Rows.Count > 0)
                        {

                            //按审批顺序排序
                            data.DefaultView.Sort = "ApprovalSort";
                            data = data.DefaultView.ToTable();

                            ATCApproveEntity approveEntity = new ATCApproveEntity();
                            approveEntity.InternalNo = "XSTH" + entity.BillCode.Substring(2);
                            approveEntity.DocumentCode = "SaleBackBill";
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
                                notification.FormClass = "SaleBackBill";
                                notification.IsRead = false;
                                notification.TargetID = entity.BillID;
                                notification.TargetCode = entity.BillCode;
                                notification.ApproveCode = approveCode;
                                notification.Message = string.Format("{0} 于 {1} 申请销售退货（单号 {2}）。请您审批。", userName,
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
                        XtraMessageBox.Show("销售退货单号已存在。", "警告", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
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

        private bool ValidateAmount()
        {
            string reviewCode = txtReviewCode.Text.Trim();

            EntityCollection<BUSReviewEntity> reviews= new EntityCollection<BUSReviewEntity>();
            reviews.Fetch(BUSReviewEntityFields.ReviewCode == reviewCode);
            if (reviews.Count == 0)
            {
                XtraMessageBox.Show(String.Format("退货数据并未根据出库复核记录填写，不符合规则，请点击“复核记录”选择退货依据。"), "提示",
                            MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                return false;
            }
            BUSReviewEntity reviewEntity = reviews[0] as BUSReviewEntity;

            List<BUSReviewDetailEntity> reviewDetails = new List<BUSReviewDetailEntity>();
            EntityCollection<BUSReviewDetailEntity> reviewDetailEntityCollection = new EntityCollection<BUSReviewDetailEntity>();
            reviewDetailEntityCollection.Fetch(BUSReviewDetailEntityFields.ReviewID == reviewEntity.ReviewID);
            foreach (BUSReviewDetailEntity busReviewDetailEntity in reviewDetailEntityCollection)
            {
                reviewDetails.Add(busReviewDetailEntity);
            }

            List<BUSBillDetailEntity> oldSaleBackDetails = new List<BUSBillDetailEntity>();
            EntityCollection<BUSBillEntity> saleBackBills = new EntityCollection<BUSBillEntity>();
            saleBackBills.Fetch(BUSBillEntityFields.ReviewCode == reviewCode & BUSBillEntityFields.BillTypeName == "销售退货");

            foreach (BUSBillEntity saleBackBill in saleBackBills)
            {
                if (m_id != null && saleBackBill.BillID == m_id)
                {
                    //修改退货单，数量检测不应该包含当前单子
                    continue;
                }
                EntityCollection<BUSBillDetailEntity> billDetailEntityCollection =
                    new EntityCollection<BUSBillDetailEntity>();
                billDetailEntityCollection.Fetch(BUSBillDetailEntityFields.BillID == saleBackBill.BillID);
                foreach (BUSBillDetailEntity billDetailEntity in billDetailEntityCollection)
                {
                    BUSBillEntity bill = new BUSBillEntity
                                         {
                                             BillID = billDetailEntity.BillID
                                         };
                    bill.Fetch();
                    if(null != bill && bill.BillStatusName != "已删除")
                    {
                        oldSaleBackDetails.Add(billDetailEntity);
                    }
                }
            }

            for (int i = 0; i < this.popupGrid.PopupView.RowCount; i++)
            {
                var productID = this.popupGrid.PopupView.GetRowCellValue(i, "产品ID");
                var productName = this.popupGrid.PopupView.GetRowCellValue(i, "产品名称");
                var batchNo = this.popupGrid.PopupView.GetRowCellValue(i, "批号");
                object amount = this.popupGrid.PopupView.GetRowCellValue(i, "数量");
                object reviewAmount = this.popupGrid.PopupView.GetRowCellValue(i, "复核数量");

                if (amount != null && amount != DBNull.Value && reviewAmount != null && reviewAmount != DBNull.Value)
                {
                    //退货货数 <= 0， 错误
                    if ((int) amount <= 0)
                    {
                        XtraMessageBox.Show(String.Format("产品‘{0}’（批号:‘{1}’）的退货数量不符合规则。", productName, batchNo), "提示",
                            MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                        return false;
                    }
                    //退货货数 > 订单复核数， 错误
                    if ((int) amount > (int) reviewAmount)
                    {
                        XtraMessageBox.Show(String.Format("产品‘{0}’（批号:‘{1}’）的退货数量不能多于订单复核数量。", productName, batchNo),
                            "提示", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                        return false;
                    }

                    int totalReviewCount = 0;
                    int totalBackCount = 0;
                    List<BUSReviewDetailEntity> matchedReviewDetails =
                        reviewDetails.Where(p => p.ProductID == (int) productID && p.BatchNo == batchNo.ToString())
                            .ToList();
                    List<BUSBillDetailEntity> matchedBillDetails =
                        oldSaleBackDetails.Where(p => p.ProductID == (int) productID && p.BatchNo == batchNo.ToString())
                            .ToList();
                    if (matchedReviewDetails.Any())
                    {
                        totalReviewCount = matchedReviewDetails.Sum(p => p.ReviewAmount);
                    }
                    if (matchedBillDetails.Any())
                    {
                        totalBackCount = matchedBillDetails.Sum(p => p.Amount);
                    }
                    
                    if (totalReviewCount > 0)
                    {
                        if ((totalBackCount+(int)amount) > totalReviewCount)
                        {
                            int returnCount = totalReviewCount - totalBackCount;
                            if (returnCount < 0)
                            {
                                returnCount = 0;
                            }
                            XtraMessageBox.Show(String.Format("产品‘{0}’（批号:‘{1}’）的总退货数量不能多于订单数量。\n订单数量: {2}\n已退货数量:{3}\n还可退货数量:{4}",
                                productName, batchNo, totalReviewCount, totalBackCount, returnCount),
                            "提示", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                            return false;
                        }
                    }
                }
            }

            return true;
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void popupGrid_PopupClosed(object sender, DQS.Controls.CommonCode.PopupFormClosedArgs e)
        {
            string fieldName = "产品ID";
            for (int i = 0; i < this.popupGrid.PopupView.RowCount; i++)
            {
                object fieldValue = this.popupGrid.PopupView.GetRowCellValue(i, fieldName);
                if (fieldValue != null && fieldValue != DBNull.Value)
                {
                    if (e.PopupRow[fieldName] != null && e.PopupRow[fieldName] != DBNull.Value)
                    {
                        if (fieldValue.ToString().Trim() == e.PopupRow[fieldName].ToString().Trim())
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
                this.txtDealerName.SetMemberValue(entity.DealerID);
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
            //保存部门
            BUSBillEntity b = new BUSBillEntity { BillCode = txtSaleBillCode.Text };
            b.Fetch();
            if (b.DepartmentID != 0)
            {
                entity.DepartmentID = b.DepartmentID;
                entity.Operator = b.Operator;
            }


            if (this.txtDealerName.SelectedValue != null)
            {
                entity.DealerID = Convert.ToInt32(this.txtDealerName.SelectedValue);
                entity.DealerName = this.txtDealerName.Text.Trim();
                entity.DealerCode = (this.txtDealerName.EditData as DataRow)["单位编号"].ToString();
                entity.DealerSpell = GlobalMethod.GetAlphabetic(entity.DealerName);
            }

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
            entity.BillStyle = this.rdgBillStyle.Properties.Items[rdgBillStyle.SelectedIndex].Value.ToString();


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
            }
        }

        private void btnReviewRecord_Click(object sender, EventArgs e)
        {
            if (this.txtDealerName.Text != "")
            {
                object dealerName = this.txtDealerName.Text;
                object dealerID = (this.txtDealerName.EditData as DataRow)["单位ID"];
                object productName = this.popupGrid.PopupView.GetFocusedRowCellValue("产品名称");
                object batchNo = this.popupGrid.PopupView.GetFocusedRowCellValue("批号");
                if (productName != null && productName != DBNull.Value && batchNo != null && batchNo != DBNull.Value)
                {
                    object productID = this.popupGrid.PopupView.GetFocusedRowCellValue("产品ID");
                    object productSpec = this.popupGrid.PopupView.GetFocusedRowCellValue("规格型号");
                    object packageSpec = this.popupGrid.PopupView.GetFocusedRowCellValue("包装规格型号");
                    object producerName = this.popupGrid.PopupView.GetFocusedRowCellValue("生产厂商");
                    object produceDate = this.popupGrid.PopupView.GetFocusedRowCellValue("生产日期");
                    object validateDate = this.popupGrid.PopupView.GetFocusedRowCellValue("有效期至");
                    using (FrmReviewRecord frmReviewRecord = new FrmReviewRecord(dealerID,dealerName,productID, productName, productSpec, packageSpec, producerName, batchNo, validateDate, produceDate))
                    {
                        DialogResult dr = frmReviewRecord.ShowDialog(this);
                        if (dr == DialogResult.OK)
                        {
                            this.popupGrid.PopupView.SetFocusedRowCellValue("生产日期", frmReviewRecord.EditRow["生产日期"]);
                            this.popupGrid.PopupView.SetFocusedRowCellValue("有效期至", frmReviewRecord.EditRow["有效期至"]);
                            this.popupGrid.PopupView.SetFocusedRowCellValue("复核数量", frmReviewRecord.EditRow["复核数量"]);
                            this.popupGrid.PopupView.SetFocusedRowCellValue("单价", frmReviewRecord.EditRow["单价"]);

                            _operator = frmReviewRecord.EditRow["业务员"].ToString();
                            this.txtSaleBillCode.Text = frmReviewRecord.SaleBillCode;
                            this.txtReviewCode.Text = frmReviewRecord.ReviewCode;

                        }
                    }
                }
            }

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

        private void txtDealerName_EditValueChanging(object sender, DevExpress.XtraEditors.Controls.ChangingEventArgs e)
        {
            if (null != e.OldValue)
            {
                string oldValue = e.OldValue.ToString();
                string newValue = e.NewValue.ToString();
                if (!string.IsNullOrWhiteSpace(oldValue) && oldValue != newValue)
                {
                    this.popupGrid.ClearGrid();
                }
            }
        }

        private void btnViewHistory_Click(object sender, EventArgs e)
        {
            FrmSingleSaleBackChangeHistory doc = new FrmSingleSaleBackChangeHistory();
            doc.Tag = m_id.Value;
            doc.Show(this);
        }

        private void btnPrint_BeforePrint(EventArgs e)
        {
            if (Settings.Default.AllowNoCodeStoreIn)
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

        private void btnChoose_Click(object sender, EventArgs e)
        {
            foreach(GridColumn col in popupGrid.PopupView.Columns)
            {
                col.OptionsColumn.AllowEdit = col.Visible && col.Caption == "数量";
            }

            this.popupGrid.RemoveRowCellClickEvent();
            string dealerName = this.txtDealerName.Text;
            if(!string.IsNullOrWhiteSpace(dealerName))
            {
                int dealerID = 0;
                if (null != txtDealerName.Tag)
                {
                    dealerID = Convert.ToInt32(txtDealerName.Tag);
                }
                else
                {
                    var dataRow = this.txtDealerName.EditData as DataRow;
                    if (null != dataRow)
                    {
                        dealerID = Convert.ToInt32(dataRow["单位ID"]);
                    }
                }
                FrmReviewRecordQuery doc = new FrmReviewRecordQuery(dealerID, dealerName);
                var dr = doc.ShowDialog();
                if(dr == DialogResult.OK)
                {
                    BindSelectedReviewDetails(doc);
                }
            }
            else
            {
                FrmReviewRecordQuery doc = new FrmReviewRecordQuery();
                var dr = doc.ShowDialog(this);
                if(dr == DialogResult.OK)
                {
                    BindSelectedReviewDetails(doc);
                }
            }
        }

        private void BindSelectedReviewDetails(FrmReviewRecordQuery doc)
        {
            txtDealerName.Tag = doc.DealerID;
            txtDealerName.SetMemberValue(doc.DealerID);
            txtDealerName.Text = doc.DealerName;
            txtSaleBillCode.Text = doc.SaleBillCode;
            txtReviewCode.Text = doc.ReviewCode;
            if (doc.EditRows.Any())
            {
                _operator = doc.EditRows[0]["业务员"].ToString();
                popupGrid.EmptySource.Clear();
                for (int i = 0; i < doc.EditRows.Length; i++)
                {
                    DataRow row = popupGrid.EmptySource.NewRow();
                    popupGrid.EmptySource.Rows.Add(row);
                }

                popupGrid.ClearGrid();

                for (int i = 0; i < doc.EditRows.Length; i++)
                {
                    foreach (GridColumn col in popupGrid.PopupView.Columns)
                    {
                        if (!col.Visible && col.Caption != "产品ID")
                        {
                            continue;
                        }
                        if (col.Caption == "数量")
                        {
                            popupGrid.PopupView.SetRowCellValue(i, col.Caption, doc.EditRows[i]["出库数量"]);
                        }
                        else
                        {
                            if (col.Caption == "金额")
                            {
                                double changedPrice = Convert.ToDouble(doc.EditRows[i]["单价"])*
                                                      Convert.ToDouble(doc.EditRows[i]["出库数量"]);
                                popupGrid.PopupView.SetRowCellValue(i, col.Caption, changedPrice);

                                popupGrid_TotalPriceChanged(this, new TotalPriceChangedArgs(popupGrid.GetSummaryPrice()));
                            }
                            else
                            {
                                popupGrid.PopupView.SetRowCellValue(i, col.Caption, doc.EditRows[i][col.Caption]);
                            }
                        }
                    }
                }
                popupGrid.PopupView.BestFitColumns();
            }
        }
    }
}