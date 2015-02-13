using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Windows.Forms;
using DevExpress.XtraEditors;
using DevExpress.XtraGrid.Views.Grid;
using DQS.Module.Entities;
using DQS.Common;
using ORMSCore;
using DQS.Module.Views;
using DevExpress.XtraLayout.Utils;

namespace DQS.AppViews.Operation.PurchaseAndSaleManager
{
    public partial class FrmSinglePurchase : DevExpress.XtraEditors.XtraForm
    {
        private int? m_id;

        public FrmSinglePurchase()
        {
            InitializeComponent();
        }

        private void FrmSinglePurchase_Load(object sender, EventArgs e)
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
                if (entity.BillStatusName == "已删除")
                {
                    this.layoutControlDel.Visibility = LayoutVisibility.Always;
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
                    pe.Add(ATCApproveEntityFields.DocumentCode == "PurchaseBill");
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
                this.txtBillCode.Text = GlobalMethod.GenPurchaseBillCode("JH");
                this.txtBillCode.Select(this.txtBillCode.Text.Length, 0);

                if (GlobalItem.g_CurrentEmployee != null) 
                {
                    this.txtOperator.Text = GlobalItem.g_CurrentEmployee.EmployeeName;
                }
                
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
                        if (!this.ValidateEnterpriseRange()) return;//验证本企业的经营范围
                        if (!this.ValidateDealerQualification()) return;//验证供货商的电子档案
                        if (!this.ValidateProductQualification()) return;//验证所有药品的电子档案
                        if (!this.ValidateDealerRange()) return;//验证供货商经营范围

                        entity.IsBillIn = true;//入库订单
                        entity.BillTypeID = 1;
                        entity.BillTypeName = "采购进货";
                        entity.BillTypeSpell = "cgjh";

                        #region 新建

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

                        #endregion

                        EntityCollection<ATCUserPageEntity> userPages = new EntityCollection<ATCUserPageEntity>();
                        PredicateExpression pe = new PredicateExpression();
                        pe.Add(ATCUserPageEntityFields.UserID == GlobalItem.g_CurrentUser.UserID);
                        pe.Add(ATCUserPageEntityFields.DocumentCode == "PurchaseBill");
                        DataTable data = userPages.FetchTable(pe);

                        if (data.Rows.Count > 0)
                        {
                            //按审批顺序排序
                            data.DefaultView.Sort = "ApprovalSort";
                            data = data.DefaultView.ToTable();

                            ATCApproveEntity approveEntity = new ATCApproveEntity();
                            approveEntity.InternalNo = "CGJH" + entity.BillCode.Substring(2);
                            approveEntity.DocumentCode = "PurchaseBill";
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
                                notification.FormClass = "PurchaseBill";
                                notification.IsRead = false;
                                notification.TargetID = entity.BillID;
                                notification.TargetCode = entity.BillCode;
                                notification.ApproveCode = approveCode;
                                notification.Message = string.Format("{0} 于 {1} 申请采购进货（单号 {2}）。请您审批。", userName,
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
                        XtraMessageBox.Show("采购单号已存在。", "警告", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
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
            for (int i = 0; i < this.popupGrid.PopupView.RowCount; i++)
            {
                object fieldValue = this.popupGrid.PopupView.GetRowCellValue(i, fieldName);
                if (fieldValue != null && fieldValue != DBNull.Value)
                {
                    if (e.PopupRow[fieldName] != null && e.PopupRow[fieldName] != DBNull.Value)
                    {
                        if (fieldValue.ToString().Trim() == e.PopupRow[fieldName].ToString().Trim())
                        {
                            XtraMessageBox.Show("药品已存在。", "系统提示", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                            this.popupGrid.PopupView.FocusedRowHandle = i;
                            e.Cancel = true;
                        }
                    }
                }
            }

            if (null != e.PopupRow)
            {
                DataRow dealer = txtDealerName.EditData as DataRow;
                if (null != dealer && !dealer.IsNull("单位ID"))
                {
                    int dealerID = int.Parse(dealer["单位ID"].ToString());
                    int productID = int.Parse(e.PopupRow["药品ID"].ToString());
                    EntityCollection<BUSProductPurchasePriceEntity> purchasePriceEntities = new EntityCollection<BUSProductPurchasePriceEntity>();
                    purchasePriceEntities.Fetch(BUSProductPurchasePriceEntityFields.DealerID == dealerID &
                                          BUSProductPurchasePriceEntityFields.ProductID == productID);
                    Dictionary<int, double> prices = new Dictionary<int, double>();
                    foreach (var purchasePriceEntity in purchasePriceEntities)
                    {
                        var price = purchasePriceEntity as BUSProductPurchasePriceEntity;
                        prices.Add(price.ProductPurchasePriceID, price.PurchasePrice);
                    }
                    if (prices.Count > 0)
                    {
                        var purchasePrice = prices.OrderByDescending(p => p.Key).FirstOrDefault();
                        this.popupGrid.PopupView.SetFocusedRowCellValue("单价", purchasePrice.Value);
                    }
                    else
                    {
                        this.popupGrid.PopupView.SetFocusedRowCellValue("单价", null);
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

            if (!entity.IsNullField("BusinessPerson"))
            {
                this.txtBusinessPerson.Text = entity.BusinessPerson;
            }

            if (!entity.IsNullField("Operator"))
            {
                this.txtOperator.Text = entity.Operator;
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
            if (this.txtDealerName.SelectedValue != null)
            {
                entity.DealerID = Convert.ToInt32(this.txtDealerName.SelectedValue);
                entity.DealerName = this.txtDealerName.Text.Trim();
                entity.DealerCode = (this.txtDealerName.EditData as DataRow)["单位编号"].ToString();
                entity.DealerSpell = GlobalMethod.GetAlphabetic(entity.DealerName);
            }

            if (this.txtBusinessPerson.Text.Trim() != "")
            {
                entity.BusinessPerson = this.txtBusinessPerson.Text.Trim();
                entity.BusinessPersonSpell = GlobalMethod.GetAlphabetic(entity.BusinessPerson);
            }

            if (this.txtOperator.Text.Trim() != "")
            {
                entity.Operator = this.txtOperator.Text.Trim();
                entity.OperatorSpell = GlobalMethod.GetAlphabetic(entity.Operator);
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
                    object priceID = this.popupGrid.PopupView.GetFocusedRowCellValue("药品ID");
                    if (priceID != null && priceID != DBNull.Value)
                    {
                        e.ActiveOperationColumn.PopupForm.Filter = "[药品ID] = " + priceID;
                    }
                }
            }
        }

        private void txtBusinessPerson_BeforePopupShow(object sender, DQS.Controls.CommonCode.BeforePopupShowArgs e)
        {
            if (this.txtDealerName.SelectedValue != null)
            {
                this.txtBusinessPerson.Filter = String.Format("所属单位 = '{0}'", this.txtDealerName.Text.Trim());
            }

        }

        /// <summary>
        /// 验证经销商的经营范围
        /// </summary>
        /// <returns></returns>
        private bool ValidateDealerRange()
        {
            //获取供货商的经营范围
            if (this.txtDealerName.SelectedValue != null)
            {
                int dealerID = Convert.ToInt32(this.txtDealerName.SelectedValue);

                BFIDealerEntity dealer = new BFIDealerEntity {DealerID = dealerID};
                dealer.Fetch();

                EntityCollection<BFIBusinessRangeEntity> ranges = new EntityCollection<BFIBusinessRangeEntity>();
                ranges.Fetch(BFIBusinessRangeEntityFields.DealerID == dealerID);

                if (dealer.IndustryStyle == "医疗机构")
                {
                    if (ranges.Count > 0)
                    {
                        //医疗机构取 诊疗范围
                        List<string> medicalSubjects =
                            ranges.Cast<BFIBusinessRangeEntity>().ToList().Select(p => p.ProductStyleName).ToList();

                        EntityCollection<SYSMedicalProductCategoryEntity> productCategories =
                            new EntityCollection<SYSMedicalProductCategoryEntity>();
                        productCategories.Fetch();
                        if (productCategories.Count > 0)
                        {
                            var productStyles =
                                productCategories.Cast<SYSMedicalProductCategoryEntity>()
                                    .Where(p => medicalSubjects.Contains(p.MedicalSubjectName))
                                    .Select(p => p.ProductStyleName)
                                    .ToList();
                            int rowCount = this.popupGrid.PopupView.RowCount;
                            for (int i = 0; i < rowCount; i++)
                            {
                                object productStyle = this.popupGrid.PopupView.GetRowCellValue(i, "药品类别");
                                bool isHava = false;
                                if (productStyle != null && productStyle != DBNull.Value)
                                {
                                    isHava = productStyles.Contains(productStyle.ToString());
                                    if (!isHava) //不存在则超经营范围
                                    {
                                        XtraMessageBox.Show(
                                            String.Format("表格中第{0}行药品的类别超出“{1}”的经营或诊疗范围，无法生成订单，请修改！", (i + 1),
                                                this.txtDealerName.Text), "系统提示", MessageBoxButtons.OK,
                                            MessageBoxIcon.Information);
                                        return false;
                                    }
                                }
                            }
                        }
                    }
                    return false;
                }
                else
                {
                    if (ranges.Count > 0)
                    {
                        int rowCount = this.popupGrid.PopupView.RowCount;
                        for (int i = 0; i < rowCount; i++)
                        {
                            object productStyle = this.popupGrid.PopupView.GetRowCellValue(i, "药品类别");
                            if (productStyle != null && productStyle != DBNull.Value)
                            {
                                bool isHava = false;
                                foreach (BFIBusinessRangeEntity range in ranges)
                                {
                                    if (productStyle.ToString().Trim() == range.ProductStyleName.Trim())
                                    {
                                        isHava = true;
                                        break;
                                    }
                                }

                                if (!isHava) //不存在则超经营范围
                                {
                                    XtraMessageBox.Show(
                                        String.Format("表格中第{0}行药品的类别超出供货商“{1}”的经营范围，无法生成订单，请修改！", (i + 1),
                                            this.txtDealerName.Text), "系统提示", MessageBoxButtons.OK,
                                        MessageBoxIcon.Information);
                                    return false;
                                }
                            }
                        }
                    }
                }
                //不存在经营范围,则无控制
                return true;
            }
            else
            {
                XtraMessageBox.Show("请先选择往来单位", "系统提示", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return false;
            }
        }

        /// <summary>
        /// 验证经销商的电子档案
        /// </summary>
        /// <returns></returns>
        private bool ValidateDealerQualification()
        {
            //获取供货商的过期证书
            if (this.txtDealerName.SelectedValue != null)
            {
                int dealerID = Convert.ToInt32(this.txtDealerName.SelectedValue);
                ViewCollection<AllQualificationView> qualifications = new ViewCollection<AllQualificationView>();

                PredicateExpression pe = new PredicateExpression();
                pe.Add(AllQualificationViewFields.所属表ID == "BFI_Dealer");
                pe.Add(AllQualificationViewFields.所属ID == dealerID);
                pe.Add(AllQualificationViewFields.到期状态 == "已过期");
                qualifications.Fetch(pe);

                if (qualifications.Count > 0)
                {
                    XtraMessageBox.Show(String.Format("供货商的{0}电子档案已过期，无法生成订单，请修改！", (qualifications[0] as AllQualificationView).档案名称), "系统提示", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    return false;
                }
                return true;
            }
            else
            {
                XtraMessageBox.Show("请先选择往来单位", "系统提示", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return false;
            }
        }

        /// <summary>
        /// 验证药品的电子档案
        /// </summary>
        /// <returns></returns>
        private bool ValidateProductQualification()
        {
            //获取所有药品的过期证书
            ViewCollection<AllQualificationView> qualifications = new ViewCollection<AllQualificationView>();

            PredicateExpression pe = new PredicateExpression();
            pe.Add(AllQualificationViewFields.所属表ID == "BFI_Product");
            pe.Add(AllQualificationViewFields.到期状态 == "已过期");
            qualifications.Fetch(pe);

            int rowCount = this.popupGrid.PopupView.RowCount;
            for (int i = 0; i < rowCount; i++)
            {
                object id = this.popupGrid.PopupView.GetRowCellValue(i, "药品ID");
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

                    if (isHava)//存在则药品过期
                    {
                        XtraMessageBox.Show(String.Format("表格中第{0}行药品的电子档案存在已过期档案，无法生成订单，请修改！", (i + 1)), "系统提示", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        return false;
                    }
                }
            }

            return true;
        }

        /// <summary>
        /// 验证本企业的经营范围
        /// </summary>
        /// <returns></returns>
        public bool ValidateEnterpriseRange()
        {
            //获取本企业的经营范围
            EntityCollection<BFIBusinessRangeEntity> ranges = new EntityCollection<BFIBusinessRangeEntity>();
            ranges.Fetch(BFIBusinessRangeEntityFields.EnterpriseID == 1);
            
            if (ranges.Count > 0)
            {
                int rowCount = this.popupGrid.PopupView.RowCount;
                for (int i = 0; i < rowCount; i++)
                {
                    object productStyle = this.popupGrid.PopupView.GetRowCellValue(i, "药品类别");
                    if (productStyle != null && productStyle != DBNull.Value)
                    {
                        bool isHava = false;
                        foreach (BFIBusinessRangeEntity range in ranges)
                        {
                            if (productStyle.ToString().Trim() == range.ProductStyleName.Trim())
                            {
                                isHava = true;
                                break;
                            }
                        }

                        if (!isHava)//不存在则超经营范围
                        {
                            XtraMessageBox.Show(String.Format("表格中第{0}行药品的类别超出本企业的经营范围，无法生成订单，请修改！", (i + 1)), "系统提示", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            return false;
                        }
                    }
                }
            }

            //不存在经营范围,则无控制
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

        private void txtBusinessPerson_PopupClosing(object sender, EventArgs e)
        {
            if (this.txtBusinessPerson.EditData != null)
            {
                this.txtBusinessPhone.Text = (this.txtBusinessPerson.EditData as DataRow)["手机"].ToString();
            }
        }

        private void btnViewHistory_Click(object sender, EventArgs e)
        {
            FrmSinglePurchaseChangeHistory doc = new FrmSinglePurchaseChangeHistory();
            doc.Tag = m_id.Value;
            doc.Show(this);
        }

    }
}