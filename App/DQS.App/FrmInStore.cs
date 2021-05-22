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
    public partial class FrmInStore : XtraForm
    {
        public FrmInStore()
        {
            InitializeComponent();
        }

        private void FrmInStore_Load(object sender, EventArgs e)
        {
            GridLoad();
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            if (lableInID.Text.Length > 0)
            {
                SqlConnection conn = new SqlConnection(GlobalItem.g_DbConnectStrings);
                conn.Open();
                try
                {
                    string catesql = @"";
                    if (lableType.Text == "销售退货")
                    {
                        catesql = @"INSERT dbo.BUS_InStoreDetail(InStoreID,InStoreCode,InStoreDate,ProductID,ProductCode,ProductName,PackageSpec,ProducerName,BatchNo,ProduceDate,ValidateDate,SterilizationBatchNo,SterilizationDate,UpDealerID,UpDealerName,InAmount,InUnitPrice,InTotalPrice,ViewPrice,Tax,DepartmentID,CuringDate,IsBillIn,StoreTypeName)
SELECT sbd.DetailID,sb.StoreCode,sb.StoreDate,sbd.ProductID,p.ProductCode,p.ProductName,p.PackageSpec,p.ProducerName,sbd.BatchNo,sbd.ProduceDate,sbd.ValidateDate,sbd.SterilizationBatchNo,sbd.SterilizationDate,sb.DealerID,sb.DealerName,sbd.Amount,sbd.Reservation4,sbd.Reservation5,ISNULL(dbo.fn_getproductinunitprice(isd.InStoreID),ISNULL((SELECT TOP 1 InUnitPrice FROM dbo.BUS_InStoreDetail bi WHERE bi.ProductID = sbd.ProductID AND bi.BatchNo = sbd.BatchNo AND StoreTypeName <> '销售退货' ORDER BY DetailID DESC),(SELECT TOP 1 PurchasePrice
			FROM dbo.BUS_ProductPurchasePrice pp
			INNER JOIN dbo.BUS_Bill b 
				ON pp.PurchaseBillID = b.BillID
		WHERE b.BillTypeName = '采购进货' AND pp.ProductID = sbd.ProductID AND pp.BatchNo = sbd.BatchNo
		ORDER BY ProductPurchasePriceID DESC))),sbd.Reservation6,b.DepartmentID,sb.StoreDate,sb.IsBillIn,sb.StoreTypeName FROM dbo.BUS_StoreBillDetail sbd
INNER JOIN dbo.BUS_StoreBill sb ON sbd.StoreID = sb.StoreID
INNER JOIN dbo.BUS_Bill b ON sb.PurchaseBillCode = b.BillCode
LEFT JOIN dbo.BUS_InStoreDetail isd ON sbd.Reservation3 = isd.InStoreID
--LEFT JOIN dbo.BUS_BillDetail bd ON sb.PurchaseBillID = bd.BillID AND sbd.ProductID = bd.ProductID
LEFT JOIN dbo.BFI_Product p ON sbd.ProductID = p.ProductID
WHERE sbd.DetailID = " + lableInID.Text + " AND NOT EXISTS(SELECT * FROM dbo.BUS_InStoreDetail bis WHERE sbd.DetailID = bis.InStoreID)";
                    }
                    else
                    {
                        catesql = @"INSERT dbo.BUS_InStoreDetail(InStoreID,InStoreCode,InStoreDate,ProductID,ProductCode,ProductName,PackageSpec,ProducerName,BatchNo,ProduceDate,ValidateDate,SterilizationBatchNo,SterilizationDate,UpDealerID,UpDealerName,InAmount,InUnitPrice,InTotalPrice,Tax,DepartmentID,CuringDate,IsBillIn,StoreTypeName)
SELECT sbd.DetailID,sb.StoreCode,sb.StoreDate,sbd.ProductID,p.ProductCode,p.ProductName,p.PackageSpec,p.ProducerName,sbd.BatchNo,sbd.ProduceDate,sbd.ValidateDate,sbd.SterilizationBatchNo,sbd.SterilizationDate,sb.DealerID,sb.DealerName,sbd.Amount,bd.UnitPrice,sbd.Amount*bd.UnitPrice,bd.Reservation1,b.DepartmentID,sb.StoreDate,sb.IsBillIn,sb.StoreTypeName FROM dbo.BUS_StoreBillDetail sbd
INNER JOIN dbo.BUS_StoreBill sb ON sbd.StoreID = sb.StoreID
INNER JOIN dbo.BUS_Bill b ON sb.PurchaseBillCode = b.BillCode
LEFT JOIN dbo.BUS_BillDetail bd ON sb.PurchaseBillID = bd.BillID AND sbd.ProductID = bd.ProductID
LEFT JOIN dbo.BFI_Product p ON sbd.ProductID = p.ProductID
WHERE sbd.DetailID = " + lableInID.Text + " AND NOT EXISTS(SELECT * FROM dbo.BUS_InStoreDetail bis WHERE sbd.DetailID = bis.InStoreID)";

                    }

                    SqlCommand com = new SqlCommand(catesql, conn);
                    int result = com.ExecuteNonQuery();
                    if (result > 0)
                    {
                        string catesql2 = @"INSERT dbo.BUS_NEWStoreDetail(ProductID,BatchNo,ProduceDate,ValidateDate,SterilizationBatchNo,SterilizationDate,ProductName,PackageSpec,ProducerName,InStoreBillID,InStoreCode,InStoreDate,UpDealerID,UpDealerName,InAmount,InUnitPrice,
InTotalPrice,PurchaseTax,InTaxTotalPrice,InNotInCludeTaxTotalPrice,InNotInCludeTaxUnitPrice,
DepartmentID,OutStoreBillID,OutStoreCode,OutAmount,Amount,CuringDate,IsBillIn,StoreTypeName)
SELECT ProductID,BatchNo,ProduceDate,ValidateDate,SterilizationBatchNo,SterilizationDate,ProductName,PackageSpec,ProducerName,InStoreID,InStoreCode,InStoreDate,UpDealerID,UpDealerName,InAmount,InUnitPrice,
InTotalPrice,Tax,CONVERT(DECIMAL(18,2),((InTotalPrice/(1+(Tax/100.0)))*(Tax/100.0))),InTotalPrice-CONVERT(DECIMAL(18,2),((InTotalPrice/(1+(Tax/100.0)))*(Tax/100.0))),
(InTotalPrice-((InTotalPrice/(1+(Tax/100.0)))*(Tax/100.0)))/InAmount,
DepartmentID,0,'',0,0,InStoreDate,IsBillIn,StoreTypeName
FROM dbo.BUS_InStoreDetail isd WHERE isd.InStoreID = " + lableInID.Text + " AND NOT EXISTS(SELECT * FROM dbo.BUS_NEWStoreDetail nsd WHERE isd.InStoreID = nsd.InStoreBillID)";
                        com = new SqlCommand(catesql2, conn);
                        int result2 = com.ExecuteNonQuery();

                        if (result2 > 0)
                        {
                            XtraMessageBox.Show("修复成功。", "系统提示", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                        }
                    }
                }
                catch (Exception)
                {
                    XtraMessageBox.Show("未能修复成功。", "系统提示", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                }
                finally
                {
                    conn.Close();
                }
                GridLoad();
            }
        }

        private void GridLoad()
        {
            string sql = @"SELECT sbd.DetailID,sb.StoreCode AS 单号,sb.StoreTypeName AS 类型,sb.DealerName AS 上家,p.ProductCode AS 编号,p.ProductName AS 名称,sbd.BatchNo AS 批号,sbd.Amount AS 数量
FROM dbo.BUS_StoreBill sb 
INNER JOIN dbo.BUS_StoreBillDetail sbd ON sb.StoreID = sbd.StoreID
INNER JOIN dbo.BFI_Product p ON sbd.ProductID = p.ProductID
WHERE sb.IsBillIn = 1 AND sb.StoreDate > '2017-03-11 01:30:16.927' AND sbd.DetailID NOT IN (SELECT InStoreID FROM dbo.BUS_InStoreDetail)";
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

        private void gridView_DoubleClick(object sender, EventArgs e)
        {
            object ID = Convert.ToInt32(gridView.GetDataRow(gridView.FocusedRowHandle)["DetailID"]);
            object Type = gridView.GetDataRow(gridView.FocusedRowHandle)["类型"];
            lableInID.Text = ID.ToString();
            lableType.Text = Type.ToString();
        }
    }
}
