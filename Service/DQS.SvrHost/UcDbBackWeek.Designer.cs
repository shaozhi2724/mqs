namespace DQS.SvrHost
{
    partial class UcDbBackWeek
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
            this.speWeek = new DevExpress.XtraEditors.SpinEdit();
            this.labelControl2 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl1 = new DevExpress.XtraEditors.LabelControl();
            this.checkEdit1 = new DevExpress.XtraEditors.CheckEdit();
            this.checkEdit2 = new DevExpress.XtraEditors.CheckEdit();
            this.checkEdit3 = new DevExpress.XtraEditors.CheckEdit();
            this.checkEdit4 = new DevExpress.XtraEditors.CheckEdit();
            this.checkEdit5 = new DevExpress.XtraEditors.CheckEdit();
            this.checkEdit6 = new DevExpress.XtraEditors.CheckEdit();
            this.checkEdit7 = new DevExpress.XtraEditors.CheckEdit();
            ((System.ComponentModel.ISupportInitialize)(this.speWeek.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.checkEdit1.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.checkEdit2.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.checkEdit3.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.checkEdit4.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.checkEdit5.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.checkEdit6.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.checkEdit7.Properties)).BeginInit();
            this.SuspendLayout();
            // 
            // speWeek
            // 
            this.speWeek.EditValue = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.speWeek.Location = new System.Drawing.Point(109, 9);
            this.speWeek.Name = "speWeek";
            this.speWeek.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton()});
            this.speWeek.Properties.IsFloatValue = false;
            this.speWeek.Properties.Mask.EditMask = "N00";
            this.speWeek.Properties.MaxValue = new decimal(new int[] {
            52,
            0,
            0,
            0});
            this.speWeek.Properties.MinValue = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.speWeek.Size = new System.Drawing.Size(100, 21);
            this.speWeek.TabIndex = 4;
            this.speWeek.EditValueChanged += new System.EventHandler(this.chkWeek_CheckedChanged);
            // 
            // labelControl2
            // 
            this.labelControl2.Location = new System.Drawing.Point(215, 12);
            this.labelControl2.Name = "labelControl2";
            this.labelControl2.Size = new System.Drawing.Size(36, 14);
            this.labelControl2.TabIndex = 3;
            this.labelControl2.Text = "周，在";
            // 
            // labelControl1
            // 
            this.labelControl1.Location = new System.Drawing.Point(24, 12);
            this.labelControl1.Name = "labelControl1";
            this.labelControl1.Size = new System.Drawing.Size(70, 14);
            this.labelControl1.TabIndex = 2;
            this.labelControl1.Text = "执行间隔(&V):";
            // 
            // checkEdit1
            // 
            this.checkEdit1.EditValue = true;
            this.checkEdit1.Location = new System.Drawing.Point(105, 60);
            this.checkEdit1.Name = "checkEdit1";
            this.checkEdit1.Properties.Caption = "星期日";
            this.checkEdit1.Size = new System.Drawing.Size(75, 20);
            this.checkEdit1.TabIndex = 5;
            this.checkEdit1.CheckedChanged += new System.EventHandler(this.chkWeek_CheckedChanged);
            // 
            // checkEdit2
            // 
            this.checkEdit2.Location = new System.Drawing.Point(22, 34);
            this.checkEdit2.Name = "checkEdit2";
            this.checkEdit2.Properties.Caption = "星期一";
            this.checkEdit2.Size = new System.Drawing.Size(75, 20);
            this.checkEdit2.TabIndex = 5;
            this.checkEdit2.CheckedChanged += new System.EventHandler(this.chkWeek_CheckedChanged);
            // 
            // checkEdit3
            // 
            this.checkEdit3.Location = new System.Drawing.Point(105, 34);
            this.checkEdit3.Name = "checkEdit3";
            this.checkEdit3.Properties.Caption = "星期二";
            this.checkEdit3.Size = new System.Drawing.Size(75, 20);
            this.checkEdit3.TabIndex = 5;
            this.checkEdit3.CheckedChanged += new System.EventHandler(this.chkWeek_CheckedChanged);
            // 
            // checkEdit4
            // 
            this.checkEdit4.Location = new System.Drawing.Point(188, 34);
            this.checkEdit4.Name = "checkEdit4";
            this.checkEdit4.Properties.Caption = "星期三";
            this.checkEdit4.Size = new System.Drawing.Size(75, 20);
            this.checkEdit4.TabIndex = 5;
            this.checkEdit4.CheckedChanged += new System.EventHandler(this.chkWeek_CheckedChanged);
            // 
            // checkEdit5
            // 
            this.checkEdit5.Location = new System.Drawing.Point(271, 34);
            this.checkEdit5.Name = "checkEdit5";
            this.checkEdit5.Properties.Caption = "星期四";
            this.checkEdit5.Size = new System.Drawing.Size(75, 20);
            this.checkEdit5.TabIndex = 5;
            this.checkEdit5.CheckedChanged += new System.EventHandler(this.chkWeek_CheckedChanged);
            // 
            // checkEdit6
            // 
            this.checkEdit6.Location = new System.Drawing.Point(354, 34);
            this.checkEdit6.Name = "checkEdit6";
            this.checkEdit6.Properties.Caption = "星期五";
            this.checkEdit6.Size = new System.Drawing.Size(75, 20);
            this.checkEdit6.TabIndex = 5;
            this.checkEdit6.CheckedChanged += new System.EventHandler(this.chkWeek_CheckedChanged);
            // 
            // checkEdit7
            // 
            this.checkEdit7.Location = new System.Drawing.Point(22, 60);
            this.checkEdit7.Name = "checkEdit7";
            this.checkEdit7.Properties.Caption = "星期六";
            this.checkEdit7.Size = new System.Drawing.Size(75, 20);
            this.checkEdit7.TabIndex = 5;
            this.checkEdit7.CheckedChanged += new System.EventHandler(this.chkWeek_CheckedChanged);
            // 
            // UcDbBackWeek
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 14F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.checkEdit7);
            this.Controls.Add(this.checkEdit6);
            this.Controls.Add(this.checkEdit5);
            this.Controls.Add(this.checkEdit4);
            this.Controls.Add(this.checkEdit3);
            this.Controls.Add(this.checkEdit2);
            this.Controls.Add(this.checkEdit1);
            this.Controls.Add(this.speWeek);
            this.Controls.Add(this.labelControl2);
            this.Controls.Add(this.labelControl1);
            this.Name = "UcDbBackWeek";
            this.Size = new System.Drawing.Size(472, 84);
            this.ParentChanged += new System.EventHandler(this.UcDbBackWeek_ParentChanged);
            ((System.ComponentModel.ISupportInitialize)(this.speWeek.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.checkEdit1.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.checkEdit2.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.checkEdit3.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.checkEdit4.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.checkEdit5.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.checkEdit6.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.checkEdit7.Properties)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private DevExpress.XtraEditors.SpinEdit speWeek;
        private DevExpress.XtraEditors.LabelControl labelControl2;
        private DevExpress.XtraEditors.LabelControl labelControl1;
        private DevExpress.XtraEditors.CheckEdit checkEdit1;
        private DevExpress.XtraEditors.CheckEdit checkEdit2;
        private DevExpress.XtraEditors.CheckEdit checkEdit3;
        private DevExpress.XtraEditors.CheckEdit checkEdit4;
        private DevExpress.XtraEditors.CheckEdit checkEdit5;
        private DevExpress.XtraEditors.CheckEdit checkEdit6;
        private DevExpress.XtraEditors.CheckEdit checkEdit7;
    }
}
