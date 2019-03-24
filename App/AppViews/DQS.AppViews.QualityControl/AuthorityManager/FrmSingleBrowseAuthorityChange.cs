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

namespace DQS.AppViews.QualityControl.AuthorityManager
{
    public partial class FrmSingleBrowseAuthorityChange : XtraForm
    {
        public FrmSingleBrowseAuthorityChange()
        {
            InitializeComponent();
        }

        private void FrmSingleBrowseAuthorityChange_Load(object sender, EventArgs e)
        {
            BandAddGrid();
            BandDelGrid();
        }

        private void BandAddGrid()
        {
            using (SqlConnection conn = new SqlConnection(GlobalItem.g_DbConnectStrings))
            {
                string sql = @"
SELECT sm.MenuName AS 操作模块 FROM dbo.ATC_BrowseAuthorityChangeDetail bacd
INNER JOIN dbo.SYS_Menu sm ON bacd.MenuCode = sm.MenuCode
WHERE ID = {0} AND MenuType = 'NEW'
AND bacd.MenuCode NOT IN (SELECT MenuCode FROM dbo.ATC_BrowseAuthorityChangeDetail WHERE ID = {0} AND MenuType = 'OLD')";
                sql = string.Format(sql,this.Tag);
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
SELECT sm.MenuName AS 操作模块 FROM dbo.ATC_BrowseAuthorityChangeDetail bacd
INNER JOIN dbo.SYS_Menu sm ON bacd.MenuCode = sm.MenuCode
WHERE ID = {0} AND MenuType = 'OLD'
AND bacd.MenuCode NOT IN (SELECT MenuCode FROM dbo.ATC_BrowseAuthorityChangeDetail WHERE ID = {0} AND MenuType = 'NEW')";
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
