﻿namespace DQS.AppViews.Operation.PurchaseAndSaleManager
{
    partial class FrmSingleOutSale
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.groupControl = new DevExpress.XtraEditors.GroupControl();
            this.gridControl2 = new DevExpress.XtraGrid.GridControl();
            this.gridView2 = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.ColInStoreID = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colProductID = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colProductCode = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colProductName = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colBatchNo = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colProduceDate = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colValidateDate = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colOutAmount = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colStoreAmount = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colUnitPrice = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colTotalPrice = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colTradePrice = new DevExpress.XtraGrid.Columns.GridColumn();
            this.RetailPrice = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridControl1 = new DevExpress.XtraGrid.GridControl();
            this.gridView1 = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.panelAction = new DevExpress.XtraEditors.PanelControl();
            this.lblStyleName = new DevExpress.XtraEditors.LabelControl();
            this.lblStyleID = new DevExpress.XtraEditors.LabelControl();
            this.btnViewHistory = new DevExpress.XtraEditors.SimpleButton();
            this.btnCancel = new DevExpress.XtraEditors.SimpleButton();
            this.btnSaveAndOut = new DevExpress.XtraEditors.SimpleButton();
            this.btnAcceptReport = new DevExpress.XtraEditors.SimpleButton();
            this.btnSave = new DevExpress.XtraEditors.SimpleButton();
            this.btnPrint = new DQS.Controls.StiPrintButtonEx();
            this.btnFix = new DevExpress.XtraEditors.SimpleButton();
            this.ftPanel = new DQS.Controls.FieldTextBoxPanel();
            this.layControl = new DevExpress.XtraLayout.LayoutControl();
            this.txtOutBillCode = new DQS.Controls.BUSBillEntityTextBox();
            this.txtDealerName = new DQS.Controls.BUSBillEntityTextBox();
            this.txtDealerArea = new DevExpress.XtraEditors.ComboBoxEdit();
            this.txtDiscount = new DQS.Controls.BUSBillEntityTextBox();
            this.txtReservation9 = new DQS.Controls.BUSBillEntityTextBox();
            this.txtInvoiceContent = new DQS.Controls.BUSBillEntityTextBox();
            this.cboDepartment = new DQS.Controls.ComboBoxCategoryEx();
            this.txtReservation15 = new DQS.Controls.BUSBillEntityTextBox();
            this.txtReservation14 = new DQS.Controls.BUSBillEntityTextBox();
            this.txtReservation13 = new DQS.Controls.BUSBillEntityTextBox();
            this.txtReservation12 = new DQS.Controls.BUSBillEntityTextBox();
            this.rdgPaymentType = new DevExpress.XtraEditors.RadioGroup();
            this.txtReservation11 = new DQS.Controls.BUSBillEntityTextBox();
            this.txtReservation6 = new DQS.Controls.TextBoxEnterPopupEx();
            this.cbxPrice = new DevExpress.XtraEditors.LookUpEdit();
            this.busBillEntityTextBox1 = new DQS.Controls.BUSBillEntityTextBox();
            this.txtBillRemark = new DQS.Controls.BUSBillEntityTextBox();
            this.rdgBillStyle = new DevExpress.XtraEditors.RadioGroup();
            this.txtDealerCode = new DQS.Controls.BUSBillEntityTextBox();
            this.txtProductAmount = new DQS.Controls.BUSBillEntityTextBox();
            this.txtPickUpPerson = new DQS.Controls.TextBoxPopupEx();
            this.cbxDeliveryType = new DQS.Controls.ComboBoxCategoryEx();
            this.cbxPaymentType = new DQS.Controls.ComboBoxCategoryEx();
            this.txtContractNo = new DQS.Controls.BUSBillEntityTextBox();
            this.txtBillCode = new DQS.Controls.BUSBillEntityTextBox();
            this.txtOperator = new DQS.Controls.TextBoxEnterPopupEx();
            this.txtTotalPrice = new DQS.Controls.BUSBillEntityTextBox();
            this.txtBusinessPerson = new DQS.Controls.TextBoxPopupEx();
            this.txtBusinessPhone = new DQS.Controls.BUSBillEntityTextBox();
            this.txtDealerAddress = new DevExpress.XtraEditors.ComboBoxEdit();
            this.layControlGroup = new DevExpress.XtraLayout.LayoutControlGroup();
            this.layBillCode = new DevExpress.XtraLayout.LayoutControlItem();
            this.layDealerAddress = new DevExpress.XtraLayout.LayoutControlItem();
            this.layPaymentType = new DevExpress.XtraLayout.LayoutControlItem();
            this.layTotalPrice = new DevExpress.XtraLayout.LayoutControlItem();
            this.layContractNo = new DevExpress.XtraLayout.LayoutControlItem();
            this.layProductAmount = new DevExpress.XtraLayout.LayoutControlItem();
            this.layDealerCode = new DevExpress.XtraLayout.LayoutControlItem();
            this.layBusinessPerson = new DevExpress.XtraLayout.LayoutControlItem();
            this.layPickUpPerson = new DevExpress.XtraLayout.LayoutControlItem();
            this.layBusinessPhone = new DevExpress.XtraLayout.LayoutControlItem();
            this.layDeliveryType = new DevExpress.XtraLayout.LayoutControlItem();
            this.layOperator = new DevExpress.XtraLayout.LayoutControlItem();
            this.layBillStyle = new DevExpress.XtraLayout.LayoutControlItem();
            this.emptySpaceItem1 = new DevExpress.XtraLayout.EmptySpaceItem();
            this.layRemark = new DevExpress.XtraLayout.LayoutControlItem();
            this.layoutControlDel = new DevExpress.XtraLayout.LayoutControlItem();
            this.layPrice = new DevExpress.XtraLayout.LayoutControlItem();
            this.layReservation6 = new DevExpress.XtraLayout.LayoutControlItem();
            this.layReservation11 = new DevExpress.XtraLayout.LayoutControlItem();
            this.layReservation12 = new DevExpress.XtraLayout.LayoutControlItem();
            this.layReservation13 = new DevExpress.XtraLayout.LayoutControlItem();
            this.layReservation14 = new DevExpress.XtraLayout.LayoutControlItem();
            this.layReservation15 = new DevExpress.XtraLayout.LayoutControlItem();
            this.layDepartment = new DevExpress.XtraLayout.LayoutControlItem();
            this.layoutControlItem1 = new DevExpress.XtraLayout.LayoutControlItem();
            this.layPaymentTypeName = new DevExpress.XtraLayout.LayoutControlItem();
            this.layReservation9 = new DevExpress.XtraLayout.LayoutControlItem();
            this.layDiscount = new DevExpress.XtraLayout.LayoutControlItem();
            this.layDealerArea = new DevExpress.XtraLayout.LayoutControlItem();
            this.layDealerName = new DevExpress.XtraLayout.LayoutControlItem();
            this.layOutBillCode = new DevExpress.XtraLayout.LayoutControlItem();
            ((System.ComponentModel.ISupportInitialize)(this.groupControl)).BeginInit();
            this.groupControl.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gridControl2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridControl1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.panelAction)).BeginInit();
            this.panelAction.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ftPanel)).BeginInit();
            this.ftPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.layControl)).BeginInit();
            this.layControl.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.txtOutBillCode.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtDealerName.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtDealerArea.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtDiscount.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtReservation9.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtInvoiceContent.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cboDepartment.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtReservation15.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtReservation14.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtReservation13.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtReservation12.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.rdgPaymentType.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtReservation11.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtReservation6.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cbxPrice.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.busBillEntityTextBox1.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtBillRemark.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.rdgBillStyle.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtDealerCode.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtProductAmount.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtPickUpPerson.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cbxDeliveryType.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cbxPaymentType.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtContractNo.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtBillCode.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtOperator.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtTotalPrice.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtBusinessPerson.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtBusinessPhone.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtDealerAddress.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layControlGroup)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layBillCode)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layDealerAddress)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layPaymentType)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layTotalPrice)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layContractNo)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layProductAmount)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layDealerCode)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layBusinessPerson)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layPickUpPerson)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layBusinessPhone)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layDeliveryType)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layOperator)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layBillStyle)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.emptySpaceItem1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layRemark)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlDel)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layPrice)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layReservation6)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layReservation11)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layReservation12)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layReservation13)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layReservation14)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layReservation15)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layDepartment)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layPaymentTypeName)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layReservation9)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layDiscount)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layDealerArea)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layDealerName)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layOutBillCode)).BeginInit();
            this.SuspendLayout();
            // 
            // groupControl
            // 
            this.groupControl.AppearanceCaption.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupControl.AppearanceCaption.Options.UseFont = true;
            this.groupControl.Controls.Add(this.gridControl2);
            this.groupControl.Controls.Add(this.gridControl1);
            this.groupControl.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupControl.Location = new System.Drawing.Point(0, 269);
            this.groupControl.Name = "groupControl";
            this.groupControl.Size = new System.Drawing.Size(872, 214);
            this.groupControl.TabIndex = 1;
            this.groupControl.Text = "销售订单明细";
            // 
            // gridControl2
            // 
            this.gridControl2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gridControl2.Location = new System.Drawing.Point(469, 25);
            this.gridControl2.MainView = this.gridView2;
            this.gridControl2.Name = "gridControl2";
            this.gridControl2.Size = new System.Drawing.Size(401, 187);
            this.gridControl2.TabIndex = 1;
            this.gridControl2.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridView2});
            // 
            // gridView2
            // 
            this.gridView2.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.ColInStoreID,
            this.colProductID,
            this.colProductCode,
            this.colProductName,
            this.colBatchNo,
            this.colProduceDate,
            this.colValidateDate,
            this.colOutAmount,
            this.colStoreAmount,
            this.colUnitPrice,
            this.colTotalPrice,
            this.colTradePrice,
            this.RetailPrice});
            this.gridView2.GridControl = this.gridControl2;
            this.gridView2.IndicatorWidth = 45;
            this.gridView2.Name = "gridView2";
            this.gridView2.OptionsBehavior.Editable = false;
            this.gridView2.OptionsBehavior.ReadOnly = true;
            this.gridView2.OptionsView.ColumnAutoWidth = false;
            this.gridView2.OptionsView.ShowGroupPanel = false;
            // 
            // ColInStoreID
            // 
            this.ColInStoreID.Caption = "InStoreID";
            this.ColInStoreID.FieldName = "InStoreID";
            this.ColInStoreID.Name = "ColInStoreID";
            // 
            // colProductID
            // 
            this.colProductID.Caption = "ProductID";
            this.colProductID.FieldName = "ProductID";
            this.colProductID.Name = "colProductID";
            // 
            // colProductCode
            // 
            this.colProductCode.Caption = "产品编号";
            this.colProductCode.FieldName = "ProductCode";
            this.colProductCode.Name = "colProductCode";
            this.colProductCode.Visible = true;
            this.colProductCode.VisibleIndex = 0;
            // 
            // colProductName
            // 
            this.colProductName.Caption = "产品名称";
            this.colProductName.FieldName = "ProductName";
            this.colProductName.Name = "colProductName";
            this.colProductName.Visible = true;
            this.colProductName.VisibleIndex = 1;
            // 
            // colBatchNo
            // 
            this.colBatchNo.Caption = "批号";
            this.colBatchNo.FieldName = "BatchNo";
            this.colBatchNo.Name = "colBatchNo";
            this.colBatchNo.Visible = true;
            this.colBatchNo.VisibleIndex = 2;
            // 
            // colProduceDate
            // 
            this.colProduceDate.Caption = "生产日期";
            this.colProduceDate.FieldName = "ProduceDate";
            this.colProduceDate.Name = "colProduceDate";
            this.colProduceDate.Visible = true;
            this.colProduceDate.VisibleIndex = 3;
            // 
            // colValidateDate
            // 
            this.colValidateDate.Caption = "有效期";
            this.colValidateDate.FieldName = "ValidateDate";
            this.colValidateDate.Name = "colValidateDate";
            this.colValidateDate.Visible = true;
            this.colValidateDate.VisibleIndex = 4;
            // 
            // colOutAmount
            // 
            this.colOutAmount.Caption = "数量";
            this.colOutAmount.FieldName = "OutAmount";
            this.colOutAmount.Name = "colOutAmount";
            this.colOutAmount.Visible = true;
            this.colOutAmount.VisibleIndex = 5;
            // 
            // colStoreAmount
            // 
            this.colStoreAmount.Caption = "库存数量";
            this.colStoreAmount.FieldName = "StoreAmount";
            this.colStoreAmount.Name = "colStoreAmount";
            this.colStoreAmount.Visible = true;
            this.colStoreAmount.VisibleIndex = 6;
            // 
            // colUnitPrice
            // 
            this.colUnitPrice.Caption = "单价";
            this.colUnitPrice.FieldName = "UnitPrice";
            this.colUnitPrice.Name = "colUnitPrice";
            this.colUnitPrice.Visible = true;
            this.colUnitPrice.VisibleIndex = 7;
            // 
            // colTotalPrice
            // 
            this.colTotalPrice.Caption = "金额";
            this.colTotalPrice.FieldName = "TotalPrice";
            this.colTotalPrice.Name = "colTotalPrice";
            this.colTotalPrice.Visible = true;
            this.colTotalPrice.VisibleIndex = 8;
            // 
            // colTradePrice
            // 
            this.colTradePrice.Caption = "批发价";
            this.colTradePrice.FieldName = "TradePrice";
            this.colTradePrice.Name = "colTradePrice";
            this.colTradePrice.Visible = true;
            this.colTradePrice.VisibleIndex = 9;
            // 
            // RetailPrice
            // 
            this.RetailPrice.Caption = "零售价";
            this.RetailPrice.FieldName = "RetailPrice";
            this.RetailPrice.Name = "RetailPrice";
            this.RetailPrice.Visible = true;
            this.RetailPrice.VisibleIndex = 10;
            // 
            // gridControl1
            // 
            this.gridControl1.Dock = System.Windows.Forms.DockStyle.Left;
            this.gridControl1.Location = new System.Drawing.Point(2, 25);
            this.gridControl1.MainView = this.gridView1;
            this.gridControl1.Name = "gridControl1";
            this.gridControl1.Size = new System.Drawing.Size(467, 187);
            this.gridControl1.TabIndex = 0;
            this.gridControl1.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridView1});
            // 
            // gridView1
            // 
            this.gridView1.GridControl = this.gridControl1;
            this.gridView1.IndicatorWidth = 45;
            this.gridView1.Name = "gridView1";
            this.gridView1.OptionsView.ColumnAutoWidth = false;
            this.gridView1.OptionsView.ShowGroupPanel = false;
            this.gridView1.CellValueChanging += new DevExpress.XtraGrid.Views.Base.CellValueChangedEventHandler(this.gridView1_CellValueChanging);
            this.gridView1.DoubleClick += new System.EventHandler(this.gridView1_DoubleClick);
            // 
            // panelAction
            // 
            this.panelAction.Controls.Add(this.lblStyleName);
            this.panelAction.Controls.Add(this.lblStyleID);
            this.panelAction.Controls.Add(this.btnViewHistory);
            this.panelAction.Controls.Add(this.btnCancel);
            this.panelAction.Controls.Add(this.btnSaveAndOut);
            this.panelAction.Controls.Add(this.btnAcceptReport);
            this.panelAction.Controls.Add(this.btnSave);
            this.panelAction.Controls.Add(this.btnPrint);
            this.panelAction.Controls.Add(this.btnFix);
            this.panelAction.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panelAction.Location = new System.Drawing.Point(0, 483);
            this.panelAction.Name = "panelAction";
            this.panelAction.Size = new System.Drawing.Size(872, 48);
            this.panelAction.TabIndex = 2;
            // 
            // lblStyleName
            // 
            this.lblStyleName.Location = new System.Drawing.Point(171, 16);
            this.lblStyleName.Name = "lblStyleName";
            this.lblStyleName.Size = new System.Drawing.Size(0, 14);
            this.lblStyleName.TabIndex = 100;
            this.lblStyleName.Visible = false;
            // 
            // lblStyleID
            // 
            this.lblStyleID.Location = new System.Drawing.Point(104, 16);
            this.lblStyleID.Name = "lblStyleID";
            this.lblStyleID.Size = new System.Drawing.Size(0, 14);
            this.lblStyleID.TabIndex = 100;
            this.lblStyleID.Visible = false;
            // 
            // btnViewHistory
            // 
            this.btnViewHistory.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnViewHistory.Appearance.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnViewHistory.Appearance.Options.UseFont = true;
            this.btnViewHistory.Location = new System.Drawing.Point(224, 13);
            this.btnViewHistory.Name = "btnViewHistory";
            this.btnViewHistory.Size = new System.Drawing.Size(102, 23);
            this.btnViewHistory.TabIndex = 18;
            this.btnViewHistory.Text = "历史记录(&H)";
            this.btnViewHistory.Visible = false;
            // 
            // btnCancel
            // 
            this.btnCancel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnCancel.Appearance.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCancel.Appearance.Options.UseFont = true;
            this.btnCancel.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btnCancel.Location = new System.Drawing.Point(783, 13);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(75, 23);
            this.btnCancel.TabIndex = 19;
            this.btnCancel.Text = "取消(&C)";
            // 
            // btnSaveAndOut
            // 
            this.btnSaveAndOut.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnSaveAndOut.Appearance.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSaveAndOut.Appearance.Options.UseFont = true;
            this.btnSaveAndOut.Location = new System.Drawing.Point(665, 13);
            this.btnSaveAndOut.Name = "btnSaveAndOut";
            this.btnSaveAndOut.Size = new System.Drawing.Size(85, 23);
            this.btnSaveAndOut.TabIndex = 16;
            this.btnSaveAndOut.Text = "保存并出库";
            this.btnSaveAndOut.Visible = false;
            // 
            // btnAcceptReport
            // 
            this.btnAcceptReport.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnAcceptReport.Appearance.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAcceptReport.Appearance.Options.UseFont = true;
            this.btnAcceptReport.Location = new System.Drawing.Point(349, 13);
            this.btnAcceptReport.Name = "btnAcceptReport";
            this.btnAcceptReport.Size = new System.Drawing.Size(75, 23);
            this.btnAcceptReport.TabIndex = 16;
            this.btnAcceptReport.Text = "验报(&P)";
            this.btnAcceptReport.Visible = false;
            // 
            // btnSave
            // 
            this.btnSave.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnSave.Appearance.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSave.Appearance.Options.UseFont = true;
            this.btnSave.Location = new System.Drawing.Point(553, 13);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(75, 23);
            this.btnSave.TabIndex = 16;
            this.btnSave.Text = "保存(&S)";
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // btnPrint
            // 
            this.btnPrint.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnPrint.Appearance.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnPrint.Appearance.Options.UseFont = true;
            this.btnPrint.Location = new System.Drawing.Point(452, 13);
            this.btnPrint.Name = "btnPrint";
            this.btnPrint.OperationName = "Sale";
            this.btnPrint.ReportName = "销售单";
            this.btnPrint.Size = new System.Drawing.Size(75, 23);
            this.btnPrint.TabIndex = 17;
            this.btnPrint.Text = "打印(&P)";
            this.btnPrint.Visible = false;
            // 
            // btnFix
            // 
            this.btnFix.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnFix.Appearance.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnFix.Appearance.Options.UseFont = true;
            this.btnFix.Location = new System.Drawing.Point(10, 13);
            this.btnFix.Name = "btnFix";
            this.btnFix.Size = new System.Drawing.Size(75, 23);
            this.btnFix.TabIndex = 99;
            this.btnFix.Text = "冲红(&F)";
            this.btnFix.Visible = false;
            // 
            // ftPanel
            // 
            this.ftPanel.Controls.Add(this.layControl);
            this.ftPanel.Dock = System.Windows.Forms.DockStyle.Top;
            this.ftPanel.Location = new System.Drawing.Point(0, 0);
            this.ftPanel.Name = "ftPanel";
            this.ftPanel.Size = new System.Drawing.Size(872, 269);
            this.ftPanel.TabIndex = 3;
            this.ftPanel.TypeOfEntity = DQS.Module.EntityType2.BUSBillEntity;
            // 
            // layControl
            // 
            this.layControl.Controls.Add(this.txtOutBillCode);
            this.layControl.Controls.Add(this.txtDealerName);
            this.layControl.Controls.Add(this.txtDealerArea);
            this.layControl.Controls.Add(this.txtDiscount);
            this.layControl.Controls.Add(this.txtReservation9);
            this.layControl.Controls.Add(this.txtInvoiceContent);
            this.layControl.Controls.Add(this.cboDepartment);
            this.layControl.Controls.Add(this.txtReservation15);
            this.layControl.Controls.Add(this.txtReservation14);
            this.layControl.Controls.Add(this.txtReservation13);
            this.layControl.Controls.Add(this.txtReservation12);
            this.layControl.Controls.Add(this.rdgPaymentType);
            this.layControl.Controls.Add(this.txtReservation11);
            this.layControl.Controls.Add(this.txtReservation6);
            this.layControl.Controls.Add(this.cbxPrice);
            this.layControl.Controls.Add(this.busBillEntityTextBox1);
            this.layControl.Controls.Add(this.txtBillRemark);
            this.layControl.Controls.Add(this.rdgBillStyle);
            this.layControl.Controls.Add(this.txtDealerCode);
            this.layControl.Controls.Add(this.txtProductAmount);
            this.layControl.Controls.Add(this.txtPickUpPerson);
            this.layControl.Controls.Add(this.cbxDeliveryType);
            this.layControl.Controls.Add(this.cbxPaymentType);
            this.layControl.Controls.Add(this.txtContractNo);
            this.layControl.Controls.Add(this.txtBillCode);
            this.layControl.Controls.Add(this.txtOperator);
            this.layControl.Controls.Add(this.txtTotalPrice);
            this.layControl.Controls.Add(this.txtBusinessPerson);
            this.layControl.Controls.Add(this.txtBusinessPhone);
            this.layControl.Controls.Add(this.txtDealerAddress);
            this.layControl.Dock = System.Windows.Forms.DockStyle.Fill;
            this.layControl.Location = new System.Drawing.Point(2, 2);
            this.layControl.Name = "layControl";
            this.layControl.Root = this.layControlGroup;
            this.layControl.Size = new System.Drawing.Size(868, 265);
            this.layControl.TabIndex = 0;
            this.layControl.Text = "layControl";
            // 
            // txtOutBillCode
            // 
            this.txtOutBillCode.AlphabeticFiled = null;
            this.txtOutBillCode.EntityField = DQS.Module.Entities.BUSBillEntityFields2.TransportCode;
            this.txtOutBillCode.IsIntegerOnly = false;
            this.txtOutBillCode.IsNullString = "订单号不能为空。";
            this.txtOutBillCode.IsNullValidate = true;
            this.txtOutBillCode.IsTransferAlphabetic = false;
            this.txtOutBillCode.Location = new System.Drawing.Point(75, 12);
            this.txtOutBillCode.Name = "txtOutBillCode";
            this.txtOutBillCode.Properties.ReadOnly = true;
            this.txtOutBillCode.Size = new System.Drawing.Size(127, 21);
            this.txtOutBillCode.StyleController = this.layControl;
            this.txtOutBillCode.TabIndex = 101;
            // 
            // txtDealerName
            // 
            this.txtDealerName.AlphabeticFiled = null;
            this.txtDealerName.EntityField = DQS.Module.Entities.BUSBillEntityFields2.DealerName;
            this.txtDealerName.IsIntegerOnly = false;
            this.txtDealerName.IsNullString = null;
            this.txtDealerName.IsNullValidate = false;
            this.txtDealerName.IsTransferAlphabetic = false;
            this.txtDealerName.Location = new System.Drawing.Point(75, 45);
            this.txtDealerName.Name = "txtDealerName";
            this.txtDealerName.Properties.ReadOnly = true;
            this.txtDealerName.Size = new System.Drawing.Size(321, 21);
            this.txtDealerName.StyleController = this.layControl;
            this.txtDealerName.TabIndex = 101;
            // 
            // txtDealerArea
            // 
            this.txtDealerArea.Location = new System.Drawing.Point(463, 70);
            this.txtDealerArea.Name = "txtDealerArea";
            this.txtDealerArea.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.txtDealerArea.Size = new System.Drawing.Size(376, 21);
            this.txtDealerArea.StyleController = this.layControl;
            this.txtDealerArea.TabIndex = 102;
            // 
            // txtDiscount
            // 
            this.txtDiscount.AlphabeticFiled = null;
            this.txtDiscount.EditValue = "100";
            this.txtDiscount.EntityField = DQS.Module.Entities.BUSBillEntityFields2.Discount;
            this.txtDiscount.IsIntegerOnly = true;
            this.txtDiscount.IsNullString = "不能为空。";
            this.txtDiscount.IsNullValidate = true;
            this.txtDiscount.IsTransferAlphabetic = false;
            this.txtDiscount.Location = new System.Drawing.Point(75, 249);
            this.txtDiscount.Name = "txtDiscount";
            this.txtDiscount.Size = new System.Drawing.Size(127, 21);
            this.txtDiscount.StyleController = this.layControl;
            this.txtDiscount.TabIndex = 103;
            // 
            // txtReservation9
            // 
            this.txtReservation9.AlphabeticFiled = null;
            this.txtReservation9.EditValue = "";
            this.txtReservation9.EntityField = DQS.Module.Entities.BUSBillEntityFields2.Reservation9;
            this.txtReservation9.IsIntegerOnly = false;
            this.txtReservation9.IsNullString = null;
            this.txtReservation9.IsNullValidate = false;
            this.txtReservation9.IsTransferAlphabetic = false;
            this.txtReservation9.Location = new System.Drawing.Point(269, 249);
            this.txtReservation9.Name = "txtReservation9";
            this.txtReservation9.Size = new System.Drawing.Size(127, 21);
            this.txtReservation9.StyleController = this.layControl;
            this.txtReservation9.TabIndex = 103;
            // 
            // txtInvoiceContent
            // 
            this.txtInvoiceContent.AlphabeticFiled = null;
            this.txtInvoiceContent.EditValue = "0%";
            this.txtInvoiceContent.EntityField = DQS.Module.Entities.BUSBillEntityFields2.InvoiceContent;
            this.txtInvoiceContent.IsIntegerOnly = false;
            this.txtInvoiceContent.IsNullString = null;
            this.txtInvoiceContent.IsNullValidate = false;
            this.txtInvoiceContent.IsTransferAlphabetic = false;
            this.txtInvoiceContent.Location = new System.Drawing.Point(294, 174);
            this.txtInvoiceContent.Name = "txtInvoiceContent";
            this.txtInvoiceContent.Properties.Appearance.BackColor = System.Drawing.Color.White;
            this.txtInvoiceContent.Properties.Appearance.Options.UseBackColor = true;
            this.txtInvoiceContent.Properties.ReadOnly = true;
            this.txtInvoiceContent.Size = new System.Drawing.Size(102, 21);
            this.txtInvoiceContent.StyleController = this.layControl;
            this.txtInvoiceContent.TabIndex = 101;
            // 
            // cboDepartment
            // 
            this.cboDepartment.AddFirstDefaultItem = false;
            this.cboDepartment.CategoryCode = "PaymentType";
            this.cboDepartment.FirstDefaultItemText = null;
            this.cboDepartment.FormatQueryString = null;
            this.cboDepartment.Location = new System.Drawing.Point(463, 199);
            this.cboDepartment.Name = "cboDepartment";
            this.cboDepartment.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.cboDepartment.Properties.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.DisableTextEditor;
            this.cboDepartment.SelectedValue = null;
            this.cboDepartment.Size = new System.Drawing.Size(376, 21);
            this.cboDepartment.StyleController = this.layControl;
            this.cboDepartment.TabIndex = 102;
            // 
            // txtReservation15
            // 
            this.txtReservation15.AlphabeticFiled = null;
            this.txtReservation15.EntityField = DQS.Module.Entities.BUSBillEntityFields2.Reservation15;
            this.txtReservation15.IsIntegerOnly = false;
            this.txtReservation15.IsNullString = null;
            this.txtReservation15.IsNullValidate = false;
            this.txtReservation15.IsTransferAlphabetic = false;
            this.txtReservation15.Location = new System.Drawing.Point(372, 324);
            this.txtReservation15.Name = "txtReservation15";
            this.txtReservation15.Size = new System.Drawing.Size(467, 21);
            this.txtReservation15.StyleController = this.layControl;
            this.txtReservation15.TabIndex = 101;
            // 
            // txtReservation14
            // 
            this.txtReservation14.AlphabeticFiled = null;
            this.txtReservation14.EntityField = DQS.Module.Entities.BUSBillEntityFields2.Reservation14;
            this.txtReservation14.IsIntegerOnly = false;
            this.txtReservation14.IsNullString = null;
            this.txtReservation14.IsNullValidate = false;
            this.txtReservation14.IsTransferAlphabetic = false;
            this.txtReservation14.Location = new System.Drawing.Point(75, 324);
            this.txtReservation14.Name = "txtReservation14";
            this.txtReservation14.Size = new System.Drawing.Size(230, 21);
            this.txtReservation14.StyleController = this.layControl;
            this.txtReservation14.TabIndex = 101;
            // 
            // txtReservation13
            // 
            this.txtReservation13.AlphabeticFiled = null;
            this.txtReservation13.EntityField = DQS.Module.Entities.BUSBillEntityFields2.Reservation13;
            this.txtReservation13.IsIntegerOnly = false;
            this.txtReservation13.IsNullString = null;
            this.txtReservation13.IsNullValidate = false;
            this.txtReservation13.IsTransferAlphabetic = false;
            this.txtReservation13.Location = new System.Drawing.Point(649, 299);
            this.txtReservation13.Name = "txtReservation13";
            this.txtReservation13.Size = new System.Drawing.Size(190, 21);
            this.txtReservation13.StyleController = this.layControl;
            this.txtReservation13.TabIndex = 101;
            // 
            // txtReservation12
            // 
            this.txtReservation12.AlphabeticFiled = null;
            this.txtReservation12.EntityField = DQS.Module.Entities.BUSBillEntityFields2.Reservation12;
            this.txtReservation12.IsIntegerOnly = false;
            this.txtReservation12.IsNullString = null;
            this.txtReservation12.IsNullValidate = false;
            this.txtReservation12.IsTransferAlphabetic = false;
            this.txtReservation12.Location = new System.Drawing.Point(372, 299);
            this.txtReservation12.Name = "txtReservation12";
            this.txtReservation12.Size = new System.Drawing.Size(210, 21);
            this.txtReservation12.StyleController = this.layControl;
            this.txtReservation12.TabIndex = 101;
            // 
            // rdgPaymentType
            // 
            this.rdgPaymentType.EditValue = "应收";
            this.rdgPaymentType.Location = new System.Drawing.Point(293, 95);
            this.rdgPaymentType.Name = "rdgPaymentType";
            this.rdgPaymentType.Properties.Appearance.BackColor = System.Drawing.Color.Transparent;
            this.rdgPaymentType.Properties.Appearance.Options.UseBackColor = true;
            this.rdgPaymentType.Properties.Columns = 2;
            this.rdgPaymentType.Properties.Items.AddRange(new DevExpress.XtraEditors.Controls.RadioGroupItem[] {
            new DevExpress.XtraEditors.Controls.RadioGroupItem("应收", "应收"),
            new DevExpress.XtraEditors.Controls.RadioGroupItem("预收", "预收")});
            this.rdgPaymentType.Size = new System.Drawing.Size(103, 25);
            this.rdgPaymentType.StyleController = this.layControl;
            this.rdgPaymentType.TabIndex = 1;
            // 
            // txtReservation11
            // 
            this.txtReservation11.AlphabeticFiled = null;
            this.txtReservation11.EntityField = DQS.Module.Entities.BUSBillEntityFields2.Reservation11;
            this.txtReservation11.IsIntegerOnly = false;
            this.txtReservation11.IsNullString = null;
            this.txtReservation11.IsNullValidate = false;
            this.txtReservation11.IsTransferAlphabetic = false;
            this.txtReservation11.Location = new System.Drawing.Point(75, 299);
            this.txtReservation11.Name = "txtReservation11";
            this.txtReservation11.Size = new System.Drawing.Size(230, 21);
            this.txtReservation11.StyleController = this.layControl;
            this.txtReservation11.TabIndex = 101;
            // 
            // txtReservation6
            // 
            this.txtReservation6.AlphabeticFiled = "";
            this.txtReservation6.EditData = null;
            this.txtReservation6.Fields = null;
            this.txtReservation6.Filter = "[岗位名称] = \'开票员\'";
            this.txtReservation6.FormatQueryString = "[员工编号] LIKE \'%{0}%\' OR ([员工姓名] LIKE \'%{0}%\' OR [员工姓名Spell] LIKE \'%{0}%\')";
            this.txtReservation6.GroupColumn = null;
            this.txtReservation6.IsIntegerOnly = false;
            this.txtReservation6.IsNullString = null;
            this.txtReservation6.IsNullValidate = false;
            this.txtReservation6.IsTransferAlphabetic = true;
            this.txtReservation6.Location = new System.Drawing.Point(463, 149);
            this.txtReservation6.MemberText = "员工姓名";
            this.txtReservation6.MemberValue = "员工ID";
            this.txtReservation6.Name = "txtReservation6";
            this.txtReservation6.PageSize = 0;
            this.txtReservation6.PrimaryField = "员工ID";
            this.txtReservation6.Properties.Appearance.BackColor = System.Drawing.Color.White;
            this.txtReservation6.Properties.Appearance.Options.UseBackColor = true;
            this.txtReservation6.Properties.ReadOnly = true;
            this.txtReservation6.Size = new System.Drawing.Size(376, 21);
            this.txtReservation6.StyleController = this.layControl;
            this.txtReservation6.TabIndex = 101;
            this.txtReservation6.ViewName = "vw_AllEmployee";
            // 
            // cbxPrice
            // 
            this.cbxPrice.Location = new System.Drawing.Point(75, 149);
            this.cbxPrice.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.cbxPrice.Name = "cbxPrice";
            this.cbxPrice.Properties.BestFitMode = DevExpress.XtraEditors.Controls.BestFitMode.BestFitResizePopup;
            this.cbxPrice.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.cbxPrice.Properties.Columns.AddRange(new DevExpress.XtraEditors.Controls.LookUpColumnInfo[] {
            new DevExpress.XtraEditors.Controls.LookUpColumnInfo("PriceListName", "价格表名称")});
            this.cbxPrice.Properties.DisplayMember = "PriceListName";
            this.cbxPrice.Properties.NullText = "";
            this.cbxPrice.Properties.PopupSizeable = false;
            this.cbxPrice.Properties.ShowFooter = false;
            this.cbxPrice.Properties.ShowHeader = false;
            this.cbxPrice.Properties.ShowLines = false;
            this.cbxPrice.Properties.ValueMember = "PriceListID";
            this.cbxPrice.Size = new System.Drawing.Size(321, 21);
            this.cbxPrice.StyleController = this.layControl;
            this.cbxPrice.TabIndex = 100;
            // 
            // busBillEntityTextBox1
            // 
            this.busBillEntityTextBox1.AlphabeticFiled = null;
            this.busBillEntityTextBox1.EntityField = DQS.Module.Entities.BUSBillEntityFields2.Reservation7;
            this.busBillEntityTextBox1.IsIntegerOnly = false;
            this.busBillEntityTextBox1.IsNullString = null;
            this.busBillEntityTextBox1.IsNullValidate = false;
            this.busBillEntityTextBox1.IsTransferAlphabetic = false;
            this.busBillEntityTextBox1.Location = new System.Drawing.Point(75, 274);
            this.busBillEntityTextBox1.Name = "busBillEntityTextBox1";
            this.busBillEntityTextBox1.Size = new System.Drawing.Size(764, 21);
            this.busBillEntityTextBox1.StyleController = this.layControl;
            this.busBillEntityTextBox1.TabIndex = 16;
            // 
            // txtBillRemark
            // 
            this.txtBillRemark.AlphabeticFiled = null;
            this.txtBillRemark.EntityField = DQS.Module.Entities.BUSBillEntityFields2.Reservation2;
            this.txtBillRemark.IsIntegerOnly = false;
            this.txtBillRemark.IsNullString = null;
            this.txtBillRemark.IsNullValidate = false;
            this.txtBillRemark.IsTransferAlphabetic = false;
            this.txtBillRemark.Location = new System.Drawing.Point(463, 249);
            this.txtBillRemark.Name = "txtBillRemark";
            this.txtBillRemark.Size = new System.Drawing.Size(376, 21);
            this.txtBillRemark.StyleController = this.layControl;
            this.txtBillRemark.TabIndex = 14;
            // 
            // rdgBillStyle
            // 
            this.rdgBillStyle.EditValue = "正常";
            this.rdgBillStyle.Location = new System.Drawing.Point(463, 12);
            this.rdgBillStyle.Name = "rdgBillStyle";
            this.rdgBillStyle.Properties.Appearance.BackColor = System.Drawing.Color.Transparent;
            this.rdgBillStyle.Properties.Appearance.Options.UseBackColor = true;
            this.rdgBillStyle.Properties.Columns = 2;
            this.rdgBillStyle.Properties.Items.AddRange(new DevExpress.XtraEditors.Controls.RadioGroupItem[] {
            new DevExpress.XtraEditors.Controls.RadioGroupItem("正常", "正常"),
            new DevExpress.XtraEditors.Controls.RadioGroupItem("直调", "直调")});
            this.rdgBillStyle.Size = new System.Drawing.Size(137, 29);
            this.rdgBillStyle.StyleController = this.layControl;
            this.rdgBillStyle.TabIndex = 1;
            // 
            // txtDealerCode
            // 
            this.txtDealerCode.AlphabeticFiled = null;
            this.txtDealerCode.EntityField = DQS.Module.Entities.BUSBillEntityFields2.DealerCode;
            this.txtDealerCode.IsIntegerOnly = false;
            this.txtDealerCode.IsNullString = null;
            this.txtDealerCode.IsNullValidate = false;
            this.txtDealerCode.IsTransferAlphabetic = false;
            this.txtDealerCode.Location = new System.Drawing.Point(463, 45);
            this.txtDealerCode.Name = "txtDealerCode";
            this.txtDealerCode.Properties.ReadOnly = true;
            this.txtDealerCode.Size = new System.Drawing.Size(376, 21);
            this.txtDealerCode.StyleController = this.layControl;
            this.txtDealerCode.TabIndex = 3;
            // 
            // txtProductAmount
            // 
            this.txtProductAmount.AlphabeticFiled = null;
            this.txtProductAmount.EditValue = "0";
            this.txtProductAmount.EntityField = DQS.Module.Entities.BUSBillEntityFields2.ProductAmount;
            this.txtProductAmount.IsIntegerOnly = false;
            this.txtProductAmount.IsNullString = null;
            this.txtProductAmount.IsNullValidate = false;
            this.txtProductAmount.IsTransferAlphabetic = false;
            this.txtProductAmount.Location = new System.Drawing.Point(463, 174);
            this.txtProductAmount.Name = "txtProductAmount";
            this.txtProductAmount.Properties.Appearance.BackColor = System.Drawing.Color.White;
            this.txtProductAmount.Properties.Appearance.Options.UseBackColor = true;
            this.txtProductAmount.Properties.ReadOnly = true;
            this.txtProductAmount.Size = new System.Drawing.Size(376, 21);
            this.txtProductAmount.StyleController = this.layControl;
            this.txtProductAmount.TabIndex = 10;
            // 
            // txtPickUpPerson
            // 
            this.txtPickUpPerson.AlphabeticFiled = "PickUpPersonSpell";
            this.txtPickUpPerson.EditData = null;
            this.txtPickUpPerson.Fields = null;
            this.txtPickUpPerson.Filter = "[所属岗位] = \'接货员\'";
            this.txtPickUpPerson.FormatQueryString = "[人员编号] LIKE \'%{0}%\' OR ([人员姓名] LIKE \'%{0}%\' OR [人员姓名Spell] LIKE \'%{0}%\')";
            this.txtPickUpPerson.GroupColumn = null;
            this.txtPickUpPerson.IsIntegerOnly = false;
            this.txtPickUpPerson.IsNullString = null;
            this.txtPickUpPerson.IsNullValidate = false;
            this.txtPickUpPerson.IsTransferAlphabetic = true;
            this.txtPickUpPerson.Location = new System.Drawing.Point(75, 199);
            this.txtPickUpPerson.MemberText = "人员姓名";
            this.txtPickUpPerson.MemberValue = "人员ID";
            this.txtPickUpPerson.Name = "txtPickUpPerson";
            this.txtPickUpPerson.PageSize = 0;
            this.txtPickUpPerson.PrimaryField = "人员ID";
            this.txtPickUpPerson.Properties.Appearance.BackColor = System.Drawing.Color.White;
            this.txtPickUpPerson.Properties.Appearance.Options.UseBackColor = true;
            this.txtPickUpPerson.Properties.ReadOnly = true;
            this.txtPickUpPerson.Size = new System.Drawing.Size(321, 21);
            this.txtPickUpPerson.StyleController = this.layControl;
            this.txtPickUpPerson.TabIndex = 11;
            this.txtPickUpPerson.ViewName = "vw_AllProviderSalesman";
            // 
            // cbxDeliveryType
            // 
            this.cbxDeliveryType.AddFirstDefaultItem = false;
            this.cbxDeliveryType.CategoryCode = "DeliveryType";
            this.cbxDeliveryType.FirstDefaultItemText = null;
            this.cbxDeliveryType.FormatQueryString = null;
            this.cbxDeliveryType.Location = new System.Drawing.Point(463, 95);
            this.cbxDeliveryType.Name = "cbxDeliveryType";
            this.cbxDeliveryType.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.cbxDeliveryType.Properties.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.DisableTextEditor;
            this.cbxDeliveryType.SelectedValue = null;
            this.cbxDeliveryType.Size = new System.Drawing.Size(376, 21);
            this.cbxDeliveryType.StyleController = this.layControl;
            this.cbxDeliveryType.TabIndex = 6;
            // 
            // cbxPaymentType
            // 
            this.cbxPaymentType.AddFirstDefaultItem = false;
            this.cbxPaymentType.CategoryCode = "PaymentType";
            this.cbxPaymentType.FirstDefaultItemText = null;
            this.cbxPaymentType.FormatQueryString = null;
            this.cbxPaymentType.Location = new System.Drawing.Point(75, 95);
            this.cbxPaymentType.Name = "cbxPaymentType";
            this.cbxPaymentType.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.cbxPaymentType.Properties.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.DisableTextEditor;
            this.cbxPaymentType.SelectedValue = null;
            this.cbxPaymentType.Size = new System.Drawing.Size(151, 21);
            this.cbxPaymentType.StyleController = this.layControl;
            this.cbxPaymentType.TabIndex = 5;
            // 
            // txtContractNo
            // 
            this.txtContractNo.AlphabeticFiled = null;
            this.txtContractNo.EntityField = DQS.Module.Entities.BUSBillEntityFields2.ContractNo;
            this.txtContractNo.IsIntegerOnly = false;
            this.txtContractNo.IsNullString = null;
            this.txtContractNo.IsNullValidate = false;
            this.txtContractNo.IsTransferAlphabetic = false;
            this.txtContractNo.Location = new System.Drawing.Point(75, 124);
            this.txtContractNo.Name = "txtContractNo";
            this.txtContractNo.Size = new System.Drawing.Size(321, 21);
            this.txtContractNo.StyleController = this.layControl;
            this.txtContractNo.TabIndex = 7;
            // 
            // txtBillCode
            // 
            this.txtBillCode.AlphabeticFiled = null;
            this.txtBillCode.EntityField = DQS.Module.Entities.BUSBillEntityFields2.BillCode;
            this.txtBillCode.IsIntegerOnly = false;
            this.txtBillCode.IsNullString = "销售单号不能为空。";
            this.txtBillCode.IsNullValidate = true;
            this.txtBillCode.IsTransferAlphabetic = false;
            this.txtBillCode.Location = new System.Drawing.Point(269, 12);
            this.txtBillCode.Name = "txtBillCode";
            this.txtBillCode.Properties.ReadOnly = true;
            this.txtBillCode.Size = new System.Drawing.Size(127, 21);
            this.txtBillCode.StyleController = this.layControl;
            this.txtBillCode.TabIndex = 0;
            // 
            // txtOperator
            // 
            this.txtOperator.AlphabeticFiled = "OperatorSpell";
            this.txtOperator.EditData = null;
            this.txtOperator.Fields = null;
            this.txtOperator.Filter = "[岗位名称] = \'业务员\'";
            this.txtOperator.FormatQueryString = "[员工编号] LIKE \'%{0}%\' OR ([员工姓名] LIKE \'%{0}%\' OR [员工姓名Spell] LIKE \'%{0}%\')";
            this.txtOperator.GroupColumn = null;
            this.txtOperator.IsIntegerOnly = false;
            this.txtOperator.IsNullString = null;
            this.txtOperator.IsNullValidate = false;
            this.txtOperator.IsTransferAlphabetic = true;
            this.txtOperator.Location = new System.Drawing.Point(463, 124);
            this.txtOperator.MemberText = "员工姓名";
            this.txtOperator.MemberValue = "员工ID";
            this.txtOperator.Name = "txtOperator";
            this.txtOperator.PageSize = 0;
            this.txtOperator.PrimaryField = "员工ID";
            this.txtOperator.Properties.Appearance.BackColor = System.Drawing.Color.White;
            this.txtOperator.Properties.Appearance.Options.UseBackColor = true;
            this.txtOperator.Properties.ReadOnly = true;
            this.txtOperator.Size = new System.Drawing.Size(376, 21);
            this.txtOperator.StyleController = this.layControl;
            this.txtOperator.TabIndex = 8;
            this.txtOperator.ViewName = "vw_AllEmployee";
            // 
            // txtTotalPrice
            // 
            this.txtTotalPrice.AlphabeticFiled = null;
            this.txtTotalPrice.EditValue = "0";
            this.txtTotalPrice.EntityField = DQS.Module.Entities.BUSBillEntityFields2.TotalPrice;
            this.txtTotalPrice.IsIntegerOnly = false;
            this.txtTotalPrice.IsNullString = null;
            this.txtTotalPrice.IsNullValidate = false;
            this.txtTotalPrice.IsTransferAlphabetic = false;
            this.txtTotalPrice.Location = new System.Drawing.Point(75, 174);
            this.txtTotalPrice.Name = "txtTotalPrice";
            this.txtTotalPrice.Properties.Appearance.BackColor = System.Drawing.Color.White;
            this.txtTotalPrice.Properties.Appearance.Options.UseBackColor = true;
            this.txtTotalPrice.Properties.ReadOnly = true;
            this.txtTotalPrice.Size = new System.Drawing.Size(152, 21);
            this.txtTotalPrice.StyleController = this.layControl;
            this.txtTotalPrice.TabIndex = 9;
            // 
            // txtBusinessPerson
            // 
            this.txtBusinessPerson.AlphabeticFiled = "BusinessPersonSpell";
            this.txtBusinessPerson.EditData = null;
            this.txtBusinessPerson.Fields = null;
            this.txtBusinessPerson.Filter = "[所属岗位] = \'采购员\'";
            this.txtBusinessPerson.FormatQueryString = "[人员编号] LIKE \'%{0}%\' OR ([人员姓名] LIKE \'%{0}%\' OR [人员姓名Spell] LIKE \'%{0}%\')";
            this.txtBusinessPerson.GroupColumn = null;
            this.txtBusinessPerson.IsIntegerOnly = false;
            this.txtBusinessPerson.IsNullString = null;
            this.txtBusinessPerson.IsNullValidate = false;
            this.txtBusinessPerson.IsTransferAlphabetic = true;
            this.txtBusinessPerson.Location = new System.Drawing.Point(75, 224);
            this.txtBusinessPerson.MemberText = "人员姓名";
            this.txtBusinessPerson.MemberValue = "人员ID";
            this.txtBusinessPerson.Name = "txtBusinessPerson";
            this.txtBusinessPerson.PageSize = 0;
            this.txtBusinessPerson.PrimaryField = "人员ID";
            this.txtBusinessPerson.Properties.Appearance.BackColor = System.Drawing.Color.White;
            this.txtBusinessPerson.Properties.Appearance.Options.UseBackColor = true;
            this.txtBusinessPerson.Properties.ReadOnly = true;
            this.txtBusinessPerson.Size = new System.Drawing.Size(321, 21);
            this.txtBusinessPerson.StyleController = this.layControl;
            this.txtBusinessPerson.TabIndex = 12;
            this.txtBusinessPerson.ViewName = "vw_AllProviderSalesman";
            // 
            // txtBusinessPhone
            // 
            this.txtBusinessPhone.AlphabeticFiled = null;
            this.txtBusinessPhone.EntityField = DQS.Module.Entities.BUSBillEntityFields2.BusinessPhone;
            this.txtBusinessPhone.IsIntegerOnly = false;
            this.txtBusinessPhone.IsNullString = null;
            this.txtBusinessPhone.IsNullValidate = false;
            this.txtBusinessPhone.IsTransferAlphabetic = false;
            this.txtBusinessPhone.Location = new System.Drawing.Point(463, 224);
            this.txtBusinessPhone.Name = "txtBusinessPhone";
            this.txtBusinessPhone.Size = new System.Drawing.Size(376, 21);
            this.txtBusinessPhone.StyleController = this.layControl;
            this.txtBusinessPhone.TabIndex = 13;
            // 
            // txtDealerAddress
            // 
            this.txtDealerAddress.Location = new System.Drawing.Point(75, 70);
            this.txtDealerAddress.Name = "txtDealerAddress";
            this.txtDealerAddress.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.txtDealerAddress.Size = new System.Drawing.Size(321, 21);
            this.txtDealerAddress.StyleController = this.layControl;
            this.txtDealerAddress.TabIndex = 4;
            // 
            // layControlGroup
            // 
            this.layControlGroup.AppearanceItemCaption.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.layControlGroup.AppearanceItemCaption.Options.UseFont = true;
            this.layControlGroup.CustomizationFormText = "销售订单";
            this.layControlGroup.EnableIndentsWithoutBorders = DevExpress.Utils.DefaultBoolean.True;
            this.layControlGroup.GroupBordersVisible = false;
            this.layControlGroup.Items.AddRange(new DevExpress.XtraLayout.BaseLayoutItem[] {
            this.layBillCode,
            this.layDealerAddress,
            this.layPaymentType,
            this.layTotalPrice,
            this.layContractNo,
            this.layProductAmount,
            this.layDealerCode,
            this.layBusinessPerson,
            this.layPickUpPerson,
            this.layBusinessPhone,
            this.layDeliveryType,
            this.layOperator,
            this.layBillStyle,
            this.emptySpaceItem1,
            this.layRemark,
            this.layoutControlDel,
            this.layPrice,
            this.layReservation6,
            this.layReservation11,
            this.layReservation12,
            this.layReservation13,
            this.layReservation14,
            this.layReservation15,
            this.layDepartment,
            this.layoutControlItem1,
            this.layPaymentTypeName,
            this.layReservation9,
            this.layDiscount,
            this.layDealerArea,
            this.layDealerName,
            this.layOutBillCode});
            this.layControlGroup.Location = new System.Drawing.Point(0, 0);
            this.layControlGroup.Name = "layControlGroup";
            this.layControlGroup.Size = new System.Drawing.Size(851, 357);
            this.layControlGroup.Spacing = new DevExpress.XtraLayout.Utils.Padding(0, 0, 0, 0);
            this.layControlGroup.Text = "销售订单";
            this.layControlGroup.TextVisible = false;
            // 
            // layBillCode
            // 
            this.layBillCode.Control = this.txtBillCode;
            this.layBillCode.CustomizationFormText = "销售单号";
            this.layBillCode.Location = new System.Drawing.Point(194, 0);
            this.layBillCode.Name = "layBillCode";
            this.layBillCode.Size = new System.Drawing.Size(194, 33);
            this.layBillCode.Text = "销售单号";
            this.layBillCode.TextSize = new System.Drawing.Size(60, 17);
            // 
            // layDealerAddress
            // 
            this.layDealerAddress.Control = this.txtDealerAddress;
            this.layDealerAddress.CustomizationFormText = "收货地址";
            this.layDealerAddress.Location = new System.Drawing.Point(0, 58);
            this.layDealerAddress.Name = "layDealerAddress";
            this.layDealerAddress.Size = new System.Drawing.Size(388, 25);
            this.layDealerAddress.Text = "收货地址";
            this.layDealerAddress.TextSize = new System.Drawing.Size(60, 17);
            // 
            // layPaymentType
            // 
            this.layPaymentType.Control = this.cbxPaymentType;
            this.layPaymentType.CustomizationFormText = "付款方式";
            this.layPaymentType.Location = new System.Drawing.Point(0, 83);
            this.layPaymentType.Name = "layPaymentType";
            this.layPaymentType.Size = new System.Drawing.Size(218, 29);
            this.layPaymentType.Text = "付款方式";
            this.layPaymentType.TextSize = new System.Drawing.Size(60, 17);
            // 
            // layTotalPrice
            // 
            this.layTotalPrice.Control = this.txtTotalPrice;
            this.layTotalPrice.CustomizationFormText = "订单总额";
            this.layTotalPrice.Location = new System.Drawing.Point(0, 162);
            this.layTotalPrice.Name = "layTotalPrice";
            this.layTotalPrice.Size = new System.Drawing.Size(219, 25);
            this.layTotalPrice.Text = "订单总额";
            this.layTotalPrice.TextSize = new System.Drawing.Size(60, 17);
            // 
            // layContractNo
            // 
            this.layContractNo.Control = this.txtContractNo;
            this.layContractNo.CustomizationFormText = "合同号";
            this.layContractNo.Location = new System.Drawing.Point(0, 112);
            this.layContractNo.Name = "layContractNo";
            this.layContractNo.Size = new System.Drawing.Size(388, 25);
            this.layContractNo.Text = "合同号";
            this.layContractNo.TextSize = new System.Drawing.Size(60, 17);
            // 
            // layProductAmount
            // 
            this.layProductAmount.Control = this.txtProductAmount;
            this.layProductAmount.CustomizationFormText = "商品品种";
            this.layProductAmount.Location = new System.Drawing.Point(388, 162);
            this.layProductAmount.Name = "layProductAmount";
            this.layProductAmount.Size = new System.Drawing.Size(443, 25);
            this.layProductAmount.Text = "商品品种";
            this.layProductAmount.TextSize = new System.Drawing.Size(60, 17);
            // 
            // layDealerCode
            // 
            this.layDealerCode.Control = this.txtDealerCode;
            this.layDealerCode.CustomizationFormText = "往来单位编号";
            this.layDealerCode.Location = new System.Drawing.Point(388, 33);
            this.layDealerCode.Name = "layDealerCode";
            this.layDealerCode.Size = new System.Drawing.Size(443, 25);
            this.layDealerCode.Text = "客户编号";
            this.layDealerCode.TextSize = new System.Drawing.Size(60, 17);
            // 
            // layBusinessPerson
            // 
            this.layBusinessPerson.Control = this.txtBusinessPerson;
            this.layBusinessPerson.CustomizationFormText = "采购人";
            this.layBusinessPerson.Location = new System.Drawing.Point(0, 212);
            this.layBusinessPerson.Name = "layBusinessPerson";
            this.layBusinessPerson.ShowInCustomizationForm = false;
            this.layBusinessPerson.Size = new System.Drawing.Size(388, 25);
            this.layBusinessPerson.Text = "采购人";
            this.layBusinessPerson.TextSize = new System.Drawing.Size(60, 17);
            // 
            // layPickUpPerson
            // 
            this.layPickUpPerson.Control = this.txtPickUpPerson;
            this.layPickUpPerson.CustomizationFormText = "收货人";
            this.layPickUpPerson.Location = new System.Drawing.Point(0, 187);
            this.layPickUpPerson.Name = "layPickUpPerson";
            this.layPickUpPerson.ShowInCustomizationForm = false;
            this.layPickUpPerson.Size = new System.Drawing.Size(388, 25);
            this.layPickUpPerson.Text = "收货人";
            this.layPickUpPerson.TextSize = new System.Drawing.Size(60, 17);
            // 
            // layBusinessPhone
            // 
            this.layBusinessPhone.Control = this.txtBusinessPhone;
            this.layBusinessPhone.CustomizationFormText = "采购人电话";
            this.layBusinessPhone.Location = new System.Drawing.Point(388, 212);
            this.layBusinessPhone.Name = "layBusinessPhone";
            this.layBusinessPhone.ShowInCustomizationForm = false;
            this.layBusinessPhone.Size = new System.Drawing.Size(443, 25);
            this.layBusinessPhone.Text = "采购人电话";
            this.layBusinessPhone.TextSize = new System.Drawing.Size(60, 17);
            // 
            // layDeliveryType
            // 
            this.layDeliveryType.Control = this.cbxDeliveryType;
            this.layDeliveryType.CustomizationFormText = "配送方式";
            this.layDeliveryType.Location = new System.Drawing.Point(388, 83);
            this.layDeliveryType.Name = "layDeliveryType";
            this.layDeliveryType.Size = new System.Drawing.Size(443, 29);
            this.layDeliveryType.Text = "配送方式";
            this.layDeliveryType.TextSize = new System.Drawing.Size(60, 17);
            // 
            // layOperator
            // 
            this.layOperator.Control = this.txtOperator;
            this.layOperator.CustomizationFormText = "业务员";
            this.layOperator.Location = new System.Drawing.Point(388, 112);
            this.layOperator.Name = "layOperator";
            this.layOperator.Size = new System.Drawing.Size(443, 25);
            this.layOperator.Text = "业务员";
            this.layOperator.TextSize = new System.Drawing.Size(60, 17);
            // 
            // layBillStyle
            // 
            this.layBillStyle.Control = this.rdgBillStyle;
            this.layBillStyle.CustomizationFormText = "类型";
            this.layBillStyle.Location = new System.Drawing.Point(388, 0);
            this.layBillStyle.MinSize = new System.Drawing.Size(147, 33);
            this.layBillStyle.Name = "layBillStyle";
            this.layBillStyle.Size = new System.Drawing.Size(204, 33);
            this.layBillStyle.SizeConstraintsType = DevExpress.XtraLayout.SizeConstraintsType.Custom;
            this.layBillStyle.Text = "类型";
            this.layBillStyle.TextSize = new System.Drawing.Size(60, 17);
            // 
            // emptySpaceItem1
            // 
            this.emptySpaceItem1.CustomizationFormText = "emptySpaceItem1";
            this.emptySpaceItem1.Location = new System.Drawing.Point(592, 0);
            this.emptySpaceItem1.Name = "emptySpaceItem1";
            this.emptySpaceItem1.Size = new System.Drawing.Size(239, 33);
            this.emptySpaceItem1.Text = "emptySpaceItem1";
            this.emptySpaceItem1.TextSize = new System.Drawing.Size(0, 0);
            // 
            // layRemark
            // 
            this.layRemark.Control = this.txtBillRemark;
            this.layRemark.CustomizationFormText = "备注";
            this.layRemark.Location = new System.Drawing.Point(388, 237);
            this.layRemark.Name = "layRemark";
            this.layRemark.Size = new System.Drawing.Size(443, 25);
            this.layRemark.Text = "备注";
            this.layRemark.TextSize = new System.Drawing.Size(60, 17);
            // 
            // layoutControlDel
            // 
            this.layoutControlDel.Control = this.busBillEntityTextBox1;
            this.layoutControlDel.CustomizationFormText = "删除原因";
            this.layoutControlDel.Location = new System.Drawing.Point(0, 262);
            this.layoutControlDel.Name = "layoutControlDel";
            this.layoutControlDel.Size = new System.Drawing.Size(831, 25);
            this.layoutControlDel.Text = "删除原因";
            this.layoutControlDel.TextSize = new System.Drawing.Size(60, 17);
            this.layoutControlDel.Visibility = DevExpress.XtraLayout.Utils.LayoutVisibility.Never;
            // 
            // layPrice
            // 
            this.layPrice.Control = this.cbxPrice;
            this.layPrice.CustomizationFormText = "销售价格表";
            this.layPrice.Location = new System.Drawing.Point(0, 137);
            this.layPrice.Name = "layPrice";
            this.layPrice.Size = new System.Drawing.Size(388, 25);
            this.layPrice.Text = "销售价格表";
            this.layPrice.TextSize = new System.Drawing.Size(60, 17);
            // 
            // layReservation6
            // 
            this.layReservation6.Control = this.txtReservation6;
            this.layReservation6.CustomizationFormText = "开票员";
            this.layReservation6.Location = new System.Drawing.Point(388, 137);
            this.layReservation6.Name = "layReservation6";
            this.layReservation6.Size = new System.Drawing.Size(443, 25);
            this.layReservation6.Text = "开票员";
            this.layReservation6.TextSize = new System.Drawing.Size(60, 17);
            // 
            // layReservation11
            // 
            this.layReservation11.Control = this.txtReservation11;
            this.layReservation11.CustomizationFormText = "layoutControlItem1";
            this.layReservation11.Location = new System.Drawing.Point(0, 287);
            this.layReservation11.Name = "layReservation11";
            this.layReservation11.Size = new System.Drawing.Size(297, 25);
            this.layReservation11.Text = "病人姓名";
            this.layReservation11.TextSize = new System.Drawing.Size(60, 17);
            this.layReservation11.Visibility = DevExpress.XtraLayout.Utils.LayoutVisibility.Never;
            // 
            // layReservation12
            // 
            this.layReservation12.Control = this.txtReservation12;
            this.layReservation12.CustomizationFormText = "layoutControlItem2";
            this.layReservation12.Location = new System.Drawing.Point(297, 287);
            this.layReservation12.Name = "layReservation12";
            this.layReservation12.Size = new System.Drawing.Size(277, 25);
            this.layReservation12.Text = "病历号";
            this.layReservation12.TextSize = new System.Drawing.Size(60, 17);
            this.layReservation12.Visibility = DevExpress.XtraLayout.Utils.LayoutVisibility.Never;
            // 
            // layReservation13
            // 
            this.layReservation13.Control = this.txtReservation13;
            this.layReservation13.CustomizationFormText = "layoutControlItem3";
            this.layReservation13.Location = new System.Drawing.Point(574, 287);
            this.layReservation13.Name = "layReservation13";
            this.layReservation13.Size = new System.Drawing.Size(257, 25);
            this.layReservation13.Text = "医生";
            this.layReservation13.TextSize = new System.Drawing.Size(60, 17);
            this.layReservation13.Visibility = DevExpress.XtraLayout.Utils.LayoutVisibility.Never;
            // 
            // layReservation14
            // 
            this.layReservation14.Control = this.txtReservation14;
            this.layReservation14.CustomizationFormText = "layoutControlItem4";
            this.layReservation14.Location = new System.Drawing.Point(0, 312);
            this.layReservation14.Name = "layReservation14";
            this.layReservation14.Size = new System.Drawing.Size(297, 25);
            this.layReservation14.Text = "手术类型";
            this.layReservation14.TextSize = new System.Drawing.Size(60, 17);
            this.layReservation14.Visibility = DevExpress.XtraLayout.Utils.LayoutVisibility.Never;
            // 
            // layReservation15
            // 
            this.layReservation15.Control = this.txtReservation15;
            this.layReservation15.CustomizationFormText = "layoutControlItem5";
            this.layReservation15.Location = new System.Drawing.Point(297, 312);
            this.layReservation15.Name = "layReservation15";
            this.layReservation15.Size = new System.Drawing.Size(534, 25);
            this.layReservation15.Text = "住院号";
            this.layReservation15.TextSize = new System.Drawing.Size(60, 17);
            this.layReservation15.Visibility = DevExpress.XtraLayout.Utils.LayoutVisibility.Never;
            // 
            // layDepartment
            // 
            this.layDepartment.Control = this.cboDepartment;
            this.layDepartment.CustomizationFormText = "部门";
            this.layDepartment.Location = new System.Drawing.Point(388, 187);
            this.layDepartment.Name = "layDepartment";
            this.layDepartment.Size = new System.Drawing.Size(443, 25);
            this.layDepartment.Text = "部门";
            this.layDepartment.TextSize = new System.Drawing.Size(60, 17);
            this.layDepartment.Visibility = DevExpress.XtraLayout.Utils.LayoutVisibility.Never;
            // 
            // layoutControlItem1
            // 
            this.layoutControlItem1.Control = this.txtInvoiceContent;
            this.layoutControlItem1.CustomizationFormText = "利润率";
            this.layoutControlItem1.Location = new System.Drawing.Point(219, 162);
            this.layoutControlItem1.Name = "layoutControlItem1";
            this.layoutControlItem1.Size = new System.Drawing.Size(169, 25);
            this.layoutControlItem1.Text = "利润率";
            this.layoutControlItem1.TextSize = new System.Drawing.Size(60, 17);
            this.layoutControlItem1.Visibility = DevExpress.XtraLayout.Utils.LayoutVisibility.Never;
            // 
            // layPaymentTypeName
            // 
            this.layPaymentTypeName.Control = this.rdgPaymentType;
            this.layPaymentTypeName.CustomizationFormText = "收款类型";
            this.layPaymentTypeName.Location = new System.Drawing.Point(218, 83);
            this.layPaymentTypeName.Name = "layPaymentTypeName";
            this.layPaymentTypeName.Size = new System.Drawing.Size(170, 29);
            this.layPaymentTypeName.Text = "收款类型";
            this.layPaymentTypeName.TextSize = new System.Drawing.Size(60, 17);
            // 
            // layReservation9
            // 
            this.layReservation9.Control = this.txtReservation9;
            this.layReservation9.CustomizationFormText = "说明";
            this.layReservation9.Location = new System.Drawing.Point(194, 237);
            this.layReservation9.Name = "layReservation9";
            this.layReservation9.Size = new System.Drawing.Size(194, 25);
            this.layReservation9.Text = "说明";
            this.layReservation9.TextSize = new System.Drawing.Size(60, 17);
            // 
            // layDiscount
            // 
            this.layDiscount.Control = this.txtDiscount;
            this.layDiscount.CustomizationFormText = "提示";
            this.layDiscount.Location = new System.Drawing.Point(0, 237);
            this.layDiscount.Name = "layDiscount";
            this.layDiscount.Size = new System.Drawing.Size(194, 25);
            this.layDiscount.Text = "提示";
            this.layDiscount.TextSize = new System.Drawing.Size(60, 17);
            // 
            // layDealerArea
            // 
            this.layDealerArea.Control = this.txtDealerArea;
            this.layDealerArea.CustomizationFormText = "销售区域";
            this.layDealerArea.Location = new System.Drawing.Point(388, 58);
            this.layDealerArea.Name = "layDealerArea";
            this.layDealerArea.Size = new System.Drawing.Size(443, 25);
            this.layDealerArea.Text = "销售区域";
            this.layDealerArea.TextSize = new System.Drawing.Size(60, 17);
            // 
            // layDealerName
            // 
            this.layDealerName.Control = this.txtDealerName;
            this.layDealerName.CustomizationFormText = "客户名称";
            this.layDealerName.Location = new System.Drawing.Point(0, 33);
            this.layDealerName.Name = "layDealerName";
            this.layDealerName.Size = new System.Drawing.Size(388, 25);
            this.layDealerName.Text = "客户名称";
            this.layDealerName.TextSize = new System.Drawing.Size(60, 17);
            // 
            // layOutBillCode
            // 
            this.layOutBillCode.Control = this.txtOutBillCode;
            this.layOutBillCode.CustomizationFormText = "订单号";
            this.layOutBillCode.Location = new System.Drawing.Point(0, 0);
            this.layOutBillCode.Name = "layOutBillCode";
            this.layOutBillCode.Size = new System.Drawing.Size(194, 33);
            this.layOutBillCode.Text = "订单号";
            this.layOutBillCode.TextSize = new System.Drawing.Size(60, 17);
            // 
            // FrmSingleOutSale
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 14F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(872, 531);
            this.Controls.Add(this.groupControl);
            this.Controls.Add(this.panelAction);
            this.Controls.Add(this.ftPanel);
            this.Name = "FrmSingleOutSale";
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "销售订单";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.FrmSingleOutSale_Load);
            ((System.ComponentModel.ISupportInitialize)(this.groupControl)).EndInit();
            this.groupControl.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.gridControl2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridControl1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.panelAction)).EndInit();
            this.panelAction.ResumeLayout(false);
            this.panelAction.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ftPanel)).EndInit();
            this.ftPanel.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.layControl)).EndInit();
            this.layControl.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.txtOutBillCode.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtDealerName.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtDealerArea.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtDiscount.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtReservation9.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtInvoiceContent.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cboDepartment.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtReservation15.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtReservation14.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtReservation13.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtReservation12.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.rdgPaymentType.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtReservation11.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtReservation6.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cbxPrice.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.busBillEntityTextBox1.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtBillRemark.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.rdgBillStyle.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtDealerCode.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtProductAmount.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtPickUpPerson.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cbxDeliveryType.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cbxPaymentType.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtContractNo.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtBillCode.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtOperator.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtTotalPrice.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtBusinessPerson.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtBusinessPhone.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtDealerAddress.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layControlGroup)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layBillCode)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layDealerAddress)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layPaymentType)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layTotalPrice)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layContractNo)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layProductAmount)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layDealerCode)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layBusinessPerson)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layPickUpPerson)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layBusinessPhone)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layDeliveryType)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layOperator)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layBillStyle)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.emptySpaceItem1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layRemark)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlDel)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layPrice)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layReservation6)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layReservation11)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layReservation12)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layReservation13)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layReservation14)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layReservation15)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layDepartment)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layPaymentTypeName)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layReservation9)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layDiscount)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layDealerArea)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layDealerName)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layOutBillCode)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraEditors.GroupControl groupControl;
        private DevExpress.XtraEditors.PanelControl panelAction;
        private DevExpress.XtraEditors.LabelControl lblStyleName;
        private DevExpress.XtraEditors.LabelControl lblStyleID;
        private DevExpress.XtraEditors.SimpleButton btnViewHistory;
        private DevExpress.XtraEditors.SimpleButton btnCancel;
        private DevExpress.XtraEditors.SimpleButton btnSaveAndOut;
        private DevExpress.XtraEditors.SimpleButton btnAcceptReport;
        private DevExpress.XtraEditors.SimpleButton btnSave;
        private Controls.StiPrintButtonEx btnPrint;
        private DevExpress.XtraEditors.SimpleButton btnFix;
        private Controls.FieldTextBoxPanel ftPanel;
        private DevExpress.XtraLayout.LayoutControl layControl;
        private DevExpress.XtraEditors.ComboBoxEdit txtDealerArea;
        private Controls.BUSBillEntityTextBox txtDiscount;
        private Controls.BUSBillEntityTextBox txtReservation9;
        private Controls.BUSBillEntityTextBox txtInvoiceContent;
        private Controls.ComboBoxCategoryEx cboDepartment;
        private Controls.BUSBillEntityTextBox txtReservation15;
        private Controls.BUSBillEntityTextBox txtReservation14;
        private Controls.BUSBillEntityTextBox txtReservation13;
        private Controls.BUSBillEntityTextBox txtReservation12;
        private DevExpress.XtraEditors.RadioGroup rdgPaymentType;
        private Controls.BUSBillEntityTextBox txtReservation11;
        private Controls.TextBoxEnterPopupEx txtReservation6;
        private DevExpress.XtraEditors.LookUpEdit cbxPrice;
        private Controls.BUSBillEntityTextBox busBillEntityTextBox1;
        private Controls.BUSBillEntityTextBox txtBillRemark;
        private DevExpress.XtraEditors.RadioGroup rdgBillStyle;
        private Controls.BUSBillEntityTextBox txtDealerCode;
        private Controls.BUSBillEntityTextBox txtProductAmount;
        private Controls.TextBoxPopupEx txtPickUpPerson;
        private Controls.ComboBoxCategoryEx cbxDeliveryType;
        private Controls.ComboBoxCategoryEx cbxPaymentType;
        private Controls.BUSBillEntityTextBox txtContractNo;
        private Controls.BUSBillEntityTextBox txtBillCode;
        private Controls.TextBoxEnterPopupEx txtOperator;
        private Controls.BUSBillEntityTextBox txtTotalPrice;
        private Controls.TextBoxPopupEx txtBusinessPerson;
        private Controls.BUSBillEntityTextBox txtBusinessPhone;
        private DevExpress.XtraEditors.ComboBoxEdit txtDealerAddress;
        private DevExpress.XtraLayout.LayoutControlGroup layControlGroup;
        private DevExpress.XtraLayout.LayoutControlItem layBillCode;
        private DevExpress.XtraLayout.LayoutControlItem layDealerAddress;
        private DevExpress.XtraLayout.LayoutControlItem layPaymentType;
        private DevExpress.XtraLayout.LayoutControlItem layTotalPrice;
        private DevExpress.XtraLayout.LayoutControlItem layContractNo;
        private DevExpress.XtraLayout.LayoutControlItem layProductAmount;
        private DevExpress.XtraLayout.LayoutControlItem layDealerCode;
        private DevExpress.XtraLayout.LayoutControlItem layBusinessPerson;
        private DevExpress.XtraLayout.LayoutControlItem layPickUpPerson;
        private DevExpress.XtraLayout.LayoutControlItem layBusinessPhone;
        private DevExpress.XtraLayout.LayoutControlItem layDeliveryType;
        private DevExpress.XtraLayout.LayoutControlItem layOperator;
        private DevExpress.XtraLayout.LayoutControlItem layBillStyle;
        private DevExpress.XtraLayout.EmptySpaceItem emptySpaceItem1;
        private DevExpress.XtraLayout.LayoutControlItem layRemark;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlDel;
        private DevExpress.XtraLayout.LayoutControlItem layPrice;
        private DevExpress.XtraLayout.LayoutControlItem layReservation6;
        private DevExpress.XtraLayout.LayoutControlItem layReservation11;
        private DevExpress.XtraLayout.LayoutControlItem layReservation12;
        private DevExpress.XtraLayout.LayoutControlItem layReservation13;
        private DevExpress.XtraLayout.LayoutControlItem layReservation14;
        private DevExpress.XtraLayout.LayoutControlItem layReservation15;
        private DevExpress.XtraLayout.LayoutControlItem layDepartment;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlItem1;
        private DevExpress.XtraLayout.LayoutControlItem layPaymentTypeName;
        private DevExpress.XtraLayout.LayoutControlItem layReservation9;
        private DevExpress.XtraLayout.LayoutControlItem layDiscount;
        private DevExpress.XtraLayout.LayoutControlItem layDealerArea;
        private Controls.BUSBillEntityTextBox txtDealerName;
        private DevExpress.XtraLayout.LayoutControlItem layDealerName;
        private DevExpress.XtraGrid.GridControl gridControl2;
        private DevExpress.XtraGrid.Views.Grid.GridView gridView2;
        private DevExpress.XtraGrid.GridControl gridControl1;
        private DevExpress.XtraGrid.Views.Grid.GridView gridView1;
        private DevExpress.XtraGrid.Columns.GridColumn ColInStoreID;
        private DevExpress.XtraGrid.Columns.GridColumn colProductID;
        private DevExpress.XtraGrid.Columns.GridColumn colProductCode;
        private DevExpress.XtraGrid.Columns.GridColumn colProductName;
        private DevExpress.XtraGrid.Columns.GridColumn colBatchNo;
        private DevExpress.XtraGrid.Columns.GridColumn colProduceDate;
        private DevExpress.XtraGrid.Columns.GridColumn colValidateDate;
        private DevExpress.XtraGrid.Columns.GridColumn colOutAmount;
        private DevExpress.XtraGrid.Columns.GridColumn colStoreAmount;
        private DevExpress.XtraGrid.Columns.GridColumn colUnitPrice;
        private DevExpress.XtraGrid.Columns.GridColumn colTotalPrice;
        private DevExpress.XtraGrid.Columns.GridColumn colTradePrice;
        private DevExpress.XtraGrid.Columns.GridColumn RetailPrice;
        private Controls.BUSBillEntityTextBox txtOutBillCode;
        private DevExpress.XtraLayout.LayoutControlItem layOutBillCode;
    }
}