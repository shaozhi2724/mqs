namespace DQS.AppViews.WarehouseOut.WarehouseOutManager
{
    partial class FrmSingleStockOut
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
            this.txtBillCode = new DQS.Controls.TextBoxPopupEx();
            this.txtStoreCode = new DQS.Controls.BUSStoreBillEntityTextBox();
            this.txtStoreRemark = new DQS.Controls.BUSStoreBillEntityTextBox();
            this.txtStoreKeeper = new DQS.Controls.TextBoxEnterPopupEx();
            this.txtBillTypeName = new DQS.Controls.BUSStoreBillEntityTextBox();
            this.txtDealerName = new DQS.Controls.BUSStoreBillEntityTextBox();
            this.layControlGroup = new DevExpress.XtraLayout.LayoutControlGroup();
            this.layStoreCode = new DevExpress.XtraLayout.LayoutControlItem();
            this.layStoreKeeper = new DevExpress.XtraLayout.LayoutControlItem();
            this.layDealerName = new DevExpress.XtraLayout.LayoutControlItem();
            this.layStoreRemark = new DevExpress.XtraLayout.LayoutControlItem();
            this.layStoreTypeName = new DevExpress.XtraLayout.LayoutControlItem();
            this.laySaleBillCode = new DevExpress.XtraLayout.LayoutControlItem();
            this.panelControl1 = new DevExpress.XtraEditors.PanelControl();
            this.btnPrint = new DQS.Controls.StiPrintButtonEx();
            this.btnOneKeyFinish = new DevExpress.XtraEditors.SimpleButton();
            this.btnSave = new DevExpress.XtraEditors.SimpleButton();
            this.groupControl1 = new DevExpress.XtraEditors.GroupControl();
            this.popupGrid = new DQS.Controls.PopupGrid();
            this.btnCancel = new DevExpress.XtraEditors.SimpleButton();
            ((System.ComponentModel.ISupportInitialize)(this.ftPanel)).BeginInit();
            this.ftPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.layControl)).BeginInit();
            this.layControl.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.txtBillCode.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtStoreCode.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtStoreRemark.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtStoreKeeper.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtBillTypeName.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtDealerName.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layControlGroup)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layStoreCode)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layStoreKeeper)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layDealerName)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layStoreRemark)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layStoreTypeName)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.laySaleBillCode)).BeginInit();
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
            this.ftPanel.Name = "ftPanel";
            this.ftPanel.Size = new System.Drawing.Size(872, 125);
            this.ftPanel.TabIndex = 0;
            this.ftPanel.TypeOfEntity = DQS.Module.EntityType2.BUSStoreBillEntity;
            // 
            // layControl
            // 
            this.layControl.Controls.Add(this.txtBillCode);
            this.layControl.Controls.Add(this.txtStoreCode);
            this.layControl.Controls.Add(this.txtStoreRemark);
            this.layControl.Controls.Add(this.txtStoreKeeper);
            this.layControl.Controls.Add(this.txtBillTypeName);
            this.layControl.Controls.Add(this.txtDealerName);
            this.layControl.Dock = System.Windows.Forms.DockStyle.Fill;
            this.layControl.Location = new System.Drawing.Point(2, 2);
            this.layControl.Name = "layControl";
            this.layControl.Root = this.layControlGroup;
            this.layControl.Size = new System.Drawing.Size(868, 121);
            this.layControl.TabIndex = 0;
            this.layControl.Text = "layControl";
            // 
            // txtBillCode
            // 
            this.txtBillCode.AlphabeticFiled = "";
            this.txtBillCode.EditData = null;
            this.txtBillCode.Fields = "";
            this.txtBillCode.Filter = "[状态] = \'已审核\'";
            this.txtBillCode.FormatQueryString = "[订单编号] = \'{0}\'";
            this.txtBillCode.GroupColumn = null;
            this.txtBillCode.IsIntegerOnly = false;
            this.txtBillCode.IsNullString = "订单编号不能为空。";
            this.txtBillCode.IsNullValidate = true;
            this.txtBillCode.IsTransferAlphabetic = false;
            this.txtBillCode.Location = new System.Drawing.Point(63, 37);
            this.txtBillCode.MemberText = "订单编号";
            this.txtBillCode.MemberValue = "订单ID";
            this.txtBillCode.Name = "txtBillCode";
            this.txtBillCode.PageSize = 0;
            this.txtBillCode.PrimaryField = "订单ID";
            this.txtBillCode.Properties.Appearance.BackColor = System.Drawing.Color.White;
            this.txtBillCode.Properties.Appearance.Options.UseBackColor = true;
            this.txtBillCode.Properties.ReadOnly = true;
            this.txtBillCode.Size = new System.Drawing.Size(369, 21);
            this.txtBillCode.StyleController = this.layControl;
            this.txtBillCode.TabIndex = 6;
            this.txtBillCode.ViewName = "vw_AllWarehouseOutBill";
            this.txtBillCode.PopupClosing += new DQS.Controls.TextBoxPopupEx.OnPopupClosingDelegate(this.txtBillCode_PopupClosing);
            // 
            // txtStoreCode
            // 
            this.txtStoreCode.AlphabeticFiled = null;
            this.txtStoreCode.EntityField = DQS.Module.Entities.BUSStoreBillEntityFields2.StoreCode;
            this.txtStoreCode.IsIntegerOnly = false;
            this.txtStoreCode.IsNullString = "出库单号不能为空。";
            this.txtStoreCode.IsNullValidate = true;
            this.txtStoreCode.IsTransferAlphabetic = false;
            this.txtStoreCode.Location = new System.Drawing.Point(63, 12);
            this.txtStoreCode.Name = "txtStoreCode";
            this.txtStoreCode.Size = new System.Drawing.Size(369, 21);
            this.txtStoreCode.StyleController = this.layControl;
            this.txtStoreCode.TabIndex = 0;
            // 
            // txtStoreRemark
            // 
            this.txtStoreRemark.AlphabeticFiled = null;
            this.txtStoreRemark.EntityField = DQS.Module.Entities.BUSStoreBillEntityFields2.StoreRemark;
            this.txtStoreRemark.IsIntegerOnly = false;
            this.txtStoreRemark.IsNullString = null;
            this.txtStoreRemark.IsNullValidate = false;
            this.txtStoreRemark.IsTransferAlphabetic = false;
            this.txtStoreRemark.Location = new System.Drawing.Point(63, 87);
            this.txtStoreRemark.Name = "txtStoreRemark";
            this.txtStoreRemark.Size = new System.Drawing.Size(793, 21);
            this.txtStoreRemark.StyleController = this.layControl;
            this.txtStoreRemark.TabIndex = 6;
            // 
            // txtStoreKeeper
            // 
            this.txtStoreKeeper.AlphabeticFiled = "StoreKeeperSpell";
            this.txtStoreKeeper.EditData = null;
            this.txtStoreKeeper.Fields = null;
            this.txtStoreKeeper.Filter = "[岗位名称] = \'库管员\'";
            this.txtStoreKeeper.FormatQueryString = "[员工编号] LIKE \'%{0}%\' OR ([员工姓名] LIKE \'%{0}%\' OR [员工姓名Spell] LIKE \'%{0}%\')";
            this.txtStoreKeeper.GroupColumn = null;
            this.txtStoreKeeper.IsIntegerOnly = false;
            this.txtStoreKeeper.IsNullString = null;
            this.txtStoreKeeper.IsNullValidate = false;
            this.txtStoreKeeper.IsTransferAlphabetic = true;
            this.txtStoreKeeper.Location = new System.Drawing.Point(487, 12);
            this.txtStoreKeeper.MemberText = "员工姓名";
            this.txtStoreKeeper.MemberValue = "员工ID";
            this.txtStoreKeeper.Name = "txtStoreKeeper";
            this.txtStoreKeeper.PageSize = 0;
            this.txtStoreKeeper.PrimaryField = "员工ID";
            this.txtStoreKeeper.Properties.Appearance.BackColor = System.Drawing.Color.White;
            this.txtStoreKeeper.Properties.Appearance.Options.UseBackColor = true;
            this.txtStoreKeeper.Properties.ReadOnly = true;
            this.txtStoreKeeper.Size = new System.Drawing.Size(369, 21);
            this.txtStoreKeeper.StyleController = this.layControl;
            this.txtStoreKeeper.TabIndex = 1;
            this.txtStoreKeeper.ViewName = "vw_AllEmployee";
            // 
            // txtBillTypeName
            // 
            this.txtBillTypeName.AlphabeticFiled = "StoreTypeSpell";
            this.txtBillTypeName.EntityField = DQS.Module.Entities.BUSStoreBillEntityFields2.StoreTypeName;
            this.txtBillTypeName.IsIntegerOnly = false;
            this.txtBillTypeName.IsNullString = null;
            this.txtBillTypeName.IsNullValidate = false;
            this.txtBillTypeName.IsTransferAlphabetic = true;
            this.txtBillTypeName.Location = new System.Drawing.Point(487, 37);
            this.txtBillTypeName.Name = "txtBillTypeName";
            this.txtBillTypeName.Properties.ReadOnly = true;
            this.txtBillTypeName.Size = new System.Drawing.Size(369, 21);
            this.txtBillTypeName.StyleController = this.layControl;
            this.txtBillTypeName.TabIndex = 5;
            // 
            // txtDealerName
            // 
            this.txtDealerName.AlphabeticFiled = "DealerSpell";
            this.txtDealerName.EntityField = DQS.Module.Entities.BUSStoreBillEntityFields2.DealerName;
            this.txtDealerName.IsIntegerOnly = false;
            this.txtDealerName.IsNullString = null;
            this.txtDealerName.IsNullValidate = false;
            this.txtDealerName.IsTransferAlphabetic = true;
            this.txtDealerName.Location = new System.Drawing.Point(63, 62);
            this.txtDealerName.Name = "txtDealerName";
            this.txtDealerName.Properties.ReadOnly = true;
            this.txtDealerName.Size = new System.Drawing.Size(793, 21);
            this.txtDealerName.StyleController = this.layControl;
            this.txtDealerName.TabIndex = 4;
            // 
            // layControlGroup
            // 
            this.layControlGroup.AppearanceItemCaption.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.layControlGroup.AppearanceItemCaption.Options.UseFont = true;
            this.layControlGroup.CustomizationFormText = "出库单";
            this.layControlGroup.EnableIndentsWithoutBorders = DevExpress.Utils.DefaultBoolean.True;
            this.layControlGroup.GroupBordersVisible = false;
            this.layControlGroup.Items.AddRange(new DevExpress.XtraLayout.BaseLayoutItem[] {
            this.layStoreCode,
            this.layStoreKeeper,
            this.layDealerName,
            this.layStoreRemark,
            this.layStoreTypeName,
            this.laySaleBillCode});
            this.layControlGroup.Location = new System.Drawing.Point(0, 0);
            this.layControlGroup.Name = "layControlGroup";
            this.layControlGroup.Size = new System.Drawing.Size(868, 121);
            this.layControlGroup.Spacing = new DevExpress.XtraLayout.Utils.Padding(0, 0, 0, 0);
            this.layControlGroup.Text = "出库单";
            this.layControlGroup.TextVisible = false;
            // 
            // layStoreCode
            // 
            this.layStoreCode.Control = this.txtStoreCode;
            this.layStoreCode.CustomizationFormText = "出库单号";
            this.layStoreCode.Location = new System.Drawing.Point(0, 0);
            this.layStoreCode.Name = "layStoreCode";
            this.layStoreCode.Size = new System.Drawing.Size(424, 25);
            this.layStoreCode.Text = "出库单号";
            this.layStoreCode.TextSize = new System.Drawing.Size(48, 17);
            // 
            // layStoreKeeper
            // 
            this.layStoreKeeper.Control = this.txtStoreKeeper;
            this.layStoreKeeper.CustomizationFormText = "出库人";
            this.layStoreKeeper.Location = new System.Drawing.Point(424, 0);
            this.layStoreKeeper.Name = "layStoreKeeper";
            this.layStoreKeeper.Size = new System.Drawing.Size(424, 25);
            this.layStoreKeeper.Text = "出库人";
            this.layStoreKeeper.TextSize = new System.Drawing.Size(48, 17);
            // 
            // layDealerName
            // 
            this.layDealerName.Control = this.txtDealerName;
            this.layDealerName.CustomizationFormText = "往来单位";
            this.layDealerName.Location = new System.Drawing.Point(0, 50);
            this.layDealerName.Name = "layDealerName";
            this.layDealerName.Size = new System.Drawing.Size(848, 25);
            this.layDealerName.Text = "往来单位";
            this.layDealerName.TextSize = new System.Drawing.Size(48, 17);
            // 
            // layStoreRemark
            // 
            this.layStoreRemark.Control = this.txtStoreRemark;
            this.layStoreRemark.CustomizationFormText = "备注";
            this.layStoreRemark.Location = new System.Drawing.Point(0, 75);
            this.layStoreRemark.Name = "layStoreRemark";
            this.layStoreRemark.Size = new System.Drawing.Size(848, 26);
            this.layStoreRemark.Text = "备注";
            this.layStoreRemark.TextSize = new System.Drawing.Size(48, 17);
            // 
            // layStoreTypeName
            // 
            this.layStoreTypeName.Control = this.txtBillTypeName;
            this.layStoreTypeName.CustomizationFormText = "订单类型";
            this.layStoreTypeName.Location = new System.Drawing.Point(424, 25);
            this.layStoreTypeName.Name = "layStoreTypeName";
            this.layStoreTypeName.Size = new System.Drawing.Size(424, 25);
            this.layStoreTypeName.Text = "订单类型";
            this.layStoreTypeName.TextSize = new System.Drawing.Size(48, 17);
            // 
            // laySaleBillCode
            // 
            this.laySaleBillCode.Control = this.txtBillCode;
            this.laySaleBillCode.CustomizationFormText = "销售记录";
            this.laySaleBillCode.Location = new System.Drawing.Point(0, 25);
            this.laySaleBillCode.Name = "laySaleBillCode";
            this.laySaleBillCode.Size = new System.Drawing.Size(424, 25);
            this.laySaleBillCode.Text = "销售记录";
            this.laySaleBillCode.TextSize = new System.Drawing.Size(48, 17);
            // 
            // panelControl1
            // 
            this.panelControl1.Controls.Add(this.btnPrint);
            this.panelControl1.Controls.Add(this.btnCancel);
            this.panelControl1.Controls.Add(this.btnOneKeyFinish);
            this.panelControl1.Controls.Add(this.btnSave);
            this.panelControl1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panelControl1.Location = new System.Drawing.Point(0, 483);
            this.panelControl1.Name = "panelControl1";
            this.panelControl1.Size = new System.Drawing.Size(872, 48);
            this.panelControl1.TabIndex = 1;
            // 
            // btnPrint
            // 
            this.btnPrint.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnPrint.Appearance.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnPrint.Appearance.Options.UseFont = true;
            this.btnPrint.Location = new System.Drawing.Point(474, 13);
            this.btnPrint.Name = "btnPrint";
            this.btnPrint.OperationName = "StockOut";
            this.btnPrint.ReportName = "拣货单";
            this.btnPrint.Size = new System.Drawing.Size(75, 23);
            this.btnPrint.TabIndex = 3;
            this.btnPrint.Text = "打印(&P)";
            // 
            // btnOneKeyFinish
            // 
            this.btnOneKeyFinish.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnOneKeyFinish.Appearance.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnOneKeyFinish.Appearance.Options.UseFont = true;
            this.btnOneKeyFinish.Location = new System.Drawing.Point(807, 19);
            this.btnOneKeyFinish.Name = "btnOneKeyFinish";
            this.btnOneKeyFinish.Size = new System.Drawing.Size(37, 13);
            this.btnOneKeyFinish.TabIndex = 1;
            this.btnOneKeyFinish.Text = "一键完成(&K)";
            this.btnOneKeyFinish.Click += new System.EventHandler(this.btnOneKeyFinish_Click);
            // 
            // btnSave
            // 
            this.btnSave.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnSave.Appearance.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSave.Appearance.Options.UseFont = true;
            this.btnSave.Location = new System.Drawing.Point(678, 13);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(75, 23);
            this.btnSave.TabIndex = 0;
            this.btnSave.Text = "保存(&S)";
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // groupControl1
            // 
            this.groupControl1.AppearanceCaption.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupControl1.AppearanceCaption.Options.UseFont = true;
            this.groupControl1.Controls.Add(this.popupGrid);
            this.groupControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupControl1.Location = new System.Drawing.Point(0, 125);
            this.groupControl1.Name = "groupControl1";
            this.groupControl1.Size = new System.Drawing.Size(872, 358);
            this.groupControl1.TabIndex = 2;
            this.groupControl1.Text = "出库单明细";
            // 
            // popupGrid
            // 
            this.popupGrid.Dock = System.Windows.Forms.DockStyle.Fill;
            this.popupGrid.IsCalculatePrice = false;
            this.popupGrid.Location = new System.Drawing.Point(2, 25);
            this.popupGrid.Name = "popupGrid";
            this.popupGrid.OperationName = "StockOut";
            this.popupGrid.Size = new System.Drawing.Size(868, 331);
            this.popupGrid.TabIndex = 4;
            this.popupGrid.BeforePopupFormShow += new DQS.Controls.PopupGrid.OnBeforePopupFormShowEventHandler(this.popupGrid_BeforePopupFormShow);
            // 
            // btnCancel
            // 
            this.btnCancel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnCancel.Appearance.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCancel.Appearance.Options.UseFont = true;
            this.btnCancel.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btnCancel.Location = new System.Drawing.Point(783, 13);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(75, 23);
            this.btnCancel.TabIndex = 1;
            this.btnCancel.Text = "取消(&C)";
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // FrmSingleStockOut
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 14F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(872, 531);
            this.Controls.Add(this.groupControl1);
            this.Controls.Add(this.panelControl1);
            this.Controls.Add(this.ftPanel);
            this.MinimizeBox = false;
            this.Name = "FrmSingleStockOut";
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "出库单";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.FrmSingleStockOut_Load);
            ((System.ComponentModel.ISupportInitialize)(this.ftPanel)).EndInit();
            this.ftPanel.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.layControl)).EndInit();
            this.layControl.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.txtBillCode.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtStoreCode.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtStoreRemark.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtStoreKeeper.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtBillTypeName.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtDealerName.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layControlGroup)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layStoreCode)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layStoreKeeper)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layDealerName)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layStoreRemark)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layStoreTypeName)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.laySaleBillCode)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.panelControl1)).EndInit();
            this.panelControl1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.groupControl1)).EndInit();
            this.groupControl1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.popupGrid)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DQS.Controls.FieldTextBoxPanel ftPanel;
        private DQS.Controls.BUSStoreBillEntityTextBox txtStoreCode;
        private DQS.Controls.TextBoxEnterPopupEx txtStoreKeeper;
        private DQS.Controls.BUSStoreBillEntityTextBox txtDealerName;
        private DQS.Controls.BUSStoreBillEntityTextBox txtBillTypeName;
        private DQS.Controls.BUSStoreBillEntityTextBox txtStoreRemark;
        private DevExpress.XtraLayout.LayoutControl layControl;
        private DevExpress.XtraLayout.LayoutControlGroup layControlGroup;
        private DevExpress.XtraEditors.PanelControl panelControl1;
        private DevExpress.XtraEditors.SimpleButton btnOneKeyFinish;
        private DevExpress.XtraEditors.SimpleButton btnSave;
        private DevExpress.XtraLayout.LayoutControlItem layStoreCode;
        private DevExpress.XtraLayout.LayoutControlItem layStoreKeeper;
        private DevExpress.XtraLayout.LayoutControlItem layDealerName;
        private DevExpress.XtraLayout.LayoutControlItem layStoreTypeName;
        private DevExpress.XtraLayout.LayoutControlItem layStoreRemark;
        private DevExpress.XtraEditors.GroupControl groupControl1;
        private DQS.Controls.PopupGrid popupGrid;
        private DQS.Controls.TextBoxPopupEx txtBillCode;
        private DevExpress.XtraLayout.LayoutControlItem laySaleBillCode;
        private DQS.Controls.StiPrintButtonEx btnPrint;
        private DevExpress.XtraEditors.SimpleButton btnCancel;
    }
}