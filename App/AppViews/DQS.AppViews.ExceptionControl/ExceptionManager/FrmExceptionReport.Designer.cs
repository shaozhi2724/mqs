namespace DQS.AppViews.ExceptionControl.ExceptionManager
{
    partial class FrmExceptionReport
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
            this.txtFinder = new DQS.Controls.TextBoxQueryEx();
            this.dteStart = new DQS.Controls.DateQueryEx();
            this.txtExceptionCode = new DQS.Controls.TextBoxQueryEx();
            this.layControlGroup = new DevExpress.XtraLayout.LayoutControlGroup();
            this.layExceptionCode = new DevExpress.XtraLayout.LayoutControlItem();
            this.layStart = new DevExpress.XtraLayout.LayoutControlItem();
            this.layFinder = new DevExpress.XtraLayout.LayoutControlItem();
            this.layEnd = new DevExpress.XtraLayout.LayoutControlItem();
            ((System.ComponentModel.ISupportInitialize)(this.gpcQuery)).BeginInit();
            this.gpcQuery.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pageNavigator)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.toolBarPanel)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layControl)).BeginInit();
            this.layControl.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dteEnd.Properties.VistaTimeProperties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dteEnd.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtFinder.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dteStart.Properties.VistaTimeProperties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dteStart.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtExceptionCode.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layControlGroup)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layExceptionCode)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layStart)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layFinder)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layEnd)).BeginInit();
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
            this.layControl.Controls.Add(this.txtFinder);
            this.layControl.Controls.Add(this.dteStart);
            this.layControl.Controls.Add(this.txtExceptionCode);
            this.layControl.Dock = System.Windows.Forms.DockStyle.Fill;
            this.layControl.Location = new System.Drawing.Point(2, 27);
            this.layControl.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.layControl.Name = "layControl";
            this.layControl.Root = this.layControlGroup;
            this.layControl.Size = new System.Drawing.Size(926, 69);
            this.layControl.TabIndex = 7;
            this.layControl.Text = "layControl";
            // 
            // dteEnd
            // 
            this.dteEnd.EditValue = null;
            this.dteEnd.FormatQueryString = "[发现时间] <= \'{0} 23:59:59\'";
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
            // txtFinder
            // 
            this.txtFinder.FormatQueryString = "[发现人] LIKE \'%{0}%\'";
            this.txtFinder.Location = new System.Drawing.Point(301, 12);
            this.txtFinder.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtFinder.Name = "txtFinder";
            this.txtFinder.Size = new System.Drawing.Size(160, 25);
            this.txtFinder.StyleController = this.layControl;
            this.txtFinder.TabIndex = 6;
            // 
            // dteStart
            // 
            this.dteStart.EditValue = null;
            this.dteStart.FormatQueryString = "[发现时间] >= \'{0} 00:00:00\'";
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
            // txtExceptionCode
            // 
            this.txtExceptionCode.FormatQueryString = "[异常编号] = \'{0}\'";
            this.txtExceptionCode.Location = new System.Drawing.Point(75, 12);
            this.txtExceptionCode.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtExceptionCode.Name = "txtExceptionCode";
            this.txtExceptionCode.Size = new System.Drawing.Size(159, 25);
            this.txtExceptionCode.StyleController = this.layControl;
            this.txtExceptionCode.TabIndex = 4;
            // 
            // layControlGroup
            // 
            this.layControlGroup.AppearanceItemCaption.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.layControlGroup.AppearanceItemCaption.Options.UseFont = true;
            this.layControlGroup.CustomizationFormText = "查询";
            this.layControlGroup.EnableIndentsWithoutBorders = DevExpress.Utils.DefaultBoolean.True;
            this.layControlGroup.GroupBordersVisible = false;
            this.layControlGroup.Items.AddRange(new DevExpress.XtraLayout.BaseLayoutItem[] {
            this.layExceptionCode,
            this.layStart,
            this.layFinder,
            this.layEnd});
            this.layControlGroup.Location = new System.Drawing.Point(0, 0);
            this.layControlGroup.Name = "layControlGroup";
            this.layControlGroup.Size = new System.Drawing.Size(926, 69);
            this.layControlGroup.Spacing = new DevExpress.XtraLayout.Utils.Padding(0, 0, 0, 0);
            this.layControlGroup.Text = "查询";
            this.layControlGroup.TextVisible = false;
            // 
            // layExceptionCode
            // 
            this.layExceptionCode.Control = this.txtExceptionCode;
            this.layExceptionCode.CustomizationFormText = "异常编号";
            this.layExceptionCode.Location = new System.Drawing.Point(0, 0);
            this.layExceptionCode.Name = "layExceptionCode";
            this.layExceptionCode.Size = new System.Drawing.Size(226, 49);
            this.layExceptionCode.Text = "异常编号";
            this.layExceptionCode.TextSize = new System.Drawing.Size(60, 20);
            // 
            // layStart
            // 
            this.layStart.Control = this.dteStart;
            this.layStart.CustomizationFormText = "发现时间";
            this.layStart.Location = new System.Drawing.Point(453, 0);
            this.layStart.Name = "layStart";
            this.layStart.Size = new System.Drawing.Size(227, 49);
            this.layStart.Text = "发现时间";
            this.layStart.TextSize = new System.Drawing.Size(60, 20);
            // 
            // layFinder
            // 
            this.layFinder.Control = this.txtFinder;
            this.layFinder.CustomizationFormText = "发现人";
            this.layFinder.Location = new System.Drawing.Point(226, 0);
            this.layFinder.Name = "layFinder";
            this.layFinder.Size = new System.Drawing.Size(227, 49);
            this.layFinder.Text = "发现人";
            this.layFinder.TextSize = new System.Drawing.Size(60, 20);
            // 
            // layEnd
            // 
            this.layEnd.Control = this.dteEnd;
            this.layEnd.CustomizationFormText = "至";
            this.layEnd.Location = new System.Drawing.Point(680, 0);
            this.layEnd.Name = "layEnd";
            this.layEnd.Size = new System.Drawing.Size(226, 49);
            this.layEnd.Text = "至";
            this.layEnd.TextSize = new System.Drawing.Size(60, 20);
            // 
            // FrmExceptionReport
            // 
            this.Appearance.Font = new System.Drawing.Font("微软雅黑", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Appearance.Options.UseFont = true;
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 19F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(930, 654);
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Name = "FrmExceptionReport";
            this.Text = "FrmExceptionReport";
            this.Load += new System.EventHandler(this.FrmExceptionReport_Load);
            ((System.ComponentModel.ISupportInitialize)(this.gpcQuery)).EndInit();
            this.gpcQuery.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pageNavigator)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.toolBarPanel)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layControl)).EndInit();
            this.layControl.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dteEnd.Properties.VistaTimeProperties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dteEnd.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtFinder.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dteStart.Properties.VistaTimeProperties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dteStart.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtExceptionCode.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layControlGroup)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layExceptionCode)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layStart)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layFinder)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layEnd)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraLayout.LayoutControl layControl;
        private DQS.Controls.DateQueryEx dteEnd;
        private DQS.Controls.TextBoxQueryEx txtFinder;
        private DQS.Controls.DateQueryEx dteStart;
        private DQS.Controls.TextBoxQueryEx txtExceptionCode;
        private DevExpress.XtraLayout.LayoutControlGroup layControlGroup;
        private DevExpress.XtraLayout.LayoutControlItem layExceptionCode;
        private DevExpress.XtraLayout.LayoutControlItem layStart;
        private DevExpress.XtraLayout.LayoutControlItem layFinder;
        private DevExpress.XtraLayout.LayoutControlItem layEnd;

    }
}