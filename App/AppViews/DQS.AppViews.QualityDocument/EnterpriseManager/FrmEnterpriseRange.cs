using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using DevExpress.XtraEditors;
using DevExpress.XtraEditors.Controls;
using DQS.Module.Entities;
using ORMSCore;
using DQS.Controls;
using DQS.Common;
using System.Data.SqlClient;

namespace DQS.AppViews.QualityDocument.EnterpriseManager
{
    public partial class FrmEnterpriseRange : DevExpress.XtraEditors.XtraForm
    {
        List<string> oldRange = new List<string>();
        List<string> newRange = new List<string>();
        public FrmEnterpriseRange()
        {
            InitializeComponent();
        }

        private void FrmEnterpriseRange_Load(object sender, EventArgs e)
        {
            //EntityCollection<BFIEnterpriseEntity> enterprises = new EntityCollection<BFIEnterpriseEntity>();
            //enterprises.Fetch();

            //foreach (BFIEnterpriseEntity enterprise in enterprises)
            //{
            //    this.lbcEnterprise.Items.Add(new ListEntityItem(enterprise, enterprise.EnterpriseName));
            //}

            this.lbcEnterprise.Items.Add("本企业");

            //绑定经营品种
            EntityCollection<SYSCategoryEntity> categories = new EntityCollection<SYSCategoryEntity>();
            categories.Fetch(SYSCategoryEntityFields.CategoryCode == "ProductStyle");

            foreach (SYSCategoryEntity c in categories)
            {
                this.chklbcProductStyle.Items.Add(new ListEntityItem(c, c.ItemName));
            }

            //选中已有的经营品种
            EntityCollection<BFIBusinessRangeEntity> ranges = new EntityCollection<BFIBusinessRangeEntity>();
            ranges.Fetch(BFIBusinessRangeEntityFields.RangeStyle == 0);
            if (ranges.Count > 0)
            {
                this.chklbcProductStyle.UnCheckAll();//先全部清空

                foreach (BFIBusinessRangeEntity rang in ranges)
                {
                    foreach (CheckedListBoxItem item in this.chklbcProductStyle.Items)
                    {
                        SYSCategoryEntity category = (item.Value as ListEntityItem).Key as SYSCategoryEntity;

                        if (category.ItemID == rang.ProductStyleID)
                        {
                            this.chklbcProductStyle.SelectedItem = item;
                            item.CheckState = CheckState.Checked;
                            break;
                        }
                    }
                    oldRange.Add(rang.ProductStyleName);
                }
            }
            else
            {
                this.chklbcProductStyle.SelectedIndex = 0;
                this.chklbcProductStyle.UnCheckAll();
            }
        }

