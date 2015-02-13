namespace DQS.AppViews.ExceptionControl.ExceptionManager
{
    partial class FrmSingleExceptionReport
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
            this.txtDealResult = new DQS.Controls.BUSExceptionReportEntityTextBox();
            this.txtDealSuggestion = new DQS.Controls.BUSExceptionReportEntityTextBox();
            this.txtDealPerson = new DQS.Controls.BUSExceptionReportEntityTextBox();
            this.tmeDealTime = new DevExpress.XtraEditors.TimeEdit();
            this.dteDealDate = new DevExpress.XtraEditors.DateEdit();
            this.txtExceptionRemark = new DQS.Controls.BUSExceptionReportEntityTextBox();
            this.txtExceptionContent = new DQS.Controls.BUSExceptionReportEntityTextBox();
            this.tmeFinderTime = new DevExpress.XtraEditors.TimeEdit();
            this.dteFinderDate = new DevExpress.XtraEditors.DateEdit();
            this.txtFinder = new DQS.Controls.BUSExceptionReportEntityTextBox();
            this.txtExceptionCode = new DQS.Controls.BUSExceptionReportEntityTextBox();
            this.rdgIsDeal = new DevExpress.XtraEditors.RadioGroup();
            this.layControlGroup = new DevExpress.XtraLayout.LayoutControlGroup();
            this.layIsDeal = new DevExpress.XtraLayout.LayoutControlItem();
            this.layExceptionCode = new DevExpress.XtraLayout.LayoutControlItem();
            this.layFinder = new DevExpress.XtraLayout.LayoutControlItem();
            this.layFinderDate = new DevExpress.XtraLayout.LayoutControlItem();
            this.layFinderTime = new DevExpress.XtraLayout.LayoutControlItem();
            this.layExceptionContent = new DevExpress.XtraLayout.LayoutControlItem();
            this.layExceptionRemark = new DevExpress.XtraLayout.LayoutControlItem();
            this.layDealTime = new DevExpress.XtraLayout.LayoutControlItem();
            this.layControlGroupDeal = new DevExpress.XtraLayout.LayoutControlGroup();
            this.layDealPerson = new DevExpress.XtraLayout.LayoutControlItem();
            this.layDealSuggestion = new DevExpress.XtraLayout.LayoutControlItem();
            this.layDealResult = new DevExpress.XtraLayout.LayoutControlItem();
            this.layDealDate = new DevExpress.XtraLayout.LayoutControlItem();
            this.pnlAction = new DevExpress.XtraEditors.PanelControl();
            this.btnCancel = new DevExpress.XtraEditors.SimpleButton();
            this.btnSave = new DevExpress.XtraEditors.SimpleButton();
            this.gpcButtom = new DevExpress.XtraEditors.GroupControl();
            this.popupGrid = new DQS.Controls.PopupGrid();
            ((System.ComponentModel.ISupportInitialize)(this.ftPanel)).BeginInit();
            this.ftPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.layControl)).BeginInit();
            this.layControl.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.txtDealResult.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtDealSuggestion.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtDealPerson.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tmeDealTime.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dteDealDate.Properties.VistaTimeProperties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dteDealDate.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtExceptionRemark.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtExceptionContent.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tmeFinderTime.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dteFinderDate.Properties.VistaTimeProperties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dteFinderDate.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtFinder.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtExceptionCode.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.rdgIsDeal.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layControlGroup)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layIsDeal)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layExceptionCode)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layFinder)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layFinderDate)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layFinderTime)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layExceptionContent)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layExceptionRemark)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layDealTime)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layControlGroupDeal)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layDealPerson)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layDealSuggestion)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layDealResult)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layDealDate)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pnlAction)).BeginInit();
            this.pnlAction.SuspendLayout();
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
            this.ftPanel.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.ftPanel.Name = "ftPanel";
            this.ftPanel.Size = new System.Drawing.Size(981, 330);
            this.ftPanel.TabIndex = 0;
            this.ftPanel.TypeOfEntity = DQS.Module.EntityType2.BUSExceptionReportEntity;
            // 
            // layControl
            // 
            this.layControl.Controls.Add(this.txtDealResult);
            this.layControl.Controls.Add(this.txtDealSuggestion);
            this.layControl.Controls.Add(this.txtDealPerson);
            this.layControl.Controls.Add(this.tmeDealTime);
            this.layControl.Controls.Add(this.dteDealDate);
            this.layControl.Controls.Add(this.txtExceptionRemark);
            this.layControl.Controls.Add(this.txtExceptionContent);
            this.layControl.Controls.Add(this.tmeFinderTime);
            this.layControl.Controls.Add(this.dteFinderDate);
            this.layControl.Controls.Add(this.txtFinder);
            this.layControl.Controls.Add(this.txtExceptionCode);
            this.layControl.Controls.Add(this.rdgIsDeal);
            this.layControl.Dock = System.Windows.Forms.DockStyle.Fill;
            this.layControl.Location = new System.Drawing.Point(2, 2);
            this.layControl.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.layControl.Name = "layControl";
            this.layControl.Root = this.layControlGroup;
            this.layControl.Size = new System.Drawing.Size(977, 326);
            this.layControl.TabIndex = 0;
            this.layControl.Text = "layControl";
            // 
            // txtDealResult
            // 
            this.txtDealResult.AlphabeticFiled = null;
            this.txtDealResult.EntityField = DQS.Module.Entities.BUSExceptionReportEntityFields2.DealResult;
            this.txtDealResult.IsIntegerOnly = false;
            this.txtDealResult.IsNullString = null;
            this.txtDealResult.IsNullValidate = false;
            this.txtDealResult.IsTransferAlphabetic = false;
            this.txtDealResult.Location = new System.Drawing.Point(87, 227);
            this.txtDealResult.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtDealResult.Name = "txtDealResult";
            this.txtDealResult.Size = new System.Drawing.Size(866, 25);
            this.txtDealResult.StyleController = this.layControl;
            this.txtDealResult.TabIndex = 2;
            // 
            // txtDealSuggestion
            // 
            this.txtDealSuggestion.AlphabeticFiled = null;
            this.txtDealSuggestion.EntityField = DQS.Module.Entities.BUSExceptionReportEntityFields2.DealSuggestion;
            this.txtDealSuggestion.IsIntegerOnly = false;
            this.txtDealSuggestion.IsNullString = null;
            this.txtDealSuggestion.IsNullValidate = false;
            this.txtDealSuggestion.IsTransferAlphabetic = false;
            this.txtDealSuggestion.Location = new System.Drawing.Point(553, 198);
            this.txtDealSuggestion.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtDealSuggestion.Name = "txtDealSuggestion";
            this.txtDealSuggestion.Size = new System.Drawing.Size(400, 25);
            this.txtDealSuggestion.StyleController = this.layControl;
            this.txtDealSuggestion.TabIndex = 2;
            // 
            // txtDealPerson
            // 
            this.txtDealPerson.AlphabeticFiled = "DealPersonSpell";
            this.txtDealPerson.EntityField = DQS.Module.Entities.BUSExceptionReportEntityFields2.DealPerson;
            this.txtDealPerson.IsIntegerOnly = false;
            this.txtDealPerson.IsNullString = null;
            this.txtDealPerson.IsNullValidate = false;
            this.txtDealPerson.IsTransferAlphabetic = true;
            this.txtDealPerson.Location = new System.Drawing.Point(87, 198);
            this.txtDealPerson.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtDealPerson.Name = "txtDealPerson";
            this.txtDealPerson.Size = new System.Drawing.Size(399, 25);
            this.txtDealPerson.StyleController = this.layControl;
            this.txtDealPerson.TabIndex = 2;
            // 
            // tmeDealTime
            // 
            this.tmeDealTime.EditValue = new System.DateTime(2013, 10, 30, 0, 0, 0, 0);
            this.tmeDealTime.Location = new System.Drawing.Point(658, 128);
            this.tmeDealTime.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.tmeDealTime.Name = "tmeDealTime";
            this.tmeDealTime.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton()});
            this.tmeDealTime.Properties.ReadOnly = true;
            this.tmeDealTime.Size = new System.Drawing.Size(307, 25);
            this.tmeDealTime.StyleController = this.layControl;
            this.tmeDealTime.TabIndex = 7;
            // 
            // dteDealDate
            // 
            this.dteDealDate.EditValue = null;
            this.dteDealDate.Location = new System.Drawing.Point(284, 128);
            this.dteDealDate.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.dteDealDate.Name = "dteDealDate";
            this.dteDealDate.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.dteDealDate.Properties.ReadOnly = true;
            this.dteDealDate.Properties.VistaTimeProperties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton()});
            this.dteDealDate.Size = new System.Drawing.Size(307, 25);
            this.dteDealDate.StyleController = this.layControl;
            this.dteDealDate.TabIndex = 6;
            // 
            // txtExceptionRemark
            // 
            this.txtExceptionRemark.AlphabeticFiled = null;
            this.txtExceptionRemark.EntityField = DQS.Module.Entities.BUSExceptionReportEntityFields2.ExceptionRemark;
            this.txtExceptionRemark.IsIntegerOnly = false;
            this.txtExceptionRemark.IsNullString = null;
            this.txtExceptionRemark.IsNullValidate = false;
            this.txtExceptionRemark.IsTransferAlphabetic = false;
            this.txtExceptionRemark.Location = new System.Drawing.Point(75, 99);
            this.txtExceptionRemark.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtExceptionRemark.Name = "txtExceptionRemark";
            this.txtExceptionRemark.Size = new System.Drawing.Size(890, 25);
            this.txtExceptionRemark.StyleController = this.layControl;
            this.txtExceptionRemark.TabIndex = 2;
            // 
            // txtExceptionContent
            // 
            this.txtExceptionContent.AlphabeticFiled = null;
            this.txtExceptionContent.EntityField = DQS.Module.Entities.BUSExceptionReportEntityFields2.ExceptionContent;
            this.txtExceptionContent.IsIntegerOnly = false;
            this.txtExceptionContent.IsNullString = null;
            this.txtExceptionContent.IsNullValidate = false;
            this.txtExceptionContent.IsTransferAlphabetic = false;
            this.txtExceptionContent.Location = new System.Drawing.Point(75, 70);
            this.txtExceptionContent.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtExceptionContent.Name = "txtExceptionContent";
            this.txtExceptionContent.Size = new System.Drawing.Size(890, 25);
            this.txtExceptionContent.StyleController = this.layControl;
            this.txtExceptionContent.TabIndex = 2;
            // 
            // tmeFinderTime
            // 
            this.tmeFinderTime.EditValue = new System.DateTime(2013, 10, 30, 0, 0, 0, 0);
            this.tmeFinderTime.Location = new System.Drawing.Point(553, 41);
            this.tmeFinderTime.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.tmeFinderTime.Name = "tmeFinderTime";
            this.tmeFinderTime.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton()});
            this.tmeFinderTime.Properties.ReadOnly = true;
            this.tmeFinderTime.Size = new System.Drawing.Size(412, 25);
            this.tmeFinderTime.StyleController = this.layControl;
            this.tmeFinderTime.TabIndex = 5;
            // 
            // dteFinderDate
            // 
            this.dteFinderDate.EditValue = null;
            this.dteFinderDate.Location = new System.Drawing.Point(75, 41);
            this.dteFinderDate.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.dteFinderDate.Name = "dteFinderDate";
            this.dteFinderDate.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.dteFinderDate.Properties.ReadOnly = true;
            this.dteFinderDate.Properties.VistaTimeProperties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton()});
            this.dteFinderDate.Size = new System.Drawing.Size(411, 25);
            this.dteFinderDate.StyleController = this.layControl;
            this.dteFinderDate.TabIndex = 4;
            // 
            // txtFinder
            // 
            this.txtFinder.AlphabeticFiled = "FinderSpell";
            this.txtFinder.EntityField = DQS.Module.Entities.BUSExceptionReportEntityFields2.Finder;
            this.txtFinder.IsIntegerOnly = false;
            this.txtFinder.IsNullString = null;
            this.txtFinder.IsNullValidate = false;
            this.txtFinder.IsTransferAlphabetic = true;
            this.txtFinder.Location = new System.Drawing.Point(553, 12);
            this.txtFinder.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtFinder.Name = "txtFinder";
            this.txtFinder.Properties.ReadOnly = true;
            this.txtFinder.Size = new System.Drawing.Size(412, 25);
            this.txtFinder.StyleController = this.layControl;
            this.txtFinder.TabIndex = 2;
            // 
            // txtExceptionCode
            // 
            this.txtExceptionCode.AlphabeticFiled = null;
            this.txtExceptionCode.EntityField = DQS.Module.Entities.BUSExceptionReportEntityFields2.ExceptionCode;
            this.txtExceptionCode.IsIntegerOnly = false;
            this.txtExceptionCode.IsNullString = "异常编号不能为空。";
            this.txtExceptionCode.IsNullValidate = true;
            this.txtExceptionCode.IsTransferAlphabetic = false;
            this.txtExceptionCode.Location = new System.Drawing.Point(75, 12);
            this.txtExceptionCode.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtExceptionCode.Name = "txtExceptionCode";
            this.txtExceptionCode.Size = new System.Drawing.Size(411, 25);
            this.txtExceptionCode.StyleController = this.layControl;
            this.txtExceptionCode.TabIndex = 2;
            // 
            // rdgIsDeal
            // 
            this.rdgIsDeal.EditValue = false;
            this.rdgIsDeal.Location = new System.Drawing.Point(75, 128);
            this.rdgIsDeal.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.rdgIsDeal.Name = "rdgIsDeal";
            this.rdgIsDeal.Properties.Appearance.BackColor = System.Drawing.Color.Transparent;
            this.rdgIsDeal.Properties.Appearance.Options.UseBackColor = true;
            this.rdgIsDeal.Properties.Items.AddRange(new DevExpress.XtraEditors.Controls.RadioGroupItem[] {
            new DevExpress.XtraEditors.Controls.RadioGroupItem(false, "否"),
            new DevExpress.XtraEditors.Controls.RadioGroupItem(true, "是")});
            this.rdgIsDeal.Size = new System.Drawing.Size(142, 29);
            this.rdgIsDeal.StyleController = this.layControl;
            this.rdgIsDeal.TabIndex = 2;
            this.rdgIsDeal.SelectedIndexChanged += new System.EventHandler(this.rdgIsDeal_SelectedIndexChanged);
            // 
            // layControlGroup
            // 
            this.layControlGroup.AppearanceItemCaption.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.layControlGroup.AppearanceItemCaption.Options.UseFont = true;
            this.layControlGroup.CustomizationFormText = "异常上报记录";
            this.layControlGroup.EnableIndentsWithoutBorders = DevExpress.Utils.DefaultBoolean.True;
            this.layControlGroup.GroupBordersVisible = false;
            this.layControlGroup.Items.AddRange(new DevExpress.XtraLayout.BaseLayoutItem[] {
            this.layIsDeal,
            this.layExceptionCode,
            this.layFinder,
            this.layFinderDate,
            this.layFinderTime,
            this.layExceptionContent,
            this.layExceptionRemark,
            this.layDealTime,
            this.layControlGroupDeal,
            this.layDealDate});
            this.layControlGroup.Location = new System.Drawing.Point(0, 0);
            this.layControlGroup.Name = "layControlGroup";
            this.layControlGroup.Size = new System.Drawing.Size(977, 326);
            this.layControlGroup.Spacing = new DevExpress.XtraLayout.Utils.Padding(0, 0, 0, 0);
            this.layControlGroup.Text = "异常上报记录";
            this.layControlGroup.TextVisible = false;
            // 
            // layIsDeal
            // 
            this.layIsDeal.Control = this.rdgIsDeal;
            this.layIsDeal.CustomizationFormText = "是否处理";
            this.layIsDeal.Location = new System.Drawing.Point(0, 116);
            this.layIsDeal.Name = "layIsDeal";
            this.layIsDeal.Size = new System.Drawing.Size(209, 33);
            this.layIsDeal.Text = "是否处理";
            this.layIsDeal.TextSize = new System.Drawing.Size(60, 20);
            // 
            // layExceptionCode
            // 
            this.layExceptionCode.Control = this.txtExceptionCode;
            this.layExceptionCode.CustomizationFormText = "异常编号";
            this.layExceptionCode.Location = new System.Drawing.Point(0, 0);
            this.layExceptionCode.Name = "layExceptionCode";
            this.layExceptionCode.Size = new System.Drawing.Size(478, 29);
            this.layExceptionCode.Text = "异常编号";
            this.layExceptionCode.TextSize = new System.Drawing.Size(60, 20);
            // 
            // layFinder
            // 
            this.layFinder.Control = this.txtFinder;
            this.layFinder.CustomizationFormText = "发现人";
            this.layFinder.Location = new System.Drawing.Point(478, 0);
            this.layFinder.Name = "layFinder";
            this.layFinder.Size = new System.Drawing.Size(479, 29);
            this.layFinder.Text = "发现人";
            this.layFinder.TextSize = new System.Drawing.Size(60, 20);
            // 
            // layFinderDate
            // 
            this.layFinderDate.Control = this.dteFinderDate;
            this.layFinderDate.CustomizationFormText = "发现日期";
            this.layFinderDate.Location = new System.Drawing.Point(0, 29);
            this.layFinderDate.Name = "layFinderDate";
            this.layFinderDate.Size = new System.Drawing.Size(478, 29);
            this.layFinderDate.Text = "发现日期";
            this.layFinderDate.TextSize = new System.Drawing.Size(60, 20);
            // 
            // layFinderTime
            // 
            this.layFinderTime.Control = this.tmeFinderTime;
            this.layFinderTime.CustomizationFormText = "发现时间";
            this.layFinderTime.Location = new System.Drawing.Point(478, 29);
            this.layFinderTime.Name = "layFinderTime";
            this.layFinderTime.Size = new System.Drawing.Size(479, 29);
            this.layFinderTime.Text = "发现时间";
            this.layFinderTime.TextSize = new System.Drawing.Size(60, 20);
            // 
            // layExceptionContent
            // 
            this.layExceptionContent.Control = this.txtExceptionContent;
            this.layExceptionContent.CustomizationFormText = "异常内容";
            this.layExceptionContent.Location = new System.Drawing.Point(0, 58);
            this.layExceptionContent.Name = "layExceptionContent";
            this.layExceptionContent.Size = new System.Drawing.Size(957, 29);
            this.layExceptionContent.Text = "异常内容";
            this.layExceptionContent.TextSize = new System.Drawing.Size(60, 20);
            // 
            // layExceptionRemark
            // 
            this.layExceptionRemark.Control = this.txtExceptionRemark;
            this.layExceptionRemark.CustomizationFormText = "备注";
            this.layExceptionRemark.Location = new System.Drawing.Point(0, 87);
            this.layExceptionRemark.Name = "layExceptionRemark";
            this.layExceptionRemark.Size = new System.Drawing.Size(957, 29);
            this.layExceptionRemark.Text = "备注";
            this.layExceptionRemark.TextSize = new System.Drawing.Size(60, 20);
            // 
            // layDealTime
            // 
            this.layDealTime.Control = this.tmeDealTime;
            this.layDealTime.CustomizationFormText = "处理时间";
            this.layDealTime.Location = new System.Drawing.Point(583, 116);
            this.layDealTime.Name = "layDealTime";
            this.layDealTime.Size = new System.Drawing.Size(374, 33);
            this.layDealTime.Text = "处理时间";
            this.layDealTime.TextSize = new System.Drawing.Size(60, 20);
            // 
            // layControlGroupDeal
            // 
            this.layControlGroupDeal.CustomizationFormText = "处理信息";
            this.layControlGroupDeal.Items.AddRange(new DevExpress.XtraLayout.BaseLayoutItem[] {
            this.layDealPerson,
            this.layDealSuggestion,
            this.layDealResult});
            this.layControlGroupDeal.Location = new System.Drawing.Point(0, 149);
            this.layControlGroupDeal.Name = "layControlGroupDeal";
            this.layControlGroupDeal.Size = new System.Drawing.Size(957, 157);
            this.layControlGroupDeal.Text = "处理信息";
            // 
            // layDealPerson
            // 
            this.layDealPerson.Control = this.txtDealPerson;
            this.layDealPerson.CustomizationFormText = "处理人";
            this.layDealPerson.Location = new System.Drawing.Point(0, 0);
            this.layDealPerson.Name = "layDealPerson";
            this.layDealPerson.Size = new System.Drawing.Size(466, 29);
            this.layDealPerson.Text = "处理人";
            this.layDealPerson.TextSize = new System.Drawing.Size(60, 20);
            // 
            // layDealSuggestion
            // 
            this.layDealSuggestion.Control = this.txtDealSuggestion;
            this.layDealSuggestion.CustomizationFormText = "处理方案";
            this.layDealSuggestion.Location = new System.Drawing.Point(466, 0);
            this.layDealSuggestion.Name = "layDealSuggestion";
            this.layDealSuggestion.Size = new System.Drawing.Size(467, 29);
            this.layDealSuggestion.Text = "处理方案";
            this.layDealSuggestion.TextSize = new System.Drawing.Size(60, 20);
            // 
            // layDealResult
            // 
            this.layDealResult.Control = this.txtDealResult;
            this.layDealResult.CustomizationFormText = "处理结果";
            this.layDealResult.Location = new System.Drawing.Point(0, 29);
            this.layDealResult.Name = "layDealResult";
            this.layDealResult.Size = new System.Drawing.Size(933, 79);
            this.layDealResult.Text = "处理结果";
            this.layDealResult.TextSize = new System.Drawing.Size(60, 20);
            // 
            // layDealDate
            // 
            this.layDealDate.Control = this.dteDealDate;
            this.layDealDate.CustomizationFormText = "处理日期";
            this.layDealDate.Location = new System.Drawing.Point(209, 116);
            this.layDealDate.Name = "layDealDate";
            this.layDealDate.Size = new System.Drawing.Size(374, 33);
            this.layDealDate.Text = "处理日期";
            this.layDealDate.TextSize = new System.Drawing.Size(60, 20);
            // 
            // pnlAction
            // 
            this.pnlAction.Controls.Add(this.btnCancel);
            this.pnlAction.Controls.Add(this.btnSave);
            this.pnlAction.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.pnlAction.Location = new System.Drawing.Point(0, 621);
            this.pnlAction.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.pnlAction.Name = "pnlAction";
            this.pnlAction.Size = new System.Drawing.Size(981, 62);
            this.pnlAction.TabIndex = 1;
            // 
            // btnCancel
            // 
            this.btnCancel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnCancel.Appearance.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCancel.Appearance.Options.UseFont = true;
            this.btnCancel.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btnCancel.Location = new System.Drawing.Point(879, 17);
            this.btnCancel.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(86, 30);
            this.btnCancel.TabIndex = 1;
            this.btnCancel.Text = "取消(&C)";
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // btnSave
            // 
            this.btnSave.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnSave.Appearance.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSave.Appearance.Options.UseFont = true;
            this.btnSave.Location = new System.Drawing.Point(759, 17);
            this.btnSave.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(86, 30);
            this.btnSave.TabIndex = 0;
            this.btnSave.Text = "保存(&S)";
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // gpcButtom
            // 
            this.gpcButtom.AppearanceCaption.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gpcButtom.AppearanceCaption.Options.UseFont = true;
            this.gpcButtom.Controls.Add(this.popupGrid);
            this.gpcButtom.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gpcButtom.Location = new System.Drawing.Point(0, 330);
            this.gpcButtom.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.gpcButtom.Name = "gpcButtom";
            this.gpcButtom.Size = new System.Drawing.Size(981, 291);
            this.gpcButtom.TabIndex = 2;
            this.gpcButtom.Text = "药品明细";
            // 
            // popupGrid
            // 
            this.popupGrid.Dock = System.Windows.Forms.DockStyle.Fill;
            this.popupGrid.EmbeddedNavigator.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.popupGrid.IsCalculatePrice = false;
            this.popupGrid.Location = new System.Drawing.Point(2, 28);
            this.popupGrid.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.popupGrid.Name = "popupGrid";
            this.popupGrid.OperationName = "Exception";
            this.popupGrid.Size = new System.Drawing.Size(977, 261);
            this.popupGrid.TabIndex = 2;
            this.popupGrid.PopupClosed += new DQS.Controls.PopupGrid.OnPopupClosedEventHandler(this.popupGrid_PopupClosed);
            // 
            // FrmSingleExceptionReport
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 18F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(981, 683);
            this.Controls.Add(this.gpcButtom);
            this.Controls.Add(this.pnlAction);
            this.Controls.Add(this.ftPanel);
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FrmSingleExceptionReport";
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "异常上报记录";
            this.Load += new System.EventHandler(this.FrmSingleExceptionReport_Load);
            ((System.ComponentModel.ISupportInitialize)(this.ftPanel)).EndInit();
            this.ftPanel.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.layControl)).EndInit();
            this.layControl.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.txtDealResult.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtDealSuggestion.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtDealPerson.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tmeDealTime.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dteDealDate.Properties.VistaTimeProperties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dteDealDate.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtExceptionRemark.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtExceptionContent.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tmeFinderTime.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dteFinderDate.Properties.VistaTimeProperties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dteFinderDate.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtFinder.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtExceptionCode.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.rdgIsDeal.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layControlGroup)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layIsDeal)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layExceptionCode)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layFinder)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layFinderDate)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layFinderTime)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layExceptionContent)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layExceptionRemark)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layDealTime)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layControlGroupDeal)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layDealPerson)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layDealSuggestion)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layDealResult)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layDealDate)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pnlAction)).EndInit();
            this.pnlAction.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.gpcButtom)).EndInit();
            this.gpcButtom.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.popupGrid)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DQS.Controls.FieldTextBoxPanel ftPanel;
        private DevExpress.XtraEditors.PanelControl pnlAction;
        private DevExpress.XtraLayout.LayoutControl layControl;
        private DevExpress.XtraLayout.LayoutControlGroup layControlGroup;
        private DevExpress.XtraEditors.GroupControl gpcButtom;
        private DevExpress.XtraEditors.SimpleButton btnCancel;
        private DevExpress.XtraEditors.SimpleButton btnSave;
        private DQS.Controls.PopupGrid popupGrid;
        private DevExpress.XtraEditors.RadioGroup rdgIsDeal;
        private DevExpress.XtraLayout.LayoutControlItem layIsDeal;
        private DQS.Controls.BUSExceptionReportEntityTextBox txtExceptionCode;
        private DevExpress.XtraLayout.LayoutControlItem layExceptionCode;
        private DQS.Controls.BUSExceptionReportEntityTextBox txtDealResult;
        private DQS.Controls.BUSExceptionReportEntityTextBox txtDealSuggestion;
        private DQS.Controls.BUSExceptionReportEntityTextBox txtDealPerson;
        private DevExpress.XtraEditors.TimeEdit tmeDealTime;
        private DevExpress.XtraEditors.DateEdit dteDealDate;
        private DQS.Controls.BUSExceptionReportEntityTextBox txtExceptionRemark;
        private DQS.Controls.BUSExceptionReportEntityTextBox txtExceptionContent;
        private DevExpress.XtraEditors.TimeEdit tmeFinderTime;
        private DevExpress.XtraEditors.DateEdit dteFinderDate;
        private DQS.Controls.BUSExceptionReportEntityTextBox txtFinder;
        private DevExpress.XtraLayout.LayoutControlItem layFinder;
        private DevExpress.XtraLayout.LayoutControlItem layFinderDate;
        private DevExpress.XtraLayout.LayoutControlItem layFinderTime;
        private DevExpress.XtraLayout.LayoutControlItem layExceptionContent;
        private DevExpress.XtraLayout.LayoutControlItem layExceptionRemark;
        private DevExpress.XtraLayout.LayoutControlItem layDealTime;
        private DevExpress.XtraLayout.LayoutControlGroup layControlGroupDeal;
        private DevExpress.XtraLayout.LayoutControlItem layDealPerson;
        private DevExpress.XtraLayout.LayoutControlItem layDealSuggestion;
        private DevExpress.XtraLayout.LayoutControlItem layDealDate;
        private DevExpress.XtraLayout.LayoutControlItem layDealResult;
    }
}