namespace DQS.AppViews.Operation.BackManager
{
    partial class FrmReviewRecordQuery
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
            this.pnlTop = new DevExpress.XtraEditors.PanelControl();
            this.layControl = new DevExpress.XtraLayout.LayoutControl();
            this.txtDealerName = new DQS.Controls.TextBoxPopupEx();
            this.txtBillCode = new DQS.Controls.TextBoxPopupMultipleEx();
            this.txtBatchNo = new DQS.Controls.TextBoxEx();
            this.txtProductName = new DQS.Controls.TextBoxEx();
            this.layoutControlGroup1 = new DevExpress.XtraLayout.LayoutControlGroup();
            this.layoutControlItem2 = new DevExpress.XtraLayout.LayoutControlItem();
            this.layoutControlItem5 = new DevExpress.XtraLayout.LayoutControlItem();
            this.复核单号 = new DevExpress.XtraLayout.LayoutControlItem();
            this.layoutControlItem1 = new DevExpress.XtraLayout.LayoutControlItem();
            this.panelControl1 = new DevExpress.XtraEditors.PanelControl();
            this.btnSelect = new DevExpress.XtraEditors.SimpleButton();
            this.btnSearch = new DevExpress.XtraEditors.SimpleButton();
            this.gpcTop = new DevExpress.XtraEditors.GroupControl();
            this.gvBill = new DQS.Controls.StandardGrid();
            this.gpcCenter = new DevExpress.XtraEditors.GroupControl();
            this.gvDetails = new DQS.Controls.StandardGrid();
            ((System.ComponentModel.ISupportInitialize)(this.pnlTop)).BeginInit();
            this.pnlTop.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.layControl)).BeginInit();
            this.layControl.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.txtDealerName.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtBillCode.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtBatchNo.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtProductName.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlGroup1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem5)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.复核单号)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.panelControl1)).BeginInit();
            this.panelControl1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gpcTop)).BeginInit();
            this.gpcTop.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gvBill)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gpcCenter)).BeginInit();
            this.gpcCenter.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gvDetails)).BeginInit();
            this.SuspendLayout();
            // 
            // pnlTop
            // 
            this.pnlTop.Controls.Add(this.layControl);
            this.pnlTop.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlTop.Location = new System.Drawing.Point(2, 2);
            this.pnlTop.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.pnlTop.Name = "pnlTop";
            this.pnlTop.Size = new System.Drawing.Size(1002, 87);
            this.pnlTop.TabIndex = 0;
            // 
            // layControl
            // 
            this.layControl.Controls.Add(this.txtDealerName);
            this.layControl.Controls.Add(this.txtBillCode);
            this.layControl.Controls.Add(this.txtBatchNo);
            this.layControl.Controls.Add(this.txtProductName);
            this.layControl.Dock = System.Windows.Forms.DockStyle.Fill;
            this.layControl.Location = new System.Drawing.Point(2, 2);
            this.layControl.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.layControl.Name = "layControl";
            this.layControl.Root = this.layoutControlGroup1;
            this.layControl.Size = new System.Drawing.Size(998, 83);
            this.layControl.TabIndex = 0;
            this.layControl.Text = "layoutControl1";
            // 
            // txtDealerName
            // 
            this.txtDealerName.AlphabeticFiled = "DealerSpell";
            this.txtDealerName.EditData = null;
            this.txtDealerName.Fields = "单位ID,单位编号,单位名称,单位名称Spell,单位类型,通讯地址";
            this.txtDealerName.Filter = "[状态] is  null or [状态] = \'正常\'";
            this.txtDealerName.FormatQueryString = "[单位编号] LIKE \'%{0}%\' OR ([单位名称] LIKE \'%{0}%\' OR [单位名称Spell] LIKE \'%{0}%\')";
            this.txtDealerName.GroupColumn = null;
            this.txtDealerName.IsIntegerOnly = false;
            this.txtDealerName.IsNullString = "单位名称不能为空。";
            this.txtDealerName.IsNullValidate = true;
            this.txtDealerName.IsTransferAlphabetic = true;
            this.txtDealerName.Location = new System.Drawing.Point(75, 12);
            this.txtDealerName.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtDealerName.MemberText = "单位名称";
            this.txtDealerName.MemberValue = "单位ID";
            this.txtDealerName.Name = "txtDealerName";
            this.txtDealerName.PageSize = 0;
            this.txtDealerName.PrimaryField = "单位ID";
            this.txtDealerName.Properties.Appearance.BackColor = System.Drawing.Color.White;
            this.txtDealerName.Properties.Appearance.Options.UseBackColor = true;
            this.txtDealerName.Properties.ReadOnly = true;
            this.txtDealerName.Size = new System.Drawing.Size(421, 25);
            this.txtDealerName.StyleController = this.layControl;
            this.txtDealerName.TabIndex = 3;
            this.txtDealerName.ViewName = "vw_AllDealer";
            // 
            // txtBillCode
            // 
            this.txtBillCode.AlphabeticFiled = "";
            this.txtBillCode.EditData = null;
            this.txtBillCode.Fields = "";
            this.txtBillCode.Filter = "[状态] = \'已复核\'";
            this.txtBillCode.FormatQueryString = "[订单编号] LIKE \'%{0}%\'";
            this.txtBillCode.GroupColumn = null;
            this.txtBillCode.IsIntegerOnly = false;
            this.txtBillCode.IsNullString = "订单编号不能为空。";
            this.txtBillCode.IsNullValidate = true;
            this.txtBillCode.IsTransferAlphabetic = false;
            this.txtBillCode.Location = new System.Drawing.Point(563, 12);
            this.txtBillCode.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtBillCode.MemberText = "订单编号";
            this.txtBillCode.MemberValue = "订单ID";
            this.txtBillCode.Name = "txtBillCode";
            this.txtBillCode.PageSize = 0;
            this.txtBillCode.PrimaryField = "订单ID";
            this.txtBillCode.Properties.Appearance.BackColor = System.Drawing.Color.White;
            this.txtBillCode.Properties.Appearance.Options.UseBackColor = true;
            this.txtBillCode.Properties.ReadOnly = true;
            this.txtBillCode.Size = new System.Drawing.Size(423, 25);
            this.txtBillCode.StyleController = this.layControl;
            this.txtBillCode.TabIndex = 6;
            this.txtBillCode.ViewName = "vw_AllWarehouseOutBill";
            // 
            // txtBatchNo
            // 
            this.txtBatchNo.AlphabeticFiled = null;
            this.txtBatchNo.IsIntegerOnly = false;
            this.txtBatchNo.IsNullString = null;
            this.txtBatchNo.IsNullValidate = false;
            this.txtBatchNo.IsTransferAlphabetic = false;
            this.txtBatchNo.Location = new System.Drawing.Point(563, 41);
            this.txtBatchNo.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtBatchNo.Name = "txtBatchNo";
            this.txtBatchNo.Size = new System.Drawing.Size(423, 25);
            this.txtBatchNo.StyleController = this.layControl;
            this.txtBatchNo.TabIndex = 8;
            // 
            // txtProductName
            // 
            this.txtProductName.AlphabeticFiled = null;
            this.txtProductName.IsIntegerOnly = false;
            this.txtProductName.IsNullString = null;
            this.txtProductName.IsNullValidate = false;
            this.txtProductName.IsTransferAlphabetic = false;
            this.txtProductName.Location = new System.Drawing.Point(75, 41);
            this.txtProductName.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtProductName.Name = "txtProductName";
            this.txtProductName.Size = new System.Drawing.Size(421, 25);
            this.txtProductName.StyleController = this.layControl;
            this.txtProductName.TabIndex = 5;
            // 
            // layoutControlGroup1
            // 
            this.layoutControlGroup1.CustomizationFormText = "出库复核记录";
            this.layoutControlGroup1.EnableIndentsWithoutBorders = DevExpress.Utils.DefaultBoolean.True;
            this.layoutControlGroup1.GroupBordersVisible = false;
            this.layoutControlGroup1.Items.AddRange(new DevExpress.XtraLayout.BaseLayoutItem[] {
            this.layoutControlItem2,
            this.layoutControlItem5,
            this.复核单号,
            this.layoutControlItem1});
            this.layoutControlGroup1.Location = new System.Drawing.Point(0, 0);
            this.layoutControlGroup1.Name = "layoutControlGroup1";
            this.layoutControlGroup1.Size = new System.Drawing.Size(998, 83);
            this.layoutControlGroup1.Spacing = new DevExpress.XtraLayout.Utils.Padding(0, 0, 0, 0);
            this.layoutControlGroup1.Text = "出库复核记录";
            this.layoutControlGroup1.TextVisible = false;
            // 
            // layoutControlItem2
            // 
            this.layoutControlItem2.Control = this.txtProductName;
            this.layoutControlItem2.CustomizationFormText = "药品名称";
            this.layoutControlItem2.Location = new System.Drawing.Point(0, 29);
            this.layoutControlItem2.Name = "layoutControlItem2";
            this.layoutControlItem2.Size = new System.Drawing.Size(488, 34);
            this.layoutControlItem2.Text = "药品名称";
            this.layoutControlItem2.TextSize = new System.Drawing.Size(60, 18);
            // 
            // layoutControlItem5
            // 
            this.layoutControlItem5.Control = this.txtBatchNo;
            this.layoutControlItem5.CustomizationFormText = "批号";
            this.layoutControlItem5.Location = new System.Drawing.Point(488, 29);
            this.layoutControlItem5.Name = "layoutControlItem5";
            this.layoutControlItem5.Size = new System.Drawing.Size(490, 34);
            this.layoutControlItem5.Text = "批号";
            this.layoutControlItem5.TextSize = new System.Drawing.Size(60, 18);
            // 
            // 复核单号
            // 
            this.复核单号.Control = this.txtBillCode;
            this.复核单号.CustomizationFormText = "复核单号";
            this.复核单号.Location = new System.Drawing.Point(488, 0);
            this.复核单号.Name = "复核单号";
            this.复核单号.Size = new System.Drawing.Size(490, 29);
            this.复核单号.Text = "复核单号";
            this.复核单号.TextSize = new System.Drawing.Size(60, 18);
            // 
            // layoutControlItem1
            // 
            this.layoutControlItem1.Control = this.txtDealerName;
            this.layoutControlItem1.CustomizationFormText = "往来单位";
            this.layoutControlItem1.Location = new System.Drawing.Point(0, 0);
            this.layoutControlItem1.Name = "layoutControlItem1";
            this.layoutControlItem1.Size = new System.Drawing.Size(488, 29);
            this.layoutControlItem1.Text = "往来单位";
            this.layoutControlItem1.TextSize = new System.Drawing.Size(60, 18);
            // 
            // panelControl1
            // 
            this.panelControl1.ContentImageAlignment = System.Drawing.ContentAlignment.MiddleLeft;
            this.panelControl1.Controls.Add(this.btnSelect);
            this.panelControl1.Controls.Add(this.pnlTop);
            this.panelControl1.Controls.Add(this.btnSearch);
            this.panelControl1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelControl1.Location = new System.Drawing.Point(0, 0);
            this.panelControl1.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.panelControl1.Name = "panelControl1";
            this.panelControl1.Size = new System.Drawing.Size(1006, 141);
            this.panelControl1.TabIndex = 6;
            // 
            // btnSelect
            // 
            this.btnSelect.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnSelect.Appearance.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSelect.Appearance.Options.UseFont = true;
            this.btnSelect.Location = new System.Drawing.Point(862, 103);
            this.btnSelect.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnSelect.Name = "btnSelect";
            this.btnSelect.Size = new System.Drawing.Size(132, 27);
            this.btnSelect.TabIndex = 5;
            this.btnSelect.Text = "选择(&C)";
            // 
            // btnSearch
            // 
            this.btnSearch.Appearance.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSearch.Appearance.Options.UseFont = true;
            this.btnSearch.Location = new System.Drawing.Point(8, 103);
            this.btnSearch.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnSearch.Name = "btnSearch";
            this.btnSearch.Size = new System.Drawing.Size(119, 27);
            this.btnSearch.TabIndex = 4;
            this.btnSearch.Text = "查询复核记录(&F)";
            // 
            // gpcTop
            // 
            this.gpcTop.Controls.Add(this.gvBill);
            this.gpcTop.Dock = System.Windows.Forms.DockStyle.Top;
            this.gpcTop.Location = new System.Drawing.Point(0, 141);
            this.gpcTop.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.gpcTop.Name = "gpcTop";
            this.gpcTop.Size = new System.Drawing.Size(1006, 180);
            this.gpcTop.TabIndex = 1;
            this.gpcTop.Text = "记录单据";
            // 
            // gvBill
            // 
            this.gvBill.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gvBill.EmbeddedNavigator.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.gvBill.Filter = null;
            this.gvBill.Location = new System.Drawing.Point(2, 27);
            this.gvBill.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.gvBill.Name = "gvBill";
            this.gvBill.Size = new System.Drawing.Size(1002, 151);
            this.gvBill.TabIndex = 0;
            this.gvBill.ViewName = null;
            // 
            // gpcCenter
            // 
            this.gpcCenter.Controls.Add(this.gvDetails);
            this.gpcCenter.Dock = System.Windows.Forms.DockStyle.Top;
            this.gpcCenter.Location = new System.Drawing.Point(0, 321);
            this.gpcCenter.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.gpcCenter.Name = "gpcCenter";
            this.gpcCenter.Size = new System.Drawing.Size(1006, 449);
            this.gpcCenter.TabIndex = 2;
            this.gpcCenter.Text = "记录明细";
            // 
            // gvDetails
            // 
            this.gvDetails.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gvDetails.EmbeddedNavigator.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.gvDetails.Filter = null;
            this.gvDetails.Location = new System.Drawing.Point(2, 27);
            this.gvDetails.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.gvDetails.Name = "gvDetails";
            this.gvDetails.Size = new System.Drawing.Size(1002, 420);
            this.gvDetails.TabIndex = 0;
            this.gvDetails.ViewName = null;
            this.gvDetails.DoubleClick += new System.EventHandler(this.gvDetails_DoubleClick);
            // 
            // FrmReviewRecordQuery
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 18F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1006, 722);
            this.Controls.Add(this.gpcCenter);
            this.Controls.Add(this.gpcTop);
            this.Controls.Add(this.panelControl1);
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Name = "FrmReviewRecordQuery";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "出库复核记录";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.FrmReviewRecordQuery_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pnlTop)).EndInit();
            this.pnlTop.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.layControl)).EndInit();
            this.layControl.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.txtDealerName.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtBillCode.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtBatchNo.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtProductName.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlGroup1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem5)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.复核单号)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.panelControl1)).EndInit();
            this.panelControl1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.gpcTop)).EndInit();
            this.gpcTop.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.gvBill)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gpcCenter)).EndInit();
            this.gpcCenter.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.gvDetails)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraEditors.PanelControl pnlTop;
        private DevExpress.XtraEditors.GroupControl gpcTop;
        private DevExpress.XtraEditors.GroupControl gpcCenter;
        private DQS.Controls.StandardGrid gvBill;
        private DQS.Controls.StandardGrid gvDetails;
        private DevExpress.XtraLayout.LayoutControl layControl;
        private DQS.Controls.TextBoxEx txtProductName;
        private DevExpress.XtraLayout.LayoutControlGroup layoutControlGroup1;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlItem2;
        private DQS.Controls.TextBoxEx txtBatchNo;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlItem5;
        private DevExpress.XtraEditors.PanelControl panelControl1;
        private DevExpress.XtraEditors.SimpleButton btnSelect;
        private DevExpress.XtraEditors.SimpleButton btnSearch;
        private Controls.TextBoxPopupMultipleEx txtBillCode;
        private DevExpress.XtraLayout.LayoutControlItem 复核单号;
        private Controls.TextBoxPopupEx txtDealerName;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlItem1;
    }
}