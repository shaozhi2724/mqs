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

namespace DQS.AppViews.QualityControl.AuthorityManager
{
    public partial class FrmFunctionAuthorityChange : StandardForm
    {
        public FrmFunctionAuthorityChange()
        {
            InitializeComponent();
        }

        private void FrmFunctionAuthorityChange_Load(object sender, EventArgs e)
        {
            LoadType("ATC_FunctionAuthorityChange", "AppStatus", cbxBillStatus);
            this.pageNavigator.SortField = "申请日期";
            this.pageNavigator.SortType = "DESC";
            base.InitPage();
        }

        private void LoadType(string tableName, string tableColumn, ComboBoxEdit cbo)
        {
            using (SqlConnection conn = new SqlConnection(GlobalItem.g_DbConnectStrings))
            {
                string sql = "SELECT " + tableColumn + " FROM " + tableName + " GROUP BY " + tableColumn;
                SqlDataAdapter sda = new SqlDataAdapter(sql, conn);
                DataSet ds = new DataSet();
                try
                {
                    sda.Fill(ds, "Table");
                    for (int i = 0; i < ds.Tables["Table"].Rows.Count; i++)
                    {
                        cbo.Properties.Items.Add(ds.Tables["Table"].Rows[i][tableColumn].ToString());
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
        protected override void CustomApprove()
        {
            object id = this.gvData.GetFocusedRowCellValue("变更ID");
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
                        string sql = @"EXEC sp_EInsertFunctionAuthorityChange {0}";
                        sql = string.Format(sql, id);
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
