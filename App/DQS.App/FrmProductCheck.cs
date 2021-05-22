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
    public partial class FrmProductCheck : Form
    {
        public FrmProductCheck()
        {
            InitializeComponent();
        }

        private void FrmProductCheck_Load(object sender, EventArgs e)
        {
            //GridLoad();
            //GridLoadAllP();
        }


        private void GridLoad()
        {
            //获取当前时间
            string dateStr = DateTime.Now.ToString("yyyy-MM-dd");
            string sql = @"SELECT DISTINCT p.ProductID AS ID,p.ProductCode AS 编号,p.ProductName AS 名称,p.CommonName AS 通用名称,p.ProducerName AS 生产厂商,
p.AuthorizedNo AS 批准文号,p.ProductSpec AS 规格,p.PackageSpec AS 包装规格 ,p.AllProductID
FROM dbo.BUS_StoreBill sb 
INNER JOIN dbo.BUS_StoreBillDetail sbd ON sb.StoreID = sbd.StoreID
INNER JOIN dbo.BFI_Product p ON sbd.ProductID = p.ProductID
WHERE p.Reservation1 = 1 and sb.StoreDate >= '" + dateStr + " 00:00:00' AND sb.StoreDate <= '" + dateStr + " 23:59:59' AND p.AuthorizedNo like '%" + txtApp.Text.Trim() + "%' AND p.productName LIKE '%" + txtProductName.Text.Trim() + "%' AND p.ProducerName LIKE '%" + txtProducer.Text.Trim() + "%'";
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
            string sql = @"SELECT ID,GenericNameOfTheDrug AS 名称,ProductionEnterprises AS 生产企业,ApprovalNo AS 批准文号,Specifications AS 规格 FROM dbo.BFI_AllProduct 
WHERE ApprovalNo like '%" + txtAllApp.Text.Trim() + "%' AND GenericNameOfTheDrug LIKE '%" + txtAllProductName.Text.Trim() + "%' AND ProductionEnterprises LIKE '%" + txtAllProducer.Text.Trim() + "%'";
            //id  NOT IN (SELECT allproductid FROM bfi_product WHERE allproductid IS not null) and 
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
                    gridView.Columns["批准文号"].OptionsColumn.AllowEdit = true;
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

        private void btnSearch_Click(object sender, EventArgs e)
        {
            if (txtApp.Text.Trim() == "")
            {
                GridLoad();
            }
            else
            {
                GridLoad();
                txtAllProductName.Text = txtProductName.Text;
                txtAllApp.Text = txtApp.Text;
                txtAllProducer.Text = txtProducer.Text;
                GridLoadAllP();
            }
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

        private void btnSave_Click(object sender, EventArgs e)
        {
            if (lblOldID.Text.Length > 0 && lblNewID.Text.Length > 0)
            {
                SqlConnection conn = new SqlConnection(GlobalItem.g_DbConnectStrings);
                conn.Open();
                try
                {
                    string catesql = "update dbo.BFI_Product set allproductID = " + lblNewID.Text + " WHERE productid = " + lblOldID.Text;
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

        private void btnAllSearch_Click(object sender, EventArgs e)
        {
            GridLoadAllP();
        }

        private void btnNew_Click(object sender, EventArgs e)
        {
            using (FrmNewAllProduct frm = new FrmNewAllProduct())
            {
                frm.ShowDialog();
            }
        }

    }
}
