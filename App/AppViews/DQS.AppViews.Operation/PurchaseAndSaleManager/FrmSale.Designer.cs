namespace DQS.AppViews.Operation.PurchaseAndSaleManager
{
    partial class FrmSale
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
            this.cbxBillStatus = new DQS.Controls.ComboBoxCategoryEx();
            this.dteEnd = new DQS.Controls.DateQueryEx();
            this.txtDealer = new DQS.Controls.TextBoxQueryEx();
            this.dteStart = new DQS.Controls.DateQueryEx();
            this.txtBillCode = new DQS.Controls.TextBoxQueryEx();
            this.layControlGroup = new DevExpress.XtraLayout.LayoutControlGroup();
            this.layBillCode = new DevExpress.XtraLayout.LayoutControlItem();
            this.layStart = new DevExpress.XtraLayout.LayoutControlItem();
            this.layDealer = new DevExpress.XtraLayout.LayoutControlItem();
            this.layEnd = new DevExpress.XtraLayout.LayoutControlItem();
            this.layBillStatus = new DevExpress.XtraLayout.LayoutControlItem();
            ((System.ComponentModel.ISupportInitialize)(this.gpcQuery)).BeginInit();
            this.gpcQuery.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pageNavigator)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.toolBarPanel)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layControl)).BeginInit();
            this.layControl.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.cbxBillStatus.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dteEnd.Properties.VistaTimeProperties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dteEnd.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtDealer.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dteStart.Properties.VistaTimeProperties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dteStart.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtBillCode.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layControlGroup)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layBillCode)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layStart)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layDealer)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layEnd)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layBillStatus)).BeginInit();
            this.SuspendLayout();
            // 
            // gpcQuery
            // 
            this.gpcQuery.Controls.Add(this.layControl);
            this.gpcQuery.Location = new System.Drawing.Point(0, 32);
            this.gpcQuery.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.gpcQuery.Size = new System.Drawing.Size(770, 81);
            // 
            // pageNavigator
            // 
            this.pageNavigator.Appearance.Font = new System.Drawing.Font("微软雅黑", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.pageNavigator.Appearance.Options.UseFont = true;
            this.pageNavigator.Location = new System.Drawing.Point(0, 113);
            this.pageNavigator.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.pageNavigator.MinimumSize = new System.Drawing.Size(686, 45);
            this.pageNavigator.Size = new System.Drawing.Size(770, 45);
            // 
            // toolBarPanel
            // 
            this.toolBarPanel.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.toolBarPanel.Size = new System.Drawing.Size(770, 32);
            // 
            // layControl
            // 
            this.layControl.Controls.Add(this.cbxBillStatus);
            this.layControl.Controls.Add(this.dteEnd);
            this.layControl.Controls.Add(this.txtDealer);
            this.layControl.Controls.Add(this.dteStart);
            this.layControl.Controls.Add(this.txtBillCode);
            this.layControl.Dock = System.Windows.Forms.DockStyle.Fill;
            this.layControl.Location = new System.Drawing.Point(2, 23);
            this.layControl.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.layControl.Name = "layControl";
            this.layControl.Root = this.layControlGroup;
            this.layControl.Size = new System.Drawing.Size(766, 56);
            this.layControl.TabIndex = 3;
            this.layControl.Text = "layControl";
            // 
            // cbxBillStatus
            // 
            this.cbxBillStatus.AddFirstDefaultItem = true;
            this.cbxBillStatus.CategoryCode = "SaleStatus";
            this.cbxBillStatus.FirstDefaultItemText = "全部";
            this.cbxBillStatus.FormatQueryString = "[状态] = \'{0}\'";
            this.cbxBillStatus.Location = new System.Drawing.Point(661, 12);
            this.cbxBillStatus.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.cbxBillStatus.Name = "cbxBillStatus";
            this.cbxBillStatus.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.cbxBillStatus.Properties.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.DisableTextEditor;
            this.cbxBillStatus.SelectedValue = null;
            this.cbxBillStatus.Size = new System.Drawing.Size(93, 21);
            this.cbxBillStatus.StyleController = this.layControl;
            this.cbxBillStatus.TabIndex = 9;
            // 
            // dteEnd
            // 
            this.dteEnd.EditValue = null;
            this.dteEnd.FormatQueryString = "[下单日期] <= \'{0} 23:59:59\'";
            this.dteEnd.Location = new System.Drawing.Point(513, 12);
            this.dteEnd.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.dteEnd.Name = "dteEnd";
            this.dteEnd.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.dteEnd.Properties.VistaTimeProperties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton()});
            this.dteEnd.Size = new System.Drawing.Size(93, 21);
            this.dteEnd.StyleController = this.layControl;
            this.dteEnd.TabIndex = 7;
            // 
            // txtDealer
            // 
            this.txtDealer.FormatQueryString = "[往来单位名称] LIKE \'%{0}%\' OR [往来单位Spell] LIKE \'%{0}%\' ";
            this.txtDealer.Location = new System.Drawing.Point(217, 12);
            this.txtDealer.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.txtDealer.Name = "txtDealer";
            this.txtDealer.Size = new System.Drawing.Size(93, 21);
            this.txtDealer.StyleController = this.layControl;
            this.txtDealer.TabIndex = 6;
            // 
            // dteStart
            // 
            this.dteStart.EditValue = null;
            this.dteStart.FormatQueryString = "[下单日期] >= \'{0} 00:00:00\'";
            this.dteStart.Location = new System.Drawing.Point(365, 12);
            this.dteStart.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.dteStart.Name = "dteStart";
            this.dteStart.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.dteStart.Properties.VistaTimeProperties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton()});
            this.dteStart.Size = new System.Drawing.Size(93, 21);
            this.dteStart.StyleController = this.layControl;
            this.dteStart.TabIndex = 5;
            // 
            // txtBillCode
            // 
            this.txtBillCode.FormatQueryString = "[销售单号] LIKE \'%{0}%\'";
            this.txtBillCode.Location = new System.Drawing.Point(63, 12);
            this.txtBillCode.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.txtBillCode.Name = "txtBillCode";
            this.txtBillCode.Size = new System.Drawing.Size(99, 21);
            this.txtBillCode.StyleController = this.layControl;
            this.txtBillCode.TabIndex = 4;
            // 
            // layControlGroup
            // 
            this.layControlGroup.AppearanceItemCaption.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.layControlGroup.AppearanceItemCaption.Options.UseFont = true;
            this.layControlGroup.CustomizationFormText = "查询";
            this.layControlGroup.EnableIndentsWithoutBorders = DevExpress.Utils.DefaultBoolean.True;
            this.layControlGroup.GroupBordersVisible = false;
            this.layControlGroup.Items.AddRange(new DevExpress.XtraLayout.BaseLayoutItem[] {
            this.layBillCode,
            this.layStart,
            this.layDealer,
            this.layEnd,
            this.layBillStatus});
            this.layControlGroup.Location = new System.Drawing.Point(0, 0);
            this.layControlGroup.Name = "layControlGroup";
            this.layControlGroup.Size = new System.Drawing.Size(766, 56);
            this.layControlGroup.Spacing = new DevExpress.XtraLayout.Utils.Padding(0, 0, 0, 0);
            this.layControlGroup.Text = "查询";
            this.layControlGroup.TextVisible = false;
            // 
            // layBillCode
            // 
            this.layBillCode.Control = this.txtBillCode;
            this.layBillCode.CustomizationFormText = "销售单号";
            this.layBillCode.Location = new System.Drawing.Point(0, 0);
            this.layBillCode.Name = "layBillCode";
            this.layBillCode.Size = new System.Drawing.Size(154, 36);
            this.layBillCode.Text = "销售单号";
            this.layBillCode.TextSize = new System.Drawing.Size(48, 17);
            // 
            // layStart
            // 
            this.layStart.Control = this.dteStart;
            this.layStart.CustomizationFormText = "下单日期";
            this.layStart.Location = new System.Drawing.Point(302, 0);
            this.layStart.Name = "layStart";
            this.layStart.Size = new System.Drawing.Size(148, 36);
            this.layStart.Text = "下单日期";
            this.layStart.TextSize = new System.Drawing.Size(48, 17);
            // 
            // layDealer
            // 
            this.layDealer.Control = this.txtDealer;
            this.layDealer.CustomizationFormText = "往来单位";
            this.layDealer.Location = new System.Drawing.Point(154, 0);
            this.layDealer.Name = "layDealer";
            this.layDealer.Size = new System.Drawing.Size(148, 36);
            this.layDealer.Text = "往来单位";
            this.layDealer.TextSize = new System.Drawing.Size(48, 17);
            // 
            // layEnd
            // 
            this.layEnd.Control = this.dteEnd;
            this.layEnd.CustomizationFormText = "至";
            this.layEnd.Location = new System.Drawing.Point(450, 0);
            this.layEnd.Name = "layEnd";
            this.layEnd.Size = new System.Drawing.Size(148, 36);
            this.layEnd.Text = "至";
            this.layEnd.TextSize = new System.Drawing.Size(48, 17);
            // 
            // layBillStatus
            // 
            this.layBillStatus.Control = this.cbxBillStatus;
            this.layBillStatus.CustomizationFormText = "单据状态";
            this.layBillStatus.Location = new System.Drawing.Point(598, 0);
            this.layBillStatus.Name = "layBillStatus";
            this.layBillStatus.Size = new System.Drawing.Size(148, 36);
            this.layBillStatus.Text = "单据状态";
            this.layBillStatus.TextSize = new System.Drawing.Size(48, 17);
            // 
            // FrmSale
            // 
            this.Appearance.Font = new System.Drawing.Font("微软雅黑", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Appearance.Options.UseFont = true;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(770, 551);
            this.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.Name = "FrmSale";
            this.Text = "FrmSale";
            this.Load += new System.EventHandler(this.FrmSale_Load);
            ((System.ComponentModel.ISupportInitialize)(this.gpcQuery)).EndInit();
            this.gpcQuery.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pageNavigator)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.toolBarPanel)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layControl)).EndInit();
            this.layControl.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.cbxBillStatus.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dteEnd.Properties.VistaTimeProperties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dteEnd.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtDealer.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dteStart.Properties.VistaTimeProperties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dteStart.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtBillCode.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layControlGroup)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layBillCode)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layStart)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layDealer)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layEnd)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layBillStatus)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraLayout.LayoutControl layControl;
        private DQS.Controls.DateQueryEx dteEnd;
        private DQS.Controls.TextBoxQueryEx txtDealer;
        private DQS.Controls.DateQueryEx dteStart;
        private DQS.Controls.TextBoxQueryEx txtBillCode;
        private DevExpress.XtraLayout.LayoutControlGroup layControlGroup;
        private DevExpress.XtraLayout.LayoutControlItem layBillCode;
        private DevExpress.XtraLayout.LayoutControlItem layStart;
        private DevExpress.XtraLayout.LayoutControlItem layDealer;
        private DevExpress.XtraLayout.LayoutControlItem layEnd;
        private Controls.ComboBoxCategoryEx cbxBillStatus;
        private DevExpress.XtraLayout.LayoutControlItem layBillStatus;
    }
}