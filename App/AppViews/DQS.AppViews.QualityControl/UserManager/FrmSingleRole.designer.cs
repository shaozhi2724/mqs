namespace DQS.AppViews.QualityControl.UserManager
{
    partial class FrmSingleRole
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
            this.rgpStatus = new DevExpress.XtraEditors.RadioGroup();
            this.txtRoleRemark = new DQS.Controls.ATCRoleEntityTextBox();
            this.txtRoleCode = new DQS.Controls.ATCRoleEntityTextBox();
            this.txtRoleName = new DQS.Controls.ATCRoleEntityTextBox();
            this.layControlGroup = new DevExpress.XtraLayout.LayoutControlGroup();
            this.layRoleCode = new DevExpress.XtraLayout.LayoutControlItem();
            this.layRoleName = new DevExpress.XtraLayout.LayoutControlItem();
            this.layRoleRemark = new DevExpress.XtraLayout.LayoutControlItem();
            this.layStatus = new DevExpress.XtraLayout.LayoutControlItem();
            ((System.ComponentModel.ISupportInitialize)(this.pnOperating)).BeginInit();
            this.pnOperating.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ftPanel)).BeginInit();
            this.ftPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.layData)).BeginInit();
            this.layData.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.rgpStatus.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtRoleRemark.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtRoleCode.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtRoleName.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layControlGroup)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layRoleCode)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layRoleName)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layRoleRemark)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layStatus)).BeginInit();
            this.SuspendLayout();
            // 
            // pnOperating
            // 
            this.pnOperating.Controls.Add(this.btnCancel);
            this.pnOperating.Controls.Add(this.btnSave);
            this.pnOperating.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.pnOperating.Location = new System.Drawing.Point(0, 165);
            this.pnOperating.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.pnOperating.Name = "pnOperating";
            this.pnOperating.Size = new System.Drawing.Size(423, 55);
            this.pnOperating.TabIndex = 1;
            // 
            // btnCancel
            // 
            this.btnCancel.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.btnCancel.Appearance.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCancel.Appearance.Options.UseFont = true;
            this.btnCancel.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btnCancel.Location = new System.Drawing.Point(323, 12);
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
            this.btnSave.Location = new System.Drawing.Point(223, 12);
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
            this.ftPanel.Size = new System.Drawing.Size(423, 165);
            this.ftPanel.TabIndex = 0;
            this.ftPanel.TypeOfEntity = DQS.Module.EntityType2.ATCRoleEntity;
            // 
            // layData
            // 
            this.layData.Controls.Add(this.rgpStatus);
            this.layData.Controls.Add(this.txtRoleRemark);
            this.layData.Controls.Add(this.txtRoleCode);
            this.layData.Controls.Add(this.txtRoleName);
            this.layData.Dock = System.Windows.Forms.DockStyle.Fill;
            this.layData.Location = new System.Drawing.Point(0, 0);
            this.layData.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.layData.Name = "layData";
            this.layData.Root = this.layControlGroup;
            this.layData.Size = new System.Drawing.Size(423, 165);
            this.layData.TabIndex = 0;
            this.layData.Text = "layControl";
            // 
            // rgpStatus
            // 
            this.rgpStatus.Location = new System.Drawing.Point(75, 70);
            this.rgpStatus.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.rgpStatus.Name = "rgpStatus";
            this.rgpStatus.Properties.Appearance.BackColor = System.Drawing.Color.White;
            this.rgpStatus.Properties.Appearance.Options.UseBackColor = true;
            this.rgpStatus.Size = new System.Drawing.Size(336, 54);
            this.rgpStatus.StyleController = this.layData;
            this.rgpStatus.TabIndex = 2;
            // 
            // txtRoleRemark
            // 
            this.txtRoleRemark.AlphabeticFiled = null;
            this.txtRoleRemark.EntityField = DQS.Module.Entities.ATCRoleEntityFields2.RoleRemark;
            this.txtRoleRemark.IsIntegerOnly = false;
            this.txtRoleRemark.IsNullString = null;
            this.txtRoleRemark.IsNullValidate = false;
            this.txtRoleRemark.IsTransferAlphabetic = false;
            this.txtRoleRemark.Location = new System.Drawing.Point(75, 128);
            this.txtRoleRemark.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtRoleRemark.Name = "txtRoleRemark";
            this.txtRoleRemark.Size = new System.Drawing.Size(336, 25);
            this.txtRoleRemark.StyleController = this.layData;
            this.txtRoleRemark.TabIndex = 4;
            // 
            // txtRoleCode
            // 
            this.txtRoleCode.AlphabeticFiled = null;
            this.txtRoleCode.EntityField = DQS.Module.Entities.ATCRoleEntityFields2.RoleCode;
            this.txtRoleCode.IsIntegerOnly = false;
            this.txtRoleCode.IsNullString = "角色编号不能为空。";
            this.txtRoleCode.IsNullValidate = true;
            this.txtRoleCode.IsTransferAlphabetic = false;
            this.txtRoleCode.Location = new System.Drawing.Point(75, 12);
            this.txtRoleCode.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtRoleCode.Name = "txtRoleCode";
            this.txtRoleCode.Size = new System.Drawing.Size(336, 25);
            this.txtRoleCode.StyleController = this.layData;
            this.txtRoleCode.TabIndex = 0;
            // 
            // txtRoleName
            // 
            this.txtRoleName.AlphabeticFiled = "RoleSpell";
            this.txtRoleName.EntityField = DQS.Module.Entities.ATCRoleEntityFields2.RoleName;
            this.txtRoleName.IsIntegerOnly = false;
            this.txtRoleName.IsNullString = "角色名称不能为空";
            this.txtRoleName.IsNullValidate = true;
            this.txtRoleName.IsTransferAlphabetic = true;
            this.txtRoleName.Location = new System.Drawing.Point(75, 41);
            this.txtRoleName.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtRoleName.Name = "txtRoleName";
            this.txtRoleName.Size = new System.Drawing.Size(336, 25);
            this.txtRoleName.StyleController = this.layData;
            this.txtRoleName.TabIndex = 1;
            // 
            // layControlGroup
            // 
            this.layControlGroup.AppearanceItemCaption.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.layControlGroup.AppearanceItemCaption.Options.UseFont = true;
            this.layControlGroup.CustomizationFormText = "角色信息";
            this.layControlGroup.EnableIndentsWithoutBorders = DevExpress.Utils.DefaultBoolean.True;
            this.layControlGroup.GroupBordersVisible = false;
            this.layControlGroup.Items.AddRange(new DevExpress.XtraLayout.BaseLayoutItem[] {
            this.layRoleCode,
            this.layRoleName,
            this.layRoleRemark,
            this.layStatus});
            this.layControlGroup.Location = new System.Drawing.Point(0, 0);
            this.layControlGroup.Name = "layControlGroup";
            this.layControlGroup.Size = new System.Drawing.Size(423, 165);
            this.layControlGroup.Spacing = new DevExpress.XtraLayout.Utils.Padding(0, 0, 0, 0);
            this.layControlGroup.Text = "角色信息";
            this.layControlGroup.TextVisible = false;
            // 
            // layRoleCode
            // 
            this.layRoleCode.Control = this.txtRoleCode;
            this.layRoleCode.CustomizationFormText = "角色编码";
            this.layRoleCode.Location = new System.Drawing.Point(0, 0);
            this.layRoleCode.Name = "layRoleCode";
            this.layRoleCode.Size = new System.Drawing.Size(403, 29);
            this.layRoleCode.Text = "角色编码";
            this.layRoleCode.TextSize = new System.Drawing.Size(60, 20);
            // 
            // layRoleName
            // 
            this.layRoleName.Control = this.txtRoleName;
            this.layRoleName.CustomizationFormText = "角色名称";
            this.layRoleName.Location = new System.Drawing.Point(0, 29);
            this.layRoleName.Name = "layRoleName";
            this.layRoleName.Size = new System.Drawing.Size(403, 29);
            this.layRoleName.Text = "角色名称";
            this.layRoleName.TextSize = new System.Drawing.Size(60, 20);
            // 
            // layRoleRemark
            // 
            this.layRoleRemark.Control = this.txtRoleRemark;
            this.layRoleRemark.CustomizationFormText = "角色备注";
            this.layRoleRemark.Location = new System.Drawing.Point(0, 116);
            this.layRoleRemark.Name = "layRoleRemark";
            this.layRoleRemark.Size = new System.Drawing.Size(403, 29);
            this.layRoleRemark.Text = "角色备注";
            this.layRoleRemark.TextSize = new System.Drawing.Size(60, 20);
            // 
            // layStatus
            // 
            this.layStatus.Control = this.rgpStatus;
            this.layStatus.CustomizationFormText = "角色状态";
            this.layStatus.Location = new System.Drawing.Point(0, 58);
            this.layStatus.Name = "layStatus";
            this.layStatus.Size = new System.Drawing.Size(403, 58);
            this.layStatus.Text = "角色状态";
            this.layStatus.TextSize = new System.Drawing.Size(60, 20);
            // 
            // FrmSingleRole
            // 
            this.AcceptButton = this.btnSave;
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 18F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CancelButton = this.btnCancel;
            this.ClientSize = new System.Drawing.Size(423, 220);
            this.Controls.Add(this.ftPanel);
            this.Controls.Add(this.pnOperating);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FrmSingleRole";
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "角色信息";
            this.Load += new System.EventHandler(this.FrmSingleRole_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pnOperating)).EndInit();
            this.pnOperating.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.ftPanel)).EndInit();
            this.ftPanel.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.layData)).EndInit();
            this.layData.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.rgpStatus.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtRoleRemark.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtRoleCode.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtRoleName.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layControlGroup)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layRoleCode)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layRoleName)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layRoleRemark)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layStatus)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraEditors.PanelControl pnOperating;
        private DevExpress.XtraEditors.SimpleButton btnCancel;
        private DevExpress.XtraEditors.SimpleButton btnSave;
        private DQS.Controls.FieldTextBoxPanel ftPanel;
        private DevExpress.XtraLayout.LayoutControl layData;
        private DQS.Controls.ATCRoleEntityTextBox txtRoleRemark;
        private DQS.Controls.ATCRoleEntityTextBox txtRoleName;
        private DQS.Controls.ATCRoleEntityTextBox txtRoleCode;
        private DevExpress.XtraLayout.LayoutControlGroup layControlGroup;
        private DevExpress.XtraLayout.LayoutControlItem layRoleCode;
        private DevExpress.XtraLayout.LayoutControlItem layRoleName;
        private DevExpress.XtraLayout.LayoutControlItem layRoleRemark;
        private DevExpress.XtraEditors.RadioGroup rgpStatus;
        private DevExpress.XtraLayout.LayoutControlItem layStatus;

    }
}