using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using DevExpress.XtraEditors;
using DQS.Common;

namespace DQS.App
{
    public partial class FrmChangePassword : DevExpress.XtraEditors.XtraForm
    {
        public FrmChangePassword()
        {
            InitializeComponent();
        }

        private void btnChangePassword_Click(object sender, EventArgs e)
        {
            string oldPassword = this.txtOldPassword.Text.Trim();
            string password = this.txtPassword.Text.Trim();
            string rePassword = this.txtRePassword.Text.Trim();

            if (string.IsNullOrEmpty(oldPassword))
            {
                XtraMessageBox.Show("旧密码不能为空", "系统提示", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                this.txtOldPassword.Focus();
                return;
            }

            if (GlobalMethod.GetEncryptPassword(oldPassword).ToUpper() != GlobalItem.g_CurrentUser.UserPassword.ToUpper())
            {
                XtraMessageBox.Show("旧密码错误", "系统提示", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                this.txtOldPassword.Focus();
                this.txtOldPassword.Select(this.txtOldPassword.Text.Length, 0);
                return;
            }

            if (string.IsNullOrEmpty(password))
            {
                XtraMessageBox.Show("新密码不能为空", "系统提示", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                this.txtPassword.Focus();
                return;
            }

            if (password == oldPassword)
            {
                XtraMessageBox.Show("旧密码不能与新密码相同", "系统提示", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                this.txtPassword.Focus();
                this.txtPassword.Select(this.txtPassword.Text.Length, 0);
                return;
            }

            if (string.IsNullOrEmpty(rePassword))
            {
                XtraMessageBox.Show("重复密码不能为空", "系统提示", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                this.txtRePassword.Focus();
                return;
            }

            if (password != rePassword)
            {
                XtraMessageBox.Show("两次密码输入不一致", "系统提示", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                this.txtPassword.Focus();
                this.txtPassword.Select(this.txtPassword.Text.Length, 0);
                return;
            }

            try
            {
                GlobalItem.g_CurrentUser.UserPassword = GlobalMethod.GetEncryptPassword(password);
                GlobalItem.g_CurrentUser.Update();

                XtraMessageBox.Show("密码修改成功，新密码将在下一次系统登录时生效。", "系统信息", MessageBoxButtons.OK, MessageBoxIcon.Information);
                this.Close();
            }
            catch (Exception ex)
            {
                XtraMessageBox.Show(ex.Message, "系统信息", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }


        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}