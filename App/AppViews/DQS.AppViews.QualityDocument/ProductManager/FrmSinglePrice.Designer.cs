namespace DQS.AppViews.QualityDocument.ProductManager
{
    partial class FrmSinglePrice
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
            this.pnOperating = new DevExpress.XtraEditors.PanelControl();
            this.btnCancel = new DevExpress.XtraEditors.SimpleButton();
            this.btnSave = new DevExpress.XtraEditors.SimpleButton();
            this.ftPanel = new DQS.Controls.FieldTextBoxPanel();
            this.layControl = new DevExpress.XtraLayout.LayoutControl();
            this.txtRemark = new DQS.Controls.BFIProductPriceEntityTextBox();
            this.txtPopupProduct = new DQS.Controls.TextBoxPopupEx();
            this.spePrice = new DevExpress.XtraEditors.SpinEdit();
            this.txtPopupStyle = new DQS.Controls.TextBoxPopupEx();
            this.layControlGroup = new DevExpress.XtraLayout.LayoutControlGroup();
            this.layPriceStyle = new DevExpress.XtraLayout.LayoutControlItem();
            this.layPrice = new DevExpress.XtraLayout.LayoutControlItem();
            this.layProduct = new DevExpress.XtraLayout.LayoutControlItem();
            this.layRemark = new DevExpress.XtraLayout.LayoutControlItem();
            ((System.ComponentModel.ISupportInitialize)(this.pnOperating)).BeginInit();
            this.pnOperating.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ftPanel)).BeginInit();
            this.ftPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.layControl)).BeginInit();
            this.layControl.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.txtRemark.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtPopupProduct.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.spePrice.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtPopupStyle.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layControlGroup)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layPriceStyle)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layPrice)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layProduct)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layRemark)).BeginInit();
            this.SuspendLayout();
            // 
            // pnOperating
            // 
            this.pnOperating.Controls.Add(this.btnCancel);
            this.pnOperating.Controls.Add(this.btnSave);
            this.pnOperating.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.pnOperating.Location = new System.Drawing.Point(0, 161);
            this.pnOperating.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.pnOperating.Name = "pnOperating";
            this.pnOperating.Size = new System.Drawing.Size(416, 55);
            this.pnOperating.TabIndex = 3;
            // 
            // btnCancel
            // 
            this.btnCancel.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.btnCancel.Appearance.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCancel.Appearance.Options.UseFont = true;
            this.btnCancel.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btnCancel.Location = new System.Drawing.Point(317, 12);
            this.btnCancel.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(86, 30);
            this.btnCancel.TabIndex = 1;
            this.btnCancel.Text = "取消(&C)";
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // btnSave
            // 
            this.btnSave.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.btnSave.Appearance.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSave.Appearance.Options.UseFont = true;
            this.btnSave.Location = new System.Drawing.Point(216, 12);
            this.btnSave.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(86, 30);
            this.btnSave.TabIndex = 0;
            this.btnSave.Text = "保存(&S)";
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // ftPanel
            // 
            this.ftPanel.Controls.Add(this.layControl);
            this.ftPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.ftPanel.Location = new System.Drawing.Point(0, 0);
            this.ftPanel.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.ftPanel.Name = "ftPanel";
            this.ftPanel.Size = new System.Drawing.Size(416, 161);
            this.ftPanel.TabIndex = 4;
            this.ftPanel.TypeOfEntity = DQS.Module.EntityType2.BFIProductPriceEntity;
            // 
            // layControl
            // 
            this.layControl.Controls.Add(this.txtRemark);
            this.layControl.Controls.Add(this.txtPopupProduct);
            this.layControl.Controls.Add(this.spePrice);
            this.layControl.Controls.Add(this.txtPopupStyle);
            this.layControl.Dock = System.Windows.Forms.DockStyle.Fill;
            this.layControl.Location = new System.Drawing.Point(2, 2);
            this.layControl.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.layControl.Name = "layControl";
            this.layControl.Root = this.layControlGroup;
            this.layControl.Size = new System.Drawing.Size(412, 157);
            this.layControl.TabIndex = 0;
            this.layControl.Text = "layoutControl1";
            // 
            // txtRemark
            // 
            this.txtRemark.AlphabeticFiled = null;
            this.txtRemark.EntityField = DQS.Module.Entities.BFIProductPriceEntityFields2.PriceRemrk;
            this.txtRemark.IsIntegerOnly = false;
            this.txtRemark.IsNullString = null;
            this.txtRemark.IsNullValidate = false;
            this.txtRemark.IsTransferAlphabetic = false;
            this.txtRemark.Location = new System.Drawing.Point(75, 99);
            this.txtRemark.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtRemark.Name = "txtRemark";
            this.txtRemark.Size = new System.Drawing.Size(325, 25);
            this.txtRemark.StyleController = this.layControl;
            this.txtRemark.TabIndex = 6;
            // 
            // txtPopupProduct
            // 
            this.txtPopupProduct.AlphabeticFiled = null;
            this.txtPopupProduct.EditData = null;
            this.txtPopupProduct.Fields = "产品ID,产品编号,产品名称,产品名称Spell,生产厂商,规格型号,包装规格型号,产品类别,注册证号";
            this.txtPopupProduct.Filter = null;
            this.txtPopupProduct.FormatQueryString = "[产品编号] LIKE \'%{0}%\' OR [产品名称] LIKE \'%{0}%\' OR [产品名称Spell] LIKE \'%{0}%\'";
            this.txtPopupProduct.IsIntegerOnly = false;
            this.txtPopupProduct.IsNullString = "产品名称不能为空。";
            this.txtPopupProduct.IsNullValidate = true;
            this.txtPopupProduct.IsTransferAlphabetic = false;
            this.txtPopupProduct.Location = new System.Drawing.Point(75, 12);
            this.txtPopupProduct.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtPopupProduct.MemberText = "产品名称";
            this.txtPopupProduct.MemberValue = "产品ID";
            this.txtPopupProduct.Name = "txtPopupProduct";
            this.txtPopupProduct.PageSize = 0;
            this.txtPopupProduct.PrimaryField = "产品ID";
            this.txtPopupProduct.Properties.Appearance.BackColor = System.Drawing.Color.White;
            this.txtPopupProduct.Properties.Appearance.Options.UseBackColor = true;
            this.txtPopupProduct.Properties.ReadOnly = true;
            this.txtPopupProduct.Size = new System.Drawing.Size(325, 25);
            this.txtPopupProduct.StyleController = this.layControl;
            this.txtPopupProduct.TabIndex = 3;
            this.txtPopupProduct.ViewName = "vw_AllProduct";
            // 
            // spePrice
            // 
            this.spePrice.EditValue = new decimal(new int[] {
            0,
            0,
            0,
            0});
            this.spePrice.Location = new System.Drawing.Point(75, 70);
            this.spePrice.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.spePrice.Name = "spePrice";
            this.spePrice.Properties.AllowNullInput = DevExpress.Utils.DefaultBoolean.False;
            this.spePrice.Properties.AppearanceFocused.BackColor = System.Drawing.Color.Azure;
            this.spePrice.Properties.AppearanceFocused.Options.UseBackColor = true;
            this.spePrice.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton()});
            this.spePrice.Properties.MaxValue = new decimal(new int[] {
            1000000,
            0,
            0,
            0});
            this.spePrice.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.spePrice.Size = new System.Drawing.Size(325, 25);
            this.spePrice.StyleController = this.layControl;
            this.spePrice.TabIndex = 2;
            // 
            // txtPopupStyle
            // 
            this.txtPopupStyle.AlphabeticFiled = null;
            this.txtPopupStyle.EditData = null;
            this.txtPopupStyle.Fields = "分类ID,价格分类,价格分类Spell,分类类型,分类描述,备注";
            this.txtPopupStyle.Filter = null;
            this.txtPopupStyle.FormatQueryString = "[价格分类] LIKE \'%{0}%\' OR [价格分类Spell] LIKE \'%{0}%\'";
            this.txtPopupStyle.IsIntegerOnly = false;
            this.txtPopupStyle.IsNullString = "价格分类不能为空。";
            this.txtPopupStyle.IsNullValidate = true;
            this.txtPopupStyle.IsTransferAlphabetic = false;
            this.txtPopupStyle.Location = new System.Drawing.Point(75, 41);
            this.txtPopupStyle.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtPopupStyle.MemberText = "价格分类";
            this.txtPopupStyle.MemberValue = "分类ID";
            this.txtPopupStyle.Name = "txtPopupStyle";
            this.txtPopupStyle.PageSize = 0;
            this.txtPopupStyle.PrimaryField = "分类ID";
            this.txtPopupStyle.Properties.Appearance.BackColor = System.Drawing.Color.White;
            this.txtPopupStyle.Properties.Appearance.Options.UseBackColor = true;
            this.txtPopupStyle.Properties.ReadOnly = true;
            this.txtPopupStyle.Size = new System.Drawing.Size(325, 25);
            this.txtPopupStyle.StyleController = this.layControl;
            this.txtPopupStyle.TabIndex = 4;
            this.txtPopupStyle.ViewName = "vw_AllProductPriceStyle";
            // 
            // layControlGroup
            // 
            this.layControlGroup.CustomizationFormText = "产品价格设定";
            this.layControlGroup.EnableIndentsWithoutBorders = DevExpress.Utils.DefaultBoolean.True;
            this.layControlGroup.GroupBordersVisible = false;
            this.layControlGroup.Items.AddRange(new DevExpress.XtraLayout.BaseLayoutItem[] {
            this.layPriceStyle,
            this.layPrice,
            this.layProduct,
            this.layRemark});
            this.layControlGroup.Location = new System.Drawing.Point(0, 0);
            this.layControlGroup.Name = "layControlGroup";
            this.layControlGroup.Size = new System.Drawing.Size(412, 157);
            this.layControlGroup.Spacing = new DevExpress.XtraLayout.Utils.Padding(0, 0, 0, 0);
            this.layControlGroup.Text = "产品价格设定";
            this.layControlGroup.TextVisible = false;
            // 
            // layPriceStyle
            // 
            this.layPriceStyle.Control = this.txtPopupStyle;
            this.layPriceStyle.CustomizationFormText = "价格分类";
            this.layPriceStyle.Location = new System.Drawing.Point(0, 29);
            this.layPriceStyle.Name = "layPriceStyle";
            this.layPriceStyle.Size = new System.Drawing.Size(392, 29);
            this.layPriceStyle.Text = "价格分类";
            this.layPriceStyle.TextSize = new System.Drawing.Size(60, 18);
            // 
            // layPrice
            // 
            this.layPrice.Control = this.spePrice;
            this.layPrice.CustomizationFormText = "价格(元)";
            this.layPrice.Location = new System.Drawing.Point(0, 58);
            this.layPrice.Name = "layPrice";
            this.layPrice.Size = new System.Drawing.Size(392, 29);
            this.layPrice.Text = "价格(元)";
            this.layPrice.TextSize = new System.Drawing.Size(60, 18);
            // 
            // layProduct
            // 
            this.layProduct.Control = this.txtPopupProduct;
            this.layProduct.CustomizationFormText = "产品名称";
            this.layProduct.Location = new System.Drawing.Point(0, 0);
            this.layProduct.Name = "layProduct";
            this.layProduct.Size = new System.Drawing.Size(392, 29);
            this.layProduct.Text = "产品名称";
            this.layProduct.TextSize = new System.Drawing.Size(60, 18);
            // 
            // layRemark
            // 
            this.layRemark.Control = this.txtRemark;
            this.layRemark.CustomizationFormText = "备注";
            this.layRemark.Location = new System.Drawing.Point(0, 87);
            this.layRemark.Name = "layRemark";
            this.layRemark.Size = new System.Drawing.Size(392, 50);
            this.layRemark.Text = "备注";
            this.layRemark.TextSize = new System.Drawing.Size(60, 18);
            // 
            // FrmSinglePrice
            // 
            this.AcceptButton = this.btnSave;
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 18F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CancelButton = this.btnCancel;
            this.ClientSize = new System.Drawing.Size(416, 216);
            this.Controls.Add(this.ftPanel);
            this.Controls.Add(this.pnOperating);
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Name = "FrmSinglePrice";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "产品价格设定";
            this.Load += new System.EventHandler(this.FrmSinglePrice_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pnOperating)).EndInit();
            this.pnOperating.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.ftPanel)).EndInit();
            this.ftPanel.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.layControl)).EndInit();
            this.layControl.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.txtRemark.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtPopupProduct.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.spePrice.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtPopupStyle.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layControlGroup)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layPriceStyle)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layPrice)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layProduct)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layRemark)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraEditors.PanelControl pnOperating;
        private DevExpress.XtraEditors.SimpleButton btnCancel;
        private DevExpress.XtraEditors.SimpleButton btnSave;
        private DQS.Controls.FieldTextBoxPanel ftPanel;
        private DevExpress.XtraLayout.LayoutControl layControl;
        private DQS.Controls.TextBoxPopupEx txtPopupStyle;
        private DevExpress.XtraLayout.LayoutControlGroup layControlGroup;
        private DevExpress.XtraLayout.LayoutControlItem layPriceStyle;
        private DevExpress.XtraEditors.SpinEdit spePrice;
        private DevExpress.XtraLayout.LayoutControlItem layPrice;
        private DQS.Controls.TextBoxPopupEx txtPopupProduct;
        private DevExpress.XtraLayout.LayoutControlItem layProduct;
        private DQS.Controls.BFIProductPriceEntityTextBox txtRemark;
        private DevExpress.XtraLayout.LayoutControlItem layRemark;
    }
}