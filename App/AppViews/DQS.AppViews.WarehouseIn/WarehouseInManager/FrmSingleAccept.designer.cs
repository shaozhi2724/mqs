namespace DQS.AppViews.WarehouseIn.WarehouseInManager
{
    partial class FrmSingleAccept
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
            this.txtAcceptDate = new DQS.Controls.BUSAcceptEntityTextBox();
            this.txtBillCode = new DQS.Controls.TextBoxPopupEx();
            this.txtAcceptRemark = new DQS.Controls.BUSAcceptEntityTextBox();
            this.txtBillTypeName = new DQS.Controls.BUSAcceptEntityTextBox();
            this.txtDealerName = new DQS.Controls.BUSAcceptEntityTextBox();
            this.txtAcceptCode = new DQS.Controls.BUSAcceptEntityTextBox();
            this.txtAcceptPerson = new DQS.Controls.TextBoxEnterPopupEx();
            this.layControlGroup = new DevExpress.XtraLayout.LayoutControlGroup();
            this.layAcceptCode = new DevExpress.XtraLayout.LayoutControlItem();
            this.layAcceptPerson = new DevExpress.XtraLayout.LayoutControlItem();
            this.layBillCode = new DevExpress.XtraLayout.LayoutControlItem();
            this.layBillTypeName = new DevExpress.XtraLayout.LayoutControlItem();
            this.layDealerName = new DevExpress.XtraLayout.LayoutControlItem();
            this.layAcceptRemark = new DevExpress.XtraLayout.LayoutControlItem();
            this.layAcceptDate = new DevExpress.XtraLayout.LayoutControlItem();
            this.barPopManager = new DevExpress.XtraBars.BarManager();
            this.barDockControlTop = new DevExpress.XtraBars.BarDockControl();
            this.barDockControlBottom = new DevExpress.XtraBars.BarDockControl();
            this.barDockControlLeft = new DevExpress.XtraBars.BarDockControl();
            this.barDockControlRight = new DevExpress.XtraBars.BarDockControl();
            this.bbiSampling = new DevExpress.XtraBars.BarButtonItem();
            this.pnlAction = new DevExpress.XtraEditors.PanelControl();
            this.btnAttachment = new DevExpress.XtraEditors.SimpleButton();
            this.btnDealerQualification = new DevExpress.XtraEditors.SimpleButton();
            this.btnProductQualification = new DevExpress.XtraEditors.SimpleButton();
            this.btnPrint = new DQS.Controls.StiPrintButtonEx();
            this.btnCancel = new DevExpress.XtraEditors.SimpleButton();
            this.btnSaveAndIn = new DevExpress.XtraEditors.SimpleButton();
            this.btnSave = new DevExpress.XtraEditors.SimpleButton();
            this.btnOneKeyFinish = new DevExpress.XtraEditors.SimpleButton();
            this.popupMenuSampling = new DevExpress.XtraBars.PopupMenu();
            this.gpcSampling = new DevExpress.XtraEditors.GroupControl();
            this.popupGridSampling = new DQS.Controls.PopupGrid();
            this.splitterControl1 = new DevExpress.XtraEditors.SplitterControl();
            this.gpcButtom = new DevExpress.XtraEditors.GroupControl();
            this.popupGrid = new DQS.Controls.PopupGrid();
            ((System.ComponentModel.ISupportInitialize)(this.ftPanel)).BeginInit();
            this.ftPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.layControl)).BeginInit();
            this.layControl.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.txtAcceptDate.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtBillCode.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtAcceptRemark.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtBillTypeName.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtDealerName.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtAcceptCode.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtAcceptPerson.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layControlGroup)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layAcceptCode)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layAcceptPerson)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layBillCode)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layBillTypeName)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layDealerName)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layAcceptRemark)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layAcceptDate)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.barPopManager)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pnlAction)).BeginInit();
            this.pnlAction.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.popupMenuSampling)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gpcSampling)).BeginInit();
            this.gpcSampling.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.popupGridSampling)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gpcButtom)).BeginInit();
            this.gpcButtom.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.popupGrid)).BeginInit();
            this.SuspendLayout();
            // 
            // ftPanel
            // 
            this.ftPanel.Controls.Add(this.layControl);
            this.ftPanel.Dock = System.Windows.Forms.DockStyle.Top;
            this.ftPanel.Location = new System.Drawing.Point(0, 0);
            this.ftPanel.Name = "ftPanel";
            this.ftPanel.Size = new System.Drawing.Size(872, 138);
            this.ftPanel.TabIndex = 0;
            this.ftPanel.TypeOfEntity = DQS.Module.EntityType2.BUSAcceptEntity;
            // 
            // layControl
            // 
            this.layControl.Controls.Add(this.txtAcceptDate);
            this.layControl.Controls.Add(this.txtBillCode);
            this.layControl.Controls.Add(this.txtAcceptRemark);
            this.layControl.Controls.Add(this.txtBillTypeName);
            this.layControl.Controls.Add(this.txtDealerName);
            this.layControl.Controls.Add(this.txtAcceptCode);
            this.layControl.Controls.Add(this.txtAcceptPerson);
            this.layControl.Dock = System.Windows.Forms.DockStyle.Fill;
            this.layControl.Location = new System.Drawing.Point(2, 2);
            this.layControl.Name = "layControl";
            this.layControl.Root = this.layControlGroup;
            this.layControl.Size = new System.Drawing.Size(868, 134);
            this.layControl.TabIndex = 0;
            this.layControl.Text = "layControl";
            // 
            // txtAcceptDate
            // 
            this.txtAcceptDate.AlphabeticFiled = null;
            this.txtAcceptDate.EntityField = DQS.Module.Entities.BUSAcceptEntityFields2.AcceptRemark;
            this.txtAcceptDate.IsIntegerOnly = false;
            this.txtAcceptDate.IsNullString = null;
            this.txtAcceptDate.IsNullValidate = false;
            this.txtAcceptDate.IsTransferAlphabetic = false;
            this.txtAcceptDate.Location = new System.Drawing.Point(63, 87);
            this.txtAcceptDate.Name = "txtAcceptDate";
            this.txtAcceptDate.Size = new System.Drawing.Size(776, 21);
            this.txtAcceptDate.StyleController = this.layControl;
            this.txtAcceptDate.TabIndex = 8;
            // 
            // txtBillCode
            // 
            this.txtBillCode.AlphabeticFiled = "";
            this.txtBillCode.EditData = null;
            this.txtBillCode.Fields = "";
            this.txtBillCode.Filter = "[状态] = \'已收货\'";
            this.txtBillCode.FormatQueryString = "[收货单号] Like \'%{0}%\'";
            this.txtBillCode.GroupColumn = null;
            this.txtBillCode.IsIntegerOnly = false;
            this.txtBillCode.IsNullString = "收货记录不能为空。";
            this.txtBillCode.IsNullValidate = true;
            this.txtBillCode.IsTransferAlphabetic = false;
            this.txtBillCode.Location = new System.Drawing.Point(63, 37);
            this.txtBillCode.MemberText = "收货单号";
            this.txtBillCode.MemberValue = "收货ID";
            this.txtBillCode.Name = "txtBillCode";
            this.txtBillCode.PageSize = 0;
            this.txtBillCode.PrimaryField = "收货ID";
            this.txtBillCode.Properties.Appearance.BackColor = System.Drawing.Color.White;
            this.txtBillCode.Properties.Appearance.Options.UseBackColor = true;
            this.txtBillCode.Properties.ReadOnly = true;
            this.txtBillCode.Size = new System.Drawing.Size(360, 21);
            this.txtBillCode.StyleController = this.layControl;
            this.txtBillCode.TabIndex = 4;
            this.txtBillCode.ViewName = "vw_AllWarehouseInBillForAccept";
            this.txtBillCode.PopupClosing += new DQS.Controls.TextBoxPopupEx.OnPopupClosingDelegate(this.txtBillCode_PopupClosing);
            // 
            // txtAcceptRemark
            // 
            this.txtAcceptRemark.AlphabeticFiled = null;
            this.txtAcceptRemark.EntityField = DQS.Module.Entities.BUSAcceptEntityFields2.AcceptRemark;
            this.txtAcceptRemark.IsIntegerOnly = false;
            this.txtAcceptRemark.IsNullString = null;
            this.txtAcceptRemark.IsNullValidate = false;
            this.txtAcceptRemark.IsTransferAlphabetic = false;
            this.txtAcceptRemark.Location = new System.Drawing.Point(63, 112);
            this.txtAcceptRemark.Name = "txtAcceptRemark";
            this.txtAcceptRemark.Size = new System.Drawing.Size(776, 21);
            this.txtAcceptRemark.StyleController = this.layControl;
            this.txtAcceptRemark.TabIndex = 7;
            // 
            // txtBillTypeName
            // 
            this.txtBillTypeName.AlphabeticFiled = "BillTypeSpell";
            this.txtBillTypeName.EntityField = DQS.Module.Entities.BUSAcceptEntityFields2.BillTypeName;
            this.txtBillTypeName.IsIntegerOnly = false;
            this.txtBillTypeName.IsNullString = null;
            this.txtBillTypeName.IsNullValidate = false;
            this.txtBillTypeName.IsTransferAlphabetic = true;
            this.txtBillTypeName.Location = new System.Drawing.Point(478, 37);
            this.txtBillTypeName.Name = "txtBillTypeName";
            this.txtBillTypeName.Properties.ReadOnly = true;
            this.txtBillTypeName.Size = new System.Drawing.Size(361, 21);
            this.txtBillTypeName.StyleController = this.layControl;
            this.txtBillTypeName.TabIndex = 5;
            // 
            // txtDealerName
            // 
            this.txtDealerName.AlphabeticFiled = "DealerSpell";
            this.txtDealerName.EntityField = DQS.Module.Entities.BUSAcceptEntityFields2.DealerName;
            this.txtDealerName.IsIntegerOnly = false;
            this.txtDealerName.IsNullString = null;
            this.txtDealerName.IsNullValidate = false;
            this.txtDealerName.IsTransferAlphabetic = true;
            this.txtDealerName.Location = new System.Drawing.Point(63, 62);
            this.txtDealerName.Name = "txtDealerName";
            this.txtDealerName.Properties.ReadOnly = true;
            this.txtDealerName.Size = new System.Drawing.Size(776, 21);
            this.txtDealerName.StyleController = this.layControl;
            this.txtDealerName.TabIndex = 6;
            // 
            // txtAcceptCode
            // 
            this.txtAcceptCode.AlphabeticFiled = null;
            this.txtAcceptCode.EntityField = DQS.Module.Entities.BUSAcceptEntityFields2.AcceptCode;
            this.txtAcceptCode.IsIntegerOnly = false;
            this.txtAcceptCode.IsNullString = "验收单号不能为空。";
            this.txtAcceptCode.IsNullValidate = true;
            this.txtAcceptCode.IsTransferAlphabetic = false;
            this.txtAcceptCode.Location = new System.Drawing.Point(63, 12);
            this.txtAcceptCode.Name = "txtAcceptCode";
            this.txtAcceptCode.Size = new System.Drawing.Size(360, 21);
            this.txtAcceptCode.StyleController = this.layControl;
            this.txtAcceptCode.TabIndex = 0;
            // 
            // txtAcceptPerson
            // 
            this.txtAcceptPerson.AlphabeticFiled = "AcceptPersonSpell";
            this.txtAcceptPerson.EditData = null;
            this.txtAcceptPerson.Fields = null;
            this.txtAcceptPerson.Filter = "[岗位名称] = \'验收员\'";
            this.txtAcceptPerson.FormatQueryString = "[员工编号] LIKE \'%{0}%\' OR ([员工姓名] LIKE \'%{0}%\' OR [员工姓名Spell] LIKE \'%{0}%\')";
            this.txtAcceptPerson.GroupColumn = null;
            this.txtAcceptPerson.IsIntegerOnly = false;
            this.txtAcceptPerson.IsNullString = null;
            this.txtAcceptPerson.IsNullValidate = false;
            this.txtAcceptPerson.IsTransferAlphabetic = true;
            this.txtAcceptPerson.Location = new System.Drawing.Point(478, 12);
            this.txtAcceptPerson.MemberText = "员工姓名";
            this.txtAcceptPerson.MemberValue = "员工ID";
            this.txtAcceptPerson.Name = "txtAcceptPerson";
            this.txtAcceptPerson.PageSize = 0;
            this.txtAcceptPerson.PrimaryField = "员工ID";
            this.txtAcceptPerson.Properties.Appearance.BackColor = System.Drawing.Color.White;
            this.txtAcceptPerson.Properties.Appearance.Options.UseBackColor = true;
            this.txtAcceptPerson.Properties.ReadOnly = true;
            this.txtAcceptPerson.Size = new System.Drawing.Size(361, 21);
            this.txtAcceptPerson.StyleController = this.layControl;
            this.txtAcceptPerson.TabIndex = 1;
            this.txtAcceptPerson.ViewName = "vw_AllEmployee";
            // 
            // layControlGroup
            // 
            this.layControlGroup.AppearanceItemCaption.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.layControlGroup.AppearanceItemCaption.Options.UseFont = true;
            this.layControlGroup.CustomizationFormText = "验收单";
            this.layControlGroup.EnableIndentsWithoutBorders = DevExpress.Utils.DefaultBoolean.True;
            this.layControlGroup.GroupBordersVisible = false;
            this.layControlGroup.Items.AddRange(new DevExpress.XtraLayout.BaseLayoutItem[] {
            this.layAcceptCode,
            this.layAcceptPerson,
            this.layBillCode,
            this.layBillTypeName,
            this.layDealerName,
            this.layAcceptRemark,
            this.layAcceptDate});
            this.layControlGroup.Location = new System.Drawing.Point(0, 0);
            this.layControlGroup.Name = "layControlGroup";
            this.layControlGroup.Size = new System.Drawing.Size(851, 145);
            this.layControlGroup.Spacing = new DevExpress.XtraLayout.Utils.Padding(0, 0, 0, 0);
            this.layControlGroup.Text = "验收单";
            this.layControlGroup.TextVisible = false;
            // 
            // layAcceptCode
            // 
            this.layAcceptCode.Control = this.txtAcceptCode;
            this.layAcceptCode.CustomizationFormText = "验收单号";
            this.layAcceptCode.Location = new System.Drawing.Point(0, 0);
            this.layAcceptCode.Name = "layAcceptCode";
            this.layAcceptCode.Size = new System.Drawing.Size(415, 25);
            this.layAcceptCode.Text = "验收单号";
            this.layAcceptCode.TextSize = new System.Drawing.Size(48, 17);
            // 
            // layAcceptPerson
            // 
            this.layAcceptPerson.Control = this.txtAcceptPerson;
            this.layAcceptPerson.CustomizationFormText = "验收人";
            this.layAcceptPerson.Location = new System.Drawing.Point(415, 0);
            this.layAcceptPerson.Name = "layAcceptPerson";
            this.layAcceptPerson.Size = new System.Drawing.Size(416, 25);
            this.layAcceptPerson.Text = "验收人";
            this.layAcceptPerson.TextSize = new System.Drawing.Size(48, 17);
            // 
            // layBillCode
            // 
            this.layBillCode.Control = this.txtBillCode;
            this.layBillCode.CustomizationFormText = "收货记录";
            this.layBillCode.Location = new System.Drawing.Point(0, 25);
            this.layBillCode.Name = "layBillCode";
            this.layBillCode.Size = new System.Drawing.Size(415, 25);
            this.layBillCode.Text = "收货记录";
            this.layBillCode.TextSize = new System.Drawing.Size(48, 17);
            // 
            // layBillTypeName
            // 
            this.layBillTypeName.Control = this.txtBillTypeName;
            this.layBillTypeName.CustomizationFormText = "订单类型";
            this.layBillTypeName.Location = new System.Drawing.Point(415, 25);
            this.layBillTypeName.Name = "layBillTypeName";
            this.layBillTypeName.Size = new System.Drawing.Size(416, 25);
            this.layBillTypeName.Text = "订单类型";
            this.layBillTypeName.TextSize = new System.Drawing.Size(48, 17);
            // 
            // layDealerName
            // 
            this.layDealerName.Control = this.txtDealerName;
            this.layDealerName.CustomizationFormText = "往来单位";
            this.layDealerName.Location = new System.Drawing.Point(0, 50);
            this.layDealerName.Name = "layDealerName";
            this.layDealerName.Size = new System.Drawing.Size(831, 25);
            this.layDealerName.Text = "往来单位";
            this.layDealerName.TextSize = new System.Drawing.Size(48, 17);
            // 
            // layAcceptRemark
            // 
            this.layAcceptRemark.Control = this.txtAcceptRemark;
            this.layAcceptRemark.CustomizationFormText = "备注";
            this.layAcceptRemark.Location = new System.Drawing.Point(0, 100);
            this.layAcceptRemark.Name = "layAcceptRemark";
            this.layAcceptRemark.Size = new System.Drawing.Size(831, 25);
            this.layAcceptRemark.Text = "备注";
            this.layAcceptRemark.TextSize = new System.Drawing.Size(48, 17);
            // 
            // layAcceptDate
            // 
            this.layAcceptDate.Control = this.txtAcceptDate;
            this.layAcceptDate.CustomizationFormText = "验收日期";
            this.layAcceptDate.Location = new System.Drawing.Point(0, 75);
            this.layAcceptDate.Name = "layAcceptDate";
            this.layAcceptDate.Size = new System.Drawing.Size(831, 25);
            this.layAcceptDate.Text = "验收日期";
            this.layAcceptDate.TextSize = new System.Drawing.Size(48, 17);
            // 
            // barPopManager
            // 
            this.barPopManager.DockControls.Add(this.barDockControlTop);
            this.barPopManager.DockControls.Add(this.barDockControlBottom);
            this.barPopManager.DockControls.Add(this.barDockControlLeft);
            this.barPopManager.DockControls.Add(this.barDockControlRight);
            this.barPopManager.Form = this;
            this.barPopManager.Items.AddRange(new DevExpress.XtraBars.BarItem[] {
            this.bbiSampling});
            this.barPopManager.MaxItemId = 1;
            // 
            // barDockControlTop
            // 
            this.barDockControlTop.Dock = System.Windows.Forms.DockStyle.Top;
            this.barDockControlTop.Location = new System.Drawing.Point(0, 0);
            this.barDockControlTop.Size = new System.Drawing.Size(872, 0);
            // 
            // barDockControlBottom
            // 
            this.barDockControlBottom.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.barDockControlBottom.Location = new System.Drawing.Point(0, 531);
            this.barDockControlBottom.Size = new System.Drawing.Size(872, 0);
            // 
            // barDockControlLeft
            // 
            this.barDockControlLeft.Dock = System.Windows.Forms.DockStyle.Left;
            this.barDockControlLeft.Location = new System.Drawing.Point(0, 0);
            this.barDockControlLeft.Size = new System.Drawing.Size(0, 531);
            // 
            // barDockControlRight
            // 
            this.barDockControlRight.Dock = System.Windows.Forms.DockStyle.Right;
            this.barDockControlRight.Location = new System.Drawing.Point(872, 0);
            this.barDockControlRight.Size = new System.Drawing.Size(0, 531);
            // 
            // bbiSampling
            // 
            this.bbiSampling.Caption = "抽检(&C)";
            this.bbiSampling.Id = 0;
            this.bbiSampling.Name = "bbiSampling";
            this.bbiSampling.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.bbiSampling_ItemClick);
            // 
            // pnlAction
            // 
            this.pnlAction.Controls.Add(this.btnAttachment);
            this.pnlAction.Controls.Add(this.btnDealerQualification);
            this.pnlAction.Controls.Add(this.btnProductQualification);
            this.pnlAction.Controls.Add(this.btnPrint);
            this.pnlAction.Controls.Add(this.btnCancel);
            this.pnlAction.Controls.Add(this.btnSaveAndIn);
            this.pnlAction.Controls.Add(this.btnSave);
            this.pnlAction.Controls.Add(this.btnOneKeyFinish);
            this.pnlAction.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.pnlAction.Location = new System.Drawing.Point(0, 483);
            this.pnlAction.Name = "pnlAction";
            this.pnlAction.Size = new System.Drawing.Size(872, 48);
            this.pnlAction.TabIndex = 1;
            // 
            // btnAttachment
            // 
            this.btnAttachment.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnAttachment.Appearance.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAttachment.Appearance.Options.UseFont = true;
            this.btnAttachment.Location = new System.Drawing.Point(317, 13);
            this.btnAttachment.Name = "btnAttachment";
            this.btnAttachment.Size = new System.Drawing.Size(116, 23);
            this.btnAttachment.TabIndex = 8;
            this.btnAttachment.Text = "产品检验报告(&V)";
            this.btnAttachment.Click += new System.EventHandler(this.btnAttachment_Click);
            // 
            // btnDealerQualification
            // 
            this.btnDealerQualification.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnDealerQualification.Appearance.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDealerQualification.Appearance.Options.UseFont = true;
            this.btnDealerQualification.Location = new System.Drawing.Point(158, 13);
            this.btnDealerQualification.Name = "btnDealerQualification";
            this.btnDealerQualification.Size = new System.Drawing.Size(129, 23);
            this.btnDealerQualification.TabIndex = 7;
            this.btnDealerQualification.Text = "供货商电子档案(&D)";
            this.btnDealerQualification.Click += new System.EventHandler(this.btnDealerQualification_Click);
            // 
            // btnProductQualification
            // 
            this.btnProductQualification.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnProductQualification.Appearance.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnProductQualification.Appearance.Options.UseFont = true;
            this.btnProductQualification.Location = new System.Drawing.Point(9, 13);
            this.btnProductQualification.Name = "btnProductQualification";
            this.btnProductQualification.Size = new System.Drawing.Size(129, 23);
            this.btnProductQualification.TabIndex = 6;
            this.btnProductQualification.Text = "产品电子档案(&A)";
            this.btnProductQualification.Click += new System.EventHandler(this.btnProductQualification_Click);
            // 
            // btnPrint
            // 
            this.btnPrint.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnPrint.Appearance.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnPrint.Appearance.Options.UseFont = true;
            this.btnPrint.Location = new System.Drawing.Point(456, 13);
            this.btnPrint.Name = "btnPrint";
            this.btnPrint.OperationName = "Accept";
            this.btnPrint.ReportName = "验收单";
            this.btnPrint.Size = new System.Drawing.Size(75, 23);
            this.btnPrint.TabIndex = 5;
            this.btnPrint.Text = "打印(&P)";
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
            // btnSaveAndIn
            // 
            this.btnSaveAndIn.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnSaveAndIn.Appearance.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSaveAndIn.Appearance.Options.UseFont = true;
            this.btnSaveAndIn.Location = new System.Drawing.Point(669, 13);
            this.btnSaveAndIn.Name = "btnSaveAndIn";
            this.btnSaveAndIn.Size = new System.Drawing.Size(87, 23);
            this.btnSaveAndIn.TabIndex = 0;
            this.btnSaveAndIn.Text = "保存并入库";
            this.btnSaveAndIn.Visible = false;
            this.btnSaveAndIn.Click += new System.EventHandler(this.btnSaveAndIn_Click);
            // 
            // btnSave
            // 
            this.btnSave.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnSave.Appearance.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSave.Appearance.Options.UseFont = true;
            this.btnSave.Location = new System.Drawing.Point(681, 13);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(75, 23);
            this.btnSave.TabIndex = 0;
            this.btnSave.Text = "保存(&S)";
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // btnOneKeyFinish
            // 
            this.btnOneKeyFinish.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnOneKeyFinish.Appearance.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnOneKeyFinish.Appearance.Options.UseFont = true;
            this.btnOneKeyFinish.Location = new System.Drawing.Point(13, 15);
            this.btnOneKeyFinish.Name = "btnOneKeyFinish";
            this.btnOneKeyFinish.Size = new System.Drawing.Size(25, 21);
            this.btnOneKeyFinish.TabIndex = 2;
            this.btnOneKeyFinish.Text = "一键完成(&K)";
            this.btnOneKeyFinish.Click += new System.EventHandler(this.btnOneKeyFinish_Click);
            // 
            // popupMenuSampling
            // 
            this.popupMenuSampling.LinksPersistInfo.AddRange(new DevExpress.XtraBars.LinkPersistInfo[] {
            new DevExpress.XtraBars.LinkPersistInfo(this.bbiSampling)});
            this.popupMenuSampling.Manager = this.barPopManager;
            this.popupMenuSampling.Name = "popupMenuSampling";
            // 
            // gpcSampling
            // 
            this.gpcSampling.AppearanceCaption.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gpcSampling.AppearanceCaption.Options.UseFont = true;
            this.gpcSampling.Controls.Add(this.popupGridSampling);
            this.gpcSampling.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.gpcSampling.Location = new System.Drawing.Point(0, 299);
            this.gpcSampling.Name = "gpcSampling";
            this.gpcSampling.Size = new System.Drawing.Size(872, 184);
            this.gpcSampling.TabIndex = 7;
            this.gpcSampling.Text = "抽检记录";
            // 
            // popupGridSampling
            // 
            this.popupGridSampling.Dock = System.Windows.Forms.DockStyle.Fill;
            this.popupGridSampling.IsCalculatePrice = false;
            this.popupGridSampling.Location = new System.Drawing.Point(2, 25);
            this.popupGridSampling.Name = "popupGridSampling";
            this.popupGridSampling.OperationName = "Sampling";
            this.popupGridSampling.Size = new System.Drawing.Size(868, 157);
            this.popupGridSampling.TabIndex = 3;
            this.popupGridSampling.BeforePopupFormShow += new DQS.Controls.PopupGrid.OnBeforePopupFormShowEventHandler(this.popupGridSampling_BeforePopupFormShow);
            // 
            // splitterControl1
            // 
            this.splitterControl1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.splitterControl1.Location = new System.Drawing.Point(0, 293);
            this.splitterControl1.Name = "splitterControl1";
            this.splitterControl1.Size = new System.Drawing.Size(872, 6);
            this.splitterControl1.TabIndex = 8;
            this.splitterControl1.TabStop = false;
            // 
            // gpcButtom
            // 
            this.gpcButtom.AppearanceCaption.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gpcButtom.AppearanceCaption.Options.UseFont = true;
            this.gpcButtom.Controls.Add(this.popupGrid);
            this.gpcButtom.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gpcButtom.Location = new System.Drawing.Point(0, 138);
            this.gpcButtom.Name = "gpcButtom";
            this.gpcButtom.Size = new System.Drawing.Size(872, 155);
            this.gpcButtom.TabIndex = 9;
            this.gpcButtom.Text = "验收单检验详细";
            // 
            // popupGrid
            // 
            this.popupGrid.Dock = System.Windows.Forms.DockStyle.Fill;
            this.popupGrid.IsCalculatePrice = false;
            this.popupGrid.Location = new System.Drawing.Point(2, 25);
            this.popupGrid.Name = "popupGrid";
            this.popupGrid.OperationName = "Accept";
            this.popupGrid.Size = new System.Drawing.Size(868, 128);
            this.popupGrid.TabIndex = 3;
            this.popupGrid.BeforePopupFormShow += new DQS.Controls.PopupGrid.OnBeforePopupFormShowEventHandler(this.popupGrid_BeforePopupFormShow);
            // 
            // FrmSingleAccept
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 14F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(872, 531);
            this.Controls.Add(this.gpcButtom);
            this.Controls.Add(this.splitterControl1);
            this.Controls.Add(this.gpcSampling);
            this.Controls.Add(this.pnlAction);
            this.Controls.Add(this.ftPanel);
            this.Controls.Add(this.barDockControlLeft);
            this.Controls.Add(this.barDockControlRight);
            this.Controls.Add(this.barDockControlBottom);
            this.Controls.Add(this.barDockControlTop);
            this.MinimizeBox = false;
            this.Name = "FrmSingleAccept";
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "验收单";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.FrmSingleAccept_Load);
            ((System.ComponentModel.ISupportInitialize)(this.ftPanel)).EndInit();
            this.ftPanel.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.layControl)).EndInit();
            this.layControl.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.txtAcceptDate.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtBillCode.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtAcceptRemark.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtBillTypeName.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtDealerName.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtAcceptCode.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtAcceptPerson.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layControlGroup)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layAcceptCode)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layAcceptPerson)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layBillCode)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layBillTypeName)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layDealerName)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layAcceptRemark)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layAcceptDate)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.barPopManager)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pnlAction)).EndInit();
            this.pnlAction.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.popupMenuSampling)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gpcSampling)).EndInit();
            this.gpcSampling.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.popupGridSampling)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gpcButtom)).EndInit();
            this.gpcButtom.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.popupGrid)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DQS.Controls.FieldTextBoxPanel ftPanel;
        private DevExpress.XtraLayout.LayoutControl layControl;
        private DevExpress.XtraLayout.LayoutControlGroup layControlGroup;
        private DevExpress.XtraEditors.PanelControl pnlAction;
        private DevExpress.XtraEditors.SimpleButton btnCancel;
        private DevExpress.XtraEditors.SimpleButton btnSave;
        private DQS.Controls.BUSAcceptEntityTextBox txtAcceptCode;
        private DQS.Controls.TextBoxEnterPopupEx txtAcceptPerson;
        private DevExpress.XtraLayout.LayoutControlItem layAcceptCode;
        private DevExpress.XtraLayout.LayoutControlItem layAcceptPerson;
        private DQS.Controls.BUSAcceptEntityTextBox txtDealerName;
        private DQS.Controls.BUSAcceptEntityTextBox txtBillTypeName;
        private DQS.Controls.BUSAcceptEntityTextBox txtAcceptRemark;
        private DevExpress.XtraLayout.LayoutControlItem layBillTypeName;
        private DevExpress.XtraLayout.LayoutControlItem layDealerName;
        private DevExpress.XtraLayout.LayoutControlItem layAcceptRemark;
        private DevExpress.XtraEditors.SimpleButton btnOneKeyFinish;
        private DevExpress.XtraBars.PopupMenu popupMenuSampling;
        private DevExpress.XtraBars.BarButtonItem bbiSampling;
        private DevExpress.XtraBars.BarManager barPopManager;
        private DevExpress.XtraBars.BarDockControl barDockControlTop;
        private DevExpress.XtraBars.BarDockControl barDockControlBottom;
        private DevExpress.XtraBars.BarDockControl barDockControlLeft;
        private DevExpress.XtraBars.BarDockControl barDockControlRight;
        private DQS.Controls.TextBoxPopupEx txtBillCode;
        private DevExpress.XtraLayout.LayoutControlItem layBillCode;
        private DevExpress.XtraEditors.GroupControl gpcButtom;
        private DQS.Controls.PopupGrid popupGrid;
        private DevExpress.XtraEditors.SplitterControl splitterControl1;
        private DevExpress.XtraEditors.GroupControl gpcSampling;
        private DQS.Controls.PopupGrid popupGridSampling;
        private DQS.Controls.StiPrintButtonEx btnPrint;
        private DevExpress.XtraEditors.SimpleButton btnDealerQualification;
        private DevExpress.XtraEditors.SimpleButton btnProductQualification;
        private Controls.BUSAcceptEntityTextBox txtAcceptDate;
        private DevExpress.XtraLayout.LayoutControlItem layAcceptDate;
        private DevExpress.XtraEditors.SimpleButton btnAttachment;
        private DevExpress.XtraEditors.SimpleButton btnSaveAndIn;
    }
}