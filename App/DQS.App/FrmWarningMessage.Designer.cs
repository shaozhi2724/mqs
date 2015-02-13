namespace DQS.App
{
    partial class FrmWarningMessage
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
            this.hleWarning = new DevExpress.XtraEditors.HyperLinkEdit();
            this.timer = new System.Windows.Forms.Timer(this.components);
            this.btnClose = new DevExpress.XtraEditors.SimpleButton();
            ((System.ComponentModel.ISupportInitialize)(this.hleWarning.Properties)).BeginInit();
            this.SuspendLayout();
            // 
            // hleWarning
            // 
            this.hleWarning.EditValue = "系统预警信息，点击查看！";
            this.hleWarning.Location = new System.Drawing.Point(19, 22);
            this.hleWarning.Name = "hleWarning";
            this.hleWarning.Properties.Appearance.BackColor = System.Drawing.Color.Transparent;
            this.hleWarning.Properties.Appearance.Font = new System.Drawing.Font("Tahoma", 14F);
            this.hleWarning.Properties.Appearance.Options.UseBackColor = true;
            this.hleWarning.Properties.Appearance.Options.UseFont = true;
            this.hleWarning.Properties.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.NoBorder;
            this.hleWarning.Size = new System.Drawing.Size(237, 27);
            this.hleWarning.TabIndex = 0;
            this.hleWarning.OpenLink += new DevExpress.XtraEditors.Controls.OpenLinkEventHandler(this.hleWarning_OpenLink);
            // 
            // timer
            // 
            this.timer.Interval = 500;
            this.timer.Tick += new System.EventHandler(this.timer_Tick);
            // 
            // btnClose
            // 
            this.btnClose.Location = new System.Drawing.Point(96, 71);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(75, 23);
            this.btnClose.TabIndex = 1;
            this.btnClose.Text = "关闭(&C)";
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // FrmWarningMessage
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 14F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(275, 106);
            this.Controls.Add(this.btnClose);
            this.Controls.Add(this.hleWarning);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FrmWarningMessage";
            this.ShowInTaskbar = false;
            this.Text = "消息框";
            this.TopMost = true;
            this.Load += new System.EventHandler(this.FrmWarningMessage_Load);
            ((System.ComponentModel.ISupportInitialize)(this.hleWarning.Properties)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraEditors.HyperLinkEdit hleWarning;
        private System.Windows.Forms.Timer timer;
        private DevExpress.XtraEditors.SimpleButton btnClose;

    }
}