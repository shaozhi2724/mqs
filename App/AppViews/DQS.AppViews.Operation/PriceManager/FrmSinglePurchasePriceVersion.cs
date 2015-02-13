using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
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
    public partial class FrmSinglePurchasePriceVersion : DevExpress.XtraEditors.XtraForm
    {
        private int? m_id;
        private BFIPriceListEntity _priceListEntity;

        public FrmSinglePurchasePriceVersion()
        {
            InitializeComponent();
        }

        public FrmSinglePurchasePriceVersion(BFIPriceListEntity priceList) : this()
        {
            _priceListEntity = priceList;
            txtPriceListName.Text = priceList.PriceListName;
        }

        private void FrmSinglePurchasePriceVersion_Load(object sender, EventArgs e)
        {
            txtPriceListVersionName.Focus();
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

                BFIPriceListVersionEntity entity = new BFIPriceListVersionEntity
                {
                    PriceListVersionID = m_id.Value
                };
                entity.Fetch();

                this.ftPanel.SetEntity(entity);

                this.CustomGetEntity(entity);

                this.popupGrid.SetGridData(m_id.Value);
            }
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            try
            {
                if(!this.ftPanel.ValidateIsNullFields())
                    return;

                BFIPriceListVersionEntity entity = this.ftPanel.GetEntity() as BFIPriceListVersionEntity;

                this.CustomSetEntity(entity);

                if(!ValiateDateRange(entity))
                {
                    return;
                }

                if(!m_id.HasValue)
                {
                    EntityCollection<BFIPriceListVersionEntity> priceListVersions =
                        new EntityCollection<BFIPriceListVersionEntity>();
                    priceListVersions.Fetch(BFIPriceListVersionEntityFields.PriceListID == _priceListEntity.PriceListID &
                                            BFIPriceListVersionEntityFields.PriceListVersionName == txtPriceListName.Text.Trim());
                    if(priceListVersions.Count > 0)
                    {
                        XtraMessageBox.Show("价格表版本已存在。", "警告", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                        return;
                    }

                    entity.CreateDate = DateTime.Now;
                    entity.LastModifyDate = DateTime.Now;
                    entity.CreateUserID = GlobalItem.g_CurrentUser.UserID;
                    entity.LastModifyUserID = GlobalItem.g_CurrentUser.UserID;
                    entity.Save();
                }
                else
                {
                    EntityCollection<BFIPriceListVersionEntity> priceListVersions =
                        new EntityCollection<BFIPriceListVersionEntity>();
                    priceListVersions.Fetch(BFIPriceListVersionEntityFields.PriceListID == _priceListEntity.PriceListID &
                                            BFIPriceListVersionEntityFields.PriceListVersionName == txtPriceListName.Text.Trim() &
                                            BFIPriceListVersionEntityFields.PriceListVersionID != m_id.Value);
                    if(priceListVersions.Count > 0)
                    {
                        XtraMessageBox.Show("价格表版本已存在。", "警告", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                        return;
                    }

                    entity = new BFIPriceListVersionEntity
                    {
                        PriceListVersionID = m_id.Value
                    };
                    entity.Fetch();

                    this.CustomSetEntity(entity);
                    entity.LastModifyDate = DateTime.Now;
                    entity.LastModifyUserID = GlobalItem.g_CurrentUser.UserID;
                    entity.Update();
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
        protected virtual void CustomGetEntity(BFIPriceListVersionEntity entity)
        {
            if(!entity.IsNullField("StartDate"))
            {
                dteStart.DateTime = entity.StartDate;
            }
            if(!entity.IsNullField("EndDate"))
            {
                dteEnd.DateTime = entity.EndDate;
            }

            if(!entity.IsNullField("Active"))
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
        protected virtual void CustomSetEntity(BFIPriceListVersionEntity entity)
        {
            entity.PriceListID = _priceListEntity.PriceListID;
            if(!string.IsNullOrWhiteSpace(txtPriceListVersionName.Text))
            {
                entity.PriceListVersionName = txtPriceListVersionName.Text.Trim();
            }
            if(!string.IsNullOrWhiteSpace(dteStart.Text))
            {
                entity.StartDate = dteStart.DateTime.Date;
            }
            if(!string.IsNullOrWhiteSpace(dteEnd.Text))
            {
                entity.EndDate = dteEnd.DateTime.Date;
            }
            entity.Active = this.txtActive.Checked;
        }

        private void btnAdd_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            SaveAndOpenPriceItemForm();
        }

        private void SaveAndOpenPriceItemForm()
        {
            if (!this.ftPanel.ValidateIsNullFields())
                return;

            BFIPriceListVersionEntity entity = this.ftPanel.GetEntity() as BFIPriceListVersionEntity;

            this.CustomSetEntity(entity);

            if (!ValiateDateRange(entity))
            {
                return;
            }

            if (!m_id.HasValue)
            {
                EntityCollection<BFIPriceListVersionEntity> priceListVersions =
                    new EntityCollection<BFIPriceListVersionEntity>();
                priceListVersions.Fetch(BFIPriceListVersionEntityFields.PriceListID == _priceListEntity.PriceListID &
                                        BFIPriceListVersionEntityFields.PriceListVersionName == txtPriceListName.Text.Trim());
                if (priceListVersions.Count > 0)
                {
                    XtraMessageBox.Show("价格表版本已存在。", "警告", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                    return;
                }

                entity.CreateDate = DateTime.Now;
                entity.LastModifyDate = DateTime.Now;
                entity.CreateUserID = GlobalItem.g_CurrentUser.UserID;
                entity.LastModifyUserID = GlobalItem.g_CurrentUser.UserID;
                entity.Save();

                //查询出其ID
                priceListVersions.Fetch(BFIPriceListVersionEntityFields.PriceListID == _priceListEntity.PriceListID &
                                        BFIPriceListVersionEntityFields.PriceListVersionName == entity.PriceListVersionName);
                entity = priceListVersions[0] as BFIPriceListVersionEntity;
                m_id = entity.PriceListVersionID;
            }
            else
            {
                EntityCollection<BFIPriceListVersionEntity> priceListVersions =
                    new EntityCollection<BFIPriceListVersionEntity>();
                priceListVersions.Fetch(BFIPriceListVersionEntityFields.PriceListID == _priceListEntity.PriceListID &
                                        BFIPriceListVersionEntityFields.PriceListVersionName == txtPriceListName.Text.Trim() &
                                        BFIPriceListVersionEntityFields.PriceListVersionID != m_id.Value);
                if (priceListVersions.Count > 0)
                {
                    XtraMessageBox.Show("价格表版本已存在。", "警告", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                    return;
                }

                entity = new BFIPriceListVersionEntity
                         {
                             PriceListVersionID = m_id.Value
                         };
                entity.Fetch();

                this.CustomSetEntity(entity);
                entity.LastModifyDate = DateTime.Now;
                entity.LastModifyUserID = GlobalItem.g_CurrentUser.UserID;
                entity.Update();
                priceListVersions.Fetch(BFIPriceListVersionEntityFields.PriceListID == _priceListEntity.PriceListID &
                                        BFIPriceListVersionEntityFields.PriceListVersionID == m_id.Value);
                entity = priceListVersions[0] as BFIPriceListVersionEntity;
            }
            FrmSinglePurchasePriceItem frmSinglePurchasePriceItem = new FrmSinglePurchasePriceItem(entity, _priceListEntity);
            frmSinglePurchasePriceItem.ShowDialog(this);
            this.popupGrid.SetGridData(m_id.Value);
        }

        private bool ValiateDateRange(BFIPriceListVersionEntity entity)
        {
            EntityCollection<BFIPriceListVersionEntity> priceListVersions = new EntityCollection<BFIPriceListVersionEntity>();
            if (m_id.HasValue)
            {
                priceListVersions.Fetch(BFIPriceListVersionEntityFields.PriceListID == _priceListEntity.PriceListID & BFIPriceListVersionEntityFields.PriceListVersionID != m_id.Value);
            }
            else
            {
                priceListVersions.Fetch(BFIPriceListVersionEntityFields.PriceListID == _priceListEntity.PriceListID);
            }

            List<BFIPriceListVersionEntity> versions = priceListVersions.Cast<BFIPriceListVersionEntity>().AsQueryable().ToList();
            if(versions.Any())
            {
                List<DateRange> versionRanges = (from v in versions
                                                 select new DateRange
                                                        {
                                                            DataItem = v,
                                                            Start =
                                                                v.IsNullField("StartDate")
                                                                    ? DateTime.MinValue
                                                                    : v.StartDate,
                                                            End =
                                                                v.IsNullField("EndDate") ? DateTime.MaxValue : v.EndDate
                                                        }).ToList();
                DateRange comparedRange = new DateRange
                                          {
                                              DataItem = entity,
                                              Start =
                                                  entity.IsNullField("StartDate")
                                                      ? DateTime.MinValue
                                                      : entity.StartDate,
                                              End =
                                                  entity.IsNullField("EndDate") ? DateTime.MaxValue : entity.EndDate
                                          };
                versionRanges.Add(comparedRange);
                //IEnumerable<OverlapPairs> overlaps = DateRange.OverlapingRanges(true, versionRanges.ToArray());
                if(DateRange.HasOverlap(true, versionRanges.ToArray()))
                {
                    XtraMessageBox.Show("当前价格版本与现有价格版本有日期重叠，不允许添加价格版本！",
                                        "价格版本日期错误",
                                        MessageBoxButtons.OK,
                                        MessageBoxIcon.Error);
                    return false;
                }
            }
            return true;
        }

        private void btnEdit_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            try
            {
                object id = popupGrid.PopupView.GetFocusedRowCellValue("价格明细ID");
                if(id != null)
                {
                    BFIPriceListVersionEntity entity = new BFIPriceListVersionEntity
                    {
                        PriceListVersionID = m_id.Value
                    };
                    entity.Fetch();

                    FrmSinglePurchasePriceItem frmSinglePurchasePriceItem = new FrmSinglePurchasePriceItem(entity, _priceListEntity);
                    frmSinglePurchasePriceItem.Tag = Convert.ToInt32(id);
                    frmSinglePurchasePriceItem.ShowDialog(this);
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
                object id = popupGrid.PopupView.GetFocusedRowCellValue("价格明细ID");
                if(id != null)
                {
                    DialogResult result = XtraMessageBox.Show("确定要删除该信息吗？", "警告", MessageBoxButtons.OKCancel, MessageBoxIcon.Question);
                    if(result == DialogResult.OK)
                    {
                        BFIPriceListItemEntity entity = new BFIPriceListItemEntity
                        {
                            PriceListItemId = Convert.ToInt32(id)
                        };
                        //删除
                        entity.Delete();

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