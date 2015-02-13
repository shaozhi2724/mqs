namespace DQS.AppViews.QualityDocument.EnterpriseManager
{
    partial class FrmEnterpriseRange
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
            this.groupControl1 = new DevExpress.XtraEditors.GroupControl();
            this.lbcEnterprise = new DevExpress.XtraEditors.ListBoxControl();
            this.panelControl1 = new DevExpress.XtraEditors.PanelControl();
            this.btnQuery = new DevExpress.XtraEditors.SimpleButton();
            this.labelControl1 = new DevExpress.XtraEditors.LabelControl();
            this.textEdit1 = new DevExpress.XtraEditors.TextEdit();
            this.splitterControl1 = new DevExpress.XtraEditors.SplitterControl();
            this.groupControl2 = new DevExpress.XtraEditors.GroupControl();
            this.chklbcProductStyle = new DevExpress.XtraEditors.CheckedListBoxControl();
            this.panelControl2 = new DevExpress.XtraEditors.PanelControl();
            this.chkCheck = new DevExpress.XtraEditors.CheckEdit();
            this.btnSave = new DevExpress.XtraEditors.SimpleButton();
            ((System.ComponentModel.ISupportInitialize)(this.groupControl1)).BeginInit();
            this.groupControl1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.lbcEnterprise)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.panelControl1)).BeginInit();
            this.panelControl1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.textEdit1.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.groupControl2)).BeginInit();
            this.groupControl2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.chklbcProductStyle)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.panelControl2)).BeginInit();
            this.panelControl2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.chkCheck.Properties)).BeginInit();
            this.SuspendLayout();
            // 
            // groupControl1
            // 
            this.groupControl1.Controls.Add(this.lbcEnterprise);
            this.groupControl1.Controls.Add(this.panelControl1);
            this.groupControl1.Dock = System.Windows.Forms.DockStyle.Left;
            this.groupControl1.Location = new System.Drawing.Point(0, 0);
            this.groupControl1.Name = "groupControl1";
            this.groupControl1.Size = new System.Drawing.Size(297, 482);
            this.groupControl1.TabIndex = 2;
            this.groupControl1.Text = "企业列表";
            // 
            // lbcEnterprise
            // 
            this.lbcEnterprise.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lbcEnterprise.HighlightedItemStyle = DevExpress.XtraEditors.HighlightStyle.Skinned;
            this.lbcEnterprise.Location = new System.Drawing.Point(2, 65);
            this.lbcEnterprise.Name = "lbcEnterprise";
            this.lbcEnterprise.SelectionMode = System.Windows.Forms.SelectionMode.MultiExtended;
            this.lbcEnterprise.Size = new System.Drawing.Size(293, 415);
            this.lbcEnterprise.TabIndex = 1;
            // 
            // panelControl1
            // 
            this.panelControl1.Controls.Add(this.btnQuery);
            this.panelControl1.Controls.Add(this.labelControl1);
            this.panelControl1.Controls.Add(this.textEdit1);
            this.panelControl1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelControl1.Location = new System.Drawing.Point(2, 23);
            this.panelControl1.Name = "panelControl1";
            this.panelControl1.Size = new System.Drawing.Size(293, 42);
            this.panelControl1.TabIndex = 0;
            this.panelControl1.Visible = false;
            // 
            // btnQuery
            // 
            this.btnQuery.Location = new System.Drawing.Point(208, 10);
            this.btnQuery.Name = "btnQuery";
            this.btnQuery.Size = new System.Drawing.Size(80, 23);
            this.btnQuery.TabIndex = 5;
            this.btnQuery.Text = "快速查询";
            // 
            // labelControl1
            // 
            this.labelControl1.Location = new System.Drawing.Point(10, 15);
            this.labelControl1.Name = "labelControl1";
            this.labelControl1.Size = new System.Drawing.Size(46, 14);
            this.labelControl1.TabIndex = 4;
            this.labelControl1.Text = "名称(&N):";
            // 
            // textEdit1
            // 
            this.textEdit1.Location = new System.Drawing.Point(77, 12);
            this.textEdit1.Name = "textEdit1";
            this.textEdit1.Size = new System.Drawing.Size(125, 21);
            this.textEdit1.TabIndex = 3;
            // 
            // splitterControl1
            // 
            this.splitterControl1.Location = new System.Drawing.Point(297, 0);
            this.splitterControl1.Name = "splitterControl1";
            this.splitterControl1.Size = new System.Drawing.Size(6, 482);
            this.splitterControl1.TabIndex = 3;
            this.splitterControl1.TabStop = false;
            // 
            // groupControl2
            // 
            this.groupControl2.Controls.Add(this.chklbcProductStyle);
            this.groupControl2.Controls.Add(this.panelControl2);
            this.groupControl2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupControl2.Location = new System.Drawing.Point(303, 0);
            this.groupControl2.Name = "groupControl2";
            this.groupControl2.Size = new System.Drawing.Size(511, 482);
            this.groupControl2.TabIndex = 4;
            this.groupControl2.Text = "药品类别清单";
            // 
            // chklbcProductStyle
            // 
            this.chklbcProductStyle.CheckOnClick = true;
            this.chklbcProductStyle.ColumnWidth = 200;
            this.chklbcProductStyle.Dock = System.Windows.Forms.DockStyle.Fill;
            this.chklbcProductStyle.HighlightedItemStyle = DevExpress.XtraEditors.HighlightStyle.Skinned;
            this.chklbcProductStyle.Location = new System.Drawing.Point(2, 65);
            this.chklbcProductStyle.MultiColumn = true;
            this.chklbcProductStyle.Name = "chklbcProductStyle";
            this.chklbcProductStyle.Size = new System.Drawing.Size(507, 415);
            this.chklbcProductStyle.TabIndex = 1;
            // 
            // panelControl2
            // 
            this.panelControl2.Controls.Add(this.chkCheck);
            this.panelControl2.Controls.Add(this.btnSave);
            this.panelControl2.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelControl2.Location = new System.Drawing.Point(2, 23);
            this.panelControl2.Name = "panelControl2";
            this.panelControl2.Size = new System.Drawing.Size(507, 42);
            this.panelControl2.TabIndex = 0;
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
            // FrmEnterpriseRange
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 14F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(814, 482);
            this.Controls.Add(this.groupControl2);
            this.Controls.Add(this.splitterControl1);
            this.Controls.Add(this.groupControl1);
            this.Name = "FrmEnterpriseRange";
            this.Text = "FrmEnterpriseRange";
            this.Load += new System.EventHandler(this.FrmEnterpriseRange_Load);
            ((System.ComponentModel.ISupportInitialize)(this.groupControl1)).EndInit();
            this.groupControl1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.lbcEnterprise)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.panelControl1)).EndInit();
            this.panelControl1.ResumeLayout(false);
            this.panelControl1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.textEdit1.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.groupControl2)).EndInit();
            this.groupControl2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.chklbcProductStyle)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.panelControl2)).EndInit();
            this.panelControl2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.chkCheck.Properties)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraEditors.GroupControl groupControl1;
        private DevExpress.XtraEditors.ListBoxControl lbcEnterprise;
        private DevExpress.XtraEditors.PanelControl panelControl1;
        private DevExpress.XtraEditors.SimpleButton btnQuery;
        private DevExpress.XtraEditors.LabelControl labelControl1;
        private DevExpress.XtraEditors.TextEdit textEdit1;
        private DevExpress.XtraEditors.SplitterControl splitterControl1;
        private DevExpress.XtraEditors.GroupControl groupControl2;
        private DevExpress.XtraEditors.CheckedListBoxControl chklbcProductStyle;
        private DevExpress.XtraEditors.PanelControl panelControl2;
        private DevExpress.XtraEditors.CheckEdit chkCheck;
        private DevExpress.XtraEditors.SimpleButton btnSave;
    }
}