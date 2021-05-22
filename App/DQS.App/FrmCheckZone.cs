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

namespace DQS.App
{
    public partial class FrmCheckZone : XtraForm
    {
        public FrmCheckZone()
        {
            InitializeComponent();
        }

        private void gridView_DoubleClick(object sender, EventArgs e)
        {
            object OldID = Convert.ToInt32(gridView.GetDataRow(gridView.FocusedRowHandle)["ID"]);
            lblOldID.Text = OldID.ToString();
        }

        private void gridViewAll_DoubleClick(object sender, EventArgs e)
        {
            object NewdID = Convert.ToInt32(gridViewAll.GetDataRow(gridViewAll.FocusedRowHandle)["ID"]);
            lblNewID.Text = NewdID.ToString();
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            if (txtZone.Text.Trim() == "")
            {
                GridLoad();
            }
            else
            {
                GridLoad();
                txtAllZone.Text = txtZone.Text;
                GridLoadAllP();
            }
        }

        private void btnAllSearch_Click(object sender, EventArgs e)
        {
            GridLoadAllP();
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            if (lblOldID.Text.Length > 0 && lblNewID.Text.Length > 0)
            {
                SqlConnection conn = new SqlConnection(GlobalItem.g_DbConnectStrings);
                conn.Open();
                try
                {
                    string catesql = "UPDATE dbo.BFI_Dealer SET ZoneID = " + lblNewID.Text + " WHERE DealerID = " + lblOldID.Text;
                    SqlCommand com = new SqlCommand(catesql, conn);
                    int result = com.ExecuteNonQuery();
                    if (result == 1)
                    {
                        XtraMessageBox.Show("配对成功。", "系统提示", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                    }
                }
                catch (Exception)
                {
                    XtraMessageBox.Show("未能配对成功。", "系统提示", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                }
                finally
                {
                    conn.Close();
                }
            }
        }


        private void GridLoad()
        {
            //获取当前时间
            string dateStr = DateTime.Now.ToString("yyyy-MM-dd");
            string sql = @"SELECT DISTINCT d.DealerID AS ID,d.DealerCode AS 编号,d.DealerName AS 名称,d.DealerArea AS 区域,d.DealerProvince AS 省份,d.DealerCity AS 城镇,d.DealerCounty AS 区县,d.DealerAddress AS 地址
FROM dbo.BUS_StoreBill sb 
INNER JOIN dbo.BFI_Dealer d ON sb.DealerID = d.DealerID
WHERE sb.StoreDate >= '" + dateStr + " 00:00:00' AND sb.StoreDate <= '" + dateStr + " 23:59:59' AND d.ZoneID IS NULL  AND (d.DealerName LIKE '%" + txtZone.Text + "%' OR d.DealerCity LIKE '%" + txtZone.Text + "%' OR d.DealerAddress LIKE '%" + txtZone.Text + "%')";
            using (SqlConnection conn = new SqlConnection(GlobalItem.g_DbConnectStrings))
            {
                SqlDataAdapter sda = new SqlDataAdapter(sql, conn);
                DataSet ds = new DataSet();
                try
                {
                    sda.Fill(ds, "Table");
                    gridControl.DataSource = ds.Tables["Table"];
                    gridView.BestFitColumns();
                    for (int i = 0; i < gridView.Columns.Count; i++)
                    {
                        string ColumnName = gridView.Columns[i].ToString();
                        if (ColumnName.Contains("ID") || ColumnName.Contains("Spell"))
                        {
                            gridView.Columns[i].Visible = false;
                        }
                        gridView.Columns[i].OptionsColumn.AllowEdit = false;
                    }
                }
                catch (Exception ex)
                {
                    XtraMessageBox.Show(ex.Message, "系统提示", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                finally
                {
                    conn.Close();
                }
            }
        }

        private void GridLoadAllP()
        {
            string sql = @"SELECT ID,ZoneName AS 区域,FullNameOfRegion AS 区域全称 FROM dbo.BFI_Zone WHERE ZoneName LIKE '%" + txtAllZone.Text + "%' OR FullNameOfRegion LIKE '%" + txtAllZone.Text + "%'";
            using (SqlConnection conn = new SqlConnection(GlobalItem.g_DbConnectStrings))
            {
                SqlDataAdapter sda = new SqlDataAdapter(sql, conn);
                DataSet ds = new DataSet();
                try
                {
                    sda.Fill(ds, "Table");
                    gridControlAll.DataSource = ds.Tables["Table"];
                    gridViewAll.BestFitColumns();
                    for (int i = 0; i < gridViewAll.Columns.Count; i++)
                    {
                        string ColumnName = gridViewAll.Columns[i].ToString();
                        if (ColumnName.Contains("ID") || ColumnName.Contains("Spell"))
                        {
                            gridViewAll.Columns[i].Visible = false;
                        }
                        gridViewAll.Columns[i].OptionsColumn.AllowEdit = false;
                    }
                }
                catch (Exception ex)
                {
                    XtraMessageBox.Show(ex.Message, "系统提示", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                finally
                {
                    conn.Close();
                }
            }
        }

    }
}
