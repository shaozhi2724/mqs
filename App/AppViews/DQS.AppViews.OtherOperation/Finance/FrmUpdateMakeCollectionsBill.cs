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
    public partial class FrmUpdateMakeCollectionsBill : XtraForm
    {
        int _id;
        string _code;
        public FrmUpdateMakeCollectionsBill()
        {
            InitializeComponent();
        }
        public FrmUpdateMakeCollectionsBill(int id,string code)
        {
            InitializeComponent();
            _id = id;
            _code = code;
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            if (txtVoucherCode.Text.Trim() == "")
            {
                MessageBox.Show("发票号不允许为空，请填写。");
                return;
            }
            if (txtTaxCode.Text.Trim() == "")
            {
                MessageBox.Show("税号不允许为空，请填写。");
                return;
            }

            using (SqlConnection conn = new SqlConnection(GlobalItem.g_DbConnectStrings))
            {
                string sql = @"UPDATE dbo.FIN_MakeCollectionsBill SET VoucherCode = '{1}',BillingCode = '{2}' WHERE MakeCollectionsBillID = {0}";
                sql = string.Format(sql, _id, txtTaxCode.Text.Trim(), txtVoucherCode.Text.Trim());
                try
                {
                    conn.Open();
                    SqlCommand comm = new SqlCommand(sql, conn);
                    comm.ExecuteNonQuery();
                }
                catch (Exception ex)
                {
                    XtraMessageBox.Show(ex.ToString(), "系统", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                finally
                {
                    conn.Close();
                }
            }
            this.DialogResult = DialogResult.Yes;
        }

        private void FrmUpdateMakeCollectionsBill_Load(object sender, EventArgs e)
        {
            txtCode.Text = _code;
        }
    }
}
