namespace DQS.AppViews.StoreAndCuring.CuringManager
{
    partial class FrmSingleFacilitiesCuring
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
            this.btnCancel = new DevExpress.XtraEditors.SimpleButton();
            this.btnAddFacilities = new DevExpress.XtraEditors.SimpleButton();
            this.btnSave = new DevExpress.XtraEditors.SimpleButton();
            this.groupControl1 = new DevExpress.XtraEditors.GroupControl();
            this.layoutControl1 = new DevExpress.XtraLayout.LayoutControl();
            this.txtCreateUser = new DevExpress.XtraEditors.TextEdit();
            this.txtCuringName = new DevExpress.XtraEditors.TextEdit();
            this.deCuringDate = new DevExpress.XtraEditors.DateEdit();
            this.cboDepartment = new DevExpress.XtraEditors.ComboBoxEdit();
            this.layoutControlGroup1 = new DevExpress.XtraLayout.LayoutControlGroup();
            this.layCuringName = new DevExpress.XtraLayout.LayoutControlItem();
            this.layDepartment = new DevExpress.XtraLayout.LayoutControlItem();
            this.layCuringDate = new DevExpress.XtraLayout.LayoutControlItem();
            this.layCreateUser = new DevExpress.XtraLayout.LayoutControlItem();
            this.groupControl2 = new DevExpress.XtraEditors.GroupControl();
            this.gridControl = new DevExpress.XtraGrid.GridControl();
            this.gridView = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.colID = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colFacilityCode = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colFacilityName = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colFacilityAddress = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colFacilitySpec = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colStyleName = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colCuringResult = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colCuringRemark = new DevExpress.XtraGrid.Columns.GridColumn();
            ((System.ComponentModel.ISupportInitialize)(this.panelControl1)).BeginInit();
            this.panelControl1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.groupControl1)).BeginInit();
            this.groupControl1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControl1)).BeginInit();
            this.layoutControl1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.txtCreateUser.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtCuringName.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.deCuringDate.Properties.VistaTimeProperties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.deCuringDate.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cboDepartment.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlGroup1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layCuringName)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layDepartment)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layCuringDate)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layCreateUser)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.groupControl2)).BeginInit();
            this.groupControl2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gridControl)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView)).BeginInit();
            this.SuspendLayout();
            // 
            // panelControl1
            // 
            this.panelControl1.Controls.Add(this.btnCancel);
            this.panelControl1.Controls.Add(this.btnAddFacilities);
            this.panelControl1.Controls.Add(this.btnSave);
            this.panelControl1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panelControl1.Location = new System.Drawing.Point(0, 397);
            this.panelControl1.Name = "panelControl1";
            this.panelControl1.Size = new System.Drawing.Size(619, 50);
            this.panelControl1.TabIndex = 0;
            // 
            // btnCancel
            // 
            this.btnCancel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnCancel.Appearance.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCancel.Appearance.Options.UseFont = true;
            this.btnCancel.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btnCancel.Location = new System.Drawing.Point(532, 15);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(75, 23);
            this.btnCancel.TabIndex = 3;
            this.btnCancel.Text = "取消(&C)";
            // 
            // btnAddFacilities
            // 
            this.btnAddFacilities.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnAddFacilities.Appearance.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAddFacilities.Appearance.Options.UseFont = true;
            this.btnAddFacilities.Location = new System.Drawing.Point(313, 15);
            this.btnAddFacilities.Name = "btnAddFacilities";
            this.btnAddFacilities.Size = new System.Drawing.Size(104, 23);
            this.btnAddFacilities.TabIndex = 2;
            this.btnAddFacilities.Text = "添加设备信息";
            this.btnAddFacilities.Click += new System.EventHandler(this.btnAddFacilities_Click);
            // 
            // btnSave
            // 
            this.btnSave.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnSave.Appearance.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSave.Appearance.Options.UseFont = true;
            this.btnSave.Location = new System.Drawing.Point(444, 15);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(75, 23);
            this.btnSave.TabIndex = 2;
            this.btnSave.Text = "保存(&S)";
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // groupControl1
            // 
            this.groupControl1.Controls.Add(this.layoutControl1);
            this.groupControl1.Dock = System.Windows.Forms.DockStyle.Top;
            this.groupControl1.Location = new System.Drawing.Point(0, 0);
            this.groupControl1.Name = "groupControl1";
            this.groupControl1.Size = new System.Drawing.Size(619, 100);
            this.groupControl1.TabIndex = 1;
            this.groupControl1.Text = "明细";
            // 
            // layoutControl1
            // 
            this.layoutControl1.Controls.Add(this.txtCreateUser);
            this.layoutControl1.Controls.Add(this.txtCuringName);
            this.layoutControl1.Controls.Add(this.deCuringDate);
            this.layoutControl1.Controls.Add(this.cboDepartment);
            this.layoutControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.layoutControl1.Location = new System.Drawing.Point(2, 23);
            this.layoutControl1.Name = "layoutControl1";
            this.layoutControl1.Root = this.layoutControlGroup1;
            this.layoutControl1.Size = new System.Drawing.Size(615, 75);
            this.layoutControl1.TabIndex = 0;
            this.layoutControl1.Text = "layoutControl1";
            // 
            // txtCreateUser
            // 
            this.txtCreateUser.Location = new System.Drawing.Point(360, 37);
            this.txtCreateUser.Name = "txtCreateUser";
            this.txtCreateUser.Properties.ReadOnly = true;
            this.txtCreateUser.Size = new System.Drawing.Size(243, 21);
            this.txtCreateUser.StyleController = this.layoutControl1;
            this.txtCreateUser.TabIndex = 4;
            // 
            // txtCuringName
            // 
            this.txtCuringName.Location = new System.Drawing.Point(63, 12);
            this.txtCuringName.Name = "txtCuringName";
            this.txtCuringName.Size = new System.Drawing.Size(242, 21);
            this.txtCuringName.StyleController = this.layoutControl1;
            this.txtCuringName.TabIndex = 4;
            // 
            // deCuringDate
            // 
            this.deCuringDate.EditValue = null;
            this.deCuringDate.Location = new System.Drawing.Point(63, 37);
            this.deCuringDate.Name = "deCuringDate";
            this.deCuringDate.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.deCuringDate.Properties.Mask.EditMask = "";
            this.deCuringDate.Properties.Mask.MaskType = DevExpress.XtraEditors.Mask.MaskType.None;
            this.deCuringDate.Properties.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.DisableTextEditor;
            this.deCuringDate.Properties.VistaTimeProperties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton()});
            this.deCuringDate.Size = new System.Drawing.Size(242, 21);
            this.deCuringDate.StyleController = this.layoutControl1;
            this.deCuringDate.TabIndex = 4;
            // 
            // cboDepartment
            // 
            this.cboDepartment.Location = new System.Drawing.Point(360, 12);
            this.cboDepartment.Name = "cboDepartment";
            this.cboDepartment.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.cboDepartment.Size = new System.Drawing.Size(243, 21);
            this.cboDepartment.StyleController = this.layoutControl1;
            this.cboDepartment.TabIndex = 4;
            // 
            // layoutControlGroup1
            // 
            this.layoutControlGroup1.CustomizationFormText = "layoutControlGroup1";
            this.layoutControlGroup1.EnableIndentsWithoutBorders = DevExpress.Utils.DefaultBoolean.True;
            this.layoutControlGroup1.GroupBordersVisible = false;
            this.layoutControlGroup1.Items.AddRange(new DevExpress.XtraLayout.BaseLayoutItem[] {
            this.layCuringName,
            this.layDepartment,
            this.layCuringDate,
            this.layCreateUser});
            this.layoutControlGroup1.Location = new System.Drawing.Point(0, 0);
            this.layoutControlGroup1.Name = "layoutControlGroup1";
            this.layoutControlGroup1.Size = new System.Drawing.Size(615, 75);
            this.layoutControlGroup1.Spacing = new DevExpress.XtraLayout.Utils.Padding(0, 0, 0, 0);
            this.layoutControlGroup1.Text = "layoutControlGroup1";
            this.layoutControlGroup1.TextVisible = false;
            // 
            // layCuringName
            // 
            this.layCuringName.Control = this.txtCuringName;
            this.layCuringName.CustomizationFormText = "保养人";
            this.layCuringName.Location = new System.Drawing.Point(0, 0);
            this.layCuringName.Name = "layCuringName";
            this.layCuringName.Size = new System.Drawing.Size(297, 25);
            this.layCuringName.Text = "保养人";
            this.layCuringName.TextSize = new System.Drawing.Size(48, 14);
            // 
            // layDepartment
            // 
            this.layDepartment.Control = this.cboDepartment;
            this.layDepartment.CustomizationFormText = "填报部门";
            this.layDepartment.Location = new System.Drawing.Point(297, 0);
            this.layDepartment.Name = "layDepartment";
            this.layDepartment.Size = new System.Drawing.Size(298, 25);
            this.layDepartment.Text = "填报部门";
            this.layDepartment.TextSize = new System.Drawing.Size(48, 14);
            // 
            // layCuringDate
            // 
            this.layCuringDate.Control = this.deCuringDate;
            this.layCuringDate.CustomizationFormText = "保养日期";
            this.layCuringDate.Location = new System.Drawing.Point(0, 25);
            this.layCuringDate.Name = "layCuringDate";
            this.layCuringDate.Size = new System.Drawing.Size(297, 30);
            this.layCuringDate.Text = "保养日期";
            this.layCuringDate.TextSize = new System.Drawing.Size(48, 14);
            // 
            // layCreateUser
            // 
            this.layCreateUser.Control = this.txtCreateUser;
            this.layCreateUser.CustomizationFormText = "创建人";
            this.layCreateUser.Location = new System.Drawing.Point(297, 25);
            this.layCreateUser.Name = "layCreateUser";
            this.layCreateUser.Size = new System.Drawing.Size(298, 30);
            this.layCreateUser.Text = "创建人";
            this.layCreateUser.TextSize = new System.Drawing.Size(48, 14);
            // 
            // groupControl2
            // 
            this.groupControl2.Controls.Add(this.gridControl);
            this.groupControl2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupControl2.Location = new System.Drawing.Point(0, 100);
            this.groupControl2.Name = "groupControl2";
            this.groupControl2.Size = new System.Drawing.Size(619, 297);
            this.groupControl2.TabIndex = 2;
            this.groupControl2.Text = "设备信息";
            // 
            // gridControl
            // 
            this.gridControl.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gridControl.Location = new System.Drawing.Point(2, 23);
            this.gridControl.MainView = this.gridView;
            this.gridControl.Name = "gridControl";
            this.gridControl.Size = new System.Drawing.Size(615, 272);
            this.gridControl.TabIndex = 0;
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
            this.colStyleName,
            this.colCuringResult,
            this.colCuringRemark});
            this.gridView.GridControl = this.gridControl;
            this.gridView.IndicatorWidth = 40;
            this.gridView.Name = "gridView";
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
            // colCuringResult
            // 
            this.colCuringResult.Caption = "保养结果";
            this.colCuringResult.FieldName = "CuringResult";
            this.colCuringResult.Name = "colCuringResult";
            this.colCuringResult.Visible = true;
            this.colCuringResult.VisibleIndex = 5;
            // 
            // colCuringRemark
            // 
            this.colCuringRemark.Caption = "备注";
            this.colCuringRemark.FieldName = "CuringRemark";
            this.colCuringRemark.Name = "colCuringRemark";
            this.colCuringRemark.Visible = true;
            this.colCuringRemark.VisibleIndex = 6;
            // 
            // FrmSingleFacilitiesCuring
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 14F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(619, 447);
            this.Controls.Add(this.groupControl2);
            this.Controls.Add(this.groupControl1);
            this.Controls.Add(this.panelControl1);
            this.Name = "FrmSingleFacilitiesCuring";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "设备保养记录";
            this.Load += new System.EventHandler(this.FrmSingleFacilitiesCuring_Load);
            ((System.ComponentModel.ISupportInitialize)(this.panelControl1)).EndInit();
            this.panelControl1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.groupControl1)).EndInit();
            this.groupControl1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.layoutControl1)).EndInit();
            this.layoutControl1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.txtCreateUser.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtCuringName.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.deCuringDate.Properties.VistaTimeProperties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.deCuringDate.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cboDepartment.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlGroup1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layCuringName)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layDepartment)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layCuringDate)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layCreateUser)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.groupControl2)).EndInit();
            this.groupControl2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.gridControl)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraEditors.PanelControl panelControl1;
        private DevExpress.XtraEditors.GroupControl groupControl1;
        private DevExpress.XtraLayout.LayoutControl layoutControl1;
        private DevExpress.XtraLayout.LayoutControlGroup layoutControlGroup1;
        private DevExpress.XtraEditors.GroupControl groupControl2;
        private DevExpress.XtraGrid.GridControl gridControl;
        private DevExpress.XtraGrid.Views.Grid.GridView gridView;
        private DevExpress.XtraEditors.SimpleButton btnCancel;
        private DevExpress.XtraEditors.SimpleButton btnSave;
        private DevExpress.XtraEditors.TextEdit txtCreateUser;
        private DevExpress.XtraEditors.TextEdit txtCuringName;
        private DevExpress.XtraEditors.DateEdit deCuringDate;
        private DevExpress.XtraEditors.ComboBoxEdit cboDepartment;
        private DevExpress.XtraLayout.LayoutControlItem layCuringName;
        private DevExpress.XtraLayout.LayoutControlItem layDepartment;
        private DevExpress.XtraLayout.LayoutControlItem layCuringDate;
        private DevExpress.XtraLayout.LayoutControlItem layCreateUser;
        private DevExpress.XtraEditors.SimpleButton btnAddFacilities;
        private DevExpress.XtraGrid.Columns.GridColumn colID;
        private DevExpress.XtraGrid.Columns.GridColumn colFacilityCode;
        private DevExpress.XtraGrid.Columns.GridColumn colFacilityName;
        private DevExpress.XtraGrid.Columns.GridColumn colFacilityAddress;
        private DevExpress.XtraGrid.Columns.GridColumn colFacilitySpec;
        private DevExpress.XtraGrid.Columns.GridColumn colStyleName;
        private DevExpress.XtraGrid.Columns.GridColumn colCuringResult;
        private DevExpress.XtraGrid.Columns.GridColumn colCuringRemark;
    }
}