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

namespace DQS.AppViews.QualityControl.AuthorityManager
{
    public partial class FrmBrowseAuthority : DevExpress.XtraEditors.XtraForm
    {

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

                foreach (ListEntityItem roleItem in this.lbcRole.SelectedItems)
                {
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
            catch (Exception ex)
            {
                XtraMessageBox.Show(ex.Message, "系统错误", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
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