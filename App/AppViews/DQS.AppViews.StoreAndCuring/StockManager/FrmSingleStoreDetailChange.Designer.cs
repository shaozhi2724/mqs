namespace DQS.AppViews.StoreAndCuring.StockManager
{
    partial class FrmSingleStoreDetailChange
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
            this.groupControl1 = new DevExpress.XtraEditors.GroupControl();
            this.layoutControl1 = new DevExpress.XtraLayout.LayoutControl();
            this.layoutControlGroup1 = new DevExpress.XtraLayout.LayoutControlGroup();
            this.txtOldBatchNo = new DevExpress.XtraEditors.TextEdit();
            this.txtNewValidateDate = new DevExpress.XtraEditors.TextEdit();
            this.layOldBatchNo = new DevExpress.XtraLayout.LayoutControlItem();
            this.txtNewBatchNo = new DevExpress.XtraEditors.TextEdit();
            this.layNewBatchNo = new DevExpress.XtraLayout.LayoutControlItem();
            this.txtOldProduceDate = new DevExpress.XtraEditors.TextEdit();
            this.layOldProduceDate = new DevExpress.XtraLayout.LayoutControlItem();
            this.txtNewProduceDate = new DevExpress.XtraEditors.TextEdit();
            this.layNewProduceDate = new DevExpress.XtraLayout.LayoutControlItem();
            this.txtValidateDate = new DevExpress.XtraEditors.TextEdit();
            this.layOldValidateDate = new DevExpress.XtraLayout.LayoutControlItem();
            this.layNewValidateDate = new DevExpress.XtraLayout.LayoutControlItem();
            this.btnSave = new DevExpress.XtraEditors.SimpleButton();
            this.btnCancel = new DevExpress.XtraEditors.SimpleButton();
            this.btnUnSave = new DevExpress.XtraEditors.SimpleButton();
            ((System.ComponentModel.ISupportInitialize)(this.panelControl1)).BeginInit();
            this.panelControl1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.groupControl1)).BeginInit();
            this.groupControl1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControl1)).BeginInit();
            this.layoutControl1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlGroup1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtOldBatchNo.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtNewValidateDate.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layOldBatchNo)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtNewBatchNo.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layNewBatchNo)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtOldProduceDate.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layOldProduceDate)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtNewProduceDate.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layNewProduceDate)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtValidateDate.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layOldValidateDate)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layNewValidateDate)).BeginInit();
            this.SuspendLayout();
            // 
            // panelControl1
            // 
            this.panelControl1.Controls.Add(this.btnCancel);
            this.panelControl1.Controls.Add(this.btnUnSave);
            this.panelControl1.Controls.Add(this.btnSave);
            this.panelControl1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panelControl1.Location = new System.Drawing.Point(0, 226);
            this.panelControl1.Name = "panelControl1";
            this.panelControl1.Size = new System.Drawing.Size(509, 64);
            this.panelControl1.TabIndex = 0;
            // 
            // groupControl1
            // 
            this.groupControl1.Controls.Add(this.layoutControl1);
            this.groupControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupControl1.Location = new System.Drawing.Point(0, 0);
            this.groupControl1.Name = "groupControl1";
            this.groupControl1.Size = new System.Drawing.Size(509, 226);
            this.groupControl1.TabIndex = 1;
            this.groupControl1.Text = "明细";
            // 
            // layoutControl1
            // 
            this.layoutControl1.Controls.Add(this.txtNewValidateDate);
            this.layoutControl1.Controls.Add(this.txtValidateDate);
            this.layoutControl1.Controls.Add(this.txtNewProduceDate);
            this.layoutControl1.Controls.Add(this.txtOldProduceDate);
            this.layoutControl1.Controls.Add(this.txtNewBatchNo);
            this.layoutControl1.Controls.Add(this.txtOldBatchNo);
            this.layoutControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.layoutControl1.Location = new System.Drawing.Point(2, 23);
            this.layoutControl1.Name = "layoutControl1";
            this.layoutControl1.Root = this.layoutControlGroup1;
            this.layoutControl1.Size = new System.Drawing.Size(505, 201);
            this.layoutControl1.TabIndex = 0;
            this.layoutControl1.Text = "layoutControl1";
            // 
            // layoutControlGroup1
            // 
            this.layoutControlGroup1.CustomizationFormText = "layoutControlGroup1";
            this.layoutControlGroup1.EnableIndentsWithoutBorders = DevExpress.Utils.DefaultBoolean.True;
            this.layoutControlGroup1.GroupBordersVisible = false;
            this.layoutControlGroup1.Items.AddRange(new DevExpress.XtraLayout.BaseLayoutItem[] {
            this.layOldBatchNo,
            this.layNewBatchNo,
            this.layOldProduceDate,
            this.layNewProduceDate,
            this.layOldValidateDate,
            this.layNewValidateDate});
            this.layoutControlGroup1.Location = new System.Drawing.Point(0, 0);
            this.layoutControlGroup1.Name = "layoutControlGroup1";
            this.layoutControlGroup1.Size = new System.Drawing.Size(505, 201);
            this.layoutControlGroup1.Spacing = new DevExpress.XtraLayout.Utils.Padding(0, 0, 0, 0);
            this.layoutControlGroup1.Text = "layoutControlGroup1";
            this.layoutControlGroup1.TextVisible = false;
            // 
            // txtOldBatchNo
            // 
            this.txtOldBatchNo.Location = new System.Drawing.Point(92, 12);
            this.txtOldBatchNo.Name = "txtOldBatchNo";
            this.txtOldBatchNo.Properties.ReadOnly = true;
            this.txtOldBatchNo.Size = new System.Drawing.Size(158, 21);
            this.txtOldBatchNo.StyleController = this.layoutControl1;
            this.txtOldBatchNo.TabIndex = 0;
            // 
            // txtNewValidateDate
            // 
            this.txtNewValidateDate.Location = new System.Drawing.Point(334, 62);
            this.txtNewValidateDate.Name = "txtNewValidateDate";
            this.txtNewValidateDate.Properties.ReadOnly = true;
            this.txtNewValidateDate.Size = new System.Drawing.Size(159, 21);
            this.txtNewValidateDate.StyleController = this.layoutControl1;
            this.txtNewValidateDate.TabIndex = 0;
            // 
            // layOldBatchNo
            // 
            this.layOldBatchNo.Control = this.txtOldBatchNo;
            this.layOldBatchNo.CustomizationFormText = "旧值-批号";
            this.layOldBatchNo.Location = new System.Drawing.Point(0, 0);
            this.layOldBatchNo.Name = "layOldBatchNo";
            this.layOldBatchNo.Size = new System.Drawing.Size(242, 25);
            this.layOldBatchNo.Text = "旧值-批号";
            this.layOldBatchNo.TextSize = new System.Drawing.Size(76, 14);
            // 
            // txtNewBatchNo
            // 
            this.txtNewBatchNo.Location = new System.Drawing.Point(334, 12);
            this.txtNewBatchNo.Name = "txtNewBatchNo";
            this.txtNewBatchNo.Properties.ReadOnly = true;
            this.txtNewBatchNo.Size = new System.Drawing.Size(159, 21);
            this.txtNewBatchNo.StyleController = this.layoutControl1;
            this.txtNewBatchNo.TabIndex = 0;
            // 
            // layNewBatchNo
            // 
            this.layNewBatchNo.Control = this.txtNewBatchNo;
            this.layNewBatchNo.CustomizationFormText = "新值";
            this.layNewBatchNo.Location = new System.Drawing.Point(242, 0);
            this.layNewBatchNo.Name = "layNewBatchNo";
            this.layNewBatchNo.Size = new System.Drawing.Size(243, 25);
            this.layNewBatchNo.Text = "新值";
            this.layNewBatchNo.TextSize = new System.Drawing.Size(76, 14);
            // 
            // txtOldProduceDate
            // 
            this.txtOldProduceDate.Location = new System.Drawing.Point(92, 37);
            this.txtOldProduceDate.Name = "txtOldProduceDate";
            this.txtOldProduceDate.Properties.ReadOnly = true;
            this.txtOldProduceDate.Size = new System.Drawing.Size(158, 21);
            this.txtOldProduceDate.StyleController = this.layoutControl1;
            this.txtOldProduceDate.TabIndex = 0;
            // 
            // layOldProduceDate
            // 
            this.layOldProduceDate.Control = this.txtOldProduceDate;
            this.layOldProduceDate.CustomizationFormText = "旧值-生产日期";
            this.layOldProduceDate.Location = new System.Drawing.Point(0, 25);
            this.layOldProduceDate.Name = "layOldProduceDate";
            this.layOldProduceDate.Size = new System.Drawing.Size(242, 25);
            this.layOldProduceDate.Text = "旧值-生产日期";
            this.layOldProduceDate.TextSize = new System.Drawing.Size(76, 14);
            // 
            // txtNewProduceDate
            // 
            this.txtNewProduceDate.Location = new System.Drawing.Point(334, 37);
            this.txtNewProduceDate.Name = "txtNewProduceDate";
            this.txtNewProduceDate.Properties.ReadOnly = true;
            this.txtNewProduceDate.Size = new System.Drawing.Size(159, 21);
            this.txtNewProduceDate.StyleController = this.layoutControl1;
            this.txtNewProduceDate.TabIndex = 0;
            // 
            // layNewProduceDate
            // 
            this.layNewProduceDate.Control = this.txtNewProduceDate;
            this.layNewProduceDate.CustomizationFormText = "新值";
            this.layNewProduceDate.Location = new System.Drawing.Point(242, 25);
            this.layNewProduceDate.Name = "layNewProduceDate";
            this.layNewProduceDate.Size = new System.Drawing.Size(243, 25);
            this.layNewProduceDate.Text = "新值";
            this.layNewProduceDate.TextSize = new System.Drawing.Size(76, 14);
            // 
            // txtValidateDate
            // 
            this.txtValidateDate.Location = new System.Drawing.Point(92, 62);
            this.txtValidateDate.Name = "txtValidateDate";
            this.txtValidateDate.Properties.ReadOnly = true;
            this.txtValidateDate.Size = new System.Drawing.Size(158, 21);
            this.txtValidateDate.StyleController = this.layoutControl1;
            this.txtValidateDate.TabIndex = 0;
            // 
            // layOldValidateDate
            // 
            this.layOldValidateDate.Control = this.txtValidateDate;
            this.layOldValidateDate.CustomizationFormText = "旧值-有效期";
            this.layOldValidateDate.Location = new System.Drawing.Point(0, 50);
            this.layOldValidateDate.Name = "layOldValidateDate";
            this.layOldValidateDate.Size = new System.Drawing.Size(242, 131);
            this.layOldValidateDate.Text = "旧值-有效期";
            this.layOldValidateDate.TextSize = new System.Drawing.Size(76, 14);
            // 
            // layNewValidateDate
            // 
            this.layNewValidateDate.Control = this.txtNewValidateDate;
            this.layNewValidateDate.CustomizationFormText = "新值";
            this.layNewValidateDate.Location = new System.Drawing.Point(242, 50);
            this.layNewValidateDate.Name = "layNewValidateDate";
            this.layNewValidateDate.Size = new System.Drawing.Size(243, 131);
            this.layNewValidateDate.Text = "新值";
            this.layNewValidateDate.TextSize = new System.Drawing.Size(76, 14);
            // 
            // btnSave
            // 
            this.btnSave.Location = new System.Drawing.Point(295, 23);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(75, 23);
            this.btnSave.TabIndex = 0;
            this.btnSave.Text = "通过";
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // btnCancel
            // 
            this.btnCancel.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btnCancel.Location = new System.Drawing.Point(405, 23);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(75, 23);
            this.btnCancel.TabIndex = 0;
            this.btnCancel.Text = "取消";
            // 
            // btnUnSave
            // 
            this.btnUnSave.Location = new System.Drawing.Point(160, 23);
            this.btnUnSave.Name = "btnUnSave";
            this.btnUnSave.Size = new System.Drawing.Size(75, 23);
            this.btnUnSave.TabIndex = 0;
            this.btnUnSave.Text = "不通过";
            this.btnUnSave.Click += new System.EventHandler(this.btnUnSave_Click);
            // 
            // FrmSingleStoreDetailChange
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 14F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(509, 290);
            this.Controls.Add(this.groupControl1);
            this.Controls.Add(this.panelControl1);
            this.Name = "FrmSingleStoreDetailChange";
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "批号申请变更明细";
            this.Load += new System.EventHandler(this.FrmSingleStoreDetailChange_Load);
            ((System.ComponentModel.ISupportInitialize)(this.panelControl1)).EndInit();
            this.panelControl1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.groupControl1)).EndInit();
            this.groupControl1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.layoutControl1)).EndInit();
            this.layoutControl1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlGroup1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtOldBatchNo.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtNewValidateDate.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layOldBatchNo)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtNewBatchNo.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layNewBatchNo)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtOldProduceDate.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layOldProduceDate)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtNewProduceDate.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layNewProduceDate)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtValidateDate.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layOldValidateDate)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layNewValidateDate)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraEditors.PanelControl panelControl1;
        private DevExpress.XtraEditors.SimpleButton btnCancel;
        private DevExpress.XtraEditors.SimpleButton btnUnSave;
        private DevExpress.XtraEditors.SimpleButton btnSave;
        private DevExpress.XtraEditors.GroupControl groupControl1;
        private DevExpress.XtraLayout.LayoutControl layoutControl1;
        private DevExpress.XtraEditors.TextEdit txtNewValidateDate;
        private DevExpress.XtraEditors.TextEdit txtValidateDate;
        private DevExpress.XtraEditors.TextEdit txtNewProduceDate;
        private DevExpress.XtraEditors.TextEdit txtOldProduceDate;
        private DevExpress.XtraEditors.TextEdit txtNewBatchNo;
        private DevExpress.XtraEditors.TextEdit txtOldBatchNo;
        private DevExpress.XtraLayout.LayoutControlGroup layoutControlGroup1;
        private DevExpress.XtraLayout.LayoutControlItem layOldBatchNo;
        private DevExpress.XtraLayout.LayoutControlItem layNewBatchNo;
        private DevExpress.XtraLayout.LayoutControlItem layOldProduceDate;
        private DevExpress.XtraLayout.LayoutControlItem layNewProduceDate;
        private DevExpress.XtraLayout.LayoutControlItem layOldValidateDate;
        private DevExpress.XtraLayout.LayoutControlItem layNewValidateDate;
    }
}