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
    public partial class FrmAdvance : XtraForm
    {
        public FrmAdvance()
        {
            InitializeComponent();
        }

        private void FrmAdvance_Load(object sender, EventArgs e)
        {
            //this.cbxBillStatus.InitSource();
            deStartDate.Text = DateTime.Today.ToString("d");
            deEndDate.Text = DateTime.Today.ToString("d");
            this.btnUpdate.Visible = GlobalItem.g_CurrentUser.UserCode == "admin" || GlobalItem.g_CurrentUser.UserCode == "root" ? true : false;
            this.btnDel.Visible = GlobalItem.g_CurrentUser.UserCode == "admin" || GlobalItem.g_CurrentUser.UserCode == "root" ? true : false;
            gridLoad();
        }

        private void btnNew_Click(object sender, EventArgs e)
        {
            using (FrmSingleAdvance frm = new FrmSingleAdvance())
            {
                DialogResult dr = frm.ShowDialog();
                if (dr == DialogResult.Yes)
                {
                    gridLoad();
                }
            }
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {

        }

        private void btnDel_Click(object sender, EventArgs e)
        {

        }

        private void btnSearch_Click(object sender, EventArgs e)
        {

        }

        private void gridView_CustomDrawRowIndicator(object sender, DevExpress.XtraGrid.Views.Grid.RowIndicatorCustomDrawEventArgs e)
        {
            if (e.Info.IsRowIndicator && e.RowHandle >= 0)
                e.Info.DisplayText = (e.RowHandle + 1).ToString();
        }

        private void gridLoad()
        {
            string billCode = txtBillCode.Text.Trim();
            string dealerCode = txtDealerCode.Text.Trim();
            string sqlSearch = " AND (a.AdvanceDate BETWEEN '" + deStartDate.Text.Trim() + " 00:00:00' AND '" + deEndDate.Text.Trim() + " 23:59:59')";

            using (SqlConnection conn = new SqlConnection(GlobalItem.g_DbConnectStrings))
            {
                string sqlBill = @"SELECT 
	a.DealerCode AS 单位编码,
	a.DealerName AS 单位名称,
	BillCode AS 单据编号,
	TotalPrice AS 金额,
	AdvanceDate AS 付款日期,
	a.CreateDate AS 创建日期,
	CreatePerson AS 创建人 
	FROM FIN_Advance a
INNER JOIN dbo.BFI_Dealer d ON a.DealerCode = d.DealerCode
WHERE (d.DealerCode LIKE '%" + dealerCode + "%' OR d.DealerName LIKE '%" + dealerCode + "%' OR d.DealerSpell LIKE '%" + dealerCode + "%')AND a.BillCode LIKE '%" + billCode + "%'" + sqlSearch;
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

                    gridView.Columns["金额"].SummaryItem.SummaryType = DevExpress.Data.SummaryItemType.Sum;
                    gridView.Columns["金额"].SummaryItem.DisplayFormat = "合计: {0}";

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
    }
}
