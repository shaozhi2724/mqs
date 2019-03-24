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
using DQS.Common;
using System.Data.SqlClient;

namespace DQS.AppViews.QualityControl.UserManager
{
    public partial class FrmUserRole : DevExpress.XtraEditors.XtraForm
    {
        List<string> oldrole = new List<string>();
        List<string> newrole = new List<string>();
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
                oldrole.Clear();
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
                        ATCRoleEntity arole = new ATCRoleEntity { RoleID = ur.RoleID };
                        oldrole.Add(arole.RoleName);
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

                if (GlobalItem.g_CurrentUser.UserCode == "admin")
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
                else
                {
                    newrole.Clear();

                    foreach (CheckedListBoxItem roleItem in this.chklbcRole.CheckedItems)
                    {
                        newrole.Add(((roleItem.Value as ListEntityItem).Key as ATCRoleEntity).RoleName);
                    }
                    if (CheckList(oldrole, newrole))
                    {
                        MessageBox.Show("没有任何修改。");
                    }
                    else
                    {
                        EntityCollection<ATCUserPageEntity> userPages = new EntityCollection<ATCUserPageEntity>();
                        PredicateExpression pe = new PredicateExpression();
                        pe.Add(ATCUserPageEntityFields.UserID == GlobalItem.g_CurrentUser.UserID);
                        pe.Add(ATCUserPageEntityFields.DocumentCode == "UserRoleChange");
                        DataTable data = userPages.FetchTable(pe);

                        if (data.Rows.Count <= 0)
                        {
                            XtraMessageBox.Show("系统未设置您的审批流程，无法点击保存功能。", "警告", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                            return;
                        }

                        using (SqlConnection conn = new SqlConnection(GlobalItem.g_DbConnectStrings))
                        {
                            string userID = "";

                            foreach (ListEntityItem userItem in this.lbcUser.SelectedItems)
                            {
                                userID = (userItem.Key as ATCUserEntity).UserID.ToString();
                            }
                            string sql = @"SELECT COUNT(0) num FROM dbo.ATC_UserRoleChange WHERE AppStatus = '' AND UserID = '" + userID + "'";

                            try
                            {
                                conn.Open();
                                SqlCommand comm = new SqlCommand(sql, conn);
                                int num = int.Parse(comm.ExecuteScalar().ToString());
                                if (num > 0)
                                {
                                    MessageBox.Show("有申请变更未处理，请处理后操作。");
                                    return;
                                }
                                else
                                {
                                    string code = "YJ" + DateTime.Now.ToString("yyyyMMddHHmmss");
                                    foreach (ListEntityItem userItem in this.lbcUser.SelectedItems)
                                    {
                                        string insertsql = @"EXEC sp_InsertOldUserRoleChange '{0}','{1}','{2}','{3}'";
                                        insertsql = string.Format(insertsql, code,(userItem.Key as ATCUserEntity).UserID,(userItem.Key as ATCUserEntity).UserName, GlobalItem.g_CurrentUser.UserName);
                                        comm = new SqlCommand(insertsql, conn);
                                        comm.ExecuteNonQuery();
                                        foreach (CheckedListBoxItem productStyle in this.chklbcRole.CheckedItems)
                                        {
                                            ATCRoleEntity roles = (productStyle.Value as ListEntityItem).Key as ATCRoleEntity;
                                            string insertnewsql = @"EXEC sp_InsertNewUserRoleChange '{0}','{1}','{2}'";
                                            comm = new SqlCommand(string.Format(insertnewsql, code, (userItem.Key as ATCUserEntity).UserID, roles.RoleID), conn);
                                            comm.ExecuteNonQuery();
                                        }
                                    }

                                    if (data.Rows.Count > 0)
                                    {
                                        //按审批顺序排序
                                        data.DefaultView.Sort = "ApprovalSort";
                                        data = data.DefaultView.ToTable();

                                        ATCApproveEntity approveEntity = new ATCApproveEntity();
                                        approveEntity.InternalNo = code;
                                        approveEntity.DocumentCode = "UserRoleChange";
                                        approveEntity.BillCode = code;
                                        approveEntity.ApproveTitle = string.Format("用户角色变更，编号：{0}", code);
                                        approveEntity.ApprovalContent = String.Format("用户角色变更，编号：{0}", code);
                                        approveEntity.CreateUserID = GlobalItem.g_CurrentUser.UserID;
                                        approveEntity.CreateDate = DateTime.Now;
                                        approveEntity.IsApprovaled = false;


                                        //获得新建的ID号
                                        string searchsql = @"SELECT ID FROM ATC_UserRoleChange WHERE ChangeCode = '" + code + "'";
                                        comm = new SqlCommand(searchsql, conn);
                                        int bgid = int.Parse(comm.ExecuteScalar().ToString());

                                        for (int i = 0; i < data.Rows.Count; i++)
                                        {
                                            var approveCode = approveEntity.InternalNo + (i + 1).ToString("00");
                                            approveEntity.ApproveCode = approveCode;
                                            approveEntity.IsWhole = Convert.ToBoolean(data.Rows[i]["IsWhole"]);
                                            approveEntity.ApproveOrder = Convert.ToInt32(data.Rows[i]["ApprovalSort"]);
                                            var approvalUserId = new Guid(data.Rows[i]["ApprovalUserID"].ToString());
                                            approveEntity.ApprovalUserID = approvalUserId;
                                            approveEntity.Save();

                                            //添加消息提醒
                                            ATCApproveNotificationEntity notification = new ATCApproveNotificationEntity();
                                            notification.CreateUserID = approveEntity.CreateUserID;
                                            var userName = GlobalItem.g_CurrentEmployee == null
                                                ? GlobalItem.g_CurrentUser.UserName
                                                : GlobalItem.g_CurrentEmployee.EmployeeName;
                                            notification.CreateUserName = userName;
                                            notification.FormClass = "UserRoleChange";
                                            notification.IsRead = false;
                                            notification.TargetID = bgid;
                                            notification.TargetCode = code;
                                            notification.ApproveCode = approveCode;
                                            notification.Message = string.Format("{0} 于 {1} 用户角色变更申请（单号 {2}）。请您审批。", userName,
                                                DateTime.Now.ToString("yyyy-MM-dd HH:mm:ss"), code);
                                            notification.OwnerUserID = approvalUserId;
                                            notification.Save();
                                        }
                                    }

                                    MessageBox.Show("变更申请保存成功。");
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
            catch (Exception ex)
            {
                XtraMessageBox.Show(ex.Message, "系统错误", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }

        private bool CheckList(List<string> lista, List<string> listb)
        {
            bool isall = true;
            foreach (var item in lista)
            {
                if (!listb.Contains(item))
                {
                    isall = false;
                    return isall;
                }
            }
            foreach (var item in listb)
            {
                if (!lista.Contains(item))
                {
                    isall = false;
                    return isall;
                }
            }
            return isall;
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