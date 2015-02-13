using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading;
using System.Windows.Forms;
using DevExpress.Utils;
using DevExpress.XtraEditors;
using DevExpress.XtraGrid;
using DevExpress.XtraGrid.Views.Grid;
using DevExpress.XtraLayout;
using DQS.Controls;
using DQS.Module.Entities;
using KellermanSoftware.CompareNetObjects;
using ORMSCore;
using DQS.Common;

namespace DQS.AppViews.QualityDocument.ProductManager
{
    public partial class FrmSingleFirstProductChangeDetail : DevExpress.XtraEditors.XtraForm
    {
        private int? m_id;

        const string tableName = "BFI_Product";
        const string fieldName = "ProductID";
        const string certificateCategory = "ProductCertificate";
        private string[] m_ImageType = new string[] { "BMP", "JPG", "GIF", "PNG", "PCX", "DCX", "EMF", "JIF", "JPE", "JFIF", "JPEG", "RLE", "DIB", "PCD", "DXF", "ICO", "WMF", "TIFF", "TGA" };
        private Guid antiApproveID;
        public FrmSingleFirstProductChangeDetail()
        {
            InitializeComponent();
            this.gridQualificationControl.GridViewData.FocusedRowChanged += Qualification_FocusedRowChanged;
        }

        private void FrmSingleFirstProductChangeDetail_Load(object sender, EventArgs e)
        {
            antiApproveID = Guid.NewGuid();
            this.cbxPhysicType.InitSource();
            this.cbxStockCondition.InitSource();
            this.cbxProductStyle.InitSource();
            this.cbxProductCycleStyle.InitSource();
            this.cbxIsForeignDrug.Checked = false;
            if (this.Tag != null)
            {
                this.m_id = Convert.ToInt32(this.Tag);

                BFIProductEntity entity = new BFIProductEntity { ProductID = m_id.Value };
                entity.Fetch();

                this.ftPanel.SetEntity(entity);

                this.txtProductCode.Enabled = false;

                this.CustomGetEntity(entity);

                BindQualification();
                BindGrantedPersons(m_id.Value);
            }
            RenderRequiredFields();
        }

