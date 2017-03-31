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

namespace DQS.AppViews.StoreAndCuring.StockManager
{
    public partial class FrmStoreDepartmentAdjust : XtraForm
    {
        public FrmStoreDepartmentAdjust()
        {
            InitializeComponent();
        }

        private void FrmStoreDepartmentAdjust_Load(object sender, EventArgs e)
        {
            GridData();
        }

        private void btnNew_Click(object sender, EventArgs e)
        {
            using (FrmSingleStoreDepartmentAdjust frm = new FrmSingleStoreDepartmentAdjust())
            {
                if (frm.ShowDialog() == DialogResult.Yes)
                {
                    GridData();
                }
            }
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            GridData();
        }

        /// <summary>
        /// 加载gCBill、gVBill，单据信息
        /// </summary>
        private void GridData()
        {
            string code = txtCode.Text.Trim();
            string batchNo = txtBatchNo.Text.Trim();
            using (SqlConnection conn = new SqlConnection(GlobalItem.g_DbConnectStrings))
            {
                string sql = @"SELECT ID,ProductID,ProductCode,ProductName,PackageSpec,ProducerName,BatchNo,
OldDepartment,NewDepartment,Amount,Remark,CreateUserName,CreateDate 
FROM BUS_StoreDetailChangeForDepartment 
WHERE (ProductCode LIKE '%{0}%' OR ProductName LIKE '%{0}%' OR dbo.fn_GetPy(ProductName) LIKE '%{0}%') 
AND BatchNo LIKE '%{1}%'";
                sql = string.Format(sql, code,batchNo);
                SqlDataAdapter sda = new SqlDataAdapter(sql, conn);
                DataSet ds = new DataSet();
                try
                {
                    sda.Fill(ds, "Table");

                    gridControl.DataSource = ds.Tables["Table"];
                    gridView.BestFitColumns();
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

        private void gridView_CustomDrawRowIndicator(object sender, DevExpress.XtraGrid.Views.Grid.RowIndicatorCustomDrawEventArgs e)
        {
            if (e.Info.IsRowIndicator && e.RowHandle >= 0)
                e.Info.DisplayText = (e.RowHandle + 1).ToString();
        }
    }
}
