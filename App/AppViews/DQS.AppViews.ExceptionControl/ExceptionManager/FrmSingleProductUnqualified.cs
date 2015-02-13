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
    public partial class FrmSingleProductUnqualified : DevExpress.XtraEditors.XtraForm
    {
        private int? m_id;

        public FrmSingleProductUnqualified()
        {
            InitializeComponent();
        }

        private void FrmSingleProductUnqualified_Load(object sender, EventArgs e)
        {
            this.popupGrid.InitGrid();
            this.popupGrid.PopupView.KeyDown += PopupView_KeyDown;

            if (this.Tag != null)
            {
                this.m_id = Convert.ToInt32(this.Tag);

                BUSProductUnqualifiedEntity entity = new BUSProductUnqualifiedEntity { UnqualifiedID = m_id.Value };
                entity.Fetch();

                this.ftPanel.SetEntity(entity);

                this.txtUnqualifiedCode.Enabled = false;

                this.popupGrid.SetGridData(m_id.Value);

                if (!entity.IsNullField("IsCutAmount"))
                {
                    this.rdgIsCutAmount.SelectedIndex = entity.IsCutAmount ? 1 : 0;
                    this.rdgIsCutAmount.Enabled = !entity.IsCutAmount;
                }
                if (entity.UnqualifiedStatusID != 1)
                {
                    btnSave.Enabled = false;
                }
                EntityCollection<ATCApproveEntity> approveEntities = new EntityCollection<ATCApproveEntity>();
                PredicateExpression pe = new PredicateExpression();
                pe.Add(ATCApproveEntityFields.DocumentCode == "ProductUnqualified");
                pe.Add(ATCApproveEntityFields.BillCode == entity.UnqualifiedCode);
                pe.Add(ATCApproveEntityFields.IsApprovaled == 1);
                approveEntities.Fetch(pe);
                if (approveEntities.Count > 0)
                {
                    btnSave.Enabled = false;
                }
            }
            else
            {
                this.txtUnqualifiedCode.Text = "BHG" + DateTime.Now.ToString("yyyyMMddHHmmss");
                this.txtUnqualifiedCode.Select(this.txtUnqualifiedCode.Text.Length, 0);


                if (GlobalItem.g_CurrentEmployee != null)
                {
                    txtBlame.Text = GlobalItem.g_CurrentEmployee.EmployeeName;
                }
                else
                {
                    txtBlame.Text = GlobalItem.g_CurrentUser.UserName;
                }
            }
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            try
            {
                if (!this.ftPanel.ValidateIsNullFields()) return;
                if (!ValidateAmount()) return;
                BUSProductUnqualifiedEntity entity = this.ftPanel.GetEntity() as BUSProductUnqualifiedEntity;

                entity.IsCutAmount = Convert.ToBoolean(this.rdgIsCutAmount.SelectedIndex);
                /*if (this.rdgIsCutAmount.Enabled)
                {
                    if (entity.IsCutAmount)
                    {
                        entity.UnqualifiedStatusID = 2;
                        entity.UnqualifiedStatus = "已处理";
                    }
                    else
                    {
                        entity.UnqualifiedStatusID = 1;
                        entity.UnqualifiedStatus = "未处理";
                    }
                }*/
                if (this.m_id != null)
                {
                    #region 修改

                    List<EntityBase> children = this.popupGrid.GetEntities();

                    entity.LastModifyDate = DateTime.Now;
                    entity.LastModifyUserID = GlobalItem.g_CurrentUser.UserID;
                    entity.Update();

                    //先删除
                    BUSProductUnqualifiedDetailEntity childToDelete = new BUSProductUnqualifiedDetailEntity { UnqualifiedID = m_id.Value };
                    childToDelete.DeleteByCommonly();

                    //后加
                    foreach (EntityBase childEntity in children)
                    {
                        BUSProductUnqualifiedDetailEntity child = childEntity as BUSProductUnqualifiedDetailEntity;
                        child.UnqualifiedID = m_id.Value;
                        child.Save();

                        //削减库存只能减一次
                        //if (this.rdgIsCutAmount.Enabled)
                        //{
                        //    if (entity.IsCutAmount)
                        //    {
                        //        UpdateStoreDetail(child);
                        //    }
                        //}
                    }

                    #endregion
                }
                else
                {
                    if (entity.IsNew())
                    {
                        #region 新建

                        EntityCollection<ATCUserPageEntity> userPages = new EntityCollection<ATCUserPageEntity>();
                        PredicateExpression pe = new PredicateExpression();
                        pe.Add(ATCUserPageEntityFields.UserID == GlobalItem.g_CurrentUser.UserID);
                        pe.Add(ATCUserPageEntityFields.DocumentCode == "ProductUnqualified");
                        DataTable data = userPages.FetchTable(pe);

                        if (data.Rows.Count <= 0)
                        {
                            XtraMessageBox.Show("系统未设置您的审批流程，无法进行不合格药品处理。", "警告", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                            return;
                        }
                        List<EntityBase> children = this.popupGrid.GetEntities();

                        entity.CreateDate = DateTime.Now;
                        entity.LastModifyDate = DateTime.Now;
                        entity.CreateUserID = GlobalItem.g_CurrentUser.UserID;
                        entity.LastModifyUserID = GlobalItem.g_CurrentUser.UserID;

                        entity.UnqualifiedStatusID = 1;
                        entity.UnqualifiedStatus = "未处理";
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

                            if (productID != null && productID != DBNull.Value && productName != null && productName != DBNull.Value)
                            {
                                selectedProducts.Add((int)productID, productName.ToString());
                            }
                        }
                        foreach (EntityBase childEntity in children)
                        {
                            BUSProductUnqualifiedDetailEntity child = childEntity as BUSProductUnqualifiedDetailEntity;
                            child.UnqualifiedID = entity.UnqualifiedID;
                            child.Save();

                            message.AppendLine(string.Format("{0}. 药品：{1}，批号：{2}，数量：{3}",
                                index,
                                selectedProducts[child.ProductID],
                                child.BatchNo,
                                child.Amount));
                            index++;
                        }
                        if (data.Rows.Count > 0)
                        {
                            //按审批顺序排序
                            data.DefaultView.Sort = "ApprovalSort";
                            data = data.DefaultView.ToTable();

                            ATCApproveEntity approveEntity = new ATCApproveEntity();
                            approveEntity.InternalNo = "SH-" + entity.UnqualifiedCode.Substring(2);
                            approveEntity.DocumentCode = "ProductUnqualified";
                            approveEntity.BillCode = entity.UnqualifiedCode;
                            approveEntity.ApproveTitle = string.Format("不合格药品处理，编号：{0}", entity.UnqualifiedCode);
                            approveEntity.ApprovalContent = String.Format("不合格药品处理 {0}:{2}{1}{2} 申请审批。", entity.UnqualifiedCode, message.ToString(), Environment.NewLine);
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
                                notification.FormClass = "ProductUnqualified";
                                notification.IsRead = false;
                                notification.TargetID = entity.UnqualifiedID;
                                notification.TargetCode = entity.UnqualifiedCode;
                                notification.ApproveCode = approveCode;
                                notification.Message = string.Format("{0} 于 {1} 申请处理不合格药品（单号 {2}）。请您审批。", userName,
                                    DateTime.Now.ToString("yyyy-MM-dd HH:mm:ss"), entity.UnqualifiedCode);
                                notification.OwnerUserID = approvalUserId;
                                notification.Save();
                            }
                        }
                        else
                        {
                            entity.UnqualifiedStatusID = 2;
                            entity.UnqualifiedStatus = "已审核";
                            entity.Update();
                        }
                        #endregion
                    }
                    else
                    {
                        XtraMessageBox.Show("不合格记录编号已存在。", "警告", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
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

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void popupGrid_PopupClosed(object sender, DQS.Controls.CommonCode.PopupFormClosedArgs e)
        {
            string fieldName = "药品ID";
            string fieldName2 = "批号";
            for (int i = 0; i < this.popupGrid.PopupView.RowCount; i++)
            {
                object fieldValue = this.popupGrid.PopupView.GetRowCellValue(i, "药品ID");
                object fieldValue2 = this.popupGrid.PopupView.GetRowCellValue(i, fieldName2);
                if (fieldValue != null && fieldValue != DBNull.Value)
                {
                    if (e.PopupRow[fieldName] != null && e.PopupRow[fieldName] != DBNull.Value)
                    {
                        if (fieldValue.ToString().Trim() == e.PopupRow[fieldName].ToString().Trim() && fieldValue2.ToString().Trim() == e.PopupRow[fieldName2].ToString().Trim())
                        {
                            XtraMessageBox.Show("该批号药品已存在。", "系统提示", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                            this.popupGrid.PopupView.FocusedRowHandle = i;
                            e.Cancel = true;
                        }
                    }
                }
            }
        }

        private void PopupView_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Delete)
            {
                DialogResult dr = XtraMessageBox.Show("确定要删除此行数据吗？", "提示", MessageBoxButtons.OKCancel, MessageBoxIcon.Question);
                if (dr == DialogResult.OK)
                {
                    this.popupGrid.ClearGrid(this.popupGrid.PopupView.FocusedRowHandle);
                }
            }
        }

        public static void UpdateStoreDetail(BUSProductUnqualifiedDetailEntity unqualifiedDetail)
        {
            BUSStoreDetailEntity storeDetail = new BUSStoreDetailEntity { ProductID = unqualifiedDetail.ProductID, BatchNo = unqualifiedDetail.BatchNo };

            //更新库存
            storeDetail.Fetch();
            storeDetail.LastModifyDate = DateTime.Now;
            storeDetail.LastModifyUserID = GlobalItem.g_CurrentUser.UserID;
            if (storeDetail.IsNullField("Amount"))
            {
                throw new Exception(String.Format("ID号为{0}的产品没有批号为{1}库存信息。", unqualifiedDetail.ProductID, unqualifiedDetail.BatchNo));
            }
            storeDetail.Amount = storeDetail.Amount - unqualifiedDetail.Amount;
            if (storeDetail.Amount < 0)
            {
                throw new Exception(String.Format("ID号为{0}的产品库存不足。", unqualifiedDetail.ProductID));
            }
            storeDetail.Update();

            BUSUnqualifiedStoreDetailEntity unqualifiedStoreDetail = new BUSUnqualifiedStoreDetailEntity { ProductID = unqualifiedDetail.ProductID, BatchNo = unqualifiedDetail.BatchNo };

            if (unqualifiedStoreDetail.IsNew(BUSUnqualifiedStoreDetailEntityFields.ProductID == unqualifiedDetail.ProductID & BUSUnqualifiedStoreDetailEntityFields.BatchNo == unqualifiedDetail.BatchNo))
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

        //验证出库总数量必须等于订单数量
        private bool ValidateAmount()
        {
            for (int i = 0; i < this.popupGrid.PopupView.RowCount; i++)
            {
                object qAmount = this.popupGrid.PopupView.GetRowCellValue(i, "库存数量");
                object amount = this.popupGrid.PopupView.GetRowCellValue(i, "数量");

                if (qAmount != null && qAmount != DBNull.Value && amount != null && amount != DBNull.Value)
                {
                    if ((int)amount == 0)
                    {
                        XtraMessageBox.Show(String.Format("第{0}行数量必须大于零！", (i + 1)), "提示", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                        return false;
                    }
                    if ((int)qAmount < (int)amount)
                    {
                        XtraMessageBox.Show(String.Format("第{0}行数量必须小于或等于库存数量！", (i + 1)), "提示", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                        return false;
                    }
                }
            }

            return true;
        }
    }
}