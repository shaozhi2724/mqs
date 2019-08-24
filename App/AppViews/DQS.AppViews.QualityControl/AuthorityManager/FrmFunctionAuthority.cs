using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using DevExpress.XtraEditors;
using ORMSCore;
using DQS.Module.Entities;
using DevExpress.XtraEditors.Controls;
using DQS.Controls;
using DQS.Module;
using DQS.Common;
using DevExpress.XtraTreeList.Nodes;
using System.Linq;
using System.Data.SqlClient;

namespace DQS.AppViews.QualityControl.AuthorityManager
{
    public partial class FrmFunctionAuthority : DevExpress.XtraEditors.XtraForm
    {
        public FrmFunctionAuthority()
        {
            InitializeComponent();
        }

        private void FrmFunctionAuthority_Load(object sender, EventArgs e)
        {
            this.BindRole();
        }

        private void BindRole()
        {
            EntityCollection<ATCRoleEntity> roles = new EntityCollection<ATCRoleEntity>();
            if (string.IsNullOrEmpty(this.txtRoleName.Text.Trim()))
            {
                roles.Fetch();
            }
            else
            {
                roles.Fetch(ATCRoleEntityFields.RoleName % this.txtRoleName.Text.Trim() | ATCRoleEntityFields.RoleSpell % this.txtRoleName.Text.Trim());
            }

            this.lbcRole.Items.Clear();
            foreach (ATCRoleEntity r in roles)
            {
                this.lbcRole.Items.Add(new ListEntityItem(r, r.RoleName));
            }
        }

        private void BindPage(ATCRoleEntity role)
        {
            EntityCollection<SYSPageEntity> pages = new EntityCollection<SYSPageEntity>();

            PrefetchRelation pRelation = new PrefetchRelation();
            pRelation.Add(RelationType.SYS_Menu_Parent_SYS_Page);
            pRelation.Add(RelationType.ATC_RoleMenu_Parent_SYS_Menu);

            PredicateExpression pe = new PredicateExpression();
            pe.Add(ATCRoleMenuEntityFields.RoleID == role.RoleID);

            if (!string.IsNullOrEmpty(this.txtPageName.Text.Trim()))
            {
                pe.Add(SYSPageEntityFields.PageName % this.txtPageName.Text.Trim());
            }

            DataTable data = pages.FetchTable(pe, pRelation);
            this.lbcPage.Items.Clear();

            if (data.Rows.Count > 0)
            {
                data.DefaultView.Sort = "SortNumber";
                data = data.DefaultView.ToTable();

                foreach (DataRow row in data.Rows)
                {
                    this.lbcPage.Items.Add(new ListDataRowItem(row, " "+row["PageName"].ToString()));
                }
            }
        }

        private void BindFunction(string pageCode)
        {
            EntityCollection<SYSFunctionEntity> functions = new EntityCollection<SYSFunctionEntity>();

            DataTable functionData = functions.FetchTable(SYSPageFunctionEntityFields.PageCode == pageCode, RelationType.SYS_PageFunction_Parent_SYS_Function);
            this.chklbcFunction.Items.Clear();


            this.chkCheck.Checked = false;
            this.chkCheck.Text = "全选";

            if (functionData.Rows.Count > 0)
            {
                functionData.DefaultView.Sort = "FunctionSort";
                functionData = functionData.DefaultView.ToTable();

                //获取功能对应关系，使已有的功能处于选中状态
                EntityCollection<ATCRolePageEntity> rolePage = new EntityCollection<ATCRolePageEntity>();
                PredicateExpression pe = new PredicateExpression();
                pe.Add(ATCRolePageEntityFields.RoleID == ((lbcRole.SelectedItem as ListEntityItem).Key as ATCRoleEntity).RoleID);
                pe.Add(ATCRolePageEntityFields.PageCode == pageCode);
                DataTable data = rolePage.FetchTable(pe);

                foreach (DataRow row in functionData.Rows)
                {
                    string functionCode = row["FunctionCode"].ToString();
                    int index = this.chklbcFunction.Items.Add(new ListDataRowItem(row, row["FunctionName"].ToString().Trim()));

                    if (data.Rows.Count > 0)//若存在对应关系
                    {
                        DataRow[] rows = data.Select(String.Format("FunctionCode = '{0}'", functionCode));
                        if (rows.Length > 0)//若匹配
                        {
                            this.chklbcFunction.Items[index].CheckState = CheckState.Checked;
                        }
                    }

                }
            }
        }

