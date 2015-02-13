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
using ORMSCore;

namespace DQS.AppViews.WarehouseOut.WarehouseOutManager
{
    public partial class FrmSingleStockOut : DevExpress.XtraEditors.XtraForm
    {
        private int? m_id;

        public FrmSingleStockOut()
        {
            InitializeComponent();
        }

        private void FrmSingleStockOut_Load(object sender, EventArgs e)
        {
            this.popupGrid.InitGrid();
            this.popupGrid.PopupView.KeyDown += PopupView_KeyDown;


            if (this.Tag != null)
            {
                this.m_id = Convert.ToInt32(this.Tag);

                BUSStoreBillEntity entity = new BUSStoreBillEntity { StoreID = m_id.Value };
                entity.Fetch();

                this.ftPanel.SetEntity(entity);

                this.txtStoreCode.Enabled = false;
                this.txtBillCode.Enabled = false;

                this.CustomGetEntity(entity);

                this.popupGrid.SetGridData(m_id.Value, false);

            }
            else
            {
                this.txtStoreCode.Text = "CK" + DateTime.Now.ToString("yyyyMMddHHmmss");
                this.txtStoreCode.Select(this.txtStoreCode.Text.Length, 0);


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
                    if (!this.ValidateBatchNo()) return;
                    if (!this.ValidateBatchDate()) return;

                    entity.LastModifyDate = DateTime.Now;
                    entity.LastModifyUserID = GlobalItem.g_CurrentUser.UserID;
                    entity.Update();

                    //先删除
                    BUSStoreBillDetailEntity childToDelete = new BUSStoreBillDetailEntity { StoreID = m_id.Value };
                    childToDelete.DeleteByCommonly();

                    //后加
                    foreach (EntityBase childEntity in children)
                    {
                        BUSStoreBillDetailEntity child = childEntity as BUSStoreBillDetailEntity;
                        child.StoreID = m_id.Value;
                        child.Save();
                    }
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
                            BFIEmployeeEntity employee = new BFIEmployeeEntity { EmployeeID = billCreateEmployeeId };
                            employee.Fetch();

                            if (null != employee && !employee.IsNullField("DepartmentID"))
                            {
                                storeDetailBelongDepartmentId = employee.DepartmentID;
                            }
                        }

                        entity.StoreDate = DateTime.Now;

                        List<EntityBase> children = this.popupGrid.GetEntities();
                        if (!this.ValidateAmount()) return;
                        if (!this.ValidateBatchNo()) return;
                        if (!this.ValidateBatchDate()) return;

                        entity.IsBillIn = false;
                        entity.CreateDate = DateTime.Now;
                        entity.LastModifyDate = DateTime.Now;
                        entity.CreateUserID = GlobalItem.g_CurrentUser.UserID;
                        entity.LastModifyUserID = GlobalItem.g_CurrentUser.UserID;
                        entity.Save();

                        BUSBillEntity bill = new BUSBillEntity { BillID = entity.SaleBillID, BillStatus = 3, BillStatusName = "等待复核" };
                        bill.Update();

                        //查询出其ID
                        entity.Fetch();

                        foreach (EntityBase childEntity in children)
                        {
                            BUSStoreBillDetailEntity child = childEntity as BUSStoreBillDetailEntity;
                            child.StoreID = entity.StoreID;
                            child.Save();
                            //更新库存价格
                            UpdateStoreDetailPrice(child, storeDetailBelongDepartmentId);
                        }

                        #endregion
                    }
                    else
                    {
                        XtraMessageBox.Show("出库单号已存在。", "警告", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
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


        public static void UpdateStoreDetailPrice(BUSStoreBillDetailEntity billDetail, int storeDetailBelongDepartmentId)
        {
            //BUSStoreDetailEntity storeDetail = new BUSStoreDetailEntity { ProductID = billDetail.ProductID, BatchNo = billDetail.BatchNo };
            EntityCollection<BUSStoreDetailEntity> storeDetails = new EntityCollection<BUSStoreDetailEntity>();
            storeDetails.Fetch(BUSStoreDetailEntityFields.ProductID == billDetail.ProductID
                & BUSStoreDetailEntityFields.BatchNo == billDetail.BatchNo
                & BUSStoreDetailEntityFields.DepartmentID == storeDetailBelongDepartmentId);
            BUSStoreBillEntity storebill = new BUSStoreBillEntity { StoreID = billDetail.StoreID };
            storebill.Fetch();
            //BUSBillDetailEntity busbilldetail = new BUSBillDetailEntity { BillID = storebill.SaleBillID, ProductID = billDetail.ProductID,BatchNo=billDetail.BatchNo };
            //busbilldetail.Fetch();

            EntityCollection<BUSBillDetailEntity> busbilldetails = new EntityCollection<BUSBillDetailEntity>();
            busbilldetails.Fetch(BUSBillDetailEntityFields.ProductID == billDetail.ProductID
                & BUSBillDetailEntityFields.BatchNo == billDetail.BatchNo
                & BUSBillDetailEntityFields.BillID == storebill.SaleBillID);

            BUSBillDetailEntity busbilldetail = new BUSBillDetailEntity
            {
                UnitPrice = (busbilldetails[0] as BUSBillDetailEntity).UnitPrice
            };

            BFIProductPriceEntity productprice = new BFIProductPriceEntity { ProductID = billDetail.ProductID, PriceID = 1 };
            productprice.Fetch();

            BUSStoreDetailEntity storeDetail = new BUSStoreDetailEntity
            {
                StoreDetailID = (storeDetails[0] as BUSStoreDetailEntity).StoreDetailID
            };
            //更新库存价格
            storeDetail.Fetch();
            storeDetail.LastStoreID = billDetail.StoreID;
            if (storebill.StoreTypeName == "采购退货")
            {
                storeDetail.TotalPrice = storeDetail.TotalPrice - (billDetail.Amount * busbilldetail.UnitPrice);
                storeDetail.Price = Convert.ToDouble(storeDetail.TotalPrice) / storeDetail.Amount;
            }
            else
            {
                storeDetail.TotalPrice = storeDetail.Price * storeDetail.Amount;
            }
            storeDetail.Update();

        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        /// <summary>
        /// 非文本框取值
        /// </summary>
        /// <param name="entity">实体</param>
        protected virtual void CustomGetEntity(BUSStoreBillEntity entity)
        {
            if (!entity.IsNullField("SaleBillID"))
            {
                this.txtBillCode.SetMemberValue(entity.SaleBillID);
            }

            if (!entity.IsNullField("StoreKeeper"))
            {
                this.txtStoreKeeper.Text = entity.StoreKeeper;
            }
            else
            {
                if (m_id == null)
                {
                    this.txtStoreKeeper.Text = GlobalItem.g_CurrentEmployee.EmployeeName;
                }
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
                entity.SaleBillID = Convert.ToInt32(this.txtBillCode.SelectedValue);
                entity.SaleBillCode = this.txtBillCode.Text.Trim();

                BUSBillEntity billEntity = new BUSBillEntity {BillID = entity.SaleBillID};
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
                ATCUserEntity userEntity = new ATCUserEntity { UserID = billCreateUserId };
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

        private void PopupView_KeyDown(object sender, KeyEventArgs e)
        {

            if (e.KeyCode == Keys.Delete)
            {
                object amount = this.popupGrid.PopupView.GetFocusedRowCellValue("订单数量");
                if (amount != null && amount != DBNull.Value)
                {
                    //订单中的原始药品不可删除
                    return;
                }

                DialogResult dr = XtraMessageBox.Show("确定要删除此行数据吗？", "提示", MessageBoxButtons.OKCancel, MessageBoxIcon.Question);
                if (dr == DialogResult.OK)
                {
                    this.popupGrid.ClearGrid(this.popupGrid.PopupView.FocusedRowHandle);
                }
            }
        }

        private void txtBillCode_PopupClosing(object sender, EventArgs e)
        {
            if (this.txtBillCode.EditData != null)
            {
                this.txtBillTypeName.Text = (this.txtBillCode.EditData as DataRow)["订单类型"].ToString();
                this.txtDealerName.Text = (this.txtBillCode.EditData as DataRow)["往来单位名称"].ToString();
                this.txtStoreRemark.Focus();

                object id = (this.txtBillCode.EditData as DataRow)["订单ID"].ToString();

                if (id != null)
                {
                    //根据订单设置表格数据
                    this.popupGrid.SetGridData("vw_AllWarehouseOutBillDetail", "订单ID", id, false);
                    //txtStoreCode.Text = (this.txtBillCode.EditData as DataRow)["订单编号"].ToString().Substring(0, 2) + "CK" + txtBillCode.Text.Substring(2);
                    txtStoreCode.Text = txtBillCode.Text;
                }
            }
        }

        private void popupGrid_BeforePopupFormShow(object sender, DQS.Controls.CommonCode.BeforePopupFormShowArgs e)
        {
            if (e.ActiveOperationColumn.PopupForm != null)
            {
                if (e.ActiveOperationColumn.PopupForm.Name == "Product")
                {
                    object amount = this.popupGrid.PopupView.GetFocusedRowCellValue("订单数量");
                    if (amount != null && amount != DBNull.Value)
                    {
                        //订单中的原始药品不须弹出窗体进行选择
                        e.Cancel = true;
                    }

                    List<string> productIDs = new List<string>();
                    for (int i = 0; i < this.popupGrid.PopupView.RowCount; i++)
                    {
                        object productID = this.popupGrid.PopupView.GetRowCellValue(i, "药品ID");
                        if (productID != null && productID != DBNull.Value)
                        {
                            productIDs.Add(productID.ToString());
                        }
                    }

                    if (productIDs.Count > 0)
                    {
                        e.ActiveOperationColumn.PopupForm.Filter = String.Format("[药品ID] IN ({0}) ", string.Join(",", productIDs.ToArray()));
                    }
                    else
                    {
                        XtraMessageBox.Show("请先选择订单。", "提示", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                        this.txtBillCode.Focus();
                        e.Cancel = true;
                    }
                }

                if (e.ActiveOperationColumn.PopupForm.Name == "ProductBatch")
                {
                    object productID = this.popupGrid.PopupView.GetFocusedRowCellValue("药品ID");
                    if (productID != null && productID != DBNull.Value)
                    {
                        //选择完药品才可选择批号
                        e.ActiveOperationColumn.PopupForm.Filter = String.Format("[药品ID] = {0}", productID);
                    }
                    else
                    {
                        e.Cancel = true;
                    }
                }
            }
        }

        //验证出库总数量必须等于订单数量
        private bool ValidateAmount()
        {

            for (int i = 0; i < this.popupGrid.PopupView.RowCount; i++)
            {
                object qAmount = this.popupGrid.PopupView.GetRowCellValue(i, "订单数量");
                object amount = this.popupGrid.PopupView.GetRowCellValue(i, "出库数量");

                if (qAmount != null && qAmount != DBNull.Value && amount != null && amount != DBNull.Value)
                {
                    if (qAmount.ToString().Trim() != amount.ToString().Trim())
                    {
                        XtraMessageBox.Show(String.Format("第{0}行出库数量必须等于订单数量！", (i + 1)), "提示", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                        return false;
                    }
                }
            }

            return true;
        }

        //验证同一产品不可出现相同批号
        private bool ValidateBatchNo()
        {
            for (int i = 0; i < this.popupGrid.PopupView.RowCount; i++)
            {
                object amount = this.popupGrid.PopupView.GetRowCellValue(i, "订单数量");
                object productName = this.popupGrid.PopupView.GetRowCellValue(i, "药品名称");
                object productSpec = this.popupGrid.PopupView.GetRowCellValue(i, "规格");
                object packageSpec = this.popupGrid.PopupView.GetRowCellValue(i, "包装规格");

                if (amount != null && amount != DBNull.Value)
                {
                    List<string> batchNos = new List<string>();

                    for (int j = 0; j < this.popupGrid.PopupView.RowCount; j++)
                    {
                        object productName2 = this.popupGrid.PopupView.GetRowCellValue(j, "药品名称");//同一药品比较
                        object productSpec2 = this.popupGrid.PopupView.GetRowCellValue(j, "规格");
                        object packageSpec2 = this.popupGrid.PopupView.GetRowCellValue(j, "包装规格");
                        if (productName.ToString().Trim() == productName2.ToString().Trim()
                            && productSpec.ToString().Trim() == productSpec2.ToString().Trim()
                            && packageSpec.ToString().Trim() == packageSpec2.ToString().Trim())
                        {
                            object batchNo = this.popupGrid.PopupView.GetRowCellValue(j, "批号");
                            if (batchNos.Contains(batchNo.ToString().Trim()))
                            {
                                XtraMessageBox.Show(String.Format("药品‘{0}’存在相同的批号{1}。", productName, batchNo), "提示", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                                return false;
                            }
                            else
                            {
                                batchNos.Add(batchNo.ToString().Trim());
                            }
                        }
                    }
                }
            }

            return true;
        }

        //验证生产日期必须小于有效期至
        private bool ValidateBatchDate()
        {
            for (int i = 0; i < this.popupGrid.PopupView.RowCount; i++)
            {
                object produceDate = this.popupGrid.PopupView.GetRowCellValue(i, "生产日期");
                object validateDate = this.popupGrid.PopupView.GetRowCellValue(i, "有效期至");

                if (produceDate != null && produceDate != DBNull.Value && validateDate != null && validateDate != DBNull.Value)
                {
                    if (Convert.ToDateTime(validateDate) <= Convert.ToDateTime(produceDate))
                    {
                        XtraMessageBox.Show(String.Format("第{0}行，药品的有效期至必须大于生产日期。", (i + 1)), "提示", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                        return false;

                    }
                }
            }
            return true;
        }
/*
        ////更新库存
        public static void UpdateStoreDetail(BUSStoreBillDetailEntity storeBillDetail, int storeDetailBelongDepartmentId)
        {
            BUSStoreDetailEntity storeDetail = new BUSStoreDetailEntity {
                ProductID = storeBillDetail.ProductID,
                BatchNo = storeBillDetail.BatchNo,
                DepartmentID = storeDetailBelongDepartmentId
            };

            //更新库存
            storeDetail.Fetch();
            storeDetail.LastStoreID = storeBillDetail.StoreID;
            storeDetail.LastModifyDate = DateTime.Now;
            storeDetail.LastModifyUserID = GlobalItem.g_CurrentUser.UserID;
            if (storeDetail.IsNullField("Amount"))
            {
                throw new Exception(String.Format("ID号为{0}的产品没有批号为{1}库存信息。", storeBillDetail.ProductID, storeBillDetail.BatchNo));
            }
            storeDetail.Amount = storeDetail.Amount - storeBillDetail.Amount;
            if (storeDetail.Amount < 0)
            {
                throw new Exception(String.Format("ID号为{0}的产品库存不足。", storeBillDetail.ProductID));
            }
            storeDetail.Update();
        }
*/
    }
}