using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Windows.Forms;
using DevExpress.XtraEditors;
using DevExpress.XtraGrid.Views.Grid;
using DQS.Module.Entities;
using DQS.Common;
using ORMSCore;
using DQS.Module.Views;
using DevExpress.XtraLayout.Utils;

namespace DQS.AppViews.Operation.PriceManager
{
    public partial class FrmSinglePurchasePriceItem : DevExpress.XtraEditors.XtraForm
    {
        private int? m_id;
        private BFIPriceListVersionEntity _priceListVersion;
        private BFIPriceListEntity _priceList;

        public FrmSinglePurchasePriceItem()
        {
            InitializeComponent();
        }

        public FrmSinglePurchasePriceItem(BFIPriceListVersionEntity priceListVersionEntity, BFIPriceListEntity priceListEntity) : this()
        {
            _priceListVersion = priceListVersionEntity;
            _priceList = priceListEntity;
        }

        private void FrmSinglePurchasePriceItem_Load(object sender, EventArgs e)
        {
            Inital();
        }

        private void Inital()
        {
            txtPriceListName.Text = _priceList.PriceListName;
            txtPriceListVersionName.Text = _priceListVersion.PriceListVersionName;
            txtMinQuantity.Properties.MaxValue = Int32.MaxValue;

            this.cbxPriceStyle.AddFirstDefaultItem = false;
            this.cbxPriceStyle.InitSource();
            cbxPriceStyle.SelectedIndex = 0;
            this.cbxProductCategory.InitSource();

            BindProducts();

            if (this.Tag != null)
            {
                this.m_id = Convert.ToInt32(this.Tag);

                BFIPriceListItemEntity entity = new BFIPriceListItemEntity
                                                {
                                                    PriceListItemId = m_id.Value
                                                };
                entity.Fetch();

                this.ftPanel.SetEntity(entity);

                this.CustomGetEntity(entity);
            }
            txtPriceListItemName.Focus();
        }

        private void BindProducts()
        {
            EntityCollection<BFIProductEntity> products = new EntityCollection<BFIProductEntity>();
            if (!string.IsNullOrWhiteSpace(cbxProductCategory.Text))
            {
                products.Fetch(BFIProductEntityFields.ProductStyle == cbxProductCategory.Text);
            }
            else
            {
                products.Fetch(); //BFIProductEntityFields.BusinessStatus == 1
            }

            cbxProduct.Properties.DataSource = products;
            cbxProduct.ClosePopup();
        }

        private void btnAppend_Click(object sender, EventArgs e)
        {
            if (SavePriceItem())
            {
                this.Tag = null;
                m_id = null;
                Inital();
                txtPriceListItemName.Text = string.Empty;
                txtMinQuantity.Value = 0;
                txtSequence.Value = 5;
                txtDiscount.Value = 0;
                txtSurcharge.Value = 0;
                cbxPriceStyle.SelectedIndex = 0;
                cbxProductCategory.SelectedIndex = 0;
                cbxProduct.EditValue = null;
                cbxProduct.ClosePopup();
            }
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            if (SavePriceItem())
            {
                this.DialogResult = DialogResult.OK;
            }
        }

        private bool SavePriceItem()
        {
            try
            {
                //if(!ValidateNullFields())
                //{
                //    return false;
                //}

                if (this.m_id != null)
                {
                    #region 修改

                    BFIPriceListItemEntity entity = new BFIPriceListItemEntity
                                                    {
                                                        PriceListItemId = m_id.Value
                                                    };
                    entity.Fetch();

                    this.CustomSetEntity(entity);
                    entity.LastModifyDate = DateTime.Now;
                    entity.LastModifyUserID = GlobalItem.g_CurrentUser.UserID;
                    entity.Update();

                    #endregion
                }
                else
                {

                    BFIPriceListItemEntity entity = new BFIPriceListItemEntity();

                    this.CustomSetEntity(entity);
                    entity.CreateDate = DateTime.Now;
                    entity.LastModifyDate = DateTime.Now;
                    entity.CreateUserID = GlobalItem.g_CurrentUser.UserID;
                    entity.LastModifyUserID = GlobalItem.g_CurrentUser.UserID;
                    entity.Save();

                }
            }
            catch (Exception ex)
            {
                XtraMessageBox.Show(ex.Message, "错误", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                return false;
            }
            return true;
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        /// <summary>
        /// 非文本框取值
        /// </summary>
        /// <param name="entity">实体</param>
        protected virtual void CustomGetEntity(BFIPriceListItemEntity entity)
        {
            if(!entity.IsNullField("Sequence"))
            {
                txtSequence.Value = entity.Sequence;
            }
            if(!entity.IsNullField("PriceListItemName"))
            {
                txtPriceListItemName.Text = entity.PriceListItemName;
            }
            if(!entity.IsNullField("ProductCategory"))
            {
                cbxProductCategory.Text = entity.ProductCategory;
            }
            if(!entity.IsNullField("ProductID"))
            {
                cbxProduct.EditValue = entity.ProductID;
                var productEntity = new BFIProductEntity{ ProductID = entity.ProductID};
                productEntity.Fetch();

                cbxProduct.Text = productEntity.ProductName;
                cbxProduct.ClosePopup();
            }
            if(!entity.IsNullField("BasePriceCategoryName"))
            {
                cbxPriceStyle.Text = entity.BasePriceCategoryName;
                lblBasePriceStyle.Text = string.Format("{0} * （1 + ", cbxPriceStyle.Text);
            }
            if(!entity.IsNullField("PriceDiscount"))
            {
                txtDiscount.Value = (decimal)entity.PriceDiscount;
            }
            if(!entity.IsNullField("PriceSurcharge"))
            {
                txtSurcharge.Value = (decimal)entity.PriceSurcharge;
            }
            if(!entity.IsNullField("MinQuantity"))
            {
                txtMinQuantity.Value = entity.MinQuantity;
            }
        }

        /// <summary>
        /// 非文本框赋值
        /// </summary>
        /// <param name="entity">实体</param>
        protected virtual void CustomSetEntity(BFIPriceListItemEntity entity)
        {
            entity.PriceVersionID = _priceListVersion.PriceListVersionID;
            entity.Sequence = (int) txtSequence.Value;
            entity.PriceListItemName = txtPriceListItemName.Text.Trim();
            if(!string.IsNullOrWhiteSpace(cbxProductCategory.Text))
            {
                entity.ProductCategory = cbxProductCategory.Text;
            }
            if(!string.IsNullOrWhiteSpace(cbxProduct.Text))
            {
                entity.ProductID = (int) cbxProduct.EditValue;
            }
            entity.BasePriceCategoryName = cbxPriceStyle.Text;
            entity.BasePriceCategoryID = (int) cbxPriceStyle.SelectedValue;
            entity.PriceDiscount = (double) txtDiscount.Value;
            entity.PriceSurcharge = (double) txtSurcharge.Value;
            entity.MinQuantity = (int) txtMinQuantity.Value;
        }

        private void cbxPriceStyle_SelectedValueChanged(object sender, EventArgs e)
        {
            lblBasePriceStyle.Text = string.Format("{0} * （1 + ", cbxPriceStyle.Text);
        }

        private void cbxProductCategory_SelectedValueChanged(object sender, EventArgs e)
        {
            BindProducts();
        }

        private void cbxProduct_ButtonClick(object sender, DevExpress.XtraEditors.Controls.ButtonPressedEventArgs e)
        {
            if(e.Button.Index == 1)
            {
                cbxProduct.EditValue = null;
                cbxProduct.Text = "";
                cbxProduct.ClosePopup();
            }
        }

    }
}