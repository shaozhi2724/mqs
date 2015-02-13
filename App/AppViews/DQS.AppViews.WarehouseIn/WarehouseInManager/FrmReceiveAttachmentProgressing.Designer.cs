namespace DQS.AppViews.WarehouseIn.WarehouseInManager
{
    partial class FrmReceiveAttachmentProgressing
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
            this.components = new System.ComponentModel.Container();
            this.picProgressing = new DevExpress.XtraEditors.PictureEdit();
            this.lblProgressing = new DevExpress.XtraEditors.LabelControl();
            this.timer = new System.Windows.Forms.Timer(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.picProgressing.Properties)).BeginInit();
            this.SuspendLayout();
            // 
            // picProgressing
            // 
            this.picProgressing.EditValue = global::DQS.AppViews.WarehouseIn.Properties.Resources.blue_loading;
            this.picProgressing.Location = new System.Drawing.Point(187, 1);
            this.picProgressing.Name = "picProgressing";
            this.picProgressing.Properties.Appearance.BackColor = System.Drawing.Color.Transparent;
            this.picProgressing.Properties.Appearance.Options.UseBackColor = true;
            this.picProgressing.Properties.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.NoBorder;
            this.picProgressing.Size = new System.Drawing.Size(50, 44);
            this.picProgressing.TabIndex = 0;
            // 
            // lblProgressing
            // 
            this.lblProgressing.Location = new System.Drawing.Point(170, 48);
            this.lblProgressing.Name = "lblProgressing";
            this.lblProgressing.Size = new System.Drawing.Size(72, 14);
            this.lblProgressing.TabIndex = 1;
            this.lblProgressing.Text = "文件正在上传";
            // 
            // timer
            // 
            this.timer.Enabled = true;
            this.timer.Interval = 1000;
            this.timer.Tick += new System.EventHandler(this.timer_Tick);
            // 
            // FrmProgressing
            // 
            this.Appearance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(227)))), ((int)(((byte)(241)))), ((int)(((byte)(254)))));
            this.Appearance.Options.UseBackColor = true;
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 14F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(413, 71);
            this.Controls.Add(this.lblProgressing);
            this.Controls.Add(this.picProgressing);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FrmProgressing";
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "FrmProgressing";
            this.TransparencyKey = System.Drawing.Color.FromArgb(((int)(((byte)(227)))), ((int)(((byte)(241)))), ((int)(((byte)(254)))));
            this.Load += new System.EventHandler(this.FrmProgressing_Load);
            ((System.ComponentModel.ISupportInitialize)(this.picProgressing.Properties)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private DevExpress.XtraEditors.PictureEdit picProgressing;
        private DevExpress.XtraEditors.LabelControl lblProgressing;
        private System.Windows.Forms.Timer timer;
    }
}