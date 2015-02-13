using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using DevExpress.XtraEditors;
using DevExpress.XtraEditors.Controls;
using DQS.Module.Entities;
using ORMSCore;
using DQS.Controls;

namespace DQS.AppViews.QualityControl.UserManager
{
    public partial class FrmUserRole : DevExpress.XtraEditors.XtraForm
    {
        public FrmUserRole()
        {
            InitializeComponent();
        }

        private void FrmUserRole_Load(object sender, EventArgs e)
        {
            EntityCollection<ATCUserEntity> users = new EntityCollection<ATCUserEntity>();
            users.Fetch();

            foreach (ATCUserEntity u in users)
            {
                this.lbcUser.Items.Add(new ListEntityItem(u, u.UserName));
            }

            EntityCollection<ATCRoleEntity> roles = new EntityCollection<ATCRoleEntity>();
            roles.Fetch();

            foreach (ATCRoleEntity r in roles)
            {
                this.chklbcRole.Items.Add(new ListEntityItem(r, r.RoleName));
            }

            if (lbcUser.Items.Count > 0)
            {
                this.lbcUser.SelectedIndex = 0;
                this.lbcUser_SelectedIndexChanged(null, null);
            }
        }

        private void lbcUser_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (lbcUser.SelectedItem != null)
            {
                ATCUserEntity selectUser = (lbcUser.SelectedItem as ListEntityItem).Key as ATCUserEntity;

                EntityCollection<ATCUserRoleEntity> userRoles = new EntityCollection<ATCUserRoleEntity>();
                userRoles.Fetch(ATCUserRoleEntityFields.UserID == selectUser.UserID);
                if (userRoles.Count > 0)
                {
                    this.chklbcRole.UnCheckAll();//先全部清空

                    foreach (ATCUserRoleEntity ur in userRoles)
                    {
                        foreach (CheckedListBoxItem item in this.chklbcRole.Items)
                        {
                            ATCRoleEntity role = (item.Value as ListEntityItem).Key as ATCRoleEntity;

                            if (role.RoleID == ur.RoleID)
                            {
                                this.chklbcRole.SelectedItem = item;
                                item.CheckState = CheckState.Checked;
                                break;
                            }
                        }
                    }
                }
                else
                {
                    this.chklbcRole.SelectedIndex = 0;
                    this.chklbcRole.UnCheckAll();
                }
            }
        }

        private void chkCheck_CheckedChanged(object sender, EventArgs e)
        {
            if (chkCheck.Checked)
            {
                chkCheck.Text = "反选";
                this.chklbcRole.CheckAll();
            }
            else
            {
                chkCheck.Text = "全选";
                this.chklbcRole.UnCheckAll();
            }
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            try
            {
                foreach (ListEntityItem userItem in this.lbcUser.SelectedItems)
                {
                    ATCUserRoleEntity userRole = new ATCUserRoleEntity { UserID = (userItem.Key as ATCUserEntity).UserID };
                    userRole.Delete();

                    foreach (CheckedListBoxItem roleItem in this.chklbcRole.CheckedItems)
                    {
                        userRole.RoleID = ((roleItem.Value as ListEntityItem).Key as ATCRoleEntity).RoleID;
                        userRole.CreateDate = DateTime.Now;
                        userRole.Save();
                    }
                }

                XtraMessageBox.Show("保存成功！", "系统提示", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (Exception ex)
            {
                XtraMessageBox.Show(ex.Message, "系统错误", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }

        private void btnQuery_Click(object sender, EventArgs e)
        {
            if (this.txtUserName.Text.Trim().Length > 0)
            {
                EntityCollection<ATCUserEntity> users = new EntityCollection<ATCUserEntity>();
                users.Fetch(ATCUserEntityFields.UserName % this.txtUserName.Text.Trim() | ATCUserEntityFields.UserSpell % this.txtUserName.Text.Trim());

                this.lbcUser.Items.Clear();
                foreach (ATCUserEntity u in users)
                {
                    this.lbcUser.Items.Add(new ListEntityItem(u, u.UserName));
                }
            }
            else
            {
                EntityCollection<ATCUserEntity> users = new EntityCollection<ATCUserEntity>();
                users.Fetch();

                this.lbcUser.Items.Clear();
                foreach (ATCUserEntity u in users)
                {
                    this.lbcUser.Items.Add(new ListEntityItem(u, u.UserName));
                }
            }
        }

        private void txtUserName_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)13)
            {
                this.btnQuery_Click(null, null);
            }
        }
    }
}