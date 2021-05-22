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
    public partial class FrmDateUpdate : XtraForm
    {
        public FrmDateUpdate()
        {
            InitializeComponent();
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            if (txtBillCode.Text.Length > 0)
            {
                GridLoad();
            }
        }

        private void GridLoad()
        {
            string sql = @"SELECT CONVERT(NVARCHAR(20),b.BillDate,120) BillDate ,ISNULL(CONVERT(NVARCHAR(20),rec.ReceiveDate,120),'') ReceiveDate,ISNULL(CONVERT(NVARCHAR(20),acc.AcceptDate,120),'') AcceptDate,ISNULL(CONVERT(NVARCHAR(20),sb.StoreDate,120),'') StoreDate,ISNULL(CONVERT(NVARCHAR(20),rev.ReviewDate,120),'') ReviewDate FROM dbo.BUS_Bill b
LEFT JOIN dbo.BUS_Receive rec ON b.BillCode = rec.BillCode
LEFT JOIN dbo.BUS_Accept acc ON b.BillCode = acc.BillCode
LEFT JOIN dbo.BUS_StoreBill sb ON (b.BillCode = sb.PurchaseBillCode OR b.BillCode = sb.SaleBillCode)
LEFT JOIN dbo.BUS_Review rev ON b.BillCode = rev.SaleBillCode
WHERE b.BillCode = '" + txtBillCode.Text + "'";
            using (SqlConnection conn = new SqlConnection(GlobalItem.g_DbConnectStrings))
            {
                SqlDataAdapter sda = new SqlDataAdapter(sql, conn);
                DataSet ds = new DataSet();
                try
                {
                    sda.Fill(ds, "Table");
                    lableBillDate.Text = ds.Tables["Table"].Rows[0]["BillDate"].ToString();
                    lableReceiveDate.Text = ds.Tables["Table"].Rows[0]["ReceiveDate"].ToString();
                    lableAcceptDate.Text = ds.Tables["Table"].Rows[0]["AcceptDate"].ToString();
                    lableStoreDate.Text = ds.Tables["Table"].Rows[0]["StoreDate"].ToString();
                    lableReviewDate.Text = ds.Tables["Table"].Rows[0]["ReviewDate"].ToString();
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

        private void btnSave1_Click(object sender, EventArgs e)
        {
            if (txtBillCode.Text.Length > 0 && txtday1.Text.Length > 0)
            {
                SqlConnection conn = new SqlConnection(GlobalItem.g_DbConnectStrings);
                conn.Open();
                try
                {
                    string catesql = "UPDATE dbo.BUS_Bill SET BillDate = DATEADD(DAY," + txtday1.Text + ",BillDate),CreateDate = DATEADD(DAY," + txtday1.Text + ",CreateDate) WHERE BillCode = '" + txtBillCode.Text + "'";
                    SqlCommand com = new SqlCommand(catesql, conn);
                    int result = com.ExecuteNonQuery();
                    if (result > 0)
                    {
                        XtraMessageBox.Show("更新成功。", "系统提示", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                    }
                }
                catch (Exception)
                {
                    XtraMessageBox.Show("未能更新成功。", "系统提示", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                }
                finally
                {
                    conn.Close();
                }
            }
        }

        private void btnSave2_Click(object sender, EventArgs e)
        {
            if (txtBillCode.Text.Length > 0 && txtday2.Text.Length > 0)
            {
                SqlConnection conn = new SqlConnection(GlobalItem.g_DbConnectStrings);
                conn.Open();
                try
                {
                    string catesql = "UPDATE dbo.BUS_Receive SET ReceiveDate = DATEADD(DAY," + txtday2.Text + ",ReceiveDate),BillDate = DATEADD(DAY," + txtday2.Text + ",BillDate),CreateDate = DATEADD(DAY," + txtday2.Text + ",CreateDate) WHERE BillCode = '" + txtBillCode.Text + "'";
                    SqlCommand com = new SqlCommand(catesql, conn);
                    int result = com.ExecuteNonQuery();
                    if (result > 0)
                    {
                        XtraMessageBox.Show("更新成功。", "系统提示", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                    }
                }
                catch (Exception)
                {
                    XtraMessageBox.Show("未能更新成功。", "系统提示", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                }
                finally
                {
                    conn.Close();
                }
            }
        }

        private void btnSave3_Click(object sender, EventArgs e)
        {
            if (txtBillCode.Text.Length > 0 && txtday3.Text.Length > 0)
            {
                SqlConnection conn = new SqlConnection(GlobalItem.g_DbConnectStrings);
                conn.Open();
                try
                {
                    string catesql = "UPDATE dbo.BUS_Accept SET AcceptDate = DATEADD(DAY," + txtday3.Text + ",AcceptDate),BillDate = DATEADD(DAY," + txtday3.Text + ",BillDate),CreateDate = DATEADD(DAY," + txtday3.Text + ",CreateDate) WHERE BillCode = '" + txtBillCode.Text + "'";
                    SqlCommand com = new SqlCommand(catesql, conn);
                    int result = com.ExecuteNonQuery();
                    if (result > 0)
                    {
                        XtraMessageBox.Show("更新成功。", "系统提示", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                    }
                }
                catch (Exception)
                {
                    XtraMessageBox.Show("未能更新成功。", "系统提示", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                }
                finally
                {
                    conn.Close();
                }
            }
        }

        private void btnSave4_Click(object sender, EventArgs e)
        {
            if (txtBillCode.Text.Length > 0 && txtday4.Text.Length > 0)
            {
                SqlConnection conn = new SqlConnection(GlobalItem.g_DbConnectStrings);
                conn.Open();
                try
                {
                    string catesql = @"UPDATE dbo.BUS_StoreBill SET StoreDate = DATEADD(DAY,{0},StoreDate),CreateDate = DATEADD(DAY,{0},CreateDate) WHERE SaleBillCode = '{1}' OR PurchaseBillCode = '{1}'
UPDATE dbo.BUS_InStoreDetail SET InStoreDate = DATEADD(DAY,{0},InStoreDate) WHERE InStoreCode = '{1}'
UPDATE dbo.BUS_OutStoreDetail SET OutStoreDate = DATEADD(DAY,{0},OutStoreDate) WHERE OutStoreCode = '{1}'
                    ";
                    catesql = string.Format(catesql, txtday4.Text, txtBillCode.Text);
                    SqlCommand com = new SqlCommand(catesql, conn);
                    int result = com.ExecuteNonQuery();
                    if (result > 0)
                    {
                        XtraMessageBox.Show("更新成功。", "系统提示", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                    }
                }
                catch (Exception)
                {
                    XtraMessageBox.Show("未能更新成功。", "系统提示", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                }
                finally
                {
                    conn.Close();
                }
            }
        }

        private void btnSave5_Click(object sender, EventArgs e)
        {
            if (txtBillCode.Text.Length > 0 && txtday5.Text.Length > 0)
            {
                SqlConnection conn = new SqlConnection(GlobalItem.g_DbConnectStrings);
                conn.Open();
                try
                {
                    string catesql = "UPDATE dbo.BUS_Review SET ReviewDate = DATEADD(DAY," + txtday5.Text + ",ReviewDate),CreateDate = DATEADD(DAY," + txtday5.Text + ",CreateDate) WHERE SaleBillCode = '" + txtBillCode.Text + "'";
                    SqlCommand com = new SqlCommand(catesql, conn);
                    int result = com.ExecuteNonQuery();
                    if (result > 0)
                    {
                        XtraMessageBox.Show("更新成功。", "系统提示", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                    }
                }
                catch (Exception)
                {
                    XtraMessageBox.Show("未能更新成功。", "系统提示", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                }
                finally
                {
                    conn.Close();
                }
            }
        }
    }
}
