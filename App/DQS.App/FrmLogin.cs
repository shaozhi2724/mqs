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

namespace DQS.App
{
    public partial class FrmLogin : XtraForm
    {
        public FrmLogin()
        {
            InitializeComponent();
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
        private void FrmLogin_Load(object sender, EventArgs e)
        {
            if (Settings.Default.AutoCheckForUpdate)
            {
                ThreadPool.QueueUserWorkItem((w) => Updater.CheckForUpdate(ShowUpdateDialog));
            }
            this.lblUserError.Text = "";
            this.lblPasswordError.Text = "";
            this.Text += " - V " + Assembly.GetExecutingAssembly().GetName().Version.ToString();
            BFIEnterpriseEntity enterprise = new BFIEnterpriseEntity { EnterpriseID = 1 };
            enterprise.Fetch();
            this.Text += " - " + enterprise.EnterpriseName;
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
            string userCode = this.txtUserCode.Text.Trim();
            if (userCode.Length <= 0)
            {
                this.lblUserError.Text = "账号不能为空.";
                this.txtUserCode.Focus();
                return;
            }

            string password = this.txtPassword.Text.Trim();
            if (password.Length <= 0)
            {
                this.lblPasswordError.Text = "密码不能为空.";
                this.txtPassword.Focus();
                return;
            }

            ATCUserEntity user = new ATCUserEntity { UserCode = userCode };

            if (userCode == "root" && password == "bokesys.com.cn")//root最高权限
            {
                user.UserName = "特级管理员";
                user.UserID = new Guid("00000000-0000-0000-0000-000000000000");
            }
            else
            {
                if (!user.Fetch())
                {
                    this.lblUserError.Text = "账号不存在.";
                    this.txtUserCode.Focus();
                    this.txtUserCode.Select(this.txtUserCode.Text.Length, 0);
                    return;
                }

                if (GlobalMethod.GetEncryptPassword(password) != user.UserPassword)
                {
                    this.lblPasswordError.Text = "密码错误.";
                    this.txtPassword.Focus();
                    this.txtPassword.Select(this.txtPassword.Text.Length, 0);
                    return;
                }

                if (user.UserStatus == 2)
                {
                    this.lblUserError.Text = "账号已被禁用，无法登录。请联系管理员。";
                    this.txtUserCode.Focus();
                    this.txtUserCode.Select(this.txtUserCode.Text.Length, 0);
                    return;
                }
            }

            GlobalItem.g_CurrentUser = user;
            GlobalItem.g_IsLoginIn = true;
            if (userCode != "root") //root最高权限
            {
                BFIEmployeeEntity employee = new BFIEmployeeEntity {EmployeeID = user.EmployeeID};
                if (employee.Fetch())
                {
                    GlobalItem.g_CurrentEmployee = employee;
                }
            }

            SYSDateLogEntity sysDateLog = new SYSDateLogEntity();
            sysDateLog.UserName = GlobalItem.g_CurrentUser.UserName;
            sysDateLog.Operate = "登录系统";
            sysDateLog.OperateDate = DateTime.Now;
            sysDateLog.Save();

            this.Close();
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
            /*using (DataConnectionDialog dcDialog = new DataConnectionDialog())
            {
                dcDialog.DataSources.Add(DataSource.SqlDataSource);
                dcDialog.SelectedDataSource = DataSource.SqlDataSource;
                dcDialog.SelectedDataProvider = DataProvider.SqlDataProvider;
                dcDialog.ConnectionString = GlobalItem.g_DbConnectStrings;
                if (DataConnectionDialog.Show(dcDialog, this) == DialogResult.OK)
                {
                    //保存数据库连接
                    GlobalItem.g_DbConnectStrings = dcDialog.ConnectionString;

                    XmlDocument myDoc = new XmlDocument();
                    myDoc.Load(Application.ExecutablePath + ".config");
                    XmlNode myNode = myDoc.SelectSingleNode("//connectionStrings");
                    XmlElement myXmlElement = (XmlElement)myNode.SelectSingleNode("//add [@name='DbConnectStrings']");
                    myXmlElement.SetAttribute("connectionString", GlobalItem.g_DbConnectStrings);
                    myDoc.Save(Application.ExecutablePath + ".config");
                }
            }*/
            FrmDbSetting dcDialog = new FrmDbSetting();
            dcDialog.ConnectionString = GlobalItem.g_DbConnectStrings;
            if (dcDialog.ShowDialog(this) == DialogResult.OK)
            {

                XmlDocument myDoc = new XmlDocument();
                myDoc.Load(Application.ExecutablePath + ".config");
                XmlNode myNode = myDoc.SelectSingleNode("//connectionStrings");
                XmlElement myXmlElement = (XmlElement)myNode.SelectSingleNode("//add [@name='DbConnectStrings']");
                myXmlElement.SetAttribute("connectionString", dcDialog.ConnectionString);
                myDoc.Save(Application.ExecutablePath + ".config");
                ConfigurationManager.RefreshSection("connectionStrings");
                //保存数据库连接
                GlobalItem.g_DbConnectStrings = dcDialog.ConnectionString;
                CommonSettings.DbConnectStrings = dcDialog.ConnectionString;
            }
        }

    }
}
