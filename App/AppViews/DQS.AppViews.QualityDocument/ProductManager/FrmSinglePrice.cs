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

namespace DQS.AppViews.QualityDocument.ProductManager
{
    public partial class FrmSinglePrice : DevExpress.XtraEditors.XtraForm
    {
        private int? m_ProductID;
        private int? m_PriceID;

        public FrmSinglePrice()
        {
            InitializeComponent();
        }

        public FrmSinglePrice(int productID, int priceID)
        {
            InitializeComponent();
            this.m_ProductID = productID;
            this.m_PriceID = priceID;
        }

        private void FrmSinglePrice_Load(object sender, EventArgs e)
        {
            if (this.m_ProductID != null && this.m_PriceID != null)
            {
                BFIProductPriceEntity entity = new BFIProductPriceEntity { ProductID = m_ProductID.Value, PriceID = m_PriceID.Value };
                entity.Fetch();

                this.ftPanel.SetEntity(entity);

                this.CustomGetEntity(entity);

            }
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            if (!this.ftPanel.ValidateIsNullFields()) return;

            BFIProductPriceEntity entity = this.ftPanel.GetEntity() as BFIProductPriceEntity;

            this.CustomSetEntity(entity);

            if (this.m_ProductID != null && this.m_PriceID != null)
            {
                entity.LastModifyDate = DateTime.Now;
                entity.LastModifyUserID = GlobalItem.g_CurrentUser.UserID;
                entity.Update();
            }
            else
            {
                if (entity.IsNew(BFIProductPriceEntityFields.ProductID == entity.ProductID & BFIProductPriceEntityFields.PriceID == entity.PriceID))
                {
                    entity.CreateDate = DateTime.Now;
                    entity.LastModifyDate = DateTime.Now;
                    entity.CreateUserID = GlobalItem.g_CurrentUser.UserID;
                    entity.LastModifyUserID = GlobalItem.g_CurrentUser.UserID;
                    entity.Save();
                }
                else
                {
                    XtraMessageBox.Show("该价格信息已存在。", "警告", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
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
        protected virtual void CustomGetEntity(BFIProductPriceEntity entity)
        {
            if (!entity.IsNullField("ProductID"))
            {
                this.txtPopupProduct.SetMemberValue(entity.ProductID);
            }

            if (!entity.IsNullField("PriceID"))
            {
                this.txtPopupStyle.SetMemberValue(entity.PriceID);
            }

            if (!entity.IsNullField("Price"))
            {
                this.spePrice.Value = Convert.ToDecimal(entity.Price);
            }
        }

        /// <summary>
        /// 非文本框赋值
        /// </summary>
        /// <param name="entity">实体</param>
        protected virtual void CustomSetEntity(BFIProductPriceEntity entity)
        {
            if (this.txtPopupProduct.SelectedValue != null)
            {
                entity.ProductID = Convert.ToInt32(this.txtPopupProduct.SelectedValue);
            }

            if (this.txtPopupStyle.SelectedValue != null)
            {
                entity.PriceID = Convert.ToInt32(this.txtPopupStyle.SelectedValue);
            }

            entity.Price = Convert.ToDouble(this.spePrice.Value);
        }

    }
}