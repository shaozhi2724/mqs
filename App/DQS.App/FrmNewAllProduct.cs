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
    public partial class FrmNewAllProduct : XtraForm
    {
        public FrmNewAllProduct()
        {
            InitializeComponent();
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            if (textEdit1.Text == "" || textEdit12.Text == "")
            {
                return;
            }
            SqlConnection conn = new SqlConnection(GlobalItem.g_DbConnectStrings);
            conn.Open();
            try
            {
                string catesql = @"INSERT BFI_AllProduct(CenterVarietyCode,GenericNameOfTheDrug,EnglishName,ProductName,TheEnglishName,ProductCategory,DosageForm,Specifications,ProductionEnterprises,ApprovalNo,DateOfApproval,DrugStandard)
VALUES('" + textEdit1.Text + "','" + textEdit2.Text + "','" + textEdit3.Text + "','" + textEdit4.Text + "','" + textEdit5.Text + "','" + textEdit6.Text + "','" + textEdit7.Text + "','" + textEdit8.Text + "','" + textEdit9.Text + "','" + textEdit10.Text + "','" + textEdit11.Text + "','" + textEdit12.Text + "')";
                SqlCommand com = new SqlCommand(catesql, conn);
                int result = com.ExecuteNonQuery();
                if (result == 1)
                {
                    XtraMessageBox.Show("保存成功。", "系统提示", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                }
            }
            catch (Exception)
            {
                XtraMessageBox.Show("保存失败。", "系统提示", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
            finally
            {
                conn.Close();
            }
        }
    }
}
