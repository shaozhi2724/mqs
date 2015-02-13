namespace DQS.AppViews.Operation.BackManager
{
    partial class FrmSingleSaleBack
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
            this.txtReason = new DQS.Controls.BUSBillEntityTextBox();
            this.rdgBillStyle = new DevExpress.XtraEditors.RadioGroup();
            this.txtReviewCode = new DQS.Controls.BUSBillEntityTextBox();
            this.txtSaleBillCode = new DQS.Controls.BUSBillEntityTextBox();
            this.cbxDeliveryType = new DQS.Controls.ComboBoxCategoryEx();
            this.cbxPaymentType = new DQS.Controls.ComboBoxCategoryEx();
            this.txtBillCode = new DQS.Controls.BUSBillEntityTextBox();
            this.txtDealerName = new DQS.Controls.TextBoxPopupEx();
            this.txtTotalPrice = new DQS.Controls.BUSBillEntityTextBox();
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
            this.btnViewHistory = new DevExpress.XtraEditors.SimpleButton();
            this.btnReviewRecord = new DevExpress.XtraEditors.SimpleButton();
            this.btnCancel = new DevExpress.XtraEditors.SimpleButton();
            this.btnSave = new DevExpress.XtraEditors.SimpleButton();
            this.btnPrint = new DQS.Controls.StiPrintButtonEx();
            this.groupControl = new DevExpress.XtraEditors.GroupControl();
            this.popupGrid = new DQS.Controls.PopupGrid();
            this.busBillEntityTextBox1 = new DQS.Controls.BUSBillEntityTextBox();
            this.layoutControlItemDel = new DevExpress.XtraLayout.LayoutControlItem();
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
            ((System.ComponentModel.ISupportInitialize)(this.busBillEntityTextBox1.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItemDel)).BeginInit();
            this.SuspendLayout();
            // 
            // ftPanel
            // 
            this.ftPanel.Controls.Add(this.layControl);
            this.ftPanel.Dock = System.Windows.Forms.DockStyle.Top;
            this.ftPanel.Location = new System.Drawing.Point(0, 0);
            this.ftPanel.Name = "ftPanel";
            this.ftPanel.Size = new System.Drawing.Size(872, 176);
            this.ftPanel.TabIndex = 0;
            this.ftPanel.TypeOfEntity = DQS.Module.EntityType2.BUSBillEntity;
            // 
            // layControl
            // 
            this.layControl.Controls.Add(this.busBillEntityTextBox1);
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
            this.layControl.Name = "layControl";
            this.layControl.Root = this.layControlGroup;
            this.layControl.Size = new System.Drawing.Size(868, 172);
            this.layControl.TabIndex = 0;
            this.layControl.Text = "layControl";
            // 
            // txtReason
            // 
            this.txtReason.AlphabeticFiled = null;
            this.txtReason.EntityField = DQS.Module.Entities.BUSBillEntityFields2.BillRemark;
            this.txtReason.IsIntegerOnly = false;
            this.txtReason.IsNullString = "销退原因不能为空。";
            this.txtReason.IsNullValidate = true;
            this.txtReason.IsTransferAlphabetic = false;
            this.txtReason.Location = new System.Drawing.Point(87, 116);
            this.txtReason.Name = "txtReason";
            this.txtReason.Size = new System.Drawing.Size(752, 21);
            this.txtReason.StyleController = this.layControl;
            this.txtReason.TabIndex = 4;
            // 
            // rdgBillStyle
            // 
            this.rdgBillStyle.EditValue = "正常";
            this.rdgBillStyle.Location = new System.Drawing.Point(502, 12);
            this.rdgBillStyle.Name = "rdgBillStyle";
            this.rdgBillStyle.Properties.Appearance.BackColor = System.Drawing.Color.Transparent;
            this.rdgBillStyle.Properties.Appearance.Options.UseBackColor = true;
            this.rdgBillStyle.Properties.Columns = 3;
            this.rdgBillStyle.Properties.Items.AddRange(new DevExpress.XtraEditors.Controls.RadioGroupItem[] {
            new DevExpress.XtraEditors.Controls.RadioGroupItem("正常", "正常"),
            new DevExpress.XtraEditors.Controls.RadioGroupItem("追回", "追回"),
            new DevExpress.XtraEditors.Controls.RadioGroupItem("召回", "召回")});
            this.rdgBillStyle.Size = new System.Drawing.Size(194, 25);
            this.rdgBillStyle.StyleController = this.layControl;
            this.rdgBillStyle.TabIndex = 18;
            // 
            // txtReviewCode
            // 
            this.txtReviewCode.AlphabeticFiled = null;
            this.txtReviewCode.EntityField = DQS.Module.Entities.BUSBillEntityFields2.ReviewCode;
            this.txtReviewCode.IsIntegerOnly = false;
            this.txtReviewCode.IsNullString = "";
            this.txtReviewCode.IsNullValidate = false;
            this.txtReviewCode.IsTransferAlphabetic = false;
            this.txtReviewCode.Location = new System.Drawing.Point(502, 66);
            this.txtReviewCode.Name = "txtReviewCode";
            this.txtReviewCode.Properties.ReadOnly = true;
            this.txtReviewCode.Size = new System.Drawing.Size(337, 21);
            this.txtReviewCode.StyleController = this.layControl;
            this.txtReviewCode.TabIndex = 4;
            // 
            // txtSaleBillCode
            // 
            this.txtSaleBillCode.AlphabeticFiled = null;
            this.txtSaleBillCode.EntityField = DQS.Module.Entities.BUSBillEntityFields2.SaleBillCode;
            this.txtSaleBillCode.IsIntegerOnly = false;
            this.txtSaleBillCode.IsNullString = "";
            this.txtSaleBillCode.IsNullValidate = false;
            this.txtSaleBillCode.IsTransferAlphabetic = false;
            this.txtSaleBillCode.Location = new System.Drawing.Point(87, 66);
            this.txtSaleBillCode.Name = "txtSaleBillCode";
            this.txtSaleBillCode.Properties.ReadOnly = true;
            this.txtSaleBillCode.Size = new System.Drawing.Size(336, 21);
            this.txtSaleBillCode.StyleController = this.layControl;
            this.txtSaleBillCode.TabIndex = 4;
            // 
            // cbxDeliveryType
            // 
            this.cbxDeliveryType.CategoryCode = "DeliveryType";
            this.cbxDeliveryType.Location = new System.Drawing.Point(502, 91);
            this.cbxDeliveryType.Name = "cbxDeliveryType";
            this.cbxDeliveryType.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.cbxDeliveryType.Properties.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.DisableTextEditor;
            this.cbxDeliveryType.SelectedValue = null;
            this.cbxDeliveryType.Size = new System.Drawing.Size(337, 21);
            this.cbxDeliveryType.StyleController = this.layControl;
            this.cbxDeliveryType.TabIndex = 13;
            // 
            // cbxPaymentType
            // 
            this.cbxPaymentType.CategoryCode = "PaymentType";
            this.cbxPaymentType.Location = new System.Drawing.Point(87, 91);
            this.cbxPaymentType.Name = "cbxPaymentType";
            this.cbxPaymentType.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.cbxPaymentType.Properties.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.DisableTextEditor;
            this.cbxPaymentType.SelectedValue = null;
            this.cbxPaymentType.Size = new System.Drawing.Size(336, 21);
            this.cbxPaymentType.StyleController = this.layControl;
            this.cbxPaymentType.TabIndex = 12;
            // 
            // txtBillCode
            // 
            this.txtBillCode.AlphabeticFiled = null;
            this.txtBillCode.EntityField = DQS.Module.Entities.BUSBillEntityFields2.BillCode;
            this.txtBillCode.IsIntegerOnly = false;
            this.txtBillCode.IsNullString = "销售单号不能为空。";
            this.txtBillCode.IsNullValidate = true;
            this.txtBillCode.IsTransferAlphabetic = false;
            this.txtBillCode.Location = new System.Drawing.Point(87, 12);
            this.txtBillCode.Name = "txtBillCode";
            this.txtBillCode.Size = new System.Drawing.Size(336, 21);
            this.txtBillCode.StyleController = this.layControl;
            this.txtBillCode.TabIndex = 0;
            // 
            // txtDealerName
            // 
            this.txtDealerName.AlphabeticFiled = "DealerSpell";
            this.txtDealerName.EditData = null;
            this.txtDealerName.Fields = "单位ID,单位编号,单位名称,单位名称Spell,单位类型,通讯地址";
            this.txtDealerName.Filter = null;
            this.txtDealerName.FormatQueryString = "[单位编号] LIKE \'%{0}%\' OR ([单位名称] LIKE \'%{0}%\' OR [单位名称Spell] LIKE \'%{0}%\')";
            this.txtDealerName.IsIntegerOnly = false;
            this.txtDealerName.IsNullString = "往来单位不能为空。";
            this.txtDealerName.IsNullValidate = true;
            this.txtDealerName.IsTransferAlphabetic = true;
            this.txtDealerName.Location = new System.Drawing.Point(87, 41);
            this.txtDealerName.MemberText = "单位名称";
            this.txtDealerName.MemberValue = "单位ID";
            this.txtDealerName.Name = "txtDealerName";
            this.txtDealerName.PageSize = 0;
            this.txtDealerName.PrimaryField = "单位ID";
            this.txtDealerName.Properties.Appearance.BackColor = System.Drawing.Color.White;
            this.txtDealerName.Properties.Appearance.Options.UseBackColor = true;
            this.txtDealerName.Properties.ReadOnly = true;
            this.txtDealerName.Size = new System.Drawing.Size(752, 21);
            this.txtDealerName.StyleController = this.layControl;
            this.txtDealerName.TabIndex = 1;
            this.txtDealerName.ViewName = "vw_AllProvider";
            this.txtDealerName.EditValueChanging += new DevExpress.XtraEditors.Controls.ChangingEventHandler(this.txtDealerName_EditValueChanging);
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
            this.txtTotalPrice.Location = new System.Drawing.Point(87, 141);
            this.txtTotalPrice.Name = "txtTotalPrice";
            this.txtTotalPrice.Properties.Appearance.BackColor = System.Drawing.Color.White;
            this.txtTotalPrice.Properties.Appearance.Options.UseBackColor = true;
            this.txtTotalPrice.Properties.ReadOnly = true;
            this.txtTotalPrice.Size = new System.Drawing.Size(752, 21);
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
            this.layReason,
            this.layoutControlItemDel});
            this.layControlGroup.Location = new System.Drawing.Point(0, 0);
            this.layControlGroup.Name = "layControlGroup";
            this.layControlGroup.Size = new System.Drawing.Size(851, 199);
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
            this.layBillCode.Size = new System.Drawing.Size(415, 29);
            this.layBillCode.Text = "销售退回单号";
            this.layBillCode.TextSize = new System.Drawing.Size(72, 17);
            // 
            // layPaymentType
            // 
            this.layPaymentType.Control = this.cbxPaymentType;
            this.layPaymentType.CustomizationFormText = "付款方式";
            this.layPaymentType.Location = new System.Drawing.Point(0, 79);
            this.layPaymentType.Name = "layPaymentType";
            this.layPaymentType.Size = new System.Drawing.Size(415, 25);
            this.layPaymentType.Text = "付款方式";
            this.layPaymentType.TextSize = new System.Drawing.Size(72, 17);
            // 
            // layTotalPrice
            // 
            this.layTotalPrice.Control = this.txtTotalPrice;
            this.layTotalPrice.CustomizationFormText = "订单总额";
            this.layTotalPrice.Location = new System.Drawing.Point(0, 129);
            this.layTotalPrice.Name = "layTotalPrice";
            this.layTotalPrice.Size = new System.Drawing.Size(831, 25);
            this.layTotalPrice.Text = "订单总额";
            this.layTotalPrice.TextSize = new System.Drawing.Size(72, 17);
            // 
            // layBillStyle
            // 
            this.layBillStyle.Control = this.rdgBillStyle;
            this.layBillStyle.CustomizationFormText = "类型";
            this.layBillStyle.Location = new System.Drawing.Point(415, 0);
            this.layBillStyle.Name = "layBillStyle";
            this.layBillStyle.Size = new System.Drawing.Size(273, 29);
            this.layBillStyle.Text = "类型";
            this.layBillStyle.TextSize = new System.Drawing.Size(72, 17);
            // 
            // laySaleBillCode
            // 
            this.laySaleBillCode.Control = this.txtSaleBillCode;
            this.laySaleBillCode.CustomizationFormText = "销售单号";
            this.laySaleBillCode.Location = new System.Drawing.Point(0, 54);
            this.laySaleBillCode.Name = "laySaleBillCode";
            this.laySaleBillCode.Size = new System.Drawing.Size(415, 25);
            this.laySaleBillCode.Text = "销售单号";
            this.laySaleBillCode.TextSize = new System.Drawing.Size(72, 17);
            // 
            // layDealerName
            // 
            this.layDealerName.Control = this.txtDealerName;
            this.layDealerName.CustomizationFormText = "往来单位";
            this.layDealerName.Location = new System.Drawing.Point(0, 29);
            this.layDealerName.Name = "layDealerName";
            this.layDealerName.Size = new System.Drawing.Size(831, 25);
            this.layDealerName.Text = "往来单位";
            this.layDealerName.TextSize = new System.Drawing.Size(72, 17);
            // 
            // layReviewCode
            // 
            this.layReviewCode.Control = this.txtReviewCode;
            this.layReviewCode.CustomizationFormText = "出库复核单号";
            this.layReviewCode.Location = new System.Drawing.Point(415, 54);
            this.layReviewCode.Name = "layReviewCode";
            this.layReviewCode.Size = new System.Drawing.Size(416, 25);
            this.layReviewCode.Text = "出库复核单号";
            this.layReviewCode.TextSize = new System.Drawing.Size(72, 17);
            // 
            // layDeliveryType
            // 
            this.layDeliveryType.Control = this.cbxDeliveryType;
            this.layDeliveryType.CustomizationFormText = "配送方式";
            this.layDeliveryType.Location = new System.Drawing.Point(415, 79);
            this.layDeliveryType.Name = "layDeliveryType";
            this.layDeliveryType.Size = new System.Drawing.Size(416, 25);
            this.layDeliveryType.Text = "配送方式";
            this.layDeliveryType.TextSize = new System.Drawing.Size(72, 17);
            // 
            // emptySpaceItem1
            // 
            this.emptySpaceItem1.CustomizationFormText = "emptySpaceItem1";
            this.emptySpaceItem1.Location = new System.Drawing.Point(688, 0);
            this.emptySpaceItem1.Name = "emptySpaceItem1";
            this.emptySpaceItem1.Size = new System.Drawing.Size(143, 29);
            this.emptySpaceItem1.Text = "emptySpaceItem1";
            this.emptySpaceItem1.TextSize = new System.Drawing.Size(0, 0);
            // 
            // layReason
            // 
            this.layReason.Control = this.txtReason;
            this.layReason.CustomizationFormText = "销退原因";
            this.layReason.Location = new System.Drawing.Point(0, 104);
            this.layReason.Name = "layReason";
            this.layReason.Size = new System.Drawing.Size(831, 25);
            this.layReason.Text = "销退原因";
            this.layReason.TextSize = new System.Drawing.Size(72, 17);
            // 
            // panelAction
            // 
            this.panelAction.Controls.Add(this.btnViewHistory);
            this.panelAction.Controls.Add(this.btnReviewRecord);
            this.panelAction.Controls.Add(this.btnCancel);
            this.panelAction.Controls.Add(this.btnSave);
            this.panelAction.Controls.Add(this.btnPrint);
            this.panelAction.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panelAction.Location = new System.Drawing.Point(0, 483);
            this.panelAction.Name = "panelAction";
            this.panelAction.Size = new System.Drawing.Size(872, 48);
            this.panelAction.TabIndex = 1;
            // 
            // btnViewHistory
            // 
            this.btnViewHistory.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnViewHistory.Appearance.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnViewHistory.Appearance.Options.UseFont = true;
            this.btnViewHistory.Location = new System.Drawing.Point(313, 13);
            this.btnViewHistory.Name = "btnViewHistory";
            this.btnViewHistory.Size = new System.Drawing.Size(102, 23);
            this.btnViewHistory.TabIndex = 5;
            this.btnViewHistory.Text = "历史记录(&H)";
            this.btnViewHistory.Visible = false;
            this.btnViewHistory.Click += new System.EventHandler(this.btnViewHistory_Click);
            // 
            // btnReviewRecord
            // 
            this.btnReviewRecord.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnReviewRecord.Appearance.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnReviewRecord.Appearance.Options.UseFont = true;
            this.btnReviewRecord.Location = new System.Drawing.Point(469, 13);
            this.btnReviewRecord.Name = "btnReviewRecord";
            this.btnReviewRecord.Size = new System.Drawing.Size(75, 23);
            this.btnReviewRecord.TabIndex = 3;
            this.btnReviewRecord.Text = "复核记录(&R)";
            this.btnReviewRecord.Click += new System.EventHandler(this.btnReviewRecord_Click);
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
            this.btnCancel.TabIndex = 1;
            this.btnCancel.Text = "取消(&C)";
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // btnSave
            // 
            this.btnSave.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnSave.Appearance.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSave.Appearance.Options.UseFont = true;
            this.btnSave.Location = new System.Drawing.Point(678, 13);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(75, 23);
            this.btnSave.TabIndex = 0;
            this.btnSave.Text = "保存(&S)";
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // btnPrint
            // 
            this.btnPrint.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnPrint.Appearance.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnPrint.Appearance.Options.UseFont = true;
            this.btnPrint.Location = new System.Drawing.Point(577, 13);
            this.btnPrint.Name = "btnPrint";
            this.btnPrint.OperationName = "SaleBack";
            this.btnPrint.ReportName = "销售退货单";
            this.btnPrint.Size = new System.Drawing.Size(75, 23);
            this.btnPrint.TabIndex = 2;
            this.btnPrint.Text = "打印(&P)";
            // 
            // groupControl
            // 
            this.groupControl.AppearanceCaption.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupControl.AppearanceCaption.Options.UseFont = true;
            this.groupControl.Controls.Add(this.popupGrid);
            this.groupControl.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupControl.Location = new System.Drawing.Point(0, 176);
            this.groupControl.Name = "groupControl";
            this.groupControl.Size = new System.Drawing.Size(872, 307);
            this.groupControl.TabIndex = 2;
            this.groupControl.Text = "销售退回明细";
            // 
            // popupGrid
            // 
            this.popupGrid.Dock = System.Windows.Forms.DockStyle.Fill;
            this.popupGrid.IsCalculatePrice = true;
            this.popupGrid.Location = new System.Drawing.Point(2, 25);
            this.popupGrid.Name = "popupGrid";
            this.popupGrid.OperationName = "SaleBack";
            this.popupGrid.Size = new System.Drawing.Size(868, 280);
            this.popupGrid.TabIndex = 1;
            this.popupGrid.PopupClosed += new DQS.Controls.PopupGrid.OnPopupClosedEventHandler(this.popupGrid_PopupClosed);
            this.popupGrid.TotalPriceChanged += new DQS.Controls.PopupGrid.OnTotalPriceChangedEventHandler(this.popupGrid_TotalPriceChanged);
            this.popupGrid.BeforePopupFormShow += new DQS.Controls.PopupGrid.OnBeforePopupFormShowEventHandler(this.popupGrid_BeforePopupFormShow);
            // 
            // busBillEntityTextBox1
            // 
            this.busBillEntityTextBox1.AlphabeticFiled = null;
            this.busBillEntityTextBox1.EntityField = DQS.Module.Entities.BUSBillEntityFields2.Reservation5;
            this.busBillEntityTextBox1.IsIntegerOnly = false;
            this.busBillEntityTextBox1.IsNullString = "";
            this.busBillEntityTextBox1.IsNullValidate = false;
            this.busBillEntityTextBox1.IsTransferAlphabetic = false;
            this.busBillEntityTextBox1.Location = new System.Drawing.Point(87, 166);
            this.busBillEntityTextBox1.Name = "busBillEntityTextBox1";
            this.busBillEntityTextBox1.Size = new System.Drawing.Size(752, 21);
            this.busBillEntityTextBox1.StyleController = this.layControl;
            this.busBillEntityTextBox1.TabIndex = 5;
            // 
            // layoutControlItemDel
            // 
            this.layoutControlItemDel.Control = this.busBillEntityTextBox1;
            this.layoutControlItemDel.CustomizationFormText = "删除原因";
            this.layoutControlItemDel.Location = new System.Drawing.Point(0, 154);
            this.layoutControlItemDel.Name = "layoutControlItemDel";
            this.layoutControlItemDel.Size = new System.Drawing.Size(831, 25);
            this.layoutControlItemDel.Text = "删除原因";
            this.layoutControlItemDel.TextSize = new System.Drawing.Size(72, 17);
            this.layoutControlItemDel.Visibility = DevExpress.XtraLayout.Utils.LayoutVisibility.Never;
            // 
            // FrmSingleSaleBack
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 14F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(872, 531);
            this.Controls.Add(this.groupControl);
            this.Controls.Add(this.panelAction);
            this.Controls.Add(this.ftPanel);
            this.MinimizeBox = false;
            this.Name = "FrmSingleSaleBack";
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "销售退回单";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.FrmSingleSaleBack_Load);
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
            ((System.ComponentModel.ISupportInitialize)(this.busBillEntityTextBox1.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItemDel)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DQS.Controls.FieldTextBoxPanel ftPanel;
        private DevExpress.XtraEditors.PanelControl panelAction;
        private DevExpress.XtraEditors.SimpleButton btnCancel;
        private DevExpress.XtraEditors.SimpleButton btnSave;
        private DQS.Controls.StiPrintButtonEx btnPrint;
        private DevExpress.XtraLayout.LayoutControl layControl;
        private DevExpress.XtraLayout.LayoutControlGroup layControlGroup;
        private DQS.Controls.BUSBillEntityTextBox txtBillCode;
        private DQS.Controls.TextBoxPopupEx txtDealerName;
        private DQS.Controls.BUSBillEntityTextBox txtTotalPrice;
        private DevExpress.XtraLayout.LayoutControlItem layBillCode;
        private DevExpress.XtraLayout.LayoutControlItem layDealerName;
        private DevExpress.XtraLayout.LayoutControlItem layTotalPrice;
        private DevExpress.XtraEditors.GroupControl groupControl;
        private DQS.Controls.ComboBoxCategoryEx cbxPaymentType;
        private DevExpress.XtraLayout.LayoutControlItem layPaymentType;
        private DQS.Controls.ComboBoxCategoryEx cbxDeliveryType;
        private DevExpress.XtraLayout.LayoutControlItem layDeliveryType;
        private DQS.Controls.PopupGrid popupGrid;
        private DevExpress.XtraEditors.SimpleButton btnReviewRecord;
        private DQS.Controls.BUSBillEntityTextBox txtReviewCode;
        private DQS.Controls.BUSBillEntityTextBox txtSaleBillCode;
        private DevExpress.XtraLayout.LayoutControlItem laySaleBillCode;
        private DevExpress.XtraLayout.LayoutControlItem layReviewCode;
        private DevExpress.XtraEditors.RadioGroup rdgBillStyle;
        private DevExpress.XtraLayout.LayoutControlItem layBillStyle;
        private DevExpress.XtraLayout.EmptySpaceItem emptySpaceItem1;
        private Controls.BUSBillEntityTextBox txtReason;
        private DevExpress.XtraLayout.LayoutControlItem layReason;
        private DevExpress.XtraEditors.SimpleButton btnViewHistory;
        private Controls.BUSBillEntityTextBox busBillEntityTextBox1;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlItemDel;
    }
}