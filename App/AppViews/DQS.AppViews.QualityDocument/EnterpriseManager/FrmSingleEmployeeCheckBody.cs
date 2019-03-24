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

namespace DQS.AppViews.QualityDocument.EnterpriseManager
{
    public partial class FrmSingleEmployeeCheckBody : XtraForm
    {
        int _epID;
        int _id;
        public FrmSingleEmployeeCheckBody()
        {
            InitializeComponent();
        }
        public FrmSingleEmployeeCheckBody(int epID,int id)
        {
            InitializeComponent();
            _epID = epID;
            _id = id;
        }

        private void FrmSingleEmployeeCheckBody_Load(object sender, EventArgs e)
        {
            if (_id > 0)
            {
                GetCheckBody();
            }
            else
            {
                txtCheckDate.Text = DateTime.Now.ToShortDateString();
            }
        }
        private void GetCheckBody()
        {
            using (SqlConnection conn = new SqlConnection(GlobalItem.g_DbConnectStrings))
            {
                string sql = @"SELECT  ID ,
        EmployeeID ,
        YearKey ,
        Code ,
        CheckProject ,
        CheckDate ,
        CheckGov ,
        Measure ,
        CheckResult ,
        Remark FROM dbo.BFI_EmployeeCheckBody WHERE ID = {0}";
                sql = string.Format(sql, _id);
                SqlDataAdapter sda = new SqlDataAdapter(sql, conn);
                DataSet ds = new DataSet();
                try
                {
                    sda.Fill(ds, "Table");
                    int i = ds.Tables["Table"].Rows.Count;
                    if (i > 0)
                    {
                        txtYearKey.Text = ds.Tables["Table"].Rows[0]["YearKey"].ToString();
                        txtCode.Text = ds.Tables["Table"].Rows[0]["Code"].ToString();
                        txtCheckProject.Text = ds.Tables["Table"].Rows[0]["CheckProject"].ToString();
                        txtCheckDate.Text = ds.Tables["Table"].Rows[0]["CheckDate"].ToString();
                        txtCheckGov.Text = ds.Tables["Table"].Rows[0]["CheckGov"].ToString();
                        txtMeasure.Text = ds.Tables["Table"].Rows[0]["Measure"].ToString();
                        txtCheckResult.Text = ds.Tables["Table"].Rows[0]["CheckResult"].ToString();
                        txtRemark.Text = ds.Tables["Table"].Rows[0]["Remark"].ToString();
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
            if (checkText())
            {
                if (_id == 0)
                {
                    saveCheckBody(0);
                }
                else
                {
                    saveCheckBody(_id);
                }
                this.DialogResult = DialogResult.OK;
            }
            //EXEC sp_insertEmployeeCheckBody {0},{1},'{2}','{3}','{4}','{5}','{6}','{7}','{8}','{9}'

        }

        private void saveCheckBody(int id)
        {
            using (SqlConnection conn = new SqlConnection(GlobalItem.g_DbConnectStrings))
            {
                string sql = "EXEC sp_insertEmployeeCheckBody {0},{1},'{2}','{3}','{4}','{5}','{6}','{7}','{8}','{9}'";
                sql = string.Format(sql, id, _epID, 
                    txtYearKey.Text,
                    txtCode.Text,
                    txtCheckProject.Text,
                    txtCheckDate.Text,
                    txtCheckGov.Text,
                    txtMeasure.Text,
                    txtCheckResult.Text,
                    txtRemark.Text);
                SqlCommand com = new SqlCommand(sql, conn);
                try
                {
                    conn.Open();
                    int i = com.ExecuteNonQuery();
                    if (i > 0)
                    {
                        MessageBox.Show("保存成功。");
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

        private bool checkText()
        {
            bool isgo = true;
            foreach (Control item in layoutControl.Controls)
            {
                if (item.GetType().Name.Equals("ComboBoxEdit"))
                {
                    if ((item as ComboBoxEdit).Properties.NullValuePromptShowForEmptyValue)
                    {
                        if (item.Text.Trim() == "")
                        {
                            MessageBox.Show(item.Tag + "不能为空。");
                            isgo = false;
                        }
                    }
                }
                if (item.GetType().Name.Equals("MemoEdit"))
                {
                    if ((item as MemoEdit).Properties.NullValuePromptShowForEmptyValue)
                    {
                        if (item.Text.Trim() == "")
                        {
                            MessageBox.Show(item.Tag + "不能为空。");
                            isgo = false;
                        }
                    }
                }
            }
            return isgo;
        }
    }
}
