using System;
using System.Collections.Generic;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Threading;
using System.Windows.Forms;
using DevExpress.XtraEditors;
using DQS.Module.Entities;
using System.IO;
using DQS.Common;
using DevExpress.XtraGrid.Views.Grid;
using DevExpress.XtraGrid;
using DevExpress.XtraBars;


namespace DQS.Controls
{
    public partial class FrmQualification : DevExpress.XtraEditors.XtraForm
    {
        private int m_Id;
        private string m_TableName;
        private string m_FieldName;
        private string m_CertificateCategory;

        private string[] m_ImageType = new string[] { "BMP", "JPG", "GIF", "PNG", "PCX", "DCX", "EMF", "JIF", "JPE", "JFIF", "JPEG", "RLE", "DIB", "PCD", "DXF", "ICO", "WMF", "TIFF", "TGA" };

        public FrmQualification()
        {
            InitializeComponent();
        }

        public FrmQualification(int id, string tableName, string fieldName, string certificateCategory)
        {
            InitializeComponent();

            this.m_Id = id;
            this.m_TableName = tableName;
            this.m_FieldName = fieldName;
            this.m_CertificateCategory = certificateCategory;
            this.gridQualificationControl.GridViewData.FocusedRowChanged += Qualification_FocusedRowChanged;
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
                            BFIQualificationEntity entity = new BFIQualificationEntity {QualificationID = (int) id};
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
        /// 绑定证书信息
        /// </summary>
        private void BindQualification()
        {
            var filter = string.Format("所属ID = {0} AND 所属表ID = '{1}' AND 所属列名ID = '{2}'", m_Id, m_TableName, m_FieldName);
            //this.gridQualificationControl.InitGrid();

            if (!string.IsNullOrEmpty(gridQualificationControl.ViewName))
            {
                DataTable data = GlobalMethod.GetViewData(gridQualificationControl.ViewName, filter);
                EnumerableRowCollection<DataRow> dataRows = data.AsEnumerable();
                const string RequiredCertificatesViewName = "vw_AllRequiredQualificationCategories";
                DataTable defaultRecords = data.Clone();
                if (this.m_TableName == "BFI_Product")
                {
                    DataTable requiredRecords = GlobalMethod.GetViewData(RequiredCertificatesViewName, "CertificateTypeName='产品证书'");
                    int i = 0;
                    foreach (DataRow item in requiredRecords.Rows)
                    {
                        string certificateName = item["CertificateName"].ToString();
                        AddDefaultQualtification(data, ref defaultRecords, certificateName, i, "PT");
                        i++;
                    }
                    /*//通用
                    "营业执照"
                    "开户信息"
                    "税务登记证"
                    "组织机构代码证"
                    "产品生产许可证"
                    "产品GMP证书"
                    "产品注册证"
                    "说明书"
                    "外包装"
                    "检验报告"*/
                }
                else if (this.m_TableName == "BFI_Dealer")
                {
                    /*//通用
                    营业执照
                    开户信息
                    税务登记证
                    组织机构代码证
                    质量保证协议书
                    体系调查表
                    法人委托书*/

                    BFIDealerEntity dealer = new BFIDealerEntity {DealerID = this.m_Id};
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
                }
                else if (this.m_TableName == "BFI_Salesman")
                {
                    /*身份证复印件
                    法人委托书*/
                    DataTable requiredRecords = GlobalMethod.GetViewData(RequiredCertificatesViewName, "CertificateTypeName='供应商人员证书'");
                    int i = 0;
                    foreach (DataRow item in requiredRecords.Rows)
                    {
                        string certificateName = item["CertificateName"].ToString();
                        AddDefaultQualtification(data, ref defaultRecords, certificateName, i, "SN");
                        i++;
                    }
                }

                foreach (DataRow row in defaultRecords.Rows)
                {
                    BFIQualificationEntity entity = new BFIQualificationEntity();
                    entity.QualificationCode = row["档案编号"].ToString();
                    entity.QualificationName = row["档案名称"].ToString();
                    entity.CertificateStyle = row["证书类型"].ToString();
                    entity.QualificationBelong = this.m_TableName;
                    entity.BelongID = this.m_Id;
                    entity.BelongTable = this.m_TableName;
                    entity.BelongFieldName = this.m_FieldName;
                    entity.Save();
                }

                data = GlobalMethod.GetViewData(gridQualificationControl.ViewName, filter);
                DataView dv = data.DefaultView;
                dv.Sort = "到期日期 ASC, 档案编号 ASC";
                DataTable sortedDT = dv.ToTable();
                gridQualificationControl.DataSource = sortedDT;
                gridQualificationControl.Filter = filter;
                gridQualificationControl.PopulateGridColumns(sortedDT);
            }

            #region 过期高亮显示

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
            #endregion
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

        /// <summary>
        ///  绑定属性信息
        /// </summary>
        private void BindAttribute()
        {
            object id = this.gridQualificationControl.GridViewData.GetFocusedRowCellValue("档案ID");
            if (id != null && id != DBNull.Value)
            {
                this.gridAttributeControl.Filter = string.Format("所属档案ID = {0}", id);
                this.gridAttributeControl.InitGrid();
            }
        }

        /// <summary>
        /// 隐藏操作按钮
        /// </summary>
        public void VisbleBarItem()
        {
            this.barBtnNew.Visibility = BarItemVisibility.Never;
            this.barBtnModify.Visibility = BarItemVisibility.Never;
            this.barBtnDelete.Visibility = BarItemVisibility.Never;
            this.barBtnUpAttachment.Visibility = BarItemVisibility.Never;
            this.barDeleteAttachment.Visibility = BarItemVisibility.Never;
            this.barBtnNewAttribute.Visibility = BarItemVisibility.Never;
            this.barBtnDeleteAttribute.Visibility = BarItemVisibility.Never;
        }

        //选中行发生变化,重新加载附件和属性
        private void Qualification_FocusedRowChanged(object sender, DevExpress.XtraGrid.Views.Base.FocusedRowChangedEventArgs e)
        {
            this.BindAttachment();
            this.BindAttribute();
        }

        private void FrmQualification_Load(object sender, EventArgs e)
        {
            this.BindQualification();
            this.BindAttachment();
            this.BindAttribute();

            #region 过期高亮显示
            GridView grid = this.gridQualificationControl.GridViewData as GridView;
            StyleFormatCondition sfcBatchWarning = new StyleFormatCondition();
            sfcBatchWarning.Appearance.BackColor = Color.Yellow;
            sfcBatchWarning.Appearance.Options.UseBackColor = true;
            sfcBatchWarning.ApplyToRow = true;
            sfcBatchWarning.Column = grid.Columns["过期状态"];
            sfcBatchWarning.Condition = FormatConditionEnum.Equal;
            sfcBatchWarning.Value1 = "即将过期";

            StyleFormatCondition sfcBatchLose = new StyleFormatCondition();
            sfcBatchLose.Appearance.BackColor = Color.Red;
            sfcBatchLose.Appearance.Options.UseBackColor = true;
            sfcBatchLose.ApplyToRow = true;
            sfcBatchLose.Column = grid.Columns["过期状态"];
            sfcBatchLose.Condition = FormatConditionEnum.Equal;
            sfcBatchLose.Value1 = "已过期";

            grid.FormatConditions.AddRange(new DevExpress.XtraGrid.StyleFormatCondition[] { sfcBatchWarning, sfcBatchLose });
            #endregion
        }

        private void barBtnNew_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            using (FrmSingleQualification frmSingleQualification = new FrmSingleQualification(this.m_Id, this.m_TableName, this.m_FieldName, this.m_CertificateCategory))
            {
                List<string> quatificateNames = new List<string>();
                DataTable data = gridQualificationControl.DataSource as DataTable;
                foreach (DataRow row in data.Rows)
                {
                    if (row["档案编号"].ToString().Length == 20 && row["档案编号"].ToString().EndsWith("D"))
                    {
                        quatificateNames.Add(row["证书类型"].ToString());
                    }
                }
                foreach (var quatificateName in quatificateNames)
                {
                    if (frmSingleQualification.cbxCertificateStyle.Properties.Items.Contains(quatificateName))
                    {
                        frmSingleQualification.cbxCertificateStyle.Properties.Items.Remove(quatificateName);
                    }
                    frmSingleQualification.cbxCertificateStyle.SelectedIndex = 0;
                }
                DialogResult result = frmSingleQualification.ShowDialog();
                if (result == DialogResult.OK)
                {
                    this.BindQualification();
                }
            }
        }

        private void barBtnModify_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            using (FrmSingleQualification frmSingleQualification = new FrmSingleQualification(this.m_Id, this.m_TableName, this.m_FieldName, this.m_CertificateCategory))
            {
                object id = this.gridQualificationControl.GridViewData.GetFocusedRowCellValue("档案ID");
                if (id != null && DBNull.Value != id)
                {
                    frmSingleQualification.Tag = id;
                    string code = this.gridQualificationControl.GridViewData.GetFocusedRowCellValue("档案编号").ToString();
                    bool isDefaultQuatificate = code.Length == 20 && code.EndsWith("D");
                    frmSingleQualification.cbxCertificateStyle.Enabled = !isDefaultQuatificate;
                    frmSingleQualification.txtQualificationName.Properties.ReadOnly = isDefaultQuatificate;
                    DialogResult result = frmSingleQualification.ShowDialog();
                    if (result == DialogResult.OK)
                    {
                        this.BindQualification();
                    }
                }
            }
        }

