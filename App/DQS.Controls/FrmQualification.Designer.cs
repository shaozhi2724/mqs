namespace DQS.Controls
{
    partial class FrmQualification
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
            this.components = new System.ComponentModel.Container();
            this.barManager1 = new DevExpress.XtraBars.BarManager(this.components);
            this.bar1 = new DevExpress.XtraBars.Bar();
            this.barBtnNew = new DevExpress.XtraBars.BarButtonItem();
            this.barBtnModify = new DevExpress.XtraBars.BarButtonItem();
            this.barBtnDelete = new DevExpress.XtraBars.BarButtonItem();
            this.barBtnUpAttachment = new DevExpress.XtraBars.BarButtonItem();
            this.barBtnDownAttachment = new DevExpress.XtraBars.BarButtonItem();
            this.barBtnPreview = new DevExpress.XtraBars.BarButtonItem();
            this.barDeleteAttachment = new DevExpress.XtraBars.BarButtonItem();
            this.barBtnNewAttribute = new DevExpress.XtraBars.BarButtonItem();
            this.barBtnDeleteAttribute = new DevExpress.XtraBars.BarButtonItem();
            this.barDockControlTop = new DevExpress.XtraBars.BarDockControl();
            this.barDockControlBottom = new DevExpress.XtraBars.BarDockControl();
            this.barDockControlLeft = new DevExpress.XtraBars.BarDockControl();
            this.barDockControlRight = new DevExpress.XtraBars.BarDockControl();
            this.pnlButtom = new DevExpress.XtraEditors.PanelControl();
            this.gpcRight = new DevExpress.XtraEditors.GroupControl();
            this.gridAttachmentControl = new DQS.Controls.StandardGrid();
            this.splitterControl1 = new DevExpress.XtraEditors.SplitterControl();
            this.gpcLeft = new DevExpress.XtraEditors.GroupControl();
            this.gridAttributeControl = new DQS.Controls.StandardGrid();
            this.gpcCenter = new DevExpress.XtraEditors.GroupControl();
            this.gridQualificationControl = new DQS.Controls.StandardGrid();
            ((System.ComponentModel.ISupportInitialize)(this.barManager1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pnlButtom)).BeginInit();
            this.pnlButtom.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gpcRight)).BeginInit();
            this.gpcRight.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gridAttachmentControl)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gpcLeft)).BeginInit();
            this.gpcLeft.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gridAttributeControl)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gpcCenter)).BeginInit();
            this.gpcCenter.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gridQualificationControl)).BeginInit();
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
            this.barBtnNew,
            this.barBtnModify,
            this.barBtnDelete,
            this.barBtnUpAttachment,
            this.barBtnDownAttachment,
            this.barBtnPreview,
            this.barDeleteAttachment,
            this.barBtnNewAttribute,
            this.barBtnDeleteAttribute});
            this.barManager1.MaxItemId = 9;
            // 
            // bar1
            // 
            this.bar1.BarName = "Tools";
            this.bar1.DockCol = 0;
            this.bar1.DockRow = 0;
            this.bar1.DockStyle = DevExpress.XtraBars.BarDockStyle.Top;
            this.bar1.LinksPersistInfo.AddRange(new DevExpress.XtraBars.LinkPersistInfo[] {
            new DevExpress.XtraBars.LinkPersistInfo(DevExpress.XtraBars.BarLinkUserDefines.PaintStyle, this.barBtnNew, DevExpress.XtraBars.BarItemPaintStyle.CaptionGlyph),
            new DevExpress.XtraBars.LinkPersistInfo(DevExpress.XtraBars.BarLinkUserDefines.PaintStyle, this.barBtnModify, DevExpress.XtraBars.BarItemPaintStyle.CaptionGlyph),
            new DevExpress.XtraBars.LinkPersistInfo(DevExpress.XtraBars.BarLinkUserDefines.PaintStyle, this.barBtnDelete, DevExpress.XtraBars.BarItemPaintStyle.CaptionGlyph),
            new DevExpress.XtraBars.LinkPersistInfo(DevExpress.XtraBars.BarLinkUserDefines.PaintStyle, this.barBtnUpAttachment, DevExpress.XtraBars.BarItemPaintStyle.CaptionGlyph),
            new DevExpress.XtraBars.LinkPersistInfo(DevExpress.XtraBars.BarLinkUserDefines.PaintStyle, this.barBtnDownAttachment, DevExpress.XtraBars.BarItemPaintStyle.CaptionGlyph),
            new DevExpress.XtraBars.LinkPersistInfo(DevExpress.XtraBars.BarLinkUserDefines.PaintStyle, this.barBtnPreview, DevExpress.XtraBars.BarItemPaintStyle.CaptionGlyph),
            new DevExpress.XtraBars.LinkPersistInfo(DevExpress.XtraBars.BarLinkUserDefines.PaintStyle, this.barDeleteAttachment, DevExpress.XtraBars.BarItemPaintStyle.CaptionGlyph),
            new DevExpress.XtraBars.LinkPersistInfo(DevExpress.XtraBars.BarLinkUserDefines.PaintStyle, this.barBtnNewAttribute, DevExpress.XtraBars.BarItemPaintStyle.CaptionGlyph),
            new DevExpress.XtraBars.LinkPersistInfo(DevExpress.XtraBars.BarLinkUserDefines.PaintStyle, this.barBtnDeleteAttribute, DevExpress.XtraBars.BarItemPaintStyle.CaptionGlyph)});
            this.bar1.OptionsBar.AllowQuickCustomization = false;
            this.bar1.OptionsBar.DrawDragBorder = false;
            this.bar1.OptionsBar.UseWholeRow = true;
            this.bar1.Text = "Tools";
            // 
            // barBtnNew
            // 
            this.barBtnNew.Caption = "新建(&N)";
            this.barBtnNew.Glyph = global::DQS.Controls.Properties.Resources.新建__2_;
            this.barBtnNew.Id = 0;
            this.barBtnNew.Name = "barBtnNew";
            this.barBtnNew.Visibility = DevExpress.XtraBars.BarItemVisibility.Never;
            this.barBtnNew.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.barBtnNew_ItemClick);
            // 
            // barBtnModify
            // 
            this.barBtnModify.Caption = "编辑(&E)";
            this.barBtnModify.Glyph = global::DQS.Controls.Properties.Resources.编辑__2_;
            this.barBtnModify.Id = 1;
            this.barBtnModify.Name = "barBtnModify";
            this.barBtnModify.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.barBtnModify_ItemClick);
            // 
            // barBtnDelete
            // 
            this.barBtnDelete.Caption = "删除(&D)";
            this.barBtnDelete.Glyph = global::DQS.Controls.Properties.Resources.删除;
            this.barBtnDelete.Id = 2;
            this.barBtnDelete.Name = "barBtnDelete";
            this.barBtnDelete.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.barBtnDelete_ItemClick);
            // 
            // barBtnUpAttachment
            // 
            this.barBtnUpAttachment.Caption = "上传附件(&U)";
            this.barBtnUpAttachment.Glyph = global::DQS.Controls.Properties.Resources.上传;
            this.barBtnUpAttachment.Id = 3;
            this.barBtnUpAttachment.Name = "barBtnUpAttachment";
            this.barBtnUpAttachment.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.barBtnUpAttachment_ItemClick);
            // 
            // barBtnDownAttachment
            // 
            this.barBtnDownAttachment.Caption = "下载附件(&D)";
            this.barBtnDownAttachment.Glyph = global::DQS.Controls.Properties.Resources.下载;
            this.barBtnDownAttachment.Id = 4;
            this.barBtnDownAttachment.Name = "barBtnDownAttachment";
            this.barBtnDownAttachment.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.barBtnDownAttachment_ItemClick);
            // 
            // barBtnPreview
            // 
            this.barBtnPreview.Caption = "在线预览(&P)";
            this.barBtnPreview.Glyph = global::DQS.Controls.Properties.Resources.预览;
            this.barBtnPreview.Id = 5;
            this.barBtnPreview.Name = "barBtnPreview";
            this.barBtnPreview.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.barBtnPreview_ItemClick);
            // 
            // barDeleteAttachment
            // 
            this.barDeleteAttachment.Caption = "删除附件(&L)";
            this.barDeleteAttachment.Glyph = global::DQS.Controls.Properties.Resources.删除__2_;
            this.barDeleteAttachment.Id = 6;
            this.barDeleteAttachment.Name = "barDeleteAttachment";
            this.barDeleteAttachment.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.barDeleteAttachment_ItemClick);
            // 
            // barBtnNewAttribute
            // 
            this.barBtnNewAttribute.Caption = "添加属性(&A)";
            this.barBtnNewAttribute.Glyph = global::DQS.Controls.Properties.Resources.新建;
            this.barBtnNewAttribute.Id = 7;
            this.barBtnNewAttribute.Name = "barBtnNewAttribute";
            this.barBtnNewAttribute.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.barBtnNewAttribute_ItemClick);
            // 
            // barBtnDeleteAttribute
            // 
            this.barBtnDeleteAttribute.Caption = "删除属性(&F)";
            this.barBtnDeleteAttribute.Glyph = global::DQS.Controls.Properties.Resources.删除;
            this.barBtnDeleteAttribute.Id = 8;
            this.barBtnDeleteAttribute.Name = "barBtnDeleteAttribute";
            this.barBtnDeleteAttribute.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.barBtnDeleteAttribute_ItemClick);
            // 
            // barDockControlTop
            // 
            this.barDockControlTop.Dock = System.Windows.Forms.DockStyle.Top;
            this.barDockControlTop.Location = new System.Drawing.Point(0, 0);
            this.barDockControlTop.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.barDockControlTop.Size = new System.Drawing.Size(1067, 40);
            // 
            // barDockControlBottom
            // 
            this.barDockControlBottom.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.barDockControlBottom.Location = new System.Drawing.Point(0, 851);
            this.barDockControlBottom.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.barDockControlBottom.Size = new System.Drawing.Size(1067, 0);
            // 
            // barDockControlLeft
            // 
            this.barDockControlLeft.Dock = System.Windows.Forms.DockStyle.Left;
            this.barDockControlLeft.Location = new System.Drawing.Point(0, 40);
            this.barDockControlLeft.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.barDockControlLeft.Size = new System.Drawing.Size(0, 811);
            // 
            // barDockControlRight
            // 
            this.barDockControlRight.Dock = System.Windows.Forms.DockStyle.Right;
            this.barDockControlRight.Location = new System.Drawing.Point(1067, 40);
            this.barDockControlRight.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.barDockControlRight.Size = new System.Drawing.Size(0, 811);
            // 
            // pnlButtom
            // 
            this.pnlButtom.Controls.Add(this.gpcRight);
            this.pnlButtom.Controls.Add(this.splitterControl1);
            this.pnlButtom.Controls.Add(this.gpcLeft);
            this.pnlButtom.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.pnlButtom.Location = new System.Drawing.Point(0, 488);
            this.pnlButtom.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.pnlButtom.Name = "pnlButtom";
            this.pnlButtom.Size = new System.Drawing.Size(1067, 363);
            this.pnlButtom.TabIndex = 5;
            // 
            // gpcRight
            // 
            this.gpcRight.Controls.Add(this.gridAttachmentControl);
            this.gpcRight.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gpcRight.Location = new System.Drawing.Point(439, 2);
            this.gpcRight.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.gpcRight.Name = "gpcRight";
            this.gpcRight.Size = new System.Drawing.Size(626, 359);
            this.gpcRight.TabIndex = 2;
            this.gpcRight.Text = "附件列表";
            // 
            // gridAttachmentControl
            // 
            this.gridAttachmentControl.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gridAttachmentControl.EmbeddedNavigator.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.gridAttachmentControl.Filter = null;
            this.gridAttachmentControl.Location = new System.Drawing.Point(2, 27);
            this.gridAttachmentControl.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.gridAttachmentControl.MenuManager = this.barManager1;
            this.gridAttachmentControl.Name = "gridAttachmentControl";
            this.gridAttachmentControl.Size = new System.Drawing.Size(622, 330);
            this.gridAttachmentControl.TabIndex = 1;
            this.gridAttachmentControl.ViewName = "vw_AllAttachment";
            // 
            // splitterControl1
            // 
            this.splitterControl1.Location = new System.Drawing.Point(433, 2);
            this.splitterControl1.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.splitterControl1.Name = "splitterControl1";
            this.splitterControl1.Size = new System.Drawing.Size(6, 359);
            this.splitterControl1.TabIndex = 1;
            this.splitterControl1.TabStop = false;
            // 
            // gpcLeft
            // 
            this.gpcLeft.Controls.Add(this.gridAttributeControl);
            this.gpcLeft.Dock = System.Windows.Forms.DockStyle.Left;
            this.gpcLeft.Location = new System.Drawing.Point(2, 2);
            this.gpcLeft.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.gpcLeft.Name = "gpcLeft";
            this.gpcLeft.Size = new System.Drawing.Size(431, 359);
            this.gpcLeft.TabIndex = 0;
            this.gpcLeft.Text = "档案内容";
            // 
            // gridAttributeControl
            // 
            this.gridAttributeControl.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gridAttributeControl.EmbeddedNavigator.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.gridAttributeControl.Filter = null;
            this.gridAttributeControl.Location = new System.Drawing.Point(2, 27);
            this.gridAttributeControl.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.gridAttributeControl.MenuManager = this.barManager1;
            this.gridAttributeControl.Name = "gridAttributeControl";
            this.gridAttributeControl.Size = new System.Drawing.Size(427, 330);
            this.gridAttributeControl.TabIndex = 2;
            this.gridAttributeControl.ViewName = "vw_AllAttribute";
            // 
            // gpcCenter
            // 
            this.gpcCenter.Controls.Add(this.gridQualificationControl);
            this.gpcCenter.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gpcCenter.Location = new System.Drawing.Point(0, 40);
            this.gpcCenter.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.gpcCenter.Name = "gpcCenter";
            this.gpcCenter.Size = new System.Drawing.Size(1067, 448);
            this.gpcCenter.TabIndex = 10;
            this.gpcCenter.Text = "档案列表";
            // 
            // gridQualificationControl
            // 
            this.gridQualificationControl.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gridQualificationControl.EmbeddedNavigator.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.gridQualificationControl.Filter = null;
            this.gridQualificationControl.Location = new System.Drawing.Point(2, 27);
            this.gridQualificationControl.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.gridQualificationControl.MenuManager = this.barManager1;
            this.gridQualificationControl.Name = "gridQualificationControl";
            this.gridQualificationControl.Size = new System.Drawing.Size(1063, 419);
            this.gridQualificationControl.TabIndex = 0;
            this.gridQualificationControl.ViewName = "vw_AllQualification";
            // 
            // FrmQualification
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 18F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1067, 851);
            this.Controls.Add(this.gpcCenter);
            this.Controls.Add(this.pnlButtom);
            this.Controls.Add(this.barDockControlLeft);
            this.Controls.Add(this.barDockControlRight);
            this.Controls.Add(this.barDockControlBottom);
            this.Controls.Add(this.barDockControlTop);
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.MinimizeBox = false;
            this.Name = "FrmQualification";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "电子档案管理器";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.FrmQualification_FormClosing);
            this.Load += new System.EventHandler(this.FrmQualification_Load);
            ((System.ComponentModel.ISupportInitialize)(this.barManager1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pnlButtom)).EndInit();
            this.pnlButtom.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.gpcRight)).EndInit();
            this.gpcRight.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.gridAttachmentControl)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gpcLeft)).EndInit();
            this.gpcLeft.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.gridAttributeControl)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gpcCenter)).EndInit();
            this.gpcCenter.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.gridQualificationControl)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraBars.BarManager barManager1;
        private DevExpress.XtraBars.Bar bar1;
        private DevExpress.XtraBars.BarDockControl barDockControlTop;
        private DevExpress.XtraBars.BarDockControl barDockControlBottom;
        private DevExpress.XtraBars.BarDockControl barDockControlLeft;
        private DevExpress.XtraBars.BarDockControl barDockControlRight;
        private DevExpress.XtraEditors.PanelControl pnlButtom;
        private DevExpress.XtraEditors.GroupControl gpcRight;
        private DevExpress.XtraEditors.SplitterControl splitterControl1;
        private DevExpress.XtraEditors.GroupControl gpcLeft;
        private DevExpress.XtraEditors.GroupControl gpcCenter;
        private StandardGrid gridQualificationControl;
        private StandardGrid gridAttachmentControl;
        private StandardGrid gridAttributeControl;
        public DevExpress.XtraBars.BarButtonItem barBtnNew;
        public DevExpress.XtraBars.BarButtonItem barBtnModify;
        public DevExpress.XtraBars.BarButtonItem barBtnDelete;
        public DevExpress.XtraBars.BarButtonItem barBtnUpAttachment;
        public DevExpress.XtraBars.BarButtonItem barBtnDownAttachment;
        public DevExpress.XtraBars.BarButtonItem barBtnPreview;
        public DevExpress.XtraBars.BarButtonItem barDeleteAttachment;
        public DevExpress.XtraBars.BarButtonItem barBtnNewAttribute;
        public DevExpress.XtraBars.BarButtonItem barBtnDeleteAttribute;

    }
}