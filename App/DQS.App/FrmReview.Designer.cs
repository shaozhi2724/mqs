namespace DQS.App
{
    partial class FrmReview
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
            this.labelControl3 = new DevExpress.XtraEditors.LabelControl();
            this.btnRepair = new DevExpress.XtraEditors.SimpleButton();
            this.txtBillCode = new DevExpress.XtraEditors.MemoEdit();
            ((System.ComponentModel.ISupportInitialize)(this.txtBillCode.Properties)).BeginInit();
            this.SuspendLayout();
            // 
            // labelControl3
            // 
            this.labelControl3.Appearance.Font = new System.Drawing.Font("黑体", 26.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelControl3.Appearance.Options.UseFont = true;
            this.labelControl3.Location = new System.Drawing.Point(12, 68);
            this.labelControl3.Name = "labelControl3";
            this.labelControl3.Size = new System.Drawing.Size(108, 35);
            this.labelControl3.TabIndex = 10;
            this.labelControl3.Text = "单号：";
            // 
            // btnRepair
            // 
            this.btnRepair.Appearance.Font = new System.Drawing.Font("宋体", 26.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnRepair.Appearance.Options.UseFont = true;
            this.btnRepair.Location = new System.Drawing.Point(271, 149);
            this.btnRepair.Name = "btnRepair";
            this.btnRepair.Size = new System.Drawing.Size(124, 53);
            this.btnRepair.TabIndex = 8;
            this.btnRepair.Text = "修复";
            this.btnRepair.Click += new System.EventHandler(this.btnRepair_Click);
            // 
            // txtBillCode
            // 
            this.txtBillCode.EditValue = "";
            this.txtBillCode.Location = new System.Drawing.Point(133, 58);
            this.txtBillCode.Name = "txtBillCode";
            this.txtBillCode.Properties.Appearance.Font = new System.Drawing.Font("黑体", 36F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.txtBillCode.Properties.Appearance.Options.UseFont = true;
            this.txtBillCode.Properties.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.txtBillCode.Size = new System.Drawing.Size(425, 55);
            this.txtBillCode.TabIndex = 9;
            // 
            // FrmReview
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 14F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(624, 282);
            this.Controls.Add(this.labelControl3);
            this.Controls.Add(this.btnRepair);
            this.Controls.Add(this.txtBillCode);
            this.Name = "FrmReview";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "修复或删除复核记录";
            ((System.ComponentModel.ISupportInitialize)(this.txtBillCode.Properties)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private DevExpress.XtraEditors.LabelControl labelControl3;
        private DevExpress.XtraEditors.SimpleButton btnRepair;
        private DevExpress.XtraEditors.MemoEdit txtBillCode;
    }
}