        private void barBtnDelete_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            object id = this.gridQualificationControl.GridViewData.GetFocusedRowCellValue("档案ID");
            if (id != null)
            {
                string code = this.gridQualificationControl.GridViewData.GetFocusedRowCellValue("档案编号").ToString();
                string certificate = this.gridQualificationControl.GridViewData.GetFocusedRowCellValue("证书类型").ToString();
                //bool isDefaultQuatificate = code.Length == 20 && code.EndsWith("D");
                //if (this.m_TableName == "BFI_Product")
                //{
                //    isDefaultQuatificate = isDefaultQuatificate && _defaultProductCertifications.ContainsKey(certificate);
                //}
                //else if (this.m_TableName == "BFI_Salesman")
                //{
                //    isDefaultQuatificate = isDefaultQuatificate && _defaultSalesManCertifications.ContainsKey(certificate);
                //}
                //if (isDefaultQuatificate)
                //{
                //    XtraMessageBox.Show("该证书不允许删除", "警告", MessageBoxButtons.OKCancel, MessageBoxIcon.Warning);
                //    return;
                //}
                DialogResult result = XtraMessageBox.Show("删除证书将连带附件和属性信息一起删除，确定要删除该证书信息吗？", "警告", MessageBoxButtons.OKCancel, MessageBoxIcon.Question);
                if (result == DialogResult.OK)
                {

                    BFIQualificationEntity entity = new BFIQualificationEntity { QualificationID = Convert.ToInt32(id) };
                    entity.Delete();

                    BFIQualificationAttachmentEntity attachment = new BFIQualificationAttachmentEntity();
                    attachment.QualificationID = Convert.ToInt32(id);
                    attachment.DeleteByCommonly();

                    BFIQualificationAttributeEntity attribute = new BFIQualificationAttributeEntity();
                    attribute.QualificationID = Convert.ToInt32(id);
                    attribute.DeleteByCommonly();

                    this.BindQualification();
                    this.BindAttachment();
                    this.BindAttribute();
                }
            }
        }

