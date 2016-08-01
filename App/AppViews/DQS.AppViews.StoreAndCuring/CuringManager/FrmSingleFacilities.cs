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

namespace DQS.AppViews.StoreAndCuring.CuringManager
{
    public partial class FrmSingleFacilities : XtraForm
    {
        public FrmSingleFacilities()
        {
            InitializeComponent();
        }

        private void FrmSingleFacilities_Load(object sender, EventArgs e)
        {
            LoadType();
            if (this.Tag != null)
            {
                GetFacilities();
                txtCode.Properties.ReadOnly = true;
            }
            else
            {
                txtCreateUser.Text = GlobalItem.g_CurrentUser.UserName;
            }
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            if (!ViliedControlBox())
            {
                return;
            }
            if (this.Tag == null)
            {
                if (IsHaveFacilities())
                {
                    return;
                }
            }
            SaveFacilities();
            this.DialogResult = DialogResult.OK;
        }

        private void SaveFacilities()
        {
            using (SqlConnection conn = new SqlConnection(GlobalItem.g_DbConnectStrings))
            {
                string sql;
                if (this.Tag != null)
                {
                    sql = @"UPDATE BFI_Facilities 
SET 
FacilityName = '{0}',
FacilityAddress = '{1}',
FacilitySpec = '{2}',
StyleName = '{3}'
WHERE ID = {4}";
                    sql = string.Format(sql, 
                        txtName.Text.Trim(),
                        txtAddress.Text.Trim(),
                        txtSpec.Text.Trim(),
                        cboStyle.Text.Trim(),
                        (int)this.Tag);
                }
                else
                {
                    sql = @"INSERT BFI_Facilities(FacilityCode,FacilityName,FacilityAddress,FacilitySpec,StyleName,CreateUser,CreateDate)
VALUES('{0}','{1}','{2}','{3}','{4}','{5}',GETDATE())";
                    sql = string.Format(sql, txtCode.Text.Trim(),
                        txtName.Text.Trim(),
                        txtAddress.Text.Trim(),
                        txtSpec.Text.Trim(),
                        cboStyle.Text.Trim(),
                        txtCreateUser.Text.Trim());
                }
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

        private bool IsHaveFacilities()
        {
            using (SqlConnection conn = new SqlConnection(GlobalItem.g_DbConnectStrings))
            {
                string sql = @"SELECT 1 FROM BFI_Facilities WHERE FacilityCode = '{0}'";
                sql = string.Format(sql, txtCode.Text.Trim());
                SqlDataAdapter sda = new SqlDataAdapter(sql, conn);
                DataSet ds = new DataSet();
                try
                {
                    sda.Fill(ds, "Table");
                    int i = ds.Tables["Table"].Rows.Count;
                    if (i > 0)
                    {
                        XtraMessageBox.Show("该编号已存在，请重新输入。", "提示", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        return true;
                    }
                    else
                    {
                        return false;
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
            return false;
        }

        private void GetFacilities()
        {
            using (SqlConnection conn = new SqlConnection(GlobalItem.g_DbConnectStrings))
            {
                string sql = @"SELECT FacilityCode,FacilityName,FacilityAddress,FacilitySpec,StyleName,CreateUser 
FROM BFI_Facilities WHERE ID = {0}";
                sql = string.Format(sql, (int)this.Tag);
                SqlDataAdapter sda = new SqlDataAdapter(sql, conn);
                DataSet ds = new DataSet();
                try
                {
                    sda.Fill(ds, "Table");
                    int i = ds.Tables["Table"].Rows.Count;
                    if (i > 0)
                    {
                        txtCode.Text = ds.Tables["Table"].Rows[0]["FacilityCode"].ToString();
                        txtName.Text = ds.Tables["Table"].Rows[0]["FacilityName"].ToString();
                        txtAddress.Text = ds.Tables["Table"].Rows[0]["FacilityAddress"].ToString();
                        txtSpec.Text = ds.Tables["Table"].Rows[0]["FacilitySpec"].ToString();
                        cboStyle.Text = ds.Tables["Table"].Rows[0]["StyleName"].ToString();
                        txtCreateUser.Text = ds.Tables["Table"].Rows[0]["CreateUser"].ToString();
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

        private bool ViliedControlBox()
        {
            if (txtCode.Text.Trim() == "")
            {
                XtraMessageBox.Show("编号不能为空。", "提示", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
            if (txtName.Text.Trim() == "")
            {
                XtraMessageBox.Show("名称不能为空。", "提示", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
            if (txtSpec.Text.Trim() == "")
            {
                XtraMessageBox.Show("规格不能为空。", "提示", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
            if (txtAddress.Text.Trim() == "")
            {
                XtraMessageBox.Show("地址不能为空。", "提示", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
            if (cboStyle.Text.Trim() == "")
            {
                XtraMessageBox.Show("类型不能为空。", "提示", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
            return true;
        }
        private void LoadType()
        {
            using (SqlConnection conn = new SqlConnection(GlobalItem.g_DbConnectStrings))
            {
                string sql = "SELECT StyleName FROM BFI_Facilities GROUP BY StyleName";
                SqlDataAdapter sda = new SqlDataAdapter(sql, conn);
                DataSet ds = new DataSet();
                try
                {
                    sda.Fill(ds, "Table");
                    for (int i = 0; i < ds.Tables["Table"].Rows.Count; i++)
                    {
                        cboStyle.Properties.Items.Add(ds.Tables["Table"].Rows[i]["StyleName"].ToString());
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
