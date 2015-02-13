namespace DQS.App
{
    partial class FrmChangePassword
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
            this.lblError1 = new DevExpress.XtraEditors.LabelControl();
            this.lblError2 = new DevExpress.XtraEditors.LabelControl();
            this.lblError3 = new DevExpress.XtraEditors.LabelControl();
            this.lblOldPassword = new DevExpress.XtraEditors.LabelControl();
            this.lblPassword = new DevExpress.XtraEditors.LabelControl();
            this.lblRePassword = new DevExpress.XtraEditors.LabelControl();
            this.btnChangePassword = new DevExpress.XtraEditors.SimpleButton();
            this.btnCancel = new DevExpress.XtraEditors.SimpleButton();
            this.txtRePassword = new DQS.Controls.TextBoxEx();
            this.txtPassword = new DQS.Controls.TextBoxEx();
            this.txtOldPassword = new DQS.Controls.TextBoxEx();
            ((System.ComponentModel.ISupportInitialize)(this.txtRePassword.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtPassword.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtOldPassword.Properties)).BeginInit();
            this.SuspendLayout();
            // 
            // lblError1
            // 
            this.lblError1.Appearance.ForeColor = System.Drawing.Color.Red;
            this.lblError1.Appearance.Options.UseForeColor = true;
            this.lblError1.Location = new System.Drawing.Point(285, 37);
            this.lblError1.Name = "lblError1";
            this.lblError1.Size = new System.Drawing.Size(53, 14);
            this.lblError1.TabIndex = 6;
            this.lblError1.Text = "*(必填项)";
            // 
            // lblError2
            // 
            this.lblError2.Appearance.ForeColor = System.Drawing.Color.Red;
            this.lblError2.Appearance.Options.UseForeColor = true;
            this.lblError2.Location = new System.Drawing.Point(285, 80);
            this.lblError2.Name = "lblError2";
            this.lblError2.Size = new System.Drawing.Size(53, 14);
            this.lblError2.TabIndex = 8;
            this.lblError2.Text = "*(必填项)";
            // 
            // lblError3
            // 
            this.lblError3.Appearance.ForeColor = System.Drawing.Color.Red;
            this.lblError3.Appearance.Options.UseForeColor = true;
            this.lblError3.Location = new System.Drawing.Point(285, 123);
            this.lblError3.Name = "lblError3";
            this.lblError3.Size = new System.Drawing.Size(53, 14);
            this.lblError3.TabIndex = 10;
            this.lblError3.Text = "*(必填项)";
            // 
            // lblOldPassword
            // 
            this.lblOldPassword.Location = new System.Drawing.Point(52, 37);
            this.lblOldPassword.Name = "lblOldPassword";
            this.lblOldPassword.Size = new System.Drawing.Size(48, 14);
            this.lblOldPassword.TabIndex = 5;
            this.lblOldPassword.Text = "旧密码：";
            // 
            // lblPassword
            // 
            this.lblPassword.Location = new System.Drawing.Point(52, 80);
            this.lblPassword.Name = "lblPassword";
            this.lblPassword.Size = new System.Drawing.Size(48, 14);
            this.lblPassword.TabIndex = 7;
            this.lblPassword.Text = "新密码：";
            // 
            // lblRePassword
            // 
            this.lblRePassword.Location = new System.Drawing.Point(40, 123);
            this.lblRePassword.Name = "lblRePassword";
            this.lblRePassword.Size = new System.Drawing.Size(60, 14);
            this.lblRePassword.TabIndex = 9;
            this.lblRePassword.Text = "重复密码：";
            // 
            // btnChangePassword
            // 
            this.btnChangePassword.Location = new System.Drawing.Point(118, 162);
            this.btnChangePassword.Name = "btnChangePassword";
            this.btnChangePassword.Size = new System.Drawing.Size(75, 23);
            this.btnChangePassword.TabIndex = 3;
            this.btnChangePassword.Text = "修改密码";
            this.btnChangePassword.Click += new System.EventHandler(this.btnChangePassword_Click);
            // 
            // btnCancel
            // 
            this.btnCancel.Location = new System.Drawing.Point(221, 162);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(75, 23);
            this.btnCancel.TabIndex = 4;
            this.btnCancel.Text = "取 消";
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // txtRePassword
            // 
            this.txtRePassword.Location = new System.Drawing.Point(106, 120);
            this.txtRePassword.Name = "txtRePassword";
            this.txtRePassword.Properties.PasswordChar = '●';
            this.txtRePassword.Size = new System.Drawing.Size(173, 21);
            this.txtRePassword.TabIndex = 2;
            // 
            // txtPassword
            // 
            this.txtPassword.Location = new System.Drawing.Point(106, 77);
            this.txtPassword.Name = "txtPassword";
            this.txtPassword.Properties.PasswordChar = '●';
            this.txtPassword.Size = new System.Drawing.Size(173, 21);
            this.txtPassword.TabIndex = 1;
            // 
            // txtOldPassword
            // 
            this.txtOldPassword.Location = new System.Drawing.Point(106, 34);
            this.txtOldPassword.Name = "txtOldPassword";
            this.txtOldPassword.Properties.PasswordChar = '●';
            this.txtOldPassword.Size = new System.Drawing.Size(173, 21);
            this.txtOldPassword.TabIndex = 0;
            // 
            // FrmChangePassword
            // 
            this.AcceptButton = this.btnChangePassword;
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 14F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(414, 218);
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.btnChangePassword);
            this.Controls.Add(this.lblRePassword);
            this.Controls.Add(this.lblPassword);
            this.Controls.Add(this.lblError3);
            this.Controls.Add(this.lblError2);
            this.Controls.Add(this.lblError1);
            this.Controls.Add(this.lblOldPassword);
            this.Controls.Add(this.txtRePassword);
            this.Controls.Add(this.txtPassword);
            this.Controls.Add(this.txtOldPassword);
            this.Name = "FrmChangePassword";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "修改密码";
            ((System.ComponentModel.ISupportInitialize)(this.txtRePassword.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtPassword.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtOldPassword.Properties)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private DQS.Controls.TextBoxEx txtOldPassword;
        private DQS.Controls.TextBoxEx txtPassword;
        private DQS.Controls.TextBoxEx txtRePassword;
        private DevExpress.XtraEditors.LabelControl lblOldPassword;
        private DevExpress.XtraEditors.LabelControl lblPassword;
        private DevExpress.XtraEditors.LabelControl lblRePassword;
        private DevExpress.XtraEditors.SimpleButton btnChangePassword;
        private DevExpress.XtraEditors.SimpleButton btnCancel;
        private DevExpress.XtraEditors.LabelControl lblError1;
        private DevExpress.XtraEditors.LabelControl lblError2;
        private DevExpress.XtraEditors.LabelControl lblError3;
    }
}