        private void barBtnUpAttachment_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            object id = this.gridQualificationControl.GridViewData.GetFocusedRowCellValue("档案ID");
            if (id != null)
            {
                using (OpenFileDialog attachmentUpDialog = new OpenFileDialog())
                {
                    if (attachmentUpDialog.ShowDialog(this) == DialogResult.OK)
                    {
                        string fullName = attachmentUpDialog.FileName;
                        FileInfo file = new FileInfo(fullName);
                        BFIQualificationAttachmentEntity attchment = new BFIQualificationAttachmentEntity();
                        attchment.AttachmentName = file.Name;
                        attchment.AttachmentSize = GlobalMethod.FormatFileSize(file.Length);
                        attchment.AttachmentType = file.Extension;
                        attchment.CreateUserID = GlobalItem.g_CurrentUser.UserID;
                        attchment.CreateDate = DateTime.Now;
                        attchment.QualificationID = Convert.ToInt32(id);

                        attchment.AttachmentContent = File.ReadAllBytes(fullName);

                        using (FrmProgressing frmProgressing = new FrmProgressing(attchment))
                        {
                            frmProgressing.ShowDialog(this);

                            this.BindAttachment();
                        }
                    }
                }
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

        private void barDeleteAttachment_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            object id = this.gridAttachmentControl.GridViewData.GetFocusedRowCellValue("附件ID");
            if (id != null)
            {
                DialogResult result = XtraMessageBox.Show("确定要删除该附件吗？", "警告", MessageBoxButtons.OKCancel, MessageBoxIcon.Question);
                if (result == DialogResult.OK)
                {

                    BFIQualificationAttachmentEntity entity = new BFIQualificationAttachmentEntity { AttachmentID = Convert.ToInt32(id) };
                    //删除
                    entity.Delete();

                    this.gridAttachmentControl.InitGrid();
                }
            }
        }