        private void chkCheck_CheckedChanged(object sender, EventArgs e)
        {
            if (chkCheck.Checked)
            {
                chkCheck.Text = "反选";
                this.chklbcProductStyle.CheckAll();
            }
            else
            {
                chkCheck.Text = "全选";
                this.chklbcProductStyle.UnCheckAll();
            }
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            try
            {
                if (chklbcProductStyle.CheckedItems.Count == 0)
                {
                    XtraMessageBox.Show("请选择经营范围。", "警告", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                    chklbcProductStyle.Focus();
                    return;
                }
                foreach (CheckedListBoxItem productStyle in this.chklbcProductStyle.CheckedItems)
                {
                    newRange.Add(productStyle.Value.ToString());
                }


                if (GlobalItem.g_CurrentUser.UserCode == "admin")
                {
                    //先全部删除
                    BFIBusinessRangeEntity range = new BFIBusinessRangeEntity { RangeStyle = 0 };
                    range.DeleteByCommonly();

                    //添加
                    foreach (CheckedListBoxItem productStyle in this.chklbcProductStyle.CheckedItems)
                    {
                        SYSCategoryEntity category = (productStyle.Value as ListEntityItem).Key as SYSCategoryEntity;
                        range.EnterpriseID = 1;
                        range.ProductStyleID = category.ItemID;
                        range.ProductStyleName = category.ItemName;
                        range.RangeStyle = 0;
                        range.RangeStyleName = "企业";
                        range.CreateDate = DateTime.Now;
                        range.LastModifyDate = DateTime.Now;
                        range.CreateUserID = GlobalItem.g_CurrentUser.UserID;
                        range.LastModifyUserID = GlobalItem.g_CurrentUser.UserID;
                        range.Save();
                    }
                    XtraMessageBox.Show("保存成功！", "系统提示", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    if (CheckList(oldRange, newRange))
                    {
                        MessageBox.Show("没有任何修改。");
                    }
                    else
                    {

                        EntityCollection<ATCUserPageEntity> userPages = new EntityCollection<ATCUserPageEntity>();
                        PredicateExpression pe = new PredicateExpression();
                        pe.Add(ATCUserPageEntityFields.UserID == GlobalItem.g_CurrentUser.UserID);
                        pe.Add(ATCUserPageEntityFields.DocumentCode == "RangeChange");
                        DataTable data = userPages.FetchTable(pe);

                        if (data.Rows.Count <= 0)
                        {
                            XtraMessageBox.Show("系统未设置您的审批流程，无法点击保存功能。", "警告", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                            return;
                        }

                        using (SqlConnection conn = new SqlConnection(GlobalItem.g_DbConnectStrings))
                        {
                            string sql = @"SELECT COUNT(0) num FROM dbo.BFI_RangeChange WHERE AppStatus = ''";

                            try
                            {
                                conn.Open();
                                SqlCommand comm = new SqlCommand(sql, conn);
                                int num = int.Parse(comm.ExecuteScalar().ToString());
                                if (num > 0)
                                {
                                    MessageBox.Show("有申请变更未处理，请处理后操作。");
                                    return;
                                }
                                else
                                {
                                    string code = "JYFW" + DateTime.Now.ToString("yyyyMMddHHmmss");
                                    string insertsql = @"EXEC sp_InsertOldRangeChange '{0}','{1}'";
                                    insertsql = string.Format(insertsql, code, GlobalItem.g_CurrentUser.UserName);
                                    comm = new SqlCommand(insertsql, conn);
                                    comm.ExecuteNonQuery();

                                    foreach (CheckedListBoxItem productStyle in this.chklbcProductStyle.CheckedItems)
                                    {
                                        SYSCategoryEntity category = (productStyle.Value as ListEntityItem).Key as SYSCategoryEntity;
                                        string insertnewsql = @"EXEC sp_InsertNewRangeChange '{0}',{1},'{2}'";
                                        comm = new SqlCommand(string.Format(insertnewsql, code, category.ItemID,category.ItemName), conn);
                                        comm.ExecuteNonQuery();
                                    }

                                    if (data.Rows.Count > 0)
                                    {
                                        //按审批顺序排序
                                        data.DefaultView.Sort = "ApprovalSort";
                                        data = data.DefaultView.ToTable();

                                        ATCApproveEntity approveEntity = new ATCApproveEntity();
                                        approveEntity.InternalNo = code;
                                        approveEntity.DocumentCode = "RangeChange";
                                        approveEntity.BillCode = code;
                                        approveEntity.ApproveTitle = string.Format("本企业经营范围变更，编号：{0}", code);
                                        approveEntity.ApprovalContent = String.Format("本企业经营范围变更，编号：{0}", code);
                                        approveEntity.CreateUserID = GlobalItem.g_CurrentUser.UserID;
                                        approveEntity.CreateDate = DateTime.Now;
                                        approveEntity.IsApprovaled = false;


                                        //获得新建的ID号
                                        string searchsql = @"SELECT ID FROM BFI_RangeChange WHERE ChangeCode = '" + code + "'";
                                        comm = new SqlCommand(searchsql, conn);
                                        int bgid = int.Parse(comm.ExecuteScalar().ToString());

                                        for (int i = 0; i < data.Rows.Count; i++)
                                        {
                                            var approveCode = approveEntity.InternalNo + (i + 1).ToString("00");
                                            approveEntity.ApproveCode = approveCode;
                                            approveEntity.IsWhole = Convert.ToBoolean(data.Rows[i]["IsWhole"]);
                                            approveEntity.ApproveOrder = Convert.ToInt32(data.Rows[i]["ApprovalSort"]);
                                            var approvalUserId = new Guid(data.Rows[i]["ApprovalUserID"].ToString());
                                            approveEntity.ApprovalUserID = approvalUserId;
                                            approveEntity.Save();

                                            //添加消息提醒
                                            ATCApproveNotificationEntity notification = new ATCApproveNotificationEntity();
                                            notification.CreateUserID = approveEntity.CreateUserID;
                                            var userName = GlobalItem.g_CurrentEmployee == null
                                                ? GlobalItem.g_CurrentUser.UserName
                                                : GlobalItem.g_CurrentEmployee.EmployeeName;
                                            notification.CreateUserName = userName;
                                            notification.FormClass = "RangeChange";
                                            notification.IsRead = false;
                                            notification.TargetID = bgid;
                                            notification.TargetCode = code;
                                            notification.ApproveCode = approveCode;
                                            notification.Message = string.Format("{0} 于 {1} 本企业经营范围变更申请（单号 {2}）。请您审批。", userName,
                                                DateTime.Now.ToString("yyyy-MM-dd HH:mm:ss"), code);
                                            notification.OwnerUserID = approvalUserId;
                                            notification.Save();
                                        }
                                    }

                                    MessageBox.Show("变更申请保存成功。");
                                }
                            }
                            catch (Exception ex)
                            {
                                MessageBox.Show(ex.ToString());
                            }
                            finally
                            {
                                conn.Close();
                            }
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                XtraMessageBox.Show(ex.Message, "系统错误", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private bool CheckList(List<string> lista, List<string> listb)
        {
            bool isall = true;
            foreach (var item in lista)
            {
                if (!listb.Contains(item))
                {
                    isall = false;
                    return isall;
                }
            }
            foreach (var item in listb)
            {
                if (!lista.Contains(item))
                {
                    isall = false;
                    return isall;
                }
            }
            return isall;
        }
    }
}