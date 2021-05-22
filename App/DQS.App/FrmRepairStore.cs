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
    public partial class FrmRepairStore : XtraForm
    {
        public FrmRepairStore()
        {
            InitializeComponent();
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            GridLoad();
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            SqlConnection conn = new SqlConnection(GlobalItem.g_DbConnectStrings);
            conn.Open();
            try
            {
                string catesql = @"INSERT dbo.BUS_NEWStoreDetail(ProductID,BatchNo,ProduceDate,ValidateDate,SterilizationBatchNo,SterilizationDate,
		ProductName,PackageSpec,ProducerName,InStoreBillID,InStoreCode,InStoreDate,UpDealerID,UpDealerName,
		InAmount,InUnitPrice,InTotalPrice,PurchaseTax,InNotInCludeTaxUnitPrice,InNotInCludeTaxTotalPrice,InTaxTotalPrice,
		DepartmentID,SaleBillID,OutStoreBillID,OutStoreCode,OutStoreDate,DownDealerID,DownDealerName,OutAmount,OutUnitPrice,
		OutTotalPrice,SaleTax,OutTaxTotalPrice,OutNotInCludeTaxTotalPrice,OutNotInCludeTaxUnitPrice,Amount,Operator,
		BuildBillUserName,IsBillIn,StoreTypeName)
		SELECT osd.ProductID,osd.BatchNo,isd.ProduceDate,isd.ValidateDate,isd.SterilizationBatchNo,isd.SterilizationDate,
		osd.ProductName,osd.PackageSpec,osd.ProducerName,isd.InStoreID,isd.InStoreCode,isd.InStoreDate,isd.UpDealerID,isd.UpDealerName,
		0,isd.InUnitPrice,0,isd.Tax,0,0,0,
isd.DepartmentID,osd.BillID,osd.OutStoreID,osd.OutStoreCode,osd.OutStoreDate,osd.DownDealerID,osd.DownDealerName,osd.OutAmount,osd.OutUnitPrice,
		osd.OutTotalPrice,osd.Tax,CONVERT(DECIMAL(18,2),((osd.OutTotalPrice/(1+(osd.Tax/100.0)))*(osd.Tax/100.0))),osd.OutTotalPrice-CONVERT(DECIMAL(18,2),((osd.OutTotalPrice/(1+(osd.Tax/100.0)))*(osd.Tax/100.0))),(osd.OutTotalPrice-((osd.OutTotalPrice/(1+(osd.Tax/100.0)))*(osd.Tax/100.0)))/osd.OutAmount,dbo.fn_GetAmount(osd.InStoreID),osd.Operator,osd.BuildBillUserName,osd.IsBillIn,osd.StoreTypeName
		FROM dbo.BUS_OutStoreDetail osd 
		INNER JOIN dbo.BUS_InStoreDetail isd ON osd.InStoreID = isd.InStoreID
		WHERE osd.OutStoreID NOT IN (SELECT OutStoreBillID FROM dbo.BUS_NEWStoreDetail)";
                SqlCommand com = new SqlCommand(catesql, conn);
                int result = com.ExecuteNonQuery();
                if (result > 0)
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
            GridLoad();
        }

        private void GridLoad()
        {
            string sql = @"SELECT InStoreID ,产品ID ,产品编号 ,产品名称 ,批号,有效期至 ,生产日期 ,库存数量 
            FROM vw_NewProductStoreDetailForError WHERE 产品编号 = '" + txtProductCode.Text + "' AND 批号 = '" + txtBatchNo.Text + "' AND 库存数量 != 0";
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

        private void GridLoadNewStore(string inStoreBillID)
        {
            string sql = @"SELECT StoreDetailID ,
       BatchNo as 批号,
       ProductName as 名称,
       InStoreCode as 入库单号,
       InAmount as 入库数量,
       OutStoreBillID ,
       OutStoreCode as 出库单号,
       OutAmount as 出库数量 FROM dbo.BUS_NEWStoreDetail WHERE InStoreBillID = " + inStoreBillID;
            using (SqlConnection conn = new SqlConnection(GlobalItem.g_DbConnectStrings))
            {
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
                    XtraMessageBox.Show(ex.Message, "系统提示", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                finally
                {
                    conn.Close();
                }
            }
        }

        private void gridView_RowClick(object sender, DevExpress.XtraGrid.Views.Grid.RowClickEventArgs e)
        {
            object ID = Convert.ToInt32(gridView.GetDataRow(gridView.FocusedRowHandle)["InStoreID"]);
            GridLoadNewStore(ID.ToString());
        }

        private void gridView1_DoubleClick(object sender, EventArgs e)
        {
            object ID = Convert.ToInt32(gridView1.GetDataRow(gridView.FocusedRowHandle)["StoreDetailID"]);
            object NoID = Convert.ToInt32(gridView1.GetDataRow(gridView.FocusedRowHandle)["OutStoreBillID"]);
            object NoAmount = Convert.ToInt32(gridView1.GetDataRow(gridView.FocusedRowHandle)["出库数量"]);
            lableDelID.Text = ID.ToString();
            lableNoID.Text = NoID.ToString();
            lableNoAmount.Text = NoAmount.ToString();
            txtInAmount.Text = NoAmount.ToString();
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            if (lableDelID.Text != "")
            {
                SqlConnection conn = new SqlConnection(GlobalItem.g_DbConnectStrings);
                conn.Open();
                try
                {
                    string catesql = "DELETE dbo.BUS_NEWStoreDetail WHERE StoreDetailID = " + lableDelID.Text;
                    SqlCommand com = new SqlCommand(catesql, conn);
                    int result = com.ExecuteNonQuery();
                    if (result == 1)
                    {
                        XtraMessageBox.Show("删除成功。", "系统提示", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                    }
                }
                catch (Exception)
                {
                    XtraMessageBox.Show("未能删除成功。", "系统提示", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                }
                finally
                {
                    conn.Close();
                }
                lableDelID.Text = "";
                GridLoad();
            }
        }

        private void btnInsert_Click(object sender, EventArgs e)
        {
            if (lableNoID.Text != "" && lableNewID.Text != "" && txtInAmount.Text != "")
            {
                SqlConnection conn = new SqlConnection(GlobalItem.g_DbConnectStrings);
                conn.Open();
                try
                {
                    string catesql = @"INSERT dbo.BUS_NEWStoreDetail(ProductID,BatchNo,ProduceDate,ValidateDate,SterilizationBatchNo,SterilizationDate,
		ProductName,PackageSpec,ProducerName,InStoreBillID,InStoreCode,InStoreDate,UpDealerID,UpDealerName,
		InAmount,InUnitPrice,InTotalPrice,PurchaseTax,InNotInCludeTaxUnitPrice,InNotInCludeTaxTotalPrice,InTaxTotalPrice,
		DepartmentID,SaleBillID,OutStoreBillID,OutStoreCode,OutStoreDate,DownDealerID,DownDealerName,OutAmount,OutUnitPrice,
		OutTotalPrice,SaleTax,OutTaxTotalPrice,OutNotInCludeTaxTotalPrice,OutNotInCludeTaxUnitPrice,Amount,Operator,
		BuildBillUserName,IsBillIn,StoreTypeName)
SELECT osd.ProductID,osd.BatchNo,isd.ProduceDate,isd.ValidateDate,isd.SterilizationBatchNo,isd.SterilizationDate,
		osd.ProductName,osd.PackageSpec,osd.ProducerName,isd.InStoreID,isd.InStoreCode,isd.InStoreDate,isd.UpDealerID,isd.UpDealerName,
		0,isd.InUnitPrice,0,isd.Tax,0,0,0,isd.DepartmentID,osd.BillID,osd.OutStoreID,osd.OutStoreCode,osd.OutStoreDate,osd.DownDealerID,
osd.DownDealerName," +txtInAmount.Text+",osd.OutUnitPrice,osd.OutTotalPrice,osd.Tax,CONVERT(DECIMAL(18,2),((osd.OutTotalPrice/(1+(osd.Tax/100.0)))*(osd.Tax/100.0))),osd.OutTotalPrice-CONVERT(DECIMAL(18,2),((osd.OutTotalPrice/(1+(osd.Tax/100.0)))*(osd.Tax/100.0))),(osd.OutTotalPrice-((osd.OutTotalPrice/(1+(osd.Tax/100.0)))*(osd.Tax/100.0)))/osd.OutAmount,dbo.fn_GetAmount(osd.InStoreID),osd.Operator,osd.BuildBillUserName,osd.IsBillIn,osd.StoreTypeName FROM dbo.BUS_OutStoreDetail osd INNER JOIN dbo.BUS_InStoreDetail isd ON isd.InStoreID = "+lableNewID.Text+" WHERE osd.OutStoreID = " + lableNoID.Text;
                    SqlCommand com = new SqlCommand(catesql, conn);
                    int result = com.ExecuteNonQuery();
                    if (result == 1)
                    {
                        XtraMessageBox.Show("插入成功。", "系统提示", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                    }
                }
                catch (Exception)
                {
                    XtraMessageBox.Show("未能插入成功。", "系统提示", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                }
                finally
                {
                    conn.Close();
                }
                lableDelID.Text = "";
                GridLoad();
            }
        }

        private void gridView_DoubleClick(object sender, EventArgs e)
        {
            object InStoreID = Convert.ToInt32(gridView.GetDataRow(gridView.FocusedRowHandle)["InStoreID"]);
            object StoreAmount = Convert.ToInt32(gridView.GetDataRow(gridView.FocusedRowHandle)["库存数量"]);
            lableNewID.Text = InStoreID.ToString();
            lableNoAmount.Text = StoreAmount.ToString();
            if (int.Parse(StoreAmount.ToString()) < int.Parse(txtInAmount.Text))
            {
                txtInAmount.Text = StoreAmount.ToString();
            }
        }
    }
}
