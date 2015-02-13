namespace DQS.AppViews.WarehouseIn.WarehouseInManager
{
    partial class FrmSingleStockIn
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
            this.txtStoreDate = new DQS.Controls.BUSStoreBillEntityTextBox();
            this.txtOperator = new DQS.Controls.BUSStoreBillEntityTextBox();
            this.txtBillCode = new DQS.Controls.TextBoxPopupEx();
            this.txtStoreRemark = new DQS.Controls.BUSStoreBillEntityTextBox();
            this.txtStoreCode = new DQS.Controls.BUSStoreBillEntityTextBox();
            this.txtBillTypeName = new DQS.Controls.BUSStoreBillEntityTextBox();
            this.txtStoreKeeper = new DQS.Controls.TextBoxEnterPopupEx();
            this.txtDealerName = new DQS.Controls.BUSStoreBillEntityTextBox();
            this.layControlGroup = new DevExpress.XtraLayout.LayoutControlGroup();
            this.layStoreCode = new DevExpress.XtraLayout.LayoutControlItem();
            this.layStoreKeeper = new DevExpress.XtraLayout.LayoutControlItem();
            this.layDealerName = new DevExpress.XtraLayout.LayoutControlItem();
            this.layStoreRemark = new DevExpress.XtraLayout.LayoutControlItem();
            this.layStoreTypeName = new DevExpress.XtraLayout.LayoutControlItem();
            this.layBillCode = new DevExpress.XtraLayout.LayoutControlItem();
            this.layOperator = new DevExpress.XtraLayout.LayoutControlItem();
            this.layoutControlItem2 = new DevExpress.XtraLayout.LayoutControlItem();
            this.pnlAction = new DevExpress.XtraEditors.PanelControl();
            this.btnPrint = new DQS.Controls.StiPrintButtonEx();
            this.btnSave = new DevExpress.XtraEditors.SimpleButton();
            this.gpcCenter = new DevExpress.XtraEditors.GroupControl();
            this.popupGrid = new DQS.Controls.PopupGrid();
            this.btnOneKeyFinish = new DevExpress.XtraEditors.SimpleButton();
            this.btnCancel = new DevExpress.XtraEditors.SimpleButton();
            ((System.ComponentModel.ISupportInitialize)(this.ftPanel)).BeginInit();
            this.ftPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.layControl)).BeginInit();
            this.layControl.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.txtStoreDate.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtOperator.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtBillCode.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtStoreRemark.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtStoreCode.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtBillTypeName.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtStoreKeeper.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtDealerName.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layControlGroup)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layStoreCode)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layStoreKeeper)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layDealerName)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layStoreRemark)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layStoreTypeName)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layBillCode)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layOperator)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pnlAction)).BeginInit();
            this.pnlAction.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gpcCenter)).BeginInit();
            this.gpcCenter.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.popupGrid)).BeginInit();
            this.SuspendLayout();
            // 
            // ftPanel
            // 
            this.ftPanel.Controls.Add(this.layControl);
            this.ftPanel.Dock = System.Windows.Forms.DockStyle.Top;
            this.ftPanel.Location = new System.Drawing.Point(0, 0);
            this.ftPanel.Name = "ftPanel";
            this.ftPanel.Size = new System.Drawing.Size(872, 151);
            this.ftPanel.TabIndex = 0;
            this.ftPanel.TypeOfEntity = DQS.Module.EntityType2.BUSStoreBillEntity;
            // 
            // layControl
            // 
            this.layControl.Controls.Add(this.txtStoreDate);
            this.layControl.Controls.Add(this.txtOperator);
            this.layControl.Controls.Add(this.txtBillCode);
            this.layControl.Controls.Add(this.txtStoreRemark);
            this.layControl.Controls.Add(this.txtStoreCode);
            this.layControl.Controls.Add(this.txtBillTypeName);
            this.layControl.Controls.Add(this.txtStoreKeeper);
            this.layControl.Controls.Add(this.txtDealerName);
            this.layControl.Dock = System.Windows.Forms.DockStyle.Fill;
            this.layControl.Location = new System.Drawing.Point(2, 2);
            this.layControl.Name = "layControl";
            this.layControl.Root = this.layControlGroup;
            this.layControl.Size = new System.Drawing.Size(868, 147);
            this.layControl.TabIndex = 0;
            this.layControl.Text = "layControl";
            // 
            // txtStoreDate
            // 
            this.txtStoreDate.AlphabeticFiled = null;
            this.txtStoreDate.EntityField = DQS.Module.Entities.BUSStoreBillEntityFields2.StoreDate;
            this.txtStoreDate.IsIntegerOnly = false;
            this.txtStoreDate.IsNullString = null;
            this.txtStoreDate.IsNullValidate = false;
            this.txtStoreDate.IsTransferAlphabetic = false;
            this.txtStoreDate.Location = new System.Drawing.Point(486, 87);
            this.txtStoreDate.Name = "txtStoreDate";
            this.txtStoreDate.Properties.ReadOnly = true;
            this.txtStoreDate.Size = new System.Drawing.Size(370, 21);
            this.txtStoreDate.StyleController = this.layControl;
            this.txtStoreDate.TabIndex = 7;
            // 
            // txtOperator
            // 
            this.txtOperator.AlphabeticFiled = null;
            this.txtOperator.EntityField = DQS.Module.Entities.BUSStoreBillEntityFields2.Operator;
            this.txtOperator.IsIntegerOnly = false;
            this.txtOperator.IsNullString = null;
            this.txtOperator.IsNullValidate = false;
            this.txtOperator.IsTransferAlphabetic = false;
            this.txtOperator.Location = new System.Drawing.Point(63, 87);
            this.txtOperator.Name = "txtOperator";
            this.txtOperator.Properties.ReadOnly = true;
            this.txtOperator.Size = new System.Drawing.Size(368, 21);
            this.txtOperator.StyleController = this.layControl;
            this.txtOperator.TabIndex = 7;
            // 
            // txtBillCode
            // 
            this.txtBillCode.AlphabeticFiled = "";
            this.txtBillCode.EditData = null;
            this.txtBillCode.Fields = "";
            this.txtBillCode.Filter = "[状态] = \'已验收\'";
            this.txtBillCode.FormatQueryString = "[验收单号] Like \'%{0}%\'";
            this.txtBillCode.GroupColumn = null;
            this.txtBillCode.IsIntegerOnly = false;
            this.txtBillCode.IsNullString = "验收记录不能为空。";
            this.txtBillCode.IsNullValidate = true;
            this.txtBillCode.IsTransferAlphabetic = false;
            this.txtBillCode.Location = new System.Drawing.Point(63, 37);
            this.txtBillCode.MemberText = "验收单号";
            this.txtBillCode.MemberValue = "验收ID";
            this.txtBillCode.Name = "txtBillCode";
            this.txtBillCode.PageSize = 0;
            this.txtBillCode.PrimaryField = "验收ID";
            this.txtBillCode.Properties.Appearance.BackColor = System.Drawing.Color.White;
            this.txtBillCode.Properties.Appearance.Options.UseBackColor = true;
            this.txtBillCode.Properties.ReadOnly = true;
            this.txtBillCode.Size = new System.Drawing.Size(370, 21);
            this.txtBillCode.StyleController = this.layControl;
            this.txtBillCode.TabIndex = 4;
            this.txtBillCode.ViewName = "vw_AllWarehouseInBillForStoreIn";
            this.txtBillCode.PopupClosing += new DQS.Controls.TextBoxPopupEx.OnPopupClosingDelegate(this.txtBillCode_PopupClosing);
            // 
            // txtStoreRemark
            // 
            this.txtStoreRemark.AlphabeticFiled = null;
            this.txtStoreRemark.EntityField = DQS.Module.Entities.BUSStoreBillEntityFields2.StoreRemark;
            this.txtStoreRemark.IsIntegerOnly = false;
            this.txtStoreRemark.IsNullString = null;
            this.txtStoreRemark.IsNullValidate = false;
            this.txtStoreRemark.IsTransferAlphabetic = false;
            this.txtStoreRemark.Location = new System.Drawing.Point(63, 112);
            this.txtStoreRemark.Name = "txtStoreRemark";
            this.txtStoreRemark.Size = new System.Drawing.Size(793, 21);
            this.txtStoreRemark.StyleController = this.layControl;
            this.txtStoreRemark.TabIndex = 6;
            // 
            // txtStoreCode
            // 
            this.txtStoreCode.AlphabeticFiled = null;
            this.txtStoreCode.EntityField = DQS.Module.Entities.BUSStoreBillEntityFields2.StoreCode;
            this.txtStoreCode.IsIntegerOnly = false;
            this.txtStoreCode.IsNullString = "入库单号不能为空。";
            this.txtStoreCode.IsNullValidate = true;
            this.txtStoreCode.IsTransferAlphabetic = false;
            this.txtStoreCode.Location = new System.Drawing.Point(63, 12);
            this.txtStoreCode.Name = "txtStoreCode";
            this.txtStoreCode.Size = new System.Drawing.Size(370, 21);
            this.txtStoreCode.StyleController = this.layControl;
            this.txtStoreCode.TabIndex = 0;
            // 
            // txtBillTypeName
            // 
            this.txtBillTypeName.AlphabeticFiled = "StoreTypeSpell";
            this.txtBillTypeName.EntityField = DQS.Module.Entities.BUSStoreBillEntityFields2.StoreTypeName;
            this.txtBillTypeName.IsIntegerOnly = false;
            this.txtBillTypeName.IsNullString = null;
            this.txtBillTypeName.IsNullValidate = false;
            this.txtBillTypeName.IsTransferAlphabetic = true;
            this.txtBillTypeName.Location = new System.Drawing.Point(488, 37);
            this.txtBillTypeName.Name = "txtBillTypeName";
            this.txtBillTypeName.Properties.ReadOnly = true;
            this.txtBillTypeName.Size = new System.Drawing.Size(368, 21);
            this.txtBillTypeName.StyleController = this.layControl;
            this.txtBillTypeName.TabIndex = 5;
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
            this.txtStoreKeeper.Location = new System.Drawing.Point(488, 12);
            this.txtStoreKeeper.MemberText = "员工姓名";
            this.txtStoreKeeper.MemberValue = "员工ID";
            this.txtStoreKeeper.Name = "txtStoreKeeper";
            this.txtStoreKeeper.PageSize = 0;
            this.txtStoreKeeper.PrimaryField = "员工ID";
            this.txtStoreKeeper.Properties.Appearance.BackColor = System.Drawing.Color.White;
            this.txtStoreKeeper.Properties.Appearance.Options.UseBackColor = true;
            this.txtStoreKeeper.Properties.ReadOnly = true;
            this.txtStoreKeeper.Size = new System.Drawing.Size(368, 21);
            this.txtStoreKeeper.StyleController = this.layControl;
            this.txtStoreKeeper.TabIndex = 1;
            this.txtStoreKeeper.ViewName = "vw_AllEmployee";
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
            this.layControlGroup.CustomizationFormText = "入库单";
            this.layControlGroup.EnableIndentsWithoutBorders = DevExpress.Utils.DefaultBoolean.True;
            this.layControlGroup.GroupBordersVisible = false;
            this.layControlGroup.Items.AddRange(new DevExpress.XtraLayout.BaseLayoutItem[] {
            this.layStoreCode,
            this.layStoreKeeper,
            this.layDealerName,
            this.layStoreRemark,
            this.layStoreTypeName,
            this.layBillCode,
            this.layOperator,
            this.layoutControlItem2});
            this.layControlGroup.Location = new System.Drawing.Point(0, 0);
            this.layControlGroup.Name = "layControlGroup";
            this.layControlGroup.Size = new System.Drawing.Size(868, 147);
            this.layControlGroup.Spacing = new DevExpress.XtraLayout.Utils.Padding(0, 0, 0, 0);
            this.layControlGroup.Text = "入库单";
            this.layControlGroup.TextVisible = false;
            // 
            // layStoreCode
            // 
            this.layStoreCode.Control = this.txtStoreCode;
            this.layStoreCode.CustomizationFormText = "入库单号";
            this.layStoreCode.Location = new System.Drawing.Point(0, 0);
            this.layStoreCode.Name = "layStoreCode";
            this.layStoreCode.Size = new System.Drawing.Size(425, 25);
            this.layStoreCode.Text = "入库单号";
            this.layStoreCode.TextSize = new System.Drawing.Size(48, 17);
            // 
            // layStoreKeeper
            // 
            this.layStoreKeeper.Control = this.txtStoreKeeper;
            this.layStoreKeeper.CustomizationFormText = "入库人";
            this.layStoreKeeper.Location = new System.Drawing.Point(425, 0);
            this.layStoreKeeper.Name = "layStoreKeeper";
            this.layStoreKeeper.Size = new System.Drawing.Size(423, 25);
            this.layStoreKeeper.Text = "入库人";
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
            this.layStoreRemark.Location = new System.Drawing.Point(0, 100);
            this.layStoreRemark.Name = "layStoreRemark";
            this.layStoreRemark.Size = new System.Drawing.Size(848, 27);
            this.layStoreRemark.Text = "备注";
            this.layStoreRemark.TextSize = new System.Drawing.Size(48, 17);
            // 
            // layStoreTypeName
            // 
            this.layStoreTypeName.Control = this.txtBillTypeName;
            this.layStoreTypeName.CustomizationFormText = "订单类型";
            this.layStoreTypeName.Location = new System.Drawing.Point(425, 25);
            this.layStoreTypeName.Name = "layStoreTypeName";
            this.layStoreTypeName.Size = new System.Drawing.Size(423, 25);
            this.layStoreTypeName.Text = "订单类型";
            this.layStoreTypeName.TextSize = new System.Drawing.Size(48, 17);
            // 
            // layBillCode
            // 
            this.layBillCode.Control = this.txtBillCode;
            this.layBillCode.CustomizationFormText = "验收记录";
            this.layBillCode.Location = new System.Drawing.Point(0, 25);
            this.layBillCode.Name = "layBillCode";
            this.layBillCode.Size = new System.Drawing.Size(425, 25);
            this.layBillCode.Text = "验收记录";
            this.layBillCode.TextSize = new System.Drawing.Size(48, 17);
            // 
            // layOperator
            // 
            this.layOperator.Control = this.txtOperator;
            this.layOperator.CustomizationFormText = "业务员";
            this.layOperator.Location = new System.Drawing.Point(0, 75);
            this.layOperator.Name = "layOperator";
            this.layOperator.Size = new System.Drawing.Size(423, 25);
            this.layOperator.Text = "业务员";
            this.layOperator.TextSize = new System.Drawing.Size(48, 17);
            // 
            // layoutControlItem2
            // 
            this.layoutControlItem2.Control = this.txtStoreDate;
            this.layoutControlItem2.CustomizationFormText = "入库日期";
            this.layoutControlItem2.Location = new System.Drawing.Point(423, 75);
            this.layoutControlItem2.Name = "layoutControlItem2";
            this.layoutControlItem2.Size = new System.Drawing.Size(425, 25);
            this.layoutControlItem2.Text = "入库日期";
            this.layoutControlItem2.TextSize = new System.Drawing.Size(48, 17);
            // 
            // pnlAction
            // 
            this.pnlAction.Controls.Add(this.btnCancel);
            this.pnlAction.Controls.Add(this.btnOneKeyFinish);
            this.pnlAction.Controls.Add(this.btnPrint);
            this.pnlAction.Controls.Add(this.btnSave);
            this.pnlAction.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.pnlAction.Location = new System.Drawing.Point(0, 483);
            this.pnlAction.Name = "pnlAction";
            this.pnlAction.Size = new System.Drawing.Size(872, 48);
            this.pnlAction.TabIndex = 1;
            // 
            // btnPrint
            // 
            this.btnPrint.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnPrint.Appearance.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnPrint.Appearance.Options.UseFont = true;
            this.btnPrint.Location = new System.Drawing.Point(474, 13);
            this.btnPrint.Name = "btnPrint";
            this.btnPrint.OperationName = "StockIn";
            this.btnPrint.ReportName = "上架单";
            this.btnPrint.Size = new System.Drawing.Size(75, 23);
            this.btnPrint.TabIndex = 4;
            this.btnPrint.Text = "打印(&P)";
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
            // gpcCenter
            // 
            this.gpcCenter.AppearanceCaption.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gpcCenter.AppearanceCaption.Options.UseFont = true;
            this.gpcCenter.Controls.Add(this.popupGrid);
            this.gpcCenter.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gpcCenter.Location = new System.Drawing.Point(0, 151);
            this.gpcCenter.Name = "gpcCenter";
            this.gpcCenter.Size = new System.Drawing.Size(872, 332);
            this.gpcCenter.TabIndex = 2;
            this.gpcCenter.Text = "入库单详细";
            // 
            // popupGrid
            // 
            this.popupGrid.Dock = System.Windows.Forms.DockStyle.Fill;
            this.popupGrid.IsCalculatePrice = false;
            this.popupGrid.Location = new System.Drawing.Point(2, 25);
            this.popupGrid.Name = "popupGrid";
            this.popupGrid.OperationName = "StockIn";
            this.popupGrid.Size = new System.Drawing.Size(868, 305);
            this.popupGrid.TabIndex = 3;
            // 
            // btnOneKeyFinish
            // 
            this.btnOneKeyFinish.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnOneKeyFinish.Appearance.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnOneKeyFinish.Appearance.Options.UseFont = true;
            this.btnOneKeyFinish.Location = new System.Drawing.Point(805, 17);
            this.btnOneKeyFinish.Name = "btnOneKeyFinish";
            this.btnOneKeyFinish.Size = new System.Drawing.Size(36, 16);
            this.btnOneKeyFinish.TabIndex = 0;
            this.btnOneKeyFinish.Text = "一键完成(&K)";
            this.btnOneKeyFinish.Click += new System.EventHandler(this.btnOneKeyFinish_Click);
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
            this.btnCancel.TabIndex = 5;
            this.btnCancel.Text = "取消(&C)";
            // 
            // FrmSingleStockIn
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 14F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(872, 531);
            this.Controls.Add(this.gpcCenter);
            this.Controls.Add(this.pnlAction);
            this.Controls.Add(this.ftPanel);
            this.MinimizeBox = false;
            this.Name = "FrmSingleStockIn";
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "入库单";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.FrmSingleStockIn_Load);
            ((System.ComponentModel.ISupportInitialize)(this.ftPanel)).EndInit();
            this.ftPanel.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.layControl)).EndInit();
            this.layControl.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.txtStoreDate.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtOperator.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtBillCode.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtStoreRemark.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtStoreCode.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtBillTypeName.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtStoreKeeper.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtDealerName.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layControlGroup)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layStoreCode)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layStoreKeeper)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layDealerName)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layStoreRemark)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layStoreTypeName)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layBillCode)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layOperator)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pnlAction)).EndInit();
            this.pnlAction.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.gpcCenter)).EndInit();
            this.gpcCenter.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.popupGrid)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DQS.Controls.FieldTextBoxPanel ftPanel;
        private DevExpress.XtraEditors.PanelControl pnlAction;
        private DevExpress.XtraEditors.SimpleButton btnSave;
        private DevExpress.XtraLayout.LayoutControl layControl;
        private DQS.Controls.BUSStoreBillEntityTextBox txtStoreRemark;
        private DQS.Controls.BUSStoreBillEntityTextBox txtStoreCode;
        private DQS.Controls.BUSStoreBillEntityTextBox txtBillTypeName;
        private DQS.Controls.TextBoxEnterPopupEx txtStoreKeeper;
        private DQS.Controls.BUSStoreBillEntityTextBox txtDealerName;
        private DevExpress.XtraLayout.LayoutControlGroup layControlGroup;
        private DevExpress.XtraLayout.LayoutControlItem layStoreCode;
        private DevExpress.XtraLayout.LayoutControlItem layStoreKeeper;
        private DevExpress.XtraLayout.LayoutControlItem layDealerName;
        private DevExpress.XtraLayout.LayoutControlItem layStoreTypeName;
        private DevExpress.XtraLayout.LayoutControlItem layStoreRemark;
        private DevExpress.XtraEditors.GroupControl gpcCenter;
        private DQS.Controls.TextBoxPopupEx txtBillCode;
        private DevExpress.XtraLayout.LayoutControlItem layBillCode;
        private DQS.Controls.PopupGrid popupGrid;
        private DQS.Controls.StiPrintButtonEx btnPrint;
        private DQS.Controls.BUSStoreBillEntityTextBox txtStoreDate;
        private DQS.Controls.BUSStoreBillEntityTextBox txtOperator;
        private DevExpress.XtraLayout.LayoutControlItem layOperator;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlItem2;
        private DevExpress.XtraEditors.SimpleButton btnOneKeyFinish;
        private DevExpress.XtraEditors.SimpleButton btnCancel;
    }
}