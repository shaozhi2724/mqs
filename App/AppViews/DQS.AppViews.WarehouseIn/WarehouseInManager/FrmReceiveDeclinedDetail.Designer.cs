namespace DQS.AppViews.WarehouseIn.WarehouseInManager
{
    partial class FrmReceiveDeclinedDetail
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
            this.lblhandle = new DevExpress.XtraEditors.LabelControl();
            this.btnOK = new DevExpress.XtraEditors.SimpleButton();
            this.txtbatchno = new DevExpress.XtraEditors.TextEdit();
            this.lblinfo = new DevExpress.XtraEditors.LabelControl();
            ((System.ComponentModel.ISupportInitialize)(this.txtbatchno.Properties)).BeginInit();
            this.SuspendLayout();
            // 
            // lblhandle
            // 
            this.lblhandle.Location = new System.Drawing.Point(42, 61);
            this.lblhandle.Name = "lblhandle";
            this.lblhandle.Size = new System.Drawing.Size(36, 14);
            this.lblhandle.TabIndex = 12;
            this.lblhandle.Text = "批号：";
            // 
            // btnOK
            // 
            this.btnOK.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnOK.Appearance.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnOK.Appearance.Options.UseFont = true;
            this.btnOK.Location = new System.Drawing.Point(302, 107);
            this.btnOK.Name = "btnOK";
            this.btnOK.Size = new System.Drawing.Size(69, 23);
            this.btnOK.TabIndex = 11;
            this.btnOK.Text = "确认";
            this.btnOK.Click += new System.EventHandler(this.btnOK_Click);
            // 
            // txtbatchno
            // 
            this.txtbatchno.Location = new System.Drawing.Point(108, 58);
            this.txtbatchno.Name = "txtbatchno";
            this.txtbatchno.Size = new System.Drawing.Size(181, 21);
            this.txtbatchno.TabIndex = 13;
            // 
            // lblinfo
            // 
            this.lblinfo.Location = new System.Drawing.Point(42, 22);
            this.lblinfo.Name = "lblinfo";
            this.lblinfo.Size = new System.Drawing.Size(31, 14);
            this.lblinfo.TabIndex = 14;
            this.lblinfo.Text = "lblinfo";
            // 
            // FrmReceiveDeclinedDetail
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 14F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(420, 154);
            this.ControlBox = false;
            this.Controls.Add(this.lblinfo);
            this.Controls.Add(this.lblhandle);
            this.Controls.Add(this.btnOK);
            this.Controls.Add(this.txtbatchno);
            this.Name = "FrmReceiveDeclinedDetail";
            this.ShowIcon = false;
            this.Text = "填写批号";
            this.Load += new System.EventHandler(this.FrmReceiveDeclinedDetail_Load);
            ((System.ComponentModel.ISupportInitialize)(this.txtbatchno.Properties)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private DevExpress.XtraEditors.LabelControl lblhandle;
        private DevExpress.XtraEditors.SimpleButton btnOK;
        private DevExpress.XtraEditors.TextEdit txtbatchno;
        private DevExpress.XtraEditors.LabelControl lblinfo;
    }
}