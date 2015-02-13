namespace DQS.AppViews.OtherOperation.Code
{
    partial class FrmCorpCodeSetting
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
            this.labelControl1 = new DevExpress.XtraEditors.LabelControl();
            this.txtCorpCode = new DevExpress.XtraEditors.TextEdit();
            this.btnSave = new DevExpress.XtraEditors.SimpleButton();
            ((System.ComponentModel.ISupportInitialize)(this.txtCorpCode.Properties)).BeginInit();
            this.SuspendLayout();
            // 
            // labelControl1
            // 
            this.labelControl1.Location = new System.Drawing.Point(30, 52);
            this.labelControl1.Name = "labelControl1";
            this.labelControl1.Size = new System.Drawing.Size(60, 14);
            this.labelControl1.TabIndex = 0;
            this.labelControl1.Text = "企业编码：";
            // 
            // txtCorpCode
            // 
            this.txtCorpCode.Location = new System.Drawing.Point(96, 49);
            this.txtCorpCode.Name = "txtCorpCode";
            this.txtCorpCode.Size = new System.Drawing.Size(238, 21);
            this.txtCorpCode.TabIndex = 1;
            // 
            // btnSave
            // 
            this.btnSave.Location = new System.Drawing.Point(148, 106);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(75, 23);
            this.btnSave.TabIndex = 2;
            this.btnSave.Text = "保存";
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // FrmCorpCodeSetting
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 14F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(381, 172);
            this.Controls.Add(this.btnSave);
            this.Controls.Add(this.txtCorpCode);
            this.Controls.Add(this.labelControl1);
            this.Name = "FrmCorpCodeSetting";
            this.ShowIcon = false;
            this.Text = "企业编码";
            this.Load += new System.EventHandler(this.FrmCorpCodeSetting_Load);
            ((System.ComponentModel.ISupportInitialize)(this.txtCorpCode.Properties)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private DevExpress.XtraEditors.LabelControl labelControl1;
        private DevExpress.XtraEditors.TextEdit txtCorpCode;
        private DevExpress.XtraEditors.SimpleButton btnSave;
    }
}