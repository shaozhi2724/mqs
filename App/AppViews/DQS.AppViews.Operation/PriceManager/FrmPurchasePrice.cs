using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Runtime.Remoting.Messaging;
using System.Text;
using System.Windows.Forms;
using DevExpress.XtraEditors;
using DQS.Common;
using DQS.Controls;
using DQS.Module.Entities;
using ORMSCore;

namespace DQS.AppViews.Operation.PriceManager
{
    public partial class FrmPurchasePrice : StandardForm
    {
        public FrmPurchasePrice()
        {
            InitializeComponent();
        }

        private void FrmPurchasePrice_Load(object sender, EventArgs e)
        {
            this.pageNavigator.SortField = "创建时间";
            this.pageNavigator.SortType = "DESC";
            base.InitPage();
        }

        protected override void CustomDelete()
        {
            this.SaveDataLog("删除");
            object id = this.gvData.GetFocusedRowCellValue("价格表ID");
            if(Convert.ToInt32(id) < 3)
            {
                XtraMessageBox.Show("系统内置价格表不允许删除！", "系统提示", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            base.CustomDelete();
            if (id != null && id != DBNull.Value)
            {
                string sql = string.Format(@"DELETE dbo.BFI_PriceListItem WHERE PriceVersionID IN(SELECT PriceListVersionID FROM dbo.BFI_PriceListVersion WHERE PriceListID={0})
DELETE dbo.BFI_PriceListVersion WHERE PriceListID={0}
DELETE dbo.BFI_PriceList WHERE PriceListID={0}", Convert.ToInt32(id));

                using(SqlConnection conn = new SqlConnection(GlobalItem.g_DbConnectStrings))
                {
                    conn.Open();
                    SqlCommand com = new SqlCommand(sql, conn);
                    com.ExecuteNonQuery();
                    conn.Close();
                }
            }
        }
    }
}