        private void BindGrantedPersons(int productID)
        {
            string sql = string.Format(@"SELECT DISTINCT 
UP.UserName AS [用户名], 
E.EmployeeName AS [员工姓名] 
FROM dbo.ATC_UserProduct AS UP
LEFT JOIN dbo.ATC_User AS U
ON U.UserID = UP.UserID
LEFT JOIN dbo.BFI_Employee AS E
ON E.EmployeeID = U.EmployeeID
WHERE UP.ProductID = {0}", productID);

            using (SqlConnection conn = new SqlConnection(GlobalItem.g_DbConnectStrings))
            {

                DataSet ds = new DataSet();
                SqlDataAdapter da = new SqlDataAdapter(sql, conn);
                da.Fill(ds);
                conn.Close();
                popupGrid.DataSource = ds.Tables[0];
            }
            var gridView = popupGrid.MainView as GridView;
            if (gridView != null)
            {
                for (int index = 0; index < gridView.Columns.Count; index++)
                {
                    gridView.Columns[index].Visible = !gridView.Columns[index].FieldName.EndsWith("ID");
                    gridView.Columns[index].OptionsColumn.AllowEdit = false;
                }

                gridView.BestFitColumns();
            }
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
            foreach (Control control in layControl2.Controls)
            {
                if (control is TextBoxEx)
                {
                    TextBoxEx ctl = ((TextBoxEx)control);
                    if (ctl.IsNullValidate)
                    {
                        layControl2.GetItemByControl(ctl).AppearanceItemCaption.ForeColor = Color.Red;
                    }
                }
                if (control is ComboBoxEdit)
                {
                    var ctl = ((ComboBoxEdit)control);
                    if (ctl.Properties.AllowNullInput == DefaultBoolean.False)
                    {
                        layControl2.GetItemByControl(ctl).AppearanceItemCaption.ForeColor = Color.Red;
                    }
                }
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
        protected virtual void CustomGetEntity(BFIProductEntity entity)
        {
            if (!entity.IsNullField("PhysicTypeID"))
            {
                this.cbxPhysicType.SelectedValue = entity.PhysicTypeID;
            }

            if (!entity.IsNullField("ProductStyleID"))
            {
                this.cbxProductStyle.SelectedValue = entity.ProductStyleID;
            }

            if (!entity.IsNullField("StockCondition"))
            {
                this.cbxStockCondition.Text = entity.StockCondition;
            }

            if (!entity.IsNullField("CycleType"))
            {
                this.cbxProductCycleStyle.Text = entity.CycleType;
            }
            chkBoxUseDescription.UnCheckAll();
            if (!entity.IsNullField("IsUseToChildren"))
            {
                if (entity.IsUseToChildren == true)
                {
                    chkBoxUseDescription.Items[0].CheckState = CheckState.Checked;
                }
            }

            if (!entity.IsNullField("IsUseToOldPeople"))
            {
                if (entity.IsUseToOldPeople == true)
                {
                    chkBoxUseDescription.Items[1].CheckState = CheckState.Checked;
                }
            }

            if (!entity.IsNullField("IsUseToPregnant"))
            {
                if (entity.IsUseToPregnant == true)
                {
                    chkBoxUseDescription.Items[2].CheckState = CheckState.Checked;
                }
            }

            if (!entity.IsNullField("IsForeignDrug"))
            {
                if (entity.IsForeignDrug)
                {
                    cbxIsForeignDrug.Checked = entity.IsForeignDrug;
                    cbxIsForeignDrug.CheckState = CheckState.Checked;
                }
                else
                {
                    cbxIsForeignDrug.CheckState = CheckState.Unchecked;
                }
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

                BFIDealerEntity dealer = new BFIDealerEntity { DealerID = m_id.Value };
                dealer.Fetch();

                var dealerType = dealer.DealerType;
                var industryStyle = dealer.IndustryStyle;

                if (industryStyle == "生产厂商")
                {
                    /*//如果是生产企业
                        药品生产许可证
                        药品GMP证书
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
                        药品经营许可证
                        药品GSP证书"*/
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

                CloneData();

                EntityCollection<ATCAntiApproveQualificationDetailEntity> changes = new EntityCollection<ATCAntiApproveQualificationDetailEntity>();
                DataTable changedData = changes.FetchTable(ATCAntiApproveQualificationDetailEntityFields.AntiApproveID == antiApproveID
                    & ATCAntiApproveQualificationDetailEntityFields.BelongTable == tableName
                    & ATCAntiApproveQualificationDetailEntityFields.BelongFieldName == fieldName
                    & ATCAntiApproveQualificationDetailEntityFields.BelongID == m_id.Value);
                data = GlobalMethod.GetViewData(gridQualificationControl.ViewName, filter);
                DataTable records = data.Clone();
                foreach (DataRow dataRow in changedData.Rows)
                {
                    DataRow oldRow =
                        data.AsEnumerable()
                            .FirstOrDefault(p => p.Field<int>("档案ID") == (int)dataRow["QualificationID"]);

                    DataRow newRow = records.NewRow();
                    newRow["档案ID"] = dataRow["QualificationID"];
                    newRow["档案编号"] = dataRow["QualificationCode"];
                    newRow["档案名称"] = dataRow["QualificationName"];
                    newRow["证书类型"] = dataRow["CertificateStyle"];
                    newRow["证书编号"] = dataRow["CertificateNo"];
                    newRow["发证机关"] = dataRow["IssuingAuthority"];
                    newRow["发证日期"] = dataRow["IssuingDate"];
                    newRow["到期日期"] = dataRow["ValidateDate"];
                    if (dataRow["ValidateDate"] != DBNull.Value)
                    {
                        string status = "未过期";
                        DateTime validDate = (DateTime)dataRow["ValidateDate"];
                        if (DateTime.Now > validDate)
                        {
                            status = "已过期";
                        }
                        else if (validDate.AddDays(-30) < DateTime.Now)
                        {
                            status = "即将过期";
                        }
                        newRow["到期状态"] = status;
                    }

                    newRow["创建人"] = oldRow["创建人"];
                    newRow["创建日期"] = oldRow["创建日期"];
                    newRow["最后修改人"] = oldRow["最后修改人"];
                    newRow["修改时间"] = oldRow["修改时间"];
                    newRow["备注"] = oldRow["备注"];
                    newRow["所属ID"] = oldRow["所属ID"];
                    newRow["所属表ID"] = oldRow["所属表ID"];
                    newRow["所属列名ID"] = oldRow["所属列名ID"];
                    records.Rows.Add(newRow);
                }
                records.AcceptChanges();
                DataView dv = records.DefaultView;
                dv.Sort = "到期日期 ASC, 档案编号 ASC";
                DataTable sortedDT = dv.ToTable();

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

                view.FormatConditions.AddRange(new DevExpress.XtraGrid.StyleFormatCondition[] { sfcRequiredExpression });

                view.BestFitColumns();
            }

            BindAttachment();
        }

        private void CloneData()
        {
            string sqlString = @"
                            IF NOT EXISTS(SELECT 1 FROM dbo.ATC_AntiApproveQualificationDetail WHERE AntiApproveID='{0}' AND BelongTable='{1}' AND BelongID='{2}')
                            BEGIN
                                INSERT INTO dbo.ATC_AntiApproveQualificationDetail
                                (
	                                DetailID,
	                                AntiApproveID,
	                                QualificationID,
	                                QualificationCode,
	                                QualificationName,
	                                CertificateStyle,
	                                CertificateNo,
	                                IssuingAuthority,
	                                IssuingDate,
	                                ValidateDate,
	                                QualificationBelong,
	                                BelongID,
	                                BelongTable,
	                                BelongFieldName,
	                                CreateUserID,
	                                CreateDate,
	                                LastModifyUserID,
	                                LastModifyDate,
	                                QualificationRemark
                                )
                                SELECT
	                                NEWID(),
	                                '{0}',
	                                QualificationID,
                                    QualificationCode,
                                    QualificationName,
                                    CertificateStyle,
                                    CertificateNo,
                                    IssuingAuthority,
                                    IssuingDate,
                                    ValidateDate,
                                    QualificationBelong,
                                    BelongID,
                                    BelongTable,
                                    BelongFieldName,
                                    CreateUserID,
                                    CreateDate,
                                    LastModifyUserID,
                                    LastModifyDate,
                                    QualificationRemark
                                FROM dbo.BFI_Qualification
                                WHERE BelongTable='{1}'
                                AND BelongID='{2}'
                            END";
            string sql = string.Format(sqlString, antiApproveID, tableName, m_id.Value);

            SqlCommand command = new SqlConnection(GlobalItem.g_DbConnectStrings).CreateCommand();
            command.CommandType = CommandType.Text;
            command.CommandText = sql;
            using (command.Connection)
            {
                try
                {
                    command.Connection.Open();
                    command.ExecuteNonQuery();
                    command.Dispose();
                }
                catch (Exception ex)
                {
                    throw ex;
                }
                finally
                {
                    if (command.Connection.State != ConnectionState.Closed)
                    {
                        command.Connection.Close();
                    }
                }
            }
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