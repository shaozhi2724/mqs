namespace DQS.AppViews.StoreAndCuring.StockManager
{
    partial class FrmBeginInventory
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
            this.layControl = new DevExpress.XtraLayout.LayoutControl();
            this.txtBatchNo = new DQS.Controls.TextBoxQueryEx();
            this.txtProducerName = new DQS.Controls.TextBoxQueryEx();
            this.txtProductName = new DQS.Controls.TextBoxQueryEx();
            this.txtProductCode = new DQS.Controls.TextBoxQueryEx();
            this.layControlGroup = new DevExpress.XtraLayout.LayoutControlGroup();
            this.layProductCode = new DevExpress.XtraLayout.LayoutControlItem();
            this.layProductName = new DevExpress.XtraLayout.LayoutControlItem();
            this.layProducerName = new DevExpress.XtraLayout.LayoutControlItem();
            this.layBatchNo = new DevExpress.XtraLayout.LayoutControlItem();
            ((System.ComponentModel.ISupportInitialize)(this.gpcQuery)).BeginInit();
            this.gpcQuery.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pageNavigator)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.toolBarPanel)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layControl)).BeginInit();
            this.layControl.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.txtBatchNo.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtProducerName.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtProductName.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtProductCode.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layControlGroup)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layProductCode)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layProductName)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layProducerName)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layBatchNo)).BeginInit();
            this.SuspendLayout();
            // 
            // gpcQuery
            // 
            this.gpcQuery.Controls.Add(this.layControl);
            // 
            // pageNavigator
            // 
            this.pageNavigator.Appearance.Font = new System.Drawing.Font("微软雅黑", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.pageNavigator.Appearance.Options.UseFont = true;
            // 
            // layControl
            // 
            this.layControl.Controls.Add(this.txtBatchNo);
            this.layControl.Controls.Add(this.txtProducerName);
            this.layControl.Controls.Add(this.txtProductName);
            this.layControl.Controls.Add(this.txtProductCode);
            this.layControl.Dock = System.Windows.Forms.DockStyle.Fill;
            this.layControl.Location = new System.Drawing.Point(2, 23);
            this.layControl.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.layControl.Name = "layControl";
            this.layControl.Root = this.layControlGroup;
            this.layControl.Size = new System.Drawing.Size(810, 55);
            this.layControl.TabIndex = 11;
            this.layControl.Text = "layControl";
            // 
            // txtBatchNo
            // 
            this.txtBatchNo.FormatQueryString = "[批号] = \'{0}\'";
            this.txtBatchNo.Location = new System.Drawing.Point(655, 12);
            this.txtBatchNo.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.txtBatchNo.Name = "txtBatchNo";
            this.txtBatchNo.Size = new System.Drawing.Size(143, 21);
            this.txtBatchNo.StyleController = this.layControl;
            this.txtBatchNo.TabIndex = 7;
            // 
            // txtProducerName
            // 
            this.txtProducerName.FormatQueryString = "[生产厂商] LIKE \'%{0}%\' OR [生产厂商Spell] LIKE \'%{0}%\'";
            this.txtProducerName.Location = new System.Drawing.Point(458, 12);
            this.txtProducerName.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.txtProducerName.Name = "txtProducerName";
            this.txtProducerName.Size = new System.Drawing.Size(142, 21);
            this.txtProducerName.StyleController = this.layControl;
            this.txtProducerName.TabIndex = 7;
            // 
            // txtProductName
            // 
            this.txtProductName.FormatQueryString = "[产品名称] LIKE \'%{0}%\' OR [产品名称Spell] LIKE \'%{0}%\'";
            this.txtProductName.Location = new System.Drawing.Point(260, 12);
            this.txtProductName.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.txtProductName.Name = "txtProductName";
            this.txtProductName.Size = new System.Drawing.Size(143, 21);
            this.txtProductName.StyleController = this.layControl;
            this.txtProductName.TabIndex = 6;
            // 
            // txtProductCode
            // 
            this.txtProductCode.FormatQueryString = "[产品编号] LIKE \'%{0}%\'";
            this.txtProductCode.Location = new System.Drawing.Point(63, 12);
            this.txtProductCode.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.txtProductCode.Name = "txtProductCode";
            this.txtProductCode.Size = new System.Drawing.Size(142, 21);
            this.txtProductCode.StyleController = this.layControl;
            this.txtProductCode.TabIndex = 4;
            // 
            // layControlGroup
            // 
            this.layControlGroup.AppearanceItemCaption.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.layControlGroup.AppearanceItemCaption.Options.UseFont = true;
            this.layControlGroup.CustomizationFormText = "查询";
            this.layControlGroup.EnableIndentsWithoutBorders = DevExpress.Utils.DefaultBoolean.True;
            this.layControlGroup.GroupBordersVisible = false;
            this.layControlGroup.Items.AddRange(new DevExpress.XtraLayout.BaseLayoutItem[] {
            this.layProductCode,
            this.layProductName,
            this.layProducerName,
            this.layBatchNo});
            this.layControlGroup.Location = new System.Drawing.Point(0, 0);
            this.layControlGroup.Name = "layControlGroup";
            this.layControlGroup.Size = new System.Drawing.Size(810, 55);
            this.layControlGroup.Spacing = new DevExpress.XtraLayout.Utils.Padding(0, 0, 0, 0);
            this.layControlGroup.Text = "查询";
            this.layControlGroup.TextVisible = false;
            // 
            // layProductCode
            // 
            this.layProductCode.Control = this.txtProductCode;
            this.layProductCode.CustomizationFormText = "产品编号";
            this.layProductCode.Location = new System.Drawing.Point(0, 0);
            this.layProductCode.Name = "layProductCode";
            this.layProductCode.Size = new System.Drawing.Size(197, 35);
            this.layProductCode.Text = "产品编号";
            this.layProductCode.TextSize = new System.Drawing.Size(48, 17);
            // 
            // layProductName
            // 
            this.layProductName.Control = this.txtProductName;
            this.layProductName.CustomizationFormText = "产品名称";
            this.layProductName.Location = new System.Drawing.Point(197, 0);
            this.layProductName.Name = "layProductName";
            this.layProductName.Size = new System.Drawing.Size(198, 35);
            this.layProductName.Text = "产品名称";
            this.layProductName.TextSize = new System.Drawing.Size(48, 17);
            // 
            // layProducerName
            // 
            this.layProducerName.Control = this.txtProducerName;
            this.layProducerName.CustomizationFormText = "生产厂商";
            this.layProducerName.Location = new System.Drawing.Point(395, 0);
            this.layProducerName.Name = "layProducerName";
            this.layProducerName.Size = new System.Drawing.Size(197, 35);
            this.layProducerName.Text = "生产厂商";
            this.layProducerName.TextSize = new System.Drawing.Size(48, 17);
            // 
            // layBatchNo
            // 
            this.layBatchNo.Control = this.txtBatchNo;
            this.layBatchNo.CustomizationFormText = "批号";
            this.layBatchNo.Location = new System.Drawing.Point(592, 0);
            this.layBatchNo.Name = "layBatchNo";
            this.layBatchNo.Size = new System.Drawing.Size(198, 35);
            this.layBatchNo.Text = "批号";
            this.layBatchNo.TextSize = new System.Drawing.Size(48, 17);
            // 
            // FrmBeginInventory
            // 
            this.Appearance.Font = new System.Drawing.Font("微软雅黑", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Appearance.Options.UseFont = true;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(814, 482);
            this.Name = "FrmBeginInventory";
            this.Text = "FrmBeginInventory";
            this.Load += new System.EventHandler(this.FrmBeginInventory_Load);
            ((System.ComponentModel.ISupportInitialize)(this.gpcQuery)).EndInit();
            this.gpcQuery.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pageNavigator)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.toolBarPanel)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layControl)).EndInit();
            this.layControl.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.txtBatchNo.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtProducerName.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtProductName.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtProductCode.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layControlGroup)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layProductCode)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layProductName)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layProducerName)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layBatchNo)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraLayout.LayoutControl layControl;
        private Controls.TextBoxQueryEx txtBatchNo;
        private Controls.TextBoxQueryEx txtProducerName;
        private Controls.TextBoxQueryEx txtProductName;
        private Controls.TextBoxQueryEx txtProductCode;
        private DevExpress.XtraLayout.LayoutControlGroup layControlGroup;
        private DevExpress.XtraLayout.LayoutControlItem layProductCode;
        private DevExpress.XtraLayout.LayoutControlItem layProductName;
        private DevExpress.XtraLayout.LayoutControlItem layProducerName;
        private DevExpress.XtraLayout.LayoutControlItem layBatchNo;

    }
}