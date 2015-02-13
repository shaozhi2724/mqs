namespace DQS.SvrHost
{
    partial class FrmDbBackPlan
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
            this.labelControl6 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl5 = new DevExpress.XtraEditors.LabelControl();
            this.panelControl2 = new DevExpress.XtraEditors.PanelControl();
            this.btnCancel = new DevExpress.XtraEditors.SimpleButton();
            this.btnOK = new DevExpress.XtraEditors.SimpleButton();
            this.panelControl3 = new DevExpress.XtraEditors.PanelControl();
            this.lblRemark = new DevExpress.XtraEditors.LabelControl();
            this.labelControl4 = new DevExpress.XtraEditors.LabelControl();
            this.groupControl1 = new DevExpress.XtraEditors.GroupControl();
            this.rdgEnd = new DevExpress.XtraEditors.RadioGroup();
            this.dtEnd = new DevExpress.XtraEditors.DateEdit();
            this.dtStart = new DevExpress.XtraEditors.DateEdit();
            this.tmeTime = new DevExpress.XtraEditors.TimeEdit();
            this.labelControl3 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl2 = new DevExpress.XtraEditors.LabelControl();
            this.gpcPlanType = new DevExpress.XtraEditors.GroupControl();
            this.cbbPlanType = new DevExpress.XtraEditors.ComboBoxEdit();
            this.labelControl1 = new DevExpress.XtraEditors.LabelControl();
            ((System.ComponentModel.ISupportInitialize)(this.panelControl1)).BeginInit();
            this.panelControl1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.panelControl2)).BeginInit();
            this.panelControl2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.panelControl3)).BeginInit();
            this.panelControl3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.groupControl1)).BeginInit();
            this.groupControl1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.rdgEnd.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dtEnd.Properties.VistaTimeProperties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dtEnd.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dtStart.Properties.VistaTimeProperties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dtStart.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tmeTime.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gpcPlanType)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cbbPlanType.Properties)).BeginInit();
            this.SuspendLayout();
            // 
            // panelControl1
            // 
            this.panelControl1.Controls.Add(this.labelControl6);
            this.panelControl1.Controls.Add(this.labelControl5);
            this.panelControl1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelControl1.Location = new System.Drawing.Point(0, 0);
            this.panelControl1.Name = "panelControl1";
            this.panelControl1.Size = new System.Drawing.Size(639, 68);
            this.panelControl1.TabIndex = 1;
            // 
            // labelControl6
            // 
            this.labelControl6.Appearance.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelControl6.Appearance.Options.UseFont = true;
            this.labelControl6.Location = new System.Drawing.Point(67, 39);
            this.labelControl6.Name = "labelControl6";
            this.labelControl6.Size = new System.Drawing.Size(156, 17);
            this.labelControl6.TabIndex = 1;
            this.labelControl6.Text = "设定数据库的备份周期及时间";
            // 
            // labelControl5
            // 
            this.labelControl5.Appearance.Font = new System.Drawing.Font("微软雅黑", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelControl5.Appearance.Options.UseFont = true;
            this.labelControl5.Location = new System.Drawing.Point(32, 12);
            this.labelControl5.Name = "labelControl5";
            this.labelControl5.Size = new System.Drawing.Size(96, 21);
            this.labelControl5.TabIndex = 0;
            this.labelControl5.Text = "备份计划信息";
            // 
            // panelControl2
            // 
            this.panelControl2.Controls.Add(this.btnCancel);
            this.panelControl2.Controls.Add(this.btnOK);
            this.panelControl2.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panelControl2.Location = new System.Drawing.Point(0, 410);
            this.panelControl2.Name = "panelControl2";
            this.panelControl2.Size = new System.Drawing.Size(639, 42);
            this.panelControl2.TabIndex = 11;
            // 
            // btnCancel
            // 
            this.btnCancel.Appearance.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCancel.Appearance.Options.UseFont = true;
            this.btnCancel.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btnCancel.Location = new System.Drawing.Point(541, 10);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(75, 23);
            this.btnCancel.TabIndex = 0;
            this.btnCancel.Text = "取消(&C)";
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // btnOK
            // 
            this.btnOK.Appearance.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnOK.Appearance.Options.UseFont = true;
            this.btnOK.Location = new System.Drawing.Point(448, 10);
            this.btnOK.Name = "btnOK";
            this.btnOK.Size = new System.Drawing.Size(75, 23);
            this.btnOK.TabIndex = 0;
            this.btnOK.Text = "确定(&O)";
            this.btnOK.Click += new System.EventHandler(this.btnOK_Click);
            // 
            // panelControl3
            // 
            this.panelControl3.Controls.Add(this.lblRemark);
            this.panelControl3.Controls.Add(this.labelControl4);
            this.panelControl3.Controls.Add(this.groupControl1);
            this.panelControl3.Controls.Add(this.gpcPlanType);
            this.panelControl3.Controls.Add(this.cbbPlanType);
            this.panelControl3.Controls.Add(this.labelControl1);
            this.panelControl3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelControl3.Location = new System.Drawing.Point(0, 68);
            this.panelControl3.Name = "panelControl3";
            this.panelControl3.Size = new System.Drawing.Size(639, 342);
            this.panelControl3.TabIndex = 12;
            // 
            // lblRemark
            // 
            this.lblRemark.Appearance.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblRemark.Appearance.Options.UseFont = true;
            this.lblRemark.Location = new System.Drawing.Point(84, 315);
            this.lblRemark.Name = "lblRemark";
            this.lblRemark.Size = new System.Drawing.Size(345, 17);
            this.lblRemark.TabIndex = 16;
            this.lblRemark.Text = "在每周 星期日 的 0:00:00 执行。将从 2013/8/2 开始使用计划。";
            // 
            // labelControl4
            // 
            this.labelControl4.Appearance.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelControl4.Appearance.Options.UseFont = true;
            this.labelControl4.Location = new System.Drawing.Point(33, 315);
            this.labelControl4.Name = "labelControl4";
            this.labelControl4.Size = new System.Drawing.Size(42, 17);
            this.labelControl4.TabIndex = 15;
            this.labelControl4.Text = "说明(&P):";
            // 
            // groupControl1
            // 
            this.groupControl1.AppearanceCaption.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupControl1.AppearanceCaption.Options.UseFont = true;
            this.groupControl1.Controls.Add(this.rdgEnd);
            this.groupControl1.Controls.Add(this.dtEnd);
            this.groupControl1.Controls.Add(this.dtStart);
            this.groupControl1.Controls.Add(this.tmeTime);
            this.groupControl1.Controls.Add(this.labelControl3);
            this.groupControl1.Controls.Add(this.labelControl2);
            this.groupControl1.Location = new System.Drawing.Point(33, 176);
            this.groupControl1.Name = "groupControl1";
            this.groupControl1.Size = new System.Drawing.Size(573, 129);
            this.groupControl1.TabIndex = 14;
            this.groupControl1.Text = "时间设定";
            // 
            // rdgEnd
            // 
            this.rdgEnd.Location = new System.Drawing.Point(286, 58);
            this.rdgEnd.Name = "rdgEnd";
            this.rdgEnd.Properties.Appearance.BackColor = System.Drawing.Color.Transparent;
            this.rdgEnd.Properties.Appearance.Options.UseBackColor = true;
            this.rdgEnd.Properties.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.NoBorder;
            this.rdgEnd.Properties.Items.AddRange(new DevExpress.XtraEditors.Controls.RadioGroupItem[] {
            new DevExpress.XtraEditors.Controls.RadioGroupItem(null, "结束日期"),
            new DevExpress.XtraEditors.Controls.RadioGroupItem(null, "无结束日期")});
            this.rdgEnd.Size = new System.Drawing.Size(100, 71);
            this.rdgEnd.TabIndex = 8;
            this.rdgEnd.SelectedIndexChanged += new System.EventHandler(this.rdgEnd_SelectedIndexChanged);
            // 
            // dtEnd
            // 
            this.dtEnd.EditValue = null;
            this.dtEnd.Location = new System.Drawing.Point(392, 66);
            this.dtEnd.Name = "dtEnd";
            this.dtEnd.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.dtEnd.Properties.VistaTimeProperties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton()});
            this.dtEnd.Size = new System.Drawing.Size(166, 21);
            this.dtEnd.TabIndex = 7;
            this.dtEnd.EditValueChanged += new System.EventHandler(this.dtEnd_EditValueChanged);
            // 
            // dtStart
            // 
            this.dtStart.EditValue = null;
            this.dtStart.Location = new System.Drawing.Point(101, 66);
            this.dtStart.Name = "dtStart";
            this.dtStart.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.dtStart.Properties.VistaTimeProperties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton()});
            this.dtStart.Size = new System.Drawing.Size(166, 21);
            this.dtStart.TabIndex = 7;
            this.dtStart.EditValueChanged += new System.EventHandler(this.dtStart_EditValueChanged);
            // 
            // tmeTime
            // 
            this.tmeTime.EditValue = new System.DateTime(2013, 8, 2, 0, 0, 0, 0);
            this.tmeTime.Location = new System.Drawing.Point(101, 31);
            this.tmeTime.Name = "tmeTime";
            this.tmeTime.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton()});
            this.tmeTime.Size = new System.Drawing.Size(166, 21);
            this.tmeTime.TabIndex = 6;
            this.tmeTime.EditValueChanged += new System.EventHandler(this.tmeTime_EditValueChanged);
            // 
            // labelControl3
            // 
            this.labelControl3.Appearance.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelControl3.Appearance.Options.UseFont = true;
            this.labelControl3.Location = new System.Drawing.Point(19, 68);
            this.labelControl3.Name = "labelControl3";
            this.labelControl3.Size = new System.Drawing.Size(68, 17);
            this.labelControl3.TabIndex = 5;
            this.labelControl3.Text = "开始日期(&D):";
            // 
            // labelControl2
            // 
            this.labelControl2.Appearance.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelControl2.Appearance.Options.UseFont = true;
            this.labelControl2.Location = new System.Drawing.Point(19, 33);
            this.labelControl2.Name = "labelControl2";
            this.labelControl2.Size = new System.Drawing.Size(67, 17);
            this.labelControl2.TabIndex = 5;
            this.labelControl2.Text = "备份时间(&A):";
            // 
            // gpcPlanType
            // 
            this.gpcPlanType.AppearanceCaption.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gpcPlanType.AppearanceCaption.Options.UseFont = true;
            this.gpcPlanType.Location = new System.Drawing.Point(33, 53);
            this.gpcPlanType.Name = "gpcPlanType";
            this.gpcPlanType.Size = new System.Drawing.Size(573, 112);
            this.gpcPlanType.TabIndex = 13;
            this.gpcPlanType.Text = "周期设定";
            // 
            // cbbPlanType
            // 
            this.cbbPlanType.EditValue = "每周";
            this.cbbPlanType.Location = new System.Drawing.Point(134, 21);
            this.cbbPlanType.Name = "cbbPlanType";
            this.cbbPlanType.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.cbbPlanType.Properties.Items.AddRange(new object[] {
            "每天",
            "每周",
            "每月"});
            this.cbbPlanType.Size = new System.Drawing.Size(166, 21);
            this.cbbPlanType.TabIndex = 12;
            this.cbbPlanType.SelectedIndexChanged += new System.EventHandler(this.cbbPlanType_SelectedIndexChanged);
            // 
            // labelControl1
            // 
            this.labelControl1.Appearance.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelControl1.Appearance.Options.UseFont = true;
            this.labelControl1.Location = new System.Drawing.Point(33, 23);
            this.labelControl1.Name = "labelControl1";
            this.labelControl1.Size = new System.Drawing.Size(66, 17);
            this.labelControl1.TabIndex = 11;
            this.labelControl1.Text = "备份周期(&S):";
            // 
            // FrmDbBackPlan
            // 
            this.AcceptButton = this.btnOK;
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 14F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CancelButton = this.btnCancel;
            this.ClientSize = new System.Drawing.Size(639, 452);
            this.Controls.Add(this.panelControl3);
            this.Controls.Add(this.panelControl2);
            this.Controls.Add(this.panelControl1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FrmDbBackPlan";
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "备份计划";
            this.Load += new System.EventHandler(this.FrmDbBackPlan_Load);
            ((System.ComponentModel.ISupportInitialize)(this.panelControl1)).EndInit();
            this.panelControl1.ResumeLayout(false);
            this.panelControl1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.panelControl2)).EndInit();
            this.panelControl2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.panelControl3)).EndInit();
            this.panelControl3.ResumeLayout(false);
            this.panelControl3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.groupControl1)).EndInit();
            this.groupControl1.ResumeLayout(false);
            this.groupControl1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.rdgEnd.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dtEnd.Properties.VistaTimeProperties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dtEnd.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dtStart.Properties.VistaTimeProperties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dtStart.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tmeTime.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gpcPlanType)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cbbPlanType.Properties)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraEditors.PanelControl panelControl1;
        private DevExpress.XtraEditors.LabelControl labelControl6;
        private DevExpress.XtraEditors.LabelControl labelControl5;
        private DevExpress.XtraEditors.PanelControl panelControl2;
        private DevExpress.XtraEditors.SimpleButton btnCancel;
        private DevExpress.XtraEditors.SimpleButton btnOK;
        private DevExpress.XtraEditors.PanelControl panelControl3;
        private DevExpress.XtraEditors.LabelControl lblRemark;
        private DevExpress.XtraEditors.LabelControl labelControl4;
        private DevExpress.XtraEditors.GroupControl groupControl1;
        private DevExpress.XtraEditors.RadioGroup rdgEnd;
        private DevExpress.XtraEditors.DateEdit dtEnd;
        private DevExpress.XtraEditors.DateEdit dtStart;
        private DevExpress.XtraEditors.TimeEdit tmeTime;
        private DevExpress.XtraEditors.LabelControl labelControl3;
        private DevExpress.XtraEditors.LabelControl labelControl2;
        private DevExpress.XtraEditors.GroupControl gpcPlanType;
        private DevExpress.XtraEditors.ComboBoxEdit cbbPlanType;
        private DevExpress.XtraEditors.LabelControl labelControl1;
    }
}