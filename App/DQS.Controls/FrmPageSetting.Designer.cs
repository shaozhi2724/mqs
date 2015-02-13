namespace DQS.Controls
{
    partial class FrmPageSetting
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
            this.lblSortField = new DevExpress.XtraEditors.LabelControl();
            this.cbbSortField = new DevExpress.XtraEditors.ComboBoxEdit();
            this.lblSortType = new DevExpress.XtraEditors.LabelControl();
            this.cbbSortType = new DevExpress.XtraEditors.ComboBoxEdit();
            this.lblPageSize = new DevExpress.XtraEditors.LabelControl();
            this.txtPageSize = new DevExpress.XtraEditors.TextEdit();
            this.pnlButtom = new DevExpress.XtraEditors.PanelControl();
            this.btnCancel = new DevExpress.XtraEditors.SimpleButton();
            this.btnSave = new DevExpress.XtraEditors.SimpleButton();
            this.pnlSetting = new DevExpress.XtraEditors.PanelControl();
            this.chkChoose = new DevExpress.XtraEditors.CheckEdit();
            this.labelControl1 = new DevExpress.XtraEditors.LabelControl();
            this.gvControl = new DevExpress.XtraGrid.GridControl();
            this.gvData = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.colIsShow = new DevExpress.XtraGrid.Columns.GridColumn();
            this.repositoryItemCheckEdit1 = new DevExpress.XtraEditors.Repository.RepositoryItemCheckEdit();
            this.colFiledName = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gpSetting = new DevExpress.XtraEditors.GroupControl();
            ((System.ComponentModel.ISupportInitialize)(this.cbbSortField.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cbbSortType.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtPageSize.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pnlButtom)).BeginInit();
            this.pnlButtom.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pnlSetting)).BeginInit();
            this.pnlSetting.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.chkChoose.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gvControl)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gvData)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemCheckEdit1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gpSetting)).BeginInit();
            this.gpSetting.SuspendLayout();
            this.SuspendLayout();
            // 
            // lblSortField
            // 
            this.lblSortField.Location = new System.Drawing.Point(316, 14);
            this.lblSortField.Name = "lblSortField";
            this.lblSortField.Size = new System.Drawing.Size(69, 14);
            this.lblSortField.TabIndex = 4;
            this.lblSortField.Text = "排序字段(&S):";
            // 
            // cbbSortField
            // 
            this.cbbSortField.Location = new System.Drawing.Point(403, 11);
            this.cbbSortField.Name = "cbbSortField";
            this.cbbSortField.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.cbbSortField.Size = new System.Drawing.Size(169, 21);
            this.cbbSortField.TabIndex = 5;
            // 
            // lblSortType
            // 
            this.lblSortType.Location = new System.Drawing.Point(316, 45);
            this.lblSortType.Name = "lblSortType";
            this.lblSortType.Size = new System.Drawing.Size(70, 14);
            this.lblSortType.TabIndex = 6;
            this.lblSortType.Text = "排序类型(&T):";
            // 
            // cbbSortType
            // 
            this.cbbSortType.Location = new System.Drawing.Point(403, 42);
            this.cbbSortType.Name = "cbbSortType";
            this.cbbSortType.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.cbbSortType.Properties.Items.AddRange(new object[] {
            "升序",
            "降序"});
            this.cbbSortType.Size = new System.Drawing.Size(169, 21);
            this.cbbSortType.TabIndex = 7;
            // 
            // lblPageSize
            // 
            this.lblPageSize.Location = new System.Drawing.Point(23, 45);
            this.lblPageSize.Name = "lblPageSize";
            this.lblPageSize.Size = new System.Drawing.Size(81, 14);
            this.lblPageSize.TabIndex = 2;
            this.lblPageSize.Text = "每页记录数(&P):";
            // 
            // txtPageSize
            // 
            this.txtPageSize.Location = new System.Drawing.Point(119, 42);
            this.txtPageSize.Name = "txtPageSize";
            this.txtPageSize.Size = new System.Drawing.Size(169, 21);
            this.txtPageSize.TabIndex = 3;
            // 
            // pnlButtom
            // 
            this.pnlButtom.Controls.Add(this.btnCancel);
            this.pnlButtom.Controls.Add(this.btnSave);
            this.pnlButtom.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.pnlButtom.Location = new System.Drawing.Point(0, 417);
            this.pnlButtom.Name = "pnlButtom";
            this.pnlButtom.Size = new System.Drawing.Size(584, 45);
            this.pnlButtom.TabIndex = 1;
            // 
            // btnCancel
            // 
            this.btnCancel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnCancel.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btnCancel.Location = new System.Drawing.Point(497, 9);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(75, 24);
            this.btnCancel.TabIndex = 1;
            this.btnCancel.Text = "取消(&S)";
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // btnSave
            // 
            this.btnSave.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnSave.Location = new System.Drawing.Point(403, 9);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(75, 24);
            this.btnSave.TabIndex = 0;
            this.btnSave.Text = "保存(&S)";
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // pnlSetting
            // 
            this.pnlSetting.Controls.Add(this.chkChoose);
            this.pnlSetting.Controls.Add(this.lblSortField);
            this.pnlSetting.Controls.Add(this.labelControl1);
            this.pnlSetting.Controls.Add(this.lblPageSize);
            this.pnlSetting.Controls.Add(this.txtPageSize);
            this.pnlSetting.Controls.Add(this.lblSortType);
            this.pnlSetting.Controls.Add(this.cbbSortType);
            this.pnlSetting.Controls.Add(this.cbbSortField);
            this.pnlSetting.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.pnlSetting.Location = new System.Drawing.Point(0, 345);
            this.pnlSetting.Name = "pnlSetting";
            this.pnlSetting.Size = new System.Drawing.Size(584, 72);
            this.pnlSetting.TabIndex = 0;
            // 
            // chkChoose
            // 
            this.chkChoose.Location = new System.Drawing.Point(117, 11);
            this.chkChoose.Name = "chkChoose";
            this.chkChoose.Properties.Caption = "全选";
            this.chkChoose.Size = new System.Drawing.Size(75, 19);
            this.chkChoose.TabIndex = 1;
            this.chkChoose.CheckedChanged += new System.EventHandler(this.chkChoose_CheckedChanged);
            // 
            // labelControl1
            // 
            this.labelControl1.Location = new System.Drawing.Point(23, 14);
            this.labelControl1.Name = "labelControl1";
            this.labelControl1.Size = new System.Drawing.Size(45, 14);
            this.labelControl1.TabIndex = 0;
            this.labelControl1.Text = "选择(&C):";
            // 
            // gvControl
            // 
            this.gvControl.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gvControl.Location = new System.Drawing.Point(2, 23);
            this.gvControl.MainView = this.gvData;
            this.gvControl.Name = "gvControl";
            this.gvControl.RepositoryItems.AddRange(new DevExpress.XtraEditors.Repository.RepositoryItem[] {
            this.repositoryItemCheckEdit1});
            this.gvControl.Size = new System.Drawing.Size(580, 320);
            this.gvControl.TabIndex = 0;
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
            this.gvData.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.colIsShow,
            this.colFiledName});
            this.gvData.GridControl = this.gvControl;
            this.gvData.IndicatorWidth = 40;
            this.gvData.Name = "gvData";
            this.gvData.OptionsNavigation.EnterMoveNextColumn = true;
            this.gvData.OptionsView.EnableAppearanceEvenRow = true;
            this.gvData.OptionsView.ShowGroupPanel = false;
            this.gvData.CustomDrawRowIndicator += new DevExpress.XtraGrid.Views.Grid.RowIndicatorCustomDrawEventHandler(this.gvData_CustomDrawRowIndicator);
            // 
            // colIsShow
            // 
            this.colIsShow.Caption = "列的可见性";
            this.colIsShow.ColumnEdit = this.repositoryItemCheckEdit1;
            this.colIsShow.FieldName = "IsShow";
            this.colIsShow.Name = "colIsShow";
            this.colIsShow.Visible = true;
            this.colIsShow.VisibleIndex = 0;
            this.colIsShow.Width = 84;
            // 
            // repositoryItemCheckEdit1
            // 
            this.repositoryItemCheckEdit1.AutoHeight = false;
            this.repositoryItemCheckEdit1.Name = "repositoryItemCheckEdit1";
            // 
            // colFiledName
            // 
            this.colFiledName.Caption = "列名";
            this.colFiledName.FieldName = "FieldName";
            this.colFiledName.Name = "colFiledName";
            this.colFiledName.OptionsColumn.AllowEdit = false;
            this.colFiledName.Visible = true;
            this.colFiledName.VisibleIndex = 1;
            this.colFiledName.Width = 452;
            // 
            // gpSetting
            // 
            this.gpSetting.Controls.Add(this.gvControl);
            this.gpSetting.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gpSetting.Location = new System.Drawing.Point(0, 0);
            this.gpSetting.Name = "gpSetting";
            this.gpSetting.Size = new System.Drawing.Size(584, 345);
            this.gpSetting.TabIndex = 2;
            this.gpSetting.Text = "设置列的可见性";
            // 
            // FrmPageSetting
            // 
            this.AcceptButton = this.btnSave;
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 14F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CancelButton = this.btnCancel;
            this.ClientSize = new System.Drawing.Size(584, 462);
            this.Controls.Add(this.gpSetting);
            this.Controls.Add(this.pnlSetting);
            this.Controls.Add(this.pnlButtom);
            this.Name = "FrmPageSetting";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "显示设置";
            ((System.ComponentModel.ISupportInitialize)(this.cbbSortField.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cbbSortType.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtPageSize.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pnlButtom)).EndInit();
            this.pnlButtom.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pnlSetting)).EndInit();
            this.pnlSetting.ResumeLayout(false);
            this.pnlSetting.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.chkChoose.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gvControl)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gvData)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemCheckEdit1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gpSetting)).EndInit();
            this.gpSetting.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraEditors.LabelControl lblSortField;
        private DevExpress.XtraEditors.ComboBoxEdit cbbSortField;
        private DevExpress.XtraEditors.LabelControl lblSortType;
        private DevExpress.XtraEditors.ComboBoxEdit cbbSortType;
        private DevExpress.XtraEditors.LabelControl lblPageSize;
        private DevExpress.XtraEditors.TextEdit txtPageSize;
        private DevExpress.XtraEditors.PanelControl pnlButtom;
        private DevExpress.XtraEditors.SimpleButton btnCancel;
        private DevExpress.XtraEditors.SimpleButton btnSave;
        private DevExpress.XtraEditors.PanelControl pnlSetting;
        private DevExpress.XtraGrid.GridControl gvControl;
        private DevExpress.XtraGrid.Views.Grid.GridView gvData;
        private DevExpress.XtraEditors.GroupControl gpSetting;
        private DevExpress.XtraGrid.Columns.GridColumn colIsShow;
        private DevExpress.XtraEditors.Repository.RepositoryItemCheckEdit repositoryItemCheckEdit1;
        private DevExpress.XtraGrid.Columns.GridColumn colFiledName;
        private DevExpress.XtraEditors.CheckEdit chkChoose;
        private DevExpress.XtraEditors.LabelControl labelControl1;
    }
}