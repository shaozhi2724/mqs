using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading;
using System.Windows.Forms;
using DevExpress.Utils;
using DevExpress.XtraEditors;
using DevExpress.XtraEditors.Controls;
using DevExpress.XtraGrid;
using DevExpress.XtraGrid.Views.Grid;
using DQS.Controls;
using DQS.Module.Entities;
using ORMSCore;
using DQS.Common;
using System.Data.SqlClient;

namespace DQS.AppViews.QualityDocument.DealerManager
{
    public partial class FrmSingleFirstDealerChangeDetail : DevExpress.XtraEditors.XtraForm
    {
        private int? m_id;

        const string tableName = "BFI_Dealer";
        const string fieldName = "DealerID";
        const string certificateCategory = "DealerCertificate";
        private string[] m_ImageType = new string[] { "BMP", "JPG", "GIF", "PNG", "PCX", "DCX", "EMF", "JIF", "JPE", "JFIF", "JPEG", "RLE", "DIB", "PCD", "DXF", "ICO", "WMF", "TIFF", "TGA" };

        private Guid antiApproveID;
        public FrmSingleFirstDealerChangeDetail()
        {
            InitializeComponent();

            this.gridQualificationControl.GridViewData.FocusedRowChanged += Qualification_FocusedRowChanged;
        }

        private void FrmSingleFirstDealerChangeDetail_Load(object sender, EventArgs e)
        {
            antiApproveID = Guid.NewGuid();
            this.cbxDealerType.Text = "供应商";
            this.cbxDealerType.Enabled = false;
            this.cbxDealerStyle.InitSource();

            cbxIndustryStyle.InitSource();
            //if (!string.IsNullOrEmpty(cbxIndustryStyle.CategoryCode))
            //{
            //    EntityCollection<SYSCategoryEntity> categories = new EntityCollection<SYSCategoryEntity>();
            //    PredicateExpression pe = new PredicateExpression();
            //    pe.Add(SYSCategoryEntityFields.CategoryCode == cbxIndustryStyle.CategoryCode);
            //    pe.Add(SYSCategoryEntityFields.ItemID <= 2);
            //    categories.Fetch(pe);

            //    foreach (SYSCategoryEntity category in categories)
            //    {
            //        cbxIndustryStyle.Properties.Items.Add(category.ItemName);
            //    }
            //}

            BindProductStyles();

            BindPrices();

            if (this.Tag != null)
            {
                this.m_id = Convert.ToInt32(this.Tag);

                BFIDealerEntity entity = new BFIDealerEntity { DealerID = m_id.Value };
                entity.Fetch();
                EntityCollection<BFIBusinessRangeEntity> ranges = new EntityCollection<BFIBusinessRangeEntity>();
                ranges.Fetch(BFIBusinessRangeEntityFields.DealerID == entity.DealerID);

                if (ranges.Count > 0)
                {
                    this.chklbcProductStyle.UnCheckAll();//先全部清空

                    foreach (BFIBusinessRangeEntity range in ranges)
                    {
                        foreach (CheckedListBoxItem item in this.chklbcProductStyle.Items)
                        {
                            SYSCategoryEntity category = (item.Value as ListEntityItem).Key as SYSCategoryEntity;

                            if (category.ItemID == range.ProductStyleID)
                            {
                                this.chklbcProductStyle.SelectedItem = item;
                                item.CheckState = CheckState.Checked;
                                break;
                            }
                        }
                    }
                }
                else
                {
                    this.chklbcProductStyle.SelectedIndex = 0;
                    this.chklbcProductStyle.UnCheckAll();
                }
                this.ftPanel.SetEntity(entity);

                this.txtDealerCode.Enabled = false;

                this.CustomGetEntity(entity);

                BindQualification();
            }
            RenderRequiredFields();
        }

        private void BindPrices()
        {
            EntityCollection<BFIPriceListEntity> prices = new EntityCollection<BFIPriceListEntity>();
            prices.Fetch(BFIPriceListEntityFields.PriceListType == "采购价格表" & BFIPriceListEntityFields.Active == true);
            if(prices.Count < 7)
            {
                cbxPrice.Properties.DropDownRows = prices.Count;
            }
            cbxPrice.Properties.DataSource = prices;

        }

        private void RenderRequiredFields()
        {
            foreach (Control control in layControl.Controls)
            {
                if (control is TextBoxEx)
                {
                    TextBoxEx ctl = ((TextBoxEx)control);
                    if (ctl.IsNullValidate)
                    {
                        layControl.GetItemByControl(ctl).AppearanceItemCaption.ForeColor = Color.Red;
                    }
                }
                if (control is ComboBoxEdit)
                {
                    var ctl = ((ComboBoxEdit)control);
                    if (ctl.Properties.AllowNullInput == DefaultBoolean.False)
                    {
                        layControl.GetItemByControl(ctl).AppearanceItemCaption.ForeColor = Color.Red;
                    }
                }
            }
        }

