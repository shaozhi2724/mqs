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
            //sqlSearch = " AND (sb.StoreDate BETWEEN '" + deStartDate.Text.Trim() + " 00:00:00' AND '" + deEndDate.Text.Trim() + " 23:59:59')";
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
            //sqlSearch = " AND (sb.StoreDate BETWEEN '" + deStartDate.Text.Trim() + " 00:00:00' AND '" + deEndDate.Text.Trim() + " 23:59:59')";
            gridLoad();
        }

        private void btnReSet_Click(object sender, EventArgs e)
        {
            //sqlSearch = "";
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
                string sqlBill = @"EXEC fn_ShowMakeCollectionsSearch '{0}','{1}','{2}','{3}'";

                sqlBill = String.Format(sqlBill, txtDealerCode.Text.Trim(), txtBillCode.Text.Trim(),deStartDate.Text.Trim(),deEndDate.Text.Trim());
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
