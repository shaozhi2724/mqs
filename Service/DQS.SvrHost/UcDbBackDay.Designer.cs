namespace DQS.SvrHost
{
    partial class UcDbBackDay
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
            this.labelControl1 = new DevExpress.XtraEditors.LabelControl();
            this.speDays = new DevExpress.XtraEditors.SpinEdit();
            this.labelControl2 = new DevExpress.XtraEditors.LabelControl();
            ((System.ComponentModel.ISupportInitialize)(this.speDays.Properties)).BeginInit();
            this.SuspendLayout();
            // 
            // labelControl1
            // 
            this.labelControl1.Location = new System.Drawing.Point(24, 12);
            this.labelControl1.Name = "labelControl1";
            this.labelControl1.Size = new System.Drawing.Size(70, 14);
            this.labelControl1.TabIndex = 0;
            this.labelControl1.Text = "执行间隔(&V):";
            // 
            // speDays
            // 
            this.speDays.EditValue = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.speDays.Location = new System.Drawing.Point(109, 9);
            this.speDays.Name = "speDays";
            this.speDays.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton()});
            this.speDays.Properties.IsFloatValue = false;
            this.speDays.Properties.Mask.EditMask = "N00";
            this.speDays.Properties.MaxValue = new decimal(new int[] {
            365,
            0,
            0,
            0});
            this.speDays.Properties.MinValue = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.speDays.Size = new System.Drawing.Size(100, 21);
            this.speDays.TabIndex = 1;
            this.speDays.EditValueChanged += new System.EventHandler(this.speDays_EditValueChanged);
            // 
            // labelControl2
            // 
            this.labelControl2.Location = new System.Drawing.Point(215, 12);
            this.labelControl2.Name = "labelControl2";
            this.labelControl2.Size = new System.Drawing.Size(12, 14);
            this.labelControl2.TabIndex = 0;
            this.labelControl2.Text = "天";
            // 
            // UcDbBackDay
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 14F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.speDays);
            this.Controls.Add(this.labelControl2);
            this.Controls.Add(this.labelControl1);
            this.Name = "UcDbBackDay";
            this.Size = new System.Drawing.Size(397, 40);
            this.ParentChanged += new System.EventHandler(this.UcDbBackDay_ParentChanged);
            ((System.ComponentModel.ISupportInitialize)(this.speDays.Properties)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private DevExpress.XtraEditors.LabelControl labelControl1;
        private DevExpress.XtraEditors.SpinEdit speDays;
        private DevExpress.XtraEditors.LabelControl labelControl2;
    }
}
