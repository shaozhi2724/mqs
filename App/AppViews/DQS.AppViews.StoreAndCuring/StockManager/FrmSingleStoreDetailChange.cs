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

namespace DQS.AppViews.StoreAndCuring.StockManager
{
    public partial class FrmSingleStoreDetailChange : XtraForm
    {
        int _ChangeID;
        bool _isSave;
        public FrmSingleStoreDetailChange()
        {
            InitializeComponent();
        }
        public FrmSingleStoreDetailChange(int ChangeID ,bool isSave)
        {
            InitializeComponent();
            _ChangeID = ChangeID;
            _isSave = isSave;
        }

        private void FrmSingleStoreDetailChange_Load(object sender, EventArgs e)
        {
            BandGrid();
            btnSave.Enabled = _isSave;
            btnUnSave.Enabled = _isSave;
        }

        private void BandGrid()
        {
            using (SqlConnection conn = new SqlConnection(GlobalItem.g_DbConnectStrings))
            {
                string sql = @"SELECT  OldBatchNo,OldProduceDate,OldValidateDate,NewBatchNo,NewProduceDate,NewValidateDate
FROM dbo.BUS_StoreDetailChangeDetail WHERE ChangeID = {0}";
                sql = string.Format(sql, _ChangeID);
                SqlDataAdapter sda = new SqlDataAdapter(sql, conn);
                DataSet ds = new DataSet();
                try
                {
                    sda.Fill(ds, "Table");
                    int i = ds.Tables["Table"].Rows.Count;
                    if (i > 0)
                    {
                        txtOldBatchNo.Text = ds.Tables["Table"].Rows[0]["OldBatchNo"].ToString();
                        txtOldProduceDate.Text = ds.Tables["Table"].Rows[0]["OldProduceDate"].ToString();
                        txtValidateDate.Text = ds.Tables["Table"].Rows[0]["OldValidateDate"].ToString();
                        txtNewBatchNo.Text = ds.Tables["Table"].Rows[0]["NewBatchNo"].ToString();
                        txtNewProduceDate.Text = ds.Tables["Table"].Rows[0]["NewProduceDate"].ToString();
                        txtNewValidateDate.Text = ds.Tables["Table"].Rows[0]["NewValidateDate"].ToString();
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

        private void btnSave_Click(object sender, EventArgs e)
        {
            string sql = @"EXEC sp_SaveStoreDetailChange {0},'{1}'";
            sql = string.Format(sql, _ChangeID, GlobalItem.g_CurrentUser.UserName);
            using (SqlConnection conn = new SqlConnection(GlobalItem.g_DbConnectStrings))
            {
                conn.Open();
                try
                {
                    SqlCommand comm = new SqlCommand(sql, conn);
                    comm.ExecuteNonQuery();
                }
                catch (Exception ex)
                {
                    XtraMessageBox.Show(ex.Message.ToString(), "提示", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                finally
                {
                    conn.Close();
                }
            }
            this.DialogResult = DialogResult.Yes;
        }

        private void btnUnSave_Click(object sender, EventArgs e)
        {
            string sql = @"EXEC sp_UnSaveStoreDetailChange {0},'{1}'";
            sql = string.Format(sql, _ChangeID, GlobalItem.g_CurrentUser.UserName);
            using (SqlConnection conn = new SqlConnection(GlobalItem.g_DbConnectStrings))
            {
                conn.Open();
                try
                {
                    SqlCommand comm = new SqlCommand(sql, conn);
                    comm.ExecuteNonQuery();
                }
                catch (Exception ex)
                {
                    XtraMessageBox.Show(ex.Message.ToString(), "提示", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                finally
                {
                    conn.Close();
                }
            }
            this.DialogResult = DialogResult.Yes;
        }
    }
}
