using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using DevExpress.Utils;
using DevExpress.XtraEditors;
using DevExpress.XtraEditors.Controls;
using DQS.Controls;
using DQS.Module.Entities;
using ORMSCore;
using DQS.Common;
using System.Data.SqlClient;

namespace DQS.AppViews.QualityDocument.DealerManager
{
    public partial class FrmSingleFirstDealer : DevExpress.XtraEditors.XtraForm
    {
        private int? m_id;



        public FrmSingleFirstDealer()
        {
            InitializeComponent();
        }

        private void FrmSingleFirstDealer_Load(object sender, EventArgs e)
        {
            //this.cbxDealerType.InitSource();
            this.cbxDealerType.Text = "供应商";
            this.cbxDealerType.Enabled = false;
            this.cbxDealerStyle.InitSource();
            //供应商只能是生产厂商和批发
            cbxIndustryStyle.InitSource(SYSCategoryEntityFields.ItemID <= 2);

            BindProductStyles();

            BindPrices();

            if (this.Tag != null)
            {
                this.m_id = Convert.ToInt32(this.Tag);

                BFIDealerEntity entity = new BFIDealerEntity { DealerID = m_id.Value };
                entity.Fetch();
            /*
                EntityCollection<BFIBusinessRangeEntity> ranges = new EntityCollection<BFIBusinessRangeEntity>();
                ranges.Fetch(BFIBusinessRangeEntityFields.DealerID == entity.DealerID);

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
             */
                this.ftPanel.SetEntity(entity);

                this.txtDealerCode.Enabled = false;

                this.CustomGetEntity(entity);

                if (entity.BusinessStatus != 0)
                {
                    btnSave.Enabled = false;
                }
                EntityCollection<ATCApproveEntity> approveEntities = new EntityCollection<ATCApproveEntity>();
                PredicateExpression pe = new PredicateExpression();
                pe.Add(ATCApproveEntityFields.DocumentCode == "FirstDealer");
                pe.Add(ATCApproveEntityFields.BillCode == entity.DealerCode);
                pe.Add(ATCApproveEntityFields.IsApprovaled == 1);
                approveEntities.Fetch(pe);
                if (approveEntities.Count > 0)
                {
                    btnSave.Enabled = false;
                }
            }
            else
            {
                cbxPrice.EditValue = 1;
            }

            RenderRequiredFields();
        }

        private void BindPrices()
        {
            EntityCollection<BFIPriceListEntity> prices = new EntityCollection<BFIPriceListEntity>();
            prices.Fetch(BFIPriceListEntityFields.PriceListType == "采购价格表" & BFIPriceListEntityFields.Active == true);
            if(prices.Count < 7)
            {
                cbxPrice.Properties.DropDownRows = prices.Count;
            }
            cbxPrice.Properties.DataSource = prices;

        }
        private void RenderRequiredFields()
        {
            foreach (Control control in layControl.Controls)
            {
                if (control is TextBoxEx)
                {
                    TextBoxEx ctl = ((TextBoxEx) control);
                    if (ctl.IsNullValidate)
                    {
                        layControl.GetItemByControl(ctl).AppearanceItemCaption.ForeColor = Color.Red;
                    }
                }
                if (control is ComboBoxEdit)
                {
                    var ctl = ((ComboBoxEdit) control);
                    if (ctl.Properties.AllowNullInput == DefaultBoolean.False)
                    {
                        layControl.GetItemByControl(ctl).AppearanceItemCaption.ForeColor = Color.Red;
                    }
                }
            }
        }

