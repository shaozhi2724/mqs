using System;
using System.Data;
using System.Windows.Forms;
using DevExpress.XtraEditors;
using DevExpress.XtraEditors.Controls;
using ORMSCore;
using DQS.Module.Entities;
using DQS.Controls;

namespace DQS.AppViews.QualityControl.AuthorityManager
{
    public partial class FrmApproveAuthority : DevExpress.XtraEditors.XtraForm
    {
        public FrmApproveAuthority()
        {
            InitializeComponent();
        }

        private void FrmApproveAuthority_Load(object sender, EventArgs e)
        {
            this.BindUser();

            this.BindDocument();

            this.ApprovalUser();
        }

        private void BindDocument()
        {
            EntityCollection<SYSDocumentEntity> documents = new EntityCollection<SYSDocumentEntity>();
            DataTable data = documents.FetchTable(SYSDocumentEntityFields.IsNeedApproval == true);

            data.DefaultView.Sort = "SortNumber";
            data = data.DefaultView.ToTable();

            foreach (DataRow row in data.Rows)
            {
                this.lbcDocument.Items.Add(new ListDataRowItem(row, row["DocumentName"].ToString()));
            }
        }

        private void BindUser()
        {
            EntityCollection<ATCUserEntity> users = new EntityCollection<ATCUserEntity>();
            if (string.IsNullOrEmpty(this.txtUserName.Text.Trim()))
            {
                users.Fetch();
            }
            else
            {
                users.Fetch(ATCUserEntityFields.UserName % this.txtUserName.Text.Trim() | ATCUserEntityFields.UserSpell % this.txtUserName.Text.Trim());
            }

            this.lbcUser.Items.Clear();
            foreach (ATCUserEntity u in users)
            {
                this.lbcUser.Items.Add(new ListEntityItem(u, u.UserName));
            }
        }

        private void ApprovalUser()
        {
            DataTable data = new DataTable();

            if (lbcUser.SelectedItem != null && lbcDocument.SelectedItem != null)
            {
                EntityCollection<ATCUserPageEntity> userPage = new EntityCollection<ATCUserPageEntity>();

                PredicateExpression pe = new PredicateExpression();
                pe.Add(ATCUserPageEntityFields.UserID == ((lbcUser.SelectedItem as ListEntityItem).Key as ATCUserEntity).UserID);
                pe.Add(ATCUserPageEntityFields.DocumentCode == (lbcDocument.SelectedItem as ListDataRowItem).Key["DocumentCode"].ToString());

                data = userPage.FetchTable(pe);
            }

            EntityCollection<ATCUserEntity> users = new EntityCollection<ATCUserEntity>();
            users.Fetch();

            this.chklbcApprovalUser.Items.Clear();
            foreach (ATCUserEntity u in users)
            {
                int index = this.chklbcApprovalUser.Items.Add(new ListEntityItem(u, u.UserName), u.UserName);

                if (data.Rows.Count > 0)//若存在对应关系
                {
                    this.rdgApproveStyle.SelectedIndex = Convert.ToInt32(data.Rows[0]["IsWhole"]);
                    
                    DataRow[] rows = data.Select(String.Format("ApprovalUserID = '{0}'", u.UserID));

                    if (rows.Length > 0)//若匹配
                    {
                        this.chklbcApprovalUser.Items[index].CheckState = CheckState.Checked;

                        if (this.rdgApproveStyle.SelectedIndex == 1)
                        {
                            //更改序号与数据库匹配
                            this.chklbcApprovalUser.Items[index].Description = "";
                            this.chklbcApprovalUser.Items[index].Description = String.Format("{0}\t\t审批顺序：{1}", u.UserName, rows[0]["ApprovalSort"]);
                        }
                    }
                }
            }
        }

        private void lbcUser_SelectedIndexChanged(object sender, EventArgs e)
        {
            this.ApprovalUser();
        }

        private void lbcDocument_SelectedIndexChanged(object sender, EventArgs e)
        {
            this.ApprovalUser();
        }

