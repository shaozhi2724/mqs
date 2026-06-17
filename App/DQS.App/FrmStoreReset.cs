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
    public partial class FrmStoreReset : DevExpress.XtraEditors.XtraForm
    {
        public FrmStoreReset()
        {
            InitializeComponent();
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            GetInOutAmount();
            GetNewStore();
        }


        /// <summary>
        /// 加载gCBill、gVBill，单据信息
        /// </summary>
        private void GetInOutAmount()
        {
            using (SqlConnection conn = new SqlConnection(GlobalItem.g_DbConnectStrings))
            {
                string code = txtCode.Text.Trim();
                string batchNo = txtBatchNo.Text.Trim();
                string sql = "SELECT sb.StoreID,sb.StoreCode AS [单号],sbd.BillAmount AS [数量],sb.IsBillIn FROM dbo.BUS_StoreBill sb INNER JOIN dbo.BUS_StoreBillDetail sbd ON sb.StoreID = sbd.StoreID INNER JOIN dbo.BFI_Product bp ON sbd.ProductID = bp.ProductID WHERE bp.ProductCode = '" + code + "' AND sbd.BatchNo = '" + batchNo + "' ORDER BY sb.StoreID";
                SqlDataAdapter sda = new SqlDataAdapter(sql, conn);
                DataSet ds = new DataSet();
                try
                {
                    sda.Fill(ds, "Table");

                    gridControl1.DataSource = ds.Tables["Table"];
                    gridView1.BestFitColumns();
                    gridView1.OptionsView.ShowGroupPanel = false;
                    for (int i = 0; i < gridView1.Columns.Count; i++)
                    {
                        string ColumnName = gridView1.Columns[i].ToString();
                        if (ColumnName.Contains("ID") || ColumnName.Contains("Is"))
                        {
                            gridView1.Columns[i].Visible = false;
                        }
                        gridView1.Columns[i].OptionsColumn.AllowEdit = false;
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
        private void GetNewStore()
        {
            using (SqlConnection conn = new SqlConnection(GlobalItem.g_DbConnectStrings))
            {
                string code = txtCode.Text.Trim();
                string batchNo = txtBatchNo.Text.Trim();
                string sql = "SELECT nsd.InStoreCode AS [入库单号],nsd.InAmount AS [入库数量],nsd.OutStoreCode AS [出库单号],nsd.OutAmount AS [出库数量] FROM dbo.BUS_NEWStoreDetail nsd INNER JOIN dbo.BFI_Product bp ON nsd.ProductID = bp.ProductID WHERE bp.ProductCode = '" + code + "' AND nsd.BatchNo = '" + batchNo + "'";
                SqlDataAdapter sda = new SqlDataAdapter(sql, conn);
                DataSet ds = new DataSet();
                try
                {
                    sda.Fill(ds, "Table");

                    gridControl3.DataSource = ds.Tables["Table"];
                    gridView3.BestFitColumns();
                    gridView3.OptionsView.ShowGroupPanel = false;
                    for (int i = 0; i < gridView3.Columns.Count; i++)
                    {
                        string ColumnName = gridView3.Columns[i].ToString();
                        if (ColumnName.Contains("ID"))
                        {
                            gridView3.Columns[i].Visible = false;
                        }
                        gridView3.Columns[i].OptionsColumn.AllowEdit = false;
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

        private void btnReSet_Click(object sender, EventArgs e)
        {
            for (int i = 0; i < gridView1.RowCount; i++)
            {
                int StoreID = Convert.ToInt32(gridView1.GetDataRow(i)["StoreID"]);
                string StoreCode = gridView1.GetDataRow(i)["单号"].ToString();
                int IsBillIn = Convert.ToInt32(gridView1.GetDataRow(i)["IsBillIn"]);
                if (IsBillIn == 1)
                {
                    resetBillIn(StoreID, StoreCode);
                }
                else
                {
                    resetBillOut(StoreID);
                }

            }
        }
        private void resetBillIn(int StoreID, string StoreCode)
        {
            string sql = @"EXEC sp_InsertBusInStoreDetailForReset {0},{1}";
            sql = string.Format(sql, StoreID, StoreCode);
            using (SqlConnection conn = new SqlConnection(GlobalItem.g_DbConnectStrings))
            {
                conn.Open(); //连接数据库
                //必须为SqlCommand指定数据库连接和登记的事务
                SqlCommand cmd = new SqlCommand(sql, conn);
                try
                {
                    cmd.ExecuteNonQuery();
                }
                catch (Exception ex)
                {
                    
                    ex.ToString();
                }
                finally
                {
                    conn.Close();
                }
            }
        }
        private void resetBillOut(int StoreID)
        {
            string sql = @"EXEC sp_InsertNewStoreDetailForReset {0}";
            sql = string.Format(sql, StoreID);
            using (SqlConnection conn = new SqlConnection(GlobalItem.g_DbConnectStrings))
            {
                conn.Open(); //连接数据库
                //必须为SqlCommand指定数据库连接和登记的事务
                SqlCommand cmd = new SqlCommand(sql, conn);
                try
                {
                    cmd.ExecuteNonQuery();
                }
                catch (Exception ex)
                {

                    ex.ToString();
                }
                finally
                {
                    conn.Close();
                }
            }
        }
    }
}
