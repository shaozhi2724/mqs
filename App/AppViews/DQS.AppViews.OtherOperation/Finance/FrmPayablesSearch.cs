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
    public partial class FrmPayablesSearch : XtraForm
    {
        public FrmPayablesSearch()
        {
            InitializeComponent();
        }

        private void FrmPayablesSearch_Load(object sender, EventArgs e)
        {
            gridLoad();
        }

        private void gridLoad()
        {
            using (SqlConnection conn = new SqlConnection(GlobalItem.g_DbConnectStrings))
            {
                string sqlBill = @"SELECT d.*,d.期初+d.本期应付-d.本期实付 AS [余额] FROM (
SELECT a.DealerCode AS [编号],a.DealerName AS [供应商名称],a.DealerSpell AS [供应商简拼],a.ThisInventoryPayables AS [期初],ISNULL(b.TotalPrice,0) AS [本期应付],ISNULL(c.TotalPrice,0) AS [本期实付] FROM
(SELECT DealerCode,DealerName,DealerSpell,ThisInventoryPayables FROM dbo.FIN_InventoryDetail WHERE DealerType = '供应商') a
FULL JOIN 
(SELECT DealerCode,DealerName,DealerSpell,SUM(TotalPrice) AS TotalPrice FROM dbo.FIN_Payables GROUP BY DealerCode,DealerName,DealerSpell) b ON a.DealerCode = b.DealerCode AND a.DealerName = b.DealerName
FULL JOIN 
(SELECT DealerCode,DealerName,DealerSpell,SUM(TotalPrice) AS TotalPrice FROM dbo.FIN_Payment GROUP BY DealerCode,DealerName,DealerSpell) c ON a.DealerCode = c.DealerCode AND a.DealerName = c.DealerName) d
WHERE (d.编号 LIKE '%" + txtDealerCode.Text.Trim() + "%' OR d.供应商名称 LIKE '%" + txtDealerCode.Text.Trim() + "%' OR d.供应商简拼 LIKE '%" + txtDealerCode.Text.Trim() + "%')";

                SqlDataAdapter sda = new SqlDataAdapter(sqlBill, conn);
                DataSet ds = new DataSet();
                try
                {
                    sda.Fill(ds, "Table");
                    //decimal Price = 0;
                    //for (int i = 0; i < ds.Tables["Table"].Rows.Count; i++)
                    //{
                    //    Price += Convert.ToDecimal(ds.Tables["TableBill"].Rows[i]["总金额"]);
                    //}
                    gridControl.DataSource = ds.Tables["Table"];
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

        private void btnReSet_Click(object sender, EventArgs e)
        {
            txtDealerCode.Text = "";
        }

        private void txtChanged(object sender, EventArgs e)
        {
            gridLoad();
        }

        private void gridView_DoubleClick(object sender, EventArgs e)
        {
            string dealerCode = gridView.GetDataRow(gridView.FocusedRowHandle)["编号"].ToString();
            string dealerName = gridView.GetDataRow(gridView.FocusedRowHandle)["供应商名称"].ToString();
            decimal fristPrice = Convert.ToDecimal(gridView.GetDataRow(gridView.FocusedRowHandle)["期初"]);
            decimal ablesPrice = Convert.ToDecimal(gridView.GetDataRow(gridView.FocusedRowHandle)["本期应付"]);
            decimal thisPrice = Convert.ToDecimal(gridView.GetDataRow(gridView.FocusedRowHandle)["本期实付"]);
            decimal thisAblesPrice = Convert.ToDecimal(gridView.GetDataRow(gridView.FocusedRowHandle)["余额"]);
            string sql = @"SELECT * FROM 
(
SELECT PaymentCode AS [单据编号],'付款单' AS [类型],DealerCode AS [供应商编号],DealerName AS [供应商名称],CONVERT(NVARCHAR(60),OperateDate,23) AS [日期],0 AS [应付],TotalPrice AS [付款] FROM dbo.FIN_Payment
UNION 
SELECT BusinessBillCode,
CASE SUBSTRING(BusinessBillCode,0,3)
WHEN 'JH' THEN '采购单'
WHEN 'JT' THEN '采退单'
END
,DealerCode,DealerName,CONVERT(NVARCHAR(60),StoreInDate,23) AS [StoreInDate],TotalPrice,0 FROM dbo.FIN_Payables) a
WHERE a.供应商编号 = '" + dealerCode + "' ORDER BY a.日期";
            using (FrmShowSecond fss = new FrmShowSecond())
            {
                fss.sql = sql;
                fss.LastPrice = fristPrice;
                fss.AblesPrice = ablesPrice;
                fss.thisPrice = thisPrice;
                fss.thisAblesPrice = thisAblesPrice;
                fss.lblAbles.Text = "本期应付：";
                fss.lblFact.Text = "本期实付：";
                fss.lblDealerName.Text = dealerName;
                DialogResult dr = fss.ShowDialog();

            }
        }

        private void gridView_CustomDrawRowIndicator(object sender, DevExpress.XtraGrid.Views.Grid.RowIndicatorCustomDrawEventArgs e)
        {
            if (e.Info.IsRowIndicator && e.RowHandle >= 0)
                e.Info.DisplayText = (e.RowHandle + 1).ToString();
        }
    }
}
