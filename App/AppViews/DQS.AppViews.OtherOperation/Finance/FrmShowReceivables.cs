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
    public partial class FrmShowReceivables : XtraForm
    {
        public FrmShowReceivables()
        {
            InitializeComponent();
        }
        //查询条件
        string sqlSearch = "";

        private void btnAdd_Click(object sender, EventArgs e)
        {
            using (FrmReceivables fr = new FrmReceivables())
            {
                DialogResult dr = fr.ShowDialog();
                if (dr == DialogResult.Yes)
                {
                    gridLoad();
                }
            }
        }

        private void gridLoad()
        {
            using (SqlConnection conn = new SqlConnection(GlobalItem.g_DbConnectStrings))
            {
                string sql = @"SELECT ReceivablesID,ReceivablesCode AS [应收编号],VoucherCode AS [凭证号],BusinessBillID AS [StoreID],BusinessBillCode AS [单据编号],DealerName AS [往来单位名称],TotalPrice AS [总金额],(SELECT SUM((UnitPrice-PurchaasePrice)*Amount) FROM dbo.FIN_ReceivablesDetail rd WHERE rd.BusinessBillID = r.BusinessBillID) AS [利润],OperatePerson AS [开票员],BusinessPerson AS [业务员],BusinessBillDate AS [下单日期],StoreOutPerson AS [出库员],StoreOutDate AS [出库日期],DealerCode AS [往来单位编码],DealerSpell AS [往来单位简拼],DealerType AS [往来单位类型],OperateDate AS [应收日期]
FROM dbo.FIN_Receivables r WHERE (DealerCode LIKE '%{0}%' OR DealerName LIKE '%{0}%' OR DealerSpell LIKE '%{0}%') AND (ReceivablesCode LIKE '%{1}%') AND (VoucherCode LIKE '%{2}%') AND (BusinessBillCode LIKE '%{3}%')" + sqlSearch;
                sql = String.Format(sql, txtDealerCode.Text.Trim(), txtReceivablesCode.Text.Trim(), txtVoucherCode.Text.Trim(), txtBillCode.Text.Trim());
                SqlDataAdapter sda = new SqlDataAdapter(sql, conn);
                DataSet ds = new DataSet();
                try
                {
                    sda.Fill(ds, "Table");
                    decimal Price = 0;
                    for (int i = 0; i < ds.Tables["Table"].Rows.Count; i++)
                    {
                        Price += Convert.ToDecimal(ds.Tables["Table"].Rows[i]["总金额"]);
                    }
                    lblTotalPrice.Text = Price.ToString();
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

        private void btnDel_Click(object sender, EventArgs e)
        {
            DialogResult dr = XtraMessageBox.Show("1.删除该组数据，点击“是(Yes)”按钮（同一个应收编号或凭证号中的数据）\n2.删除该条信息，点击“否(No)”按钮\n3.取消请点击“取消(Cancel)”按钮", "系统提示", MessageBoxButtons.YesNoCancel, MessageBoxIcon.Question);

            if (dr == DialogResult.Cancel) return;

            using (SqlConnection conn = new SqlConnection(GlobalItem.g_DbConnectStrings))
            {
                string Delsql = @"DELETE dbo.FIN_Receivables WHERE {0}
DELETE dbo.FIN_ReceivablesDetail WHERE {0}";
                if (dr == DialogResult.Yes)
                {
                    string code = gridView.GetDataRow(gridView.FocusedRowHandle)["应收编号"].ToString();
                    Delsql = String.Format(Delsql, "ReceivablesCode = '" + code + "'");
                }
                else if (dr == DialogResult.No)
                {
                    int storeID = Convert.ToInt32(gridView.GetDataRow(gridView.FocusedRowHandle)["StoreID"]);
                    Delsql = String.Format(Delsql, "BusinessBillID = " + storeID);
                }

                try
                {
                    conn.Open();
                    SqlCommand Bcommand = new SqlCommand(Delsql, conn);
                    Bcommand.ExecuteNonQuery();
                }
                catch (Exception ex)
                {
                    XtraMessageBox.Show(ex.ToString(), "系统", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                finally
                {
                    conn.Close();
                }
            }
            gridLoad();
        }

        private void FrmShowReceivables_Load(object sender, EventArgs e)
        {
            gridLoad();
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            sqlSearch = " AND (BusinessBillDate BETWEEN '" + deStartDate.Text.Trim() + " 00:00:00' AND '" + deEndDate.Text.Trim() + " 23:59:59')";
            gridLoad();
        }

        private void btnReSet_Click(object sender, EventArgs e)
        {
            sqlSearch = "";
            txtBillCode.Text = "";
            txtDealerCode.Text = "";
            txtReceivablesCode.Text = "";
            txtVoucherCode.Text = "";
            gridLoad();
        }

        private void txtChanged(object sender, EventArgs e)
        {
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
    }
}
