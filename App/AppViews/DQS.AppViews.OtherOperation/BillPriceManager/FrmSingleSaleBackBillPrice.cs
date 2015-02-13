using System;
using System.Collections.Generic;
using System.Data;
using System.Windows.Forms;
using DevExpress.XtraEditors;
using DevExpress.XtraGrid.Views.Grid;
using DQS.Common;
using DQS.Module.Entities;
using ORMSCore;

namespace DQS.AppViews.OtherOperation.BillPriceManager
{
    public partial class FrmSingleSaleBackBillPrice : DevExpress.XtraEditors.XtraForm
    {
        private int? m_id;

        public FrmSingleSaleBackBillPrice()
        {
            InitializeComponent();
        }

        private void FrmSingleSaleBackBillPrice_Load(object sender, EventArgs e)
        {
            this.cbxDeliveryType.InitSource();
            this.cbxPaymentType.InitSource();
            this.popupGrid.InitGrid();
            if (this.Tag != null)
            {
                (this.popupGrid.MainView as GridView).OptionsBehavior.Editable = false;

                this.popupGrid.RemoveRowCellClickEvent();
                this.m_id = Convert.ToInt32(this.Tag);

                BUSBillPriceHistoryEntity entity = new BUSBillPriceHistoryEntity { BillPriceHistoryID = m_id.Value };
                entity.Fetch();

                this.ftPanel.SetEntity(entity);

                this.txtBillCode.Enabled = false;
                btnSave.Enabled = false;

                this.CustomGetEntity(entity);

                this.popupGrid.SetGridData(m_id.Value);
            }
        }

