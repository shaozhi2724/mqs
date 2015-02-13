namespace DQS.AppViews.StoreAndCuring.StockManager
{
    partial class FrmSingleInventory
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
            this.ftPanel = new DQS.Controls.FieldTextBoxPanel();
            this.layControl = new DevExpress.XtraLayout.LayoutControl();
            this.txtInventoryArea = new DQS.Controls.BUSInventoryEntityTextBox();
            this.txtInventoryCode = new DQS.Controls.BUSInventoryEntityTextBox();
            this.txtInventoryRemark = new DQS.Controls.BUSInventoryEntityTextBox();
            this.txtInventoryPerson = new DQS.Controls.BUSInventoryEntityTextBox();
            this.layControlGroup = new DevExpress.XtraLayout.LayoutControlGroup();
            this.layStoreCode = new DevExpress.XtraLayout.LayoutControlItem();
            this.layStoreKeeper = new DevExpress.XtraLayout.LayoutControlItem();
            this.layStoreRemark = new DevExpress.XtraLayout.LayoutControlItem();
            this.layoutControlItem1 = new DevExpress.XtraLayout.LayoutControlItem();
            this.panelControl1 = new DevExpress.XtraEditors.PanelControl();
            this.btnUpdateStoreAmount = new DevExpress.XtraEditors.SimpleButton();
            this.btnCancel = new DevExpress.XtraEditors.SimpleButton();
            this.btnSave = new DevExpress.XtraEditors.SimpleButton();
            this.btnOneKeyFinish = new DevExpress.XtraEditors.SimpleButton();
            this.groupControl1 = new DevExpress.XtraEditors.GroupControl();
            this.popupGrid = new DQS.Controls.PopupGrid();
            this.btnImport = new DevExpress.XtraEditors.SimpleButton();
            this.btnExport = new DevExpress.XtraEditors.SimpleButton();
            ((System.ComponentModel.ISupportInitialize)(this.ftPanel)).BeginInit();
            this.ftPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.layControl)).BeginInit();
            this.layControl.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.txtInventoryArea.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtInventoryCode.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtInventoryRemark.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtInventoryPerson.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layControlGroup)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layStoreCode)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layStoreKeeper)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layStoreRemark)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.panelControl1)).BeginInit();
            this.panelControl1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.groupControl1)).BeginInit();
            this.groupControl1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.popupGrid)).BeginInit();
            this.SuspendLayout();
            // 
            // ftPanel
            // 
            this.ftPanel.Controls.Add(this.layControl);
            this.ftPanel.Dock = System.Windows.Forms.DockStyle.Top;
            this.ftPanel.Location = new System.Drawing.Point(0, 0);
            this.ftPanel.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.ftPanel.Name = "ftPanel";
            this.ftPanel.Size = new System.Drawing.Size(997, 95);
            this.ftPanel.TabIndex = 0;
            this.ftPanel.TypeOfEntity = DQS.Module.EntityType2.BUSInventoryEntity;
            // 
            // layControl
            // 
            this.layControl.Controls.Add(this.txtInventoryArea);
            this.layControl.Controls.Add(this.txtInventoryCode);
            this.layControl.Controls.Add(this.txtInventoryRemark);
            this.layControl.Controls.Add(this.txtInventoryPerson);
            this.layControl.Dock = System.Windows.Forms.DockStyle.Fill;
            this.layControl.Location = new System.Drawing.Point(2, 2);
            this.layControl.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.layControl.Name = "layControl";
            this.layControl.Root = this.layControlGroup;
            this.layControl.Size = new System.Drawing.Size(993, 91);
            this.layControl.TabIndex = 0;
            this.layControl.Text = "layControl";
            // 
            // txtInventoryArea
            // 
            this.txtInventoryArea.AlphabeticFiled = null;
            this.txtInventoryArea.EntityField = DQS.Module.Entities.BUSInventoryEntityFields2.InventoryArea;
            this.txtInventoryArea.IsIntegerOnly = false;
            this.txtInventoryArea.IsNullString = "";
            this.txtInventoryArea.IsNullValidate = false;
            this.txtInventoryArea.IsTransferAlphabetic = false;
            this.txtInventoryArea.Location = new System.Drawing.Point(561, 41);
            this.txtInventoryArea.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtInventoryArea.Name = "txtInventoryArea";
            this.txtInventoryArea.Size = new System.Drawing.Size(420, 25);
            this.txtInventoryArea.StyleController = this.layControl;
            this.txtInventoryArea.TabIndex = 3;
            // 
            // txtInventoryCode
            // 
            this.txtInventoryCode.AlphabeticFiled = null;
            this.txtInventoryCode.EntityField = DQS.Module.Entities.BUSInventoryEntityFields2.InventoryCode;
            this.txtInventoryCode.IsIntegerOnly = false;
            this.txtInventoryCode.IsNullString = "盘点单号不能为空。";
            this.txtInventoryCode.IsNullValidate = true;
            this.txtInventoryCode.IsTransferAlphabetic = false;
            this.txtInventoryCode.Location = new System.Drawing.Point(75, 12);
            this.txtInventoryCode.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtInventoryCode.Name = "txtInventoryCode";
            this.txtInventoryCode.Size = new System.Drawing.Size(419, 25);
            this.txtInventoryCode.StyleController = this.layControl;
            this.txtInventoryCode.TabIndex = 0;
            // 
            // txtInventoryRemark
            // 
            this.txtInventoryRemark.AlphabeticFiled = null;
            this.txtInventoryRemark.EntityField = DQS.Module.Entities.BUSInventoryEntityFields2.InventoryRemark;
            this.txtInventoryRemark.IsIntegerOnly = false;
            this.txtInventoryRemark.IsNullString = null;
            this.txtInventoryRemark.IsNullValidate = false;
            this.txtInventoryRemark.IsTransferAlphabetic = false;
            this.txtInventoryRemark.Location = new System.Drawing.Point(75, 41);
            this.txtInventoryRemark.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtInventoryRemark.Name = "txtInventoryRemark";
            this.txtInventoryRemark.Size = new System.Drawing.Size(419, 25);
            this.txtInventoryRemark.StyleController = this.layControl;
            this.txtInventoryRemark.TabIndex = 6;
            // 
            // txtInventoryPerson
            // 
            this.txtInventoryPerson.AlphabeticFiled = "InventoryPersonSpell";
            this.txtInventoryPerson.EntityField = DQS.Module.Entities.BUSInventoryEntityFields2.InventoryPerson;
            this.txtInventoryPerson.IsIntegerOnly = false;
            this.txtInventoryPerson.IsNullString = null;
            this.txtInventoryPerson.IsNullValidate = false;
            this.txtInventoryPerson.IsTransferAlphabetic = true;
            this.txtInventoryPerson.Location = new System.Drawing.Point(561, 12);
            this.txtInventoryPerson.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtInventoryPerson.Name = "txtInventoryPerson";
            this.txtInventoryPerson.Size = new System.Drawing.Size(420, 25);
            this.txtInventoryPerson.StyleController = this.layControl;
            this.txtInventoryPerson.TabIndex = 1;
            // 
            // layControlGroup
            // 
            this.layControlGroup.AppearanceItemCaption.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.layControlGroup.AppearanceItemCaption.Options.UseFont = true;
            this.layControlGroup.CustomizationFormText = "盘点单";
            this.layControlGroup.EnableIndentsWithoutBorders = DevExpress.Utils.DefaultBoolean.True;
            this.layControlGroup.GroupBordersVisible = false;
            this.layControlGroup.Items.AddRange(new DevExpress.XtraLayout.BaseLayoutItem[] {
            this.layStoreCode,
            this.layStoreKeeper,
            this.layStoreRemark,
            this.layoutControlItem1});
            this.layControlGroup.Location = new System.Drawing.Point(0, 0);
            this.layControlGroup.Name = "layControlGroup";
            this.layControlGroup.Size = new System.Drawing.Size(993, 91);
            this.layControlGroup.Spacing = new DevExpress.XtraLayout.Utils.Padding(0, 0, 0, 0);
            this.layControlGroup.Text = "盘点单";
            this.layControlGroup.TextVisible = false;
            // 
            // layStoreCode
            // 
            this.layStoreCode.Control = this.txtInventoryCode;
            this.layStoreCode.CustomizationFormText = "盘点单号";
            this.layStoreCode.Location = new System.Drawing.Point(0, 0);
            this.layStoreCode.Name = "layStoreCode";
            this.layStoreCode.Size = new System.Drawing.Size(486, 29);
            this.layStoreCode.Text = "盘点单号";
            this.layStoreCode.TextSize = new System.Drawing.Size(60, 20);
            // 
            // layStoreKeeper
            // 
            this.layStoreKeeper.Control = this.txtInventoryPerson;
            this.layStoreKeeper.CustomizationFormText = "盘点人";
            this.layStoreKeeper.Location = new System.Drawing.Point(486, 0);
            this.layStoreKeeper.Name = "layStoreKeeper";
            this.layStoreKeeper.Size = new System.Drawing.Size(487, 29);
            this.layStoreKeeper.Text = "盘点人";
            this.layStoreKeeper.TextSize = new System.Drawing.Size(60, 20);
            // 
            // layStoreRemark
            // 
            this.layStoreRemark.Control = this.txtInventoryRemark;
            this.layStoreRemark.CustomizationFormText = "备注";
            this.layStoreRemark.Location = new System.Drawing.Point(0, 29);
            this.layStoreRemark.Name = "layStoreRemark";
            this.layStoreRemark.Size = new System.Drawing.Size(486, 42);
            this.layStoreRemark.Text = "备注";
            this.layStoreRemark.TextSize = new System.Drawing.Size(60, 20);
            // 
            // layoutControlItem1
            // 
            this.layoutControlItem1.Control = this.txtInventoryArea;
            this.layoutControlItem1.CustomizationFormText = "盘点区域";
            this.layoutControlItem1.Location = new System.Drawing.Point(486, 29);
            this.layoutControlItem1.Name = "layoutControlItem1";
            this.layoutControlItem1.Size = new System.Drawing.Size(487, 42);
            this.layoutControlItem1.Text = "盘点区域";
            this.layoutControlItem1.TextSize = new System.Drawing.Size(60, 20);
            // 
            // panelControl1
            // 
            this.panelControl1.Controls.Add(this.btnExport);
            this.panelControl1.Controls.Add(this.btnImport);
            this.panelControl1.Controls.Add(this.btnUpdateStoreAmount);
            this.panelControl1.Controls.Add(this.btnCancel);
            this.panelControl1.Controls.Add(this.btnSave);
            this.panelControl1.Controls.Add(this.btnOneKeyFinish);
            this.panelControl1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panelControl1.Location = new System.Drawing.Point(0, 621);
            this.panelControl1.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.panelControl1.Name = "panelControl1";
            this.panelControl1.Size = new System.Drawing.Size(997, 62);
            this.panelControl1.TabIndex = 1;
            // 
            // btnUpdateStoreAmount
            // 
            this.btnUpdateStoreAmount.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnUpdateStoreAmount.Appearance.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnUpdateStoreAmount.Appearance.Options.UseFont = true;
            this.btnUpdateStoreAmount.Location = new System.Drawing.Point(714, 17);
            this.btnUpdateStoreAmount.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnUpdateStoreAmount.Name = "btnUpdateStoreAmount";
            this.btnUpdateStoreAmount.Size = new System.Drawing.Size(151, 30);
            this.btnUpdateStoreAmount.TabIndex = 3;
            this.btnUpdateStoreAmount.Text = "保存并更新库存(&U)";
            this.btnUpdateStoreAmount.Click += new System.EventHandler(this.btnUpdateStoreAmount_Click);
            // 
            // btnCancel
            // 
            this.btnCancel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnCancel.Appearance.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCancel.Appearance.Options.UseFont = true;
            this.btnCancel.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btnCancel.Location = new System.Drawing.Point(895, 17);
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
            this.btnSave.Location = new System.Drawing.Point(602, 17);
            this.btnSave.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(86, 30);
            this.btnSave.TabIndex = 0;
            this.btnSave.Text = "保存(&S)";
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // btnOneKeyFinish
            // 
            this.btnOneKeyFinish.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnOneKeyFinish.Appearance.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnOneKeyFinish.Appearance.Options.UseFont = true;
            this.btnOneKeyFinish.Location = new System.Drawing.Point(391, 17);
            this.btnOneKeyFinish.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnOneKeyFinish.Name = "btnOneKeyFinish";
            this.btnOneKeyFinish.Size = new System.Drawing.Size(128, 30);
            this.btnOneKeyFinish.TabIndex = 2;
            this.btnOneKeyFinish.Text = "一键完成(&K)";
            this.btnOneKeyFinish.Click += new System.EventHandler(this.btnOneKeyFinish_Click);
            // 
            // groupControl1
            // 
            this.groupControl1.AppearanceCaption.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupControl1.AppearanceCaption.Options.UseFont = true;
            this.groupControl1.Controls.Add(this.popupGrid);
            this.groupControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupControl1.Location = new System.Drawing.Point(0, 95);
            this.groupControl1.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.groupControl1.Name = "groupControl1";
            this.groupControl1.Size = new System.Drawing.Size(997, 526);
            this.groupControl1.TabIndex = 2;
            this.groupControl1.Text = "盘点单明细";
            // 
            // popupGrid
            // 
            this.popupGrid.Dock = System.Windows.Forms.DockStyle.Fill;
            this.popupGrid.EmbeddedNavigator.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.popupGrid.IsCalculatePrice = false;
            this.popupGrid.Location = new System.Drawing.Point(2, 28);
            this.popupGrid.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.popupGrid.Name = "popupGrid";
            this.popupGrid.OperationName = "Inventory";
            this.popupGrid.Size = new System.Drawing.Size(993, 496);
            this.popupGrid.TabIndex = 4;
            this.popupGrid.PopupClosed += new DQS.Controls.PopupGrid.OnPopupClosedEventHandler(this.popupGrid_PopupClosed);
            this.popupGrid.BeforePopupFormShow += new DQS.Controls.PopupGrid.OnBeforePopupFormShowEventHandler(this.popupGrid_BeforePopupFormShow);
            // 
            // btnImport
            // 
            this.btnImport.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnImport.Appearance.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnImport.Appearance.Options.UseFont = true;
            this.btnImport.Location = new System.Drawing.Point(210, 17);
            this.btnImport.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnImport.Name = "btnImport";
            this.btnImport.Size = new System.Drawing.Size(128, 30);
            this.btnImport.TabIndex = 4;
            this.btnImport.Text = "导入盘点结果(&I)";
            this.btnImport.Click += new System.EventHandler(this.btnImport_Click);
            // 
            // btnExport
            // 
            this.btnExport.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnExport.Appearance.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnExport.Appearance.Options.UseFont = true;
            this.btnExport.Location = new System.Drawing.Point(44, 17);
            this.btnExport.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnExport.Name = "btnExport";
            this.btnExport.Size = new System.Drawing.Size(128, 30);
            this.btnExport.TabIndex = 5;
            this.btnExport.Text = "导出盘点明细(&E)";
            this.btnExport.Click += new System.EventHandler(this.btnExport_Click);
            // 
            // FrmSingleInventory
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 18F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(997, 683);
            this.Controls.Add(this.groupControl1);
            this.Controls.Add(this.panelControl1);
            this.Controls.Add(this.ftPanel);
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FrmSingleInventory";
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "盘点单";
            this.Load += new System.EventHandler(this.FrmSingleInventory_Load);
            ((System.ComponentModel.ISupportInitialize)(this.ftPanel)).EndInit();
            this.ftPanel.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.layControl)).EndInit();
            this.layControl.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.txtInventoryArea.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtInventoryCode.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtInventoryRemark.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtInventoryPerson.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layControlGroup)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layStoreCode)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layStoreKeeper)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layStoreRemark)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.panelControl1)).EndInit();
            this.panelControl1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.groupControl1)).EndInit();
            this.groupControl1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.popupGrid)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DQS.Controls.FieldTextBoxPanel ftPanel;
        private DevExpress.XtraLayout.LayoutControl layControl;
        private DevExpress.XtraLayout.LayoutControlGroup layControlGroup;
        private DevExpress.XtraEditors.PanelControl panelControl1;
        private DevExpress.XtraEditors.SimpleButton btnCancel;
        private DevExpress.XtraEditors.SimpleButton btnSave;
        private DevExpress.XtraEditors.SimpleButton btnOneKeyFinish;
        private DevExpress.XtraLayout.LayoutControlItem layStoreCode;
        private DevExpress.XtraLayout.LayoutControlItem layStoreKeeper;
        private DevExpress.XtraLayout.LayoutControlItem layStoreRemark;
        private DevExpress.XtraEditors.GroupControl groupControl1;
        private DQS.Controls.PopupGrid popupGrid;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlItem1;
        private DQS.Controls.BUSInventoryEntityTextBox txtInventoryCode;
        private DQS.Controls.BUSInventoryEntityTextBox txtInventoryRemark;
        private DQS.Controls.BUSInventoryEntityTextBox txtInventoryPerson;
        private DQS.Controls.BUSInventoryEntityTextBox txtInventoryArea;
        private DevExpress.XtraEditors.SimpleButton btnUpdateStoreAmount;
        private DevExpress.XtraEditors.SimpleButton btnExport;
        private DevExpress.XtraEditors.SimpleButton btnImport;
    }
}