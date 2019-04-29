﻿using System;
using System.Collections.Generic;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Windows.Forms;
using DevExpress.Utils;
using DevExpress.XtraEditors;
using DQS.Module.Entities;
using DQS.Module.Views;
using ORMSCore;
using DQS.Common;
using DQS.Controls;
using System.IO;

namespace DQS.AppViews.WarehouseIn.WarehouseInManager
{
    public partial class FrmSingleReceive : DevExpress.XtraEditors.XtraForm
    {
        private int? m_id;

        public FrmSingleReceive()
        {
            InitializeComponent();
        }

        private void FrmSingleReceive_Load(object sender, EventArgs e)
        {
            this.popupGrid.InitGrid();
            BindLookupData();
            if (this.Tag != null)
            {
                this.m_id = Convert.ToInt32(this.Tag);

                this.btnReCheck.Enabled = false;

                BUSReceiveEntity entity = new BUSReceiveEntity { ReceiveID = m_id.Value };
                entity.Fetch();

                this.ftPanel.SetEntity(entity);

                this.txtBillCode.Enabled = false;
                this.txtReceiveCode.Enabled = false;

                this.CustomGetEntity(entity);

                this.popupGrid.SetGridData(m_id.Value, true);

            }
            else
            {
                this.dateTransportDate.Text = DateTime.Now.ToString("yyyy-MM-dd HH:mm:ss");
                this.txtArriveTime.Text = DateTime.Now.ToString("yyyy-MM-dd HH:mm:ss");

                this.txtReceiveCode.Text = "SH" + DateTime.Now.ToString("yyyyMMddHHmmss");
                this.txtReceiveCode.Select(this.txtReceiveCode.Text.Length, 0);

                if (GlobalItem.g_CurrentEmployee != null)
                {
                    this.txtReceivePerson.Text = GlobalItem.g_CurrentEmployee.EmployeeName;
                }
                else
                {
                    this.txtReceivePerson.Text = GlobalItem.g_CurrentUser.UserName;
                }
            }

            if (txtBillTypeName.Text.Trim() == "采购进货")
            {
                for (int i = 0; i < popupGrid.PopupView.Columns.Count; i++)
                {
                    string ColumnName = popupGrid.PopupView.Columns[i].ToString();
                    if (ColumnName.Contains("批号") || ColumnName.Contains("生产日期") || ColumnName.Contains("有效期至"))
                    {
                        popupGrid.PopupView.Columns[i].Visible = false;
                    }
                }
            }
            //RenderRequiredFields();
        }

