using DevExpress.XtraEditors;
using DQS.Common;
using DQS.Controls;
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
    public partial class FrmFacilitiesCuring : StandardForm
    {
        public FrmFacilitiesCuring()
        {
            InitializeComponent();
        }

        private void FrmFacilitiesCuring_Load(object sender, EventArgs e)
        {
            this.pageNavigator.SortField = "创建日期";
            this.pageNavigator.SortType = "DESC";
            base.InitPage();
        }

        protected override void CustomDelete()
        {
            this.SaveDataLog("删除");
            object CuringResultID = this.gvData.GetFocusedRowCellValue("运行ID");
            if (CuringResultID != null && CuringResultID != DBNull.Value)
            {
                DialogResult dr = XtraMessageBox.Show("确定删除该记录？", "提示", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (dr == DialogResult.Yes)
                {
                    using (SqlConnection conn = new SqlConnection(GlobalItem.g_DbConnectStrings))
                    {
                        string sql = @"DELETE BUS_FacilitiesCuring WHERE ID = " + int.Parse(CuringResultID.ToString());
                        try
                        {
                            conn.Open();
                            SqlCommand comm = new SqlCommand(sql, conn);
                            comm.ExecuteNonQuery();
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
                this.pageNavigator.ShowData();
            }
        }
    }
}