        private void barBtnNewAttribute_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            object id = this.gridQualificationControl.GridViewData.GetFocusedRowCellValue("档案ID");
            if (id != null)
            {
                using (FrmSingleAttribute frmSingleAttribute = new FrmSingleAttribute(Convert.ToInt32(id)))
                {
                    DialogResult result = frmSingleAttribute.ShowDialog();
                    if (result == DialogResult.OK)
                    {
                        this.BindAttribute();
                    }
                }
            }

        }

        private void barBtnDeleteAttribute_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            object id = this.gridAttributeControl.GridViewData.GetFocusedRowCellValue("属性ID");
            if (id != null)
            {
                DialogResult result = XtraMessageBox.Show("确定要删除该属性信息吗？", "警告", MessageBoxButtons.OKCancel, MessageBoxIcon.Question);
                if (result == DialogResult.OK)
                {
                    BFIQualificationAttributeEntity entity = new BFIQualificationAttributeEntity { AttributeID = Convert.ToInt32(id) };
                    entity.Delete();

                    this.BindAttribute();
                }
            }
        }

        private void FrmQualification_FormClosing(object sender, FormClosingEventArgs e)
        {
            List<string> quatificateNames = new List<string>();
            DataTable data = gridQualificationControl.DataSource as DataTable;
            int i = 1;
            foreach (DataRow row in data.Rows)
            {
                if (row["到期日期"] == DBNull.Value && row["档案编号"].ToString().Length == 20 && row["档案编号"].ToString().EndsWith("D"))
                {
                    quatificateNames.Add(string.Concat(i, ". ", row["证书类型"].ToString()));
                    i++;
                }
            }
            if (quatificateNames.Any())
            {
                var dialogResult =
                    XtraMessageBox.Show(
                        string.Format("不完成以下证书将影响业务操作：\n{0}\n确定关闭？", string.Join("\n", quatificateNames)), "警告",
                        MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
                e.Cancel = dialogResult == DialogResult.No;
            }
        }
    }
}