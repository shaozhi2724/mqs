using DevExpress.XtraEditors;
using DQS.Common;
using DQS.Controls;
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

namespace DQS.AppViews.Operation.PurchaseAndSaleManager
{
    public partial class FrmOutSale : StandardForm
    {
        public FrmOutSale()
        {
            InitializeComponent();
        }

        private void FrmOutSale_Load(object sender, EventArgs e)
        {
            this.cbxBillStatus.InitSource();
            this.pageNavigator.SortField = "订单日期";
            this.pageNavigator.SortType = "DESC";
            base.InitPage();
        }

        protected override void CustomModify()
        {
            var id = this.gvData.GetFocusedRowCellValue("订单ID");
            if (id != null && id != DBNull.Value)
            {
                base.CustomModify();
                this.pageNavigator.ShowData();
            }
            else
            {
                MessageBox.Show("请选择单据，进行操作。");
                return;
            }
        }
        protected override void CustomChangeStatus()
        {
            var code = this.gvData.GetFocusedRowCellValue("订单号");
            if (code != null && code != DBNull.Value)
            {
                DialogResult result = XtraMessageBox.Show("该单为网页订单，重置将删除订单，返回暂存状态，是否继续？", "系统提示", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
                if (result == DialogResult.Yes)
                {
                    string sql = string.Format("EXEC sp_ModifyAppBill '{0}'", code.ToString());
                    using (SqlConnection conn = new SqlConnection(GlobalItem.g_DbConnectStrings))
                    {
                        conn.Open();//连接数据库
                        try
                        {
                            SqlCommand cmd = new SqlCommand(sql, conn);
                            cmd.ExecuteNonQuery();
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
            this.pageNavigator.ShowData();
        }
    }
}
