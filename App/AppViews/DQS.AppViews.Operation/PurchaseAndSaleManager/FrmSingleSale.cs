using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Transactions;
using System.Windows.Forms;
using DevExpress.XtraBars.Utils;
using DevExpress.XtraEditors;
using DevExpress.XtraGrid;
using DevExpress.XtraGrid.Views.Grid;
using DevExpress.XtraLayout;
using DevExpress.XtraLayout.Utils;
using DQS.Controls;
using DQS.Module.Entities;
using DQS.Common;
using ORMSCore;
using DQS.Module.Views;
using DQS.Controls.CommonCode;
using DQS.AppViews.Operation.Properties;
using DQS.Module;
using DevExpress.XtraEditors.Repository;


namespace DQS.AppViews.Operation.PurchaseAndSaleManager
{
    public partial class FrmSingleSale : DevExpress.XtraEditors.XtraForm
    {
        private bool _useInternalProductPrice = true;
        private List<int> _selectedProductIds;
        private int? m_id;
        private List<string> _amountErrors;
        List<SaleViewDetail> list = new List<SaleViewDetail>();

        List<UpdateBillDetail> ubdlist = new List<UpdateBillDetail>();
        List<UpdateBillDetail> updatelist = new List<UpdateBillDetail>();
        List<SaleViewDetail> addlist = new List<SaleViewDetail>();
        UpdateBillDetail ubd;
        SaleViewDetail svd;


        public string alter;

        public FrmSingleSale()
        {
            InitializeComponent();
            _selectedProductIds = new List<int>();
            _amountErrors = new List<string>();
        }