        private void RenderRequiredFields()
        {
            foreach (Control control in layControl.Controls)
            {
                if (control is TextBoxEx)
                {
                    TextBoxEx ctl = ((TextBoxEx)control);
                    if (ctl.IsNullValidate)
                    {
                        layControl.GetItemByControl(ctl).AppearanceItemCaption.ForeColor = Color.Red;
                    }
                }
                if (control is ComboBoxEdit)
                {
                    var ctl = ((ComboBoxEdit)control);
                    if (ctl.Properties.AllowNullInput == DefaultBoolean.False)
                    {
                        layControl.GetItemByControl(ctl).AppearanceItemCaption.ForeColor = Color.Red;
                    }
                }
                if (control is DateEdit)
                {
                    var ctl = ((DateEdit)control);
                    if (ctl.Properties.AllowNullInput == DefaultBoolean.False)
                    {
                        layControl.GetItemByControl(ctl).AppearanceItemCaption.ForeColor = Color.Red;
                    }
                }
            }
        }
        private void BindLookupData()
        {
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
        }
        private void SaveLookupData()
        {
            string transportToolName = txtTransportTool.Text.Trim();
            EntityCollection<BFITransportToolEntity> transportTools = new EntityCollection<BFITransportToolEntity>();
            transportTools.Fetch(BFITransportToolEntityFields.TransportToolName == transportToolName);
            if (transportTools.Count == 0)
            {
                BFITransportToolEntity entity = new BFITransportToolEntity();
                entity.TransportToolName = transportToolName;
                entity.Save();
            }
            string transportTypeName = txtTransportType.Text.Trim();
            EntityCollection<BFITransportTypeEntity> transportTypes = new EntityCollection<BFITransportTypeEntity>();
            transportTypes.Fetch(BFITransportTypeEntityFields.TransportTypeName == transportTypeName);
            if (transportTypes.Count == 0)
            {
                BFITransportTypeEntity entity = new BFITransportTypeEntity();
                entity.TransportTypeName = transportTypeName;
                entity.Save();
            }

        }
        private void btnSave_Click(object sender, EventArgs e)
        {
            try
            {
                if (!this.ftPanel.ValidateIsNullFields()) return;
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
                if (!ValidateDealerQualification()) return;
                if (txtBillTypeName.Text.Trim() != "销售退货")
                {
                    if (!ValidateProductQualification()) return;
                }
                
                SaveLookupData();
                BUSReceiveEntity entity = this.ftPanel.GetEntity() as BUSReceiveEntity;

                this.CustomSetEntity(entity);

                if (this.m_id != null)
                {
                    #region 修改

                    List<EntityBase> children = this.popupGrid.GetEntities();
                    List<BUSReceiveDetailEntity> busReceiveDetailEntities = children.Cast<BUSReceiveDetailEntity>().ToList();
                    if (busReceiveDetailEntities.Any(p => p.ReceiveAmount > p.Amount))
                    {
                        XtraMessageBox.Show("收货数量不能大于订单数量。", "警告", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                        return;
                    }

                    if (busReceiveDetailEntities.Any(p => p.ReceiveAmount < p.Amount))
                    {
                        var dialogResult = XtraMessageBox.Show("是否走拒收流程", "警告", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
                        switch (dialogResult)
                        {
                            //选择“取消”，不保存，手动修改
                            case DialogResult.Cancel:
                            case DialogResult.No:
                                return;
                            //选择是，提示：“收货数量与订单数量不符，是否拒收，选择是，生成拒收单，选择否，自动更改收货数量与订单数量一致”，自动保存。
                            case DialogResult.Yes:
                                var dialogResult2 = XtraMessageBox.Show("收货数量与订单数量不符，是否拒收，选择是，生成拒收单，选择否，自动更改收货数量与订单数量一致", "警告", MessageBoxButtons.YesNoCancel, MessageBoxIcon.Question);
                                if (DialogResult.Cancel == dialogResult2)
                                {
                                    return;
                                }

                                if (DialogResult.Yes == dialogResult2) //生成拒收单
                                {
                                    GenerateDeclinedBill(entity, busReceiveDetailEntities);
                                    busReceiveDetailEntities.RemoveAll(p => p.ReceiveAmount == 0 || p.Amount == 0);
                                }
                                else if (DialogResult.No == dialogResult2)
                                {
                                    ChangeReceiveAmountToAmount(busReceiveDetailEntities); //自动更改收货数量与订单数量一致
                                }
                                break;
                        }
                    }
                    entity.LastModifyDate = DateTime.Now;
                    entity.LastModifyUserID = GlobalItem.g_CurrentUser.UserID;

                    if (!busReceiveDetailEntities.Any() || busReceiveDetailEntities.TrueForAll(p => p.ReceiveAmount == 0))
                    {

                        BUSBillEntity bill = new BUSBillEntity { BillID = entity.BillID, };
                        bill.Fetch();
                        if (bill.BillStatusName != "收货复查")
                        {
                            entity.ReceiveStatusID = 2;
                            entity.ReceiveStatus = "拒收";
                            entity.ReceiveStatusSpell = "js";

                            //更新订单状态
                            BUSBillEntity billEntity = new BUSBillEntity
                            {
                                BillID = entity.BillID,
                                BillStatus = 6,
                                BillStatusName = "拒收"
                            };
                            billEntity.Update();
                        }
                    }
                    else
                    {
                        if (!busReceiveDetailEntities.Any(p => p.ReceiveAmount < p.Amount))
                        {
                            BUSDeclinedEntity dec = new BUSDeclinedEntity { DeclinedCode = "SHJS-" + entity.ReceiveCode };
                            dec.Fetch();
                            if (!dec.IsNullField("DeclinedID"))
                            {
                                //删除拒收明细
                                BUSDeclinedDetailEntity decDelete = new BUSDeclinedDetailEntity { DeclinedID = dec.DeclinedID };
                                decDelete.DeleteByCommonly();
                                //删除拒收单
                                dec.Delete();
                            }
                        }

                        entity.Update();

                        //先删除
                        BUSReceiveDetailEntity childToDelete = new BUSReceiveDetailEntity {ReceiveID = m_id.Value};
                        childToDelete.DeleteByCommonly();

                        //后加
                        foreach (BUSReceiveDetailEntity child in busReceiveDetailEntities)
                        {

                            child.ReceiveID = m_id.Value;
                            child.Reservation2 = (child.ReceiveAmount * double.Parse(child.Reservation1)).ToString();
                            child.Save();
                        }

                        if (entity.ReceiveStatusID == 1)
                        {
                            //更新订单状态
                            BUSBillEntity billEntity = new BUSBillEntity
                            {
                                BillID = entity.BillID
                            };
                            billEntity.Fetch();
                            if (billEntity.BillStatusName != "收货复查")
                            {
                                billEntity.BillStatus = 3;
                                billEntity.BillStatusName = "已收货";
                            }
                            billEntity.ReceiveID = m_id.Value;
                            billEntity.ReceiveCode = entity.ReceiveCode;
                            billEntity.Update();
                        }
                        //else
                        //{
                        //    //更新订单状态
                        //    BUSBillEntity billEntity = new BUSBillEntity { BillID = entity.BillID, BillStatus = 6, BillStatusName = "拒收" };
                        //    billEntity.Update();
                        //}
                    }

                    #endregion
                }
                else
                {
                    if (Convert.ToInt32(txtTransportTime.Text) > Convert.ToInt32(txtTimeLimit.Text))
                    {
                        XtraMessageBox.Show("在途时间超过运输时限，不允许收货。", "系统提示", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        return;
                    }
                    if (entity.IsNew(BUSReceiveEntityFields.ReceiveCode == entity.ReceiveCode))
                    {
                        #region 新建

                        List<EntityBase> children = this.popupGrid.GetEntities();
                        List<BUSReceiveDetailEntity> busReceiveDetailEntities = children.Cast<BUSReceiveDetailEntity>().ToList();
                        if (busReceiveDetailEntities.Any(p => p.ReceiveAmount > p.Amount))
                        {
                            XtraMessageBox.Show("收货数量不能大于订单数量。", "警告", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                            return;
                        }

                        if (busReceiveDetailEntities.Any(p => p.ReceiveAmount < p.Amount))
                        {
                            var dialogResult = XtraMessageBox.Show("是否走拒收流程", "警告", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
                            switch (dialogResult)
                            {
                                //选择“否”，不保存，手动修改
                                case DialogResult.Cancel:
                                case DialogResult.No:
                                    return;
                                //选择是，提示：“收货数量与订单数量不符，是否拒收，选择是，生成拒收单，选择否，自动更改收货数量与订单数量一致”，自动保存。
                                case DialogResult.Yes:
                                    var dialogResult2 = XtraMessageBox.Show("收货数量与订单数量不符，是否拒收，选择是，生成拒收单，选择否，自动更改收货数量与订单数量一致", "警告", MessageBoxButtons.YesNoCancel, MessageBoxIcon.Question);
                                    if (DialogResult.Cancel == dialogResult2)
                                    {
                                        return;
                                    }

                                    if (DialogResult.Yes == dialogResult2) //生成拒收单
                                    {
                                        GenerateDeclinedBill(entity, busReceiveDetailEntities);
                                        busReceiveDetailEntities.RemoveAll(p => p.ReceiveAmount == 0 || p.Amount == 0);
                                    }
                                    else if (DialogResult.No == dialogResult2)
                                    {
                                        ChangeReceiveAmountToAmount(busReceiveDetailEntities); //自动更改收货数量与订单数量一致
                                    }
                                    break;
                            }
                        }
                        entity.ReceiveDate = DateTime.Now;
                        entity.CreateDate = DateTime.Now;
                        entity.LastModifyDate = DateTime.Now;
                        entity.CreateUserID = GlobalItem.g_CurrentUser.UserID;
                        entity.LastModifyUserID = GlobalItem.g_CurrentUser.UserID;
                        if (!busReceiveDetailEntities.Any() || busReceiveDetailEntities.TrueForAll(p => p.ReceiveAmount == 0))
                        {
                            entity.ReceiveStatusID = 2;
                            entity.ReceiveStatus = "拒收";
                            entity.ReceiveStatusSpell = "js";

                            //更新订单状态
                            BUSBillEntity billEntity = new BUSBillEntity { BillID = entity.BillID, BillStatus = 6, BillStatusName = "拒收" };
                            billEntity.Update();
                        }
                        else
                        {
                            entity.Save();

                            //BUSBillEntity bill = new BUSBillEntity { BillID = entity.BillID, BillStatus = 3, BillStatusName = "已收货" };
                            //bill.Update();

                            //查询出其ID
                            entity.Fetch();

                            foreach (BUSReceiveDetailEntity child in busReceiveDetailEntities)
                            {
                                child.ReceiveID = entity.ReceiveID;
                                child.Reservation2 = (child.ReceiveAmount * double.Parse(child.Reservation1)).ToString();
                                child.Save();
                            }

                            if (entity.ReceiveStatusID == 1)
                            {
                                //更新订单状态
                                BUSBillEntity billEntity = new BUSBillEntity
                                {
                                    
                                    BillID = entity.BillID,
                                    BillStatus = 3,
                                    BillStatusName = "已收货"
                                };
                                billEntity.ReceiveID = entity.ReceiveID;
                                billEntity.ReceiveCode = entity.ReceiveCode;
                                billEntity.Update();
                            }
                            //else
                            //{
                            //    //更新订单状态
                            //    BUSBillEntity billEntity = new BUSBillEntity { BillID = entity.BillID, BillStatus = 6, BillStatusName = "拒收" };
                            //    billEntity.Update();
                            //}

                        }

                        #endregion
                    }
                    else
                    {
                        XtraMessageBox.Show("收货单号已存在。", "警告", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                        return;
                    }
                }
            }
            catch (Exception ex)
            {
                XtraMessageBox.Show(ex.Message, "错误", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                return;
            }

            this.DialogResult = DialogResult.OK;
        }

        private void GenerateDeclinedBill(BUSReceiveEntity receiveEntity,
            List<BUSReceiveDetailEntity> busReceiveDetailEntities)
        {
            String reason = "";
            String handle = "";
            using (FrmAcceptDeclinedReason frm = new FrmAcceptDeclinedReason())
            {
                var dialog = frm.ShowDialog();
                if (dialog == DialogResult.OK)
                {
                    reason = frm.reason;
                    handle = frm.handle;
                }
            }
            BUSDeclinedEntity entity = new BUSDeclinedEntity
            {
                BillID = receiveEntity.BillID,
                BillCode = receiveEntity.BillCode,
                BillDate = receiveEntity.BillDate,
                BillTypeID = receiveEntity.BillTypeID,
                BillTypeName = receiveEntity.BillTypeName,
                BillTypeSpell = receiveEntity.BillTypeSpell,
                CarryCompnay = receiveEntity.CarryCompnay,
                CarryCompnaySpell = receiveEntity.CarryCompnaySpell,
                CarryPerson = receiveEntity.CarryPerson,
                CarryPersonContact = receiveEntity.CarryPersonContact,
                CarryPersonSpell = receiveEntity.CarryPersonSpell,
                DealerID = receiveEntity.DealerID,
                DealerCode = receiveEntity.DealerCode,
                DealerName = receiveEntity.DealerName,
                DealerSpell = receiveEntity.DealerSpell,
                CreateDate = DateTime.Now,
                CreateUserID = GlobalItem.g_CurrentUser.UserID,
                DeclinedDate = DateTime.Now,
                DeclinedType = "收货拒收",
                DeclinedCode = "SHJS-" + receiveEntity.BillCode,
                Reservation1 = reason,
                Reservation2 = handle
            };
            receiveEntity.ReceiveRemark = string.Format("收货数量与订单数量不符，收货拒收单号:{0}", entity.DeclinedCode);
            if (null != GlobalItem.g_CurrentEmployee)
            {
                entity.DeclinedPerson = GlobalItem.g_CurrentEmployee.EmployeeName;
                entity.DeclinedPersonSpell = GlobalItem.g_CurrentEmployee.EmployeeSpell;
            }

            if (!receiveEntity.IsNullField("TransportID"))
            {
                entity.TransportID = receiveEntity.TransportID;
            }
            if (!string.IsNullOrWhiteSpace(receiveEntity.TransportCode))
            {
                entity.TransportCode = receiveEntity.TransportCode;
            }
            if (!entity.IsNew(BUSDeclinedEntityFields.DeclinedCode == entity.DeclinedCode))
            {
                entity.LastModifyDate = DateTime.Now;
                entity.LastModifyUserID = GlobalItem.g_CurrentUser.UserID;
                entity.Update();
                entity.Fetch();
                BUSDeclinedDetailEntity childToDelete = new BUSDeclinedDetailEntity { DeclinedID = entity.DeclinedID };
                childToDelete.DeleteByCommonly();
            }
            else
            {
                entity.Save();
            }
            entity.Fetch();
            var receiveDetails = busReceiveDetailEntities.Where(p => p.ReceiveAmount < p.Amount);
            foreach (var receiveDetail in receiveDetails)
            {
               var declinedDetail = new BUSDeclinedDetailEntity
                {
                    DeclinedID = entity.DeclinedID,
                    ProductID = receiveDetail.ProductID,
                    Amount = receiveDetail.Amount,
                    DeclinedAmount = receiveDetail.Amount - receiveDetail.ReceiveAmount,
                    CreateUserID = GlobalItem.g_CurrentUser.UserID,
                    CreateDate = DateTime.Now,
                    DetailRemark = string.Format("{0} - 收货拒收 {1} (总数:{2}，收货：{3}，拒收：{4})", receiveEntity.BillCode, receiveDetail.ProductID, receiveDetail.Amount, receiveDetail.ReceiveAmount, receiveDetail.Amount - receiveDetail.ReceiveAmount)
                };
                if (!receiveDetail.IsNullField("ProduceDate"))
                {
                    declinedDetail.ProduceDate = receiveDetail.ProduceDate;
                }
                if (!receiveDetail.IsNullField("ValidateDate"))
                {
                    declinedDetail.ValidateDate = receiveDetail.ValidateDate;
                }
                if (!receiveDetail.IsNullField("BatchNo"))
                {
                    declinedDetail.BatchNo = receiveDetail.BatchNo;
                }
                else
                {
                    using (FrmReceiveDeclinedDetail frm = new FrmReceiveDeclinedDetail(receiveDetail.ProductID))
                    {
                        var result = frm.ShowDialog();
                        if (result == DialogResult.OK)
                        {
                            declinedDetail.BatchNo = frm.batchno;
                        }
                    }
                }
                declinedDetail.Save();
            }
        }

        private void ChangeReceiveAmountToAmount(List<BUSReceiveDetailEntity> busReceiveDetailEntities)
        {
            busReceiveDetailEntities.ForEach(p =>
            {
                p.ReceiveAmount = p.Amount;
            });
        }

        private void ChangeAmountToReceiveAmount(List<BUSReceiveDetailEntity> busReceiveDetailEntities)
        {
            busReceiveDetailEntities.ForEach(p =>
            {
                p.Amount = p.ReceiveAmount;
            });

        }
        private void ChangeAmountToReceiveAmount(int billID, List<BUSReceiveDetailEntity> busReceiveDetailEntities)
        {
            busReceiveDetailEntities.ForEach(p =>
            {
                p.Amount = p.ReceiveAmount;

                BUSBillEntity billEntity = new BUSBillEntity
                {
                    BillID = billID
                };
                billEntity.Fetch();

                if (billEntity.BillTypeName == "销售退货")
                {
                    EntityCollection<BUSBillDetailEntity> billDetails = new EntityCollection<BUSBillDetailEntity>();
                    //var batchNo = p.BatchNo.ToString();
                    //billDetails.Fetch(BUSBillDetailEntityFields.BillID == billID & BUSBillDetailEntityFields.ProductID == p.ProductID & BUSBillDetailEntityFields.BatchNo == batchNo);
                    billDetails.Fetch(BUSBillDetailEntityFields.BillID == billID & BUSBillDetailEntityFields.ProductID == p.ProductID);
                    foreach (BUSBillDetailEntity billDetail in billDetails)
                    {
                        if (!billDetail.IsNullField("BatchNo"))
                        {
                            billDetail.Amount = p.ReceiveAmount;
                            billDetail.TotalPrice = billDetail.UnitPrice*p.ReceiveAmount;
                            billDetail.Update();
                        }
                    }

                }
                else
                {
                    EntityCollection<BUSBillDetailEntity> billDetails = new EntityCollection<BUSBillDetailEntity>();

                    billDetails.Fetch(BUSBillDetailEntityFields.BillID == billID & BUSBillDetailEntityFields.ProductID == p.ProductID);

                    foreach (BUSBillDetailEntity billDetail in billDetails)
                    {
                        billDetail.Amount = p.ReceiveAmount;
                        billDetail.TotalPrice = billDetail.UnitPrice * p.ReceiveAmount;
                        billDetail.Update();
                    }
                }
                EntityCollection<BUSBillDetailEntity> allBillDetails = new EntityCollection<BUSBillDetailEntity>();

                allBillDetails.Fetch(BUSBillDetailEntityFields.BillID == billID);
                double totalPrice = 0;
                foreach (BUSBillDetailEntity billDetail in allBillDetails)
                {
                    totalPrice += billDetail.TotalPrice;
                }
                billEntity.TotalPrice = totalPrice;
                billEntity.Update();
            });

        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        /// <summary>
        /// 非文本框取值
        /// </summary>
        /// <param name="entity">实体</param>
        protected virtual void CustomGetEntity(BUSReceiveEntity entity)
        {
            if (!entity.IsNullField("BillID"))
            {
                this.txtBillCode.SetMemberValue(entity.BillID);
            }

            if (!entity.IsNullField("DealerID"))
            {
                this.txtDealerName.Tag = entity.DealerID;
            }

            if (!entity.IsNullField("ReceivePerson"))
            {
                this.txtReceivePerson.Text = entity.ReceivePerson;
            }

            if (!entity.IsNullField("TransportCode"))
            {
                this.txtTransportType.Text = entity.TransportCode;
            }

            if (!entity.IsNullField("TransportTool"))
            {
                this.txtTransportTool.Text = entity.TransportTool;
            }

            if (!entity.IsNullField("Reservation3"))
            {
                this.dateTransportDate.Text = entity.Reservation3;
            }

        }

        /// <summary>
        /// 非文本框赋值
        /// </summary>
        /// <param name="entity">实体</param>
        protected virtual void CustomSetEntity(BUSReceiveEntity entity)
        {
            if (this.txtBillCode.SelectedValue != null)
            {
                entity.BillID = Convert.ToInt32(this.txtBillCode.SelectedValue);
                entity.BillCode = this.txtBillCode.Text.Trim();
                entity.BillDate = Convert.ToDateTime((this.txtBillCode.EditData as DataRow)["下单日期"]);

                entity.DealerID = Convert.ToInt32((this.txtBillCode.EditData as DataRow)["往来单位ID"]);
                entity.DealerName = this.txtDealerName.Text.Trim();
                entity.DealerAddress = this.txtDealerAddress.Text.Trim();
                entity.DealerSpell = GlobalMethod.GetAlphabetic(entity.DealerName);
                entity.DealerCode = (this.txtBillCode.EditData as DataRow)["往来单位编号"].ToString();

                entity.BillTypeID = Convert.ToInt32((this.txtBillCode.EditData as DataRow)["订单类型ID"]);
                entity.BillTypeName = (this.txtBillCode.EditData as DataRow)["订单类型"].ToString();
                entity.BillTypeSpell = (this.txtBillCode.EditData as DataRow)["订单类型Spell"].ToString();
            }

            if (this.txtReceivePerson.Text.Trim() != "")
            {
                entity.ReceivePerson = this.txtReceivePerson.Text.Trim();
                entity.ReceivePersonSpell = GlobalMethod.GetAlphabetic(entity.ReceivePerson);
            }
            if (!string.IsNullOrWhiteSpace(txtTransportTool.Text))
            {
                entity.TransportTool = txtTransportTool.Text.Trim();
            }
            if (!string.IsNullOrWhiteSpace(txtTransportType.Text))
            {
                entity.TransportCode = txtTransportType.Text.Trim();
            }
            if (!string.IsNullOrWhiteSpace(dateTransportDate.Text))
            {
                entity.Reservation3 = dateTransportDate.Text;
            }
            this.SetReceiveStatus(entity);
        }

        private void txtBillCode_PopupClosing(object sender, EventArgs e)
        {
            if (this.txtBillCode.EditData != null)
            {
                this.txtBillTypeName.Text = (this.txtBillCode.EditData as DataRow)["订单类型"].ToString();
                this.txtDealerName.Text = (this.txtBillCode.EditData as DataRow)["往来单位名称"].ToString();
                this.txtDealerName.Tag = (this.txtBillCode.EditData as DataRow)["往来单位ID"].ToString();
                this.txtDealerAddress.Text = (this.txtBillCode.EditData as DataRow)["往来单位仓库地址"].ToString();
                this.txtCarryCompnay.Text = (this.txtBillCode.EditData as DataRow)["承运方"].ToString();
                this.txtTransportType.Text = (this.txtBillCode.EditData as DataRow)["运输方式"].ToString();
                this.txtTransportTool.Text = (this.txtBillCode.EditData as DataRow)["运输工具"].ToString();
                this.txtTimeLimit.Text = (this.txtBillCode.EditData as DataRow)["运输时限"].ToString();
                this.dateTransportDate.Text = (this.txtBillCode.EditData as DataRow)["下单日期"].ToString();
                string deliveryTypeName = (this.txtBillCode.EditData as DataRow)["配送方式"].ToString();
                if (DQS.Controls.Properties.Settings.Default.IsThird)
                {
                    if (deliveryTypeName == "第三方物流")
                    {
                        txtTimeLimit.Properties.ReadOnly = true;
                    }
                    else
                    {
                        txtTimeLimit.Properties.ReadOnly = false;
                    }
                }
                else
                {
                    txtTimeLimit.Properties.ReadOnly = false;
                }
                this.dateTransportDate.Focus();

                if (txtBillTypeName.Text.Trim() == "采购进货")
                {
                    for (int i = 0; i < popupGrid.PopupView.Columns.Count; i++)
                    {
                        string ColumnName = popupGrid.PopupView.Columns[i].ToString();
                        if (ColumnName.Contains("批号") || ColumnName.Contains("生产日期") || ColumnName.Contains("有效期至"))
                        {
                            popupGrid.PopupView.Columns[i].Visible = false;
                        }
                    }
                }

                object id = (this.txtBillCode.EditData as DataRow)["订单ID"].ToString();

                if (id != null)
                {
                    //根据订单设置表格数据
                    this.popupGrid.SetGridData("vw_AllWarehouseInBillDetail", "订单ID", id, true);

                    for (int i = 0; i < this.popupGrid.PopupView.RowCount; i++)
                    {
                        this.popupGrid.PopupView.SetRowCellValue(i, "收货数量", 0);
                    }

                    //this.txtReceiveCode.Text = "SH" + txtBillCode.Text.Substring(2);
                    this.txtReceiveCode.Text = txtBillCode.Text;
                }
            }
        }

        private void btnOneKeyFinish_Click(object sender, EventArgs e)
        {
            for (int i = 0; i < this.popupGrid.PopupView.RowCount; i++)
            {
                object amount = this.popupGrid.PopupView.GetRowCellValue(i, "订单数量");
                if (amount != null)
                {
                    if (!string.IsNullOrEmpty(amount.ToString()))
                    {
                        this.popupGrid.PopupView.SetRowCellValue(i, "收货数量", amount);
                        this.popupGrid.PopupView.SetRowCellValue(i, "拒收数量", 0);
                    }
                }
            }
        }

        private void SetReceiveStatus(BUSReceiveEntity entity)
        {
            entity.ReceiveStatusID = 1;
            entity.ReceiveStatus = "正常";
            entity.ReceiveStatusSpell = "zc";
            /*for (int i = 0; i < this.popupGrid.PopupView.RowCount; i++)
            {
                object amount = this.popupGrid.PopupView.GetRowCellValue(i, "订单数量");
                object receiveAmount = this.popupGrid.PopupView.GetRowCellValue(i, "收货数量");
                if (amount.ToString().Trim() != receiveAmount.ToString().Trim())
                {
                    entity.ReceiveStatusID = 2;
                    entity.ReceiveStatus = "拒收";
                    entity.ReceiveStatusSpell = "js";
                    break;
                }
            }*/
        }

        private void btnProductQualification_Click(object sender, EventArgs e)
        {
            object id = this.popupGrid.PopupView.GetFocusedRowCellValue("产品ID");
            if (id != null && id != DBNull.Value)
            {
                using (FrmQualification frmQualification = new FrmQualification(Convert.ToInt32(id), "BFI_Product", "ProductID", "ProductCertificate"))
                {
                    frmQualification.VisbleBarItem();
                    frmQualification.ShowDialog();
                }
            }
        }

        private void btnDealerQualification_Click(object sender, EventArgs e)
        {
            if (this.txtDealerName.Tag != null)
            {
                int id = Convert.ToInt32(this.txtDealerName.Tag);
                using (FrmQualification frmQualification = new FrmQualification(id, "BFI_Dealer", "DealerID", "DealerCertificate"))
                {
                    frmQualification.VisbleBarItem();
                    frmQualification.ShowDialog();
                }
            }
        }

        private void btnTemperature_Click(object sender, EventArgs e)
        {
            if (this.m_id != null)
            {
                using (FrmReceiveAttachment frmReceiveAttachment = new FrmReceiveAttachment(m_id.Value))
                {
                    frmReceiveAttachment.ShowDialog();
                }
            }
        }

        private bool ValidateDealerQualification()
        {
            //获取供货商的过期证书
            if (this.txtDealerName.Tag != null)
            {
                int dealerID = Convert.ToInt32(this.txtDealerName.Tag);
                ViewCollection<AllQualificationView> qualifications = new ViewCollection<AllQualificationView>();

                PredicateExpression pe = new PredicateExpression();
                pe.Add(AllQualificationViewFields.所属表ID == "BFI_Dealer");
                pe.Add(AllQualificationViewFields.所属ID == dealerID);
                pe.Add(AllQualificationViewFields.到期状态 == "已过期");
                qualifications.Fetch(pe);

                if (qualifications.Count > 0)
                {
                    XtraMessageBox.Show(String.Format("往来单位的{0}电子档案已过期，无法生成收货单，请修改！", (qualifications[0] as AllQualificationView).档案名称), "系统提示", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    return false;
                }
            }
            return true;
        }

        /// <summary>
        /// 验证产品的电子档案
        /// </summary>
        /// <returns></returns>
        private bool ValidateProductQualification()
        {
            //获取所有产品的过期证书
            ViewCollection<AllQualificationView> qualifications = new ViewCollection<AllQualificationView>();

            PredicateExpression pe = new PredicateExpression();
            pe.Add(AllQualificationViewFields.所属表ID == "BFI_Product");
            pe.Add(AllQualificationViewFields.到期状态 == "已过期");
            qualifications.Fetch(pe);

            int rowCount = this.popupGrid.PopupView.RowCount;
            for (int i = 0; i < rowCount; i++)
            {
                object id = this.popupGrid.PopupView.GetRowCellValue(i, "产品ID");
                if (id != null && id != DBNull.Value)
                {
                    bool isHava = false;
                    foreach (AllQualificationView q in qualifications)
                    {
                        if (Convert.ToInt32(id) == q.所属ID)
                        {
                            isHava = true;
                            break;
                        }
                    }

                    if (isHava)//存在则产品过期
                    {
                        XtraMessageBox.Show(String.Format("表格中第{0}行产品的电子档案存在已过期档案，无法生成收货单，请修改！", (i + 1)), "系统提示", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        return false;
                    }
                }
            }

            return true;
        }

        private void btnReCheck_Click(object sender, EventArgs e)
        {

            EntityCollection<ATCUserPageEntity> userPages = new EntityCollection<ATCUserPageEntity>();
            PredicateExpression pe = new PredicateExpression();
            pe.Add(ATCUserPageEntityFields.UserID == GlobalItem.g_CurrentUser.UserID);
            pe.Add(ATCUserPageEntityFields.DocumentCode == "ReceiveBill");
            DataTable data = userPages.FetchTable(pe);

            if (data.Rows.Count <= 0)
            {
                XtraMessageBox.Show("系统未设置您的审批流程，无法点击复查功能。", "警告", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                return;
            }

            DialogResult dr = XtraMessageBox.Show("是否提交复查？", "提示", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (dr == DialogResult.No)
            {
                return;
            }

            try
            {
                if (!this.ftPanel.ValidateIsNullFields()) return;
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
                if (!ValidateDealerQualification()) return;
                if (txtBillTypeName.Text.Trim() != "销售退货")
                {
                    if (!ValidateProductQualification()) return;
                }

                SaveLookupData();
                BUSReceiveEntity entity = this.ftPanel.GetEntity() as BUSReceiveEntity;

                this.CustomSetEntity(entity);


                #region 新建

                //string reason;
                //using (FrmReCheckReason frm = new FrmReCheckReason())
                //{
                //    DialogResult drs = frm.ShowDialog();
                //    if (drs == DialogResult.Yes)
                //    {
                //        reason = frm.reason;
                //    }
                //    else
                //    {
                //        return;
                //    }
                //}

                List<EntityBase> children = this.popupGrid.GetEntities();
                List<BUSReceiveDetailEntity> busReceiveDetailEntities = children.Cast<BUSReceiveDetailEntity>().ToList();
                if (busReceiveDetailEntities.Any(p => p.ReceiveAmount > p.Amount))
                {
                    XtraMessageBox.Show("收货数量不能大于订单数量。", "警告", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                    return;
                }

                if (busReceiveDetailEntities.Any(p => p.ReceiveAmount < p.Amount))
                {
                    var dialogResult = XtraMessageBox.Show("是否走拒收流程", "警告", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
                    switch (dialogResult)
                    {
                        //选择“否”，不保存，手动修改
                        case DialogResult.Cancel:
                        case DialogResult.No:
                            return;
                        //选择是，提示：“收货数量与订单数量不符，是否拒收，选择是，生成拒收单，选择否，自动更改收货数量与订单数量一致”，自动保存。
                        case DialogResult.Yes:
                            var dialogResult2 = XtraMessageBox.Show("收货数量与订单数量不符，是否拒收，选择是，生成拒收单，选择否，自动更改收货数量与订单数量一致", "警告", MessageBoxButtons.YesNoCancel, MessageBoxIcon.Question);
                            if (DialogResult.Cancel == dialogResult2)
                            {
                                return;
                            }

                            if (DialogResult.Yes == dialogResult2) //生成拒收单
                            {
                                GenerateDeclinedBill(entity, busReceiveDetailEntities);
                                busReceiveDetailEntities.RemoveAll(p => p.ReceiveAmount == 0 || p.Amount == 0);
                            }
                            else if (DialogResult.No == dialogResult2)
                            {
                                ChangeReceiveAmountToAmount(busReceiveDetailEntities); //自动更改收货数量与订单数量一致
                            }
                            break;
                    }
                }
                entity.ReceiveDate = DateTime.Now;
                entity.CreateDate = DateTime.Now;
                entity.LastModifyDate = DateTime.Now;
                entity.CreateUserID = GlobalItem.g_CurrentUser.UserID;
                entity.LastModifyUserID = GlobalItem.g_CurrentUser.UserID;
                //entity.Reservation7 = reason;
                entity.Reservation7 = "";
                entity.Reservation10 = "复查单据";
                if (!busReceiveDetailEntities.Any() || busReceiveDetailEntities.TrueForAll(p => p.ReceiveAmount == 0))
                {
                    entity.Reservation5 = "2";
                    entity.Reservation6 = "拒收";
                    //entity.ReceiveStatusSpell = "js";

                    //更新订单状态
                    BUSBillEntity billEntity = new BUSBillEntity { BillID = entity.BillID, BillStatus = 7, BillStatusName = "收货复查" };
                    billEntity.Update();
                }
                else
                {
                    entity.Reservation5 = "3";
                    entity.Reservation6 = "已收货";
                    entity.Save();

                    //BUSBillEntity bill = new BUSBillEntity { BillID = entity.BillID, BillStatus = 3, BillStatusName = "已收货" };
                    //bill.Update();

                    //查询出其ID
                    entity.Fetch();

                    foreach (BUSReceiveDetailEntity child in busReceiveDetailEntities)
                    {
                        child.ReceiveID = entity.ReceiveID;
                        child.Reservation2 = (child.ReceiveAmount * double.Parse(child.Reservation1)).ToString();
                        child.Save();
                    }

                    if (entity.ReceiveStatusID == 1)
                    {
                        //更新订单状态
                        BUSBillEntity billEntity = new BUSBillEntity
                        {

                            BillID = entity.BillID,
                            BillStatus = 7,
                            BillStatusName = "收货复查"
                        };
                        billEntity.ReceiveID = entity.ReceiveID;
                        billEntity.ReceiveCode = entity.ReceiveCode;
                        billEntity.Update();
                    }
                    else
                    {
                        //更新订单状态
                        BUSBillEntity billEntity = new BUSBillEntity { BillID = entity.BillID, BillStatus = 7, BillStatusName = "收货复查" };
                        billEntity.Update();
                    }

                }

                #endregion


                if (data.Rows.Count > 0)
                {
                    //按审批顺序排序
                    data.DefaultView.Sort = "ApprovalSort";
                    data = data.DefaultView.ToTable();

                    ATCApproveEntity approveEntity = new ATCApproveEntity();
                    approveEntity.InternalNo = "SH" + entity.ReceiveCode.Substring(2);
                    approveEntity.DocumentCode = "ReceiveBill";
                    approveEntity.BillCode = entity.ReceiveCode;
                    approveEntity.ApproveTitle = string.Format("{0}({1})--收货，编号：{2}", entity.BillTypeName,
                        entity.ReceiveStatus, entity.ReceiveCode);
                    approveEntity.ApprovalContent = String.Format("{0}({1}) {2} --收货，申请审批。", entity.BillTypeName,
                        entity.ReceiveStatus, entity.ReceiveCode);
                    approveEntity.CreateUserID = GlobalItem.g_CurrentUser.UserID;
                    approveEntity.CreateDate = DateTime.Now;
                    approveEntity.IsApprovaled = false;
                    for (int i = 0; i < data.Rows.Count; i++)
                    {
                        var approveCode = approveEntity.InternalNo + (i + 1).ToString("00");
                        approveEntity.ApproveCode = approveCode;
                        approveEntity.IsWhole = Convert.ToBoolean(data.Rows[i]["IsWhole"]);
                        approveEntity.ApproveOrder = Convert.ToInt32(data.Rows[i]["ApprovalSort"]);
                        var approvalUserId = new Guid(data.Rows[i]["ApprovalUserID"].ToString());
                        approveEntity.ApprovalUserID = approvalUserId;
                        approveEntity.Save();

                        //添加消息提醒
                        ATCApproveNotificationEntity notification = new ATCApproveNotificationEntity();
                        notification.CreateUserID = approveEntity.CreateUserID;
                        var userName = GlobalItem.g_CurrentEmployee == null
                            ? GlobalItem.g_CurrentUser.UserName
                            : GlobalItem.g_CurrentEmployee.EmployeeName;
                        notification.CreateUserName = userName;
                        notification.FormClass = "ReceiveBill";
                        notification.IsRead = false;
                        notification.TargetID = entity.BillID;
                        notification.TargetCode = entity.BillCode;
                        notification.ApproveCode = approveCode;
                        notification.Message = string.Format("{0} 于 {1} 收货申请（单号 {2}）。请您审批。", userName,
                            DateTime.Now.ToString("yyyy-MM-dd HH:mm:ss"), entity.BillCode);
                        notification.OwnerUserID = approvalUserId;
                        notification.Save();
                    }
                }

                DialogResult dia = XtraMessageBox.Show("是否打印报告单？", "提示", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (dia == DialogResult.Yes)
                {
                    string fileName = Path.Combine(AppDomain.CurrentDomain.BaseDirectory + "收货报告单.mrt");
                    if (File.Exists(fileName))
                    {
                        PrintPreviewForm printPreview = new PrintPreviewForm(fileName, Convert.ToInt32(entity.ReceiveID));
                        printPreview.ShowDialog(this);
                    }
                    else
                    {
                        XtraMessageBox.Show("找不到文件。", "系统提示", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
            }
            catch (Exception ex)
            {
                XtraMessageBox.Show(ex.Message, "错误", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                return;
            }

            this.DialogResult = DialogResult.OK;
        }

        private void dateTransportDate_TextChanged(object sender, EventArgs e)
        {
            if (this.Tag == null)
            {
                TimeSpan span = DateTime.Now - dateTransportDate.DateTime;
                txtTransportTime.Text = Convert.ToInt32(span.TotalHours).ToString();
            }
        }

        private void txtTimeLimit_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)13)
            {
                txtTimeLimit.Properties.ReadOnly = false;
            }
        }
    }
}