namespace DQS.AppViews.Operation.BackManager
{
    partial class FrmSingleSaleBackChangeHistory
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
            this.ftPanel = new DQS.Controls.FieldTextBoxPanel();
            this.layControl = new DevExpress.XtraLayout.LayoutControl();
            this.txtReason = new DQS.Controls.BUSBillChangeHistoryEntityTextBox();
            this.rdgBillStyle = new DevExpress.XtraEditors.RadioGroup();
            this.txtReviewCode = new DQS.Controls.BUSBillChangeHistoryEntityTextBox();
            this.txtSaleBillCode = new DQS.Controls.BUSBillChangeHistoryEntityTextBox();
            this.cbxDeliveryType = new DQS.Controls.ComboBoxCategoryEx();
            this.cbxPaymentType = new DQS.Controls.ComboBoxCategoryEx();
            this.txtBillCode = new DQS.Controls.BUSBillChangeHistoryEntityTextBox();
            this.txtDealerName = new DQS.Controls.BUSBillChangeHistoryEntityTextBox();
            this.txtTotalPrice = new DQS.Controls.BUSBillChangeHistoryEntityTextBox();
            this.layControlGroup = new DevExpress.XtraLayout.LayoutControlGroup();
            this.layBillCode = new DevExpress.XtraLayout.LayoutControlItem();
            this.layPaymentType = new DevExpress.XtraLayout.LayoutControlItem();
            this.layTotalPrice = new DevExpress.XtraLayout.LayoutControlItem();
            this.layBillStyle = new DevExpress.XtraLayout.LayoutControlItem();
            this.laySaleBillCode = new DevExpress.XtraLayout.LayoutControlItem();
            this.layDealerName = new DevExpress.XtraLayout.LayoutControlItem();
            this.layReviewCode = new DevExpress.XtraLayout.LayoutControlItem();
            this.layDeliveryType = new DevExpress.XtraLayout.LayoutControlItem();
            this.emptySpaceItem1 = new DevExpress.XtraLayout.EmptySpaceItem();
            this.layReason = new DevExpress.XtraLayout.LayoutControlItem();
            this.panelAction = new DevExpress.XtraEditors.PanelControl();
            this.btnCancel = new DevExpress.XtraEditors.SimpleButton();
            this.groupControl = new DevExpress.XtraEditors.GroupControl();
            this.popupGrid = new DQS.Controls.PopupGrid();
            this.splitterControl1 = new DevExpress.XtraEditors.SplitterControl();
            this.groupControl1 = new DevExpress.XtraEditors.GroupControl();
            this.lbcHistories = new DevExpress.XtraEditors.ListBoxControl();
            this.groupControl2 = new DevExpress.XtraEditors.GroupControl();
            ((System.ComponentModel.ISupportInitialize)(this.ftPanel)).BeginInit();
            this.ftPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.layControl)).BeginInit();
            this.layControl.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.txtReason.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.rdgBillStyle.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtReviewCode.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtSaleBillCode.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cbxDeliveryType.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cbxPaymentType.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtBillCode.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtDealerName.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtTotalPrice.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layControlGroup)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layBillCode)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layPaymentType)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layTotalPrice)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layBillStyle)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.laySaleBillCode)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layDealerName)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layReviewCode)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layDeliveryType)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.emptySpaceItem1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layReason)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.panelAction)).BeginInit();
            this.panelAction.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.groupControl)).BeginInit();
            this.groupControl.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.popupGrid)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.groupControl1)).BeginInit();
            this.groupControl1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.lbcHistories)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.groupControl2)).BeginInit();
            this.groupControl2.SuspendLayout();
            this.SuspendLayout();
            // 
            // ftPanel
            // 
            this.ftPanel.Controls.Add(this.layControl);
            this.ftPanel.Dock = System.Windows.Forms.DockStyle.Top;
            this.ftPanel.Location = new System.Drawing.Point(2, 27);
            this.ftPanel.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.ftPanel.Name = "ftPanel";
            this.ftPanel.Size = new System.Drawing.Size(671, 210);
            this.ftPanel.TabIndex = 0;
            this.ftPanel.TypeOfEntity = DQS.Module.EntityType2.BUSBillEntity;
            // 
            // layControl
            // 
            this.layControl.Controls.Add(this.txtReason);
            this.layControl.Controls.Add(this.rdgBillStyle);
            this.layControl.Controls.Add(this.txtReviewCode);
            this.layControl.Controls.Add(this.txtSaleBillCode);
            this.layControl.Controls.Add(this.cbxDeliveryType);
            this.layControl.Controls.Add(this.cbxPaymentType);
            this.layControl.Controls.Add(this.txtBillCode);
            this.layControl.Controls.Add(this.txtDealerName);
            this.layControl.Controls.Add(this.txtTotalPrice);
            this.layControl.Dock = System.Windows.Forms.DockStyle.Fill;
            this.layControl.Location = new System.Drawing.Point(2, 2);
            this.layControl.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.layControl.Name = "layControl";
            this.layControl.Root = this.layControlGroup;
            this.layControl.Size = new System.Drawing.Size(667, 206);
            this.layControl.TabIndex = 0;
            this.layControl.Text = "layControl";
            // 
            // txtReason
            // 
            this.txtReason.AlphabeticFiled = null;
            this.txtReason.EntityField = DQS.Module.Entities.BUSBillChangeHistoryEntityFields2.BillRemark;
            this.txtReason.IsIntegerOnly = false;
            this.txtReason.IsNullString = "销退原因不能为空。";
            this.txtReason.IsNullValidate = true;
            this.txtReason.IsTransferAlphabetic = false;
            this.txtReason.Location = new System.Drawing.Point(105, 132);
            this.txtReason.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtReason.Name = "txtReason";
            this.txtReason.Properties.ReadOnly = true;
            this.txtReason.Size = new System.Drawing.Size(550, 25);
            this.txtReason.StyleController = this.layControl;
            this.txtReason.TabIndex = 4;
            // 
            // rdgBillStyle
            // 
            this.rdgBillStyle.EditValue = "正常";
            this.rdgBillStyle.Location = new System.Drawing.Point(428, 12);
            this.rdgBillStyle.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.rdgBillStyle.Name = "rdgBillStyle";
            this.rdgBillStyle.Properties.Appearance.BackColor = System.Drawing.Color.Transparent;
            this.rdgBillStyle.Properties.Appearance.Options.UseBackColor = true;
            this.rdgBillStyle.Properties.Columns = 3;
            this.rdgBillStyle.Properties.Items.AddRange(new DevExpress.XtraEditors.Controls.RadioGroupItem[] {
            new DevExpress.XtraEditors.Controls.RadioGroupItem("正常", "正常"),
            new DevExpress.XtraEditors.Controls.RadioGroupItem("追回", "追回"),
            new DevExpress.XtraEditors.Controls.RadioGroupItem("召回", "召回")});
            this.rdgBillStyle.Properties.ReadOnly = true;
            this.rdgBillStyle.Size = new System.Drawing.Size(168, 29);
            this.rdgBillStyle.StyleController = this.layControl;
            this.rdgBillStyle.TabIndex = 18;
            // 
            // txtReviewCode
            // 
            this.txtReviewCode.AlphabeticFiled = null;
            this.txtReviewCode.EntityField = DQS.Module.Entities.BUSBillChangeHistoryEntityFields2.ReviewCode;
            this.txtReviewCode.IsIntegerOnly = false;
            this.txtReviewCode.IsNullString = "";
            this.txtReviewCode.IsNullValidate = false;
            this.txtReviewCode.IsTransferAlphabetic = false;
            this.txtReviewCode.Location = new System.Drawing.Point(428, 74);
            this.txtReviewCode.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtReviewCode.Name = "txtReviewCode";
            this.txtReviewCode.Properties.ReadOnly = true;
            this.txtReviewCode.Size = new System.Drawing.Size(227, 25);
            this.txtReviewCode.StyleController = this.layControl;
            this.txtReviewCode.TabIndex = 4;
            // 
            // txtSaleBillCode
            // 
            this.txtSaleBillCode.AlphabeticFiled = null;
            this.txtSaleBillCode.EntityField = DQS.Module.Entities.BUSBillChangeHistoryEntityFields2.SaleBillCode;
            this.txtSaleBillCode.IsIntegerOnly = false;
            this.txtSaleBillCode.IsNullString = "";
            this.txtSaleBillCode.IsNullValidate = false;
            this.txtSaleBillCode.IsTransferAlphabetic = false;
            this.txtSaleBillCode.Location = new System.Drawing.Point(105, 74);
            this.txtSaleBillCode.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtSaleBillCode.Name = "txtSaleBillCode";
            this.txtSaleBillCode.Properties.ReadOnly = true;
            this.txtSaleBillCode.Size = new System.Drawing.Size(226, 25);
            this.txtSaleBillCode.StyleController = this.layControl;
            this.txtSaleBillCode.TabIndex = 4;
            // 
            // cbxDeliveryType
            // 
            this.cbxDeliveryType.CategoryCode = "DeliveryType";
            this.cbxDeliveryType.Location = new System.Drawing.Point(428, 103);
            this.cbxDeliveryType.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.cbxDeliveryType.Name = "cbxDeliveryType";
            this.cbxDeliveryType.Properties.Appearance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(247)))), ((int)(((byte)(245)))), ((int)(((byte)(241)))));
            this.cbxDeliveryType.Properties.Appearance.Options.UseBackColor = true;
            this.cbxDeliveryType.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.cbxDeliveryType.Properties.ReadOnly = true;
            this.cbxDeliveryType.Properties.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.DisableTextEditor;
            this.cbxDeliveryType.SelectedValue = null;
            this.cbxDeliveryType.Size = new System.Drawing.Size(227, 25);
            this.cbxDeliveryType.StyleController = this.layControl;
            this.cbxDeliveryType.TabIndex = 13;
            // 
            // cbxPaymentType
            // 
            this.cbxPaymentType.CategoryCode = "PaymentType";
            this.cbxPaymentType.Location = new System.Drawing.Point(105, 103);
            this.cbxPaymentType.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.cbxPaymentType.Name = "cbxPaymentType";
            this.cbxPaymentType.Properties.Appearance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(247)))), ((int)(((byte)(245)))), ((int)(((byte)(241)))));
            this.cbxPaymentType.Properties.Appearance.Options.UseBackColor = true;
            this.cbxPaymentType.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.cbxPaymentType.Properties.ReadOnly = true;
            this.cbxPaymentType.Properties.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.DisableTextEditor;
            this.cbxPaymentType.SelectedValue = null;
            this.cbxPaymentType.Size = new System.Drawing.Size(226, 25);
            this.cbxPaymentType.StyleController = this.layControl;
            this.cbxPaymentType.TabIndex = 12;
            // 
            // txtBillCode
            // 
            this.txtBillCode.AlphabeticFiled = null;
            this.txtBillCode.EntityField = DQS.Module.Entities.BUSBillChangeHistoryEntityFields2.BillCode;
            this.txtBillCode.IsIntegerOnly = false;
            this.txtBillCode.IsNullString = "销售单号不能为空。";
            this.txtBillCode.IsNullValidate = true;
            this.txtBillCode.IsTransferAlphabetic = false;
            this.txtBillCode.Location = new System.Drawing.Point(105, 12);
            this.txtBillCode.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtBillCode.Name = "txtBillCode";
            this.txtBillCode.Properties.ReadOnly = true;
            this.txtBillCode.Size = new System.Drawing.Size(226, 25);
            this.txtBillCode.StyleController = this.layControl;
            this.txtBillCode.TabIndex = 0;
            // 
            // txtDealerName
            // 
            this.txtDealerName.AlphabeticFiled = "DealerSpell";
            this.txtDealerName.EntityField = DQS.Module.Entities.BUSBillChangeHistoryEntityFields2.DealerName;
            this.txtDealerName.IsIntegerOnly = false;
            this.txtDealerName.IsNullString = "往来单位不能为空。";
            this.txtDealerName.IsNullValidate = true;
            this.txtDealerName.IsTransferAlphabetic = true;
            this.txtDealerName.Location = new System.Drawing.Point(105, 45);
            this.txtDealerName.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtDealerName.Name = "txtDealerName";
            this.txtDealerName.Properties.Appearance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(247)))), ((int)(((byte)(245)))), ((int)(((byte)(241)))));
            this.txtDealerName.Properties.Appearance.Options.UseBackColor = true;
            this.txtDealerName.Properties.ReadOnly = true;
            this.txtDealerName.Size = new System.Drawing.Size(550, 25);
            this.txtDealerName.StyleController = this.layControl;
            this.txtDealerName.TabIndex = 1;
            // 
            // txtTotalPrice
            // 
            this.txtTotalPrice.AlphabeticFiled = null;
            this.txtTotalPrice.EditValue = "0";
            this.txtTotalPrice.EntityField = DQS.Module.Entities.BUSBillChangeHistoryEntityFields2.TotalPrice;
            this.txtTotalPrice.IsIntegerOnly = false;
            this.txtTotalPrice.IsNullString = null;
            this.txtTotalPrice.IsNullValidate = false;
            this.txtTotalPrice.IsTransferAlphabetic = false;
            this.txtTotalPrice.Location = new System.Drawing.Point(105, 161);
            this.txtTotalPrice.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtTotalPrice.Name = "txtTotalPrice";
            this.txtTotalPrice.Properties.Appearance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(247)))), ((int)(((byte)(245)))), ((int)(((byte)(241)))));
            this.txtTotalPrice.Properties.Appearance.Options.UseBackColor = true;
            this.txtTotalPrice.Properties.ReadOnly = true;
            this.txtTotalPrice.Size = new System.Drawing.Size(550, 25);
            this.txtTotalPrice.StyleController = this.layControl;
            this.txtTotalPrice.TabIndex = 7;
            // 
            // layControlGroup
            // 
            this.layControlGroup.AppearanceItemCaption.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.layControlGroup.AppearanceItemCaption.Options.UseFont = true;
            this.layControlGroup.CustomizationFormText = "销售退回单";
            this.layControlGroup.EnableIndentsWithoutBorders = DevExpress.Utils.DefaultBoolean.True;
            this.layControlGroup.GroupBordersVisible = false;
            this.layControlGroup.Items.AddRange(new DevExpress.XtraLayout.BaseLayoutItem[] {
            this.layBillCode,
            this.layPaymentType,
            this.layTotalPrice,
            this.layBillStyle,
            this.laySaleBillCode,
            this.layDealerName,
            this.layReviewCode,
            this.layDeliveryType,
            this.emptySpaceItem1,
            this.layReason});
            this.layControlGroup.Location = new System.Drawing.Point(0, 0);
            this.layControlGroup.Name = "layControlGroup";
            this.layControlGroup.Size = new System.Drawing.Size(667, 206);
            this.layControlGroup.Spacing = new DevExpress.XtraLayout.Utils.Padding(0, 0, 0, 0);
            this.layControlGroup.Text = "销售退回单";
            this.layControlGroup.TextVisible = false;
            // 
            // layBillCode
            // 
            this.layBillCode.Control = this.txtBillCode;
            this.layBillCode.CustomizationFormText = "销售退回单号";
            this.layBillCode.Location = new System.Drawing.Point(0, 0);
            this.layBillCode.Name = "layBillCode";
            this.layBillCode.Size = new System.Drawing.Size(323, 33);
            this.layBillCode.Text = "销售退回单号";
            this.layBillCode.TextSize = new System.Drawing.Size(90, 20);
            // 
            // layPaymentType
            // 
            this.layPaymentType.Control = this.cbxPaymentType;
            this.layPaymentType.CustomizationFormText = "付款方式";
            this.layPaymentType.Location = new System.Drawing.Point(0, 91);
            this.layPaymentType.Name = "layPaymentType";
            this.layPaymentType.Size = new System.Drawing.Size(323, 29);
            this.layPaymentType.Text = "付款方式";
            this.layPaymentType.TextSize = new System.Drawing.Size(90, 20);
            // 
            // layTotalPrice
            // 
            this.layTotalPrice.Control = this.txtTotalPrice;
            this.layTotalPrice.CustomizationFormText = "订单总额";
            this.layTotalPrice.Location = new System.Drawing.Point(0, 149);
            this.layTotalPrice.Name = "layTotalPrice";
            this.layTotalPrice.Size = new System.Drawing.Size(647, 37);
            this.layTotalPrice.Text = "订单总额";
            this.layTotalPrice.TextSize = new System.Drawing.Size(90, 20);
            // 
            // layBillStyle
            // 
            this.layBillStyle.Control = this.rdgBillStyle;
            this.layBillStyle.CustomizationFormText = "类型";
            this.layBillStyle.Location = new System.Drawing.Point(323, 0);
            this.layBillStyle.Name = "layBillStyle";
            this.layBillStyle.Size = new System.Drawing.Size(265, 33);
            this.layBillStyle.Text = "类型";
            this.layBillStyle.TextSize = new System.Drawing.Size(90, 20);
            // 
            // laySaleBillCode
            // 
            this.laySaleBillCode.Control = this.txtSaleBillCode;
            this.laySaleBillCode.CustomizationFormText = "销售单号";
            this.laySaleBillCode.Location = new System.Drawing.Point(0, 62);
            this.laySaleBillCode.Name = "laySaleBillCode";
            this.laySaleBillCode.Size = new System.Drawing.Size(323, 29);
            this.laySaleBillCode.Text = "销售单号";
            this.laySaleBillCode.TextSize = new System.Drawing.Size(90, 20);
            // 
            // layDealerName
            // 
            this.layDealerName.Control = this.txtDealerName;
            this.layDealerName.CustomizationFormText = "往来单位";
            this.layDealerName.Location = new System.Drawing.Point(0, 33);
            this.layDealerName.Name = "layDealerName";
            this.layDealerName.Size = new System.Drawing.Size(647, 29);
            this.layDealerName.Text = "往来单位";
            this.layDealerName.TextSize = new System.Drawing.Size(90, 20);
            // 
            // layReviewCode
            // 
            this.layReviewCode.Control = this.txtReviewCode;
            this.layReviewCode.CustomizationFormText = "出库复核单号";
            this.layReviewCode.Location = new System.Drawing.Point(323, 62);
            this.layReviewCode.Name = "layReviewCode";
            this.layReviewCode.Size = new System.Drawing.Size(324, 29);
            this.layReviewCode.Text = "出库复核单号";
            this.layReviewCode.TextSize = new System.Drawing.Size(90, 20);
            // 
            // layDeliveryType
            // 
            this.layDeliveryType.Control = this.cbxDeliveryType;
            this.layDeliveryType.CustomizationFormText = "配送方式";
            this.layDeliveryType.Location = new System.Drawing.Point(323, 91);
            this.layDeliveryType.Name = "layDeliveryType";
            this.layDeliveryType.Size = new System.Drawing.Size(324, 29);
            this.layDeliveryType.Text = "配送方式";
            this.layDeliveryType.TextSize = new System.Drawing.Size(90, 20);
            // 
            // emptySpaceItem1
            // 
            this.emptySpaceItem1.CustomizationFormText = "emptySpaceItem1";
            this.emptySpaceItem1.Location = new System.Drawing.Point(588, 0);
            this.emptySpaceItem1.Name = "emptySpaceItem1";
            this.emptySpaceItem1.Size = new System.Drawing.Size(59, 33);
            this.emptySpaceItem1.Text = "emptySpaceItem1";
            this.emptySpaceItem1.TextSize = new System.Drawing.Size(0, 0);
            // 
            // layReason
            // 
            this.layReason.Control = this.txtReason;
            this.layReason.CustomizationFormText = "销退原因";
            this.layReason.Location = new System.Drawing.Point(0, 120);
            this.layReason.Name = "layReason";
            this.layReason.Size = new System.Drawing.Size(647, 29);
            this.layReason.Text = "销退原因";
            this.layReason.TextSize = new System.Drawing.Size(90, 20);
            // 
            // panelAction
            // 
            this.panelAction.Controls.Add(this.btnCancel);
            this.panelAction.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panelAction.Location = new System.Drawing.Point(0, 621);
            this.panelAction.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.panelAction.Name = "panelAction";
            this.panelAction.Size = new System.Drawing.Size(972, 62);
            this.panelAction.TabIndex = 1;
            // 
            // btnCancel
            // 
            this.btnCancel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnCancel.Appearance.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCancel.Appearance.Options.UseFont = true;
            this.btnCancel.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btnCancel.Location = new System.Drawing.Point(870, 17);
            this.btnCancel.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(86, 30);
            this.btnCancel.TabIndex = 1;
            this.btnCancel.Text = "关闭(&C)";
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // groupControl
            // 
            this.groupControl.AppearanceCaption.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupControl.AppearanceCaption.Options.UseFont = true;
            this.groupControl.Controls.Add(this.popupGrid);
            this.groupControl.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupControl.Location = new System.Drawing.Point(2, 237);
            this.groupControl.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.groupControl.Name = "groupControl";
            this.groupControl.Size = new System.Drawing.Size(671, 382);
            this.groupControl.TabIndex = 2;
            this.groupControl.Text = "销售退回明细";
            // 
            // popupGrid
            // 
            this.popupGrid.Dock = System.Windows.Forms.DockStyle.Fill;
            this.popupGrid.EmbeddedNavigator.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.popupGrid.IsCalculatePrice = true;
            this.popupGrid.Location = new System.Drawing.Point(2, 28);
            this.popupGrid.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.popupGrid.Name = "popupGrid";
            this.popupGrid.OperationName = "SaleBack";
            this.popupGrid.Size = new System.Drawing.Size(667, 352);
            this.popupGrid.TabIndex = 1;
            // 
            // splitterControl1
            // 
            this.splitterControl1.Location = new System.Drawing.Point(291, 0);
            this.splitterControl1.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.splitterControl1.Name = "splitterControl1";
            this.splitterControl1.Size = new System.Drawing.Size(6, 621);
            this.splitterControl1.TabIndex = 12;
            this.splitterControl1.TabStop = false;
            // 
            // groupControl1
            // 
            this.groupControl1.Controls.Add(this.lbcHistories);
            this.groupControl1.Dock = System.Windows.Forms.DockStyle.Left;
            this.groupControl1.Location = new System.Drawing.Point(0, 0);
            this.groupControl1.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.groupControl1.Name = "groupControl1";
            this.groupControl1.Size = new System.Drawing.Size(291, 621);
            this.groupControl1.TabIndex = 11;
            this.groupControl1.Text = "版本列表";
            // 
            // lbcHistories
            // 
            this.lbcHistories.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lbcHistories.HighlightedItemStyle = DevExpress.XtraEditors.HighlightStyle.Skinned;
            this.lbcHistories.Location = new System.Drawing.Point(2, 27);
            this.lbcHistories.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.lbcHistories.Name = "lbcHistories";
            this.lbcHistories.SelectionMode = System.Windows.Forms.SelectionMode.MultiExtended;
            this.lbcHistories.Size = new System.Drawing.Size(287, 592);
            this.lbcHistories.TabIndex = 1;
            this.lbcHistories.SelectedIndexChanged += new System.EventHandler(this.lbcHistories_SelectedIndexChanged);
            // 
            // groupControl2
            // 
            this.groupControl2.Controls.Add(this.groupControl);
            this.groupControl2.Controls.Add(this.ftPanel);
            this.groupControl2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupControl2.Location = new System.Drawing.Point(297, 0);
            this.groupControl2.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.groupControl2.Name = "groupControl2";
            this.groupControl2.Size = new System.Drawing.Size(675, 621);
            this.groupControl2.TabIndex = 13;
            this.groupControl2.Text = "销售退回单内容";
            // 
            // FrmSingleSaleBackChangeHistory
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 18F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(972, 683);
            this.Controls.Add(this.groupControl2);
            this.Controls.Add(this.splitterControl1);
            this.Controls.Add(this.groupControl1);
            this.Controls.Add(this.panelAction);
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.MinimizeBox = false;
            this.Name = "FrmSingleSaleBackChangeHistory";
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "销售退回单修改历史";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.FrmSingleSaleBackChangeHistory_Load);
            ((System.ComponentModel.ISupportInitialize)(this.ftPanel)).EndInit();
            this.ftPanel.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.layControl)).EndInit();
            this.layControl.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.txtReason.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.rdgBillStyle.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtReviewCode.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtSaleBillCode.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cbxDeliveryType.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cbxPaymentType.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtBillCode.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtDealerName.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtTotalPrice.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layControlGroup)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layBillCode)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layPaymentType)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layTotalPrice)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layBillStyle)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.laySaleBillCode)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layDealerName)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layReviewCode)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layDeliveryType)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.emptySpaceItem1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layReason)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.panelAction)).EndInit();
            this.panelAction.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.groupControl)).EndInit();
            this.groupControl.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.popupGrid)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.groupControl1)).EndInit();
            this.groupControl1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.lbcHistories)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.groupControl2)).EndInit();
            this.groupControl2.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private DQS.Controls.FieldTextBoxPanel ftPanel;
        private DevExpress.XtraEditors.PanelControl panelAction;
        private DevExpress.XtraEditors.SimpleButton btnCancel;
        private DevExpress.XtraLayout.LayoutControl layControl;
        private DevExpress.XtraLayout.LayoutControlGroup layControlGroup;
        private DQS.Controls.BUSBillChangeHistoryEntityTextBox txtBillCode;
        private DQS.Controls.BUSBillChangeHistoryEntityTextBox txtDealerName;
        private DQS.Controls.BUSBillChangeHistoryEntityTextBox txtTotalPrice;
        private DevExpress.XtraLayout.LayoutControlItem layBillCode;
        private DevExpress.XtraLayout.LayoutControlItem layDealerName;
        private DevExpress.XtraLayout.LayoutControlItem layTotalPrice;
        private DevExpress.XtraEditors.GroupControl groupControl;
        private DQS.Controls.ComboBoxCategoryEx cbxPaymentType;
        private DevExpress.XtraLayout.LayoutControlItem layPaymentType;
        private DQS.Controls.ComboBoxCategoryEx cbxDeliveryType;
        private DevExpress.XtraLayout.LayoutControlItem layDeliveryType;
        private DQS.Controls.PopupGrid popupGrid;
        private DQS.Controls.BUSBillChangeHistoryEntityTextBox txtReviewCode;
        private DQS.Controls.BUSBillChangeHistoryEntityTextBox txtSaleBillCode;
        private DevExpress.XtraLayout.LayoutControlItem laySaleBillCode;
        private DevExpress.XtraLayout.LayoutControlItem layReviewCode;
        private DevExpress.XtraEditors.RadioGroup rdgBillStyle;
        private DevExpress.XtraLayout.LayoutControlItem layBillStyle;
        private DevExpress.XtraLayout.EmptySpaceItem emptySpaceItem1;
        private Controls.BUSBillChangeHistoryEntityTextBox txtReason;
        private DevExpress.XtraLayout.LayoutControlItem layReason;
        private DevExpress.XtraEditors.SplitterControl splitterControl1;
        private DevExpress.XtraEditors.GroupControl groupControl1;
        private DevExpress.XtraEditors.ListBoxControl lbcHistories;
        private DevExpress.XtraEditors.GroupControl groupControl2;
    }
}