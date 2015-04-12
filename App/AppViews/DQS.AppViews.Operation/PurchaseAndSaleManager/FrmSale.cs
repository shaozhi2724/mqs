using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using DevExpress.XtraEditors;
using DQS.Common;
using DQS.Controls;
using DQS.Module.Entities;
using ORMSCore;

namespace DQS.AppViews.Operation.PurchaseAndSaleManager
{
    public partial class FrmSale : StandardForm
    {
        public FrmSale()
        {
            InitializeComponent();
        }

        private void FrmSale_Load(object sender, EventArgs e)
        {
            SetDealerAreaFilter();
            this.cbxBillStatus.InitSource();
            this.pageNavigator.SortField = "销售单号";
            this.pageNavigator.SortType = "DESC";
            base.InitPage();
        }

        private void SetDealerAreaFilter()
        {
            string defaultDealerFilter = pageNavigator.Filter;

            EntityCollection<ATCUserAreaEntity> grantedUserAreas = new EntityCollection<ATCUserAreaEntity>();
            grantedUserAreas.Fetch(ATCUserAreaEntityFields.UserID == GlobalItem.g_CurrentUser.UserID);

            string areaFilter = "";
            List<string> areas = new List<string>();
            if (grantedUserAreas.Count > 0)
            {
                foreach (var grantedUserArea in grantedUserAreas)
                {
                    ATCUserAreaEntity userArea = (ATCUserAreaEntity)grantedUserArea;
                    if (!string.IsNullOrWhiteSpace(userArea.AreaName))
                    {
                        areas.Add(userArea.AreaName);
                    }
                }
            }
            if (areas.Any())
            {
                areaFilter = string.Join("','", areas);
            }

            if (!string.IsNullOrWhiteSpace(areaFilter))
            {
                areaFilter = string.Format("'{0}'", areaFilter);

                pageNavigator.DefaultFilter = string.Format("(所属销售区域 IN ({0}))", areaFilter);

                if (!string.IsNullOrWhiteSpace(defaultDealerFilter))
                {
                    pageNavigator.Filter = string.Format("({0}) AND (所属销售区域 IN ({1}))", defaultDealerFilter, areaFilter);
                }
                else
                {
                    pageNavigator.Filter = string.Format("(所属销售区域 IN ({0}))", areaFilter);
                }
            }
        }


