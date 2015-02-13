namespace DQS.App
{
    partial class FrmLicenserIdentification
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
            this.components = new System.ComponentModel.Container();
            this.lblComputerID = new DevExpress.XtraEditors.LabelControl();
            this.btnClose = new DevExpress.XtraEditors.SimpleButton();
            this.btnCopy = new DevExpress.XtraEditors.SimpleButton();
            this.labelControl1 = new DevExpress.XtraEditors.LabelControl();
            this.fdgLicenseFile = new System.Windows.Forms.OpenFileDialog();
            this.btnBrowser = new DevExpress.XtraEditors.SimpleButton();
            this.btnRegister = new DevExpress.XtraEditors.SimpleButton();
            this.defaultLookAndFeel = new DevExpress.LookAndFeel.DefaultLookAndFeel(this.components);
            this.txtLicenseFile = new DQS.Controls.TextBoxEx();
            this.txtComputerID = new DQS.Controls.TextBoxEx();
            ((System.ComponentModel.ISupportInitialize)(this.txtLicenseFile.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtComputerID.Properties)).BeginInit();
            this.SuspendLayout();
            // 
            // lblComputerID
            // 
            this.lblComputerID.Appearance.Font = new System.Drawing.Font("微软雅黑", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.lblComputerID.Appearance.ForeColor = System.Drawing.SystemColors.ControlText;
            this.lblComputerID.Appearance.Options.UseFont = true;
            this.lblComputerID.Appearance.Options.UseForeColor = true;
            this.lblComputerID.Location = new System.Drawing.Point(50, 37);
            this.lblComputerID.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.lblComputerID.Name = "lblComputerID";
            this.lblComputerID.Size = new System.Drawing.Size(73, 24);
            this.lblComputerID.TabIndex = 2;
            this.lblComputerID.Text = "注册标识:";
            // 
            // btnClose
            // 
            this.btnClose.Appearance.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnClose.Appearance.Options.UseFont = true;
            this.btnClose.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btnClose.Location = new System.Drawing.Point(362, 203);
            this.btnClose.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(86, 30);
            this.btnClose.TabIndex = 5;
            this.btnClose.Text = "关闭(&C)";
            // 
            // btnCopy
            // 
            this.btnCopy.Appearance.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCopy.Appearance.Options.UseFont = true;
            this.btnCopy.Location = new System.Drawing.Point(632, 33);
            this.btnCopy.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnCopy.Name = "btnCopy";
            this.btnCopy.Size = new System.Drawing.Size(86, 30);
            this.btnCopy.TabIndex = 6;
            this.btnCopy.Text = "复制(&D)";
            this.btnCopy.Click += new System.EventHandler(this.btnCopy_Click);
            // 
            // labelControl1
            // 
            this.labelControl1.Appearance.Font = new System.Drawing.Font("微软雅黑", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.labelControl1.Appearance.ForeColor = System.Drawing.SystemColors.ControlText;
            this.labelControl1.Appearance.Options.UseFont = true;
            this.labelControl1.Appearance.Options.UseForeColor = true;
            this.labelControl1.Location = new System.Drawing.Point(50, 124);
            this.labelControl1.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.labelControl1.Name = "labelControl1";
            this.labelControl1.Size = new System.Drawing.Size(73, 24);
            this.labelControl1.TabIndex = 7;
            this.labelControl1.Text = "注册文件:";
            // 
            // fdgLicenseFile
            // 
            this.fdgLicenseFile.FileName = "DQS.lic";
            this.fdgLicenseFile.Filter = "DQS注册文件(*.lic)|*.lic";
            this.fdgLicenseFile.Title = "导入DQS注册文件";
            this.fdgLicenseFile.FileOk += new System.ComponentModel.CancelEventHandler(this.fdgLicenseFile_FileOk);
            // 
            // btnBrowser
            // 
            this.btnBrowser.Appearance.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnBrowser.Appearance.Options.UseFont = true;
            this.btnBrowser.Location = new System.Drawing.Point(502, 120);
            this.btnBrowser.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnBrowser.Name = "btnBrowser";
            this.btnBrowser.Size = new System.Drawing.Size(86, 30);
            this.btnBrowser.TabIndex = 9;
            this.btnBrowser.Text = "浏览...";
            this.btnBrowser.Click += new System.EventHandler(this.btnBrowser_Click);
            // 
            // btnRegister
            // 
            this.btnRegister.Appearance.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnRegister.Appearance.Options.UseFont = true;
            this.btnRegister.Enabled = false;
            this.btnRegister.Location = new System.Drawing.Point(632, 118);
            this.btnRegister.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnRegister.Name = "btnRegister";
            this.btnRegister.Size = new System.Drawing.Size(86, 30);
            this.btnRegister.TabIndex = 10;
            this.btnRegister.Text = "注册(&R)";
            this.btnRegister.Click += new System.EventHandler(this.btnRegister_Click);
            // 
            // defaultLookAndFeel
            // 
            this.defaultLookAndFeel.LookAndFeel.SkinName = "McSkin";
            // 
            // txtLicenseFile
            // 
            this.txtLicenseFile.AlphabeticFiled = null;
            this.txtLicenseFile.IsIntegerOnly = false;
            this.txtLicenseFile.IsNullString = null;
            this.txtLicenseFile.IsNullValidate = false;
            this.txtLicenseFile.IsTransferAlphabetic = false;
            this.txtLicenseFile.Location = new System.Drawing.Point(134, 121);
            this.txtLicenseFile.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtLicenseFile.Name = "txtLicenseFile";
            this.txtLicenseFile.Properties.Appearance.Font = new System.Drawing.Font("微软雅黑", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtLicenseFile.Properties.Appearance.Options.UseFont = true;
            this.txtLicenseFile.Properties.ReadOnly = true;
            this.txtLicenseFile.Size = new System.Drawing.Size(362, 29);
            this.txtLicenseFile.TabIndex = 8;
            // 
            // txtComputerID
            // 
            this.txtComputerID.AlphabeticFiled = null;
            this.txtComputerID.IsIntegerOnly = false;
            this.txtComputerID.IsNullString = null;
            this.txtComputerID.IsNullValidate = false;
            this.txtComputerID.IsTransferAlphabetic = false;
            this.txtComputerID.Location = new System.Drawing.Point(134, 34);
            this.txtComputerID.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtComputerID.Name = "txtComputerID";
            this.txtComputerID.Properties.Appearance.Font = new System.Drawing.Font("微软雅黑", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtComputerID.Properties.Appearance.Options.UseFont = true;
            this.txtComputerID.Properties.ReadOnly = true;
            this.txtComputerID.Size = new System.Drawing.Size(467, 29);
            this.txtComputerID.TabIndex = 3;
            // 
            // FrmLicenserIdentification
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 18F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(775, 278);
            this.ControlBox = false;
            this.Controls.Add(this.btnRegister);
            this.Controls.Add(this.btnBrowser);
            this.Controls.Add(this.txtLicenseFile);
            this.Controls.Add(this.labelControl1);
            this.Controls.Add(this.btnClose);
            this.Controls.Add(this.btnCopy);
            this.Controls.Add(this.txtComputerID);
            this.Controls.Add(this.lblComputerID);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.LookAndFeel.SkinName = "Black";
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Name = "FrmLicenserIdentification";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "DQS注册";
            this.Load += new System.EventHandler(this.FrmLicenserIdentification_Load);
            ((System.ComponentModel.ISupportInitialize)(this.txtLicenseFile.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtComputerID.Properties)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Controls.TextBoxEx txtComputerID;
        private DevExpress.XtraEditors.LabelControl lblComputerID;
        private DevExpress.XtraEditors.SimpleButton btnClose;
        private DevExpress.XtraEditors.SimpleButton btnCopy;
        private Controls.TextBoxEx txtLicenseFile;
        private DevExpress.XtraEditors.LabelControl labelControl1;
        private System.Windows.Forms.OpenFileDialog fdgLicenseFile;
        private DevExpress.XtraEditors.SimpleButton btnBrowser;
        private DevExpress.XtraEditors.SimpleButton btnRegister;
        private DevExpress.LookAndFeel.DefaultLookAndFeel defaultLookAndFeel;
    }
}