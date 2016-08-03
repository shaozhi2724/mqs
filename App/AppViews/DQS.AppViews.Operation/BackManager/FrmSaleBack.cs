using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using DevExpress.XtraEditors;
using DQS.Common;
using DQS.Controls;
using DQS.Module.Entities;
using ORMSCore;

namespace DQS.AppViews.Operation.BackManager
{
    public partial class FrmSaleBack : StandardForm
    {
	
        public string reason;
        public FrmSaleBack()
        {
            InitializeComponent();
        }

        private void FrmSaleBack_Load(object sender, EventArgs e)
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
                    XtraMessageBox.Show(string.Format("退货单状态为：{0}，不允许修改！", entity.BillStatusName), "系统提示", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }
                base.CustomModify();
            }
        }


        protected override void CustomDelete()
        {
            object id = this.gvData.GetFocusedRowCellValue("退货单ID");
            if (id != null && id != DBNull.Value)
            {
                BUSBillEntity entity = new BUSBillEntity {BillID = (int) id};
                entity.Fetch();
                if (entity.BillStatus > 2)
                {
                    XtraMessageBox.Show(string.Format("退货单状态为：{0}，不允许删除！", entity.BillStatusName), "系统提示",
                        MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                /*EntityCollection<ATCApproveEntity> approveEntities = new EntityCollection<ATCApproveEntity>();
                PredicateExpression pe = new PredicateExpression();
                pe.Add(ATCApproveEntityFields.DocumentCode == "SaleBackBill");
                pe.Add(ATCApproveEntityFields.BillCode == entity.BillCode);
                pe.Add(ATCApproveEntityFields.IsApprovaled == 0);
                approveEntities.Fetch(pe);
                if (approveEntities.Count > 0)
                {
                    XtraMessageBox.Show("退货单正在审核中，不允许删除！", "系统提示", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }*/
                DialogResult result = XtraMessageBox.Show("确定要删除该退货单吗？", "警告", MessageBoxButtons.OKCancel, MessageBoxIcon.Question);
                if (result == DialogResult.OK)
                {
                    using (FrmReason fr = new FrmReason(this))
                    {
                        if (DialogResult.Yes == fr.ShowDialog())
                        {
                            string userName = "";
                            string usersql = "SELECT UserName FROM dbo.ATC_User WHERE UserID = '" + GlobalItem.g_CurrentUser.UserID + "'";
                            using (SqlConnection conn = new SqlConnection(GlobalItem.g_DbConnectStrings))
                            {
                                conn.Open();//连接数据库
                                //开始一个本地事务
                                SqlTransaction transaction = conn.BeginTransaction("PurchaseTransaction");
                                //必须为SqlCommand指定数据库连接和登记的事务
                                SqlCommand cmd = new SqlCommand(usersql, conn, transaction);
                                try
                                {
                                    userName = cmd.ExecuteScalar().ToString();

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
                            string time = string.Format("{0:yyyy年MM月dd日 HH:mm:ss}", DateTime.Now);
                            //删除
                            entity.BillStatus = 9;
                            entity.BillStatusName = "已删除";
                            entity.LastModifyDate = DateTime.Now;
                            entity.LastModifyUserID = GlobalItem.g_CurrentUser.UserID;
                            entity.Reservation5 = "已删除。操作员：" + userName + "于" + time + "删除，删除原因为：" + reason;
                            entity.Update();
                            this.pageNavigator.ShowData();
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
                storeBills.Fetch(BUSStoreBillEntityFields.PurchaseBillID == (int)id);

                if (storeBills.Count > 0)
                {
                    XtraMessageBox.Show("退货单对应的入库单已生成，不允许反审批！", "系统提示", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                DialogResult result = XtraMessageBox.Show("反审批操作将删除此记录对应的收货和验收记录，确定要反审批退货单吗？", "警告", MessageBoxButtons.OKCancel, MessageBoxIcon.Question);
                if (result == DialogResult.OK)
                {
                    ProcessApproveRejection(entity);
                }
            }
            base.CustomRejectApprove();
        }

        private void ProcessApproveRejection(BUSBillEntity billEntity)
        {
            //删除退货单相关的收货、验收、拒收
            string sql = @"
DELETE dbo.BUS_ReceiveInspection WHERE ReceiveID=(SELECT ReceiveID FROM dbo.BUS_Receive WHERE BillID='{0}')
DELETE dbo.BUS_ReceiveTemperatureAttachment WHERE ReceiveID=(SELECT ReceiveID FROM dbo.BUS_Receive WHERE BillID='{0}')
DELETE dbo.BUS_ReceiveDetail WHERE ReceiveID=(SELECT ReceiveID FROM dbo.BUS_Receive WHERE BillID='{0}')
DELETE dbo.BUS_Receive WHERE BillID='{0}'

DELETE dbo.BUS_AcceptAttachment WHERE AcceptID=(SELECT AcceptID FROM dbo.BUS_Accept WHERE BillID='{0}')
DELETE dbo.BUS_AcceptDetail WHERE AcceptID=(SELECT AcceptID FROM dbo.BUS_Accept WHERE BillID='{0}')
DELETE dbo.BUS_Sampling WHERE AcceptID=(SELECT AcceptID FROM dbo.BUS_Accept WHERE BillID='{0}')
DELETE dbo.BUS_Accept WHERE BillID='{0}'

DELETE dbo.BUS_DeclinedDetail WHERE DeclinedID=(SELECT DeclinedID FROM dbo.BUS_Declined WHERE BillID='{0}')
DELETE dbo.BUS_Declined WHERE BillID='{0}'

UPDATE dbo.BUS_Bill SET BillStatus=1,BillStatusName='已下单',ReceiveID=NULL,ReviewCode=NULL,AcceptID=NULL,AcceptCode=NULL,Reservation10='反审批' WHERE BillID='{0}'
";
            using (SqlConnection conn = new SqlConnection(GlobalItem.g_DbConnectStrings))
            {
                conn.Open();//连接数据库
                //开始一个本地事务
                SqlTransaction transaction = conn.BeginTransaction("SaleBackTransaction");
                //必须为SqlCommand指定数据库连接和登记的事务
                SqlCommand cmd = new SqlCommand("", conn, transaction);
                try
                {
                    //向数据表中插入记录的命令语句
                    cmd.CommandText = string.Format(sql, billEntity.BillID);
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
    }
}