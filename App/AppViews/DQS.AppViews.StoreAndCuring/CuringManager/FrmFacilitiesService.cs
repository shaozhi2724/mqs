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
    public partial class FrmFacilitiesService : XtraForm
    {
        int _FacilityID = 0;
        int _ServiceID = 0;
        public FrmFacilitiesService()
        {
            InitializeComponent();
        }
        public FrmFacilitiesService(int FacilityID)
        {
            InitializeComponent();
            _FacilityID = FacilityID;
        }
        public FrmFacilitiesService(int ServiceID, int FacilityID)
        {
            InitializeComponent();
            _FacilityID = FacilityID;
            _ServiceID = ServiceID;
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            using (SqlConnection conn = new SqlConnection(GlobalItem.g_DbConnectStrings))
            {
                string sql;
                if (_ServiceID != 0)
                {
                    sql = @"UPDATE BUS_FacilitiesService
SET
        RepairPerson = '{0}',
        RepairDate = {1},
        FacServicePerson = '{2}',
        FacServiceResult = '{3}',
        FulfillDate = {4},
        LastUser = '{5}',
        LastDate = GETDATE()
WHERE ID = {6}";
                    sql = string.Format(sql,
                        txtRepairPerson.Text,
                        dteRepairDate.Text == "" ? "NULL" : "'" + dteRepairDate.DateTime.ToString() + "'",
                        txtFacServicePerson.Text.Trim(),
                        txtFacServiceResult.Text.Trim(),
                        dteFulfillDate.Text == "" ? "NULL" : "'" + dteFulfillDate.DateTime.ToString() + "'",
                        GlobalItem.g_CurrentUser.UserName,
                        _ServiceID);
                }
                else
                {
                    sql = @"INSERT dbo.BUS_FacilitiesService(FacilityID,RepairPerson,RepairDate,FacServicePerson,FacServiceResult,FulfillDate,CreateUser,CreateDate)
VALUES ( {0} ,'{1}',{2},'{3}' ,'{4}',{5},'{6}',GETDATE())";
                    sql = string.Format(sql, _FacilityID,
                        txtRepairPerson.Text,
                        dteRepairDate.Text == "" ? "NULL" : "'" + dteRepairDate.DateTime.ToString() + "'",
                        txtFacServicePerson.Text.Trim(),
                        txtFacServiceResult.Text.Trim(),
                        dteFulfillDate.Text == "" ? "NULL" : "'" + dteFulfillDate.DateTime.ToString() + "'",
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

        private void FrmFacilitiesService_Load(object sender, EventArgs e)
        {
            if (_ServiceID != 0)
            {
                GetService();
            }
            else
            {
                txtCreateUser.Text = GlobalItem.g_CurrentUser.UserName;
            }
        }

        private void GetService()
        {
            using (SqlConnection conn = new SqlConnection(GlobalItem.g_DbConnectStrings))
            {
                string sql = @"SELECT RepairPerson ,RepairDate ,FacServicePerson ,FacServiceResult ,FulfillDate ,CreateUser FROM dbo.BUS_FacilitiesService WHERE ID = {0}";
                sql = string.Format(sql, _ServiceID);
                SqlDataAdapter sda = new SqlDataAdapter(sql, conn);
                DataSet ds = new DataSet();
                try
                {
                    sda.Fill(ds, "Table");
                    int i = ds.Tables["Table"].Rows.Count;
                    if (i > 0)
                    {
                        txtCreateUser.Text = ds.Tables["Table"].Rows[0]["CreateUser"].ToString();
                        txtFacServicePerson.Text = ds.Tables["Table"].Rows[0]["FacServicePerson"].ToString();
                        txtFacServiceResult.Text = ds.Tables["Table"].Rows[0]["FacServiceResult"].ToString();
                        txtRepairPerson.Text = ds.Tables["Table"].Rows[0]["RepairPerson"].ToString();
                        dteFulfillDate.Text = ds.Tables["Table"].Rows[0]["FulfillDate"].ToString() == "" ? "" : Convert.ToDateTime(ds.Tables["Table"].Rows[0]["FulfillDate"]).ToShortDateString();
                        dteRepairDate.Text = ds.Tables["Table"].Rows[0]["RepairDate"].ToString() == "" ? "" : Convert.ToDateTime(ds.Tables["Table"].Rows[0]["RepairDate"]).ToShortDateString();
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
