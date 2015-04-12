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
    public partial class FrmShowPaymentBill : XtraForm
    {
        public FrmShowPaymentBill()
        {
            InitializeComponent();
        }

        //查询条件
        string sqlSearch = "";

        private void FrmShowPaymentBill_Load(object sender, EventArgs e)
        {
            gridLoad();
        }

        private void gridLoad()
        {
            using (SqlConnection conn = new SqlConnection(GlobalItem.g_DbConnectStrings))
            {
                string sql = @"SELECT 
	md.PaymentBillID,md.PaymentBillCode AS [自动生成单号],
	DealerName AS [往来单位名称],md.VoucherCode AS [税号],
	BillingCode AS [发票号],
	IncludeTaxPrice AS [含税金额],
	NotIncludeTaxPrice AS [不含税金额],
	Tax AS [税率],
	TaxPrice AS [税额],
	BillingType AS [发票类型],
	BillingDate AS [发票日期],
	DealerCode AS [往来单位编码],
	DealerSpell AS [往来单位简拼] FROM dbo.FIN_PaymentBill md WHERE (md.DealerCode LIKE '%{0}%' OR md.DealerName LIKE '%{0}%' OR md.DealerSpell LIKE '%{0}%') AND (md.BillingCode LIKE '%{1}%') AND (md.VoucherCode LIKE '%{2}%')" + sqlSearch;

                sql = String.Format(sql, txtDealerCode.Text.Trim(), txtBillingCode.Text.Trim(), txtVoucherCode.Text.Trim(), txtBillCode.Text.Trim());
                SqlDataAdapter sda = new SqlDataAdapter(sql, conn);
                DataSet ds = new DataSet();
                try
                {
                    sda.Fill(ds, "Table");
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

        private void txtChanged(object sender, EventArgs e)
        {
            gridLoad();
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            using (FrmPaymentBill pb = new FrmPaymentBill())
            {
                DialogResult dr = pb.ShowDialog();
                if (dr == DialogResult.Yes)
                {
                    gridLoad();
                }
            }
        }

        private void gridView_CustomDrawRowIndicator(object sender, DevExpress.XtraGrid.Views.Grid.RowIndicatorCustomDrawEventArgs e)
        {
            if (e.Info.IsRowIndicator && e.RowHandle >= 0)
                e.Info.DisplayText = (e.RowHandle + 1).ToString();
        }

        private void btnDel_Click(object sender, EventArgs e)
        {
            DialogResult dr = XtraMessageBox.Show("确定要删除该发票信息？", "系统提示", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            if (dr == DialogResult.No) return;

            using (SqlConnection conn = new SqlConnection(GlobalItem.g_DbConnectStrings))
            {
                string Delsql = @"DELETE dbo.FIN_PaymentBill WHERE {0}
DELETE dbo.FIN_PaymentBillDetail WHERE {0}";
                if (dr == DialogResult.Yes)
                {
                    string code = gridView.GetDataRow(gridView.FocusedRowHandle)["自动生成单号"].ToString();
                    Delsql = String.Format(Delsql, "PaymentBillCode = '" + code + "'");
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

        private void btnSearch_Click(object sender, EventArgs e)
        {
            sqlSearch = " AND (md.BusinessBillDate BETWEEN '" + deStartDate.Text.Trim() + " 00:00:00' AND '" + deEndDate.Text.Trim() + " 23:59:59')";
            gridLoad();
        }

        private void btnReSet_Click(object sender, EventArgs e)
        {
            sqlSearch = "";
            txtBillCode.Text = "";
            txtDealerCode.Text = "";
            txtBillingCode.Text = "";
            txtVoucherCode.Text = "";
            gridLoad();
        }
    }
}
