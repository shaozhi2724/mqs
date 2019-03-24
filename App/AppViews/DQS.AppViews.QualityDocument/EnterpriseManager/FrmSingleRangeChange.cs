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

namespace DQS.AppViews.QualityDocument.EnterpriseManager
{
    public partial class FrmSingleRangeChange : XtraForm
    {
        public FrmSingleRangeChange()
        {
            InitializeComponent();
        }

        private void FrmSingleRangeChange_Load(object sender, EventArgs e)
        {
            BandAddGrid();
            BandDelGrid();
        }

        private void BandAddGrid()
        {
            using (SqlConnection conn = new SqlConnection(GlobalItem.g_DbConnectStrings))
            {
                string sql = @"
SELECT ProductStyleName AS 经营范围 FROM dbo.BFI_RangeChangeDetail bacd
WHERE ID = {0} AND RangeType = 'NEW'
AND bacd.ProductStyleName NOT IN (SELECT ProductStyleName FROM dbo.BFI_RangeChangeDetail WHERE ID = {0} AND RangeType = 'OLD')";
                sql = string.Format(sql, this.Tag);
                try
                {
                    SqlDataAdapter sda = new SqlDataAdapter(sql, conn);
                    DataSet ds = new DataSet();
                    sda.Fill(ds, "Table");

                    gcAdd.DataSource = ds.Tables["Table"];
                    gvAdd.OptionsView.ColumnAutoWidth = false;
                    gvAdd.BestFitColumns();
                    gvAdd.OptionsView.ShowGroupPanel = false;
                    for (int i = 0; i < gvAdd.Columns.Count; i++)
                    {
                        string ColumnName = gvAdd.Columns[i].ToString();
                        if (ColumnName.Contains("ID"))
                        {
                            gvAdd.Columns[i].Visible = false;
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

        private void BandDelGrid()
        {
            using (SqlConnection conn = new SqlConnection(GlobalItem.g_DbConnectStrings))
            {
                string sql = @"
SELECT ProductStyleName AS 经营范围 FROM dbo.BFI_RangeChangeDetail bacd
WHERE ID = {0} AND RangeType = 'OLD'
AND bacd.ProductStyleName NOT IN (SELECT ProductStyleName FROM dbo.BFI_RangeChangeDetail WHERE ID = {0} AND RangeType = 'NEW')";
                sql = string.Format(sql, this.Tag);
                try
                {
                    SqlDataAdapter sda = new SqlDataAdapter(sql, conn);
                    DataSet ds = new DataSet();
                    sda.Fill(ds, "Table");

                    gcDel.DataSource = ds.Tables["Table"];
                    gvDel.OptionsView.ColumnAutoWidth = false;
                    gvDel.BestFitColumns();
                    gvDel.OptionsView.ShowGroupPanel = false;
                    for (int i = 0; i < gvDel.Columns.Count; i++)
                    {
                        string ColumnName = gvDel.Columns[i].ToString();
                        if (ColumnName.Contains("ID"))
                        {
                            gvDel.Columns[i].Visible = false;
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
    }
}
