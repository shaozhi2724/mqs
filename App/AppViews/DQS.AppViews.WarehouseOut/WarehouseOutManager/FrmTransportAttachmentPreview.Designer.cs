namespace DQS.AppViews.WarehouseOut.WarehouseOutManager
{
    partial class FrmTransportAttachmentPreview
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
            this.picAttachment = new DevExpress.XtraEditors.PictureEdit();
            ((System.ComponentModel.ISupportInitialize)(this.picAttachment.Properties)).BeginInit();
            this.SuspendLayout();
            // 
            // picAttachment
            // 
            this.picAttachment.Dock = System.Windows.Forms.DockStyle.Fill;
            this.picAttachment.Location = new System.Drawing.Point(0, 0);
            this.picAttachment.Name = "picAttachment";
            this.picAttachment.Properties.SizeMode = DevExpress.XtraEditors.Controls.PictureSizeMode.Stretch;
            this.picAttachment.Size = new System.Drawing.Size(930, 605);
            this.picAttachment.TabIndex = 0;
            // 
            // FrmAttachmentPreview
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 14F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(930, 605);
            this.Controls.Add(this.picAttachment);
            this.MinimizeBox = false;
            this.Name = "FrmAttachmentPreview";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "附件预览";
            this.Load += new System.EventHandler(this.FrmReceiveAttachmentPreview_Load);
            ((System.ComponentModel.ISupportInitialize)(this.picAttachment.Properties)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraEditors.PictureEdit picAttachment;
    }
}