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

namespace DQS.App
{
    public partial class FrmUpdateViewPrice : XtraForm
    {

        public int inStoreID = 0;

        public double price = 0.0;

        public FrmUpdateViewPrice()
        {
            InitializeComponent();
        }

        private void FrmUpdateViewPrice_Load(object sender, EventArgs e)
        {
            txtPrice.Text = price.ToString();
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            using (SqlConnection conn = new SqlConnection(GlobalItem.g_DbConnectStrings))
            {
                string sql = @"UPDATE dbo.BUS_InStoreDetail SET ViewPrice = '" + txtViewPrice.Text.Trim() + "' WHERE InStoreID = " + inStoreID;

                try
                {
                    conn.Open();
                    SqlCommand com = new SqlCommand(sql, conn);
                    int result = com.ExecuteNonQuery();
                    if (result == 1)
                    {
                        this.DialogResult = DialogResult.Yes;
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
    }
}
