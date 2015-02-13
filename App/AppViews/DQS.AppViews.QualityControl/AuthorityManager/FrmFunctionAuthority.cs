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
                    this.lbcPage.Items.Add(new ListDataRowItem(row, row["PageName"].ToString()));
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

                ATCRolePageEntity rolePage = new ATCRolePageEntity { RoleID = ((lbcRole.SelectedItem as ListEntityItem).Key as ATCRoleEntity).RoleID, PageCode = (lbcPage.SelectedItem as ListDataRowItem).Key["PageCode"].ToString() };

                rolePage.Delete();

                foreach (CheckedListBoxItem functionItem in this.chklbcFunction.CheckedItems)
                {
                    rolePage.FunctionCode = (functionItem.Value as ListDataRowItem).Key["FunctionCode"].ToString();
                    rolePage.Save();
                }

                XtraMessageBox.Show("保存成功！", "系统提示", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (Exception ex)
            {
                XtraMessageBox.Show(ex.Message, "系统错误", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
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