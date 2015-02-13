namespace DQS.AppViews.QualityDocument.EnterpriseManager
{
    partial class FrmSingleDepartment
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
            this.layControl = new DevExpress.XtraLayout.LayoutControl();
            this.txtDepartmentCode = new DQS.Controls.BFIDepartmentEntityTextBox();
            this.txtDepartmentName = new DQS.Controls.BFIDepartmentEntityTextBox();
            this.txtDepartmentDuty = new DQS.Controls.BFIDepartmentEntityTextBox();
            this.txtDepartmentRemark = new DQS.Controls.BFIDepartmentEntityTextBox();
            this.txtLeaderPhone = new DQS.Controls.BFIDepartmentEntityTextBox();
            this.txtDepartmentLeader = new DQS.Controls.BFIDepartmentEntityTextBox();
            this.layControlGroup = new DevExpress.XtraLayout.LayoutControlGroup();
            this.layDepartmentCode = new DevExpress.XtraLayout.LayoutControlItem();
            this.layDepartmentLeader = new DevExpress.XtraLayout.LayoutControlItem();
            this.layLeaderPhone = new DevExpress.XtraLayout.LayoutControlItem();
            this.layDepartmentRemark = new DevExpress.XtraLayout.LayoutControlItem();
            this.layDepartmentDuty = new DevExpress.XtraLayout.LayoutControlItem();
            this.layDepartmentName = new DevExpress.XtraLayout.LayoutControlItem();
            ((System.ComponentModel.ISupportInitialize)(this.pnOperating)).BeginInit();
            this.pnOperating.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ftPanel)).BeginInit();
            this.ftPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.layControl)).BeginInit();
            this.layControl.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.txtDepartmentCode.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtDepartmentName.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtDepartmentDuty.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtDepartmentRemark.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtLeaderPhone.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtDepartmentLeader.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layControlGroup)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layDepartmentCode)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layDepartmentLeader)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layLeaderPhone)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layDepartmentRemark)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layDepartmentDuty)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layDepartmentName)).BeginInit();
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
            this.pnOperating.Size = new System.Drawing.Size(610, 55);
            this.pnOperating.TabIndex = 1;
            // 
            // btnCancel
            // 
            this.btnCancel.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.btnCancel.Appearance.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCancel.Appearance.Options.UseFont = true;
            this.btnCancel.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btnCancel.Location = new System.Drawing.Point(511, 12);
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
            this.btnSave.Location = new System.Drawing.Point(410, 12);
            this.btnSave.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(86, 30);
            this.btnSave.TabIndex = 0;
            this.btnSave.Text = "保存(&S)";
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // ftPanel
            // 
            this.ftPanel.Controls.Add(this.layControl);
            this.ftPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.ftPanel.Location = new System.Drawing.Point(0, 0);
            this.ftPanel.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.ftPanel.Name = "ftPanel";
            this.ftPanel.Size = new System.Drawing.Size(610, 165);
            this.ftPanel.TabIndex = 0;
            this.ftPanel.TypeOfEntity = DQS.Module.EntityType2.BFIDepartmentEntity;
            // 
            // layControl
            // 
            this.layControl.Controls.Add(this.txtDepartmentCode);
            this.layControl.Controls.Add(this.txtDepartmentName);
            this.layControl.Controls.Add(this.txtDepartmentDuty);
            this.layControl.Controls.Add(this.txtDepartmentRemark);
            this.layControl.Controls.Add(this.txtLeaderPhone);
            this.layControl.Controls.Add(this.txtDepartmentLeader);
            this.layControl.Dock = System.Windows.Forms.DockStyle.Fill;
            this.layControl.Location = new System.Drawing.Point(2, 2);
            this.layControl.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.layControl.Name = "layControl";
            this.layControl.Root = this.layControlGroup;
            this.layControl.Size = new System.Drawing.Size(606, 161);
            this.layControl.TabIndex = 0;
            this.layControl.Text = "layControl";
            // 
            // txtDepartmentCode
            // 
            this.txtDepartmentCode.AlphabeticFiled = null;
            this.txtDepartmentCode.EntityField = DQS.Module.Entities.BFIDepartmentEntityFields2.DepartmentCode;
            this.txtDepartmentCode.IsIntegerOnly = false;
            this.txtDepartmentCode.IsNullString = "部门编号不能为空。";
            this.txtDepartmentCode.IsNullValidate = true;
            this.txtDepartmentCode.IsTransferAlphabetic = false;
            this.txtDepartmentCode.Location = new System.Drawing.Point(90, 12);
            this.txtDepartmentCode.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtDepartmentCode.Name = "txtDepartmentCode";
            this.txtDepartmentCode.Size = new System.Drawing.Size(211, 25);
            this.txtDepartmentCode.StyleController = this.layControl;
            this.txtDepartmentCode.TabIndex = 0;
            // 
            // txtDepartmentName
            // 
            this.txtDepartmentName.AlphabeticFiled = "DepartmentSpell";
            this.txtDepartmentName.EntityField = DQS.Module.Entities.BFIDepartmentEntityFields2.DepartmentName;
            this.txtDepartmentName.IsIntegerOnly = false;
            this.txtDepartmentName.IsNullString = "部门名称不能为空。";
            this.txtDepartmentName.IsNullValidate = true;
            this.txtDepartmentName.IsTransferAlphabetic = true;
            this.txtDepartmentName.Location = new System.Drawing.Point(383, 12);
            this.txtDepartmentName.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtDepartmentName.Name = "txtDepartmentName";
            this.txtDepartmentName.Size = new System.Drawing.Size(211, 25);
            this.txtDepartmentName.StyleController = this.layControl;
            this.txtDepartmentName.TabIndex = 1;
            // 
            // txtDepartmentDuty
            // 
            this.txtDepartmentDuty.AlphabeticFiled = null;
            this.txtDepartmentDuty.EntityField = DQS.Module.Entities.BFIDepartmentEntityFields2.DepartmentDuty;
            this.txtDepartmentDuty.IsIntegerOnly = false;
            this.txtDepartmentDuty.IsNullString = null;
            this.txtDepartmentDuty.IsNullValidate = false;
            this.txtDepartmentDuty.IsTransferAlphabetic = false;
            this.txtDepartmentDuty.Location = new System.Drawing.Point(90, 70);
            this.txtDepartmentDuty.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtDepartmentDuty.Name = "txtDepartmentDuty";
            this.txtDepartmentDuty.Size = new System.Drawing.Size(504, 25);
            this.txtDepartmentDuty.StyleController = this.layControl;
            this.txtDepartmentDuty.TabIndex = 4;
            // 
            // txtDepartmentRemark
            // 
            this.txtDepartmentRemark.AlphabeticFiled = null;
            this.txtDepartmentRemark.EntityField = DQS.Module.Entities.BFIDepartmentEntityFields2.DepartmentRemark;
            this.txtDepartmentRemark.IsIntegerOnly = false;
            this.txtDepartmentRemark.IsNullString = null;
            this.txtDepartmentRemark.IsNullValidate = false;
            this.txtDepartmentRemark.IsTransferAlphabetic = false;
            this.txtDepartmentRemark.Location = new System.Drawing.Point(90, 99);
            this.txtDepartmentRemark.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtDepartmentRemark.Name = "txtDepartmentRemark";
            this.txtDepartmentRemark.Size = new System.Drawing.Size(504, 25);
            this.txtDepartmentRemark.StyleController = this.layControl;
            this.txtDepartmentRemark.TabIndex = 5;
            // 
            // txtLeaderPhone
            // 
            this.txtLeaderPhone.AlphabeticFiled = null;
            this.txtLeaderPhone.EntityField = DQS.Module.Entities.BFIDepartmentEntityFields2.LeaderPhone;
            this.txtLeaderPhone.IsIntegerOnly = false;
            this.txtLeaderPhone.IsNullString = null;
            this.txtLeaderPhone.IsNullValidate = false;
            this.txtLeaderPhone.IsTransferAlphabetic = false;
            this.txtLeaderPhone.Location = new System.Drawing.Point(383, 41);
            this.txtLeaderPhone.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtLeaderPhone.Name = "txtLeaderPhone";
            this.txtLeaderPhone.Size = new System.Drawing.Size(211, 25);
            this.txtLeaderPhone.StyleController = this.layControl;
            this.txtLeaderPhone.TabIndex = 3;
            // 
            // txtDepartmentLeader
            // 
            this.txtDepartmentLeader.AlphabeticFiled = "LeaderSpell";
            this.txtDepartmentLeader.EntityField = DQS.Module.Entities.BFIDepartmentEntityFields2.DepartmentLeader;
            this.txtDepartmentLeader.IsIntegerOnly = false;
            this.txtDepartmentLeader.IsNullString = null;
            this.txtDepartmentLeader.IsNullValidate = false;
            this.txtDepartmentLeader.IsTransferAlphabetic = true;
            this.txtDepartmentLeader.Location = new System.Drawing.Point(90, 41);
            this.txtDepartmentLeader.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtDepartmentLeader.Name = "txtDepartmentLeader";
            this.txtDepartmentLeader.Size = new System.Drawing.Size(211, 25);
            this.txtDepartmentLeader.StyleController = this.layControl;
            this.txtDepartmentLeader.TabIndex = 2;
            // 
            // layControlGroup
            // 
            this.layControlGroup.AppearanceItemCaption.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.layControlGroup.AppearanceItemCaption.Options.UseFont = true;
            this.layControlGroup.CustomizationFormText = "部门信息";
            this.layControlGroup.EnableIndentsWithoutBorders = DevExpress.Utils.DefaultBoolean.True;
            this.layControlGroup.GroupBordersVisible = false;
            this.layControlGroup.Items.AddRange(new DevExpress.XtraLayout.BaseLayoutItem[] {
            this.layDepartmentCode,
            this.layDepartmentLeader,
            this.layLeaderPhone,
            this.layDepartmentRemark,
            this.layDepartmentDuty,
            this.layDepartmentName});
            this.layControlGroup.Location = new System.Drawing.Point(0, 0);
            this.layControlGroup.Name = "layControlGroup";
            this.layControlGroup.Size = new System.Drawing.Size(606, 161);
            this.layControlGroup.Spacing = new DevExpress.XtraLayout.Utils.Padding(0, 0, 0, 0);
            this.layControlGroup.Text = "部门信息";
            this.layControlGroup.TextVisible = false;
            // 
            // layDepartmentCode
            // 
            this.layDepartmentCode.Control = this.txtDepartmentCode;
            this.layDepartmentCode.CustomizationFormText = "部门编码";
            this.layDepartmentCode.Location = new System.Drawing.Point(0, 0);
            this.layDepartmentCode.Name = "layDepartmentCode";
            this.layDepartmentCode.Size = new System.Drawing.Size(293, 29);
            this.layDepartmentCode.Text = "部门编码";
            this.layDepartmentCode.TextSize = new System.Drawing.Size(75, 20);
            // 
            // layDepartmentLeader
            // 
            this.layDepartmentLeader.Control = this.txtDepartmentLeader;
            this.layDepartmentLeader.CustomizationFormText = "部门负责人";
            this.layDepartmentLeader.Location = new System.Drawing.Point(0, 29);
            this.layDepartmentLeader.Name = "layDepartmentLeader";
            this.layDepartmentLeader.Size = new System.Drawing.Size(293, 29);
            this.layDepartmentLeader.Text = "部门负责人";
            this.layDepartmentLeader.TextSize = new System.Drawing.Size(75, 20);
            // 
            // layLeaderPhone
            // 
            this.layLeaderPhone.Control = this.txtLeaderPhone;
            this.layLeaderPhone.CustomizationFormText = "负责人电话";
            this.layLeaderPhone.Location = new System.Drawing.Point(293, 29);
            this.layLeaderPhone.Name = "layLeaderPhone";
            this.layLeaderPhone.Size = new System.Drawing.Size(293, 29);
            this.layLeaderPhone.Text = "负责人电话";
            this.layLeaderPhone.TextSize = new System.Drawing.Size(75, 20);
            // 
            // layDepartmentRemark
            // 
            this.layDepartmentRemark.Control = this.txtDepartmentRemark;
            this.layDepartmentRemark.CustomizationFormText = "备注";
            this.layDepartmentRemark.Location = new System.Drawing.Point(0, 87);
            this.layDepartmentRemark.Name = "layDepartmentRemark";
            this.layDepartmentRemark.Size = new System.Drawing.Size(586, 54);
            this.layDepartmentRemark.Text = "备注";
            this.layDepartmentRemark.TextSize = new System.Drawing.Size(75, 20);
            // 
            // layDepartmentDuty
            // 
            this.layDepartmentDuty.Control = this.txtDepartmentDuty;
            this.layDepartmentDuty.CustomizationFormText = "部门职责";
            this.layDepartmentDuty.Location = new System.Drawing.Point(0, 58);
            this.layDepartmentDuty.Name = "layDepartmentDuty";
            this.layDepartmentDuty.Size = new System.Drawing.Size(586, 29);
            this.layDepartmentDuty.Text = "部门职责";
            this.layDepartmentDuty.TextSize = new System.Drawing.Size(75, 20);
            // 
            // layDepartmentName
            // 
            this.layDepartmentName.Control = this.txtDepartmentName;
            this.layDepartmentName.CustomizationFormText = "部门名称";
            this.layDepartmentName.Location = new System.Drawing.Point(293, 0);
            this.layDepartmentName.Name = "layDepartmentName";
            this.layDepartmentName.Size = new System.Drawing.Size(293, 29);
            this.layDepartmentName.Text = "部门名称";
            this.layDepartmentName.TextSize = new System.Drawing.Size(75, 20);
            // 
            // FrmSingleDepartment
            // 
            this.AcceptButton = this.btnSave;
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 18F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CancelButton = this.btnCancel;
            this.ClientSize = new System.Drawing.Size(610, 220);
            this.Controls.Add(this.ftPanel);
            this.Controls.Add(this.pnOperating);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FrmSingleDepartment";
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "部门信息";
            this.Load += new System.EventHandler(this.FrmSingleDepartment_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pnOperating)).EndInit();
            this.pnOperating.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.ftPanel)).EndInit();
            this.ftPanel.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.layControl)).EndInit();
            this.layControl.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.txtDepartmentCode.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtDepartmentName.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtDepartmentDuty.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtDepartmentRemark.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtLeaderPhone.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtDepartmentLeader.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layControlGroup)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layDepartmentCode)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layDepartmentLeader)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layLeaderPhone)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layDepartmentRemark)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layDepartmentDuty)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layDepartmentName)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraEditors.PanelControl pnOperating;
        private DevExpress.XtraEditors.SimpleButton btnCancel;
        private DevExpress.XtraEditors.SimpleButton btnSave;
        private DQS.Controls.FieldTextBoxPanel ftPanel;
        private DevExpress.XtraLayout.LayoutControl layControl;
        private DQS.Controls.BFIDepartmentEntityTextBox txtDepartmentRemark;
        private DQS.Controls.BFIDepartmentEntityTextBox txtLeaderPhone;
        private DQS.Controls.BFIDepartmentEntityTextBox txtDepartmentLeader;
        private DQS.Controls.BFIDepartmentEntityTextBox txtDepartmentCode;
        private DevExpress.XtraLayout.LayoutControlGroup layControlGroup;
        private DevExpress.XtraLayout.LayoutControlItem layDepartmentCode;
        private DevExpress.XtraLayout.LayoutControlItem layDepartmentLeader;
        private DevExpress.XtraLayout.LayoutControlItem layLeaderPhone;
        private DevExpress.XtraLayout.LayoutControlItem layDepartmentRemark;
        private DQS.Controls.BFIDepartmentEntityTextBox txtDepartmentName;
        private DQS.Controls.BFIDepartmentEntityTextBox txtDepartmentDuty;
        private DevExpress.XtraLayout.LayoutControlItem layDepartmentDuty;
        private DevExpress.XtraLayout.LayoutControlItem layDepartmentName;
    }
}