namespace DQS.AppViews.QualityDocument.ProductManager
{
    partial class FrmSinglePriceOfDealer
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
            this.txtDealerName = new DQS.Controls.TextBoxPopupEx();
            this.layControl = new DevExpress.XtraLayout.LayoutControl();
            this.txtRetailPrice = new DevExpress.XtraEditors.TextEdit();
            this.txtTradePrice = new DevExpress.XtraEditors.TextEdit();
            this.txtUnitPrice = new DevExpress.XtraEditors.TextEdit();
            this.txtProducerName = new DevExpress.XtraEditors.TextEdit();
            this.txtAuthorizedNo = new DevExpress.XtraEditors.TextEdit();
            this.txtProductStyle = new DevExpress.XtraEditors.TextEdit();
            this.txtPackageSpec = new DevExpress.XtraEditors.TextEdit();
            this.txtProductSpec = new DevExpress.XtraEditors.TextEdit();
            this.txtProductCode = new DQS.Controls.TextBoxPopupEx();
            this.layControlGroup = new DevExpress.XtraLayout.LayoutControlGroup();
            this.layoutControlItem1 = new DevExpress.XtraLayout.LayoutControlItem();
            this.layoutControlItem2 = new DevExpress.XtraLayout.LayoutControlItem();
            this.layoutControlItem11 = new DevExpress.XtraLayout.LayoutControlItem();
            this.layoutControlItem12 = new DevExpress.XtraLayout.LayoutControlItem();
            this.layoutControlItem13 = new DevExpress.XtraLayout.LayoutControlItem();
            this.layoutControlItem14 = new DevExpress.XtraLayout.LayoutControlItem();
            this.layoutControlItem15 = new DevExpress.XtraLayout.LayoutControlItem();
            this.layoutControlItem16 = new DevExpress.XtraLayout.LayoutControlItem();
            this.layoutControlItem17 = new DevExpress.XtraLayout.LayoutControlItem();
            this.layoutControlItem18 = new DevExpress.XtraLayout.LayoutControlItem();
            this.btnSave = new DevExpress.XtraEditors.SimpleButton();
            this.btnCancel = new DevExpress.XtraEditors.SimpleButton();
            this.ftPanel = new DQS.Controls.FieldTextBoxPanel();
            ((System.ComponentModel.ISupportInitialize)(this.txtDealerName.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layControl)).BeginInit();
            this.layControl.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.txtRetailPrice.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtTradePrice.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtUnitPrice.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtProducerName.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtAuthorizedNo.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtProductStyle.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtPackageSpec.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtProductSpec.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtProductCode.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layControlGroup)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem11)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem12)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem13)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem14)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem15)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem16)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem17)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem18)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ftPanel)).BeginInit();
            this.ftPanel.SuspendLayout();
            this.SuspendLayout();
            // 
            // txtDealerName
            // 
            this.txtDealerName.AlphabeticFiled = "";
            this.txtDealerName.EditData = null;
            this.txtDealerName.Fields = "单位ID,单位编号,单位名称,业务联系人,业务联系电话,所属销售区域,区县,通讯地址,单位类型,单位名称Spell";
            this.txtDealerName.Filter = "[状态] is  null or [状态] = \'正常\'";
            this.txtDealerName.FormatQueryString = "[单位编号] LIKE \'%{0}%\' OR ([单位名称] LIKE \'%{0}%\' OR [单位名称Spell] LIKE \'%{0}%\')";
            this.txtDealerName.GroupColumn = "区县";
            this.txtDealerName.IsIntegerOnly = false;
            this.txtDealerName.IsNullString = "往来单位不能为空。";
            this.txtDealerName.IsNullValidate = true;
            this.txtDealerName.IsTransferAlphabetic = true;
            this.txtDealerName.Location = new System.Drawing.Point(75, 12);
            this.txtDealerName.MemberText = "单位名称";
            this.txtDealerName.MemberValue = "单位ID";
            this.txtDealerName.Name = "txtDealerName";
            this.txtDealerName.PageSize = 500;
            this.txtDealerName.PrimaryField = "单位ID";
            this.txtDealerName.Properties.Appearance.BackColor = System.Drawing.Color.White;
            this.txtDealerName.Properties.Appearance.Options.UseBackColor = true;
            this.txtDealerName.Properties.ReadOnly = true;
            this.txtDealerName.Size = new System.Drawing.Size(348, 21);
            this.txtDealerName.StyleController = this.layControl;
            this.txtDealerName.TabIndex = 3;
            this.txtDealerName.ViewName = "vw_AllProvider";
            this.txtDealerName.PopupClosing += new DQS.Controls.TextBoxPopupEx.OnPopupClosingDelegate(this.txtDealerName_PopupClosing);
            // 
            // layControl
            // 
            this.layControl.Controls.Add(this.txtRetailPrice);
            this.layControl.Controls.Add(this.txtTradePrice);
            this.layControl.Controls.Add(this.txtUnitPrice);
            this.layControl.Controls.Add(this.txtProducerName);
            this.layControl.Controls.Add(this.txtAuthorizedNo);
            this.layControl.Controls.Add(this.txtProductStyle);
            this.layControl.Controls.Add(this.txtPackageSpec);
            this.layControl.Controls.Add(this.txtProductSpec);
            this.layControl.Controls.Add(this.txtDealerName);
            this.layControl.Controls.Add(this.txtProductCode);
            this.layControl.Dock = System.Windows.Forms.DockStyle.Fill;
            this.layControl.Location = new System.Drawing.Point(2, 2);
            this.layControl.Name = "layControl";
            this.layControl.Root = this.layControlGroup;
            this.layControl.Size = new System.Drawing.Size(850, 148);
            this.layControl.TabIndex = 0;
            this.layControl.Text = "layControl";
            // 
            // txtRetailPrice
            // 
            this.txtRetailPrice.EditValue = "0";
            this.txtRetailPrice.Location = new System.Drawing.Point(490, 112);
            this.txtRetailPrice.Name = "txtRetailPrice";
            this.txtRetailPrice.Size = new System.Drawing.Size(348, 21);
            this.txtRetailPrice.StyleController = this.layControl;
            this.txtRetailPrice.TabIndex = 6;
            // 
            // txtTradePrice
            // 
            this.txtTradePrice.EditValue = "0";
            this.txtTradePrice.Location = new System.Drawing.Point(75, 112);
            this.txtTradePrice.Name = "txtTradePrice";
            this.txtTradePrice.Size = new System.Drawing.Size(348, 21);
            this.txtTradePrice.StyleController = this.layControl;
            this.txtTradePrice.TabIndex = 6;
            // 
            // txtUnitPrice
            // 
            this.txtUnitPrice.EditValue = "0";
            this.txtUnitPrice.Location = new System.Drawing.Point(490, 87);
            this.txtUnitPrice.Name = "txtUnitPrice";
            this.txtUnitPrice.Size = new System.Drawing.Size(348, 21);
            this.txtUnitPrice.StyleController = this.layControl;
            this.txtUnitPrice.TabIndex = 6;
            // 
            // txtProducerName
            // 
            this.txtProducerName.Location = new System.Drawing.Point(75, 87);
            this.txtProducerName.Name = "txtProducerName";
            this.txtProducerName.Properties.ReadOnly = true;
            this.txtProducerName.Size = new System.Drawing.Size(348, 21);
            this.txtProducerName.StyleController = this.layControl;
            this.txtProducerName.TabIndex = 6;
            // 
            // txtAuthorizedNo
            // 
            this.txtAuthorizedNo.Location = new System.Drawing.Point(75, 62);
            this.txtAuthorizedNo.Name = "txtAuthorizedNo";
            this.txtAuthorizedNo.Properties.ReadOnly = true;
            this.txtAuthorizedNo.Size = new System.Drawing.Size(348, 21);
            this.txtAuthorizedNo.StyleController = this.layControl;
            this.txtAuthorizedNo.TabIndex = 6;
            // 
            // txtProductStyle
            // 
            this.txtProductStyle.Location = new System.Drawing.Point(490, 62);
            this.txtProductStyle.Name = "txtProductStyle";
            this.txtProductStyle.Properties.ReadOnly = true;
            this.txtProductStyle.Size = new System.Drawing.Size(348, 21);
            this.txtProductStyle.StyleController = this.layControl;
            this.txtProductStyle.TabIndex = 6;
            // 
            // txtPackageSpec
            // 
            this.txtPackageSpec.Location = new System.Drawing.Point(490, 37);
            this.txtPackageSpec.Name = "txtPackageSpec";
            this.txtPackageSpec.Properties.ReadOnly = true;
            this.txtPackageSpec.Size = new System.Drawing.Size(348, 21);
            this.txtPackageSpec.StyleController = this.layControl;
            this.txtPackageSpec.TabIndex = 6;
            // 
            // txtProductSpec
            // 
            this.txtProductSpec.Location = new System.Drawing.Point(75, 37);
            this.txtProductSpec.Name = "txtProductSpec";
            this.txtProductSpec.Properties.ReadOnly = true;
            this.txtProductSpec.Size = new System.Drawing.Size(348, 21);
            this.txtProductSpec.StyleController = this.layControl;
            this.txtProductSpec.TabIndex = 6;
            // 
            // txtProductCode
            // 
            this.txtProductCode.AlphabeticFiled = "";
            this.txtProductCode.EditData = null;
            this.txtProductCode.Fields = "药品ID,药品编号,药品名称,药品名称Spell,规格,单位,包装规格,剂型,药品类别,批准文号,生产厂商,生产地址,贮藏条件,包装比例,状态";
            this.txtProductCode.Filter = "[状态] is  null or [状态] = \'正常\'";
            this.txtProductCode.FormatQueryString = "[药品编号] LIKE \'%{0}%\' OR ([药品名称] LIKE \'%{0}%\' OR [药品名称Spell] LIKE \'%{0}%\')";
            this.txtProductCode.GroupColumn = "药品类别";
            this.txtProductCode.IsIntegerOnly = false;
            this.txtProductCode.IsNullString = "药品名称不能为空。";
            this.txtProductCode.IsNullValidate = true;
            this.txtProductCode.IsTransferAlphabetic = true;
            this.txtProductCode.Location = new System.Drawing.Point(490, 12);
            this.txtProductCode.MemberText = "药品名称";
            this.txtProductCode.MemberValue = "药品ID";
            this.txtProductCode.Name = "txtProductCode";
            this.txtProductCode.PageSize = 500;
            this.txtProductCode.PrimaryField = "药品ID";
            this.txtProductCode.Properties.Appearance.BackColor = System.Drawing.Color.White;
            this.txtProductCode.Properties.Appearance.Options.UseBackColor = true;
            this.txtProductCode.Properties.ReadOnly = true;
            this.txtProductCode.Size = new System.Drawing.Size(348, 21);
            this.txtProductCode.StyleController = this.layControl;
            this.txtProductCode.TabIndex = 5;
            this.txtProductCode.ViewName = "vw_AllProduct";
            this.txtProductCode.PopupClosing += new DQS.Controls.TextBoxPopupEx.OnPopupClosingDelegate(this.txtProductCode_PopupClosing);
            // 
            // layControlGroup
            // 
            this.layControlGroup.AppearanceItemCaption.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.layControlGroup.AppearanceItemCaption.Options.UseFont = true;
            this.layControlGroup.CustomizationFormText = "销售订单";
            this.layControlGroup.EnableIndentsWithoutBorders = DevExpress.Utils.DefaultBoolean.True;
            this.layControlGroup.GroupBordersVisible = false;
            this.layControlGroup.Items.AddRange(new DevExpress.XtraLayout.BaseLayoutItem[] {
            this.layoutControlItem1,
            this.layoutControlItem2,
            this.layoutControlItem11,
            this.layoutControlItem12,
            this.layoutControlItem13,
            this.layoutControlItem14,
            this.layoutControlItem15,
            this.layoutControlItem16,
            this.layoutControlItem17,
            this.layoutControlItem18});
            this.layControlGroup.Location = new System.Drawing.Point(0, 0);
            this.layControlGroup.Name = "layControlGroup";
            this.layControlGroup.Size = new System.Drawing.Size(850, 148);
            this.layControlGroup.Spacing = new DevExpress.XtraLayout.Utils.Padding(0, 0, 0, 0);
            this.layControlGroup.Text = "销售订单";
            this.layControlGroup.TextVisible = false;
            // 
            // layoutControlItem1
            // 
            this.layoutControlItem1.Control = this.txtDealerName;
            this.layoutControlItem1.CustomizationFormText = "单位名称：";
            this.layoutControlItem1.Location = new System.Drawing.Point(0, 0);
            this.layoutControlItem1.Name = "layoutControlItem1";
            this.layoutControlItem1.Size = new System.Drawing.Size(415, 25);
            this.layoutControlItem1.Text = "单位名称：";
            this.layoutControlItem1.TextSize = new System.Drawing.Size(60, 17);
            // 
            // layoutControlItem2
            // 
            this.layoutControlItem2.Control = this.txtProductCode;
            this.layoutControlItem2.CustomizationFormText = "药品名称：";
            this.layoutControlItem2.Location = new System.Drawing.Point(415, 0);
            this.layoutControlItem2.Name = "layoutControlItem2";
            this.layoutControlItem2.Size = new System.Drawing.Size(415, 25);
            this.layoutControlItem2.Text = "药品名称：";
            this.layoutControlItem2.TextSize = new System.Drawing.Size(60, 17);
            // 
            // layoutControlItem11
            // 
            this.layoutControlItem11.Control = this.txtProductSpec;
            this.layoutControlItem11.CustomizationFormText = "规格：";
            this.layoutControlItem11.Location = new System.Drawing.Point(0, 25);
            this.layoutControlItem11.Name = "layoutControlItem11";
            this.layoutControlItem11.Size = new System.Drawing.Size(415, 25);
            this.layoutControlItem11.Text = "规格：";
            this.layoutControlItem11.TextSize = new System.Drawing.Size(60, 17);
            // 
            // layoutControlItem12
            // 
            this.layoutControlItem12.Control = this.txtPackageSpec;
            this.layoutControlItem12.CustomizationFormText = "包装规格：";
            this.layoutControlItem12.Location = new System.Drawing.Point(415, 25);
            this.layoutControlItem12.Name = "layoutControlItem12";
            this.layoutControlItem12.Size = new System.Drawing.Size(415, 25);
            this.layoutControlItem12.Text = "包装规格：";
            this.layoutControlItem12.TextSize = new System.Drawing.Size(60, 17);
            // 
            // layoutControlItem13
            // 
            this.layoutControlItem13.Control = this.txtAuthorizedNo;
            this.layoutControlItem13.CustomizationFormText = "批准文号：";
            this.layoutControlItem13.Location = new System.Drawing.Point(0, 50);
            this.layoutControlItem13.Name = "layoutControlItem13";
            this.layoutControlItem13.Size = new System.Drawing.Size(415, 25);
            this.layoutControlItem13.Text = "批准文号：";
            this.layoutControlItem13.TextSize = new System.Drawing.Size(60, 17);
            // 
            // layoutControlItem14
            // 
            this.layoutControlItem14.Control = this.txtProductStyle;
            this.layoutControlItem14.CustomizationFormText = "药品类别：";
            this.layoutControlItem14.Location = new System.Drawing.Point(415, 50);
            this.layoutControlItem14.Name = "layoutControlItem14";
            this.layoutControlItem14.Size = new System.Drawing.Size(415, 25);
            this.layoutControlItem14.Text = "药品类别：";
            this.layoutControlItem14.TextSize = new System.Drawing.Size(60, 17);
            // 
            // layoutControlItem15
            // 
            this.layoutControlItem15.Control = this.txtProducerName;
            this.layoutControlItem15.CustomizationFormText = "生产厂商：";
            this.layoutControlItem15.Location = new System.Drawing.Point(0, 75);
            this.layoutControlItem15.Name = "layoutControlItem15";
            this.layoutControlItem15.Size = new System.Drawing.Size(415, 25);
            this.layoutControlItem15.Text = "生产厂商：";
            this.layoutControlItem15.TextSize = new System.Drawing.Size(60, 17);
            // 
            // layoutControlItem16
            // 
            this.layoutControlItem16.Control = this.txtUnitPrice;
            this.layoutControlItem16.CustomizationFormText = "进货价：";
            this.layoutControlItem16.Location = new System.Drawing.Point(415, 75);
            this.layoutControlItem16.Name = "layoutControlItem16";
            this.layoutControlItem16.Size = new System.Drawing.Size(415, 25);
            this.layoutControlItem16.Text = "进货价：";
            this.layoutControlItem16.TextSize = new System.Drawing.Size(60, 17);
            // 
            // layoutControlItem17
            // 
            this.layoutControlItem17.Control = this.txtTradePrice;
            this.layoutControlItem17.CustomizationFormText = "批发价：";
            this.layoutControlItem17.Location = new System.Drawing.Point(0, 100);
            this.layoutControlItem17.Name = "layoutControlItem17";
            this.layoutControlItem17.Size = new System.Drawing.Size(415, 28);
            this.layoutControlItem17.Text = "批发价：";
            this.layoutControlItem17.TextSize = new System.Drawing.Size(60, 17);
            // 
            // layoutControlItem18
            // 
            this.layoutControlItem18.Control = this.txtRetailPrice;
            this.layoutControlItem18.CustomizationFormText = "零售价：";
            this.layoutControlItem18.Location = new System.Drawing.Point(415, 100);
            this.layoutControlItem18.Name = "layoutControlItem18";
            this.layoutControlItem18.Size = new System.Drawing.Size(415, 28);
            this.layoutControlItem18.Text = "零售价：";
            this.layoutControlItem18.TextSize = new System.Drawing.Size(60, 17);
            // 
            // btnSave
            // 
            this.btnSave.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnSave.Location = new System.Drawing.Point(641, 172);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(75, 23);
            this.btnSave.TabIndex = 5;
            this.btnSave.Text = "保存";
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // btnCancel
            // 
            this.btnCancel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnCancel.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btnCancel.Location = new System.Drawing.Point(751, 172);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(75, 23);
            this.btnCancel.TabIndex = 5;
            this.btnCancel.Text = "取消";
            // 
            // ftPanel
            // 
            this.ftPanel.Controls.Add(this.layControl);
            this.ftPanel.Dock = System.Windows.Forms.DockStyle.Top;
            this.ftPanel.Location = new System.Drawing.Point(0, 0);
            this.ftPanel.Name = "ftPanel";
            this.ftPanel.Size = new System.Drawing.Size(854, 152);
            this.ftPanel.TabIndex = 6;
            this.ftPanel.TypeOfEntity = DQS.Module.EntityType2.BFIPriceOfDealerEntity;
            // 
            // FrmSinglePriceOfDealer
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 14F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(854, 207);
            this.Controls.Add(this.ftPanel);
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.btnSave);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FrmSinglePriceOfDealer";
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "特殊价格";
            this.Load += new System.EventHandler(this.FrmSinglePriceOfDealer_Load);
            ((System.ComponentModel.ISupportInitialize)(this.txtDealerName.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layControl)).EndInit();
            this.layControl.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.txtRetailPrice.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtTradePrice.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtUnitPrice.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtProducerName.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtAuthorizedNo.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtProductStyle.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtPackageSpec.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtProductSpec.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtProductCode.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layControlGroup)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem11)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem12)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem13)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem14)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem15)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem16)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem17)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem18)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ftPanel)).EndInit();
            this.ftPanel.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private Controls.TextBoxPopupEx txtDealerName;
        private Controls.TextBoxPopupEx txtProductCode;
        private DevExpress.XtraEditors.SimpleButton btnSave;
        private DevExpress.XtraEditors.SimpleButton btnCancel;
        private Controls.FieldTextBoxPanel ftPanel;
        private DevExpress.XtraLayout.LayoutControl layControl;
        private DevExpress.XtraLayout.LayoutControlGroup layControlGroup;
        private DevExpress.XtraEditors.TextEdit txtRetailPrice;
        private DevExpress.XtraEditors.TextEdit txtTradePrice;
        private DevExpress.XtraEditors.TextEdit txtUnitPrice;
        private DevExpress.XtraEditors.TextEdit txtProducerName;
        private DevExpress.XtraEditors.TextEdit txtAuthorizedNo;
        private DevExpress.XtraEditors.TextEdit txtProductStyle;
        private DevExpress.XtraEditors.TextEdit txtPackageSpec;
        private DevExpress.XtraEditors.TextEdit txtProductSpec;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlItem1;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlItem2;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlItem11;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlItem12;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlItem13;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlItem14;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlItem15;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlItem16;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlItem17;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlItem18;

    }
}