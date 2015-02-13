namespace DQS.Controls
{
    partial class FrmProductPopupQuery
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
            this.btnClose = new DevExpress.XtraEditors.SimpleButton();
            this.btnQuery = new DevExpress.XtraEditors.SimpleButton();
            this.txtQuery = new DQS.Controls.TextBoxQueryEx();
            this.labelControl1 = new DevExpress.XtraEditors.LabelControl();
            this.pageNavigator = new DQS.Controls.PageNavigator();
            this.gvControl = new DevExpress.XtraGrid.GridControl();
            this.gvData = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.gridControl1 = new DevExpress.XtraGrid.GridControl();
            this.gridView1 = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.colPrice = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colSaleDate = new DevExpress.XtraGrid.Columns.GridColumn();
            this.splitterControl1 = new DevExpress.XtraEditors.SplitterControl();
            this.gpcTop = new DevExpress.XtraEditors.GroupControl();
            this.gpcBottom = new DevExpress.XtraEditors.GroupControl();
            ((System.ComponentModel.ISupportInitialize)(this.pnlTop)).BeginInit();
            this.pnlTop.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.txtQuery.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pageNavigator)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gvControl)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gvData)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridControl1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gpcTop)).BeginInit();
            this.gpcTop.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gpcBottom)).BeginInit();
            this.gpcBottom.SuspendLayout();
            this.SuspendLayout();
            // 
            // pnlTop
            // 
            this.pnlTop.Controls.Add(this.btnClose);
            this.pnlTop.Controls.Add(this.btnQuery);
            this.pnlTop.Controls.Add(this.txtQuery);
            this.pnlTop.Controls.Add(this.labelControl1);
            this.pnlTop.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlTop.Location = new System.Drawing.Point(0, 0);
            this.pnlTop.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.pnlTop.Name = "pnlTop";
            this.pnlTop.Size = new System.Drawing.Size(919, 57);
            this.pnlTop.TabIndex = 0;
            // 
            // btnClose
            // 
            this.btnClose.Appearance.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnClose.Appearance.Options.UseFont = true;
            this.btnClose.Location = new System.Drawing.Point(533, 14);
            this.btnClose.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(86, 30);
            this.btnClose.TabIndex = 99;
            this.btnClose.Text = "关闭(&C)";
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // btnQuery
            // 
            this.btnQuery.Appearance.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnQuery.Appearance.Options.UseFont = true;
            this.btnQuery.Location = new System.Drawing.Point(426, 14);
            this.btnQuery.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnQuery.Name = "btnQuery";
            this.btnQuery.Size = new System.Drawing.Size(86, 30);
            this.btnQuery.TabIndex = 98;
            this.btnQuery.Text = "查询(&Q)";
            this.btnQuery.Visible = false;
            this.btnQuery.Click += new System.EventHandler(this.btnQuery_Click);
            // 
            // txtQuery
            // 
            this.txtQuery.FormatQueryString = null;
            this.txtQuery.Location = new System.Drawing.Point(123, 17);
            this.txtQuery.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtQuery.Name = "txtQuery";
            this.txtQuery.Size = new System.Drawing.Size(285, 25);
            this.txtQuery.TabIndex = 1;
            this.txtQuery.TextChanged += new System.EventHandler(this.txtQuery_TextChanged);
            this.txtQuery.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtQuery_KeyPress);
            // 
            // labelControl1
            // 
            this.labelControl1.Appearance.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelControl1.Appearance.Options.UseFont = true;
            this.labelControl1.Location = new System.Drawing.Point(14, 19);
            this.labelControl1.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.labelControl1.Name = "labelControl1";
            this.labelControl1.Size = new System.Drawing.Size(100, 20);
            this.labelControl1.TabIndex = 0;
            this.labelControl1.Text = "编号或名称(&U):";
            // 
            // pageNavigator
            // 
            this.pageNavigator.DefaultFilter = "";
            this.pageNavigator.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.pageNavigator.EmptySource = null;
            this.pageNavigator.Fields = "*";
            this.pageNavigator.Filter = "";
            this.pageNavigator.GridControl = this.gvControl;
            this.pageNavigator.Location = new System.Drawing.Point(2, 297);
            this.pageNavigator.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.pageNavigator.MinimumSize = new System.Drawing.Size(914, 51);
            this.pageNavigator.Name = "pageNavigator";
            this.pageNavigator.PageCount = 0;
            this.pageNavigator.PageIndex = 0;
            this.pageNavigator.PageSize = 50;
            this.pageNavigator.PrimaryField = null;
            this.pageNavigator.RecordCount = 0;
            this.pageNavigator.Size = new System.Drawing.Size(915, 51);
            this.pageNavigator.SortField = "";
            this.pageNavigator.SortType = "";
            this.pageNavigator.TabIndex = 4;
            this.pageNavigator.ViewName = "";
            // 
            // gvControl
            // 
            this.gvControl.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gvControl.EmbeddedNavigator.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.gvControl.Location = new System.Drawing.Point(2, 28);
            this.gvControl.MainView = this.gvData;
            this.gvControl.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.gvControl.Name = "gvControl";
            this.gvControl.Size = new System.Drawing.Size(915, 269);
            this.gvControl.TabIndex = 2;
            this.gvControl.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gvData});
            this.gvControl.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.gvControl_KeyPress);
            // 
            // gvData
            // 
            this.gvData.Appearance.EvenRow.BackColor = System.Drawing.Color.WhiteSmoke;
            this.gvData.Appearance.EvenRow.Options.UseBackColor = true;
            this.gvData.Appearance.FocusedCell.BackColor = System.Drawing.Color.Aqua;
            this.gvData.Appearance.FocusedCell.Options.UseBackColor = true;
            this.gvData.Appearance.FocusedRow.BackColor = System.Drawing.Color.Beige;
            this.gvData.Appearance.FocusedRow.ForeColor = System.Drawing.Color.Black;
            this.gvData.Appearance.FocusedRow.Options.UseBackColor = true;
            this.gvData.Appearance.FocusedRow.Options.UseForeColor = true;
            this.gvData.Appearance.HeaderPanel.Font = new System.Drawing.Font("微软雅黑", 9F);
            this.gvData.Appearance.HeaderPanel.Options.UseFont = true;
            this.gvData.FocusRectStyle = DevExpress.XtraGrid.Views.Grid.DrawFocusRectStyle.RowFocus;
            this.gvData.GridControl = this.gvControl;
            this.gvData.IndicatorWidth = 43;
            this.gvData.Name = "gvData";
            this.gvData.OptionsBehavior.Editable = false;
            this.gvData.OptionsNavigation.EnterMoveNextColumn = true;
            this.gvData.OptionsView.EnableAppearanceEvenRow = true;
            this.gvData.OptionsView.ShowGroupPanel = false;
            this.gvData.CustomDrawRowIndicator += new DevExpress.XtraGrid.Views.Grid.RowIndicatorCustomDrawEventHandler(this.gvData_CustomDrawRowIndicator);
            this.gvData.FocusedRowChanged += new DevExpress.XtraGrid.Views.Base.FocusedRowChangedEventHandler(this.gvData_FocusedRowChanged);
            this.gvData.DoubleClick += new System.EventHandler(this.gvData_DoubleClick);
            // 
            // gridControl1
            // 
            this.gridControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gridControl1.EmbeddedNavigator.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.gridControl1.Location = new System.Drawing.Point(2, 28);
            this.gridControl1.MainView = this.gridView1;
            this.gridControl1.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.gridControl1.Name = "gridControl1";
            this.gridControl1.Size = new System.Drawing.Size(915, 170);
            this.gridControl1.TabIndex = 5;
            this.gridControl1.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridView1});
            // 
            // gridView1
            // 
            this.gridView1.Appearance.EvenRow.BackColor = System.Drawing.Color.WhiteSmoke;
            this.gridView1.Appearance.EvenRow.Options.UseBackColor = true;
            this.gridView1.Appearance.FocusedCell.BackColor = System.Drawing.Color.Aqua;
            this.gridView1.Appearance.FocusedCell.Options.UseBackColor = true;
            this.gridView1.Appearance.FocusedRow.BackColor = System.Drawing.Color.Beige;
            this.gridView1.Appearance.FocusedRow.ForeColor = System.Drawing.Color.Black;
            this.gridView1.Appearance.FocusedRow.Options.UseBackColor = true;
            this.gridView1.Appearance.FocusedRow.Options.UseForeColor = true;
            this.gridView1.Appearance.HeaderPanel.Font = new System.Drawing.Font("微软雅黑", 9F);
            this.gridView1.Appearance.HeaderPanel.Options.UseFont = true;
            this.gridView1.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.colPrice,
            this.colSaleDate});
            this.gridView1.FocusRectStyle = DevExpress.XtraGrid.Views.Grid.DrawFocusRectStyle.RowFocus;
            this.gridView1.GridControl = this.gridControl1;
            this.gridView1.IndicatorWidth = 43;
            this.gridView1.Name = "gridView1";
            this.gridView1.OptionsBehavior.AllowAddRows = DevExpress.Utils.DefaultBoolean.False;
            this.gridView1.OptionsBehavior.AllowDeleteRows = DevExpress.Utils.DefaultBoolean.False;
            this.gridView1.OptionsBehavior.Editable = false;
            this.gridView1.OptionsBehavior.ReadOnly = true;
            this.gridView1.OptionsNavigation.EnterMoveNextColumn = true;
            this.gridView1.OptionsView.EnableAppearanceEvenRow = true;
            this.gridView1.OptionsView.ShowGroupPanel = false;
            // 
            // colPrice
            // 
            this.colPrice.Caption = "价格";
            this.colPrice.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric;
            this.colPrice.FieldName = "SalePrice";
            this.colPrice.Name = "colPrice";
            this.colPrice.Visible = true;
            this.colPrice.VisibleIndex = 0;
            this.colPrice.Width = 345;
            // 
            // colSaleDate
            // 
            this.colSaleDate.Caption = "销售日期";
            this.colSaleDate.DisplayFormat.FormatString = "d";
            this.colSaleDate.DisplayFormat.FormatType = DevExpress.Utils.FormatType.DateTime;
            this.colSaleDate.FieldName = "CreateDate";
            this.colSaleDate.Name = "colSaleDate";
            this.colSaleDate.Visible = true;
            this.colSaleDate.VisibleIndex = 1;
            this.colSaleDate.Width = 523;
            // 
            // splitterControl1
            // 
            this.splitterControl1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.splitterControl1.Location = new System.Drawing.Point(0, 607);
            this.splitterControl1.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.splitterControl1.Name = "splitterControl1";
            this.splitterControl1.Size = new System.Drawing.Size(919, 6);
            this.splitterControl1.TabIndex = 9;
            this.splitterControl1.TabStop = false;
            // 
            // gpcTop
            // 
            this.gpcTop.AppearanceCaption.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gpcTop.AppearanceCaption.Options.UseFont = true;
            this.gpcTop.Controls.Add(this.gvControl);
            this.gpcTop.Controls.Add(this.pageNavigator);
            this.gpcTop.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gpcTop.Location = new System.Drawing.Point(0, 57);
            this.gpcTop.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.gpcTop.Name = "gpcTop";
            this.gpcTop.Size = new System.Drawing.Size(919, 350);
            this.gpcTop.TabIndex = 0;
            this.gpcTop.Text = "查询结果";
            // 
            // gpcBottom
            // 
            this.gpcBottom.AppearanceCaption.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gpcBottom.AppearanceCaption.Options.UseFont = true;
            this.gpcBottom.Controls.Add(this.gridControl1);
            this.gpcBottom.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.gpcBottom.Location = new System.Drawing.Point(0, 407);
            this.gpcBottom.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.gpcBottom.Name = "gpcBottom";
            this.gpcBottom.Size = new System.Drawing.Size(919, 200);
            this.gpcBottom.TabIndex = 11;
            this.gpcBottom.Text = "历史销售价格";
            // 
            // FrmProductPopupQuery
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 18F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(919, 613);
            this.Controls.Add(this.gpcTop);
            this.Controls.Add(this.gpcBottom);
            this.Controls.Add(this.splitterControl1);
            this.Controls.Add(this.pnlTop);
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.MinimizeBox = false;
            this.MinimumSize = new System.Drawing.Size(820, 427);
            this.Name = "FrmProductPopupQuery";
            this.ShowIcon = false;
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "双击选择项";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.FrmProductPopupQuery_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pnlTop)).EndInit();
            this.pnlTop.ResumeLayout(false);
            this.pnlTop.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.txtQuery.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pageNavigator)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gvControl)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gvData)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridControl1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gpcTop)).EndInit();
            this.gpcTop.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.gpcBottom)).EndInit();
            this.gpcBottom.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraEditors.PanelControl pnlTop;
        private PageNavigator pageNavigator;
        private DevExpress.XtraEditors.LabelControl labelControl1;
        protected DevExpress.XtraGrid.GridControl gvControl;
        protected DevExpress.XtraGrid.Views.Grid.GridView gvData;
        private TextBoxQueryEx txtQuery;
        private DevExpress.XtraEditors.SimpleButton btnClose;
        private DevExpress.XtraEditors.SimpleButton btnQuery;
        protected DevExpress.XtraGrid.GridControl gridControl1;
        protected DevExpress.XtraGrid.Views.Grid.GridView gridView1;
        private DevExpress.XtraEditors.SplitterControl splitterControl1;
        private DevExpress.XtraEditors.GroupControl gpcTop;
        private DevExpress.XtraEditors.GroupControl gpcBottom;
        private DevExpress.XtraGrid.Columns.GridColumn colPrice;
        private DevExpress.XtraGrid.Columns.GridColumn colSaleDate;
    }
}