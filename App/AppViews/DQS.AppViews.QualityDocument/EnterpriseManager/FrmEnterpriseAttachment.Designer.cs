namespace DQS.AppViews.QualityDocument.EnterpriseManager
{
    partial class FrmEnterpriseAttachment
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
            this.barManager1 = new DevExpress.XtraBars.BarManager();
            this.bar1 = new DevExpress.XtraBars.Bar();
            this.barBtnUpAttachment = new DevExpress.XtraBars.BarButtonItem();
            this.barBtnDownAttachment = new DevExpress.XtraBars.BarButtonItem();
            this.barBtnPreview = new DevExpress.XtraBars.BarButtonItem();
            this.barDeleteAttachment = new DevExpress.XtraBars.BarButtonItem();
            this.barDockControlTop = new DevExpress.XtraBars.BarDockControl();
            this.barDockControlBottom = new DevExpress.XtraBars.BarDockControl();
            this.barDockControlLeft = new DevExpress.XtraBars.BarDockControl();
            this.barDockControlRight = new DevExpress.XtraBars.BarDockControl();
            this.gpcCenter = new DevExpress.XtraEditors.GroupControl();
            this.gridAttachmentControl = new DQS.Controls.StandardGrid();
            ((System.ComponentModel.ISupportInitialize)(this.barManager1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gpcCenter)).BeginInit();
            this.gpcCenter.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gridAttachmentControl)).BeginInit();
            this.SuspendLayout();
            // 
            // barManager1
            // 
            this.barManager1.Bars.AddRange(new DevExpress.XtraBars.Bar[] {
            this.bar1});
            this.barManager1.DockControls.Add(this.barDockControlTop);
            this.barManager1.DockControls.Add(this.barDockControlBottom);
            this.barManager1.DockControls.Add(this.barDockControlLeft);
            this.barManager1.DockControls.Add(this.barDockControlRight);
            this.barManager1.Form = this;
            this.barManager1.Items.AddRange(new DevExpress.XtraBars.BarItem[] {
            this.barBtnUpAttachment,
            this.barBtnDownAttachment,
            this.barBtnPreview,
            this.barDeleteAttachment});
            this.barManager1.MaxItemId = 9;
            // 
            // bar1
            // 
            this.bar1.BarName = "Tools";
            this.bar1.DockCol = 0;
            this.bar1.DockRow = 0;
            this.bar1.DockStyle = DevExpress.XtraBars.BarDockStyle.Top;
            this.bar1.LinksPersistInfo.AddRange(new DevExpress.XtraBars.LinkPersistInfo[] {
            new DevExpress.XtraBars.LinkPersistInfo(DevExpress.XtraBars.BarLinkUserDefines.PaintStyle, this.barBtnUpAttachment, DevExpress.XtraBars.BarItemPaintStyle.CaptionGlyph),
            new DevExpress.XtraBars.LinkPersistInfo(DevExpress.XtraBars.BarLinkUserDefines.PaintStyle, this.barBtnDownAttachment, DevExpress.XtraBars.BarItemPaintStyle.CaptionGlyph),
            new DevExpress.XtraBars.LinkPersistInfo(DevExpress.XtraBars.BarLinkUserDefines.PaintStyle, this.barBtnPreview, DevExpress.XtraBars.BarItemPaintStyle.CaptionGlyph),
            new DevExpress.XtraBars.LinkPersistInfo(DevExpress.XtraBars.BarLinkUserDefines.PaintStyle, this.barDeleteAttachment, DevExpress.XtraBars.BarItemPaintStyle.CaptionGlyph)});
            this.bar1.OptionsBar.AllowQuickCustomization = false;
            this.bar1.OptionsBar.DrawDragBorder = false;
            this.bar1.OptionsBar.UseWholeRow = true;
            this.bar1.Text = "Tools";
            // 
            // barBtnUpAttachment
            // 
            this.barBtnUpAttachment.Caption = "上传附件(&U)";
            this.barBtnUpAttachment.Glyph = global::DQS.AppViews.QualityDocument.Properties.Resources.上传;
            this.barBtnUpAttachment.Id = 3;
            this.barBtnUpAttachment.Name = "barBtnUpAttachment";
            this.barBtnUpAttachment.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.barBtnUpAttachment_ItemClick);
            // 
            // barBtnDownAttachment
            // 
            this.barBtnDownAttachment.Caption = "下载附件(&D)";
            this.barBtnDownAttachment.Glyph = global::DQS.AppViews.QualityDocument.Properties.Resources.下载;
            this.barBtnDownAttachment.Id = 4;
            this.barBtnDownAttachment.Name = "barBtnDownAttachment";
            this.barBtnDownAttachment.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.barBtnDownAttachment_ItemClick);
            // 
            // barBtnPreview
            // 
            this.barBtnPreview.Caption = "在线预览(&P)";
            this.barBtnPreview.Glyph = global::DQS.AppViews.QualityDocument.Properties.Resources.预览;
            this.barBtnPreview.Id = 5;
            this.barBtnPreview.Name = "barBtnPreview";
            this.barBtnPreview.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.barBtnPreview_ItemClick);
            // 
            // barDeleteAttachment
            // 
            this.barDeleteAttachment.Caption = "删除附件(&L)";
            this.barDeleteAttachment.Glyph = global::DQS.AppViews.QualityDocument.Properties.Resources.删除;
            this.barDeleteAttachment.Id = 6;
            this.barDeleteAttachment.Name = "barDeleteAttachment";
            this.barDeleteAttachment.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.barDeleteAttachment_ItemClick);
            // 
            // barDockControlTop
            // 
            this.barDockControlTop.Dock = System.Windows.Forms.DockStyle.Top;
            this.barDockControlTop.Location = new System.Drawing.Point(0, 0);
            this.barDockControlTop.Size = new System.Drawing.Size(1074, 26);
            // 
            // barDockControlBottom
            // 
            this.barDockControlBottom.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.barDockControlBottom.Location = new System.Drawing.Point(0, 515);
            this.barDockControlBottom.Size = new System.Drawing.Size(1074, 0);
            // 
            // barDockControlLeft
            // 
            this.barDockControlLeft.Dock = System.Windows.Forms.DockStyle.Left;
            this.barDockControlLeft.Location = new System.Drawing.Point(0, 26);
            this.barDockControlLeft.Size = new System.Drawing.Size(0, 489);
            // 
            // barDockControlRight
            // 
            this.barDockControlRight.Dock = System.Windows.Forms.DockStyle.Right;
            this.barDockControlRight.Location = new System.Drawing.Point(1074, 26);
            this.barDockControlRight.Size = new System.Drawing.Size(0, 489);
            // 
            // gpcCenter
            // 
            this.gpcCenter.Controls.Add(this.gridAttachmentControl);
            this.gpcCenter.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gpcCenter.Location = new System.Drawing.Point(0, 26);
            this.gpcCenter.Name = "gpcCenter";
            this.gpcCenter.Size = new System.Drawing.Size(1074, 489);
            this.gpcCenter.TabIndex = 10;
            this.gpcCenter.Text = "企业资质列表";
            // 
            // gridAttachmentControl
            // 
            this.gridAttachmentControl.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gridAttachmentControl.Filter = null;
            this.gridAttachmentControl.Location = new System.Drawing.Point(2, 23);
            this.gridAttachmentControl.MenuManager = this.barManager1;
            this.gridAttachmentControl.Name = "gridAttachmentControl";
            this.gridAttachmentControl.Size = new System.Drawing.Size(1070, 464);
            this.gridAttachmentControl.TabIndex = 2;
            this.gridAttachmentControl.ViewName = "vw_EnterpriseAttachment";
            // 
            // FrmEnterpriseAttachment
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 14F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1074, 515);
            this.Controls.Add(this.gpcCenter);
            this.Controls.Add(this.barDockControlLeft);
            this.Controls.Add(this.barDockControlRight);
            this.Controls.Add(this.barDockControlBottom);
            this.Controls.Add(this.barDockControlTop);
            this.MinimizeBox = false;
            this.Name = "FrmEnterpriseAttachment";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "企业资质管理器";
            this.Load += new System.EventHandler(this.FrmEnterpriseAttachment_Load);
            ((System.ComponentModel.ISupportInitialize)(this.barManager1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gpcCenter)).EndInit();
            this.gpcCenter.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.gridAttachmentControl)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraBars.BarManager barManager1;
        private DevExpress.XtraBars.Bar bar1;
        private DevExpress.XtraBars.BarDockControl barDockControlTop;
        private DevExpress.XtraBars.BarDockControl barDockControlBottom;
        private DevExpress.XtraBars.BarDockControl barDockControlLeft;
        private DevExpress.XtraBars.BarDockControl barDockControlRight;
        private DevExpress.XtraEditors.GroupControl gpcCenter;
        public DevExpress.XtraBars.BarButtonItem barBtnUpAttachment;
        public DevExpress.XtraBars.BarButtonItem barBtnDownAttachment;
        public DevExpress.XtraBars.BarButtonItem barBtnPreview;
        public DevExpress.XtraBars.BarButtonItem barDeleteAttachment;
        private DQS.Controls.StandardGrid gridAttachmentControl;
    }
}