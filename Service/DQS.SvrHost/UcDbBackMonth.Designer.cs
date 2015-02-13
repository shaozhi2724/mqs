namespace DQS.SvrHost
{
    partial class UcDbBackMonth
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.speMonth = new DevExpress.XtraEditors.SpinEdit();
            this.labelControl2 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl1 = new DevExpress.XtraEditors.LabelControl();
            this.speDays = new DevExpress.XtraEditors.SpinEdit();
            this.labelControl3 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl4 = new DevExpress.XtraEditors.LabelControl();
            ((System.ComponentModel.ISupportInitialize)(this.speMonth.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.speDays.Properties)).BeginInit();
            this.SuspendLayout();
            // 
            // speMonth
            // 
            this.speMonth.EditValue = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.speMonth.Location = new System.Drawing.Point(127, 9);
            this.speMonth.Name = "speMonth";
            this.speMonth.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton()});
            this.speMonth.Properties.IsFloatValue = false;
            this.speMonth.Properties.Mask.EditMask = "N00";
            this.speMonth.Properties.MaxValue = new decimal(new int[] {
            12,
            0,
            0,
            0});
            this.speMonth.Properties.MinValue = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.speMonth.Size = new System.Drawing.Size(71, 21);
            this.speMonth.TabIndex = 7;
            this.speMonth.EditValueChanged += new System.EventHandler(this.speInterval_EditValueChanged);
            // 
            // labelControl2
            // 
            this.labelControl2.Location = new System.Drawing.Point(204, 12);
            this.labelControl2.Name = "labelControl2";
            this.labelControl2.Size = new System.Drawing.Size(36, 14);
            this.labelControl2.TabIndex = 6;
            this.labelControl2.Text = "月，第";
            // 
            // labelControl1
            // 
            this.labelControl1.Location = new System.Drawing.Point(24, 12);
            this.labelControl1.Name = "labelControl1";
            this.labelControl1.Size = new System.Drawing.Size(70, 14);
            this.labelControl1.TabIndex = 5;
            this.labelControl1.Text = "执行间隔(&V):";
            // 
            // speDays
            // 
            this.speDays.EditValue = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.speDays.Location = new System.Drawing.Point(246, 9);
            this.speDays.Name = "speDays";
            this.speDays.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton()});
            this.speDays.Properties.IsFloatValue = false;
            this.speDays.Properties.Mask.EditMask = "N00";
            this.speDays.Properties.MaxValue = new decimal(new int[] {
            31,
            0,
            0,
            0});
            this.speDays.Properties.MinValue = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.speDays.Size = new System.Drawing.Size(71, 21);
            this.speDays.TabIndex = 7;
            this.speDays.EditValueChanged += new System.EventHandler(this.speInterval_EditValueChanged);
            // 
            // labelControl3
            // 
            this.labelControl3.Location = new System.Drawing.Point(323, 12);
            this.labelControl3.Name = "labelControl3";
            this.labelControl3.Size = new System.Drawing.Size(12, 14);
            this.labelControl3.TabIndex = 6;
            this.labelControl3.Text = "天";
            // 
            // labelControl4
            // 
            this.labelControl4.Location = new System.Drawing.Point(109, 12);
            this.labelControl4.Name = "labelControl4";
            this.labelControl4.Size = new System.Drawing.Size(12, 14);
            this.labelControl4.TabIndex = 8;
            this.labelControl4.Text = "每";
            // 
            // UcDbBackMonth
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 14F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.labelControl4);
            this.Controls.Add(this.speDays);
            this.Controls.Add(this.speMonth);
            this.Controls.Add(this.labelControl3);
            this.Controls.Add(this.labelControl2);
            this.Controls.Add(this.labelControl1);
            this.Name = "UcDbBackMonth";
            this.Size = new System.Drawing.Size(397, 40);
            this.ParentChanged += new System.EventHandler(this.UcDbBackMonth_ParentChanged);
            ((System.ComponentModel.ISupportInitialize)(this.speMonth.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.speDays.Properties)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private DevExpress.XtraEditors.SpinEdit speMonth;
        private DevExpress.XtraEditors.LabelControl labelControl2;
        private DevExpress.XtraEditors.LabelControl labelControl1;
        private DevExpress.XtraEditors.SpinEdit speDays;
        private DevExpress.XtraEditors.LabelControl labelControl3;
        private DevExpress.XtraEditors.LabelControl labelControl4;
    }
}
