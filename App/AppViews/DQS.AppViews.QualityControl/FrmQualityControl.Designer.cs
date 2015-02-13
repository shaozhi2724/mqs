namespace DQS.AppViews.QualityControl
{
    partial class FrmQualityControl
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
            this.tbtnUserRole = new DQS.Controls.ToolButton();
            this.tbtnRoleInfo = new DQS.Controls.ToolButton();
            this.tbtnUserInfo = new DQS.Controls.ToolButton();
            this.tbtnBrowseAuthority = new DQS.Controls.ToolButton();
            this.tbtnFunctionAuthority = new DQS.Controls.ToolButton();
            this.tbtnApproveAuthority = new DQS.Controls.ToolButton();
            this.SuspendLayout();
            // 
            // tbtnUserRole
            // 
            this.tbtnUserRole.AllowFocus = false;
            this.tbtnUserRole.Appearance.BackColor = System.Drawing.Color.Transparent;
            this.tbtnUserRole.Appearance.Font = new System.Drawing.Font("微软雅黑", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbtnUserRole.Appearance.ForeColor = System.Drawing.Color.Black;
            this.tbtnUserRole.Appearance.Options.UseBackColor = true;
            this.tbtnUserRole.Appearance.Options.UseFont = true;
            this.tbtnUserRole.Appearance.Options.UseForeColor = true;
            this.tbtnUserRole.ButtonStyle = DevExpress.XtraEditors.Controls.BorderStyles.UltraFlat;
            this.tbtnUserRole.Cursor = System.Windows.Forms.Cursors.Hand;
            this.tbtnUserRole.Image = global::DQS.AppViews.QualityControl.Properties.Resources.用户角色分配;
            this.tbtnUserRole.ImageLocation = DevExpress.XtraEditors.ImageLocation.TopCenter;
            this.tbtnUserRole.Location = new System.Drawing.Point(498, 23);
            this.tbtnUserRole.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.tbtnUserRole.MenuCode = "UserRole";
            this.tbtnUserRole.MenuFullClass = "DQS.AppViews.QualityControl.UserManager.FrmUserRole, DQS.AppViews.QualityControl";
            this.tbtnUserRole.MenuName = "用户角色分配";
            this.tbtnUserRole.MouseEnterImage = global::DQS.AppViews.QualityControl.Properties.Resources.用户角色分配MouseEnter;
            this.tbtnUserRole.Name = "tbtnUserRole";
            this.tbtnUserRole.Size = new System.Drawing.Size(134, 136);
            this.tbtnUserRole.TabIndex = 2;
            this.tbtnUserRole.Text = "用户角色分配";
            // 
            // tbtnRoleInfo
            // 
            this.tbtnRoleInfo.AllowFocus = false;
            this.tbtnRoleInfo.Appearance.BackColor = System.Drawing.Color.Transparent;
            this.tbtnRoleInfo.Appearance.Font = new System.Drawing.Font("微软雅黑", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbtnRoleInfo.Appearance.ForeColor = System.Drawing.Color.Black;
            this.tbtnRoleInfo.Appearance.Options.UseBackColor = true;
            this.tbtnRoleInfo.Appearance.Options.UseFont = true;
            this.tbtnRoleInfo.Appearance.Options.UseForeColor = true;
            this.tbtnRoleInfo.ButtonStyle = DevExpress.XtraEditors.Controls.BorderStyles.UltraFlat;
            this.tbtnRoleInfo.Cursor = System.Windows.Forms.Cursors.Hand;
            this.tbtnRoleInfo.Image = global::DQS.AppViews.QualityControl.Properties.Resources.角色控制;
            this.tbtnRoleInfo.ImageLocation = DevExpress.XtraEditors.ImageLocation.TopCenter;
            this.tbtnRoleInfo.Location = new System.Drawing.Point(299, 23);
            this.tbtnRoleInfo.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.tbtnRoleInfo.MenuCode = "RoleInfo";
            this.tbtnRoleInfo.MenuFullClass = "DQS.AppViews.QualityControl.UserManager.FrmRoleInfo, DQS.AppViews.QualityControl";
            this.tbtnRoleInfo.MenuName = "角色管理";
            this.tbtnRoleInfo.MouseEnterImage = global::DQS.AppViews.QualityControl.Properties.Resources.角色控制MouseEnter;
            this.tbtnRoleInfo.Name = "tbtnRoleInfo";
            this.tbtnRoleInfo.Size = new System.Drawing.Size(134, 136);
            this.tbtnRoleInfo.TabIndex = 1;
            this.tbtnRoleInfo.Text = "角色管理";
            // 
            // tbtnUserInfo
            // 
            this.tbtnUserInfo.AllowFocus = false;
            this.tbtnUserInfo.Appearance.BackColor = System.Drawing.Color.Transparent;
            this.tbtnUserInfo.Appearance.Font = new System.Drawing.Font("微软雅黑", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbtnUserInfo.Appearance.ForeColor = System.Drawing.Color.Black;
            this.tbtnUserInfo.Appearance.Options.UseBackColor = true;
            this.tbtnUserInfo.Appearance.Options.UseFont = true;
            this.tbtnUserInfo.Appearance.Options.UseForeColor = true;
            this.tbtnUserInfo.ButtonStyle = DevExpress.XtraEditors.Controls.BorderStyles.UltraFlat;
            this.tbtnUserInfo.Cursor = System.Windows.Forms.Cursors.Hand;
            this.tbtnUserInfo.Image = global::DQS.AppViews.QualityControl.Properties.Resources.用户管理;
            this.tbtnUserInfo.ImageLocation = DevExpress.XtraEditors.ImageLocation.TopCenter;
            this.tbtnUserInfo.Location = new System.Drawing.Point(101, 23);
            this.tbtnUserInfo.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.tbtnUserInfo.MenuCode = "UserInfo";
            this.tbtnUserInfo.MenuFullClass = "DQS.AppViews.QualityControl.UserManager.FrmUserInfo, DQS.AppViews.QualityControl";
            this.tbtnUserInfo.MenuName = "用户管理";
            this.tbtnUserInfo.MouseEnterImage = global::DQS.AppViews.QualityControl.Properties.Resources.用户管理MouseEnter;
            this.tbtnUserInfo.Name = "tbtnUserInfo";
            this.tbtnUserInfo.Size = new System.Drawing.Size(134, 136);
            this.tbtnUserInfo.TabIndex = 0;
            this.tbtnUserInfo.Text = "用户管理";
            // 
            // tbtnBrowseAuthority
            // 
            this.tbtnBrowseAuthority.AllowFocus = false;
            this.tbtnBrowseAuthority.Appearance.BackColor = System.Drawing.Color.Transparent;
            this.tbtnBrowseAuthority.Appearance.Font = new System.Drawing.Font("微软雅黑", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbtnBrowseAuthority.Appearance.ForeColor = System.Drawing.Color.Black;
            this.tbtnBrowseAuthority.Appearance.Options.UseBackColor = true;
            this.tbtnBrowseAuthority.Appearance.Options.UseFont = true;
            this.tbtnBrowseAuthority.Appearance.Options.UseForeColor = true;
            this.tbtnBrowseAuthority.ButtonStyle = DevExpress.XtraEditors.Controls.BorderStyles.UltraFlat;
            this.tbtnBrowseAuthority.Cursor = System.Windows.Forms.Cursors.Hand;
            this.tbtnBrowseAuthority.Image = global::DQS.AppViews.QualityControl.Properties.Resources.浏览权限控制;
            this.tbtnBrowseAuthority.ImageLocation = DevExpress.XtraEditors.ImageLocation.TopCenter;
            this.tbtnBrowseAuthority.Location = new System.Drawing.Point(101, 180);
            this.tbtnBrowseAuthority.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.tbtnBrowseAuthority.MenuCode = "BrowseAuthority";
            this.tbtnBrowseAuthority.MenuFullClass = "DQS.AppViews.QualityControl.AuthorityManager.FrmBrowseAuthority, DQS.AppViews.Qua" +
    "lityControl";
            this.tbtnBrowseAuthority.MenuName = "浏览权限控制";
            this.tbtnBrowseAuthority.MouseEnterImage = global::DQS.AppViews.QualityControl.Properties.Resources.浏览权限控制MouseEnter;
            this.tbtnBrowseAuthority.Name = "tbtnBrowseAuthority";
            this.tbtnBrowseAuthority.Size = new System.Drawing.Size(134, 136);
            this.tbtnBrowseAuthority.TabIndex = 3;
            this.tbtnBrowseAuthority.Text = "浏览权限控制";
            // 
            // tbtnFunctionAuthority
            // 
            this.tbtnFunctionAuthority.AllowFocus = false;
            this.tbtnFunctionAuthority.Appearance.BackColor = System.Drawing.Color.Transparent;
            this.tbtnFunctionAuthority.Appearance.Font = new System.Drawing.Font("微软雅黑", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbtnFunctionAuthority.Appearance.ForeColor = System.Drawing.Color.Black;
            this.tbtnFunctionAuthority.Appearance.Options.UseBackColor = true;
            this.tbtnFunctionAuthority.Appearance.Options.UseFont = true;
            this.tbtnFunctionAuthority.Appearance.Options.UseForeColor = true;
            this.tbtnFunctionAuthority.ButtonStyle = DevExpress.XtraEditors.Controls.BorderStyles.UltraFlat;
            this.tbtnFunctionAuthority.Cursor = System.Windows.Forms.Cursors.Hand;
            this.tbtnFunctionAuthority.Image = global::DQS.AppViews.QualityControl.Properties.Resources.功能权限控制;
            this.tbtnFunctionAuthority.ImageLocation = DevExpress.XtraEditors.ImageLocation.TopCenter;
            this.tbtnFunctionAuthority.Location = new System.Drawing.Point(299, 180);
            this.tbtnFunctionAuthority.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.tbtnFunctionAuthority.MenuCode = "FunctionAuthority";
            this.tbtnFunctionAuthority.MenuFullClass = "DQS.AppViews.QualityControl.AuthorityManager.FrmFunctionAuthority, DQS.AppViews.Q" +
    "ualityControl";
            this.tbtnFunctionAuthority.MenuName = "功能权限控制";
            this.tbtnFunctionAuthority.MouseEnterImage = global::DQS.AppViews.QualityControl.Properties.Resources.功能权限控制MouseEnter;
            this.tbtnFunctionAuthority.Name = "tbtnFunctionAuthority";
            this.tbtnFunctionAuthority.Size = new System.Drawing.Size(134, 136);
            this.tbtnFunctionAuthority.TabIndex = 4;
            this.tbtnFunctionAuthority.Text = "功能权限控制";
            // 
            // tbtnApproveAuthority
            // 
            this.tbtnApproveAuthority.AllowFocus = false;
            this.tbtnApproveAuthority.Appearance.BackColor = System.Drawing.Color.Transparent;
            this.tbtnApproveAuthority.Appearance.Font = new System.Drawing.Font("微软雅黑", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbtnApproveAuthority.Appearance.ForeColor = System.Drawing.Color.Black;
            this.tbtnApproveAuthority.Appearance.Options.UseBackColor = true;
            this.tbtnApproveAuthority.Appearance.Options.UseFont = true;
            this.tbtnApproveAuthority.Appearance.Options.UseForeColor = true;
            this.tbtnApproveAuthority.ButtonStyle = DevExpress.XtraEditors.Controls.BorderStyles.UltraFlat;
            this.tbtnApproveAuthority.Cursor = System.Windows.Forms.Cursors.Hand;
            this.tbtnApproveAuthority.Image = global::DQS.AppViews.QualityControl.Properties.Resources.审批权限控制;
            this.tbtnApproveAuthority.ImageLocation = DevExpress.XtraEditors.ImageLocation.TopCenter;
            this.tbtnApproveAuthority.Location = new System.Drawing.Point(498, 180);
            this.tbtnApproveAuthority.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.tbtnApproveAuthority.MenuCode = "ApproveAuthority";
            this.tbtnApproveAuthority.MenuFullClass = "DQS.AppViews.QualityControl.AuthorityManager.FrmApproveAuthority, DQS.AppViews.Qu" +
    "alityControl";
            this.tbtnApproveAuthority.MenuName = "审批权限控制";
            this.tbtnApproveAuthority.MouseEnterImage = global::DQS.AppViews.QualityControl.Properties.Resources.审批权限控制MouseEnter;
            this.tbtnApproveAuthority.Name = "tbtnApproveAuthority";
            this.tbtnApproveAuthority.Size = new System.Drawing.Size(134, 136);
            this.tbtnApproveAuthority.TabIndex = 5;
            this.tbtnApproveAuthority.Text = "审批权限控制";
            // 
            // FrmQualityControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 18F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(896, 723);
            this.Controls.Add(this.tbtnApproveAuthority);
            this.Controls.Add(this.tbtnFunctionAuthority);
            this.Controls.Add(this.tbtnBrowseAuthority);
            this.Controls.Add(this.tbtnUserRole);
            this.Controls.Add(this.tbtnRoleInfo);
            this.Controls.Add(this.tbtnUserInfo);
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Name = "FrmQualityControl";
            this.Text = "FrmQualityControl";
            this.Load += new System.EventHandler(this.FrmQualityControl_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private DQS.Controls.ToolButton tbtnUserInfo;
        private DQS.Controls.ToolButton tbtnRoleInfo;
        private DQS.Controls.ToolButton tbtnUserRole;
        private DQS.Controls.ToolButton tbtnBrowseAuthority;
        private DQS.Controls.ToolButton tbtnFunctionAuthority;
        private DQS.Controls.ToolButton tbtnApproveAuthority;

    }
}