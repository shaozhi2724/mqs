namespace DQS.AppViews.QualityControl.AuthorityManager
{
    partial class FrmBrowseAuthority
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
            this.btnQuery = new DevExpress.XtraEditors.SimpleButton();
            this.lblRoleName = new DevExpress.XtraEditors.LabelControl();
            this.txtRole = new DevExpress.XtraEditors.TextEdit();
            this.splitterControl = new DevExpress.XtraEditors.SplitterControl();
            this.gpcRight = new DevExpress.XtraEditors.GroupControl();
            this.treeMenu = new DevExpress.XtraTreeList.TreeList();
            this.repositoryItemCheckEdit1 = new DevExpress.XtraEditors.Repository.RepositoryItemCheckEdit();
            this.pnlRight = new DevExpress.XtraEditors.PanelControl();
            this.chkCheck = new DevExpress.XtraEditors.CheckEdit();
            this.btnSave = new DevExpress.XtraEditors.SimpleButton();
            ((System.ComponentModel.ISupportInitialize)(this.gpcLeft)).BeginInit();
            this.gpcLeft.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.lbcRole)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pnlLeft)).BeginInit();
            this.pnlLeft.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.txtRole.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gpcRight)).BeginInit();
            this.gpcRight.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.treeMenu)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemCheckEdit1)).BeginInit();
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
            this.gpcLeft.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.gpcLeft.Name = "gpcLeft";
            this.gpcLeft.Size = new System.Drawing.Size(339, 620);
            this.gpcLeft.TabIndex = 1;
            this.gpcLeft.Text = "角色列表";
            // 
            // lbcRole
            // 
            this.lbcRole.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lbcRole.HighlightedItemStyle = DevExpress.XtraEditors.HighlightStyle.Skinned;
            this.lbcRole.Location = new System.Drawing.Point(2, 81);
            this.lbcRole.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.lbcRole.Name = "lbcRole";
            this.lbcRole.SelectionMode = System.Windows.Forms.SelectionMode.MultiExtended;
            this.lbcRole.Size = new System.Drawing.Size(335, 537);
            this.lbcRole.TabIndex = 1;
            this.lbcRole.SelectedIndexChanged += new System.EventHandler(this.lbcRole_SelectedIndexChanged);
            // 
            // pnlLeft
            // 
            this.pnlLeft.Controls.Add(this.btnQuery);
            this.pnlLeft.Controls.Add(this.lblRoleName);
            this.pnlLeft.Controls.Add(this.txtRole);
            this.pnlLeft.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlLeft.Location = new System.Drawing.Point(2, 27);
            this.pnlLeft.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.pnlLeft.Name = "pnlLeft";
            this.pnlLeft.Size = new System.Drawing.Size(335, 54);
            this.pnlLeft.TabIndex = 0;
            // 
            // btnQuery
            // 
            this.btnQuery.Location = new System.Drawing.Point(237, 13);
            this.btnQuery.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnQuery.Name = "btnQuery";
            this.btnQuery.Size = new System.Drawing.Size(91, 30);
            this.btnQuery.TabIndex = 5;
            this.btnQuery.Text = "快速查询";
            this.btnQuery.Click += new System.EventHandler(this.btnQuery_Click);
            // 
            // lblRoleName
            // 
            this.lblRoleName.Location = new System.Drawing.Point(11, 19);
            this.lblRoleName.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.lblRoleName.Name = "lblRoleName";
            this.lblRoleName.Size = new System.Drawing.Size(71, 18);
            this.lblRoleName.TabIndex = 4;
            this.lblRoleName.Text = "角色名(&R):";
            // 
            // txtRole
            // 
            this.txtRole.Location = new System.Drawing.Point(88, 15);
            this.txtRole.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtRole.Name = "txtRole";
            this.txtRole.Size = new System.Drawing.Size(143, 25);
            this.txtRole.TabIndex = 3;
            this.txtRole.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtRole_KeyPress);
            // 
            // splitterControl
            // 
            this.splitterControl.Location = new System.Drawing.Point(339, 0);
            this.splitterControl.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.splitterControl.Name = "splitterControl";
            this.splitterControl.Size = new System.Drawing.Size(6, 620);
            this.splitterControl.TabIndex = 2;
            this.splitterControl.TabStop = false;
            // 
            // gpcRight
            // 
            this.gpcRight.Controls.Add(this.treeMenu);
            this.gpcRight.Controls.Add(this.pnlRight);
            this.gpcRight.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gpcRight.Location = new System.Drawing.Point(345, 0);
            this.gpcRight.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.gpcRight.Name = "gpcRight";
            this.gpcRight.Size = new System.Drawing.Size(585, 620);
            this.gpcRight.TabIndex = 3;
            this.gpcRight.Text = "菜单列表";
            // 
            // treeMenu
            // 
            this.treeMenu.Appearance.EvenRow.BackColor = System.Drawing.Color.WhiteSmoke;
            this.treeMenu.Appearance.EvenRow.Options.UseBackColor = true;
            this.treeMenu.Appearance.FocusedCell.BackColor = System.Drawing.Color.Aqua;
            this.treeMenu.Appearance.FocusedCell.Options.UseBackColor = true;
            this.treeMenu.Appearance.FocusedRow.BackColor = System.Drawing.Color.Beige;
            this.treeMenu.Appearance.FocusedRow.ForeColor = System.Drawing.Color.Black;
            this.treeMenu.Appearance.FocusedRow.Options.UseBackColor = true;
            this.treeMenu.Appearance.FocusedRow.Options.UseForeColor = true;
            this.treeMenu.Dock = System.Windows.Forms.DockStyle.Fill;
            this.treeMenu.Location = new System.Drawing.Point(2, 81);
            this.treeMenu.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.treeMenu.Name = "treeMenu";
            this.treeMenu.OptionsBehavior.AllowIndeterminateCheckState = true;
            this.treeMenu.OptionsBehavior.Editable = false;
            this.treeMenu.OptionsView.EnableAppearanceEvenRow = true;
            this.treeMenu.OptionsView.ShowCheckBoxes = true;
            this.treeMenu.OptionsView.ShowIndicator = false;
            this.treeMenu.RepositoryItems.AddRange(new DevExpress.XtraEditors.Repository.RepositoryItem[] {
            this.repositoryItemCheckEdit1});
            this.treeMenu.Size = new System.Drawing.Size(581, 537);
            this.treeMenu.TabIndex = 1;
            this.treeMenu.BeforeCheckNode += new DevExpress.XtraTreeList.CheckNodeEventHandler(this.treeMenu_BeforeCheckNode);
            this.treeMenu.AfterCheckNode += new DevExpress.XtraTreeList.NodeEventHandler(this.treeMenu_AfterCheckNode);
            // 
            // repositoryItemCheckEdit1
            // 
            this.repositoryItemCheckEdit1.AutoHeight = false;
            this.repositoryItemCheckEdit1.Name = "repositoryItemCheckEdit1";
            // 
            // pnlRight
            // 
            this.pnlRight.Controls.Add(this.chkCheck);
            this.pnlRight.Controls.Add(this.btnSave);
            this.pnlRight.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlRight.Location = new System.Drawing.Point(2, 27);
            this.pnlRight.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.pnlRight.Name = "pnlRight";
            this.pnlRight.Size = new System.Drawing.Size(581, 54);
            this.pnlRight.TabIndex = 0;
            // 
            // chkCheck
            // 
            this.chkCheck.Location = new System.Drawing.Point(1, 14);
            this.chkCheck.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.chkCheck.Name = "chkCheck";
            this.chkCheck.Properties.Caption = "全选";
            this.chkCheck.Size = new System.Drawing.Size(66, 23);
            this.chkCheck.TabIndex = 7;
            this.chkCheck.CheckedChanged += new System.EventHandler(this.chkCheck_CheckedChanged);
            // 
            // btnSave
            // 
            this.btnSave.Location = new System.Drawing.Point(74, 13);
            this.btnSave.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(91, 30);
            this.btnSave.TabIndex = 6;
            this.btnSave.Text = "保存(&S)";
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // FrmBrowseAuthority
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 18F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(930, 620);
            this.Controls.Add(this.gpcRight);
            this.Controls.Add(this.splitterControl);
            this.Controls.Add(this.gpcLeft);
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Name = "FrmBrowseAuthority";
            this.Text = "FrmBrowseAuthority";
            this.Load += new System.EventHandler(this.FrmBrowseAuthority_Load);
            ((System.ComponentModel.ISupportInitialize)(this.gpcLeft)).EndInit();
            this.gpcLeft.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.lbcRole)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pnlLeft)).EndInit();
            this.pnlLeft.ResumeLayout(false);
            this.pnlLeft.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.txtRole.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gpcRight)).EndInit();
            this.gpcRight.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.treeMenu)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemCheckEdit1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pnlRight)).EndInit();
            this.pnlRight.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.chkCheck.Properties)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraEditors.GroupControl gpcLeft;
        private DevExpress.XtraEditors.ListBoxControl lbcRole;
        private DevExpress.XtraEditors.PanelControl pnlLeft;
        private DevExpress.XtraEditors.SimpleButton btnQuery;
        private DevExpress.XtraEditors.LabelControl lblRoleName;
        private DevExpress.XtraEditors.TextEdit txtRole;
        private DevExpress.XtraEditors.SplitterControl splitterControl;
        private DevExpress.XtraEditors.GroupControl gpcRight;
        private DevExpress.XtraTreeList.TreeList treeMenu;
        private DevExpress.XtraEditors.PanelControl pnlRight;
        private DevExpress.XtraEditors.CheckEdit chkCheck;
        private DevExpress.XtraEditors.SimpleButton btnSave;
        private DevExpress.XtraEditors.Repository.RepositoryItemCheckEdit repositoryItemCheckEdit1;
    }
}