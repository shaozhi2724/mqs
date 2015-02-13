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

namespace DQS.AppViews.Operation.PriceManager
{
    public partial class FrmSalePrice : StandardForm
    {
        public FrmSalePrice()
        {
            InitializeComponent();
        }

        private void FrmSalePrice_Load(object sender, EventArgs e)
        {
            this.pageNavigator.SortField = "创建时间";
            this.pageNavigator.SortType = "DESC";
            base.InitPage();
        }



        protected override void CustomModify()
        {
            /*object id = this.gvData.GetFocusedRowCellValue("销售单ID");
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
UPDATE SD
    SET SD.Amount = SD.Amount + BD.Amount
FROM dbo.BUS_BillDetail AS BD
LEFT JOIN dbo.BUS_StoreDetail AS SD
ON BD.ProductID = SD.ProductID
AND BD.BatchNo = SD.BatchNo
WHERE BD.BillID='{0}' AND SD.DepartmentID='{1}'

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
                            cmd.CommandText = string.Format(sql, entity.BillID, departmentID);
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
            }*/
            base.CustomModify();
        }

        public string reason;
        protected override void CustomDelete()
        {
            base.CustomDelete();
        }

        protected override void CustomApprove()
        {
            base.CustomApprove();
            /*object id = this.gvData.GetFocusedRowCellValue("销售单ID");
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
            }*/
        }


        protected override void CustomRejectApprove()
        {
            /*object id = this.gvData.GetFocusedRowCellValue("销售单ID");
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
            }*/
            base.CustomRejectApprove();
        }

    }
}