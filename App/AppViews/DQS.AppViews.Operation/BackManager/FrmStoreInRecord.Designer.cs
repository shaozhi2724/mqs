namespace DQS.AppViews.Operation.BackManager
{
    partial class FrmStoreInRecord
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
            this.gpcCenter = new DevExpress.XtraEditors.GroupControl();
            this.gvDetails = new DQS.Controls.StandardGrid();
            this.gpcTop = new DevExpress.XtraEditors.GroupControl();
            this.gvBill = new DQS.Controls.StandardGrid();
            ((System.ComponentModel.ISupportInitialize)(this.gpcCenter)).BeginInit();
            this.gpcCenter.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gvDetails)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gpcTop)).BeginInit();
            this.gpcTop.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gvBill)).BeginInit();
            this.SuspendLayout();
            // 
            // gpcCenter
            // 
            this.gpcCenter.Controls.Add(this.gvDetails);
            this.gpcCenter.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gpcCenter.Location = new System.Drawing.Point(0, 213);
            this.gpcCenter.Name = "gpcCenter";
            this.gpcCenter.Size = new System.Drawing.Size(782, 269);
            this.gpcCenter.TabIndex = 4;
            this.gpcCenter.Text = "记录明细";
            // 
            // gvDetails
            // 
            this.gvDetails.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gvDetails.Filter = null;
            this.gvDetails.Location = new System.Drawing.Point(2, 23);
            this.gvDetails.Name = "gvDetails";
            this.gvDetails.Size = new System.Drawing.Size(778, 244);
            this.gvDetails.TabIndex = 0;
            this.gvDetails.ViewName = null;
            this.gvDetails.DoubleClick += new System.EventHandler(this.gvDetails_DoubleClick);
            // 
            // gpcTop
            // 
            this.gpcTop.Controls.Add(this.gvBill);
            this.gpcTop.Dock = System.Windows.Forms.DockStyle.Top;
            this.gpcTop.Location = new System.Drawing.Point(0, 0);
            this.gpcTop.Name = "gpcTop";
            this.gpcTop.Size = new System.Drawing.Size(782, 213);
            this.gpcTop.TabIndex = 3;
            this.gpcTop.Text = "记录单据";
            // 
            // gvBill
            // 
            this.gvBill.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gvBill.Filter = null;
            this.gvBill.Location = new System.Drawing.Point(2, 23);
            this.gvBill.Name = "gvBill";
            this.gvBill.Size = new System.Drawing.Size(778, 188);
            this.gvBill.TabIndex = 0;
            this.gvBill.ViewName = null;
            // 
            // FrmStoreInRecord
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 14F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(782, 482);
            this.Controls.Add(this.gpcCenter);
            this.Controls.Add(this.gpcTop);
            this.Name = "FrmStoreInRecord";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "入库记录";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.FrmStoreInRecord_Load);
            ((System.ComponentModel.ISupportInitialize)(this.gpcCenter)).EndInit();
            this.gpcCenter.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.gvDetails)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gpcTop)).EndInit();
            this.gpcTop.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.gvBill)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraEditors.GroupControl gpcCenter;
        private Controls.StandardGrid gvDetails;
        private DevExpress.XtraEditors.GroupControl gpcTop;
        private Controls.StandardGrid gvBill;
    }
}