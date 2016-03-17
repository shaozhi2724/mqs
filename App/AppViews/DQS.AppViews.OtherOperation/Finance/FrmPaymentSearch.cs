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
    public partial class FrmPaymentSearch : XtraForm
    {
        public FrmPaymentSearch()
        {
            InitializeComponent();
        }

        //查询条件
        string sqlSearch = "";

        private void FrmPaymentSearch_Load(object sender, EventArgs e)
        {
            deStartDate.Text = DateTime.Today.ToString("d");
            deEndDate.Text = DateTime.Today.ToString("d");
            //gridLoad();
        }

        private void gridView_CustomDrawRowIndicator(object sender, DevExpress.XtraGrid.Views.Grid.RowIndicatorCustomDrawEventArgs e)
        {
            if (e.Info.IsRowIndicator && e.RowHandle >= 0)
                e.Info.DisplayText = (e.RowHandle + 1).ToString();
        }

        private void btnExport_Click(object sender, EventArgs e)
        {
            SaveFileDialog saveFileDialog = new SaveFileDialog();

            saveFileDialog.Title = "导出Excel";

            saveFileDialog.Filter = "Excel文件(*.xls)|*.xls";

            DialogResult dialogResult = saveFileDialog.ShowDialog(this);

            if (dialogResult == DialogResult.OK)
            {

                DevExpress.XtraPrinting.XlsExportOptions options = new DevExpress.XtraPrinting.XlsExportOptions();

                //gridControl1.ExportToXls(saveFileDialog.FileName, options);  

                //gridControl.ExportToExcelOld(saveFileDialog.FileName);
                gridControl.ExportToXls(saveFileDialog.FileName);

                DevExpress.XtraEditors.XtraMessageBox.Show("保存成功！", "提示", MessageBoxButtons.OK, MessageBoxIcon.Information);

            }
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            gridLoad();
        }

        private void btnReSet_Click(object sender, EventArgs e)
        {
            txtBillCode.Text = "";
            txtDealerCode.Text = "";
            deStartDate.Text = DateTime.Today.ToString("d");
            deEndDate.Text = DateTime.Today.ToString("d");
            gridLoad();
        }

        private void gridLoad()
        {
            sqlSearch = " AND (sb.StoreDate BETWEEN '" + deStartDate.Text.Trim() + " 00:00:00' AND '" + deEndDate.Text.Trim() + " 23:59:59')";
            using (SqlConnection conn = new SqlConnection(GlobalItem.g_DbConnectStrings))
            {
                string sqlBill = @"SELECT 
	sb.StoreID,sb.StoreCode AS [单据编号],
	d.DealerCode AS [往来单位编码],
	d.DealerName AS [往来单位名称],
	d.DealerSpell AS [往来单位简拼],
	d.DealerType AS [往来单位类型],
	u.UserName AS [开票人],
	d.BusinessPerson AS [业务员],
	b.BillDate AS [下单日期],
	sb.StoreKeeper AS [入库人],
	sb.StoreDate AS [出库日期],
	CASE sb.StoreTypeName
	WHEN '采购进货' THEN b.TotalPrice 
	WHEN '采购退货' THEN -b.TotalPrice
	ELSE b.TotalPrice
	END AS [总金额]
FROM dbo.BUS_StoreBill sb 
	INNER JOIN dbo.BUS_Bill b ON (sb.SaleBillID = b.BillID OR sb.PurchaseBillID = b.BillID)
	LEFT JOIN dbo.ATC_User u ON b.CreateUserID = u.UserID
	INNER JOIN dbo.BFI_Dealer d ON b.DealerID = d.DealerID
	LEFT JOIN dbo.WMS_StoreOutReviewIdentity w ON sb.StoreID = w.StoreID
WHERE sb.StoreTypeName IN ('采购进货','采购退货') AND (d.DealerCode LIKE '%{0}%' OR d.DealerName LIKE '%{0}%' OR d.DealerSpell LIKE '%{0}%') AND (sb.StoreCode LIKE '%{1}%')" + sqlSearch;
                string sql = @"SELECT 
	sb.StoreCode AS [单据编号],
	p.ProductName AS [产品名称],
	sbd.BatchNo AS [批号],
	CASE sb.StoreTypeName 
		WHEN '采购进货' THEN sbd.Amount 
		WHEN '采购退货' THEN -sbd.Amount	
	ELSE sbd.Amount 
	END AS [数量],
	bd.UnitPrice AS [单价],
	CASE sb.StoreTypeName 
		WHEN '采购进货' THEN sbd.Amount*bd.UnitPrice 
		WHEN '采购退货' THEN -sbd.Amount*bd.UnitPrice	
	ELSE sbd.Amount*bd.UnitPrice 
	END AS [金额],
	p.ProductStyle AS [类别],
	p.PhysicType AS [剂型],
	p.ProducerName AS [生产厂商],
	p.AuthorizedNo AS [注册证号],
	sbd.ProduceDate AS [生产日期],
	sbd.ValidateDate AS [有效期],
	p.PackageSpec AS [包装规格]
FROM dbo.BUS_StoreBillDetail sbd
	INNER JOIN dbo.BUS_StoreBill sb ON sbd.StoreID = sb.StoreID
	INNER JOIN dbo.BUS_BillDetail bd ON (sb.SaleBillID = bd.BillID AND sbd.ProductID = bd.ProductID AND sbd.BatchNo = bd.BatchNo) OR (sb.PurchaseBillID = bd.BillID AND sbd.ProductID = bd.ProductID)
	INNER JOIN dbo.BFI_Product p ON sbd.ProductID = p.ProductID
	INNER JOIN dbo.BFI_Dealer d ON sb.DealerID = d.DealerID";

                sqlBill = String.Format(sqlBill, txtDealerCode.Text.Trim(), txtBillCode.Text.Trim());
                SqlDataAdapter sda = new SqlDataAdapter(sql, conn);
                SqlDataAdapter sdad = new SqlDataAdapter(sqlBill, conn);
                DataSet ds = new DataSet();
                try
                {
                    sda.Fill(ds, "Table");
                    sdad.Fill(ds, "TableBill");
                    DataRelation dr = new DataRelation("单据明细", ds.Tables["TableBill"].Columns["单据编号"], ds.Tables["Table"].Columns["单据编号"], false);
                    ds.Relations.Add(dr);
                    //decimal Price = 0;
                    //for (int i = 0; i < ds.Tables["TableBill"].Rows.Count; i++)
                    //{
                    //    Price += Convert.ToDecimal(ds.Tables["TableBill"].Rows[i]["总金额"]);
                    //}
                    //lblTotalPrice.Text = Price.ToString();
                    gridControl.DataSource = ds.Tables["TableBill"];
                    gridView.OptionsView.ColumnAutoWidth = false;
                    gridView.BestFitColumns();
                    gridView.OptionsView.ShowGroupPanel = false;

                    gridView.Columns["总金额"].SummaryItem.SummaryType = DevExpress.Data.SummaryItemType.Sum;
                    gridView.Columns["总金额"].SummaryItem.DisplayFormat = "合计: {0}";

                    for (int i = 0; i < gridView.Columns.Count; i++)
                    {
                        string ColumnName = gridView.Columns[i].ToString();
                        if (ColumnName.Contains("ID"))
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

        private void txtChanged(object sender, EventArgs e)
        {
            gridLoad();
        }
    }
}
