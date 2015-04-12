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
    public partial class FrmShowSecond : XtraForm
    {
        public FrmShowSecond()
        {
            InitializeComponent();
        }
        //记录传进来的查询sql
        public string sql = "";
        //记录上期余额
        public decimal LastPrice = 0;
        //记录应收、应付
        public decimal AblesPrice = 0;
        //记录实收、实付
        public decimal thisPrice = 0;
        //记录本期余额
        public decimal thisAblesPrice = 0;

        private void FrmShowSecond_Load(object sender, EventArgs e)
        {
            txtLastInventory.Text = LastPrice.ToString();
            txtThisAbles.Text = AblesPrice.ToString();
            txtThisPrice.Text = thisPrice.ToString();
            txtThisInventoryAbles.Text = thisAblesPrice.ToString();
            gridLoad();
        }

        private void gridLoad()
        {
            using (SqlConnection conn = new SqlConnection(GlobalItem.g_DbConnectStrings))
            {
                SqlDataAdapter sda = new SqlDataAdapter(sql, conn);
                DataSet ds = new DataSet();
                try
                {
                    sda.Fill(ds, "Table");
                    //decimal ThisReceivables = 0;
                    //decimal ThisMakeCollections = 0;
                    //for (int i = 0; i < ds.Tables["Table"].Rows.Count; i++)
                    //{
                    //    ThisReceivables += Convert.ToDecimal(ds.Tables["Table"].Rows[i]["应收"]);
                    //    ThisMakeCollections += Convert.ToDecimal(ds.Tables["Table"].Rows[i]["收款"]);
                    //}
                    //txtThisReceivables.Text = ThisReceivables.ToString();
                    //txtThisMakeCollections.Text = ThisMakeCollections.ToString();
                    //txtThisInventoryReceivables.Text = (LastPrice + ThisReceivables - ThisMakeCollections).ToString();
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
    }
}
