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

namespace DQS.AppViews.QualityDocument.EnterpriseManager
{
    public partial class FrmEnterpriseRange : DevExpress.XtraEditors.XtraForm
    {
        public FrmEnterpriseRange()
        {
            InitializeComponent();
        }

        private void FrmEnterpriseRange_Load(object sender, EventArgs e)
        {
            //EntityCollection<BFIEnterpriseEntity> enterprises = new EntityCollection<BFIEnterpriseEntity>();
            //enterprises.Fetch();

            //foreach (BFIEnterpriseEntity enterprise in enterprises)
            //{
            //    this.lbcEnterprise.Items.Add(new ListEntityItem(enterprise, enterprise.EnterpriseName));
            //}

            this.lbcEnterprise.Items.Add("本企业");

            //绑定经营品种
            EntityCollection<SYSCategoryEntity> categories = new EntityCollection<SYSCategoryEntity>();
            categories.Fetch(SYSCategoryEntityFields.CategoryCode == "ProductStyle");

            foreach (SYSCategoryEntity c in categories)
            {
                this.chklbcProductStyle.Items.Add(new ListEntityItem(c, c.ItemName));
            }

            //选中已有的经营品种
            EntityCollection<BFIBusinessRangeEntity> ranges = new EntityCollection<BFIBusinessRangeEntity>();
            ranges.Fetch(BFIBusinessRangeEntityFields.RangeStyle == 0);
            if (ranges.Count > 0)
            {
                this.chklbcProductStyle.UnCheckAll();//先全部清空

                foreach (BFIBusinessRangeEntity rang in ranges)
                {
                    foreach (CheckedListBoxItem item in this.chklbcProductStyle.Items)
                    {
                        SYSCategoryEntity category = (item.Value as ListEntityItem).Key as SYSCategoryEntity;

                        if (category.ItemID == rang.ProductStyleID)
                        {
                            this.chklbcProductStyle.SelectedItem = item;
                            item.CheckState = CheckState.Checked;
                            break;
                        }
                    }
                }
            }
            else
            {
                this.chklbcProductStyle.SelectedIndex = 0;
                this.chklbcProductStyle.UnCheckAll();
            }
        }

        private void chkCheck_CheckedChanged(object sender, EventArgs e)
        {
            if (chkCheck.Checked)
            {
                chkCheck.Text = "反选";
                this.chklbcProductStyle.CheckAll();
            }
            else
            {
                chkCheck.Text = "全选";
                this.chklbcProductStyle.UnCheckAll();
            }
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            try
            {
                if (chklbcProductStyle.CheckedItems.Count == 0)
                {
                    XtraMessageBox.Show("请选择经营范围。", "警告", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                    chklbcProductStyle.Focus();
                    return;
                }

                //先全部删除
                BFIBusinessRangeEntity range = new BFIBusinessRangeEntity { RangeStyle = 0 };
                range.DeleteByCommonly();

                //添加
                foreach (CheckedListBoxItem productStyle in this.chklbcProductStyle.CheckedItems)
                {
                    SYSCategoryEntity category = (productStyle.Value as ListEntityItem).Key as SYSCategoryEntity;
                    range.EnterpriseID = 1;
                    range.ProductStyleID = category.ItemID;
                    range.ProductStyleName = category.ItemName;
                    range.RangeStyle = 0;
                    range.RangeStyleName = "企业";
                    range.CreateDate = DateTime.Now;
                    range.LastModifyDate = DateTime.Now;
                    range.CreateUserID = GlobalItem.g_CurrentUser.UserID;
                    range.LastModifyUserID = GlobalItem.g_CurrentUser.UserID;
                    range.Save();
                }
                XtraMessageBox.Show("保存成功！", "系统提示", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (Exception ex)
            {
                XtraMessageBox.Show(ex.Message, "系统错误", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}