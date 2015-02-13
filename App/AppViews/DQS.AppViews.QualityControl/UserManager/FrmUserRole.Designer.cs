namespace DQS.AppViews.QualityControl.UserManager
{
    partial class FrmUserRole
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
            this.pnlLeftTop = new DevExpress.XtraEditors.PanelControl();
            this.txtUserName = new DQS.Controls.TextBoxEx();
            this.btnQuery = new DevExpress.XtraEditors.SimpleButton();
            this.lblUserName = new DevExpress.XtraEditors.LabelControl();
            this.splitterControl1 = new DevExpress.XtraEditors.SplitterControl();
            this.gpcRight = new DevExpress.XtraEditors.GroupControl();
            this.chklbcRole = new DevExpress.XtraEditors.CheckedListBoxControl();
            this.pnlRightTop = new DevExpress.XtraEditors.PanelControl();
            this.chkCheck = new DevExpress.XtraEditors.CheckEdit();
            this.btnSave = new DevExpress.XtraEditors.SimpleButton();
            ((System.ComponentModel.ISupportInitialize)(this.gpcLeft)).BeginInit();
            this.gpcLeft.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.lbcUser)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pnlLeftTop)).BeginInit();
            this.pnlLeftTop.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.txtUserName.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gpcRight)).BeginInit();
            this.gpcRight.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.chklbcRole)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pnlRightTop)).BeginInit();
            this.pnlRightTop.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.chkCheck.Properties)).BeginInit();
            this.SuspendLayout();
            // 
            // gpcLeft
            // 
            this.gpcLeft.Controls.Add(this.lbcUser);
            this.gpcLeft.Controls.Add(this.pnlLeftTop);
            this.gpcLeft.Dock = System.Windows.Forms.DockStyle.Left;
            this.gpcLeft.Location = new System.Drawing.Point(0, 0);
            this.gpcLeft.Name = "gpcLeft";
            this.gpcLeft.Size = new System.Drawing.Size(297, 482);
            this.gpcLeft.TabIndex = 0;
            this.gpcLeft.Text = "用户列表";
            // 
            // lbcUser
            // 
            this.lbcUser.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lbcUser.HighlightedItemStyle = DevExpress.XtraEditors.HighlightStyle.Skinned;
            this.lbcUser.Location = new System.Drawing.Point(2, 65);
            this.lbcUser.Name = "lbcUser";
            this.lbcUser.SelectionMode = System.Windows.Forms.SelectionMode.MultiExtended;
            this.lbcUser.Size = new System.Drawing.Size(293, 415);
            this.lbcUser.TabIndex = 1;
            this.lbcUser.SelectedIndexChanged += new System.EventHandler(this.lbcUser_SelectedIndexChanged);
            // 
            // pnlLeftTop
            // 
            this.pnlLeftTop.Controls.Add(this.txtUserName);
            this.pnlLeftTop.Controls.Add(this.btnQuery);
            this.pnlLeftTop.Controls.Add(this.lblUserName);
            this.pnlLeftTop.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlLeftTop.Location = new System.Drawing.Point(2, 23);
            this.pnlLeftTop.Name = "pnlLeftTop";
            this.pnlLeftTop.Size = new System.Drawing.Size(293, 42);
            this.pnlLeftTop.TabIndex = 0;
            // 
            // txtUserName
            // 
            this.txtUserName.AlphabeticFiled = null;
            this.txtUserName.IsIntegerOnly = false;
            this.txtUserName.IsNullString = null;
            this.txtUserName.IsNullValidate = false;
            this.txtUserName.IsTransferAlphabetic = false;
            this.txtUserName.Location = new System.Drawing.Point(75, 11);
            this.txtUserName.Name = "txtUserName";
            this.txtUserName.Size = new System.Drawing.Size(127, 21);
            this.txtUserName.TabIndex = 6;
            this.txtUserName.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtUserName_KeyPress);
            // 
            // btnQuery
            // 
            this.btnQuery.Location = new System.Drawing.Point(208, 10);
            this.btnQuery.Name = "btnQuery";
            this.btnQuery.Size = new System.Drawing.Size(80, 23);
            this.btnQuery.TabIndex = 5;
            this.btnQuery.Text = "快速查询(&Q)";
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
            // splitterControl1
            // 
            this.splitterControl1.Location = new System.Drawing.Point(297, 0);
            this.splitterControl1.Name = "splitterControl1";
            this.splitterControl1.Size = new System.Drawing.Size(6, 482);
            this.splitterControl1.TabIndex = 1;
            this.splitterControl1.TabStop = false;
            // 
            // gpcRight
            // 
            this.gpcRight.Controls.Add(this.chklbcRole);
            this.gpcRight.Controls.Add(this.pnlRightTop);
            this.gpcRight.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gpcRight.Location = new System.Drawing.Point(303, 0);
            this.gpcRight.Name = "gpcRight";
            this.gpcRight.Size = new System.Drawing.Size(511, 482);
            this.gpcRight.TabIndex = 2;
            this.gpcRight.Text = "角色列表";
            // 
            // chklbcRole
            // 
            this.chklbcRole.CheckOnClick = true;
            this.chklbcRole.ColumnWidth = 200;
            this.chklbcRole.Dock = System.Windows.Forms.DockStyle.Fill;
            this.chklbcRole.HighlightedItemStyle = DevExpress.XtraEditors.HighlightStyle.Skinned;
            this.chklbcRole.Location = new System.Drawing.Point(2, 65);
            this.chklbcRole.MultiColumn = true;
            this.chklbcRole.Name = "chklbcRole";
            this.chklbcRole.Size = new System.Drawing.Size(507, 415);
            this.chklbcRole.TabIndex = 1;
            // 
            // pnlRightTop
            // 
            this.pnlRightTop.Controls.Add(this.chkCheck);
            this.pnlRightTop.Controls.Add(this.btnSave);
            this.pnlRightTop.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlRightTop.Location = new System.Drawing.Point(2, 23);
            this.pnlRightTop.Name = "pnlRightTop";
            this.pnlRightTop.Size = new System.Drawing.Size(507, 42);
            this.pnlRightTop.TabIndex = 0;
            // 
            // chkCheck
            // 
            this.chkCheck.Location = new System.Drawing.Point(1, 11);
            this.chkCheck.Name = "chkCheck";
            this.chkCheck.Properties.Caption = "全选";
            this.chkCheck.Size = new System.Drawing.Size(58, 19);
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
            // FrmUserRole
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 14F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(814, 482);
            this.Controls.Add(this.gpcRight);
            this.Controls.Add(this.splitterControl1);
            this.Controls.Add(this.gpcLeft);
            this.Name = "FrmUserRole";
            this.Text = "FrmUserRole";
            this.Load += new System.EventHandler(this.FrmUserRole_Load);
            ((System.ComponentModel.ISupportInitialize)(this.gpcLeft)).EndInit();
            this.gpcLeft.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.lbcUser)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pnlLeftTop)).EndInit();
            this.pnlLeftTop.ResumeLayout(false);
            this.pnlLeftTop.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.txtUserName.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gpcRight)).EndInit();
            this.gpcRight.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.chklbcRole)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pnlRightTop)).EndInit();
            this.pnlRightTop.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.chkCheck.Properties)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraEditors.GroupControl gpcLeft;
        private DevExpress.XtraEditors.PanelControl pnlLeftTop;
        private DevExpress.XtraEditors.SimpleButton btnQuery;
        private DevExpress.XtraEditors.LabelControl lblUserName;
        private DevExpress.XtraEditors.SplitterControl splitterControl1;
        private DevExpress.XtraEditors.ListBoxControl lbcUser;
        private DevExpress.XtraEditors.GroupControl gpcRight;
        private DevExpress.XtraEditors.PanelControl pnlRightTop;
        private DevExpress.XtraEditors.CheckedListBoxControl chklbcRole;
        private DevExpress.XtraEditors.SimpleButton btnSave;
        private DevExpress.XtraEditors.CheckEdit chkCheck;
        private DQS.Controls.TextBoxEx txtUserName;
    }
}