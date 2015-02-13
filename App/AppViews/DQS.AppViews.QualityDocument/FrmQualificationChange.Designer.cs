namespace DQS.AppViews.QualityDocument
{
    partial class FrmQualificationChange
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
            this.pnOperating = new DevExpress.XtraEditors.PanelControl();
            this.btnCancel = new DevExpress.XtraEditors.SimpleButton();
            this.btnSave = new DevExpress.XtraEditors.SimpleButton();
            this.ftPanel = new DQS.Controls.FieldTextBoxPanel();
            this.layData = new DevExpress.XtraLayout.LayoutControl();
            this.txtQualificationRemark = new DQS.Controls.BFIQualificationEntityTextBox();
            this.dteValidateDate = new DevExpress.XtraEditors.DateEdit();
            this.dteIssuingDate = new DevExpress.XtraEditors.DateEdit();
            this.txtIssuingAuthority = new DQS.Controls.BFIQualificationEntityTextBox();
            this.txtCertificateNo = new DQS.Controls.BFIQualificationEntityTextBox();
            this.cbxCertificateStyle = new DQS.Controls.ComboBoxCategoryEx();
            this.txtQualificationName = new DQS.Controls.BFIQualificationEntityTextBox();
            this.txtQualificationCode = new DQS.Controls.BFIQualificationEntityTextBox();
            this.chkNoEndDate = new DevExpress.XtraEditors.CheckEdit();
            this.layControlGroup = new DevExpress.XtraLayout.LayoutControlGroup();
            this.layQualificationCode = new DevExpress.XtraLayout.LayoutControlItem();
            this.layQualificationName = new DevExpress.XtraLayout.LayoutControlItem();
            this.layCertificateStyle = new DevExpress.XtraLayout.LayoutControlItem();
            this.layCertificateNo = new DevExpress.XtraLayout.LayoutControlItem();
            this.layIssuingAuthority = new DevExpress.XtraLayout.LayoutControlItem();
            this.layIssuingDate = new DevExpress.XtraLayout.LayoutControlItem();
            this.layValidateDate = new DevExpress.XtraLayout.LayoutControlItem();
            this.layQualificationRemark = new DevExpress.XtraLayout.LayoutControlItem();
            this.layoutControlItem1 = new DevExpress.XtraLayout.LayoutControlItem();
            ((System.ComponentModel.ISupportInitialize)(this.pnOperating)).BeginInit();
            this.pnOperating.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ftPanel)).BeginInit();
            this.ftPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.layData)).BeginInit();
            this.layData.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.txtQualificationRemark.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dteValidateDate.Properties.VistaTimeProperties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dteValidateDate.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dteIssuingDate.Properties.VistaTimeProperties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dteIssuingDate.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtIssuingAuthority.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtCertificateNo.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cbxCertificateStyle.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtQualificationName.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtQualificationCode.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.chkNoEndDate.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layControlGroup)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layQualificationCode)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layQualificationName)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layCertificateStyle)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layCertificateNo)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layIssuingAuthority)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layIssuingDate)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layValidateDate)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layQualificationRemark)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem1)).BeginInit();
            this.SuspendLayout();
            // 
            // pnOperating
            // 
            this.pnOperating.Controls.Add(this.btnCancel);
            this.pnOperating.Controls.Add(this.btnSave);
            this.pnOperating.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.pnOperating.Location = new System.Drawing.Point(0, 283);
            this.pnOperating.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.pnOperating.Name = "pnOperating";
            this.pnOperating.Size = new System.Drawing.Size(374, 55);
            this.pnOperating.TabIndex = 1;
            // 
            // btnCancel
            // 
            this.btnCancel.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.btnCancel.Appearance.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCancel.Appearance.Options.UseFont = true;
            this.btnCancel.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btnCancel.Location = new System.Drawing.Point(274, 12);
            this.btnCancel.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(86, 30);
            this.btnCancel.TabIndex = 1;
            this.btnCancel.Text = "取消(&C)";
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // btnSave
            // 
            this.btnSave.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.btnSave.Appearance.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSave.Appearance.Options.UseFont = true;
            this.btnSave.Location = new System.Drawing.Point(174, 12);
            this.btnSave.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(86, 30);
            this.btnSave.TabIndex = 0;
            this.btnSave.Text = "保存(&S)";
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // ftPanel
            // 
            this.ftPanel.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.NoBorder;
            this.ftPanel.Controls.Add(this.layData);
            this.ftPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.ftPanel.Location = new System.Drawing.Point(0, 0);
            this.ftPanel.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.ftPanel.Name = "ftPanel";
            this.ftPanel.Size = new System.Drawing.Size(374, 283);
            this.ftPanel.TabIndex = 0;
            this.ftPanel.TypeOfEntity = DQS.Module.EntityType2.BFIQualificationEntity;
            // 
            // layData
            // 
            this.layData.Controls.Add(this.txtQualificationRemark);
            this.layData.Controls.Add(this.dteValidateDate);
            this.layData.Controls.Add(this.dteIssuingDate);
            this.layData.Controls.Add(this.txtIssuingAuthority);
            this.layData.Controls.Add(this.txtCertificateNo);
            this.layData.Controls.Add(this.cbxCertificateStyle);
            this.layData.Controls.Add(this.txtQualificationName);
            this.layData.Controls.Add(this.txtQualificationCode);
            this.layData.Controls.Add(this.chkNoEndDate);
            this.layData.Dock = System.Windows.Forms.DockStyle.Fill;
            this.layData.Location = new System.Drawing.Point(0, 0);
            this.layData.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.layData.Name = "layData";
            this.layData.Root = this.layControlGroup;
            this.layData.Size = new System.Drawing.Size(374, 283);
            this.layData.TabIndex = 0;
            this.layData.Text = "layControl";
            // 
            // txtQualificationRemark
            // 
            this.txtQualificationRemark.AlphabeticFiled = null;
            this.txtQualificationRemark.EntityField = DQS.Module.Entities.BFIQualificationEntityFields2.QualificationRemark;
            this.txtQualificationRemark.IsIntegerOnly = false;
            this.txtQualificationRemark.IsNullString = null;
            this.txtQualificationRemark.IsNullValidate = false;
            this.txtQualificationRemark.IsTransferAlphabetic = false;
            this.txtQualificationRemark.Location = new System.Drawing.Point(75, 244);
            this.txtQualificationRemark.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtQualificationRemark.Name = "txtQualificationRemark";
            this.txtQualificationRemark.Size = new System.Drawing.Size(287, 25);
            this.txtQualificationRemark.StyleController = this.layData;
            this.txtQualificationRemark.TabIndex = 2;
            // 
            // dteValidateDate
            // 
            this.dteValidateDate.EditValue = null;
            this.dteValidateDate.Location = new System.Drawing.Point(75, 186);
            this.dteValidateDate.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.dteValidateDate.Name = "dteValidateDate";
            this.dteValidateDate.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.dteValidateDate.Properties.VistaTimeProperties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton()});
            this.dteValidateDate.Size = new System.Drawing.Size(287, 25);
            this.dteValidateDate.StyleController = this.layData;
            this.dteValidateDate.TabIndex = 7;
            // 
            // dteIssuingDate
            // 
            this.dteIssuingDate.EditValue = null;
            this.dteIssuingDate.Location = new System.Drawing.Point(75, 157);
            this.dteIssuingDate.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.dteIssuingDate.Name = "dteIssuingDate";
            this.dteIssuingDate.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.dteIssuingDate.Properties.VistaTimeProperties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton()});
            this.dteIssuingDate.Size = new System.Drawing.Size(287, 25);
            this.dteIssuingDate.StyleController = this.layData;
            this.dteIssuingDate.TabIndex = 6;
            // 
            // txtIssuingAuthority
            // 
            this.txtIssuingAuthority.AlphabeticFiled = null;
            this.txtIssuingAuthority.EntityField = DQS.Module.Entities.BFIQualificationEntityFields2.IssuingAuthority;
            this.txtIssuingAuthority.IsIntegerOnly = false;
            this.txtIssuingAuthority.IsNullString = null;
            this.txtIssuingAuthority.IsNullValidate = false;
            this.txtIssuingAuthority.IsTransferAlphabetic = false;
            this.txtIssuingAuthority.Location = new System.Drawing.Point(75, 128);
            this.txtIssuingAuthority.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtIssuingAuthority.Name = "txtIssuingAuthority";
            this.txtIssuingAuthority.Size = new System.Drawing.Size(287, 25);
            this.txtIssuingAuthority.StyleController = this.layData;
            this.txtIssuingAuthority.TabIndex = 2;
            // 
            // txtCertificateNo
            // 
            this.txtCertificateNo.AlphabeticFiled = null;
            this.txtCertificateNo.EntityField = DQS.Module.Entities.BFIQualificationEntityFields2.CertificateNo;
            this.txtCertificateNo.IsIntegerOnly = false;
            this.txtCertificateNo.IsNullString = null;
            this.txtCertificateNo.IsNullValidate = false;
            this.txtCertificateNo.IsTransferAlphabetic = false;
            this.txtCertificateNo.Location = new System.Drawing.Point(75, 99);
            this.txtCertificateNo.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtCertificateNo.Name = "txtCertificateNo";
            this.txtCertificateNo.Size = new System.Drawing.Size(287, 25);
            this.txtCertificateNo.StyleController = this.layData;
            this.txtCertificateNo.TabIndex = 2;
            // 
            // cbxCertificateStyle
            // 
            this.cbxCertificateStyle.CategoryCode = "";
            this.cbxCertificateStyle.Location = new System.Drawing.Point(75, 70);
            this.cbxCertificateStyle.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.cbxCertificateStyle.Name = "cbxCertificateStyle";
            this.cbxCertificateStyle.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.cbxCertificateStyle.Properties.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.DisableTextEditor;
            this.cbxCertificateStyle.SelectedValue = null;
            this.cbxCertificateStyle.Size = new System.Drawing.Size(287, 25);
            this.cbxCertificateStyle.StyleController = this.layData;
            this.cbxCertificateStyle.TabIndex = 5;
            this.cbxCertificateStyle.SelectedIndexChanged += new System.EventHandler(this.cbxCertificateStyle_SelectedIndexChanged);
            // 
            // txtQualificationName
            // 
            this.txtQualificationName.AlphabeticFiled = "QualificationSpell";
            this.txtQualificationName.EntityField = DQS.Module.Entities.BFIQualificationEntityFields2.QualificationName;
            this.txtQualificationName.IsIntegerOnly = false;
            this.txtQualificationName.IsNullString = "档案名称不能为空";
            this.txtQualificationName.IsNullValidate = true;
            this.txtQualificationName.IsTransferAlphabetic = true;
            this.txtQualificationName.Location = new System.Drawing.Point(75, 41);
            this.txtQualificationName.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtQualificationName.Name = "txtQualificationName";
            this.txtQualificationName.Size = new System.Drawing.Size(287, 25);
            this.txtQualificationName.StyleController = this.layData;
            this.txtQualificationName.TabIndex = 2;
            // 
            // txtQualificationCode
            // 
            this.txtQualificationCode.AlphabeticFiled = null;
            this.txtQualificationCode.EntityField = DQS.Module.Entities.BFIQualificationEntityFields2.QualificationCode;
            this.txtQualificationCode.IsIntegerOnly = false;
            this.txtQualificationCode.IsNullString = "档案编号不能为空";
            this.txtQualificationCode.IsNullValidate = true;
            this.txtQualificationCode.IsTransferAlphabetic = false;
            this.txtQualificationCode.Location = new System.Drawing.Point(75, 12);
            this.txtQualificationCode.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtQualificationCode.Name = "txtQualificationCode";
            this.txtQualificationCode.Size = new System.Drawing.Size(287, 25);
            this.txtQualificationCode.StyleController = this.layData;
            this.txtQualificationCode.TabIndex = 4;
            // 
            // chkNoEndDate
            // 
            this.chkNoEndDate.EditValue = null;
            this.chkNoEndDate.Location = new System.Drawing.Point(12, 215);
            this.chkNoEndDate.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.chkNoEndDate.Name = "chkNoEndDate";
            this.chkNoEndDate.Properties.Appearance.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.chkNoEndDate.Properties.Appearance.Options.UseFont = true;
            this.chkNoEndDate.Properties.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.Default;
            this.chkNoEndDate.Properties.Caption = "无限期";
            this.chkNoEndDate.Size = new System.Drawing.Size(350, 25);
            this.chkNoEndDate.StyleController = this.layData;
            this.chkNoEndDate.TabIndex = 3;
            this.chkNoEndDate.CheckedChanged += new System.EventHandler(this.chkNoEndDate_CheckedChanged);
            // 
            // layControlGroup
            // 
            this.layControlGroup.AppearanceItemCaption.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.layControlGroup.AppearanceItemCaption.Options.UseFont = true;
            this.layControlGroup.CustomizationFormText = "证书信息";
            this.layControlGroup.EnableIndentsWithoutBorders = DevExpress.Utils.DefaultBoolean.True;
            this.layControlGroup.GroupBordersVisible = false;
            this.layControlGroup.Items.AddRange(new DevExpress.XtraLayout.BaseLayoutItem[] {
            this.layQualificationCode,
            this.layQualificationName,
            this.layCertificateStyle,
            this.layCertificateNo,
            this.layIssuingAuthority,
            this.layIssuingDate,
            this.layValidateDate,
            this.layQualificationRemark,
            this.layoutControlItem1});
            this.layControlGroup.Location = new System.Drawing.Point(0, 0);
            this.layControlGroup.Name = "layControlGroup";
            this.layControlGroup.Size = new System.Drawing.Size(374, 283);
            this.layControlGroup.Spacing = new DevExpress.XtraLayout.Utils.Padding(0, 0, 0, 0);
            this.layControlGroup.Text = "证书信息";
            this.layControlGroup.TextVisible = false;
            // 
            // layQualificationCode
            // 
            this.layQualificationCode.Control = this.txtQualificationCode;
            this.layQualificationCode.CustomizationFormText = "档案编号";
            this.layQualificationCode.Location = new System.Drawing.Point(0, 0);
            this.layQualificationCode.Name = "layQualificationCode";
            this.layQualificationCode.Size = new System.Drawing.Size(354, 29);
            this.layQualificationCode.Text = "档案编号";
            this.layQualificationCode.TextSize = new System.Drawing.Size(60, 20);
            // 
            // layQualificationName
            // 
            this.layQualificationName.Control = this.txtQualificationName;
            this.layQualificationName.CustomizationFormText = "档案名称";
            this.layQualificationName.Location = new System.Drawing.Point(0, 29);
            this.layQualificationName.Name = "layQualificationName";
            this.layQualificationName.Size = new System.Drawing.Size(354, 29);
            this.layQualificationName.Text = "档案名称";
            this.layQualificationName.TextSize = new System.Drawing.Size(60, 20);
            // 
            // layCertificateStyle
            // 
            this.layCertificateStyle.Control = this.cbxCertificateStyle;
            this.layCertificateStyle.CustomizationFormText = "证书类型";
            this.layCertificateStyle.Location = new System.Drawing.Point(0, 58);
            this.layCertificateStyle.Name = "layCertificateStyle";
            this.layCertificateStyle.Size = new System.Drawing.Size(354, 29);
            this.layCertificateStyle.Text = "证书类型";
            this.layCertificateStyle.TextSize = new System.Drawing.Size(60, 20);
            // 
            // layCertificateNo
            // 
            this.layCertificateNo.Control = this.txtCertificateNo;
            this.layCertificateNo.CustomizationFormText = "证书编号";
            this.layCertificateNo.Location = new System.Drawing.Point(0, 87);
            this.layCertificateNo.Name = "layCertificateNo";
            this.layCertificateNo.Size = new System.Drawing.Size(354, 29);
            this.layCertificateNo.Text = "证书编号";
            this.layCertificateNo.TextSize = new System.Drawing.Size(60, 20);
            // 
            // layIssuingAuthority
            // 
            this.layIssuingAuthority.Control = this.txtIssuingAuthority;
            this.layIssuingAuthority.CustomizationFormText = "发证机关";
            this.layIssuingAuthority.Location = new System.Drawing.Point(0, 116);
            this.layIssuingAuthority.Name = "layIssuingAuthority";
            this.layIssuingAuthority.Size = new System.Drawing.Size(354, 29);
            this.layIssuingAuthority.Text = "发证机关";
            this.layIssuingAuthority.TextSize = new System.Drawing.Size(60, 20);
            // 
            // layIssuingDate
            // 
            this.layIssuingDate.Control = this.dteIssuingDate;
            this.layIssuingDate.CustomizationFormText = "发证日期";
            this.layIssuingDate.Location = new System.Drawing.Point(0, 145);
            this.layIssuingDate.Name = "layIssuingDate";
            this.layIssuingDate.Size = new System.Drawing.Size(354, 29);
            this.layIssuingDate.Text = "发证日期";
            this.layIssuingDate.TextSize = new System.Drawing.Size(60, 20);
            // 
            // layValidateDate
            // 
            this.layValidateDate.Control = this.dteValidateDate;
            this.layValidateDate.CustomizationFormText = "到期日期";
            this.layValidateDate.Location = new System.Drawing.Point(0, 174);
            this.layValidateDate.Name = "layValidateDate";
            this.layValidateDate.Size = new System.Drawing.Size(354, 29);
            this.layValidateDate.Text = "到期日期";
            this.layValidateDate.TextSize = new System.Drawing.Size(60, 20);
            // 
            // layQualificationRemark
            // 
            this.layQualificationRemark.Control = this.txtQualificationRemark;
            this.layQualificationRemark.CustomizationFormText = "备注";
            this.layQualificationRemark.Location = new System.Drawing.Point(0, 232);
            this.layQualificationRemark.Name = "layQualificationRemark";
            this.layQualificationRemark.Size = new System.Drawing.Size(354, 31);
            this.layQualificationRemark.Text = "备注";
            this.layQualificationRemark.TextSize = new System.Drawing.Size(60, 20);
            // 
            // layoutControlItem1
            // 
            this.layoutControlItem1.Control = this.chkNoEndDate;
            this.layoutControlItem1.CustomizationFormText = "无限期";
            this.layoutControlItem1.Location = new System.Drawing.Point(0, 203);
            this.layoutControlItem1.Name = "layoutControlItem1";
            this.layoutControlItem1.Size = new System.Drawing.Size(354, 29);
            this.layoutControlItem1.Text = "无限期";
            this.layoutControlItem1.TextSize = new System.Drawing.Size(0, 0);
            this.layoutControlItem1.TextToControlDistance = 0;
            this.layoutControlItem1.TextVisible = false;
            // 
            // FrmQualificationChange
            // 
            this.AcceptButton = this.btnSave;
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 18F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CancelButton = this.btnCancel;
            this.ClientSize = new System.Drawing.Size(374, 338);
            this.Controls.Add(this.ftPanel);
            this.Controls.Add(this.pnOperating);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FrmQualificationChange";
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "证书信息";
            this.Load += new System.EventHandler(this.FrmQualificationChange_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pnOperating)).EndInit();
            this.pnOperating.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.ftPanel)).EndInit();
            this.ftPanel.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.layData)).EndInit();
            this.layData.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.txtQualificationRemark.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dteValidateDate.Properties.VistaTimeProperties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dteValidateDate.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dteIssuingDate.Properties.VistaTimeProperties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dteIssuingDate.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtIssuingAuthority.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtCertificateNo.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cbxCertificateStyle.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtQualificationName.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtQualificationCode.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.chkNoEndDate.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layControlGroup)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layQualificationCode)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layQualificationName)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layCertificateStyle)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layCertificateNo)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layIssuingAuthority)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layIssuingDate)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layValidateDate)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layQualificationRemark)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraEditors.PanelControl pnOperating;
        private DevExpress.XtraEditors.SimpleButton btnCancel;
        private DevExpress.XtraEditors.SimpleButton btnSave;
        private DQS.Controls.FieldTextBoxPanel ftPanel;
        private DevExpress.XtraLayout.LayoutControl layData;
        private DevExpress.XtraLayout.LayoutControlGroup layControlGroup;
        private DQS.Controls.BFIQualificationEntityTextBox txtQualificationRemark;
        private DQS.Controls.BFIQualificationEntityTextBox txtQualificationCode;
        private DevExpress.XtraLayout.LayoutControlItem layQualificationCode;
        private DQS.Controls.BFIQualificationEntityTextBox txtCertificateNo;
        private DevExpress.XtraLayout.LayoutControlItem layQualificationName;
        private DevExpress.XtraEditors.DateEdit dteValidateDate;
        private DevExpress.XtraEditors.DateEdit dteIssuingDate;
        private DQS.Controls.BFIQualificationEntityTextBox txtIssuingAuthority;
        private DevExpress.XtraLayout.LayoutControlItem layCertificateStyle;
        private DevExpress.XtraLayout.LayoutControlItem layCertificateNo;
        private DevExpress.XtraLayout.LayoutControlItem layIssuingAuthority;
        private DevExpress.XtraLayout.LayoutControlItem layIssuingDate;
        private DevExpress.XtraLayout.LayoutControlItem layValidateDate;
        private DevExpress.XtraLayout.LayoutControlItem layQualificationRemark;
        public DQS.Controls.ComboBoxCategoryEx cbxCertificateStyle;
        public DQS.Controls.BFIQualificationEntityTextBox txtQualificationName;
        private DevExpress.XtraEditors.CheckEdit chkNoEndDate;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlItem1;

    }
}