using DevExpress.XtraEditors;
using DQS.App.Services;
using DQS.Common;
using ORMSCore;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Xml;

namespace DQS.App
{
    public partial class FrmNewConnIP : XtraForm
    {

        ILogin _login;
        public FrmNewConnIP()
        {
            InitializeComponent();
        }

        private void btnConn_Click(object sender, EventArgs e)
        {
            SqlConnectionStringBuilder sqlConnection = new SqlConnectionStringBuilder();
            sqlConnection.ConnectionString = GlobalItem.g_DbConnectStrings;
            string ip = txtIP.Text.Trim();
            string ConnectionString = "";

                    ConnectionString = new SqlConnectionStringBuilder
                    {
                        DataSource = ip,
                        InitialCatalog = sqlConnection.InitialCatalog,
                        IntegratedSecurity = false,
                        UserID = sqlConnection.UserID,
                        Password = sqlConnection.Password,
                        ConnectTimeout = 120
                    }.ConnectionString;

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

            this.DialogResult = DialogResult.Yes;
        }
    }
}
