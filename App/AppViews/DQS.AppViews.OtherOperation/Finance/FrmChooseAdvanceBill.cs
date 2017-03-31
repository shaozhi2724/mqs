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
    public partial class FrmChooseAdvanceBill : XtraForm
    {
        public DataRow dataRow;

        public FrmChooseAdvanceBill()
        {
            InitializeComponent();
        }

        private void gridView_CustomDrawRowIndicator(object sender, DevExpress.XtraGrid.Views.Grid.RowIndicatorCustomDrawEventArgs e)
        {
            if (e.Info.IsRowIndicator && e.RowHandle >= 0)
                e.Info.DisplayText = (e.RowHandle + 1).ToString();
        }

        private void FrmChooseAdvanceBill_Load(object sender, EventArgs e)
        {
            GainData();
        }

        private void gridView_DoubleClick(object sender, EventArgs e)
        {
            if (gridView.RowCount <= 0)
            {
                return;
            }
            dataRow = gridView.GetDataRow(gridView.FocusedRowHandle);
            this.DialogResult = DialogResult.Yes;
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            GainData();
        }
        private void GainData()
        {
            using (SqlConnection conn = new SqlConnection(GlobalItem.g_DbConnectStrings))
            {
                string sql = @"
SELECT BillCode AS [单据编号],CONVERT(NVARCHAR(60),BillDate,23) AS [单据日期],b.DealerCode AS [单位编码],b.DealerName AS [单位名称],TotalPrice AS [金额] FROM BUS_Bill b 
INNER JOIN dbo.BFI_Dealer d ON b.DealerID = d.DealerID
WHERE IsBillIn = 1 AND b.BillTypeID = 1 AND BillStatus < 3 
AND NOT EXISTS (SELECT * FROM dbo.FIN_Advance a WHERE b.BillCode = a.BillCode)
AND b.BillCode LIKE '%{0}%' AND (d.DealerCode LIKE '%{1}%' OR d.DealerName LIKE '%{1}%' OR d.DealerSpell LIKE '%{1}%')";
                sql = string.Format(sql, txtBillCode.Text.Trim(), txtDealerCode.Text.Trim());
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
