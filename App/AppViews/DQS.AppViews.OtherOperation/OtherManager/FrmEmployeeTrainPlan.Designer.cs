namespace DQS.AppViews.OtherOperation.OtherManager
{
    partial class FrmEmployeeTrainPlan
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
            this.txtProposer = new DQS.Controls.TextBoxQueryEx();
            this.dteStart = new DQS.Controls.DateQueryEx();
            this.txtTrainName = new DQS.Controls.TextBoxQueryEx();
            this.layControlGroup = new DevExpress.XtraLayout.LayoutControlGroup();
            this.layoutControlItem1 = new DevExpress.XtraLayout.LayoutControlItem();
            this.layoutControlItem2 = new DevExpress.XtraLayout.LayoutControlItem();
            this.layoutControlItem3 = new DevExpress.XtraLayout.LayoutControlItem();
            this.layoutControlItem4 = new DevExpress.XtraLayout.LayoutControlItem();
            ((System.ComponentModel.ISupportInitialize)(this.gpcQuery)).BeginInit();
            this.gpcQuery.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pageNavigator)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.toolBarPanel)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layControl)).BeginInit();
            this.layControl.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dteEnd.Properties.VistaTimeProperties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dteEnd.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtProposer.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dteStart.Properties.VistaTimeProperties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dteStart.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtTrainName.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layControlGroup)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem3)).BeginInit();
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
            this.layControl.Controls.Add(this.txtProposer);
            this.layControl.Controls.Add(this.dteStart);
            this.layControl.Controls.Add(this.txtTrainName);
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
            this.dteEnd.FormatQueryString = "[创建日期] <= \'{0} 23:59:59\'";
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
            // txtProposer
            // 
            this.txtProposer.FormatQueryString = "[申请人] LIKE \'%{0}%\' OR [申请人Spell] LIKE \'%{0}%\' ";
            this.txtProposer.Location = new System.Drawing.Point(301, 12);
            this.txtProposer.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtProposer.Name = "txtProposer";
            this.txtProposer.Size = new System.Drawing.Size(160, 25);
            this.txtProposer.StyleController = this.layControl;
            this.txtProposer.TabIndex = 6;
            // 
            // dteStart
            // 
            this.dteStart.EditValue = null;
            this.dteStart.FormatQueryString = "[创建日期] >= \'{0} 00:00:00\'";
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
            // txtTrainName
            // 
            this.txtTrainName.FormatQueryString = "[培训名称] LIKE \'%{0}%\'";
            this.txtTrainName.Location = new System.Drawing.Point(75, 12);
            this.txtTrainName.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtTrainName.Name = "txtTrainName";
            this.txtTrainName.Size = new System.Drawing.Size(159, 25);
            this.txtTrainName.StyleController = this.layControl;
            this.txtTrainName.TabIndex = 4;
            // 
            // layControlGroup
            // 
            this.layControlGroup.AppearanceItemCaption.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.layControlGroup.AppearanceItemCaption.Options.UseFont = true;
            this.layControlGroup.CustomizationFormText = "查询";
            this.layControlGroup.EnableIndentsWithoutBorders = DevExpress.Utils.DefaultBoolean.True;
            this.layControlGroup.GroupBordersVisible = false;
            this.layControlGroup.Items.AddRange(new DevExpress.XtraLayout.BaseLayoutItem[] {
            this.layoutControlItem1,
            this.layoutControlItem2,
            this.layoutControlItem3,
            this.layoutControlItem4});
            this.layControlGroup.Location = new System.Drawing.Point(0, 0);
            this.layControlGroup.Name = "layControlGroup";
            this.layControlGroup.Size = new System.Drawing.Size(926, 69);
            this.layControlGroup.Spacing = new DevExpress.XtraLayout.Utils.Padding(0, 0, 0, 0);
            this.layControlGroup.Text = "查询";
            this.layControlGroup.TextVisible = false;
            // 
            // layoutControlItem1
            // 
            this.layoutControlItem1.Control = this.txtTrainName;
            this.layoutControlItem1.CustomizationFormText = "培训名称";
            this.layoutControlItem1.Location = new System.Drawing.Point(0, 0);
            this.layoutControlItem1.Name = "layoutControlItem1";
            this.layoutControlItem1.Size = new System.Drawing.Size(226, 49);
            this.layoutControlItem1.Text = "培训名称";
            this.layoutControlItem1.TextSize = new System.Drawing.Size(60, 20);
            // 
            // layoutControlItem2
            // 
            this.layoutControlItem2.Control = this.dteStart;
            this.layoutControlItem2.CustomizationFormText = "创建日期";
            this.layoutControlItem2.Location = new System.Drawing.Point(453, 0);
            this.layoutControlItem2.Name = "layoutControlItem2";
            this.layoutControlItem2.Size = new System.Drawing.Size(227, 49);
            this.layoutControlItem2.Text = "创建日期";
            this.layoutControlItem2.TextSize = new System.Drawing.Size(60, 20);
            // 
            // layoutControlItem3
            // 
            this.layoutControlItem3.Control = this.txtProposer;
            this.layoutControlItem3.CustomizationFormText = "申请人";
            this.layoutControlItem3.Location = new System.Drawing.Point(226, 0);
            this.layoutControlItem3.Name = "layoutControlItem3";
            this.layoutControlItem3.Size = new System.Drawing.Size(227, 49);
            this.layoutControlItem3.Text = "申请人";
            this.layoutControlItem3.TextSize = new System.Drawing.Size(60, 20);
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
            // FrmEmployeeTrainPlan
            // 
            this.Appearance.Font = new System.Drawing.Font("微软雅黑", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Appearance.Options.UseFont = true;
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 19F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(930, 654);
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Name = "FrmEmployeeTrainPlan";
            this.Text = "FrmEmployeeTrainPlan";
            this.Load += new System.EventHandler(this.FrmEmployeeTrainPlan_Load);
            ((System.ComponentModel.ISupportInitialize)(this.gpcQuery)).EndInit();
            this.gpcQuery.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pageNavigator)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.toolBarPanel)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layControl)).EndInit();
            this.layControl.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dteEnd.Properties.VistaTimeProperties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dteEnd.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtProposer.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dteStart.Properties.VistaTimeProperties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dteStart.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtTrainName.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layControlGroup)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem4)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraLayout.LayoutControl layControl;
        private DQS.Controls.DateQueryEx dteEnd;
        private DQS.Controls.TextBoxQueryEx txtProposer;
        private DQS.Controls.DateQueryEx dteStart;
        private DQS.Controls.TextBoxQueryEx txtTrainName;
        private DevExpress.XtraLayout.LayoutControlGroup layControlGroup;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlItem1;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlItem2;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlItem3;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlItem4;

    }
}