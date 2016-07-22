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
using ORMSCore;

namespace DQS.AppViews.ExceptionControl.ExceptionManager
{
    public partial class FrmSingleProductLocked : DevExpress.XtraEditors.XtraForm   {
        private int? m_id;

        public FrmSingleProductLocked()
        {
            InitializeComponent();
        }

        private void FrmSingleProductLocked_Load(object sender, EventArgs e)
        {
            if (this.Tag != null)
            {
                this.m_id = Convert.ToInt32(this.Tag);

                BUSProductLockedEntity entity = new BUSProductLockedEntity { LockedID = m_id.Value };
                entity.Fetch();

                this.ftPanel.SetEntity(entity);

                this.txtPopupProduct.Enabled = false;
                this.txtLockedCode.Enabled = false;
                //rdgIsLockedBatch.Enabled = false;
                txtLockedRemark.Enabled = false;
                txtPopBatch.Enabled = true;
                txtLockedAmount.Enabled = true;
                this.CustomGetEntity(entity);

            }
            else
            {
                this.txtLockedCode.Text = "YPSD" + DateTime.Now.ToString("yyyyMMddHHmmss");
                this.txtLockedCode.Select(this.txtLockedCode.Text.Length, 0);
                this.dteLockedDate.DateTime = DateTime.Now;
                this.tmeLockedTime.Time = DateTime.Now;
                SetLockedBatch(true);
                SetUnLocked(false);
                if (GlobalItem.g_CurrentEmployee != null)
                {
                    txtLockedUser.Text = GlobalItem.g_CurrentEmployee.EmployeeName;
                }
                else
                {
                    txtLockedUser.Text = GlobalItem.g_CurrentUser.UserName;
                }
                rdgIsUnLocked.Enabled = false;
            }
        }

        private void rdgIsLockedBatch_SelectedIndexChanged(object sender, EventArgs e)
        {
            this.SetLockedBatch(rdgIsLockedBatch.SelectedIndex == 1);
        }

        private void rdgIsUnLocked_SelectedIndexChanged(object sender, EventArgs e)
        {
            this.SetUnLocked(rdgIsUnLocked.SelectedIndex == 1);
        }

        /// <summary>
        /// 非文本框取值
        /// </summary>
        /// <param name="entity">实体</param>
        protected virtual void CustomGetEntity(BUSProductLockedEntity entity)
        {
            if (!entity.IsNullField("ProductID"))
            {
                this.txtPopupProduct.SetMemberValue(entity.ProductID);
                this.txtProductName.Text = (this.txtPopupProduct.EditData as DataRow)["产品名称"].ToString();
                this.txtProductSpec.Text = (this.txtPopupProduct.EditData as DataRow)["规格型号"].ToString();
                this.txtProductUnit.Text = (this.txtPopupProduct.EditData as DataRow)["单位"].ToString();
                this.txtPackageSpec.Text = (this.txtPopupProduct.EditData as DataRow)["包装规格型号"].ToString();
                //this.txtPhysicType.Text = (this.txtPopupProduct.EditData as DataRow)["剂型"].ToString();
                this.txtAuthorizedNo.Text = (this.txtPopupProduct.EditData as DataRow)["注册证号"].ToString();
                this.txtProductStyle.Text = (this.txtPopupProduct.EditData as DataRow)["产品类别"].ToString();
                this.txtProducerName.Text = (this.txtPopupProduct.EditData as DataRow)["生产厂商"].ToString();
            }

            if (!entity.IsNullField("BatchNo"))
            {
                this.txtPopBatch.Text = entity.BatchNo;
                this.txtLockedAmount.Text = entity.LockedAmount.ToString();
            }

            /*if (!entity.IsNullField("ProduceDate"))
            {
                txtProduceDate.Text = entity.ProduceDate.ToShortDateString();
            }

            if (!entity.IsNullField("ValidateDate"))
            {
                txtValidateDate.Text = entity.ValidateDate.ToShortDateString();
            }*/

            if (!entity.IsNullField("IsUnLocked"))
            {
                this.rdgIsUnLocked.SelectedIndex = entity.IsUnLocked ? 1 : 0;
                this.SetUnLocked(rdgIsUnLocked.SelectedIndex == 1);
            }

            if (!entity.IsNullField("IsLockedBatch"))
            {
                this.rdgIsLockedBatch.SelectedIndex = entity.IsLockedBatch ? 1 : 0;
                this.SetLockedBatch(rdgIsLockedBatch.SelectedIndex == 1);
            }

            if (!entity.IsNullField("LockedDate"))
            {
                dteLockedDate.DateTime = entity.LockedDate;
                tmeLockedTime.Time = entity.LockedDate;
            }

            if (!entity.IsNullField("UnLockedDate"))
            {
                dteUnLockedDate.DateTime = entity.UnLockedDate;
                tmeUnLockedTime.Time = entity.UnLockedDate;
            }

            
        }