        private void popupGrid_NewTotalPriceChanged(object sender, DQS.Controls.CommonCode.TotalPriceChangedArgs e)
        {
            this.txtNewTotalPrice.Text = e.TotalPrice + "";
        }
        private void btnSave_Click(object sender, EventArgs e)
        {
            try
            {
                if (!this.ftPanel.ValidateIsNullFields())
                {
                    return;
                }

                BUSBillPriceHistoryEntity entity = this.ftPanel.GetEntity() as BUSBillPriceHistoryEntity;

                this.CustomSetEntity(entity);
                if (entity.IsNew(BUSBillPriceHistoryEntityFields.BillPriceHistoryCode == entity.BillPriceHistoryCode))
                {
                    entity.Save();
                }
                else
                {
                    XtraMessageBox.Show("调价单号已存在，请检查并重新选择销售退回记录。", "错误", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                    return;
                }

                //查询出其ID
                EntityCollection<BUSBillPriceHistoryEntity> entities = new EntityCollection<BUSBillPriceHistoryEntity>();
                entities.Fetch(BUSBillPriceHistoryEntityFields.BillPriceHistoryCode == entity.BillPriceHistoryCode);
                var priceHistory = entities[0] as BUSBillPriceHistoryEntity;

                List<EntityBase> children = this.popupGrid.GetEntities();
                foreach (EntityBase childEntity in children)
                {
                    BUSBillPriceHistoryDetailEntity child = childEntity as BUSBillPriceHistoryDetailEntity;
                    child.BillPriceHistoryID = priceHistory.BillPriceHistoryID;
                    child.BillID = entity.BillID;

                    child.CreateDate = DateTime.Now;
                    child.CreateUserName = GlobalItem.g_CurrentEmployee != null ? GlobalItem.g_CurrentEmployee.EmployeeName : GlobalItem.g_CurrentUser.UserName;
                    child.Save();
                }

            }
            catch (Exception ex)
            {
                XtraMessageBox.Show(ex.Message, "错误", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                return;
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
        protected virtual void CustomGetEntity(BUSBillPriceHistoryEntity entity)
        {
            if (!entity.IsNullField("DealerName"))
            {
                this.txtDealerName.Text = entity.DealerName;
            }
            else
            {
                txtDealerName.Text = "";
            }
            txtBillCode.SetMemberValue(entity.BillID);

            BUSBillEntity bill = new BUSBillEntity{BillID = entity.BillID};
            bill.Fetch();

            if (!bill.IsNullField("DeliveryTypeName"))
            {
                cbxDeliveryType.Text = bill.DeliveryTypeName;
            }

            if (!bill.IsNullField("PaymentTypeName"))
            {
                cbxPaymentType.Text = bill.PaymentTypeName;
            }

            if (!bill.IsNullField("BillRemark"))
            {
                txtReason.Text = bill.BillRemark;
            }

            if (!bill.IsNullField("TotalPrice"))
            {
                txtTotalPrice.Text = bill.TotalPrice.ToString();
            }
            if (!bill.IsNullField("BillStyle"))
            {
                var index = rdgBillStyle.Properties.Items.GetItemIndexByValue(bill.BillStyle);
                rdgBillStyle.SelectedIndex = index;
            }
            else
            {
                rdgBillStyle.SelectedIndex = 0;
            }

        }

        /// <summary>
        /// 非文本框赋值
        /// </summary>
        /// <param name="entity">实体</param>
        protected virtual void CustomSetEntity(BUSBillPriceHistoryEntity entity)
        {
            var dataRow = this.txtBillCode.EditData as DataRow;
            if (null != dataRow)
            {
                entity.BillID = Convert.ToInt32(dataRow["退货单ID"]);
                entity.DealerName = this.txtDealerName.Text.Trim();
                entity.DealerCode = dataRow["往来单位编号"].ToString();
            }
            entity.BillPriceHistoryCode = txtHistoryCode.Text.Trim();
            entity.BillCode = txtBillCode.Text.Trim();
            entity.NewTotalPrice = Convert.ToDouble(txtNewTotalPrice.Text);
            entity.PriceHistoryRemark = txtPriceHistoryRemark.Text.Trim();
            entity.CreateDate = DateTime.Now;
            entity.CreateUserName = GlobalItem.g_CurrentEmployee != null
                ? GlobalItem.g_CurrentEmployee.EmployeeName
                : GlobalItem.g_CurrentUser.UserName;
        }

        private void txtBillCode_PopupClosing(object sender, EventArgs e)
        {
            if (this.txtBillCode.EditData != null)
            {
                var dataRow = this.txtBillCode.EditData as DataRow;
                this.txtDealerName.Text = dataRow["往来单位名称"].ToString();
                this.rdgBillStyle.SelectedIndex = dataRow["类型"].ToString() == "正常" ? 0 : 1;

                cbxPaymentType.Text = dataRow["付款方式"].ToString();
                cbxDeliveryType.Text = dataRow["配送方式"].ToString();
                txtTotalPrice.Text = dataRow["订单总额"].ToString();
                txtReason.Text = dataRow["备注"].ToString();
                object id = dataRow["退货单ID"].ToString();

                BUSBillEntity bill = new BUSBillEntity{BillID = Convert.ToInt32(id)};
                bill.Fetch();
                if (!bill.IsNullField("ReviewCode"))
                {
                    txtReviewCode.Text = bill.ReviewCode;
                }

                if (!bill.IsNullField("SaleBillCode"))
                {
                    txtSaleBillCode.Text = bill.SaleBillCode;
                }

                if (!bill.IsNullField("BillStyle"))
                {
                    var index = rdgBillStyle.Properties.Items.GetItemIndexByValue(bill.BillStyle);
                    rdgBillStyle.SelectedIndex = index;
                }
                else
                {
                    rdgBillStyle.SelectedIndex = 0;
                }
                EntityCollection<BUSBillPriceHistoryEntity> entities = new EntityCollection<BUSBillPriceHistoryEntity>();
                entities.Fetch(BUSBillPriceHistoryEntityFields.BillID == Convert.ToInt32(id));

                txtHistoryCode.Text = "TJ" + dataRow["退货单编号"].ToString() + (entities.Count + 1).ToString().PadLeft(2, '0');

                if (id != null)
                {
                    //根据订单设置表格数据
                    this.popupGrid.SetGridData("vw_AllSaleBackDetail", "销售退货单ID", id, true);

                    for (int i = 0; i < this.popupGrid.PopupView.RowCount; i++)
                    {
                        var price = this.popupGrid.PopupView.GetRowCellValue(i, "单价");
                        this.popupGrid.PopupView.SetRowCellValue(i, "调整单价", price.ToString());
                        var totalPrice = this.popupGrid.PopupView.GetRowCellValue(i, "金额");
                        this.popupGrid.PopupView.SetRowCellValue(i, "调价后金额", totalPrice.ToString());

                        this.popupGrid.PopupView.SetRowCellValue(i, "差价", 0);
                        this.popupGrid.PopupView.SetRowCellValue(i, "差价金额", 0);
                    }
                    txtNewTotalPrice.Text = popupGrid.GetNewSummaryPrice().ToString();
                }
            }
        }
    }
}