using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Windows.Forms;
using DevExpress.Utils;
using DevExpress.XtraEditors;
using DevExpress.XtraGrid.Views.Grid;
using DQS.Module.Entities;
using DQS.Common;
using ORMSCore;
using DQS.Module.Views;
using DevExpress.XtraLayout.Utils;

namespace DQS.AppViews.Operation.PriceManager
{
    public partial class FrmSinglePurchasePrice : DevExpress.XtraEditors.XtraForm
    {
        private int? m_id;

        public FrmSinglePurchasePrice()
        {
            InitializeComponent();
        }

        private void FrmSinglePurchasePrice_Load(object sender, EventArgs e)
        {
            this.popupGrid.InitGrid();
            this.popupGrid.PopupView.OptionsBehavior.Editable = false;
            this.popupGrid.PopupView.OptionsSelection.EnableAppearanceFocusedRow = true;
            this.popupGrid.PopupView.OptionsSelection.EnableAppearanceFocusedCell = false;
            this.popupGrid.PopupView.OptionsSelection.InvertSelection = false;
            this.popupGrid.PopupView.FocusRectStyle = DrawFocusRectStyle.RowFocus;
            this.popupGrid.PopupView.Appearance.FocusedRow.BackColor = SystemColors.Highlight;
            this.popupGrid.PopupView.Appearance.FocusedRow.ForeColor = SystemColors.HighlightText;
            if (this.Tag != null)
            {
                this.m_id = Convert.ToInt32(this.Tag);

                BFIPriceListEntity entity = new BFIPriceListEntity
                {
                    PriceListID = m_id.Value
                };
                entity.Fetch();

                this.ftPanel.SetEntity(entity);
                if(entity.PriceListName == "默认采购价格表" || entity.PriceListName == "默认销售价格表")
                {
                    this.txtPriceListName.Enabled = false;
                }
                this.CustomGetEntity(entity);

                this.popupGrid.SetGridData(m_id.Value);
            }
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            try
            {
                if (!this.ftPanel.ValidateIsNullFields()) return;

                BFIPriceListEntity entity = this.ftPanel.GetEntity() as BFIPriceListEntity;

                

                if (this.m_id != null)
                {
                    #region 修改

                    entity = new BFIPriceListEntity {PriceListID = m_id.Value};
                    entity.Fetch();
                    this.CustomSetEntity(entity);
                    EntityCollection<BFIPriceListEntity> priceLists = new EntityCollection<BFIPriceListEntity>();
                    priceLists.Fetch(BFIPriceListEntityFields.PriceListType == "采购价格表" &
                                        BFIPriceListEntityFields.PriceListName == txtPriceListName.Text.Trim()
                                        & BFIPriceListEntityFields.PriceListID != m_id.Value);
                    if(priceLists.Count > 0)
                    {
                        XtraMessageBox.Show("价格表已存在。", "警告", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                        return;
                    }

                    entity.LastModifyDate = DateTime.Now;
                    entity.LastModifyUserID = GlobalItem.g_CurrentUser.UserID;
                    entity.Update();

                    #endregion
                }
                else
                {
                    #region 新建
                    this.CustomSetEntity(entity);
                    EntityCollection<BFIPriceListEntity> priceLists = new EntityCollection<BFIPriceListEntity>();
                    priceLists.Fetch(BFIPriceListEntityFields.PriceListType == "采购价格表" &
                                        BFIPriceListEntityFields.PriceListName == txtPriceListName.Text.Trim());
                    if(priceLists.Count > 0)
                    {
                        XtraMessageBox.Show("价格表已存在。", "警告", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                        return;
                    }

                    entity.CreateDate = DateTime.Now;
                    entity.LastModifyDate = DateTime.Now;
                    entity.CreateUserID = GlobalItem.g_CurrentUser.UserID;
                    entity.LastModifyUserID = GlobalItem.g_CurrentUser.UserID;
                    entity.Save();

                    #endregion
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
        protected virtual void CustomGetEntity(BFIPriceListEntity entity)
        {
            if (!entity.IsNullField("Active"))
            {
                this.txtActive.Checked = entity.Active;
            }
            else
            {
                this.txtActive.Checked = false;
            }
        }

        /// <summary>
        /// 非文本框赋值
        /// </summary>
        /// <param name="entity">实体</param>
        protected virtual void CustomSetEntity(BFIPriceListEntity entity)
        {
            entity.PriceListType = "采购价格表";
            entity.PriceListName = txtPriceListName.Text.Trim();
            entity.Active = this.txtActive.Checked;
        }

        private void btnAdd_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            SaveAndOpenPriceVersionForm();
        }

        private void SaveAndOpenPriceVersionForm()
        {
            if (!this.ftPanel.ValidateIsNullFields())
                return;

            BFIPriceListEntity entity = this.ftPanel.GetEntity() as BFIPriceListEntity;

            this.CustomSetEntity(entity);

            if (!m_id.HasValue)
            {
                EntityCollection<BFIPriceListEntity> priceLists = new EntityCollection<BFIPriceListEntity>();
                priceLists.Fetch(BFIPriceListEntityFields.PriceListType == "采购价格表" &
                                 BFIPriceListEntityFields.PriceListName == txtPriceListName.Text.Trim());
                if (priceLists.Count > 0)
                {
                    XtraMessageBox.Show("价格表已存在。", "警告", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                    return;
                }


                entity.CreateDate = DateTime.Now;
                entity.LastModifyDate = DateTime.Now;
                entity.CreateUserID = GlobalItem.g_CurrentUser.UserID;
                entity.LastModifyUserID = GlobalItem.g_CurrentUser.UserID;
                entity.Save();

                //查询出其ID
                priceLists.Fetch(BFIPriceListEntityFields.PriceListType == "采购价格表" &
                                 BFIPriceListEntityFields.PriceListName == entity.PriceListName);
                entity = priceLists[0] as BFIPriceListEntity;
                m_id = entity.PriceListID;
            }
            else
            {
                EntityCollection<BFIPriceListEntity> priceLists = new EntityCollection<BFIPriceListEntity>();
                priceLists.Fetch(BFIPriceListEntityFields.PriceListType == "采购价格表" &
                                 BFIPriceListEntityFields.PriceListName == txtPriceListName.Text.Trim() &
                                 BFIPriceListEntityFields.PriceListID != m_id.Value);
                if (priceLists.Count > 0)
                {
                    XtraMessageBox.Show("价格表已存在。", "警告", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                    return;
                }

                entity = new BFIPriceListEntity
                         {
                             PriceListID = m_id.Value
                         };
                entity.Fetch();

                this.CustomSetEntity(entity);

                entity.LastModifyDate = DateTime.Now;
                entity.LastModifyUserID = GlobalItem.g_CurrentUser.UserID;
                entity.Update();
                priceLists = new EntityCollection<BFIPriceListEntity>();
                priceLists.Fetch(BFIPriceListEntityFields.PriceListType == "采购价格表" &
                                 BFIPriceListEntityFields.PriceListID == m_id.Value);
                entity = priceLists[0] as BFIPriceListEntity;
            }
            FrmSinglePurchasePriceVersion frmSinglePurchasePriceVersion = new FrmSinglePurchasePriceVersion(entity);
            frmSinglePurchasePriceVersion.ShowDialog(this);
            this.popupGrid.SetGridData(m_id.Value);
        }

        private void btnEdit_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            try
            {
                object id = popupGrid.PopupView.GetFocusedRowCellValue("价格表版本ID");
                if(id != null)
                {
                    BFIPriceListEntity entity = new BFIPriceListEntity
                    {
                        PriceListID = m_id.Value
                    };
                    entity.Fetch();
                    FrmSinglePurchasePriceVersion frmSinglePurchasePriceVersion = new FrmSinglePurchasePriceVersion(entity);
                    frmSinglePurchasePriceVersion.Tag = Convert.ToInt32(id);
                    frmSinglePurchasePriceVersion.ShowDialog(this);
                    this.popupGrid.SetGridData(m_id.Value);
                }
            }
            catch(Exception ex)
            {
                XtraMessageBox.Show(ex.Message, "错误", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnDelete_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            try
            {
                object id = popupGrid.PopupView.GetFocusedRowCellValue("价格表版本ID");
                if(id != null)
                {
                    DialogResult result = XtraMessageBox.Show("确定要删除该信息吗？", "警告", MessageBoxButtons.OKCancel, MessageBoxIcon.Question);
                    if(result == DialogResult.OK)
                    {
                        string sql = string.Format(@"DELETE dbo.BFI_PriceListItem WHERE PriceVersionID = {0}
DELETE dbo.BFI_PriceListVersion WHERE PriceListVersionID={0}", Convert.ToInt32(id));

                        using(SqlConnection conn = new SqlConnection(GlobalItem.g_DbConnectStrings))
                        {
                            conn.Open();
                            SqlCommand com = new SqlCommand(sql, conn);
                            com.ExecuteNonQuery();
                            conn.Close();
                        }
                        this.popupGrid.SetGridData(m_id.Value);
                    }
                }
            }
            catch(Exception ex)
            {
                XtraMessageBox.Show(ex.Message, "错误", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

    }
}