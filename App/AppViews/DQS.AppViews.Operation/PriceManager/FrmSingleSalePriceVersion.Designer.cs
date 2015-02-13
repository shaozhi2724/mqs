namespace DQS.AppViews.Operation.PriceManager
{
    partial class FrmSingleSalePriceVersion
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
            this.components = new System.ComponentModel.Container();
            this.pnlAction = new DevExpress.XtraEditors.PanelControl();
            this.btnCancel = new DevExpress.XtraEditors.SimpleButton();
            this.btnSave = new DevExpress.XtraEditors.SimpleButton();
            this.groupButtom = new DevExpress.XtraEditors.GroupControl();
            this.popupGrid = new DQS.Controls.PopupGrid();
            this.barDockControlLeft = new DevExpress.XtraBars.BarDockControl();
            this.barDockControlRight = new DevExpress.XtraBars.BarDockControl();
            this.barDockControlBottom = new DevExpress.XtraBars.BarDockControl();
            this.barDockControlTop = new DevExpress.XtraBars.BarDockControl();
            this.ftPanel = new DQS.Controls.FieldTextBoxPanel();
            this.layControl = new DevExpress.XtraLayout.LayoutControl();
            this.dteEnd = new DevExpress.XtraEditors.DateEdit();
            this.dteStart = new DevExpress.XtraEditors.DateEdit();
            this.txtPriceListName = new DQS.Controls.TextBoxEx();
            this.txtActive = new DevExpress.XtraEditors.CheckEdit();
            this.txtPriceListVersionName = new DQS.Controls.BFIPriceListVersionEntityTextBox();
            this.layControlGroup = new DevExpress.XtraLayout.LayoutControlGroup();
            this.layPriceListVersionName = new DevExpress.XtraLayout.LayoutControlItem();
            this.layoutControlItem1 = new DevExpress.XtraLayout.LayoutControlItem();
            this.layPriceListName = new DevExpress.XtraLayout.LayoutControlItem();
            this.layStartDate = new DevExpress.XtraLayout.LayoutControlItem();
            this.layEndDate = new DevExpress.XtraLayout.LayoutControlItem();
            this.barManager1 = new DevExpress.XtraBars.BarManager(this.components);
            this.bar1 = new DevExpress.XtraBars.Bar();
            this.btnAdd = new DevExpress.XtraBars.BarButtonItem();
            this.btnEdit = new DevExpress.XtraBars.BarButtonItem();
            this.btnDelete = new DevExpress.XtraBars.BarButtonItem();
            ((System.ComponentModel.ISupportInitialize)(this.pnlAction)).BeginInit();
            this.pnlAction.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.groupButtom)).BeginInit();
            this.groupButtom.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.popupGrid)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ftPanel)).BeginInit();
            this.ftPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.layControl)).BeginInit();
            this.layControl.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dteEnd.Properties.VistaTimeProperties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dteEnd.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dteStart.Properties.VistaTimeProperties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dteStart.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtPriceListName.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtActive.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtPriceListVersionName.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layControlGroup)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layPriceListVersionName)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layPriceListName)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layStartDate)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layEndDate)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.barManager1)).BeginInit();
            this.SuspendLayout();
            // 
            // pnlAction
            // 
            this.pnlAction.Controls.Add(this.btnCancel);
            this.pnlAction.Controls.Add(this.btnSave);
            this.pnlAction.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.pnlAction.Location = new System.Drawing.Point(0, 621);
            this.pnlAction.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.pnlAction.Name = "pnlAction";
            this.pnlAction.Size = new System.Drawing.Size(782, 62);
            this.pnlAction.TabIndex = 1;
            // 
            // btnCancel
            // 
            this.btnCancel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnCancel.Appearance.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCancel.Appearance.Options.UseFont = true;
            this.btnCancel.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btnCancel.Location = new System.Drawing.Point(680, 17);
            this.btnCancel.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(86, 30);
            this.btnCancel.TabIndex = 1;
            this.btnCancel.Text = "取消(&C)";
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // btnSave
            // 
            this.btnSave.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnSave.Appearance.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSave.Appearance.Options.UseFont = true;
            this.btnSave.Location = new System.Drawing.Point(560, 17);
            this.btnSave.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(86, 30);
            this.btnSave.TabIndex = 0;
            this.btnSave.Text = "保存(&S)";
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // groupButtom
            // 
            this.groupButtom.AppearanceCaption.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupButtom.AppearanceCaption.Options.UseFont = true;
            this.groupButtom.Controls.Add(this.popupGrid);
            this.groupButtom.Controls.Add(this.barDockControlLeft);
            this.groupButtom.Controls.Add(this.barDockControlRight);
            this.groupButtom.Controls.Add(this.barDockControlBottom);
            this.groupButtom.Controls.Add(this.barDockControlTop);
            this.groupButtom.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupButtom.Location = new System.Drawing.Point(0, 149);
            this.groupButtom.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.groupButtom.Name = "groupButtom";
            this.groupButtom.Size = new System.Drawing.Size(782, 472);
            this.groupButtom.TabIndex = 2;
            this.groupButtom.Text = "价格表明细";
            // 
            // popupGrid
            // 
            this.popupGrid.Dock = System.Windows.Forms.DockStyle.Fill;
            this.popupGrid.EmbeddedNavigator.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.popupGrid.IsCalculatePrice = false;
            this.popupGrid.Location = new System.Drawing.Point(2, 78);
            this.popupGrid.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.popupGrid.Name = "popupGrid";
            this.popupGrid.OperationName = "SalePriceListItem";
            this.popupGrid.Size = new System.Drawing.Size(778, 392);
            this.popupGrid.TabIndex = 0;
            // 
            // barDockControlLeft
            // 
            this.barDockControlLeft.Dock = System.Windows.Forms.DockStyle.Left;
            this.barDockControlLeft.Location = new System.Drawing.Point(2, 78);
            this.barDockControlLeft.Size = new System.Drawing.Size(0, 392);
            // 
            // barDockControlRight
            // 
            this.barDockControlRight.Dock = System.Windows.Forms.DockStyle.Right;
            this.barDockControlRight.Location = new System.Drawing.Point(780, 78);
            this.barDockControlRight.Size = new System.Drawing.Size(0, 392);
            // 
            // barDockControlBottom
            // 
            this.barDockControlBottom.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.barDockControlBottom.Location = new System.Drawing.Point(2, 470);
            this.barDockControlBottom.Size = new System.Drawing.Size(778, 0);
            // 
            // barDockControlTop
            // 
            this.barDockControlTop.Dock = System.Windows.Forms.DockStyle.Top;
            this.barDockControlTop.Location = new System.Drawing.Point(2, 28);
            this.barDockControlTop.Size = new System.Drawing.Size(778, 50);
            // 
            // ftPanel
            // 
            this.ftPanel.Controls.Add(this.layControl);
            this.ftPanel.Dock = System.Windows.Forms.DockStyle.Top;
            this.ftPanel.Location = new System.Drawing.Point(0, 0);
            this.ftPanel.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.ftPanel.Name = "ftPanel";
            this.ftPanel.Size = new System.Drawing.Size(782, 149);
            this.ftPanel.TabIndex = 0;
            this.ftPanel.TypeOfEntity = DQS.Module.EntityType2.BFIPriceListVersionEntity;
            // 
            // layControl
            // 
            this.layControl.Controls.Add(this.dteEnd);
            this.layControl.Controls.Add(this.dteStart);
            this.layControl.Controls.Add(this.txtPriceListName);
            this.layControl.Controls.Add(this.txtActive);
            this.layControl.Controls.Add(this.txtPriceListVersionName);
            this.layControl.Dock = System.Windows.Forms.DockStyle.Fill;
            this.layControl.Location = new System.Drawing.Point(2, 2);
            this.layControl.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.layControl.Name = "layControl";
            this.layControl.Root = this.layControlGroup;
            this.layControl.Size = new System.Drawing.Size(778, 145);
            this.layControl.TabIndex = 0;
            this.layControl.Text = "layControl";
            // 
            // dteEnd
            // 
            this.dteEnd.EditValue = null;
            this.dteEnd.Location = new System.Drawing.Point(510, 97);
            this.dteEnd.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.dteEnd.Name = "dteEnd";
            this.dteEnd.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.dteEnd.Properties.VistaTimeProperties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton()});
            this.dteEnd.Size = new System.Drawing.Size(256, 25);
            this.dteEnd.StyleController = this.layControl;
            this.dteEnd.TabIndex = 8;
            // 
            // dteStart
            // 
            this.dteStart.EditValue = null;
            this.dteStart.Location = new System.Drawing.Point(131, 97);
            this.dteStart.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.dteStart.Name = "dteStart";
            this.dteStart.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.dteStart.Properties.VistaTimeProperties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton()});
            this.dteStart.Size = new System.Drawing.Size(256, 25);
            this.dteStart.StyleController = this.layControl;
            this.dteStart.TabIndex = 6;
            // 
            // txtPriceListName
            // 
            this.txtPriceListName.AlphabeticFiled = null;
            this.txtPriceListName.IsIntegerOnly = false;
            this.txtPriceListName.IsNullString = "采购价格表名称不能为空。";
            this.txtPriceListName.IsNullValidate = true;
            this.txtPriceListName.IsTransferAlphabetic = false;
            this.txtPriceListName.Location = new System.Drawing.Point(131, 12);
            this.txtPriceListName.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtPriceListName.Name = "txtPriceListName";
            this.txtPriceListName.Properties.ReadOnly = true;
            this.txtPriceListName.Size = new System.Drawing.Size(635, 25);
            this.txtPriceListName.StyleController = this.layControl;
            this.txtPriceListName.TabIndex = 5;
            // 
            // txtActive
            // 
            this.txtActive.EditValue = true;
            this.txtActive.Location = new System.Drawing.Point(12, 70);
            this.txtActive.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtActive.Name = "txtActive";
            this.txtActive.Properties.Appearance.BackColor = System.Drawing.Color.White;
            this.txtActive.Properties.Appearance.Options.UseBackColor = true;
            this.txtActive.Properties.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.Default;
            this.txtActive.Properties.Caption = "可用";
            this.txtActive.Properties.NullStyle = DevExpress.XtraEditors.Controls.StyleIndeterminate.Unchecked;
            this.txtActive.Size = new System.Drawing.Size(754, 23);
            this.txtActive.StyleController = this.layControl;
            this.txtActive.TabIndex = 2;
            // 
            // txtPriceListVersionName
            // 
            this.txtPriceListVersionName.AlphabeticFiled = null;
            this.txtPriceListVersionName.EntityField = DQS.Module.Entities.BFIPriceListVersionEntityFields2.PriceListVersionName;
            this.txtPriceListVersionName.IsIntegerOnly = false;
            this.txtPriceListVersionName.IsNullString = "价格表版本名称不能为空。";
            this.txtPriceListVersionName.IsNullValidate = true;
            this.txtPriceListVersionName.IsTransferAlphabetic = false;
            this.txtPriceListVersionName.Location = new System.Drawing.Point(131, 41);
            this.txtPriceListVersionName.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtPriceListVersionName.Name = "txtPriceListVersionName";
            this.txtPriceListVersionName.Size = new System.Drawing.Size(635, 25);
            this.txtPriceListVersionName.StyleController = this.layControl;
            this.txtPriceListVersionName.TabIndex = 0;
            // 
            // layControlGroup
            // 
            this.layControlGroup.AppearanceItemCaption.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.layControlGroup.AppearanceItemCaption.Options.UseFont = true;
            this.layControlGroup.CustomizationFormText = "采购订单";
            this.layControlGroup.EnableIndentsWithoutBorders = DevExpress.Utils.DefaultBoolean.True;
            this.layControlGroup.GroupBordersVisible = false;
            this.layControlGroup.Items.AddRange(new DevExpress.XtraLayout.BaseLayoutItem[] {
            this.layPriceListVersionName,
            this.layoutControlItem1,
            this.layPriceListName,
            this.layStartDate,
            this.layEndDate});
            this.layControlGroup.Location = new System.Drawing.Point(0, 0);
            this.layControlGroup.Name = "layControlGroup";
            this.layControlGroup.Size = new System.Drawing.Size(778, 145);
            this.layControlGroup.Spacing = new DevExpress.XtraLayout.Utils.Padding(0, 0, 0, 0);
            this.layControlGroup.Text = "采购订单";
            this.layControlGroup.TextVisible = false;
            // 
            // layPriceListVersionName
            // 
            this.layPriceListVersionName.Control = this.txtPriceListVersionName;
            this.layPriceListVersionName.CustomizationFormText = "价格表名称";
            this.layPriceListVersionName.Location = new System.Drawing.Point(0, 29);
            this.layPriceListVersionName.Name = "layPriceListVersionName";
            this.layPriceListVersionName.Size = new System.Drawing.Size(758, 29);
            this.layPriceListVersionName.Text = "价格表版本名称 *";
            this.layPriceListVersionName.TextSize = new System.Drawing.Size(116, 20);
            // 
            // layoutControlItem1
            // 
            this.layoutControlItem1.Control = this.txtActive;
            this.layoutControlItem1.CustomizationFormText = "layoutControlItem1";
            this.layoutControlItem1.Location = new System.Drawing.Point(0, 58);
            this.layoutControlItem1.Name = "layoutControlItem1";
            this.layoutControlItem1.Size = new System.Drawing.Size(758, 27);
            this.layoutControlItem1.Text = "layoutControlItem1";
            this.layoutControlItem1.TextSize = new System.Drawing.Size(0, 0);
            this.layoutControlItem1.TextToControlDistance = 0;
            this.layoutControlItem1.TextVisible = false;
            // 
            // layPriceListName
            // 
            this.layPriceListName.Control = this.txtPriceListName;
            this.layPriceListName.CustomizationFormText = "layoutControlItem2";
            this.layPriceListName.Location = new System.Drawing.Point(0, 0);
            this.layPriceListName.Name = "layPriceListName";
            this.layPriceListName.Size = new System.Drawing.Size(758, 29);
            this.layPriceListName.Text = "价格表名称";
            this.layPriceListName.TextSize = new System.Drawing.Size(116, 20);
            // 
            // layStartDate
            // 
            this.layStartDate.Control = this.dteStart;
            this.layStartDate.CustomizationFormText = "开始日期";
            this.layStartDate.Location = new System.Drawing.Point(0, 85);
            this.layStartDate.Name = "layStartDate";
            this.layStartDate.Size = new System.Drawing.Size(379, 40);
            this.layStartDate.Text = "开始日期";
            this.layStartDate.TextSize = new System.Drawing.Size(116, 20);
            // 
            // layEndDate
            // 
            this.layEndDate.Control = this.dteEnd;
            this.layEndDate.CustomizationFormText = "结束日期";
            this.layEndDate.Location = new System.Drawing.Point(379, 85);
            this.layEndDate.Name = "layEndDate";
            this.layEndDate.Size = new System.Drawing.Size(379, 40);
            this.layEndDate.Text = "结束日期";
            this.layEndDate.TextSize = new System.Drawing.Size(116, 20);
            // 
            // barManager1
            // 
            this.barManager1.AllowMoveBarOnToolbar = false;
            this.barManager1.AllowQuickCustomization = false;
            this.barManager1.AllowShowToolbarsPopup = false;
            this.barManager1.Bars.AddRange(new DevExpress.XtraBars.Bar[] {
            this.bar1});
            this.barManager1.CloseButtonAffectAllTabs = false;
            this.barManager1.DockControls.Add(this.barDockControlTop);
            this.barManager1.DockControls.Add(this.barDockControlBottom);
            this.barManager1.DockControls.Add(this.barDockControlLeft);
            this.barManager1.DockControls.Add(this.barDockControlRight);
            this.barManager1.Form = this.groupButtom;
            this.barManager1.Items.AddRange(new DevExpress.XtraBars.BarItem[] {
            this.btnAdd,
            this.btnEdit,
            this.btnDelete});
            this.barManager1.MaxItemId = 3;
            // 
            // bar1
            // 
            this.bar1.BarName = "Custom 1";
            this.bar1.DockCol = 0;
            this.bar1.DockRow = 0;
            this.bar1.DockStyle = DevExpress.XtraBars.BarDockStyle.Top;
            this.bar1.LinksPersistInfo.AddRange(new DevExpress.XtraBars.LinkPersistInfo[] {
            new DevExpress.XtraBars.LinkPersistInfo(DevExpress.XtraBars.BarLinkUserDefines.PaintStyle, this.btnAdd, DevExpress.XtraBars.BarItemPaintStyle.CaptionGlyph),
            new DevExpress.XtraBars.LinkPersistInfo(this.btnEdit),
            new DevExpress.XtraBars.LinkPersistInfo(this.btnDelete)});
            this.bar1.OptionsBar.AllowQuickCustomization = false;
            this.bar1.OptionsBar.DisableClose = true;
            this.bar1.OptionsBar.DisableCustomization = true;
            this.bar1.OptionsBar.DrawDragBorder = false;
            this.bar1.OptionsBar.UseWholeRow = true;
            this.bar1.Text = "工具栏";
            // 
            // btnAdd
            // 
            this.btnAdd.Caption = "新建";
            this.btnAdd.Glyph = global::DQS.AppViews.Operation.Properties.Resources.add;
            this.btnAdd.Id = 0;
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.PaintStyle = DevExpress.XtraBars.BarItemPaintStyle.CaptionGlyph;
            this.btnAdd.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.btnAdd_ItemClick);
            // 
            // btnEdit
            // 
            this.btnEdit.Caption = "修改";
            this.btnEdit.Glyph = global::DQS.AppViews.Operation.Properties.Resources.edit_button;
            this.btnEdit.Id = 1;
            this.btnEdit.Name = "btnEdit";
            this.btnEdit.PaintStyle = DevExpress.XtraBars.BarItemPaintStyle.CaptionGlyph;
            this.btnEdit.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.btnEdit_ItemClick);
            // 
            // btnDelete
            // 
            this.btnDelete.Caption = "删除";
            this.btnDelete.Glyph = global::DQS.AppViews.Operation.Properties.Resources.delete;
            this.btnDelete.Id = 2;
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.PaintStyle = DevExpress.XtraBars.BarItemPaintStyle.CaptionGlyph;
            this.btnDelete.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.btnDelete_ItemClick);
            // 
            // FrmSingleSalePriceVersion
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 18F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(782, 683);
            this.Controls.Add(this.groupButtom);
            this.Controls.Add(this.pnlAction);
            this.Controls.Add(this.ftPanel);
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.MinimizeBox = false;
            this.Name = "FrmSingleSalePriceVersion";
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "销售价格表版本";
            this.Load += new System.EventHandler(this.FrmSingleSalePriceVersion_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pnlAction)).EndInit();
            this.pnlAction.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.groupButtom)).EndInit();
            this.groupButtom.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.popupGrid)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ftPanel)).EndInit();
            this.ftPanel.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.layControl)).EndInit();
            this.layControl.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dteEnd.Properties.VistaTimeProperties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dteEnd.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dteStart.Properties.VistaTimeProperties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dteStart.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtPriceListName.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtActive.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtPriceListVersionName.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layControlGroup)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layPriceListVersionName)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layPriceListName)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layStartDate)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layEndDate)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.barManager1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DQS.Controls.FieldTextBoxPanel ftPanel;
        private DevExpress.XtraEditors.PanelControl pnlAction;
        private DevExpress.XtraEditors.SimpleButton btnCancel;
        private DevExpress.XtraEditors.SimpleButton btnSave;
        private DevExpress.XtraLayout.LayoutControl layControl;
        private DQS.Controls.BFIPriceListVersionEntityTextBox txtPriceListVersionName;
        private DevExpress.XtraLayout.LayoutControlGroup layControlGroup;
        private DevExpress.XtraLayout.LayoutControlItem layPriceListVersionName;
        private DevExpress.XtraEditors.GroupControl groupButtom;
        private DQS.Controls.PopupGrid popupGrid;
        private DevExpress.XtraEditors.CheckEdit txtActive;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlItem1;
        private DevExpress.XtraBars.BarManager barManager1;
        private DevExpress.XtraBars.BarDockControl barDockControlLeft;
        private DevExpress.XtraBars.BarDockControl barDockControlRight;
        private DevExpress.XtraBars.BarDockControl barDockControlBottom;
        private DevExpress.XtraBars.BarDockControl barDockControlTop;
        private DevExpress.XtraBars.Bar bar1;
        private DevExpress.XtraBars.BarButtonItem btnAdd;
        private DevExpress.XtraBars.BarButtonItem btnEdit;
        private DevExpress.XtraBars.BarButtonItem btnDelete;
        private Controls.TextBoxEx txtPriceListName;
        private DevExpress.XtraLayout.LayoutControlItem layPriceListName;
        private DevExpress.XtraEditors.DateEdit dteStart;
        private DevExpress.XtraLayout.LayoutControlItem layStartDate;
        private DevExpress.XtraEditors.DateEdit dteEnd;
        private DevExpress.XtraLayout.LayoutControlItem layEndDate;

    }
}