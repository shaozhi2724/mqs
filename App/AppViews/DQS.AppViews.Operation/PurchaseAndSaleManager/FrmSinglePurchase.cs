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
using DQS.AppViews.Operation.Properties;

namespace DQS.AppViews.Operation.PurchaseAndSaleManager
{
    public partial class FrmSinglePurchase : DevExpress.XtraEditors.XtraForm
    {
        private int? m_id;

        List<GetDepartment> departments = new List<GetDepartment>();

        GetDepartment department = new GetDepartment();

        public FrmSinglePurchase()
        {
            InitializeComponent();
        }

        private void FrmSinglePurchase_Load(object sender, EventArgs e)
        {

            BindLookupData();
            this.cbxDeliveryType.InitSource();
            this.cbxPaymentType.InitSource();
            this.popupGrid.InitGrid();
            this.popupGrid.PopupView.KeyDown += PopupView_KeyDown;

            if (Settings.Default.IsUseDepartment)
            {
                this.layDepartment.Visibility = LayoutVisibility.Always;
                LoadDepartment();
            }

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
                this.txtBillDate.Text = DateTime.Now.ToString("F");
                this.txtBillCode.Text = GlobalMethod.GenPurchaseBillCode("JH");
                this.txtBillCode.Select(this.txtBillCode.Text.Length, 0);

                if (GlobalItem.g_CurrentEmployee != null) 
                {
                    this.txtOperator.Text = GlobalItem.g_CurrentEmployee.EmployeeName;
                }
            }
        }

        private void BindLookupData()
        {
            EntityCollection<BFITransportTypeEntity> transportTypes = new EntityCollection<BFITransportTypeEntity>();
            transportTypes.Fetch();
            foreach (var transportType in transportTypes)
            {
                txtTransportType.Properties.Items.Add(
                    (transportType as BFITransportTypeEntity).TransportTypeName);
            }

            EntityCollection<BFITransportToolEntity> transportTools = new EntityCollection<BFITransportToolEntity>();
            transportTools.Fetch();
            foreach (var transportTool in transportTools)
            {
                txtTransportTool.Properties.Items.Add(
                    (transportTool as BFITransportToolEntity).TransportToolName);
            }
        }

        private void SaveLookupData()
        {
            string transportToolName = txtTransportTool.Text.Trim();
            EntityCollection<BFITransportToolEntity> transportTools = new EntityCollection<BFITransportToolEntity>();
            transportTools.Fetch(BFITransportToolEntityFields.TransportToolName == transportToolName);
            if (transportTools.Count == 0)
            {
                BFITransportToolEntity entity = new BFITransportToolEntity();
                entity.TransportToolName = transportToolName;
                entity.Save();
            }
            string transportTypeName = txtTransportType.Text.Trim();
            EntityCollection<BFITransportTypeEntity> transportTypes = new EntityCollection<BFITransportTypeEntity>();
            transportTypes.Fetch(BFITransportTypeEntityFields.TransportTypeName == transportTypeName);
            if (transportTypes.Count == 0)
            {
                BFITransportTypeEntity entity = new BFITransportTypeEntity();
                entity.TransportTypeName = transportTypeName;
                entity.Save();
            }

        }

