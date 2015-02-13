namespace DQS.AppViews.OtherOperation.Code
{
    partial class FrmImportCode
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
            this.labelControl1 = new DevExpress.XtraEditors.LabelControl();
            this.txtFile = new DevExpress.XtraEditors.TextEdit();
            this.btnBrowse = new DevExpress.XtraEditors.SimpleButton();
            this.btnImport = new DevExpress.XtraEditors.SimpleButton();
            this.grdCodes = new DevExpress.XtraGrid.GridControl();
            this.gridView = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.openFileDialog = new System.Windows.Forms.OpenFileDialog();
            ((System.ComponentModel.ISupportInitialize)(this.txtFile.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.grdCodes)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView)).BeginInit();
            this.SuspendLayout();
            // 
            // labelControl1
            // 
            this.labelControl1.Location = new System.Drawing.Point(23, 29);
            this.labelControl1.Name = "labelControl1";
            this.labelControl1.Size = new System.Drawing.Size(60, 14);
            this.labelControl1.TabIndex = 0;
            this.labelControl1.Text = "导入文件：";
            // 
            // txtFile
            // 
            this.txtFile.Location = new System.Drawing.Point(89, 26);
            this.txtFile.Name = "txtFile";
            this.txtFile.Size = new System.Drawing.Size(312, 21);
            this.txtFile.TabIndex = 1;
            // 
            // btnBrowse
            // 
            this.btnBrowse.Location = new System.Drawing.Point(437, 24);
            this.btnBrowse.Name = "btnBrowse";
            this.btnBrowse.Size = new System.Drawing.Size(75, 23);
            this.btnBrowse.TabIndex = 2;
            this.btnBrowse.Text = "浏览…";
            this.btnBrowse.Click += new System.EventHandler(this.btnBrowse_Click);
            // 
            // btnImport
            // 
            this.btnImport.Location = new System.Drawing.Point(552, 24);
            this.btnImport.Name = "btnImport";
            this.btnImport.Size = new System.Drawing.Size(75, 23);
            this.btnImport.TabIndex = 2;
            this.btnImport.Text = "确定导入";
            this.btnImport.Click += new System.EventHandler(this.btnImport_Click);
            // 
            // grdCodes
            // 
            this.grdCodes.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.grdCodes.Location = new System.Drawing.Point(23, 79);
            this.grdCodes.MainView = this.gridView;
            this.grdCodes.Name = "grdCodes";
            this.grdCodes.Size = new System.Drawing.Size(697, 377);
            this.grdCodes.TabIndex = 3;
            this.grdCodes.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridView});
            // 
            // gridView
            // 
            this.gridView.GridControl = this.grdCodes;
            this.gridView.IndicatorWidth = 45;
            this.gridView.Name = "gridView";
            this.gridView.OptionsBehavior.Editable = false;
            this.gridView.OptionsBehavior.ReadOnly = true;
            this.gridView.OptionsView.ColumnAutoWidth = false;
            this.gridView.OptionsView.ShowGroupPanel = false;
            this.gridView.CustomDrawRowIndicator += new DevExpress.XtraGrid.Views.Grid.RowIndicatorCustomDrawEventHandler(this.gridView_CustomDrawRowIndicator);
            // 
            // openFileDialog
            // 
            this.openFileDialog.Filter = "Excel文件|*.xls";
            this.openFileDialog.FileOk += new System.ComponentModel.CancelEventHandler(this.openFileDialog_FileOk);
            // 
            // FrmImportCode
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 14F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(747, 484);
            this.Controls.Add(this.grdCodes);
            this.Controls.Add(this.btnImport);
            this.Controls.Add(this.btnBrowse);
            this.Controls.Add(this.txtFile);
            this.Controls.Add(this.labelControl1);
            this.Name = "FrmImportCode";
            this.ShowIcon = false;
            this.Text = "导入监管码";
            ((System.ComponentModel.ISupportInitialize)(this.txtFile.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.grdCodes)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private DevExpress.XtraEditors.LabelControl labelControl1;
        private DevExpress.XtraEditors.TextEdit txtFile;
        private DevExpress.XtraEditors.SimpleButton btnBrowse;
        private DevExpress.XtraEditors.SimpleButton btnImport;
        private DevExpress.XtraGrid.GridControl grdCodes;
        private DevExpress.XtraGrid.Views.Grid.GridView gridView;
        private System.Windows.Forms.OpenFileDialog openFileDialog;
    }
}