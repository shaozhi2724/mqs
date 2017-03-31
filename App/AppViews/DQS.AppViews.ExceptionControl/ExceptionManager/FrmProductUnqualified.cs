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
using System.Data.SqlClient;
using System.Linq;

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
                base.SinglePrint("不合格产品处理", (int)id);
            }

            //base.CustomPrint();
        }

        public void ApproveAndUpdateStoreDetail(int entityID)
        {

            BUSProductUnqualifiedEntity entity = new BUSProductUnqualifiedEntity { UnqualifiedID = entityID };
            entity.Fetch();

            //自动解锁

            EntityCollection<BUSProductUnqualifiedDetailEntity> entityDetail = new EntityCollection<BUSProductUnqualifiedDetailEntity>();
            entityDetail.Fetch(BUSProductUnqualifiedDetailEntityFields.UnqualifiedID == entityID);

            foreach (EntityBase item in entityDetail)
            {
                BUSProductUnqualifiedDetailEntity child = item as BUSProductUnqualifiedDetailEntity;
                EntityCollection<BUSProductLockedEntity> pl = new EntityCollection<BUSProductLockedEntity>();
                pl.Fetch(BUSProductLockedEntityFields.InStoreID == child.InStoreID
                    & BUSProductLockedEntityFields.IsUnLocked == false);
                if (pl.Count > 0)
                {
                    foreach (var plitem in pl)
                    {
                        BUSProductLockedEntity entitypl = new BUSProductLockedEntity { LockedID = (plitem as BUSProductLockedEntity).LockedID };
                        entitypl.Fetch();
                        entitypl.IsUnLocked = true;
                        if (GlobalItem.g_CurrentEmployee != null)
                        {
                            entitypl.UnLockedUser = GlobalItem.g_CurrentEmployee.EmployeeName;
                        }
                        else
                        {
                            entitypl.UnLockedUser = GlobalItem.g_CurrentUser.UserName;
                        }
                        entitypl.DealResult = entity.DealSuggestion;
                        entitypl.UnLockedDate = DateTime.Now;
                        entitypl.Update();
                    }
                }
            }

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

            if (entity.IsCutAmount)
            {
                int result = 0;
                string sql = @"EXEC sp_InsertNewStoreDetailForUnqualified '{0}','{1}','{2}'";
                sql = string.Format(sql, entity.UnqualifiedCode, entity.CreateDate, GlobalItem.g_CurrentEmployee.EmployeeName);
                using (SqlConnection conn = new SqlConnection(GlobalItem.g_DbConnectStrings))
                {
                    conn.Open(); //连接数据库
                    //必须为SqlCommand指定数据库连接和登记的事务
                    SqlCommand cmd = new SqlCommand(sql, conn);
                    try
                    {
                        result = Convert.ToInt32(cmd.ExecuteScalar());
                        if (result == 1)
                        {
                            XtraMessageBox.Show("明细中有产品库存不够，请检查。", "系统提示", MessageBoxButtons.OK, MessageBoxIcon.Error);
                            rollback();
                            return;
                        }
                    }
                    catch (Exception ex)
                    {
                        XtraMessageBox.Show(ex.Message, "系统提示", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                    finally
                    {
                        conn.Close();
                    }
                }
            }
            foreach (BUSProductUnqualifiedDetailEntity unqualifiedDetail in details)
            {

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
                    if (!unqualifiedDetail.IsNullField("ProduceDate"))
                    {
                        unqualifiedStoreDetail.ProduceDate = unqualifiedDetail.ProduceDate;
                    }
                    if (!unqualifiedDetail.IsNullField("ValidateDate"))
                    {
                        unqualifiedStoreDetail.ValidateDate = unqualifiedDetail.ValidateDate;
                    }
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

        private void rollback()
        {
            object approveStatus = this.gvData.GetFocusedRowCellValue("审批状态");
            object unqualifiedCode = this.gvData.GetFocusedRowCellValue("记录编号");
            if (unqualifiedCode != null && unqualifiedCode != DBNull.Value && approveStatus != null && approveStatus != DBNull.Value)
            {
                EntityCollection<ATCApproveEntity> approves = new EntityCollection<ATCApproveEntity>();
                PredicateExpression pe = new PredicateExpression();
                pe.Add(ATCApproveEntityFields.DocumentCode == "ProductUnqualified");
                pe.Add(ATCApproveEntityFields.BillCode == unqualifiedCode.ToString());
                approves.Fetch(pe);
                foreach (ATCApproveEntity item in approves)
                {
                    item.IsApprovaled = false;
                    item.IsPass = false;
                    item.Update();
                }
            }
        }
    }
}