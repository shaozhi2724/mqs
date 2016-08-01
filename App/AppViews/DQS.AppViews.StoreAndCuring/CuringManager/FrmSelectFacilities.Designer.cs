namespace DQS.AppViews.StoreAndCuring.CuringManager
{
    partial class FrmSelectFacilities
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
            this.panelControl1 = new DevExpress.XtraEditors.PanelControl();
            this.panelControl2 = new DevExpress.XtraEditors.PanelControl();
            this.gridControl = new DevExpress.XtraGrid.GridControl();
            this.gridView = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.colID = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colFacilityCode = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colFacilityName = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colFacilityAddress = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colFacilitySpec = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colStyleName = new DevExpress.XtraGrid.Columns.GridColumn();
            this.btnSelect = new DevExpress.XtraEditors.SimpleButton();
            ((System.ComponentModel.ISupportInitialize)(this.panelControl1)).BeginInit();
            this.panelControl1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.panelControl2)).BeginInit();
            this.panelControl2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gridControl)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView)).BeginInit();
            this.SuspendLayout();
            // 
            // panelControl1
            // 
            this.panelControl1.Controls.Add(this.btnSelect);
            this.panelControl1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelControl1.Location = new System.Drawing.Point(0, 0);
            this.panelControl1.Name = "panelControl1";
            this.panelControl1.Size = new System.Drawing.Size(629, 55);
            this.panelControl1.TabIndex = 0;
            // 
            // panelControl2
            // 
            this.panelControl2.Controls.Add(this.gridControl);
            this.panelControl2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelControl2.Location = new System.Drawing.Point(0, 55);
            this.panelControl2.Name = "panelControl2";
            this.panelControl2.Size = new System.Drawing.Size(629, 339);
            this.panelControl2.TabIndex = 1;
            // 
            // gridControl
            // 
            this.gridControl.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gridControl.Location = new System.Drawing.Point(2, 2);
            this.gridControl.MainView = this.gridView;
            this.gridControl.Name = "gridControl";
            this.gridControl.Size = new System.Drawing.Size(625, 335);
            this.gridControl.TabIndex = 1;
            this.gridControl.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridView});
            // 
            // gridView
            // 
            this.gridView.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.colID,
            this.colFacilityCode,
            this.colFacilityName,
            this.colFacilityAddress,
            this.colFacilitySpec,
            this.colStyleName});
            this.gridView.FocusRectStyle = DevExpress.XtraGrid.Views.Grid.DrawFocusRectStyle.RowFocus;
            this.gridView.GridControl = this.gridControl;
            this.gridView.IndicatorWidth = 40;
            this.gridView.Name = "gridView";
            this.gridView.OptionsBehavior.Editable = false;
            this.gridView.OptionsNavigation.EnterMoveNextColumn = true;
            this.gridView.OptionsSelection.MultiSelect = true;
            this.gridView.OptionsView.EnableAppearanceEvenRow = true;
            this.gridView.OptionsView.ShowGroupPanel = false;
            // 
            // colID
            // 
            this.colID.Caption = "ID";
            this.colID.Name = "colID";
            this.colID.OptionsColumn.AllowEdit = false;
            this.colID.OptionsColumn.ReadOnly = true;
            // 
            // colFacilityCode
            // 
            this.colFacilityCode.Caption = "编号";
            this.colFacilityCode.FieldName = "FacilityCode";
            this.colFacilityCode.Name = "colFacilityCode";
            this.colFacilityCode.OptionsColumn.AllowEdit = false;
            this.colFacilityCode.OptionsColumn.ReadOnly = true;
            this.colFacilityCode.Visible = true;
            this.colFacilityCode.VisibleIndex = 0;
            // 
            // colFacilityName
            // 
            this.colFacilityName.Caption = "名称";
            this.colFacilityName.FieldName = "FacilityName";
            this.colFacilityName.Name = "colFacilityName";
            this.colFacilityName.OptionsColumn.AllowEdit = false;
            this.colFacilityName.OptionsColumn.ReadOnly = true;
            this.colFacilityName.Visible = true;
            this.colFacilityName.VisibleIndex = 1;
            // 
            // colFacilityAddress
            // 
            this.colFacilityAddress.Caption = "地址";
            this.colFacilityAddress.FieldName = "FacilityAddress";
            this.colFacilityAddress.Name = "colFacilityAddress";
            this.colFacilityAddress.OptionsColumn.AllowEdit = false;
            this.colFacilityAddress.OptionsColumn.ReadOnly = true;
            this.colFacilityAddress.Visible = true;
            this.colFacilityAddress.VisibleIndex = 2;
            // 
            // colFacilitySpec
            // 
            this.colFacilitySpec.Caption = "规格";
            this.colFacilitySpec.FieldName = "FacilitySpec";
            this.colFacilitySpec.Name = "colFacilitySpec";
            this.colFacilitySpec.OptionsColumn.AllowEdit = false;
            this.colFacilitySpec.OptionsColumn.ReadOnly = true;
            this.colFacilitySpec.Visible = true;
            this.colFacilitySpec.VisibleIndex = 3;
            // 
            // colStyleName
            // 
            this.colStyleName.Caption = "类型";
            this.colStyleName.FieldName = "StyleName";
            this.colStyleName.Name = "colStyleName";
            this.colStyleName.OptionsColumn.AllowEdit = false;
            this.colStyleName.OptionsColumn.ReadOnly = true;
            this.colStyleName.Visible = true;
            this.colStyleName.VisibleIndex = 4;
            // 
            // btnSelect
            // 
            this.btnSelect.Location = new System.Drawing.Point(525, 16);
            this.btnSelect.Name = "btnSelect";
            this.btnSelect.Size = new System.Drawing.Size(75, 23);
            this.btnSelect.TabIndex = 0;
            this.btnSelect.Text = "选择并关闭";
            this.btnSelect.Click += new System.EventHandler(this.btnSelect_Click);
            // 
            // FrmSelectFacilities
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 14F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(629, 394);
            this.Controls.Add(this.panelControl2);
            this.Controls.Add(this.panelControl1);
            this.Name = "FrmSelectFacilities";
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "设备选择";
            this.Load += new System.EventHandler(this.FrmSelectFacilities_Load);
            ((System.ComponentModel.ISupportInitialize)(this.panelControl1)).EndInit();
            this.panelControl1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.panelControl2)).EndInit();
            this.panelControl2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.gridControl)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraEditors.PanelControl panelControl1;
        private DevExpress.XtraEditors.PanelControl panelControl2;
        private DevExpress.XtraGrid.GridControl gridControl;
        private DevExpress.XtraGrid.Views.Grid.GridView gridView;
        private DevExpress.XtraGrid.Columns.GridColumn colID;
        private DevExpress.XtraGrid.Columns.GridColumn colFacilityCode;
        private DevExpress.XtraGrid.Columns.GridColumn colFacilityName;
        private DevExpress.XtraGrid.Columns.GridColumn colFacilityAddress;
        private DevExpress.XtraGrid.Columns.GridColumn colFacilitySpec;
        private DevExpress.XtraGrid.Columns.GridColumn colStyleName;
        private DevExpress.XtraEditors.SimpleButton btnSelect;

    }
}