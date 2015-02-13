namespace DQS.AppViews.StatReport.StatManager
{
    partial class FrmPastProductStoreDeatils
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
            this.txtDealer = new DQS.Controls.TextBoxQueryEx();
            this.txtProductName = new DQS.Controls.TextBoxQueryEx();
            this.layControlGroup = new DevExpress.XtraLayout.LayoutControlGroup();
            this.layProductName = new DevExpress.XtraLayout.LayoutControlItem();
            this.layBillCode = new DevExpress.XtraLayout.LayoutControlItem();
            ((System.ComponentModel.ISupportInitialize)(this.gpcQuery)).BeginInit();
            this.gpcQuery.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pageNavigator)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.toolBarPanel)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layControl)).BeginInit();
            this.layControl.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.txtDealer.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtProductName.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layControlGroup)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layProductName)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layBillCode)).BeginInit();
            this.SuspendLayout();
            // 
            // gpcQuery
            // 
            this.gpcQuery.Controls.Add(this.layControl);
            this.gpcQuery.Location = new System.Drawing.Point(0, 38);
            this.gpcQuery.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.gpcQuery.Size = new System.Drawing.Size(930, 98);
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
            // 
            // layControl
            // 
            this.layControl.Controls.Add(this.txtDealer);
            this.layControl.Controls.Add(this.txtProductName);
            this.layControl.Dock = System.Windows.Forms.DockStyle.Fill;
            this.layControl.Location = new System.Drawing.Point(2, 27);
            this.layControl.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.layControl.Name = "layControl";
            this.layControl.Root = this.layControlGroup;
            this.layControl.Size = new System.Drawing.Size(926, 69);
            this.layControl.TabIndex = 10;
            this.layControl.Text = "layControl";
            // 
            // txtDealer
            // 
            this.txtDealer.FormatQueryString = "[采购单号] = \'{0}\'";
            this.txtDealer.Location = new System.Drawing.Point(301, 12);
            this.txtDealer.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtDealer.Name = "txtDealer";
            this.txtDealer.Size = new System.Drawing.Size(613, 25);
            this.txtDealer.StyleController = this.layControl;
            this.txtDealer.TabIndex = 7;
            // 
            // txtProductName
            // 
            this.txtProductName.FormatQueryString = "[药品名称] LIKE \'%{0}%\' OR [药品名称Spell] LIKE \'%{0}%\' ";
            this.txtProductName.Location = new System.Drawing.Point(75, 12);
            this.txtProductName.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtProductName.Name = "txtProductName";
            this.txtProductName.Size = new System.Drawing.Size(159, 25);
            this.txtProductName.StyleController = this.layControl;
            this.txtProductName.TabIndex = 6;
            // 
            // layControlGroup
            // 
            this.layControlGroup.AppearanceItemCaption.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.layControlGroup.AppearanceItemCaption.Options.UseFont = true;
            this.layControlGroup.CustomizationFormText = "查询";
            this.layControlGroup.EnableIndentsWithoutBorders = DevExpress.Utils.DefaultBoolean.True;
            this.layControlGroup.GroupBordersVisible = false;
            this.layControlGroup.Items.AddRange(new DevExpress.XtraLayout.BaseLayoutItem[] {
            this.layProductName,
            this.layBillCode});
            this.layControlGroup.Location = new System.Drawing.Point(0, 0);
            this.layControlGroup.Name = "layControlGroup";
            this.layControlGroup.Size = new System.Drawing.Size(926, 69);
            this.layControlGroup.Spacing = new DevExpress.XtraLayout.Utils.Padding(0, 0, 0, 0);
            this.layControlGroup.Text = "查询";
            this.layControlGroup.TextVisible = false;
            // 
            // layProductName
            // 
            this.layProductName.Control = this.txtProductName;
            this.layProductName.CustomizationFormText = "药品名称";
            this.layProductName.Location = new System.Drawing.Point(0, 0);
            this.layProductName.Name = "layProductName";
            this.layProductName.Size = new System.Drawing.Size(226, 49);
            this.layProductName.Text = "药品名称";
            this.layProductName.TextSize = new System.Drawing.Size(60, 20);
            // 
            // layBillCode
            // 
            this.layBillCode.Control = this.txtDealer;
            this.layBillCode.CustomizationFormText = "往来单位";
            this.layBillCode.Location = new System.Drawing.Point(226, 0);
            this.layBillCode.Name = "layBillCode";
            this.layBillCode.Size = new System.Drawing.Size(680, 49);
            this.layBillCode.Text = "往来单位";
            this.layBillCode.TextSize = new System.Drawing.Size(60, 20);
            // 
            // FrmPastProductStoreDeatils
            // 
            this.Appearance.Font = new System.Drawing.Font("微软雅黑", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Appearance.Options.UseFont = true;
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 19F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(930, 654);
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Name = "FrmPastProductStoreDeatils";
            this.Text = "FrmAcceptDeatils";
            this.Load += new System.EventHandler(this.FrmPastProductStoreDeatils_Load);
            ((System.ComponentModel.ISupportInitialize)(this.gpcQuery)).EndInit();
            this.gpcQuery.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pageNavigator)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.toolBarPanel)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layControl)).EndInit();
            this.layControl.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.txtDealer.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtProductName.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layControlGroup)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layProductName)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layBillCode)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraLayout.LayoutControl layControl;
        private DQS.Controls.TextBoxQueryEx txtDealer;
        private DQS.Controls.TextBoxQueryEx txtProductName;
        private DevExpress.XtraLayout.LayoutControlGroup layControlGroup;
        private DevExpress.XtraLayout.LayoutControlItem layProductName;
        private DevExpress.XtraLayout.LayoutControlItem layBillCode;
    }
}