        private void lbcRole_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (lbcRole.SelectedItem != null)
            {
                ATCRoleEntity selectRole = (lbcRole.SelectedItem as ListEntityItem).Key as ATCRoleEntity;

                this.BindPage(selectRole);
            }
            else
            {
                this.lbcPage.Items.Clear();
            }
        }

        private void lbcPage_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (lbcPage.SelectedItem != null)
            {
                DataRow selectPage = (lbcPage.SelectedItem as ListDataRowItem).Key;

                this.BindFunction(selectPage["PageCode"].ToString());
            }
            else
            {
                this.chklbcFunction.Items.Clear();
            }
        }

        private void chkCheck_CheckedChanged(object sender, EventArgs e)
        {
            if (chkCheck.Checked)
            {
                chkCheck.Text = "反选";
                foreach (CheckedListBoxItem item in this.chklbcFunction.Items)
                {
                    item.CheckState = CheckState.Checked;
                }
            }
            else
            {
                chkCheck.Text = "全选";
                foreach (CheckedListBoxItem item in this.chklbcFunction.Items)
                {
                    item.CheckState = CheckState.Unchecked;
                }
            }
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            try
            {
                if (lbcRole.SelectedItem == null)
                {
                    XtraMessageBox.Show("请选择角色！", "系统提示", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                    return;
                }

                if (lbcPage.SelectedItem == null)
                {
                    XtraMessageBox.Show("请选择页面！", "系统提示", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                    return;
                }

                if (chklbcFunction.SelectedItem == null)
                {
                    XtraMessageBox.Show("请选择功能！", "系统提示", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                    return;
                }
                // 如果是admin,直接保存,不生成审批记录
                if (GlobalItem.g_CurrentUser.UserCode == "admin")
                {
                    ATCRolePageEntity rolePage = new ATCRolePageEntity { RoleID = ((lbcRole.SelectedItem as ListEntityItem).Key as ATCRoleEntity).RoleID, PageCode = (lbcPage.SelectedItem as ListDataRowItem).Key["PageCode"].ToString() };

                    rolePage.Delete();

                    foreach (CheckedListBoxItem functionItem in this.chklbcFunction.CheckedItems)
                    {
                        rolePage.FunctionCode = (functionItem.Value as ListDataRowItem).Key["FunctionCode"].ToString();
                        rolePage.Save();
                    }

                    XtraMessageBox.Show("保存成功！", "系统提示", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    //获取原有的功能列表
                    EntityCollection<ATCRolePageEntity> rolefuns = new EntityCollection<ATCRolePageEntity>();
                    rolefuns.Fetch(ATCRolePageEntityFields.RoleID == ((lbcRole.SelectedItem as ListEntityItem).Key as ATCRoleEntity).RoleID);
                    rolefuns.Fetch(ATCRolePageEntityFields.PageCode == (lbcPage.SelectedItem as ListDataRowItem).Key["PageCode"].ToString());
                    List<string> funstrs =
                        rolefuns.Cast<ATCRolePageEntity>().ToList().Select(p => p.FunctionCode).ToList();
                    //选中的list
                    List<string> nowfunstrs = new List<string>();
                    foreach (CheckedListBoxItem functionItem in this.chklbcFunction.CheckedItems)
                    {
                        nowfunstrs.Add((functionItem.Value as ListDataRowItem).Key["FunctionCode"].ToString());
                    }
                    //判断是否有改动
                    if (CheckList(funstrs, nowfunstrs))
                    {

                        XtraMessageBox.Show("没有任何修改！", "系统提示", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                    else
                    {
                        EntityCollection<ATCUserPageEntity> userPages = new EntityCollection<ATCUserPageEntity>();
                        PredicateExpression pe = new PredicateExpression();
                        pe.Add(ATCUserPageEntityFields.UserID == GlobalItem.g_CurrentUser.UserID);
                        pe.Add(ATCUserPageEntityFields.DocumentCode == "FunctionAuthorityChange");
                        DataTable data = userPages.FetchTable(pe);

                        if (data.Rows.Count <= 0)
                        {
                            XtraMessageBox.Show("系统未设置您的审批流程，无法点击保存功能。", "警告", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                            return;
                        }
                        foreach (ListEntityItem roleItem in this.lbcRole.SelectedItems)
                        {

                            using (SqlConnection conn = new SqlConnection(GlobalItem.g_DbConnectStrings))
                            {
                                string sql = @"SELECT COUNT(0) num FROM dbo.ATC_FunctionAuthorityChange WHERE RoleID = '" + ((lbcRole.SelectedItem as ListEntityItem).Key as ATCRoleEntity).RoleID + "' AND PageCode = '" + (lbcPage.SelectedItem as ListDataRowItem).Key["PageCode"].ToString() + "' AND AppStatus = ''";

                                try
                                {
                                    conn.Open();
                                    SqlCommand comm = new SqlCommand(sql, conn);
                                    int num = int.Parse(comm.ExecuteScalar().ToString());
                                    if (num > 0)
                                    {
                                        XtraMessageBox.Show("有申请变更未处理，请处理后操作！", "系统提示", MessageBoxButtons.OK, MessageBoxIcon.Information);
                                        return;
                                    }
                                    else
                                    {
                                        string code = "GN" + DateTime.Now.ToString("yyyyMMddHHmmss");
                                        string insertsql = @"EXEC sp_InsertOldRolePageFunctionChange '{0}','{1}','{2}','{3}'";
                                        insertsql = string.Format(insertsql, code, ((lbcRole.SelectedItem as ListEntityItem).Key as ATCRoleEntity).RoleID, (lbcPage.SelectedItem as ListDataRowItem).Key["PageCode"].ToString(), GlobalItem.g_CurrentUser.UserName);
                                        comm = new SqlCommand(insertsql, conn);
                                        comm.ExecuteNonQuery();
                                        foreach (var item in nowfunstrs)
                                        {
                                            string insertnewsql = @"EXEC sp_InsertNewRolePageFunctionChange '{0}','{1}'";
                                            comm = new SqlCommand(string.Format(insertnewsql, code, item), conn);
                                            comm.ExecuteNonQuery();
                                        }

                                        if (data.Rows.Count > 0)
                                        {
                                            //按审批顺序排序
                                            data.DefaultView.Sort = "ApprovalSort";
                                            data = data.DefaultView.ToTable();

                                            ATCApproveEntity approveEntity = new ATCApproveEntity();
                                            approveEntity.InternalNo = code;
                                            approveEntity.DocumentCode = "FunctionAuthorityChange";
                                            approveEntity.BillCode = code;
                                            approveEntity.ApproveTitle = string.Format("{0}角色功能权限变更，编号：{1}", (roleItem.Key as ATCRoleEntity).RoleName, code);
                                            approveEntity.ApprovalContent = String.Format("{0}角色功能权限变更，编号：{1}", (roleItem.Key as ATCRoleEntity).RoleName, code);
                                            approveEntity.CreateUserID = GlobalItem.g_CurrentUser.UserID;
                                            approveEntity.CreateDate = DateTime.Now;
                                            approveEntity.IsApprovaled = false;


                                            //获得新建的ID号
                                            string searchsql = @"SELECT ID FROM ATC_FunctionAuthorityChange WHERE ChangeCode = '" + code + "'";
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
                                                notification.FormClass = "FunctionAuthorityChange";
                                                notification.IsRead = false;
                                                notification.TargetID = bgid;
                                                notification.TargetCode = code;
                                                notification.ApproveCode = approveCode;
                                                notification.Message = string.Format("{0} 于 {1} 功能权限变更申请（单号 {2}）。请您审批。", userName,
                                                    DateTime.Now.ToString("yyyy-MM-dd HH:mm:ss"), code);
                                                notification.OwnerUserID = approvalUserId;
                                                notification.Save();
                                            }
                                        }

                                        XtraMessageBox.Show("变更申请保存成功！", "系统提示", MessageBoxButtons.OK, MessageBoxIcon.Information);
                                    }
                                }
                                catch (Exception ex)
                                {
                                    XtraMessageBox.Show(ex.ToString(), "系统提示", MessageBoxButtons.OK, MessageBoxIcon.Information);
                                }
                                finally
                                {
                                    conn.Close();
                                }
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

        private void btnRoleQuery_Click(object sender, EventArgs e)
        {
            this.BindRole();
        }

        private void btnPageQuery_Click(object sender, EventArgs e)
        {
            if (lbcRole.SelectedItem != null)
            {
                ATCRoleEntity selectRole = (lbcRole.SelectedItem as ListEntityItem).Key as ATCRoleEntity;

                this.BindPage(selectRole);
            }
            else
            {
                this.lbcPage.Items.Clear();
            }
        }

        private void txtRoleName_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)13)
            {
                this.btnRoleQuery_Click(null, null);
            }
        }

        private void txtPageName_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)13)
            {
                this.btnPageQuery_Click(null, null);
            }
        }

    }
}