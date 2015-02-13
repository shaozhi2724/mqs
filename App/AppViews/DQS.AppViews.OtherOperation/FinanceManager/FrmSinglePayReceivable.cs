using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Windows.Forms;
using DevExpress.XtraEditors;
using DevExpress.XtraGrid.Views.Grid;
using DQS.Module.Entities;
using DQS.Common;
using ORMSCore;
using DQS.Controls.CommonCode;

namespace DQS.AppViews.OtherOperation.FinanceManager
{
    public partial class FrmSinglePayReceivable : DevExpress.XtraEditors.XtraForm
    {
        private int? m_id;

        public FrmSinglePayReceivable()
        {
            InitializeComponent();
        }

        private void FrmSinglePayReceivable_Load(object sender, EventArgs e)
        {
            this.cbxDeliveryType.InitSource();
            this.cbxPaymentType.InitSource();
            this.popupGrid.InitGrid();

            if (this.Tag != null)
            {
                (this.popupGrid.MainView as GridView).OptionsBehavior.Editable = false;

                this.popupGrid.RemoveRowCellClickEvent();
                this.m_id = Convert.ToInt32(this.Tag);

                BUSBillReceivableEntity entity = new BUSBillReceivableEntity { BillReceivableID = m_id.Value };
                entity.Fetch();

                this.ftPanel.SetEntity(entity);

                this.txtBillCode.Enabled = false;
                btnSave.Enabled = false;

                this.CustomGetEntity(entity);

                if (!entity.IsNullField("BillID"))
                {
                    //根据订单设置表格数据
                    this.popupGrid.SetGridData("vw_AllReceivableBillDetail", "订单ID", entity.BillID, true);
                }
            }
        }

