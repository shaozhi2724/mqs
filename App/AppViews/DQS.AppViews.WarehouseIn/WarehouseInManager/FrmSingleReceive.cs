using System;
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
                    else
                    {
                        entity.Update();

                        //先删除
                        BUSReceiveDetailEntity childToDelete = new BUSReceiveDetailEntity {ReceiveID = m_id.Value};
                        childToDelete.DeleteByCommonly();

                        //后加
                        foreach (BUSReceiveDetailEntity child in busReceiveDetailEntities)
                        {
                            child.ReceiveID = m_id.Value;
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
                DeclinedCode = "SHJS-" + receiveEntity.BillCode
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
                this.txtCarryCompnay.Focus();

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
            object id = this.popupGrid.PopupView.GetFocusedRowCellValue("药品ID");
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
        /// 验证药品的电子档案
        /// </summary>
        /// <returns></returns>
        private bool ValidateProductQualification()
        {
            //获取所有药品的过期证书
            ViewCollection<AllQualificationView> qualifications = new ViewCollection<AllQualificationView>();

            PredicateExpression pe = new PredicateExpression();
            pe.Add(AllQualificationViewFields.所属表ID == "BFI_Product");
            pe.Add(AllQualificationViewFields.到期状态 == "已过期");
            qualifications.Fetch(pe);

            int rowCount = this.popupGrid.PopupView.RowCount;
            for (int i = 0; i < rowCount; i++)
            {
                object id = this.popupGrid.PopupView.GetRowCellValue(i, "药品ID");
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

                    if (isHava)//存在则药品过期
                    {
                        XtraMessageBox.Show(String.Format("表格中第{0}行药品的电子档案存在已过期档案，无法生成收货单，请修改！", (i + 1)), "系统提示", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        return false;
                    }
                }
            }

            return true;
        }
    }
}