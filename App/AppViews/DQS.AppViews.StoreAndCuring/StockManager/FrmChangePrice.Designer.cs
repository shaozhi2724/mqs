namespace DQS.AppViews.StoreAndCuring.StockManager
{
    partial class FrmChangePrice
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
            this.txtAmount = new DevExpress.XtraEditors.TextEdit();
            this.labelControl1 = new DevExpress.XtraEditors.LabelControl();
            this.btnSave = new DevExpress.XtraEditors.SimpleButton();
            this.btnXg = new DevExpress.XtraEditors.SimpleButton();
            this.btnCancel = new DevExpress.XtraEditors.SimpleButton();
            this.txtOldUnitPrice = new DevExpress.XtraEditors.TextEdit();
            this.labelControl2 = new DevExpress.XtraEditors.LabelControl();
            this.txtNewUnitPrice = new DevExpress.XtraEditors.TextEdit();
            this.txtTradePrice = new DevExpress.XtraEditors.TextEdit();
            this.labelControl3 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl4 = new DevExpress.XtraEditors.LabelControl();
            this.txtAdjustPrice = new DevExpress.XtraEditors.TextEdit();
            this.txtAdjustTotalPrice = new DevExpress.XtraEditors.TextEdit();
            this.labelControl5 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl6 = new DevExpress.XtraEditors.LabelControl();
            this.txtDealerName = new DevExpress.XtraEditors.ComboBoxEdit();
            this.labelControl7 = new DevExpress.XtraEditors.LabelControl();
            this.btnOK = new DevExpress.XtraEditors.SimpleButton();
            ((System.ComponentModel.ISupportInitialize)(this.txtAmount.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtOldUnitPrice.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtNewUnitPrice.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtTradePrice.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtAdjustPrice.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtAdjustTotalPrice.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtDealerName.Properties)).BeginInit();
            this.SuspendLayout();
            // 
            // txtAmount
            // 
            this.txtAmount.EditValue = "0";
            this.txtAmount.Location = new System.Drawing.Point(103, 63);
            this.txtAmount.Name = "txtAmount";
            this.txtAmount.Size = new System.Drawing.Size(100, 21);
            this.txtAmount.TabIndex = 0;
            this.txtAmount.TextChanged += new System.EventHandler(this.txtChanged);
            this.txtAmount.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtKeyPress);
            // 
            // labelControl1
            // 
            this.labelControl1.Location = new System.Drawing.Point(48, 66);
            this.labelControl1.Name = "labelControl1";
            this.labelControl1.Size = new System.Drawing.Size(48, 14);
            this.labelControl1.TabIndex = 1;
            this.labelControl1.Text = "调整数量";
            // 
            // btnSave
            // 
            this.btnSave.Location = new System.Drawing.Point(131, 223);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(75, 23);
            this.btnSave.TabIndex = 2;
            this.btnSave.Text = "保存";
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // btnXg
            // 
            this.btnXg.Location = new System.Drawing.Point(231, 223);
            this.btnXg.Name = "btnXg";
            this.btnXg.Size = new System.Drawing.Size(75, 23);
            this.btnXg.TabIndex = 2;
            this.btnXg.Text = "修改";
            this.btnXg.Click += new System.EventHandler(this.btnXg_Click);
            // 
            // btnCancel
            // 
            this.btnCancel.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btnCancel.Location = new System.Drawing.Point(331, 223);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(75, 23);
            this.btnCancel.TabIndex = 2;
            this.btnCancel.Text = "取消";
            // 
            // txtOldUnitPrice
            // 
            this.txtOldUnitPrice.EditValue = "0";
            this.txtOldUnitPrice.Location = new System.Drawing.Point(295, 63);
            this.txtOldUnitPrice.Name = "txtOldUnitPrice";
            this.txtOldUnitPrice.Size = new System.Drawing.Size(100, 21);
            this.txtOldUnitPrice.TabIndex = 0;
            this.txtOldUnitPrice.TextChanged += new System.EventHandler(this.txtChanged);
            this.txtOldUnitPrice.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtKeyPress);
            // 
            // labelControl2
            // 
            this.labelControl2.Location = new System.Drawing.Point(240, 66);
            this.labelControl2.Name = "labelControl2";
            this.labelControl2.Size = new System.Drawing.Size(36, 14);
            this.labelControl2.TabIndex = 1;
            this.labelControl2.Text = "原单价";
            // 
            // txtNewUnitPrice
            // 
            this.txtNewUnitPrice.EditValue = "0";
            this.txtNewUnitPrice.Location = new System.Drawing.Point(103, 102);
            this.txtNewUnitPrice.Name = "txtNewUnitPrice";
            this.txtNewUnitPrice.Size = new System.Drawing.Size(100, 21);
            this.txtNewUnitPrice.TabIndex = 0;
            this.txtNewUnitPrice.TextChanged += new System.EventHandler(this.txtChanged);
            this.txtNewUnitPrice.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtKeyPress);
            // 
            // txtTradePrice
            // 
            this.txtTradePrice.EditValue = "0";
            this.txtTradePrice.Location = new System.Drawing.Point(295, 102);
            this.txtTradePrice.Name = "txtTradePrice";
            this.txtTradePrice.Size = new System.Drawing.Size(100, 21);
            this.txtTradePrice.TabIndex = 0;
            this.txtTradePrice.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtKeyPress);
            // 
            // labelControl3
            // 
            this.labelControl3.Location = new System.Drawing.Point(48, 105);
            this.labelControl3.Name = "labelControl3";
            this.labelControl3.Size = new System.Drawing.Size(36, 14);
            this.labelControl3.TabIndex = 1;
            this.labelControl3.Text = "新单价";
            // 
            // labelControl4
            // 
            this.labelControl4.Location = new System.Drawing.Point(240, 105);
            this.labelControl4.Name = "labelControl4";
            this.labelControl4.Size = new System.Drawing.Size(48, 14);
            this.labelControl4.TabIndex = 1;
            this.labelControl4.Text = "新批发价";
            // 
            // txtAdjustPrice
            // 
            this.txtAdjustPrice.Location = new System.Drawing.Point(103, 141);
            this.txtAdjustPrice.Name = "txtAdjustPrice";
            this.txtAdjustPrice.Properties.ReadOnly = true;
            this.txtAdjustPrice.Size = new System.Drawing.Size(100, 21);
            this.txtAdjustPrice.TabIndex = 0;
            // 
            // txtAdjustTotalPrice
            // 
            this.txtAdjustTotalPrice.Location = new System.Drawing.Point(295, 141);
            this.txtAdjustTotalPrice.Name = "txtAdjustTotalPrice";
            this.txtAdjustTotalPrice.Properties.ReadOnly = true;
            this.txtAdjustTotalPrice.Size = new System.Drawing.Size(100, 21);
            this.txtAdjustTotalPrice.TabIndex = 0;
            // 
            // labelControl5
            // 
            this.labelControl5.Location = new System.Drawing.Point(48, 144);
            this.labelControl5.Name = "labelControl5";
            this.labelControl5.Size = new System.Drawing.Size(24, 14);
            this.labelControl5.TabIndex = 1;
            this.labelControl5.Text = "差价";
            // 
            // labelControl6
            // 
            this.labelControl6.Location = new System.Drawing.Point(240, 144);
            this.labelControl6.Name = "labelControl6";
            this.labelControl6.Size = new System.Drawing.Size(48, 14);
            this.labelControl6.TabIndex = 1;
            this.labelControl6.Text = "差价金额";
            // 
            // txtDealerName
            // 
            this.txtDealerName.Location = new System.Drawing.Point(103, 23);
            this.txtDealerName.Name = "txtDealerName";
            this.txtDealerName.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.txtDealerName.Properties.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.DisableTextEditor;
            this.txtDealerName.Size = new System.Drawing.Size(292, 21);
            this.txtDealerName.TabIndex = 19;
            // 
            // labelControl7
            // 
            this.labelControl7.Location = new System.Drawing.Point(48, 26);
            this.labelControl7.Name = "labelControl7";
            this.labelControl7.Size = new System.Drawing.Size(24, 14);
            this.labelControl7.TabIndex = 1;
            this.labelControl7.Text = "单位";
            // 
            // btnOK
            // 
            this.btnOK.Location = new System.Drawing.Point(331, 185);
            this.btnOK.Name = "btnOK";
            this.btnOK.Size = new System.Drawing.Size(75, 23);
            this.btnOK.TabIndex = 2;
            this.btnOK.Text = "确认";
            this.btnOK.Click += new System.EventHandler(this.btnOK_Click);
            // 
            // FrmChangePrice
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 14F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(453, 268);
            this.Controls.Add(this.txtDealerName);
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.btnOK);
            this.Controls.Add(this.btnXg);
            this.Controls.Add(this.btnSave);
            this.Controls.Add(this.labelControl6);
            this.Controls.Add(this.labelControl4);
            this.Controls.Add(this.labelControl2);
            this.Controls.Add(this.labelControl5);
            this.Controls.Add(this.txtAdjustTotalPrice);
            this.Controls.Add(this.labelControl3);
            this.Controls.Add(this.txtTradePrice);
            this.Controls.Add(this.txtAdjustPrice);
            this.Controls.Add(this.labelControl7);
            this.Controls.Add(this.labelControl1);
            this.Controls.Add(this.txtNewUnitPrice);
            this.Controls.Add(this.txtOldUnitPrice);
            this.Controls.Add(this.txtAmount);
            this.Name = "FrmChangePrice";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "库存调价";
            this.Load += new System.EventHandler(this.FrmChangePrice_Load);
            ((System.ComponentModel.ISupportInitialize)(this.txtAmount.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtOldUnitPrice.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtNewUnitPrice.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtTradePrice.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtAdjustPrice.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtAdjustTotalPrice.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtDealerName.Properties)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private DevExpress.XtraEditors.TextEdit txtAmount;
        private DevExpress.XtraEditors.LabelControl labelControl1;
        private DevExpress.XtraEditors.SimpleButton btnSave;
        private DevExpress.XtraEditors.SimpleButton btnXg;
        private DevExpress.XtraEditors.SimpleButton btnCancel;
        private DevExpress.XtraEditors.TextEdit txtOldUnitPrice;
        private DevExpress.XtraEditors.LabelControl labelControl2;
        private DevExpress.XtraEditors.TextEdit txtNewUnitPrice;
        private DevExpress.XtraEditors.TextEdit txtTradePrice;
        private DevExpress.XtraEditors.LabelControl labelControl3;
        private DevExpress.XtraEditors.LabelControl labelControl4;
        private DevExpress.XtraEditors.TextEdit txtAdjustPrice;
        private DevExpress.XtraEditors.TextEdit txtAdjustTotalPrice;
        private DevExpress.XtraEditors.LabelControl labelControl5;
        private DevExpress.XtraEditors.LabelControl labelControl6;
        private DevExpress.XtraEditors.ComboBoxEdit txtDealerName;
        private DevExpress.XtraEditors.LabelControl labelControl7;
        private DevExpress.XtraEditors.SimpleButton btnOK;
    }
}