        private void FrmSingleSale_Load(object sender, EventArgs e)
        {
            this.btnSaveAndOut.Visible = Settings.Default.IsSaveAndOutStoreButtonVisible;
            _useInternalProductPrice = GlobalItem.g_CurrentUser.UseInternalProductPrice;
            this.cbxDeliveryType.InitSource();
            this.cbxPaymentType.InitSource();
            this.popupGrid.InitGrid();

            RepositoryItemComboBox cbo = new RepositoryItemComboBox();
            cbo.Items.Add("是");
            this.popupGrid.PopupView.Columns["是否打印检报"].ColumnEdit = cbo;

            this.popupGrid.PopupView.KeyDown += PopupView_KeyDown;

            SetDealerAreaFilter();
            BindPrices();

            if (this.Tag != null)
            {
                this.btnSaveAndOut.Enabled = false;
                btnViewHistory.Visible = true;
                this.m_id = Convert.ToInt32(this.Tag);

                BUSBillEntity entity = new BUSBillEntity { BillID = m_id.Value };
                entity.Fetch();

                popupGrid.Tag = entity.DealerID.ToString() + "$" + entity.DealerName.ToString();

                this.btnFix.Visible = entity.BillStatus == 1 && (entity.IsNullField("Reservation10") || entity.Reservation10 == "");
                this.ftPanel.SetEntity(entity);

                this.txtBillCode.Enabled = false;

                if (entity.BillStatus == 9)
                {
                    this.layoutControlDel.Visibility = LayoutVisibility.Always;
                }
                BFIDealerEntity dealer = new BFIDealerEntity
                {
                    DealerID = entity.DealerID
                };
                dealer.Fetch();
                if (dealer.IndustryStyle == "医疗机构")
                {
                    this.layReservation11.Visibility = LayoutVisibility.Always;
                    this.layReservation12.Visibility = LayoutVisibility.Always;
                    this.layReservation13.Visibility = LayoutVisibility.Always;
                    this.layReservation14.Visibility = LayoutVisibility.Always;
                    this.layReservation15.Visibility = LayoutVisibility.Always;
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

                if (!entity.IsNullField("Reservation10") && entity.BillStatusName == "已下单" && entity.Reservation10 == "反审批")
                {
                    btnSave.Enabled = true;
                    btnCancel.Enabled = false;
                }
                else if (!entity.IsNullField("Reservation10") && entity.BillStatusName == "已下单" && entity.Reservation10 == "修改")
                {
                    btnSave.Enabled = true;
                    btnCancel.Enabled = false;
                }
                else
                {
                    btnSave.Enabled = false;
                    EntityCollection<ATCApproveEntity> approveEntities = new EntityCollection<ATCApproveEntity>();
                    PredicateExpression pe = new PredicateExpression();
                    pe.Add(ATCApproveEntityFields.DocumentCode == "SaleBill");
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
                this.txtBillCode.Text = GlobalMethod.GenSaleBillCode("XS");
                this.txtBillCode.Select(this.txtBillCode.Text.Length, 0);

                if (!Settings.Default.SettingBusinessPersonISNULL)
                {
                    if (GlobalItem.g_CurrentEmployee != null)
                    {
                        this.txtOperator.Text = GlobalItem.g_CurrentEmployee.EmployeeName;
                        txtOperator.SetMemberValue(GlobalItem.g_CurrentEmployee.EmployeeID);
                    }
                }
                this.txtReservation6.Text = GlobalItem.g_CurrentEmployee.EmployeeName;
            }


            var gridView = popupGrid.MainView as GridView;
            DevExpress.XtraGrid.Columns.GridColumn gc = gridView.Columns[1];


            gridView.FocusedColumn = gc;
            gridView.SelectCell(1, gc);
            this.SetProductAmount(false);
            this.btnFix.Visible = false;
        }
        private void BindPrices()
        {
            EntityCollection<BFIPriceListEntity> prices = new EntityCollection<BFIPriceListEntity>();
            prices.Fetch(BFIPriceListEntityFields.PriceListType == "销售价格表" & BFIPriceListEntityFields.Active == true);
            if (prices.Count < 7)
            {
                cbxPrice.Properties.DropDownRows = prices.Count;
            }
            cbxPrice.Properties.DataSource = prices;

        }
        private void SetDealerAreaFilter()
        {
            string defaultDealerFilter = txtDealerName.Filter;
            string defaultDealerFormatQueryString = txtDealerName.FormatQueryString;

            EntityCollection<ATCUserAreaEntity> grantedUserAreas = new EntityCollection<ATCUserAreaEntity>();
            grantedUserAreas.Fetch(ATCUserAreaEntityFields.UserID == GlobalItem.g_CurrentUser.UserID);

            string areaFilter = "";
            List<string> areas = new List<string>();
            if (grantedUserAreas.Count > 0)
            {
                foreach (var grantedUserArea in grantedUserAreas)
                {
                    ATCUserAreaEntity userArea = (ATCUserAreaEntity)grantedUserArea;
                    if (!string.IsNullOrWhiteSpace(userArea.AreaName))
                    {
                        areas.Add(userArea.AreaName);
                    }
                }
            }
            if (areas.Any())
            {
                areaFilter = string.Join("','", areas);
            }

            if (!string.IsNullOrWhiteSpace(areaFilter))
            {
                areaFilter = string.Format("'{0}'", areaFilter);

                txtDealerName.Filter = string.Format("({0}) AND (所属销售区域 IN ({1}))", defaultDealerFilter, areaFilter);
                txtDealerName.FormatQueryString = string.Format("({0}) AND (所属销售区域 IN ({1}))", defaultDealerFormatQueryString,
                    areaFilter);
            }
        }

        private void BindDealerAddress()
        {
            txtDealerAddress.Properties.Items.Clear();
            int dealerID = Convert.ToInt32(this.txtDealerName.SelectedValue);
            EntityCollection<BFIDealerAddressEntity> addresses = new EntityCollection<BFIDealerAddressEntity>();
            addresses.Fetch(BFIDealerAddressEntityFields.DealerID == dealerID & BFIDealerAddressEntityFields.DealerAddressType == "收货地址");
            foreach (var address in addresses)
            {
                txtDealerAddress.Properties.Items.Add(
                    (address as BFIDealerAddressEntity).DealerAddress);
            }
        }

        private void SaveDealerAddress()
        {
            int dealerID = Convert.ToInt32(this.txtDealerName.SelectedValue);
            string address = txtDealerAddress.Text.Trim();
            EntityCollection<BFIDealerAddressEntity> enterpriseAddresses = new EntityCollection<BFIDealerAddressEntity>();
            enterpriseAddresses.Fetch(BFIDealerAddressEntityFields.DealerID == dealerID & BFIDealerAddressEntityFields.DealerAddressType == "收货地址" & BFIDealerAddressEntityFields.DealerAddress == address);
            if (enterpriseAddresses.Count == 0)
            {
                BFIDealerAddressEntity addressEntity = new BFIDealerAddressEntity();
                addressEntity.DealerID = dealerID;
                addressEntity.DealerAddressType = "收货地址";
                addressEntity.DealerAddress = address;
                addressEntity.Save();
            }
        }

        private void btnFix_Click(object sender, EventArgs e)
        {
            if (DialogResult.OK != XtraMessageBox.Show(this, "确定冲红？不可更改。", "警告", MessageBoxButtons.OKCancel, MessageBoxIcon.Question))
            {
                return;
            }

            BUSBillEntity entity = this.ftPanel.GetEntity() as BUSBillEntity;

            this.CustomSetEntity(entity);
            if (this.m_id != null && this.m_id.Value > 0)
            {
                var billDetails = this.popupGrid.GetEntities();
                foreach (var item in billDetails)
                {
                    BUSBillDetailEntity billDetail = item as BUSBillDetailEntity;
                    BUSStoreDetailEntity storeDetail = new BUSStoreDetailEntity { ProductID = billDetail.ProductID, BatchNo = billDetail.BatchNo };

                    //更新库存
                    storeDetail.Fetch();
                    //storeDetail.LastStoreID = billDetail.BillID;
                    storeDetail.LastModifyDate = DateTime.Now;
                    storeDetail.LastModifyUserID = GlobalItem.g_CurrentUser.UserID;
                    if (storeDetail.IsNullField("Amount"))
                    {
                        throw new Exception(String.Format("ID号为{0}的产品没有批号为{1}库存信息。", billDetail.ProductID, billDetail.BatchNo));
                    }
                    storeDetail.Amount = storeDetail.Amount + billDetail.Amount;
                    storeDetail.Update();

                    billDetail.DeleteByCommonly();
                }
                entity.DeleteByCommonly();
            }
            this.DialogResult = System.Windows.Forms.DialogResult.OK;
            this.Close();
        }

        private bool TotalPrice()
        {
            for (int i = 0; i < this.popupGrid.PopupView.RowCount; i++)
            {
                object unitprice = this.popupGrid.PopupView.GetRowCellValue(i, "单价");
                object amount = this.popupGrid.PopupView.GetRowCellValue(i, "数量");
                object ttprice = this.popupGrid.PopupView.GetRowCellValue(i, "金额");

                if (unitprice == DBNull.Value || unitprice == null)
                {
                    break;
                }
                if (Convert.ToDecimal(unitprice) * Convert.ToDecimal(amount) != Convert.ToDecimal(ttprice))
                {
                    XtraMessageBox.Show(String.Format("第{0}行，产品的金额不正确，请确认。", (i + 1)), "提示", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                    return false;

                }
            }
            return true;
        }

        private void LoadubdList(int BillID)
        {
            ubdlist.Clear();
            string sql = @"SELECT DetailID,ProductID,BatchNo,Amount,UnitPrice,TotalPrice,TradePrice,RetailPrice,Reservation2 FROM dbo.BUS_BillDetail WHERE BillID = " + BillID;
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
                        double TradePrice = Convert.ToDouble(ds.Tables["Table"].Rows[i]["TradePrice"]);
                        double RetailPrice = Convert.ToDouble(ds.Tables["Table"].Rows[i]["RetailPrice"]);
                        int Reservation2 = Convert.ToInt32(ds.Tables["Table"].Rows[i]["Reservation2"]);
                        ubd.DetailID = DetailID;
                        ubd.ProductID = ProductID;
                        ubd.BatchNo = BatchNo;
                        ubd.Amount = Amount;
                        ubd.UnitPrice = UnitPrice;
                        ubd.TotalPrice = TotalPrice;
                        ubd.TradePrice = TradePrice;
                        ubd.RetailPrice = RetailPrice;
                        ubd.InStoreID = Reservation2;
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
                            string isPrint = popupGrid.PopupView.GetDataRow(i)["是否打印检报"].ToString();

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
                                svd.isPrint = isPrint;
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
                                svd.isPrint = isPrint;
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

        private void btnSave_Click(object sender, EventArgs e)
        {
            if (!this.TotalPrice()) return;
            _amountErrors = new List<string>();
            //using (TransactionScope tx = new TransactionScope())
            //{
            try
            {
                if (!this.ftPanel.ValidateIsNullFields()) return;
                SaveDealerAddress();
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
                            string newid = Guid.NewGuid().ToString();
                            string sql = string.Format(sqlString, newid, m_id.Value, changeUserName, alter);
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
                            //bool needUpdateStoreAmount = false;
                            List<EntityBase> children = this.popupGrid.GetEntities();

                            //if (!this.ValidateBatchNo())
                            //    return;
                            //if (!this.ValidateSaleAmount())
                            //    return; //验证库存和销售数量
                            if (!this.ValidateBatchDate())
                                return;
                            if (!ValidateUnitPrice())
                                return;

                            if (!this.Amount())
                                return;
                            if (!this.MonthAmount())
                                return;

                            BUSBillEntity bill = new BUSBillEntity { BillID = m_id.Value };
                            bill.Fetch();

                            CorrectStockAmount();

                            Guid billCreateUserId = bill.CreateUserID;
                            if (!bill.IsNullField("Reservation10"))
                            {
                                if (bill.BillStatusName == "已下单" && bill.Reservation10 == "反审批")
                                {
                                    entity.Reservation10 = "";
                                    entity.BillStatus = 2;
                                    entity.BillStatusName = "已审核";
                                }
                                if (bill.BillStatusName == "已下单" && bill.Reservation10 == "修改")
                                {
                                    entity.Reservation10 = "";
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


                            if (Settings.Default.IsNewStoreDetail)
                            {
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

                                    BUSProductSalePriceEntity priceEntity = new BUSProductSalePriceEntity();
                                    priceEntity.DealerID = entity.DealerID;
                                    priceEntity.SaleBillID = child.BillID;
                                    priceEntity.ProductID = child.ProductID;
                                    priceEntity.BatchNo = child.BatchNo;
                                    priceEntity.SalePrice = child.UnitPrice;
                                    priceEntity.CreateDate = DateTime.Now;
                                    priceEntity.CreateUserID = GlobalItem.g_CurrentUser.UserID;
                                    priceEntity.Save();
                                }

                                int employeeID = Convert.ToInt32(txtOperator.SelectedValue);
                                if (employeeID == 0)
                                {
                                    ATCUserEntity userEntity = new ATCUserEntity { UserID = billCreateUserId };
                                    userEntity.Fetch();
                                    int billCreateEmployeeId = userEntity.EmployeeID;
                                    BFIEmployeeEntity employee = new BFIEmployeeEntity
                                    {
                                        EmployeeID =
                                            billCreateEmployeeId
                                    };
                                    employee.Fetch();

                                    if (!employee.IsNullField("DepartmentID"))
                                    {
                                        departmentID = employee.DepartmentID;
                                    }
                                }
                                else
                                {
                                    BFIEmployeeEntity employee = new BFIEmployeeEntity { EmployeeID = employeeID };
                                    employee.Fetch();

                                    if (!employee.IsNullField("DepartmentID"))
                                    {
                                        departmentID = employee.DepartmentID;
                                    }
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
                        if (!Settings.Default.IsNewStoreDetail)
                        {
                            if (!this.ValidateBatchNo()) return;
                        }
                        if (!this.ValidateDealerRange()) return; //验证客户经营范围
                        if (!this.ValidateDealerQualification()) return; //验证客户的电子档案
                        //if (!this.ValidateSaleAmount()) return; //验证库存和销售数量
                        if (!ValidateUnitPrice()) return;
                        if (!this.ProductStyle()) return;//验证现金交易

                        if (!this.ValidateBatchDate()) return;
                        if (!this.ValidateValidDate()) return;
                        if (!this.ValidateLockStatus()) return;
                        //新添加，验证特殊产品数量不能超过
                        if (!this.Amount()) return;
                        if (!this.MonthAmount()) return;
                        if (!this.checkPersonRange()) return;//验证客户采购员的经营范围
                        if (!this.checkEmployeeRange()) return;//验证本企业业务员的经营范围

                        #region 新建

                        if (Settings.Default.IsUseDepartment)
                        {
                            int employeeId = GlobalItem.g_CurrentEmployee.EmployeeID;
                            ATCUserEntity user = GlobalItem.g_CurrentUser;

                            if (null != user)
                            {
                                Guid userID = user.UserID;
                                if (employeeId > 0)
                                {
                                    BFIEmployeeEntity employee = new BFIEmployeeEntity { EmployeeID = employeeId };
                                    employee.Fetch();

                                    if (!employee.IsNullField("DepartmentID"))
                                    {
                                        departmentID = employee.DepartmentID;
                                    }
                                }
                            }
                        }
                        else
                        {
                            //int employeeID = Convert.ToInt32(txtOperator.SelectedValue);
                            int employeeID = GlobalItem.g_CurrentEmployee.EmployeeID;
                            if (employeeID == 0)
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
                                BFIEmployeeEntity employee = new BFIEmployeeEntity { EmployeeID = employeeID };
                                employee.Fetch();

                                if (!employee.IsNullField("DepartmentID"))
                                {
                                    departmentID = employee.DepartmentID;
                                }
                            }
                        }
                        entity.IsBillIn = false; //出库订单
                        entity.BillTypeID = 1;
                        entity.BillTypeName = "销售出货";
                        entity.BillTypeSpell = "xsch";
                        entity.BillStatus = 1;
                        entity.BillStatusName = "已下单";

                        List<EntityBase> children = this.popupGrid.GetEntities();



                        if (!Settings.Default.IsNewStoreDetail)
                        {
                            //保存单据前检测库存是否足够出库

                            foreach (EntityBase childEntity in children)
                            {
                                BUSBillDetailEntity child = childEntity as BUSBillDetailEntity;
                                ValidateStoreDetails(child, departmentID);
                            }
                        }
                        else
                        {
                            //新库存
                            CheckStoreDetail(departmentID);
                        }


                        //只要有一条库存错误信息，就不能保存销售单
                        if (_amountErrors.Any())
                        {
                            string message = string.Join("\n", _amountErrors);
                            XtraMessageBox.Show(message, "销售数据错误", MessageBoxButtons.OK, MessageBoxIcon.Error);
                            return;
                        }

                        entity.BillDate = DateTime.Now;
                        entity.CreateDate = DateTime.Now;
                        entity.LastModifyDate = DateTime.Now;
                        entity.CreateUserID = GlobalItem.g_CurrentUser.UserID;
                        entity.LastModifyUserID = GlobalItem.g_CurrentUser.UserID;
                        entity.Save();

                        //查询出其ID
                        entity.Fetch();


                        if (!Settings.Default.IsNewStoreDetail)
                        {
                            List<string> errors = new List<string>();
                            foreach (EntityBase childEntity in children)
                            {
                                BUSBillDetailEntity child = childEntity as BUSBillDetailEntity;
                                child.BillID = entity.BillID;

                                ValidateStoreDetails(child, departmentID);
                                if (!_amountErrors.Any())
                                {
                                    //保存明细
                                    child.Save();

                                    //更新库存
                                    UpdateStoreDetail(child, departmentID);

                                    BUSProductSalePriceEntity priceEntity = new BUSProductSalePriceEntity();
                                    priceEntity.DealerID = entity.DealerID;
                                    priceEntity.SaleBillID = child.BillID;
                                    priceEntity.ProductID = child.ProductID;
                                    priceEntity.BatchNo = child.BatchNo;
                                    priceEntity.SalePrice = child.UnitPrice;
                                    priceEntity.CreateDate = DateTime.Now;
                                    priceEntity.CreateUserID = GlobalItem.g_CurrentUser.UserID;
                                    priceEntity.Save();
                                }
                                errors.AddRange(_amountErrors);
                                _amountErrors.Clear();
                            }
                            //提示业务库存错误
                            if (errors.Any())
                            {
                                string message = string.Join("\n", errors);
                                XtraMessageBox.Show(message, "销售数据错误", MessageBoxButtons.OK, MessageBoxIcon.Error);
                            }
                        }
                        else
                        {
                            InsertBillDetail(list, entity.BillID);
                            //新库存
                            if (!UpdateNewStoreDetail(entity.BillID, entity.BillCode))
                            {
                                CheckStoreDetail(departmentID);
                            }
                        }

                        //只要有一条库存错误信息，就不能保存销售单
                        if (_amountErrors.Any())
                        {
                            string message = string.Join("\n", _amountErrors);
                            XtraMessageBox.Show(message, "销售数据错误", MessageBoxButtons.OK, MessageBoxIcon.Error);
                            return;
                        }




                        #endregion

                        EntityCollection<ATCUserPageEntity> userPages = new EntityCollection<ATCUserPageEntity>();
                        PredicateExpression pe = new PredicateExpression();
                        pe.Add(ATCUserPageEntityFields.UserID == GlobalItem.g_CurrentUser.UserID);
                        pe.Add(ATCUserPageEntityFields.DocumentCode == "SaleBill");
                        DataTable data = userPages.FetchTable(pe);

                        if (data.Rows.Count > 0)
                        {
                            //按审批顺序排序
                            data.DefaultView.Sort = "ApprovalSort";
                            data = data.DefaultView.ToTable();

                            ATCApproveEntity approveEntity = new ATCApproveEntity();
                            approveEntity.InternalNo = "XSCH" + entity.BillCode.Substring(2);
                            approveEntity.DocumentCode = "SaleBill";
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
                                notification.Message = string.Format("{0} 于 {1} 申请产品销售（单号 {2}）。请您审批。", userName,
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
                        XtraMessageBox.Show("销售单号已存在。", "警告", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                        return;
                    }
                }

            }
            catch (Exception ex)
            {
                XtraMessageBox.Show(ex.Message, "错误", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                return;
            }
            //tx.Complete();
            this.DialogResult = DialogResult.OK;
            //}
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

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void delProduct(object id)
        {
            if (id != null && id != DBNull.Value)
            {
                this.popupGrid.ClearGrid(this.popupGrid.PopupView.FocusedRowHandle);
                _selectedProductIds.Remove((int)id);
                txtProductAmount.Text = _selectedProductIds.Distinct().Count().ToString();
                txtTotalPrice.Text = this.popupGrid.GetSummaryPrice().ToString();
            }
        }

        private void popupGrid_PopupClosed(object sender, DQS.Controls.CommonCode.PopupFormClosedArgs e)
        {
            string popupFormName = "";
            if (null != e.PopupRow)
            {
                var grid = (sender as PopupGrid);

                if (grid != null)
                {
                    if (null != grid.PopupView.FocusedColumn.Tag)
                    {
                        var column = grid.PopupView.FocusedColumn.Tag as OperationGridColumn;
                        popupFormName = column.PopupForm.Name;
                    }
                }
                if (popupFormName == "Product")
                {
                    if (Settings.Default.IsBillCategory)
                    {
                        if (null != e.PopupRow["StyleID"])
                        {

                            string style = e.PopupRow["StyleID"].ToString();
                            if (style != "0")
                            {
                                if (lblStyleID.Text == "")
                                {
                                    lblStyleID.Text = e.PopupRow["StyleID"].ToString();
                                    lblStyleName.Text = e.PopupRow["StyleName"].ToString();
                                }
                                else
                                {
                                    if (style != (lblStyleID.Text))
                                    {
                                        XtraMessageBox.Show(
                                                            "该产品为" + e.PopupRow["StyleName"].ToString() + "，该单据属于" +
                                                            lblStyleName.Text + "单据，不能混开，需要重新下单。点击确定后，请按Del键删除此产品。",
                                                            "系统提示",
                                                            MessageBoxButtons.OK,
                                                            MessageBoxIcon.Warning);
                                        e.PopupRow.Delete();
                                        e.Cancel = true;
                                        return;
                                    }
                                }
                            }
                        }
                    }

                    if (null != e.PopupRow["批发价"])
                    {
                        this.popupGrid.PopupView.SetFocusedRowCellValue("批发价", e.PopupRow["批发价"]);

                    }

                    if (null != e.PopupRow["零售价"])
                    {
                        this.popupGrid.PopupView.SetFocusedRowCellValue("零售价", e.PopupRow["零售价"]);
                    }

                    DataRow dealer = txtDealerName.EditData as DataRow;
                    if (null != dealer && !dealer.IsNull("单位ID"))
                    {
                        int dealerID = int.Parse(dealer["单位ID"].ToString());
                        int productID = int.Parse(e.PopupRow["产品ID"].ToString());
                        string batchNo = e.PopupRow["批号"].ToString();
                        string productCategory = e.PopupRow["产品类别"].ToString();

                        #region 新的价格计算规则

                        //1 - 根据产品获取价格配置
                        //2 - 根据选择价格表获取适合的价格版本
                        //3 - 根据价格表版本获取所有价格规则
                        //4 - 根据产品明细获取适合的唯一价格规则,得到价格计算公式
                        //5 - 根据价格计算公式计算单价
                        //6 - 设置单价
                        decimal finalPrice = 0;
                        //根据产品获取价格配置
                        EntityCollection<BFIProductPriceEntity> productPrices =
                            new EntityCollection<BFIProductPriceEntity>();
                        productPrices.Fetch(BFIProductPriceEntityFields.ProductID == productID);
                        List<BFIProductPriceEntity> basePrices =
                            productPrices.Cast<BFIProductPriceEntity>().AsQueryable().ToList();
                        //根据选择价格表获取适合的价格版本
                        int priceListId = Convert.ToInt32(cbxPrice.EditValue);
                        if (priceListId > 0)
                        {
                            //找到所选价格表的所有可用价格表版本
                            EntityCollection<BFIPriceListVersionEntity> priceVersionEntities =
                                new EntityCollection<BFIPriceListVersionEntity>();
                            priceVersionEntities.Fetch(BFIPriceListVersionEntityFields.PriceListID == priceListId
                                                       & BFIPriceListVersionEntityFields.Active == true);

                            if (priceVersionEntities.Count > 0)
                            {
                                var priceVersions =
                                    priceVersionEntities.Cast<BFIPriceListVersionEntity>().AsQueryable().ToList();
                                List<DateRange> versionRanges = (from v in priceVersions
                                                                 select new DateRange
                                                                 {
                                                                     DataItem = v,
                                                                     Start =
                                                                         v.IsNullField("StartDate")
                                                                             ? DateTime.MinValue
                                                                             : v.StartDate,
                                                                     End =
                                                                         v.IsNullField("EndDate")
                                                                             ? DateTime.MaxValue
                                                                             : v.EndDate
                                                                 })
                                    .OrderBy(p => p.Start)
                                    .ThenBy(p => p.End)
                                    .ToList();
                                //找有效的价格表版本 - 当前日期必须在价格表版本开始日期、结束日期范围内
                                var version =
                                    versionRanges.FirstOrDefault(
                                                                 p =>
                                                                 DateTime.Today >= p.Start && DateTime.Today <= p.End);
                                if (null != version)
                                {
                                    var priceVersion = version.DataItem as BFIPriceListVersionEntity;
                                    int priceVersionId = priceVersion.PriceListVersionID;
                                    //根据有效价格表版本找所有的价格规则
                                    EntityCollection<BFIPriceListItemEntity> priceRuleEntities =
                                        new EntityCollection<BFIPriceListItemEntity>();
                                    priceRuleEntities.Fetch(BFIPriceListItemEntityFields.PriceVersionID ==
                                                            priceVersionId);

                                    //如果价格版本设置了规则
                                    if (priceRuleEntities.Count > 0)
                                    {
                                        List<BFIPriceListItemEntity> priceRules =
                                            priceRuleEntities.Cast<BFIPriceListItemEntity>().AsQueryable().ToList();

                                        int minSequence = priceRules.Min(p => p.Sequence);

                                        int sequenceCount = priceRules.Count(p => p.Sequence == minSequence);
                                        BFIPriceListItemEntity rule = null;
                                        if (sequenceCount == 1) //最高优先级只有一条规则
                                        {
                                            rule = priceRules.First(p => p.Sequence == minSequence);
                                        }
                                        else //最高优先级有多条规则
                                        {
                                            //1 - 先按产品ID找匹配的价格规则
                                            var productPriceRules = priceRules
                                                .Where(p => p.Sequence == minSequence)
                                                .Where(p => !p.IsNullField("ProductID"))
                                                .Where(p => p.ProductID == productID)
                                                .ToList();
                                            if (productPriceRules.Count >= 1)
                                            {
                                                rule = productPriceRules.FirstOrDefault();
                                            }
                                            else
                                            {
                                                //2 - 没有设置产品ID的价格规则，按产品类型找价格规则
                                                var productCategoryPriceRules = priceRules
                                                    .Where(p => p.Sequence == minSequence)
                                                    .Where(p => !p.IsNullField("ProductCategory"))
                                                    .Where(p => p.ProductCategory == productCategory)
                                                    .ToList();
                                                if (productCategoryPriceRules.Count >= 1)
                                                {
                                                    rule = productCategoryPriceRules.FirstOrDefault();
                                                }
                                                else
                                                {
                                                    //3 - 没有设置产品ID和产品类型的价格规则，按优先级找未设置产品ID和产品类型的价格规则
                                                    var noSpecailPriceRules = priceRules
                                                        .Where(p => p.Sequence == minSequence)
                                                        .Where(p => p.IsNullField("ProductCategory"))
                                                        .Where(p => p.IsNullField("ProductID"))
                                                        .ToList();
                                                    rule = noSpecailPriceRules.FirstOrDefault();
                                                }
                                            }
                                        }

                                        if (null != rule)
                                        {
                                            int priceStyleId = rule.BasePriceCategoryID;
                                            string priceStyleName = rule.BasePriceCategoryName;

                                            double basePrice = 0;
                                            if (priceStyleId > 0)
                                            {
                                                var basePriceEntity =
                                                    basePrices.FirstOrDefault(p => p.PriceID == priceStyleId);
                                                if (null != basePriceEntity)
                                                {
                                                    basePrice = basePriceEntity.Price;
                                                }

                                            }
                                            else
                                            {
                                                if (priceStyleName == "上次进货价")
                                                {
                                                    //上次的采购单价
                                                    EntityCollection<BUSProductPurchasePriceEntity>
                                                        purchasePriceEntities =
                                                            new EntityCollection<BUSProductPurchasePriceEntity>();
                                                    purchasePriceEntities.Fetch(
                                                                                BUSProductPurchasePriceEntityFields
                                                                                    .DealerID ==
                                                                                dealerID &
                                                                                BUSProductPurchasePriceEntityFields
                                                                                    .ProductID == productID &
                                                                                BUSProductPurchasePriceEntityFields
                                                                                    .BatchNo ==
                                                                                batchNo);
                                                    Dictionary<int, double> prices = new Dictionary<int, double>();
                                                    foreach (var purchasePriceEntity in purchasePriceEntities)
                                                    {
                                                        var price = purchasePriceEntity as BUSProductPurchasePriceEntity;
                                                        prices.Add(price.ProductPurchasePriceID, price.PurchasePrice);
                                                    }

                                                    if (prices.Count > 0)
                                                    {
                                                        var purchasePrice =
                                                            prices.OrderByDescending(p => p.Key).FirstOrDefault();
                                                        basePrice = purchasePrice.Value;
                                                    }
                                                }
                                                else if (priceStyleName == "上次销售价")
                                                {
                                                    //上次的销售单价
                                                    EntityCollection<BUSProductSalePriceEntity> salePriceEntities =
                                                        new EntityCollection<BUSProductSalePriceEntity>();
                                                    salePriceEntities.Fetch(BUSProductSalePriceEntityFields.DealerID ==
                                                                            dealerID &
                                                                            BUSProductSalePriceEntityFields.ProductID ==
                                                                            productID// &
                                                        //BUSProductSalePriceEntityFields.BatchNo ==
                                                        // batchNo
                                                                            );
                                                    Dictionary<int, double> prices = new Dictionary<int, double>();
                                                    foreach (var salePriceEntity in salePriceEntities)
                                                    {
                                                        var price = salePriceEntity as BUSProductSalePriceEntity;
                                                        prices.Add(price.ProductSalePriceID, price.SalePrice);
                                                    }

                                                    if (prices.Count > 0)
                                                    {
                                                        var saleprice =
                                                            prices.OrderByDescending(p => p.Key).FirstOrDefault();
                                                        basePrice = saleprice.Value;
                                                    }
                                                }
                                            }
                                            //单价 = 基本价 * (1 + 折扣) + 附加费
                                            double discount = rule.PriceDiscount;
                                            double surcharge = rule.PriceSurcharge;
                                            double unitPrice = basePrice * (1 + discount) + surcharge;
                                            finalPrice = Math.Round((decimal)unitPrice,
                                                                    2,
                                                                    MidpointRounding.AwayFromZero);
                                        }
                                    }

                                }
                            }
                        }

                        this.popupGrid.PopupView.SetFocusedRowCellValue("单价", finalPrice);

                        #endregion
                    }

                    this.SetProductAmount(e);
                }
                else if (popupFormName == "Price1" || popupFormName == "Price2")
                {
                    if (null != e.PopupRow["批发价"])
                    {
                        this.popupGrid.PopupView.SetFocusedRowCellValue("批发价", e.PopupRow["批发价"]);

                    }

                    if (null != e.PopupRow["零售价"])
                    {
                        this.popupGrid.PopupView.SetFocusedRowCellValue("零售价", e.PopupRow["零售价"]);

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

            if (!entity.IsNullField("PickUpPerson"))
            {
                this.txtPickUpPerson.Text = entity.PickUpPerson;
            }

            if (!entity.IsNullField("Operator"))
            {
                this.txtOperator.Text = entity.Operator;
            }
            else
            {
                if (m_id == null)
                {
                    this.txtOperator.Text = GlobalItem.g_CurrentEmployee.EmployeeName;
                    this.txtOperator.SetMemberValue(GlobalItem.g_CurrentEmployee.EmployeeID);
                }
            }

            if (!entity.IsNullField("Reservation6"))
            {
                this.txtReservation6.Text = entity.Reservation6;
            }
            else
            {
                if (m_id == null)
                {
                    this.txtReservation6.Text = GlobalItem.g_CurrentEmployee.EmployeeName;
                }
            }

            if (!entity.IsNullField("DeliveryTypeID"))
            {
                this.cbxDeliveryType.SelectedValue = entity.DeliveryTypeID;
            }

            if (!entity.IsNullField("PaymentTypeID"))
            {
                this.cbxPaymentType.SelectedValue = entity.PaymentTypeID;
            }

            if (!entity.IsNullField("DealerAddress"))
            {
                this.txtDealerAddress.Text = entity.DealerAddress;
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

            if (!entity.IsNullField("SalePriceListID"))
            {
                cbxPrice.EditValue = entity.SalePriceListID;
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

                BFIDealerEntity dealer = new BFIDealerEntity { DealerID = entity.DealerID };
                dealer.Fetch();
                if (!dealer.IsNullField("BusinessPerson"))
                {
                    entity.BusinessPerson = dealer.BusinessPerson;
                }
                if (!dealer.IsNullField("BusinessPhone"))
                {
                    entity.BusinessPhone = dealer.BusinessPhone;
                }
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

            if (this.txtReservation6.Text.Trim() != "")
            {
                entity.Reservation6 = this.txtReservation6.Text.Trim();
            }

            if (this.txtPickUpPerson.Text.Trim() != "")
            {
                entity.PickUpPerson = this.txtPickUpPerson.Text.Trim();
                entity.PickUpPersonSpell = GlobalMethod.GetAlphabetic(entity.PickUpPerson);
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

            if (!string.IsNullOrWhiteSpace(txtDealerAddress.Text.Trim()))
            {
                entity.DealerAddress = txtDealerAddress.Text.Trim();
            }
            entity.BillStyle = this.rdgBillStyle.Properties.Items[rdgBillStyle.SelectedIndex].Value.ToString();

            entity.SalePriceListID = Convert.ToInt32(cbxPrice.EditValue);
        }

        private void txtDealerName_PopupClosing(object sender, EventArgs e)
        {
            if (this.txtDealerName.EditData != null)
            {
                BindDealerAddress();
                var dataRow = (this.txtDealerName.EditData as DataRow);
                if (null != dataRow)
                {
                    int dealerID = Convert.ToInt32(dataRow["单位ID"]);
                    BFIDealerEntity dealer = new BFIDealerEntity
                    {
                        DealerID = dealerID
                    };
                    dealer.Fetch();
                    if (dealer.IndustryStyle == "医疗机构")
                    {
                        this.layReservation11.Visibility = LayoutVisibility.Always;
                        this.layReservation12.Visibility = LayoutVisibility.Always;
                        this.layReservation13.Visibility = LayoutVisibility.Always;
                        this.layReservation14.Visibility = LayoutVisibility.Always;
                        this.layReservation15.Visibility = LayoutVisibility.Always;
                    }
                    if (!dealer.IsNullField("SalePriceListID"))
                    {
                        cbxPrice.EditValue = dealer.SalePriceListID;
                    }
                    this.txtDealerAddress.Text = dataRow["通讯地址"].ToString();
                    this.txtDealerCode.Text = dataRow["单位编号"].ToString();
                    popupGrid.Tag = dataRow["单位ID"].ToString() + "$" + dataRow["单位名称"].ToString();
                    BandSaleMan(dealerID);
                }
            }
            if (!this.ValidateDealerQualification()) return;
        }

        private void BandSaleMan(int dealerID)
        {
            string sql = "SELECT TOP 1 SalesmanID,SalesmanName,MobilePhone FROM dbo.BFI_Salesman WHERE DealerID = " + dealerID;
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

        private void popupGrid_BeforePopupFormShow(object sender, DQS.Controls.CommonCode.BeforePopupFormShowArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtOperator.Text))
            {
                XtraMessageBox.Show("请先选择业务员！", "提示", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                e.Cancel = true;
            }
            if (string.IsNullOrWhiteSpace(txtDealerName.Text))
            {
                XtraMessageBox.Show(string.Format("请先选择{0}！", layDealerName.CustomizationFormText), "提示", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                e.Cancel = true;
            }
            if (!this.ValidateDealerQualification())
            {
                e.Cancel = true;
            }
            else
            {
                if (e.ActiveOperationColumn.PopupForm != null)
                {
                    if (e.ActiveOperationColumn.PopupForm.Name == "Price1" || e.ActiveOperationColumn.PopupForm.Name == "Price2")
                    {
                        var dealerName = txtDealerName.Text.Trim();

                        object productName = this.popupGrid.PopupView.GetFocusedRowCellValue("产品名称");
                        if (productName != null && productName != DBNull.Value)
                        {
                            e.ActiveOperationColumn.PopupForm.Filter = string.Format("[往来单位] = '{0}' AND [产品名称] = '{1}'", dealerName, productName);
                        }
                    }

                    if (e.ActiveOperationColumn.PopupForm.Name == "Price3")
                    {
                        object priceID = this.popupGrid.PopupView.GetFocusedRowCellValue("产品ID");
                        if (priceID != null && priceID != DBNull.Value)
                        {
                            e.ActiveOperationColumn.PopupForm.Filter = "[产品ID] = " + priceID;
                        }
                    }

                    if (e.ActiveOperationColumn.PopupForm.Name == "ProductBatch")
                    {
                        object productID = this.popupGrid.PopupView.GetFocusedRowCellValue("产品ID");
                        if (productID != null && productID != DBNull.Value)
                        {
                            //选择完产品才可选择批号
                            e.ActiveOperationColumn.PopupForm.Filter = String.Format("[产品ID] = {0}", productID);
                        }
                        else
                        {
                            e.Cancel = true;
                        }
                    }
                    //新逻辑 - 按所选择业务员对应授权产品进行产品过滤
                    if (e.ActiveOperationColumn.PopupForm.Name == "Product")
                    {
                        //2015-05-04:lnj
                        //涵更要求按当前账号所属部门过滤产品
                        if (Settings.Default.IsUseDepartment)
                        {
                            int employeeId = GlobalItem.g_CurrentEmployee.EmployeeID;
                            ATCUserEntity user = GlobalItem.g_CurrentUser;

                            if (null != user)
                            {
                                Guid userID = user.UserID;
                                int departmentID = 0;
                                if (employeeId > 0)
                                {
                                    BFIEmployeeEntity employee = new BFIEmployeeEntity { EmployeeID = employeeId };
                                    employee.Fetch();

                                    if (!employee.IsNullField("DepartmentID"))
                                    {
                                        departmentID = employee.DepartmentID;
                                    }
                                }
                                EntityCollection<ATCUserProductEntity> userProducts =
                                    new EntityCollection<ATCUserProductEntity>();
                                userProducts.Fetch(ATCUserProductEntityFields.UserID == userID);

                                if (userProducts.Count > 0)
                                {
                                    e.ActiveOperationColumn.PopupForm.Filter =
                                        string.Format("[所属部门ID]={0} AND EXISTS (SELECT * FROM ATC_UserProduct WHERE [产品ID]=ProductID AND UserID='{1}')", departmentID, userID);
                                }
                                else
                                {
                                    e.ActiveOperationColumn.PopupForm.Filter =
                                        string.Format("[所属部门ID]={0}", departmentID);
                                }
                            }
                        }
                        else
                        {
                            int employeeId = Convert.ToInt32(txtOperator.SelectedValue);
                            EntityCollection<ATCUserEntity> users = new EntityCollection<ATCUserEntity>();
                            users.Fetch(ATCUserEntityFields.EmployeeID == employeeId);
                            ATCUserEntity user = users.Cast<ATCUserEntity>().FirstOrDefault();

                            if (employeeId == 0)
                            {
                                user = GlobalItem.g_CurrentUser;
                            }
                            if (null != user)
                            {
                                Guid userID = user.UserID;
                                int departmentID = 0;
                                if (employeeId > 0)
                                {
                                    BFIEmployeeEntity employee = new BFIEmployeeEntity { EmployeeID = employeeId };
                                    employee.Fetch();

                                    if (!employee.IsNullField("DepartmentID"))
                                    {
                                        departmentID = employee.DepartmentID;
                                    }
                                }
                                EntityCollection<ATCUserProductEntity> userProducts =
                                    new EntityCollection<ATCUserProductEntity>();
                                userProducts.Fetch(ATCUserProductEntityFields.UserID == userID);

                                if (userProducts.Count > 0)
                                {
                                    e.ActiveOperationColumn.PopupForm.Filter =
                                        string.Format("[所属部门ID]={0} AND EXISTS (SELECT * FROM ATC_UserProduct WHERE [产品ID]=ProductID AND UserID='{1}')", departmentID, userID);
                                }
                                else
                                {
                                    e.ActiveOperationColumn.PopupForm.Filter =
                                        string.Format("[所属部门ID]={0}", departmentID);
                                }
                            }
                        }
                    }
                }
            }
        }

        //验证同一产品不可出现相同批号
        private bool ValidateBatchNo()
        {
            for (int i = 0; i < this.popupGrid.PopupView.RowCount; i++)
            {
                object amount = this.popupGrid.PopupView.GetRowCellValue(i, "数量");
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
                    if (Convert.ToDateTime(validateDate) <= Convert.ToDateTime(produceDate))
                    {
                        XtraMessageBox.Show(String.Format("第{0}行，产品的有效期至必须大于生产日期。", (i + 1)), "提示", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                        return false;

                    }
                }
            }
            return true;
        }

        //验证价格
        private bool ValidateUnitPrice()
        {
            for (int i = 0; i < this.popupGrid.PopupView.RowCount; i++)
            {
                object unitPrice = this.popupGrid.PopupView.GetRowCellValue(i, "单价");
                object purchasePrice = this.popupGrid.PopupView.GetRowCellValue(i, "进货价");
                object tradePrice = this.popupGrid.PopupView.GetRowCellValue(i, "批发价");

                if (unitPrice != null && unitPrice != DBNull.Value
                    && purchasePrice != null && purchasePrice != DBNull.Value
                    && tradePrice != null && tradePrice != DBNull.Value)
                {
                    if (Settings.Default.JudgementSaleBillPrice)
                    {
                        if (Convert.ToDecimal(unitPrice) < Convert.ToDecimal(purchasePrice)
                            || (Convert.ToDecimal(tradePrice) > 0 && Convert.ToDecimal(unitPrice) > Convert.ToDecimal(tradePrice)))
                        {
                            var dialogResult = XtraMessageBox.Show(String.Format("第{0}行，产品的单价不能小于进货价，不能高于批发价。是否提交？", (i + 1)), "提示", MessageBoxButtons.YesNo, MessageBoxIcon.Exclamation);
                            return dialogResult == DialogResult.Yes;

                        }
                    }
                    else
                    {
                        if (Convert.ToDecimal(unitPrice) < Convert.ToDecimal(purchasePrice))
                        {
                            var dialogResult = XtraMessageBox.Show(String.Format("第{0}行，产品的单价不能小于进货价！", (i + 1)), "提示", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                            return dialogResult == DialogResult.No;
                        }
                        if (Convert.ToDecimal(unitPrice) == Convert.ToDecimal(purchasePrice))
                        {
                            var dialogResult = XtraMessageBox.Show(String.Format("第{0}行，产品的单价等于进货价，是否开单！", (i + 1)), "提示", MessageBoxButtons.YesNo, MessageBoxIcon.Exclamation);
                            return dialogResult == DialogResult.Yes;
                        }
                        if (Convert.ToDecimal(tradePrice) > 0 && Convert.ToDecimal(unitPrice) > Convert.ToDecimal(tradePrice))
                        {
                            var dialogResult = XtraMessageBox.Show(String.Format("第{0}行，不能高于批发价。是否提交？", (i + 1)), "提示", MessageBoxButtons.YesNo, MessageBoxIcon.Exclamation);
                            return dialogResult == DialogResult.Yes;
                        }
                    }
                }
            }
            return true;
        }

        private bool ValidateSaleAmount()
        {
            int rowCount = this.popupGrid.PopupView.RowCount;
            for (int i = 0; i < rowCount; i++)
            {
                object totalAmout = this.popupGrid.PopupView.GetRowCellValue(i, "库存数量");
                if (totalAmout != null && totalAmout != DBNull.Value)
                {
                    object saleAmount = this.popupGrid.PopupView.GetRowCellValue(i, "数量");
                    if (saleAmount != null && saleAmount != DBNull.Value)
                    {
                        if (Convert.ToInt32(saleAmount) > Convert.ToInt32(totalAmout))
                        {
                            XtraMessageBox.Show(String.Format("表格中第{0}行产品的销售数量不能大于库存数量。", (i + 1)), "系统提示", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            return false;
                        }
                    }
                }
            }
            return true;
        }

        /// <summary>
        /// 验证客户的经营范围
        /// </summary>
        /// <returns></returns>
        private bool ValidateDealerRange()
        {
            //获取客户的经营范围
            if (this.txtDealerName.SelectedValue != null)
            {
                int dealerID = Convert.ToInt32(this.txtDealerName.SelectedValue);

                BFIDealerEntity dealer = new BFIDealerEntity { DealerID = dealerID };
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
                            if (!productStyles.Any())
                            {
                                return true;
                            }
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
                                             String.Format("表格中第{0}行产品的类别超出“{1}”的诊疗范围，无法生成订单，请修改！", (i + 1),
                                                 this.txtDealerName.Text), "系统提示", MessageBoxButtons.OK,
                                             MessageBoxIcon.Information);
                                        return false;
                                    }
                                }
                            }
                            return true;
                        }
                        else
                        {
                            #region 河北版暂不检测
                            //XtraMessageBox.Show(
                            //                String.Format("“{0}”的诊疗范围未设置对应产品类别，无法生成订单，请设置其诊疗范围对应产品类别！",
                            //                this.txtDealerName.Text), "系统提示", MessageBoxButtons.OK,
                            //                MessageBoxIcon.Information); 
                            //return false;
                            return true;
                            #endregion
                        }
                    }
                    else
                    {
                        #region 河北版暂不检测
                        return true;
                        XtraMessageBox.Show(
                                            String.Format("“{0}”未设置诊疗范围，无法生成订单，请设置其经营或诊疗范围！",
                                                this.txtDealerName.Text), "系统提示", MessageBoxButtons.OK,
                                            MessageBoxIcon.Information);
                        #endregion
                    }
                    return false;
                }

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
                                XtraMessageBox.Show(String.Format("表格中第{0}行产品的类别超出客户“{1}”的经营范围，无法生成订单，请修改！", (i + 1), this.txtDealerName.Text), "系统提示", MessageBoxButtons.OK, MessageBoxIcon.Information);
                                return false;
                            }
                        }
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
        /// 验证产品中是否有含黄麻碱的产品
        /// </summary>
        /// <returns></returns>
        private bool ProductStyle()
        {

            int rowCount = this.popupGrid.PopupView.RowCount;
            for (int i = 0; i < rowCount; i++)
            {
                object productstyle = this.popupGrid.PopupView.GetRowCellValue(i, "产品类别");

                if (productstyle != null && productstyle != DBNull.Value)
                {
                    if (productstyle.ToString() == "含黄麻碱" || productstyle.ToString() == "含可卡因")
                    {
                        if (this.cbxPaymentType.Text.Trim() == "现金")
                        {
                            XtraMessageBox.Show(String.Format("表格中第{0}行的产品是" + productstyle.ToString() + "产品，不能使用现金交易，无法生成订单，请修改！", (i + 1)), "系统提示", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            return false;
                        }
                    }
                }
            }
            return true;
        }

        /// <summary>
        /// 验证客户的电子档案
        /// </summary>
        /// <returns></returns>
        private bool ValidateDealerQualification()
        {
            //获取客户的过期证书
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
                    XtraMessageBox.Show(String.Format("客户的{0}电子档案已过期，无法生成订单，请修改！", (qualifications[0] as AllQualificationView).档案名称), "系统提示", MessageBoxButtons.OK, MessageBoxIcon.Information);
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
        /// 验证产品效期，已过期产品不能开单
        /// </summary>
        /// <returns></returns>
        private bool ValidateValidDate()
        {
            int rowCount = this.popupGrid.PopupView.RowCount;
            for (int i = 0; i < rowCount; i++)
            {
                object valid = this.popupGrid.PopupView.GetRowCellValue(i, "过期状态");
                if (valid != null && valid != DBNull.Value)
                {
                    if (valid.ToString() == "已过期")
                    {
                        XtraMessageBox.Show(String.Format("表格中第{0}行产品的已过期。", (i + 1)), "系统提示", MessageBoxButtons.OK,
                            MessageBoxIcon.Information);
                        return false;
                    }
                }
            }
            return true;
        }

        /// <summary>
        /// 执行sql查询语句，并将结果以DataTable的形式返回
        /// </summary>
        /// <param name="sql">sql查询语句</param>
        /// <param name="conString">连接字符串</param>
        /// <returns>sql查询语句结果</returns>
        public static DataTable GetDataBySQL(string sql, string conString)
        {
            SqlConnection cn = new SqlConnection(conString);
            if (cn.State != ConnectionState.Open)
                cn.Open();
            SqlCommand cmd = new SqlCommand(sql, cn);
            SqlDataAdapter sdap = new SqlDataAdapter();
            sdap.SelectCommand = cmd;
            DataTable dt = new DataTable();
            sdap.Fill(dt);
            cn.Close();
            return dt;
        }


        /// <summary>
        /// 验证产品当天限购数量
        /// </summary>
        /// <returns></returns>
        private bool Amount()
        {
            int rowCount = this.popupGrid.PopupView.RowCount;
            int specialNum = 0;
            string sql = "SELECT SUM(bd.Amount) FROM dbo.BUS_BillDetail bd INNER JOIN dbo.BUS_Bill b ON bd.BillID = b.BillID WHERE bd.ProductID = {0} AND b.DealerID = {1} AND (CONVERT(NVARCHAR(100),b.BillDate,23) = CONVERT(NVARCHAR(100),GETDATE(),23)) AND b.BillStatusName <> '已删除'";

            int dealerID = Convert.ToInt32(this.txtDealerName.SelectedValue);

            for (int i = 0; i < rowCount; i++)
            {
                object productID = this.popupGrid.PopupView.GetRowCellValue(i, "产品ID");
                if (productID != null && productID != DBNull.Value)
                {
                    int productNum = (int)this.popupGrid.PopupView.GetRowCellValue(i, "数量");
                    string batch = this.popupGrid.PopupView.GetRowCellValue(i, "批号").ToString();
                    int SpecialProductNum = (int)this.popupGrid.PopupView.GetRowCellValue(i, "当天限购数量");
                    if (SpecialProductNum > 0)
                    {
                        for (int j = 0; j < this.popupGrid.PopupView.RowCount; j++)
                        {
                            object productID2 = this.popupGrid.PopupView.GetRowCellValue(j, "产品ID");
                            if (productID2 != null && productID2 != DBNull.Value)
                            {
                                int productNum2 = (int)this.popupGrid.PopupView.GetRowCellValue(j, "数量");
                                string batch2 = this.popupGrid.PopupView.GetRowCellValue(j, "批号").ToString();
                                if ((int)productID == (int)productID2)
                                {
                                    if (batch != batch2)
                                    {
                                        productNum += productNum2;
                                    }
                                }
                            }
                        }
                        using (SqlConnection conn = new SqlConnection(GlobalItem.g_DbConnectStrings))
                        {
                            conn.Open(); //连接数据库
                            //必须为SqlCommand指定数据库连接和登记的事务
                            SqlCommand cmd = new SqlCommand(sql, conn);
                            try
                            {
                                cmd.CommandText = string.Format(sql, (int)productID, dealerID);
                                object special = cmd.ExecuteScalar();
                                if (special != null && special != DBNull.Value)
                                {
                                    specialNum = (int)special;
                                }
                                else
                                {
                                    specialNum = 0;
                                }

                                if (specialNum + productNum > SpecialProductNum)
                                {
                                    string productName = this.popupGrid.PopupView.GetRowCellValue(i, "产品名称").ToString();
                                    XtraMessageBox.Show(String.Format("表格中产品：" + productName + "，客户" + this.txtDealerName.Text + "，今天可以开：" + SpecialProductNum + "，已开" + specialNum + "，还可以采购数量为：" + (SpecialProductNum - specialNum) + "，列表中数量总和：" + productNum), "系统提示", MessageBoxButtons.OK, MessageBoxIcon.Information);
                                    return false;
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
                    }
                }
            }
            return true;
        }

        /// <summary>
        /// 验证产品当月限购数量
        /// </summary>
        /// <returns></returns>
        private bool MonthAmount()
        {
            int rowCount = this.popupGrid.PopupView.RowCount;
            int specialNum = 0;
            string sql = "SELECT SUM(bd.Amount) FROM dbo.BUS_BillDetail bd INNER JOIN dbo.BUS_Bill b ON bd.BillID = b.BillID WHERE bd.ProductID = {0} AND b.DealerID = {1} AND (CONVERT(NVARCHAR(7),b.BillDate,23) = CONVERT(NVARCHAR(7),GETDATE(),23)) AND b.BillStatusName <> '已删除' AND (b.Reservation10 = '' OR b.Reservation10 = NULL)";

            int dealerID = Convert.ToInt32(this.txtDealerName.SelectedValue);

            for (int i = 0; i < rowCount; i++)
            {
                object productID = this.popupGrid.PopupView.GetRowCellValue(i, "产品ID");
                if (productID != null && productID != DBNull.Value)
                {
                    int productNum = (int)this.popupGrid.PopupView.GetRowCellValue(i, "数量");
                    string batch = this.popupGrid.PopupView.GetRowCellValue(i, "批号").ToString();
                    int SpecialProductNum = (int)this.popupGrid.PopupView.GetRowCellValue(i, "当月限购数量");
                    if (SpecialProductNum > 0)
                    {
                        for (int j = 0; j < this.popupGrid.PopupView.RowCount; j++)
                        {
                            object productID2 = this.popupGrid.PopupView.GetRowCellValue(j, "产品ID");
                            if (productID2 != null && productID2 != DBNull.Value)
                            {
                                int productNum2 = (int)this.popupGrid.PopupView.GetRowCellValue(j, "数量");
                                string batch2 = this.popupGrid.PopupView.GetRowCellValue(j, "批号").ToString();
                                if ((int)productID == (int)productID2)
                                {
                                    if (batch != batch2)
                                    {
                                        productNum += productNum2;
                                    }
                                }
                            }
                        }
                        using (SqlConnection conn = new SqlConnection(GlobalItem.g_DbConnectStrings))
                        {
                            conn.Open(); //连接数据库
                            //必须为SqlCommand指定数据库连接和登记的事务
                            SqlCommand cmd = new SqlCommand(sql, conn);
                            try
                            {
                                cmd.CommandText = string.Format(sql, (int)productID, dealerID);
                                object special = cmd.ExecuteScalar();
                                if (special != null && special != DBNull.Value)
                                {
                                    specialNum = (int)special;
                                }
                                else
                                {
                                    specialNum = 0;
                                }

                                if (specialNum + productNum > SpecialProductNum)
                                {
                                    string productName = this.popupGrid.PopupView.GetRowCellValue(i, "产品名称").ToString();
                                    XtraMessageBox.Show(String.Format("表格中产品：" + productName + "，客户" + this.txtDealerName.Text + "，当前月可以开：" + SpecialProductNum + "，已开" + specialNum + "，还可以采购数量为：" + (SpecialProductNum - specialNum) + "，列表中数量总和：" + productNum), "系统提示", MessageBoxButtons.OK, MessageBoxIcon.Information);
                                    return false;
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
                object id = this.popupGrid.PopupView.GetFocusedRowCellValue("产品ID");
                if (id != null && id != DBNull.Value)
                {
                    DialogResult dr = XtraMessageBox.Show("确定要删除此行数据吗？", "提示", MessageBoxButtons.OKCancel, MessageBoxIcon.Question);
                    if (dr == DialogResult.OK)
                    {
                        this.popupGrid.ClearGrid(this.popupGrid.PopupView.FocusedRowHandle);
                        _selectedProductIds.Remove((int)id);
                        txtProductAmount.Text = _selectedProductIds.Distinct().Count().ToString();
                        txtTotalPrice.Text = this.popupGrid.GetSummaryPrice().ToString();
                    }
                }
            }
        }

        private void txtBusinessPerson_PopupClosing(object sender, EventArgs e)
        {
            if (this.txtBusinessPerson.EditData != null)
            {
                this.txtBusinessPerson.Tag = (this.txtBusinessPerson.EditData as DataRow)["人员ID"].ToString();
                this.txtBusinessPhone.Text = (this.txtBusinessPerson.EditData as DataRow)["手机"].ToString();
            }
        }

        private void txtBusinessPerson_BeforePopupShow(object sender, DQS.Controls.CommonCode.BeforePopupShowArgs e)
        {
            if (this.txtDealerName.SelectedValue != null)
            {
                this.txtBusinessPerson.Filter += String.Format(" AND 所属单位 = '{0}'", this.txtDealerName.Text.Trim());
            }
        }

        private void txtPickUpPerson_BeforePopupShow(object sender, DQS.Controls.CommonCode.BeforePopupShowArgs e)
        {
            if (this.txtDealerName.SelectedValue != null)
            {
                this.txtPickUpPerson.Filter += String.Format(" AND 所属单位 = '{0}'", this.txtDealerName.Text.Trim());
            }
        }
        private void SetProductAmount(PopupFormClosedArgs e)
        {
            var productID = int.Parse(e.PopupRow.ItemArray[0].ToString());
            _selectedProductIds.Add(productID);
            txtProductAmount.Text = _selectedProductIds.Distinct().Count().ToString();
        }
        private void SetProductAmount(bool upDown)
        {
            List<int> details = new List<int>();
            for (int i = 0; i < this.popupGrid.PopupView.RowCount; i++)
            {
                string dataInCell = ((DataRowView)popupGrid.MainView.GetRow(i)).Row.ItemArray[0].ToString();
                if (!string.IsNullOrEmpty(dataInCell))
                {
                    int productID = int.Parse(dataInCell);
                    _selectedProductIds.Add(productID);
                }
            }
            this.txtProductAmount.Text = _selectedProductIds.Distinct().Count().ToString();
        }

        //检测出库库存
        public void ValidateStoreDetails(BUSBillDetailEntity billDetail, int storeDetailBelongDepartmentId)
        {
            BFIProductEntity productEntity = new BFIProductEntity
            {
                ProductID = billDetail.ProductID
            };
            productEntity.Fetch();
            EntityCollection<BUSStoreDetailEntity> storeDetails = new EntityCollection<BUSStoreDetailEntity>();
            storeDetails.Fetch(BUSStoreDetailEntityFields.ProductID == billDetail.ProductID
                & BUSStoreDetailEntityFields.BatchNo == billDetail.BatchNo
                & BUSStoreDetailEntityFields.DepartmentID == storeDetailBelongDepartmentId);
            if (storeDetails.Count <= 0)
            {
                _amountErrors.Add(String.Format("{0} 没有批号为 {1} 库存信息。", productEntity.ProductName, billDetail.BatchNo));
            }
            BUSStoreDetailEntity storeDetail = new BUSStoreDetailEntity
            {
                StoreDetailID = (storeDetails[0] as BUSStoreDetailEntity).StoreDetailID
            };
            //更新库存
            storeDetail.Fetch();
            if (storeDetail.IsNullField("Amount"))
            {
                _amountErrors.Add(String.Format("{0} 没有批号为 {1} 库存信息。", productEntity.ProductName, billDetail.BatchNo));
            }
            storeDetail.Amount = storeDetail.Amount - billDetail.Amount;
            if (storeDetail.Amount < 0)
            {
                _amountErrors.Add(String.Format("{0} 库存不足。", productEntity.ProductName));
            }
        }
        //更新库存
        public static void UpdateStoreDetail(BUSBillDetailEntity billDetail, int storeDetailBelongDepartmentId)
        {
            EntityCollection<BUSStoreDetailEntity> storeDetails = new EntityCollection<BUSStoreDetailEntity>();
            storeDetails.Fetch(BUSStoreDetailEntityFields.ProductID == billDetail.ProductID
                & BUSStoreDetailEntityFields.BatchNo == billDetail.BatchNo
                & BUSStoreDetailEntityFields.DepartmentID == storeDetailBelongDepartmentId);
            if (storeDetails.Count <= 0)
            {
                throw new Exception(String.Format("ID号为{0}的产品没有批号为{1}库存信息。", billDetail.ProductID, billDetail.BatchNo));
            }
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
            FrmSingleSaleChangeHistory doc = new FrmSingleSaleChangeHistory();
            doc.Tag = m_id.Value;
            doc.Show(this);
        }

        private void txtOperator_PopupClosing(object sender, EventArgs e)
        {
            if (this.txtOperator.EditData != null)
            {
                txtOperator.SetMemberValue((this.txtOperator.EditData as DataRow)["员工ID"].ToString());
            }
            if (txtOperator.Text.Trim() != txtOperator.Tag.ToString())
            {
                popupGrid.ClearGrid();
            }
            SendKeys.Send("{TAB}");
        }

        private void txtOperator_BeforePopupShow(object sender, BeforePopupShowArgs e)
        {
            txtOperator.Tag = txtOperator.Text.Trim();
        }

        protected override bool ProcessCmdKey(ref Message msg, Keys keyData)
        {
            if (keyData == Keys.Enter)
            {
                if ((ActiveControl is LayoutControl)
                    && (((LayoutControl)ActiveControl).FocusHelper.SelectedComponent as LayoutControlItem).Control is TextBoxEnterPopupEx)
                {
                    return base.ProcessCmdKey(ref msg, keyData);
                }

                if ((!(ActiveControl is Button))
                && (!(ActiveControl is BaseButton))
                && (!(ActiveControl is GridControl)))
                {
                    if (popupGrid.PopupView.FocusedColumn.FieldName == "数量")
                    {
                        popupGrid.PopupView.FocusedRowHandle = popupGrid.PopupView.FocusedRowHandle + 1;
                        popupGrid.PopupView.FocusedColumn = popupGrid.PopupView.Columns["产品名称"];
                    }
                    else
                    {
                        if (popupGrid.PopupView.FocusedColumn.FieldName != "批发价" &&
                            popupGrid.PopupView.FocusedColumn.FieldName != "零售价")
                        {
                            SendKeys.Send("{TAB}");
                        }
                        else
                        {
                            return base.ProcessCmdKey(ref msg, keyData);
                        }
                    }
                    return true;
                }
            }
            return base.ProcessCmdKey(ref msg, keyData);

        }

        private void txtDealerName_BeforePopupShow(object sender, BeforePopupShowArgs e)
        {

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

        private void btnSaveAndOut_Click(object sender, EventArgs e)
        {
            if (!this.TotalPrice()) return;
            _amountErrors = new List<string>();
            try
            {
                if (!this.ftPanel.ValidateIsNullFields()) return;
                SaveDealerAddress();
                BUSBillEntity entity = this.ftPanel.GetEntity() as BUSBillEntity;

                this.CustomSetEntity(entity);

                int departmentID = 0;

                if (entity.IsNew())
                {
                    if (!Settings.Default.IsNewStoreDetail)
                    {
                        if (!this.ValidateBatchNo()) return;
                    }
                    if (!this.ValidateDealerRange()) return; //验证客户经营范围
                    if (!this.ValidateDealerQualification()) return; //验证客户的电子档案
                    //if (!this.ValidateSaleAmount()) return; //验证库存和销售数量
                    if (!ValidateUnitPrice()) return;
                    if (!this.ProductStyle()) return;//验证现金交易

                    if (!this.ValidateBatchDate()) return;
                    if (!this.ValidateValidDate()) return;
                    if (!this.ValidateLockStatus()) return;
                    //新添加，验证特殊产品数量不能超过
                    if (!this.Amount()) return;
                    if (!this.MonthAmount()) return;

                    #region 新建

                    if (Settings.Default.IsUseDepartment)
                    {
                        int employeeId = GlobalItem.g_CurrentEmployee.EmployeeID;
                        ATCUserEntity user = GlobalItem.g_CurrentUser;

                        if (null != user)
                        {
                            Guid userID = user.UserID;
                            if (employeeId > 0)
                            {
                                BFIEmployeeEntity employee = new BFIEmployeeEntity { EmployeeID = employeeId };
                                employee.Fetch();

                                if (!employee.IsNullField("DepartmentID"))
                                {
                                    departmentID = employee.DepartmentID;
                                }
                            }
                        }
                    }
                    else
                    {
                        //int employeeID = Convert.ToInt32(txtOperator.SelectedValue);
                        int employeeID = GlobalItem.g_CurrentEmployee.EmployeeID;
                        if (employeeID == 0)
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
                            BFIEmployeeEntity employee = new BFIEmployeeEntity { EmployeeID = employeeID };
                            employee.Fetch();

                            if (!employee.IsNullField("DepartmentID"))
                            {
                                departmentID = employee.DepartmentID;
                            }
                        }
                    }
                    entity.IsBillIn = false; //出库订单
                    entity.BillTypeID = 1;
                    entity.BillTypeName = "销售出货";
                    entity.BillTypeSpell = "xsch";
                    entity.BillStatus = 1;
                    entity.BillStatusName = "已下单";

                    List<EntityBase> children = this.popupGrid.GetEntities();


                    if (!Settings.Default.IsNewStoreDetail)
                    {
                        //保存单据前检测库存是否足够出库

                        foreach (EntityBase childEntity in children)
                        {
                            BUSBillDetailEntity child = childEntity as BUSBillDetailEntity;
                            ValidateStoreDetails(child, departmentID);
                        }
                    }
                    else
                    {
                        //新库存
                        CheckStoreDetail(departmentID);
                    }


                    //只要有一条库存错误信息，就不能保存销售单
                    if (_amountErrors.Any())
                    {
                        string message = string.Join("\n", _amountErrors);
                        XtraMessageBox.Show(message, "销售数据错误", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        return;
                    }


                    entity.BillDate = DateTime.Now;
                    entity.CreateDate = DateTime.Now;
                    entity.LastModifyDate = DateTime.Now;
                    entity.CreateUserID = GlobalItem.g_CurrentUser.UserID;
                    entity.LastModifyUserID = GlobalItem.g_CurrentUser.UserID;
                    entity.Save();

                    //查询出其ID
                    entity.Fetch();

                    if (!Settings.Default.IsNewStoreDetail)
                    {
                        List<string> errors = new List<string>();
                        foreach (EntityBase childEntity in children)
                        {
                            BUSBillDetailEntity child = childEntity as BUSBillDetailEntity;
                            child.BillID = entity.BillID;
                            ValidateStoreDetails(child, departmentID);
                            if (!_amountErrors.Any())
                            {
                                //保存明细
                                child.Save();

                                UpdateStoreDetail(child, departmentID);

                                BUSProductSalePriceEntity priceEntity = new BUSProductSalePriceEntity();
                                priceEntity.DealerID = entity.DealerID;
                                priceEntity.SaleBillID = child.BillID;
                                priceEntity.ProductID = child.ProductID;
                                priceEntity.BatchNo = child.BatchNo;
                                priceEntity.SalePrice = child.UnitPrice;
                                priceEntity.CreateDate = DateTime.Now;
                                priceEntity.CreateUserID = GlobalItem.g_CurrentUser.UserID;
                                priceEntity.Save();
                            }
                            errors.AddRange(_amountErrors);
                            _amountErrors.Clear();
                        }
                        //提示业务库存错误
                        if (errors.Any())
                        {
                            string message = string.Join("\n", errors);
                            XtraMessageBox.Show(message, "销售数据错误", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }
                    }
                    else
                    {
                        InsertBillDetail(list, entity.BillID);
                        //新库存
                        if (!UpdateNewStoreDetail(entity.BillID, entity.BillCode))
                        {
                            CheckStoreDetail(departmentID);
                        }
                    }

                    //只要有一条库存错误信息，就不能保存销售单
                    if (_amountErrors.Any())
                    {
                        string message = string.Join("\n", _amountErrors);
                        XtraMessageBox.Show(message, "销售数据错误", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        return;
                    }

                    #endregion

                    EntityCollection<ATCUserPageEntity> userPages = new EntityCollection<ATCUserPageEntity>();
                    PredicateExpression pe = new PredicateExpression();
                    pe.Add(ATCUserPageEntityFields.UserID == GlobalItem.g_CurrentUser.UserID);
                    pe.Add(ATCUserPageEntityFields.DocumentCode == "SaleBill");
                    DataTable data = userPages.FetchTable(pe);

                    if (data.Rows.Count > 0)
                    {
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
                    XtraMessageBox.Show("销售单号已存在。", "警告", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                    return;
                }
            }
            catch (Exception ex)
            {
                XtraMessageBox.Show(ex.Message, "错误", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                return;
            }
            //tx.Complete();
            this.DialogResult = DialogResult.OK;
            BUSBillEntity bill = new BUSBillEntity
            {
                BillCode = txtBillCode.Text
            };
            bill.Fetch();
            bill.BillStatus = 3;
            bill.BillStatusName = "等待复核";
            bill.Update();
            BUSStoreBillEntity storebill = new BUSStoreBillEntity();
            storebill.StoreCode = txtBillCode.Text;
            storebill.StoreDate = DateTime.Now;
            storebill.IsBillIn = false;
            storebill.BillStyle = "正常";
            storebill.StoreTypeID = 1;
            storebill.StoreTypeName = "销售出货";
            storebill.StoreTypeSpell = "xsck";
            storebill.DealerID = bill.DealerID;
            storebill.DealerName = bill.DealerName;
            storebill.SaleBillID = bill.BillID;
            storebill.SaleBillCode = txtBillCode.Text;
            storebill.Operator = bill.Operator;
            storebill.CreateUserID = GlobalItem.g_CurrentUser.UserID;
            storebill.CreateDate = DateTime.Now;
            storebill.LastModifyUserID = GlobalItem.g_CurrentUser.UserID;
            storebill.LastModifyDate = DateTime.Now;
            storebill.Reservation1 = "2";
            storebill.Reservation9 = "保存并出库";
            storebill.Save();
            storebill.Fetch();
            BUSStoreBillDetailEntity storebilldetail = new BUSStoreBillDetailEntity();
            storebilldetail.StoreID = storebill.StoreID;
            int rowCount = this.popupGrid.PopupView.RowCount;
            for (int i = 0; i < rowCount; i++)
            {
                object productid = this.popupGrid.PopupView.GetRowCellValue(i, "产品ID");
                if (productid != null && productid != DBNull.Value)
                {
                    storebilldetail.ProductID = (int)productid;
                    storebilldetail.BatchNo = this.popupGrid.PopupView.GetRowCellValue(i, "批号").ToString();
                    storebilldetail.ProduceDate = (DateTime)this.popupGrid.PopupView.GetRowCellValue(i, "生产日期");
                    storebilldetail.ValidateDate = (DateTime)this.popupGrid.PopupView.GetRowCellValue(i, "有效期至");
                    storebilldetail.SterilizationBatchNo = popupGrid.PopupView.GetRowCellValue(i, "灭菌批号").ToString();
                    if (popupGrid.PopupView.GetRowCellValue(i, "灭菌日期").ToString() != "")
                    {
                        storebilldetail.SterilizationDate = (DateTime)popupGrid.PopupView.GetRowCellValue(i, "灭菌日期");
                    }
                    storebilldetail.BillAmount = (int)this.popupGrid.PopupView.GetRowCellValue(i, "数量");
                    storebilldetail.Amount = (int)this.popupGrid.PopupView.GetRowCellValue(i, "数量");
                    storebilldetail.StoreAmount = 0;
                    storebilldetail.Save();
                }
            }
            string sql = "UPDATE dbo.BUS_StoreBill SET Reservation1 = NULL WHERE StoreID = " + storebill.StoreID;
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

        private void CorrectStockAmount()
        {
            if (!m_id.HasValue || m_id.Value <= 0)
            {
                return;
            }

            BUSBillEntity entity = new BUSBillEntity
            {
                BillID = m_id.Value
            };
            entity.Fetch();

            int departmentID = 0;
            var billCreateUserId = entity.CreateUserID;
            ATCUserEntity userEntity = new ATCUserEntity
            {
                UserID = billCreateUserId
            };
            userEntity.Fetch();
            var billCreateEmployeeId = userEntity.EmployeeID;
            var employee = new BFIEmployeeEntity
            {
                EmployeeID = billCreateEmployeeId
            };
            employee.Fetch();
            if (!employee.IsNullField("DepartmentID"))
            {
                departmentID = employee.DepartmentID;
            }
            string sql = @"
UPDATE SD
    SET SD.Amount = SD.Amount + BD.Amount
FROM dbo.BUS_BillDetail AS BD
LEFT JOIN dbo.BUS_StoreDetail AS SD
ON BD.ProductID = SD.ProductID
AND BD.BatchNo = SD.BatchNo
WHERE BD.BillID='{0}' AND SD.DepartmentID='{1}'

UPDATE dbo.BUS_Bill SET BillStatus=1,BillStatusName='已下单',ReceiveID=NULL,ReviewCode=NULL,AcceptID=NULL,AcceptCode=NULL,Reservation10='修改' WHERE BillID='{0}'
";
            using (SqlConnection conn = new SqlConnection(GlobalItem.g_DbConnectStrings))
            {
                conn.Open();//连接数据库
                //开始一个本地事务
                SqlTransaction transaction = conn.BeginTransaction("SaleTransaction");
                //必须为SqlCommand指定数据库连接和登记的事务
                SqlCommand cmd = new SqlCommand("", conn, transaction);
                try
                {
                    //向数据表中插入记录的命令语句
                    cmd.CommandText = string.Format(sql, entity.BillID, departmentID);
                    cmd.ExecuteNonQuery();
                    transaction.Commit();//提交事务
                }
                catch (Exception ex)
                {
                    try
                    {
                        transaction.Rollback();//回滚事务
                    }
                    catch (Exception ex2)
                    {
                    }
                }
            }
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
                    double TradePrice = Convert.ToDouble(popupGrid.PopupView.GetDataRow(i)["批发价"]);
                    double RetailPrice = Convert.ToDouble(popupGrid.PopupView.GetDataRow(i)["零售价"]);
                    string Reservation1 = popupGrid.PopupView.GetDataRow(i)["销项税"].ToString();
                    string isPrint = popupGrid.PopupView.GetDataRow(i)["是否打印检报"].ToString();
                    svd.InStoreDetailID = InStoreDetailID;
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
                    svd.isPrint = isPrint;
                    if (!CheckNewStoreDetail(InStoreDetailID, Amount, BatchNo))
                    {
                        BFIProductEntity productEntity = new BFIProductEntity
                        {
                            ProductID = ProductID
                        };
                        productEntity.Fetch();
                        _amountErrors.Add(String.Format("第{0}行，{1} 批号为{2}库存不足。", i + 1, productEntity.ProductName, BatchNo));
                    }
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

        private void txtReservation6_PopupClosing(object sender, EventArgs e)
        {

        }

        private bool checkPersonRange()
        {
            EntityCollection<BFIPersonRangeEntity> ranges = new EntityCollection<BFIPersonRangeEntity>();
            ranges.Fetch(BFIPersonRangeEntityFields.PersonType == "客户"
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
                            XtraMessageBox.Show(String.Format("表格中第{0}行产品超出客户采购人员{1}的经营范围，无法生成订单，请修改！", (i + 1), txtBusinessPerson.Text.Trim()), "系统提示", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            return false;
                        }
                    }
                }
            }
            else
            {
                ranges.Fetch(BFIPersonRangeEntityFields.PersonType == "客户"
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
                                XtraMessageBox.Show(String.Format("表格中第{0}行产品超出客户采购人员{1}的经营范围，无法生成订单，请修改！", (i + 1), txtBusinessPerson.Text.Trim()), "系统提示", MessageBoxButtons.OK, MessageBoxIcon.Information);
                                return false;
                            }
                        }
                    }
                }
                else
                {
                    ranges.Fetch(BFIPersonRangeEntityFields.PersonType == "客户"
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
                                    XtraMessageBox.Show(String.Format("表格中第{0}行产品超出客户采购人员{1}的经营范围，无法生成订单，请修改！", (i + 1), txtBusinessPerson.Text.Trim()), "系统提示", MessageBoxButtons.OK, MessageBoxIcon.Information);
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

        private bool checkEmployeeRange()
        {
            int value = Convert.ToInt32(txtOperator.SelectedValue);
            EntityCollection<BFIPersonRangeEntity> ranges = new EntityCollection<BFIPersonRangeEntity>();
            ranges.Fetch(BFIPersonRangeEntityFields.PersonType == "员工"
                & BFIPersonRangeEntityFields.PersonID == value
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
                            XtraMessageBox.Show(String.Format("表格中第{0}行产品超出本企业业务员{1}的经营范围，无法生成订单，请修改！", (i + 1), txtOperator.Text.Trim()), "系统提示", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            return false;
                        }
                    }
                }
            }
            else
            {
                ranges.Fetch(BFIPersonRangeEntityFields.PersonType == "员工"
                    & BFIPersonRangeEntityFields.PersonID == value
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
                                XtraMessageBox.Show(String.Format("表格中第{0}行产品超出本企业业务员{1}的经营范围，无法生成订单，请修改！", (i + 1), txtOperator.Text.Trim()), "系统提示", MessageBoxButtons.OK, MessageBoxIcon.Information);
                                return false;
                            }
                        }
                    }
                }
                else
                {
                    ranges.Fetch(BFIPersonRangeEntityFields.PersonType == "员工"
                        & BFIPersonRangeEntityFields.PersonID == value
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
                                    XtraMessageBox.Show(String.Format("表格中第{0}行产品超出本企业业务员{1}的经营范围，无法生成订单，请修改！", (i + 1), txtOperator.Text.Trim()), "系统提示", MessageBoxButtons.OK, MessageBoxIcon.Information);
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
    }
}