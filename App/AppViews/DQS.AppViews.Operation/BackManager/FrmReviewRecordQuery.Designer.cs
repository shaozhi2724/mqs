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
            this.txtBillCode = new DQS.Controls.TextBoxPopupEx();
            this.txtBatchNo = new DQS.Controls.TextBoxEx();
            this.txtProductName = new DQS.Controls.TextBoxPopupEx();
            this.layoutControlGroup1 = new DevExpress.XtraLayout.LayoutControlGroup();
            this.复核单号 = new DevExpress.XtraLayout.LayoutControlItem();
            this.layoutControlItem1 = new DevExpress.XtraLayout.LayoutControlItem();
            this.layoutControlItem2 = new DevExpress.XtraLayout.LayoutControlItem();
            this.layoutControlItem5 = new DevExpress.XtraLayout.LayoutControlItem();
            this.panelControl1 = new DevExpress.XtraEditors.PanelControl();
            this.btnSelect = new DevExpress.XtraEditors.SimpleButton();
            this.btnSearch = new DevExpress.XtraEditors.SimpleButton();
            this.gpcTop = new DevExpress.XtraEditors.GroupControl();
            this.gvBill = new DQS.Controls.StandardGrid();
            this.gpcCenter = new DevExpress.XtraEditors.GroupControl();
            this.gvDetails = new DevExpress.XtraGrid.GridControl();
            this.gvData = new DevExpress.XtraGrid.Views.Grid.GridView();
            ((System.ComponentModel.ISupportInitialize)(this.pnlTop)).BeginInit();
            this.pnlTop.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.layControl)).BeginInit();
            this.layControl.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.txtDealerName.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtBillCode.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtBatchNo.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtProductName.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlGroup1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.复核单号)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem5)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.panelControl1)).BeginInit();
            this.panelControl1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gpcTop)).BeginInit();
            this.gpcTop.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gvBill)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gpcCenter)).BeginInit();
            this.gpcCenter.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gvDetails)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gvData)).BeginInit();
            this.SuspendLayout();
            // 
            // pnlTop
            // 
            this.pnlTop.Controls.Add(this.layControl);
            this.pnlTop.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlTop.Location = new System.Drawing.Point(2, 2);
            this.pnlTop.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.pnlTop.Name = "pnlTop";
            this.pnlTop.Size = new System.Drawing.Size(1002, 55);
            this.pnlTop.TabIndex = 0;
            // 
            // layControl
            // 
            this.layControl.Controls.Add(this.txtDealerName);
            this.layControl.Controls.Add(this.txtBillCode);
            this.layControl.Controls.Add(this.txtBatchNo);
            this.layControl.Controls.Add(this.txtProductName);
            this.layControl.Dock = System.Windows.Forms.DockStyle.Fill;
            this.layControl.HiddenItems.AddRange(new DevExpress.XtraLayout.BaseLayoutItem[] {
            this.layoutControlItem5,
            this.layoutControlItem2});
            this.layControl.Location = new System.Drawing.Point(2, 2);
            this.layControl.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.layControl.Name = "layControl";
            this.layControl.Root = this.layoutControlGroup1;
            this.layControl.Size = new System.Drawing.Size(998, 51);
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
            this.txtDealerName.ViewName = "vw_AllProvider";
            this.txtDealerName.PopupClosing += new DQS.Controls.TextBoxPopupEx.OnPopupClosingDelegate(this.txtDealerName_PopupClosing);
            // 
            // txtBillCode
            // 
            this.txtBillCode.AlphabeticFiled = "";
            this.txtBillCode.EditData = null;
            this.txtBillCode.Fields = "";
            this.txtBillCode.Filter = "";
            this.txtBillCode.FormatQueryString = "[往来单位Spell] LIKE \'%{0}%\' OR [往来单位名称] LIKE \'%{0}%\'";
            this.txtBillCode.GroupColumn = null;
            this.txtBillCode.IsIntegerOnly = false;
            this.txtBillCode.IsNullString = "订单编号不能为空。";
            this.txtBillCode.IsNullValidate = true;
            this.txtBillCode.IsTransferAlphabetic = false;
            this.txtBillCode.Location = new System.Drawing.Point(563, 12);
            this.txtBillCode.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtBillCode.MemberText = "复核单号";
            this.txtBillCode.MemberValue = "复核ID";
            this.txtBillCode.Name = "txtBillCode";
            this.txtBillCode.PageSize = 0;
            this.txtBillCode.PrimaryField = "复核ID";
            this.txtBillCode.Properties.Appearance.BackColor = System.Drawing.Color.White;
            this.txtBillCode.Properties.Appearance.Options.UseBackColor = true;
            this.txtBillCode.Properties.ReadOnly = true;
            this.txtBillCode.Size = new System.Drawing.Size(423, 25);
            this.txtBillCode.StyleController = this.layControl;
            this.txtBillCode.TabIndex = 6;
            this.txtBillCode.ViewName = "vw_AllReview";
            this.txtBillCode.PopupClosing += new DQS.Controls.TextBoxPopupEx.OnPopupClosingDelegate(this.txtBillCode_PopupClosing);
            this.txtBillCode.BeforePopupShow += new DQS.Controls.TextBoxPopupEx.OnBeforePopupShowEventHandler(this.txtBillCode_BeforePopupShow);
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
            this.txtProductName.EditData = null;
            this.txtProductName.Fields = "药品ID,药品编号,药品名称,药品名称Spell,生产厂商,规格,包装规格,剂型,药品类别,批准文号";
            this.txtProductName.Filter = null;
            this.txtProductName.FormatQueryString = "[药品编号] LIKE \'%{0}%\' OR [药品名称] LIKE \'%{0}%\' OR [药品名称Spell] LIKE \'%{0}%\'";
            this.txtProductName.GroupColumn = null;
            this.txtProductName.IsIntegerOnly = false;
            this.txtProductName.IsNullString = null;
            this.txtProductName.IsNullValidate = false;
            this.txtProductName.IsTransferAlphabetic = false;
            this.txtProductName.Location = new System.Drawing.Point(75, 41);
            this.txtProductName.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtProductName.MemberText = "药品名称";
            this.txtProductName.MemberValue = "药品ID";
            this.txtProductName.Name = "txtProductName";
            this.txtProductName.PageSize = 0;
            this.txtProductName.PrimaryField = "药品ID";
            this.txtProductName.Properties.Appearance.BackColor = System.Drawing.Color.White;
            this.txtProductName.Properties.Appearance.Options.UseBackColor = true;
            this.txtProductName.Properties.ReadOnly = true;
            this.txtProductName.Size = new System.Drawing.Size(911, 25);
            this.txtProductName.StyleController = this.layControl;
            this.txtProductName.TabIndex = 5;
            this.txtProductName.ViewName = "vw_AllProduct";
            // 
            // layoutControlGroup1
            // 
            this.layoutControlGroup1.CustomizationFormText = "出库复核记录";
            this.layoutControlGroup1.EnableIndentsWithoutBorders = DevExpress.Utils.DefaultBoolean.True;
            this.layoutControlGroup1.GroupBordersVisible = false;
            this.layoutControlGroup1.Items.AddRange(new DevExpress.XtraLayout.BaseLayoutItem[] {
            this.复核单号,
            this.layoutControlItem1});
            this.layoutControlGroup1.Location = new System.Drawing.Point(0, 0);
            this.layoutControlGroup1.Name = "layoutControlGroup1";
            this.layoutControlGroup1.Size = new System.Drawing.Size(998, 51);
            this.layoutControlGroup1.Spacing = new DevExpress.XtraLayout.Utils.Padding(0, 0, 0, 0);
            this.layoutControlGroup1.Text = "出库复核记录";
            this.layoutControlGroup1.TextVisible = false;
            // 
            // 复核单号
            // 
            this.复核单号.Control = this.txtBillCode;
            this.复核单号.CustomizationFormText = "复核单号";
            this.复核单号.Location = new System.Drawing.Point(488, 0);
            this.复核单号.Name = "复核单号";
            this.复核单号.Size = new System.Drawing.Size(490, 31);
            this.复核单号.Text = "复核单号";
            this.复核单号.TextSize = new System.Drawing.Size(60, 18);
            // 
            // layoutControlItem1
            // 
            this.layoutControlItem1.Control = this.txtDealerName;
            this.layoutControlItem1.CustomizationFormText = "往来单位";
            this.layoutControlItem1.Location = new System.Drawing.Point(0, 0);
            this.layoutControlItem1.Name = "layoutControlItem1";
            this.layoutControlItem1.Size = new System.Drawing.Size(488, 31);
            this.layoutControlItem1.Text = "往来单位";
            this.layoutControlItem1.TextSize = new System.Drawing.Size(60, 18);
            // 
            // layoutControlItem2
            // 
            this.layoutControlItem2.Control = this.txtProductName;
            this.layoutControlItem2.CustomizationFormText = "药品名称";
            this.layoutControlItem2.Location = new System.Drawing.Point(0, 29);
            this.layoutControlItem2.Name = "layoutControlItem2";
            this.layoutControlItem2.Size = new System.Drawing.Size(978, 34);
            this.layoutControlItem2.Text = "药品名称";
            this.layoutControlItem2.TextSize = new System.Drawing.Size(60, 18);
            this.layoutControlItem2.TextToControlDistance = 5;
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
            this.layoutControlItem5.TextToControlDistance = 5;
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
            this.panelControl1.Size = new System.Drawing.Size(1006, 105);
            this.panelControl1.TabIndex = 6;
            // 
            // btnSelect
            // 
            this.btnSelect.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnSelect.Appearance.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSelect.Appearance.Options.UseFont = true;
            this.btnSelect.Location = new System.Drawing.Point(869, 65);
            this.btnSelect.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnSelect.Name = "btnSelect";
            this.btnSelect.Size = new System.Drawing.Size(132, 27);
            this.btnSelect.TabIndex = 5;
            this.btnSelect.Text = "选择并关闭(&S)";
            this.btnSelect.Click += new System.EventHandler(this.btnSelect_Click);
            // 
            // btnSearch
            // 
            this.btnSearch.Appearance.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSearch.Appearance.Options.UseFont = true;
            this.btnSearch.Location = new System.Drawing.Point(12, 63);
            this.btnSearch.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnSearch.Name = "btnSearch";
            this.btnSearch.Size = new System.Drawing.Size(119, 27);
            this.btnSearch.TabIndex = 4;
            this.btnSearch.Text = "查询复核记录(&F)";
            this.btnSearch.Visible = false;
            this.btnSearch.Click += new System.EventHandler(this.btnSearch_Click);
            // 
            // gpcTop
            // 
            this.gpcTop.Controls.Add(this.gvBill);
            this.gpcTop.Dock = System.Windows.Forms.DockStyle.Top;
            this.gpcTop.Location = new System.Drawing.Point(0, 105);
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
            this.gpcCenter.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gpcCenter.Location = new System.Drawing.Point(0, 285);
            this.gpcCenter.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.gpcCenter.Name = "gpcCenter";
            this.gpcCenter.Size = new System.Drawing.Size(1006, 460);
            this.gpcCenter.TabIndex = 2;
            this.gpcCenter.Text = "记录明细";
            // 
            // gvDetails
            // 
            this.gvDetails.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gvDetails.EmbeddedNavigator.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.gvDetails.Location = new System.Drawing.Point(2, 27);
            this.gvDetails.MainView = this.gvData;
            this.gvDetails.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.gvDetails.Name = "gvDetails";
            this.gvDetails.Size = new System.Drawing.Size(1002, 431);
            this.gvDetails.TabIndex = 2;
            this.gvDetails.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gvData});
            // 
            // gvData
            // 
            this.gvData.Appearance.EvenRow.BackColor = System.Drawing.Color.WhiteSmoke;
            this.gvData.Appearance.EvenRow.Options.UseBackColor = true;
            this.gvData.Appearance.HeaderPanel.Font = new System.Drawing.Font("微软雅黑", 9F);
            this.gvData.Appearance.HeaderPanel.Options.UseFont = true;
            this.gvData.FocusRectStyle = DevExpress.XtraGrid.Views.Grid.DrawFocusRectStyle.RowFocus;
            this.gvData.GridControl = this.gvDetails;
            this.gvData.IndicatorWidth = 43;
            this.gvData.Name = "gvData";
            this.gvData.OptionsBehavior.Editable = false;
            this.gvData.OptionsNavigation.EnterMoveNextColumn = true;
            this.gvData.OptionsSelection.MultiSelect = true;
            this.gvData.OptionsView.ColumnAutoWidth = false;
            this.gvData.OptionsView.EnableAppearanceEvenRow = true;
            this.gvData.OptionsView.ShowGroupPanel = false;
            // 
            // FrmReviewRecordQuery
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 18F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1006, 745);
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
            ((System.ComponentModel.ISupportInitialize)(this.复核单号)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem5)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.panelControl1)).EndInit();
            this.panelControl1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.gpcTop)).EndInit();
            this.gpcTop.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.gvBill)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gpcCenter)).EndInit();
            this.gpcCenter.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.gvDetails)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gvData)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraEditors.PanelControl pnlTop;
        private DevExpress.XtraEditors.GroupControl gpcTop;
        private DevExpress.XtraEditors.GroupControl gpcCenter;
        private DQS.Controls.StandardGrid gvBill;
        private DevExpress.XtraLayout.LayoutControl layControl;
        private DQS.Controls.TextBoxPopupEx txtProductName;
        private DevExpress.XtraLayout.LayoutControlGroup layoutControlGroup1;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlItem2;
        private DQS.Controls.TextBoxEx txtBatchNo;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlItem5;
        private DevExpress.XtraEditors.PanelControl panelControl1;
        private DevExpress.XtraEditors.SimpleButton btnSelect;
        private DevExpress.XtraEditors.SimpleButton btnSearch;
        private Controls.TextBoxPopupEx txtBillCode;
        private DevExpress.XtraLayout.LayoutControlItem 复核单号;
        private Controls.TextBoxPopupEx txtDealerName;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlItem1;
        protected DevExpress.XtraGrid.GridControl gvDetails;
        protected DevExpress.XtraGrid.Views.Grid.GridView gvData;
    }
}