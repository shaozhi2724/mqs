namespace DQS.App
{
    partial class FrmProduct
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
            this.btnCheck = new DevExpress.XtraEditors.SimpleButton();
            this.btnCreate = new DevExpress.XtraEditors.SimpleButton();
            this.SuspendLayout();
            // 
            // btnCheck
            // 
            this.btnCheck.Location = new System.Drawing.Point(51, 35);
            this.btnCheck.Name = "btnCheck";
            this.btnCheck.Size = new System.Drawing.Size(116, 56);
            this.btnCheck.TabIndex = 0;
            this.btnCheck.Text = "对应";
            this.btnCheck.Click += new System.EventHandler(this.btnCheck_Click);
            // 
            // btnCreate
            // 
            this.btnCreate.Location = new System.Drawing.Point(248, 35);
            this.btnCreate.Name = "btnCreate";
            this.btnCreate.Size = new System.Drawing.Size(116, 56);
            this.btnCreate.TabIndex = 1;
            this.btnCreate.Text = "生成";
            this.btnCreate.Click += new System.EventHandler(this.btnCreate_Click);
            // 
            // FrmProduct
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 14F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(423, 300);
            this.Controls.Add(this.btnCreate);
            this.Controls.Add(this.btnCheck);
            this.Name = "FrmProduct";
            this.Text = "主体";
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraEditors.SimpleButton btnCheck;
        private DevExpress.XtraEditors.SimpleButton btnCreate;
    }
}