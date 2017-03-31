using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using DevExpress.XtraEditors;
using DevExpress.XtraLayout.Utils;
using DQS.Module.Entities;
using ORMSCore;
using DQS.Common;

namespace DQS.AppViews.ExceptionControl.ExceptionManager
{
    public partial class FrmSingleExceptionReport : DevExpress.XtraEditors.XtraForm
    {
        private int? m_id;

        public FrmSingleExceptionReport()
        {
            InitializeComponent();
        }

        private void FrmSingleExceptionReport_Load(object sender, EventArgs e)
        {
            this.popupGrid.InitGrid();
            this.popupGrid.PopupView.KeyDown += PopupView_KeyDown;

            if (this.Tag != null)
            {
                this.cboResult.Properties.Items.Add("无");
                this.cboResult.Properties.Items.Add("解锁");
                this.cboResult.Properties.Items.Add("放入不合格品区");
                this.cboResult.SelectedItem = "解锁";

                popupGrid.PopupView.Columns["上报数量"].OptionsColumn.AllowEdit = false;

                this.m_id = Convert.ToInt32(this.Tag);

                BUSExceptionReportEntity entity = new BUSExceptionReportEntity { ExceptionID = m_id.Value };
                entity.Fetch();

                //如果已自动生成不合格品处理，保存按钮为不可用
                if (!entity.IsNullField("Reservation1"))
                {
                    btnSave.Enabled = false;
                }
                //如果已自动生成不合格品处理，保存按钮为不可用
                if (!entity.IsNullField("Reservation2"))
                {
                    this.cboResult.SelectedItem = entity.Reservation2;
                }

                this.ftPanel.SetEntity(entity);

                this.txtExceptionCode.Enabled = false;

                this.popupGrid.SetGridData(m_id.Value);

                this.CustomGetEntity(entity);
                txtDealPerson.Text = GlobalItem.g_CurrentEmployee != null ? GlobalItem.g_CurrentEmployee.EmployeeName : GlobalItem.g_CurrentUser.UserName;
                txtDealPerson.Properties.ReadOnly = false;
                txtDealSuggestion.Properties.ReadOnly = false;
                txtDealResult.Properties.ReadOnly = false;
                //layControlGroupDeal.Visibility = LayoutVisibility.Always;
            }
            else
            {
                this.txtExceptionCode.Text = "YCSB" + DateTime.Now.ToString("yyyyMMddHHmmss");
                this.txtExceptionCode.Select(this.txtExceptionCode.Text.Length, 0);
                if (GlobalItem.g_CurrentEmployee != null)
                {
                    txtFinder.Text = GlobalItem.g_CurrentEmployee.EmployeeName;
                }
                else
                {
                    txtFinder.Text = GlobalItem.g_CurrentUser.UserName;
                }
                rdgIsDeal.Enabled = false;
                dteFinderDate.DateTime = DateTime.Now;
                tmeFinderTime.Time = DateTime.Now;

                txtDealPerson.Properties.ReadOnly = true;
                txtDealSuggestion.Properties.ReadOnly = true;
                txtDealResult.Properties.ReadOnly = true;
                //layControlGroupDeal.Visibility = LayoutVisibility.Never;
            }
        }

