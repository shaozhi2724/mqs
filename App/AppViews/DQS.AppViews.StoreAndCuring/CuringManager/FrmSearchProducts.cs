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

namespace DQS.AppViews.StoreAndCuring.CuringManager
{
    public partial class FrmSearchProducts : Form
    {
        public int _PID;
        public FrmSearchProducts()
        {
            InitializeComponent();
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            BandGird();
        }

        private void FrmSearchProducts_Load(object sender, EventArgs e)
        {
            BandGird();
        }

        private void BandGird()
        {
            using (SqlConnection conn = new SqlConnection(GlobalItem.g_DbConnectStrings))
            {
                string sql = @"SELECT ProductID 产品ID,ProductCode 产品编号,ProductName 产品名称,ProductSpec 规格,PackageSpec 包装规格,ProducerName 生产厂商,AuthorizedNo 批准文号 FROM dbo.BFI_Product WHERE (ProductStatus IS NULL OR ProductStatus = '正常') AND CuringCode IS NULL AND BusinessStatus = 1 AND (ProductName LIKE '%{0}%' OR ProductSpell LIKE '%{0}%' OR ProductCode LIKE '%{0}%')";
                sql = string.Format(sql, txtCode.Text.Trim());
                SqlDataAdapter sda = new SqlDataAdapter(sql, conn);
                DataSet ds = new DataSet();
                try
                {
                    sda.Fill(ds, "Table");
                    gridControl.DataSource = ds.Tables["Table"];
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

        private void gridView_RowClick(object sender, DevExpress.XtraGrid.Views.Grid.RowClickEventArgs e)
        {
            if (e.Clicks == 2)
            {
                _PID = int.Parse(gridView.GetFocusedRowCellValue("产品ID").ToString());
                this.DialogResult = DialogResult.Yes;
            }
        }

        private void gridView_CustomDrawRowIndicator(object sender, DevExpress.XtraGrid.Views.Grid.RowIndicatorCustomDrawEventArgs e)
        {
            if (e.Info.IsRowIndicator && e.RowHandle >= 0)
                e.Info.DisplayText = (e.RowHandle + 1).ToString();
        }
    }
}
