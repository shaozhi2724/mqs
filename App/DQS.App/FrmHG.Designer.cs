namespace DQS.App
{
    partial class FrmHG
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
            this.btnChangReason = new DevExpress.XtraEditors.SimpleButton();
            this.btnReview = new DevExpress.XtraEditors.SimpleButton();
            this.btnRepairStore = new DevExpress.XtraEditors.SimpleButton();
            this.btnInStore = new DevExpress.XtraEditors.SimpleButton();
            this.btnDateUpdate = new DevExpress.XtraEditors.SimpleButton();
            this.SuspendLayout();
            // 
            // btnChangReason
            // 
            this.btnChangReason.Location = new System.Drawing.Point(52, 36);
            this.btnChangReason.Name = "btnChangReason";
            this.btnChangReason.Size = new System.Drawing.Size(166, 42);
            this.btnChangReason.TabIndex = 5;
            this.btnChangReason.Text = "修改变更原因";
            this.btnChangReason.Click += new System.EventHandler(this.btnChangReason_Click);
            // 
            // btnReview
            // 
            this.btnReview.Location = new System.Drawing.Point(317, 36);
            this.btnReview.Name = "btnReview";
            this.btnReview.Size = new System.Drawing.Size(166, 42);
            this.btnReview.TabIndex = 6;
            this.btnReview.Text = "补充或删除复核记录";
            this.btnReview.Click += new System.EventHandler(this.btnReview_Click);
            // 
            // btnRepairStore
            // 
            this.btnRepairStore.Location = new System.Drawing.Point(582, 36);
            this.btnRepairStore.Name = "btnRepairStore";
            this.btnRepairStore.Size = new System.Drawing.Size(166, 42);
            this.btnRepairStore.TabIndex = 7;
            this.btnRepairStore.Text = "出库库存修复";
            this.btnRepairStore.Click += new System.EventHandler(this.btnRepairStore_Click);
            // 
            // btnInStore
            // 
            this.btnInStore.Location = new System.Drawing.Point(52, 124);
            this.btnInStore.Name = "btnInStore";
            this.btnInStore.Size = new System.Drawing.Size(166, 42);
            this.btnInStore.TabIndex = 8;
            this.btnInStore.Text = "入库库存修复";
            this.btnInStore.Click += new System.EventHandler(this.btnInStore_Click);
            // 
            // btnDateUpdate
            // 
            this.btnDateUpdate.Location = new System.Drawing.Point(317, 124);
            this.btnDateUpdate.Name = "btnDateUpdate";
            this.btnDateUpdate.Size = new System.Drawing.Size(166, 42);
            this.btnDateUpdate.TabIndex = 8;
            this.btnDateUpdate.Text = "单据日期修改";
            this.btnDateUpdate.Click += new System.EventHandler(this.btnDateUpdate_Click);
            // 
            // FrmHG
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 14F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(914, 491);
            this.Controls.Add(this.btnDateUpdate);
            this.Controls.Add(this.btnInStore);
            this.Controls.Add(this.btnRepairStore);
            this.Controls.Add(this.btnReview);
            this.Controls.Add(this.btnChangReason);
            this.MaximizeBox = false;
            this.Name = "FrmHG";
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "修改工具类";
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraEditors.SimpleButton btnChangReason;
        private DevExpress.XtraEditors.SimpleButton btnReview;
        private DevExpress.XtraEditors.SimpleButton btnRepairStore;
        private DevExpress.XtraEditors.SimpleButton btnInStore;
        private DevExpress.XtraEditors.SimpleButton btnDateUpdate;
    }
}