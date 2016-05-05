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

namespace DQS.AppViews.StoreAndCuring.StockManager
{
    public partial class FrmUpdateBeginInventory : XtraForm
    {
        public FrmUpdateBeginInventory()
        {
            InitializeComponent();
        }

        private void cboLoad()
        {
            using (SqlConnection conn = new SqlConnection(GlobalItem.g_DbConnectStrings))
            {
                string sql = @"SELECT DepartmentName FROM dbo.BFI_Department";

                SqlDataAdapter sda = new SqlDataAdapter(sql, conn);
                DataSet ds = new DataSet();
                try
                {
                    sda.Fill(ds, "Table");
                    for (int i = 0; i < ds.Tables["Table"].Rows.Count; i++)
                    {
                        cboDepartmentName.Properties.Items.Add(ds.Tables["Table"].Rows[i]["DepartmentName"].ToString());
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

        private void FrmUpdateBeginInventory_Load(object sender, EventArgs e)
        {
            cboLoad();
        }

        private void gridGain()
        {
            using (SqlConnection conn = new SqlConnection(GlobalItem.g_DbConnectStrings))
            {
                string sql = @"SELECT sd.BeginInventoryID,sd.ProductID,p.ProductCode AS [产品编号],p.ProductName AS [产品名称],p.PackageSpec AS [包装规格],p.ProducerName AS [生产厂商],sd.BatchNo AS [批号],sd.ProduceDate AS [生产日期],sd.ValidateDate AS [有效期至],sd.Amount AS [期初数量],dbo.fn_GetAmount(-sd.BeginInventoryID) AS [库存数量]
	FROM dbo.BUS_BeginInventory sd
	LEFT JOIN dbo.BFI_Product p ON sd.ProductID = p.ProductID
WHERE p.ProductName LIKE '%{0}%' OR p.ProductCode LIKE '%{0}%' OR p.ProductSpell LIKE '%{0}%'";

                sql = string.Format(sql, txtCode.Text.Trim());
                SqlDataAdapter sda = new SqlDataAdapter(sql, conn);
                DataSet ds = new DataSet();
                try
                {
                    sda.Fill(ds, "Table");
                    gridControl.DataSource = ds.Tables["Table"];
                    gridView.OptionsView.ColumnAutoWidth = false;
                    gridView.BestFitColumns();
                    gridView.OptionsView.ShowGroupPanel = false;
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
                    MessageBox.Show(ex.ToString());
                }
                finally
                {
                    conn.Close();
                }
            }
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            if (txtCode.Text.Trim() == "")
            {
                XtraMessageBox.Show("请输入查询条件！", "系统提示", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }
            gridGain();
        }

        private void gridView_DoubleClick(object sender, EventArgs e)
        {
            txtProductCode.Tag = (int)gridView.GetDataRow(gridView.FocusedRowHandle)["BeginInventoryID"];
            txtProductCode.Text = gridView.GetDataRow(gridView.FocusedRowHandle)["产品编号"].ToString();
            txtProductName.Tag = (int)gridView.GetDataRow(gridView.FocusedRowHandle)["ProductID"];
            txtProductName.Text = gridView.GetDataRow(gridView.FocusedRowHandle)["产品名称"].ToString();
            txtPackage.Text = gridView.GetDataRow(gridView.FocusedRowHandle)["包装规格"].ToString();
            txtProducerName.Text = gridView.GetDataRow(gridView.FocusedRowHandle)["生产厂商"].ToString();
            txtBatchNo.Tag = gridView.GetDataRow(gridView.FocusedRowHandle)["批号"].ToString();
            txtBatchNo.Text = gridView.GetDataRow(gridView.FocusedRowHandle)["批号"].ToString();
            deProduceDate.Text = gridView.GetDataRow(gridView.FocusedRowHandle)["生产日期"].ToString();
            deValidateDate.Text = gridView.GetDataRow(gridView.FocusedRowHandle)["有效期至"].ToString();
            txtAmount.Text = gridView.GetDataRow(gridView.FocusedRowHandle)["期初数量"].ToString();
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            if (txtProductCode.Text.Trim() == "")
            {
                XtraMessageBox.Show("请选择库存信息", "系统提示", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }
            using (SqlConnection conn = new SqlConnection(GlobalItem.g_DbConnectStrings))
            {
                string sql = @"
UPDATE dbo.BUS_BillDetail SET BatchNo = '{0}',ProduceDate = '{1}',ValidateDate = '{2}' WHERE Reservation2 = -{3}
UPDATE dbo.BUS_StoreBillDetail SET BatchNo = '{0}',ProduceDate = '{1}',ValidateDate = '{2}' WHERE Reservation3 = -{3}
UPDATE dbo.BUS_ReviewDetail SET BatchNo = '{0}',ProduceDate = '{1}',ValidateDate = '{2}' WHERE Reservation1 = -{3}

UPDATE dbo.BUS_BeginInventory SET BatchNo = '{0}',ProduceDate = '{1}',ValidateDate = '{2}' WHERE BeginInventoryID = {3}

UPDATE dbo.BUS_InStoreDetail SET BatchNo = '{0}',ProduceDate = '{1}',ValidateDate = '{2}' WHERE InStoreID = -{3}
UPDATE dbo.BUS_OutStoreDetail SET BatchNo = '{0}',ProduceDate = '{1}',ValidateDate = '{2}' WHERE InStoreID = -{3}
UPDATE dbo.BUS_NEWStoreDetail SET BatchNo = '{0}',ProduceDate = '{1}',ValidateDate = '{2}' WHERE InStoreBillID = -{3}
";

                sql = string.Format(sql, txtBatchNo.Text.Trim(), deProduceDate.Text, deValidateDate.Text, txtProductCode.Tag);
                SqlDataAdapter sda = new SqlDataAdapter(sql, conn);
                DataSet ds = new DataSet();
                try
                {
                    conn.Open();
                    SqlCommand cmd = new SqlCommand(sql, conn);
                    cmd.ExecuteNonQuery();
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
            ClearText();
            gridGain();
        }

        private void gridView_CustomDrawRowIndicator(object sender, DevExpress.XtraGrid.Views.Grid.RowIndicatorCustomDrawEventArgs e)
        {
            if (e.Info.IsRowIndicator && e.RowHandle >= 0)
                e.Info.DisplayText = (e.RowHandle + 1).ToString();
        }

        private void ClearText()
        {
            txtProductCode.Text = "";
            txtProductName.Text = "";
            txtProducerName.Text = "";
            txtPackage.Text = "";
            txtBatchNo.Text = "";
            txtAmount.Text = "";
            deProduceDate.Text = "";
            deValidateDate.Text = "";
            cboDepartmentName.Text = "";
        }
    }
}
