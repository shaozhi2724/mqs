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

namespace DQS.AppViews.QualityDocument.DealerManager
{
    public partial class FrmProductOfDealer : XtraForm
    {
        public FrmProductOfDealer()
        {
            InitializeComponent();
        }

        public int DealerID = 0;

        //记录选择的ID
        public List<int> BillList = new List<int>();

        private void btnSave_Click(object sender, EventArgs e)
        {
            using (SqlConnection conn = new SqlConnection(GlobalItem.g_DbConnectStrings))
            {
                string del = @"EXEC sp_DelDealerVSProduct {0}";
                string insertBill = @"EXEC sp_SaveDealerVSProduct {0},{1},'{2}'";

                try
                {
                    conn.Open();
                    SqlCommand cmd = new SqlCommand(String.Format(del,DealerID),conn);
                    cmd.ExecuteNonQuery();
                    foreach (int ProductID in BillList)
                    {
                        SqlCommand command = new SqlCommand(String.Format(insertBill,DealerID, ProductID,GlobalItem.g_CurrentUser.UserName), conn);
                        command.ExecuteNonQuery();
                    }
                    XtraMessageBox.Show("保存成功。", "系统提示", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                catch (Exception ex)
                {
                    XtraMessageBox.Show(ex.ToString(), "系统提示", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                finally
                {
                    conn.Close();
                }
            } 
            this.DialogResult = DialogResult.Yes;
        }

        private void gridLoad()
        {
            using (SqlConnection conn = new SqlConnection(GlobalItem.g_DbConnectStrings))
            {
                string sqlBill = @"SELECT ProductID,ProductCode AS [编号],ProductName AS [名称],CommonName AS [通用名称],ProductSpec AS [规格],
PackageSpec AS [包装规格],ProducerName AS [生产厂商],AuthorizedNo AS [批准文号]
FROM dbo.BFI_Product";

                SqlDataAdapter sdad = new SqlDataAdapter(sqlBill, conn);
                DataSet ds = new DataSet();
                try
                {
                    sdad.Fill(ds, "Table");
                    ds.Tables["Table"].Columns.Add("选择", System.Type.GetType("System.Boolean"));
                    gridControl.DataSource = ds.Tables["Table"];
                    //gridView.OptionsView.ColumnAutoWidth = false;
                    //gridView.OptionsView.ColumnAutoWidth = false;
                    gridView.BestFitColumns();
                    gridView.OptionsView.ShowGroupPanel = false;

                    for (int i = 0; i < gridView.Columns.Count; i++)
                    {
                        string ColumnName = gridView.Columns[i].ToString();
                        if (ColumnName.Contains("ID"))
                        {
                            gridView.Columns[i].Visible = false;
                        }
                        gridView.Columns[i].OptionsColumn.AllowEdit = false;
                    }
                    for (int i = 0; i < gridView.RowCount; i++)
                    {
                        gridView.SetRowCellValue(i, "选择", "False");
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

        /// <summary>
        /// 单据信息点击选择
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void gridView_Click(object sender, EventArgs e)
        {
            if (gridView.FocusedColumn.ToString() == "选择")
            {
                string value = gridView.GetRowCellValue(gridView.FocusedRowHandle, "选择").ToString();
                if (value == "True")
                {
                    gridView.SetRowCellValue(gridView.FocusedRowHandle, "选择", "False");
                    BillList.Remove(Convert.ToInt32(gridView.GetDataRow(gridView.FocusedRowHandle)["ProductID"]));
                }
                else
                {
                    gridView.SetRowCellValue(gridView.FocusedRowHandle, "选择", "True");
                    BillList.Add(Convert.ToInt32(gridView.GetDataRow(gridView.FocusedRowHandle)["ProductID"]));
                }
            }
        }

        private void getList()
        {
            using (SqlConnection conn = new SqlConnection(GlobalItem.g_DbConnectStrings))
            {
                string sqlBill = @"SELECT ProductID FROM BUS_DealerVSProduct WHERE DealerID = " + DealerID;

                SqlDataAdapter sdad = new SqlDataAdapter(sqlBill, conn);
                DataSet ds = new DataSet();
                try
                {
                    sdad.Fill(ds, "Table");

                    for (int i = 0; i < ds.Tables["Table"].Rows.Count; i++)
                    {
                        BillList.Add(Convert.ToInt32(ds.Tables["Table"].Rows[i]["ProductID"]));
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

        /// <summary>
        /// 读取单据列表是否选择
        /// </summary>
        private void ReadBillList()
        {
            for (int i = 0; i < gridView.RowCount; i++)
            {
                int StoreID = Convert.ToInt32(gridView.GetRowCellValue(i, "ProductID"));
                if (BillList.Contains(StoreID))
                {
                    gridView.SetRowCellValue(i, "选择", "True");
                }
                else
                {
                    gridView.SetRowCellValue(i, "选择", "False");
                }
            }
        }

        private void FrmProductOfDealer_Load(object sender, EventArgs e)
        {
            gridLoad();
            getList();
            ReadBillList();
        }
    }
}
