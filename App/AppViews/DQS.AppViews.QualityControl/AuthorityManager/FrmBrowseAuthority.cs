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
using DevExpress.XtraTreeList.Nodes;
using DQS.Controls;
using System.Data.SqlClient;
using DQS.Common;

namespace DQS.AppViews.QualityControl.AuthorityManager
{
    public partial class FrmBrowseAuthority : DevExpress.XtraEditors.XtraForm
    {

        List<string> rolemenus = new List<string>();
        public FrmBrowseAuthority()
        {
            InitializeComponent();
        }
        private void FrmBrowseAuthority_Load(object sender, EventArgs e)
        {
            this.BindRole();

            this.BindMenu();

            if (this.lbcRole.Items.Count > 0)
            {
                this.lbcRole_SelectedIndexChanged(null, null);
            }
        }

        //绑定角色到列表
        private void BindRole()
        {
            EntityCollection<ATCRoleEntity> roles = new EntityCollection<ATCRoleEntity>();
            if (string.IsNullOrEmpty(this.txtRole.Text.Trim()))
            {
                roles.Fetch();
            }
            else
            {
                roles.Fetch(ATCRoleEntityFields.RoleName % this.txtRole.Text.Trim() | ATCRoleEntityFields.RoleSpell % this.txtRole.Text.Trim());
            }

            this.lbcRole.Items.Clear();
            foreach (ATCRoleEntity r in roles)
            {
                this.lbcRole.Items.Add(new ListEntityItem(r, r.RoleName));
            }
        }

        //绑定菜单到TreeList
        private void BindMenu()
        {
            treeMenu.Nodes.Clear();
            treeMenu.DataSource = null;
            EntityCollection<SYSMenuEntity> menus = new EntityCollection<SYSMenuEntity>();

            PredicateExpression filter = new PredicateExpression();
            filter.Add(SYSMenuEntityFields.IsEnabled == 1);
            filter.Add(SYSMenuEntityFields.LevelNo < 4);

            DataTable data = menus.FetchTable(filter);
            string[] columnNames = new string[] { "MenuCode", "MenuName", "ParentCode" };
            data.DefaultView.Sort = "SortNumber";
            data = data.DefaultView.ToTable(true, columnNames);
/*

            //移除不需要的字段
            while (data.Columns.Count > 3)
            {
                if (data.Columns[0].ColumnName != "MenuCode")
                {
                    data.Columns.RemoveAt(0);
                }
                else if (data.Columns[1].ColumnName != "MenuName")
                {
                    data.Columns.RemoveAt(1);
                }
                else if (data.Columns[2].ColumnName != "ParentCode")
                {
                    data.Columns.RemoveAt(2);
                }
                else
                {
                    data.Columns.RemoveAt(3);
                }
            }
*/

            data.Columns["MenuName"].ColumnName = "菜单名称";
            treeMenu.BeginUpdate();
            this.treeMenu.DataSource = data;
            this.treeMenu.KeyFieldName = "MenuCode";
            this.treeMenu.ParentFieldName = "ParentCode";
            this.treeMenu.ExpandAll();
            treeMenu.EndUpdate();
        }

        //设置子节点的勾选状态
        private void SetCheckedChildNodes(TreeListNode node, CheckState check)
        {
            for (int i = 0; i < node.Nodes.Count; i++)
            {
                node.Nodes[i].CheckState = check;
                SetCheckedChildNodes(node.Nodes[i], check);
            }
        }

        //设置父节点的勾选状态
        private void SetCheckedParentNodes(TreeListNode node, CheckState check)
        {
            if (node.ParentNode != null)
            {
                bool b = false;
                CheckState state;
                for (int i = 0; i < node.ParentNode.Nodes.Count; i++)
                {
                    state = (CheckState)node.ParentNode.Nodes[i].CheckState;
                    if (!check.Equals(state))
                    {
                        b = !b;
                        break;
                    }
                }
                node.ParentNode.CheckState = b ? CheckState.Indeterminate : check;
                SetCheckedParentNodes(node.ParentNode, check);
            }
        }

        //选择所有
        private void CheckAll()
        {
            foreach (TreeListNode node in treeMenu.Nodes)
            {
                node.Checked = true;
                SetCheckedChildNodes(node, node.CheckState);
                SetCheckedParentNodes(node, node.CheckState);
                node.CheckState = CheckState.Indeterminate;
            }
        }

        //反选所有
        private void UnCheckAll()
        {
            foreach (TreeListNode node in treeMenu.Nodes)
            {
                node.Checked = false;
                SetCheckedChildNodes(node, node.CheckState);
                SetCheckedParentNodes(node, node.CheckState);
                node.CheckState = CheckState.Unchecked;
            }
        }

        //递归设置对应的菜单选中
        private void SetCheckedByMenuCode(TreeListNodes nodes, string munuCode)
        {
            foreach (TreeListNode n in nodes)
            {
                if (n.GetValue("MenuCode").ToString() == munuCode)
                {
                    n.Checked = true;
                    return;
                }
                else
                {
                    if (n.HasChildren)
                    {
                        this.SetCheckedByMenuCode(n.Nodes, munuCode);
                    }
                }
            }
        }

        //递归获取所有选择的节点的菜单编号
        private void GetCheckedMenuCode(TreeListNodes nodes, List<string> munus)
        {
            if (nodes.Count == 0)
            {
                return;
            }

            foreach (TreeListNode n in nodes)
            {
                if (n.CheckState != CheckState.Unchecked)
                {
                    string menuCode = n.GetValue("MenuCode").ToString();
                    munus.Add(menuCode);
                }

                if (n.HasChildren)
                {
                    this.GetCheckedMenuCode(n.Nodes, munus);
                }
            }
        }

