namespace DQS.AppViews.OtherOperation.Finance
{
    partial class FrmPaymentBill
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
            this.gridControl = new DevExpress.XtraGrid.GridControl();
            this.gridView = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.panelControl2 = new DevExpress.XtraEditors.PanelControl();
            this.btnCancel = new DevExpress.XtraEditors.SimpleButton();
            this.btnSave = new DevExpress.XtraEditors.SimpleButton();
            this.lblTotalPrice = new DevExpress.XtraEditors.LabelControl();
            this.labelControl1 = new DevExpress.XtraEditors.LabelControl();
            this.panelControl1 = new DevExpress.XtraEditors.PanelControl();
            this.deBillDate = new DevExpress.XtraEditors.DateEdit();
            this.btnOnPassage = new DevExpress.XtraEditors.SimpleButton();
            this.cboBillingType = new DevExpress.XtraEditors.ComboBoxEdit();
            this.cboTax = new DevExpress.XtraEditors.ComboBoxEdit();
            this.txtTaxCode = new DevExpress.XtraEditors.TextEdit();
            this.txtIncludeTaxPrice = new DevExpress.XtraEditors.TextEdit();
            this.txtTaxPrice = new DevExpress.XtraEditors.TextEdit();
            this.txtNotIncludeTaxPrice = new DevExpress.XtraEditors.TextEdit();
            this.txtVoucherCode = new DevExpress.XtraEditors.TextEdit();
            this.labelControl10 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl6 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl9 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl5 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl8 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl4 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl7 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl2 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl3 = new DevExpress.XtraEditors.LabelControl();
            this.txtDealerName = new DevExpress.XtraEditors.TextEdit();
            ((System.ComponentModel.ISupportInitialize)(this.gridControl)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.panelControl2)).BeginInit();
            this.panelControl2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.panelControl1)).BeginInit();
            this.panelControl1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.deBillDate.Properties.VistaTimeProperties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.deBillDate.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cboBillingType.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cboTax.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtTaxCode.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtIncludeTaxPrice.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtTaxPrice.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtNotIncludeTaxPrice.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtVoucherCode.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtDealerName.Properties)).BeginInit();
            this.SuspendLayout();
            // 
            // gridControl
            // 
            this.gridControl.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.gridControl.Location = new System.Drawing.Point(3, 109);
            this.gridControl.MainView = this.gridView;
            this.gridControl.Name = "gridControl";
            this.gridControl.Size = new System.Drawing.Size(689, 271);
            this.gridControl.TabIndex = 3;
            this.gridControl.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridView});
            // 
            // gridView
            // 
            this.gridView.GridControl = this.gridControl;
            this.gridView.IndicatorWidth = 40;
            this.gridView.Name = "gridView";
            this.gridView.CustomDrawRowIndicator += new DevExpress.XtraGrid.Views.Grid.RowIndicatorCustomDrawEventHandler(this.gridView_CustomDrawRowIndicator);
            // 
            // panelControl2
            // 
            this.panelControl2.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panelControl2.Controls.Add(this.btnCancel);
            this.panelControl2.Controls.Add(this.btnSave);
            this.panelControl2.Controls.Add(this.lblTotalPrice);
            this.panelControl2.Controls.Add(this.labelControl1);
            this.panelControl2.Location = new System.Drawing.Point(3, 382);
            this.panelControl2.Name = "panelControl2";
            this.panelControl2.Size = new System.Drawing.Size(690, 48);
            this.panelControl2.TabIndex = 5;
            // 
            // btnCancel
            // 
            this.btnCancel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnCancel.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btnCancel.Location = new System.Drawing.Point(581, 11);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(87, 27);
            this.btnCancel.TabIndex = 0;
            this.btnCancel.Text = "取消";
            // 
            // btnSave
            // 
            this.btnSave.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnSave.Location = new System.Drawing.Point(442, 11);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(87, 27);
            this.btnSave.TabIndex = 0;
            this.btnSave.Text = "保存";
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // lblTotalPrice
            // 
            this.lblTotalPrice.Location = new System.Drawing.Point(100, 16);
            this.lblTotalPrice.Name = "lblTotalPrice";
            this.lblTotalPrice.Size = new System.Drawing.Size(0, 14);
            this.lblTotalPrice.TabIndex = 0;
            // 
            // labelControl1
            // 
            this.labelControl1.Location = new System.Drawing.Point(10, 16);
            this.labelControl1.Name = "labelControl1";
            this.labelControl1.Size = new System.Drawing.Size(84, 14);
            this.labelControl1.TabIndex = 0;
            this.labelControl1.Text = "选中单据总额：";
            // 
            // panelControl1
            // 
            this.panelControl1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panelControl1.Controls.Add(this.deBillDate);
            this.panelControl1.Controls.Add(this.btnOnPassage);
            this.panelControl1.Controls.Add(this.cboBillingType);
            this.panelControl1.Controls.Add(this.cboTax);
            this.panelControl1.Controls.Add(this.txtTaxCode);
            this.panelControl1.Controls.Add(this.txtIncludeTaxPrice);
            this.panelControl1.Controls.Add(this.txtTaxPrice);
            this.panelControl1.Controls.Add(this.txtNotIncludeTaxPrice);
            this.panelControl1.Controls.Add(this.txtDealerName);
            this.panelControl1.Controls.Add(this.txtVoucherCode);
            this.panelControl1.Controls.Add(this.labelControl10);
            this.panelControl1.Controls.Add(this.labelControl6);
            this.panelControl1.Controls.Add(this.labelControl9);
            this.panelControl1.Controls.Add(this.labelControl5);
            this.panelControl1.Controls.Add(this.labelControl8);
            this.panelControl1.Controls.Add(this.labelControl4);
            this.panelControl1.Controls.Add(this.labelControl7);
            this.panelControl1.Controls.Add(this.labelControl2);
            this.panelControl1.Controls.Add(this.labelControl3);
            this.panelControl1.Location = new System.Drawing.Point(3, 3);
            this.panelControl1.Name = "panelControl1";
            this.panelControl1.Size = new System.Drawing.Size(689, 104);
            this.panelControl1.TabIndex = 7;
            // 
            // deBillDate
            // 
            this.deBillDate.EditValue = null;
            this.deBillDate.Location = new System.Drawing.Point(581, 11);
            this.deBillDate.Name = "deBillDate";
            this.deBillDate.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.deBillDate.Properties.VistaTimeProperties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton()});
            this.deBillDate.Size = new System.Drawing.Size(96, 21);
            this.deBillDate.TabIndex = 22;
            // 
            // btnOnPassage
            // 
            this.btnOnPassage.Location = new System.Drawing.Point(581, 70);
            this.btnOnPassage.Name = "btnOnPassage";
            this.btnOnPassage.Size = new System.Drawing.Size(96, 27);
            this.btnOnPassage.TabIndex = 17;
            this.btnOnPassage.Text = "选择在途单据";
            this.btnOnPassage.Click += new System.EventHandler(this.btnOnPassage_Click);
            // 
            // cboBillingType
            // 
            this.cboBillingType.Location = new System.Drawing.Point(419, 11);
            this.cboBillingType.Name = "cboBillingType";
            this.cboBillingType.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.cboBillingType.Size = new System.Drawing.Size(114, 21);
            this.cboBillingType.TabIndex = 16;
            // 
            // cboTax
            // 
            this.cboTax.Location = new System.Drawing.Point(581, 42);
            this.cboTax.Name = "cboTax";
            this.cboTax.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.cboTax.Size = new System.Drawing.Size(96, 21);
            this.cboTax.TabIndex = 16;
            this.cboTax.TextChanged += new System.EventHandler(this.cboTax_TextChanged);
            // 
            // txtTaxCode
            // 
            this.txtTaxCode.Location = new System.Drawing.Point(419, 42);
            this.txtTaxCode.Name = "txtTaxCode";
            this.txtTaxCode.Size = new System.Drawing.Size(114, 21);
            this.txtTaxCode.TabIndex = 15;
            // 
            // txtIncludeTaxPrice
            // 
            this.txtIncludeTaxPrice.EditValue = "0";
            this.txtIncludeTaxPrice.Location = new System.Drawing.Point(76, 73);
            this.txtIncludeTaxPrice.Name = "txtIncludeTaxPrice";
            this.txtIncludeTaxPrice.Size = new System.Drawing.Size(104, 21);
            this.txtIncludeTaxPrice.TabIndex = 15;
            // 
            // txtTaxPrice
            // 
            this.txtTaxPrice.Location = new System.Drawing.Point(228, 74);
            this.txtTaxPrice.Name = "txtTaxPrice";
            this.txtTaxPrice.Size = new System.Drawing.Size(107, 21);
            this.txtTaxPrice.TabIndex = 15;
            // 
            // txtNotIncludeTaxPrice
            // 
            this.txtNotIncludeTaxPrice.Location = new System.Drawing.Point(419, 74);
            this.txtNotIncludeTaxPrice.Name = "txtNotIncludeTaxPrice";
            this.txtNotIncludeTaxPrice.Size = new System.Drawing.Size(114, 21);
            this.txtNotIncludeTaxPrice.TabIndex = 15;
            // 
            // txtVoucherCode
            // 
            this.txtVoucherCode.Location = new System.Drawing.Point(76, 42);
            this.txtVoucherCode.Name = "txtVoucherCode";
            this.txtVoucherCode.Size = new System.Drawing.Size(259, 21);
            this.txtVoucherCode.TabIndex = 15;
            // 
            // labelControl10
            // 
            this.labelControl10.Location = new System.Drawing.Point(539, 14);
            this.labelControl10.Name = "labelControl10";
            this.labelControl10.Size = new System.Drawing.Size(36, 14);
            this.labelControl10.TabIndex = 10;
            this.labelControl10.Text = "日期：";
            // 
            // labelControl6
            // 
            this.labelControl6.Location = new System.Drawing.Point(539, 45);
            this.labelControl6.Name = "labelControl6";
            this.labelControl6.Size = new System.Drawing.Size(36, 14);
            this.labelControl6.TabIndex = 10;
            this.labelControl6.Text = "税率：";
            // 
            // labelControl9
            // 
            this.labelControl9.Location = new System.Drawing.Point(341, 14);
            this.labelControl9.Name = "labelControl9";
            this.labelControl9.Size = new System.Drawing.Size(60, 14);
            this.labelControl9.TabIndex = 10;
            this.labelControl9.Text = "发票类型：";
            // 
            // labelControl5
            // 
            this.labelControl5.Location = new System.Drawing.Point(341, 45);
            this.labelControl5.Name = "labelControl5";
            this.labelControl5.Size = new System.Drawing.Size(36, 14);
            this.labelControl5.TabIndex = 10;
            this.labelControl5.Text = "税号：";
            // 
            // labelControl8
            // 
            this.labelControl8.Location = new System.Drawing.Point(341, 77);
            this.labelControl8.Name = "labelControl8";
            this.labelControl8.Size = new System.Drawing.Size(72, 14);
            this.labelControl8.TabIndex = 10;
            this.labelControl8.Text = "不含税金额：";
            // 
            // labelControl4
            // 
            this.labelControl4.Location = new System.Drawing.Point(10, 45);
            this.labelControl4.Name = "labelControl4";
            this.labelControl4.Size = new System.Drawing.Size(48, 14);
            this.labelControl4.TabIndex = 10;
            this.labelControl4.Text = "发票号：";
            // 
            // labelControl7
            // 
            this.labelControl7.Location = new System.Drawing.Point(186, 77);
            this.labelControl7.Name = "labelControl7";
            this.labelControl7.Size = new System.Drawing.Size(36, 14);
            this.labelControl7.TabIndex = 10;
            this.labelControl7.Text = "税额：";
            // 
            // labelControl2
            // 
            this.labelControl2.Location = new System.Drawing.Point(10, 76);
            this.labelControl2.Name = "labelControl2";
            this.labelControl2.Size = new System.Drawing.Size(60, 14);
            this.labelControl2.TabIndex = 10;
            this.labelControl2.Text = "含税金额：";
            // 
            // labelControl3
            // 
            this.labelControl3.Location = new System.Drawing.Point(10, 14);
            this.labelControl3.Name = "labelControl3";
            this.labelControl3.Size = new System.Drawing.Size(60, 14);
            this.labelControl3.TabIndex = 11;
            this.labelControl3.Text = "往来单位：";
            // 
            // txtDealerName
            // 
            this.txtDealerName.Location = new System.Drawing.Point(76, 11);
            this.txtDealerName.Name = "txtDealerName";
            this.txtDealerName.Size = new System.Drawing.Size(259, 21);
            this.txtDealerName.TabIndex = 15;
            this.txtDealerName.Click += new System.EventHandler(this.txtDealerName_Click);
            // 
            // FrmPaymentBill
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 14F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(696, 433);
            this.Controls.Add(this.panelControl1);
            this.Controls.Add(this.panelControl2);
            this.Controls.Add(this.gridControl);
            this.Name = "FrmPaymentBill";
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "采购收发票";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.FrmPaymentBill_Load);
            ((System.ComponentModel.ISupportInitialize)(this.gridControl)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.panelControl2)).EndInit();
            this.panelControl2.ResumeLayout(false);
            this.panelControl2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.panelControl1)).EndInit();
            this.panelControl1.ResumeLayout(false);
            this.panelControl1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.deBillDate.Properties.VistaTimeProperties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.deBillDate.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cboBillingType.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cboTax.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtTaxCode.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtIncludeTaxPrice.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtTaxPrice.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtNotIncludeTaxPrice.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtVoucherCode.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtDealerName.Properties)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraGrid.GridControl gridControl;
        private DevExpress.XtraGrid.Views.Grid.GridView gridView;
        private DevExpress.XtraEditors.PanelControl panelControl2;
        private DevExpress.XtraEditors.SimpleButton btnCancel;
        private DevExpress.XtraEditors.SimpleButton btnSave;
        private DevExpress.XtraEditors.LabelControl labelControl1;
        private DevExpress.XtraEditors.PanelControl panelControl1;
        private DevExpress.XtraEditors.SimpleButton btnOnPassage;
        private DevExpress.XtraEditors.ComboBoxEdit cboTax;
        private DevExpress.XtraEditors.TextEdit txtTaxCode;
        private DevExpress.XtraEditors.TextEdit txtIncludeTaxPrice;
        private DevExpress.XtraEditors.TextEdit txtTaxPrice;
        private DevExpress.XtraEditors.TextEdit txtNotIncludeTaxPrice;
        private DevExpress.XtraEditors.TextEdit txtVoucherCode;
        private DevExpress.XtraEditors.LabelControl labelControl6;
        private DevExpress.XtraEditors.LabelControl labelControl5;
        private DevExpress.XtraEditors.LabelControl labelControl8;
        private DevExpress.XtraEditors.LabelControl labelControl4;
        private DevExpress.XtraEditors.LabelControl labelControl7;
        private DevExpress.XtraEditors.LabelControl labelControl2;
        private DevExpress.XtraEditors.LabelControl labelControl3;
        private DevExpress.XtraEditors.LabelControl lblTotalPrice;
        private DevExpress.XtraEditors.ComboBoxEdit cboBillingType;
        private DevExpress.XtraEditors.LabelControl labelControl9;
        private DevExpress.XtraEditors.DateEdit deBillDate;
        private DevExpress.XtraEditors.LabelControl labelControl10;
        private DevExpress.XtraEditors.TextEdit txtDealerName;
    }
}