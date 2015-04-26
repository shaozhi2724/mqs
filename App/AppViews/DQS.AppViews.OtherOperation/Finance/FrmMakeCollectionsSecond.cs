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
    public partial class FrmMakeCollectionsSecond : XtraForm
    {
        public FrmMakeCollectionsSecond()
        {
            InitializeComponent();
        }
        //传参查询条件
        public string sqlConditions;

        private void FrmMakeCollectionsSecond_Load(object sender, EventArgs e)
        {
            gridLoad();
        }

        private void gridLoad()
        {
            using (SqlConnection conn = new SqlConnection(GlobalItem.g_DbConnectStrings))
            {
                string sql = sqlConditions;
                sql = String.Format(sql, txtBusinessPerson.Text.Trim(), txtDealerCode.Text.Trim(), txtProductStyle.Text.Trim());
                SqlDataAdapter sda = new SqlDataAdapter(sql, conn);
                DataSet ds = new DataSet();
                try
                {
                    sda.Fill(ds, "Table");
                    decimal Price = 0;
                    for (int i = 0; i < ds.Tables["Table"].Rows.Count; i++)
                    {
                        Price += Convert.ToDecimal(ds.Tables["Table"].Rows[i]["金额"]);
                    }
                    lblTotalPrice.Text = Price.ToString();
                    gridControl.DataSource = ds.Tables["Table"];
                    gridView.OptionsView.ColumnAutoWidth = false;
                    gridView.OptionsView.ColumnAutoWidth = false;
                    gridView.BestFitColumns();
                    gridView.OptionsView.ShowGroupPanel = false;

                    for (int i = 0; i < gridView.Columns.Count; i++)
                    {
                        string ColumnName = gridView.Columns[i].ToString();
                        if (ColumnName.Contains("ID") || ColumnName.Contains("简拼"))
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

        private void txtChanged(object sender, EventArgs e)
        {
            gridLoad();
        }
    }
}
