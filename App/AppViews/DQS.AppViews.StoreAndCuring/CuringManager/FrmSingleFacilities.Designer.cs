namespace DQS.AppViews.StoreAndCuring.CuringManager
{
    partial class FrmSingleFacilities
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
            this.panelControl1 = new DevExpress.XtraEditors.PanelControl();
            this.btnCancel = new DevExpress.XtraEditors.SimpleButton();
            this.btnSave = new DevExpress.XtraEditors.SimpleButton();
            this.groupControl = new DevExpress.XtraEditors.GroupControl();
            this.layoutControl1 = new DevExpress.XtraLayout.LayoutControl();
            this.txtCreateUser = new DevExpress.XtraEditors.TextEdit();
            this.cboStyle = new DevExpress.XtraEditors.ComboBoxEdit();
            this.txtName = new DevExpress.XtraEditors.TextEdit();
            this.txtAddress = new DevExpress.XtraEditors.TextEdit();
            this.txtCode = new DevExpress.XtraEditors.TextEdit();
            this.txtSpec = new DevExpress.XtraEditors.TextEdit();
            this.layoutControlGroup1 = new DevExpress.XtraLayout.LayoutControlGroup();
            this.layCode = new DevExpress.XtraLayout.LayoutControlItem();
            this.layName = new DevExpress.XtraLayout.LayoutControlItem();
            this.laySpec = new DevExpress.XtraLayout.LayoutControlItem();
            this.layAddress = new DevExpress.XtraLayout.LayoutControlItem();
            this.layStyle = new DevExpress.XtraLayout.LayoutControlItem();
            this.layCreateUser = new DevExpress.XtraLayout.LayoutControlItem();
            ((System.ComponentModel.ISupportInitialize)(this.panelControl1)).BeginInit();
            this.panelControl1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.groupControl)).BeginInit();
            this.groupControl.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControl1)).BeginInit();
            this.layoutControl1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.txtCreateUser.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cboStyle.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtName.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtAddress.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtCode.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtSpec.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlGroup1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layCode)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layName)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.laySpec)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layAddress)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layStyle)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layCreateUser)).BeginInit();
            this.SuspendLayout();
            // 
            // panelControl1
            // 
            this.panelControl1.Controls.Add(this.btnCancel);
            this.panelControl1.Controls.Add(this.btnSave);
            this.panelControl1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panelControl1.Location = new System.Drawing.Point(0, 132);
            this.panelControl1.Name = "panelControl1";
            this.panelControl1.Size = new System.Drawing.Size(568, 43);
            this.panelControl1.TabIndex = 0;
            // 
            // btnCancel
            // 
            this.btnCancel.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.btnCancel.Appearance.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCancel.Appearance.Options.UseFont = true;
            this.btnCancel.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btnCancel.Location = new System.Drawing.Point(479, 11);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(75, 23);
            this.btnCancel.TabIndex = 3;
            this.btnCancel.Text = "取消(&C)";
            // 
            // btnSave
            // 
            this.btnSave.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.btnSave.Appearance.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSave.Appearance.Options.UseFont = true;
            this.btnSave.Location = new System.Drawing.Point(391, 11);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(75, 23);
            this.btnSave.TabIndex = 2;
            this.btnSave.Text = "保存(&S)";
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // groupControl
            // 
            this.groupControl.Controls.Add(this.layoutControl1);
            this.groupControl.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupControl.Location = new System.Drawing.Point(0, 0);
            this.groupControl.Name = "groupControl";
            this.groupControl.Size = new System.Drawing.Size(568, 132);
            this.groupControl.TabIndex = 1;
            this.groupControl.Text = "明细";
            // 
            // layoutControl1
            // 
            this.layoutControl1.Controls.Add(this.txtCreateUser);
            this.layoutControl1.Controls.Add(this.cboStyle);
            this.layoutControl1.Controls.Add(this.txtName);
            this.layoutControl1.Controls.Add(this.txtAddress);
            this.layoutControl1.Controls.Add(this.txtCode);
            this.layoutControl1.Controls.Add(this.txtSpec);
            this.layoutControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.layoutControl1.Location = new System.Drawing.Point(2, 23);
            this.layoutControl1.Name = "layoutControl1";
            this.layoutControl1.Root = this.layoutControlGroup1;
            this.layoutControl1.Size = new System.Drawing.Size(564, 107);
            this.layoutControl1.TabIndex = 0;
            this.layoutControl1.Text = "layoutControl1";
            // 
            // txtCreateUser
            // 
            this.txtCreateUser.Location = new System.Drawing.Point(323, 62);
            this.txtCreateUser.Name = "txtCreateUser";
            this.txtCreateUser.Properties.ReadOnly = true;
            this.txtCreateUser.Size = new System.Drawing.Size(229, 21);
            this.txtCreateUser.StyleController = this.layoutControl1;
            this.txtCreateUser.TabIndex = 0;
            // 
            // cboStyle
            // 
            this.cboStyle.Location = new System.Drawing.Point(51, 62);
            this.cboStyle.Name = "cboStyle";
            this.cboStyle.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.cboStyle.Size = new System.Drawing.Size(229, 21);
            this.cboStyle.StyleController = this.layoutControl1;
            this.cboStyle.TabIndex = 0;
            // 
            // txtName
            // 
            this.txtName.Location = new System.Drawing.Point(323, 12);
            this.txtName.Name = "txtName";
            this.txtName.Size = new System.Drawing.Size(229, 21);
            this.txtName.StyleController = this.layoutControl1;
            this.txtName.TabIndex = 0;
            // 
            // txtAddress
            // 
            this.txtAddress.Location = new System.Drawing.Point(323, 37);
            this.txtAddress.Name = "txtAddress";
            this.txtAddress.Size = new System.Drawing.Size(229, 21);
            this.txtAddress.StyleController = this.layoutControl1;
            this.txtAddress.TabIndex = 0;
            // 
            // txtCode
            // 
            this.txtCode.Location = new System.Drawing.Point(51, 12);
            this.txtCode.Name = "txtCode";
            this.txtCode.Size = new System.Drawing.Size(229, 21);
            this.txtCode.StyleController = this.layoutControl1;
            this.txtCode.TabIndex = 0;
            // 
            // txtSpec
            // 
            this.txtSpec.Location = new System.Drawing.Point(51, 37);
            this.txtSpec.Name = "txtSpec";
            this.txtSpec.Size = new System.Drawing.Size(229, 21);
            this.txtSpec.StyleController = this.layoutControl1;
            this.txtSpec.TabIndex = 0;
            // 
            // layoutControlGroup1
            // 
            this.layoutControlGroup1.CustomizationFormText = "layoutControlGroup1";
            this.layoutControlGroup1.EnableIndentsWithoutBorders = DevExpress.Utils.DefaultBoolean.True;
            this.layoutControlGroup1.GroupBordersVisible = false;
            this.layoutControlGroup1.Items.AddRange(new DevExpress.XtraLayout.BaseLayoutItem[] {
            this.layCode,
            this.layName,
            this.laySpec,
            this.layAddress,
            this.layStyle,
            this.layCreateUser});
            this.layoutControlGroup1.Location = new System.Drawing.Point(0, 0);
            this.layoutControlGroup1.Name = "layoutControlGroup1";
            this.layoutControlGroup1.Size = new System.Drawing.Size(564, 107);
            this.layoutControlGroup1.Spacing = new DevExpress.XtraLayout.Utils.Padding(0, 0, 0, 0);
            this.layoutControlGroup1.Text = "layoutControlGroup1";
            this.layoutControlGroup1.TextVisible = false;
            // 
            // layCode
            // 
            this.layCode.Control = this.txtCode;
            this.layCode.CustomizationFormText = "编号";
            this.layCode.Location = new System.Drawing.Point(0, 0);
            this.layCode.Name = "layCode";
            this.layCode.Size = new System.Drawing.Size(272, 25);
            this.layCode.Text = "编号";
            this.layCode.TextSize = new System.Drawing.Size(36, 14);
            // 
            // layName
            // 
            this.layName.Control = this.txtName;
            this.layName.CustomizationFormText = "名称";
            this.layName.Location = new System.Drawing.Point(272, 0);
            this.layName.Name = "layName";
            this.layName.Size = new System.Drawing.Size(272, 25);
            this.layName.Text = "名称";
            this.layName.TextSize = new System.Drawing.Size(36, 14);
            // 
            // laySpec
            // 
            this.laySpec.Control = this.txtSpec;
            this.laySpec.CustomizationFormText = "规格";
            this.laySpec.Location = new System.Drawing.Point(0, 25);
            this.laySpec.Name = "laySpec";
            this.laySpec.Size = new System.Drawing.Size(272, 25);
            this.laySpec.Text = "规格";
            this.laySpec.TextSize = new System.Drawing.Size(36, 14);
            // 
            // layAddress
            // 
            this.layAddress.Control = this.txtAddress;
            this.layAddress.CustomizationFormText = "地址";
            this.layAddress.Location = new System.Drawing.Point(272, 25);
            this.layAddress.Name = "layAddress";
            this.layAddress.Size = new System.Drawing.Size(272, 25);
            this.layAddress.Text = "地址";
            this.layAddress.TextSize = new System.Drawing.Size(36, 14);
            // 
            // layStyle
            // 
            this.layStyle.Control = this.cboStyle;
            this.layStyle.CustomizationFormText = "类型";
            this.layStyle.Location = new System.Drawing.Point(0, 50);
            this.layStyle.Name = "layStyle";
            this.layStyle.Size = new System.Drawing.Size(272, 37);
            this.layStyle.Text = "类型";
            this.layStyle.TextSize = new System.Drawing.Size(36, 14);
            // 
            // layCreateUser
            // 
            this.layCreateUser.Control = this.txtCreateUser;
            this.layCreateUser.CustomizationFormText = "创建人";
            this.layCreateUser.Location = new System.Drawing.Point(272, 50);
            this.layCreateUser.Name = "layCreateUser";
            this.layCreateUser.Size = new System.Drawing.Size(272, 37);
            this.layCreateUser.Text = "创建人";
            this.layCreateUser.TextSize = new System.Drawing.Size(36, 14);
            // 
            // FrmSingleFacilities
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 14F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(568, 175);
            this.Controls.Add(this.groupControl);
            this.Controls.Add(this.panelControl1);
            this.Name = "FrmSingleFacilities";
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "设施设备";
            this.Load += new System.EventHandler(this.FrmSingleFacilities_Load);
            ((System.ComponentModel.ISupportInitialize)(this.panelControl1)).EndInit();
            this.panelControl1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.groupControl)).EndInit();
            this.groupControl.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.layoutControl1)).EndInit();
            this.layoutControl1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.txtCreateUser.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cboStyle.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtName.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtAddress.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtCode.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtSpec.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlGroup1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layCode)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layName)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.laySpec)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layAddress)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layStyle)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layCreateUser)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraEditors.PanelControl panelControl1;
        private DevExpress.XtraEditors.GroupControl groupControl;
        private DevExpress.XtraLayout.LayoutControl layoutControl1;
        private DevExpress.XtraEditors.TextEdit txtCreateUser;
        private DevExpress.XtraEditors.ComboBoxEdit cboStyle;
        private DevExpress.XtraEditors.TextEdit txtName;
        private DevExpress.XtraEditors.TextEdit txtAddress;
        private DevExpress.XtraEditors.TextEdit txtCode;
        private DevExpress.XtraEditors.TextEdit txtSpec;
        private DevExpress.XtraLayout.LayoutControlGroup layoutControlGroup1;
        private DevExpress.XtraLayout.LayoutControlItem layCode;
        private DevExpress.XtraLayout.LayoutControlItem layName;
        private DevExpress.XtraLayout.LayoutControlItem laySpec;
        private DevExpress.XtraLayout.LayoutControlItem layAddress;
        private DevExpress.XtraLayout.LayoutControlItem layStyle;
        private DevExpress.XtraLayout.LayoutControlItem layCreateUser;
        private DevExpress.XtraEditors.SimpleButton btnCancel;
        private DevExpress.XtraEditors.SimpleButton btnSave;
    }
}