        private void txtBillCode_PopupClosing(object sender, EventArgs e)
        {
            if (this.txtBillCode.EditData != null)
            {
                var dataRow = this.txtBillCode.EditData as DataRow;
                this.txtDealerName.Text = dataRow["往来单位名称"].ToString();
                this.rdgBillStyle.SelectedIndex = dataRow["类型"].ToString() == "正常" ? 0 : 1;
                txtBusinessPerson.Text = dataRow["联系人"].ToString();
                txtBusinessPhone.Text = dataRow["联系方式"].ToString();
                cbxPaymentType.Text = dataRow["付款方式"].ToString();
                cbxDeliveryType.Text = dataRow["配送方式"].ToString();
                txtContractNo.Text = dataRow["合同号"].ToString();
                txtOperator.Text = dataRow["业务员"].ToString();
                double totalPrice = Convert.ToDouble(dataRow["订单总额"]);
                txtTotalPrice.Text = totalPrice.ToString();
                txtBillRemark.Text = dataRow["备注"].ToString();
                txtProductAmount.Text = dataRow["商品数目"].ToString();
                object id = dataRow["订单ID"].ToString();
                EntityCollection<BUSBillReceivableEntity> entities = new EntityCollection<BUSBillReceivableEntity>();
                entities.Fetch(BUSBillReceivableEntityFields.BillID == Convert.ToInt32(id));

                txtBillReceivableCode.Text = "YS" + dataRow["订单号"].ToString() + (entities.Count + 1).ToString().PadLeft(2, '0');
                if (entities.Count > 0)
                {
                    var payables = entities.Cast<BUSBillReceivableEntity>().ToList();
                    var sumPaid = (decimal)payables.Sum(p => p.AccountsReceive);
                    txtAccountsReceivable.Text = ((decimal)totalPrice - sumPaid).ToString();
                    txtReceived.Text = sumPaid.ToString();
                }
                else
                {
                    txtAccountsReceivable.Text = totalPrice.ToString();
                    txtReceived.Text = "0";
                }

                if (id != null)
                {
                    //根据订单设置表格数据
                    this.popupGrid.SetGridData("vw_AllReceivableBillDetail", "订单ID", id, true);
                }
            }
        }
        private void btnSave_Click(object sender, EventArgs e)
        {
            try
            {
                if (!this.ftPanel.ValidateIsNullFields()) return;

                BUSBillReceivableEntity entity = this.ftPanel.GetEntity() as BUSBillReceivableEntity;

                this.CustomSetEntity(entity);
                if (entity.IsNew(BUSBillReceivableEntityFields.BillReceivableCode == entity.BillReceivableCode))
                {
                    decimal received = Decimal.Parse(txtReceived.Text);
                    decimal receive = decimal.Parse(txtReceive.Text);

                    decimal total = received + receive;
                    if (received == (decimal)entity.TotalPrice)
                    {
                        XtraMessageBox.Show("款项已清，请检查并重新录入。", "错误", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                        txtReceive.Focus();
                        return;
                    }
                    if (receive <= 0)
                    {
                        XtraMessageBox.Show("收款金额必须大于0，请检查并重新录入。", "错误", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                        txtReceive.Focus();
                        return;
                    }
                    if ((double)total > entity.TotalPrice)
                    {
                        XtraMessageBox.Show("收款金额与已收款金额总和大于订单总额，请检查并重新录入。", "错误", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                        txtReceive.Focus();
                        return;
                    }
                    entity.Save();
                }
                else
                {
                    XtraMessageBox.Show("应收记录已存在，请检查并重新录入。", "警告", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                    return;
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
        protected virtual void CustomGetEntity(BUSBillReceivableEntity entity)
        {
            if (!entity.IsNullField("DealerName"))
            {
                this.txtDealerName.Text = entity.DealerName;
            }

            txtBillCode.SetMemberValue(entity.BillID);

            BUSBillEntity bill = new BUSBillEntity { BillID = entity.BillID };
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
                txtBillRemark.Text = bill.BillRemark;
            }

            if (!bill.IsNullField("BillStyle"))
            {
                rdgBillStyle.SelectedIndex = bill.BillStyle == "正常" ? 0 : 1;
            }

            if (!bill.IsNullField("BusinessPerson"))
            {
                txtBusinessPerson.Text = bill.BusinessPerson;
            }

            if (!bill.IsNullField("BusinessPhone"))
            {
                txtBusinessPhone.Text = bill.BusinessPhone;
            }

            if (!bill.IsNullField("ContractNo"))
            {
                txtContractNo.Text = bill.ContractNo;
            }

            if (!bill.IsNullField("Operator"))
            {
                txtOperator.Text = bill.Operator;
            }

            if (!bill.IsNullField("PickUpPerson"))
            {
                this.txtPickUpPerson.Text = bill.PickUpPerson;
            }

            if (!bill.IsNullField("Operator"))
            {
                this.txtOperator.Text = bill.Operator;
            }

            if (!bill.IsNullField("DealerAddress"))
            {
                this.txtDealerAddress.Text = bill.DealerAddress;
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


            if (!bill.IsNullField("TotalPrice"))
            {
                txtTotalPrice.Text = bill.TotalPrice.ToString();
            }
        }

        /// <summary>
        /// 非文本框赋值
        /// </summary>
        /// <param name="entity">实体</param>
        protected virtual void CustomSetEntity(BUSBillReceivableEntity entity)
        {
            var dataRow = this.txtBillCode.EditData as DataRow;
            if (null != dataRow)
            {
                entity.BillID = Convert.ToInt32(dataRow["订单ID"]);
                entity.DealerName = this.txtDealerName.Text.Trim();
                entity.DealerCode = dataRow["往来单位编号"].ToString();
            }
            entity.BillReceivableCode = txtBillReceivableCode.Text.Trim();
            entity.BillCode = txtBillCode.Text.Trim();
            entity.AccountsReceivable = Convert.ToDouble(txtAccountsReceivable.Text);
            entity.BillReceivableRemark = txtBillReceivableRemark.Text.Trim();
            entity.CreateDate = DateTime.Now;
            entity.CreateUserName = GlobalItem.g_CurrentEmployee != null
                ? GlobalItem.g_CurrentEmployee.EmployeeName
                : GlobalItem.g_CurrentUser.UserName;
            
        }

    }
}