        private void LoadDepartment()
        {
            using (SqlConnection conn = new SqlConnection(GlobalItem.g_DbConnectStrings))
            {
                string sqlBill = @"SELECT DepartmentID,DepartmentName FROM dbo.BFI_Department WHERE DepartmentName LIKE '%业务%'";

                SqlDataAdapter sdad = new SqlDataAdapter(sqlBill, conn);
                DataSet ds = new DataSet();
                try
                {
                    bool isdefualtdepartment = DQS.Controls.Properties.Settings.Default.IsDefaultDepartment;
                    bool islockdepartment = DQS.Controls.Properties.Settings.Default.IsLockDepartment;
                    if (islockdepartment)
                    {
                        isdefualtdepartment = false;
                    }
                    sdad.Fill(ds, "Table");
                    for (int i = 0; i < ds.Tables["Table"].Rows.Count; i++)
                    {
                        department = new GetDepartment();
                        department.departmentID = Convert.ToInt32(ds.Tables["Table"].Rows[i]["DepartmentID"]);
                        department.departmentName = ds.Tables["Table"].Rows[i]["DepartmentName"].ToString();
                        departments.Add(department);
                        cboDepartment.Properties.Items.Add(department.departmentName);
                        if (isdefualtdepartment && i == 0)
                        {
                            cboDepartment.Text = department.departmentName;
                        }
                    }
                    if (islockdepartment)
                    {
                        this.cboDepartment.Properties.ReadOnly = true;
                        var departmentid = GlobalItem.g_CurrentEmployee.DepartmentID;
                        if (departmentid == 0)
                        {
                            XtraMessageBox.Show("没有找到相对应的部门，请核实。");
                            return;
                        }
                        foreach (var item in departments)
                        {
                            if (item.departmentID == departmentid)
                            {
                                cboDepartment.Text = item.departmentName;
                            }
                        }
                    }
                }
                catch (Exception ex)
                {
                    XtraMessageBox.Show(ex.ToString(), "系统提示", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                finally
                {
                    conn.Close();
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

                SaveLookupData();

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
                        if (!this.ValidateDealerQualificationfordetail()) return;//验证供货商的电子档案
                        if (!this.ValidateProductQualification()) return;//验证所有产品的电子档案
                        if (!this.ValidateDealerRange()) return;//验证供货商经营范围
                        if (!this.checkPersonRange()) return;//验证供应商销售员的经营范围

                        if (DQS.Controls.Properties.Settings.Default.IsThird)
                        {
                            if (cbxDeliveryType.Text.Trim() == "第三方物流")
                            {
                                if (string.IsNullOrWhiteSpace(txtTransportType.Text))
                                {
                                    XtraMessageBox.Show(txtTransportType.Properties.NullValuePrompt, "警告", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                                    txtTransportType.Focus();
                                    return;
                                }
                                if (string.IsNullOrWhiteSpace(txtTransportTool.Text))
                                {
                                    XtraMessageBox.Show(txtTransportTool.Properties.NullValuePrompt, "警告", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                                    txtTransportTool.Focus();
                                    return;
                                }
                                if (string.IsNullOrWhiteSpace(txtCarryCompnay.Text))
                                {
                                    XtraMessageBox.Show(txtCarryCompnay.Properties.NullValuePrompt, "警告", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                                    txtCarryCompnay.Focus();
                                    return;
                                }
                                if (string.IsNullOrWhiteSpace(txtTimeLimit.Text))
                                {
                                    XtraMessageBox.Show(txtTimeLimit.Properties.NullValuePrompt, "警告", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                                    txtTimeLimit.Focus();
                                    return;
                                }
                            }
                        }

                        if (Settings.Default.IsUseDepartment)
                        {
                            if (cboDepartment.Text == "")
                            {
                                XtraMessageBox.Show("选择项部门不能为空。", "系统提示", MessageBoxButtons.OK, MessageBoxIcon.Error);
                                return;
                            }
                        }

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

            if (null != e.PopupRow)
            {
                //检测选中品种的电子档案
                if (!ValidateProductQualificationForGrid(int.Parse(e.PopupRow["产品ID"].ToString()))) e.Cancel = true;

                DataRow dealer = txtDealerName.EditData as DataRow;
                if (null != dealer && !dealer.IsNull("单位ID"))
                {
                    int dealerID = int.Parse(dealer["单位ID"].ToString());
                    int productID = int.Parse(e.PopupRow["产品ID"].ToString());
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
                        BFIProductPriceEntity pprice = new BFIProductPriceEntity { ProductID = productID, PriceID = 1 };
                        pprice.Fetch();
                        double price = 0.0;
                        if (!pprice.IsNew())
                        {
                            price = pprice.Price;
                        }
                        this.popupGrid.PopupView.SetFocusedRowCellValue("单价", price);
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
            if (Settings.Default.IsUseDepartment)
            {
                if (!entity.IsNullField("DepartmentID"))
                {
                    foreach (GetDepartment depart in departments)
                    {
                        if (depart.departmentID == entity.DepartmentID)
                        {
                            cboDepartment.Text = depart.departmentName;
                        }
                    }
                }
            }
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

            if (!entity.IsNullField("TransportCode"))
            {
                this.txtTransportType.Text = entity.TransportCode;
            }

            if (!entity.IsNullField("Reservation6"))
            {
                this.txtTransportTool.Text = entity.Reservation6;
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

            if (!entity.IsNullField("InvoiceTypeName"))
            {
                var index = rdgPaymentType.Properties.Items.GetItemIndexByValue(entity.InvoiceTypeName);
                rdgPaymentType.SelectedIndex = index;
            }
            else
            {
                rdgPaymentType.SelectedIndex = 0;
            }
        }

        /// <summary>
        /// 非文本框赋值
        /// </summary>
        /// <param name="entity">实体</param>
        protected virtual void CustomSetEntity(BUSBillEntity entity)
        {
            if (Settings.Default.IsUseDepartment)
            {
                if (cboDepartment.Text != "")
                {
                    foreach (GetDepartment depart in departments)
                    {
                        if (depart.departmentName == cboDepartment.Text)
                        {
                            entity.DepartmentID = depart.departmentID;
                        }
                    }
                }
            }
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

            if (!string.IsNullOrWhiteSpace(txtTransportTool.Text))
            {
                entity.Reservation6 = txtTransportTool.Text.Trim();
            }
            if (!string.IsNullOrWhiteSpace(txtTransportType.Text))
            {
                entity.TransportCode = txtTransportType.Text.Trim();
            }

            if (this.cbxPaymentType.SelectedValue != null)
            {
                entity.PaymentTypeID = Convert.ToInt32(this.cbxPaymentType.SelectedValue);
                entity.PaymentTypeName = this.cbxPaymentType.Text.Trim();
            }
            entity.BillStyle = this.rdgBillStyle.Properties.Items[rdgBillStyle.SelectedIndex].Value.ToString();
            entity.InvoiceTypeName = this.rdgPaymentType.Properties.Items[rdgPaymentType.SelectedIndex].Value.ToString();

        }

        private void popupGrid_BeforePopupFormShow(object sender, DQS.Controls.CommonCode.BeforePopupFormShowArgs e)
        {
            if (Settings.Default.IsUseDepartment)
            {
                if (cboDepartment.Text == "")
                {
                    XtraMessageBox.Show("选择项部门不能为空。", "系统提示", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                    e.Cancel = true;
                }
                else
                {
                    cboDepartment.Properties.ReadOnly = true;
                }
            }
            if (!this.ValidateDealerManQu())
            {
                e.Cancel = true;
            }
            if (!this.ValidateDealerQualificationfordetail())
            {
                e.Cancel = true;
            }
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

        private void txtBusinessPerson_BeforePopupShow(object sender, DQS.Controls.CommonCode.BeforePopupShowArgs e)
        {
            if (this.txtDealerName.SelectedValue != null)
            {
                //this.txtBusinessPerson.Filter = String.Format("所属单位 = '{0}'", this.txtDealerName.Text.Trim());
                this.txtBusinessPerson.Filter = String.Format("所属单位ID = {0}", Convert.ToInt32(this.txtDealerName.SelectedValue));
            }

        }

        private bool ValidateDealerManQu()
        {
            //获取客户的过期证书
            if (this.txtBusinessPerson.Text != "")
            {
                int ManID = Convert.ToInt32(this.txtBusinessPerson.Tag);
                ViewCollection<AllQualificationView> qualifications = new ViewCollection<AllQualificationView>();

                PredicateExpression pe = new PredicateExpression();
                pe.Add(AllQualificationViewFields.所属表ID == "BFI_Salesman");
                pe.Add(AllQualificationViewFields.所属ID == ManID);
                pe.Add(AllQualificationViewFields.到期状态 == "已过期");
                qualifications.Fetch(pe);

                bool isgo = true;
                string message = "";
                foreach (var item in qualifications)
                {
                    var itemli = (AllQualificationView)item;
                    if (itemli.到期状态 == "已过期")
                    {
                        isgo = false;
                    }
                    string validate = "";
                    try
                    {
                        validate = itemli.到期日期.ToString("d");
                    }
                    catch (Exception)
                    {
                        validate = "空";
                    }
                    string mes = itemli.档案名称 + "--" + itemli.到期状态 + "--" + validate + "\r\n";
                    message += mes;
                }

                if (qualifications.Count > 0)
                {
                    if (isgo)
                    {
                        XtraMessageBox.Show(String.Format("销售员的电子档案即将过期！\r\n{0}", message), "系统提示", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        return true;
                    }
                    else
                    {
                        XtraMessageBox.Show(String.Format("销售员的电子档案已过期，无法生成订单，请修改！\r\n{0}", message), "系统提示", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        return false;
                    }
                }

                return true;
            }
            else
            {
                if (!Settings.Default.IsEmptySaleManSaveBill)
                {
                    XtraMessageBox.Show("请先选择采购员", "系统提示", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    return false;
                }
                else
                {
                    return true;
                }
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
                                object productStyle = this.popupGrid.PopupView.GetRowCellValue(i, "产品类别");
                                bool isHava = false;
                                if (productStyle != null && productStyle != DBNull.Value)
                                {
                                    isHava = productStyles.Contains(productStyle.ToString());
                                    if (!isHava) //不存在则超经营范围
                                    {
                                        XtraMessageBox.Show(
                                            String.Format("表格中第{0}行产品的类别超出“{1}”的经营或诊疗范围，无法生成订单，请修改！", (i + 1),
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
                else if (dealer.IndustryStyle == "生产厂商" && DQS.Controls.Properties.Settings.Default.IsControlDealerAsProductPhy)
                {
                    if (ranges.Count > 0)
                    {
                        int rowCount = this.popupGrid.PopupView.RowCount;
                        for (int i = 0; i < rowCount; i++)
                        {
                            object productStyle = this.popupGrid.PopupView.GetRowCellValue(i, "剂型");
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
                                        String.Format("表格中第{0}行产品的剂型超出供货商“{1}”的经营范围，无法生成订单，请修改！", (i + 1),
                                            this.txtDealerName.Text), "系统提示", MessageBoxButtons.OK,
                                        MessageBoxIcon.Information);
                                    return false;
                                }
                            }
                        }
                    }
                }
                else
                {
                    if (ranges.Count > 0)
                    {
                        int rowCount = this.popupGrid.PopupView.RowCount;
                        for (int i = 0; i < rowCount; i++)
                        {
                            object productStyle = this.popupGrid.PopupView.GetRowCellValue(i, "产品类别");
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
                                        String.Format("表格中第{0}行产品的类别超出供货商“{1}”的经营范围，无法生成订单，请修改！", (i + 1),
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
        private bool ValidateDealerQualificationfordetail()
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

                bool isgo = true;
                string message = "";
                foreach (var item in qualifications)
                {
                    var itemli = (AllQualificationView)item;
                    if (itemli.到期状态 == "已过期")
                    {
                        isgo = false;
                    }
                    string validate = "";
                    try
                    {
                        validate = itemli.到期日期.ToString("d");
                    }
                    catch (Exception)
                    {
                        validate = "空";
                    }
                    string mes = itemli.档案名称 + "--" + itemli.到期状态 + "--" + validate + "\r\n";
                    message += mes;
                }


                if (qualifications.Count > 0)
                {
                    if (isgo)
                    {
                        XtraMessageBox.Show(String.Format("供货商的电子档案即将过期！\r\n{0}", message), "系统提示", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        return true;
                    }
                    else
                    {
                        XtraMessageBox.Show(String.Format("供货商的电子档案包含已过期，无法生成订单，请修改！\r\n{0}", message), "系统提示", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        return false;
                    }
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
                pe.Add(AllQualificationViewFields.到期状态 == "已过期" | AllQualificationViewFields.到期状态 == "即将过期");
                qualifications.Fetch(pe);

                bool isgo = true;
                string message = "";
                foreach (var item in qualifications)
                {
                    var itemli = (AllQualificationView)item;
                    if (itemli.到期状态 == "已过期")
                    {
                        isgo = false;
                    }
                    string validate = "";
                    try
                    {
                        validate = itemli.到期日期.ToString("d");
                    }
                    catch (Exception)
                    {
                        validate = "空";
                    }
                    string mes = itemli.档案名称 + "--" + itemli.到期状态 + "--" + validate + "\r\n";
                    message += mes;
                }
                

                if (qualifications.Count > 0)
                {
                    if (isgo)
                    {
                        XtraMessageBox.Show(String.Format("供货商的电子档案即将过期！\r\n{0}", message), "系统提示", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        return true;
                    }
                    else
                    {
                        XtraMessageBox.Show(String.Format("供货商的电子档案包含已过期，无法生成订单，请修改！\r\n{0}", message), "系统提示", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        return false;
                    }
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
        /// 验证产品的电子档案
        /// </summary>
        /// <returns></returns>
        private bool ValidateProductQualificationForGrid(int productid)
        {
            //获取所有产品的过期证书
            ViewCollection<AllQualificationView> qualifications = new ViewCollection<AllQualificationView>();

            PredicateExpression pe = new PredicateExpression();
            pe.Add(AllQualificationViewFields.所属表ID == "BFI_Product");
            pe.Add(AllQualificationViewFields.所属ID == productid);
            pe.Add(AllQualificationViewFields.到期状态 == "已过期" | AllQualificationViewFields.到期状态 == "即将过期");
            qualifications.Fetch(pe);

            bool isgo = true;
            string message = "";
            foreach (var item in qualifications)
            {
                var itemli = (AllQualificationView)item;
                if (itemli.到期状态 == "已过期")
                {
                    isgo = false;
                }
                string validate = "";
                try
                {
                    validate = itemli.到期日期.ToString("d");
                }
                catch (Exception)
                {
                    validate = "空";
                }
                string mes = itemli.档案名称 + "--" + itemli.到期状态 + "--" + validate + "\r\n";
                message += mes;
            }
            BFIProductEntity product = new BFIProductEntity { ProductID = productid };
            product.Fetch();

            if (qualifications.Count > 0)
            {
                if (isgo)
                {
                    XtraMessageBox.Show(String.Format("产品：{0} 的电子档案即将过期！\r\n{1}",product.ProductName ,message), "系统提示", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    return true;
                }
                else
                {
                    XtraMessageBox.Show(String.Format("产品：{0} 的电子档案包含已过期，无法生成订单，请修改！\r\n{1}", product.ProductName, message), "系统提示", MessageBoxButtons.OK, MessageBoxIcon.Information);
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
                        XtraMessageBox.Show(String.Format("表格中第{0}行产品的电子档案存在已过期档案，无法生成订单，请修改！", (i + 1)), "系统提示", MessageBoxButtons.OK, MessageBoxIcon.Information);
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
                    object productStyle = this.popupGrid.PopupView.GetRowCellValue(i, "产品类别");
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
                            XtraMessageBox.Show(String.Format("表格中第{0}行产品的类别超出本企业的经营范围，无法生成订单，请修改！", (i + 1)), "系统提示", MessageBoxButtons.OK, MessageBoxIcon.Information);
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
                this.txtBusinessPerson.Tag = (this.txtBusinessPerson.EditData as DataRow)["人员ID"].ToString();
            }
        }

        private bool checkPersonRange()
        {
            EntityCollection<BFIPersonRangeEntity> ranges = new EntityCollection<BFIPersonRangeEntity>();
            ranges.Fetch(BFIPersonRangeEntityFields.PersonType == "供应商"
                & BFIPersonRangeEntityFields.PersonID == Convert.ToInt32(txtBusinessPerson.Tag)
                & BFIPersonRangeEntityFields.CheckType == "产品");

            int rowCount = this.popupGrid.PopupView.RowCount;
            if (ranges.Count > 0)
            {
                for (int i = 0; i < rowCount; i++)
                {
                    object code = this.popupGrid.PopupView.GetRowCellValue(i, "产品编号");
                    if (code != null && code != DBNull.Value)
                    {
                        bool isHava = false;
                        foreach (BFIPersonRangeEntity q in ranges)
                        {
                            if (code.ToString() == q.CheckValue)
                            {
                                isHava = true;
                                break;
                            }
                        }

                        if (!isHava)//不存在则超出经营范围
                        {
                            XtraMessageBox.Show(String.Format("表格中第{0}行产品超出供应商销售人员{1}的经营范围，无法生成订单，请修改！", (i + 1),txtBusinessPerson.Text.Trim()), "系统提示", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            return false;
                        }
                    }
                }
            }
            else
            {
                ranges.Fetch(BFIPersonRangeEntityFields.PersonType == "供应商"
                    & BFIPersonRangeEntityFields.PersonID == Convert.ToInt32(txtBusinessPerson.Tag)
                    & BFIPersonRangeEntityFields.CheckType == "明细");
                if (ranges.Count > 0)
                {
                    for (int i = 0; i < rowCount; i++)
                    {
                        object code = this.popupGrid.PopupView.GetRowCellValue(i, "产品类别");
                        if (code != null && code != DBNull.Value)
                        {
                            bool isHava = false;
                            foreach (BFIPersonRangeEntity q in ranges)
                            {
                                if (code.ToString() == q.CheckValue)
                                {
                                    isHava = true;
                                    break;
                                }
                            }

                            if (!isHava)//不存在则超出经营范围
                            {
                                XtraMessageBox.Show(String.Format("表格中第{0}行产品超出供应商销售人员{1}的经营范围，无法生成订单，请修改！", (i + 1), txtBusinessPerson.Text.Trim()), "系统提示", MessageBoxButtons.OK, MessageBoxIcon.Information);
                                return false;
                            }
                        }
                    }
                }
                else
                {
                    ranges.Fetch(BFIPersonRangeEntityFields.PersonType == "供应商"
                        & BFIPersonRangeEntityFields.PersonID == Convert.ToInt32(txtBusinessPerson.Tag)
                        & BFIPersonRangeEntityFields.CheckType == "大类");
                    if (ranges.Count > 0)
                    {
                        for (int i = 0; i < rowCount; i++)
                        {
                            object code = this.popupGrid.PopupView.GetRowCellValue(i, "产品大类");
                            if (code != null && code != DBNull.Value)
                            {
                                bool isHava = false;
                                foreach (BFIPersonRangeEntity q in ranges)
                                {
                                    if (code.ToString() == q.CheckValue)
                                    {
                                        isHava = true;
                                        break;
                                    }
                                }

                                if (!isHava)//不存在则超出经营范围
                                {
                                    XtraMessageBox.Show(String.Format("表格中第{0}行产品超出供应商销售人员{1}的经营范围，无法生成订单，请修改！", (i + 1), txtBusinessPerson.Text.Trim()), "系统提示", MessageBoxButtons.OK, MessageBoxIcon.Information);
                                    return false;
                                }
                            }
                        }
                    }
                }
            }
            //没有选择则不控制
            return true;
        }

        private void btnViewHistory_Click(object sender, EventArgs e)
        {
            FrmSinglePurchaseChangeHistory doc = new FrmSinglePurchaseChangeHistory();
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

        private void txtDealerName_PopupClosing(object sender, EventArgs e)
        {
            if (this.txtDealerName.EditData != null)
            {
                var dataRow = (this.txtDealerName.EditData as DataRow);
                if (null != dataRow)
                {
                    int dealerID = Convert.ToInt32(dataRow["单位ID"]);
                    BFIDealerEntity dealer = new BFIDealerEntity
                    {
                        DealerID = dealerID
                    };
                    dealer.Fetch();
                    this.txtDealerAddress.Text = dataRow["通讯地址"].ToString();
                    popupGrid.Tag = dataRow["单位名称"].ToString();
                    popupGrid.DealerID = dealerID;
                    BandSaleMan(dealerID);
                }
            }
            if (!this.ValidateDealerQualification()) return;
        }

        private void BandSaleMan(int dealerID)
        {
            string sql = @"SELECT TOP 1 SalesmanID,SalesmanName,MobilePhone,SalesmanStatus FROM (
SELECT SalesmanID,SalesmanName,MobilePhone,CASE WHEN (SELECT COUNT(0) FROM dbo.BFI_Qualification bq WHERE bq.BelongID = bs.SalesmanID AND BelongTable = 'BFI_Salesman' AND bq.ValidateDate < GETDATE())> 0 THEN '已过期' ELSE '未过期' END SalesmanStatus
FROM dbo.BFI_Salesman bs
WHERE DealerID =  " + dealerID + ") t ORDER BY t.SalesmanStatus";
            using (SqlConnection conn = new SqlConnection(GlobalItem.g_DbConnectStrings))
            {
                conn.Open(); //连接数据库
                SqlDataAdapter sda = new SqlDataAdapter(sql, conn);
                DataSet ds = new DataSet();
                try
                {
                    sda.Fill(ds, "TableBill");
                    if (ds.Tables["TableBill"].Rows.Count > 0)
                    {
                        txtBusinessPerson.Tag = ds.Tables["TableBill"].Rows[0]["SalesmanID"].ToString();
                        txtBusinessPerson.Text = ds.Tables["TableBill"].Rows[0]["SalesmanName"].ToString();
                        txtBusinessPhone.Text = ds.Tables["TableBill"].Rows[0]["MobilePhone"].ToString();
                    }
                    else
                    {
                        txtBusinessPerson.Text = "";
                        txtBusinessPhone.Text = "";
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

        private void cbxDeliveryType_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (DQS.Controls.Properties.Settings.Default.IsThird)
            {
                if (cbxDeliveryType.Text.Trim() == "第三方物流")
                {
                    this.layTransportType.Visibility = LayoutVisibility.Always;
                    this.layTransportTool.Visibility = LayoutVisibility.Always;
                    this.layTimeLimit.Visibility = LayoutVisibility.Always;
                    this.layCarryCompnay.Visibility = LayoutVisibility.Always;
                    this.layoutControlItem1.Visibility = LayoutVisibility.Always;
                }
                else
                {
                    this.layTransportType.Visibility = LayoutVisibility.Never;
                    this.layTransportTool.Visibility = LayoutVisibility.Never;
                    this.layTimeLimit.Visibility = LayoutVisibility.Never;
                    this.layCarryCompnay.Visibility = LayoutVisibility.Never;
                    this.layoutControlItem1.Visibility = LayoutVisibility.Never;
                }
            }
            else
            {
                this.layTransportType.Visibility = LayoutVisibility.Never;
                this.layTransportTool.Visibility = LayoutVisibility.Never;
                this.layTimeLimit.Visibility = LayoutVisibility.Never;
                this.layCarryCompnay.Visibility = LayoutVisibility.Never;
                this.layoutControlItem1.Visibility = LayoutVisibility.Never;
            }
        }
    }
}