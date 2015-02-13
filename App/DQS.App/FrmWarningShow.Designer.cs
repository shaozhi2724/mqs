namespace DQS.App
{
    partial class FrmWarningShow
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
            this.xtcMain = new DevExpress.XtraTab.XtraTabControl();
            this.xtbBatchWaning = new DevExpress.XtraTab.XtraTabPage();
            this.gridBatch = new DQS.Controls.StandardGrid();
            this.xtbLicenseLockWarning = new DevExpress.XtraTab.XtraTabPage();
            this.gridLicenseLock = new DQS.Controls.StandardGrid();
            this.xtbTradeLicenseLockWarning = new DevExpress.XtraTab.XtraTabPage();
            this.gridTradeLicenseLock = new DQS.Controls.StandardGrid();
            this.xtbLockWaning = new DevExpress.XtraTab.XtraTabPage();
            this.gridLock = new DQS.Controls.StandardGrid();
            this.xtbQualificationWaning = new DevExpress.XtraTab.XtraTabPage();
            this.gridQualification = new DQS.Controls.StandardGrid();
            this.xtbTransport = new DevExpress.XtraTab.XtraTabPage();
            this.gridTransport = new DQS.Controls.StandardGrid();
            ((System.ComponentModel.ISupportInitialize)(this.xtcMain)).BeginInit();
            this.xtcMain.SuspendLayout();
            this.xtbBatchWaning.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gridBatch)).BeginInit();
            this.xtbLicenseLockWarning.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gridLicenseLock)).BeginInit();
            this.xtbTradeLicenseLockWarning.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gridTradeLicenseLock)).BeginInit();
            this.xtbLockWaning.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gridLock)).BeginInit();
            this.xtbQualificationWaning.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gridQualification)).BeginInit();
            this.xtbTransport.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gridTransport)).BeginInit();
            this.SuspendLayout();
            // 
            // xtcMain
            // 
            this.xtcMain.Dock = System.Windows.Forms.DockStyle.Fill;
            this.xtcMain.Location = new System.Drawing.Point(0, 0);
            this.xtcMain.Name = "xtcMain";
            this.xtcMain.SelectedTabPage = this.xtbBatchWaning;
            this.xtcMain.Size = new System.Drawing.Size(1065, 576);
            this.xtcMain.TabIndex = 0;
            this.xtcMain.TabPages.AddRange(new DevExpress.XtraTab.XtraTabPage[] {
            this.xtbLicenseLockWarning,
            this.xtbTradeLicenseLockWarning,
            this.xtbBatchWaning,
            this.xtbLockWaning,
            this.xtbQualificationWaning,
            this.xtbTransport});
            // 
            // xtbBatchWaning
            // 
            this.xtbBatchWaning.Controls.Add(this.gridBatch);
            this.xtbBatchWaning.Name = "xtbBatchWaning";
            this.xtbBatchWaning.Size = new System.Drawing.Size(1058, 546);
            this.xtbBatchWaning.Text = "药品效期预警";
            // 
            // gridBatch
            // 
            this.gridBatch.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gridBatch.Filter = null;
            this.gridBatch.Location = new System.Drawing.Point(0, 0);
            this.gridBatch.Name = "gridBatch";
            this.gridBatch.Size = new System.Drawing.Size(1058, 546);
            this.gridBatch.TabIndex = 0;
            this.gridBatch.ViewName = null;
            // 
            // xtbLicenseLockWarning
            // 
            this.xtbLicenseLockWarning.Controls.Add(this.gridLicenseLock);
            this.xtbLicenseLockWarning.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.xtbLicenseLockWarning.Name = "xtbLicenseLockWarning";
            this.xtbLicenseLockWarning.Size = new System.Drawing.Size(1058, 546);
            this.xtbLicenseLockWarning.Text = "本企业GSP证书到期日锁定记录";
            // 
            // gridLicenseLock
            // 
            this.gridLicenseLock.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gridLicenseLock.Filter = null;
            this.gridLicenseLock.Location = new System.Drawing.Point(0, 0);
            this.gridLicenseLock.Name = "gridLicenseLock";
            this.gridLicenseLock.Size = new System.Drawing.Size(1058, 546);
            this.gridLicenseLock.TabIndex = 2;
            this.gridLicenseLock.ViewName = null;
            // 
            // xtbTradeLicenseLockWarning
            // 
            this.xtbTradeLicenseLockWarning.Controls.Add(this.gridTradeLicenseLock);
            this.xtbTradeLicenseLockWarning.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.xtbTradeLicenseLockWarning.Name = "xtbTradeLicenseLockWarning";
            this.xtbTradeLicenseLockWarning.Size = new System.Drawing.Size(1058, 546);
            this.xtbTradeLicenseLockWarning.Text = "本企业药品经营许可证到期日锁定记录";
            // 
            // gridTradeLicenseLock
            // 
            this.gridTradeLicenseLock.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gridTradeLicenseLock.Filter = null;
            this.gridTradeLicenseLock.Location = new System.Drawing.Point(0, 0);
            this.gridTradeLicenseLock.Name = "gridTradeLicenseLock";
            this.gridTradeLicenseLock.Size = new System.Drawing.Size(1058, 546);
            this.gridTradeLicenseLock.TabIndex = 3;
            this.gridTradeLicenseLock.ViewName = null;
            // 
            // xtbLockWaning
            // 
            this.xtbLockWaning.Controls.Add(this.gridLock);
            this.xtbLockWaning.Name = "xtbLockWaning";
            this.xtbLockWaning.Size = new System.Drawing.Size(1058, 546);
            this.xtbLockWaning.Text = "药品锁定预警";
            // 
            // gridLock
            // 
            this.gridLock.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gridLock.Filter = null;
            this.gridLock.Location = new System.Drawing.Point(0, 0);
            this.gridLock.Name = "gridLock";
            this.gridLock.Size = new System.Drawing.Size(1058, 546);
            this.gridLock.TabIndex = 1;
            this.gridLock.ViewName = null;
            // 
            // xtbQualificationWaning
            // 
            this.xtbQualificationWaning.Controls.Add(this.gridQualification);
            this.xtbQualificationWaning.Name = "xtbQualificationWaning";
            this.xtbQualificationWaning.Size = new System.Drawing.Size(1058, 546);
            this.xtbQualificationWaning.Text = "电子档案到期预警";
            // 
            // gridQualification
            // 
            this.gridQualification.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gridQualification.Filter = null;
            this.gridQualification.Location = new System.Drawing.Point(0, 0);
            this.gridQualification.Name = "gridQualification";
            this.gridQualification.Size = new System.Drawing.Size(1058, 546);
            this.gridQualification.TabIndex = 2;
            this.gridQualification.ViewName = null;
            // 
            // xtbTransport
            // 
            this.xtbTransport.Controls.Add(this.gridTransport);
            this.xtbTransport.Name = "xtbTransport";
            this.xtbTransport.Size = new System.Drawing.Size(1058, 546);
            this.xtbTransport.Text = "运输时限预警";
            // 
            // gridTransport
            // 
            this.gridTransport.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gridTransport.Filter = null;
            this.gridTransport.Location = new System.Drawing.Point(0, 0);
            this.gridTransport.Name = "gridTransport";
            this.gridTransport.Size = new System.Drawing.Size(1058, 546);
            this.gridTransport.TabIndex = 3;
            this.gridTransport.ViewName = null;
            // 
            // FrmWarningShow
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 14F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1065, 576);
            this.Controls.Add(this.xtcMain);
            this.Name = "FrmWarningShow";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "预警信息";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.FrmWarningShow_Load);
            ((System.ComponentModel.ISupportInitialize)(this.xtcMain)).EndInit();
            this.xtcMain.ResumeLayout(false);
            this.xtbBatchWaning.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.gridBatch)).EndInit();
            this.xtbLicenseLockWarning.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.gridLicenseLock)).EndInit();
            this.xtbTradeLicenseLockWarning.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.gridTradeLicenseLock)).EndInit();
            this.xtbLockWaning.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.gridLock)).EndInit();
            this.xtbQualificationWaning.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.gridQualification)).EndInit();
            this.xtbTransport.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.gridTransport)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraTab.XtraTabControl xtcMain;
        private DevExpress.XtraTab.XtraTabPage xtbBatchWaning;
        private DevExpress.XtraTab.XtraTabPage xtbLockWaning;
        private DevExpress.XtraTab.XtraTabPage xtbQualificationWaning;
        private DQS.Controls.StandardGrid gridBatch;
        private DQS.Controls.StandardGrid gridQualification;
        private Controls.StandardGrid gridLock;
        private DevExpress.XtraTab.XtraTabPage xtbLicenseLockWarning;
        private Controls.StandardGrid gridLicenseLock;
        private DevExpress.XtraTab.XtraTabPage xtbTradeLicenseLockWarning;
        private Controls.StandardGrid gridTradeLicenseLock;
        private DevExpress.XtraTab.XtraTabPage xtbTransport;
        private Controls.StandardGrid gridTransport;
    }
}