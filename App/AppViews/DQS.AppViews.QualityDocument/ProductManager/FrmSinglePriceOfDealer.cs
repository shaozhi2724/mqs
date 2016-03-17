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
using DevExpress.XtraEditors.Repository;
using DevExpress.XtraGrid.Views.Grid;
using DQS.Common;

namespace DQS.AppViews.QualityDocument.ProductManager
{
    public partial class FrmSinglePriceOfDealer : XtraForm
    {

        List<DealerPriceViewModel> dealerPrices = new List<DealerPriceViewModel>();
        private int _priceId;
        private int? m_id;
        public FrmSinglePriceOfDealer()
        {
            InitializeComponent();
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

        private void txtProductCode_PopupClosing(object sender, EventArgs e)
        {
            if (this.txtProductCode.EditData != null)
            {
                this.txtProductCode.Tag = (this.txtProductCode.EditData as DataRow)["产品ID"].ToString();
                this.txtProductSpec.Text = (this.txtProductCode.EditData as DataRow)["规格型号"].ToString();
                this.txtPackageSpec.Text = (this.txtProductCode.EditData as DataRow)["包装规格型号"].ToString();
                this.txtAuthorizedNo.Text = (this.txtProductCode.EditData as DataRow)["注册证号"].ToString();
                this.txtProducerName.Text = (this.txtProductCode.EditData as DataRow)["生产厂商"].ToString();
                this.txtProductStyle.Text = (this.txtProductCode.EditData as DataRow)["产品类别"].ToString();
            }
        }

        private void txtDealerName_PopupClosing(object sender, EventArgs e)
        {
            if (this.txtDealerName.EditData != null)
            {
                this.txtDealerName.Tag = (this.txtDealerName.EditData as DataRow)["单位ID"].ToString();
            }
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            if(!ValidateNewRecord())
            {
                return;
            }
            _priceId--;
            var dealerId = int.Parse(txtDealerName.Tag.ToString());
            var dealerName = txtDealerName.Text.Trim();
            var productId = int.Parse(txtProductCode.Tag.ToString());
            var productName = txtProductCode.Text.Trim();
            var unitPrice = Convert.ToDouble(txtUnitPrice.Value);
            var tradePrice = Convert.ToDouble(txtTradePrice.Value);
            var retailPrice = Convert.ToDouble(txtRetailPrice.Value);
            if (!dealerPrices.Exists(p => p.DealerID == dealerId 
                                     && p.ProductID == productId 
                                     && p.TradePrice == tradePrice
                                     && p.RetailPrice == retailPrice))
            {
                dealerPrices.Add(new DealerPriceViewModel
                                 {
                                     PriceID = _priceId,
                                     DealerID = dealerId,
                                     DealerName = dealerName,
                                     ProductID = productId,
                                     ProductName = productName,
                                     UnitPrice = unitPrice,
                                     TradePrice = tradePrice,
                                     RetailPrice = retailPrice,
                                     CreateDate = DateTime.Now,
                                     CreateUserID = GlobalItem.g_CurrentUser.UserID,
                                     CreateUsername =
                                         null == GlobalItem.g_CurrentEmployee
                                             ? GlobalItem.g_CurrentUser.UserName
                                             : GlobalItem.g_CurrentEmployee.EmployeeName,
                                     LastModifyDate = DateTime.Now,
                                     LastModifyUserID = GlobalItem.g_CurrentUser.UserID
                                 });
            }
            else
            {
                XtraMessageBox.Show("要添加的价格记录已经存在！", "提示", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            grdPriceList.DataSource = dealerPrices;
            gvPriceList.BestFitColumns();
            grdPriceList.Refresh();
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            if(null == gvPriceList.GetFocusedRow())
            {
                XtraMessageBox.Show("请选择删除的数据！", "提示", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            DialogResult dr = XtraMessageBox.Show("确定要删除此行数据吗？", "提示", MessageBoxButtons.OKCancel, MessageBoxIcon.Question);
            if(dr == DialogResult.OK)
            {
                int priceId = Convert.ToInt32(gvPriceList.GetFocusedRowCellValue("PriceID"));
                var dealerPrice = dealerPrices.FirstOrDefault(p => p.PriceID == priceId);
                if(null != dealerPrice)
                {
                    dealerPrices.Remove(dealerPrice);
                }
                grdPriceList.DataSource = dealerPrices;
                gvPriceList.BestFitColumns();
                grdPriceList.Refresh();
            }
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            if(!ValidateNewRecord())
            {
                return;
            }
            BFIPriceOfDealerEntity entity = this.ftPanel.GetEntity() as BFIPriceOfDealerEntity;

            this.CustomSetEntity(entity);

            if (this.m_id != null)
            {
                entity.Update();
            }
            if (dealerPrices.Any())
            {
                foreach (var priceViewModel in dealerPrices)
                {
                    BFIPriceOfDealerEntity priceEntity = new BFIPriceOfDealerEntity
                                                         {
                                                             DealerID = priceViewModel.DealerID,
                                                             ProductID = priceViewModel.ProductID,
                                                             UnitPrice = priceViewModel.UnitPrice,
                                                             RetailPrice = priceViewModel.RetailPrice,
                                                             TradePrice = priceViewModel.TradePrice,
                                                             CreateUserID = priceViewModel.CreateUserID,
                                                             CreateDate = priceViewModel.CreateDate,
                                                             LastModifyDate = priceViewModel.LastModifyDate,
                                                             LastModifyUserID = priceViewModel.LastModifyUserID
                                                         };
                    priceEntity.Save();
                }
            }
            this.DialogResult = DialogResult.OK;
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {

        }

        private bool ValidateNewRecord()
        {
            if(string.IsNullOrWhiteSpace(txtDealerName.Text))
            {
                XtraMessageBox.Show("请选择往来单位！", "系统数据校验提示", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return false;
            }
            if(string.IsNullOrWhiteSpace(txtProductCode.Text))
            {
                XtraMessageBox.Show("请选择产品名称！", "系统数据校验提示", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return false;
            }
            return true;
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

        private void gvPriceList_CustomDrawRowIndicator(object sender, DevExpress.XtraGrid.Views.Grid.RowIndicatorCustomDrawEventArgs e)
        {
            if (e.Info.IsRowIndicator)
            {
                if (e.RowHandle >= 0)
                {
                    e.Info.DisplayText = (e.RowHandle + 1).ToString();
                }
            }
        }
        private void gvPriceList_CustomDrawEmptyForeground(object sender, DevExpress.XtraGrid.Views.Base.CustomDrawEventArgs e)
        {
            GridView view = sender as GridView;

            if(view.RowCount != 0)
                return;//有记录，返回

            using(StringFormat drawFormat = new StringFormat())
            {
                drawFormat.Alignment = drawFormat.LineAlignment = StringAlignment.Center;
                e.Graphics.DrawString("暂无记录.", e.Appearance.Font, SystemBrushes.ControlDark, new RectangleF(e.Bounds.X, e.Bounds.Y, e.Bounds.Width, e.Bounds.Height), drawFormat);
            }
        }
        private void gvPriceList_KeyDown(object sender, KeyEventArgs e)
        {
            if(e.KeyCode == Keys.Delete)
            {
                DialogResult dr = XtraMessageBox.Show("确定要删除此行数据吗？", "提示", MessageBoxButtons.OKCancel, MessageBoxIcon.Question);
                if(dr == DialogResult.OK)
                {
                    int priceId = Convert.ToInt32(gvPriceList.GetFocusedRowCellValue("PriceID"));
                    var dealerPrice = dealerPrices.FirstOrDefault(p => p.PriceID == priceId);
                    if(null != dealerPrice)
                    {
                        dealerPrices.Remove(dealerPrice);
                    }
                    grdPriceList.DataSource = dealerPrices;
                    gvPriceList.BestFitColumns();
                    grdPriceList.Refresh();
                }
            }
        }
    }

    public class DealerPriceViewModel : BFIPriceOfDealerEntity
    {
        public string DealerName { get; set; }
        public string ProductName { get; set; }
        public string CreateUsername { get; set; }
    }
}
