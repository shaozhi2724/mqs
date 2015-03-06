using DevExpress.XtraEditors;
using DQS.Module.Entities;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace DQS.AppViews.QualityDocument.ProductManager
{
    public partial class FrmSinglePriceOfDealer : XtraForm
    {

        private int? m_id;
        public FrmSinglePriceOfDealer()
        {
            InitializeComponent();
        }

        private void txtProductCode_PopupClosing(object sender, EventArgs e)
        {
            if (this.txtProductCode.EditData != null)
            {
                this.txtProductCode.Tag = (this.txtProductCode.EditData as DataRow)["药品ID"].ToString();
                this.txtProductSpec.Text = (this.txtProductCode.EditData as DataRow)["规格"].ToString();
                this.txtPackageSpec.Text = (this.txtProductCode.EditData as DataRow)["包装规格"].ToString();
                this.txtAuthorizedNo.Text = (this.txtProductCode.EditData as DataRow)["批准文号"].ToString();
                this.txtProducerName.Text = (this.txtProductCode.EditData as DataRow)["生产厂商"].ToString();
                this.txtProductStyle.Text = (this.txtProductCode.EditData as DataRow)["药品类别"].ToString();
            }
        }

        private void txtDealerName_PopupClosing(object sender, EventArgs e)
        {
            if (this.txtDealerName.EditData != null)
            {
                this.txtDealerName.Tag = (this.txtDealerName.EditData as DataRow)["单位ID"].ToString();
            }
        }

        private void btnSave_Click(object sender, EventArgs e)
        {

            BFIPriceOfDealerEntity entity = this.ftPanel.GetEntity() as BFIPriceOfDealerEntity;

            this.CustomSetEntity(entity);

            if (this.m_id != null)
            {
                entity.Update();
            }
            else
            {
                if (entity.IsNew())
                {
                    entity.Save();
                }
            }
            this.DialogResult = DialogResult.OK;
        }
        
        /// <summary>
        /// 非文本框赋值
        /// </summary>
        /// <param name="entity">实体</param>
        protected virtual void CustomSetEntity(BFIPriceOfDealerEntity entity)
        {
            if (this.txtDealerName.Tag != null)
            {
                entity.DealerID = Convert.ToInt32(this.txtDealerName.Tag);
            }
            if (this.txtProductCode.Tag != null)
            {
                entity.ProductID = Convert.ToInt32(this.txtProductCode.Tag);
            }
            if (this.txtUnitPrice.Text != "")
            {
                entity.UnitPrice = Convert.ToDouble(this.txtUnitPrice.Text);
            }
            if (this.txtTradePrice.Text != "")
            {
                entity.TradePrice = Convert.ToDouble(this.txtTradePrice.Text);
            }
            if (this.txtRetailPrice.Text != "")
            {
                entity.RetailPrice = Convert.ToDouble(this.txtRetailPrice.Text);
            }
        }
        /// <summary>
        /// 非文本框取值
        /// </summary>
        /// <param name="entity">实体</param>
        protected virtual void CustomGetEntity(BFIPriceOfDealerEntity entity)
        {
            if (!entity.IsNullField("DealerID"))
            {
                this.txtDealerName.Tag = entity.DealerID;
                BFIDealerEntity DealerEntity = new BFIDealerEntity { DealerID = (int)this.txtDealerName.Tag };
                DealerEntity.Fetch();
                this.txtDealerName.Text = DealerEntity.DealerName;
            }
        }

        private void FrmSinglePriceOfDealer_Load(object sender, EventArgs e)
        {
            if (this.Tag != null)
            {
                this.m_id = Convert.ToInt32(this.Tag);
                BFIPriceOfDealerEntity entity = new BFIPriceOfDealerEntity { PriceID = m_id.Value };
                entity.Fetch();
                this.txtDealerName.Tag = entity.DealerID;
                this.txtProductCode.Tag = entity.ProductID;
                BFIDealerEntity DealerEntity = new BFIDealerEntity { DealerID = entity.DealerID };
                DealerEntity.Fetch();
                this.txtDealerName.Text = DealerEntity.DealerName;
                BFIProductEntity ProductEntity = new BFIProductEntity { ProductID = entity.ProductID };
                ProductEntity.Fetch();
                this.txtProductCode.Text = ProductEntity.ProductName;
                this.txtProductSpec.Text = ProductEntity.ProductSpec;
                this.txtPackageSpec.Text = ProductEntity.PackageSpec;
                this.txtAuthorizedNo.Text = ProductEntity.AuthorizedNo;
                this.txtProducerName.Text = ProductEntity.ProducerName;
                this.txtProductStyle.Text = ProductEntity.ProductStyle;

                this.txtUnitPrice.Text = entity.UnitPrice.ToString();
                this.txtTradePrice.Text = entity.TradePrice.ToString();
                this.txtRetailPrice.Text = entity.RetailPrice.ToString();
            }
        }
    }
}
