using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using DevExpress.XtraEditors;
using DQS.Module.Entities;
using ORMSCore;
using DQS.Common;

namespace DQS.AppViews.ExceptionControl.ExceptionManager
{
    public partial class FrmSingleProdcutDestroy : DevExpress.XtraEditors.XtraForm
    {
        private int? m_id;

        public FrmSingleProdcutDestroy()
        {
            InitializeComponent();
        }


        private void FrmSingleProdcutDestroy_Load(object sender, EventArgs e)
        {
            this.popupGrid.InitGrid();

            if (this.Tag != null)
            {
                this.m_id = Convert.ToInt32(this.Tag);

                BUSProdcutDestroyEntity entity = new BUSProdcutDestroyEntity { DestroyID = m_id.Value };
                entity.Fetch();

                this.ftPanel.SetEntity(entity);

                this.CustomGetEntity(entity);

                this.txtDestroyCode.Enabled = false;

                this.popupGrid.SetGridData(m_id.Value);
                if (entity.DestroyStatusID != 0)
                {
                    btnSave.Enabled = false;
                }
                EntityCollection<ATCApproveEntity> approveEntities = new EntityCollection<ATCApproveEntity>();
                PredicateExpression pe = new PredicateExpression();
                pe.Add(ATCApproveEntityFields.DocumentCode == "ProductDestroy");
                pe.Add(ATCApproveEntityFields.BillCode == entity.DestroyCode);
                pe.Add(ATCApproveEntityFields.IsApprovaled == 1);
                approveEntities.Fetch(pe);
                if (approveEntities.Count > 0)
                {
                    btnSave.Enabled = false;
                }
            }
            else
            {
                this.txtDestroyCode.Text = "YPXH" + DateTime.Now.ToString("yyyyMMddHHmmss");
                this.txtDestroyCode.Select(this.txtDestroyCode.Text.Length, 0);
                if (GlobalItem.g_CurrentEmployee != null)
                {
                    txtTransactor.Text = GlobalItem.g_CurrentEmployee.EmployeeName;
                }
                else
                {
                    txtTransactor.Text = GlobalItem.g_CurrentUser.UserName;
                }
                dteDestroyDate.DateTime = DateTime.Now;
                tmeDestroyTime.Time = DateTime.Now;
            }
        }

