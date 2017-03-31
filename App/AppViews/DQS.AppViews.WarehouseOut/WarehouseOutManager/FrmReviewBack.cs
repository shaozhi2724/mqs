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

namespace DQS.AppViews.WarehouseOut.WarehouseOutManager
{
    public partial class FrmReviewBack : StandardForm
    {
        public FrmReviewBack()
        {
            InitializeComponent();
        }

        private void FrmReviewBack_Load(object sender, EventArgs e)
        {
            this.cbxBillStatus.InitSource();
            this.pageNavigator.SortField = "申请日期";
            this.pageNavigator.SortType = "DESC";
            base.InitPage();
        }

        protected override void CustomModify()
        {
            object id = this.gvData.GetFocusedRowCellValue("返单ID");
            string statusName = gvData.GetFocusedRowCellValue("状态").ToString();
            if (statusName == "已通过" || statusName == "已处理")
            {
                if (id != null && id != DBNull.Value)
                {
                    using (FrmSingleReviewBack rb = new FrmSingleReviewBack(Convert.ToInt32(id), statusName == "已通过" ? true : false))
                    {
                        if (rb.ShowDialog(this) == DialogResult.OK)
                        {
                            base.CustomRefresh();
                        }
                    }
                }
                else
                {
                    XtraMessageBox.Show("请选择返单单据。", "提示", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            }
        }
        protected override void CustomApprove()
        {
            object id = this.gvData.GetFocusedRowCellValue("返单ID");
            object bid = this.gvData.GetFocusedRowCellValue("单据ID");
            if (id != null && id != DBNull.Value)
            {
                string statusName = gvData.GetFocusedRowCellValue("状态").ToString();
                if (statusName == "未批准")
                {
                    XtraMessageBox.Show("该单据已作废，不允许再次审批", "系统提示", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    return;
                }
                DialogResult dr = base.BaseApprove();
                if (dr == DialogResult.Yes)
                {

                    using (SqlConnection conn = new SqlConnection(GlobalItem.g_DbConnectStrings))
                    {
                        string sql= @"
INSERT dbo.BUS_ReviewBackDetail(BackID,BillID,ProductID,BatchNo,ProduceDate,ValidateDate,Amount,DownStructureID)
SELECT {0},{1},ProductID,BatchNo,ProduceDate,ValidateDate,Amount,StructureID FROM dbo.WMS_StoreBillDetail WHERE StoreID = {1}

UPDATE dbo.BUS_ReviewBack SET AppStatus = '已通过' WHERE BackID = {0}
";
                        sql = string.Format(sql, id, bid);
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
                    this.pageNavigator.ShowData();
                }
            }
        }
    }
}
