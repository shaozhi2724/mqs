namespace DQS.AppViews.StoreAndCuring.StockManager
{
    partial class FrmUnStockDetail
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
            this.layoutControl1 = new DevExpress.XtraLayout.LayoutControl();
            this.layoutControlGroup1 = new DevExpress.XtraLayout.LayoutControlGroup();
            this.txtProductCode = new DQS.Controls.TextBoxQueryEx();
            this.layProductCode = new DevExpress.XtraLayout.LayoutControlItem();
            this.txtProducerName = new DQS.Controls.TextBoxQueryEx();
            this.layProducerName = new DevExpress.XtraLayout.LayoutControlItem();
            this.txtBatchNo = new DQS.Controls.TextBoxQueryEx();
            this.layBatchNo = new DevExpress.XtraLayout.LayoutControlItem();
            this.txtProductName = new DQS.Controls.TextBoxQueryEx();
            this.layProductName = new DevExpress.XtraLayout.LayoutControlItem();
            ((System.ComponentModel.ISupportInitialize)(this.gpcQuery)).BeginInit();
            this.gpcQuery.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pageNavigator)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.toolBarPanel)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControl1)).BeginInit();
            this.layoutControl1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlGroup1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtProductCode.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layProductCode)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtProducerName.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layProducerName)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtBatchNo.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layBatchNo)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtProductName.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layProductName)).BeginInit();
            this.SuspendLayout();
            // 
            // gpcQuery
            // 
            this.gpcQuery.Controls.Add(this.layoutControl1);
            // 
            // pageNavigator
            // 
            this.pageNavigator.Appearance.Font = new System.Drawing.Font("微软雅黑", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.pageNavigator.Appearance.Options.UseFont = true;
            // 
            // layoutControl1
            // 
            this.layoutControl1.Controls.Add(this.txtProductName);
            this.layoutControl1.Controls.Add(this.txtBatchNo);
            this.layoutControl1.Controls.Add(this.txtProducerName);
            this.layoutControl1.Controls.Add(this.txtProductCode);
            this.layoutControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.layoutControl1.Location = new System.Drawing.Point(2, 23);
            this.layoutControl1.Name = "layoutControl1";
            this.layoutControl1.Root = this.layoutControlGroup1;
            this.layoutControl1.Size = new System.Drawing.Size(810, 55);
            this.layoutControl1.TabIndex = 0;
            this.layoutControl1.Text = "layoutControl1";
            // 
            // layoutControlGroup1
            // 
            this.layoutControlGroup1.CustomizationFormText = "layoutControlGroup1";
            this.layoutControlGroup1.EnableIndentsWithoutBorders = DevExpress.Utils.DefaultBoolean.True;
            this.layoutControlGroup1.GroupBordersVisible = false;
            this.layoutControlGroup1.Items.AddRange(new DevExpress.XtraLayout.BaseLayoutItem[] {
            this.layProductCode,
            this.layProducerName,
            this.layBatchNo,
            this.layProductName});
            this.layoutControlGroup1.Location = new System.Drawing.Point(0, 0);
            this.layoutControlGroup1.Name = "layoutControlGroup1";
            this.layoutControlGroup1.Size = new System.Drawing.Size(810, 55);
            this.layoutControlGroup1.Spacing = new DevExpress.XtraLayout.Utils.Padding(0, 0, 0, 0);
            this.layoutControlGroup1.Text = "layoutControlGroup1";
            this.layoutControlGroup1.TextVisible = false;
            // 
            // txtProductCode
            // 
            this.txtProductCode.FormatQueryString = "[产品编号] LIKE \'%{0}%\'";
            this.txtProductCode.Location = new System.Drawing.Point(64, 12);
            this.txtProductCode.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.txtProductCode.Name = "txtProductCode";
            this.txtProductCode.Size = new System.Drawing.Size(141, 21);
            this.txtProductCode.StyleController = this.layoutControl1;
            this.txtProductCode.TabIndex = 5;
            // 
            // layProductCode
            // 
            this.layProductCode.Control = this.txtProductCode;
            this.layProductCode.CustomizationFormText = "产品编号";
            this.layProductCode.Location = new System.Drawing.Point(0, 0);
            this.layProductCode.Name = "layProductCode";
            this.layProductCode.Size = new System.Drawing.Size(197, 35);
            this.layProductCode.Text = "产品编号";
            this.layProductCode.TextSize = new System.Drawing.Size(48, 14);
            // 
            // txtProducerName
            // 
            this.txtProducerName.FormatQueryString = "[生产厂商] LIKE \'%{0}%\' OR [生产厂商Spell] LIKE \'%{0}%\'";
            this.txtProducerName.Location = new System.Drawing.Point(459, 12);
            this.txtProducerName.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.txtProducerName.Name = "txtProducerName";
            this.txtProducerName.Size = new System.Drawing.Size(141, 21);
            this.txtProducerName.StyleController = this.layoutControl1;
            this.txtProducerName.TabIndex = 5;
            // 
            // layProducerName
            // 
            this.layProducerName.Control = this.txtProducerName;
            this.layProducerName.CustomizationFormText = "生产厂家";
            this.layProducerName.Location = new System.Drawing.Point(395, 0);
            this.layProducerName.Name = "layProducerName";
            this.layProducerName.Size = new System.Drawing.Size(197, 35);
            this.layProducerName.Text = "生产厂家";
            this.layProducerName.TextSize = new System.Drawing.Size(48, 14);
            // 
            // txtBatchNo
            // 
            this.txtBatchNo.FormatQueryString = "[批号] LIKE \'%{0}%\'";
            this.txtBatchNo.Location = new System.Drawing.Point(656, 12);
            this.txtBatchNo.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.txtBatchNo.Name = "txtBatchNo";
            this.txtBatchNo.Size = new System.Drawing.Size(142, 21);
            this.txtBatchNo.StyleController = this.layoutControl1;
            this.txtBatchNo.TabIndex = 5;
            // 
            // layBatchNo
            // 
            this.layBatchNo.Control = this.txtBatchNo;
            this.layBatchNo.CustomizationFormText = "批号";
            this.layBatchNo.Location = new System.Drawing.Point(592, 0);
            this.layBatchNo.Name = "layBatchNo";
            this.layBatchNo.Size = new System.Drawing.Size(198, 35);
            this.layBatchNo.Text = "批号";
            this.layBatchNo.TextSize = new System.Drawing.Size(48, 14);
            // 
            // txtProductName
            // 
            this.txtProductName.FormatQueryString = "[产品名称] LIKE \'%{0}%\' OR [产品名称Spell] LIKE \'%{0}%\'";
            this.txtProductName.Location = new System.Drawing.Point(261, 12);
            this.txtProductName.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.txtProductName.Name = "txtProductName";
            this.txtProductName.Size = new System.Drawing.Size(142, 21);
            this.txtProductName.StyleController = this.layoutControl1;
            this.txtProductName.TabIndex = 5;
            // 
            // layProductName
            // 
            this.layProductName.Control = this.txtProductName;
            this.layProductName.CustomizationFormText = "产品名称";
            this.layProductName.Location = new System.Drawing.Point(197, 0);
            this.layProductName.Name = "layProductName";
            this.layProductName.Size = new System.Drawing.Size(198, 35);
            this.layProductName.Text = "产品名称";
            this.layProductName.TextSize = new System.Drawing.Size(48, 14);
            // 
            // FrmUnStockDetail
            // 
            this.Appearance.Font = new System.Drawing.Font("微软雅黑", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Appearance.Options.UseFont = true;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(814, 482);
            this.Name = "FrmUnStockDetail";
            this.Text = "FrmUnStockDetail";
            this.Load += new System.EventHandler(this.FrmStockDetail_Load);
            ((System.ComponentModel.ISupportInitialize)(this.gpcQuery)).EndInit();
            this.gpcQuery.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pageNavigator)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.toolBarPanel)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControl1)).EndInit();
            this.layoutControl1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlGroup1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtProductCode.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layProductCode)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtProducerName.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layProducerName)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtBatchNo.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layBatchNo)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtProductName.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layProductName)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraLayout.LayoutControl layoutControl1;
        private DevExpress.XtraLayout.LayoutControlGroup layoutControlGroup1;
        private Controls.TextBoxQueryEx txtProductName;
        private Controls.TextBoxQueryEx txtBatchNo;
        private Controls.TextBoxQueryEx txtProducerName;
        private Controls.TextBoxQueryEx txtProductCode;
        private DevExpress.XtraLayout.LayoutControlItem layProductCode;
        private DevExpress.XtraLayout.LayoutControlItem layProducerName;
        private DevExpress.XtraLayout.LayoutControlItem layBatchNo;
        private DevExpress.XtraLayout.LayoutControlItem layProductName;

    }
}