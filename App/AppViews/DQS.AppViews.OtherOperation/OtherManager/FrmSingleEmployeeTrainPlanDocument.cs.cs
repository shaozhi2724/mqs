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
using DQS.Module.Entities;

namespace DQS.AppViews.OtherOperation.OtherManager
{
    public partial class FrmSingleEmployeeTrainPlanDocument : XtraForm
    {
        int _PlanID;
        int _id;
        public FrmSingleEmployeeTrainPlanDocument()
        {
            InitializeComponent();
        }
        public FrmSingleEmployeeTrainPlanDocument(int PlanID, int id)
        {
            InitializeComponent();
            _PlanID = PlanID;
            _id = id;
        }

        private void FrmSingleEmployeeTrainPlanDocument_Load(object sender, EventArgs e)
        {
            if (_id > 0)
            {
                GetCheckBody();
            }
        }
        private void GetCheckBody()
        {
            using (SqlConnection conn = new SqlConnection(GlobalItem.g_DbConnectStrings))
            {
                string sql = @"SELECT TrainID,etpd.EmployeeID,e.EmployeeName,d.DepartmentName,CheckResult,CheckSolution,Remark FROM BUS_EmployeeTrainPlanDocument etpd
INNER JOIN dbo.BFI_Employee e ON etpd.EmployeeID = e.EmployeeID
INNER JOIN dbo.BFI_Department d ON e.DepartmentID = d.DepartmentID WHERE etpd.ID = {0}";
                sql = string.Format(sql, _id);
                SqlDataAdapter sda = new SqlDataAdapter(sql, conn);
                DataSet ds = new DataSet();
                try
                {
                    sda.Fill(ds, "Table");
                    int i = ds.Tables["Table"].Rows.Count;
                    if (i > 0)
                    {
                        txtEmployee.Tag = ds.Tables["Table"].Rows[0]["EmployeeID"].ToString();
                        txtEmployee.Text = ds.Tables["Table"].Rows[0]["EmployeeName"].ToString();
                        txtDeparment.Text = ds.Tables["Table"].Rows[0]["DepartmentName"].ToString();
                        txtMeasure.Text = ds.Tables["Table"].Rows[0]["CheckSolution"].ToString();
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
        }

        private void saveCheckBody(int id)
        {
            using (SqlConnection conn = new SqlConnection(GlobalItem.g_DbConnectStrings))
            {
                string sql = "EXEC sp_UpdateEmployeeTrainPlanDocument {0},{1},{2},'{3}','{4}','{5}'";
                sql = string.Format(sql,_PlanID, txtEmployee.Tag, id,
                    txtCheckResult.Text,
                    txtMeasure.Text,
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
                            MessageBox.Show((item as ComboBoxEdit).Properties.NullValuePrompt);
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
                            MessageBox.Show((item as ComboBoxEdit).Properties.NullValuePrompt);
                            isgo = false;
                        }
                    }
                }
            }
            return isgo;
        }

        private void txtEmployee_Click(object sender, EventArgs e)
        {
            using (FrmSearchEmployee frm = new FrmSearchEmployee())
            {
                DialogResult dr = frm.ShowDialog();
                if (dr == DialogResult.Yes)
                {
                    GetEmployee(frm._EID);
                }
            }
        }

        private void GetEmployee(int EID)
        {
            BFIEmployeeEntity em = new BFIEmployeeEntity { EmployeeID = EID };
            em.Fetch();
            txtEmployee.Tag = EID;
            txtEmployee.Text = em.EmployeeName;
            if (em.DepartmentID == 0 || em.IsNullField("DepartmentID"))
            {
                return;
            }
            BFIDepartmentEntity de = new BFIDepartmentEntity { DepartmentID = em.DepartmentID };
            de.Fetch();
            txtDeparment.Text = de.DepartmentName;
        }
    }
}
