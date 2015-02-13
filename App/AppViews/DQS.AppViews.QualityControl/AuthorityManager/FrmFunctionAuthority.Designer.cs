namespace DQS.AppViews.QualityControl.AuthorityManager
{
    partial class FrmFunctionAuthority
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
            this.gpcLeft = new DevExpress.XtraEditors.GroupControl();
            this.lbcRole = new DevExpress.XtraEditors.ListBoxControl();
            this.pnlLeft = new DevExpress.XtraEditors.PanelControl();
            this.btnRoleQuery = new DevExpress.XtraEditors.SimpleButton();
            this.lblRole = new DevExpress.XtraEditors.LabelControl();
            this.txtRoleName = new DevExpress.XtraEditors.TextEdit();
            this.splitterControl1 = new DevExpress.XtraEditors.SplitterControl();
            this.splitterControl2 = new DevExpress.XtraEditors.SplitterControl();
            this.gpcCenter = new DevExpress.XtraEditors.GroupControl();
            this.lbcPage = new DevExpress.XtraEditors.ListBoxControl();
            this.pnlCenter = new DevExpress.XtraEditors.PanelControl();
            this.btnPageQuery = new DevExpress.XtraEditors.SimpleButton();
            this.lblPage = new DevExpress.XtraEditors.LabelControl();
            this.txtPageName = new DevExpress.XtraEditors.TextEdit();
            this.gpcRight = new DevExpress.XtraEditors.GroupControl();
            this.chklbcFunction = new DevExpress.XtraEditors.CheckedListBoxControl();
            this.pnlRight = new DevExpress.XtraEditors.PanelControl();
            this.chkCheck = new DevExpress.XtraEditors.CheckEdit();
            this.btnSave = new DevExpress.XtraEditors.SimpleButton();
            ((System.ComponentModel.ISupportInitialize)(this.gpcLeft)).BeginInit();
            this.gpcLeft.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.lbcRole)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pnlLeft)).BeginInit();
            this.pnlLeft.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.txtRoleName.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gpcCenter)).BeginInit();
            this.gpcCenter.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.lbcPage)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pnlCenter)).BeginInit();
            this.pnlCenter.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.txtPageName.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gpcRight)).BeginInit();
            this.gpcRight.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.chklbcFunction)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pnlRight)).BeginInit();
            this.pnlRight.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.chkCheck.Properties)).BeginInit();
            this.SuspendLayout();
            // 
            // gpcLeft
            // 
            this.gpcLeft.Controls.Add(this.lbcRole);
            this.gpcLeft.Controls.Add(this.pnlLeft);
            this.gpcLeft.Dock = System.Windows.Forms.DockStyle.Left;
            this.gpcLeft.Location = new System.Drawing.Point(0, 0);
            this.gpcLeft.Name = "gpcLeft";
            this.gpcLeft.Size = new System.Drawing.Size(297, 482);
            this.gpcLeft.TabIndex = 2;
            this.gpcLeft.Text = "角色列表";
            // 
            // lbcRole
            // 
            this.lbcRole.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lbcRole.HighlightedItemStyle = DevExpress.XtraEditors.HighlightStyle.Skinned;
            this.lbcRole.Location = new System.Drawing.Point(2, 66);
            this.lbcRole.Name = "lbcRole";
            this.lbcRole.Size = new System.Drawing.Size(293, 414);
            this.lbcRole.TabIndex = 1;
            this.lbcRole.SelectedIndexChanged += new System.EventHandler(this.lbcRole_SelectedIndexChanged);
            // 
            // pnlLeft
            // 
            this.pnlLeft.Controls.Add(this.btnRoleQuery);
            this.pnlLeft.Controls.Add(this.lblRole);
            this.pnlLeft.Controls.Add(this.txtRoleName);
            this.pnlLeft.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlLeft.Location = new System.Drawing.Point(2, 24);
            this.pnlLeft.Name = "pnlLeft";
            this.pnlLeft.Size = new System.Drawing.Size(293, 42);
            this.pnlLeft.TabIndex = 0;
            // 
            // btnRoleQuery
            // 
            this.btnRoleQuery.Location = new System.Drawing.Point(208, 10);
            this.btnRoleQuery.Name = "btnRoleQuery";
            this.btnRoleQuery.Size = new System.Drawing.Size(80, 23);
            this.btnRoleQuery.TabIndex = 5;
            this.btnRoleQuery.Text = "快速查询";
            this.btnRoleQuery.Click += new System.EventHandler(this.btnRoleQuery_Click);
            // 
            // lblRole
            // 
            this.lblRole.Location = new System.Drawing.Point(10, 15);
            this.lblRole.Name = "lblRole";
            this.lblRole.Size = new System.Drawing.Size(57, 14);
            this.lblRole.TabIndex = 4;
            this.lblRole.Text = "角色名(&R):";
            // 
            // txtRoleName
            // 
            this.txtRoleName.Location = new System.Drawing.Point(77, 12);
            this.txtRoleName.Name = "txtRoleName";
            this.txtRoleName.Size = new System.Drawing.Size(125, 21);
            this.txtRoleName.TabIndex = 3;
            this.txtRoleName.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtRoleName_KeyPress);
            // 
            // splitterControl1
            // 
            this.splitterControl1.Location = new System.Drawing.Point(297, 0);
            this.splitterControl1.Name = "splitterControl1";
            this.splitterControl1.Size = new System.Drawing.Size(6, 482);
            this.splitterControl1.TabIndex = 3;
            this.splitterControl1.TabStop = false;
            // 
            // splitterControl2
            // 
            this.splitterControl2.Location = new System.Drawing.Point(600, 0);
            this.splitterControl2.Name = "splitterControl2";
            this.splitterControl2.Size = new System.Drawing.Size(6, 482);
            this.splitterControl2.TabIndex = 5;
            this.splitterControl2.TabStop = false;
            // 
            // gpcCenter
            // 
            this.gpcCenter.Controls.Add(this.lbcPage);
            this.gpcCenter.Controls.Add(this.pnlCenter);
            this.gpcCenter.Dock = System.Windows.Forms.DockStyle.Left;
            this.gpcCenter.Location = new System.Drawing.Point(303, 0);
            this.gpcCenter.Name = "gpcCenter";
            this.gpcCenter.Size = new System.Drawing.Size(297, 482);
            this.gpcCenter.TabIndex = 4;
            this.gpcCenter.Text = "页面列表";
            // 
            // lbcPage
            // 
            this.lbcPage.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lbcPage.HighlightedItemStyle = DevExpress.XtraEditors.HighlightStyle.Skinned;
            this.lbcPage.Location = new System.Drawing.Point(2, 66);
            this.lbcPage.Name = "lbcPage";
            this.lbcPage.Size = new System.Drawing.Size(293, 414);
            this.lbcPage.TabIndex = 1;
            this.lbcPage.SelectedIndexChanged += new System.EventHandler(this.lbcPage_SelectedIndexChanged);
            // 
            // pnlCenter
            // 
            this.pnlCenter.Controls.Add(this.btnPageQuery);
            this.pnlCenter.Controls.Add(this.lblPage);
            this.pnlCenter.Controls.Add(this.txtPageName);
            this.pnlCenter.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlCenter.Location = new System.Drawing.Point(2, 24);
            this.pnlCenter.Name = "pnlCenter";
            this.pnlCenter.Size = new System.Drawing.Size(293, 42);
            this.pnlCenter.TabIndex = 0;
            // 
            // btnPageQuery
            // 
            this.btnPageQuery.Location = new System.Drawing.Point(208, 10);
            this.btnPageQuery.Name = "btnPageQuery";
            this.btnPageQuery.Size = new System.Drawing.Size(80, 23);
            this.btnPageQuery.TabIndex = 5;
            this.btnPageQuery.Text = "快速查询";
            this.btnPageQuery.Click += new System.EventHandler(this.btnPageQuery_Click);
            // 
            // lblPage
            // 
            this.lblPage.Location = new System.Drawing.Point(10, 15);
            this.lblPage.Name = "lblPage";
            this.lblPage.Size = new System.Drawing.Size(57, 14);
            this.lblPage.TabIndex = 4;
            this.lblPage.Text = "页面名(&R):";
            // 
            // txtPageName
            // 
            this.txtPageName.Location = new System.Drawing.Point(77, 12);
            this.txtPageName.Name = "txtPageName";
            this.txtPageName.Size = new System.Drawing.Size(125, 21);
            this.txtPageName.TabIndex = 3;
            this.txtPageName.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtPageName_KeyPress);
            // 
            // gpcRight
            // 
            this.gpcRight.Controls.Add(this.chklbcFunction);
            this.gpcRight.Controls.Add(this.pnlRight);
            this.gpcRight.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gpcRight.Location = new System.Drawing.Point(606, 0);
            this.gpcRight.Name = "gpcRight";
            this.gpcRight.Size = new System.Drawing.Size(208, 482);
            this.gpcRight.TabIndex = 6;
            this.gpcRight.Text = "功能清单";
            // 
            // chklbcFunction
            // 
            this.chklbcFunction.CheckOnClick = true;
            this.chklbcFunction.ColumnWidth = 200;
            this.chklbcFunction.Dock = System.Windows.Forms.DockStyle.Fill;
            this.chklbcFunction.HighlightedItemStyle = DevExpress.XtraEditors.HighlightStyle.Skinned;
            this.chklbcFunction.Location = new System.Drawing.Point(2, 66);
            this.chklbcFunction.MultiColumn = true;
            this.chklbcFunction.Name = "chklbcFunction";
            this.chklbcFunction.Size = new System.Drawing.Size(204, 414);
            this.chklbcFunction.TabIndex = 2;
            // 
            // pnlRight
            // 
            this.pnlRight.Controls.Add(this.chkCheck);
            this.pnlRight.Controls.Add(this.btnSave);
            this.pnlRight.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlRight.Location = new System.Drawing.Point(2, 24);
            this.pnlRight.Name = "pnlRight";
            this.pnlRight.Size = new System.Drawing.Size(204, 42);
            this.pnlRight.TabIndex = 0;
            // 
            // chkCheck
            // 
            this.chkCheck.Location = new System.Drawing.Point(1, 11);
            this.chkCheck.Name = "chkCheck";
            this.chkCheck.Properties.Caption = "全选";
            this.chkCheck.Size = new System.Drawing.Size(58, 20);
            this.chkCheck.TabIndex = 7;
            this.chkCheck.CheckedChanged += new System.EventHandler(this.chkCheck_CheckedChanged);
            // 
            // btnSave
            // 
            this.btnSave.Location = new System.Drawing.Point(65, 10);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(80, 23);
            this.btnSave.TabIndex = 6;
            this.btnSave.Text = "保存(&S)";
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // FrmFunctionAuthority
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 14F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(814, 482);
            this.Controls.Add(this.gpcRight);
            this.Controls.Add(this.splitterControl2);
            this.Controls.Add(this.gpcCenter);
            this.Controls.Add(this.splitterControl1);
            this.Controls.Add(this.gpcLeft);
            this.Name = "FrmFunctionAuthority";
            this.Text = "FrmFunctionAuthority";
            this.Load += new System.EventHandler(this.FrmFunctionAuthority_Load);
            ((System.ComponentModel.ISupportInitialize)(this.gpcLeft)).EndInit();
            this.gpcLeft.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.lbcRole)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pnlLeft)).EndInit();
            this.pnlLeft.ResumeLayout(false);
            this.pnlLeft.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.txtRoleName.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gpcCenter)).EndInit();
            this.gpcCenter.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.lbcPage)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pnlCenter)).EndInit();
            this.pnlCenter.ResumeLayout(false);
            this.pnlCenter.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.txtPageName.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gpcRight)).EndInit();
            this.gpcRight.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.chklbcFunction)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pnlRight)).EndInit();
            this.pnlRight.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.chkCheck.Properties)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraEditors.GroupControl gpcLeft;
        private DevExpress.XtraEditors.ListBoxControl lbcRole;
        private DevExpress.XtraEditors.PanelControl pnlLeft;
        private DevExpress.XtraEditors.SimpleButton btnRoleQuery;
        private DevExpress.XtraEditors.LabelControl lblRole;
        private DevExpress.XtraEditors.TextEdit txtRoleName;
        private DevExpress.XtraEditors.SplitterControl splitterControl1;
        private DevExpress.XtraEditors.SplitterControl splitterControl2;
        private DevExpress.XtraEditors.GroupControl gpcCenter;
        private DevExpress.XtraEditors.ListBoxControl lbcPage;
        private DevExpress.XtraEditors.PanelControl pnlCenter;
        private DevExpress.XtraEditors.SimpleButton btnPageQuery;
        private DevExpress.XtraEditors.LabelControl lblPage;
        private DevExpress.XtraEditors.TextEdit txtPageName;
        private DevExpress.XtraEditors.GroupControl gpcRight;
        private DevExpress.XtraEditors.PanelControl pnlRight;
        private DevExpress.XtraEditors.CheckEdit chkCheck;
        private DevExpress.XtraEditors.SimpleButton btnSave;
        private DevExpress.XtraEditors.CheckedListBoxControl chklbcFunction;
    }
}