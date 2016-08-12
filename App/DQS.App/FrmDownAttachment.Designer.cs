namespace DQS.App
{
    partial class FrmDownAttachment
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
            this.gcSearch = new DevExpress.XtraEditors.GroupControl();
            this.btnPrint = new DevExpress.XtraEditors.SimpleButton();
            this.btnDown = new DevExpress.XtraEditors.SimpleButton();
            this.btnSearch = new DevExpress.XtraEditors.SimpleButton();
            this.txtBatchNo = new DevExpress.XtraEditors.TextEdit();
            this.txtCode = new DevExpress.XtraEditors.TextEdit();
            this.labelControl2 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl1 = new DevExpress.XtraEditors.LabelControl();
            this.panelControl = new DevExpress.XtraEditors.PanelControl();
            this.pictureEdit = new DevExpress.XtraEditors.PictureEdit();
            this.gcDetails = new DevExpress.XtraEditors.GroupControl();
            this.gridControl = new DevExpress.XtraGrid.GridControl();
            this.gridView = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.colAcceptAttachmentID = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colProductID = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colProductCode = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colProductName = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colPackageSpec = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colProducerName = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colBatchNo = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colAttachmentName = new DevExpress.XtraGrid.Columns.GridColumn();
            this.printDocument = new System.Drawing.Printing.PrintDocument();
            this.splitterControl1 = new DevExpress.XtraEditors.SplitterControl();
            ((System.ComponentModel.ISupportInitialize)(this.gcSearch)).BeginInit();
            this.gcSearch.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.txtBatchNo.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtCode.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.panelControl)).BeginInit();
            this.panelControl.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureEdit.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gcDetails)).BeginInit();
            this.gcDetails.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gridControl)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView)).BeginInit();
            this.SuspendLayout();
            // 
            // gcSearch
            // 
            this.gcSearch.Controls.Add(this.btnPrint);
            this.gcSearch.Controls.Add(this.btnDown);
            this.gcSearch.Controls.Add(this.btnSearch);
            this.gcSearch.Controls.Add(this.txtBatchNo);
            this.gcSearch.Controls.Add(this.txtCode);
            this.gcSearch.Controls.Add(this.labelControl2);
            this.gcSearch.Controls.Add(this.labelControl1);
            this.gcSearch.Dock = System.Windows.Forms.DockStyle.Top;
            this.gcSearch.Location = new System.Drawing.Point(0, 0);
            this.gcSearch.Name = "gcSearch";
            this.gcSearch.Size = new System.Drawing.Size(884, 64);
            this.gcSearch.TabIndex = 0;
            this.gcSearch.Text = "查询条件";
            // 
            // btnPrint
            // 
            this.btnPrint.Location = new System.Drawing.Point(771, 29);
            this.btnPrint.Name = "btnPrint";
            this.btnPrint.Size = new System.Drawing.Size(87, 27);
            this.btnPrint.TabIndex = 2;
            this.btnPrint.Text = "打印";
            this.btnPrint.Click += new System.EventHandler(this.btnPrint_Click);
            // 
            // btnDown
            // 
            this.btnDown.Location = new System.Drawing.Point(643, 29);
            this.btnDown.Name = "btnDown";
            this.btnDown.Size = new System.Drawing.Size(87, 27);
            this.btnDown.TabIndex = 2;
            this.btnDown.Text = "下载";
            this.btnDown.Click += new System.EventHandler(this.btnDown_Click);
            // 
            // btnSearch
            // 
            this.btnSearch.Location = new System.Drawing.Point(517, 29);
            this.btnSearch.Name = "btnSearch";
            this.btnSearch.Size = new System.Drawing.Size(87, 27);
            this.btnSearch.TabIndex = 2;
            this.btnSearch.Text = "查询";
            this.btnSearch.Click += new System.EventHandler(this.btnSearch_Click);
            // 
            // txtBatchNo
            // 
            this.txtBatchNo.Location = new System.Drawing.Point(346, 31);
            this.txtBatchNo.Name = "txtBatchNo";
            this.txtBatchNo.Size = new System.Drawing.Size(133, 21);
            this.txtBatchNo.TabIndex = 1;
            // 
            // txtCode
            // 
            this.txtCode.Location = new System.Drawing.Point(91, 31);
            this.txtCode.Name = "txtCode";
            this.txtCode.Size = new System.Drawing.Size(199, 21);
            this.txtCode.TabIndex = 1;
            // 
            // labelControl2
            // 
            this.labelControl2.Location = new System.Drawing.Point(297, 34);
            this.labelControl2.Name = "labelControl2";
            this.labelControl2.Size = new System.Drawing.Size(36, 14);
            this.labelControl2.TabIndex = 0;
            this.labelControl2.Text = "批号：";
            // 
            // labelControl1
            // 
            this.labelControl1.Location = new System.Drawing.Point(14, 34);
            this.labelControl1.Name = "labelControl1";
            this.labelControl1.Size = new System.Drawing.Size(60, 14);
            this.labelControl1.TabIndex = 0;
            this.labelControl1.Text = "产品名称：";
            // 
            // panelControl
            // 
            this.panelControl.Controls.Add(this.pictureEdit);
            this.panelControl.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panelControl.Location = new System.Drawing.Point(0, 385);
            this.panelControl.Name = "panelControl";
            this.panelControl.Size = new System.Drawing.Size(884, 184);
            this.panelControl.TabIndex = 1;
            // 
            // pictureEdit
            // 
            this.pictureEdit.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pictureEdit.Location = new System.Drawing.Point(2, 2);
            this.pictureEdit.Name = "pictureEdit";
            this.pictureEdit.Properties.SizeMode = DevExpress.XtraEditors.Controls.PictureSizeMode.Zoom;
            this.pictureEdit.Size = new System.Drawing.Size(880, 180);
            this.pictureEdit.TabIndex = 2;
            this.pictureEdit.Visible = false;
            // 
            // gcDetails
            // 
            this.gcDetails.Controls.Add(this.gridControl);
            this.gcDetails.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gcDetails.Location = new System.Drawing.Point(0, 64);
            this.gcDetails.Name = "gcDetails";
            this.gcDetails.Size = new System.Drawing.Size(884, 321);
            this.gcDetails.TabIndex = 2;
            this.gcDetails.Text = "明细";
            // 
            // gridControl
            // 
            this.gridControl.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gridControl.Location = new System.Drawing.Point(2, 23);
            this.gridControl.MainView = this.gridView;
            this.gridControl.Name = "gridControl";
            this.gridControl.Size = new System.Drawing.Size(880, 296);
            this.gridControl.TabIndex = 0;
            this.gridControl.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridView});
            // 
            // gridView
            // 
            this.gridView.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.colAcceptAttachmentID,
            this.colProductID,
            this.colProductCode,
            this.colProductName,
            this.colPackageSpec,
            this.colProducerName,
            this.colBatchNo,
            this.colAttachmentName});
            this.gridView.GridControl = this.gridControl;
            this.gridView.IndicatorWidth = 40;
            this.gridView.Name = "gridView";
            this.gridView.OptionsBehavior.Editable = false;
            this.gridView.OptionsBehavior.ReadOnly = true;
            this.gridView.OptionsView.ShowGroupPanel = false;
            this.gridView.Click += new System.EventHandler(this.gridView_Click);
            // 
            // colAcceptAttachmentID
            // 
            this.colAcceptAttachmentID.Caption = "附件ID";
            this.colAcceptAttachmentID.FieldName = "AcceptAttachmentID";
            this.colAcceptAttachmentID.Name = "colAcceptAttachmentID";
            // 
            // colProductID
            // 
            this.colProductID.Caption = "产品ID";
            this.colProductID.FieldName = "ProductID";
            this.colProductID.Name = "colProductID";
            // 
            // colProductCode
            // 
            this.colProductCode.Caption = "产品编号";
            this.colProductCode.FieldName = "ProductCode";
            this.colProductCode.Name = "colProductCode";
            this.colProductCode.Visible = true;
            this.colProductCode.VisibleIndex = 0;
            // 
            // colProductName
            // 
            this.colProductName.Caption = "产品名称";
            this.colProductName.FieldName = "ProductName";
            this.colProductName.Name = "colProductName";
            this.colProductName.Visible = true;
            this.colProductName.VisibleIndex = 1;
            // 
            // colPackageSpec
            // 
            this.colPackageSpec.Caption = "规格";
            this.colPackageSpec.FieldName = "PackageSpec";
            this.colPackageSpec.Name = "colPackageSpec";
            this.colPackageSpec.Visible = true;
            this.colPackageSpec.VisibleIndex = 2;
            // 
            // colProducerName
            // 
            this.colProducerName.Caption = "厂商";
            this.colProducerName.FieldName = "ProducerName";
            this.colProducerName.Name = "colProducerName";
            this.colProducerName.Visible = true;
            this.colProducerName.VisibleIndex = 3;
            // 
            // colBatchNo
            // 
            this.colBatchNo.Caption = "批号";
            this.colBatchNo.FieldName = "BatchNo";
            this.colBatchNo.Name = "colBatchNo";
            this.colBatchNo.Visible = true;
            this.colBatchNo.VisibleIndex = 4;
            // 
            // colAttachmentName
            // 
            this.colAttachmentName.Caption = "附件名称";
            this.colAttachmentName.FieldName = "AttachmentName";
            this.colAttachmentName.Name = "colAttachmentName";
            this.colAttachmentName.Visible = true;
            this.colAttachmentName.VisibleIndex = 5;
            // 
            // printDocument
            // 
            this.printDocument.PrintPage += new System.Drawing.Printing.PrintPageEventHandler(this.printDocument_PrintPage);
            // 
            // splitterControl1
            // 
            this.splitterControl1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.splitterControl1.Location = new System.Drawing.Point(0, 379);
            this.splitterControl1.Name = "splitterControl1";
            this.splitterControl1.Size = new System.Drawing.Size(884, 6);
            this.splitterControl1.TabIndex = 3;
            this.splitterControl1.TabStop = false;
            // 
            // FrmDownAttachment
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 14F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(884, 569);
            this.Controls.Add(this.splitterControl1);
            this.Controls.Add(this.gcDetails);
            this.Controls.Add(this.panelControl);
            this.Controls.Add(this.gcSearch);
            this.Name = "FrmDownAttachment";
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "附件下载";
            ((System.ComponentModel.ISupportInitialize)(this.gcSearch)).EndInit();
            this.gcSearch.ResumeLayout(false);
            this.gcSearch.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.txtBatchNo.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtCode.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.panelControl)).EndInit();
            this.panelControl.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureEdit.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gcDetails)).EndInit();
            this.gcDetails.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.gridControl)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraEditors.GroupControl gcSearch;
        private DevExpress.XtraEditors.LabelControl labelControl1;
        private DevExpress.XtraEditors.PanelControl panelControl;
        private DevExpress.XtraEditors.GroupControl gcDetails;
        private DevExpress.XtraEditors.TextEdit txtBatchNo;
        private DevExpress.XtraEditors.TextEdit txtCode;
        private DevExpress.XtraEditors.LabelControl labelControl2;
        private DevExpress.XtraEditors.SimpleButton btnSearch;
        private DevExpress.XtraGrid.GridControl gridControl;
        private DevExpress.XtraGrid.Views.Grid.GridView gridView;
        private DevExpress.XtraEditors.SimpleButton btnDown;
        private DevExpress.XtraEditors.SimpleButton btnPrint;
        private DevExpress.XtraGrid.Columns.GridColumn colAcceptAttachmentID;
        private DevExpress.XtraGrid.Columns.GridColumn colProductID;
        private DevExpress.XtraGrid.Columns.GridColumn colProductCode;
        private DevExpress.XtraGrid.Columns.GridColumn colProductName;
        private DevExpress.XtraGrid.Columns.GridColumn colPackageSpec;
        private DevExpress.XtraGrid.Columns.GridColumn colProducerName;
        private DevExpress.XtraGrid.Columns.GridColumn colBatchNo;
        private DevExpress.XtraGrid.Columns.GridColumn colAttachmentName;
        private System.Drawing.Printing.PrintDocument printDocument;
        private DevExpress.XtraEditors.PictureEdit pictureEdit;
        private DevExpress.XtraEditors.SplitterControl splitterControl1;
    }
}