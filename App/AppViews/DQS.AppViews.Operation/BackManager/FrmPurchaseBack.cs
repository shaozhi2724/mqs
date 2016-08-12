using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using DevExpress.XtraEditors;
using DevExpress.XtraGrid.Views.Grid;
using DQS.Common;
using DQS.Controls;
using DQS.Module.Entities;
using ORMSCore;
using DQS.AppViews.Operation.Properties;

namespace DQS.AppViews.Operation.BackManager
{
    public partial class FrmPurchaseBack : StandardForm
    {
        public FrmPurchaseBack()
        {
            InitializeComponent();
        }

        private void FrmPurchaseBack_Load(object sender, EventArgs e)
        {
            this.cbxBillStatus.InitSource();
            this.pageNavigator.SortField = "退货单编号";
            this.pageNavigator.SortType = "DESC";
            base.InitPage();
        }


        protected override void CustomModify()
        {
            object id = this.gvData.GetFocusedRowCellValue("退货单ID");
            if (id != null && id != DBNull.Value)
            {
                BUSBillEntity entity = new BUSBillEntity { BillID = (int)id };
                entity.Fetch();
                if (entity.BillStatus > 1)
                {
                    XtraMessageBox.Show("退货单" + entity.BillStatusName + "，不允许修改！", "系统提示", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }
                else
                {
                    int departmentID = 0;
                    var billCreateUserId = entity.CreateUserID;
                    ATCUserEntity userEntity = new ATCUserEntity { UserID = billCreateUserId };
                    userEntity.Fetch();
                    var billCreateEmployeeId = userEntity.EmployeeID;
                    var employee = new BFIEmployeeEntity { EmployeeID = billCreateEmployeeId };
                    employee.Fetch();
                    if (!employee.IsNullField("DepartmentID"))
                    {
                        departmentID = employee.DepartmentID;
                    }
                    string sql = @"
UPDATE dbo.BUS_Bill SET BillStatus=1,BillStatusName='已下单',ReceiveID=NULL,ReviewCode=NULL,AcceptID=NULL,AcceptCode=NULL,Reservation10='修改' WHERE BillID='{0}'
";
//                    string sql = @"
//UPDATE SD
//    SET SD.Amount = SD.Amount + BD.Amount
//FROM dbo.BUS_BillDetail AS BD
//LEFT JOIN dbo.BUS_StoreDetail AS SD
//ON BD.ProductID = SD.ProductID
//AND BD.BatchNo = SD.BatchNo
//WHERE BD.BillID='{0}' AND SD.DepartmentID='{1}'
//
//UPDATE dbo.BUS_Bill SET BillStatus=1,BillStatusName='已下单',ReceiveID=NULL,ReviewCode=NULL,AcceptID=NULL,AcceptCode=NULL,Reservation10='修改' WHERE BillID='{0}'
//";
                    using (SqlConnection conn = new SqlConnection(GlobalItem.g_DbConnectStrings))
                    {
                        conn.Open();//连接数据库
                        //开始一个本地事务
                        SqlTransaction transaction = conn.BeginTransaction("SaleTransaction");
                        //必须为SqlCommand指定数据库连接和登记的事务
                        SqlCommand cmd = new SqlCommand("", conn, transaction);
                        try
                        {
                            //向数据表中插入记录的命令语句
                            cmd.CommandText = string.Format(sql, entity.BillID);
                            cmd.ExecuteNonQuery();
                            transaction.Commit();//提交事务
                        }
                        catch (Exception ex)
                        {
                            try
                            {
                                transaction.Rollback();//回滚事务
                            }
                            catch (Exception ex2)
                            {
                            }
                        }
                    }
                    base.CustomModify();
                }
            }
        }

        public string reason;
        protected override void CustomDelete()
        {
            object id = this.gvData.GetFocusedRowCellValue("退货单ID");
            if (id != null && id != DBNull.Value)
            {
                BUSBillEntity entity = new BUSBillEntity { BillID = (int)id };
                entity.Fetch();
                if (entity.BillStatus > 2)
                {
                    XtraMessageBox.Show(string.Format("退货单状态为：{0}，不允许删除！", entity.BillStatusName), "系统提示",
                        MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                /*EntityCollection<ATCApproveEntity> approveEntities = new EntityCollection<ATCApproveEntity>();
                PredicateExpression pe = new PredicateExpression();
                pe.Add(ATCApproveEntityFields.DocumentCode == "PurchaseBackBill");
                pe.Add(ATCApproveEntityFields.BillCode == entity.BillCode);
                pe.Add(ATCApproveEntityFields.IsApprovaled == 0);
                approveEntities.Fetch(pe);
                if (approveEntities.Count > 0)
                {
                    XtraMessageBox.Show("退货单正在审核中，不允许删除！", "系统提示", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }*/

                DialogResult result = XtraMessageBox.Show("确定要删除该退货单吗？", "警告", MessageBoxButtons.OKCancel,
                    MessageBoxIcon.Question);
                if (result == DialogResult.OK)
                {

                    using (FrmReason fr = new FrmReason(this))
                    {
                        if (DialogResult.Yes == fr.ShowDialog())
                        {
                            if (entity.ContractNo == "不合格")
                            {
                                //将销售单减掉的业务库存加回来
                                string sql = @"
UPDATE SD
    SET SD.Amount = SD.Amount + BD.Amount
FROM dbo.BUS_BillDetail AS BD
LEFT JOIN dbo.BUS_UnqualifiedStoreDetail AS SD
ON BD.ProductID = SD.ProductID
AND BD.BatchNo = SD.BatchNo
WHERE BD.BillID='{0}'


UPDATE dbo.BUS_Bill SET BillStatus=9,BillStatusName='已删除',LastModifyDate=GETDATE(),LastModifyUserID='{1}',Reservation5='已删除。操作员：'+(SELECT UserName FROM dbo.ATC_User WHERE UserID = '{1}')+'于'+CONVERT(varchar(100), GETDATE(), 20)+'删除，删除原因为：'+'{2}' WHERE BillID='{0}'
";
                                using (SqlConnection conn = new SqlConnection(GlobalItem.g_DbConnectStrings))
                                {
                                    conn.Open(); //连接数据库
                                    //开始一个本地事务
                                    SqlTransaction transaction = conn.BeginTransaction("PBDeletionTransaction");
                                    //必须为SqlCommand指定数据库连接和登记的事务
                                    SqlCommand cmd = new SqlCommand("", conn, transaction);
                                    try
                                    {
                                        //向数据表中插入记录的命令语句
                                        cmd.CommandText = string.Format(sql, entity.BillID, GlobalItem.g_CurrentUser.UserID, reason);
                                        cmd.ExecuteNonQuery();
                                        transaction.Commit(); //提交事务
                                    }
                                    catch (Exception ex)
                                    {
                                        try
                                        {
                                            transaction.Rollback(); //回滚事务
                                        }
                                        catch (Exception ex2)
                                        {
                                        }
                                    }
                                }
                                this.pageNavigator.ShowData();
                            }
                            else
                            {
                                //将销售单减掉的业务库存加回来
                                string Updatesql = @"
UPDATE dbo.BUS_Bill SET BillStatus=9,BillStatusName='已删除',LastModifyDate=GETDATE(),LastModifyUserID='{1}',Reservation5='已删除。操作员：'+(SELECT UserName FROM dbo.ATC_User WHERE UserID = '{1}')+'于'+CONVERT(varchar(100), GETDATE(), 20)+'删除，删除原因为：'+'{2}' WHERE BillID='{0}'";
                                string DelNewsql = "EXEC sp_NewStoreDetailDeleteBill ";
                                using (SqlConnection conn = new SqlConnection(GlobalItem.g_DbConnectStrings))
                                {
                                    DataSet ds = new DataSet();
                                    conn.Open();
                                    try
                                    {
                                        Updatesql = string.Format(Updatesql, entity.BillID, GlobalItem.g_CurrentUser.UserID, reason);
                                        SqlCommand Bcommand = new SqlCommand(Updatesql, conn);
                                        Bcommand.ExecuteNonQuery();
                                        SqlCommand comm = new SqlCommand(DelNewsql + entity.BillID, conn);
                                            comm.ExecuteNonQuery();
                                    }
                                    catch (Exception ex)
                                    {
                                        XtraMessageBox.Show(ex.Message.ToString(), "提示", MessageBoxButtons.OK, MessageBoxIcon.Error);
                                    }
                                    finally
                                    {
                                        conn.Close();
                                    }
                                }
                                this.pageNavigator.ShowData();
                            }
                        }
                    }
                }
            }
        }

        protected override void CustomApprove()
        {
            object id = this.gvData.GetFocusedRowCellValue("退货单ID");
            if (id != null && id != DBNull.Value)
            {
                string statusName = gvData.GetFocusedRowCellValue("状态").ToString();
                if (statusName == "未批准")
                {
                    XtraMessageBox.Show("该单据已作废，不允许再次审批", "系统提示", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    return;
                }
                DialogResult dr = base.BaseApprove();
                if (dr == DialogResult.Yes)
                {
                    //更新采购单状态

                    BUSBillEntity entity = new BUSBillEntity { BillID = (int)id };
                    entity.Fetch();
                    if (entity.BillStatus == 1)
                    {
                        entity.BillStatus = 2;
                        entity.BillStatusName = "已审核";
                        entity.Update();
                    }
                    this.pageNavigator.ShowData();
                }
            }
        }


        protected override void CustomRejectApprove()
        {
            object id = this.gvData.GetFocusedRowCellValue("退货单ID");
            if (id != null && id != DBNull.Value)
            {
                BUSBillEntity entity = new BUSBillEntity { BillID = (int)id };
                entity.Fetch();
                if (entity.BillStatus < 2)
                {
                    XtraMessageBox.Show("退货单还未通过审核，请直接修改！", "系统提示", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                EntityCollection<BUSStoreBillEntity> storeBills = new EntityCollection<BUSStoreBillEntity>();
                storeBills.Fetch(BUSStoreBillEntityFields.SaleBillID == (int)id);

                if (storeBills.Count > 0)
                {
                    XtraMessageBox.Show("退货单对应的出库单已生成，不允许反审批！", "系统提示", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                DialogResult result = XtraMessageBox.Show("确定要反审批退货单吗？", "警告", MessageBoxButtons.OKCancel, MessageBoxIcon.Question);
                if (result == DialogResult.OK)
                {
                    ProcessApproveRejection(entity);
                }
            }
            base.CustomRejectApprove();
        }

        private void ProcessApproveRejection(BUSBillEntity billEntity)
        {
            int departmentID = 0;
            var billCreateUserId = billEntity.CreateUserID;
            ATCUserEntity userEntity = new ATCUserEntity { UserID = billCreateUserId };
            userEntity.Fetch();
            var billCreateEmployeeId = userEntity.EmployeeID;
            var employee = new BFIEmployeeEntity { EmployeeID = billCreateEmployeeId };
            employee.Fetch();

            if (!employee.IsNullField("DepartmentID"))
            {
                departmentID = employee.DepartmentID;
            }
            //将销售单减掉的业务库存加回来
            string sql = @"
UPDATE dbo.BUS_Bill SET BillStatus=1,BillStatusName='已下单',ReceiveID=NULL,ReviewCode=NULL,AcceptID=NULL,AcceptCode=NULL,Reservation10='反审批' WHERE BillID='{0}'
";
            using (SqlConnection conn = new SqlConnection(GlobalItem.g_DbConnectStrings))
            {
                conn.Open();//连接数据库
                //开始一个本地事务
                SqlTransaction transaction = conn.BeginTransaction("PurchaseBackTransaction");
                //必须为SqlCommand指定数据库连接和登记的事务
                SqlCommand cmd = new SqlCommand("", conn, transaction);
                try
                {
                    //向数据表中插入记录的命令语句
                    cmd.CommandText = string.Format(sql, billEntity.BillID, departmentID);
                    cmd.ExecuteNonQuery();
                    transaction.Commit();//提交事务
                }
                catch (Exception ex)
                {
                    try
                    {
                        transaction.Rollback();//回滚事务
                    }
                    catch (Exception ex2)
                    {
                    }
                }
            }
            base.CustomModify();
        }
        protected override void CustomChangeStatus()
        {
            object id = this.gvData.GetFocusedRowCellValue("退货单ID");
            if (id != null && id != DBNull.Value)
            {
                BUSBillEntity entity = new BUSBillEntity { BillID = (int)id };
                entity.Fetch();
                if (entity.BillStatus > 2)
                {
                    XtraMessageBox.Show(string.Format("状态为{0}，不允许重置已下单状态！", entity.BillStatusName),
                        "系统提示", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }
                else
                {
                    entity.BillStatus = 1;
                    entity.BillStatusName = "已下单";
                    entity.Update();
                }


                EntityCollection<ATCApproveEntity> approveEntitys = new EntityCollection<ATCApproveEntity>();
                approveEntitys.Fetch(ATCApproveEntityFields.BillCode == entity.BillCode);

                if (approveEntitys.Count > 0)
                {
                    foreach (var approveEntity in approveEntitys)
                    {
                        ATCApproveEntity approve = (ATCApproveEntity)approveEntity;
                        approve.IsApprovaled = false;
                        approve.IsPass = false;
                        approve.Update();
                    }
                }
            }
            base.CustomChangeStatus();
            this.pageNavigator.ShowData();
        }

        protected override void CustomRegulatoryCode()
        {
            object id = this.gvData.GetFocusedRowCellValue("退货单ID");
            if (id != null && id != DBNull.Value)
            {
                string code = this.gvData.GetFocusedRowCellValue("退货单编号").ToString();
                using (FrmViewRegulatoryCode frm = new FrmViewRegulatoryCode())
                {
                    frm._Code = code;
                    frm.ShowDialog();
                }
            }
            base.CustomRegulatoryCode();
        }
    }
}