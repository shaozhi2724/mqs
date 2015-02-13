namespace DQS.Controls
{
    partial class FrmHighQuery
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
            this.pnlButtom = new DevExpress.XtraEditors.PanelControl();
            this.btnCancel = new DevExpress.XtraEditors.SimpleButton();
            this.btnQuery = new DevExpress.XtraEditors.SimpleButton();
            this.gpHighQuery = new DevExpress.XtraEditors.GroupControl();
            this.gvControl = new DevExpress.XtraGrid.GridControl();
            this.gvData = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.colFieldName = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colCondition = new DevExpress.XtraGrid.Columns.GridColumn();
            this.repositoryItemComboBox1 = new DevExpress.XtraEditors.Repository.RepositoryItemComboBox();
            this.colFieldValue = new DevExpress.XtraGrid.Columns.GridColumn();
            this.repositoryItemCheckEdit1 = new DevExpress.XtraEditors.Repository.RepositoryItemCheckEdit();
            ((System.ComponentModel.ISupportInitialize)(this.pnlButtom)).BeginInit();
            this.pnlButtom.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gpHighQuery)).BeginInit();
            this.gpHighQuery.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gvControl)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gvData)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemComboBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemCheckEdit1)).BeginInit();
            this.SuspendLayout();
            // 
            // pnlButtom
            // 
            this.pnlButtom.Controls.Add(this.btnCancel);
            this.pnlButtom.Controls.Add(this.btnQuery);
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
            // btnQuery
            // 
            this.btnQuery.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnQuery.Location = new System.Drawing.Point(403, 9);
            this.btnQuery.Name = "btnQuery";
            this.btnQuery.Size = new System.Drawing.Size(75, 24);
            this.btnQuery.TabIndex = 0;
            this.btnQuery.Text = "查询(&S)";
            this.btnQuery.Click += new System.EventHandler(this.btnQuery_Click);
            // 
            // gpHighQuery
            // 
            this.gpHighQuery.Controls.Add(this.gvControl);
            this.gpHighQuery.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gpHighQuery.Location = new System.Drawing.Point(0, 0);
            this.gpHighQuery.Name = "gpHighQuery";
            this.gpHighQuery.Size = new System.Drawing.Size(584, 417);
            this.gpHighQuery.TabIndex = 0;
            this.gpHighQuery.Text = "设置查询条件";
            // 
            // gvControl
            // 
            this.gvControl.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gvControl.Location = new System.Drawing.Point(2, 23);
            this.gvControl.MainView = this.gvData;
            this.gvControl.Name = "gvControl";
            this.gvControl.RepositoryItems.AddRange(new DevExpress.XtraEditors.Repository.RepositoryItem[] {
            this.repositoryItemCheckEdit1,
            this.repositoryItemComboBox1});
            this.gvControl.Size = new System.Drawing.Size(580, 392);
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
            this.colFieldName,
            this.colCondition,
            this.colFieldValue});
            this.gvData.GridControl = this.gvControl;
            this.gvData.IndicatorWidth = 40;
            this.gvData.Name = "gvData";
            this.gvData.OptionsNavigation.EnterMoveNextColumn = true;
            this.gvData.OptionsView.EnableAppearanceEvenRow = true;
            this.gvData.OptionsView.ShowGroupPanel = false;
            this.gvData.CustomDrawRowIndicator += new DevExpress.XtraGrid.Views.Grid.RowIndicatorCustomDrawEventHandler(this.gvData_CustomDrawRowIndicator);
            // 
            // colFieldName
            // 
            this.colFieldName.Caption = "字段名称";
            this.colFieldName.FieldName = "FieldName";
            this.colFieldName.Name = "colFieldName";
            this.colFieldName.OptionsColumn.AllowEdit = false;
            this.colFieldName.Visible = true;
            this.colFieldName.VisibleIndex = 0;
            // 
            // colCondition
            // 
            this.colCondition.Caption = "运算条件";
            this.colCondition.ColumnEdit = this.repositoryItemComboBox1;
            this.colCondition.FieldName = "Condition";
            this.colCondition.Name = "colCondition";
            this.colCondition.Visible = true;
            this.colCondition.VisibleIndex = 1;
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
            // colFieldValue
            // 
            this.colFieldValue.Caption = "值";
            this.colFieldValue.FieldName = "FieldValue";
            this.colFieldValue.Name = "colFieldValue";
            this.colFieldValue.Visible = true;
            this.colFieldValue.VisibleIndex = 2;
            // 
            // repositoryItemCheckEdit1
            // 
            this.repositoryItemCheckEdit1.AutoHeight = false;
            this.repositoryItemCheckEdit1.Name = "repositoryItemCheckEdit1";
            // 
            // FrmHighQuery
            // 
            this.AcceptButton = this.btnQuery;
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 14F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CancelButton = this.btnCancel;
            this.ClientSize = new System.Drawing.Size(584, 462);
            this.Controls.Add(this.gpHighQuery);
            this.Controls.Add(this.pnlButtom);
            this.Name = "FrmHighQuery";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "高级查询";
            this.Load += new System.EventHandler(this.FrmHighQuery_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pnlButtom)).EndInit();
            this.pnlButtom.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.gpHighQuery)).EndInit();
            this.gpHighQuery.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.gvControl)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gvData)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemComboBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemCheckEdit1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraEditors.PanelControl pnlButtom;
        private DevExpress.XtraEditors.SimpleButton btnCancel;
        private DevExpress.XtraEditors.SimpleButton btnQuery;
        private DevExpress.XtraEditors.GroupControl gpHighQuery;
        private DevExpress.XtraGrid.GridControl gvControl;
        private DevExpress.XtraGrid.Views.Grid.GridView gvData;
        private DevExpress.XtraGrid.Columns.GridColumn colFieldName;
        private DevExpress.XtraGrid.Columns.GridColumn colCondition;
        private DevExpress.XtraEditors.Repository.RepositoryItemComboBox repositoryItemComboBox1;
        private DevExpress.XtraGrid.Columns.GridColumn colFieldValue;
        private DevExpress.XtraEditors.Repository.RepositoryItemCheckEdit repositoryItemCheckEdit1;

    }
}