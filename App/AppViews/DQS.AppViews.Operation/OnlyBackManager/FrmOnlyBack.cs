using DevExpress.XtraEditors;
using DQS.Common;
using DQS.Controls;
using DQS.Module.Entities;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace DQS.AppViews.Operation.OnlyBackManager
{
    public partial class FrmOnlyBack : StandardForm
    {
        public FrmOnlyBack()
        {
            InitializeComponent();
        }

        private void FrmOnlyBack_Load(object sender, EventArgs e)
        {
            this.pageNavigator.SortField = "直调单号";
            this.pageNavigator.SortType = "DESC";
            base.InitPage();
        }
        protected override void CustomApprove()
        {
            this.SaveDataLog("审批");
            object id = this.gvData.GetFocusedRowCellValue("直调单ID");
            if (id != null && id != DBNull.Value)
            {
                DialogResult dr = base.BaseApprove();
                if (dr == DialogResult.Yes)
                {
                    //更新销售单状态
                    BUSOnlyBillEntity entity = new BUSOnlyBillEntity { BillID = (int)id };
                    entity.Fetch();
                    if (entity.BillStatusName == "已下单")
                    {
                        entity.BillStatusName = "已审核";
                        entity.Update();
                    }
                    this.pageNavigator.ShowData();
                }
            }
        }


        protected override void CustomModify()
        {
            this.SaveDataLog("修改");
            object id = this.gvData.GetFocusedRowCellValue("直调单ID");
            if (id != null && id != DBNull.Value)
            {
                BUSOnlyBillEntity entity = new BUSOnlyBillEntity { BillID = (int)id };
                entity.Fetch();
                if (entity.BillStatusName == "已审核")
                {
                    XtraMessageBox.Show("销售单已审核通过，不允许修改！", "系统提示", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }
                else
                {
                    string sql = @"
UPDATE dbo.BUS_OnlyBill SET BillRemark = '修改' WHERE BillID = '{0}'
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
                    base.CustomModify();
                }
            }
        }


        protected override void CustomDelete()
        {
            this.SaveDataLog("删除");
            object id = this.gvData.GetFocusedRowCellValue("直调单ID");
            if (id != null && id != DBNull.Value)
            {
                BUSOnlyBillEntity entity = new BUSOnlyBillEntity { BillID = (int)id };
                entity.Fetch();
                if (entity.BillStatusName == "已审核")
                {
                    XtraMessageBox.Show(string.Format("销售单状态为：{0}，不允许删除！", entity.BillStatusName), "系统提示",
                        MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }
                DialogResult result = XtraMessageBox.Show("确定要删除该销售单吗？", "警告", MessageBoxButtons.OKCancel,
                    MessageBoxIcon.Question);
                if (result == DialogResult.OK)
                {

                    
                    string sql = @"
UPDATE dbo.BUS_OnlyBill SET BillStatusName='已删除',LastModifyDate=GETDATE(),LastModifyUserID='{1}' WHERE BillID='{0}'

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
                            cmd.CommandText = string.Format(sql, entity.BillID, GlobalItem.g_CurrentUser.UserID);
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
