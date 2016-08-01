using DevExpress.XtraEditors;
using DevExpress.XtraEditors.Repository;
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
    public partial class FrmSingleFacilitiesCuring : XtraForm
    {

        RepositoryItemComboBox cbo = new RepositoryItemComboBox();
        List<Facilities> facilities = new List<Facilities>();
        public FrmSingleFacilitiesCuring()
        {
            InitializeComponent();
        }

        private void FrmSingleFacilitiesCuring_Load(object sender, EventArgs e)
        {
            LoadCboType();
            gridView.Columns["CuringResult"].ColumnEdit = cbo;

            LoadType();
            txtCuringName.Text = GlobalItem.g_CurrentUser.UserName;
            txtCreateUser.Text = GlobalItem.g_CurrentUser.UserName;
            deCuringDate.Text = DateTime.Now.ToString("d");
        }
        private void LoadType()
        {
            using (SqlConnection conn = new SqlConnection(GlobalItem.g_DbConnectStrings))
            {
                string sql = "SELECT CuringDepartment FROM dbo.BUS_FacilitiesCuring GROUP BY CuringDepartment";
                SqlDataAdapter sda = new SqlDataAdapter(sql, conn);
                DataSet ds = new DataSet();
                try
                {
                    sda.Fill(ds, "Table");
                    for (int i = 0; i < ds.Tables["Table"].Rows.Count; i++)
                    {
                        cboDepartment.Properties.Items.Add(ds.Tables["Table"].Rows[i]["CuringDepartment"].ToString());
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
        private void LoadCboType()
        {
            using (SqlConnection conn = new SqlConnection(GlobalItem.g_DbConnectStrings))
            {
                string sql = "SELECT CuringResult FROM dbo.BUS_FacilitiesCuring GROUP BY CuringResult";
                SqlDataAdapter sda = new SqlDataAdapter(sql, conn);
                DataSet ds = new DataSet();
                try
                {
                    sda.Fill(ds, "Table");
                    for (int i = 0; i < ds.Tables["Table"].Rows.Count; i++)
                    {
                        cbo.Items.Add(ds.Tables["Table"].Rows[i]["CuringResult"].ToString());
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

        private void btnAddFacilities_Click(object sender, EventArgs e)
        {
            using (FrmSelectFacilities frm = new FrmSelectFacilities())
            {
                frm.selectedFacilities = facilities;
                DialogResult dr = frm.ShowDialog();
                if (dr == DialogResult.OK)
                {
                    foreach (var item in frm.selectedFacilities)
                    {
                        if (!facilities.Select(p => p.ID).Contains(item.ID))
                        {
                            facilities.Add(item);
                        }
                    }
                }
            }
            LoadGrid();
        }

        private void LoadGrid()
        {
            gridControl.DataSource = facilities;
            gridControl.RefreshDataSource();
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            string curingPerson = txtCuringName.Text.Trim();
            string department = cboDepartment.Text.Trim();
            DateTime curingDate = deCuringDate.DateTime;
            string createUser = txtCreateUser.Text.Trim();
            foreach (var item in facilities)
            {
                if (!SaveCuring(item.ID, curingPerson, department, curingDate, item.CuringResult, 
                    item.CuringRemark, createUser, DateTime.Now))
                {
                    XtraMessageBox.Show("保存失败！", "提示", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }
            }
            this.DialogResult = DialogResult.OK;
        }

        private bool SaveCuring(int id,string curingPerson,string curingDepartment,DateTime curingDate,
            string curingResult,string curingRemark,string createUser,DateTime createDate)
        {
            using (SqlConnection conn = new SqlConnection(GlobalItem.g_DbConnectStrings))
            {
                string sql = @"INSERT dbo.BUS_FacilitiesCuring(FacilitiesID,CuringPerson,CuringDepartment,CuringDate,CuringResult,CuringRemark,CreateUser,CreateDate)
VALUES ({0},N'{1}',N'{2}','{3}',N'{4}',N'{5}',N'{6}','{7}')";
                sql = string.Format(sql, id, curingPerson, curingDepartment, curingDate,
                    curingResult, curingRemark, createUser, createDate);
                try
                {
                    conn.Open();
                    SqlCommand comm = new SqlCommand(sql, conn);
                    comm.ExecuteNonQuery();
                    return true;
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.ToString());
                    return false;
                }
                finally
                {
                    conn.Close();
                }
            }
        }
    }

    public class Facilities
    {
        public int ID { get; set; }
        public string FacilityCode { get; set; }
        public string FacilityName { get; set; }
        public string FacilityAddress { get; set; }
        public string FacilitySpec { get; set; }
        public string StyleName { get; set; }
        public string CuringResult { get; set; }
        public string CuringRemark { get; set; }

        public Facilities() { }

        public Facilities(int id, string facilityCode, string facilityName, string facilityAddress,
            string facilitySpec, string styleName, string curingResult, string curingRemark)
        {
            this.ID = id;
            this.FacilityCode = facilityCode;
            this.FacilityName = facilityName;
            this.FacilityAddress = facilityAddress;
            this.FacilitySpec = facilitySpec;
            this.StyleName = styleName;
            this.CuringResult = curingResult;
            this.CuringRemark = curingRemark;
        }
    }

    public class FacilitiesCuring
    {
        public int ID { get; set; }
        public int FacilitiesID { get; set; }
        public string CuringPerson { get; set; }
        public string CuringDepartment { get; set; }
        public DateTime CuringDate { get; set; }
        public string CuringResult { get; set; }
        public string CuringRemark { get; set; }
        public string CreateUser { get; set; }
        public DateTime CreateDate { get; set; }
    }
}