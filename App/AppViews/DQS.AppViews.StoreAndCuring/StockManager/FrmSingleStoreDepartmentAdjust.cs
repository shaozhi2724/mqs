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
    public partial class FrmSingleStoreDepartmentAdjust : XtraForm
    {
        List<GetDepartment> departments = new List<GetDepartment>();

        GetDepartment department = new GetDepartment();

        StoreDetail store = new StoreDetail();

        public FrmSingleStoreDepartmentAdjust()
        {
            InitializeComponent();
        }

        private void txtProductName_Click(object sender, EventArgs e)
        {
            using (FrmChooseStoreDetails frm = new FrmChooseStoreDetails())
            {
                if (frm.ShowDialog() == DialogResult.Yes)
                {
                    this.store = frm._stroe;
                    GetStoreDetail();
                }
            }
        }

        private void GetStoreDetail()
        {
            this.Tag = store.StoreDetailID;
            this.txtProductName.Text = store.ProductName;
            this.txtProductCode.Text = store.ProductCode;
            this.txtPackageSpec.Text = store.PackageSpec;
            this.txtProducerName.Text = store.ProducerName;
            this.txtBatchNo.Text = store.BatchNo;
            this.txtAmount.Text = store.Amount.ToString() ;
            this.txtDepartment.Text = store.DepartmentName;
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            if (txtProductName.Text.Trim() == "")
            {
                XtraMessageBox.Show("请选择药品。", "系统提示", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            if (txtAdjustAmount.Text.Trim() == "")
            {
                XtraMessageBox.Show("请输入移库数量。", "系统提示", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            if (cboDepartment.Text.Trim() == "")
            {
                XtraMessageBox.Show("请选择移库部门。", "系统提示", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            
            using (SqlConnection conn = new SqlConnection(GlobalItem.g_DbConnectStrings))
            {
                string sql = @"EXEC sp_DepartmentStore {0},{1},{2},'{3}','{4}'";
                sql = string.Format(sql, this.Tag, GetDepartmentID(), int.Parse(txtAdjustAmount.Text.Trim()), txtRemark.Text,GlobalItem.g_CurrentUser.UserName);

                conn.Open(); //连接数据库
                try
                {
                    SqlCommand cmd = new SqlCommand(sql, conn);
                    cmd.ExecuteNonQuery();
                }
                catch (Exception ex)
                {
                    XtraMessageBox.Show(ex.ToString(), "提示", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                finally
                {
                    conn.Close();
                }
            }
            this.DialogResult = DialogResult.Yes;
        }

        private int GetDepartmentID()
        {
            int departmentID = 0;
            foreach (GetDepartment depart in departments)
            {
                if (depart.departmentName == cboDepartment.Text)
                {
                    departmentID = depart.departmentID;
                }
            }
            return departmentID;
        }

        private void LoadDepartment()
        {
            using (SqlConnection conn = new SqlConnection(GlobalItem.g_DbConnectStrings))
            {
                string sqlBill = @"SELECT DepartmentID,DepartmentName FROM dbo.BFI_Department WHERE DepartmentName LIKE '%业务%'";

                SqlDataAdapter sdad = new SqlDataAdapter(sqlBill, conn);
                DataSet ds = new DataSet();
                try
                {
                    sdad.Fill(ds, "Table");
                    for (int i = 0; i < ds.Tables["Table"].Rows.Count; i++)
                    {
                        department = new GetDepartment();
                        department.departmentID = Convert.ToInt32(ds.Tables["Table"].Rows[i]["DepartmentID"]);
                        department.departmentName = ds.Tables["Table"].Rows[i]["DepartmentName"].ToString();
                        departments.Add(department);
                        cboDepartment.Properties.Items.Add(department.departmentName);
                    }
                }
                catch (Exception ex)
                {
                    XtraMessageBox.Show(ex.ToString(), "系统提示", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                finally
                {
                    conn.Close();
                }
            }
        }

        private void FrmSingleStoreDepartmentAdjust_Load(object sender, EventArgs e)
        {
            LoadDepartment();
        }
    }
}
