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

namespace DQS.AppViews.OtherOperation.OtherManager
{
    public partial class FrmSearchEmployee : XtraForm
    {

        public int _EID;
        public FrmSearchEmployee()
        {
            InitializeComponent();
        }

        private void FrmSearchEmployee_Load(object sender, EventArgs e)
        {
            BandGird();
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            BandGird();
        }

        private void BandGird()
        {
            using (SqlConnection conn = new SqlConnection(GlobalItem.g_DbConnectStrings))
            {
                string sql = @"SELECT EmployeeID 员工ID,EmployeeName 员工姓名 FROM dbo.BFI_Employee WHERE EmployeeName LIKE '%{0}%'";
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
                _EID = int.Parse(gridView.GetFocusedRowCellValue("员工ID").ToString());
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