        /// <summary>
        /// 非文本框赋值
        /// </summary>
        /// <param name="entity">实体</param>
        protected virtual void CustomSetEntity(BUSProductLockedEntity entity)
        {

            if (txtPopBatch.Tag != null)
            {
                entity.InStoreID = Convert.ToInt32(txtPopBatch.Tag);
                BUSInStoreDetailEntity inStoreDetail = new BUSInStoreDetailEntity { InStoreID = entity.InStoreID };
                inStoreDetail.Fetch();
                if (!inStoreDetail.IsNullField("ProduceDate"))
                {
                    entity.ProduceDate = inStoreDetail.ProduceDate;
                }
                if (!inStoreDetail.IsNullField("ValidateDate"))
                {
                    entity.ValidateDate = inStoreDetail.ValidateDate;
                }
            }
            else
            {
                entity.InStoreID = 0;
            }

            if (this.txtPopupProduct.SelectedValue != null)
            {
                entity.ProductID = Convert.ToInt32(this.txtPopupProduct.SelectedValue);
            }

            if (this.txtPopBatch.SelectedValue != null)
            {
                entity.BatchNo = this.txtPopBatch.Text.Trim();
                entity.LockedAmount = Convert.ToInt32(this.txtLockedAmount.Text.Trim());
            }

            if (!string.IsNullOrEmpty(dteLockedDate.Text))
            {
                entity.LockedDate = Convert.ToDateTime(String.Format("{0:yyyy-MM-dd} {1:HH:mm:ss}", dteLockedDate.DateTime, tmeLockedTime.Time));
            }

            if (rdgIsUnLocked.SelectedIndex == 1)
            {
                entity.IsUnLocked = true;
                if (!string.IsNullOrEmpty(dteUnLockedDate.Text))
                {
                    entity.UnLockedDate = Convert.ToDateTime(String.Format("{0:yyyy-MM-dd} {1:HH:mm:ss}", dteUnLockedDate.DateTime, tmeUnLockedTime.Time));
                }
            }
            else
            {
                entity.IsUnLocked = false;
            }

            if (rdgIsLockedBatch.SelectedIndex == 1)
            {
                entity.IsLockedBatch = true;
                /*entity.ProduceDate = Convert.ToDateTime(txtProduceDate.Text);
                entity.ValidateDate = Convert.ToDateTime(txtValidateDate.Text);*/
            }
            else
            {
                entity.IsLockedBatch = false;
                entity.BatchNo = "";
                entity.LockedAmount = 0;
            }
        }

        private void txtPopupProduct_PopupClosing(object sender, EventArgs e)
        {
            if (this.txtPopupProduct.EditData != null)
            {
                this.txtProductName.Text = (this.txtPopupProduct.EditData as DataRow)["产品名称"].ToString();
                this.txtProductSpec.Text = (this.txtPopupProduct.EditData as DataRow)["规格型号"].ToString();
                this.txtProductUnit.Text = (this.txtPopupProduct.EditData as DataRow)["单位"].ToString();
                this.txtPackageSpec.Text = (this.txtPopupProduct.EditData as DataRow)["包装规格型号"].ToString();
                //this.txtPhysicType.Text = (this.txtPopupProduct.EditData as DataRow)["剂型"].ToString();
                this.txtAuthorizedNo.Text = (this.txtPopupProduct.EditData as DataRow)["注册证号"].ToString();
                this.txtProductStyle.Text = (this.txtPopupProduct.EditData as DataRow)["产品类别"].ToString();
                this.txtProducerName.Text = (this.txtPopupProduct.EditData as DataRow)["生产厂商"].ToString();

                this.txtPopBatch.Text = "";
                /*this.txtLockedAmount.Text = "";
                this.txtProduceDate.Text = "";
                this.txtValidateDate.Text = "";*/

                this.rdgIsLockedBatch.Focus();
            }
        }
        string ProduceDate = "";
        string ValidateDate = "";

