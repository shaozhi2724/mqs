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

namespace DQS.AppViews.StatReport.StatManager
{
    public partial class FrmNewGridViewerDetail : XtraForm
    {
        public FrmNewGridViewerDetail()
        {
            InitializeComponent();
        }
        //传参查询条件
        public string sqlConditions;

        private void gridLoad()
        {
            using (SqlConnection conn = new SqlConnection(GlobalItem.g_DbConnectStrings))
            {
                string sqlBill = sqlConditions;
                SqlDataAdapter sdad = new SqlDataAdapter(sqlBill, conn);
                DataSet ds = new DataSet();
                try
                {
                    sdad.Fill(ds, "TableBill");
                    //decimal Price = 0;
                    //for (int i = 0; i < ds.Tables["TableBill"].Rows.Count; i++)
                    //{
                    //    Price += Convert.ToDecimal(ds.Tables["TableBill"].Rows[i]["总金额"]);
                    //}
                    //lblTotalPrice.Text = Price.ToString();
                    gridControl.DataSource = ds.Tables["TableBill"];
                    gridView.OptionsView.ColumnAutoWidth = false;
                    gridView.OptionsView.ColumnAutoWidth = false;
                    gridView.BestFitColumns();
                    gridView.OptionsView.ShowGroupPanel = false;

                    string summarynames = "";

                    for (int i = 0; i < gridView.Columns.Count; i++)
                    {
                        string ColumnName = gridView.Columns[i].ToString();
                        if (ColumnName.Contains("ID"))
                        {
                            gridView.Columns[i].Visible = false;
                        }
                        if (ColumnName.Contains("金额") || ColumnName.Contains("数量"))
                        {
                            summarynames += ColumnName + ",";
                        }
                        gridView.Columns[i].OptionsColumn.AllowEdit = false;
                    }


                    if (summarynames != "")
                    {
                        summarynames = summarynames.Substring(0, summarynames.Length - 1);
                        if (summarynames.Contains(","))
                        {
                            string s = summarynames;
                            string[] sArray = s.Split(',');
                            foreach (string i in sArray)
                            {
                                gridView.Columns[i.ToString()].SummaryItem.SummaryType = DevExpress.Data.SummaryItemType.Sum;
                                gridView.Columns[i.ToString()].SummaryItem.DisplayFormat = i.ToString() + "合计: {0}";
                            }
                        }
                        else
                        {
                            gridView.Columns[summarynames].SummaryItem.SummaryType = DevExpress.Data.SummaryItemType.Sum;
                            gridView.Columns[summarynames].SummaryItem.DisplayFormat = summarynames + "合计: {0}";
                        }
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

        private void FrmNewGridViewerDetail_Load(object sender, EventArgs e)
        {
            gridLoad();
        }
    }
}
