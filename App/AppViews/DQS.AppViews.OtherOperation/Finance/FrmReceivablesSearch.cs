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
    public partial class FrmReceivablesSearch : XtraForm
    {
        public FrmReceivablesSearch()
        {
            InitializeComponent();
        }

        private void FrmReceivablesSearch_Load(object sender, EventArgs e)
        {
            gridLoad();
        }

        private void gridLoad()
        {
            using (SqlConnection conn = new SqlConnection(GlobalItem.g_DbConnectStrings))
            {
                string sqlBill = @"EXEC sp_InventoryReceivablesMakeCollections '" + txtDealerCode.Text.Trim() + "'";

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
            string dealerName = gridView.GetDataRow(gridView.FocusedRowHandle)["客户名称"].ToString();
            decimal fristPrice = Convert.ToDecimal(gridView.GetDataRow(gridView.FocusedRowHandle)["期初"]);
            decimal ablesPrice = Convert.ToDecimal(gridView.GetDataRow(gridView.FocusedRowHandle)["本期应收"]);
            decimal thisPrice = Convert.ToDecimal(gridView.GetDataRow(gridView.FocusedRowHandle)["本期实收"]);
            decimal thisAblesPrice = Convert.ToDecimal(gridView.GetDataRow(gridView.FocusedRowHandle)["余额"]);
            string sql = @" EXEC sp_InventoryReceivablesMakeCollectionsDetail '" + dealerCode + "'";
            using (FrmShowSecond fss = new FrmShowSecond())
            {
                fss.sql = sql;
                fss.LastPrice = fristPrice;
                fss.AblesPrice = ablesPrice;
                fss.thisPrice = thisPrice;
                fss.thisAblesPrice = thisAblesPrice;
                fss.lblAbles.Text = "本期应收：";
                fss.lblFact.Text = "本期实收：";
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
