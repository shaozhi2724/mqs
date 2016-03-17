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
    public partial class FrmDealer : XtraForm
    {
        public FrmDealer()
        {
            InitializeComponent();
        }
        //记录从那张表中读取往来单位
        public string table = "";
        //编号
        public string code = "";
        //名称
        public string name = "";
        //简拼
        public string spell = "";

        private void FrmDealer_Load(object sender, EventArgs e)
        {
            GainData();
        }

        /// <summary>
        /// 加载gCBill、gVBill，单据信息
        /// </summary>
        private void GainData()
        {
            string type = "";
            if (table == "FIN_MakeCollectionsOnPassage") { type = "客户"; }
            if (table == "FIN_PaymentOnPassage") { type = "供应商"; }
            using (SqlConnection conn = new SqlConnection(GlobalItem.g_DbConnectStrings))
            {
                string sql = @"SELECT DealerCode AS [编号],DealerName AS [名称],DealerSpell AS [简拼] FROM BFI_Dealer WHERE DealerType = '" + type + "' AND (DealerCode LIKE '%" + txtDealerName.Text.Trim() + "%' OR DealerName LIKE '%" + txtDealerName.Text.Trim() + "%' OR DealerSpell LIKE '%" + txtDealerName.Text.Trim() + "%')";
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

        private void txtChange(object sender, EventArgs e)
        {
            GainData();
        }

        private void gridView_DoubleClick(object sender, EventArgs e)
        {
            code = gridView.GetDataRow(gridView.FocusedRowHandle)["编号"].ToString();
            name = gridView.GetDataRow(gridView.FocusedRowHandle)["名称"].ToString();
            spell = gridView.GetDataRow(gridView.FocusedRowHandle)["简拼"].ToString();
            this.DialogResult = DialogResult.Yes;
        }
    }
}
