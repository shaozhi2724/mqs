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
    public partial class FrmSingleFirstProductAntiApprove : DevExpress.XtraEditors.XtraForm
    {
        private int? m_id;

        const string tableName = "BFI_Product";
        const string fieldName = "ProductID";
        const string certificateCategory = "ProductCertificate";
        private string[] m_ImageType = new string[] { "BMP", "JPG", "GIF", "PNG", "PCX", "DCX", "EMF", "JIF", "JPE", "JFIF", "JPEG", "RLE", "DIB", "PCD", "DXF", "ICO", "WMF", "TIFF", "TGA" };
        private Guid antiApproveID;
        public FrmSingleFirstProductAntiApprove()
        {
            InitializeComponent();
            this.gridQualificationControl.GridViewData.FocusedRowChanged += Qualification_FocusedRowChanged;
        }

        private void FrmSingleFirstProductAntiApprove_Load(object sender, EventArgs e)
        {
            antiApproveID = Guid.NewGuid();
            this.cbxPhysicType.InitSource();
            this.cbxStockCondition.InitSource();
            this.cbxProductStyle.InitSource();
            this.cboPurchaseTax.InitSource();
            this.cboSaleTax.InitSource();
            this.cbxProductCycleStyle.InitSource();
            this.cbxIsForeignDrug.Checked = false;
            tabGrantedPerson.PageVisible = GlobalItem.g_CurrentUser.UserCode == "admin" || GlobalItem.g_CurrentUser.UserCode == "root" ? true : false; 
            if (this.Tag != null)
            {
                this.m_id = Convert.ToInt32(this.Tag);

                BFIProductEntity entity = new BFIProductEntity { ProductID = m_id.Value };
                entity.Fetch();

                this.ftPanel.SetEntity(entity);

                this.txtProductCode.Enabled = false;

                this.CustomGetEntity(entity);
                if (entity.BusinessStatus > 0)
                {
                    btnSave.Enabled = true;
                }
                else
                {
                    btnSave.Enabled = false;
                }
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

        private void btnSave_Click(object sender, EventArgs e)
        {
            if (!this.ftPanel.ValidateIsNullFields()) return;
            if (null == cbxPhysicType.SelectedValue)
            {
                XtraMessageBox.Show(cbxPhysicType.Properties.NullValuePrompt, "警告", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                cbxPhysicType.Focus();
                return;
            }
            if (null == cbxProductStyle.SelectedValue)
            {
                XtraMessageBox.Show(cbxProductStyle.Properties.NullValuePrompt, "警告", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                cbxProductStyle.Focus();
                return;
            }
            if (null == cboPurchaseTax.SelectedValue)
            {
                XtraMessageBox.Show(cboPurchaseTax.Properties.NullValuePrompt, "警告", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                cboPurchaseTax.Focus();
                return;
            }
            if (null == cboSaleTax.SelectedValue)
            {
                XtraMessageBox.Show(cboSaleTax.Properties.NullValuePrompt, "警告", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                cboSaleTax.Focus();
                return;
            }
            if (null == cbxStockCondition.SelectedValue)
            {
                XtraMessageBox.Show(cbxStockCondition.Properties.NullValuePrompt, "警告", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                cbxStockCondition.Focus();
                return;
            }
            if (null == cbxProductCycleStyle.SelectedValue)
            {
                XtraMessageBox.Show(cbxProductCycleStyle.Properties.NullValuePrompt, "警告", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                cbxProductCycleStyle.Focus();
                return;
            }
            BFIProductEntity entity = this.ftPanel.GetEntity() as BFIProductEntity;

            this.CustomSetEntity(entity);

            if (this.m_id != null)
            {
                BFIProductEntity oldEntity = new BFIProductEntity {ProductID = m_id.Value};
                oldEntity.Fetch();

                Dictionary<string, string> needComparedFields = new Dictionary<string, string>();
                Dictionary<string, string> needComparedControls = new Dictionary<string, string>();
                foreach (TextBoxEx field in ftPanel.TextBoxFields)
                {
                    if (field.GetType().GetProperty("EntityField") != null)
                    {
                        if (field.IsIntegerOnly && field.Text.Trim().Length == 0)
                        {
                            field.Text = "0";
                        }

                        LayoutControlItem layoutControlItem = layControl.GetItemByControl(field);
                        if (null == layoutControlItem)
                        {
                            layoutControlItem = layControl2.GetItemByControl(field);
                        }
                        string displayText = layoutControlItem.Text;
                        string controlId = field.Name;
                        string fieldName = field.GetType().GetProperty("EntityField").GetValue(field, null).ToString();
                        needComparedFields.Add(fieldName, displayText);
                        needComparedControls.Add(fieldName, controlId);
                    }
                }
                needComparedFields.Add("PhysicTypeID", layControl.GetItemByControl(cbxPhysicType).Text);
                needComparedFields.Add("ProductStyleID", layControl.GetItemByControl(cbxProductStyle).Text);
                needComparedFields.Add("PhysicType", layControl.GetItemByControl(cbxPhysicType).Text);
                needComparedFields.Add("ProductStyle", layControl.GetItemByControl(cbxProductStyle).Text);
                needComparedFields.Add("PurchaseTaxID", layControl.GetItemByControl(cboPurchaseTax).Text);
                needComparedFields.Add("PurchaseTax", layControl.GetItemByControl(cboPurchaseTax).Text);
                needComparedFields.Add("SaleTaxID", layControl.GetItemByControl(cboSaleTax).Text);
                needComparedFields.Add("SaleTax", layControl.GetItemByControl(cboSaleTax).Text);
                needComparedFields.Add("StockCondition", layControl.GetItemByControl(cbxStockCondition).Text);
                needComparedFields.Add("CycleType", layControl.GetItemByControl(cbxProductCycleStyle).Text);
                needComparedFields.Add("IsUseToChildren",
                    layControl2.GetItemByControl(chkBoxUseDescription).Text + " - " +
                    chkBoxUseDescription.Items[0].Description);
                needComparedFields.Add("IsUseToOldPeople",
                    layControl2.GetItemByControl(chkBoxUseDescription).Text + " - " +
                    chkBoxUseDescription.Items[1].Description);
                needComparedFields.Add("IsUseToPregnant",
                    layControl2.GetItemByControl(chkBoxUseDescription).Text + " - " +
                    chkBoxUseDescription.Items[2].Description);
                needComparedFields.Add("IsForeignDrug", cbxIsForeignDrug.Text);

                needComparedControls.Add("PhysicTypeID", cbxPhysicType.Name);
                needComparedControls.Add("ProductStyleID", cbxProductStyle.Name);
                needComparedControls.Add("PhysicType", cbxPhysicType.Name);
                needComparedControls.Add("ProductStyle", cbxProductStyle.Name);
                needComparedControls.Add("PurchaseTaxID", cboPurchaseTax.Name);
                needComparedControls.Add("PurchaseTax", cboPurchaseTax.Name);
                needComparedControls.Add("SaleTaxID", cboSaleTax.Name);
                needComparedControls.Add("SaleTax", cboSaleTax.Name);
                needComparedControls.Add("StockCondition", cbxStockCondition.Name);
                needComparedControls.Add("CycleType", cbxProductCycleStyle.Name);
                needComparedControls.Add("IsUseToChildren", chkBoxUseDescription.Name);
                needComparedControls.Add("IsUseToOldPeople", chkBoxUseDescription.Name);
                needComparedControls.Add("IsUseToPregnant", chkBoxUseDescription.Name);
                needComparedControls.Add("IsForeignDrug", cbxIsForeignDrug.Name);

                CompareLogic compareLogic = new CompareLogic();
                compareLogic.Config.MaxDifferences = needComparedFields.Count;
                compareLogic.Config.MembersToInclude.AddRange(needComparedFields.Keys.ToList());

                var compareResult = compareLogic.Compare(oldEntity, entity);
                bool certificateChanged = CompareAndSaveDifferences();
                if (!compareResult.AreEqual || certificateChanged)
                {
                    if (DialogResult.Yes ==
                        XtraMessageBox.Show("确定提交信息变更请求？", "确认", MessageBoxButtons.YesNo, MessageBoxIcon.Question))
                    {
                        string requestPerson = GlobalItem.g_CurrentUser.UserName;
                        if (null != GlobalItem.g_CurrentEmployee)
                        {
                            requestPerson = GlobalItem.g_CurrentEmployee.EmployeeName;
                        }

                        ATCAntiApproveEntity antiApproveEntity = new ATCAntiApproveEntity
                        {
                            AntiApproveID = antiApproveID
                        };
                        antiApproveEntity.AntiApproveTitle = string.Format("{0} 于 {1} 申请变更首营产品信息",
                            requestPerson, DateTime.Now.ToString("yyyy年M月d日 HH时m分"));
                        antiApproveEntity.DocumentCode = "FirstProduct";
                        antiApproveEntity.AntiApproveItemID = oldEntity.ProductID;
                        antiApproveEntity.AntiApproveItemCode = oldEntity.ProductCode;
                        antiApproveEntity.AntiApproveItemName = oldEntity.ProductName;
                        antiApproveEntity.RequestPerson = requestPerson;
                        antiApproveEntity.CreateDate = DateTime.Now;
                        antiApproveEntity.CreateUserID = GlobalItem.g_CurrentUser.UserID;
                        antiApproveEntity.StatusID = 1;
                        antiApproveEntity.StatusName = "申请变更";

                        antiApproveEntity.Save();

                        foreach (Difference difference in compareResult.Differences)
                        {
                            string propertyName = difference.PropertyName.Substring(1);
                            //resultString.AppendFormat("修改了{0}({1}) - 原值： {2}，新值： {3}\n",
                            //    needComparedFields[propertyName],
                            //    propertyName,
                            //    difference.Object1Value,
                            //    difference.Object2Value);
                            ATCAntiApproveDetailEntity detail = new ATCAntiApproveDetailEntity();
                            detail.AntiApproveID = antiApproveID;
                            detail.ControlName = needComparedControls[propertyName];
                            detail.DisplayText = needComparedFields[propertyName];
                            detail.FieldName = propertyName;
                            detail.FieldType = difference.Object1TypeName;
                            if (detail.FieldType == "Boolean")
                            {
                                detail.OldValue = difference.Object1Value == "(null)"
                                    ? ""
                                    : difference.Object1Value.Trim() == "True" ? "是" : "否";
                                detail.NewValue = difference.Object2Value == "(null)"
                                    ? ""
                                    : difference.Object2Value.Trim() == "True" ? "是" : "否";
                            }
                            else
                            {
                                detail.OldValue = difference.Object1Value == "(null)"
                                    ? ""
                                    : difference.Object1Value.Trim();
                                detail.NewValue = difference.Object2Value == "(null)"
                                    ? ""
                                    : difference.Object2Value.Trim();
                            }

                            detail.Save();
                        }
                        this.DialogResult = DialogResult.OK;
                    }
                }
                else
                {
                    XtraMessageBox.Show("未检测到任何修改，不会生成信息变更请求。", "警告", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                    return;
                }
            }
        }

        private bool CompareAndSaveDifferences()
        {
            bool certificateChanged = false;
            //获取电子档案旧数据
            var filter = string.Format("所属ID = {0} AND 所属表ID = '{1}' AND 所属列名ID = '{2}'", m_id.Value, tableName, fieldName);
            DataTable oldCertificates = GlobalMethod.GetViewData(gridQualificationControl.ViewName, filter);
            //获取修改后的电子档案数据
            EntityCollection<ATCAntiApproveQualificationDetailEntity> changes = new EntityCollection<ATCAntiApproveQualificationDetailEntity>();
            DataTable changedData = changes.FetchTable(ATCAntiApproveQualificationDetailEntityFields.AntiApproveID == antiApproveID
                & ATCAntiApproveQualificationDetailEntityFields.BelongTable == tableName
                & ATCAntiApproveQualificationDetailEntityFields.BelongFieldName == fieldName
                & ATCAntiApproveQualificationDetailEntityFields.BelongID == m_id.Value);

            DataTable newCertificates = oldCertificates.Clone();
            foreach (DataRow dataRow in changedData.Rows)
            {
                DataRow oldRow =
                    oldCertificates.AsEnumerable()
                        .FirstOrDefault(p => p.Field<int>("档案ID") == (int)dataRow["QualificationID"]);

                DataRow newRow = newCertificates.NewRow();
                newRow["档案ID"] = dataRow["QualificationID"];
                newRow["档案编号"] = dataRow["QualificationCode"];
                newRow["档案名称"] = dataRow["QualificationName"];
                newRow["证书类型"] = dataRow["CertificateStyle"];
                newRow["证书编号"] = dataRow["CertificateNo"];
                newRow["发证机关"] = dataRow["IssuingAuthority"];
                newRow["发证日期"] = dataRow["IssuingDate"];
                newRow["到期日期"] = dataRow["ValidateDate"];
                newRow["备注"] = dataRow["QualificationRemark"];
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
                newRow["所属ID"] = oldRow["所属ID"];
                newRow["所属表ID"] = oldRow["所属表ID"];
                newRow["所属列名ID"] = oldRow["所属列名ID"];
                newCertificates.Rows.Add(newRow);
            }
            newCertificates.AcceptChanges();

            DataView dvNew = newCertificates.DefaultView;
            dvNew.Sort = "档案ID ASC";
            DataTable sortedNewCertificates = dvNew.ToTable();

            DataView dvOld = oldCertificates.DefaultView;
            dvOld.Sort = "档案ID ASC";
            DataTable sortedOldCertificates = dvOld.ToTable();

            //比较
            List<string> columns = new List<string>();
            foreach (DataColumn column in newCertificates.Columns)
            {
                columns.Add(column.ColumnName);
            }
            List<CertificateModel> newCertificateModels = sortedNewCertificates.ToList<CertificateModel>();
            List<CertificateModel> oldCertificateModels = sortedOldCertificates.ToList<CertificateModel>();
            foreach (CertificateModel newCertificate in newCertificateModels)
            {
                var oldCertificate = oldCertificateModels.FirstOrDefault(p => p.档案ID == newCertificate.档案ID);
                CompareLogic compareLogic = new CompareLogic();
                compareLogic.Config.MaxDifferences = newCertificates.Columns.Count;
                //compareLogic.Config.MembersToInclude.AddRange(columns);
                var compareResult = compareLogic.Compare(oldCertificate, newCertificate);
                if (!compareResult.AreEqual)
                {
                    certificateChanged = true;
                }
                StringBuilder resultString = new StringBuilder("修改:\n");
                foreach (Difference difference in compareResult.Differences)
                {
                    string propertyName = difference.PropertyName.Replace("[0].", "").TrimStart('.');
                    if ((difference.Object1Value == "(null)" && string.IsNullOrWhiteSpace(difference.Object2Value))
                        || (difference.Object2Value == "(null)" && string.IsNullOrWhiteSpace(difference.Object1Value)))
                    {
                        continue;
                    }
                    resultString.AppendFormat("{0} - 旧值： {1}，新值： {2}\n",
                        propertyName,
                        difference.Object1Value == "(null)"
                            ? ""
                            : (propertyName.EndsWith("日期")
                                ? DateTime.Parse(difference.Object1Value.Trim()).ToString("yyyy年M月d日")
                                : difference.Object1Value.Trim()),
                        difference.Object2Value == "(null)"
                            ? ""
                            : (propertyName.EndsWith("日期")
                                ? DateTime.Parse(difference.Object2Value.Trim()).ToString("yyyy年M月d日")
                                : difference.Object2Value.Trim()));
                }
                //保存比较结果至ActionRemark
                if (!compareResult.AreEqual)
                {
                    ATCAntiApproveQualificationActionEntity actionEntity = new ATCAntiApproveQualificationActionEntity();
                    actionEntity.ActionID = Guid.NewGuid();
                    actionEntity.AntiApproveID = antiApproveID;
                    actionEntity.BelongID = m_id.Value;
                    actionEntity.QualificationBelong = tableName;
                    actionEntity.QualificationID = m_id.Value;
                    actionEntity.QualificationName = newCertificate.档案名称;
                    actionEntity.QualificationCode = newCertificate.档案编号;
                    actionEntity.Action = 2;
                    actionEntity.ActionRemark = resultString.ToString();
                    actionEntity.CreateUserID = GlobalItem.g_CurrentUser.UserID;
                    actionEntity.CreateDate = DateTime.Now;
                    actionEntity.Save();
                }
            }
            return certificateChanged;
        }
        private void btnCancel_Click(object sender, EventArgs e)
        {
            if (System.Windows.Forms.DialogResult.Yes ==
                XtraMessageBox.Show("如果取消，将不保存结果，确定取消？", "警告", MessageBoxButtons.YesNo, MessageBoxIcon.Exclamation))
            {
                DeleteTempData();
                this.DialogResult = DialogResult.Cancel;

            }
            else
            {
                this.DialogResult = DialogResult.None;
            }
        }

        private void DeleteTempData()
        {
            string sql = string.Format("DELETE ATC_AntiApproveQualificationAction WHERE AntiApproveID='{0}'\nDELETE ATC_AntiApproveQualificationDetail WHERE AntiApproveID='{0}'", antiApproveID);

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

            if (!entity.IsNullField("PurchaseTaxID"))
            {
                this.cboPurchaseTax.SelectedValue = entity.PurchaseTaxID;
            }

            if (!entity.IsNullField("SaleTaxID"))
            {
                this.cboSaleTax.SelectedValue = entity.SaleTaxID;
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

        /// <summary>
        /// 非文本框赋值
        /// </summary>
        /// <param name="entity">实体</param>
        protected virtual void CustomSetEntity(BFIProductEntity entity)
        {
            if (this.cbxPhysicType.SelectedValue != null)
            {
                entity.PhysicTypeID = Convert.ToInt32(this.cbxPhysicType.SelectedValue);
                entity.PhysicType = this.cbxPhysicType.Text.Trim();
            }

            entity.StockCondition = this.cbxStockCondition.Text.Trim();

            if (this.cbxProductStyle.SelectedValue != null)
            {
                entity.ProductStyleID = Convert.ToInt32(this.cbxProductStyle.SelectedValue);
                entity.ProductStyle = this.cbxProductStyle.Text.Trim();
            }
            if (this.cboPurchaseTax.SelectedValue != null)
            {
                entity.PurchaseTaxID = Convert.ToInt32(this.cboPurchaseTax.SelectedValue);
                entity.PurchaseTax = this.cboPurchaseTax.Text.Trim();
            }
            if (this.cboSaleTax.SelectedValue != null)
            {
                entity.SaleTaxID = Convert.ToInt32(this.cboSaleTax.SelectedValue);
                entity.SaleTax = this.cboSaleTax.Text.Trim();
            }
            if (this.cbxProductCycleStyle.SelectedValue != null)
            {
                entity.CycleType = this.cbxProductCycleStyle.Text;
            }
            entity.IsUseToChildren = chkBoxUseDescription.Items[0].CheckState == CheckState.Checked ? true : false;
            entity.IsUseToOldPeople = chkBoxUseDescription.Items[1].CheckState == CheckState.Checked ? true : false;
            entity.IsUseToPregnant = chkBoxUseDescription.Items[2].CheckState == CheckState.Checked ? true : false;

            entity.IsForeignDrug = cbxIsForeignDrug.Checked;
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
                if (tableName == "BFI_Product")
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
                    if (null != oldRow)
                    {
                        if (oldRow["创建人"] != DBNull.Value)
                        {
                            newRow["创建人"] = oldRow["创建人"];
                        }
                        newRow["创建日期"] = oldRow["创建日期"];
                        newRow["最后修改人"] = oldRow["最后修改人"];
                        newRow["修改时间"] = oldRow["修改时间"];
                        newRow["备注"] = oldRow["备注"];
                        newRow["所属ID"] = oldRow["所属ID"];
                        newRow["所属表ID"] = oldRow["所属表ID"];
                        newRow["所属列名ID"] = oldRow["所属列名ID"];
                        records.Rows.Add(newRow);
                    }
                }
                records.AcceptChanges();
                DataView dv = records.DefaultView;
                dv.Sort = "到期日期 ASC, 档案编号 ASC";
                DataTable sortedDT = dv.ToTable();

                gridQualificationControl.DataSource = sortedDT;
                gridQualificationControl.Filter = filter;
                gridQualificationControl.PopulateGridColumns(sortedDT);
                gridQualificationControl.RefreshGrid();
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
                view.RefreshData();
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

        private void barBtnNew_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            using (FrmQualificationChange frmSingleQualification = new FrmQualificationChange(antiApproveID, m_id.Value, tableName, fieldName, certificateCategory))
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
            using (FrmQualificationChange frmSingleQualification = new FrmQualificationChange(antiApproveID, m_id.Value, tableName, fieldName, certificateCategory))
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
                string qualificationName = this.gridQualificationControl.GridViewData.GetFocusedRowCellValue("档案名称").ToString();
                string certificate = this.gridQualificationControl.GridViewData.GetFocusedRowCellValue("证书类型").ToString();
                bool isDefaultQuatificate = code.Length == 20 && code.EndsWith("D");
                //if (this.m_TableName == "BFI_Product")
                //{
                //    isDefaultQuatificate = isDefaultQuatificate && _defaultProductCertifications.ContainsKey(certificate);
                //}
                if (!DQS.Controls.Properties.Settings.Default.IsDelDefault && isDefaultQuatificate)
                {
                    XtraMessageBox.Show("该证书不允许删除", "警告", MessageBoxButtons.OKCancel, MessageBoxIcon.Warning);
                    return;
                }
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

                    ATCAntiApproveQualificationActionEntity actionEntity = new ATCAntiApproveQualificationActionEntity();
                    actionEntity.ActionID = Guid.NewGuid();
                    actionEntity.AntiApproveID = antiApproveID;
                    actionEntity.BelongID = m_id.Value;
                    actionEntity.QualificationBelong = tableName;
                    actionEntity.QualificationID = attachment.QualificationID;
                    actionEntity.QualificationName = certificate;
                    actionEntity.QualificationCode = code;
                    actionEntity.Action = 3;
                    actionEntity.ActionRemark = string.Format("删除证书及连带附件和属性信息");
                    actionEntity.CreateUserID = GlobalItem.g_CurrentUser.UserID;
                    actionEntity.CreateDate = DateTime.Now;
                    actionEntity.Save();

                    BindQualification();
                    BindAttachment();
                }
            }
        }

        private void barBtnUpAttachment_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            object id = this.gridQualificationControl.GridViewData.GetFocusedRowCellValue("档案ID");
            object qualificationName = this.gridQualificationControl.GridViewData.GetFocusedRowCellValue("档案名称");
            object qualificationCode = this.gridQualificationControl.GridViewData.GetFocusedRowCellValue("档案编号");
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
                        attchment.CreateDate = DateTime.Now;
                        attchment.CreateUserID = GlobalItem.g_CurrentUser.UserID;
                        attchment.QualificationID = Convert.ToInt32(id);

                        attchment.AttachmentContent = File.ReadAllBytes(fullName);

                        using (FrmProgressing frmProgressing = new FrmProgressing(attchment))
                        {
                            frmProgressing.ShowDialog(this);

                            this.BindAttachment();
                        }

                        ATCAntiApproveQualificationActionEntity actionEntity = new ATCAntiApproveQualificationActionEntity();
                        actionEntity.ActionID = Guid.NewGuid();
                        actionEntity.AntiApproveID = antiApproveID;
                        actionEntity.BelongID = m_id.Value;
                        actionEntity.QualificationBelong = tableName;
                        actionEntity.QualificationID = attchment.QualificationID;
                        actionEntity.QualificationName = qualificationName.ToString();
                        actionEntity.QualificationCode = qualificationCode.ToString();
                        actionEntity.Action = 4;
                        actionEntity.ActionRemark = string.Format("修改:\n上传附件: {0}", attchment.AttachmentName);
                        actionEntity.CreateUserID = GlobalItem.g_CurrentUser.UserID;
                        actionEntity.CreateDate = DateTime.Now;
                        actionEntity.Save();
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
            object qualificationName = this.gridQualificationControl.GridViewData.GetFocusedRowCellValue("档案名称");
            object qualificationCode = this.gridQualificationControl.GridViewData.GetFocusedRowCellValue("档案编号");
            object id = this.gridAttachmentControl.GridViewData.GetFocusedRowCellValue("附件ID");
            object attachmentName = this.gridAttachmentControl.GridViewData.GetFocusedRowCellValue("附件名称");
            object uploadPerson = this.gridAttachmentControl.GridViewData.GetFocusedRowCellValue("上传人");
            object uploadDate = this.gridAttachmentControl.GridViewData.GetFocusedRowCellValue("上传日期");
            if (id != null)
            {
                DialogResult result = XtraMessageBox.Show("确定要删除该附件吗？", "警告", MessageBoxButtons.OKCancel, MessageBoxIcon.Question);
                if (result == DialogResult.OK)
                {
                    ATCAntiApproveQualificationActionEntity actionEntity = new ATCAntiApproveQualificationActionEntity();
                    actionEntity.ActionID = Guid.NewGuid();
                    actionEntity.AntiApproveID = antiApproveID;
                    actionEntity.BelongID = m_id.Value;
                    actionEntity.QualificationBelong = tableName;
                    actionEntity.QualificationID = int.Parse(gridQualificationControl.GridViewData.GetFocusedRowCellValue("档案ID").ToString());
                    actionEntity.QualificationName = qualificationName.ToString();
                    actionEntity.QualificationCode = qualificationCode.ToString();
                    actionEntity.Action = 5;
                    actionEntity.ActionRemark = string.Format("修改: \n删除了“{0}”于 {1} 上传的附件: {2}", uploadPerson.ToString(), ((DateTime)uploadDate).ToString("yyyy年M月d日"), attachmentName.ToString());
                    actionEntity.CreateUserID = GlobalItem.g_CurrentUser.UserID;
                    actionEntity.CreateDate = DateTime.Now;
                    actionEntity.Save();

                    BFIQualificationAttachmentEntity entity = new BFIQualificationAttachmentEntity { AttachmentID = Convert.ToInt32(id) };
                    //删除
                    entity.Delete();

                    this.gridAttachmentControl.InitGrid();
                }
            }
            else
            {
                XtraMessageBox.Show("请选中要删除的附件。", "系统提示", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        //选中行发生变化,重新加载附件和属性
        private void Qualification_FocusedRowChanged(object sender, DevExpress.XtraGrid.Views.Base.FocusedRowChangedEventArgs e)
        {
            this.BindAttachment();
        }
        #endregion
    }
}