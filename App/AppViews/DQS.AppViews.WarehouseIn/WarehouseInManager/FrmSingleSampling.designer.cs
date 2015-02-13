namespace DQS.AppViews.WarehouseIn.WarehouseInManager
{
    partial class FrmSingleSampling
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
            this.pnlAction = new DevExpress.XtraEditors.PanelControl();
            this.btnCancel = new DevExpress.XtraEditors.SimpleButton();
            this.gpcCenter = new DevExpress.XtraEditors.GroupControl();
            this.popupGridSampling = new DQS.Controls.PopupGrid();
            ((System.ComponentModel.ISupportInitialize)(this.pnlAction)).BeginInit();
            this.pnlAction.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gpcCenter)).BeginInit();
            this.gpcCenter.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.popupGridSampling)).BeginInit();
            this.SuspendLayout();
            // 
            // pnlAction
            // 
            this.pnlAction.Controls.Add(this.btnCancel);
            this.pnlAction.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.pnlAction.Location = new System.Drawing.Point(0, 483);
            this.pnlAction.Name = "pnlAction";
            this.pnlAction.Size = new System.Drawing.Size(872, 48);
            this.pnlAction.TabIndex = 1;
            // 
            // btnCancel
            // 
            this.btnCancel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnCancel.Appearance.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCancel.Appearance.Options.UseFont = true;
            this.btnCancel.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btnCancel.Location = new System.Drawing.Point(783, 13);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(75, 23);
            this.btnCancel.TabIndex = 1;
            this.btnCancel.Text = "关闭(&C)";
            this.btnCancel.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // gpcCenter
            // 
            this.gpcCenter.AppearanceCaption.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gpcCenter.AppearanceCaption.Options.UseFont = true;
            this.gpcCenter.Controls.Add(this.popupGridSampling);
            this.gpcCenter.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gpcCenter.Location = new System.Drawing.Point(0, 0);
            this.gpcCenter.Name = "gpcCenter";
            this.gpcCenter.Size = new System.Drawing.Size(872, 483);
            this.gpcCenter.TabIndex = 2;
            this.gpcCenter.Text = "抽检单详细";
            // 
            // popupGridSampling
            // 
            this.popupGridSampling.Dock = System.Windows.Forms.DockStyle.Fill;
            this.popupGridSampling.IsCalculatePrice = false;
            this.popupGridSampling.Location = new System.Drawing.Point(2, 25);
            this.popupGridSampling.Name = "popupGridSampling";
            this.popupGridSampling.OperationName = "Sampling";
            this.popupGridSampling.Size = new System.Drawing.Size(868, 456);
            this.popupGridSampling.TabIndex = 4;
            // 
            // FrmSingleSampling
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 14F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CancelButton = this.btnCancel;
            this.ClientSize = new System.Drawing.Size(872, 531);
            this.Controls.Add(this.gpcCenter);
            this.Controls.Add(this.pnlAction);
            this.MinimizeBox = false;
            this.Name = "FrmSingleSampling";
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "抽检单";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.FrmSingleSampling_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pnlAction)).EndInit();
            this.pnlAction.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.gpcCenter)).EndInit();
            this.gpcCenter.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.popupGridSampling)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraEditors.PanelControl pnlAction;
        private DevExpress.XtraEditors.SimpleButton btnCancel;
        private DevExpress.XtraEditors.GroupControl gpcCenter;
        private DQS.Controls.PopupGrid popupGridSampling;
    }
}