        private void BindProductStyles()
        {
            //EntityCollection<SYSCategoryEntity> categories = new EntityCollection<SYSCategoryEntity>();
            //categories.Fetch(SYSCategoryEntityFields.CategoryCode == "ProductStyle");

            //foreach (SYSCategoryEntity c in categories)
            //{
            //    this.chklbcProductStyle.Items.Add(new ListEntityItem(c, c.ItemName));
            //}

            chklbcProductStyle.Items.Clear();
            if (cbxIndustryStyle.Text == "生产厂商")
            {
                layBusinessRange.Text = "生产范围";
                layBusinessRange.CustomizationFormText = "生产范围";
                if (DQS.Controls.Properties.Settings.Default.IsControlDealerAsProductPhy)
                {
                    gpcRight.Text = "产品剂型清单";
                    EntityCollection<SYSCategoryEntity> categories = new EntityCollection<SYSCategoryEntity>();
                    categories.Fetch(SYSCategoryEntityFields.CategoryCode == "PhysicType");

                    foreach (SYSCategoryEntity c in categories)
                    {
                        this.chklbcProductStyle.Items.Add(new ListEntityItem(c, c.ItemName));
                    }
                }
                else
                {
                    gpcRight.Text = "产品类别清单";
                    EntityCollection<SYSCategoryEntity> categories = new EntityCollection<SYSCategoryEntity>();
                    categories.Fetch(SYSCategoryEntityFields.CategoryCode == "ProductStyle");

                    foreach (SYSCategoryEntity c in categories)
                    {
                        this.chklbcProductStyle.Items.Add(new ListEntityItem(c, c.ItemName));
                    }
                }
            }
            else
            {

                layBusinessRange.Text = "经营范围";
                layBusinessRange.CustomizationFormText = "经营范围";
                gpcRight.Text = "产品类别清单";
                EntityCollection<SYSCategoryEntity> categories = new EntityCollection<SYSCategoryEntity>();
                categories.Fetch(SYSCategoryEntityFields.CategoryCode == "ProductStyle");

                foreach (SYSCategoryEntity c in categories)
                {
                    this.chklbcProductStyle.Items.Add(new ListEntityItem(c, c.ItemName));
                }
            }

            if (null != m_id)
            {
                EntityCollection<BFIBusinessRangeEntity> ranges = new EntityCollection<BFIBusinessRangeEntity>();
                ranges.Fetch(BFIBusinessRangeEntityFields.DealerID == m_id.Value);

                if (ranges.Count > 0)
                {
                    this.chklbcProductStyle.UnCheckAll();//先全部清空

                    foreach (BFIBusinessRangeEntity range in ranges)
                    {
                        foreach (CheckedListBoxItem item in this.chklbcProductStyle.Items)
                        {
                            SYSCategoryEntity category = (item.Value as ListEntityItem).Key as SYSCategoryEntity;

                            if (category.ItemName == range.ProductStyleName)
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
            if (!this.ftPanel.ValidateIsNullFields()) return;
            //if (null == cbxDealerStyle.SelectedValue)
            //{
            //    XtraMessageBox.Show(cbxDealerStyle.Properties.NullValuePrompt, "警告", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            //    cbxDealerStyle.Focus();
            //    return;
            //}
            if (null == cbxIndustryStyle.SelectedItem)
            {
                XtraMessageBox.Show(cbxIndustryStyle.Properties.NullValuePrompt, "警告", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                cbxIndustryStyle.Focus();
                return;
            }
            if (chklbcProductStyle.CheckedItems.Count == 0)
            {
                XtraMessageBox.Show(string.Format("请选择{0}。", layBusinessRange.CustomizationFormText), "警告", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                chklbcProductStyle.Focus();
                return;
            }
            BFIDealerEntity entity = this.ftPanel.GetEntity() as BFIDealerEntity;
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
                    EntityCollection<ATCUserPageEntity> userPages = new EntityCollection<ATCUserPageEntity>();
                    PredicateExpression pe = new PredicateExpression();
                    pe.Add(ATCUserPageEntityFields.UserID == GlobalItem.g_CurrentUser.UserID);
                    pe.Add(ATCUserPageEntityFields.DocumentCode == "FirstDealer");
                    DataTable data = userPages.FetchTable(pe);

                    if (data.Rows.Count <= 0)
                    {
                        XtraMessageBox.Show("系统未设置您的审批流程，无法创建首营往来单位。", "警告", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                        return;
                    }


                    //按审批顺序排序
                    data.DefaultView.Sort = "ApprovalSort";
                    data = data.DefaultView.ToTable();

                    ATCApproveEntity approveEntity = new ATCApproveEntity();
                    approveEntity.InternalNo = "SYYP" + DateTime.Now.ToString("yyyyMMddHHmmss");
                    approveEntity.DocumentCode = "FirstDealer";
                    approveEntity.BillCode = entity.DealerCode;
                    approveEntity.ApproveTitle = "首营往来单位，编号：" + entity.DealerCode;
                    approveEntity.ApprovalContent = String.Format("首营往来单位 {0} 申请审批。", entity.DealerName);
                    approveEntity.CreateUserID = GlobalItem.g_CurrentUser.UserID;
                    approveEntity.CreateDate = DateTime.Now;
                    approveEntity.IsApprovaled = false;

                    entity.CreateDate = DateTime.Now;
                    entity.LastModifyDate = DateTime.Now;
                    entity.CreateUserID = GlobalItem.g_CurrentUser.UserID;
                    entity.LastModifyUserID = GlobalItem.g_CurrentUser.UserID;
                    entity.Save();
                    entity.Fetch();
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
                        notification.FormClass = "FirstDealer";
                        notification.IsRead = false;
                        notification.TargetID = entity.DealerID;
                        notification.TargetCode = entity.DealerCode;
                        notification.ApproveCode = approveCode;
                        notification.Message = string.Format("{0} 于 {1} 申请首营往来单位（名称 {2}）。请您审批。", userName,
                            DateTime.Now.ToString("yyyy-MM-dd HH:mm:ss"), entity.DealerName);
                        notification.OwnerUserID = approvalUserId;
                        notification.Save();
                    }
                    SaveProductStyles(entity.DealerID);
                }
                else
                {
                    XtraMessageBox.Show("往来单位编号已存在。", "警告", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                    return;
                }
            }

            this.DialogResult = DialogResult.OK;
        }
        private void SaveProductStyles(int dealerId)
        {

            BFIBusinessRangeEntity range = new BFIBusinessRangeEntity { DealerID = dealerId };
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
        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        /// <summary>
        /// 非文本框取值
        /// </summary>
        /// <param name="entity">实体</param>
        protected virtual void CustomGetEntity(BFIDealerEntity entity)
        {
            //if (!entity.IsNullField("DealerType"))
            //{
            //    this.cbxDealerType.Text = entity.DealerType;
            //}

            this.cbxDealerType.Text = "供应商";

            if (!entity.IsNullField("DealerStyle"))
            {
                this.cbxDealerStyle.Text = entity.DealerStyle;
            }

            if (!entity.IsNullField("IndustryStyle"))
            {
                this.cbxIndustryStyle.Text = entity.IndustryStyle;

                if (cbxIndustryStyle.Text == "生产厂商")
                {
                    layBusinessRange.CustomizationFormText = "生产范围";
                    layBusinessRange.Text = "生产范围";
                }
                else
                {
                    layBusinessRange.CustomizationFormText = "经营范围";
                    layBusinessRange.Text = "经营范围";
                }
            }

            if (!entity.IsNullField("RegisterData") && entity.RegisterData.HasValue)
            {
                this.dteRegisterData.DateTime = entity.RegisterData.Value;
            }

            if (!entity.IsNullField("PurchasePriceListID"))
            {
                cbxPrice.EditValue = entity.PurchasePriceListID;
            }

        }

        /// <summary>
        /// 非文本框赋值
        /// </summary>
        /// <param name="entity">实体</param>
        protected virtual void CustomSetEntity(BFIDealerEntity entity)
        {
            if (this.cbxDealerType.Text.Trim().Length > 0)
            {
                entity.DealerType = this.cbxDealerType.Text.Trim();
            }

            if (this.cbxDealerStyle.SelectedIndex >= 0)
            {
                entity.DealerStyle = this.cbxDealerStyle.Text.Trim();
            }

            if (this.cbxIndustryStyle.SelectedIndex >= 0)
            {
                entity.IndustryStyle = this.cbxIndustryStyle.Text.Trim();
            }

            if (this.dteRegisterData.Text.Trim().Length > 0)
            {
                entity.RegisterData = this.dteRegisterData.DateTime;
            }

            entity.PurchasePriceListID = Convert.ToInt32(cbxPrice.EditValue);

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

        public void MarkChangedFieds(Guid antiApproveID)
        {
            btnSave.Visible = false;
            //chkCheck.Enabled = false;
            //ftPanel.Enabled = false;
            btnCancel.Text = "关闭(&C)";
            EntityCollection<ATCAntiApproveDetailEntity> details = new EntityCollection<ATCAntiApproveDetailEntity>();
            details.Fetch(ATCAntiApproveDetailEntityFields.AntiApproveID == antiApproveID);
            foreach (ATCAntiApproveDetailEntity entity in details)
            {
                Control[] controls = this.Controls.Find(entity.ControlName, true);
                foreach (Control control in controls)
                {
                    control.BackColor = Color.LightPink;
                }
            }
            MakeControlsReadOnly();
        }

        private void MakeControlsReadOnly()
        {
            foreach (Control control in layControl.Controls)
            {
                if (control is BaseEdit)
                {
                    ((BaseEdit) control).Properties.ReadOnly = true;
                }
                else
                {
                    control.Enabled = false;
                }
            }
        }

        private void cbxIndustryStyle_SelectedIndexChanged(object sender, EventArgs e)
        {
            BindProductStyles();
            if (cbxIndustryStyle.Text == "生产厂商")
            {
                layBusinessRange.CustomizationFormText = "生产范围";
                layBusinessRange.Text = "生产范围";
            }
            else
            {
                layBusinessRange.CustomizationFormText = "经营范围";
                layBusinessRange.Text = "经营范围";
            }
        }
    }
}