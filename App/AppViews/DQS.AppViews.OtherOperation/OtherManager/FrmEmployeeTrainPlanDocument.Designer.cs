namespace DQS.AppViews.OtherOperation.OtherManager
{
    partial class FrmEmployeeTrainPlanDocument
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
            this.barBtnAdd = new DevExpress.XtraBars.BarButtonItem();
            this.barBtnUpdate = new DevExpress.XtraBars.BarButtonItem();
            this.barBtnDel = new DevExpress.XtraBars.BarButtonItem();
            this.barBtnUpAttachment = new DevExpress.XtraBars.BarButtonItem();
            this.barBtnDownAttachment = new DevExpress.XtraBars.BarButtonItem();
            this.barBtnPreview = new DevExpress.XtraBars.BarButtonItem();
            this.barDeleteAttachment = new DevExpress.XtraBars.BarButtonItem();
            this.barDockControlTop = new DevExpress.XtraBars.BarDockControl();
            this.barDockControlBottom = new DevExpress.XtraBars.BarDockControl();
            this.barDockControlLeft = new DevExpress.XtraBars.BarDockControl();
            this.barDockControlRight = new DevExpress.XtraBars.BarDockControl();
            this.pnlContent = new DevExpress.XtraEditors.PanelControl();
            this.gpcTop = new DevExpress.XtraEditors.GroupControl();
            this.gridAcceptDetailControl = new DQS.Controls.StandardGrid();
            this.gpcBottom = new DevExpress.XtraEditors.GroupControl();
            this.gridAttachmentControl = new DQS.Controls.StandardGrid();
            ((System.ComponentModel.ISupportInitialize)(this.barManager1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pnlContent)).BeginInit();
            this.pnlContent.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gpcTop)).BeginInit();
            this.gpcTop.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gridAcceptDetailControl)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gpcBottom)).BeginInit();
            this.gpcBottom.SuspendLayout();
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
            this.barDeleteAttachment,
            this.barBtnAdd,
            this.barBtnUpdate,
            this.barBtnDel});
            this.barManager1.MaxItemId = 12;
            // 
            // bar1
            // 
            this.bar1.BarName = "Tools";
            this.bar1.DockCol = 0;
            this.bar1.DockRow = 0;
            this.bar1.DockStyle = DevExpress.XtraBars.BarDockStyle.Top;
            this.bar1.LinksPersistInfo.AddRange(new DevExpress.XtraBars.LinkPersistInfo[] {
            new DevExpress.XtraBars.LinkPersistInfo(DevExpress.XtraBars.BarLinkUserDefines.PaintStyle, this.barBtnAdd, DevExpress.XtraBars.BarItemPaintStyle.CaptionGlyph),
            new DevExpress.XtraBars.LinkPersistInfo(DevExpress.XtraBars.BarLinkUserDefines.PaintStyle, this.barBtnUpdate, DevExpress.XtraBars.BarItemPaintStyle.CaptionGlyph),
            new DevExpress.XtraBars.LinkPersistInfo(DevExpress.XtraBars.BarLinkUserDefines.PaintStyle, this.barBtnDel, DevExpress.XtraBars.BarItemPaintStyle.CaptionGlyph),
            new DevExpress.XtraBars.LinkPersistInfo(DevExpress.XtraBars.BarLinkUserDefines.PaintStyle, this.barBtnUpAttachment, DevExpress.XtraBars.BarItemPaintStyle.CaptionGlyph),
            new DevExpress.XtraBars.LinkPersistInfo(DevExpress.XtraBars.BarLinkUserDefines.PaintStyle, this.barBtnDownAttachment, DevExpress.XtraBars.BarItemPaintStyle.CaptionGlyph),
            new DevExpress.XtraBars.LinkPersistInfo(DevExpress.XtraBars.BarLinkUserDefines.PaintStyle, this.barBtnPreview, DevExpress.XtraBars.BarItemPaintStyle.CaptionGlyph),
            new DevExpress.XtraBars.LinkPersistInfo(DevExpress.XtraBars.BarLinkUserDefines.PaintStyle, this.barDeleteAttachment, DevExpress.XtraBars.BarItemPaintStyle.CaptionGlyph)});
            this.bar1.OptionsBar.AllowQuickCustomization = false;
            this.bar1.OptionsBar.DrawDragBorder = false;
            this.bar1.OptionsBar.UseWholeRow = true;
            this.bar1.Text = "Tools";
            // 
            // barBtnAdd
            // 
            this.barBtnAdd.Caption = "新建";
            this.barBtnAdd.Glyph = global::DQS.AppViews.OtherOperation.Properties.Resources.新建__2_;
            this.barBtnAdd.Id = 9;
            this.barBtnAdd.Name = "barBtnAdd";
            this.barBtnAdd.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.barBtnAdd_ItemClick);
            // 
            // barBtnUpdate
            // 
            this.barBtnUpdate.Caption = "修改";
            this.barBtnUpdate.Glyph = global::DQS.AppViews.OtherOperation.Properties.Resources.编辑__2_;
            this.barBtnUpdate.Id = 10;
            this.barBtnUpdate.Name = "barBtnUpdate";
            this.barBtnUpdate.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.barBtnUpdate_ItemClick);
            // 
            // barBtnDel
            // 
            this.barBtnDel.Caption = "删除";
            this.barBtnDel.Glyph = global::DQS.AppViews.OtherOperation.Properties.Resources.删除;
            this.barBtnDel.Id = 11;
            this.barBtnDel.Name = "barBtnDel";
            this.barBtnDel.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.barBtnDel_ItemClick);
            // 
            // barBtnUpAttachment
            // 
            this.barBtnUpAttachment.Caption = "上传附件(&U)";
            this.barBtnUpAttachment.Id = 3;
            this.barBtnUpAttachment.Name = "barBtnUpAttachment";
            this.barBtnUpAttachment.Visibility = DevExpress.XtraBars.BarItemVisibility.Never;
            // 
            // barBtnDownAttachment
            // 
            this.barBtnDownAttachment.Caption = "下载附件(&D)";
            this.barBtnDownAttachment.Id = 4;
            this.barBtnDownAttachment.Name = "barBtnDownAttachment";
            this.barBtnDownAttachment.Visibility = DevExpress.XtraBars.BarItemVisibility.Never;
            // 
            // barBtnPreview
            // 
            this.barBtnPreview.Caption = "在线预览(&P)";
            this.barBtnPreview.Id = 5;
            this.barBtnPreview.Name = "barBtnPreview";
            this.barBtnPreview.Visibility = DevExpress.XtraBars.BarItemVisibility.Never;
            // 
            // barDeleteAttachment
            // 
            this.barDeleteAttachment.Caption = "删除附件(&L)";
            this.barDeleteAttachment.Id = 6;
            this.barDeleteAttachment.Name = "barDeleteAttachment";
            this.barDeleteAttachment.Visibility = DevExpress.XtraBars.BarItemVisibility.Never;
            // 
            // barDockControlTop
            // 
            this.barDockControlTop.Dock = System.Windows.Forms.DockStyle.Top;
            this.barDockControlTop.Location = new System.Drawing.Point(0, 0);
            this.barDockControlTop.Size = new System.Drawing.Size(874, 34);
            // 
            // barDockControlBottom
            // 
            this.barDockControlBottom.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.barDockControlBottom.Location = new System.Drawing.Point(0, 425);
            this.barDockControlBottom.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.barDockControlBottom.Size = new System.Drawing.Size(874, 0);
            // 
            // barDockControlLeft
            // 
            this.barDockControlLeft.Dock = System.Windows.Forms.DockStyle.Left;
            this.barDockControlLeft.Location = new System.Drawing.Point(0, 34);
            this.barDockControlLeft.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.barDockControlLeft.Size = new System.Drawing.Size(0, 391);
            // 
            // barDockControlRight
            // 
            this.barDockControlRight.Dock = System.Windows.Forms.DockStyle.Right;
            this.barDockControlRight.Location = new System.Drawing.Point(874, 34);
            this.barDockControlRight.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.barDockControlRight.Size = new System.Drawing.Size(0, 391);
            // 
            // pnlContent
            // 
            this.pnlContent.Controls.Add(this.gpcTop);
            this.pnlContent.Controls.Add(this.gpcBottom);
            this.pnlContent.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlContent.Location = new System.Drawing.Point(0, 34);
            this.pnlContent.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.pnlContent.Name = "pnlContent";
            this.pnlContent.Size = new System.Drawing.Size(874, 391);
            this.pnlContent.TabIndex = 15;
            // 
            // gpcTop
            // 
            this.gpcTop.Controls.Add(this.gridAcceptDetailControl);
            this.gpcTop.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gpcTop.Location = new System.Drawing.Point(2, 2);
            this.gpcTop.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.gpcTop.Name = "gpcTop";
            this.gpcTop.Size = new System.Drawing.Size(870, 311);
            this.gpcTop.TabIndex = 0;
            this.gpcTop.Text = "培训档案";
            // 
            // gridAcceptDetailControl
            // 
            this.gridAcceptDetailControl.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gridAcceptDetailControl.Filter = null;
            this.gridAcceptDetailControl.Location = new System.Drawing.Point(2, 23);
            this.gridAcceptDetailControl.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.gridAcceptDetailControl.MenuManager = this.barManager1;
            this.gridAcceptDetailControl.Name = "gridAcceptDetailControl";
            this.gridAcceptDetailControl.Size = new System.Drawing.Size(866, 286);
            this.gridAcceptDetailControl.TabIndex = 1;
            this.gridAcceptDetailControl.ViewName = "vw_AllAcceptDetailForAttachment";
            // 
            // gpcBottom
            // 
            this.gpcBottom.Controls.Add(this.gridAttachmentControl);
            this.gpcBottom.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.gpcBottom.Location = new System.Drawing.Point(2, 313);
            this.gpcBottom.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.gpcBottom.Name = "gpcBottom";
            this.gpcBottom.Size = new System.Drawing.Size(870, 76);
            this.gpcBottom.TabIndex = 2;
            this.gpcBottom.Text = "产品检验报告列表";
            this.gpcBottom.Visible = false;
            // 
            // gridAttachmentControl
            // 
            this.gridAttachmentControl.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gridAttachmentControl.Filter = null;
            this.gridAttachmentControl.Location = new System.Drawing.Point(2, 23);
            this.gridAttachmentControl.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.gridAttachmentControl.MenuManager = this.barManager1;
            this.gridAttachmentControl.Name = "gridAttachmentControl";
            this.gridAttachmentControl.Size = new System.Drawing.Size(866, 51);
            this.gridAttachmentControl.TabIndex = 4;
            this.gridAttachmentControl.ViewName = "vw_AllAcceptAttachment";
            // 
            // FrmEmployeeTrainPlanDocument
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 14F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(874, 425);
            this.Controls.Add(this.pnlContent);
            this.Controls.Add(this.barDockControlLeft);
            this.Controls.Add(this.barDockControlRight);
            this.Controls.Add(this.barDockControlBottom);
            this.Controls.Add(this.barDockControlTop);
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.MinimizeBox = false;
            this.Name = "FrmEmployeeTrainPlanDocument";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "培训档案";
            this.Load += new System.EventHandler(this.FrmEmployeeTrainPlanDocument_Load);
            ((System.ComponentModel.ISupportInitialize)(this.barManager1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pnlContent)).EndInit();
            this.pnlContent.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.gpcTop)).EndInit();
            this.gpcTop.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.gridAcceptDetailControl)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gpcBottom)).EndInit();
            this.gpcBottom.ResumeLayout(false);
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
        public DevExpress.XtraBars.BarButtonItem barBtnUpAttachment;
        public DevExpress.XtraBars.BarButtonItem barBtnDownAttachment;
        public DevExpress.XtraBars.BarButtonItem barBtnPreview;
        public DevExpress.XtraBars.BarButtonItem barDeleteAttachment;
        private DevExpress.XtraEditors.PanelControl pnlContent;
        private DevExpress.XtraEditors.GroupControl gpcBottom;
        private Controls.StandardGrid gridAttachmentControl;
        private DevExpress.XtraEditors.GroupControl gpcTop;
        private Controls.StandardGrid gridAcceptDetailControl;
        private DevExpress.XtraBars.BarButtonItem barBtnAdd;
        private DevExpress.XtraBars.BarButtonItem barBtnUpdate;
        private DevExpress.XtraBars.BarButtonItem barBtnDel;

    }
}