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
    public partial class FrmSelectFacilities : XtraForm
    {

        public List<Facilities> facilities = new List<Facilities>();
        public List<Facilities> selectedFacilities = new List<Facilities>();
        public FrmSelectFacilities()
        {
            InitializeComponent();
        }

        private void FrmSelectFacilities_Load(object sender, EventArgs e)
        {
            LoadGrid();
            SelectGrid();
        }

        private void LoadGrid()
        {
            using (SqlConnection conn = new SqlConnection(GlobalItem.g_DbConnectStrings))
            {
                string sql = "SELECT * FROM dbo.BFI_Facilities";
                SqlDataAdapter sda = new SqlDataAdapter(sql, conn);
                DataSet ds = new DataSet();
                try
                {
                    sda.Fill(ds, "Table");
                    for (int i = 0; i < ds.Tables["Table"].Rows.Count; i++)
                    {
                        Facilities facility = new Facilities();
                        facility.ID = int.Parse(ds.Tables["Table"].Rows[i]["ID"].ToString());
                        facility.FacilityCode = ds.Tables["Table"].Rows[i]["FacilityCode"].ToString();
                        facility.FacilityName = ds.Tables["Table"].Rows[i]["FacilityName"].ToString();
                        facility.FacilitySpec = ds.Tables["Table"].Rows[i]["FacilitySpec"].ToString();
                        facility.FacilityAddress = ds.Tables["Table"].Rows[i]["FacilityAddress"].ToString();
                        facility.StyleName = ds.Tables["Table"].Rows[i]["StyleName"].ToString();
                        if (!selectedFacilities.Select(p => p.ID).Contains(facility.ID))
                        {
                            facilities.Add(facility);
                        }
                    }
                    gridControl.DataSource = facilities;
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

        private void SelectGrid()
        {
            for (int i = 0; i < gridView.DataRowCount; i++)
            {
                var data = (Facilities)gridView.GetRow(i);
                if (selectedFacilities.Contains(data))
                {
                    gridView.SelectRow(i);
                }
            }
        }

        private void btnSelect_Click(object sender, EventArgs e)
        {
            var rows = gridView.GetSelectedRows();

            foreach (var row in rows)
            {
                selectedFacilities.Add((Facilities)gridView.GetRow(row));
            }

            this.DialogResult = DialogResult.OK;
        }
    }
}