        private void btnSave_Click(object sender, EventArgs e)
        {

            try
            {
                if (!this.ftPanel.ValidateIsNullFields()) return;
                if (!ValidateDestroyDate()) return;
                BUSProdcutDestroyEntity entity = this.ftPanel.GetEntity() as BUSProdcutDestroyEntity;

                this.CustomSetEntity(entity);

                if (this.m_id != null)
                {
                    #region 修改

                    entity.LastModifyDate = DateTime.Now;
                    entity.LastModifyUserID = GlobalItem.g_CurrentUser.UserID;
                    entity.Update();

                    #endregion
                }
                else
                {
                    if (entity.IsNew())
                    {
                        EntityCollection<ATCUserPageEntity> userPages = new EntityCollection<ATCUserPageEntity>();
                        PredicateExpression pe = new PredicateExpression();
                        pe.Add(ATCUserPageEntityFields.UserID == GlobalItem.g_CurrentUser.UserID);
                        pe.Add(ATCUserPageEntityFields.DocumentCode == "ProductDestroy");
                        DataTable data = userPages.FetchTable(pe);

                        if (data.Rows.Count <= 0)
                        {
                            XtraMessageBox.Show("系统未设置您的审批流程，无法进行药品销毁处理。", "警告", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                            return;
                        }
                        #region 新建

                        List<EntityBase> children = this.popupGrid.GetEntities();

                        entity.CreateDate = DateTime.Now;
                        entity.LastModifyDate = DateTime.Now;
                        entity.CreateUserID = GlobalItem.g_CurrentUser.UserID;
                        entity.LastModifyUserID = GlobalItem.g_CurrentUser.UserID;
                        entity.DestroyStatusID = 1;
                        entity.DestroyStatus = "申请销毁";
                        entity.Save();

                        //查询出其ID
                        entity.Fetch();
                        int index = 1;
                        StringBuilder message = new StringBuilder();
                        Dictionary<int, string> selectedProducts = new Dictionary<int, string>();
                        for (int i = 0; i < this.popupGrid.PopupView.RowCount; i++)
                        {
                            object productID = this.popupGrid.PopupView.GetRowCellValue(i, "药品ID");
                            object productName = this.popupGrid.PopupView.GetRowCellValue(i, "药品名称");

                            if (productID != null && productID != DBNull.Value 
                                && productName != null && productName != DBNull.Value)
                            {
                                if (!selectedProducts.ContainsKey((int) productID))
                                {
                                    selectedProducts.Add((int) productID, productName.ToString());
                                }
                            }
                        }
                        foreach (EntityBase childEntity in children)
                        {
                            BUSProdcutDestroyDetailEntity child = childEntity as BUSProdcutDestroyDetailEntity;
                            child.DestroyID = entity.DestroyID;
                            child.Save();
                            message.AppendLine(string.Format("{0}. 药品：{1}，批号：{2}，数量：{3}", 
                                index,
                                selectedProducts[child.ProductID],
                                child.BatchNo,
                                child.Amount));
                            index++;
                        }

                        #endregion


                        if (data.Rows.Count > 0)
                        {
                            //按审批顺序排序
                            data.DefaultView.Sort = "ApprovalSort";
                            data = data.DefaultView.ToTable();

                            ATCApproveEntity approveEntity = new ATCApproveEntity();
                            approveEntity.InternalNo = "SH-" + entity.DestroyCode.Substring(2);
                            approveEntity.DocumentCode = "ProductDestroy";
                            approveEntity.BillCode = entity.DestroyCode;
                            approveEntity.ApproveTitle = string.Format("药品销毁，编号：{0}", entity.DestroyCode);
                            approveEntity.ApprovalContent = String.Format("药品销毁 {0}:{2}{1}{2} 申请审批。", entity.DestroyCode, message.ToString(), Environment.NewLine);
                            approveEntity.CreateUserID = GlobalItem.g_CurrentUser.UserID;
                            approveEntity.CreateDate = DateTime.Now;
                            approveEntity.IsApprovaled = false;
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
                                notification.FormClass = "ProductDestroy";
                                notification.IsRead = false;
                                notification.TargetID = entity.DestroyID;
                                notification.TargetCode = entity.DestroyCode;
                                notification.ApproveCode = approveCode;
                                notification.Message = string.Format("{0} 于 {1} 申请药品销毁（单号 {2}）。请您审批。", userName,
                                    DateTime.Now.ToString("yyyy-MM-dd HH:mm:ss"), entity.DestroyCode);
                                notification.OwnerUserID = approvalUserId;
                                notification.Save();
                            }
                        }
                        else
                        {
                            entity.DestroyStatusID = 2;
                            entity.DestroyStatus = "已审核";
                            entity.Update();
                        }
                    }
                    else
                    {
                        XtraMessageBox.Show("销毁编号已存在。", "警告", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
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

        private bool ValidateDestroyDate()
        {
            if (string.IsNullOrWhiteSpace(this.dteDestroyDate.Text))
            {

                XtraMessageBox.Show("请选择销毁日期和时间！", "系统提示",
                    MessageBoxButtons.OK, MessageBoxIcon.Information);
                return false;
            }
            return true;
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        /// <summary>
        /// 非文本框取值
        /// </summary>
        /// <param name="entity">实体</param>
        protected virtual void CustomGetEntity(BUSProdcutDestroyEntity entity)
        {

            if (!entity.IsNullField("DestroyDate"))
            {
                dteDestroyDate.DateTime = entity.DestroyDate;
                tmeDestroyTime.Time = entity.DestroyDate;
            }
        }

        /// <summary>
        /// 非文本框赋值
        /// </summary>
        /// <param name="entity">实体</param>
        protected virtual void CustomSetEntity(BUSProdcutDestroyEntity entity)
        {
            if (!string.IsNullOrEmpty(dteDestroyDate.Text))
            {
                entity.DestroyDate = Convert.ToDateTime(String.Format("{0:yyyy-MM-dd} {1:HH:mm:ss}", dteDestroyDate.DateTime, tmeDestroyTime.Time));
            }
        }

    }
}