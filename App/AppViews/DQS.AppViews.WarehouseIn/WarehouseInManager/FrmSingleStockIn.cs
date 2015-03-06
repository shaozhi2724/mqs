using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using DevExpress.XtraEditors;
using DQS.Module.Entities;
using DQS.Common;
using ORMSCore;

namespace DQS.AppViews.WarehouseIn.WarehouseInManager
{
    public partial class FrmSingleStockIn : DevExpress.XtraEditors.XtraForm
    {
        private int? m_id;

        public FrmSingleStockIn()
        {
            InitializeComponent();
        }

        private void FrmSingleStockIn_Load(object sender, EventArgs e)
        {
            this.popupGrid.InitGrid();

            if (this.Tag != null)
            {
                this.m_id = Convert.ToInt32(this.Tag);

                BUSStoreBillEntity entity = new BUSStoreBillEntity { StoreID = m_id.Value };
                entity.Fetch();

                this.ftPanel.SetEntity(entity);

                this.txtBillCode.Enabled = false;
                this.txtStoreCode.Enabled = false;

                this.CustomGetEntity(entity);

                this.popupGrid.SetGridData(m_id.Value, true);

            }
            else
            {
                this.txtStoreCode.Text = "RK" + DateTime.Now.ToString("yyyyMMddHHmmss");
                this.txtStoreCode.Select(this.txtStoreCode.Text.Length, 0);

                this.txtStoreDate.Text = DateTime.Now.ToString("yyyy-MM-dd HH:mm:ss");

                if (GlobalItem.g_CurrentEmployee != null)
                {
                    this.txtStoreKeeper.Text = GlobalItem.g_CurrentEmployee.EmployeeName;
                }
                else
                {
                    txtStoreKeeper.Text = GlobalItem.g_CurrentUser.UserName;
                }
            }
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            try
            {
                if (!this.ftPanel.ValidateIsNullFields()) return;

                BUSStoreBillEntity entity = this.ftPanel.GetEntity() as BUSStoreBillEntity;
                int billCreateEmployeeId = 0;
                this.CustomSetEntity(entity, out billCreateEmployeeId);

                if (this.m_id != null)
                {
                    #region 修改

                    List<EntityBase> children = this.popupGrid.GetEntities();
                    if (!this.ValidateAmount()) return;

                    entity.LastModifyDate = DateTime.Now;
                    entity.LastModifyUserID = GlobalItem.g_CurrentUser.UserID;
                    entity.Update();

                    ////先删除
                    //BUSStoreBillDetailEntity childToDelete = new BUSStoreBillDetailEntity { StoreID = m_id.Value };
                    //childToDelete.DeleteByCommonly();

                    ////后加
                    //foreach (EntityBase childEntity in children)
                    //{
                    //    BUSStoreBillDetailEntity child = childEntity as BUSStoreBillDetailEntity;
                    //    child.StoreID = m_id.Value;
                    //    child.Save();
                    //}
                    #endregion
                }
                else
                {
                    if (entity.IsNew(BUSStoreBillEntityFields.StoreCode == entity.StoreCode))
                    {
                        #region 新建
                        
                        int storeDetailBelongDepartmentId = 0;

                        if (billCreateEmployeeId > 0)
                        {
                            BFIEmployeeEntity employee = new BFIEmployeeEntity {EmployeeID = billCreateEmployeeId};
                            employee.Fetch();

                            if (null != employee && !employee.IsNullField("DepartmentID"))
                            {
                                storeDetailBelongDepartmentId = employee.DepartmentID;
                            }
                        }

                        entity.StoreDate = DateTime.Now;

                        List<EntityBase> children = this.popupGrid.GetEntities();
                        if (!this.ValidateAmount()) return;
                        entity.CreateDate = DateTime.Now;
                        entity.LastModifyDate = DateTime.Now;
                        entity.CreateUserID = GlobalItem.g_CurrentUser.UserID;
                        entity.LastModifyUserID = GlobalItem.g_CurrentUser.UserID;
                        entity.Save();

                        //查询出其ID
                        entity.Fetch();
                        BUSBillEntity bill = new BUSBillEntity { BillID = entity.PurchaseBillID, BillStatus = 5, BillStatusName = "已入库" };
                        bill.StoreInID = entity.StoreID;
                        bill.StoreInCode = entity.StoreCode;
                        bill.Update();

                        List<BUSProductPurchasePriceEntity> productPrices = new List<BUSProductPurchasePriceEntity>();
                        for (int i = 0; i < this.popupGrid.PopupView.RowCount; i++)
                        {
                            object productID = this.popupGrid.PopupView.GetRowCellValue(i, "药品ID");
                            object batchNo = this.popupGrid.PopupView.GetRowCellValue(i, "批号");
                            object unitPrice = this.popupGrid.PopupView.GetRowCellValue(i, "单价");
                            productPrices.Add(new BUSProductPurchasePriceEntity
                            {
                                ProductID = (int)productID,
                                BatchNo = batchNo.ToString(),
                                PurchasePrice = (double)unitPrice
                            });
                        }

                        foreach (EntityBase childEntity in children)
                        {
                            BUSStoreBillDetailEntity child = childEntity as BUSStoreBillDetailEntity;
                            child.StoreID = entity.StoreID;
                            child.Save();

                            #region 记录采购价-按批号

                            var productPrice = productPrices.FirstOrDefault(p => p.ProductID == child.ProductID
                                                                                 && p.BatchNo == child.BatchNo);
                            BUSProductPurchasePriceEntity priceEntity = new BUSProductPurchasePriceEntity();
                            priceEntity.DealerID = entity.DealerID;
                            priceEntity.PurchaseBillID = entity.PurchaseBillID;
                            priceEntity.ProductID = child.ProductID;
                            priceEntity.BatchNo = child.BatchNo;
                            if (null != productPrice)
                            {
                                priceEntity.PurchasePrice = productPrice.PurchasePrice;
                            }
                            priceEntity.CreateDate = DateTime.Now;
                            priceEntity.CreateUserID = GlobalItem.g_CurrentUser.UserID;
                            priceEntity.Save();

                            #endregion


                            //更新库存
                            UpdateStoreDetail(child, storeDetailBelongDepartmentId, productPrice.PurchasePrice);
                        }
                        #endregion

                    }
                    else
                    {
                        XtraMessageBox.Show("入库单号已存在。", "警告", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
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

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        /// <summary>
        /// 非文本框取值
        /// </summary>
        /// <param name="entity">实体</param>
        protected virtual void CustomGetEntity(BUSStoreBillEntity entity)
        {
            if (!entity.IsNullField("AcceptID"))
            {
                this.txtBillCode.SetMemberValue(entity.AcceptID);
            }
            if (!entity.IsNullField("StoreKeeper"))
            {
                this.txtStoreKeeper.Text = entity.StoreKeeper;
            }
        }

        /// <summary>
        /// 非文本框赋值
        /// </summary>
        /// <param name="entity">实体</param>
        protected virtual void CustomSetEntity(BUSStoreBillEntity entity, out int billCreateEmployeeId)
        {
            billCreateEmployeeId = 0;
            if (this.txtBillCode.SelectedValue != null)
            {
                entity.AcceptID = Convert.ToInt32(this.txtBillCode.SelectedValue);
                entity.AcceptCode = this.txtBillCode.Text.Trim();

                BUSAcceptEntity acceptEntity = new BUSAcceptEntity {AcceptID = entity.AcceptID};
                acceptEntity.Fetch();

                entity.ReceiveID = acceptEntity.ReceiveID;
                entity.ReceiveCode = acceptEntity.ReceiveCode;
                entity.PurchaseBillID = acceptEntity.BillID;
                entity.PurchaseBillCode = acceptEntity.BillCode;
                BUSBillEntity billEntity = new BUSBillEntity{BillID = acceptEntity.BillID};
                billEntity.Fetch();
                if (billEntity.IsNullField("BillStyle"))
                {
                    entity.BillStyle = "正常";
                }
                else
                {
                    entity.BillStyle = billEntity.BillStyle;
                }
                Guid billCreateUserId = billEntity.CreateUserID;
                ATCUserEntity userEntity = new ATCUserEntity{UserID = billCreateUserId};
                userEntity.Fetch();

                billCreateEmployeeId = userEntity.EmployeeID;

                entity.DealerID = Convert.ToInt32((this.txtBillCode.EditData as DataRow)["往来单位ID"]);
                entity.DealerName = this.txtDealerName.Text.Trim();
                entity.DealerSpell = GlobalMethod.GetAlphabetic(entity.DealerName);

                entity.StoreTypeID = Convert.ToInt32((this.txtBillCode.EditData as DataRow)["订单类型ID"]);
                entity.StoreTypeName = (this.txtBillCode.EditData as DataRow)["订单类型"].ToString();
                entity.StoreTypeSpell = (this.txtBillCode.EditData as DataRow)["订单类型Spell"].ToString();
            }

            if (this.txtStoreKeeper.Text.Trim() != "")
            {
                entity.StoreKeeper = this.txtStoreKeeper.Text.Trim();
                entity.StoreKeeperSpell = GlobalMethod.GetAlphabetic(entity.StoreKeeper);
            }
        }

        private void txtBillCode_PopupClosing(object sender, EventArgs e)
        {
            if (this.txtBillCode.EditData != null)
            {
                this.txtBillTypeName.Text = (this.txtBillCode.EditData as DataRow)["订单类型"].ToString();
                this.txtDealerName.Text = (this.txtBillCode.EditData as DataRow)["往来单位名称"].ToString();
                this.txtOperator.Text = (this.txtBillCode.EditData as DataRow)["业务员"].ToString();
                this.txtStoreRemark.Focus();

                object id = (this.txtBillCode.EditData as DataRow)["验收ID"].ToString();

                if (id != null)
                {
                    //根据订单设置表格数据
                    this.popupGrid.SetGridData("vw_AllWarehouseInBillDetailForStoreIn", "验收ID", id, true);
                    //txtStoreCode.Text = (this.txtBillCode.EditData as DataRow)["订单编号"].ToString().Substring(0, 2) +"RK" + txtBillCode.Text.Substring(2);
                    txtStoreCode.Text = txtBillCode.Text;
                }
            }
        }


        //入库总数量必须等于订单数量
        private bool ValidateAmount()
        {
            for (int i = 0; i < this.popupGrid.PopupView.RowCount; i++)
            {
                object amount = this.popupGrid.PopupView.GetRowCellValue(i, "验收数量");
                object productCode = this.popupGrid.PopupView.GetRowCellValue(i, "药品编号");

                if (amount != null && amount != DBNull.Value)
                {
                    //获取所有入库数量
                    int totalAmount = 0, totalStockInAmount = 0;
                    for (int j = 0; j < this.popupGrid.PopupView.RowCount; j++)
                    {
                        object productCode2 = this.popupGrid.PopupView.GetRowCellValue(j, "药品编号");//同一药品比较
                        if (productCode.ToString().Trim() == productCode2.ToString().Trim())
                        {
                            object billAmount = this.popupGrid.PopupView.GetRowCellValue(j, "验收数量");
                            if (billAmount != null && billAmount != DBNull.Value)
                            {
                                totalAmount += Convert.ToInt32(billAmount);
                            }
                            object stockInAmount = this.popupGrid.PopupView.GetRowCellValue(j, "入库数量");
                            if (stockInAmount != null && stockInAmount != DBNull.Value)
                            {
                                totalStockInAmount += Convert.ToInt32(stockInAmount);
                            }
                        }
                    }

                    if (totalAmount != totalStockInAmount)
                    {
                        XtraMessageBox.Show(String.Format("入库时，药品‘{0}’的总体入库数量和验收数量不符。", productCode), "提示", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                        return false;
                    }
                }
            }
            return true;
        }

        public void UpdateStoreDetail(BUSStoreBillDetailEntity billDetail, int storeDetailBelongDepartmentId,object price)
        {
            //BUSStoreDetailEntity storeDetail = new BUSStoreDetailEntity { ProductID = billDetail.ProductID, BatchNo = billDetail.BatchNo };
            EntityCollection<BUSStoreDetailEntity> storeDetails = new EntityCollection<BUSStoreDetailEntity>();
            storeDetails.Fetch(BUSStoreDetailEntityFields.ProductID == billDetail.ProductID
                & BUSStoreDetailEntityFields.BatchNo == billDetail.BatchNo
                & BUSStoreDetailEntityFields.DepartmentID == storeDetailBelongDepartmentId);
            BFIProductPriceEntity productprice = new BFIProductPriceEntity { ProductID = billDetail.ProductID, PriceID = 1 };
            productprice.Fetch();
            if (storeDetails.Count == 0)
            {
                BUSStoreDetailEntity storeDetail = new BUSStoreDetailEntity();
                
                //新建库存
                storeDetail.ProductID = billDetail.ProductID;
                storeDetail.BatchNo = billDetail.BatchNo;
                storeDetail.DepartmentID = storeDetailBelongDepartmentId;
                storeDetail.ProduceDate = billDetail.ProduceDate;
                storeDetail.ValidateDate = billDetail.ValidateDate;
                storeDetail.Amount = billDetail.Amount;
                storeDetail.CreateDate = DateTime.Now;
                storeDetail.LastModifyDate = DateTime.Now;
                storeDetail.LastModifyUserID = GlobalItem.g_CurrentUser.UserID;
                storeDetail.LastCuringDate = DateTime.Now;
                storeDetail.CreateStoreID = billDetail.StoreID;
                storeDetail.LastStoreID = billDetail.StoreID;
                storeDetail.DepartmentID = storeDetailBelongDepartmentId;
                //停掉库存中价格计算。
                /*
                if (txtBillTypeName.Text == "采购进货")
                {
                    storeDetail.Price = Convert.ToDouble(price);
                    storeDetail.TotalPrice = billDetail.Amount * Convert.ToDouble(price);
                }
                else
                {
                    if (productprice.Price == 0)
                    {
                        storeDetail.Price = 0;
                        storeDetail.TotalPrice = 0;
                    }
                }
                */
                storeDetail.Save();
                
            }
            else
            {
                BUSStoreDetailEntity storeDetail = new BUSStoreDetailEntity
                {
                    StoreDetailID = (storeDetails[0] as BUSStoreDetailEntity).StoreDetailID
                };
                //更新库存
                storeDetail.Fetch();
                storeDetail.LastStoreID = billDetail.StoreID;
                storeDetail.LastModifyDate = DateTime.Now;
                storeDetail.LastModifyUserID = GlobalItem.g_CurrentUser.UserID;
                //停掉库存中价格计算。
                /*
                if (txtBillTypeName.Text == "采购进货")
                {
                    storeDetail.TotalPrice = storeDetail.TotalPrice + (billDetail.Amount * Convert.ToDouble(price));
                    storeDetail.Price = Convert.ToDouble(storeDetail.TotalPrice) / (storeDetail.Amount + billDetail.Amount);
                }
                else
                {
                    storeDetail.TotalPrice = storeDetail.Price * (storeDetail.Amount + billDetail.Amount);
                }
                */
                storeDetail.Amount = storeDetail.Amount + billDetail.Amount;
                storeDetail.Update();
            }
        }

        private void btnOneKeyFinish_Click(object sender, EventArgs e)
        {
            for (int i = 0; i < this.popupGrid.PopupView.RowCount; i++)
            {
                object amount = this.popupGrid.PopupView.GetRowCellValue(i, "验收数量");
                if (amount != null)
                {
                    if (!string.IsNullOrEmpty(amount.ToString()))
                    {
                        this.popupGrid.PopupView.SetRowCellValue(i, "入库数量", amount);
                    }
                }
            }
        }
    }
}