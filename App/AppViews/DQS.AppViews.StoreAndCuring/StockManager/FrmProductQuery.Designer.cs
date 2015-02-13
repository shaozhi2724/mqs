namespace DQS.AppViews.StoreAndCuring.StockManager
{
    partial class FrmProductQuery
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
            this.txtStructureLocation = new DQS.Controls.TextBoxQueryEx();
            this.txtProducerName = new DQS.Controls.TextBoxQueryEx();
            this.txtProductName = new DQS.Controls.TextBoxQueryEx();
            this.txtProductCode = new DQS.Controls.TextBoxQueryEx();
            this.layControlGroup = new DevExpress.XtraLayout.LayoutControlGroup();
            this.layProductCode = new DevExpress.XtraLayout.LayoutControlItem();
            this.layProductName = new DevExpress.XtraLayout.LayoutControlItem();
            this.layProducerName = new DevExpress.XtraLayout.LayoutControlItem();
            this.layStructureLocation = new DevExpress.XtraLayout.LayoutControlItem();
            ((System.ComponentModel.ISupportInitialize)(this.gpcQuery)).BeginInit();
            this.gpcQuery.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pageNavigator)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.toolBarPanel)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layControl)).BeginInit();
            this.layControl.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.txtStructureLocation.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtProducerName.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtProductName.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtProductCode.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layControlGroup)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layProductCode)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layProductName)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layProducerName)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layStructureLocation)).BeginInit();
            this.SuspendLayout();
            // 
            // gpcQuery
            // 
            this.gpcQuery.Controls.Add(this.layControl);
            this.gpcQuery.Location = new System.Drawing.Point(0, 38);
            this.gpcQuery.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.gpcQuery.Size = new System.Drawing.Size(930, 98);
            this.gpcQuery.TabIndex = 0;
            // 
            // pageNavigator
            // 
            this.pageNavigator.Appearance.Font = new System.Drawing.Font("微软雅黑", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.pageNavigator.Appearance.Options.UseFont = true;
            this.pageNavigator.Location = new System.Drawing.Point(0, 136);
            this.pageNavigator.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.pageNavigator.MinimumSize = new System.Drawing.Size(914, 54);
            this.pageNavigator.Size = new System.Drawing.Size(930, 54);
            // 
            // toolBarPanel
            // 
            this.toolBarPanel.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.toolBarPanel.Size = new System.Drawing.Size(930, 38);
            this.toolBarPanel.TabIndex = 1;
            // 
            // layControl
            // 
            this.layControl.Controls.Add(this.txtStructureLocation);
            this.layControl.Controls.Add(this.txtProducerName);
            this.layControl.Controls.Add(this.txtProductName);
            this.layControl.Controls.Add(this.txtProductCode);
            this.layControl.Dock = System.Windows.Forms.DockStyle.Fill;
            this.layControl.Location = new System.Drawing.Point(2, 27);
            this.layControl.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.layControl.Name = "layControl";
            this.layControl.Root = this.layControlGroup;
            this.layControl.Size = new System.Drawing.Size(926, 69);
            this.layControl.TabIndex = 0;
            this.layControl.Text = "layControl";
            // 
            // txtStructureLocation
            // 
            this.txtStructureLocation.FormatQueryString = "[货位位置]  LIKE \'%{0}%\'";
            this.txtStructureLocation.Location = new System.Drawing.Point(754, 12);
            this.txtStructureLocation.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtStructureLocation.Name = "txtStructureLocation";
            this.txtStructureLocation.Size = new System.Drawing.Size(160, 25);
            this.txtStructureLocation.StyleController = this.layControl;
            this.txtStructureLocation.TabIndex = 3;
            // 
            // txtProducerName
            // 
            this.txtProducerName.FormatQueryString = "[生产厂商] LIKE \'%{0}%\' OR [生产厂商Spell] LIKE \'%{0}%\'";
            this.txtProducerName.Location = new System.Drawing.Point(528, 12);
            this.txtProducerName.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtProducerName.Name = "txtProducerName";
            this.txtProducerName.Size = new System.Drawing.Size(159, 25);
            this.txtProducerName.StyleController = this.layControl;
            this.txtProducerName.TabIndex = 2;
            // 
            // txtProductName
            // 
            this.txtProductName.FormatQueryString = "[药品名称] LIKE \'%{0}%\' OR [药品名称Spell] LIKE \'%{0}%\'";
            this.txtProductName.Location = new System.Drawing.Point(301, 12);
            this.txtProductName.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtProductName.Name = "txtProductName";
            this.txtProductName.Size = new System.Drawing.Size(160, 25);
            this.txtProductName.StyleController = this.layControl;
            this.txtProductName.TabIndex = 1;
            // 
            // txtProductCode
            // 
            this.txtProductCode.FormatQueryString = "[药品编号] LIKE \'%{0}%\'";
            this.txtProductCode.Location = new System.Drawing.Point(75, 12);
            this.txtProductCode.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtProductCode.Name = "txtProductCode";
            this.txtProductCode.Size = new System.Drawing.Size(159, 25);
            this.txtProductCode.StyleController = this.layControl;
            this.txtProductCode.TabIndex = 0;
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
            this.layStructureLocation});
            this.layControlGroup.Location = new System.Drawing.Point(0, 0);
            this.layControlGroup.Name = "layControlGroup";
            this.layControlGroup.Size = new System.Drawing.Size(926, 69);
            this.layControlGroup.Spacing = new DevExpress.XtraLayout.Utils.Padding(0, 0, 0, 0);
            this.layControlGroup.Text = "查询";
            this.layControlGroup.TextVisible = false;
            // 
            // layProductCode
            // 
            this.layProductCode.Control = this.txtProductCode;
            this.layProductCode.CustomizationFormText = "药品编号";
            this.layProductCode.Location = new System.Drawing.Point(0, 0);
            this.layProductCode.Name = "layProductCode";
            this.layProductCode.Size = new System.Drawing.Size(226, 49);
            this.layProductCode.Text = "药品编号";
            this.layProductCode.TextSize = new System.Drawing.Size(60, 20);
            // 
            // layProductName
            // 
            this.layProductName.Control = this.txtProductName;
            this.layProductName.CustomizationFormText = "药品名称";
            this.layProductName.Location = new System.Drawing.Point(226, 0);
            this.layProductName.Name = "layProductName";
            this.layProductName.Size = new System.Drawing.Size(227, 49);
            this.layProductName.Text = "药品名称";
            this.layProductName.TextSize = new System.Drawing.Size(60, 20);
            // 
            // layProducerName
            // 
            this.layProducerName.Control = this.txtProducerName;
            this.layProducerName.CustomizationFormText = "生产厂商";
            this.layProducerName.Location = new System.Drawing.Point(453, 0);
            this.layProducerName.Name = "layProducerName";
            this.layProducerName.Size = new System.Drawing.Size(226, 49);
            this.layProducerName.Text = "生产厂商";
            this.layProducerName.TextSize = new System.Drawing.Size(60, 20);
            // 
            // layStructureLocation
            // 
            this.layStructureLocation.Control = this.txtStructureLocation;
            this.layStructureLocation.CustomizationFormText = "货位位置";
            this.layStructureLocation.Location = new System.Drawing.Point(679, 0);
            this.layStructureLocation.Name = "layStructureLocation";
            this.layStructureLocation.Size = new System.Drawing.Size(227, 49);
            this.layStructureLocation.Text = "货位位置";
            this.layStructureLocation.TextSize = new System.Drawing.Size(60, 20);
            // 
            // FrmProductQuery
            // 
            this.Appearance.Font = new System.Drawing.Font("微软雅黑", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Appearance.Options.UseFont = true;
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 19F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(930, 654);
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Name = "FrmProductQuery";
            this.Text = "FrmProductQuery";
            this.Load += new System.EventHandler(this.FrmProductQuery_Load);
            ((System.ComponentModel.ISupportInitialize)(this.gpcQuery)).EndInit();
            this.gpcQuery.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pageNavigator)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.toolBarPanel)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layControl)).EndInit();
            this.layControl.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.txtStructureLocation.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtProducerName.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtProductName.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtProductCode.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layControlGroup)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layProductCode)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layProductName)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layProducerName)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layStructureLocation)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraLayout.LayoutControl layControl;
        private DQS.Controls.TextBoxQueryEx txtStructureLocation;
        private DQS.Controls.TextBoxQueryEx txtProducerName;
        private DQS.Controls.TextBoxQueryEx txtProductName;
        private DQS.Controls.TextBoxQueryEx txtProductCode;
        private DevExpress.XtraLayout.LayoutControlGroup layControlGroup;
        private DevExpress.XtraLayout.LayoutControlItem layProductCode;
        private DevExpress.XtraLayout.LayoutControlItem layProductName;
        private DevExpress.XtraLayout.LayoutControlItem layProducerName;
        private DevExpress.XtraLayout.LayoutControlItem layStructureLocation;

    }
}