using DevExpress.XtraEditors;
using DQS.Common;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace DQS.AppViews.StoreAndCuring.CuringManager
{
    public partial class FrmFacilitiesVerification : XtraForm
    {
        int _FacilityID = 0;
        int _VerificationID = 0;
        public FrmFacilitiesVerification()
        {
            InitializeComponent();
        }
        public FrmFacilitiesVerification(int FacilityID)
        {
            InitializeComponent();
            _FacilityID = FacilityID;
        }
        public FrmFacilitiesVerification(int VerificationID,int FacilityID)
        {
            InitializeComponent();
            _FacilityID = FacilityID;
            _VerificationID = VerificationID;
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            using (SqlConnection conn = new SqlConnection(GlobalItem.g_DbConnectStrings))
            {
                string sql;
                if (_VerificationID != 0)
                {
                    sql = @"UPDATE dbo.BUS_FacilitiesVerification 
SET VerificationDate =  {0},
VerificationValiDate = {1} ,
VerificationDealer = '{2}',
VerificationContent = '{3}',
VerificationResult = '{4}',
LastUser = '{5}',
LastDate = GETDATE()
WHERE ID = {6}";
                    sql = string.Format(sql,
                        dteVerificationDate.Text == "" ? "NULL" : "'" + dteVerificationDate.DateTime.ToString() + "'",
                        dteVerificationValiDate.Text == "" ? "NULL" : "'" + dteVerificationValiDate.DateTime.ToString() + "'",
                        txtVerificationDealer.Text.Trim(),
                        txtVerificationContent.Text.Trim(),
                        txtVerificationResult.Text.Trim(),
                        GlobalItem.g_CurrentUser.UserName,
                        _VerificationID);
                }
                else
                {
                    sql = @"INSERT dbo.BUS_FacilitiesVerification(FacilityID,VerificationDate,VerificationValiDate,VerificationDealer,VerificationContent,VerificationResult,CreateUser,CreateDate)
VALUES  ({0} ,{1},{2},'{3}','{4}','{5}','{6}',GETDATE())";
                    sql = string.Format(sql, _FacilityID,
                        dteVerificationDate.Text == "" ? "NULL" : "'" + dteVerificationDate.DateTime.ToString() + "'",
                        dteVerificationValiDate.Text == "" ? "NULL" : "'" + dteVerificationValiDate.DateTime.ToString() + "'",
                        txtVerificationDealer.Text.Trim(),
                        txtVerificationContent.Text.Trim(),
                        txtVerificationResult.Text.Trim(),
                        txtCreateUser.Text.Trim());
                }
                try
                {
                    conn.Open();
                    SqlCommand comm = new SqlCommand(sql, conn);
                    comm.ExecuteNonQuery();
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
            this.DialogResult = DialogResult.OK;
        }

        private void FrmFacilitiesVerification_Load(object sender, EventArgs e)
        {
            if (_VerificationID != 0)
            {
                GetVerification();
            }
            else
            {
                txtCreateUser.Text = GlobalItem.g_CurrentUser.UserName;
            }
        }

        private void GetVerification()
        {
            using (SqlConnection conn = new SqlConnection(GlobalItem.g_DbConnectStrings))
            {
                string sql = @"SELECT VerificationDate ,VerificationValiDate ,VerificationDealer ,VerificationContent ,VerificationResult ,CreateUser 
FROM dbo.BUS_FacilitiesVerification WHERE ID = {0}";
                sql = string.Format(sql, _VerificationID);
                SqlDataAdapter sda = new SqlDataAdapter(sql, conn);
                DataSet ds = new DataSet();
                try
                {
                    sda.Fill(ds, "Table");
                    int i = ds.Tables["Table"].Rows.Count;
                    if (i > 0)
                    {
                        txtCreateUser.Text = ds.Tables["Table"].Rows[0]["CreateUser"].ToString();
                        txtVerificationContent.Text = ds.Tables["Table"].Rows[0]["VerificationContent"].ToString();
                        txtVerificationDealer.Text = ds.Tables["Table"].Rows[0]["VerificationDealer"].ToString();
                        txtVerificationResult.Text = ds.Tables["Table"].Rows[0]["VerificationResult"].ToString();
                        dteVerificationDate.Text = ds.Tables["Table"].Rows[0]["VerificationDate"].ToString() == "" ? "" : Convert.ToDateTime(ds.Tables["Table"].Rows[0]["VerificationDate"]).ToShortDateString();
                        dteVerificationValiDate.Text = ds.Tables["Table"].Rows[0]["VerificationValiDate"].ToString() == "" ? "" : Convert.ToDateTime(ds.Tables["Table"].Rows[0]["VerificationValiDate"]).ToShortDateString();
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
    }
}