        protected override void CustomModify()
        {
            object id = this.gvData.GetFocusedRowCellValue("销售单ID");
            if (id != null && id != DBNull.Value)
            {
                BUSBillEntity entity = new BUSBillEntity { BillID = (int)id };
                entity.Fetch();
                //if (entity.BillStatusName == "已审核" || entity.BillStatusName == "已删除" || entity.BillStatusName == "未批准")
                if (entity.BillStatus >1)
                {
                    XtraMessageBox.Show("销售单" + entity.BillStatusName + "，不允许修改！", "系统提示", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }
//不能在点击修改时就将减掉的业务库存加回来，此操作必须在修改点击“保存”之前做，避免用户点修改后又取消
                else
                {
                    /*
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
                    }*/
                    string sql = @"
UPDATE dbo.BUS_Bill SET BillStatus=1,BillStatusName='已下单',ReceiveID=NULL,ReviewCode=NULL,AcceptID=NULL,AcceptCode=NULL,Reservation10='修改' WHERE BillID='{0}'
";
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
                }

                base.CustomModify();
            }
        }

        public string reason;
        protected override void CustomDelete()
        {
            object id = this.gvData.GetFocusedRowCellValue("销售单ID");
            if (id != null && id != DBNull.Value)
            {
                BUSBillEntity entity = new BUSBillEntity {BillID = (int) id};
                entity.Fetch();
                if (entity.BillStatus > 2)
                {
                    XtraMessageBox.Show(string.Format("销售单状态为：{0}，不允许删除！", entity.BillStatusName), "系统提示",
                        MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                /*EntityCollection<ATCApproveEntity> approveEntities = new EntityCollection<ATCApproveEntity>();
                PredicateExpression pe = new PredicateExpression();
                pe.Add(ATCApproveEntityFields.DocumentCode == "SaleBill");
                pe.Add(ATCApproveEntityFields.BillCode == entity.BillCode);
                pe.Add(ATCApproveEntityFields.IsApprovaled == 0);
                approveEntities.Fetch(pe);
                if (approveEntities.Count > 0)
                {
                    XtraMessageBox.Show("销售单正在审核中，不允许删除！", "系统提示", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }*/


                DialogResult result = XtraMessageBox.Show("确定要删除该销售单吗？", "警告", MessageBoxButtons.OKCancel,
                    MessageBoxIcon.Question);
                if (result == DialogResult.OK)
                {
                    using (FrmReason fr = new FrmReason(this))
                    {
                        if (DialogResult.Yes == fr.ShowDialog())
                        {
                            //将销售单减掉的业务库存加回来
                            string sql = @"
UPDATE SD
    SET SD.Amount = SD.Amount + BD.Amount
FROM dbo.BUS_BillDetail AS BD
LEFT JOIN dbo.BUS_StoreDetail AS SD
ON BD.ProductID = SD.ProductID
AND BD.BatchNo = SD.BatchNo
WHERE BD.BillID='{0}'

UPDATE dbo.BUS_Bill SET BillStatus=9,BillStatusName='已删除',LastModifyDate=GETDATE(),LastModifyUserID='{1}',Reservation5='已删除。操作员：'+(SELECT UserName FROM dbo.ATC_User WHERE UserID = '{1}')+'于'+CONVERT(varchar(100), GETDATE(), 20)+'删除，删除原因为：'+'{2}' WHERE BillID='{0}'

";
                            using (SqlConnection conn = new SqlConnection(GlobalItem.g_DbConnectStrings))
                            {
                                conn.Open(); //连接数据库
                                //开始一个本地事务
                                SqlTransaction transaction = conn.BeginTransaction("SaleDeletionTransaction");
                                //必须为SqlCommand指定数据库连接和登记的事务
                                SqlCommand cmd = new SqlCommand("", conn, transaction);
                                try
                                {
                                    //向数据表中插入记录的命令语句
                                    cmd.CommandText = string.Format(sql, entity.BillID, GlobalItem.g_CurrentUser.UserID,reason);
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
                    }
                }
            }
        }

        protected override void CustomApprove()
        {
            object id = this.gvData.GetFocusedRowCellValue("销售单ID");
            if (id != null && id != DBNull.Value)
            {
                DialogResult dr = base.BaseApprove();
                if (dr == DialogResult.Yes)
                {
                    //更新销售单状态
                    BUSBillEntity entity = new BUSBillEntity {BillID = (int) id};
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

        /*
        protected override void CustomAdd()
        {
            string sql = "SELECT TOP 1 Code FROM dbo.WMS_RegulatoryCode WHERE StatusID = 0 AND StatusName = '未使用'";
            using (SqlConnection conn = new SqlConnection(GlobalItem.g_DbConnectStrings))
            {
                conn.Open(); //连接数据库
                //必须为SqlCommand指定数据库连接和登记的事务
                SqlCommand cmd = new SqlCommand(sql, conn);
                try
                {
                    cmd.CommandText = string.Format(sql);
                    object code = cmd.ExecuteScalar();
                    if (code != null && code != DBNull.Value)
                    {
                        base.CustomAdd();
                    }
                    else
                    {
                        XtraMessageBox.Show("没有可用流通监管码，请联系管理员成功导入后再使用。", "系统提示", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        return;
                    }
                }
                catch (Exception ex)
                {

                }
                finally
                {
                    conn.Close();
                }
            }
            
        }
        */

        protected override void CustomRejectApprove()
        {
            object id = this.gvData.GetFocusedRowCellValue("销售单ID");
            if (id != null && id != DBNull.Value)
            {
                BUSBillEntity entity = new BUSBillEntity { BillID = (int)id };
                entity.Fetch();
                if (entity.BillStatus < 2)
                {
                    XtraMessageBox.Show("销售单还未通过审核，请直接修改！", "系统提示", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                EntityCollection<BUSStoreBillEntity> storeBills = new EntityCollection<BUSStoreBillEntity>();
                storeBills.Fetch(BUSStoreBillEntityFields.SaleBillID == (int)id);

                if (storeBills.Count > 0)
                {
                    XtraMessageBox.Show("销售单对应的出库单已生成，不允许反审批！", "系统提示", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                DialogResult result = XtraMessageBox.Show("确定要反审批销售单吗？", "警告", MessageBoxButtons.OKCancel, MessageBoxIcon.Question);
                if (result == DialogResult.OK)
                {
                    if (entity.BillStatus != 2)
                    {
                        XtraMessageBox.Show("当前单据状态为："+entity.BillStatusName+"，不允许反审批！", "警告", MessageBoxButtons.OK, MessageBoxIcon.Stop);
                        return;
                    }
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

/*
              string sql = @"
UPDATE SD
    SET SD.Amount = SD.Amount + BD.Amount
FROM dbo.BUS_BillDetail AS BD
LEFT JOIN dbo.BUS_StoreDetail AS SD
ON BD.ProductID = SD.ProductID
AND BD.BatchNo = SD.BatchNo
WHERE BD.BillID='{0}' AND SD.DepartmentID='{1}'

UPDATE dbo.BUS_Bill SET BillStatus=1,BillStatusName='已下单',ReceiveID=NULL,ReviewCode=NULL,AcceptID=NULL,AcceptCode=NULL,Reservation10='反审批' WHERE BillID='{0}'
";*/
            string sql = @"UPDATE dbo.BUS_Bill SET BillStatus=1,BillStatusName='已下单',ReceiveID=NULL,ReviewCode=NULL,AcceptID=NULL,AcceptCode=NULL,Reservation10='反审批' WHERE BillID='{0}'";
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
    }
}