        private bool ValidateResultAmount()
        {
            int rowCount = this.popupGrid.PopupView.RowCount;
            for (int i = 0; i < rowCount; i++)
            {
                object lockAmout = this.popupGrid.PopupView.GetRowCellValue(i, "上报数量");
                if (lockAmout != null && lockAmout != DBNull.Value)
                {
                    object Amount = this.popupGrid.PopupView.GetRowCellValue(i, "确认数量");
                    if (Amount != null && Amount != DBNull.Value)
                    {
                        if (Convert.ToInt32(Amount) > Convert.ToInt32(lockAmout))
                        {
                            XtraMessageBox.Show(String.Format("表格中第{0}行产品的确认数量不能大于上报数量。", (i + 1)), "系统提示", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            return false;
                        }
                    }
                }
            }
            return true;
        }

        private bool ValidateAmount()
        {
            int rowCount = this.popupGrid.PopupView.RowCount;
            for (int i = 0; i < rowCount; i++)
            {
                object lockAmout = this.popupGrid.PopupView.GetRowCellValue(i, "锁定数量");
                if (lockAmout != null && lockAmout != DBNull.Value)
                {
                    object Amount = this.popupGrid.PopupView.GetRowCellValue(i, "上报数量");
                    if (Amount != null && Amount != DBNull.Value)
                    {
                        if (Convert.ToInt32(Amount) > Convert.ToInt32(lockAmout))
                        {
                            XtraMessageBox.Show(String.Format("表格中第{0}行产品的上报数量不能大于锁定数量。", (i + 1)), "系统提示", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            return false;
                        }
                    }
                }
            }
            return true;
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            try
            {
                if (!this.ftPanel.ValidateIsNullFields()) return;

                BUSExceptionReportEntity entity = this.ftPanel.GetEntity() as BUSExceptionReportEntity;

                this.CustomSetEntity(entity);

                if (this.m_id != null)
                {
                    #region 修改

                    //确认数量不能大于上报数量
                    if (!ValidateResultAmount()) return;

                    List<EntityBase> children = this.popupGrid.GetEntities();

                    entity.LastModifyDate = DateTime.Now;
                    entity.LastModifyUserID = GlobalItem.g_CurrentUser.UserID;
                    entity.Reservation2 = cboResult.SelectedItem.ToString();
                    entity.Update();

                    entity.Fetch();

                    //先删除
                    BUSExceptionReportDetailEntity childToDelete = new BUSExceptionReportDetailEntity { ExceptionID = m_id.Value };
                    childToDelete.DeleteByCommonly();

                    //后加
                    foreach (EntityBase childEntity in children)
                    {
                        BUSExceptionReportDetailEntity child = childEntity as BUSExceptionReportDetailEntity;
                        child.ExceptionID = m_id.Value;
                        child.Save();
                    }

                    #endregion

                    if (DQS.Controls.Properties.Settings.Default.IsExceptionAutoDeal)
                    {
                        if (cboResult.SelectedItem.ToString() == "解锁")
                        {
                            foreach (EntityBase item in children)
                            {
                                BUSExceptionReportDetailEntity child = item as BUSExceptionReportDetailEntity;
                                EntityCollection<BUSProductLockedEntity> pl = new EntityCollection<BUSProductLockedEntity>();
                                pl.Fetch(BUSProductLockedEntityFields.InStoreID == child.Reservation1
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
                                        entitypl.DealResult = entity.DealResult;
                                        entitypl.UnLockedDate = DateTime.Now;
                                        entitypl.Update();
                                    }
                                }
                            }
                        }
                        else if (cboResult.SelectedItem.ToString() == "放入不合格品区")
                        {
                            EntityCollection<ATCUserPageEntity> userPages = new EntityCollection<ATCUserPageEntity>();
                            PredicateExpression pe = new PredicateExpression();
                            pe.Add(ATCUserPageEntityFields.UserID == GlobalItem.g_CurrentUser.UserID);
                            pe.Add(ATCUserPageEntityFields.DocumentCode == "ProductUnqualified");
                            DataTable data = userPages.FetchTable(pe);

                            if (data.Rows.Count <= 0)
                            {
                                XtraMessageBox.Show("系统未设置您的审批流程，无法进行不合格产品处理。", "警告", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                                return;
                            }

                            string bhgCode = "BHG" + DateTime.Now.ToString("yyyyMMddHHmmss");
                            string bhgCause = txtExceptionContent.Text;
                            string bhgResult = txtDealResult.Text;

                            #region 新建不合格处理记录

                            int index = 1;
                            StringBuilder message = new StringBuilder();
                            Dictionary<int, string> selectedProducts = new Dictionary<int, string>();
                            for (int i = 0; i < this.popupGrid.PopupView.RowCount; i++)
                            {
                                object productID = this.popupGrid.PopupView.GetRowCellValue(i, "产品ID");
                                object productName = this.popupGrid.PopupView.GetRowCellValue(i, "产品名称");

                                if (productID != null && productID != DBNull.Value && productName != null && productName != DBNull.Value)
                                {
                                    selectedProducts.Add((int)productID, productName.ToString());
                                }
                            }

                            BUSProductUnqualifiedEntity prounquali = new BUSProductUnqualifiedEntity();
                            prounquali.UnqualifiedCode = bhgCode;
                            prounquali.UnqualifiedCause = bhgCause;
                            prounquali.DealSuggestion = bhgResult;
                            prounquali.Blame = txtFinder.Text;
                            prounquali.CreateDate = DateTime.Now;
                            prounquali.LastModifyDate = DateTime.Now;
                            prounquali.CreateUserID = GlobalItem.g_CurrentUser.UserID;
                            prounquali.LastModifyUserID = GlobalItem.g_CurrentUser.UserID;
                            prounquali.Reservation1 = "自动生成不合格品记录";
                            prounquali.Reservation2 = Convert.ToString(entity.ExceptionID);
                            prounquali.IsCutAmount = true;
                            prounquali.UnqualifiedStatusID = 1;
                            prounquali.UnqualifiedStatus = "未处理";
                            prounquali.Save();
                            prounquali.Fetch();


                            EntityCollection<BUSExceptionReportDetailEntity> pl = new EntityCollection<BUSExceptionReportDetailEntity>();
                            pl.Fetch(BUSExceptionReportDetailEntityFields.ExceptionID == entity.ExceptionID);
                            if (pl.Count > 0)
                            {
                                foreach (var plitem in pl)
                                {
                                    BUSExceptionReportDetailEntity prd = plitem as BUSExceptionReportDetailEntity;
                                    BUSProductUnqualifiedDetailEntity productunqualidetail = new BUSProductUnqualifiedDetailEntity();
                                    productunqualidetail.UnqualifiedID = prounquali.UnqualifiedID;
                                    productunqualidetail.ProductID = prd.ProductID;
                                    productunqualidetail.BatchNo = prd.BatchNo;
                                    productunqualidetail.ProduceDate = prd.ProduceDate;
                                    productunqualidetail.ValidateDate = prd.ValidateDate;
                                    productunqualidetail.Amount = prd.ResultAmount;
                                    productunqualidetail.InStoreID = Convert.ToInt32(prd.Reservation1);
                                    productunqualidetail.DetailCause = prd.DetailContent;
                                    productunqualidetail.Save();


                                    message.AppendLine(string.Format("{0}. 产品：{1}，批号：{2}，数量：{3}",
                                        index,
                                        selectedProducts[prd.ProductID],
                                        prd.BatchNo,
                                        prd.Amount));
                                    index++;
                                }
                            }

                            if (data.Rows.Count > 0)
                            {
                                //按审批顺序排序
                                data.DefaultView.Sort = "ApprovalSort";
                                data = data.DefaultView.ToTable();

                                ATCApproveEntity approveEntity = new ATCApproveEntity();
                                approveEntity.InternalNo = "SH-" + prounquali.UnqualifiedCode.Substring(2);
                                approveEntity.DocumentCode = "ProductUnqualified";
                                approveEntity.BillCode = prounquali.UnqualifiedCode;
                                approveEntity.ApproveTitle = string.Format("不合格产品处理，编号：{0}", prounquali.UnqualifiedCode);
                                approveEntity.ApprovalContent = String.Format("不合格产品处理 {0}:{2}{1}{2} 申请审批。", prounquali.UnqualifiedCode, message.ToString(), Environment.NewLine);
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
                                    notification.TargetID = prounquali.UnqualifiedID;
                                    notification.TargetCode = prounquali.UnqualifiedCode;
                                    notification.ApproveCode = approveCode;
                                    notification.Message = string.Format("{0} 于 {1} 申请处理不合格产品（单号 {2}）。请您审批。", userName,
                                        DateTime.Now.ToString("yyyy-MM-dd HH:mm:ss"), prounquali.UnqualifiedCode);
                                    notification.OwnerUserID = approvalUserId;
                                    notification.Save();
                                }
                            }
                            else
                            {
                                prounquali.UnqualifiedStatusID = 2;
                                prounquali.UnqualifiedStatus = "已审核";
                                prounquali.Update();
                            }

                            #endregion
                            entity.Reservation1 = "自动生成不合格品记录";
                            entity.Update();
                        }
                    }
                }
                else
                {
                    if (entity.IsNew())
                    {
                        #region 新建
                        //验证上报数量不能大于锁定数量
                        if (!ValidateAmount()) return;

                        List<EntityBase> children = this.popupGrid.GetEntities();

                        entity.CreateDate = DateTime.Now;
                        entity.LastModifyDate = DateTime.Now;
                        entity.CreateUserID = GlobalItem.g_CurrentUser.UserID;
                        entity.LastModifyUserID = GlobalItem.g_CurrentUser.UserID;
                        entity.Save();

                        //查询出其ID
                        entity.Fetch();

                        foreach (EntityBase childEntity in children)
                        {
                            BUSExceptionReportDetailEntity child = childEntity as BUSExceptionReportDetailEntity;
                            child.ExceptionID = entity.ExceptionID;
                            child.Save();
                        }

                        #endregion
                    }
                    else
                    {
                        XtraMessageBox.Show("异常编号已存在。", "警告", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
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

        private void rdgIsDeal_SelectedIndexChanged(object sender, EventArgs e)
        {
            //this.dteDealDate.Properties.ReadOnly = rdgIsDeal.SelectedIndex == 0;
            //this.tmeDealTime.Properties.ReadOnly = rdgIsDeal.SelectedIndex == 0;
            //this.txtDealPerson.Properties.ReadOnly = rdgIsDeal.SelectedIndex == 0;
            this.txtDealResult.Properties.ReadOnly = rdgIsDeal.SelectedIndex == 0;
            this.txtDealSuggestion.Properties.ReadOnly = rdgIsDeal.SelectedIndex == 0;

            if (rdgIsDeal.SelectedIndex == 0)
            {
                this.dteDealDate.Text = "";
                this.tmeDealTime.Time = new DateTime();
            }
            else
            {
                this.dteDealDate.DateTime = DateTime.Now;
                this.tmeDealTime.Time = DateTime.Now;

                if (GlobalItem.g_CurrentEmployee != null)
                {
                    txtDealPerson.Text = GlobalItem.g_CurrentEmployee.EmployeeName;
                }
                else
                {
                    txtDealPerson.Text = GlobalItem.g_CurrentUser.UserName;
                }
            }
        }

        private void popupGrid_PopupClosed(object sender, DQS.Controls.CommonCode.PopupFormClosedArgs e)
        {
            string fieldName = "产品ID";
            string fieldName2 = "批号";
            for (int i = 0; i < this.popupGrid.PopupView.RowCount; i++)
            {
                object fieldValue = this.popupGrid.PopupView.GetRowCellValue(i, "产品ID");
                object fieldValue2 = this.popupGrid.PopupView.GetRowCellValue(i, fieldName2);
                if (fieldValue != null && fieldValue != DBNull.Value)
                {
                    if (e.PopupRow[fieldName] != null && e.PopupRow[fieldName] != DBNull.Value)
                    {
                        if (fieldValue.ToString().Trim() == e.PopupRow[fieldName].ToString().Trim() && fieldValue2.ToString().Trim() == e.PopupRow[fieldName2].ToString().Trim())
                        {
                            XtraMessageBox.Show("该批号产品已存在。", "系统提示", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
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

        /// <summary>
        /// 非文本框取值
        /// </summary>
        /// <param name="entity">实体</param>
        protected virtual void CustomGetEntity(BUSExceptionReportEntity entity)
        {
            if (!entity.IsNullField("IsDeal"))
            {
                this.rdgIsDeal.SelectedIndex = entity.IsDeal ? 1 : 0;
            }

            if (!entity.IsNullField("DealDate"))
            {
                dteDealDate.DateTime = entity.DealDate;
                tmeDealTime.Time = entity.DealDate;
            }

            if (!entity.IsNullField("FinderDate"))
            {
                dteFinderDate.DateTime = entity.FinderDate;
                tmeFinderTime.Time = entity.FinderDate;
            }
        }

        /// <summary>
        /// 非文本框赋值
        /// </summary>
        /// <param name="entity">实体</param>
        protected virtual void CustomSetEntity(BUSExceptionReportEntity entity)
        {
            if (!string.IsNullOrEmpty(dteFinderDate.Text))
            {
                entity.FinderDate = Convert.ToDateTime(String.Format("{0:yyyy-MM-dd} {1:HH:mm:ss}", dteFinderDate.DateTime, tmeFinderTime.Time));
            }

            if (rdgIsDeal.SelectedIndex == 1)
            {
                entity.IsDeal = true;
                if (!string.IsNullOrEmpty(dteDealDate.Text))
                {
                    entity.DealDate = Convert.ToDateTime(String.Format("{0:yyyy-MM-dd} {1:HH:mm:ss}", dteDealDate.DateTime, tmeDealTime.Time));
                }

                entity.ExceptionStatusID = 2;
                entity.ExceptionStatus = "已处理";
            }
            else
            {
                entity.IsDeal = false;

                entity.ExceptionStatusID = 1;
                entity.ExceptionStatus = "未处理";
            }
        }
    }
}