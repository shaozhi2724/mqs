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
    public partial class FrmSingleStoreDetail : XtraForm
    {
        int _inStoreID;
        string _batchNo;
        string _ProduceDate;
        string _ValidateDate;
        public FrmSingleStoreDetail()
        {
            InitializeComponent();
        }
        public FrmSingleStoreDetail(int inStoreID)
        {
            InitializeComponent();
            _inStoreID = inStoreID;
        }

        private void FrmSingleStoreDetail_Load(object sender, EventArgs e)
        {
            BandGrid();
        }

        private void BandGrid()
        {
            using (SqlConnection conn = new SqlConnection(GlobalItem.g_DbConnectStrings))
            {
                string sql = @"SELECT InStoreID,p.ProductCode,p.ProductName,p.ProductSpec,p.ProductUnit,p.PackageSpec,p.PhysicType,p.AuthorizedNo,p.ProductStyle,p.ProducerName,BatchNo,ProduceDate,ValidateDate,InAmount,d.DepartmentName FROM dbo.BUS_InStoreDetail isd
INNER JOIN dbo.BFI_Product p ON isd.ProductID = p.ProductID
INNER JOIN dbo.BFI_Department d ON isd.DepartmentID = d.DepartmentID
WHERE InStoreID = {0}";
                sql = string.Format(sql, _inStoreID);
                SqlDataAdapter sda = new SqlDataAdapter(sql, conn);
                DataSet ds = new DataSet();
                try
                {
                    sda.Fill(ds, "Table");
                    int i = ds.Tables["Table"].Rows.Count;
                    if (i > 0)
                    {
                        this.ftPanel.Tag = ds.Tables["Table"].Rows[0]["InStoreID"];
                        this.txtProductCode.Text = ds.Tables["Table"].Rows[0]["ProductCode"].ToString();
                        this.txtProductName.Text = ds.Tables["Table"].Rows[0]["ProductName"].ToString();
                        this.txtProductSpec.Text = ds.Tables["Table"].Rows[0]["ProductSpec"].ToString();
                        this.txtProductUnit.Text = ds.Tables["Table"].Rows[0]["ProductUnit"].ToString();
                        this.txtPackageSpec.Text = ds.Tables["Table"].Rows[0]["PackageSpec"].ToString();
                        this.txtPhysicType.Text = ds.Tables["Table"].Rows[0]["PhysicType"].ToString();
                        this.txtAuthorizedNo.Text = ds.Tables["Table"].Rows[0]["AuthorizedNo"].ToString();
                        this.txtProductStyle.Text = ds.Tables["Table"].Rows[0]["ProductStyle"].ToString();
                        this.txtProducerName.Text = ds.Tables["Table"].Rows[0]["ProducerName"].ToString();
                        this.txtBatchNo.Text = ds.Tables["Table"].Rows[0]["BatchNo"].ToString();
                        _batchNo = ds.Tables["Table"].Rows[0]["BatchNo"].ToString();
                        this.dteProduceDate.Text = ds.Tables["Table"].Rows[0]["ProduceDate"].ToString() == "" ? "" : Convert.ToDateTime(ds.Tables["Table"].Rows[0]["ProduceDate"]).ToShortDateString();
                        _ProduceDate = ds.Tables["Table"].Rows[0]["ProduceDate"].ToString() == "" ? "" : Convert.ToDateTime(ds.Tables["Table"].Rows[0]["ProduceDate"]).ToShortDateString();
                        this.dteValidateDate.Text = ds.Tables["Table"].Rows[0]["ValidateDate"].ToString() == "" ? "" : Convert.ToDateTime(ds.Tables["Table"].Rows[0]["ValidateDate"]).ToShortDateString();
                        _ValidateDate = ds.Tables["Table"].Rows[0]["ValidateDate"].ToString() == "" ? "" : Convert.ToDateTime(ds.Tables["Table"].Rows[0]["ValidateDate"]).ToShortDateString();
                        this.speAmount.Text = ds.Tables["Table"].Rows[0]["InAmount"].ToString();
                        this.cbxDepartment.Text = ds.Tables["Table"].Rows[0]["DepartmentName"].ToString();
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
            if (txtCause.Text == "")
            {
                XtraMessageBox.Show("原因不能为空。", "系统提示", MessageBoxButtons.OK, MessageBoxIcon.Stop);
                return;
            }
            if (txtBatchNo.Text.Trim() == _batchNo.Trim() && Convert.ToDateTime(dteProduceDate.DateTime.ToString()).ToShortDateString() == Convert.ToDateTime(_ProduceDate).ToShortDateString() && Convert.ToDateTime(dteValidateDate.DateTime.ToString()).ToShortDateString() == Convert.ToDateTime(_ValidateDate).ToShortDateString())
            {
                XtraMessageBox.Show("未检测到更改。", "系统提示", MessageBoxButtons.OK, MessageBoxIcon.Stop);
                return;
            }
            if (txtBatchNo.Text.Trim() == "")
            {
                XtraMessageBox.Show("批号不能为空。", "系统提示", MessageBoxButtons.OK, MessageBoxIcon.Stop);
                return;
            }
            if (dteProduceDate.Text.Trim() == "")
            {
                XtraMessageBox.Show("生产日期不能为空。", "系统提示", MessageBoxButtons.OK, MessageBoxIcon.Stop);
                return;
            }
            if (dteValidateDate.Text.Trim() == "")
            {
                XtraMessageBox.Show("有效期不能为空。", "系统提示", MessageBoxButtons.OK, MessageBoxIcon.Stop);
                return;
            }
            string code = "KCBG" + DateTime.Now.ToString("yyyyMMddhhmmss");

            string sql = @"EXEC sp_StoreDetailChange '{0}',{1},'{2}','{3}','{4}','{5}','{6}','{7}'";
            sql = string.Format(sql,
                code,
                ftPanel.Tag,
                txtCause.Text,
                GlobalItem.g_CurrentUser.UserName,
                txtRemark.Text,
                txtBatchNo.Text,
                dteProduceDate.DateTime,
                dteValidateDate.DateTime);
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
