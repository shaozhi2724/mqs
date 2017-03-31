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
using DQS.Common;
using DQS.Controls;
using DevExpress.XtraEditors.Controls;

namespace DQS.AppViews.QualityDocument.EnterpriseManager
{
    public partial class FrmSingleEmployee : DevExpress.XtraEditors.XtraForm
    {
        private int? m_id;

        List<chkProduct> chkproducts = new List<chkProduct>();

        public FrmSingleEmployee()
        {
            InitializeComponent();
        }

        private void FrmSingleEmployee_Load(object sender, EventArgs e)
        {
            this.cbxDepartment.InitSource();
            this.cbxPostName.InitSource();

            BindPhysicTypes();
            BindProductStyles();
            BindProducts();
            LoadchkProduct();

            if (this.Tag != null)
            {
                this.m_id = Convert.ToInt32(this.Tag);

                BFIEmployeeEntity entity = new BFIEmployeeEntity { EmployeeID = m_id.Value };
                entity.Fetch();

                this.ftPanel.SetEntity(entity);

                this.txtEmployeeCode.Enabled = false;

                this.CustomGetEntity(entity);

                EntityCollection<BFIPersonRangeEntity> ranges = new EntityCollection<BFIPersonRangeEntity>();
                ranges.Fetch(BFIPersonRangeEntityFields.PersonType == "员工" 
                    & BFIPersonRangeEntityFields.PersonID == entity.EmployeeID
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
                ranges.Fetch(BFIPersonRangeEntityFields.PersonType == "员工" 
                    & BFIPersonRangeEntityFields.PersonID == entity.EmployeeID
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
                /*
                ranges.Fetch(BFIPersonRangeEntityFields.PersonType == "员工"
                    & BFIPersonRangeEntityFields.PersonID == entity.EmployeeID
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
                */
            }
        }

        private void LoadchkProduct()
        {
            if (this.Tag != null)
            {
                this.m_id = Convert.ToInt32(this.Tag);
                BFIEmployeeEntity entity = new BFIEmployeeEntity { EmployeeID = m_id.Value };
                entity.Fetch();

                EntityCollection<BFIPersonRangeEntity> ranges = new EntityCollection<BFIPersonRangeEntity>();
                ranges.Fetch(BFIPersonRangeEntityFields.PersonType == "员工"
                    & BFIPersonRangeEntityFields.PersonID == entity.EmployeeID
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

        private void btnSave_Click(object sender, EventArgs e)
        {
            if (!this.ftPanel.ValidateIsNullFields()) return;

            BFIEmployeeEntity entity = this.ftPanel.GetEntity() as BFIEmployeeEntity;

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
                    SaveProductStyles(entity.EmployeeID);
                }
                else
                {
                    XtraMessageBox.Show("员工编号已存在。", "警告", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
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
        protected virtual void CustomGetEntity(BFIEmployeeEntity entity)
        {
            rgpSex.SelectedIndex = entity.Sex.Trim() == "男" ? 0 : 1;

            if (!entity.IsNullField("Birthday"))
            {
                dteBirthday.DateTime = entity.Birthday;
            }

            if (!entity.IsNullField("EntryDate"))
            {
                dteEntryDate.DateTime = entity.EntryDate;
            }

            if (!entity.IsNullField("FinishSchoolDate"))
            {
                dteFinishSchoolDate.DateTime = entity.FinishSchoolDate;
            }

            if (!entity.IsNullField("DepartmentID"))
            {
                this.cbxDepartment.SelectedValue = entity.DepartmentID;
            }

            if (!entity.IsNullField("MaritalStatus"))
            {
                this.cbxMaritalStatus.Text = entity.MaritalStatus;
            }

            if (!entity.IsNullField("PostName"))
            {
                this.cbxPostName.Text = entity.PostName;
            }
        }

        /// <summary>
        /// 非文本框赋值
        /// </summary>
        /// <param name="entity">实体</param>
        protected virtual void CustomSetEntity(BFIEmployeeEntity entity)
        {
            entity.Sex = rgpSex.Text;

            if (!string.IsNullOrEmpty(dteBirthday.Text.Trim()))
            {
                entity.Birthday = dteBirthday.DateTime;
            }

            if (!string.IsNullOrEmpty(dteEntryDate.Text.Trim()))
            {
                entity.EntryDate = dteEntryDate.DateTime;
            }

            if (!string.IsNullOrEmpty(dteFinishSchoolDate.Text.Trim()))
            {
                entity.FinishSchoolDate = dteFinishSchoolDate.DateTime;
            }

            if (this.cbxDepartment.SelectedValue != null)
            {
                entity.DepartmentID = Convert.ToInt32(this.cbxDepartment.SelectedValue);
            }

            if (this.cbxPostName.SelectedValue != null)
            {
                entity.PostName = this.cbxPostName.Text;
            }

            entity.MaritalStatus = this.cbxMaritalStatus.Text.Trim();
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
                chkProduct chk = new chkProduct();
                chk.product = c.ProductCode + "-" + c.ProductName + "-" + c.ProductSpec + "-" + c.ProducerName;
                chk.ischeck = 0;
                chkproducts.Add(chk);
            }
        }

        private void SaveProductStyles(int personID)
        {

            BFIPersonRangeEntity range = new BFIPersonRangeEntity { PersonType = "员工", PersonID = personID };
            range.DeleteByCommonly();

            range.PersonType = "员工";
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
    public class chkProduct
    {
        public string product { get; set; }
        public int ischeck { get; set; }
    }
}