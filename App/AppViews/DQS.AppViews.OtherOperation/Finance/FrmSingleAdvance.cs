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
    public partial class FrmSingleAdvance : XtraForm
    {
        private DataRow _dataRow;

        public FrmSingleAdvance()
        {
            InitializeComponent();
        }

        private void txtBillCode_Click(object sender, EventArgs e)
        {
            using (FrmChooseAdvanceBill frm = new FrmChooseAdvanceBill())
            {
                DialogResult dr = frm.ShowDialog();
                if (dr == DialogResult.Yes)
                {
                    _dataRow = frm.dataRow;
                    txtBillCode.Text = _dataRow["单据编号"].ToString();
                    txtBillDate.Text = _dataRow["单据日期"].ToString();
                    txtDealerCode.Text = _dataRow["单位编码"].ToString();
                    txtDealerName.Text = _dataRow["单位名称"].ToString();
                    txtBillTotalPrice.Text = _dataRow["金额"].ToString();
                    txtAdvanceTotalPrice.Text = _dataRow["金额"].ToString();
                }
            }
        }

        private void FrmSingleAdvance_Load(object sender, EventArgs e)
        {
            this.deAdvanceDate.Text = DateTime.Now.ToString("d");
            this.txtAdvancePerson.Text = GlobalItem.g_CurrentUser.UserName;
            txtAdvanceTotalPrice.Focus();
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            using (SqlConnection conn = new SqlConnection(GlobalItem.g_DbConnectStrings))
            {
                string sql = @"INSERT dbo.FIN_Advance( DealerCode ,DealerName ,BillCode ,TotalPrice ,
AdvanceDate ,CreateDate ,CreatePerson)
VALUES  ( N'{0}' ,N'{1}' ,N'{2}' ,{3} ,'{4}' ,'{5}' ,N'{6}')
";
                sql = string.Format(sql, _dataRow["单位编码"].ToString(), _dataRow["单位名称"].ToString(), _dataRow["单据编号"].ToString(), txtAdvanceTotalPrice.Text.Trim(), deAdvanceDate.Text, DateTime.Now, GlobalItem.g_CurrentUser.UserName);
                try
                {
                    int re = 0;
                    conn.Open();
                    SqlCommand com = new SqlCommand(sql, conn);
                    re=com.ExecuteNonQuery();
                    if (re == 1)
                    {
                        this.DialogResult = DialogResult.Yes;
                    }
                    else
                    {
                        this.DialogResult = DialogResult.No;
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
