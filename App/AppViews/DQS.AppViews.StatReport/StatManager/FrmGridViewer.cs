using DevExpress.XtraEditors;
using DevExpress.XtraGrid;
using DQS.Common;
using DQS.Module.Entities;
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
    public partial class FrmGridViewer : XtraForm
    {
        private SYSPageEntity sysPage;
        public FrmGridViewer()
        {
            InitializeComponent();
        }

        private void FrmGridViewer_Load(object sender, EventArgs e)
        {
            deStartDate.Text = DateTime.Today.ToString("d");
            deEndDate.Text = DateTime.Today.ToString("d");
            gridLoad();
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            gridLoad();
        }

        private void btnReSet_Click(object sender, EventArgs e)
        {
            deStartDate.Text = DateTime.Today.ToString("d");
            deEndDate.Text = DateTime.Today.ToString("d");
            gridLoad();
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

        private void gridLoad()
        {
            string pageName = this.Tag.ToString();
            //设置数据
            sysPage = GlobalMethod.GetFormPage(pageName);
            if (sysPage != null)
            {
                using (SqlConnection conn = new SqlConnection(GlobalItem.g_DbConnectStrings))
                {
                    string sql = "";
                    if (sysPage.Reservation1 == "1")
                    {
                        lblStartDate.Visible = true;
                        lblEndDate.Visible = true;
                        deStartDate.Visible = true;
                        deEndDate.Visible = true;
                        sql = "exec " + sysPage.DbViewName + " '" + deStartDate.DateTime.ToString("d") + "','" + deEndDate.DateTime.ToString("d") + "'";
                    }
                    else
                    {
                        lblStartDate.Visible = false;
                        lblEndDate.Visible = false;
                        deStartDate.Visible = false;
                        deEndDate.Visible = false;
                        sql = "exec " + sysPage.DbViewName;
                    }

                    SqlDataAdapter sdad = new SqlDataAdapter(sql, conn);
                    DataSet ds = new DataSet();
                    try
                    {
                        sdad.Fill(ds, "Table");
                        gridControl.DataSource = ds.Tables["Table"];
                        gridView.OptionsView.ColumnAutoWidth = false;
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
            if (sysPage.Reservation2 != "")
            {
                //DevExpress.XtraGrid.Columns.GridColumn col_Profit = gridView.Columns["总数"];
                //gridView.Columns["数量"].SummaryItem.SummaryType = DevExpress.Data.SummaryItemType.Sum;
                //gridView.Columns["数量"].SummaryItem.DisplayFormat = "数量合计: {0}";
                //GridGroupSummaryItem item1 = new GridGroupSummaryItem();
                //item1.FieldName = "参考利润";
                //item1.SummaryType = DevExpress.Data.SummaryItemType.Sum;
                //item1.DisplayFormat = "利润小计:  {0:c2}";//格式
                //item1.ShowInGroupColumnFooter = col_Profit;
                if (sysPage.Reservation2.Contains(","))
                {
                    string s = sysPage.Reservation2;
                    string[] sArray = s.Split(',');
                    foreach (string i in sArray)
                    {
                        gridView.Columns[i.ToString()].SummaryItem.SummaryType = DevExpress.Data.SummaryItemType.Sum;
                        gridView.Columns[i.ToString()].SummaryItem.DisplayFormat = i.ToString() + "合计: {0}";
                    }
                }
                else
                {
                    gridView.Columns[sysPage.Reservation2].SummaryItem.SummaryType = DevExpress.Data.SummaryItemType.Sum;
                    gridView.Columns[sysPage.Reservation2].SummaryItem.DisplayFormat = sysPage.Reservation2 + "合计: {0}";
                }
            }
        }

        private void gridView_CustomDrawRowIndicator(object sender, DevExpress.XtraGrid.Views.Grid.RowIndicatorCustomDrawEventArgs e)
        {
            if (e.Info.IsRowIndicator && e.RowHandle >= 0)
                e.Info.DisplayText = (e.RowHandle + 1).ToString();
        }
    }
}
