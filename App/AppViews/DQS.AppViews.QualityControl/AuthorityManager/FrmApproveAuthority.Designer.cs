namespace DQS.AppViews.QualityControl.AuthorityManager
{
    partial class FrmApproveAuthority
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
            this.lbcUser = new DevExpress.XtraEditors.ListBoxControl();
            this.pnlLeft = new DevExpress.XtraEditors.PanelControl();
            this.btnQuery = new DevExpress.XtraEditors.SimpleButton();
            this.lblUserName = new DevExpress.XtraEditors.LabelControl();
            this.txtUserName = new DevExpress.XtraEditors.TextEdit();
            this.splitterControl1 = new DevExpress.XtraEditors.SplitterControl();
            this.gpcCenter = new DevExpress.XtraEditors.GroupControl();
            this.lbcDocument = new DevExpress.XtraEditors.ListBoxControl();
            this.pnlCenter = new DevExpress.XtraEditors.PanelControl();
            this.rdgApproveStyle = new DevExpress.XtraEditors.RadioGroup();
            this.splitterControl2 = new DevExpress.XtraEditors.SplitterControl();
            this.gpcRight = new DevExpress.XtraEditors.GroupControl();
            this.chklbcApprovalUser = new DevExpress.XtraEditors.CheckedListBoxControl();
            this.pnlRight = new DevExpress.XtraEditors.PanelControl();
            this.chkCheck = new DevExpress.XtraEditors.CheckEdit();
            this.btnSave = new DevExpress.XtraEditors.SimpleButton();
            ((System.ComponentModel.ISupportInitialize)(this.gpcLeft)).BeginInit();
            this.gpcLeft.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.lbcUser)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pnlLeft)).BeginInit();
            this.pnlLeft.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.txtUserName.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gpcCenter)).BeginInit();
            this.gpcCenter.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.lbcDocument)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pnlCenter)).BeginInit();
            this.pnlCenter.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.rdgApproveStyle.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gpcRight)).BeginInit();
            this.gpcRight.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.chklbcApprovalUser)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pnlRight)).BeginInit();
            this.pnlRight.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.chkCheck.Properties)).BeginInit();
            this.SuspendLayout();
            // 
            // gpcLeft
            // 
            this.gpcLeft.Controls.Add(this.lbcUser);
            this.gpcLeft.Controls.Add(this.pnlLeft);
            this.gpcLeft.Dock = System.Windows.Forms.DockStyle.Left;
            this.gpcLeft.Location = new System.Drawing.Point(0, 0);
            this.gpcLeft.Name = "gpcLeft";
            this.gpcLeft.Size = new System.Drawing.Size(297, 482);
            this.gpcLeft.TabIndex = 1;
            this.gpcLeft.Text = "发起人";
            // 
            // lbcUser
            // 
            this.lbcUser.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lbcUser.HighlightedItemStyle = DevExpress.XtraEditors.HighlightStyle.Skinned;
            this.lbcUser.Location = new System.Drawing.Point(2, 66);
            this.lbcUser.Name = "lbcUser";
            this.lbcUser.SelectionMode = System.Windows.Forms.SelectionMode.MultiExtended;
            this.lbcUser.Size = new System.Drawing.Size(293, 414);
            this.lbcUser.TabIndex = 1;
            this.lbcUser.SelectedIndexChanged += new System.EventHandler(this.lbcUser_SelectedIndexChanged);
            // 
            // pnlLeft
            // 
            this.pnlLeft.Controls.Add(this.btnQuery);
            this.pnlLeft.Controls.Add(this.lblUserName);
            this.pnlLeft.Controls.Add(this.txtUserName);
            this.pnlLeft.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlLeft.Location = new System.Drawing.Point(2, 24);
            this.pnlLeft.Name = "pnlLeft";
            this.pnlLeft.Size = new System.Drawing.Size(293, 42);
            this.pnlLeft.TabIndex = 0;
            // 
            // btnQuery
            // 
            this.btnQuery.Location = new System.Drawing.Point(208, 10);
            this.btnQuery.Name = "btnQuery";
            this.btnQuery.Size = new System.Drawing.Size(80, 23);
            this.btnQuery.TabIndex = 5;
            this.btnQuery.Text = "快速查询";
            this.btnQuery.Click += new System.EventHandler(this.btnQuery_Click);
            // 
            // lblUserName
            // 
            this.lblUserName.Location = new System.Drawing.Point(10, 15);
            this.lblUserName.Name = "lblUserName";
            this.lblUserName.Size = new System.Drawing.Size(58, 14);
            this.lblUserName.TabIndex = 4;
            this.lblUserName.Text = "用户名(&U):";
            // 
            // txtUserName
            // 
            this.txtUserName.Location = new System.Drawing.Point(77, 12);
            this.txtUserName.Name = "txtUserName";
            this.txtUserName.Size = new System.Drawing.Size(125, 21);
            this.txtUserName.TabIndex = 3;
            this.txtUserName.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtUserName_KeyPress);
            // 
            // splitterControl1
            // 
            this.splitterControl1.Location = new System.Drawing.Point(297, 0);
            this.splitterControl1.Name = "splitterControl1";
            this.splitterControl1.Size = new System.Drawing.Size(6, 482);
            this.splitterControl1.TabIndex = 2;
            this.splitterControl1.TabStop = false;
            // 
            // gpcCenter
            // 
            this.gpcCenter.Controls.Add(this.lbcDocument);
            this.gpcCenter.Controls.Add(this.pnlCenter);
            this.gpcCenter.Dock = System.Windows.Forms.DockStyle.Left;
            this.gpcCenter.Location = new System.Drawing.Point(303, 0);
            this.gpcCenter.Name = "gpcCenter";
            this.gpcCenter.Size = new System.Drawing.Size(297, 482);
            this.gpcCenter.TabIndex = 5;
            this.gpcCenter.Text = "单据列表";
            // 
            // lbcDocument
            // 
            this.lbcDocument.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lbcDocument.HighlightedItemStyle = DevExpress.XtraEditors.HighlightStyle.Skinned;
            this.lbcDocument.Location = new System.Drawing.Point(2, 66);
            this.lbcDocument.Name = "lbcDocument";
            this.lbcDocument.Size = new System.Drawing.Size(293, 414);
            this.lbcDocument.TabIndex = 1;
            this.lbcDocument.SelectedIndexChanged += new System.EventHandler(this.lbcDocument_SelectedIndexChanged);
            // 
            // pnlCenter
            // 
            this.pnlCenter.Controls.Add(this.rdgApproveStyle);
            this.pnlCenter.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlCenter.Location = new System.Drawing.Point(2, 24);
            this.pnlCenter.Name = "pnlCenter";
            this.pnlCenter.Size = new System.Drawing.Size(293, 42);
            this.pnlCenter.TabIndex = 0;
            // 
            // rdgApproveStyle
            // 
            this.rdgApproveStyle.Dock = System.Windows.Forms.DockStyle.Fill;
            this.rdgApproveStyle.Location = new System.Drawing.Point(2, 2);
            this.rdgApproveStyle.Name = "rdgApproveStyle";
            this.rdgApproveStyle.Properties.Appearance.BackColor = System.Drawing.Color.Transparent;
            this.rdgApproveStyle.Properties.Appearance.Options.UseBackColor = true;
            this.rdgApproveStyle.Properties.Items.AddRange(new DevExpress.XtraEditors.Controls.RadioGroupItem[] {
            new DevExpress.XtraEditors.Controls.RadioGroupItem(null, "单人一次审批通过"),
            new DevExpress.XtraEditors.Controls.RadioGroupItem(null, "多人全部审批通过")});
            this.rdgApproveStyle.Size = new System.Drawing.Size(289, 38);
            this.rdgApproveStyle.TabIndex = 0;
            this.rdgApproveStyle.SelectedIndexChanged += new System.EventHandler(this.rdgApproveStyle_SelectedIndexChanged);
            // 
            // splitterControl2
            // 
            this.splitterControl2.Location = new System.Drawing.Point(600, 0);
            this.splitterControl2.Name = "splitterControl2";
            this.splitterControl2.Size = new System.Drawing.Size(6, 482);
            this.splitterControl2.TabIndex = 6;
            this.splitterControl2.TabStop = false;
            // 
            // gpcRight
            // 
            this.gpcRight.Controls.Add(this.chklbcApprovalUser);
            this.gpcRight.Controls.Add(this.pnlRight);
            this.gpcRight.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gpcRight.Location = new System.Drawing.Point(606, 0);
            this.gpcRight.Name = "gpcRight";
            this.gpcRight.Size = new System.Drawing.Size(208, 482);
            this.gpcRight.TabIndex = 7;
            this.gpcRight.Text = "审批人";
            // 
            // chklbcApprovalUser
            // 
            this.chklbcApprovalUser.CheckOnClick = true;
            this.chklbcApprovalUser.ColumnWidth = 200;
            this.chklbcApprovalUser.Dock = System.Windows.Forms.DockStyle.Fill;
            this.chklbcApprovalUser.HighlightedItemStyle = DevExpress.XtraEditors.HighlightStyle.Skinned;
            this.chklbcApprovalUser.Location = new System.Drawing.Point(2, 66);
            this.chklbcApprovalUser.MultiColumn = true;
            this.chklbcApprovalUser.Name = "chklbcApprovalUser";
            this.chklbcApprovalUser.Size = new System.Drawing.Size(204, 414);
            this.chklbcApprovalUser.TabIndex = 2;
            this.chklbcApprovalUser.ItemCheck += new DevExpress.XtraEditors.Controls.ItemCheckEventHandler(this.chklbcApprovalUser_ItemCheck);
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
            // FrmApproveAuthority
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 14F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(814, 482);
            this.Controls.Add(this.gpcRight);
            this.Controls.Add(this.splitterControl2);
            this.Controls.Add(this.gpcCenter);
            this.Controls.Add(this.splitterControl1);
            this.Controls.Add(this.gpcLeft);
            this.Name = "FrmApproveAuthority";
            this.Text = "FrmApproveAuthority";
            this.Load += new System.EventHandler(this.FrmApproveAuthority_Load);
            ((System.ComponentModel.ISupportInitialize)(this.gpcLeft)).EndInit();
            this.gpcLeft.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.lbcUser)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pnlLeft)).EndInit();
            this.pnlLeft.ResumeLayout(false);
            this.pnlLeft.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.txtUserName.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gpcCenter)).EndInit();
            this.gpcCenter.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.lbcDocument)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pnlCenter)).EndInit();
            this.pnlCenter.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.rdgApproveStyle.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gpcRight)).EndInit();
            this.gpcRight.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.chklbcApprovalUser)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pnlRight)).EndInit();
            this.pnlRight.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.chkCheck.Properties)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraEditors.GroupControl gpcLeft;
        private DevExpress.XtraEditors.ListBoxControl lbcUser;
        private DevExpress.XtraEditors.PanelControl pnlLeft;
        private DevExpress.XtraEditors.SimpleButton btnQuery;
        private DevExpress.XtraEditors.LabelControl lblUserName;
        private DevExpress.XtraEditors.TextEdit txtUserName;
        private DevExpress.XtraEditors.SplitterControl splitterControl1;
        private DevExpress.XtraEditors.GroupControl gpcCenter;
        private DevExpress.XtraEditors.ListBoxControl lbcDocument;
        private DevExpress.XtraEditors.PanelControl pnlCenter;
        private DevExpress.XtraEditors.SplitterControl splitterControl2;
        private DevExpress.XtraEditors.GroupControl gpcRight;
        private DevExpress.XtraEditors.CheckedListBoxControl chklbcApprovalUser;
        private DevExpress.XtraEditors.PanelControl pnlRight;
        private DevExpress.XtraEditors.CheckEdit chkCheck;
        private DevExpress.XtraEditors.SimpleButton btnSave;
        private DevExpress.XtraEditors.RadioGroup rdgApproveStyle;
    }
}