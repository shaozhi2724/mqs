namespace DQS.AppViews.WarehouseIn
{
    partial class FrmWarehouseIn
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
            this.tbtnCondition = new DQS.Controls.ToolButton();
            this.tbtnStockIn = new DQS.Controls.ToolButton();
            this.tbtnSampling = new DQS.Controls.ToolButton();
            this.tbtnAccept = new DQS.Controls.ToolButton();
            this.tbtnReceive = new DQS.Controls.ToolButton();
            this.picd = new DevExpress.XtraEditors.PictureEdit();
            this.picl1 = new DevExpress.XtraEditors.PictureEdit();
            this.picl2 = new DevExpress.XtraEditors.PictureEdit();
            this.pictureEdit1 = new DevExpress.XtraEditors.PictureEdit();
            ((System.ComponentModel.ISupportInitialize)(this.picd.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picl1.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picl2.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureEdit1.Properties)).BeginInit();
            this.SuspendLayout();
            // 
            // tbtnCondition
            // 
            this.tbtnCondition.AllowFocus = false;
            this.tbtnCondition.Appearance.BackColor = System.Drawing.Color.Transparent;
            this.tbtnCondition.Appearance.Font = new System.Drawing.Font("微软雅黑", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbtnCondition.Appearance.ForeColor = System.Drawing.Color.Black;
            this.tbtnCondition.Appearance.Options.UseBackColor = true;
            this.tbtnCondition.Appearance.Options.UseFont = true;
            this.tbtnCondition.Appearance.Options.UseForeColor = true;
            this.tbtnCondition.ButtonStyle = DevExpress.XtraEditors.Controls.BorderStyles.UltraFlat;
            this.tbtnCondition.Cursor = System.Windows.Forms.Cursors.Hand;
            this.tbtnCondition.Image = global::DQS.AppViews.WarehouseIn.Properties.Resources.收货验收情况定义;
            this.tbtnCondition.ImageLocation = DevExpress.XtraEditors.ImageLocation.TopCenter;
            this.tbtnCondition.Location = new System.Drawing.Point(27, 154);
            this.tbtnCondition.MenuCode = "Condition";
            this.tbtnCondition.MenuFullClass = "DQS.AppViews.WarehouseIn.WarehouseInManager.FrmCondition, DQS.AppViews.WarehouseI" +
                "n";
            this.tbtnCondition.MenuName = "抽检项目设定";
            this.tbtnCondition.MouseEnterImage = global::DQS.AppViews.WarehouseIn.Properties.Resources.收货验收情况定义MouseEnter;
            this.tbtnCondition.Name = "tbtnCondition";
            this.tbtnCondition.Size = new System.Drawing.Size(110, 96);
            this.tbtnCondition.TabIndex = 6;
            this.tbtnCondition.Text = "抽检项目设定";
            // 
            // tbtnStockIn
            // 
            this.tbtnStockIn.AllowFocus = false;
            this.tbtnStockIn.Appearance.BackColor = System.Drawing.Color.Transparent;
            this.tbtnStockIn.Appearance.Font = new System.Drawing.Font("微软雅黑", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbtnStockIn.Appearance.ForeColor = System.Drawing.Color.Black;
            this.tbtnStockIn.Appearance.Options.UseBackColor = true;
            this.tbtnStockIn.Appearance.Options.UseFont = true;
            this.tbtnStockIn.Appearance.Options.UseForeColor = true;
            this.tbtnStockIn.ButtonStyle = DevExpress.XtraEditors.Controls.BorderStyles.UltraFlat;
            this.tbtnStockIn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.tbtnStockIn.Image = global::DQS.AppViews.WarehouseIn.Properties.Resources.入库单管理MouseEnter;
            this.tbtnStockIn.ImageLocation = DevExpress.XtraEditors.ImageLocation.TopCenter;
            this.tbtnStockIn.Location = new System.Drawing.Point(700, 298);
            this.tbtnStockIn.MenuCode = "StockIn";
            this.tbtnStockIn.MenuFullClass = "DQS.AppViews.WarehouseIn.WarehouseInManager.FrmStockIn, DQS.AppViews.WarehouseIn";
            this.tbtnStockIn.MenuName = "入库管理";
            this.tbtnStockIn.MouseEnterImage = global::DQS.AppViews.WarehouseIn.Properties.Resources.入库单管理MouseEnter;
            this.tbtnStockIn.Name = "tbtnStockIn";
            this.tbtnStockIn.Size = new System.Drawing.Size(87, 96);
            this.tbtnStockIn.TabIndex = 5;
            this.tbtnStockIn.Text = "入库管理";
            // 
            // tbtnSampling
            // 
            this.tbtnSampling.AllowFocus = false;
            this.tbtnSampling.Appearance.BackColor = System.Drawing.Color.Transparent;
            this.tbtnSampling.Appearance.Font = new System.Drawing.Font("微软雅黑", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbtnSampling.Appearance.ForeColor = System.Drawing.Color.Black;
            this.tbtnSampling.Appearance.Options.UseBackColor = true;
            this.tbtnSampling.Appearance.Options.UseFont = true;
            this.tbtnSampling.Appearance.Options.UseForeColor = true;
            this.tbtnSampling.ButtonStyle = DevExpress.XtraEditors.Controls.BorderStyles.UltraFlat;
            this.tbtnSampling.Cursor = System.Windows.Forms.Cursors.Hand;
            this.tbtnSampling.Image = global::DQS.AppViews.WarehouseIn.Properties.Resources.抽检单管理;
            this.tbtnSampling.ImageLocation = DevExpress.XtraEditors.ImageLocation.TopCenter;
            this.tbtnSampling.Location = new System.Drawing.Point(484, 298);
            this.tbtnSampling.MenuCode = "Sampling";
            this.tbtnSampling.MenuFullClass = "DQS.AppViews.WarehouseIn.WarehouseInManager.FrmSampling, DQS.AppViews.WarehouseIn" +
                "";
            this.tbtnSampling.MenuName = "抽检查询";
            this.tbtnSampling.MouseEnterImage = global::DQS.AppViews.WarehouseIn.Properties.Resources.抽检单管理MouseEnter;
            this.tbtnSampling.Name = "tbtnSampling";
            this.tbtnSampling.Size = new System.Drawing.Size(87, 96);
            this.tbtnSampling.TabIndex = 4;
            this.tbtnSampling.Text = "抽检查询";
            // 
            // tbtnAccept
            // 
            this.tbtnAccept.AllowFocus = false;
            this.tbtnAccept.Appearance.BackColor = System.Drawing.Color.Transparent;
            this.tbtnAccept.Appearance.Font = new System.Drawing.Font("微软雅黑", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbtnAccept.Appearance.ForeColor = System.Drawing.Color.Black;
            this.tbtnAccept.Appearance.Options.UseBackColor = true;
            this.tbtnAccept.Appearance.Options.UseFont = true;
            this.tbtnAccept.Appearance.Options.UseForeColor = true;
            this.tbtnAccept.ButtonStyle = DevExpress.XtraEditors.Controls.BorderStyles.UltraFlat;
            this.tbtnAccept.Cursor = System.Windows.Forms.Cursors.Hand;
            this.tbtnAccept.Image = global::DQS.AppViews.WarehouseIn.Properties.Resources.验收单管理;
            this.tbtnAccept.ImageLocation = DevExpress.XtraEditors.ImageLocation.TopCenter;
            this.tbtnAccept.Location = new System.Drawing.Point(268, 298);
            this.tbtnAccept.MenuCode = "Accept";
            this.tbtnAccept.MenuFullClass = "DQS.AppViews.WarehouseIn.WarehouseInManager.FrmAccept, DQS.AppViews.WarehouseIn";
            this.tbtnAccept.MenuName = "验收";
            this.tbtnAccept.MouseEnterImage = global::DQS.AppViews.WarehouseIn.Properties.Resources.验收单管理MouseEnter;
            this.tbtnAccept.Name = "tbtnAccept";
            this.tbtnAccept.Size = new System.Drawing.Size(87, 96);
            this.tbtnAccept.TabIndex = 3;
            this.tbtnAccept.Text = "验收";
            // 
            // tbtnReceive
            // 
            this.tbtnReceive.AllowFocus = false;
            this.tbtnReceive.Appearance.BackColor = System.Drawing.Color.Transparent;
            this.tbtnReceive.Appearance.Font = new System.Drawing.Font("微软雅黑", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbtnReceive.Appearance.ForeColor = System.Drawing.Color.Black;
            this.tbtnReceive.Appearance.Options.UseBackColor = true;
            this.tbtnReceive.Appearance.Options.UseFont = true;
            this.tbtnReceive.Appearance.Options.UseForeColor = true;
            this.tbtnReceive.ButtonStyle = DevExpress.XtraEditors.Controls.BorderStyles.UltraFlat;
            this.tbtnReceive.Cursor = System.Windows.Forms.Cursors.Hand;
            this.tbtnReceive.Image = global::DQS.AppViews.WarehouseIn.Properties.Resources.收货单管理;
            this.tbtnReceive.ImageLocation = DevExpress.XtraEditors.ImageLocation.TopCenter;
            this.tbtnReceive.Location = new System.Drawing.Point(268, 12);
            this.tbtnReceive.MenuCode = "Receive";
            this.tbtnReceive.MenuFullClass = "DQS.AppViews.WarehouseIn.WarehouseInManager.FrmReceive, DQS.AppViews.WarehouseIn";
            this.tbtnReceive.MenuName = "收货管理";
            this.tbtnReceive.MouseEnterImage = global::DQS.AppViews.WarehouseIn.Properties.Resources.收货单管理MouseEnter;
            this.tbtnReceive.Name = "tbtnReceive";
            this.tbtnReceive.Size = new System.Drawing.Size(87, 96);
            this.tbtnReceive.TabIndex = 2;
            this.tbtnReceive.Text = "收货管理";
            // 
            // picd
            // 
            this.picd.EditValue = global::DQS.AppViews.WarehouseIn.Properties.Resources.line_d;
            this.picd.Location = new System.Drawing.Point(256, 130);
            this.picd.Name = "picd";
            this.picd.Properties.Appearance.BackColor = System.Drawing.Color.Transparent;
            this.picd.Properties.Appearance.Options.UseBackColor = true;
            this.picd.Properties.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.NoBorder;
            this.picd.Size = new System.Drawing.Size(100, 142);
            this.picd.TabIndex = 7;
            // 
            // picl1
            // 
            this.picl1.EditValue = global::DQS.AppViews.WarehouseIn.Properties.Resources.line_l;
            this.picl1.Location = new System.Drawing.Point(361, 316);
            this.picl1.Name = "picl1";
            this.picl1.Properties.Appearance.BackColor = System.Drawing.Color.Transparent;
            this.picl1.Properties.Appearance.Options.UseBackColor = true;
            this.picl1.Properties.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.NoBorder;
            this.picl1.Size = new System.Drawing.Size(117, 69);
            this.picl1.TabIndex = 7;
            // 
            // picl2
            // 
            this.picl2.EditValue = global::DQS.AppViews.WarehouseIn.Properties.Resources.line_l;
            this.picl2.Location = new System.Drawing.Point(577, 316);
            this.picl2.Name = "picl2";
            this.picl2.Properties.Appearance.BackColor = System.Drawing.Color.Transparent;
            this.picl2.Properties.Appearance.Options.UseBackColor = true;
            this.picl2.Properties.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.NoBorder;
            this.picl2.Size = new System.Drawing.Size(117, 69);
            this.picl2.TabIndex = 7;
            // 
            // pictureEdit1
            // 
            this.pictureEdit1.EditValue = global::DQS.AppViews.WarehouseIn.Properties.Resources.line_s;
            this.pictureEdit1.Location = new System.Drawing.Point(141, 28);
            this.pictureEdit1.Name = "pictureEdit1";
            this.pictureEdit1.Properties.Appearance.BackColor = System.Drawing.Color.Transparent;
            this.pictureEdit1.Properties.Appearance.Options.UseBackColor = true;
            this.pictureEdit1.Properties.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.NoBorder;
            this.pictureEdit1.Size = new System.Drawing.Size(121, 357);
            this.pictureEdit1.TabIndex = 7;
            // 
            // FrmWarehouseIn
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 14F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(784, 562);
            this.Controls.Add(this.picl2);
            this.Controls.Add(this.picl1);
            this.Controls.Add(this.pictureEdit1);
            this.Controls.Add(this.picd);
            this.Controls.Add(this.tbtnCondition);
            this.Controls.Add(this.tbtnStockIn);
            this.Controls.Add(this.tbtnSampling);
            this.Controls.Add(this.tbtnAccept);
            this.Controls.Add(this.tbtnReceive);
            this.Name = "FrmWarehouseIn";
            this.Text = "FrmWarehouseIn";
            ((System.ComponentModel.ISupportInitialize)(this.picd.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picl1.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picl2.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureEdit1.Properties)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DQS.Controls.ToolButton tbtnReceive;
        private DQS.Controls.ToolButton tbtnAccept;
        private DQS.Controls.ToolButton tbtnSampling;
        private DQS.Controls.ToolButton tbtnCondition;
        private DQS.Controls.ToolButton tbtnStockIn;
        private DevExpress.XtraEditors.PictureEdit picd;
        private DevExpress.XtraEditors.PictureEdit picl1;
        private DevExpress.XtraEditors.PictureEdit picl2;
        private DevExpress.XtraEditors.PictureEdit pictureEdit1;

    }
}