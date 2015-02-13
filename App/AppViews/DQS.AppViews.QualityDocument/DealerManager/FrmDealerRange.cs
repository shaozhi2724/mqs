using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using DevExpress.XtraEditors;
using DevExpress.XtraEditors.Controls;
using ORMSCore;
using DQS.Module.Entities;
using DQS.Controls;
using DQS.Common;

namespace DQS.AppViews.QualityDocument.DealerManager
{
    public partial class FrmDealerRange : DevExpress.XtraEditors.XtraForm
    {
        public FrmDealerRange()
        {
            InitializeComponent();
        }

        private void FrmDealerRange_Load(object sender, EventArgs e)
        {
            EntityCollection<BFIDealerEntity> dealers = new EntityCollection<BFIDealerEntity>();
            dealers.Fetch(BFIDealerEntityFields.DealerType == "供应商");

            foreach (BFIDealerEntity d in dealers)
            {
                this.lbcDealer.Items.Add(new ListEntityItem(d, d.DealerName));
            }

            EntityCollection<SYSCategoryEntity> categories = new EntityCollection<SYSCategoryEntity>();
            categories.Fetch(SYSCategoryEntityFields.CategoryCode == "ProductStyle");

            foreach (SYSCategoryEntity c in categories)
            {
                this.chklbcProductStyle.Items.Add(new ListEntityItem(c, c.ItemName));
            }

            if (lbcDealer.Items.Count > 0)
            {
                this.lbcDealer.SelectedIndex = 0;
                this.lbcDealer_SelectedIndexChanged(null, null);
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

        private void lbcDealer_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (lbcDealer.SelectedItem != null)
            {
                BFIDealerEntity selectDealer = (lbcDealer.SelectedItem as ListEntityItem).Key as BFIDealerEntity;

                EntityCollection<BFIBusinessRangeEntity> ranges = new EntityCollection<BFIBusinessRangeEntity>();
                ranges.Fetch(BFIBusinessRangeEntityFields.DealerID == selectDealer.DealerID);

                if (ranges.Count > 0)
                {
                    this.chklbcProductStyle.UnCheckAll();//先全部清空

                    foreach (BFIBusinessRangeEntity range in ranges)
                    {
                        foreach (CheckedListBoxItem item in this.chklbcProductStyle.Items)
                        {
                            SYSCategoryEntity category = (item.Value as ListEntityItem).Key as SYSCategoryEntity;

                            if (category.ItemID == range.ProductStyleID)
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
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            try
            {
                foreach (ListEntityItem dealerItem in this.lbcDealer.SelectedItems)
                {
                    BFIBusinessRangeEntity range = new BFIBusinessRangeEntity { DealerID = (dealerItem.Key as BFIDealerEntity).DealerID };
                    range.DeleteByCommonly();

                    foreach (CheckedListBoxItem productStyle in this.chklbcProductStyle.CheckedItems)
                    {
                        SYSCategoryEntity category = (productStyle.Value as ListEntityItem).Key as SYSCategoryEntity;
                        range.ProductStyleID = category.ItemID;
                        range.ProductStyleName = category.ItemName;
                        range.RangeStyle = 1;
                        range.RangeStyleName = "往来单位";
                        range.CreateDate = DateTime.Now;
                        range.LastModifyDate = DateTime.Now;
                        range.CreateUserID = GlobalItem.g_CurrentUser.UserID;
                        range.LastModifyUserID = GlobalItem.g_CurrentUser.UserID;
                        range.Save();
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
            if (this.txtDealerName.Text.Trim().Length > 0)
            {
                EntityCollection<BFIDealerEntity> dealers = new EntityCollection<BFIDealerEntity>();
                dealers.Fetch(BFIDealerEntityFields.DealerName % this.txtDealerName.Text.Trim() | BFIDealerEntityFields.DealerSpell % this.txtDealerName.Text.Trim());

                this.lbcDealer.Items.Clear();
                foreach (BFIDealerEntity d in dealers)
                {
                    this.lbcDealer.Items.Add(new ListEntityItem(d, d.DealerName));
                }
            }
            else
            {
                EntityCollection<BFIDealerEntity> dealers = new EntityCollection<BFIDealerEntity>();
                dealers.Fetch();

                this.lbcDealer.Items.Clear();
                foreach (BFIDealerEntity d in dealers)
                {
                    this.lbcDealer.Items.Add(new ListEntityItem(d, d.DealerName));
                }
            }
        }

        private void txtDealerName_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)13)
            {
                this.btnQuery_Click(null, null);
            }
        }
    }
}