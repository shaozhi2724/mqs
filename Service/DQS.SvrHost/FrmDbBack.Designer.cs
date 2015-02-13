namespace DQS.SvrHost
{
    partial class FrmDbBack
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmDbBack));
            this.barManager = new DevExpress.XtraBars.BarManager();
            this.bar1 = new DevExpress.XtraBars.Bar();
            this.bbiDbBack = new DevExpress.XtraBars.BarButtonItem();
            this.bbiDbRecover = new DevExpress.XtraBars.BarButtonItem();
            this.bbiDbBackPlan = new DevExpress.XtraBars.BarButtonItem();
            this.bar3 = new DevExpress.XtraBars.Bar();
            this.bsiPlan = new DevExpress.XtraBars.BarStaticItem();
            this.barDockControlTop = new DevExpress.XtraBars.BarDockControl();
            this.barDockControlBottom = new DevExpress.XtraBars.BarDockControl();
            this.barDockControlLeft = new DevExpress.XtraBars.BarDockControl();
            this.barDockControlRight = new DevExpress.XtraBars.BarDockControl();
            this.imageCollection = new DevExpress.Utils.ImageCollection();
            this.groupControl1 = new DevExpress.XtraEditors.GroupControl();
            this.simpleButton1 = new DevExpress.XtraEditors.SimpleButton();
            this.layControl = new DevExpress.XtraLayout.LayoutControl();
            this.dtEnd = new DevExpress.XtraEditors.DateEdit();
            this.dtStart = new DevExpress.XtraEditors.DateEdit();
            this.layControlGroup = new DevExpress.XtraLayout.LayoutControlGroup();
            this.layoutControlItem1 = new DevExpress.XtraLayout.LayoutControlItem();
            this.layoutControlItem2 = new DevExpress.XtraLayout.LayoutControlItem();
            this.gvControl = new DevExpress.XtraGrid.GridControl();
            this.gvData = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.repositoryItemCheckEdit1 = new DevExpress.XtraEditors.Repository.RepositoryItemCheckEdit();
            this.repositoryItemComboBox1 = new DevExpress.XtraEditors.Repository.RepositoryItemComboBox();
            ((System.ComponentModel.ISupportInitialize)(this.barManager)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.imageCollection)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.groupControl1)).BeginInit();
            this.groupControl1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.layControl)).BeginInit();
            this.layControl.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dtEnd.Properties.VistaTimeProperties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dtEnd.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dtStart.Properties.VistaTimeProperties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dtStart.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layControlGroup)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gvControl)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gvData)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemCheckEdit1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemComboBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // barManager
            // 
            this.barManager.Bars.AddRange(new DevExpress.XtraBars.Bar[] {
            this.bar1,
            this.bar3});
            this.barManager.DockControls.Add(this.barDockControlTop);
            this.barManager.DockControls.Add(this.barDockControlBottom);
            this.barManager.DockControls.Add(this.barDockControlLeft);
            this.barManager.DockControls.Add(this.barDockControlRight);
            this.barManager.Form = this;
            this.barManager.Images = this.imageCollection;
            this.barManager.Items.AddRange(new DevExpress.XtraBars.BarItem[] {
            this.bsiPlan,
            this.bbiDbBack,
            this.bbiDbRecover,
            this.bbiDbBackPlan});
            this.barManager.MaxItemId = 4;
            this.barManager.StatusBar = this.bar3;
            // 
            // bar1
            // 
            this.bar1.BarName = "Tools";
            this.bar1.DockCol = 0;
            this.bar1.DockRow = 0;
            this.bar1.DockStyle = DevExpress.XtraBars.BarDockStyle.Top;
            this.bar1.LinksPersistInfo.AddRange(new DevExpress.XtraBars.LinkPersistInfo[] {
            new DevExpress.XtraBars.LinkPersistInfo(DevExpress.XtraBars.BarLinkUserDefines.PaintStyle, this.bbiDbBack, DevExpress.XtraBars.BarItemPaintStyle.CaptionGlyph),
            new DevExpress.XtraBars.LinkPersistInfo(DevExpress.XtraBars.BarLinkUserDefines.PaintStyle, this.bbiDbRecover, DevExpress.XtraBars.BarItemPaintStyle.CaptionGlyph),
            new DevExpress.XtraBars.LinkPersistInfo(DevExpress.XtraBars.BarLinkUserDefines.PaintStyle, this.bbiDbBackPlan, DevExpress.XtraBars.BarItemPaintStyle.CaptionGlyph)});
            this.bar1.OptionsBar.AllowQuickCustomization = false;
            this.bar1.OptionsBar.DrawDragBorder = false;
            this.bar1.OptionsBar.UseWholeRow = true;
            this.bar1.Text = "Tools";
            // 
            // bbiDbBack
            // 
            this.bbiDbBack.Caption = "备份(&B)";
            this.bbiDbBack.Id = 1;
            this.bbiDbBack.ImageIndex = 0;
            this.bbiDbBack.Name = "bbiDbBack";
            // 
            // bbiDbRecover
            // 
            this.bbiDbRecover.Caption = "还原(&R)";
            this.bbiDbRecover.Id = 2;
            this.bbiDbRecover.ImageIndex = 1;
            this.bbiDbRecover.Name = "bbiDbRecover";
            // 
            // bbiDbBackPlan
            // 
            this.bbiDbBackPlan.Caption = "备份计划(&P)";
            this.bbiDbBackPlan.Id = 3;
            this.bbiDbBackPlan.ImageIndex = 2;
            this.bbiDbBackPlan.Name = "bbiDbBackPlan";
            this.bbiDbBackPlan.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.bbiDbBackPlan_ItemClick);
            // 
            // bar3
            // 
            this.bar3.BarName = "Status bar";
            this.bar3.CanDockStyle = DevExpress.XtraBars.BarCanDockStyle.Bottom;
            this.bar3.DockCol = 0;
            this.bar3.DockRow = 0;
            this.bar3.DockStyle = DevExpress.XtraBars.BarDockStyle.Bottom;
            this.bar3.LinksPersistInfo.AddRange(new DevExpress.XtraBars.LinkPersistInfo[] {
            new DevExpress.XtraBars.LinkPersistInfo(this.bsiPlan)});
            this.bar3.OptionsBar.AllowQuickCustomization = false;
            this.bar3.OptionsBar.DrawDragBorder = false;
            this.bar3.OptionsBar.UseWholeRow = true;
            this.bar3.Text = "Status bar";
            // 
            // bsiPlan
            // 
            this.bsiPlan.Caption = "摘要：无备份计划。";
            this.bsiPlan.Id = 0;
            this.bsiPlan.Name = "bsiPlan";
            this.bsiPlan.TextAlignment = System.Drawing.StringAlignment.Near;
            // 
            // barDockControlTop
            // 
            this.barDockControlTop.Dock = System.Windows.Forms.DockStyle.Top;
            this.barDockControlTop.Location = new System.Drawing.Point(0, 0);
            this.barDockControlTop.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.barDockControlTop.Size = new System.Drawing.Size(958, 50);
            // 
            // barDockControlBottom
            // 
            this.barDockControlBottom.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.barDockControlBottom.Location = new System.Drawing.Point(0, 637);
            this.barDockControlBottom.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.barDockControlBottom.Size = new System.Drawing.Size(958, 33);
            // 
            // barDockControlLeft
            // 
            this.barDockControlLeft.Dock = System.Windows.Forms.DockStyle.Left;
            this.barDockControlLeft.Location = new System.Drawing.Point(0, 50);
            this.barDockControlLeft.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.barDockControlLeft.Size = new System.Drawing.Size(0, 587);
            // 
            // barDockControlRight
            // 
            this.barDockControlRight.Dock = System.Windows.Forms.DockStyle.Right;
            this.barDockControlRight.Location = new System.Drawing.Point(958, 50);
            this.barDockControlRight.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.barDockControlRight.Size = new System.Drawing.Size(0, 587);
            // 
            // imageCollection
            // 
            this.imageCollection.ImageSize = new System.Drawing.Size(32, 32);
            this.imageCollection.ImageStream = ((DevExpress.Utils.ImageCollectionStreamer)(resources.GetObject("imageCollection.ImageStream")));
            this.imageCollection.Images.SetKeyName(0, "数据库备份.png");
            this.imageCollection.Images.SetKeyName(1, "数据库还原.png");
            this.imageCollection.Images.SetKeyName(2, "数据库备份计划.png");
            // 
            // groupControl1
            // 
            this.groupControl1.Controls.Add(this.simpleButton1);
            this.groupControl1.Controls.Add(this.layControl);
            this.groupControl1.Dock = System.Windows.Forms.DockStyle.Top;
            this.groupControl1.Location = new System.Drawing.Point(0, 50);
            this.groupControl1.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.groupControl1.Name = "groupControl1";
            this.groupControl1.Size = new System.Drawing.Size(958, 86);
            this.groupControl1.TabIndex = 4;
            this.groupControl1.Text = "查询";
            // 
            // simpleButton1
            // 
            this.simpleButton1.Location = new System.Drawing.Point(698, 44);
            this.simpleButton1.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.simpleButton1.Name = "simpleButton1";
            this.simpleButton1.Size = new System.Drawing.Size(86, 30);
            this.simpleButton1.TabIndex = 1;
            this.simpleButton1.Text = "查询(&Q)";
            // 
            // layControl
            // 
            this.layControl.Controls.Add(this.dtEnd);
            this.layControl.Controls.Add(this.dtStart);
            this.layControl.Location = new System.Drawing.Point(14, 30);
            this.layControl.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.layControl.Name = "layControl";
            this.layControl.Root = this.layControlGroup;
            this.layControl.Size = new System.Drawing.Size(678, 58);
            this.layControl.TabIndex = 0;
            this.layControl.Text = "layControl";
            // 
            // dtEnd
            // 
            this.dtEnd.EditValue = null;
            this.dtEnd.Location = new System.Drawing.Point(403, 12);
            this.dtEnd.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.dtEnd.MenuManager = this.barManager;
            this.dtEnd.Name = "dtEnd";
            this.dtEnd.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.dtEnd.Properties.DisplayFormat.FormatString = "D";
            this.dtEnd.Properties.DisplayFormat.FormatType = DevExpress.Utils.FormatType.DateTime;
            this.dtEnd.Properties.EditFormat.FormatString = "D";
            this.dtEnd.Properties.EditFormat.FormatType = DevExpress.Utils.FormatType.DateTime;
            this.dtEnd.Properties.Mask.EditMask = "D";
            this.dtEnd.Properties.VistaTimeProperties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton()});
            this.dtEnd.Size = new System.Drawing.Size(263, 25);
            this.dtEnd.StyleController = this.layControl;
            this.dtEnd.TabIndex = 4;
            // 
            // dtStart
            // 
            this.dtStart.EditValue = null;
            this.dtStart.Location = new System.Drawing.Point(75, 12);
            this.dtStart.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.dtStart.MenuManager = this.barManager;
            this.dtStart.Name = "dtStart";
            this.dtStart.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.dtStart.Properties.DisplayFormat.FormatString = "D";
            this.dtStart.Properties.DisplayFormat.FormatType = DevExpress.Utils.FormatType.DateTime;
            this.dtStart.Properties.EditFormat.FormatString = "D";
            this.dtStart.Properties.EditFormat.FormatType = DevExpress.Utils.FormatType.DateTime;
            this.dtStart.Properties.Mask.EditMask = "D";
            this.dtStart.Properties.VistaTimeProperties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton()});
            this.dtStart.Size = new System.Drawing.Size(261, 25);
            this.dtStart.StyleController = this.layControl;
            this.dtStart.TabIndex = 2;
            // 
            // layControlGroup
            // 
            this.layControlGroup.CustomizationFormText = "查询";
            this.layControlGroup.EnableIndentsWithoutBorders = DevExpress.Utils.DefaultBoolean.True;
            this.layControlGroup.GroupBordersVisible = false;
            this.layControlGroup.Items.AddRange(new DevExpress.XtraLayout.BaseLayoutItem[] {
            this.layoutControlItem1,
            this.layoutControlItem2});
            this.layControlGroup.Location = new System.Drawing.Point(0, 0);
            this.layControlGroup.Name = "layControlGroup";
            this.layControlGroup.Size = new System.Drawing.Size(678, 58);
            this.layControlGroup.Spacing = new DevExpress.XtraLayout.Utils.Padding(0, 0, 0, 0);
            this.layControlGroup.Text = "查询";
            this.layControlGroup.TextVisible = false;
            // 
            // layoutControlItem1
            // 
            this.layoutControlItem1.Control = this.dtStart;
            this.layoutControlItem1.CustomizationFormText = "备份日期";
            this.layoutControlItem1.Location = new System.Drawing.Point(0, 0);
            this.layoutControlItem1.Name = "layoutControlItem1";
            this.layoutControlItem1.Size = new System.Drawing.Size(328, 38);
            this.layoutControlItem1.Text = "备份日期";
            this.layoutControlItem1.TextSize = new System.Drawing.Size(60, 18);
            // 
            // layoutControlItem2
            // 
            this.layoutControlItem2.Control = this.dtEnd;
            this.layoutControlItem2.CustomizationFormText = "至";
            this.layoutControlItem2.Location = new System.Drawing.Point(328, 0);
            this.layoutControlItem2.Name = "layoutControlItem2";
            this.layoutControlItem2.Size = new System.Drawing.Size(330, 38);
            this.layoutControlItem2.Text = "至";
            this.layoutControlItem2.TextSize = new System.Drawing.Size(60, 18);
            // 
            // gvControl
            // 
            this.gvControl.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gvControl.EmbeddedNavigator.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.gvControl.Location = new System.Drawing.Point(0, 136);
            this.gvControl.MainView = this.gvData;
            this.gvControl.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.gvControl.Name = "gvControl";
            this.gvControl.RepositoryItems.AddRange(new DevExpress.XtraEditors.Repository.RepositoryItem[] {
            this.repositoryItemCheckEdit1,
            this.repositoryItemComboBox1});
            this.gvControl.Size = new System.Drawing.Size(958, 501);
            this.gvControl.TabIndex = 5;
            this.gvControl.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gvData});
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
            this.gvData.GridControl = this.gvControl;
            this.gvData.IndicatorWidth = 40;
            this.gvData.Name = "gvData";
            this.gvData.OptionsBehavior.Editable = false;
            this.gvData.OptionsNavigation.EnterMoveNextColumn = true;
            this.gvData.OptionsView.EnableAppearanceEvenRow = true;
            this.gvData.OptionsView.ShowGroupPanel = false;
            this.gvData.CustomDrawRowIndicator += new DevExpress.XtraGrid.Views.Grid.RowIndicatorCustomDrawEventHandler(this.gvData_CustomDrawRowIndicator);
            this.gvData.CustomDrawEmptyForeground += new DevExpress.XtraGrid.Views.Base.CustomDrawEventHandler(this.gvData_CustomDrawEmptyForeground);
            // 
            // repositoryItemCheckEdit1
            // 
            this.repositoryItemCheckEdit1.AutoHeight = false;
            this.repositoryItemCheckEdit1.Name = "repositoryItemCheckEdit1";
            // 
            // repositoryItemComboBox1
            // 
            this.repositoryItemComboBox1.AutoHeight = false;
            this.repositoryItemComboBox1.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.repositoryItemComboBox1.Items.AddRange(new object[] {
            "等于",
            "不等于",
            "大于",
            "大于等于",
            "小于",
            "小于等于",
            "模糊等于"});
            this.repositoryItemComboBox1.Name = "repositoryItemComboBox1";
            this.repositoryItemComboBox1.NullText = "等于";
            this.repositoryItemComboBox1.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.DisableTextEditor;
            // 
            // FrmDbBack
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 18F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(958, 670);
            this.Controls.Add(this.gvControl);
            this.Controls.Add(this.groupControl1);
            this.Controls.Add(this.barDockControlLeft);
            this.Controls.Add(this.barDockControlRight);
            this.Controls.Add(this.barDockControlBottom);
            this.Controls.Add(this.barDockControlTop);
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FrmDbBack";
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "数据备份信息";
            this.Load += new System.EventHandler(this.FrmDbBack_Load);
            ((System.ComponentModel.ISupportInitialize)(this.barManager)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.imageCollection)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.groupControl1)).EndInit();
            this.groupControl1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.layControl)).EndInit();
            this.layControl.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dtEnd.Properties.VistaTimeProperties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dtEnd.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dtStart.Properties.VistaTimeProperties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dtStart.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layControlGroup)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gvControl)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gvData)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemCheckEdit1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemComboBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraBars.BarManager barManager;
        private DevExpress.XtraBars.Bar bar1;
        private DevExpress.XtraBars.Bar bar3;
        private DevExpress.XtraBars.BarDockControl barDockControlTop;
        private DevExpress.XtraBars.BarDockControl barDockControlBottom;
        private DevExpress.XtraBars.BarDockControl barDockControlLeft;
        private DevExpress.XtraBars.BarDockControl barDockControlRight;
        private DevExpress.XtraBars.BarStaticItem bsiPlan;
        private DevExpress.XtraBars.BarButtonItem bbiDbBack;
        private DevExpress.XtraBars.BarButtonItem bbiDbRecover;
        private DevExpress.XtraBars.BarButtonItem bbiDbBackPlan;
        private DevExpress.XtraEditors.GroupControl groupControl1;
        private DevExpress.XtraGrid.GridControl gvControl;
        private DevExpress.XtraGrid.Views.Grid.GridView gvData;
        private DevExpress.XtraEditors.Repository.RepositoryItemCheckEdit repositoryItemCheckEdit1;
        private DevExpress.XtraEditors.Repository.RepositoryItemComboBox repositoryItemComboBox1;
        private DevExpress.XtraLayout.LayoutControl layControl;
        private DevExpress.XtraLayout.LayoutControlGroup layControlGroup;
        private DevExpress.XtraEditors.DateEdit dtStart;
        private DevExpress.XtraEditors.DateEdit dtEnd;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlItem1;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlItem2;
        private DevExpress.Utils.ImageCollection imageCollection;
        private DevExpress.XtraEditors.SimpleButton simpleButton1;
    }
}