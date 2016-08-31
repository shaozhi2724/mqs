namespace DQS.App
{
    partial class FrmLogin
    {
        /// <summary>
        /// 必需的设计器变量。
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 清理所有正在使用的资源。
        /// </summary>
        /// <param name="disposing">如果应释放托管资源，为 true；否则为 false。</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows 窗体设计器生成的代码

        /// <summary>
        /// 设计器支持所需的方法 - 不要
        /// 使用代码编辑器修改此方法的内容。
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmLogin));
            this.lblUserCode = new DevExpress.XtraEditors.LabelControl();
            this.lblPassword = new DevExpress.XtraEditors.LabelControl();
            this.btnLogin = new DevExpress.XtraEditors.SimpleButton();
            this.btnClose = new DevExpress.XtraEditors.SimpleButton();
            this.lblUserError = new DevExpress.XtraEditors.LabelControl();
            this.lblPasswordError = new DevExpress.XtraEditors.LabelControl();
            this.btnDbConnect = new DevExpress.XtraEditors.SimpleButton();
            this.defaultLookAndFeel = new DevExpress.LookAndFeel.DefaultLookAndFeel(this.components);
            this.lblConn = new DevExpress.XtraEditors.LabelControl();
            this.cboConn = new DevExpress.XtraEditors.ComboBoxEdit();
            this.txtPassword = new DQS.Controls.TextBoxEx();
            this.txtUserCode = new DQS.Controls.TextBoxEx();
            this.btnConn = new DevExpress.XtraEditors.SimpleButton();
            ((System.ComponentModel.ISupportInitialize)(this.cboConn.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtPassword.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtUserCode.Properties)).BeginInit();
            this.SuspendLayout();
            // 
            // lblUserCode
            // 
            this.lblUserCode.Appearance.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.lblUserCode.Appearance.ForeColor = System.Drawing.Color.White;
            this.lblUserCode.Appearance.Options.UseFont = true;
            this.lblUserCode.Appearance.Options.UseForeColor = true;
            this.lblUserCode.Location = new System.Drawing.Point(512, 122);
            this.lblUserCode.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.lblUserCode.Name = "lblUserCode";
            this.lblUserCode.Size = new System.Drawing.Size(46, 17);
            this.lblUserCode.TabIndex = 0;
            this.lblUserCode.Text = "账号(&U):";
            // 
            // lblPassword
            // 
            this.lblPassword.Appearance.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.lblPassword.Appearance.ForeColor = System.Drawing.Color.White;
            this.lblPassword.Appearance.Options.UseFont = true;
            this.lblPassword.Appearance.Options.UseForeColor = true;
            this.lblPassword.Location = new System.Drawing.Point(512, 177);
            this.lblPassword.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.lblPassword.Name = "lblPassword";
            this.lblPassword.Size = new System.Drawing.Size(45, 17);
            this.lblPassword.TabIndex = 2;
            this.lblPassword.Text = "密码(&P):";
            // 
            // btnLogin
            // 
            this.btnLogin.Appearance.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLogin.Appearance.Options.UseFont = true;
            this.btnLogin.Location = new System.Drawing.Point(507, 267);
            this.btnLogin.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnLogin.Name = "btnLogin";
            this.btnLogin.Size = new System.Drawing.Size(75, 28);
            this.btnLogin.TabIndex = 4;
            this.btnLogin.Text = "登录(&L)";
            this.btnLogin.Click += new System.EventHandler(this.btnLogin_Click);
            // 
            // btnClose
            // 
            this.btnClose.Appearance.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnClose.Appearance.Options.UseFont = true;
            this.btnClose.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btnClose.Location = new System.Drawing.Point(690, 267);
            this.btnClose.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(75, 28);
            this.btnClose.TabIndex = 4;
            this.btnClose.Text = "关闭(&C)";
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // lblUserError
            // 
            this.lblUserError.Appearance.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblUserError.Appearance.ForeColor = System.Drawing.Color.Red;
            this.lblUserError.Appearance.Options.UseFont = true;
            this.lblUserError.Appearance.Options.UseForeColor = true;
            this.lblUserError.Location = new System.Drawing.Point(577, 146);
            this.lblUserError.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.lblUserError.Name = "lblUserError";
            this.lblUserError.Size = new System.Drawing.Size(97, 17);
            this.lblUserError.TabIndex = 5;
            this.lblUserError.Text = "lblUserErrorMsg";
            // 
            // lblPasswordError
            // 
            this.lblPasswordError.Appearance.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPasswordError.Appearance.ForeColor = System.Drawing.Color.Red;
            this.lblPasswordError.Appearance.Options.UseFont = true;
            this.lblPasswordError.Appearance.Options.UseForeColor = true;
            this.lblPasswordError.Location = new System.Drawing.Point(577, 202);
            this.lblPasswordError.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.lblPasswordError.Name = "lblPasswordError";
            this.lblPasswordError.Size = new System.Drawing.Size(126, 17);
            this.lblPasswordError.TabIndex = 5;
            this.lblPasswordError.Text = "lblPasswordErrorMsg";
            // 
            // btnDbConnect
            // 
            this.btnDbConnect.Appearance.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDbConnect.Appearance.Options.UseFont = true;
            this.btnDbConnect.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btnDbConnect.Location = new System.Drawing.Point(591, 267);
            this.btnDbConnect.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnDbConnect.Name = "btnDbConnect";
            this.btnDbConnect.Size = new System.Drawing.Size(90, 28);
            this.btnDbConnect.TabIndex = 6;
            this.btnDbConnect.Text = "数据库连接(&T)";
            this.btnDbConnect.Click += new System.EventHandler(this.btnDbConnect_Click);
            // 
            // defaultLookAndFeel
            // 
            this.defaultLookAndFeel.LookAndFeel.SkinName = "McSkin";
            // 
            // lblConn
            // 
            this.lblConn.Appearance.ForeColor = System.Drawing.Color.DodgerBlue;
            this.lblConn.Appearance.Options.UseForeColor = true;
            this.lblConn.Location = new System.Drawing.Point(512, 231);
            this.lblConn.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.lblConn.Name = "lblConn";
            this.lblConn.Size = new System.Drawing.Size(52, 14);
            this.lblConn.TabIndex = 0;
            this.lblConn.Text = "帐套选择:";
            this.lblConn.Visible = false;
            // 
            // cboConn
            // 
            this.cboConn.Location = new System.Drawing.Point(577, 227);
            this.cboConn.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.cboConn.Name = "cboConn";
            this.cboConn.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.cboConn.Size = new System.Drawing.Size(113, 21);
            this.cboConn.TabIndex = 8;
            this.cboConn.Visible = false;
            this.cboConn.SelectedIndexChanged += new System.EventHandler(this.cboConn_SelectedIndexChanged);
            this.cboConn.TextChanged += new System.EventHandler(this.txtUserCode_TextChanged);
            // 
            // txtPassword
            // 
            this.txtPassword.AlphabeticFiled = null;
            this.txtPassword.IsIntegerOnly = false;
            this.txtPassword.IsNullString = null;
            this.txtPassword.IsNullValidate = false;
            this.txtPassword.IsTransferAlphabetic = false;
            this.txtPassword.Location = new System.Drawing.Point(577, 174);
            this.txtPassword.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtPassword.Name = "txtPassword";
            this.txtPassword.Properties.PasswordChar = '●';
            this.txtPassword.Size = new System.Drawing.Size(188, 21);
            this.txtPassword.TabIndex = 2;
            this.txtPassword.TextChanged += new System.EventHandler(this.txtPassword_TextChanged);
            // 
            // txtUserCode
            // 
            this.txtUserCode.AlphabeticFiled = null;
            this.txtUserCode.IsIntegerOnly = false;
            this.txtUserCode.IsNullString = null;
            this.txtUserCode.IsNullValidate = false;
            this.txtUserCode.IsTransferAlphabetic = false;
            this.txtUserCode.Location = new System.Drawing.Point(577, 118);
            this.txtUserCode.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtUserCode.Name = "txtUserCode";
            this.txtUserCode.Size = new System.Drawing.Size(188, 21);
            this.txtUserCode.TabIndex = 1;
            this.txtUserCode.TextChanged += new System.EventHandler(this.txtUserCode_TextChanged);
            // 
            // btnConn
            // 
            this.btnConn.Location = new System.Drawing.Point(709, 223);
            this.btnConn.Name = "btnConn";
            this.btnConn.Size = new System.Drawing.Size(56, 28);
            this.btnConn.TabIndex = 7;
            this.btnConn.Text = "连接";
            this.btnConn.Click += new System.EventHandler(this.btnConn_Click);
            // 
            // FrmLogin
            // 
            this.AcceptButton = this.btnLogin;
            this.Appearance.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Appearance.Options.UseFont = true;
            this.Appearance.Options.UseImage = true;
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 17F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImageLayoutStore = System.Windows.Forms.ImageLayout.Tile;
            this.BackgroundImageStore = global::DQS.App.Properties.Resources.登录背景;
            this.CancelButton = this.btnClose;
            this.ClientSize = new System.Drawing.Size(812, 380);
            this.Controls.Add(this.btnConn);
            this.Controls.Add(this.btnDbConnect);
            this.Controls.Add(this.lblPasswordError);
            this.Controls.Add(this.lblUserError);
            this.Controls.Add(this.btnClose);
            this.Controls.Add(this.btnLogin);
            this.Controls.Add(this.txtPassword);
            this.Controls.Add(this.txtUserCode);
            this.Controls.Add(this.lblPassword);
            this.Controls.Add(this.lblConn);
            this.Controls.Add(this.lblUserCode);
            this.Controls.Add(this.cboConn);
            this.DoubleBuffered = true;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.LookAndFeel.SkinName = "Black";
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FrmLogin";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "登录";
            this.Load += new System.EventHandler(this.FrmLogin_Load);
            this.MouseDown += new System.Windows.Forms.MouseEventHandler(this.FrmLogin_MouseDown);
            ((System.ComponentModel.ISupportInitialize)(this.cboConn.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtPassword.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtUserCode.Properties)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private DevExpress.XtraEditors.LabelControl lblUserCode;
        private DevExpress.XtraEditors.LabelControl lblPassword;
        private DQS.Controls.TextBoxEx txtUserCode;
        private DQS.Controls.TextBoxEx txtPassword;
        private DevExpress.XtraEditors.SimpleButton btnLogin;
        private DevExpress.XtraEditors.SimpleButton btnClose;
        private DevExpress.XtraEditors.LabelControl lblUserError;
        private DevExpress.XtraEditors.LabelControl lblPasswordError;
        private DevExpress.XtraEditors.SimpleButton btnDbConnect;
        private DevExpress.LookAndFeel.DefaultLookAndFeel defaultLookAndFeel;
        private DevExpress.XtraEditors.LabelControl lblConn;
        private DevExpress.XtraEditors.ComboBoxEdit cboConn;
        private DevExpress.XtraEditors.SimpleButton btnConn;
    }
}

