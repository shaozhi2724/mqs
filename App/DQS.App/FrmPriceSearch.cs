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
    public partial class FrmPriceSearch : XtraForm
    {
        public FrmPriceSearch()
        {
            InitializeComponent();
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            GainData();
        }

        private void btnReSet_Click(object sender, EventArgs e)
        {
            this.txtCode.Text = "";
        }

        /// <summary>
        /// 加载gCBill、gVBill，单据信息
        /// </summary>
        private void GainData()
        {
            using (SqlConnection conn = new SqlConnection(GlobalItem.g_DbConnectStrings))
            {
                string code = txtCode.Text.Trim();
                string sql = "SELECT ProductID,ProductName AS [名称],ProductSpec AS [规格],ProducerName AS [厂家] FROM dbo.BFI_Product WHERE ProductCode LIKE '%" + code + "%' OR ProductName LIKE '%" + code + "%' OR ProductSpell LIKE '%" + code + "%'";
                SqlDataAdapter sda = new SqlDataAdapter(sql, conn);
                DataSet ds = new DataSet();
                try
                {
                    sda.Fill(ds, "Table");
                    //ds.Tables["Table"].Columns.Add("选择", System.Type.GetType("System.Boolean"));

                    gridControl1.DataSource = ds.Tables["Table"];
                    gridView1.BestFitColumns();
                    gridView1.OptionsView.ShowGroupPanel = false;
                    for (int i = 0; i < gridView1.Columns.Count; i++)
                    {
                        string ColumnName = gridView1.Columns[i].ToString();
                        if (ColumnName.Contains("ID"))
                        {
                            gridView1.Columns[i].Visible = false;
                        }
                        gridView1.Columns[i].OptionsColumn.AllowEdit = false;
                    }
                    //for (int i = 0; i < gridView1.RowCount; i++)
                    //{
                    //    gridView1.SetRowCellValue(i, "选择", "False");
                    //}
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

        private void Grid2Load(int ProductID)
        {
            using (SqlConnection conn = new SqlConnection(GlobalItem.g_DbConnectStrings))
            {
                string sql = @"EXEC sp_LatelyInPrice " + ProductID;
                SqlDataAdapter sda = new SqlDataAdapter(sql, conn);
                DataSet ds = new DataSet();
                try
                {
                    sda.Fill(ds, "Table");
                    gridControl2.DataSource = ds.Tables["Table"];
                    gridView2.BestFitColumns();
                    for (int i = 0; i < gridView2.Columns.Count; i++)
                    {
                        string ColumnName = gridView2.Columns[i].ToString();
                        if (ColumnName.Contains("ID") || ColumnName.Contains("Spell"))
                        {
                            gridView2.Columns[i].Visible = false;
                        }
                        gridView2.Columns[i].OptionsColumn.AllowEdit = false;
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

        private void gridView1_FocusedRowChanged(object sender, DevExpress.XtraGrid.Views.Base.FocusedRowChangedEventArgs e)
        {
            if (gridView1.RowCount <= 0)
            {
                return;
            }
            int ProductID = Convert.ToInt32(gridView1.GetDataRow(gridView1.FocusedRowHandle)["ProductID"]);
            Grid2Load(ProductID);
        }

        private void gridView2_DoubleClick(object sender, EventArgs e)
        {
            object inStoreID = Convert.ToInt32(gridView2.GetDataRow(gridView2.FocusedRowHandle)["InStoreID"]);
            object price = Convert.ToDouble(gridView2.GetDataRow(gridView2.FocusedRowHandle)["进货价"]);
            if (null == inStoreID)
            {
                XtraMessageBox.Show("请选择数据行。", "系统提示", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            using (FrmUpdateViewPrice frm = new FrmUpdateViewPrice())
            {
                frm.inStoreID = Convert.ToInt32(inStoreID);
                frm.price = Convert.ToDouble(price);
                DialogResult dr = frm.ShowDialog();
                if (dr == DialogResult.Yes)
                {
                    gridView2.Columns.Clear();
                    int ProductID = Convert.ToInt32(gridView1.GetDataRow(gridView1.FocusedRowHandle)["ProductID"]);
                    Grid2Load(ProductID);
                    gridControl2.RefreshDataSource();
                }
            }
        }

        private void txtCode_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)13)
            {
                GainData();
                if (gridView1.RowCount <= 0)
                {
                    return;
                }
                gridView1.Focus();
            }
        }
    }
}
