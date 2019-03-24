namespace DQS.AppViews.OtherOperation.OtherManager
{
    partial class FrmSingleEmployeeTrainPlanDocument
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
            this.layoutControl = new DevExpress.XtraLayout.LayoutControl();
            this.txtEmployee = new DevExpress.XtraEditors.TextEdit();
            this.txtRemark = new DevExpress.XtraEditors.MemoEdit();
            this.txtCheckResult = new DevExpress.XtraEditors.MemoEdit();
            this.txtMeasure = new DevExpress.XtraEditors.MemoEdit();
            this.layoutControlGroup1 = new DevExpress.XtraLayout.LayoutControlGroup();
            this.layEmployee = new DevExpress.XtraLayout.LayoutControlItem();
            this.layCheckResult = new DevExpress.XtraLayout.LayoutControlItem();
            this.layRemark = new DevExpress.XtraLayout.LayoutControlItem();
            this.layMeasure = new DevExpress.XtraLayout.LayoutControlItem();
            this.panelControl1 = new DevExpress.XtraEditors.PanelControl();
            this.btnSave = new DevExpress.XtraEditors.SimpleButton();
            this.btnCancel = new DevExpress.XtraEditors.SimpleButton();
            this.txtDeparment = new DevExpress.XtraEditors.TextEdit();
            this.layDeparment = new DevExpress.XtraLayout.LayoutControlItem();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControl)).BeginInit();
            this.layoutControl.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.txtEmployee.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtRemark.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtCheckResult.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtMeasure.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlGroup1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layEmployee)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layCheckResult)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layRemark)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layMeasure)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.panelControl1)).BeginInit();
            this.panelControl1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.txtDeparment.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layDeparment)).BeginInit();
            this.SuspendLayout();
            // 
            // layoutControl
            // 
            this.layoutControl.Controls.Add(this.txtEmployee);
            this.layoutControl.Controls.Add(this.txtDeparment);
            this.layoutControl.Controls.Add(this.txtRemark);
            this.layoutControl.Controls.Add(this.txtCheckResult);
            this.layoutControl.Controls.Add(this.txtMeasure);
            this.layoutControl.Dock = System.Windows.Forms.DockStyle.Fill;
            this.layoutControl.Location = new System.Drawing.Point(0, 0);
            this.layoutControl.Name = "layoutControl";
            this.layoutControl.Root = this.layoutControlGroup1;
            this.layoutControl.Size = new System.Drawing.Size(660, 358);
            this.layoutControl.TabIndex = 3;
            this.layoutControl.Text = "layoutControl1";
            // 
            // txtEmployee
            // 
            this.txtEmployee.Location = new System.Drawing.Point(63, 12);
            this.txtEmployee.Name = "txtEmployee";
            this.txtEmployee.Properties.NullValuePrompt = "员工不能为空。";
            this.txtEmployee.Properties.NullValuePromptShowForEmptyValue = true;
            this.txtEmployee.Size = new System.Drawing.Size(257, 21);
            this.txtEmployee.StyleController = this.layoutControl;
            this.txtEmployee.TabIndex = 1;
            this.txtEmployee.Tag = "";
            this.txtEmployee.Click += new System.EventHandler(this.txtEmployee_Click);
            // 
            // txtRemark
            // 
            this.txtRemark.Location = new System.Drawing.Point(63, 260);
            this.txtRemark.Name = "txtRemark";
            this.txtRemark.Properties.NullValuePrompt = "备注不能为空。";
            this.txtRemark.Size = new System.Drawing.Size(585, 86);
            this.txtRemark.StyleController = this.layoutControl;
            this.txtRemark.TabIndex = 1;
            this.txtRemark.Tag = "备注";
            // 
            // txtCheckResult
            // 
            this.txtCheckResult.Location = new System.Drawing.Point(63, 37);
            this.txtCheckResult.Name = "txtCheckResult";
            this.txtCheckResult.Properties.NullValuePrompt = "检查结果不能为空。";
            this.txtCheckResult.Properties.NullValuePromptShowForEmptyValue = true;
            this.txtCheckResult.Size = new System.Drawing.Size(585, 107);
            this.txtCheckResult.StyleController = this.layoutControl;
            this.txtCheckResult.TabIndex = 1;
            this.txtCheckResult.Tag = "检查结果";
            // 
            // txtMeasure
            // 
            this.txtMeasure.Location = new System.Drawing.Point(63, 148);
            this.txtMeasure.Name = "txtMeasure";
            this.txtMeasure.Size = new System.Drawing.Size(585, 108);
            this.txtMeasure.StyleController = this.layoutControl;
            this.txtMeasure.TabIndex = 1;
            this.txtMeasure.Tag = "采取措施";
            // 
            // layoutControlGroup1
            // 
            this.layoutControlGroup1.CustomizationFormText = "layoutControlGroup1";
            this.layoutControlGroup1.EnableIndentsWithoutBorders = DevExpress.Utils.DefaultBoolean.True;
            this.layoutControlGroup1.GroupBordersVisible = false;
            this.layoutControlGroup1.Items.AddRange(new DevExpress.XtraLayout.BaseLayoutItem[] {
            this.layEmployee,
            this.layDeparment,
            this.layCheckResult,
            this.layRemark,
            this.layMeasure});
            this.layoutControlGroup1.Location = new System.Drawing.Point(0, 0);
            this.layoutControlGroup1.Name = "layoutControlGroup1";
            this.layoutControlGroup1.Size = new System.Drawing.Size(660, 358);
            this.layoutControlGroup1.Spacing = new DevExpress.XtraLayout.Utils.Padding(0, 0, 0, 0);
            this.layoutControlGroup1.Text = "layoutControlGroup1";
            this.layoutControlGroup1.TextVisible = false;
            // 
            // layEmployee
            // 
            this.layEmployee.Control = this.txtEmployee;
            this.layEmployee.CustomizationFormText = "年度";
            this.layEmployee.Location = new System.Drawing.Point(0, 0);
            this.layEmployee.Name = "layEmployee";
            this.layEmployee.Size = new System.Drawing.Size(312, 25);
            this.layEmployee.Text = "员工";
            this.layEmployee.TextSize = new System.Drawing.Size(48, 14);
            // 
            // layCheckResult
            // 
            this.layCheckResult.Control = this.txtCheckResult;
            this.layCheckResult.CustomizationFormText = "检查结果";
            this.layCheckResult.Location = new System.Drawing.Point(0, 25);
            this.layCheckResult.Name = "layCheckResult";
            this.layCheckResult.Size = new System.Drawing.Size(640, 111);
            this.layCheckResult.Text = "考核结果";
            this.layCheckResult.TextSize = new System.Drawing.Size(48, 14);
            // 
            // layRemark
            // 
            this.layRemark.Control = this.txtRemark;
            this.layRemark.CustomizationFormText = "备注";
            this.layRemark.Location = new System.Drawing.Point(0, 248);
            this.layRemark.Name = "layRemark";
            this.layRemark.Size = new System.Drawing.Size(640, 90);
            this.layRemark.Text = "备注";
            this.layRemark.TextSize = new System.Drawing.Size(48, 14);
            // 
            // layMeasure
            // 
            this.layMeasure.Control = this.txtMeasure;
            this.layMeasure.CustomizationFormText = "采取措施";
            this.layMeasure.Location = new System.Drawing.Point(0, 136);
            this.layMeasure.Name = "layMeasure";
            this.layMeasure.Size = new System.Drawing.Size(640, 112);
            this.layMeasure.Text = "采取措施";
            this.layMeasure.TextSize = new System.Drawing.Size(48, 14);
            // 
            // panelControl1
            // 
            this.panelControl1.Controls.Add(this.btnSave);
            this.panelControl1.Controls.Add(this.btnCancel);
            this.panelControl1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panelControl1.Location = new System.Drawing.Point(0, 358);
            this.panelControl1.Name = "panelControl1";
            this.panelControl1.Size = new System.Drawing.Size(660, 64);
            this.panelControl1.TabIndex = 2;
            // 
            // btnSave
            // 
            this.btnSave.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnSave.Location = new System.Drawing.Point(460, 27);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(75, 23);
            this.btnSave.TabIndex = 0;
            this.btnSave.Text = "保存";
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // btnCancel
            // 
            this.btnCancel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnCancel.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btnCancel.Location = new System.Drawing.Point(558, 27);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(75, 23);
            this.btnCancel.TabIndex = 0;
            this.btnCancel.Text = "取消";
            // 
            // txtDeparment
            // 
            this.txtDeparment.Location = new System.Drawing.Point(375, 12);
            this.txtDeparment.Name = "txtDeparment";
            this.txtDeparment.Properties.Appearance.BackColor = System.Drawing.Color.White;
            this.txtDeparment.Properties.Appearance.Options.UseBackColor = true;
            this.txtDeparment.Properties.ReadOnly = true;
            this.txtDeparment.Size = new System.Drawing.Size(273, 21);
            this.txtDeparment.StyleController = this.layoutControl;
            this.txtDeparment.TabIndex = 1;
            this.txtDeparment.Tag = "部门";
            // 
            // layDeparment
            // 
            this.layDeparment.Control = this.txtDeparment;
            this.layDeparment.CustomizationFormText = "编号";
            this.layDeparment.Location = new System.Drawing.Point(312, 0);
            this.layDeparment.Name = "layDeparment";
            this.layDeparment.Size = new System.Drawing.Size(328, 25);
            this.layDeparment.Text = "部门";
            this.layDeparment.TextSize = new System.Drawing.Size(48, 14);
            // 
            // FrmSingleEmployeeTrainPlanDocument
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 14F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(660, 422);
            this.Controls.Add(this.layoutControl);
            this.Controls.Add(this.panelControl1);
            this.Name = "FrmSingleEmployeeTrainPlanDocument";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "培训档案";
            this.Load += new System.EventHandler(this.FrmSingleEmployeeTrainPlanDocument_Load);
            ((System.ComponentModel.ISupportInitialize)(this.layoutControl)).EndInit();
            this.layoutControl.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.txtEmployee.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtRemark.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtCheckResult.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtMeasure.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlGroup1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layEmployee)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layCheckResult)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layRemark)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layMeasure)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.panelControl1)).EndInit();
            this.panelControl1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.txtDeparment.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layDeparment)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraLayout.LayoutControl layoutControl;
        private DevExpress.XtraEditors.TextEdit txtEmployee;
        private DevExpress.XtraEditors.MemoEdit txtRemark;
        private DevExpress.XtraEditors.MemoEdit txtCheckResult;
        private DevExpress.XtraEditors.MemoEdit txtMeasure;
        private DevExpress.XtraLayout.LayoutControlGroup layoutControlGroup1;
        private DevExpress.XtraLayout.LayoutControlItem layEmployee;
        private DevExpress.XtraLayout.LayoutControlItem layCheckResult;
        private DevExpress.XtraLayout.LayoutControlItem layRemark;
        private DevExpress.XtraLayout.LayoutControlItem layMeasure;
        private DevExpress.XtraEditors.PanelControl panelControl1;
        private DevExpress.XtraEditors.SimpleButton btnSave;
        private DevExpress.XtraEditors.SimpleButton btnCancel;
        private DevExpress.XtraEditors.TextEdit txtDeparment;
        private DevExpress.XtraLayout.LayoutControlItem layDeparment;
    }
}