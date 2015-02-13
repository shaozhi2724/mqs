namespace DQS.AppViews.OtherOperation.Code
{
    partial class FrmExportTickets
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
            this.btnExport = new DevExpress.XtraEditors.SimpleButton();
            this.lblTotalCodeCount = new DevExpress.XtraEditors.LabelControl();
            this.labelControl3 = new DevExpress.XtraEditors.LabelControl();
            this.lblUsedCodesCount = new DevExpress.XtraEditors.LabelControl();
            this.labelControl5 = new DevExpress.XtraEditors.LabelControl();
            this.lblExportedCodesCount = new DevExpress.XtraEditors.LabelControl();
            this.labelControl7 = new DevExpress.XtraEditors.LabelControl();
            this.lblCanUsedCodesCount = new DevExpress.XtraEditors.LabelControl();
            this.saveFileDialog = new System.Windows.Forms.SaveFileDialog();
            this.SuspendLayout();
            // 
            // labelControl1
            // 
            this.labelControl1.Location = new System.Drawing.Point(35, 38);
            this.labelControl1.Name = "labelControl1";
            this.labelControl1.Size = new System.Drawing.Size(96, 14);
            this.labelControl1.TabIndex = 0;
            this.labelControl1.Text = "流通监管码总量：";
            // 
            // btnExport
            // 
            this.btnExport.Location = new System.Drawing.Point(121, 264);
            this.btnExport.Name = "btnExport";
            this.btnExport.Size = new System.Drawing.Size(75, 23);
            this.btnExport.TabIndex = 1;
            this.btnExport.Text = "导出";
            this.btnExport.Click += new System.EventHandler(this.btnExport_Click);
            // 
            // lblTotalCodeCount
            // 
            this.lblTotalCodeCount.Location = new System.Drawing.Point(167, 38);
            this.lblTotalCodeCount.Name = "lblTotalCodeCount";
            this.lblTotalCodeCount.Size = new System.Drawing.Size(0, 14);
            this.lblTotalCodeCount.TabIndex = 0;
            // 
            // labelControl3
            // 
            this.labelControl3.Location = new System.Drawing.Point(83, 94);
            this.labelControl3.Name = "labelControl3";
            this.labelControl3.Size = new System.Drawing.Size(48, 14);
            this.labelControl3.TabIndex = 0;
            this.labelControl3.Text = "未导出：";
            // 
            // lblUsedCodesCount
            // 
            this.lblUsedCodesCount.Location = new System.Drawing.Point(167, 94);
            this.lblUsedCodesCount.Name = "lblUsedCodesCount";
            this.lblUsedCodesCount.Size = new System.Drawing.Size(0, 14);
            this.lblUsedCodesCount.TabIndex = 0;
            // 
            // labelControl5
            // 
            this.labelControl5.Location = new System.Drawing.Point(83, 150);
            this.labelControl5.Name = "labelControl5";
            this.labelControl5.Size = new System.Drawing.Size(48, 14);
            this.labelControl5.TabIndex = 0;
            this.labelControl5.Text = "已导出：";
            // 
            // lblExportedCodesCount
            // 
            this.lblExportedCodesCount.Location = new System.Drawing.Point(167, 150);
            this.lblExportedCodesCount.Name = "lblExportedCodesCount";
            this.lblExportedCodesCount.Size = new System.Drawing.Size(0, 14);
            this.lblExportedCodesCount.TabIndex = 0;
            // 
            // labelControl7
            // 
            this.labelControl7.Location = new System.Drawing.Point(83, 206);
            this.labelControl7.Name = "labelControl7";
            this.labelControl7.Size = new System.Drawing.Size(48, 14);
            this.labelControl7.TabIndex = 0;
            this.labelControl7.Text = "未使用：";
            // 
            // lblCanUsedCodesCount
            // 
            this.lblCanUsedCodesCount.Location = new System.Drawing.Point(167, 206);
            this.lblCanUsedCodesCount.Name = "lblCanUsedCodesCount";
            this.lblCanUsedCodesCount.Size = new System.Drawing.Size(0, 14);
            this.lblCanUsedCodesCount.TabIndex = 0;
            // 
            // saveFileDialog
            // 
            this.saveFileDialog.Filter = "Excel 文件|*.xls";
            this.saveFileDialog.Title = "保存导出单据";
            this.saveFileDialog.FileOk += new System.ComponentModel.CancelEventHandler(this.saveFileDialog_FileOk);
            // 
            // FrmExportTickets
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 14F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(340, 324);
            this.Controls.Add(this.btnExport);
            this.Controls.Add(this.lblCanUsedCodesCount);
            this.Controls.Add(this.labelControl7);
            this.Controls.Add(this.lblExportedCodesCount);
            this.Controls.Add(this.labelControl5);
            this.Controls.Add(this.lblUsedCodesCount);
            this.Controls.Add(this.labelControl3);
            this.Controls.Add(this.lblTotalCodeCount);
            this.Controls.Add(this.labelControl1);
            this.Name = "FrmExportTickets";
            this.ShowIcon = false;
            this.Text = "导出单据";
            this.Load += new System.EventHandler(this.FrmExportTickets_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private DevExpress.XtraEditors.LabelControl labelControl1;
        private DevExpress.XtraEditors.SimpleButton btnExport;
        private DevExpress.XtraEditors.LabelControl lblTotalCodeCount;
        private DevExpress.XtraEditors.LabelControl labelControl3;
        private DevExpress.XtraEditors.LabelControl lblUsedCodesCount;
        private DevExpress.XtraEditors.LabelControl labelControl5;
        private DevExpress.XtraEditors.LabelControl lblExportedCodesCount;
        private DevExpress.XtraEditors.LabelControl labelControl7;
        private DevExpress.XtraEditors.LabelControl lblCanUsedCodesCount;
        private System.Windows.Forms.SaveFileDialog saveFileDialog;
    }
}