namespace DQS.App
{
    partial class FrmApproveNotifications
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
            this.xtbNoProcess = new DevExpress.XtraTab.XtraTabPage();
            this.gridNotProcess = new DQS.Controls.StandardGrid();
            this.xtbProcessed = new DevExpress.XtraTab.XtraTabPage();
            this.gridProcessed = new DQS.Controls.StandardGrid();
            ((System.ComponentModel.ISupportInitialize)(this.xtcMain)).BeginInit();
            this.xtcMain.SuspendLayout();
            this.xtbNoProcess.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gridNotProcess)).BeginInit();
            this.xtbProcessed.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gridProcessed)).BeginInit();
            this.SuspendLayout();
            // 
            // xtcMain
            // 
            this.xtcMain.Dock = System.Windows.Forms.DockStyle.Fill;
            this.xtcMain.Location = new System.Drawing.Point(0, 0);
            this.xtcMain.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.xtcMain.Name = "xtcMain";
            this.xtcMain.SelectedTabPage = this.xtbNoProcess;
            this.xtcMain.Size = new System.Drawing.Size(623, 604);
            this.xtcMain.TabIndex = 1;
            this.xtcMain.TabPages.AddRange(new DevExpress.XtraTab.XtraTabPage[] {
            this.xtbNoProcess,
            this.xtbProcessed});
            this.xtcMain.SelectedPageChanged += new DevExpress.XtraTab.TabPageChangedEventHandler(this.xtcMain_SelectedPageChanged);
            // 
            // xtbNoProcess
            // 
            this.xtbNoProcess.Controls.Add(this.gridNotProcess);
            this.xtbNoProcess.Name = "xtbNoProcess";
            this.xtbNoProcess.Size = new System.Drawing.Size(616, 570);
            this.xtbNoProcess.Text = "未处理消息";
            // 
            // gridNotProcess
            // 
            this.gridNotProcess.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gridNotProcess.EmbeddedNavigator.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.gridNotProcess.Filter = null;
            this.gridNotProcess.Location = new System.Drawing.Point(0, 0);
            this.gridNotProcess.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.gridNotProcess.Name = "gridNotProcess";
            this.gridNotProcess.ServerMode = true;
            this.gridNotProcess.Size = new System.Drawing.Size(616, 570);
            this.gridNotProcess.TabIndex = 2;
            this.gridNotProcess.ViewName = null;
            // 
            // xtbProcessed
            // 
            this.xtbProcessed.Controls.Add(this.gridProcessed);
            this.xtbProcessed.Name = "xtbProcessed";
            this.xtbProcessed.Size = new System.Drawing.Size(616, 570);
            this.xtbProcessed.Text = "已处理消息";
            // 
            // gridProcessed
            // 
            this.gridProcessed.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gridProcessed.EmbeddedNavigator.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.gridProcessed.Filter = null;
            this.gridProcessed.Location = new System.Drawing.Point(0, 0);
            this.gridProcessed.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.gridProcessed.Name = "gridProcessed";
            this.gridProcessed.Size = new System.Drawing.Size(616, 570);
            this.gridProcessed.TabIndex = 3;
            this.gridProcessed.ViewName = null;
            // 
            // FrmApproveNotifications
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 18F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(623, 604);
            this.Controls.Add(this.xtcMain);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "FrmApproveNotifications";
            this.Text = "消息提醒记录";
            this.Load += new System.EventHandler(this.FrmApproveNotifications_Load);
            ((System.ComponentModel.ISupportInitialize)(this.xtcMain)).EndInit();
            this.xtcMain.ResumeLayout(false);
            this.xtbNoProcess.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.gridNotProcess)).EndInit();
            this.xtbProcessed.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.gridProcessed)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraTab.XtraTabControl xtcMain;
        private DevExpress.XtraTab.XtraTabPage xtbNoProcess;
        private Controls.StandardGrid gridNotProcess;
        private DevExpress.XtraTab.XtraTabPage xtbProcessed;
        private Controls.StandardGrid gridProcessed;

    }
}