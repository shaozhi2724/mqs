using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using DevExpress.XtraEditors;
using DQS.Common;
using DQS.Controls;
using DQS.Module.Entities;
using ORMSCore;

namespace DQS.AppViews.ExceptionControl.ExceptionManager
{
    public partial class FrmProductUnqualified : StandardForm
    {
        public FrmProductUnqualified()
        {
            InitializeComponent();
        }

        private void FrmProductUnqualified_Load(object sender, EventArgs e)
        {
            base.InitPage();
        }

        protected override void CustomApprove()
        {
            object id = this.gvData.GetFocusedRowCellValue("记录ID");
            if (id != null && id != DBNull.Value)
            {
                DialogResult dr = base.BaseApprove();
                if (dr == DialogResult.Yes)
                {
                    ApproveAndUpdateStoreDetail((int)id);
                    this.pageNavigator.ShowData();
                }
            }
        }

        protected override void CustomDelete()
        {
            object approveStatus = this.gvData.GetFocusedRowCellValue("审批状态");
            object unqualifiedCode = this.gvData.GetFocusedRowCellValue("记录编号");
            if (unqualifiedCode != null && unqualifiedCode != DBNull.Value && approveStatus != null && approveStatus != DBNull.Value)
            {
                if (approveStatus.ToString() == "审批结束")
                {
                    XtraMessageBox.Show("此记录已审核通过，不允许删除！", "系统提示", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }
                else
                {
                    EntityCollection<ATCApproveEntity> approveEntities = new EntityCollection<ATCApproveEntity>();
                    PredicateExpression pe = new PredicateExpression();
                    pe.Add(ATCApproveEntityFields.DocumentCode == "ProductUnqualified");
                    pe.Add(ATCApproveEntityFields.BillCode == unqualifiedCode.ToString());
                    pe.Add(ATCApproveEntityFields.IsApprovaled == 1);
                    approveEntities.Fetch(pe);
                    if (approveEntities.Count > 0)
                    {
                        XtraMessageBox.Show("此记录正在审核中，不允许删除！", "系统提示", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        return;
                    }
                    base.CustomDelete();
                }
            }
        }

        protected override void CustomPrint()
        {
            object id = gvData.GetFocusedRowCellValue("记录ID");
            if (id != null)
            {
                base.SinglePrint("不合格药品处理", (int)id);
            }

            //base.CustomPrint();
        }

        public static void ApproveAndUpdateStoreDetail(int entityID)
        {

            BUSProductUnqualifiedEntity entity = new BUSProductUnqualifiedEntity { UnqualifiedID = entityID };
            entity.Fetch();

            Guid billCreateUserId = entity.CreateUserID;
            ATCUserEntity userEntity = new ATCUserEntity { UserID = billCreateUserId };
            userEntity.Fetch();

            int billCreateEmployeeId = userEntity.EmployeeID;
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

            EntityCollection<BUSProductUnqualifiedDetailEntity> details = new EntityCollection<BUSProductUnqualifiedDetailEntity>();
            details.Fetch(BUSProductUnqualifiedDetailEntityFields.UnqualifiedID == entity.UnqualifiedID);
            foreach (BUSProductUnqualifiedDetailEntity unqualifiedDetail in details)
            {
                if (entity.IsCutAmount)
                {

                    EntityCollection<BUSStoreDetailEntity> storeDetails = new EntityCollection<BUSStoreDetailEntity>();
                    storeDetails.Fetch(BUSStoreDetailEntityFields.ProductID == unqualifiedDetail.ProductID
                        & BUSStoreDetailEntityFields.BatchNo == unqualifiedDetail.BatchNo
                        & BUSStoreDetailEntityFields.DepartmentID == storeDetailBelongDepartmentId);
                    //BUSStoreDetailEntity storeDetail = new BUSStoreDetailEntity
                    //{
                    //    ProductID = unqualifiedDetail.ProductID,
                    //    BatchNo = unqualifiedDetail.BatchNo
                    //};

                    //更新库存
                    foreach (BUSStoreDetailEntity storeDetail in storeDetails)
                    {
                        storeDetail.LastModifyDate = DateTime.Now;
                        storeDetail.LastModifyUserID = GlobalItem.g_CurrentUser.UserID;
                        if (storeDetail.IsNullField("Amount"))
                        {
                            XtraMessageBox.Show(
                                String.Format("审批失败！\nID号为{0}的产品没有批号为{1}库存信息。", unqualifiedDetail.ProductID,
                                    unqualifiedDetail.BatchNo), "警告", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                            return;
                        }
                        storeDetail.Amount = storeDetail.Amount - unqualifiedDetail.Amount;
                        if (storeDetail.Amount < 0)
                        {
                            XtraMessageBox.Show(String.Format("审批失败！\nID号为{0}的产品库存不足。", unqualifiedDetail.ProductID),
                                "警告",
                                MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                            return;
                        }
                        storeDetail.Update();
                    }
                }

                BUSUnqualifiedStoreDetailEntity unqualifiedStoreDetail = new BUSUnqualifiedStoreDetailEntity
                {
                    ProductID = unqualifiedDetail.ProductID,
                    BatchNo = unqualifiedDetail.BatchNo
                };

                if (
                    unqualifiedStoreDetail.IsNew(BUSUnqualifiedStoreDetailEntityFields.ProductID ==
                                                 unqualifiedDetail.ProductID &
                                                 BUSUnqualifiedStoreDetailEntityFields.BatchNo ==
                                                 unqualifiedDetail.BatchNo))
                {
                    //新建不合格品库存
                    unqualifiedStoreDetail.ProduceDate = unqualifiedDetail.ProduceDate;
                    unqualifiedStoreDetail.ValidateDate = unqualifiedDetail.ValidateDate;
                    unqualifiedStoreDetail.Amount = unqualifiedDetail.Amount;
                    unqualifiedStoreDetail.CreateUserID = GlobalItem.g_CurrentUser.UserID;
                    unqualifiedStoreDetail.CreateDate = DateTime.Now;
                    unqualifiedStoreDetail.LastCuringDate = DateTime.Now;
                    unqualifiedStoreDetail.Save();

                }
                else
                {
                    //更新不合格品库存
                    unqualifiedStoreDetail.Fetch();
                    unqualifiedStoreDetail.LastModifyDate = DateTime.Now;
                    unqualifiedStoreDetail.LastModifyUserID = GlobalItem.g_CurrentUser.UserID;
                    unqualifiedStoreDetail.Amount = unqualifiedStoreDetail.Amount + unqualifiedDetail.Amount;
                    unqualifiedStoreDetail.Update();
                }
            }


            if (entity.UnqualifiedStatusID == 1)
            {
                entity.UnqualifiedStatusID = 2;
                entity.UnqualifiedStatus = "已审核";
                entity.Update();
            }
        }
    }
}