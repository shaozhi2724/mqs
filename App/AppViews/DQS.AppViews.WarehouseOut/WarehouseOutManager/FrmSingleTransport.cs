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

namespace DQS.AppViews.WarehouseOut.WarehouseOutManager
{
    public partial class FrmSingleTransport : DevExpress.XtraEditors.XtraForm
    {
        private int? m_id;

        public FrmSingleTransport()
        {
            InitializeComponent();
        }

        private void FrmSingleTransport_Load(object sender, EventArgs e)
        {
            this.popupGrid.InitGrid();

            if (this.Tag != null)
            {
                this.m_id = Convert.ToInt32(this.Tag);

                BUSTransportRecordEntity entity = new BUSTransportRecordEntity { TransportID = m_id.Value };
                entity.Fetch();

                this.ftPanel.SetEntity(entity);

                this.txtTransportCode.Enabled = false;

                this.CustomGetEntity(entity);
            }
            else
            {
                this.txtTransportCode.Text = "YS" + DateTime.Now.ToString("yyyyMMddHHmmss");
                this.txtTransportCode.Select(this.txtTransportCode.Text.Length, 0);

                this.dteStartTime.DateTime = DateTime.Now;
                this.tmeStartTime.Time = DateTime.Now;

                if (GlobalItem.g_CurrentEmployee != null)
                {
                    this.txtDeliveryPerson.Text = GlobalItem.g_CurrentEmployee.EmployeeName;
                }
                else
                {
                    txtDeliveryPerson.Text = GlobalItem.g_CurrentUser.UserName;
                }
            }
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            if (!this.ftPanel.ValidateIsNullFields()) return;

            BUSTransportRecordEntity entity = this.ftPanel.GetEntity() as BUSTransportRecordEntity;

            try
            {
                this.CustomSetEntity(entity);
            }
            catch (Exception ex)
            {
                XtraMessageBox.Show(ex.Message, "警告", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                return;
            }

            if (this.m_id != null)
            {
                entity.LastModifyDate = DateTime.Now;
                entity.LastModifyUserID = GlobalItem.g_CurrentUser.UserID;
                entity.Update();

                BUSBillEntity billEntity = new BUSBillEntity();
                billEntity.BillID = entity.BillID;

                if (entity.TransportStatusID == 1)
                {
                    billEntity.BillStatus = 5;
                    billEntity.BillStatusName = "正在运输";
                }
                else
                {
                    billEntity.BillStatus = 6;
                    billEntity.BillStatusName = "运输结束";
                }
                billEntity.Update();
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

                    BUSBillEntity billEntity = new BUSBillEntity { BillID = entity.BillID, TransportID = entity.TransportID };
                    if (entity.TransportStatusID == 1)
                    {
                        billEntity.BillStatus = 5;
                        billEntity.BillStatusName = "正在运输";
                    }
                    else
                    {
                        billEntity.BillStatus = 6;
                        billEntity.BillStatusName = "运输结束";
                    }
                    billEntity.Update();
                }
                else
                {
                    XtraMessageBox.Show("运输单号已存在。", "警告", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
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
        protected virtual void CustomGetEntity(BUSTransportRecordEntity entity)
        {
            if (!entity.IsNullField("BillID"))
            {
                this.txtBillCode.SetMemberValue(entity.BillID);

                //根据订单设置表格数据
                this.popupGrid.SetGridData("vw_AllStockOutDeatil", "订单ID", entity.BillID, true);
            }

            if (!entity.IsNullField("CarID"))
            {
                this.txtPopCarCode.SetMemberValue(entity.CarID);

                this.txtCarNo.Text = (this.txtPopCarCode.EditData as DataRow)["车牌号"].ToString();
                this.txtCarName.Text = (this.txtPopCarCode.EditData as DataRow)["车辆名称"].ToString();
            }

            if (!entity.IsNullField("MinTimeLimit"))
            {
                speMinTimeLimit.Value = Convert.ToDecimal(entity.MinTimeLimit);
            }

            if (!entity.IsNullField("StartTime"))
            {
                dteStartTime.DateTime = entity.StartTime;
                tmeStartTime.Time = entity.StartTime;
            }

            if (!entity.IsNullField("ArriveTime"))
            {
                dteArriveTime.DateTime = entity.ArriveTime;
                tmeArriveTime.Time = entity.ArriveTime;
            }

            if (!entity.IsNullField("RelatePerson"))
            {
                this.txtRelatePerson.Text = entity.RelatePerson;
            }

            if (!entity.IsNullField("DeliveryPerson"))
            {
                this.txtDeliveryPerson.Text = entity.DeliveryPerson;
            }
        }

        /// <summary>
        /// 非文本框赋值
        /// </summary>
        /// <param name="entity">实体</param>
        protected virtual void CustomSetEntity(BUSTransportRecordEntity entity)
        {
            if (this.txtBillCode.SelectedValue != null)
            {
                entity.BillID = Convert.ToInt32(this.txtBillCode.SelectedValue);
                entity.BillCode = this.txtBillCode.Text.Trim();
                if (this.txtBillCode.EditData != null)
                {
                    entity.DealerID = Convert.ToInt32((this.txtBillCode.EditData as DataRow)["往来单位ID"]);
                    entity.DealerCode = (this.txtBillCode.EditData as DataRow)["往来单位编号"].ToString();
                }
            }

            if (this.txtPopCarCode.SelectedValue != null)
            {
                entity.CarID = Convert.ToInt32(this.txtPopCarCode.SelectedValue);
                entity.CarCode = this.txtPopCarCode.Text.Trim();
            }

            if (this.speMinTimeLimit.Value > 0)
            {
                entity.MinTimeLimit = Convert.ToDouble(this.speMinTimeLimit.Value);
            }

            if (!string.IsNullOrEmpty(dteStartTime.Text))
            {
                entity.StartTime = Convert.ToDateTime(String.Format("{0:yyyy-MM-dd} {1:HH:mm:ss}", dteStartTime.DateTime, tmeStartTime.Time));
            }
            else
            {
                dteStartTime.Focus();
                throw new Exception("起运日期不能为空。");
            }

            if (!string.IsNullOrEmpty(dteArriveTime.Text))
            {
                entity.ArriveTime = Convert.ToDateTime(String.Format("{0:yyyy-MM-dd} {1:HH:mm:ss}", dteArriveTime.DateTime, tmeArriveTime.Time));
            }

            if (!entity.IsNullField("StartTime") && !entity.IsNullField("ArriveTime"))
            {
                //运输结束
                entity.TransportStatusID = 2;
                entity.TransportStatus = "运输结束";
            }
            else
            {
                //正在运输
                //运输结束
                entity.TransportStatusID = 1;
                entity.TransportStatus = "正在运输";
            }

            if (this.txtRelatePerson.Text.Trim() != "")
            {
                entity.RelatePerson = this.txtRelatePerson.Text.Trim();
                entity.RelatePersonSpell = GlobalMethod.GetAlphabetic(entity.RelatePerson);
            }

            if (this.txtDeliveryPerson.Text.Trim() != "")
            {
                entity.DeliveryPerson = this.txtDeliveryPerson.Text.Trim();
                entity.DeliverySpell = GlobalMethod.GetAlphabetic(entity.DeliveryPerson);
            }

        }

        private void txtBillCode_PopupClosing(object sender, EventArgs e)
        {
            if (this.txtBillCode.EditData != null)
            {
                this.txtRelateCompany.Text = (this.txtBillCode.EditData as DataRow)["往来单位名称"].ToString();
                this.txtRelateAddress.Text = (this.txtBillCode.EditData as DataRow)["收货地址"].ToString();
                this.txtRelateAddress.Focus();

                object id = (this.txtBillCode.EditData as DataRow)["订单ID"].ToString();

                if (id != null)
                {
                    //根据订单设置表格数据
                    this.popupGrid.SetGridData("vw_AllStockOutDeatil", "订单ID", id, true);
                }
            }
        }

        private void txtRelatePerson_PopupClosing(object sender, EventArgs e)
        {
            if (this.txtRelatePerson.EditData != null)
            {
                this.txtRelatePersonContact.Text = (this.txtRelatePerson.EditData as DataRow)["手机"].ToString();
                this.txtPopCarCode.Focus();
            }
        }

        private void txtPopCarCode_PopupClosing(object sender, EventArgs e)
        {
            if (this.txtPopCarCode.EditData != null)
            {
                this.txtCarNo.Text = (this.txtPopCarCode.EditData as DataRow)["车牌号"].ToString();
                this.txtCarName.Text = (this.txtPopCarCode.EditData as DataRow)["车辆名称"].ToString();
                this.txtTransportRemark.Focus();
            }
        }

        private void txtRelatePerson_BeforePopupShow(object sender, DQS.Controls.CommonCode.BeforePopupShowArgs e)
        {
            if (this.txtRelateCompany.Text.Trim() != "")
            {
                this.txtRelatePerson.Filter = String.Format("所属单位 = '{0}'", this.txtRelateCompany.Text.Trim());
            }
        }

        private void btnTemperature_Click(object sender, EventArgs e)
        {
            if (this.m_id != null)
            {
                using (FrmTransportAttachment frmTransportAttachment = new FrmTransportAttachment(m_id.Value))
                {
                    frmTransportAttachment.ShowDialog();
                }
            }
        }

        
    }
}