        private void chkCheck_CheckedChanged(object sender, EventArgs e)
        {
            if (chkCheck.Checked)
            {
                chkCheck.Text = "反选";
                foreach (CheckedListBoxItem item in this.chklbcApprovalUser.Items)
                {
                    item.CheckState = CheckState.Checked;
                }
            }
            else
            {
                chkCheck.Text = "全选";
                foreach (CheckedListBoxItem item in this.chklbcApprovalUser.Items)
                {
                    item.CheckState = CheckState.Unchecked;
                }
            }
        }

        private void btnSave_Click(object sender, EventArgs e)
        {

            try
            {
                if (lbcUser.SelectedItem == null)
                {
                    XtraMessageBox.Show("请选择发起人！", "系统提示", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                    return;
                }

                if (lbcDocument.SelectedItem == null)
                {
                    XtraMessageBox.Show("请选择要审批的单据！", "系统提示", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                    return;
                }

                if (chklbcApprovalUser.SelectedItem == null)
                {
                    XtraMessageBox.Show("请选择审批人！", "系统提示", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                    return;
                }

                ATCUserPageEntity userPage = new ATCUserPageEntity
                {
                    DocumentCode = ((lbcDocument.SelectedItem as ListDataRowItem).Key as DataRow)["DocumentCode"].ToString(),
                    IsWhole = rdgApproveStyle.SelectedIndex == 1
                };

                foreach (ListEntityItem item in lbcUser.SelectedItems)
                {
                    userPage.UserID = (item.Key as ATCUserEntity).UserID;

                    userPage.Delete();

                    foreach (CheckedListBoxItem functionItem in this.chklbcApprovalUser.CheckedItems)
                    {
                        userPage.ApprovalUserID = ((functionItem.Value as ListEntityItem).Key as ATCUserEntity).UserID;
                        userPage.ApprovalSort = this.GetApprovalSort(functionItem);
                        userPage.Save();
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
            this.BindUser();
        }

        private void txtUserName_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)13)
            {
                this.BindUser();
            }
        }

        private void rdgApproveStyle_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (rdgApproveStyle.SelectedIndex == 1)
            {
                //加序号
                int sign = 1;
                foreach (CheckedListBoxItem item in chklbcApprovalUser.Items)
                {
                    if (item.CheckState == CheckState.Checked)
                    {
                        item.Description = String.Format("{0}\t\t审批顺序：{1}", item.Value, sign);
                        sign++;
                    }
                }
            }
            else
            {
                //去序号
                foreach (CheckedListBoxItem item in chklbcApprovalUser.Items)
                {
                    item.Description = ((item.Value as ListEntityItem).Key as ATCUserEntity).UserName;
                }
            }
        }

        private void chklbcApprovalUser_ItemCheck(object sender, DevExpress.XtraEditors.Controls.ItemCheckEventArgs e)
        {
            CheckedListBoxItem item = chklbcApprovalUser.Items[e.Index];
            if (rdgApproveStyle.SelectedIndex == 1)
            {
                if (e.State == CheckState.Checked)
                {
                    item.Description = String.Format("{0}\t\t审批顺序：{1}", item.Value, chklbcApprovalUser.CheckedItems.Count);
                }
                else
                {
                    int currentSign = this.GetApprovalSort(item);
                    item.Description = ((item.Value as ListEntityItem).Key as ATCUserEntity).UserName;

                    //重新分配顺序
                    foreach (CheckedListBoxItem checkedItem in chklbcApprovalUser.Items)
                    {
                        if (checkedItem.CheckState == CheckState.Checked)
                        {
                            int sign = this.GetApprovalSort(checkedItem);
                            if (sign > currentSign)
                            {
                                checkedItem.Description = String.Format("{0}\t\t审批顺序：{1}", checkedItem.Value, sign - 1);
                            }

                        }
                    }
                }
            }
        }

        private int GetApprovalSort(CheckedListBoxItem item)
        {
            int startIndex = item.Description.IndexOf("审批顺序：");
            if (startIndex >= 0)
            {
                return int.Parse(item.Description.Substring(startIndex + 5, item.Description.Length - 5 - startIndex));
            }
            else
            {
                return 0;
            }
        }
    }
}