namespace DQS.AppViews.QualityDocument.ProviderManager
{
    partial class FrmProviderRange
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
            this.lbcDealer = new DevExpress.XtraEditors.ListBoxControl();
            this.pnlLeftTop = new DevExpress.XtraEditors.PanelControl();
            this.btnQuery = new DevExpress.XtraEditors.SimpleButton();
            this.lblDealerName = new DevExpress.XtraEditors.LabelControl();
            this.txtDealerName = new DQS.Controls.TextBoxEx();
            this.splitterControl = new DevExpress.XtraEditors.SplitterControl();
            this.gpcRight = new DevExpress.XtraEditors.GroupControl();
            this.chklbcProductStyle = new DevExpress.XtraEditors.CheckedListBoxControl();
            this.pnlRightTop = new DevExpress.XtraEditors.PanelControl();
            this.chkCheck = new DevExpress.XtraEditors.CheckEdit();
            this.btnSave = new DevExpress.XtraEditors.SimpleButton();
            ((System.ComponentModel.ISupportInitialize)(this.gpcLeft)).BeginInit();
            this.gpcLeft.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.lbcDealer)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pnlLeftTop)).BeginInit();
            this.pnlLeftTop.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.txtDealerName.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gpcRight)).BeginInit();
            this.gpcRight.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.chklbcProductStyle)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pnlRightTop)).BeginInit();
            this.pnlRightTop.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.chkCheck.Properties)).BeginInit();
            this.SuspendLayout();
            // 
            // gpcLeft
            // 
            this.gpcLeft.Controls.Add(this.lbcDealer);
            this.gpcLeft.Controls.Add(this.pnlLeftTop);
            this.gpcLeft.Dock = System.Windows.Forms.DockStyle.Left;
            this.gpcLeft.Location = new System.Drawing.Point(0, 0);
            this.gpcLeft.Name = "gpcLeft";
            this.gpcLeft.Size = new System.Drawing.Size(297, 482);
            this.gpcLeft.TabIndex = 1;
            this.gpcLeft.Text = "往来单位列表";
            // 
            // lbcDealer
            // 
            this.lbcDealer.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lbcDealer.HighlightedItemStyle = DevExpress.XtraEditors.HighlightStyle.Skinned;
            this.lbcDealer.Location = new System.Drawing.Point(2, 65);
            this.lbcDealer.Name = "lbcDealer";
            this.lbcDealer.SelectionMode = System.Windows.Forms.SelectionMode.MultiExtended;
            this.lbcDealer.Size = new System.Drawing.Size(293, 415);
            this.lbcDealer.TabIndex = 1;
            this.lbcDealer.SelectedIndexChanged += new System.EventHandler(this.lbcDealer_SelectedIndexChanged);
            // 
            // pnlLeftTop
            // 
            this.pnlLeftTop.Controls.Add(this.btnQuery);
            this.pnlLeftTop.Controls.Add(this.lblDealerName);
            this.pnlLeftTop.Controls.Add(this.txtDealerName);
            this.pnlLeftTop.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlLeftTop.Location = new System.Drawing.Point(2, 23);
            this.pnlLeftTop.Name = "pnlLeftTop";
            this.pnlLeftTop.Size = new System.Drawing.Size(293, 42);
            this.pnlLeftTop.TabIndex = 0;
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
            // lblDealerName
            // 
            this.lblDealerName.Location = new System.Drawing.Point(10, 15);
            this.lblDealerName.Name = "lblDealerName";
            this.lblDealerName.Size = new System.Drawing.Size(46, 14);
            this.lblDealerName.TabIndex = 4;
            this.lblDealerName.Text = "名称(&N):";
            // 
            // txtDealerName
            // 
            this.txtDealerName.AlphabeticFiled = null;
            this.txtDealerName.IsIntegerOnly = false;
            this.txtDealerName.IsNullString = null;
            this.txtDealerName.IsNullValidate = false;
            this.txtDealerName.IsTransferAlphabetic = false;
            this.txtDealerName.Location = new System.Drawing.Point(77, 12);
            this.txtDealerName.Name = "txtDealerName";
            this.txtDealerName.Size = new System.Drawing.Size(125, 21);
            this.txtDealerName.TabIndex = 3;
            this.txtDealerName.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtDealerName_KeyPress);
            // 
            // splitterControl
            // 
            this.splitterControl.Location = new System.Drawing.Point(297, 0);
            this.splitterControl.Name = "splitterControl";
            this.splitterControl.Size = new System.Drawing.Size(6, 482);
            this.splitterControl.TabIndex = 2;
            this.splitterControl.TabStop = false;
            // 
            // gpcRight
            // 
            this.gpcRight.Controls.Add(this.chklbcProductStyle);
            this.gpcRight.Controls.Add(this.pnlRightTop);
            this.gpcRight.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gpcRight.Location = new System.Drawing.Point(303, 0);
            this.gpcRight.Name = "gpcRight";
            this.gpcRight.Size = new System.Drawing.Size(511, 482);
            this.gpcRight.TabIndex = 3;
            this.gpcRight.Text = "产品类别清单";
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
            // FrmDealerRange
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 14F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(814, 482);
            this.Controls.Add(this.gpcRight);
            this.Controls.Add(this.splitterControl);
            this.Controls.Add(this.gpcLeft);
            this.Name = "FrmProviderRange";
            this.Text = "FrmProviderRange";
            this.Load += new System.EventHandler(this.FrmProviderRange_Load);
            ((System.ComponentModel.ISupportInitialize)(this.gpcLeft)).EndInit();
            this.gpcLeft.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.lbcDealer)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pnlLeftTop)).EndInit();
            this.pnlLeftTop.ResumeLayout(false);
            this.pnlLeftTop.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.txtDealerName.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gpcRight)).EndInit();
            this.gpcRight.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.chklbcProductStyle)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pnlRightTop)).EndInit();
            this.pnlRightTop.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.chkCheck.Properties)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraEditors.GroupControl gpcLeft;
        private DevExpress.XtraEditors.ListBoxControl lbcDealer;
        private DevExpress.XtraEditors.PanelControl pnlLeftTop;
        private DevExpress.XtraEditors.SimpleButton btnQuery;
        private DevExpress.XtraEditors.LabelControl lblDealerName;
        private DQS.Controls.TextBoxEx txtDealerName;
        private DevExpress.XtraEditors.SplitterControl splitterControl;
        private DevExpress.XtraEditors.GroupControl gpcRight;
        private DevExpress.XtraEditors.CheckedListBoxControl chklbcProductStyle;
        private DevExpress.XtraEditors.PanelControl pnlRightTop;
        private DevExpress.XtraEditors.CheckEdit chkCheck;
        private DevExpress.XtraEditors.SimpleButton btnSave;
    }
}