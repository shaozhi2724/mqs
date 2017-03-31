namespace DQS.AppViews.Operation.PurchaseAndSaleManager
{
    partial class FrmAcceptReport
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
            this.panelControl1 = new DevExpress.XtraEditors.PanelControl();
            this.pictureEdit = new DevExpress.XtraEditors.PictureEdit();
            this.panelControl2 = new DevExpress.XtraEditors.PanelControl();
            this.btnPrint = new DevExpress.XtraEditors.SimpleButton();
            this.gcAccept = new DevExpress.XtraEditors.GroupControl();
            this.gReport = new DevExpress.XtraGrid.GridControl();
            this.vReport = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.gcDetails = new DevExpress.XtraEditors.GroupControl();
            this.gDetails = new DevExpress.XtraGrid.GridControl();
            this.vDetails = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.colProductID = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colProductCode = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colProductName = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colProductSpec = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colBatchNo = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colAcceptAttachmentID = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colAttachmentName = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colAttachmentSize = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colAttachmentType = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colCreateDate = new DevExpress.XtraGrid.Columns.GridColumn();
            this.printDocument = new System.Drawing.Printing.PrintDocument();
            ((System.ComponentModel.ISupportInitialize)(this.panelControl1)).BeginInit();
            this.panelControl1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureEdit.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.panelControl2)).BeginInit();
            this.panelControl2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gcAccept)).BeginInit();
            this.gcAccept.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gReport)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.vReport)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gcDetails)).BeginInit();
            this.gcDetails.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gDetails)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.vDetails)).BeginInit();
            this.SuspendLayout();
            // 
            // panelControl1
            // 
            this.panelControl1.Controls.Add(this.pictureEdit);
            this.panelControl1.Controls.Add(this.panelControl2);
            this.panelControl1.Dock = System.Windows.Forms.DockStyle.Right;
            this.panelControl1.Location = new System.Drawing.Point(459, 0);
            this.panelControl1.Name = "panelControl1";
            this.panelControl1.Size = new System.Drawing.Size(345, 492);
            this.panelControl1.TabIndex = 0;
            // 
            // pictureEdit
            // 
            this.pictureEdit.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pictureEdit.Location = new System.Drawing.Point(2, 2);
            this.pictureEdit.Name = "pictureEdit";
            this.pictureEdit.Properties.SizeMode = DevExpress.XtraEditors.Controls.PictureSizeMode.Zoom;
            this.pictureEdit.Size = new System.Drawing.Size(341, 442);
            this.pictureEdit.TabIndex = 1;
            // 
            // panelControl2
            // 
            this.panelControl2.Controls.Add(this.btnPrint);
            this.panelControl2.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panelControl2.Location = new System.Drawing.Point(2, 444);
            this.panelControl2.Name = "panelControl2";
            this.panelControl2.Size = new System.Drawing.Size(341, 46);
            this.panelControl2.TabIndex = 0;
            // 
            // btnPrint
            // 
            this.btnPrint.Location = new System.Drawing.Point(240, 13);
            this.btnPrint.Name = "btnPrint";
            this.btnPrint.Size = new System.Drawing.Size(75, 23);
            this.btnPrint.TabIndex = 0;
            this.btnPrint.Text = "打印";
            this.btnPrint.Click += new System.EventHandler(this.btnPrint_Click);
            // 
            // gcAccept
            // 
            this.gcAccept.Controls.Add(this.gReport);
            this.gcAccept.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.gcAccept.Location = new System.Drawing.Point(0, 325);
            this.gcAccept.Name = "gcAccept";
            this.gcAccept.Size = new System.Drawing.Size(459, 167);
            this.gcAccept.TabIndex = 1;
            this.gcAccept.Text = "检验报告";
            // 
            // gReport
            // 
            this.gReport.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gReport.Location = new System.Drawing.Point(2, 23);
            this.gReport.MainView = this.vReport;
            this.gReport.Name = "gReport";
            this.gReport.Size = new System.Drawing.Size(455, 142);
            this.gReport.TabIndex = 0;
            this.gReport.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.vReport});
            // 
            // vReport
            // 
            this.vReport.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.colAcceptAttachmentID,
            this.colAttachmentName,
            this.colAttachmentSize,
            this.colAttachmentType,
            this.colCreateDate});
            this.vReport.GridControl = this.gReport;
            this.vReport.IndicatorWidth = 45;
            this.vReport.Name = "vReport";
            this.vReport.OptionsBehavior.Editable = false;
            this.vReport.OptionsBehavior.ReadOnly = true;
            this.vReport.OptionsView.ShowGroupPanel = false;
            this.vReport.RowClick += new DevExpress.XtraGrid.Views.Grid.RowClickEventHandler(this.vReport_RowClick);
            this.vReport.CustomDrawRowIndicator += new DevExpress.XtraGrid.Views.Grid.RowIndicatorCustomDrawEventHandler(this.vReport_CustomDrawRowIndicator);
            // 
            // gcDetails
            // 
            this.gcDetails.Controls.Add(this.gDetails);
            this.gcDetails.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gcDetails.Location = new System.Drawing.Point(0, 0);
            this.gcDetails.Name = "gcDetails";
            this.gcDetails.Size = new System.Drawing.Size(459, 325);
            this.gcDetails.TabIndex = 2;
            this.gcDetails.Text = "明细";
            // 
            // gDetails
            // 
            this.gDetails.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gDetails.Location = new System.Drawing.Point(2, 23);
            this.gDetails.MainView = this.vDetails;
            this.gDetails.Name = "gDetails";
            this.gDetails.Size = new System.Drawing.Size(455, 300);
            this.gDetails.TabIndex = 0;
            this.gDetails.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.vDetails});
            // 
            // vDetails
            // 
            this.vDetails.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.colProductID,
            this.colProductCode,
            this.colProductName,
            this.colProductSpec,
            this.colBatchNo});
            this.vDetails.GridControl = this.gDetails;
            this.vDetails.IndicatorWidth = 45;
            this.vDetails.Name = "vDetails";
            this.vDetails.OptionsBehavior.Editable = false;
            this.vDetails.OptionsBehavior.ReadOnly = true;
            this.vDetails.OptionsView.ShowGroupPanel = false;
            this.vDetails.RowClick += new DevExpress.XtraGrid.Views.Grid.RowClickEventHandler(this.vDetails_RowClick);
            this.vDetails.CustomDrawRowIndicator += new DevExpress.XtraGrid.Views.Grid.RowIndicatorCustomDrawEventHandler(this.vDetails_CustomDrawRowIndicator);
            // 
            // colProductID
            // 
            this.colProductID.Caption = "ProductID";
            this.colProductID.FieldName = "ProductID";
            this.colProductID.Name = "colProductID";
            // 
            // colProductCode
            // 
            this.colProductCode.Caption = "编号";
            this.colProductCode.FieldName = "ProductCode";
            this.colProductCode.Name = "colProductCode";
            this.colProductCode.Visible = true;
            this.colProductCode.VisibleIndex = 0;
            // 
            // colProductName
            // 
            this.colProductName.Caption = "名称";
            this.colProductName.FieldName = "ProductName";
            this.colProductName.Name = "colProductName";
            this.colProductName.Visible = true;
            this.colProductName.VisibleIndex = 1;
            // 
            // colProductSpec
            // 
            this.colProductSpec.Caption = "规格";
            this.colProductSpec.FieldName = "ProductSpec";
            this.colProductSpec.Name = "colProductSpec";
            this.colProductSpec.Visible = true;
            this.colProductSpec.VisibleIndex = 2;
            // 
            // colBatchNo
            // 
            this.colBatchNo.Caption = "批号";
            this.colBatchNo.FieldName = "BatchNo";
            this.colBatchNo.Name = "colBatchNo";
            this.colBatchNo.Visible = true;
            this.colBatchNo.VisibleIndex = 3;
            // 
            // colAcceptAttachmentID
            // 
            this.colAcceptAttachmentID.Caption = "AcceptAttachmentID";
            this.colAcceptAttachmentID.FieldName = "AcceptAttachmentID";
            this.colAcceptAttachmentID.Name = "colAcceptAttachmentID";
            // 
            // colAttachmentName
            // 
            this.colAttachmentName.Caption = "附件名称";
            this.colAttachmentName.FieldName = "AttachmentName";
            this.colAttachmentName.Name = "colAttachmentName";
            this.colAttachmentName.Visible = true;
            this.colAttachmentName.VisibleIndex = 0;
            // 
            // colAttachmentSize
            // 
            this.colAttachmentSize.Caption = "附件大小";
            this.colAttachmentSize.FieldName = "AttachmentSize";
            this.colAttachmentSize.Name = "colAttachmentSize";
            this.colAttachmentSize.Visible = true;
            this.colAttachmentSize.VisibleIndex = 1;
            // 
            // colAttachmentType
            // 
            this.colAttachmentType.Caption = "类型";
            this.colAttachmentType.FieldName = "AttachmentType";
            this.colAttachmentType.Name = "colAttachmentType";
            this.colAttachmentType.Visible = true;
            this.colAttachmentType.VisibleIndex = 2;
            // 
            // colCreateDate
            // 
            this.colCreateDate.Caption = "日期";
            this.colCreateDate.FieldName = "CreateDate";
            this.colCreateDate.Name = "colCreateDate";
            this.colCreateDate.Visible = true;
            this.colCreateDate.VisibleIndex = 3;
            // 
            // printDocument
            // 
            this.printDocument.PrintPage += new System.Drawing.Printing.PrintPageEventHandler(this.printDocument_PrintPage);
            // 
            // FrmAcceptReport
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 14F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(804, 492);
            this.Controls.Add(this.gcDetails);
            this.Controls.Add(this.gcAccept);
            this.Controls.Add(this.panelControl1);
            this.Name = "FrmAcceptReport";
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "明细检验报告";
            this.Load += new System.EventHandler(this.FrmAcceptReport_Load);
            ((System.ComponentModel.ISupportInitialize)(this.panelControl1)).EndInit();
            this.panelControl1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureEdit.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.panelControl2)).EndInit();
            this.panelControl2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.gcAccept)).EndInit();
            this.gcAccept.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.gReport)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.vReport)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gcDetails)).EndInit();
            this.gcDetails.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.gDetails)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.vDetails)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraEditors.PanelControl panelControl1;
        private DevExpress.XtraEditors.PanelControl panelControl2;
        private DevExpress.XtraEditors.SimpleButton btnPrint;
        private DevExpress.XtraEditors.GroupControl gcAccept;
        private DevExpress.XtraEditors.GroupControl gcDetails;
        private DevExpress.XtraEditors.PictureEdit pictureEdit;
        private DevExpress.XtraGrid.GridControl gDetails;
        private DevExpress.XtraGrid.Views.Grid.GridView vDetails;
        private DevExpress.XtraGrid.GridControl gReport;
        private DevExpress.XtraGrid.Views.Grid.GridView vReport;
        private DevExpress.XtraGrid.Columns.GridColumn colProductID;
        private DevExpress.XtraGrid.Columns.GridColumn colProductCode;
        private DevExpress.XtraGrid.Columns.GridColumn colProductName;
        private DevExpress.XtraGrid.Columns.GridColumn colProductSpec;
        private DevExpress.XtraGrid.Columns.GridColumn colBatchNo;
        private DevExpress.XtraGrid.Columns.GridColumn colAcceptAttachmentID;
        private DevExpress.XtraGrid.Columns.GridColumn colAttachmentName;
        private DevExpress.XtraGrid.Columns.GridColumn colAttachmentSize;
        private DevExpress.XtraGrid.Columns.GridColumn colAttachmentType;
        private DevExpress.XtraGrid.Columns.GridColumn colCreateDate;
        private System.Drawing.Printing.PrintDocument printDocument;
    }
}