using DQS.Common;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Windows.Forms;

namespace DQS.AppViews.StoreAndCuring.StockManager
{
    public partial class FrmChooseStoreDetails : Form
    {
        public int productID = 0;
        //public 
        public StoreDetail _stroe;

        public FrmChooseStoreDetails()
        {
            InitializeComponent();
        }

        private void FrmChooseStoreDetails_Load(object sender, EventArgs e)
        {
            GridData();
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            GridData();
        }

        private void gridView_DoubleClick(object sender, EventArgs e)
        {
        }

        private void gridView_CustomDrawRowIndicator(object sender, DevExpress.XtraGrid.Views.Grid.RowIndicatorCustomDrawEventArgs e)
        {
            if (e.Info.IsRowIndicator && e.RowHandle >= 0)
                e.Info.DisplayText = (e.RowHandle + 1).ToString();
        }

        /// <summary>
        /// 加载gCBill、gVBill，单据信息
        /// </summary>
        private void GridData()
        {
            List<StoreDetail> stores = new List<StoreDetail>();
            string code = txtProductCode.Text.Trim();
            using (SqlConnection conn = new SqlConnection(GlobalItem.g_DbConnectStrings))
            {
                string sql = @"SELECT sd.InStoreID StoreDetailID,sd.产品编号 ProductCode,sd.产品名称 ProductName,sd.规格型号 PackageSpec,sd.生产厂商 ProducerName,sd.批号 BatchNo,sd.库存数量 Amount,sd.部门 DepartmentName FROM dbo.vw_NewProductStoreDetail sd
WHERE sd.库存数量 > 0 AND (sd.产品编号 LIKE '%{0}%' OR sd.产品名称 LIKE '%{0}%' OR sd.产品名称Spell LIKE '%{0}%')";
                sql = string.Format(sql, code);
                SqlDataAdapter sda = new SqlDataAdapter(sql, conn);
                DataSet ds = new DataSet();
                try
                {
                    sda.Fill(ds, "Table");

                    gridControl.DataSource = ConvertToModel(ds.Tables["Table"]);
                    gridView.BestFitColumns();
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

        public static List<StoreDetail> ConvertToModel(DataTable dt)
        {

            List<StoreDetail> ts = new List<StoreDetail>();// 定义集合
            Type type = typeof(StoreDetail); // 获得此模型的类型
            string tempName = "";
            foreach (DataRow dr in dt.Rows)
            {
                StoreDetail t = new StoreDetail();
                PropertyInfo[] propertys = t.GetType().GetProperties();// 获得此模型的公共属性
                foreach (PropertyInfo pi in propertys)
                {
                    tempName = pi.Name;
                    if (dt.Columns.Contains(tempName))
                    {
                        if (!pi.CanWrite) continue;
                        object value = dr[tempName];
                        if (value != DBNull.Value)
                            pi.SetValue(t, value, null);
                    }
                }
                ts.Add(t);
            }
            return ts;
        }


        private void gridControl_DoubleClick(object sender, EventArgs e)
        {
            DevExpress.XtraGrid.Views.Grid.ViewInfo.GridHitInfo hi = gridView.CalcHitInfo((sender as Control).PointToClient(Control.MousePosition));

            if (hi.InRow || hi.InRowCell)
            {
                if (hi != null && hi.RowHandle >= 0)
                {
                    gridView.SelectRow(hi.RowHandle);
                    _stroe = this.gridView.GetRow(this.gridView.FocusedRowHandle) as StoreDetail;
                }
            }
            //_stroe = gridView.GetFocusedRow() as StoreDetail;
            this.DialogResult = DialogResult.Yes;
        }
    }
}
