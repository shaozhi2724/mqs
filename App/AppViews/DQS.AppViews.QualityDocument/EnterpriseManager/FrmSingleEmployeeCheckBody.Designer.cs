namespace DQS.AppViews.QualityDocument.EnterpriseManager
{
    partial class FrmSingleEmployeeCheckBody
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
            this.layoutControl = new DevExpress.XtraLayout.LayoutControl();
            this.layoutControlGroup1 = new DevExpress.XtraLayout.LayoutControlGroup();
            this.btnCancel = new DevExpress.XtraEditors.SimpleButton();
            this.btnSave = new DevExpress.XtraEditors.SimpleButton();
            this.txtYearKey = new DevExpress.XtraEditors.TextEdit();
            this.layYearKey = new DevExpress.XtraLayout.LayoutControlItem();
            this.txtCheckGov = new DevExpress.XtraEditors.TextEdit();
            this.txtCheckProject = new DevExpress.XtraEditors.TextEdit();
            this.txtCode = new DevExpress.XtraEditors.TextEdit();
            this.layCode = new DevExpress.XtraLayout.LayoutControlItem();
            this.layCheckProject = new DevExpress.XtraLayout.LayoutControlItem();
            this.layCheckDate = new DevExpress.XtraLayout.LayoutControlItem();
            this.layCheckGov = new DevExpress.XtraLayout.LayoutControlItem();
            this.layMeasure = new DevExpress.XtraLayout.LayoutControlItem();
            this.layCheckResult = new DevExpress.XtraLayout.LayoutControlItem();
            this.layRemark = new DevExpress.XtraLayout.LayoutControlItem();
            this.txtRemark = new DevExpress.XtraEditors.MemoEdit();
            this.txtCheckResult = new DevExpress.XtraEditors.MemoEdit();
            this.txtMeasure = new DevExpress.XtraEditors.MemoEdit();
            this.txtCheckDate = new DevExpress.XtraEditors.DateEdit();
            ((System.ComponentModel.ISupportInitialize)(this.panelControl1)).BeginInit();
            this.panelControl1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControl)).BeginInit();
            this.layoutControl.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlGroup1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtYearKey.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layYearKey)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtCheckGov.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtCheckProject.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtCode.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layCode)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layCheckProject)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layCheckDate)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layCheckGov)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layMeasure)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layCheckResult)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layRemark)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtRemark.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtCheckResult.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtMeasure.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtCheckDate.Properties.VistaTimeProperties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtCheckDate.Properties)).BeginInit();
            this.SuspendLayout();
            // 
            // panelControl1
            // 
            this.panelControl1.Controls.Add(this.btnSave);
            this.panelControl1.Controls.Add(this.btnCancel);
            this.panelControl1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panelControl1.Location = new System.Drawing.Point(0, 276);
            this.panelControl1.Name = "panelControl1";
            this.panelControl1.Size = new System.Drawing.Size(598, 64);
            this.panelControl1.TabIndex = 0;
            // 
            // layoutControl
            // 
            this.layoutControl.Controls.Add(this.txtYearKey);
            this.layoutControl.Controls.Add(this.txtCheckGov);
            this.layoutControl.Controls.Add(this.txtCode);
            this.layoutControl.Controls.Add(this.txtCheckProject);
            this.layoutControl.Controls.Add(this.txtRemark);
            this.layoutControl.Controls.Add(this.txtCheckResult);
            this.layoutControl.Controls.Add(this.txtMeasure);
            this.layoutControl.Controls.Add(this.txtCheckDate);
            this.layoutControl.Dock = System.Windows.Forms.DockStyle.Fill;
            this.layoutControl.Location = new System.Drawing.Point(0, 0);
            this.layoutControl.Name = "layoutControl";
            this.layoutControl.Root = this.layoutControlGroup1;
            this.layoutControl.Size = new System.Drawing.Size(598, 276);
            this.layoutControl.TabIndex = 1;
            this.layoutControl.Text = "layoutControl1";
            // 
            // layoutControlGroup1
            // 
            this.layoutControlGroup1.CustomizationFormText = "layoutControlGroup1";
            this.layoutControlGroup1.EnableIndentsWithoutBorders = DevExpress.Utils.DefaultBoolean.True;
            this.layoutControlGroup1.GroupBordersVisible = false;
            this.layoutControlGroup1.Items.AddRange(new DevExpress.XtraLayout.BaseLayoutItem[] {
            this.layYearKey,
            this.layCode,
            this.layCheckProject,
            this.layCheckResult,
            this.layRemark,
            this.layMeasure,
            this.layCheckDate,
            this.layCheckGov});
            this.layoutControlGroup1.Location = new System.Drawing.Point(0, 0);
            this.layoutControlGroup1.Name = "layoutControlGroup1";
            this.layoutControlGroup1.Size = new System.Drawing.Size(598, 276);
            this.layoutControlGroup1.Spacing = new DevExpress.XtraLayout.Utils.Padding(0, 0, 0, 0);
            this.layoutControlGroup1.Text = "layoutControlGroup1";
            this.layoutControlGroup1.TextVisible = false;
            // 
            // btnCancel
            // 
            this.btnCancel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnCancel.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btnCancel.Location = new System.Drawing.Point(496, 27);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(75, 23);
            this.btnCancel.TabIndex = 0;
            this.btnCancel.Text = "取消";
            // 
            // btnSave
            // 
            this.btnSave.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnSave.Location = new System.Drawing.Point(398, 27);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(75, 23);
            this.btnSave.TabIndex = 0;
            this.btnSave.Text = "保存";
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // txtYearKey
            // 
            this.txtYearKey.Location = new System.Drawing.Point(64, 12);
            this.txtYearKey.Name = "txtYearKey";
            this.txtYearKey.Properties.NullValuePromptShowForEmptyValue = true;
            this.txtYearKey.Size = new System.Drawing.Size(226, 21);
            this.txtYearKey.StyleController = this.layoutControl;
            this.txtYearKey.TabIndex = 1;
            this.txtYearKey.Tag = "年度";
            // 
            // layYearKey
            // 
            this.layYearKey.Control = this.txtYearKey;
            this.layYearKey.CustomizationFormText = "年度";
            this.layYearKey.Location = new System.Drawing.Point(0, 0);
            this.layYearKey.Name = "layYearKey";
            this.layYearKey.Size = new System.Drawing.Size(282, 25);
            this.layYearKey.Text = "年度";
            this.layYearKey.TextSize = new System.Drawing.Size(48, 14);
            // 
            // txtCheckGov
            // 
            this.txtCheckGov.Location = new System.Drawing.Point(346, 37);
            this.txtCheckGov.Name = "txtCheckGov";
            this.txtCheckGov.Properties.NullValuePromptShowForEmptyValue = true;
            this.txtCheckGov.Size = new System.Drawing.Size(240, 21);
            this.txtCheckGov.StyleController = this.layoutControl;
            this.txtCheckGov.TabIndex = 1;
            this.txtCheckGov.Tag = "检查机构";
            // 
            // txtCheckProject
            // 
            this.txtCheckProject.Location = new System.Drawing.Point(64, 37);
            this.txtCheckProject.Name = "txtCheckProject";
            this.txtCheckProject.Properties.NullValuePromptShowForEmptyValue = true;
            this.txtCheckProject.Size = new System.Drawing.Size(226, 21);
            this.txtCheckProject.StyleController = this.layoutControl;
            this.txtCheckProject.TabIndex = 1;
            this.txtCheckProject.Tag = "检查项目";
            // 
            // txtCode
            // 
            this.txtCode.Location = new System.Drawing.Point(346, 12);
            this.txtCode.Name = "txtCode";
            this.txtCode.Properties.NullValuePromptShowForEmptyValue = true;
            this.txtCode.Size = new System.Drawing.Size(88, 21);
            this.txtCode.StyleController = this.layoutControl;
            this.txtCode.TabIndex = 1;
            this.txtCode.Tag = "编号";
            // 
            // layCode
            // 
            this.layCode.Control = this.txtCode;
            this.layCode.CustomizationFormText = "编号";
            this.layCode.Location = new System.Drawing.Point(282, 0);
            this.layCode.Name = "layCode";
            this.layCode.Size = new System.Drawing.Size(144, 25);
            this.layCode.Text = "编号";
            this.layCode.TextSize = new System.Drawing.Size(48, 14);
            // 
            // layCheckProject
            // 
            this.layCheckProject.Control = this.txtCheckProject;
            this.layCheckProject.CustomizationFormText = "检查项目";
            this.layCheckProject.Location = new System.Drawing.Point(0, 25);
            this.layCheckProject.Name = "layCheckProject";
            this.layCheckProject.Size = new System.Drawing.Size(282, 25);
            this.layCheckProject.Text = "检查项目";
            this.layCheckProject.TextSize = new System.Drawing.Size(48, 14);
            // 
            // layCheckDate
            // 
            this.layCheckDate.Control = this.txtCheckDate;
            this.layCheckDate.CustomizationFormText = "检查日期";
            this.layCheckDate.Location = new System.Drawing.Point(426, 0);
            this.layCheckDate.Name = "layCheckDate";
            this.layCheckDate.Size = new System.Drawing.Size(152, 25);
            this.layCheckDate.Text = "检查日期";
            this.layCheckDate.TextSize = new System.Drawing.Size(48, 14);
            // 
            // layCheckGov
            // 
            this.layCheckGov.Control = this.txtCheckGov;
            this.layCheckGov.CustomizationFormText = "检查机构";
            this.layCheckGov.Location = new System.Drawing.Point(282, 25);
            this.layCheckGov.Name = "layCheckGov";
            this.layCheckGov.Size = new System.Drawing.Size(296, 25);
            this.layCheckGov.Text = "检查机构";
            this.layCheckGov.TextSize = new System.Drawing.Size(48, 14);
            // 
            // layMeasure
            // 
            this.layMeasure.Control = this.txtMeasure;
            this.layMeasure.CustomizationFormText = "采取措施";
            this.layMeasure.Location = new System.Drawing.Point(0, 50);
            this.layMeasure.Name = "layMeasure";
            this.layMeasure.Size = new System.Drawing.Size(578, 71);
            this.layMeasure.Text = "采取措施";
            this.layMeasure.TextSize = new System.Drawing.Size(48, 14);
            // 
            // layCheckResult
            // 
            this.layCheckResult.Control = this.txtCheckResult;
            this.layCheckResult.CustomizationFormText = "检查结果";
            this.layCheckResult.Location = new System.Drawing.Point(0, 121);
            this.layCheckResult.Name = "layCheckResult";
            this.layCheckResult.Size = new System.Drawing.Size(578, 67);
            this.layCheckResult.Text = "检查结果";
            this.layCheckResult.TextSize = new System.Drawing.Size(48, 14);
            // 
            // layRemark
            // 
            this.layRemark.Control = this.txtRemark;
            this.layRemark.CustomizationFormText = "备注";
            this.layRemark.Location = new System.Drawing.Point(0, 188);
            this.layRemark.Name = "layRemark";
            this.layRemark.Size = new System.Drawing.Size(578, 68);
            this.layRemark.Text = "备注";
            this.layRemark.TextSize = new System.Drawing.Size(48, 14);
            // 
            // txtRemark
            // 
            this.txtRemark.Location = new System.Drawing.Point(64, 200);
            this.txtRemark.Name = "txtRemark";
            this.txtRemark.Size = new System.Drawing.Size(522, 64);
            this.txtRemark.StyleController = this.layoutControl;
            this.txtRemark.TabIndex = 1;
            this.txtRemark.Tag = "备注";
            // 
            // txtCheckResult
            // 
            this.txtCheckResult.Location = new System.Drawing.Point(64, 133);
            this.txtCheckResult.Name = "txtCheckResult";
            this.txtCheckResult.Properties.NullValuePromptShowForEmptyValue = true;
            this.txtCheckResult.Size = new System.Drawing.Size(522, 63);
            this.txtCheckResult.StyleController = this.layoutControl;
            this.txtCheckResult.TabIndex = 1;
            this.txtCheckResult.Tag = "检查结果";
            // 
            // txtMeasure
            // 
            this.txtMeasure.Location = new System.Drawing.Point(64, 62);
            this.txtMeasure.Name = "txtMeasure";
            this.txtMeasure.Properties.NullValuePromptShowForEmptyValue = true;
            this.txtMeasure.Size = new System.Drawing.Size(522, 67);
            this.txtMeasure.StyleController = this.layoutControl;
            this.txtMeasure.TabIndex = 1;
            this.txtMeasure.Tag = "采取措施";
            // 
            // txtCheckDate
            // 
            this.txtCheckDate.EditValue = null;
            this.txtCheckDate.Location = new System.Drawing.Point(490, 12);
            this.txtCheckDate.Name = "txtCheckDate";
            this.txtCheckDate.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.txtCheckDate.Properties.Mask.EditMask = "";
            this.txtCheckDate.Properties.Mask.MaskType = DevExpress.XtraEditors.Mask.MaskType.None;
            this.txtCheckDate.Properties.NullValuePromptShowForEmptyValue = true;
            this.txtCheckDate.Properties.VistaTimeProperties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton()});
            this.txtCheckDate.Size = new System.Drawing.Size(96, 21);
            this.txtCheckDate.StyleController = this.layoutControl;
            this.txtCheckDate.TabIndex = 1;
            this.txtCheckDate.Tag = "检查日期";
            // 
            // FrmSingleEmployeeCheckBody
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 14F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(598, 340);
            this.Controls.Add(this.layoutControl);
            this.Controls.Add(this.panelControl1);
            this.Name = "FrmSingleEmployeeCheckBody";
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "员工健康检查档案";
            this.Load += new System.EventHandler(this.FrmSingleEmployeeCheckBody_Load);
            ((System.ComponentModel.ISupportInitialize)(this.panelControl1)).EndInit();
            this.panelControl1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.layoutControl)).EndInit();
            this.layoutControl.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlGroup1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtYearKey.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layYearKey)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtCheckGov.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtCheckProject.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtCode.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layCode)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layCheckProject)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layCheckDate)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layCheckGov)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layMeasure)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layCheckResult)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layRemark)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtRemark.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtCheckResult.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtMeasure.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtCheckDate.Properties.VistaTimeProperties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtCheckDate.Properties)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraEditors.PanelControl panelControl1;
        private DevExpress.XtraLayout.LayoutControl layoutControl;
        private DevExpress.XtraLayout.LayoutControlGroup layoutControlGroup1;
        private DevExpress.XtraEditors.SimpleButton btnSave;
        private DevExpress.XtraEditors.SimpleButton btnCancel;
        private DevExpress.XtraEditors.TextEdit txtYearKey;
        private DevExpress.XtraEditors.TextEdit txtCheckGov;
        private DevExpress.XtraEditors.TextEdit txtCode;
        private DevExpress.XtraEditors.TextEdit txtCheckProject;
        private DevExpress.XtraEditors.MemoEdit txtRemark;
        private DevExpress.XtraEditors.MemoEdit txtCheckResult;
        private DevExpress.XtraEditors.MemoEdit txtMeasure;
        private DevExpress.XtraLayout.LayoutControlItem layYearKey;
        private DevExpress.XtraLayout.LayoutControlItem layCode;
        private DevExpress.XtraLayout.LayoutControlItem layCheckProject;
        private DevExpress.XtraLayout.LayoutControlItem layCheckResult;
        private DevExpress.XtraLayout.LayoutControlItem layRemark;
        private DevExpress.XtraLayout.LayoutControlItem layMeasure;
        private DevExpress.XtraLayout.LayoutControlItem layCheckDate;
        private DevExpress.XtraLayout.LayoutControlItem layCheckGov;
        private DevExpress.XtraEditors.DateEdit txtCheckDate;
    }
}