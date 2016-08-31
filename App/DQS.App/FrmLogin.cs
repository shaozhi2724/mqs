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

namespace DQS.App
{
    public partial class FrmLogin : XtraForm
    {

        List<SYSConnection> conns = new List<SYSConnection>();
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

        private void LoadCbo()
        {
            conns.Clear();
            cboConn.Properties.Items.Clear();
            using (SqlConnection conn = new SqlConnection(GlobalItem.g_DbConnectStrings))
            {
                string sql = "SELECT * FROM dbo.SYS_Connection";
                SqlDataAdapter sda = new SqlDataAdapter(sql, conn);
                DataSet ds = new DataSet();
                try
                {
                    sda.Fill(ds, "Table");
                    for (int i = 0; i < ds.Tables["Table"].Rows.Count; i++)
                    {
                        SYSConnection connDB = new SYSConnection();
                        connDB.ID = int.Parse(ds.Tables["Table"].Rows[i]["ID"].ToString());
                        connDB.ConnName = ds.Tables["Table"].Rows[i]["ConnName"].ToString();
                        connDB.ServerName = ds.Tables["Table"].Rows[i]["ServerName"].ToString();
                        connDB.DBName = ds.Tables["Table"].Rows[i]["DBName"].ToString();
                        connDB.UserID = ds.Tables["Table"].Rows[i]["UserID"].ToString();
                        connDB.PWD = ds.Tables["Table"].Rows[i]["PWD"].ToString();
                        connDB.Remark = ds.Tables["Table"].Rows[i]["Remark"].ToString();
                        conns.Add(connDB);
                        cboConn.Properties.Items.Add(connDB.ConnName);
                    }

                    foreach (var item in conns)
                    {
                        if (item.ServerName == conn.DataSource && item.DBName == conn.Database)
                        {
                            cboConn.Text = item.ConnName;
                        }
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.ToString());
                }
                finally
                {
                    conn.Close();
                }
            }
        }

        private void FrmLogin_Load(object sender, EventArgs e)
        {
            this.Text = "登录";
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
            bool isVisible = enterprise.Reservation10 == "True" ? true : false;
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

        private void cboConn_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void btnConn_Click(object sender, EventArgs e)
        {
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
    public class SYSConnection
    {
        public int ID { get; set; }
        public string ConnName { get; set; }
        public string ServerName { get; set; }
        public string DBName { get; set; }
        public string UserID { get; set; }
        public string PWD { get; set; }
        public string Remark { get; set; }

        public SYSConnection() { }

        public SYSConnection(int id,string connName,string serverName,string dbName,string userID,string pwd,string remark)
        {
            this.ID = id;
            this.ConnName = connName;
            this.ServerName = serverName;
            this.DBName = dbName;
            this.UserID = userID;
            this.PWD = pwd;
            this.Remark = remark;
        }
    }
}
