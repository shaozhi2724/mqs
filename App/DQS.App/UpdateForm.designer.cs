namespace DQS.App
{
    partial class UpdateForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(UpdateForm));
            this.label1 = new DevExpress.XtraEditors.LabelControl();
            this.lblInfo = new DevExpress.XtraEditors.LabelControl();
            this.linkInfo = new System.Windows.Forms.LinkLabel();
            this.btnUpdate = new DevExpress.XtraEditors.SimpleButton();
            this.btnSkip = new DevExpress.XtraEditors.SimpleButton();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.Appearance.Font = new System.Drawing.Font("微软雅黑", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Appearance.Options.UseFont = true;
            this.label1.Location = new System.Drawing.Point(42, 31);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(115, 30);
            this.label1.TabIndex = 0;
            this.label1.Text = "有新的更新";
            // 
            // lblInfo
            // 
            this.lblInfo.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lblInfo.Location = new System.Drawing.Point(44, 80);
            this.lblInfo.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblInfo.Name = "lblInfo";
            this.lblInfo.Size = new System.Drawing.Size(254, 18);
            this.lblInfo.TabIndex = 1;
            this.lblInfo.Text = "有新的版本 {0} 可用，更新日期 {1}。";
            // 
            // linkInfo
            // 
            this.linkInfo.AutoSize = true;
            this.linkInfo.Location = new System.Drawing.Point(44, 173);
            this.linkInfo.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.linkInfo.Name = "linkInfo";
            this.linkInfo.Size = new System.Drawing.Size(69, 20);
            this.linkInfo.TabIndex = 2;
            this.linkInfo.TabStop = true;
            this.linkInfo.Text = "关于更新";
            this.linkInfo.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.linkInfo_LinkClicked);
            // 
            // btnUpdate
            // 
            this.btnUpdate.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnUpdate.DialogResult = System.Windows.Forms.DialogResult.OK;
            this.btnUpdate.Image = ((System.Drawing.Image)(resources.GetObject("btnUpdate.Image")));
            this.btnUpdate.ImageLocation = DevExpress.XtraEditors.ImageLocation.TopCenter;
            this.btnUpdate.Location = new System.Drawing.Point(456, 139);
            this.btnUpdate.Margin = new System.Windows.Forms.Padding(4);
            this.btnUpdate.Name = "btnUpdate";
            this.btnUpdate.Size = new System.Drawing.Size(99, 61);
            this.btnUpdate.TabIndex = 3;
            this.btnUpdate.Text = "更新";
            // 
            // btnSkip
            // 
            this.btnSkip.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnSkip.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btnSkip.Image = ((System.Drawing.Image)(resources.GetObject("btnSkip.Image")));
            this.btnSkip.ImageLocation = DevExpress.XtraEditors.ImageLocation.TopCenter;
            this.btnSkip.Location = new System.Drawing.Point(330, 140);
            this.btnSkip.Margin = new System.Windows.Forms.Padding(4);
            this.btnSkip.Name = "btnSkip";
            this.btnSkip.Size = new System.Drawing.Size(99, 61);
            this.btnSkip.TabIndex = 4;
            this.btnSkip.Text = "跳过";
            // 
            // UpdateForm
            // 
            this.AcceptButton = this.btnUpdate;
            this.Appearance.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Appearance.Options.UseFont = true;
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CancelButton = this.btnSkip;
            this.ClientSize = new System.Drawing.Size(584, 220);
            this.ControlBox = false;
            this.Controls.Add(this.btnSkip);
            this.Controls.Add(this.btnUpdate);
            this.Controls.Add(this.linkInfo);
            this.Controls.Add(this.lblInfo);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "UpdateForm";
            this.ShowIcon = false;
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "{0} {1}";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private DevExpress.XtraEditors.LabelControl label1;
        private DevExpress.XtraEditors.LabelControl lblInfo;
        private System.Windows.Forms.LinkLabel linkInfo;
        private DevExpress.XtraEditors.SimpleButton btnUpdate;
        private DevExpress.XtraEditors.SimpleButton btnSkip;
    }
}