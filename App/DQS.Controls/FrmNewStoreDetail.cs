using DevExpress.XtraEditors;
using DQS.Common;
using DQS.Controls.Properties;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace DQS.Controls
{
    public partial class FrmNewStoreDetail : XtraForm
    {
        public FrmNewStoreDetail()
        {
            InitializeComponent();
        }

        public DataRow EditRow { get; set; }

        private void FrmNewStoreDetail_Load(object sender, EventArgs e)
        {
            txtProductCode.Focus();
            Grid1Load();
        }

        private void Grid1Load()
        {
            using (SqlConnection conn = new SqlConnection(GlobalItem.g_DbConnectStrings))
            {
                string sql = @"EXEC sp_ProductDetail '" + txtProductCode.Text.Trim() + "'";
                SqlDataAdapter sda = new SqlDataAdapter(sql, conn);
                DataSet ds = new DataSet();
                try
                {
                    sda.Fill(ds, "Table");
                    gridControl1.DataSource = ds.Tables["Table"];
                    gridView1.BestFitColumns();
                    for (int i = 0; i < gridView1.Columns.Count; i++)
                    {
                        string ColumnName = gridView1.Columns[i].ToString();
                        if (ColumnName.Contains("ID") || ColumnName.Contains("Spell"))
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

        private void gridView1_Click(object sender, EventArgs e)
        {
            int ProductID = Convert.ToInt32(gridView1.GetDataRow(gridView1.FocusedRowHandle)["ProductID"]);
            Grid2Load(ProductID);
            Grid3Load(ProductID);
            Grid4Load(ProductID);
        }

        private void Grid2Load(int ProductID)
        {
            using (SqlConnection conn = new SqlConnection(GlobalItem.g_DbConnectStrings))
            {
                string sql = @"EXEC sp_LatelyOutPrice " + ProductID;
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

        private void Grid3Load(int ProductID)
        {
            using (SqlConnection conn = new SqlConnection(GlobalItem.g_DbConnectStrings))
            {
                string sql = @"EXEC sp_LatelyInPrice " + ProductID;
                SqlDataAdapter sda = new SqlDataAdapter(sql, conn);
                DataSet ds = new DataSet();
                try
                {
                    sda.Fill(ds, "Table");
                    gridControl3.DataSource = ds.Tables["Table"];
                    gridView3.BestFitColumns();
                    for (int i = 0; i < gridView3.Columns.Count; i++)
                    {
                        string ColumnName = gridView3.Columns[i].ToString();
                        if (ColumnName.Contains("ID") || ColumnName.Contains("Spell"))
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

        private void Grid4Load(int ProductID)
        {
            using (SqlConnection conn = new SqlConnection(GlobalItem.g_DbConnectStrings))
            {
                string sql = "";
                if (Settings.Default.IsUseDepartment)
                {
                    sql = @"EXEC sp_SelectedStoreDetailDepartment " + ProductID + "" + Convert.ToInt32(GlobalItem.g_CurrentEmployee.DepartmentID);
                }
                else
                {
                    sql = @"EXEC sp_SelectedStoreDetail " + ProductID;
                }
                SqlDataAdapter sda = new SqlDataAdapter(sql, conn);
                DataSet ds = new DataSet();
                try
                {
                    sda.Fill(ds, "Table");
                    gridControl4.DataSource = ds.Tables["Table"];
                    gridView4.BestFitColumns();
                    //for (int i = 0; i < gridView4.Columns.Count; i++)
                    //{
                    //    string ColumnName = gridView4.Columns[i].ToString();
                    //    if (ColumnName.Contains("ID") || ColumnName.Contains("Spell"))
                    //    {
                    //        gridView4.Columns[i].Visible = false;
                    //    }
                    //    gridView4.Columns[i].OptionsColumn.AllowEdit = false;
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

        private void SelectProduct()
        {
            this.EditRow = gridView4.GetFocusedDataRow();

            //if (this.m_PopupBox != null)
            //{
            //    this.m_PopupBox.EditData = gridView4.GetFocusedDataRow();
            //    if (!string.IsNullOrEmpty(this.m_PopupBox.MemberText) && !string.IsNullOrEmpty(this.m_PopupBox.MemberValue))
            //    {
            //        this.m_PopupBox.EditValue2 = gridView4.GetFocusedRowCellValue(this.m_PopupBox.MemberValue);
            //        if (gridView4.GetFocusedRowCellValue(this.m_PopupBox.MemberText) != null)
            //        {
            //            this.m_PopupBox.Text = gridView4.GetFocusedRowCellValue(this.m_PopupBox.MemberText).ToString();
            //            this.m_PopupBox.Select(this.m_PopupBox.Text.Length, 0);
            //        }
            //    }
            //}

            this.DialogResult = DialogResult.OK;
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            Grid1Load();
            if (gridView1.RowCount < 1)
            {
                gridControl2.DataSource = null;
                gridControl3.DataSource = null;
                gridControl4.DataSource = null;
                return;
            }
            int ProductID = Convert.ToInt32(gridView1.GetDataRow(gridView1.FocusedRowHandle)["ProductID"]);
            gridView1.Focus();
            Grid2Load(ProductID);
            Grid3Load(ProductID);
            Grid4Load(ProductID);
        }

        private void gridView4_DoubleClick(object sender, EventArgs e)
        {
            SelectProduct();
        }

        private void txtProductCode_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)13)
            {
                Grid1Load();
                if (gridView1.RowCount < 1)
                {
                    gridControl2.DataSource = null;
                    gridControl3.DataSource = null;
                    gridControl4.DataSource = null;
                    return;
                }
                int ProductID = Convert.ToInt32(gridView1.GetDataRow(gridView1.FocusedRowHandle)["ProductID"]);
                gridView1.Focus();
                Grid2Load(ProductID);
                Grid3Load(ProductID);
                Grid4Load(ProductID);
            }
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            //int dealerID = int.Parse(this.Tag.ToString().Split('$')[0]);
            this.Close();
        }

        private void gridView1_FocusedRowChanged(object sender, DevExpress.XtraGrid.Views.Base.FocusedRowChangedEventArgs e)
        {
            int ProductID = Convert.ToInt32(gridView1.GetDataRow(gridView1.FocusedRowHandle)["ProductID"]);
            Grid2Load(ProductID);
            Grid3Load(ProductID);
            Grid4Load(ProductID);
        }

        private void gridView1_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)13)
            {
                gridView4.Focus();
            }
        }

        private void gridView4_KeyPress(object sender, KeyPressEventArgs e)
        {
            SelectProduct();
        }
    }
}
