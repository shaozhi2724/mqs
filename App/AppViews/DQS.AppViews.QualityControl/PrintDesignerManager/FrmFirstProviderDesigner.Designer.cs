namespace DQS.AppViews.QualityControl.PrintDesignerManager
{
    partial class FrmFirstProviderDesigner
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
            this.toolBarPanel.Size = new System.Drawing.Size(756, 28);
            // 
            // xrDesigner
            // 
            this.xrDesigner.ClientSize = new System.Drawing.Size(1920, 1028);
            this.xrDesigner.Location = new System.Drawing.Point(-8, -8);
            this.xrDesigner.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            // 
            // pnlCenter
            // 
            this.pnlCenter.Size = new System.Drawing.Size(756, 413);
            // 
            // FrmFirstProviderDesigner
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 14F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(756, 441);
            this.Name = "FrmFirstProviderDesigner";
            this.OperationName = "FirstProvider";
            this.ReportName = "首营客户";
            this.Text = "FrmFirstProviderDesigner";
            this.Load += new System.EventHandler(this.FrmFirstProviderDesigner_Load);
            ((System.ComponentModel.ISupportInitialize)(this.toolBarPanel)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pnlCenter)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
    }
}