using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Windows.Forms;
using DevExpress.XtraEditors;
using DevExpress.XtraGrid.Views.Grid;
using DQS.Common;
using DQS.Module.Entities;
using ORMSCore;

namespace DQS.AppViews.OtherOperation.FinanceManager
{
    public partial class FrmSinglePayable : DevExpress.XtraEditors.XtraForm
    {
        private int? m_id;
        public FrmSinglePayable()
        {
            InitializeComponent();
        }

        private void FrmSinglePayable_Load(object sender, EventArgs e)
        {
            this.cbxDeliveryType.InitSource();
            this.cbxPaymentType.InitSource();
            this.popupGrid.InitGrid();
            if (this.Tag != null)
            {
                (this.popupGrid.MainView as GridView).OptionsBehavior.Editable = false;

                this.popupGrid.RemoveRowCellClickEvent();
                this.m_id = Convert.ToInt32(this.Tag);

                BUSBillPayableEntity entity = new BUSBillPayableEntity { BillPayableID = m_id.Value };
                entity.Fetch();

                this.ftPanel.SetEntity(entity);

                this.txtBillCode.Enabled = false;
                btnSave.Enabled = false;

                this.CustomGetEntity(entity);

                if (!entity.IsNullField("BillID"))
                {
                    //根据订单设置表格数据
                    this.popupGrid.SetGridData("vw_AllPayableBillDetail", "订单ID", entity.BillID, true);
                }
            }
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Close();
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
                object id = dataRow["订单ID"].ToString();
                EntityCollection<BUSBillPayableEntity> entities = new EntityCollection<BUSBillPayableEntity>();
                entities.Fetch(BUSBillPayableEntityFields.BillID == Convert.ToInt32(id));

                txtBillPayableCode.Text = "YF" + dataRow["订单号"].ToString() + (entities.Count + 1).ToString().PadLeft(2, '0');
                if (entities.Count > 0)
                {
                    var payables = entities.Cast<BUSBillPayableEntity>().ToList();
                    var sumPaid = (decimal) payables.Sum(p => p.AccountsPay);
                    txtAccountsPayable.Text = ((decimal) totalPrice - sumPaid).ToString();
                    txtPaid.Text = sumPaid.ToString();
                }
                else
                {
                    txtAccountsPayable.Text = totalPrice.ToString();
                    txtPaid.Text = "0";
                }

                if (id != null)
                {
                    //根据订单设置表格数据
                    this.popupGrid.SetGridData("vw_AllPayableBillDetail", "订单ID", id, true);
                }
            }
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            try
            {
                if (!this.ftPanel.ValidateIsNullFields())
                {
                    return;
                }

                BUSBillPayableEntity entity = this.ftPanel.GetEntity() as BUSBillPayableEntity;

                this.CustomSetEntity(entity);
                if (entity.IsNew(BUSBillPayableEntityFields.BillPayableCode == entity.BillPayableCode))
                {
                    decimal paid = Decimal.Parse(txtPaid.Text);
                    decimal pay = decimal.Parse(txtPayment.Text);

                    decimal total = paid + pay;
                    if (paid == (decimal)entity.TotalPrice)
                    {
                        XtraMessageBox.Show("款项已付清，请检查并重新录入。", "错误", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                        txtPayment.Focus();
                        return;
                    }
                    if (pay <= 0)
                    {
                        XtraMessageBox.Show("付款金额必须大于0，请检查并重新录入。", "错误", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                        txtPayment.Focus();
                        return;
                    }
                    if ((double) total > entity.TotalPrice)
                    {
                        XtraMessageBox.Show("付款金额与已付款金额总和大于订单总额，请检查并重新录入。", "错误", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                        txtPayment.Focus();
                        return;
                    }
                    entity.Save();
                }
                else
                {
                    XtraMessageBox.Show("应付记录已存在，请检查并重新录入。", "错误", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
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

        /// <summary>
        /// 非文本框取值
        /// </summary>
        /// <param name="entity">实体</param>
        protected virtual void CustomGetEntity(BUSBillPayableEntity entity)
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
                txtBillRemark.Text = bill.BillRemark;
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

            if (!bill.IsNullField("TotalPrice"))
            {
                txtTotalPrice.Text = bill.TotalPrice.ToString();
            }
        }

        /// <summary>
        /// 非文本框赋值
        /// </summary>
        /// <param name="entity">实体</param>
        protected virtual void CustomSetEntity(BUSBillPayableEntity entity)
        {
            var dataRow = this.txtBillCode.EditData as DataRow;
            if(null != dataRow)
            {
                entity.BillID = Convert.ToInt32(dataRow["订单ID"]);
                entity.DealerName = this.txtDealerName.Text.Trim();
                entity.DealerCode = dataRow["往来单位编号"].ToString();
            }
            entity.BillPayableCode = txtBillPayableCode.Text.Trim();
            entity.BillCode = txtBillCode.Text.Trim();
            entity.AccountsPay = Convert.ToDouble(txtPayment.Text);
            entity.BillPayableRemark = txtBillPayableRemark.Text.Trim();
            entity.CreateDate = DateTime.Now;
            entity.CreateUserName = GlobalItem.g_CurrentEmployee != null
                ? GlobalItem.g_CurrentEmployee.EmployeeName
                : GlobalItem.g_CurrentUser.UserName;

        }
    }
}