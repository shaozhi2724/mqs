namespace DQS.AppViews.QualityControl.PrintDesignerManager
{
    partial class FrmReceiveDesigner
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
            ((System.ComponentModel.ISupportInitialize)(this.toolBarPanel)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pnlCenter)).BeginInit();
            this.SuspendLayout();
            // 
            // toolBarPanel
            // 
            this.toolBarPanel.Size = new System.Drawing.Size(722, 28);
            // 
            // xrDesigner
            // 
            this.xrDesigner.ClientSize = new System.Drawing.Size(1920, 1028);
            this.xrDesigner.Location = new System.Drawing.Point(-8, -8);
            this.xrDesigner.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            // 
            // pnlCenter
            // 
            this.pnlCenter.Size = new System.Drawing.Size(722, 412);
            // 
            // FrmReceiveDesigner
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 14F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(722, 440);
            this.Name = "FrmReceiveDesigner";
            this.OperationName = "Receive";
            this.ReportName = "收货单";
            this.Text = "FrmReceiveDesigner";
            this.Load += new System.EventHandler(this.FrmReceiveDesigner_Load);
            ((System.ComponentModel.ISupportInitialize)(this.toolBarPanel)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pnlCenter)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
    }
}