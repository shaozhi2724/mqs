namespace DQS.AppViews.StoreAndCuring.StockManager
{
    partial class FrmInventory
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
            this.dteEnd = new DQS.Controls.DateQueryEx();
            this.txtInventoryPerson = new DQS.Controls.TextBoxQueryEx();
            this.dteStart = new DQS.Controls.DateQueryEx();
            this.txtInventoryCode = new DQS.Controls.TextBoxQueryEx();
            this.layControlGroup = new DevExpress.XtraLayout.LayoutControlGroup();
            this.layInventoryCode = new DevExpress.XtraLayout.LayoutControlItem();
            this.layStart = new DevExpress.XtraLayout.LayoutControlItem();
            this.layInventoryPerson = new DevExpress.XtraLayout.LayoutControlItem();
            this.layoutControlItem4 = new DevExpress.XtraLayout.LayoutControlItem();
            ((System.ComponentModel.ISupportInitialize)(this.gpcQuery)).BeginInit();
            this.gpcQuery.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pageNavigator)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.toolBarPanel)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layControl)).BeginInit();
            this.layControl.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dteEnd.Properties.VistaTimeProperties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dteEnd.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtInventoryPerson.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dteStart.Properties.VistaTimeProperties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dteStart.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtInventoryCode.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layControlGroup)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layInventoryCode)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layStart)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layInventoryPerson)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem4)).BeginInit();
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
            this.layControl.Controls.Add(this.dteEnd);
            this.layControl.Controls.Add(this.txtInventoryPerson);
            this.layControl.Controls.Add(this.dteStart);
            this.layControl.Controls.Add(this.txtInventoryCode);
            this.layControl.Dock = System.Windows.Forms.DockStyle.Fill;
            this.layControl.Location = new System.Drawing.Point(2, 27);
            this.layControl.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.layControl.Name = "layControl";
            this.layControl.Root = this.layControlGroup;
            this.layControl.Size = new System.Drawing.Size(926, 69);
            this.layControl.TabIndex = 6;
            this.layControl.Text = "layControl";
            // 
            // dteEnd
            // 
            this.dteEnd.EditValue = null;
            this.dteEnd.FormatQueryString = "[盘点时间] <= \'{0} 23:59:59\'";
            this.dteEnd.Location = new System.Drawing.Point(755, 12);
            this.dteEnd.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.dteEnd.Name = "dteEnd";
            this.dteEnd.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.dteEnd.Properties.VistaTimeProperties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton()});
            this.dteEnd.Size = new System.Drawing.Size(159, 25);
            this.dteEnd.StyleController = this.layControl;
            this.dteEnd.TabIndex = 7;
            // 
            // txtInventoryPerson
            // 
            this.txtInventoryPerson.FormatQueryString = "[盘点人员] LIKE \'%{0}%\'";
            this.txtInventoryPerson.Location = new System.Drawing.Point(301, 12);
            this.txtInventoryPerson.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtInventoryPerson.Name = "txtInventoryPerson";
            this.txtInventoryPerson.Size = new System.Drawing.Size(160, 25);
            this.txtInventoryPerson.StyleController = this.layControl;
            this.txtInventoryPerson.TabIndex = 6;
            // 
            // dteStart
            // 
            this.dteStart.EditValue = null;
            this.dteStart.FormatQueryString = "[盘点时间] >= \'{0} 00:00:00\'";
            this.dteStart.Location = new System.Drawing.Point(528, 12);
            this.dteStart.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.dteStart.Name = "dteStart";
            this.dteStart.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.dteStart.Properties.VistaTimeProperties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton()});
            this.dteStart.Size = new System.Drawing.Size(160, 25);
            this.dteStart.StyleController = this.layControl;
            this.dteStart.TabIndex = 5;
            // 
            // txtInventoryCode
            // 
            this.txtInventoryCode.FormatQueryString = "[盘点编号] = \'{0}\'";
            this.txtInventoryCode.Location = new System.Drawing.Point(75, 12);
            this.txtInventoryCode.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtInventoryCode.Name = "txtInventoryCode";
            this.txtInventoryCode.Size = new System.Drawing.Size(159, 25);
            this.txtInventoryCode.StyleController = this.layControl;
            this.txtInventoryCode.TabIndex = 4;
            // 
            // layControlGroup
            // 
            this.layControlGroup.AppearanceItemCaption.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.layControlGroup.AppearanceItemCaption.Options.UseFont = true;
            this.layControlGroup.CustomizationFormText = "查询";
            this.layControlGroup.EnableIndentsWithoutBorders = DevExpress.Utils.DefaultBoolean.True;
            this.layControlGroup.GroupBordersVisible = false;
            this.layControlGroup.Items.AddRange(new DevExpress.XtraLayout.BaseLayoutItem[] {
            this.layInventoryCode,
            this.layStart,
            this.layInventoryPerson,
            this.layoutControlItem4});
            this.layControlGroup.Location = new System.Drawing.Point(0, 0);
            this.layControlGroup.Name = "layControlGroup";
            this.layControlGroup.Size = new System.Drawing.Size(926, 69);
            this.layControlGroup.Spacing = new DevExpress.XtraLayout.Utils.Padding(0, 0, 0, 0);
            this.layControlGroup.Text = "查询";
            this.layControlGroup.TextVisible = false;
            // 
            // layInventoryCode
            // 
            this.layInventoryCode.Control = this.txtInventoryCode;
            this.layInventoryCode.CustomizationFormText = "盘点编号";
            this.layInventoryCode.Location = new System.Drawing.Point(0, 0);
            this.layInventoryCode.Name = "layInventoryCode";
            this.layInventoryCode.Size = new System.Drawing.Size(226, 49);
            this.layInventoryCode.Text = "盘点编号";
            this.layInventoryCode.TextSize = new System.Drawing.Size(60, 20);
            // 
            // layStart
            // 
            this.layStart.Control = this.dteStart;
            this.layStart.CustomizationFormText = "盘点日期";
            this.layStart.Location = new System.Drawing.Point(453, 0);
            this.layStart.Name = "layStart";
            this.layStart.Size = new System.Drawing.Size(227, 49);
            this.layStart.Text = "盘点日期";
            this.layStart.TextSize = new System.Drawing.Size(60, 20);
            // 
            // layInventoryPerson
            // 
            this.layInventoryPerson.Control = this.txtInventoryPerson;
            this.layInventoryPerson.CustomizationFormText = "盘点人员";
            this.layInventoryPerson.Location = new System.Drawing.Point(226, 0);
            this.layInventoryPerson.Name = "layInventoryPerson";
            this.layInventoryPerson.Size = new System.Drawing.Size(227, 49);
            this.layInventoryPerson.Text = "盘点人员";
            this.layInventoryPerson.TextSize = new System.Drawing.Size(60, 20);
            // 
            // layoutControlItem4
            // 
            this.layoutControlItem4.Control = this.dteEnd;
            this.layoutControlItem4.CustomizationFormText = "至";
            this.layoutControlItem4.Location = new System.Drawing.Point(680, 0);
            this.layoutControlItem4.Name = "layoutControlItem4";
            this.layoutControlItem4.Size = new System.Drawing.Size(226, 49);
            this.layoutControlItem4.Text = "至";
            this.layoutControlItem4.TextSize = new System.Drawing.Size(60, 20);
            // 
            // FrmInventory
            // 
            this.Appearance.Font = new System.Drawing.Font("微软雅黑", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Appearance.Options.UseFont = true;
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 19F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(930, 654);
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Name = "FrmInventory";
            this.Text = "FrmInventory";
            this.Load += new System.EventHandler(this.FrmInventory_Load);
            ((System.ComponentModel.ISupportInitialize)(this.gpcQuery)).EndInit();
            this.gpcQuery.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pageNavigator)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.toolBarPanel)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layControl)).EndInit();
            this.layControl.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dteEnd.Properties.VistaTimeProperties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dteEnd.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtInventoryPerson.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dteStart.Properties.VistaTimeProperties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dteStart.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtInventoryCode.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layControlGroup)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layInventoryCode)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layStart)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layInventoryPerson)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem4)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraLayout.LayoutControl layControl;
        private DQS.Controls.DateQueryEx dteEnd;
        private DQS.Controls.TextBoxQueryEx txtInventoryPerson;
        private DQS.Controls.DateQueryEx dteStart;
        private DQS.Controls.TextBoxQueryEx txtInventoryCode;
        private DevExpress.XtraLayout.LayoutControlGroup layControlGroup;
        private DevExpress.XtraLayout.LayoutControlItem layInventoryCode;
        private DevExpress.XtraLayout.LayoutControlItem layStart;
        private DevExpress.XtraLayout.LayoutControlItem layInventoryPerson;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlItem4;

    }
}