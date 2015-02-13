namespace DQS.AppViews.Operation
{
    partial class FrmOperation
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
            this.tbtnPurchase = new DQS.Controls.ToolButton();
            this.tbtnSale = new DQS.Controls.ToolButton();
            this.tbtnPurchaseBack = new DQS.Controls.ToolButton();
            this.tbtnSaleBack = new DQS.Controls.ToolButton();
            this.SuspendLayout();
            // 
            // tbtnPurchase
            // 
            this.tbtnPurchase.AllowFocus = false;
            this.tbtnPurchase.Appearance.BackColor = System.Drawing.Color.Transparent;
            this.tbtnPurchase.Appearance.Font = new System.Drawing.Font("微软雅黑", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbtnPurchase.Appearance.ForeColor = System.Drawing.Color.Black;
            this.tbtnPurchase.Appearance.Options.UseBackColor = true;
            this.tbtnPurchase.Appearance.Options.UseFont = true;
            this.tbtnPurchase.Appearance.Options.UseForeColor = true;
            this.tbtnPurchase.ButtonStyle = DevExpress.XtraEditors.Controls.BorderStyles.UltraFlat;
            this.tbtnPurchase.Cursor = System.Windows.Forms.Cursors.Hand;
            this.tbtnPurchase.Image = global::DQS.AppViews.Operation.Properties.Resources.采购订单管理;
            this.tbtnPurchase.ImageLocation = DevExpress.XtraEditors.ImageLocation.TopCenter;
            this.tbtnPurchase.Location = new System.Drawing.Point(88, 90);
            this.tbtnPurchase.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.tbtnPurchase.MenuCode = "Purchase";
            this.tbtnPurchase.MenuFullClass = "DQS.AppViews.Operation.PurchaseAndSaleManager.FrmPurchase, DQS.AppViews.Operation" +
    "";
            this.tbtnPurchase.MenuName = "采购订单管理";
            this.tbtnPurchase.MouseEnterImage = global::DQS.AppViews.Operation.Properties.Resources.采购订单管理MouseEnter;
            this.tbtnPurchase.Name = "tbtnPurchase";
            this.tbtnPurchase.Size = new System.Drawing.Size(151, 158);
            this.tbtnPurchase.TabIndex = 0;
            this.tbtnPurchase.Text = "采购订单管理";
            // 
            // tbtnSale
            // 
            this.tbtnSale.AllowFocus = false;
            this.tbtnSale.Appearance.BackColor = System.Drawing.Color.Transparent;
            this.tbtnSale.Appearance.Font = new System.Drawing.Font("微软雅黑", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbtnSale.Appearance.ForeColor = System.Drawing.Color.Black;
            this.tbtnSale.Appearance.Options.UseBackColor = true;
            this.tbtnSale.Appearance.Options.UseFont = true;
            this.tbtnSale.Appearance.Options.UseForeColor = true;
            this.tbtnSale.ButtonStyle = DevExpress.XtraEditors.Controls.BorderStyles.UltraFlat;
            this.tbtnSale.Cursor = System.Windows.Forms.Cursors.Hand;
            this.tbtnSale.Image = global::DQS.AppViews.Operation.Properties.Resources.销售订单管理;
            this.tbtnSale.ImageLocation = DevExpress.XtraEditors.ImageLocation.TopCenter;
            this.tbtnSale.Location = new System.Drawing.Point(361, 90);
            this.tbtnSale.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.tbtnSale.MenuCode = "Sale";
            this.tbtnSale.MenuFullClass = "DQS.AppViews.Operation.PurchaseAndSaleManager.FrmSale, DQS.AppViews.Operation";
            this.tbtnSale.MenuName = "销售订单管理";
            this.tbtnSale.MouseEnterImage = global::DQS.AppViews.Operation.Properties.Resources.销售出库单管理MouseEnter;
            this.tbtnSale.Name = "tbtnSale";
            this.tbtnSale.Size = new System.Drawing.Size(151, 158);
            this.tbtnSale.TabIndex = 1;
            this.tbtnSale.Text = "销售订单管理";
            // 
            // tbtnPurchaseBack
            // 
            this.tbtnPurchaseBack.AllowFocus = false;
            this.tbtnPurchaseBack.Appearance.BackColor = System.Drawing.Color.Transparent;
            this.tbtnPurchaseBack.Appearance.Font = new System.Drawing.Font("微软雅黑", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbtnPurchaseBack.Appearance.ForeColor = System.Drawing.Color.Black;
            this.tbtnPurchaseBack.Appearance.Options.UseBackColor = true;
            this.tbtnPurchaseBack.Appearance.Options.UseFont = true;
            this.tbtnPurchaseBack.Appearance.Options.UseForeColor = true;
            this.tbtnPurchaseBack.ButtonStyle = DevExpress.XtraEditors.Controls.BorderStyles.UltraFlat;
            this.tbtnPurchaseBack.Cursor = System.Windows.Forms.Cursors.Hand;
            this.tbtnPurchaseBack.Image = global::DQS.AppViews.Operation.Properties.Resources.采购退货制单;
            this.tbtnPurchaseBack.ImageLocation = DevExpress.XtraEditors.ImageLocation.TopCenter;
            this.tbtnPurchaseBack.Location = new System.Drawing.Point(88, 360);
            this.tbtnPurchaseBack.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.tbtnPurchaseBack.MenuCode = "PurchaseBack";
            this.tbtnPurchaseBack.MenuFullClass = "DQS.AppViews.Operation.BackManager.FrmPurchaseBack, DQS.AppViews.Operation";
            this.tbtnPurchaseBack.MenuName = "采购退货制单";
            this.tbtnPurchaseBack.MouseEnterImage = global::DQS.AppViews.Operation.Properties.Resources.采购退货制单MouseEnter;
            this.tbtnPurchaseBack.Name = "tbtnPurchaseBack";
            this.tbtnPurchaseBack.Size = new System.Drawing.Size(151, 158);
            this.tbtnPurchaseBack.TabIndex = 2;
            this.tbtnPurchaseBack.Text = "采购退货制单";
            // 
            // tbtnSaleBack
            // 
            this.tbtnSaleBack.AllowFocus = false;
            this.tbtnSaleBack.Appearance.BackColor = System.Drawing.Color.Transparent;
            this.tbtnSaleBack.Appearance.Font = new System.Drawing.Font("微软雅黑", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbtnSaleBack.Appearance.ForeColor = System.Drawing.Color.Black;
            this.tbtnSaleBack.Appearance.Options.UseBackColor = true;
            this.tbtnSaleBack.Appearance.Options.UseFont = true;
            this.tbtnSaleBack.Appearance.Options.UseForeColor = true;
            this.tbtnSaleBack.ButtonStyle = DevExpress.XtraEditors.Controls.BorderStyles.UltraFlat;
            this.tbtnSaleBack.Cursor = System.Windows.Forms.Cursors.Hand;
            this.tbtnSaleBack.Image = global::DQS.AppViews.Operation.Properties.Resources.销售退货订单管理;
            this.tbtnSaleBack.ImageLocation = DevExpress.XtraEditors.ImageLocation.TopCenter;
            this.tbtnSaleBack.Location = new System.Drawing.Point(361, 360);
            this.tbtnSaleBack.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.tbtnSaleBack.MenuCode = "SaleBack";
            this.tbtnSaleBack.MenuFullClass = "DQS.AppViews.Operation.BackManager.FrmSaleBack, DQS.AppViews.Operation";
            this.tbtnSaleBack.MenuName = "销售退货制单";
            this.tbtnSaleBack.MouseEnterImage = global::DQS.AppViews.Operation.Properties.Resources.销售退货单管理MouseEnter;
            this.tbtnSaleBack.Name = "tbtnSaleBack";
            this.tbtnSaleBack.Size = new System.Drawing.Size(151, 158);
            this.tbtnSaleBack.TabIndex = 3;
            this.tbtnSaleBack.Text = "销售退货制单";
            // 
            // FrmOperation
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 18F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(896, 723);
            this.Controls.Add(this.tbtnSaleBack);
            this.Controls.Add(this.tbtnPurchaseBack);
            this.Controls.Add(this.tbtnSale);
            this.Controls.Add(this.tbtnPurchase);
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Name = "FrmOperation";
            this.Text = "FrmOperation";
            this.ResumeLayout(false);

        }

        #endregion

        private DQS.Controls.ToolButton tbtnPurchase;
        private DQS.Controls.ToolButton tbtnSale;
        private DQS.Controls.ToolButton tbtnPurchaseBack;
        private DQS.Controls.ToolButton tbtnSaleBack;
    }
}