        private void BindProductStyles()
        {
            EntityCollection<SYSCategoryEntity> categories = new EntityCollection<SYSCategoryEntity>();
            categories.Fetch(SYSCategoryEntityFields.CategoryCode == "ProductStyle");

            foreach (SYSCategoryEntity c in categories)
            {
                this.chklbcProductStyle.Items.Add(new ListEntityItem(c, c.ItemName));
            }
        }
        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.Cancel;
        }

        /// <summary>
        /// 非文本框取值
        /// </summary>
        /// <param name="entity">实体</param>
        protected virtual void CustomGetEntity(BFIDealerEntity entity)
        {
            this.cbxDealerType.Text = "供应商";

            if (!entity.IsNullField("DealerStyle"))
            {
                this.cbxDealerStyle.Text = entity.DealerStyle;
            }

            if (!entity.IsNullField("IndustryStyle"))
            {
                this.cbxIndustryStyle.Text = entity.IndustryStyle;
                if (cbxIndustryStyle.Text == "生产厂商")
                {
                    layBusinessRange.CustomizationFormText = "生产范围";
                    layBusinessRange.Text = "生产范围";
                }
                else
                {
                    layBusinessRange.CustomizationFormText = "经营范围";
                    layBusinessRange.Text = "经营范围";
                }
            }

            if (!entity.IsNullField("RegisterData") && entity.RegisterData.HasValue)
            {
                this.dteRegisterData.DateTime = entity.RegisterData.Value;
            }

            if(!entity.IsNullField("PurchasePriceListID"))
            {
                cbxPrice.EditValue = entity.PurchasePriceListID;
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

        #region 电子档案变更

        /// <summary>
        /// 绑定证书信息
        /// </summary>
        private void BindQualification()
        {
            var filter = string.Format("所属ID = {0} AND 所属表ID = '{1}' AND 所属列名ID = '{2}'", m_id.Value, tableName, fieldName);
            //this.gridQualificationControl.InitGrid();

            if (!string.IsNullOrEmpty(gridQualificationControl.ViewName))
            {
                DataTable data = GlobalMethod.GetViewData(gridQualificationControl.ViewName, filter);
                EnumerableRowCollection<DataRow> dataRows = data.AsEnumerable();
                const string RequiredCertificatesViewName = "vw_AllRequiredQualificationCategories";
                DataTable defaultRecords = data.Clone();
                /*//通用
                    营业执照
                    开户信息
                    税务登记证
                    组织机构代码证
                    质量保证协议书
                    体系调查表
                    法人委托书*/

                BFIDealerEntity dealer = new BFIDealerEntity {DealerID = m_id.Value};
                dealer.Fetch();

                var dealerType = dealer.DealerType;
                var industryStyle = dealer.IndustryStyle;

                if (industryStyle == "生产厂商")
                {
                    /*//如果是生产企业
                        产品生产许可证
                        产品GMP证书
                        印章印模
                        随货同行单
                         */
                    DataTable requiredRecords = GlobalMethod.GetViewData(RequiredCertificatesViewName,
                        "CertificateTypeName='生产企业证书'");
                    int i = 0;
                    foreach (DataRow item in requiredRecords.Rows)
                    {
                        string certificateName = item["CertificateName"].ToString();
                        AddDefaultQualtification(data, ref defaultRecords, certificateName, i, "DR");
                        i++;
                    }
                }
                else if (industryStyle == "医疗机构")
                {

                    DataTable requiredRecords = GlobalMethod.GetViewData(RequiredCertificatesViewName,
                        "CertificateTypeName='医疗机构证书'");
                    int i = 0;
                    foreach (DataRow item in requiredRecords.Rows)
                    {
                        string certificateName = item["CertificateName"].ToString();
                        AddDefaultQualtification(data, ref defaultRecords, certificateName, i, "DR");
                        i++;
                    }
                }
                else
                {
                    string certificateTypeName = "经营企业证书";
                    if (dealerType == "供应商")
                    {
                        /*//供应商
                        印章印模
                        随货同行单*/
                        certificateTypeName = "供应商经营企业证书";
                    }
                    else
                    {
                        /*//如果是经营企业
                        产品经营许可证
                        产品GSP证书"*/
                        certificateTypeName = "经营企业证书";
                    }
                    DataTable requiredRecords = GlobalMethod.GetViewData(RequiredCertificatesViewName,
                        string.Format("CertificateTypeName='{0}'", certificateTypeName));
                    int i = 0;
                    foreach (DataRow item in requiredRecords.Rows)
                    {
                        string certificateName = item["CertificateName"].ToString();
                        AddDefaultQualtification(data, ref defaultRecords, certificateName, i, "DR");
                        i++;
                    }
                }

                foreach (DataRow row in defaultRecords.Rows)
                {
                    BFIQualificationEntity entity = new BFIQualificationEntity();
                    entity.QualificationCode = row["档案编号"].ToString();
                    entity.QualificationName = row["档案名称"].ToString();
                    entity.CertificateStyle = row["证书类型"].ToString();
                    entity.QualificationBelong = tableName;
                    entity.BelongID = m_id.Value;
                    entity.BelongTable = tableName;
                    entity.BelongFieldName = fieldName;
                    entity.Save();
                }

                data = GlobalMethod.GetViewData(gridQualificationControl.ViewName, filter);
                DataView dv = data.DefaultView;
                dv.Sort = "到期日期 ASC, 档案编号 ASC";
                DataTable sortedDT = dv.ToTable();

                EntityCollection<ATCAntiApproveQualificationDetailEntity> changes = new EntityCollection<ATCAntiApproveQualificationDetailEntity>();
                DataTable changedData = changes.FetchTable(ATCAntiApproveQualificationDetailEntityFields.AntiApproveID == antiApproveID 
                    & ATCAntiApproveQualificationDetailEntityFields.BelongTable == tableName
                    & ATCAntiApproveQualificationDetailEntityFields.BelongFieldName == fieldName
                    & ATCAntiApproveQualificationDetailEntityFields.BelongID == m_id.Value);
                if (changedData.Rows.Count > 0)
                {
                    foreach (DataRow row in changedData.Rows)
                    {
                        DataRow oldRow =
                            sortedDT.AsEnumerable()
                                .FirstOrDefault(p => p.Field<int>("档案ID") == (int) row["QualificationID"]);
                        if (null != oldRow)
                        {
                            oldRow["证书编号"] = row["CertificateNo"];
                            oldRow["发证机关"] = row["IssuingAuthority"];
                            oldRow["发证日期"] = row["IssuingDate"];
                            oldRow["到期日期"] = row["ValidateDate"];
                            if (row["ValidateDate"] != DBNull.Value)
                            {
                                string status = "未过期";
                                DateTime validDate = (DateTime)row["ValidateDate"];
                                if (DateTime.Now > validDate)
                                {
                                    status = "已过期";
                                }
                                else if (validDate.AddDays(-30) < DateTime.Now)
                                {
                                    status = "即将过期";
                                }
                                oldRow["到期状态"] = status;
                            }
                            oldRow["备注"] = row["QualificationRemark"];
                        }
                    }
                }
                gridQualificationControl.DataSource = sortedDT;
                gridQualificationControl.Filter = filter;
                gridQualificationControl.PopulateGridColumns(sortedDT);
            }

            GridView view = gridQualificationControl.MainView as GridView;
            if (null != view)
            {
                StyleFormatCondition sfcRequiredExpression = new StyleFormatCondition();
                sfcRequiredExpression.Appearance.ForeColor = Color.Red;
                sfcRequiredExpression.Appearance.Options.UseBackColor = true;
                sfcRequiredExpression.Appearance.Options.UseForeColor = true;
                sfcRequiredExpression.ApplyToRow = true;
                sfcRequiredExpression.Column = view.Columns["档案编号"];
                sfcRequiredExpression.Condition = FormatConditionEnum.Expression;
                //20位编码，并且最后一位是"D",并且 到期日期 未填
                sfcRequiredExpression.Expression = "[到期日期] == ? && Len([档案编号]) == 20 && Substring([档案编号],19,1)== 'D'";

                view.FormatConditions.AddRange(new DevExpress.XtraGrid.StyleFormatCondition[] {sfcRequiredExpression});

                view.BestFitColumns();
            }

            BindAttachment();
        }

        private void AddDefaultQualtification(DataTable data, ref DataTable dataTable, string quatificationName, int rowIndex, string codePrefix)
        {

            var rows = data.Select(string.Format("[证书类型]='{0}'", quatificationName));

            if (rows.Length == 0)
            {
                DataRow row = dataTable.NewRow();
                string code = string.Format("{0}{1}D", codePrefix, DateTime.Now.ToString("yyyyMMddHHmmssfff"));
                row["档案编号"] = code;
                row["档案名称"] = quatificationName;
                row["证书类型"] = quatificationName;
                row["到期日期"] = DBNull.Value;
                dataTable.Rows.InsertAt(row, rowIndex);
                dataTable.AcceptChanges();
                Thread.Sleep(10);
            }
            else
            {
                foreach (var dataRow in rows)
                {
                    if (dataRow["档案编号"].ToString().Length != 20 && !dataRow["档案编号"].ToString().EndsWith("D"))
                    {
                        string code = string.Format("{0}{1}D", codePrefix, DateTime.Now.ToString("yyyyMMddHHmmssfff"));
                        dataRow["档案编号"] = code;
                        var id = dataRow["档案ID"];
                        if (DBNull.Value != id)
                        {
                            BFIQualificationEntity entity = new BFIQualificationEntity { QualificationID = (int)id };
                            entity.Fetch();
                            entity.QualificationCode = code;
                            entity.Update();
                        }
                    }
                    data.AcceptChanges();
                    Thread.Sleep(10);
                }
            }
        }
        /// <summary>
        /// 绑定附件信息
        /// </summary>
        private void BindAttachment()
        {
            object id = this.gridQualificationControl.GridViewData.GetFocusedRowCellValue("档案ID");
            if (id != null && id != DBNull.Value)
            {
                this.gridAttachmentControl.Filter = string.Format("所属档案ID = {0}", id);
                this.gridAttachmentControl.InitGrid();

            }
        }

        private void barBtnDownAttachment_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            if (this.gridAttachmentControl.GridViewData.RowCount > 0)
            {
                if (this.gridAttachmentControl.GridViewData.GetFocusedRowCellValue("附件名称") != null && this.gridAttachmentControl.GridViewData.GetFocusedRowCellValue("附件ID") != null)
                {
                    int attachmentID = Convert.ToInt32(this.gridAttachmentControl.GridViewData.GetFocusedRowCellValue("附件ID"));
                    string fileName = this.gridAttachmentControl.GridViewData.GetFocusedRowCellValue("附件名称").ToString();

                    using (FolderBrowserDialog attachmentDownDialog = new FolderBrowserDialog())
                    {
                        if (attachmentDownDialog.ShowDialog(this) == DialogResult.OK)
                        {
                            string fullName = Path.Combine(attachmentDownDialog.SelectedPath, fileName);
                            if (File.Exists(fullName))
                            {
                                XtraMessageBox.Show(fullName + "已存在，请选择其它目录进行存放。", "系统提示", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                                return;
                            }

                            using (FrmProgressing frmProgressing = new FrmProgressing(attachmentID, fullName))
                            {
                                frmProgressing.ShowDialog(this);
                            }
                        }
                    }

                }
                else
                {
                    XtraMessageBox.Show("请先选中一个附件再进行下载。", "系统提示", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
            else
            {
                XtraMessageBox.Show("无任何附件可供下载。", "系统提示", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void barBtnPreview_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            if (this.gridAttachmentControl.GridViewData.RowCount > 0)
            {
                if (this.gridAttachmentControl.GridViewData.GetFocusedRowCellValue("附件名称") != null && this.gridAttachmentControl.GridViewData.GetFocusedRowCellValue("附件ID") != null)
                {
                    int attachmentID = Convert.ToInt32(this.gridAttachmentControl.GridViewData.GetFocusedRowCellValue("附件ID"));
                    string fileName = this.gridAttachmentControl.GridViewData.GetFocusedRowCellValue("附件名称").ToString();

                    string fileType = this.gridAttachmentControl.GridViewData.GetFocusedRowCellValue("类型").ToString();

                    bool isImage = false;
                    foreach (string imageType in m_ImageType)
                    {
                        if (fileType.ToUpper().Contains(imageType))
                        {
                            isImage = true;
                            break;
                        }
                    }

                    if (!isImage)
                    {
                        XtraMessageBox.Show("不支持此附件类型，只能显示图片类型的附件。", "系统提示", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                        return;
                    }

                    string tempName = String.Format("TEMP~{0}~{1}", Guid.NewGuid(), fileName);

                    using (FrmAttachmentPreview frmAttachmentPreview = new FrmAttachmentPreview(attachmentID, tempName))
                    {
                        frmAttachmentPreview.ShowDialog(this);
                    }


                }
            }
        }

        //选中行发生变化,重新加载附件和属性
        private void Qualification_FocusedRowChanged(object sender, DevExpress.XtraGrid.Views.Base.FocusedRowChangedEventArgs e)
        {
            this.BindAttachment();
        }
        #endregion


        public void MarkChangedFieds(Guid antiApproveID)
        {
            btnCancel.Text = "关闭(&C)";
            EntityCollection<ATCAntiApproveDetailEntity> details = new EntityCollection<ATCAntiApproveDetailEntity>();
            details.Fetch(ATCAntiApproveDetailEntityFields.AntiApproveID == antiApproveID);
            foreach (ATCAntiApproveDetailEntity entity in details)
            {
                Control[] controls = this.Controls.Find(entity.ControlName, true);
                foreach (Control control in controls)
                {
                    control.BackColor = Color.LightPink;
                }
            }
            MakeControlsReadOnly();
        }

        private void MakeControlsReadOnly()
        {
            foreach (Control control in layControl.Controls)
            {
                if (control is BaseEdit)
                {
                    ((BaseEdit)control).Properties.ReadOnly = true;
                }
                else
                {
                    control.Enabled = false;
                }
            }
        }
    }
}