using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using DevExpress.XtraEditors;
using DQS.Common;
using DQS.Module.Views;
using ORMSCore;
using DQS.Module.Entities;
using System.Data.SqlClient;
using DQS.Controls;

namespace DQS.Controls
{
    public partial class FrmApprove : DevExpress.XtraEditors.XtraForm
    {
        private string m_DocumentCode;
        private string m_BillCode;

        private AllApproveView m_AllApproveView;
        private int m_MaxApproveCount;

        public FrmApprove()
        {
            InitializeComponent();
        }

        public FrmApprove(string documentCode, string billCode)
        {
            InitializeComponent();
            this.m_DocumentCode = documentCode;
            this.m_BillCode = billCode;
        }

        public FrmApprove(AllApproveView allApproveView,int maxApproveCount)
        {
            InitializeComponent();
            this.m_AllApproveView = allApproveView;
            this.m_MaxApproveCount = maxApproveCount;
        }

        private void FrmApproveStatus_Load(object sender, EventArgs e)
        {
            this.txtApproveCode.Text = this.m_AllApproveView.编号;
            this.txtApproveTitle.Text = this.m_AllApproveView.标题;
            this.txtApprovalContent.Text = this.m_AllApproveView.内容;
            this.txtCreateUser.Text = this.m_AllApproveView.申请人;
            this.txtCreateDate.Text = this.m_AllApproveView.申请时间.ToString("yyyy-MM-dd HH:mm:ss");
            this.txtIsWhole.Text = this.m_AllApproveView.审批类型;
            this.txtIsPass.Text = this.m_AllApproveView.状态;

        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnOK_Click(object sender, EventArgs e)
        {
            ATCApproveEntity approve = new ATCApproveEntity();

            approve.ApproveID = this.m_AllApproveView.ApproveID;
            approve.ApprovalSuggestion = this.txtApprovalSuggestion.Text;
            approve.ApprovalResult = this.txtApprovalResult.Text;
            approve.ApprovalRemark = this.txtApprovalRemark.Text;
            approve.ApprovalDate = DateTime.Now;

            approve.IsApprovaled = true;

            EntityCollection<ATCApproveNotificationEntity> notifications = new EntityCollection<ATCApproveNotificationEntity>();
            PredicateExpression pe = new PredicateExpression();
            pe.Add(ATCApproveNotificationEntityFields.ApproveCode == m_AllApproveView.编号);
            pe.Add(ATCApproveNotificationEntityFields.FormClass == m_AllApproveView.DocumentCode);
            pe.Add(ATCApproveNotificationEntityFields.TargetCode == m_AllApproveView.BillCode);
            pe.Add(ATCApproveNotificationEntityFields.OwnerUserID == GlobalItem.g_CurrentUser.UserID);
            notifications.Fetch(pe);

            ATCApproveNotificationEntity notification = null;
            if (notifications.Count > 0)
            {
                notification = notifications[0] as ATCApproveNotificationEntity;
            }

            if (this.m_AllApproveView.ApproveOrder == this.m_MaxApproveCount)
            {
                //已审核通过，可修改状态
                approve.IsPass = true;
                approve.Update();

                if (null != notification)
                {
                    EntityCollection<ATCApproveNotificationEntity> notifs = new EntityCollection<ATCApproveNotificationEntity>();
                    PredicateExpression pes = new PredicateExpression();
                    pes.Add(ATCApproveNotificationEntityFields.FormClass == m_AllApproveView.DocumentCode);
                    pes.Add(ATCApproveNotificationEntityFields.TargetCode == m_AllApproveView.BillCode);
                    notifs.Fetch(pes);
                    foreach (var item in notifs)
                    {
                        ATCApproveNotificationEntity notifica = item as ATCApproveNotificationEntity;

                        notifica.IsRead = true;
                        notifica.ReadTime = DateTime.Now;
                        notifica.Update();
                    }
                }
                this.DialogResult = DialogResult.Yes;
            }
            else
            {
                if (null != notification)
                {
                    notification.IsRead = true;
                    notification.ReadTime = DateTime.Now;
                    notification.Update();
                }
                //未全部审核通过，不可修改状态
                approve.Update();

                this.DialogResult = DialogResult.No;
            }
            
        }

        private void btnDeny_Click(object sender, EventArgs e)
        {
            if (this.txtApprovalSuggestion.Text.Trim() == "")
            {
                XtraMessageBox.Show("请在审批意见中填写未通过原因。", "系统提示", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            if (this.txtApprovalResult.Text.Trim() == "")
            {
                XtraMessageBox.Show("请在审批结果中填写最终结果。", "系统提示", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            ATCApproveEntity approve = new ATCApproveEntity();

            approve.ApproveID = this.m_AllApproveView.ApproveID;
            approve.Fetch();
            EntityCollection<ATCApproveEntity> approves = new EntityCollection<ATCApproveEntity>();
            //直接把单据作废

            if (approve.DocumentCode == "PurchaseBackBill" || approve.DocumentCode == "PurchaseBill" || approve.DocumentCode == "SaleBackBill" || approve.DocumentCode == "SaleBill")
            {
                BUSBillEntity Entity = new BUSBillEntity { BillCode = approve.BillCode };
                Entity.Fetch();
                ProcessApproveRejection(Entity);
                approve.IsPass = false;
                approve.ApprovalSuggestion = this.txtApprovalSuggestion.Text.Trim();
                approve.ApprovalResult = this.txtApprovalResult.Text.Trim();
                approve.ApprovalRemark = this.txtApprovalRemark.Text.Trim();
                approve.ApprovalDate = DateTime.Now;
                approve.Update();
            }


            //逐步往上反推

            if (approve.DocumentCode == "FirstDealer" || approve.DocumentCode == "FirstProvider" || approve.DocumentCode == "FirstProduct")
            {
                PredicateExpression pe = new PredicateExpression();
                pe.Add(ATCApproveEntityFields.InternalNo == approve.InternalNo);
                pe.Add(ATCApproveEntityFields.BillCode == approve.BillCode);
                pe.Add(ATCApproveEntityFields.ApproveOrder <= approve.ApproveOrder);
                approves.Fetch(pe);
                List<ATCApproveEntity> tempList = new List<ATCApproveEntity>();
                foreach (ATCApproveEntity item in approves)
                {
                    tempList.Add(item);
                }
                var previouseApproves = tempList.OrderByDescending(p => p.ApproveOrder).Take(2).ToList();
                foreach (var entity in previouseApproves)
                {
                    ATCApproveEntity approveEntity = new ATCApproveEntity();

                    approveEntity.ApproveID = entity.ApproveID;
                    approveEntity.Fetch();

                    approveEntity.IsPass = false;
                    approveEntity.IsApprovaled = false;
                    if (approveEntity.ApprovalUserID == GlobalItem.g_CurrentUser.UserID)
                    {
                        approveEntity.ApprovalSuggestion = txtApprovalSuggestion.Text;
                        approveEntity.ApprovalResult = txtApprovalResult.Text;
                        approveEntity.ApprovalRemark = txtApprovalRemark.Text;
                        approveEntity.ApprovalDate = DateTime.Now;
                    }
                    approveEntity.Update();
                }
            }
            this.DialogResult = DialogResult.No;
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

DELETE BUS_OutStoreDetail WHERE BillID = '{0}'

DELETE BUS_NEWStoreDetail WHERE SaleBillID = '{0}'

UPDATE dbo.BUS_Bill SET BillStatus=10,BillStatusName='未批准',ReceiveID=NULL,ReviewCode=NULL,AcceptID=NULL,AcceptCode=NULL,Reservation10='未批准' WHERE BillID='{0}'";
            string sqltwo = @"
UPDATE dbo.BUS_Bill SET BillStatus=10,BillStatusName='未批准',ReceiveID=NULL,ReviewCode=NULL,AcceptID=NULL,AcceptCode=NULL,Reservation10='未批准' WHERE BillID='{0}'
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
                    if (billEntity.BillTypeName == "销售出货" || billEntity.BillTypeName == "采购退货")
                    {
                        cmd.CommandText = string.Format(sql, billEntity.BillID);
                    }
                    if (billEntity.BillTypeName == "采购进货" || billEntity.BillTypeName == "销售退货")
                    {
                        cmd.CommandText = string.Format(sqltwo, billEntity.BillID);
                    }
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
    }
}