        private void txtPopBatch_PopupClosing(object sender, EventArgs e)
        {
            if (this.txtPopBatch.EditData != null)
            {
                ProduceDate = (this.txtPopBatch.EditData as DataRow)["生产日期"].ToString();
                ValidateDate = (this.txtPopBatch.EditData as DataRow)["有效期至"].ToString();

                this.txtLockedAmount.Text = (this.txtPopBatch.EditData as DataRow)["库存数量"].ToString();
                txtPopBatch.Tag = (this.txtPopBatch.EditData as DataRow)["入库ID"].ToString();
                this.rdgIsUnLocked.Focus();
            }
        }

        private void txtPopBatch_BeforePopupShow(object sender, DQS.Controls.CommonCode.BeforePopupShowArgs e)
        {
            if (this.txtPopupProduct.SelectedValue == null)
            {
                e.Cancel = true;
                XtraMessageBox.Show("请先选择产品。", "警告", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                this.txtPopupProduct.Focus();

            }
            else
            {
                this.txtPopBatch.Filter = string.Format("产品ID = {0} AND 锁定状态<>'已锁定'", this.txtPopupProduct.SelectedValue);
            }

        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            if (!this.ftPanel.ValidateIsNullFields()) return;

            BUSProductLockedEntity entity = this.ftPanel.GetEntity() as BUSProductLockedEntity;

            this.CustomSetEntity(entity);

            if (this.m_id != null)
            {
                entity.LastModifyDate = DateTime.Now;
                entity.LastModifyUserID = GlobalItem.g_CurrentUser.UserID;
                entity.Update();
            }
            else
            {
                if (entity.IsNew())
                {
                    if (!CheckProduct()) return;

                    entity.CreateDate = DateTime.Now;
                    entity.LastModifyDate = DateTime.Now;
                    entity.CreateUserID = GlobalItem.g_CurrentUser.UserID;
                    entity.LastModifyUserID = GlobalItem.g_CurrentUser.UserID;
                    entity.Save();
                }
                else
                {
                    XtraMessageBox.Show("锁定编号已存在。", "警告", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                    return;
                }
            }

            this.DialogResult = DialogResult.OK;
        }

        private bool CheckProduct()
        {
            if (rdgIsLockedBatch.SelectedIndex == 0)
            {
                EntityCollection<BUSProductLockedEntity> pl = new EntityCollection<BUSProductLockedEntity>();
                pl.Fetch(BUSProductLockedEntityFields.ProductID == Convert.ToInt32(this.txtPopupProduct.SelectedValue)
                    & BUSProductLockedEntityFields.IsUnLocked == false);
                if (pl.Count > 0)
                {
                    XtraMessageBox.Show("该产品已锁定，不能重复锁定", "系统提示", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return false;
                }
            }
            else
            {
                EntityCollection<BUSProductLockedEntity> pl = new EntityCollection<BUSProductLockedEntity>();
                pl.Fetch(BUSProductLockedEntityFields.InStoreID == Convert.ToInt32(this.txtPopBatch.Tag)
                    & BUSProductLockedEntityFields.IsUnLocked == false);
                if (pl.Count > 0)
                {
                    XtraMessageBox.Show("该产品已锁定，不能重复锁定", "系统提示", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return false;
                }
            }
            return true;
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        //设置是否锁定批号
        private void SetLockedBatch(bool isLocked)
        {
            this.txtPopBatch.Enabled = isLocked;
            this.txtLockedAmount.Enabled = isLocked;
        }

        //设置是否解除锁定
        private void SetUnLocked(bool isUnLocked)
        {
            this.txtUnLockedUser.Enabled = isUnLocked;
            this.txtDealResult.Enabled = isUnLocked;
            
            //this.dteUnLockedDate.Enabled = isUnLocked;
            //this.tmeUnLockedTime.Enabled = isUnLocked;
            if (isUnLocked)
            {
                dteUnLockedDate.DateTime = DateTime.Now;
                tmeUnLockedTime.Time = DateTime.Now;
                if (GlobalItem.g_CurrentEmployee != null)
                {
                    txtUnLockedUser.Text = GlobalItem.g_CurrentEmployee.EmployeeName;
                }
                else
                {
                    txtUnLockedUser.Text = GlobalItem.g_CurrentUser.UserName;
                }
            }
            else
            {
                dteUnLockedDate.Text = "";
                tmeUnLockedTime.Time = new DateTime();
                txtUnLockedUser.Text = "";
            }
        }
    }
}