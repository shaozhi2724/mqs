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
using System.Data.SqlClient;

namespace DQS.AppViews.WarehouseOut.WarehouseOutManager
{
    public partial class FrmSingleReview : DevExpress.XtraEditors.XtraForm
    {
        private int? m_id;

        public FrmSingleReview()
        {
            InitializeComponent();
        }

        private void FrmSingleReview_Load(object sender, EventArgs e)
        {
            this.popupGrid.InitGrid();

            if (this.Tag != null)
            {
                this.m_id = Convert.ToInt32(this.Tag);

                BUSReviewEntity entity = new BUSReviewEntity { ReviewID = m_id.Value };
                entity.Fetch();

                this.ftPanel.SetEntity(entity);

                this.txtReviewCode.Enabled = false;
                this.txtBillCode.Enabled = false;

                this.CustomGetEntity(entity);

                this.popupGrid.SetGridData(m_id.Value, true);

            }
            else
            {
                this.txtReviewCode.Text = "FH" + DateTime.Now.ToString("yyyyMMddHHmmss");
                this.txtReviewCode.Select(this.txtReviewCode.Text.Length, 0);


                if (GlobalItem.g_CurrentEmployee != null)
                {
                    this.txtReviewPerson.Text = GlobalItem.g_CurrentEmployee.EmployeeName;
                }
                else
                {
                    txtReviewPerson.Text = GlobalItem.g_CurrentUser.UserName;
                }
            }
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            try
            {
                if (!this.ftPanel.ValidateIsNullFields()) return;

                BUSReviewEntity entity = this.ftPanel.GetEntity() as BUSReviewEntity;

                this.CustomSetEntity(entity);

                if (this.m_id != null)
                {
                    #region 修改

                    List<EntityBase> children = this.popupGrid.GetEntities();

                    entity.LastModifyDate = DateTime.Now;
                    entity.LastModifyUserID = GlobalItem.g_CurrentUser.UserID;

                    //状态
                    this.SetReviewStatus(entity);
                    entity.Update();

                    //先删除
                    BUSReviewDetailEntity childToDelete = new BUSReviewDetailEntity { ReviewID = m_id.Value };
                    childToDelete.DeleteByCommonly();

                    //后加
                    foreach (EntityBase childEntity in children)
                    {
                        BUSReviewDetailEntity child = childEntity as BUSReviewDetailEntity;
                        child.ReviewID = m_id.Value;
                        child.Save();
                    }

                    //状态
                    if (entity.StatusID == 1)//复核成功后
                    {
                        //更新订单
                        BUSBillEntity bill = new BUSBillEntity { BillID = entity.SaleBillID, BillStatus = 4, BillStatusName = "已复核" };
                        bill.Update();

                        //更新库存(挪到出库单建立时)
                        //foreach (EntityBase childEntity in children)
                        //{
                        //    BUSReviewDetailEntity child = childEntity as BUSReviewDetailEntity;
                        //    UpdateStoreDetail(child);
                        //}
                    }
                    #endregion
                }
                else
                {
                    if (entity.IsNew(BUSReviewEntityFields.ReviewCode == entity.ReviewCode))
                    {
                        #region 新建

                        entity.ReviewDate = DateTime.Now;

                        List<EntityBase> children = this.popupGrid.GetEntities();

                        entity.CreateDate = DateTime.Now;
                        entity.LastModifyDate = DateTime.Now;
                        entity.CreateUserID = GlobalItem.g_CurrentUser.UserID;
                        entity.LastModifyUserID = GlobalItem.g_CurrentUser.UserID;

                        //状态
                        this.SetReviewStatus(entity);
                        entity.Save();

                        //查询出其ID
                        entity.Fetch();

                        foreach (EntityBase childEntity in children)
                        {
                            BUSReviewDetailEntity child = childEntity as BUSReviewDetailEntity;
                            child.ReviewID = entity.ReviewID;
                            child.Save();
                        }

                        //状态
                        if (entity.StatusID == 1)//复核成功后
                        {
                            //更新订单
                            BUSBillEntity bill = new BUSBillEntity { BillID = entity.SaleBillID, BillStatus = 4, BillStatusName = "已复核" };
                            bill.Update();

                            //更新库存(挪到出库单建立时)
                            //foreach (EntityBase childEntity in children)
                            //{
                            //    BUSReviewDetailEntity child = childEntity as BUSReviewDetailEntity;
                            //    UpdateStoreDetail(child);
                            //}
                        }

                        using (SqlConnection conn = new SqlConnection(GlobalItem.g_DbConnectStrings))
                        {
                            string sqlBill = string.Format("EXEC sp_UpdateStatusForOut '{0}','{1}','{2}'", entity.SaleBillCode, "已复核", GlobalItem.g_CurrentEmployee.EmployeeName);

                            try
                            {
                                conn.Open();//连接数据库
                                SqlCommand Bcommand = new SqlCommand(sqlBill, conn);
                                Bcommand.ExecuteNonQuery();
                            }
                            catch (Exception ex)
                            {
                                XtraMessageBox.Show(ex.ToString(), "系统提示", MessageBoxButtons.OK, MessageBoxIcon.Error);
                            }
                            finally
                            {
                                conn.Close();
                            }
                        }

                        #endregion
                    }
                    else
                    {
                        XtraMessageBox.Show("复核单号已存在。", "警告", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
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

        /// <summary>
        /// 非文本框取值
        /// </summary>
        /// <param name="entity">实体</param>
        protected virtual void CustomGetEntity(BUSReviewEntity entity)
        {
            if (!entity.IsNullField("SaleBillID"))
            {
                this.txtBillCode.SetMemberValue(entity.SaleBillID);
                this.txtBillTypeName.Text = (this.txtBillCode.EditData as DataRow)["状态"].ToString();
                this.txtDealerName.Text = (this.txtBillCode.EditData as DataRow)["往来单位名称"].ToString();
            }

            if (!entity.IsNullField("ReviewPerson"))
            {
                this.txtReviewPerson.Text = entity.ReviewPerson;
            }

        }

        /// <summary>
        /// 非文本框赋值
        /// </summary>
        /// <param name="entity">实体</param>
        protected virtual void CustomSetEntity(BUSReviewEntity entity)
        {
            if (this.txtBillCode.SelectedValue != null)
            {
                entity.SaleBillID = Convert.ToInt32(this.txtBillCode.SelectedValue);
                entity.SaleBillCode = this.txtBillCode.Text.Trim();
            }

            if (this.txtReviewPerson.Text.Trim() != "")
            {
                entity.ReviewPerson = this.txtReviewPerson.Text.Trim();
                entity.ReviewPersonSpell = GlobalMethod.GetAlphabetic(entity.ReviewPerson);
            }
        }

        private void txtBillCode_PopupClosing(object sender, EventArgs e)
        {
            if (this.txtBillCode.EditData != null)
            {
                this.txtBillTypeName.Text = (this.txtBillCode.EditData as DataRow)["订单类型"].ToString();
                this.txtDealerName.Text = (this.txtBillCode.EditData as DataRow)["往来单位名称"].ToString();
                this.txtRemark.Focus();

                object id = (this.txtBillCode.EditData as DataRow)["订单ID"].ToString();

                if (id != null)
                {
                    //根据订单设置表格数据
                    this.popupGrid.SetGridData("vw_AllStockOutDeatil", "订单ID", id, true);
                    txtReviewCode.Text = txtBillCode.Text;
                }
            }
        }

        private void btnOneKeyFinish_Click(object sender, EventArgs e)
        {

            for (int i = 0; i < this.popupGrid.PopupView.RowCount; i++)
            {
                object amount = this.popupGrid.PopupView.GetRowCellValue(i, "出库数量");
                if (amount != null)
                {
                    if (!string.IsNullOrEmpty(amount.ToString()))
                    {
                        this.popupGrid.PopupView.SetRowCellValue(i, "复核数量", amount); ;
                    }
                }
            }
        }

        //要把更新库存挪到出库单建立的时候
        //public static void UpdateStoreDetail(BUSReviewDetailEntity reviewDetail)
        //{
        //    BUSStoreDetailEntity storeDetail = new BUSStoreDetailEntity { ProductID = reviewDetail.ProductID, BatchNo = reviewDetail.BatchNo };

        //    //更新库存
        //    storeDetail.Fetch();
        //    storeDetail.LastStoreID = reviewDetail.ReviewID;
        //    storeDetail.LastModifyDate = DateTime.Now;
        //    storeDetail.LastModifyUserID = GlobalItem.g_CurrentUser.UserID;
        //    if (storeDetail.IsNullField("Amount"))
        //    {
        //        throw new Exception(String.Format("ID号为{0}的产品没有批号为{1}库存信息。", reviewDetail.ProductID, reviewDetail.BatchNo));
        //    }
        //    storeDetail.Amount = storeDetail.Amount - reviewDetail.Amount;
        //    if (storeDetail.Amount < 0)
        //    {
        //        throw new Exception(String.Format("ID号为{0}的产品库存不足。", reviewDetail.ProductID));
        //    }
        //    storeDetail.Update();

        //}

        private void SetReviewStatus(BUSReviewEntity entity)
        {
            entity.StatusID = 1;
            entity.StatusName = "复核成功";
            entity.StatusSpell = "hfcg";
            for (int i = 0; i < this.popupGrid.PopupView.RowCount; i++)
            {
                object amount = this.popupGrid.PopupView.GetRowCellValue(i, "出库数量");
                object receiveAmount = this.popupGrid.PopupView.GetRowCellValue(i, "复核数量");
                if (amount.ToString().Trim() != receiveAmount.ToString().Trim())
                {
                    entity.StatusID = 2;
                    entity.StatusName = "复核失败";
                    entity.StatusSpell = "hfsb";
                    break;
                }
            }
        }
    }
}