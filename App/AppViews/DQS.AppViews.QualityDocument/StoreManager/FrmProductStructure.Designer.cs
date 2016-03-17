namespace DQS.AppViews.QualityDocument.StoreManager
{
    partial class FrmProductStructure
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
            this.pnlButtom = new DevExpress.XtraEditors.PanelControl();
            this.gvControlUnion = new DevExpress.XtraGrid.GridControl();
            this.gvUnion = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.pageNavigatorUnion = new DQS.Controls.PageNavigator();
            this.pnlTool = new DevExpress.XtraEditors.PanelControl();
            this.btnUnionQuery = new DevExpress.XtraEditors.SimpleButton();
            this.lblUnionName = new DevExpress.XtraEditors.LabelControl();
            this.txtUnionQuery = new DQS.Controls.TextBoxQueryEx();
            this.btnUnRelation = new DevExpress.XtraEditors.SimpleButton();
            this.btnRelation = new DevExpress.XtraEditors.SimpleButton();
            this.splitterButtom = new DevExpress.XtraEditors.SplitterControl();
            this.pnlCenter = new DevExpress.XtraEditors.PanelControl();
            this.gpcRight = new DevExpress.XtraEditors.GroupControl();
            this.gvControlStructure = new DevExpress.XtraGrid.GridControl();
            this.gvStructure = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.pageNavigatorStructure = new DQS.Controls.PageSimpleNavigator();
            this.pnlRightTop = new DevExpress.XtraEditors.PanelControl();
            this.btnStructureQuery = new DevExpress.XtraEditors.SimpleButton();
            this.lblStructureName = new DevExpress.XtraEditors.LabelControl();
            this.txtStructureName = new DQS.Controls.TextBoxQueryEx();
            this.splitterTop = new DevExpress.XtraEditors.SplitterControl();
            this.gpcLeft = new DevExpress.XtraEditors.GroupControl();
            this.gvControlProduct = new DevExpress.XtraGrid.GridControl();
            this.gvProduct = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.pageNavigatorProduct = new DQS.Controls.PageSimpleNavigator();
            this.pnlLeftTop = new DevExpress.XtraEditors.PanelControl();
            this.btnProductQuery = new DevExpress.XtraEditors.SimpleButton();
            this.lblProductName = new DevExpress.XtraEditors.LabelControl();
            this.txtProductName = new DQS.Controls.TextBoxQueryEx();
            ((System.ComponentModel.ISupportInitialize)(this.pnlButtom)).BeginInit();
            this.pnlButtom.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gvControlUnion)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gvUnion)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pageNavigatorUnion)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pnlTool)).BeginInit();
            this.pnlTool.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.txtUnionQuery.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pnlCenter)).BeginInit();
            this.pnlCenter.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gpcRight)).BeginInit();
            this.gpcRight.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gvControlStructure)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gvStructure)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pageNavigatorStructure)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pnlRightTop)).BeginInit();
            this.pnlRightTop.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.txtStructureName.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gpcLeft)).BeginInit();
            this.gpcLeft.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gvControlProduct)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gvProduct)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pageNavigatorProduct)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pnlLeftTop)).BeginInit();
            this.pnlLeftTop.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.txtProductName.Properties)).BeginInit();
            this.SuspendLayout();
            // 
            // pnlButtom
            // 
            this.pnlButtom.Controls.Add(this.gvControlUnion);
            this.pnlButtom.Controls.Add(this.pageNavigatorUnion);
            this.pnlButtom.Controls.Add(this.pnlTool);
            this.pnlButtom.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.pnlButtom.Location = new System.Drawing.Point(0, 252);
            this.pnlButtom.Name = "pnlButtom";
            this.pnlButtom.Size = new System.Drawing.Size(814, 230);
            this.pnlButtom.TabIndex = 0;
            // 
            // gvControlUnion
            // 
            this.gvControlUnion.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gvControlUnion.Location = new System.Drawing.Point(2, 44);
            this.gvControlUnion.MainView = this.gvUnion;
            this.gvControlUnion.Name = "gvControlUnion";
            this.gvControlUnion.Size = new System.Drawing.Size(810, 144);
            this.gvControlUnion.TabIndex = 0;
            this.gvControlUnion.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gvUnion});
            // 
            // gvUnion
            // 
            this.gvUnion.Appearance.EvenRow.BackColor = System.Drawing.Color.WhiteSmoke;
            this.gvUnion.Appearance.EvenRow.Options.UseBackColor = true;
            this.gvUnion.Appearance.FocusedCell.BackColor = System.Drawing.Color.Aqua;
            this.gvUnion.Appearance.FocusedCell.Options.UseBackColor = true;
            this.gvUnion.Appearance.FocusedRow.BackColor = System.Drawing.Color.Beige;
            this.gvUnion.Appearance.FocusedRow.ForeColor = System.Drawing.Color.Black;
            this.gvUnion.Appearance.FocusedRow.Options.UseBackColor = true;
            this.gvUnion.Appearance.FocusedRow.Options.UseForeColor = true;
            this.gvUnion.FocusRectStyle = DevExpress.XtraGrid.Views.Grid.DrawFocusRectStyle.RowFocus;
            this.gvUnion.GridControl = this.gvControlUnion;
            this.gvUnion.IndicatorWidth = 40;
            this.gvUnion.Name = "gvUnion";
            this.gvUnion.OptionsBehavior.Editable = false;
            this.gvUnion.OptionsNavigation.EnterMoveNextColumn = true;
            this.gvUnion.OptionsView.ColumnAutoWidth = false;
            this.gvUnion.OptionsView.EnableAppearanceEvenRow = true;
            this.gvUnion.OptionsView.ShowGroupPanel = false;
            this.gvUnion.CustomDrawRowIndicator += new DevExpress.XtraGrid.Views.Grid.RowIndicatorCustomDrawEventHandler(this.gvData_CustomDrawRowIndicator);
            this.gvUnion.CustomDrawEmptyForeground += new DevExpress.XtraGrid.Views.Base.CustomDrawEventHandler(this.gvData_CustomDrawEmptyForeground);
            // 
            // pageNavigatorUnion
            // 
            this.pageNavigatorUnion.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.pageNavigatorUnion.EmptySource = null;
            this.pageNavigatorUnion.Fields = "*";
            this.pageNavigatorUnion.Filter = "";
            this.pageNavigatorUnion.GridControl = this.gvControlUnion;
            this.pageNavigatorUnion.Location = new System.Drawing.Point(2, 188);
            this.pageNavigatorUnion.MinimumSize = new System.Drawing.Size(800, 40);
            this.pageNavigatorUnion.Name = "pageNavigatorUnion";
            this.pageNavigatorUnion.PageCount = 0;
            this.pageNavigatorUnion.PageIndex = 0;
            this.pageNavigatorUnion.PageSize = 50;
            this.pageNavigatorUnion.PrimaryField = "产品ID";
            this.pageNavigatorUnion.RecordCount = 0;
            this.pageNavigatorUnion.Size = new System.Drawing.Size(810, 40);
            this.pageNavigatorUnion.SortField = "";
            this.pageNavigatorUnion.SortType = "";
            this.pageNavigatorUnion.TabIndex = 1;
            this.pageNavigatorUnion.ViewName = "vw_AllProductStructure";
            // 
            // pnlTool
            // 
            this.pnlTool.Controls.Add(this.btnUnionQuery);
            this.pnlTool.Controls.Add(this.lblUnionName);
            this.pnlTool.Controls.Add(this.txtUnionQuery);
            this.pnlTool.Controls.Add(this.btnUnRelation);
            this.pnlTool.Controls.Add(this.btnRelation);
            this.pnlTool.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlTool.Location = new System.Drawing.Point(2, 2);
            this.pnlTool.Name = "pnlTool";
            this.pnlTool.Size = new System.Drawing.Size(810, 42);
            this.pnlTool.TabIndex = 2;
            // 
            // btnUnionQuery
            // 
            this.btnUnionQuery.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnUnionQuery.Location = new System.Drawing.Point(321, 11);
            this.btnUnionQuery.Name = "btnUnionQuery";
            this.btnUnionQuery.Size = new System.Drawing.Size(80, 23);
            this.btnUnionQuery.TabIndex = 2;
            this.btnUnionQuery.Text = "查询(&U)";
            this.btnUnionQuery.Click += new System.EventHandler(this.btnUnionQuery_Click);
            // 
            // lblUnionName
            // 
            this.lblUnionName.Location = new System.Drawing.Point(12, 16);
            this.lblUnionName.Name = "lblUnionName";
            this.lblUnionName.Size = new System.Drawing.Size(130, 14);
            this.lblUnionName.TabIndex = 0;
            this.lblUnionName.Text = "产品或存储单位名称(&U):";
            // 
            // txtUnionQuery
            // 
            this.txtUnionQuery.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.txtUnionQuery.FormatQueryString = "[产品名称] LIKE \'%{0}%\' OR [产品名称Spell] LIKE \'%{0}%\'  OR [存储名称] LIKE \'%{0}%\' OR [存储名称S" +
                "pell] LIKE \'%{0}%\' ";
            this.txtUnionQuery.Location = new System.Drawing.Point(148, 13);
            this.txtUnionQuery.Name = "txtUnionQuery";
            this.txtUnionQuery.Size = new System.Drawing.Size(167, 21);
            this.txtUnionQuery.TabIndex = 1;
            this.txtUnionQuery.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtQuery_KeyPress);
            // 
            // btnUnRelation
            // 
            this.btnUnRelation.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnUnRelation.Location = new System.Drawing.Point(493, 11);
            this.btnUnRelation.Name = "btnUnRelation";
            this.btnUnRelation.Size = new System.Drawing.Size(80, 23);
            this.btnUnRelation.TabIndex = 4;
            this.btnUnRelation.Text = "解除关联(&D)";
            this.btnUnRelation.Click += new System.EventHandler(this.btnUnRelation_Click);
            // 
            // btnRelation
            // 
            this.btnRelation.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnRelation.Location = new System.Drawing.Point(407, 11);
            this.btnRelation.Name = "btnRelation";
            this.btnRelation.Size = new System.Drawing.Size(80, 23);
            this.btnRelation.TabIndex = 3;
            this.btnRelation.Text = "关联(&R)";
            this.btnRelation.Click += new System.EventHandler(this.btnRelation_Click);
            // 
            // splitterButtom
            // 
            this.splitterButtom.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.splitterButtom.Location = new System.Drawing.Point(0, 246);
            this.splitterButtom.Name = "splitterButtom";
            this.splitterButtom.Size = new System.Drawing.Size(814, 6);
            this.splitterButtom.TabIndex = 1;
            this.splitterButtom.TabStop = false;
            // 
            // pnlCenter
            // 
            this.pnlCenter.Controls.Add(this.gpcRight);
            this.pnlCenter.Controls.Add(this.splitterTop);
            this.pnlCenter.Controls.Add(this.gpcLeft);
            this.pnlCenter.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlCenter.Location = new System.Drawing.Point(0, 0);
            this.pnlCenter.Name = "pnlCenter";
            this.pnlCenter.Size = new System.Drawing.Size(814, 246);
            this.pnlCenter.TabIndex = 2;
            // 
            // gpcRight
            // 
            this.gpcRight.Controls.Add(this.gvControlStructure);
            this.gpcRight.Controls.Add(this.pageNavigatorStructure);
            this.gpcRight.Controls.Add(this.pnlRightTop);
            this.gpcRight.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gpcRight.Location = new System.Drawing.Point(425, 2);
            this.gpcRight.Name = "gpcRight";
            this.gpcRight.Size = new System.Drawing.Size(387, 242);
            this.gpcRight.TabIndex = 0;
            this.gpcRight.Text = "存储单位列表";
            // 
            // gvControlStructure
            // 
            this.gvControlStructure.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gvControlStructure.Location = new System.Drawing.Point(2, 65);
            this.gvControlStructure.MainView = this.gvStructure;
            this.gvControlStructure.Name = "gvControlStructure";
            this.gvControlStructure.Size = new System.Drawing.Size(383, 135);
            this.gvControlStructure.TabIndex = 1;
            this.gvControlStructure.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gvStructure});
            // 
            // gvStructure
            // 
            this.gvStructure.Appearance.EvenRow.BackColor = System.Drawing.Color.WhiteSmoke;
            this.gvStructure.Appearance.EvenRow.Options.UseBackColor = true;
            this.gvStructure.Appearance.FocusedCell.BackColor = System.Drawing.Color.Aqua;
            this.gvStructure.Appearance.FocusedCell.Options.UseBackColor = true;
            this.gvStructure.Appearance.FocusedRow.BackColor = System.Drawing.Color.Beige;
            this.gvStructure.Appearance.FocusedRow.ForeColor = System.Drawing.Color.Black;
            this.gvStructure.Appearance.FocusedRow.Options.UseBackColor = true;
            this.gvStructure.Appearance.FocusedRow.Options.UseForeColor = true;
            this.gvStructure.FocusRectStyle = DevExpress.XtraGrid.Views.Grid.DrawFocusRectStyle.RowFocus;
            this.gvStructure.GridControl = this.gvControlStructure;
            this.gvStructure.IndicatorWidth = 40;
            this.gvStructure.Name = "gvStructure";
            this.gvStructure.OptionsBehavior.Editable = false;
            this.gvStructure.OptionsNavigation.EnterMoveNextColumn = true;
            this.gvStructure.OptionsView.ColumnAutoWidth = false;
            this.gvStructure.OptionsView.EnableAppearanceEvenRow = true;
            this.gvStructure.OptionsView.ShowGroupPanel = false;
            this.gvStructure.CustomDrawRowIndicator += new DevExpress.XtraGrid.Views.Grid.RowIndicatorCustomDrawEventHandler(this.gvData_CustomDrawRowIndicator);
            this.gvStructure.CustomDrawEmptyForeground += new DevExpress.XtraGrid.Views.Base.CustomDrawEventHandler(this.gvData_CustomDrawEmptyForeground);
            // 
            // pageNavigatorStructure
            // 
            this.pageNavigatorStructure.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.pageNavigatorStructure.EmptySource = null;
            this.pageNavigatorStructure.Fields = "*";
            this.pageNavigatorStructure.Filter = "";
            this.pageNavigatorStructure.GridControl = this.gvControlStructure;
            this.pageNavigatorStructure.Location = new System.Drawing.Point(2, 200);
            this.pageNavigatorStructure.MinimumSize = new System.Drawing.Size(320, 40);
            this.pageNavigatorStructure.Name = "pageNavigatorStructure";
            this.pageNavigatorStructure.PageCount = 0;
            this.pageNavigatorStructure.PageIndex = 0;
            this.pageNavigatorStructure.PageSize = 50;
            this.pageNavigatorStructure.PrimaryField = "存储ID";
            this.pageNavigatorStructure.RecordCount = 0;
            this.pageNavigatorStructure.Size = new System.Drawing.Size(383, 40);
            this.pageNavigatorStructure.SortField = "";
            this.pageNavigatorStructure.SortType = "";
            this.pageNavigatorStructure.TabIndex = 2;
            this.pageNavigatorStructure.ViewName = "vw_AllStructureForProduct";
            // 
            // pnlRightTop
            // 
            this.pnlRightTop.Controls.Add(this.btnStructureQuery);
            this.pnlRightTop.Controls.Add(this.lblStructureName);
            this.pnlRightTop.Controls.Add(this.txtStructureName);
            this.pnlRightTop.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlRightTop.Location = new System.Drawing.Point(2, 23);
            this.pnlRightTop.Name = "pnlRightTop";
            this.pnlRightTop.Size = new System.Drawing.Size(383, 42);
            this.pnlRightTop.TabIndex = 0;
            // 
            // btnStructureQuery
            // 
            this.btnStructureQuery.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnStructureQuery.Location = new System.Drawing.Point(289, 10);
            this.btnStructureQuery.Name = "btnStructureQuery";
            this.btnStructureQuery.Size = new System.Drawing.Size(80, 23);
            this.btnStructureQuery.TabIndex = 2;
            this.btnStructureQuery.Text = "快速查询(&S)";
            this.btnStructureQuery.Click += new System.EventHandler(this.btnStructureQuery_Click);
            // 
            // lblStructureName
            // 
            this.lblStructureName.Location = new System.Drawing.Point(8, 15);
            this.lblStructureName.Name = "lblStructureName";
            this.lblStructureName.Size = new System.Drawing.Size(82, 14);
            this.lblStructureName.TabIndex = 0;
            this.lblStructureName.Text = "存储单位名(&U):";
            // 
            // txtStructureName
            // 
            this.txtStructureName.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.txtStructureName.FormatQueryString = "[存储名称] LIKE \'%{0}%\' OR [存储名称Spell] LIKE \'%{0}%\' ";
            this.txtStructureName.Location = new System.Drawing.Point(96, 12);
            this.txtStructureName.Name = "txtStructureName";
            this.txtStructureName.Size = new System.Drawing.Size(187, 21);
            this.txtStructureName.TabIndex = 1;
            this.txtStructureName.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtQuery_KeyPress);
            // 
            // splitterTop
            // 
            this.splitterTop.Location = new System.Drawing.Point(419, 2);
            this.splitterTop.Name = "splitterTop";
            this.splitterTop.Size = new System.Drawing.Size(6, 242);
            this.splitterTop.TabIndex = 2;
            this.splitterTop.TabStop = false;
            // 
            // gpcLeft
            // 
            this.gpcLeft.Controls.Add(this.gvControlProduct);
            this.gpcLeft.Controls.Add(this.pageNavigatorProduct);
            this.gpcLeft.Controls.Add(this.pnlLeftTop);
            this.gpcLeft.Dock = System.Windows.Forms.DockStyle.Left;
            this.gpcLeft.Location = new System.Drawing.Point(2, 2);
            this.gpcLeft.Name = "gpcLeft";
            this.gpcLeft.Size = new System.Drawing.Size(417, 242);
            this.gpcLeft.TabIndex = 0;
            this.gpcLeft.Text = "产品列表";
            // 
            // gvControlProduct
            // 
            this.gvControlProduct.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gvControlProduct.Location = new System.Drawing.Point(2, 65);
            this.gvControlProduct.MainView = this.gvProduct;
            this.gvControlProduct.Name = "gvControlProduct";
            this.gvControlProduct.Size = new System.Drawing.Size(413, 135);
            this.gvControlProduct.TabIndex = 1;
            this.gvControlProduct.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gvProduct});
            // 
            // gvProduct
            // 
            this.gvProduct.Appearance.EvenRow.BackColor = System.Drawing.Color.WhiteSmoke;
            this.gvProduct.Appearance.EvenRow.Options.UseBackColor = true;
            this.gvProduct.Appearance.FocusedCell.BackColor = System.Drawing.Color.Aqua;
            this.gvProduct.Appearance.FocusedCell.Options.UseBackColor = true;
            this.gvProduct.Appearance.FocusedRow.BackColor = System.Drawing.Color.Beige;
            this.gvProduct.Appearance.FocusedRow.ForeColor = System.Drawing.Color.Black;
            this.gvProduct.Appearance.FocusedRow.Options.UseBackColor = true;
            this.gvProduct.Appearance.FocusedRow.Options.UseForeColor = true;
            this.gvProduct.FocusRectStyle = DevExpress.XtraGrid.Views.Grid.DrawFocusRectStyle.RowFocus;
            this.gvProduct.GridControl = this.gvControlProduct;
            this.gvProduct.IndicatorWidth = 40;
            this.gvProduct.Name = "gvProduct";
            this.gvProduct.OptionsBehavior.Editable = false;
            this.gvProduct.OptionsNavigation.EnterMoveNextColumn = true;
            this.gvProduct.OptionsView.ColumnAutoWidth = false;
            this.gvProduct.OptionsView.EnableAppearanceEvenRow = true;
            this.gvProduct.OptionsView.ShowGroupPanel = false;
            this.gvProduct.CustomDrawRowIndicator += new DevExpress.XtraGrid.Views.Grid.RowIndicatorCustomDrawEventHandler(this.gvData_CustomDrawRowIndicator);
            this.gvProduct.CustomDrawEmptyForeground += new DevExpress.XtraGrid.Views.Base.CustomDrawEventHandler(this.gvData_CustomDrawEmptyForeground);
            // 
            // pageNavigatorProduct
            // 
            this.pageNavigatorProduct.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.pageNavigatorProduct.EmptySource = null;
            this.pageNavigatorProduct.Fields = "*";
            this.pageNavigatorProduct.Filter = "";
            this.pageNavigatorProduct.GridControl = this.gvControlProduct;
            this.pageNavigatorProduct.Location = new System.Drawing.Point(2, 200);
            this.pageNavigatorProduct.MinimumSize = new System.Drawing.Size(320, 40);
            this.pageNavigatorProduct.Name = "pageNavigatorProduct";
            this.pageNavigatorProduct.PageCount = 0;
            this.pageNavigatorProduct.PageIndex = 0;
            this.pageNavigatorProduct.PageSize = 50;
            this.pageNavigatorProduct.PrimaryField = "产品ID";
            this.pageNavigatorProduct.RecordCount = 0;
            this.pageNavigatorProduct.Size = new System.Drawing.Size(413, 40);
            this.pageNavigatorProduct.SortField = "";
            this.pageNavigatorProduct.SortType = "";
            this.pageNavigatorProduct.TabIndex = 2;
            this.pageNavigatorProduct.ViewName = "vw_AllProductForStructure";
            // 
            // pnlLeftTop
            // 
            this.pnlLeftTop.Controls.Add(this.btnProductQuery);
            this.pnlLeftTop.Controls.Add(this.lblProductName);
            this.pnlLeftTop.Controls.Add(this.txtProductName);
            this.pnlLeftTop.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlLeftTop.Location = new System.Drawing.Point(2, 23);
            this.pnlLeftTop.Name = "pnlLeftTop";
            this.pnlLeftTop.Size = new System.Drawing.Size(413, 42);
            this.pnlLeftTop.TabIndex = 0;
            // 
            // btnProductQuery
            // 
            this.btnProductQuery.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnProductQuery.Location = new System.Drawing.Point(267, 10);
            this.btnProductQuery.Name = "btnProductQuery";
            this.btnProductQuery.Size = new System.Drawing.Size(80, 23);
            this.btnProductQuery.TabIndex = 2;
            this.btnProductQuery.Text = "快速查询(&P)";
            this.btnProductQuery.Click += new System.EventHandler(this.btnProductQuery_Click);
            // 
            // lblProductName
            // 
            this.lblProductName.Location = new System.Drawing.Point(10, 15);
            this.lblProductName.Name = "lblProductName";
            this.lblProductName.Size = new System.Drawing.Size(58, 14);
            this.lblProductName.TabIndex = 0;
            this.lblProductName.Text = "产品名(&U):";
            // 
            // txtProductName
            // 
            this.txtProductName.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.txtProductName.FormatQueryString = "[产品名称] LIKE \'%{0}%\' OR [产品名称Spell] LIKE \'%{0}%\' ";
            this.txtProductName.Location = new System.Drawing.Point(74, 12);
            this.txtProductName.Name = "txtProductName";
            this.txtProductName.Size = new System.Drawing.Size(187, 21);
            this.txtProductName.TabIndex = 1;
            this.txtProductName.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtQuery_KeyPress);
            // 
            // FrmProductStructure
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 14F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(814, 482);
            this.Controls.Add(this.pnlCenter);
            this.Controls.Add(this.splitterButtom);
            this.Controls.Add(this.pnlButtom);
            this.Name = "FrmProductStructure";
            this.Text = "FrmProductStructure";
            this.Load += new System.EventHandler(this.FrmProductStructure_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pnlButtom)).EndInit();
            this.pnlButtom.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.gvControlUnion)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gvUnion)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pageNavigatorUnion)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pnlTool)).EndInit();
            this.pnlTool.ResumeLayout(false);
            this.pnlTool.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.txtUnionQuery.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pnlCenter)).EndInit();
            this.pnlCenter.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.gpcRight)).EndInit();
            this.gpcRight.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.gvControlStructure)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gvStructure)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pageNavigatorStructure)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pnlRightTop)).EndInit();
            this.pnlRightTop.ResumeLayout(false);
            this.pnlRightTop.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.txtStructureName.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gpcLeft)).EndInit();
            this.gpcLeft.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.gvControlProduct)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gvProduct)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pageNavigatorProduct)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pnlLeftTop)).EndInit();
            this.pnlLeftTop.ResumeLayout(false);
            this.pnlLeftTop.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.txtProductName.Properties)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraEditors.PanelControl pnlButtom;
        private DevExpress.XtraEditors.SplitterControl splitterButtom;
        private DevExpress.XtraEditors.PanelControl pnlTool;
        private DevExpress.XtraEditors.LabelControl lblUnionName;
        private DQS.Controls.TextBoxQueryEx txtUnionQuery;
        private DevExpress.XtraEditors.SimpleButton btnUnRelation;
        private DevExpress.XtraEditors.SimpleButton btnRelation;
        private DevExpress.XtraEditors.PanelControl pnlCenter;
        private DevExpress.XtraEditors.GroupControl gpcLeft;
        private DevExpress.XtraEditors.PanelControl pnlLeftTop;
        private DevExpress.XtraEditors.SimpleButton btnProductQuery;
        private DevExpress.XtraEditors.LabelControl lblProductName;
        private DQS.Controls.TextBoxQueryEx txtProductName;
        private DevExpress.XtraEditors.SimpleButton btnUnionQuery;
        private DevExpress.XtraEditors.GroupControl gpcRight;
        private DevExpress.XtraEditors.PanelControl pnlRightTop;
        private DevExpress.XtraEditors.SimpleButton btnStructureQuery;
        private DevExpress.XtraEditors.LabelControl lblStructureName;
        private DQS.Controls.TextBoxQueryEx txtStructureName;
        private DevExpress.XtraEditors.SplitterControl splitterTop;
        private DQS.Controls.PageSimpleNavigator pageNavigatorProduct;
        private DevExpress.XtraGrid.GridControl gvControlUnion;
        private DevExpress.XtraGrid.Views.Grid.GridView gvUnion;
        private DQS.Controls.PageNavigator pageNavigatorUnion;
        private DevExpress.XtraGrid.GridControl gvControlStructure;
        private DevExpress.XtraGrid.Views.Grid.GridView gvStructure;
        private DQS.Controls.PageSimpleNavigator pageNavigatorStructure;
        private DevExpress.XtraGrid.GridControl gvControlProduct;
        private DevExpress.XtraGrid.Views.Grid.GridView gvProduct;
    }
}