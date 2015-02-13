namespace DQS.AppViews.StatReport.StatManager
{
    partial class FrmReportViewer
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
            this.stiViewer = new Stimulsoft.Report.Viewer.StiViewerControl();
            this.toolBarPanel = new DQS.Controls.ToolBarPanel();
            ((System.ComponentModel.ISupportInitialize)(this.toolBarPanel)).BeginInit();
            this.SuspendLayout();
            // 
            // stiViewer
            // 
            this.stiViewer.AllowDrop = true;
            this.stiViewer.Dock = System.Windows.Forms.DockStyle.Fill;
            this.stiViewer.Font = new System.Drawing.Font("微软雅黑", 9F);
            this.stiViewer.Location = new System.Drawing.Point(0, 0);
            this.stiViewer.Name = "stiViewer";
            this.stiViewer.PageViewMode = Stimulsoft.Report.Viewer.StiPageViewMode.SinglePage;
            this.stiViewer.Report = null;
            this.stiViewer.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.stiViewer.ShowBookmarksPanel = false;
            this.stiViewer.ShowCloseButton = false;
            this.stiViewer.ShowContextMenu = false;
            this.stiViewer.ShowDotMatrixModeButton = false;
            this.stiViewer.ShowEditor = false;
            this.stiViewer.ShowFind = false;
            this.stiViewer.ShowFullScreen = false;
            this.stiViewer.ShowOpen = false;
            this.stiViewer.ShowPageDelete = false;
            this.stiViewer.ShowPageDesign = false;
            this.stiViewer.ShowPageNew = false;
            this.stiViewer.ShowPageSize = false;
            this.stiViewer.ShowPageViewMode = false;
            this.stiViewer.ShowSendEMail = false;
            this.stiViewer.ShowSendEMailDocumentFile = false;
            this.stiViewer.ShowThumbsPanel = false;
            this.stiViewer.ShowViewModeContinuous = false;
            this.stiViewer.ShowViewModeMultiplePages = false;
            this.stiViewer.ShowViewModeSinglePage = false;
            this.stiViewer.ShowZoom = false;
            this.stiViewer.ShowZoomMultiplePages = false;
            this.stiViewer.ShowZoomOnePage = false;
            this.stiViewer.ShowZoomPageWidth = false;
            this.stiViewer.ShowZoomTwoPages = false;
            this.stiViewer.Size = new System.Drawing.Size(930, 620);
            this.stiViewer.TabIndex = 4;
            this.stiViewer.ThumbsPanelEnabled = false;
            // 
            // toolBarPanel
            // 
            this.toolBarPanel.Location = new System.Drawing.Point(0, 0);
            this.toolBarPanel.Name = "toolBarPanel";
            this.toolBarPanel.Size = new System.Drawing.Size(930, 34);
            this.toolBarPanel.TabIndex = 5;
            this.toolBarPanel.Visible = false;
            // 
            // FrmReportViewer
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 18F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(930, 620);
            this.Controls.Add(this.stiViewer);
            this.Controls.Add(this.toolBarPanel);
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Name = "FrmReportViewer";
            this.Text = "FrmReportViewer";
            this.Load += new System.EventHandler(this.FrmStatReport_Load);
            ((System.ComponentModel.ISupportInitialize)(this.toolBarPanel)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Stimulsoft.Report.Viewer.StiViewerControl stiViewer;
        protected Controls.ToolBarPanel toolBarPanel;

    }
}