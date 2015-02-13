namespace DQS.SvrHost
{
    partial class FrmFunctionLogs
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
            this.groupControl1 = new DevExpress.XtraEditors.GroupControl();
            this.trlLogs = new DevExpress.XtraTreeList.TreeList();
            this.tcLogStyle = new DevExpress.XtraTreeList.Columns.TreeListColumn();
            this.panelControl1 = new DevExpress.XtraEditors.PanelControl();
            this.simpleButton1 = new DevExpress.XtraEditors.SimpleButton();
            this.labelControl1 = new DevExpress.XtraEditors.LabelControl();
            this.textEdit1 = new DevExpress.XtraEditors.TextEdit();
            this.splitterControl1 = new DevExpress.XtraEditors.SplitterControl();
            this.groupControl2 = new DevExpress.XtraEditors.GroupControl();
            this.gvControl = new DevExpress.XtraGrid.GridControl();
            this.gvData = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.repositoryItemCheckEdit1 = new DevExpress.XtraEditors.Repository.RepositoryItemCheckEdit();
            this.repositoryItemComboBox1 = new DevExpress.XtraEditors.Repository.RepositoryItemComboBox();
            this.panelControl2 = new DevExpress.XtraEditors.PanelControl();
            this.dateEdit2 = new DevExpress.XtraEditors.DateEdit();
            this.dateEdit1 = new DevExpress.XtraEditors.DateEdit();
            this.labelControl3 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl2 = new DevExpress.XtraEditors.LabelControl();
            this.btnSave = new DevExpress.XtraEditors.SimpleButton();
            ((System.ComponentModel.ISupportInitialize)(this.groupControl1)).BeginInit();
            this.groupControl1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.trlLogs)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.panelControl1)).BeginInit();
            this.panelControl1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.textEdit1.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.groupControl2)).BeginInit();
            this.groupControl2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gvControl)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gvData)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemCheckEdit1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemComboBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.panelControl2)).BeginInit();
            this.panelControl2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dateEdit2.Properties.VistaTimeProperties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dateEdit2.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dateEdit1.Properties.VistaTimeProperties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dateEdit1.Properties)).BeginInit();
            this.SuspendLayout();
            // 
            // groupControl1
            // 
            this.groupControl1.Controls.Add(this.trlLogs);
            this.groupControl1.Controls.Add(this.panelControl1);
            this.groupControl1.Dock = System.Windows.Forms.DockStyle.Left;
            this.groupControl1.Location = new System.Drawing.Point(0, 0);
            this.groupControl1.Name = "groupControl1";
            this.groupControl1.Size = new System.Drawing.Size(297, 579);
            this.groupControl1.TabIndex = 1;
            this.groupControl1.Text = "日志列表";
            // 
            // trlLogs
            // 
            this.trlLogs.Appearance.EvenRow.BackColor = System.Drawing.Color.WhiteSmoke;
            this.trlLogs.Appearance.EvenRow.Options.UseBackColor = true;
            this.trlLogs.Appearance.FocusedCell.BackColor = System.Drawing.Color.Aqua;
            this.trlLogs.Appearance.FocusedCell.Options.UseBackColor = true;
            this.trlLogs.Appearance.FocusedRow.BackColor = System.Drawing.Color.Beige;
            this.trlLogs.Appearance.FocusedRow.ForeColor = System.Drawing.Color.Black;
            this.trlLogs.Appearance.FocusedRow.Options.UseBackColor = true;
            this.trlLogs.Appearance.FocusedRow.Options.UseForeColor = true;
            this.trlLogs.Columns.AddRange(new DevExpress.XtraTreeList.Columns.TreeListColumn[] {
            this.tcLogStyle});
            this.trlLogs.Dock = System.Windows.Forms.DockStyle.Fill;
            this.trlLogs.Location = new System.Drawing.Point(2, 65);
            this.trlLogs.Name = "trlLogs";
            this.trlLogs.BeginUnboundLoad();
            this.trlLogs.AppendNode(new object[] {
            "日志查看器"}, -1);
            this.trlLogs.AppendNode(new object[] {
            "功能日志"}, 0);
            this.trlLogs.AppendNode(new object[] {
            "新建"}, 1);
            this.trlLogs.AppendNode(new object[] {
            "编辑"}, 1);
            this.trlLogs.AppendNode(new object[] {
            "删除"}, 1);
            this.trlLogs.AppendNode(new object[] {
            "查询"}, 1);
            this.trlLogs.AppendNode(new object[] {
            "刷新"}, 1);
            this.trlLogs.AppendNode(new object[] {
            "导出"}, 1);
            this.trlLogs.AppendNode(new object[] {
            "打印"}, 1);
            this.trlLogs.AppendNode(new object[] {
            "显示设置"}, 1);
            this.trlLogs.AppendNode(new object[] {
            "高级查询"}, 1);
            this.trlLogs.AppendNode(new object[] {
            "业务日志"}, 0);
            this.trlLogs.AppendNode(new object[] {
            "采购"}, 11);
            this.trlLogs.AppendNode(new object[] {
            "销售"}, 11);
            this.trlLogs.AppendNode(new object[] {
            "采购退货"}, 11);
            this.trlLogs.AppendNode(new object[] {
            "销售退货"}, 11);
            this.trlLogs.AppendNode(new object[] {
            "审批日志"}, 0);
            this.trlLogs.AppendNode(new object[] {
            "采购单"}, 16);
            this.trlLogs.AppendNode(new object[] {
            "销售单"}, 16);
            this.trlLogs.AppendNode(new object[] {
            "采购退货单"}, 16);
            this.trlLogs.AppendNode(new object[] {
            "销售退货单"}, 16);
            this.trlLogs.AppendNode(new object[] {
            "养护计划单"}, 16);
            this.trlLogs.AppendNode(new object[] {
            "异常上报单"}, 16);
            this.trlLogs.AppendNode(new object[] {
            "盘点单"}, 16);
            this.trlLogs.AppendNode(new object[] {
            "药品锁定单"}, 16);
            this.trlLogs.AppendNode(new object[] {
            "系统日志"}, 0);
            this.trlLogs.AppendNode(new object[] {
            "数据库自动备份"}, 25);
            this.trlLogs.AppendNode(new object[] {
            "客户端注册记录"}, 25);
            this.trlLogs.EndUnboundLoad();
            this.trlLogs.OptionsBehavior.Editable = false;
            this.trlLogs.OptionsView.EnableAppearanceEvenRow = true;
            this.trlLogs.Size = new System.Drawing.Size(293, 512);
            this.trlLogs.TabIndex = 2;
            // 
            // tcLogStyle
            // 
            this.tcLogStyle.Caption = "日志分类";
            this.tcLogStyle.FieldName = "日志分类";
            this.tcLogStyle.MinWidth = 56;
            this.tcLogStyle.Name = "tcLogStyle";
            this.tcLogStyle.Visible = true;
            this.tcLogStyle.VisibleIndex = 0;
            this.tcLogStyle.Width = 93;
            // 
            // panelControl1
            // 
            this.panelControl1.Controls.Add(this.simpleButton1);
            this.panelControl1.Controls.Add(this.labelControl1);
            this.panelControl1.Controls.Add(this.textEdit1);
            this.panelControl1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelControl1.Location = new System.Drawing.Point(2, 23);
            this.panelControl1.Name = "panelControl1";
            this.panelControl1.Size = new System.Drawing.Size(293, 42);
            this.panelControl1.TabIndex = 0;
            // 
            // simpleButton1
            // 
            this.simpleButton1.Location = new System.Drawing.Point(208, 10);
            this.simpleButton1.Name = "simpleButton1";
            this.simpleButton1.Size = new System.Drawing.Size(80, 23);
            this.simpleButton1.TabIndex = 5;
            this.simpleButton1.Text = "快速查询";
            // 
            // labelControl1
            // 
            this.labelControl1.Location = new System.Drawing.Point(10, 15);
            this.labelControl1.Name = "labelControl1";
            this.labelControl1.Size = new System.Drawing.Size(58, 14);
            this.labelControl1.TabIndex = 4;
            this.labelControl1.Text = "日志名(&U):";
            // 
            // textEdit1
            // 
            this.textEdit1.Location = new System.Drawing.Point(77, 12);
            this.textEdit1.Name = "textEdit1";
            this.textEdit1.Size = new System.Drawing.Size(125, 21);
            this.textEdit1.TabIndex = 3;
            // 
            // splitterControl1
            // 
            this.splitterControl1.Location = new System.Drawing.Point(297, 0);
            this.splitterControl1.Name = "splitterControl1";
            this.splitterControl1.Size = new System.Drawing.Size(6, 579);
            this.splitterControl1.TabIndex = 2;
            this.splitterControl1.TabStop = false;
            // 
            // groupControl2
            // 
            this.groupControl2.Controls.Add(this.gvControl);
            this.groupControl2.Controls.Add(this.panelControl2);
            this.groupControl2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupControl2.Location = new System.Drawing.Point(303, 0);
            this.groupControl2.Name = "groupControl2";
            this.groupControl2.Size = new System.Drawing.Size(656, 579);
            this.groupControl2.TabIndex = 3;
            this.groupControl2.Text = "日志详情";
            // 
            // gvControl
            // 
            this.gvControl.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gvControl.Location = new System.Drawing.Point(2, 65);
            this.gvControl.MainView = this.gvData;
            this.gvControl.Name = "gvControl";
            this.gvControl.RepositoryItems.AddRange(new DevExpress.XtraEditors.Repository.RepositoryItem[] {
            this.repositoryItemCheckEdit1,
            this.repositoryItemComboBox1});
            this.gvControl.Size = new System.Drawing.Size(652, 512);
            this.gvControl.TabIndex = 6;
            this.gvControl.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gvData});
            // 
            // gvData
            // 
            this.gvData.Appearance.EvenRow.BackColor = System.Drawing.Color.WhiteSmoke;
            this.gvData.Appearance.EvenRow.Options.UseBackColor = true;
            this.gvData.Appearance.FocusedCell.BackColor = System.Drawing.Color.Aqua;
            this.gvData.Appearance.FocusedCell.Options.UseBackColor = true;
            this.gvData.Appearance.FocusedRow.BackColor = System.Drawing.Color.Beige;
            this.gvData.Appearance.FocusedRow.ForeColor = System.Drawing.Color.Black;
            this.gvData.Appearance.FocusedRow.Options.UseBackColor = true;
            this.gvData.Appearance.FocusedRow.Options.UseForeColor = true;
            this.gvData.GridControl = this.gvControl;
            this.gvData.IndicatorWidth = 40;
            this.gvData.Name = "gvData";
            this.gvData.OptionsBehavior.Editable = false;
            this.gvData.OptionsNavigation.EnterMoveNextColumn = true;
            this.gvData.OptionsView.ColumnAutoWidth = false;
            this.gvData.OptionsView.EnableAppearanceEvenRow = true;
            this.gvData.OptionsView.ShowGroupPanel = false;
            this.gvData.CustomDrawRowIndicator += new DevExpress.XtraGrid.Views.Grid.RowIndicatorCustomDrawEventHandler(this.gvData_CustomDrawRowIndicator);
            this.gvData.CustomDrawEmptyForeground += new DevExpress.XtraGrid.Views.Base.CustomDrawEventHandler(this.gvData_CustomDrawEmptyForeground);
            // 
            // repositoryItemCheckEdit1
            // 
            this.repositoryItemCheckEdit1.AutoHeight = false;
            this.repositoryItemCheckEdit1.Name = "repositoryItemCheckEdit1";
            // 
            // repositoryItemComboBox1
            // 
            this.repositoryItemComboBox1.AutoHeight = false;
            this.repositoryItemComboBox1.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.repositoryItemComboBox1.Items.AddRange(new object[] {
            "等于",
            "不等于",
            "大于",
            "大于等于",
            "小于",
            "小于等于",
            "模糊等于"});
            this.repositoryItemComboBox1.Name = "repositoryItemComboBox1";
            this.repositoryItemComboBox1.NullText = "等于";
            this.repositoryItemComboBox1.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.DisableTextEditor;
            // 
            // panelControl2
            // 
            this.panelControl2.Controls.Add(this.dateEdit2);
            this.panelControl2.Controls.Add(this.dateEdit1);
            this.panelControl2.Controls.Add(this.labelControl3);
            this.panelControl2.Controls.Add(this.labelControl2);
            this.panelControl2.Controls.Add(this.btnSave);
            this.panelControl2.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelControl2.Location = new System.Drawing.Point(2, 23);
            this.panelControl2.Name = "panelControl2";
            this.panelControl2.Size = new System.Drawing.Size(652, 42);
            this.panelControl2.TabIndex = 0;
            // 
            // dateEdit2
            // 
            this.dateEdit2.EditValue = null;
            this.dateEdit2.Location = new System.Drawing.Point(225, 12);
            this.dateEdit2.Name = "dateEdit2";
            this.dateEdit2.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.dateEdit2.Properties.VistaTimeProperties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton()});
            this.dateEdit2.Size = new System.Drawing.Size(131, 21);
            this.dateEdit2.TabIndex = 8;
            // 
            // dateEdit1
            // 
            this.dateEdit1.EditValue = null;
            this.dateEdit1.Location = new System.Drawing.Point(70, 12);
            this.dateEdit1.Name = "dateEdit1";
            this.dateEdit1.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.dateEdit1.Properties.VistaTimeProperties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton()});
            this.dateEdit1.Size = new System.Drawing.Size(131, 21);
            this.dateEdit1.TabIndex = 8;
            // 
            // labelControl3
            // 
            this.labelControl3.Location = new System.Drawing.Point(207, 15);
            this.labelControl3.Name = "labelControl3";
            this.labelControl3.Size = new System.Drawing.Size(12, 14);
            this.labelControl3.TabIndex = 7;
            this.labelControl3.Text = "至";
            // 
            // labelControl2
            // 
            this.labelControl2.Location = new System.Drawing.Point(18, 15);
            this.labelControl2.Name = "labelControl2";
            this.labelControl2.Size = new System.Drawing.Size(46, 14);
            this.labelControl2.TabIndex = 7;
            this.labelControl2.Text = "日期(&A):";
            // 
            // btnSave
            // 
            this.btnSave.Location = new System.Drawing.Point(373, 10);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(80, 23);
            this.btnSave.TabIndex = 6;
            this.btnSave.Text = "查询(&Q)";
            // 
            // FrmFunctionLogs
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 14F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(959, 579);
            this.Controls.Add(this.groupControl2);
            this.Controls.Add(this.splitterControl1);
            this.Controls.Add(this.groupControl1);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FrmFunctionLogs";
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "查看系统日志";
            this.Load += new System.EventHandler(this.FrmFunctionLogs_Load);
            ((System.ComponentModel.ISupportInitialize)(this.groupControl1)).EndInit();
            this.groupControl1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.trlLogs)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.panelControl1)).EndInit();
            this.panelControl1.ResumeLayout(false);
            this.panelControl1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.textEdit1.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.groupControl2)).EndInit();
            this.groupControl2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.gvControl)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gvData)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemCheckEdit1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemComboBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.panelControl2)).EndInit();
            this.panelControl2.ResumeLayout(false);
            this.panelControl2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dateEdit2.Properties.VistaTimeProperties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dateEdit2.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dateEdit1.Properties.VistaTimeProperties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dateEdit1.Properties)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraEditors.GroupControl groupControl1;
        private DevExpress.XtraEditors.PanelControl panelControl1;
        private DevExpress.XtraEditors.SimpleButton simpleButton1;
        private DevExpress.XtraEditors.LabelControl labelControl1;
        private DevExpress.XtraEditors.TextEdit textEdit1;
        private DevExpress.XtraEditors.SplitterControl splitterControl1;
        private DevExpress.XtraEditors.GroupControl groupControl2;
        private DevExpress.XtraEditors.PanelControl panelControl2;
        private DevExpress.XtraEditors.DateEdit dateEdit2;
        private DevExpress.XtraEditors.DateEdit dateEdit1;
        private DevExpress.XtraEditors.LabelControl labelControl3;
        private DevExpress.XtraEditors.LabelControl labelControl2;
        private DevExpress.XtraEditors.SimpleButton btnSave;
        private DevExpress.XtraTreeList.TreeList trlLogs;
        private DevExpress.XtraTreeList.Columns.TreeListColumn tcLogStyle;
        private DevExpress.XtraGrid.GridControl gvControl;
        private DevExpress.XtraGrid.Views.Grid.GridView gvData;
        private DevExpress.XtraEditors.Repository.RepositoryItemCheckEdit repositoryItemCheckEdit1;
        private DevExpress.XtraEditors.Repository.RepositoryItemComboBox repositoryItemComboBox1;
    }
}