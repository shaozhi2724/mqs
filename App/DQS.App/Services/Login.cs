using DQS.Common;
using DQS.Module.Entities;
using ORMSCore;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Xml;

namespace DQS.App.Services
{
    public class Login : ILogin
    {
        public void verificationLogintxt(string userCode, out string codeError, string password, out string pwdError)
        {
            if (userCode.Length <= 0)
            {
                codeError = "账号不能为空.";
                pwdError = "";
            }

            if (password.Length <= 0)
            {
                codeError = "";
                pwdError = "密码不能为空.";
            }
            codeError = "";
            pwdError = "";
        }
        public void Logintxt(string userCode, out string codeError, string password, out string pwdError)
        {
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
                    codeError = "账号不存在.";
                    pwdError = "";
                    return;
                }

                if (GlobalMethod.GetEncryptPassword(password) != user.UserPassword)
                {
                    codeError = "";
                    pwdError = "密码错误.";
                    return;
                }

                if (user.UserStatus == 2)
                {
                    codeError = "账号已被禁用，无法登录。请联系管理员。";
                    pwdError = "";
                    return;
                }
            }

            GlobalItem.g_CurrentUser = user;
            GlobalItem.g_IsLoginIn = true;
            if (userCode != "root") //root最高权限
            {
                BFIEmployeeEntity employee = new BFIEmployeeEntity { EmployeeID = user.EmployeeID };
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

            codeError = "";
            pwdError = "";
        }
        public List<SYSConnection> getConnList(out string cboText)
        {
            List<SYSConnection> conns = new List<SYSConnection>();
            conns.Clear();
            string txt = "";
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

                        foreach (var item in conns)
                        {
                            if (item.ServerName == conn.DataSource && item.DBName == conn.Database)
                            {
                                txt = item.ConnName;
                            }
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
                cboText = txt;
                return conns;
            }
        }
        public bool isVisible(out string EnterpriseName)
        {
            BFIEnterpriseEntity enterprise = new BFIEnterpriseEntity { EnterpriseID = 1 };
            enterprise.Fetch();
            EnterpriseName = enterprise.EnterpriseName;
            bool isVisible = enterprise.Reservation10 == "True" ? true : false;
            return isVisible;
        }
        public void SaveConfiguration(string connection)
        {
            XmlDocument myDoc = new XmlDocument();
            myDoc.Load(Application.ExecutablePath + ".config");
            XmlNode myNode = myDoc.SelectSingleNode("//connectionStrings");
            XmlElement myXmlElement = (XmlElement)myNode.SelectSingleNode("//add [@name='DbConnectStrings']");
            myXmlElement.SetAttribute("connectionString", connection);
            myDoc.Save(Application.ExecutablePath + ".config");
            ConfigurationManager.RefreshSection("connectionStrings");
            //保存数据库连接
            GlobalItem.g_DbConnectStrings = connection;
            CommonSettings.DbConnectStrings = connection;
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

        public SYSConnection(int id, string connName, string serverName, string dbName, string userID, string pwd, string remark)
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
