namespace DQS.AppViews.WarehouseIn.WarehouseInManager
{
    partial class FrmAcceptDeclinedReason
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
            this.btnOK = new DevExpress.XtraEditors.SimpleButton();
            this.lblreason = new DevExpress.XtraEditors.LabelControl();
            this.txtreason = new DevExpress.XtraEditors.TextEdit();
            this.txthandle = new DevExpress.XtraEditors.TextEdit();
            this.lblhandle = new DevExpress.XtraEditors.LabelControl();
            ((System.ComponentModel.ISupportInitialize)(this.txtreason.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txthandle.Properties)).BeginInit();
            this.SuspendLayout();
            // 
            // btnOK
            // 
            this.btnOK.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnOK.Appearance.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnOK.Appearance.Options.UseFont = true;
            this.btnOK.Location = new System.Drawing.Point(283, 165);
            this.btnOK.Name = "btnOK";
            this.btnOK.Size = new System.Drawing.Size(69, 23);
            this.btnOK.TabIndex = 1;
            this.btnOK.Text = "确认";
            this.btnOK.Click += new System.EventHandler(this.btnOK_Click);
            // 
            // lblreason
            // 
            this.lblreason.Location = new System.Drawing.Point(22, 50);
            this.lblreason.Name = "lblreason";
            this.lblreason.Size = new System.Drawing.Size(60, 14);
            this.lblreason.TabIndex = 9;
            this.lblreason.Text = "拒收原因：";
            // 
            // txtreason
            // 
            this.txtreason.Location = new System.Drawing.Point(88, 47);
            this.txtreason.Name = "txtreason";
            this.txtreason.Size = new System.Drawing.Size(263, 21);
            this.txtreason.TabIndex = 10;
            // 
            // txthandle
            // 
            this.txthandle.Location = new System.Drawing.Point(88, 85);
            this.txthandle.Name = "txthandle";
            this.txthandle.Size = new System.Drawing.Size(263, 21);
            this.txthandle.TabIndex = 10;
            // 
            // lblhandle
            // 
            this.lblhandle.Location = new System.Drawing.Point(22, 88);
            this.lblhandle.Name = "lblhandle";
            this.lblhandle.Size = new System.Drawing.Size(60, 14);
            this.lblhandle.TabIndex = 9;
            this.lblhandle.Text = "处理方式：";
            // 
            // FrmAcceptDeclinedReason
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 14F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(397, 210);
            this.ControlBox = false;
            this.Controls.Add(this.lblhandle);
            this.Controls.Add(this.lblreason);
            this.Controls.Add(this.btnOK);
            this.Controls.Add(this.txthandle);
            this.Controls.Add(this.txtreason);
            this.Name = "FrmAcceptDeclinedReason";
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "验收拒收原因";
            this.TopMost = true;
            ((System.ComponentModel.ISupportInitialize)(this.txtreason.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txthandle.Properties)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private DevExpress.XtraEditors.SimpleButton btnOK;
        private DevExpress.XtraEditors.LabelControl lblreason;
        private DevExpress.XtraEditors.TextEdit txtreason;
        private DevExpress.XtraEditors.TextEdit txthandle;
        private DevExpress.XtraEditors.LabelControl lblhandle;
    }
}