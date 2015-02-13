namespace DQS.Controls
{
    partial class PrintPreviewForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(PrintPreviewForm));
            this.stiViewer = new Stimulsoft.Report.Viewer.StiViewerControl();
            this.SuspendLayout();
            // 
            // stiViewer
            // 
            this.stiViewer.AllowDrop = true;
            resources.ApplyResources(this.stiViewer, "stiViewer");
            this.stiViewer.Name = "stiViewer";
            this.stiViewer.PageViewMode = Stimulsoft.Report.Viewer.StiPageViewMode.SinglePage;
            this.stiViewer.ShowCloseButton = false;
            this.stiViewer.ShowOpen = false;
            this.stiViewer.ShowPageDelete = false;
            this.stiViewer.ShowPageNew = false;
            this.stiViewer.ShowThumbsPanel = false;
            this.stiViewer.ShowZoom = true;
            this.stiViewer.ThumbsPanelEnabled = false;
            // 
            // PrintPreviewForm
            // 
            resources.ApplyResources(this, "$this");
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.stiViewer);
            this.MinimizeBox = false;
            this.Name = "PrintPreviewForm";
            this.ShowIcon = false;
            this.ShowInTaskbar = false;
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.ResumeLayout(false);

        }

        #endregion

        private Stimulsoft.Report.Viewer.StiViewerControl stiViewer;


    }
}