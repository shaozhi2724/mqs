using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using DevExpress.XtraEditors;
using DevExpress.XtraGrid.Views.Grid;
using DevExpress.XtraLayout.Utils;
using DQS.Module.Entities;
using DQS.Common;
using ORMSCore;
using System.Data.SqlClient;

namespace DQS.AppViews.WarehouseOut.WarehouseOutManager
{
    public partial class FrmSingleTransportWithMultipleBill : DevExpress.XtraEditors.XtraForm
    {
        private int? m_id;

        public FrmSingleTransportWithMultipleBill()
        {
            InitializeComponent();
        }

        private void FrmSingleTransportWithMultipleBill_Load(object sender, EventArgs e)
        {
            bool isenabletool = GetSettingValue.GetSettingValueFor("IsEnableBillModify");
            this.popupGrid.InitGrid();
            BindLookupData();
            if (this.Tag != null)
            {
                this.m_id = Convert.ToInt32(this.Tag);

                BUSTransportRecordEntity entity = new BUSTransportRecordEntity { TransportID = m_id.Value };
                entity.Fetch();

                this.ftPanel.SetEntity(entity);

                this.txtTransportCode.Enabled = false;
                txtBillCode.Enabled = false;

                this.CustomGetEntity(entity);
                if (isenabletool)
                {
                    txtShippingAddress.Properties.ReadOnly = true;
                    txtRelatePerson.Properties.ReadOnly = true;
                    txtRelatePersonContact.Properties.ReadOnly = true;
                    dteStartTime.Properties.ReadOnly = true;
                    tmeStartTime.Properties.ReadOnly = true;
                    txtCarryCompnay.Properties.ReadOnly = true;
                    txtTransportType.Properties.ReadOnly = true;
                    txtTransportTool.Properties.ReadOnly = true;
                    txtDeliveryPerson.Properties.ReadOnly = true;
                    txtCommissionedManagers.Properties.ReadOnly = true;
                    txtPopCarCode.Enabled = false;
                    txtCarName.Properties.ReadOnly = true;
                    txtCarNo.Properties.ReadOnly = true;
                    speMinTimeLimit.Properties.ReadOnly = true;
                    txtTransportRemark.Properties.ReadOnly = true;
                }
            }
            else
            {
                if (isenabletool)
                {
                    txtDeliveryPerson.Properties.ReadOnly = true;
                    txtCarNo.Properties.ReadOnly = true;
                    txtCarName.Properties.ReadOnly = true;
                }
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

        private void BindLookupData()
        {
            EntityCollection<BFIEnterpriseAddressEntity> enterpriseAddresses = new EntityCollection<BFIEnterpriseAddressEntity>();
            enterpriseAddresses.Fetch(BFIEnterpriseAddressEntityFields.EnterpriseAddressType == "发货地址");
            foreach (var enterpriseAddress in enterpriseAddresses)
            {
                txtShippingAddress.Properties.Items.Add(
                    (enterpriseAddress as BFIEnterpriseAddressEntity).EnterpriseAddress);
            }
            EntityCollection<BFITransportTypeEntity> transportTypes = new EntityCollection<BFITransportTypeEntity>();
            transportTypes.Fetch();
            foreach (var transportType in transportTypes)
            {
                txtTransportType.Properties.Items.Add(
                    (transportType as BFITransportTypeEntity).TransportTypeName);
            }
            EntityCollection<BFITransportToolEntity> transportTools = new EntityCollection<BFITransportToolEntity>();
            transportTools.Fetch();
            foreach (var transportTool in transportTools)
            {
                txtTransportTool.Properties.Items.Add(
                    (transportTool as BFITransportToolEntity).TransportToolName);
            }
            EntityCollection<BFITransportCompanyEntity> transportCompanys = new EntityCollection<BFITransportCompanyEntity>();
            transportCompanys.Fetch();
            foreach (var company in transportCompanys)
            {
                txtCarryCompnay.Properties.Items.Add(
                    (company as BFITransportCompanyEntity).TransportCompanyName);
            }
        }
        private void SaveLookupData()
        {
            string shippingAddress = txtShippingAddress.Text.Trim();
            if (!string.IsNullOrWhiteSpace(shippingAddress))
            {
                EntityCollection<BFIEnterpriseAddressEntity> enterpriseAddresses =
                    new EntityCollection<BFIEnterpriseAddressEntity>();
                enterpriseAddresses.Fetch(BFIEnterpriseAddressEntityFields.EnterpriseAddressType == "发货地址" &
                                          BFIEnterpriseAddressEntityFields.EnterpriseAddress == shippingAddress);
                if (enterpriseAddresses.Count == 0)
                {
                    BFIEnterpriseAddressEntity addressEntity = new BFIEnterpriseAddressEntity();
                    addressEntity.EnterpriseAddressType = "发货地址";
                    addressEntity.EnterpriseAddress = shippingAddress;
                    addressEntity.Save();
                }
            }

            string transportType = txtTransportType.Text.Trim();
            if (!string.IsNullOrWhiteSpace(transportType))
            {
                EntityCollection<BFITransportTypeEntity> transportTypes = new EntityCollection<BFITransportTypeEntity>();
                transportTypes.Fetch(BFITransportTypeEntityFields.TransportTypeName == transportType);
                if (transportTypes.Count == 0)
                {
                    BFITransportTypeEntity transportTypeEntity = new BFITransportTypeEntity();
                    transportTypeEntity.TransportTypeName = transportType;
                    transportTypeEntity.Save();
                }
            }
            string transportTool = txtTransportTool.Text.Trim();
            if (!string.IsNullOrWhiteSpace(transportTool))
            {
                EntityCollection<BFITransportToolEntity> transportTools = new EntityCollection<BFITransportToolEntity>();
                transportTools.Fetch(BFITransportToolEntityFields.TransportToolName == transportTool);
                if (transportTools.Count == 0)
                {
                    BFITransportToolEntity transportToolEntity = new BFITransportToolEntity();
                    transportToolEntity.TransportToolName = transportTool;
                    transportToolEntity.Save();
                }
            }
            string transportCompany = txtCarryCompnay.Text.Trim();
            if (!string.IsNullOrWhiteSpace(transportCompany))
            {
                EntityCollection<BFITransportCompanyEntity> companys = new EntityCollection<BFITransportCompanyEntity>();
                companys.Fetch(BFITransportCompanyEntityFields.TransportCompanyName == transportCompany);
                if (companys.Count == 0)
                {
                    BFITransportCompanyEntity transportCompanyEntity = new BFITransportCompanyEntity();
                    transportCompanyEntity.TransportCompanyName = transportCompany;
                    transportCompanyEntity.Save();
                }
            }
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            if (!this.ftPanel.ValidateIsNullFields()) return;

            if (dteArriveTime.Text.Trim() != "")
            {
                if (Convert.ToDateTime(dteStartTime.Text.Trim()) > Convert.ToDateTime(dteArriveTime.Text.Trim()))
                {
                    XtraMessageBox.Show("到达日期不能在启运日期前，请重新填写。", "提示", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                    return;
                }
            }

            if (string.IsNullOrWhiteSpace(txtTransportType.Text))
            {
                XtraMessageBox.Show(txtTransportType.Properties.NullValuePrompt, "警告", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                txtTransportType.Focus();
                return;
            }
            if (string.IsNullOrWhiteSpace(txtTransportTool.Text))
            {
                XtraMessageBox.Show(txtTransportTool.Properties.NullValuePrompt, "警告", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                txtTransportTool.Focus();
                return;
            }
            if (string.IsNullOrWhiteSpace(txtShippingAddress.Text))
            {
                XtraMessageBox.Show("请选择或输入发货地址", "警告", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                return;
            }
            SaveLookupData();

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

            this.txtBillCode.SetMemberValue(entity.BillID);
            if (!entity.IsNullField("BillID"))
            {
                this.txtBillCode.SetMemberValue(entity.BillID);

                //根据订单设置表格数据
                this.popupGrid.SetGridData("vw_AllTransportReviewDetail", "订单ID", entity.BillID, true);
            }

            if (!entity.IsNullField("CarID"))
            {
                this.txtPopCarCode.SetMemberValue(entity.CarID);

                this.txtCarNo.Text = (this.txtPopCarCode.EditData as DataRow)["车牌号"].ToString();
                this.txtCarName.Text = (this.txtPopCarCode.EditData as DataRow)["车辆名称"].ToString();
            }
            else if (!entity.IsNullField("CarCode"))
            {
                this.txtCarNo.Text = entity.CarCode;
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
            if (!entity.IsNullField("ShippingAddress"))
            {
                this.txtShippingAddress.Text = entity.ShippingAddress;
            }
            if (!entity.IsNullField("CarryCompnay"))
            {
                this.txtCarryCompnay.Text = entity.CarryCompnay;
            }
            if (!entity.IsNullField("TransportType"))
            {
                this.txtTransportType.Text = entity.TransportType;
            }
            if (!entity.IsNullField("TransportStyle"))
            {
                this.txtTransportTool.Text = entity.TransportStyle;
            }
        }

        /// <summary>
        /// 非文本框赋值
        /// </summary>
        protected virtual void CustomSetEntity(BUSTransportRecordEntity transportEntity)
        {
            if (this.txtBillCode.EditData != null)
            {
                foreach (DataRow dataRow in txtBillCode.EditData)
                {
                    var billId = (int) dataRow["订单ID"];
                    BUSBillEntity bill = new BUSBillEntity {BillID = billId};
                    bill.Fetch();

                    var entity = new BUSTransportRecordEntity
                    {
                        BillID = billId,
                        BillCode = dataRow["订单编号"].ToString(),
                        DealerID = (int) dataRow["往来单位ID"],
                        DealerCode = dataRow["往来单位编号"].ToString(),
                        RelateAddress = bill.DealerAddress,
                        RelateCompany = bill.DealerName,
                        TransportCode = txtTransportCode.Text.Trim(),
                        ShippingAddress = txtShippingAddress.Text.Trim(),
                        CarryCompnay = txtCarryCompnay.Text.Trim(),
                        CommissionedManagers = txtCommissionedManagers.Text.Trim(),
                        TransportType = txtTransportType.Text.Trim(),
                        TransportStyle = txtTransportTool.Text.Trim(),
                        TransportRemark = txtTransportRemark.Text.Trim(),
                        CarCode = txtCarNo.Text.Trim()
                    };
                    //entity.RelateAddress = transportEntity.RelateAddress;
                    //entity.RelateCompany = transportEntity.RelateCompany;
                    //entity.RelateCompanySpell = transportEntity.RelateCompanySpell;
                    //entity.RelatePersonContact = transportEntity.RelatePersonContact;
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
                    if (this.m_id != null)
                    {
                        entity.TransportID = this.m_id.Value;
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
                        using (SqlConnection conn = new SqlConnection(GlobalItem.g_DbConnectStrings))
                        {
                            string sqlBill = "EXEC sp_UpdateStatusForOut '{0}','{1}','{2}'";

                            try
                            {
                                conn.Open();//连接数据库
                                if (entity.TransportStatusID != 1)
                                {
                                    SqlCommand Bcommand = new SqlCommand(string.Format(sqlBill, entity.BillCode, "运输结束", GlobalItem.g_CurrentEmployee.EmployeeName), conn);
                                    Bcommand.ExecuteNonQuery();
                                }
                            }
                            catch (Exception ex)
                            {
                                XtraMessageBox.Show(ex.ToString(), "系统提示", MessageBoxButtons.OK, MessageBoxIcon.Error);
                            }
                            finally
                            {
                                conn.Close();
                            }
                        }
                    }
                    else
                    {
                        //if (entity.IsNew())
                        //{
                        entity.CreateDate = DateTime.Now;
                        entity.LastModifyDate = DateTime.Now;
                        entity.CreateUserID = GlobalItem.g_CurrentUser.UserID;
                        entity.LastModifyUserID = GlobalItem.g_CurrentUser.UserID;
                        entity.Save();

                        EntityCollection<BUSTransportRecordEntity> transportEntityCollection =
                            new EntityCollection<BUSTransportRecordEntity>();
                        transportEntityCollection.Fetch(BUSTransportRecordEntityFields.BillID == entity.BillID);
                        if (transportEntityCollection.Count > 0)
                        {
                            BUSBillEntity billEntity = new BUSBillEntity {BillID = entity.BillID};
                            billEntity.Fetch();
                            billEntity.TransportID =
                                (transportEntityCollection[0] as BUSTransportRecordEntity).TransportID;
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

                            using (SqlConnection conn = new SqlConnection(GlobalItem.g_DbConnectStrings))
                            {
                                string sqlBill = "EXEC sp_UpdateStatusForOut '{0}','{1}','{2}'";

                                try
                                {
                                    conn.Open();//连接数据库
                                    SqlCommand Bcommand = new SqlCommand(string.Format(sqlBill, entity.BillCode, "正在运输", GlobalItem.g_CurrentEmployee.EmployeeName), conn);
                                    Bcommand.ExecuteNonQuery();
                                    if (entity.TransportStatusID != 1)
                                    {
                                        Bcommand = new SqlCommand(string.Format(sqlBill, entity.BillCode, "运输结束", GlobalItem.g_CurrentEmployee.EmployeeName), conn);
                                        Bcommand.ExecuteNonQuery();
                                    }
                                }
                                catch (Exception ex)
                                {
                                    XtraMessageBox.Show(ex.ToString(), "系统提示", MessageBoxButtons.OK, MessageBoxIcon.Error);
                                }
                                finally
                                {
                                    conn.Close();
                                }
                            }
                        }
                        //}
                        //else
                        //{
                        //    XtraMessageBox.Show("运输单号已存在。", "警告", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                        //    return;
                        //}
                    }
                }
            }
        }

        private void txtBillCode_PopupClosing(object sender, EventArgs e)
        {
            if (this.txtBillCode.EditData != null)
            {
                List<string> values = new List<string>();
                List<int> billIDs = new List<int>();
                List<string> filters = new List<string>();
                foreach (DataRow dataRow in txtBillCode.EditData)
                {
                    filters.Add(string.Format("[订单ID]='{0}'", dataRow.ItemArray[1].ToString()));

                    values.Add(dataRow.ItemArray[2].ToString());
                }

                txtBillCode.Text = string.Join(",", values);
                if (values.Count > 1)
                {
                    layRelateAddress.Visibility = LayoutVisibility.Never;
                    layRelateCompany.Visibility = LayoutVisibility.Never;
                }
                else
                {
                    layRelateAddress.Visibility = LayoutVisibility.Always;
                    layRelateCompany.Visibility = LayoutVisibility.Always;
                    this.txtRelateCompany.Text = this.txtBillCode.EditData[0]["往来单位名称"].ToString();
                    this.txtRelateAddress.Text = (this.txtBillCode.EditData[0])["收货地址"].ToString();
                    this.txtRelateAddress.Focus();
                }

                var filter = string.Join(" OR ", filters);
                //根据订单设置表格数据
                this.popupGrid.SetGridData("vw_AllTransportReviewDetail", filter, true);
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
                this.txtDeliveryPerson.Text = (this.txtPopCarCode.EditData as DataRow)["行驶证车主"].ToString();
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