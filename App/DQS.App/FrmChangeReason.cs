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
    public partial class FrmChangeReason : XtraForm
    {
        public FrmChangeReason()
        {
            InitializeComponent();
        }

        private void btnProduct_Click(object sender, EventArgs e)
        {
            lableType.Text = "产品";
            lableTypeID.Text = "1";
            GridLoad();
        }

        private void btnDealer_Click(object sender, EventArgs e)
        {
            lableType.Text = "供应商/客户";
            lableTypeID.Text = "2";
            GridLoad();
        }

        private void FrmChangeReason_Load(object sender, EventArgs e)
        {
            GridLoad();
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            if (lableID.Text != "")
            {
                SqlConnection conn = new SqlConnection(GlobalItem.g_DbConnectStrings);
                conn.Open();
                try
                {
                    string catesql = "";
                    if (lableTypeID.Text == "1")
                    {
                        catesql = @"UPDATE dbo.BFI_Product SET Reservation10 = '" + txtReason.Text + "' WHERE ProductID = " + lableID.Text;
                    }
                    else
                    {
                        catesql = @"UPDATE dbo.BFI_Dealer SET Reservation10 = '" + txtReason.Text + "' WHERE DealerID = " + lableID.Text;
                    }
                    SqlCommand com = new SqlCommand(catesql, conn);
                    int result = com.ExecuteNonQuery();
                    if (result == 1)
                    {
                        XtraMessageBox.Show("更新成功。", "系统提示", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                    }
                }
                catch (Exception)
                {
                    XtraMessageBox.Show("未能更新成功。", "系统提示", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                }
                finally
                {
                    conn.Close();
                }
                lableID.Text = "";
                GridLoad();
            }
        }

        private void GridLoad()
        {
            string sql = "";
            if (lableTypeID.Text == "1")
            {
                sql = @"SELECT ProductID AS ID, ProductCode AS 产品编号,ProductName AS 产品名称,Reservation10 AS 变更原因 FROM dbo.BFI_Product";
            }
            else
            {
                sql = @"SELECT DealerID AS ID,DealerCode AS 编号,DealerName AS 名称,Reservation10 AS 变更原因 FROM dbo.BFI_Dealer";
            }
            using (SqlConnection conn = new SqlConnection(GlobalItem.g_DbConnectStrings))
            {
                SqlDataAdapter sda = new SqlDataAdapter(sql, conn);
                DataSet ds = new DataSet();
                try
                {
                    gridView.Columns.Clear();
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

        private void gridView_DoubleClick(object sender, EventArgs e)
        {
            object ID = Convert.ToInt32(gridView.GetDataRow(gridView.FocusedRowHandle)["ID"]);
            lableID.Text = ID.ToString();
        }
    }
}
