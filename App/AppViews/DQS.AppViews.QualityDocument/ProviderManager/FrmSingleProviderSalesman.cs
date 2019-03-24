using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using DevExpress.XtraEditors;
using DQS.Module.Entities;
using DQS.Common;
using DevExpress.XtraEditors.Controls;
using ORMSCore;
using DQS.Controls;
using DQS.AppViews.QualityDocument.EnterpriseManager;

namespace DQS.AppViews.QualityDocument.ProviderManager
{
    public partial class FrmSingleProviderSalesman : DevExpress.XtraEditors.XtraForm
    {
        private int? m_id;

        List<chkProduct> chkproducts = new List<chkProduct>();

        public FrmSingleProviderSalesman()
        {
            InitializeComponent();
        }

        private void FrmSingleProviderSalesman_Load(object sender, EventArgs e)
        {
            this.cbxSalesmanJob.InitSource();

            BindPhysicTypes();
            BindProductStyles();
            BindProducts();
            LoadchkProduct();

            if (this.Tag != null)
            {
                this.m_id = Convert.ToInt32(this.Tag);

                BFISalesmanEntity entity = new BFISalesmanEntity { SalesmanID = m_id.Value };
                entity.Fetch();

                this.ftPanel.SetEntity(entity);

                this.txtSalesmanCode.Enabled = false;

                this.CustomGetEntity(entity);

                EntityCollection<BFIPersonRangeEntity> ranges = new EntityCollection<BFIPersonRangeEntity>();
                ranges.Fetch(BFIPersonRangeEntityFields.PersonType == "客户"
                    & BFIPersonRangeEntityFields.PersonID == entity.SalesmanID
                    & BFIPersonRangeEntityFields.CheckType == "大类");

                if (ranges.Count > 0)
                {
                    this.chkBCType.UnCheckAll();//先全部清空

                    foreach (BFIPersonRangeEntity range in ranges)
                    {
                        foreach (CheckedListBoxItem item in this.chkBCType.Items)
                        {
                            SYSCategoryEntity category = (item.Value as ListEntityItem).Key as SYSCategoryEntity;

                            if (category.ItemName == range.CheckValue)
                            {
                                this.chkBCType.SelectedItem = item;
                                item.CheckState = CheckState.Checked;
                                break;
                            }
                        }
                    }
                }
                else
                {
                    this.chkBCType.SelectedIndex = 0;
                    this.chkBCType.UnCheckAll();
                }
                ranges.Fetch(BFIPersonRangeEntityFields.PersonType == "客户"
                    & BFIPersonRangeEntityFields.PersonID == entity.SalesmanID
                    & BFIPersonRangeEntityFields.CheckType == "明细");

                if (ranges.Count > 0)
                {
                    this.chkBCTypeDetail.UnCheckAll();//先全部清空

                    foreach (BFIPersonRangeEntity range in ranges)
                    {
                        foreach (CheckedListBoxItem item in this.chkBCTypeDetail.Items)
                        {
                            SYSCategoryEntity category = (item.Value as ListEntityItem).Key as SYSCategoryEntity;

                            if (category.ItemName == range.CheckValue)
                            {
                                this.chkBCTypeDetail.SelectedItem = item;
                                item.CheckState = CheckState.Checked;
                                break;
                            }
                        }
                    }
                }
                else
                {
                    this.chkBCTypeDetail.SelectedIndex = 0;
                    this.chkBCTypeDetail.UnCheckAll();
                }
                ranges.Fetch(BFIPersonRangeEntityFields.PersonType == "客户"
                    & BFIPersonRangeEntityFields.PersonID == entity.SalesmanID
                    & BFIPersonRangeEntityFields.CheckType == "产品");

                if (ranges.Count > 0)
                {
                    this.chkBCProduct.UnCheckAll();//先全部清空

                    foreach (BFIPersonRangeEntity range in ranges)
                    {
                        foreach (CheckedListBoxItem item in this.chkBCProduct.Items)
                        {

                            if (item.Value.ToString() == range.Remark)
                            {
                                this.chkBCProduct.SelectedItem = item;
                                item.CheckState = CheckState.Checked;
                                break;
                            }
                        }
                    }
                }
                else
                {
                    this.chkBCProduct.SelectedIndex = 0;
                    this.chkBCProduct.UnCheckAll();
                }
            }
            else
            {
                this.txtSalesmanCode.Text = "KHXSRY" + DateTime.Now.ToString("yyyyMMddHHmmss");
                this.txtSalesmanCode.Select(this.txtSalesmanCode.Text.Length, 0);
            }

        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            if (!this.ftPanel.ValidateIsNullFields()) return;

            BFISalesmanEntity entity = this.ftPanel.GetEntity() as BFISalesmanEntity;
            this.CustomSetEntity(entity);

            if (this.m_id != null)
            {
                entity.LastModifyDate = DateTime.Now;
                entity.LastModifyUserID = GlobalItem.g_CurrentUser.UserID;
                entity.Update();
                SaveProductStyles(m_id.Value);
            }
            else
            {
                if (entity.IsNew())
                {
                    entity.CreateDate = DateTime.Now;
                    entity.LastModifyDate = DateTime.Now;
                    entity.CreateUserID = GlobalItem.g_CurrentUser.UserID;
                    entity.LastModifyUserID = GlobalItem.g_CurrentUser.UserID;
                    entity.Save();
                    entity.Fetch();
                    SaveProductStyles(entity.SalesmanID);
                }
                else
                {
                    XtraMessageBox.Show("人员编号已存在。", "警告", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                    return;
                }
            }

            this.DialogResult = DialogResult.OK;
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        /// <summary>
        /// 非文本框取值
        /// </summary>
        /// <param name="entity">实体</param>
        protected virtual void CustomGetEntity(BFISalesmanEntity entity)
        {
            if (!entity.IsNullField("DealerID"))
            {
                this.txtPopupDealer.SetMemberValue(entity.DealerID);
            }

            if (!entity.IsNullField("Sex"))
            {
                this.rgpSex.EditValue = entity.Sex;
            }

            if (!entity.IsNullField("Birthday"))
            {
                this.dteBirthday.DateTime = entity.Birthday;
            }

            if (!entity.IsNullField("FinishSchoolDate"))
            {
                this.dteFinishSchoolDate.DateTime = entity.FinishSchoolDate;
            }

            if (!entity.IsNullField("SalesJobID"))
            {
                this.cbxSalesmanJob.SelectedValue = entity.SalesJobID;
            }
        }

        /// <summary>
        /// 非文本框赋值
        /// </summary>
        /// <param name="entity">实体</param>
        protected virtual void CustomSetEntity(BFISalesmanEntity entity)
        {
            if (this.txtPopupDealer.SelectedValue != null)
            {
                entity.DealerID = Convert.ToInt32(this.txtPopupDealer.SelectedValue);
                entity.DealerName = this.txtPopupDealer.Text.Trim();
                entity.DealerSpell = GlobalMethod.GetAlphabetic(entity.DealerName);
            }

            if (this.rgpSex.EditValue != null)
            {
                entity.Sex = this.rgpSex.EditValue.ToString();
            }

            if (this.dteBirthday.Text.Trim().Length > 0)
            {
                entity.Birthday = this.dteBirthday.DateTime;
            }

            if (this.dteFinishSchoolDate.Text.Trim().Length > 0)
            {
                entity.FinishSchoolDate = this.dteFinishSchoolDate.DateTime;
            }

            if (this.cbxSalesmanJob.SelectedValue != null)
            {
                entity.SalesJobID = Convert.ToInt32(this.cbxSalesmanJob.SelectedValue);
                entity.SalesJobName = this.cbxSalesmanJob.Text.Trim();
            }
        }

        private void BindPhysicTypes()
        {
            EntityCollection<SYSCategoryEntity> categories = new EntityCollection<SYSCategoryEntity>();
            categories.Fetch(SYSCategoryEntityFields.CategoryCode == "PhysicType");

            foreach (SYSCategoryEntity c in categories)
            {
                this.chkBCType.Items.Add(new ListEntityItem(c, c.ItemName));
            }
        }

        private void BindProductStyles()
        {
            EntityCollection<SYSCategoryEntity> categories = new EntityCollection<SYSCategoryEntity>();
            categories.Fetch(SYSCategoryEntityFields.CategoryCode == "ProductStyle");

            foreach (SYSCategoryEntity c in categories)
            {
                this.chkBCTypeDetail.Items.Add(new ListEntityItem(c, c.ItemName));
            }
        }

        private void BindProducts()
        {
            EntityCollection<BFIProductEntity> products = new EntityCollection<BFIProductEntity>();
            products.Fetch(BFIProductEntityFields.BusinessStatus != 0);

            foreach (BFIProductEntity c in products)
            {
                //this.chkBCProduct.Items.Add(new ListEntityItem(c, c.ProductCode + "-" + c.ProductName + "-" + c.ProductSpec + "-" + c.ProducerName));
                chkProduct chk = new chkProduct();
                chk.product = c.ProductCode + "-" + c.ProductName + "-" + c.ProductSpec + "-" + c.ProducerName;
                chk.ischeck = 0;
                chkproducts.Add(chk);
            }
        }

        private void SaveProductStyles(int personID)
        {

            BFIPersonRangeEntity range = new BFIPersonRangeEntity { PersonType = "客户", PersonID = personID };
            range.DeleteByCommonly();

            range.PersonType = "客户";
            range.PersonID = personID;
            range.CreateDate = DateTime.Now;
            range.LastModifyDate = DateTime.Now;
            range.CreateUserID = GlobalItem.g_CurrentUser.UserID;
            range.LastModifyUserID = GlobalItem.g_CurrentUser.UserID;
            foreach (CheckedListBoxItem productStyle in this.chkBCType.CheckedItems)
            {
                range.CheckType = "大类";
                range.CheckValue = productStyle.Value.ToString();
                range.Remark = "";
                range.Save();
            }
            foreach (CheckedListBoxItem productStyle in this.chkBCTypeDetail.CheckedItems)
            {
                range.CheckType = "明细";
                range.CheckValue = productStyle.Value.ToString();
                range.Remark = "";
                range.Save();
            }
            foreach (var item in chkproducts)
            {
                if (item.ischeck == 1)
                {
                    string productCode = item.product;
                    string[] sArray = productCode.Split('-');
                    range.CheckType = "产品";
                    range.CheckValue = sArray[0];
                    range.Remark = item.product;
                    range.Save();
                }
            }
        }

        private void checkTypeAll_CheckedChanged(object sender, EventArgs e)
        {
            if (checkTypeAll.Checked)
            {
                checkTypeAll.Text = "反选";
                this.chkBCType.CheckAll();
            }
            else
            {
                checkTypeAll.Text = "全选";
                this.chkBCType.UnCheckAll();
            }
        }

        private void checkTypeDetailAll_CheckedChanged(object sender, EventArgs e)
        {
            if (checkTypeDetailAll.Checked)
            {
                checkTypeDetailAll.Text = "反选";
                this.chkBCTypeDetail.CheckAll();
            }
            else
            {
                checkTypeDetailAll.Text = "全选";
                this.chkBCTypeDetail.UnCheckAll();
            }
        }

        private void checkProductAll_CheckedChanged(object sender, EventArgs e)
        {
            if (checkProductAll.Checked)
            {
                checkProductAll.Text = "反选";
                this.chkBCProduct.CheckAll();
                foreach (var item in chkproducts)
                {
                    if (item.product.Contains(txtqk.Text.Trim()))
                    {
                        item.ischeck = 1;
                    }
                }
            }
            else
            {
                checkProductAll.Text = "全选";
                this.chkBCProduct.UnCheckAll();
                foreach (var item in chkproducts)
                {
                    if (item.product.Contains(txtqk.Text.Trim()))
                    {
                        item.ischeck = 0;
                    }
                }
            }
        }

        private void btnGO_Click(object sender, EventArgs e)
        {
            chkBCProduct.Items.Clear();
            LoadchkProductDetail();
        }
        private void LoadchkProductDetail()
        {
            foreach (var item in chkproducts)
            {
                if (item.product.Contains(txtqk.Text.Trim()))
                {
                    chkBCProduct.Items.Add(item.product, item.ischeck == 1 ? true : false);
                }
            }
        }

        private void LoadchkProduct()
        {
            if (this.Tag != null)
            {
                this.m_id = Convert.ToInt32(this.Tag);
                BFISalesmanEntity entity = new BFISalesmanEntity { SalesmanID = m_id.Value };
                entity.Fetch();

                EntityCollection<BFIPersonRangeEntity> ranges = new EntityCollection<BFIPersonRangeEntity>();
                ranges.Fetch(BFIPersonRangeEntityFields.PersonType == "客户"
                    & BFIPersonRangeEntityFields.PersonID == entity.SalesmanID
                    & BFIPersonRangeEntityFields.CheckType == "产品");

                if (ranges.Count > 0)
                {
                    foreach (BFIPersonRangeEntity range in ranges)
                    {
                        foreach (var item in chkproducts)
                        {
                            if (item.product == range.Remark)
                            {
                                item.ischeck = 1;
                                break;
                            }
                        }
                    }
                }
                LoadchkProductDetail();
            }
            else
            {
                LoadchkProductDetail();
            }
        }

        private void chkBCProduct_Click(object sender, EventArgs e)
        {
            var item = (CheckedListBoxItem)chkBCProduct.SelectedItem;
            foreach (var product in chkproducts)
            {
                if (product.product == item.Value.ToString())
                {
                    product.ischeck = product.ischeck == 0 ? 1 : 0;
                }
            }
            foreach (CheckedListBoxItem chkitem in chkBCProduct.Items)
            {
                if (chkitem.Value.ToString() == item.Value.ToString())
                {
                    chkitem.CheckState = item.CheckState;
                    break;
                }
            }
        }
    }
}