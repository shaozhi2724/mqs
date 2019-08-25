using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using DevExpress.XtraEditors;
using DQS.Controls;
using DQS.Module.Entities;
using System.Data.SqlClient;
using DQS.Common;
using ORMSCore;

namespace DQS.AppViews.StoreAndCuring.StockManager
{
    public partial class FrmInventory : StandardForm
    {
        public FrmInventory()
        {
            InitializeComponent();
        }

        private void FrmInventory_Load(object sender, EventArgs e)
        {
            base.InitPage();
        }

        protected override void CustomApprove()
        {
            this.SaveDataLog("审批");
            object id = this.gvData.GetFocusedRowCellValue("盘点ID");
            if (id != null && id != DBNull.Value)
            {
                string statusName = gvData.GetFocusedRowCellValue("状态").ToString();
                if (statusName == "未批准" || statusName == "已删除")
                {
                    XtraMessageBox.Show("该单据已作废，不允许再次审批", "系统提示", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    return;
                }
                DialogResult dr = base.BaseApprove();
                if (dr == DialogResult.Yes)
                {
                    //更新销售单状态
                    BUSInventoryEntity entity = new BUSInventoryEntity { InventoryID = (int)id };
                    entity.Fetch();
                    if (entity.StatusID == 1)
                    {
                        entity.StatusID = 2;
                        entity.StatusName = "已处理";
                        entity.Update();
                        UpdateStoreAmount(entity.InventoryID);
                    }
                    this.pageNavigator.ShowData();
                }
            }
        }

        public void UpdateStoreAmount(int InventoryID)
        {
            using (SqlConnection conn = new SqlConnection(GlobalItem.g_DbConnectStrings))
            {
                conn.Open(); //连接数据库
                //必须为SqlCommand指定数据库连接和登记的事务
                try
                {
                    string sql = "EXEC sp_InsertNewStoreDetailForInventoryDetail " + InventoryID;
                    SqlCommand cmd = new SqlCommand(sql, conn);
                    cmd.ExecuteNonQuery();
                }
                catch (Exception ex)
                {
                    XtraMessageBox.Show(ex.Message, "系统提示", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                finally
                {
                    conn.Close();
                }
            }
        }
    }
}