namespace DQS.AppViews.Operation
{
    partial class FrmReason
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
            this.layOperator = new DevExpress.XtraLayout.LayoutControlItem();
            this.meReason = new DevExpress.XtraEditors.MemoEdit();
            this.btnOK = new DevExpress.XtraEditors.SimpleButton();
            this.btnCancel = new DevExpress.XtraEditors.SimpleButton();
            ((System.ComponentModel.ISupportInitialize)(this.layOperator)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.meReason.Properties)).BeginInit();
            this.SuspendLayout();
            // 
            // labelControl1
            // 
            this.labelControl1.Location = new System.Drawing.Point(18, 33);
            this.labelControl1.Name = "labelControl1";
            this.labelControl1.Size = new System.Drawing.Size(60, 14);
            this.labelControl1.TabIndex = 0;
            this.labelControl1.Text = "删除原因：";
            // 
            // layOperator
            // 
            this.layOperator.CustomizationFormText = "采购员";
            this.layOperator.Location = new System.Drawing.Point(414, 104);
            this.layOperator.Name = "layoutControlItem10";
            this.layOperator.Size = new System.Drawing.Size(417, 25);
            this.layOperator.Text = "采购员";
            this.layOperator.TextSize = new System.Drawing.Size(60, 17);
            this.layOperator.TextToControlDistance = 5;
            // 
            // meReason
            // 
            this.meReason.Location = new System.Drawing.Point(84, 30);
            this.meReason.Name = "meReason";
            this.meReason.Size = new System.Drawing.Size(263, 87);
            this.meReason.TabIndex = 1;
            // 
            // btnOK
            // 
            this.btnOK.Location = new System.Drawing.Point(84, 175);
            this.btnOK.Name = "btnOK";
            this.btnOK.Size = new System.Drawing.Size(75, 23);
            this.btnOK.TabIndex = 2;
            this.btnOK.Text = "确认";
            this.btnOK.Click += new System.EventHandler(this.btnOK_Click);
            // 
            // btnCancel
            // 
            this.btnCancel.Location = new System.Drawing.Point(211, 175);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(75, 23);
            this.btnCancel.TabIndex = 2;
            this.btnCancel.Text = "取消";
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // FrmReason
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 14F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(372, 241);
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.btnOK);
            this.Controls.Add(this.labelControl1);
            this.Controls.Add(this.meReason);
            this.Name = "FrmReason";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "删除原因";
            ((System.ComponentModel.ISupportInitialize)(this.layOperator)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.meReason.Properties)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private DevExpress.XtraEditors.LabelControl labelControl1;
        private DevExpress.XtraLayout.LayoutControlItem layOperator;
        private DevExpress.XtraEditors.MemoEdit meReason;
        private DevExpress.XtraEditors.SimpleButton btnOK;
        private DevExpress.XtraEditors.SimpleButton btnCancel;
    }
}