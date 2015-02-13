using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data.SqlClient;
using System.Windows.Forms;
using DevExpress.XtraEditors;

namespace DQS.App
{
    public partial class FrmDbSetting : DevExpress.XtraEditors.XtraForm
    {
        public FrmDbSetting()
        {
            InitializeComponent();
        }

        public string ConnectionString { get; set; }

        private void FrmDbSetting_Load(object sender, EventArgs e)
        {
            this.lblUserID.Enabled = false;
            this.txtUserID.Enabled = false;

            this.lblPassword.Enabled = false;
            this.txtPassword.Enabled = false;
            if(!string.IsNullOrWhiteSpace(ConnectionString))
            {
                SqlConnection sqlConnection = new SqlConnection();
                sqlConnection.ConnectionString = ConnectionString;
                txtServer.Text = sqlConnection.DataSource;
                txtDatabase.Text = sqlConnection.Database;
            }
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnOK_Click(object sender, EventArgs e)
        {
            if (ValidatePage(true))
            {
                if (DialogResult.Yes ==
                    XtraMessageBox.Show(this, "修改数据库连接可能导致程序不能运行，确定修改?", "系统提示", MessageBoxButtons.YesNo,
                        MessageBoxIcon.Warning))
                {
                    if (radSecurity.SelectedIndex == 0)
                    {
                        ConnectionString = GenerateSQLConnectionString(txtServer.Text.Trim(),
                            txtDatabase.Text.Trim());
                    }
                    else
                    {
                        ConnectionString = GenerateSQLConnectionString(txtServer.Text.Trim(), txtDatabase.Text.Trim(),
                            txtUserID.Text.Trim(), txtPassword.Text.Trim());
                    }


                    this.DialogResult = DialogResult.OK;
                }
                this.Close();
            }
        }

        private void radSecurity_SelectedIndexChanged(object sender, EventArgs e)
        {
            // Enable/disable the authentication parameters
            lblUserID.Enabled = radSecurity.SelectedIndex == 1;
            txtUserID.Enabled = radSecurity.SelectedIndex == 1;
            lblPassword.Enabled = radSecurity.SelectedIndex == 1;
            txtPassword.Enabled = radSecurity.SelectedIndex == 1;
        }
        private bool ValidatePage(bool triggerErrors)
        {
            // Start off assuming the page IS valid
            bool pageIsValid = true;

            if (string.IsNullOrEmpty(txtServer.Text.Trim()))
            {
                if (triggerErrors)
                {
                    errorProvider.SetError(txtServer,
                        "请指定数据库服务器名称！");
                }

                pageIsValid = false;
            }
            else
            {
                errorProvider.SetError(txtDatabase, string.Empty);
            }

            if (string.IsNullOrEmpty(txtDatabase.Text.Trim()))
            {
                if (triggerErrors)
                {
                    errorProvider.SetError(txtDatabase, "请指定数据库名称！");
                }

                pageIsValid = false;
            }
            else
            {
                errorProvider.SetError(txtDatabase, string.Empty);
            }

            if (radSecurity.SelectedIndex == 1)
            {
                if (string.IsNullOrEmpty(txtUserID.Text.Trim()))
                {
                    if (triggerErrors)
                    {
                        errorProvider.SetError(txtUserID,
                            "如果未勾选“Windows身份认证”，请指定数据库登录用户名！");
                    }

                    pageIsValid = false;
                }
                else
                {
                    errorProvider.SetError(txtUserID, string.Empty);
                }

                if (string.IsNullOrEmpty(txtPassword.Text.Trim()))
                {
                    if (triggerErrors)
                    {
                        errorProvider.SetError(txtPassword,
                            "如果未勾选“Windows身份认证”，请指定数据库登录密码！");
                    }

                    pageIsValid = false;
                }
                else
                {
                    errorProvider.SetError(txtPassword, string.Empty);
                }
            }

            return pageIsValid;
        }


        public static string GenerateSQLConnectionString(string existingConnectionString)
        {
            Dictionary<string, string> connectionParameters = new Dictionary<string, string>();

            string[] nameValuePairs = existingConnectionString.Split(';');
            foreach (string nameValuePair in nameValuePairs)
            {
                connectionParameters.Add(nameValuePair.Split('=')[0].ToUpper(), nameValuePair.Split('=')[1]);
            }

            string dataSource = string.Empty;
            string initialCatalog = string.Empty;
            string integratedSecurity = string.Empty;
            string password = string.Empty;
            string userID = string.Empty;
            string connectTimeout = string.Empty;

            connectionParameters.TryGetValue("DATA SOURCE", out dataSource);
            connectionParameters.TryGetValue("INITIAL CATALOG", out initialCatalog);
            connectionParameters.TryGetValue("INTEGRATED SECURITY", out integratedSecurity);
            connectionParameters.TryGetValue("PASSWORD", out password);
            connectionParameters.TryGetValue("USER ID", out userID);
            connectionParameters.TryGetValue("CONNECT TIMEOUT", out connectTimeout);

            if (string.IsNullOrEmpty(connectTimeout))
            {
                connectTimeout = "120";
            }

            if (integratedSecurity != null &&
                (integratedSecurity.ToUpper().Equals("SSPI") || integratedSecurity.ToUpper().Equals("TRUE")))
            {
                return
                    new SqlConnectionStringBuilder
                    {
                        DataSource = dataSource,
                        InitialCatalog = initialCatalog,
                        IntegratedSecurity = true,
                        ConnectTimeout = Convert.ToInt32(connectTimeout),
                        MultipleActiveResultSets = true
                    }.ConnectionString;
            }
            return new SqlConnectionStringBuilder { DataSource = dataSource, InitialCatalog = initialCatalog, IntegratedSecurity = false, UserID = userID, Password = password, ConnectTimeout = Convert.ToInt32(connectTimeout), MultipleActiveResultSets = true }.ConnectionString;
        }

        public static string GenerateSQLConnectionString(string dataSource, string initialCatalog)
        {
            return new SqlConnectionStringBuilder { DataSource = dataSource, InitialCatalog = initialCatalog, IntegratedSecurity = true, ConnectTimeout = 120 }.ConnectionString;
        }

        public static string GenerateSQLConnectionString(string dataSource, string initialCatalog, string userID, string password)
        {
            return new SqlConnectionStringBuilder { DataSource = dataSource, InitialCatalog = initialCatalog, IntegratedSecurity = false, UserID = userID, Password = password, ConnectTimeout = 120 }.ConnectionString;
        }
    }
}