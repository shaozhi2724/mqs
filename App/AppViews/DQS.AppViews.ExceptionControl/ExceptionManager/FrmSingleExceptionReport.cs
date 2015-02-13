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
                this.m_id = Convert.ToInt32(this.Tag);

                BUSExceptionReportEntity entity = new BUSExceptionReportEntity { ExceptionID = m_id.Value };
                entity.Fetch();

                this.ftPanel.SetEntity(entity);

                this.txtExceptionCode.Enabled = false;

                this.popupGrid.SetGridData(m_id.Value);

                this.CustomGetEntity(entity);
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
                dteFinderDate.DateTime = DateTime.Now;
                tmeFinderTime.Time = DateTime.Now;

                txtDealPerson.Properties.ReadOnly = true;
                txtDealSuggestion.Properties.ReadOnly = true;
                txtDealResult.Properties.ReadOnly = true;
                //layControlGroupDeal.Visibility = LayoutVisibility.Never;
            }
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

                    List<EntityBase> children = this.popupGrid.GetEntities();

                    entity.LastModifyDate = DateTime.Now;
                    entity.LastModifyUserID = GlobalItem.g_CurrentUser.UserID;
                    entity.Update();

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
                }
                else
                {
                    if (entity.IsNew())
                    {
                        #region 新建
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
            this.txtDealPerson.Properties.ReadOnly = rdgIsDeal.SelectedIndex == 0;
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
            }
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