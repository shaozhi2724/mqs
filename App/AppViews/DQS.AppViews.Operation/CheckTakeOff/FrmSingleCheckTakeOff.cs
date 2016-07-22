using DevExpress.XtraEditors;
using DQS.Common;
using DQS.Module;
using DQS.Module.Entities;
using ORMSCore;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace DQS.AppViews.Operation.CheckTakeOff
{
    public partial class FrmSingleCheckTakeOff : XtraForm
    {
        public FrmSingleCheckTakeOff()
        {
            InitializeComponent();
        }

        List<TakeOff> list = new List<TakeOff>();

        DataTable dt = new DataTable();

        private void FrmSingleCheckTakeOff_Load(object sender, EventArgs e)
        {
            DataTableLoad();
            txtDate.Text = DateTime.Today.ToString("d");
            txtOper.Text = GlobalItem.g_CurrentEmployee.EmployeeName;
            GridLoad();
        }

        private void GridTwoLoad()
        {
            gridControl2.DataSource = dt;
        }

        private void DataTableLoad()
        {

            dt.Columns.Add("DetailID", typeof(int));
            dt.Columns.Add("ProductID", typeof(int));
            dt.Columns.Add("StructureID", typeof(int));
            dt.Columns.Add("StructureCode", typeof(string));
            dt.Columns.Add("StructureName", typeof(string));
            dt.Columns.Add("ProductName", typeof(string));
            dt.Columns.Add("ProductBatchNumber", typeof(string));
            dt.Columns.Add("ProductionDate", typeof(DateTime));
            dt.Columns.Add("ProductValidDate", typeof(DateTime));
            dt.Columns.Add("ProductAmount", typeof(int));
            dt.Columns.Add("PackageSpec", typeof(string));
            dt.Columns.Add("ProducerName", typeof(string));
            dt.Columns.Add("Amount", typeof(int));
        }

        private void GridLoad()
        {
            using (SqlConnection conn = new SqlConnection(GlobalItem.g_DbConnectStrings))
            {
                string sql = @"SELECT 
	cssd.CargoSpaceStoreDetailID AS [DetailID],
	cssd.StructureID,
	ss.StructureCode AS [货位编码],
	ss.StructureName AS [货位名称],
	cssd.ProductID,
	p.ProductName AS [产品名称],
	cssd.ProductBatchNumber AS [批号],
	cssd.ProductionDate AS [生产日期],
	cssd.ProductValidDate AS [有效期至],
	cssd.ProductAmount AS [数量],
	p.PackageSpec AS [包装规格],
	p.ProducerName AS [生产厂商]
FROM dbo.WMS_CargoSpaceStoreDetail cssd
LEFT JOIN dbo.BFI_StorageStructure ss ON cssd.StructureID = ss.StructureID
LEFT JOIN dbo.BFI_Product p ON cssd.ProductID = p.ProductID
WHERE (p.ProductCode LIKE '%" + txtProduct.Text.Trim() + "%' OR p.ProductName LIKE '%" + txtProduct.Text.Trim() + "%' OR p.ProductSpell LIKE '%" + txtProduct.Text.Trim() + "%') AND ss.StructureCode LIKE '%" + txtStructureCode.Text.Trim() + "%'";
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

        private void gridView1_DoubleClick(object sender, EventArgs e)
        {

            DataRow dr = dt.NewRow();

            int DetailID = Convert.ToInt32(gridView1.GetFocusedDataRow()["DetailID"]);
            int StructureID = Convert.ToInt32(gridView1.GetFocusedDataRow()["StructureID"]);
            string StructureCode = gridView1.GetFocusedDataRow()["货位编码"].ToString();
            string StructureName = gridView1.GetFocusedDataRow()["货位名称"].ToString();
            int ProductID = Convert.ToInt32(gridView1.GetFocusedDataRow()["ProductID"]);
            string ProductName = gridView1.GetFocusedDataRow()["产品名称"].ToString();
            string BatchNo = gridView1.GetFocusedDataRow()["批号"].ToString();
            DateTime ProductionDate = (DateTime)gridView1.GetFocusedDataRow()["生产日期"];
            DateTime ProductValidDate = (DateTime)gridView1.GetFocusedDataRow()["有效期至"];
            int ProductAmount = Convert.ToInt32(gridView1.GetFocusedDataRow()["数量"]);
            string PackageSpec = gridView1.GetFocusedDataRow()["包装规格"].ToString();
            string ProducerName = gridView1.GetFocusedDataRow()["生产厂商"].ToString();
            
            dr["DetailID"] = DetailID;
            dr["ProductID"] = ProductID;
            dr["StructureID"] = StructureID;
            dr["StructureCode"] = StructureCode;
            dr["StructureName"] = StructureName;
            dr["ProductName"] = ProductName;
            dr["ProductBatchNumber"] = BatchNo;
            dr["ProductionDate"] = ProductionDate;
            dr["ProductValidDate"] = ProductValidDate;
            dr["ProductAmount"] = ProductAmount;
            dr["PackageSpec"] = PackageSpec;
            dr["ProducerName"] = ProducerName;
            dr["Amount"] = 0;
            dt.Rows.Add(dr);
            GridTwoLoad();
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            GridLoad();
        }

        private void gridView2_CellValueChanging(object sender, DevExpress.XtraGrid.Views.Base.CellValueChangedEventArgs e)
        {
            int ProductAmount = Convert.ToInt32(gridView2.GetFocusedRowCellValue("ProductAmount"));
            int Amount = Convert.ToInt32(e.Value);
            if (Amount > ProductAmount)
            {
                XtraMessageBox.Show("不能大于库存数量！", "系统提示", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            //dt.Rows[0]["Amount"] = Amount;
        }

        private void gridView2_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Delete)
            {
                DialogResult dr = XtraMessageBox.Show("确定要删除此行数据吗？", "提示", MessageBoxButtons.OKCancel, MessageBoxIcon.Question);
                if (dr == DialogResult.OK)
                {
                    dt.Rows.RemoveAt(gridView2.FocusedRowHandle);
                }
            }
        }

        private void gridView1_CustomDrawRowIndicator(object sender, DevExpress.XtraGrid.Views.Grid.RowIndicatorCustomDrawEventArgs e)
        {
            if (e.Info.IsRowIndicator && e.RowHandle >= 0)
                e.Info.DisplayText = (e.RowHandle + 1).ToString();
        }

        private void gridView2_CustomDrawRowIndicator(object sender, DevExpress.XtraGrid.Views.Grid.RowIndicatorCustomDrawEventArgs e)
        {
            if (e.Info.IsRowIndicator && e.RowHandle >= 0)
                e.Info.DisplayText = (e.RowHandle + 1).ToString();
        }

        private bool CheckTakeAmount()
        {
            for (int i = 0; i < gridView2.RowCount; i++)
            {
                int TakeAmount = Convert.ToInt32(gridView2.GetDataRow(i)["Amount"]);
                if (TakeAmount == 0)
                {
                    XtraMessageBox.Show(string.Format("第{0}行的数量不能为0.", i+1), "系统提示", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return false;
                }
            }
            return true;
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            if (!CheckTakeAmount()) return;
            if (txtRemark.Text.Trim() == "")
            {
                XtraMessageBox.Show("原因备注不能为空！", "系统提示", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            for (int i = 0; i < gridView2.RowCount; i++)
            {
                int DetailID = Convert.ToInt32(gridView2.GetDataRow(i)["DetailID"]);
                int StructureID = Convert.ToInt32(gridView2.GetDataRow(i)["StructureID"]);
                string StructureCode = gridView2.GetDataRow(i)["StructureCode"].ToString();
                string StructureName = gridView2.GetDataRow(i)["StructureName"].ToString();
                int ProductID = Convert.ToInt32(gridView2.GetDataRow(i)["ProductID"]);
                string ProductName = gridView2.GetDataRow(i)["ProductName"].ToString();
                string BatchNo = gridView2.GetDataRow(i)["ProductBatchNumber"].ToString();
                DateTime ProductionDate = (DateTime)gridView2.GetDataRow(i)["ProductionDate"];
                DateTime ProductValidDate = (DateTime)gridView2.GetDataRow(i)["ProductValidDate"];
                int ProductAmount = Convert.ToInt32(gridView2.GetDataRow(i)["ProductAmount"]);
                string PackageSpec = gridView2.GetDataRow(i)["PackageSpec"].ToString();
                string ProducerName = gridView2.GetDataRow(i)["ProducerName"].ToString();
                int TakeAmount = Convert.ToInt32(gridView2.GetDataRow(i)["Amount"]);

                UpdateBusStoreDetail(ProductID, ProductName, BatchNo, TakeAmount);
                UpdateStoreDetail(TakeAmount, DetailID);
                Save(ProductID, BatchNo, ProductionDate, ProductValidDate, StructureID, ProductAmount, TakeAmount, Convert.ToDateTime(txtDate.Text.Trim()), txtOper.Text.Trim(), txtRemark.Text.Trim());
            }
            this.DialogResult = DialogResult.Yes;
        }

        private void Save(int ProductID, string BatchNo, DateTime ProductionDate, DateTime ProductValidDate, int StructureID, int Amount, int TakeAmount, DateTime OperDate, string OperPerson, string Remark)
        {
            string sql = @"INSERT dbo.BUS_CheckTakeOff(ProductID,BatchNo,ProductionDate,ProductValidDate,StructureID,Amount,TakeAmount,OperDate,OperPerson,Remark)
VALUES ({0},'{1}','{2}','{3}',{4},{5},{6},'{7}','{8}','{9}')";
            sql = string.Format(sql, ProductID, BatchNo, ProductionDate, ProductValidDate, StructureID, Amount, TakeAmount, OperDate, OperPerson, Remark);
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
                    XtraMessageBox.Show(ex.Message, "系统提示", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                finally
                {
                    conn.Close();
                }
            }
        }

        private void UpdateBusStoreDetail(int ProductID, string ProductName, string BatchNo, int TakeAmount)
        {
            string sql = @"SELECT StoreDetailID FROM dbo.BUS_StoreDetail WHERE ProductID = " + ProductID + " AND BatchNo = '" + BatchNo + "' AND Amount > " + TakeAmount;
            using (SqlConnection conn = new SqlConnection(GlobalItem.g_DbConnectStrings))
            {
                conn.Open(); //连接数据库
                //必须为SqlCommand指定数据库连接和登记的事务
                SqlCommand cmd = new SqlCommand(sql, conn);
                try
                {
                    object num = cmd.ExecuteScalar();
                    if (num != null)
                    {
                        string Updatesql = "UPDATE dbo.BUS_StoreDetail SET Amount = Amount - " + TakeAmount + " WHERE StoreDetailID = " + (int)num;
                        SqlCommand comm = new SqlCommand(Updatesql, conn);
                        comm.ExecuteNonQuery();
                    }
                    else
                    {
                        XtraMessageBox.Show(string.Format("请手动更改 {0} 批号为 {1} 的业务库存！", ProductName, BatchNo), "系统提示", MessageBoxButtons.OK, MessageBoxIcon.Error);
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

        private void UpdateStoreDetail(int TakeAmount, int DetailID)
        {
            string sql = @"UPDATE dbo.WMS_CargoSpaceStoreDetail SET ProductAmount = ProductAmount - {0} WHERE CargoSpaceStoreDetailID = {1}";
            sql = string.Format(sql, TakeAmount, DetailID);
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
