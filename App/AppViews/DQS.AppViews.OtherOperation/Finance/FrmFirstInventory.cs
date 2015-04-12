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

namespace DQS.AppViews.OtherOperation.Finance
{
    public partial class FrmFirstInventory : XtraForm
    {
        public FrmFirstInventory()
        {
            InitializeComponent();
        }

        private void FrmInventory_Load(object sender, EventArgs e)
        {

        }

        private void btnOneClickInventory_Click(object sender, EventArgs e)
        {
            if (deInventoryDate.Text.Trim() == "")
            {
                XtraMessageBox.Show("请选择结存日期！", "系统提示", MessageBoxButtons.OK, MessageBoxIcon.Information);
                deInventoryDate.Focus();
                return;
            }
            using (SqlConnection conn = new SqlConnection(GlobalItem.g_DbConnectStrings))
            {
                string insertInventory = "EXEC fn_FirstInventory '{0}'";
                try
                {
                    conn.Open();
                    insertInventory = String.Format(insertInventory,deInventoryDate.Text);
                    SqlCommand command = new SqlCommand(insertInventory, conn);
                    command.ExecuteNonQuery();
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
            GainData();
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            DialogResult dr = XtraMessageBox.Show("清空后，期初所有数据将清空为0，确认要清空？", "系统提示", MessageBoxButtons.OKCancel, MessageBoxIcon.Question);
            if (dr == DialogResult.OK)
            {
                using (SqlConnection conn = new SqlConnection(GlobalItem.g_DbConnectStrings))
                {
                    string ClearInventory = @"DELETE dbo.FIN_Inventory
DELETE dbo.FIN_InventoryDetail";
                    try
                    {
                        conn.Open();
                        SqlCommand command = new SqlCommand(ClearInventory, conn);
                        command.ExecuteNonQuery();
                        XtraMessageBox.Show("已清空", "系统提示", MessageBoxButtons.OK, MessageBoxIcon.None);
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
            }
        }

        private void txtChanged(object sender, EventArgs e)
        {
            if (gridView.RowCount > 0)
            {
                GainData();
            }
        }

        private void GainData()
        {
            using (SqlConnection conn = new SqlConnection(GlobalItem.g_DbConnectStrings))
            {
                string sql = @"EXEC fn_ShowDealerForInventory '" + txtDealerCode.Text.Trim() + "'";
                SqlDataAdapter sda = new SqlDataAdapter(sql, conn);
                DataSet ds = new DataSet();
                try
                {
                    sda.Fill(ds, "Table");
                    //ds.Tables["Table"].Columns.Add("选择", System.Type.GetType("System.Boolean"));

                    gridControl.DataSource = ds.Tables["Table"];
                    gridView.OptionsView.ColumnAutoWidth = false;
                    gridView.BestFitColumns();
                    gridView.OptionsView.ShowGroupPanel = false;
                    for (int i = 0; i < gridView.Columns.Count; i++)
                    {
                        string ColumnName = gridView.Columns[i].ToString();
                        if (ColumnName.Contains("应收") || ColumnName.Contains("应付"))
                        {
                            gridView.Columns[i].OptionsColumn.AllowEdit = true;
                        }
                        else
                        {
                            gridView.Columns[i].OptionsColumn.AllowEdit = false;
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

        private void gridView_BeforeLeaveRow(object sender, DevExpress.XtraGrid.Views.Base.RowAllowEventArgs e)
        {
            string DealerCode = gridView.GetRowCellValue(gridView.FocusedRowHandle, "往来单位编号").ToString().Trim();
            string DealerName = gridView.GetRowCellValue(gridView.FocusedRowHandle, "往来单位名称").ToString().Trim();
            string DealerSpell = gridView.GetRowCellValue(gridView.FocusedRowHandle, "往来单位简拼").ToString().Trim();
            string DealerType = gridView.GetRowCellValue(gridView.FocusedRowHandle, "往来单位类型").ToString().Trim();
            string Receivables = gridView.GetRowCellValue(gridView.FocusedRowHandle, "应收").ToString().Trim();
            string Payables = gridView.GetRowCellValue(gridView.FocusedRowHandle, "应付").ToString().Trim();
            /*
            if (Receivables == "0" && Payables == "0")
            {
                return;
            }*/
            using (SqlConnection conn = new SqlConnection(GlobalItem.g_DbConnectStrings))
            {
                string insertInventory = "EXEC fn_FirstInventoryDetail '{0}','{1}','{2}','{3}','{4}','{5}'";
                try
                {
                    conn.Open();
                    insertInventory = String.Format(insertInventory, DealerCode, DealerName, DealerSpell, DealerType, Receivables, Payables);
                    SqlCommand command = new SqlCommand(insertInventory, conn);
                    command.ExecuteNonQuery();
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
        }

        private void btnOK_Click(object sender, EventArgs e)
        {
            using (SqlConnection conn = new SqlConnection(GlobalItem.g_DbConnectStrings))
            {
                string OkInventory = "UPDATE dbo.FIN_Inventory SET InventoryRemark = '完成期初' WHERE InventoryCode = 'QCDJ'";
                try
                {
                    conn.Open();
                    SqlCommand command = new SqlCommand(OkInventory, conn);
                    command.ExecuteNonQuery();
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
    }
}
