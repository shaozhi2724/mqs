using System.Configuration;
using System.Threading;
using System.Xml.Linq;
using DevExpress.XtraEditors;
using DQS.App.Properties;
using DQS.Common;
using DQS.Module.Entities;
using System;
using System.Reflection;
using System.Runtime.InteropServices;
using System.Windows.Forms;
using System.Xml;
using ORMSCore;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Data;
using DQS.App.Services;

namespace DQS.App
{
    public partial class FrmLogin : XtraForm
    {

        ILogin _login;

        List<SYSConnection> conns = new List<SYSConnection>();
        public FrmLogin()
        {
            InitializeComponent();
            _login = new Login();
        }
        private void ShowUpdateDialog(Version appVersion, Version newVersion, XDocument doc)
        {
            if (InvokeRequired)
            {
                Invoke(new Action<Version, Version, XDocument>(ShowUpdateDialog), appVersion, newVersion, doc);
                return;
            }

            using (UpdateForm f = new UpdateForm())
            {
                f.Text = string.Format(f.Text, Application.ProductName, appVersion);
                f.MoreInfoLink = (string)doc.Root.Element("info");
                f.Info = string.Format(f.Info, newVersion, (DateTime)doc.Root.Element("date"));
                if (f.ShowDialog(this) == DialogResult.OK)
                {
                    Updater.LaunchUpdater(doc);
                    Application.Exit();
                }
            }
        }
        //加载数据库选项
        private void LoadCbo()
        {
            string cboText;
            List<SYSConnection> conns = _login.getConnList(out cboText);
            cboConn.Properties.Items.Clear();
            foreach (var item in conns)
            {
                cboConn.Properties.Items.Add(item.ConnName);
            }
            cboConn.Text = cboText;
        }

        private void FrmLogin_Load(object sender, EventArgs e)
        {
            if (Settings.Default.AutoCheckForUpdate)
            {
                ThreadPool.QueueUserWorkItem((w) => Updater.CheckForUpdate(ShowUpdateDialog));
            }
            if (!_login.CanCn())
            {
            /*
                using (FrmNewConnIP frm = new FrmNewConnIP())
                {
                    DialogResult dr = frm.ShowDialog();
                    if (dr == DialogResult.Cancel)
                    {
                        return;
                    }
                    if (dr == DialogResult.Yes)
                    {
                        FrmLogin_Load(null, null);
                    }
                }
            */
                MessageBox.Show("未连接服务器");
                return;
            }
            LoadVersion();
        }

        private void LoadVersion()
        {
            this.Text = "登录";
            this.lblUserError.Text = "";
            this.lblPasswordError.Text = "";
            string EnterpriseName;
            this.Text += " - V " + Assembly.GetExecutingAssembly().GetName().Version.ToString();
            bool isVisible = _login.isVisible(out EnterpriseName);
            this.Text += " - " + EnterpriseName;
            this.lblConn.Visible = isVisible;
            this.cboConn.Visible = isVisible;
            this.btnConn.Visible = isVisible;

            if (isVisible)
            {
                LoadCbo();
            }
        }

        private void txtUserCode_TextChanged(object sender, EventArgs e)
        {
            this.lblUserError.Text = "";
        }

        private void txtPassword_TextChanged(object sender, EventArgs e)
        {
            this.lblPasswordError.Text = "";
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            //验证
            if(!verificationLogintxt()) return;
            //登录
            loginSys();
        }
        //验证登录
        private void loginSys()
        {
            string userCode = this.txtUserCode.Text.Trim();
            string password = this.txtPassword.Text.Trim();
            string UserError;
            string PasswordError;
            _login.Logintxt(userCode, out UserError, password, out PasswordError);

            if (UserError.Length > 0)
            {
                this.lblUserError.Text = UserError;
                this.txtUserCode.Focus();
                this.txtUserCode.Select(0, this.txtUserCode.Text.Length);
                return;
            }

            if (PasswordError.Length > 0)
            {
                this.lblPasswordError.Text = PasswordError;
                this.txtPassword.Focus();
                this.txtPassword.Select(0, this.txtPassword.Text.Length);
                return;
            }
            //关闭
            this.Close();
        }
        //验证文本框
        private bool verificationLogintxt()
        {
            string userCode = this.txtUserCode.Text.Trim();
            string password = this.txtPassword.Text.Trim();
            string UserError;
            string PasswordError;
            _login.verificationLogintxt(userCode,out UserError,password,out PasswordError);
            if (UserError.Length > 0)
            {
                this.lblUserError.Text = UserError;
                this.txtUserCode.Focus();
                return false;
            }

            if (PasswordError.Length > 0)
            {
                this.lblPasswordError.Text = PasswordError;
                this.txtPassword.Focus();
                return false;
            }
            return true;
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        #region 点击窗体任意位置拖动窗体

        [DllImport("user32.dll")]
        public static extern bool ReleaseCapture();

        [DllImport("user32.dll")]
        public static extern bool SendMessage(IntPtr hwnd, int wMsg, int wParam, int lParam);
        public const int WM_SYSCOMMAND = 0x0112;
        public const int SC_MOVE = 0xF010;
        public const int HTCAPTION = 0x0002;

        private void FrmLogin_MouseDown(object sender, MouseEventArgs e)
        {
            ReleaseCapture();
            SendMessage(this.Handle, WM_SYSCOMMAND, SC_MOVE + HTCAPTION, 0);
        }
        #endregion

        private void btnDbConnect_Click(object sender, EventArgs e)
        {
            FrmDbSetting dcDialog = new FrmDbSetting();
            dcDialog.ConnectionString = GlobalItem.g_DbConnectStrings;
            if (dcDialog.ShowDialog(this) == DialogResult.OK)
            {
                _login.SaveConfiguration(dcDialog.ConnectionString);
                LoadVersion();
            }
        }

        private void cboConn_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void btnConn_Click(object sender, EventArgs e)
        {
            string cboText = "";
            List<SYSConnection> conns = _login.getConnList(out cboText);
            string ConnectionString = "";
            foreach (var item in conns)
            {
                if (item.ConnName == cboConn.Text.Trim())
                {
                    ConnectionString = new SqlConnectionStringBuilder
                    {
                        DataSource = item.ServerName,
                        InitialCatalog = item.DBName,
                        IntegratedSecurity = false,
                        UserID = item.UserID,
                        Password = item.PWD,
                        ConnectTimeout = 120
                    }.ConnectionString;
                    break;
                }
            }

            XmlDocument myDoc = new XmlDocument();
            myDoc.Load(Application.ExecutablePath + ".config");
            XmlNode myNode = myDoc.SelectSingleNode("//connectionStrings");
            XmlElement myXmlElement = (XmlElement)myNode.SelectSingleNode("//add [@name='DbConnectStrings']");
            myXmlElement.SetAttribute("connectionString", ConnectionString);
            myDoc.Save(Application.ExecutablePath + ".config");
            ConfigurationManager.RefreshSection("connectionStrings");
            //保存数据库连接
            GlobalItem.g_DbConnectStrings = ConnectionString;
            CommonSettings.DbConnectStrings = ConnectionString;

            FrmLogin_Load(null, null);
        }
    }
}
