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
    public partial class FrmMakeCollectionsSearch : XtraForm
    {
        public FrmMakeCollectionsSearch()
        {
            InitializeComponent();
        }

        //查询条件
        string sqlSearch = "";

        private void FrmMakeCollectionsSearch_Load(object sender, EventArgs e)
        {
            deStartDate.Text = DateTime.Today.ToString("d");
            deEndDate.Text = DateTime.Today.ToString("d");
            sqlSearch = " AND (sb.StoreDate BETWEEN '" + deStartDate.Text.Trim() + " 00:00:00' AND '" + deEndDate.Text.Trim() + " 23:59:59')";
            gridLoad();
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
            sqlSearch = " AND (sb.StoreDate BETWEEN '" + deStartDate.Text.Trim() + " 00:00:00' AND '" + deEndDate.Text.Trim() + " 23:59:59')";
            gridLoad();
        }

        private void btnReSet_Click(object sender, EventArgs e)
        {
            sqlSearch = "";
            txtBillCode.Text = "";
            txtDealerCode.Text = "";
            deStartDate.Text = DateTime.Today.ToString("d");
            deEndDate.Text = DateTime.Today.ToString("d");
            gridLoad();
        }

        private void gridLoad()
        {
            using (SqlConnection conn = new SqlConnection(GlobalItem.g_DbConnectStrings))
            {
                string sqlBill = @"SELECT *,
CASE
WHEN tm.状态 = '已收款' THEN CONVERT(NVARCHAR(100),(DATEDIFF(DAY,CONVERT(DATE,tm.出库日期),CONVERT(DATE,tm.收款日期))))
ELSE '未收款'
END AS [收款周期]
FROM (SELECT *,
	CASE 
	WHEN EXISTS(SELECT * FROM dbo.FIN_MakeCollectionsDetail mc WHERE mc.BusinessBillID = t.StoreID) THEN '已收款'
	WHEN EXISTS(SELECT * FROM dbo.FIN_Receivables mc WHERE mc.BusinessBillID = t.StoreID) AND NOT EXISTS(SELECT * FROM dbo.FIN_MakeCollectionsDetail mc WHERE mc.BusinessBillID = t.StoreID) THEN '未收款，在应收'
	WHEN EXISTS(SELECT * FROM dbo.FIN_MakeCollectionsOnPassage mc WHERE mc.BusinessBillID = t.StoreID) AND NOT EXISTS(SELECT * FROM dbo.FIN_Receivables mc WHERE mc.BusinessBillID = t.StoreID) THEN '在途'
	ELSE '无'
	END AS [状态],
	CASE 
	WHEN EXISTS(SELECT * FROM dbo.FIN_MakeCollectionsDetail mc WHERE mc.BusinessBillID = t.StoreID) THEN CONVERT(NVARCHAR(100),CONVERT(DATE,(SELECT TOP 1 m.OperateDate FROM dbo.FIN_MakeCollectionsDetail mc INNER JOIN dbo.FIN_MakeCollections m ON mc.MakeCollectionsCode = m.MakeCollectionsCode WHERE mc.BusinessBillID = t.StoreID)))
	WHEN EXISTS(SELECT * FROM dbo.FIN_Receivables mc WHERE mc.BusinessBillID = t.StoreID) AND NOT EXISTS(SELECT * FROM dbo.FIN_MakeCollectionsDetail mc WHERE mc.BusinessBillID = t.StoreID) THEN '未收款，在应收'
	WHEN EXISTS(SELECT * FROM dbo.FIN_MakeCollectionsOnPassage mc WHERE mc.BusinessBillID = t.StoreID) AND NOT EXISTS(SELECT * FROM dbo.FIN_Receivables mc WHERE mc.BusinessBillID = t.StoreID) THEN '在途'
	ELSE '无'
	END AS [收款日期] FROM
(SELECT 
	sb.StoreID,sb.StoreCode AS [单据编号],
	d.DealerCode AS [往来单位编码],
	d.DealerName AS [往来单位名称],
	d.DealerSpell AS [往来单位简拼],
	d.DealerType AS [往来单位类型],
	u.UserName AS [开票人],
	d.BusinessPerson AS [业务员],
	b.BillDate AS [下单日期],
	ISNULL(w.OperationRealname,'') AS [出库人],
	sb.StoreDate AS [出库日期],
	CASE sb.StoreTypeName
	WHEN '销售出货' THEN b.TotalPrice 
	WHEN '销售退货' THEN -b.TotalPrice
	ELSE b.TotalPrice
	END AS [总金额]
FROM dbo.BUS_StoreBill sb 
	INNER JOIN dbo.BUS_Bill b ON (sb.SaleBillID = b.BillID OR sb.PurchaseBillID = b.BillID)
	LEFT JOIN dbo.ATC_User u ON b.CreateUserID = u.UserID
	INNER JOIN dbo.BFI_Dealer d ON b.DealerID = d.DealerID
	LEFT JOIN dbo.WMS_StoreOutReviewIdentity w ON sb.StoreID = w.StoreID
WHERE sb.StoreTypeName IN ('销售出货','销售退货') AND (d.DealerCode LIKE '%{0}%' OR d.DealerName LIKE '%{0}%' OR d.DealerSpell LIKE '%{0}%') AND (sb.StoreCode LIKE '%{1}%')" + sqlSearch + ") t) tm";

                sqlBill = String.Format(sqlBill, txtDealerCode.Text.Trim(), txtBillCode.Text.Trim());
                SqlDataAdapter sda = new SqlDataAdapter(sqlBill, conn);
                DataSet ds = new DataSet();
                try
                {
                    sda.Fill(ds, "TableBill");
                    decimal Price = 0;
                    for (int i = 0; i < ds.Tables["TableBill"].Rows.Count; i++)
                    {
                        Price += Convert.ToDecimal(ds.Tables["TableBill"].Rows[i]["总金额"]);
                    }
                    lblTotalPrice.Text = Price.ToString();
                    gridControl.DataSource = ds.Tables["TableBill"];
                    gridView.OptionsView.ColumnAutoWidth = false;
                    gridView.BestFitColumns();
                    gridView.OptionsView.ShowGroupPanel = false;

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
