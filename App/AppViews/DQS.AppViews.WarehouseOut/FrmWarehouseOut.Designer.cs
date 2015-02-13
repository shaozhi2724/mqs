namespace DQS.AppViews.WarehouseOut
{
    partial class FrmWarehouseOut
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
            this.picl1 = new DevExpress.XtraEditors.PictureEdit();
            this.tbtnCar = new DQS.Controls.ToolButton();
            this.tbtnTransport = new DQS.Controls.ToolButton();
            this.tbtnStockOut = new DQS.Controls.ToolButton();
            this.tbtnReview = new DQS.Controls.ToolButton();
            this.pictureEdit1 = new DevExpress.XtraEditors.PictureEdit();
            ((System.ComponentModel.ISupportInitialize)(this.picl1.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureEdit1.Properties)).BeginInit();
            this.SuspendLayout();
            // 
            // picl1
            // 
            this.picl1.EditValue = global::DQS.AppViews.WarehouseOut.Properties.Resources.line_l;
            this.picl1.Location = new System.Drawing.Point(147, 331);
            this.picl1.Name = "picl1";
            this.picl1.Properties.Appearance.BackColor = System.Drawing.Color.Transparent;
            this.picl1.Properties.Appearance.Options.UseBackColor = true;
            this.picl1.Properties.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.NoBorder;
            this.picl1.Size = new System.Drawing.Size(114, 69);
            this.picl1.TabIndex = 8;
            // 
            // tbtnCar
            // 
            this.tbtnCar.AllowFocus = false;
            this.tbtnCar.Appearance.BackColor = System.Drawing.Color.Transparent;
            this.tbtnCar.Appearance.Font = new System.Drawing.Font("微软雅黑", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbtnCar.Appearance.ForeColor = System.Drawing.Color.Black;
            this.tbtnCar.Appearance.Options.UseBackColor = true;
            this.tbtnCar.Appearance.Options.UseFont = true;
            this.tbtnCar.Appearance.Options.UseForeColor = true;
            this.tbtnCar.ButtonStyle = DevExpress.XtraEditors.Controls.BorderStyles.UltraFlat;
            this.tbtnCar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.tbtnCar.Image = global::DQS.AppViews.WarehouseOut.Properties.Resources.运输车辆登记;
            this.tbtnCar.ImageLocation = DevExpress.XtraEditors.ImageLocation.TopCenter;
            this.tbtnCar.Location = new System.Drawing.Point(267, 22);
            this.tbtnCar.MenuCode = "Car";
            this.tbtnCar.MenuFullClass = "DQS.AppViews.WarehouseOut.WarehouseOutManager.FrmCar, DQS.AppViews.WarehouseOut";
            this.tbtnCar.MenuName = "运输车辆定义";
            this.tbtnCar.MouseEnterImage = global::DQS.AppViews.WarehouseOut.Properties.Resources.运输车辆登记MouseEnter;
            this.tbtnCar.Name = "tbtnCar";
            this.tbtnCar.Size = new System.Drawing.Size(107, 98);
            this.tbtnCar.TabIndex = 5;
            this.tbtnCar.Text = "运输车辆定义";
            // 
            // tbtnTransport
            // 
            this.tbtnTransport.AllowFocus = false;
            this.tbtnTransport.Appearance.BackColor = System.Drawing.Color.Transparent;
            this.tbtnTransport.Appearance.Font = new System.Drawing.Font("微软雅黑", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbtnTransport.Appearance.ForeColor = System.Drawing.Color.Black;
            this.tbtnTransport.Appearance.Options.UseBackColor = true;
            this.tbtnTransport.Appearance.Options.UseFont = true;
            this.tbtnTransport.Appearance.Options.UseForeColor = true;
            this.tbtnTransport.ButtonStyle = DevExpress.XtraEditors.Controls.BorderStyles.UltraFlat;
            this.tbtnTransport.Cursor = System.Windows.Forms.Cursors.Hand;
            this.tbtnTransport.Image = global::DQS.AppViews.WarehouseOut.Properties.Resources.运输记录;
            this.tbtnTransport.ImageLocation = DevExpress.XtraEditors.ImageLocation.TopCenter;
            this.tbtnTransport.Location = new System.Drawing.Point(550, 167);
            this.tbtnTransport.MenuCode = "Transport";
            this.tbtnTransport.MenuFullClass = "DQS.AppViews.WarehouseOut.WarehouseOutManager.FrmTransport, DQS.AppViews.Warehous" +
                "eOut";
            this.tbtnTransport.MenuName = "运输记录";
            this.tbtnTransport.MouseEnterImage = global::DQS.AppViews.WarehouseOut.Properties.Resources.运输记录MouseEnter;
            this.tbtnTransport.Name = "tbtnTransport";
            this.tbtnTransport.Size = new System.Drawing.Size(107, 98);
            this.tbtnTransport.TabIndex = 4;
            this.tbtnTransport.Text = "运输记录";
            // 
            // tbtnStockOut
            // 
            this.tbtnStockOut.AllowFocus = false;
            this.tbtnStockOut.Appearance.BackColor = System.Drawing.Color.Transparent;
            this.tbtnStockOut.Appearance.Font = new System.Drawing.Font("微软雅黑", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbtnStockOut.Appearance.ForeColor = System.Drawing.Color.Black;
            this.tbtnStockOut.Appearance.Options.UseBackColor = true;
            this.tbtnStockOut.Appearance.Options.UseFont = true;
            this.tbtnStockOut.Appearance.Options.UseForeColor = true;
            this.tbtnStockOut.ButtonStyle = DevExpress.XtraEditors.Controls.BorderStyles.UltraFlat;
            this.tbtnStockOut.Cursor = System.Windows.Forms.Cursors.Hand;
            this.tbtnStockOut.Image = global::DQS.AppViews.WarehouseOut.Properties.Resources.出库单管理;
            this.tbtnStockOut.ImageLocation = DevExpress.XtraEditors.ImageLocation.TopCenter;
            this.tbtnStockOut.Location = new System.Drawing.Point(34, 316);
            this.tbtnStockOut.MenuCode = "StockOut";
            this.tbtnStockOut.MenuFullClass = "DQS.AppViews.WarehouseOut.WarehouseOutManager.FrmStockOut, DQS.AppViews.Warehouse" +
                "Out";
            this.tbtnStockOut.MenuName = "出库单管理";
            this.tbtnStockOut.MouseEnterImage = global::DQS.AppViews.WarehouseOut.Properties.Resources.出库单管理MouseEnter;
            this.tbtnStockOut.Name = "tbtnStockOut";
            this.tbtnStockOut.Size = new System.Drawing.Size(107, 98);
            this.tbtnStockOut.TabIndex = 3;
            this.tbtnStockOut.Text = "出库单管理";
            // 
            // tbtnReview
            // 
            this.tbtnReview.AllowFocus = false;
            this.tbtnReview.Appearance.BackColor = System.Drawing.Color.Transparent;
            this.tbtnReview.Appearance.Font = new System.Drawing.Font("微软雅黑", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbtnReview.Appearance.ForeColor = System.Drawing.Color.Black;
            this.tbtnReview.Appearance.Options.UseBackColor = true;
            this.tbtnReview.Appearance.Options.UseFont = true;
            this.tbtnReview.Appearance.Options.UseForeColor = true;
            this.tbtnReview.ButtonStyle = DevExpress.XtraEditors.Controls.BorderStyles.UltraFlat;
            this.tbtnReview.Cursor = System.Windows.Forms.Cursors.Hand;
            this.tbtnReview.Image = global::DQS.AppViews.WarehouseOut.Properties.Resources.出库复核;
            this.tbtnReview.ImageLocation = DevExpress.XtraEditors.ImageLocation.TopCenter;
            this.tbtnReview.Location = new System.Drawing.Point(267, 316);
            this.tbtnReview.MenuCode = "Review";
            this.tbtnReview.MenuFullClass = "DQS.AppViews.WarehouseOut.WarehouseOutManager.FrmReview, DQS.AppViews.WarehouseOu" +
                "t";
            this.tbtnReview.MenuName = "出库复核";
            this.tbtnReview.MouseEnterImage = global::DQS.AppViews.WarehouseOut.Properties.Resources.出库复核单管理MouseEnter;
            this.tbtnReview.Name = "tbtnReview";
            this.tbtnReview.Size = new System.Drawing.Size(107, 98);
            this.tbtnReview.TabIndex = 2;
            this.tbtnReview.Text = "出库复核";
            // 
            // pictureEdit1
            // 
            this.pictureEdit1.EditValue = global::DQS.AppViews.WarehouseOut.Properties.Resources.line_l2;
            this.pictureEdit1.Location = new System.Drawing.Point(380, 45);
            this.pictureEdit1.Name = "pictureEdit1";
            this.pictureEdit1.Properties.Appearance.BackColor = System.Drawing.Color.Transparent;
            this.pictureEdit1.Properties.Appearance.Options.UseBackColor = true;
            this.pictureEdit1.Properties.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.NoBorder;
            this.pictureEdit1.Properties.SizeMode = DevExpress.XtraEditors.Controls.PictureSizeMode.StretchVertical;
            this.pictureEdit1.Size = new System.Drawing.Size(164, 333);
            this.pictureEdit1.TabIndex = 8;
            // 
            // FrmWarehouseOut
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 14F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(784, 562);
            this.Controls.Add(this.pictureEdit1);
            this.Controls.Add(this.picl1);
            this.Controls.Add(this.tbtnCar);
            this.Controls.Add(this.tbtnTransport);
            this.Controls.Add(this.tbtnStockOut);
            this.Controls.Add(this.tbtnReview);
            this.Name = "FrmWarehouseOut";
            this.Text = "FrmWarehouseOut";
            ((System.ComponentModel.ISupportInitialize)(this.picl1.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureEdit1.Properties)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DQS.Controls.ToolButton tbtnReview;
        private DQS.Controls.ToolButton tbtnStockOut;
        private DQS.Controls.ToolButton tbtnTransport;
        private DQS.Controls.ToolButton tbtnCar;
        private DevExpress.XtraEditors.PictureEdit picl1;
        private DevExpress.XtraEditors.PictureEdit pictureEdit1;

    }
}