        private void treeMenu_BeforeCheckNode(object sender, DevExpress.XtraTreeList.CheckNodeEventArgs e)
        {
            e.State = (e.PrevState == CheckState.Checked ? CheckState.Unchecked : CheckState.Checked);
        }

        private void treeMenu_AfterCheckNode(object sender, DevExpress.XtraTreeList.NodeEventArgs e)
        {
            SetCheckedChildNodes(e.Node, e.Node.CheckState);
            SetCheckedParentNodes(e.Node, e.Node.CheckState);
        }

        private void chkCheck_CheckedChanged(object sender, EventArgs e)
        {
            if (chkCheck.Checked)
            {
                chkCheck.Text = "反选";
                this.CheckAll();
            }
            else
            {
                chkCheck.Text = "全选";
                this.UnCheckAll();
            }
        }

        private void lbcRole_SelectedIndexChanged(object sender, EventArgs e)
        {
            rolemenus.Clear();
            if (lbcRole.SelectedItem != null)
            {
                ATCRoleEntity selectRole = (lbcRole.SelectedItem as ListEntityItem).Key as ATCRoleEntity;

                EntityCollection<ATCRoleMenuEntity> roleMenus = new EntityCollection<ATCRoleMenuEntity>();
                roleMenus.Fetch(ATCRoleMenuEntityFields.RoleID == selectRole.RoleID);

                if (roleMenus.Count > 0)
                {

                    this.UnCheckAll();

                    //重新选择
                    foreach (ATCRoleMenuEntity rm in roleMenus)
                    {
                        this.SetCheckedByMenuCode(this.treeMenu.Nodes, rm.MenuCode);
                        rolemenus.Add(rm.MenuCode);
                    }
                }
                else
                {
                    if (this.treeMenu.Nodes.Count > 0)
                    {
                        this.treeMenu.FocusedNode = this.treeMenu.Nodes[0];
                    }
                    this.UnCheckAll();
                }

            }
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            try
            {
                List<string> munus = new List<string>();

                this.GetCheckedMenuCode(this.treeMenu.Nodes, munus);

                if (GlobalItem.g_CurrentUser.UserCode == "admin")
                {
                    foreach (ListEntityItem roleItem in this.lbcRole.SelectedItems)
                    {
                        //(roleItem.Key as ATCRoleEntity).RoleID;
                        ATCRoleMenuEntity roleMenu = new ATCRoleMenuEntity { RoleID = (roleItem.Key as ATCRoleEntity).RoleID };
                        roleMenu.Delete();

                        foreach (string menuCode in munus)
                        {
                            roleMenu.MenuCode = menuCode;
                            roleMenu.CreateDate = DateTime.Now;
                            roleMenu.Save();
                        }
                    }

                    XtraMessageBox.Show("保存成功！", "系统提示", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    if (CheckList(munus, rolemenus))
                    {
                        MessageBox.Show("没有任何修改。");
                    }
                    else
                    {

                        EntityCollection<ATCUserPageEntity> userPages = new EntityCollection<ATCUserPageEntity>();
                        PredicateExpression pe = new PredicateExpression();
                        pe.Add(ATCUserPageEntityFields.UserID == GlobalItem.g_CurrentUser.UserID);
                        pe.Add(ATCUserPageEntityFields.DocumentCode == "BrowseAuthorityChange");
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
                                string sql = @"SELECT COUNT(0) num FROM dbo.ATC_BrowseAuthorityChange WHERE RoleID = '" + (roleItem.Key as ATCRoleEntity).RoleID + "' AND AppStatus = ''";

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
                                        string code = "LL" + DateTime.Now.ToString("yyyyMMddHHmmss");
                                        string insertsql = @"EXEC sp_InsertOldRoleMenuChange '{0}','{1}','{2}','{3}'";
                                        insertsql = string.Format(insertsql, code, (roleItem.Key as ATCRoleEntity).RoleID, (roleItem.Key as ATCRoleEntity).RoleName, GlobalItem.g_CurrentUser.UserName);
                                        comm = new SqlCommand(insertsql, conn);
                                        comm.ExecuteNonQuery();
                                        foreach (var item in munus)
                                        {
                                            string insertnewsql = @"EXEC sp_InsertNewRoleMenuChange '{0}','{1}'";
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
                                            approveEntity.DocumentCode = "BrowseAuthorityChange";
                                            approveEntity.BillCode = code;
                                            approveEntity.ApproveTitle = string.Format("{0}角色浏览权限变更，编号：{1}", (roleItem.Key as ATCRoleEntity).RoleName, code);
                                            approveEntity.ApprovalContent = String.Format("{0}角色浏览权限变更，编号：{1}", (roleItem.Key as ATCRoleEntity).RoleName, code);
                                            approveEntity.CreateUserID = GlobalItem.g_CurrentUser.UserID;
                                            approveEntity.CreateDate = DateTime.Now;
                                            approveEntity.IsApprovaled = false;


                                            //获得新建的ID号
                                            string searchsql = @"SELECT ID FROM ATC_BrowseAuthorityChange WHERE ChangeCode = '" + code + "'";
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
                                                notification.FormClass = "BrowseAuthorityChange";
                                                notification.IsRead = false;
                                                notification.TargetID = bgid;
                                                notification.TargetCode = code;
                                                notification.ApproveCode = approveCode;
                                                notification.Message = string.Format("{0} 于 {1} 浏览权限变更申请（单号 {2}）。请您审批。", userName,
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
            }
            catch (Exception ex)
            {
                XtraMessageBox.Show(ex.Message, "系统错误", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private bool CheckList(List<string> lista,List<string> listb)
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
            this.BindRole();
        }

        private void txtRole_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)13)
            {
                this.BindRole();
            }
        }
    }
}