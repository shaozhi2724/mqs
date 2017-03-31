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
using DevExpress.XtraEditors.Controls;
using DevExpress.XtraGrid;
using DevExpress.XtraGrid.Views.Grid;
using DQS.Controls;
using DQS.Module.Entities;
using KellermanSoftware.CompareNetObjects;
using ORMSCore;
using DQS.Common;

namespace DQS.AppViews.QualityDocument.ProviderManager
{
    public partial class FrmSingleFirstProviderAntiApprove : DevExpress.XtraEditors.XtraForm
    {
        private int? m_id;
        List<string> operators = new List<string>();

        const string tableName = "BFI_Dealer";
        const string fieldName = "DealerID";
        const string certificateCategory = "ProviderCertificate";
        private string[] m_ImageType = new string[] { "BMP", "JPG", "GIF", "PNG", "PCX", "DCX", "EMF", "JIF", "JPE", "JFIF", "JPEG", "RLE", "DIB", "PCD", "DXF", "ICO", "WMF", "TIFF", "TGA" };

        //string opers = "";

        private Guid antiApproveID;
        public FrmSingleFirstProviderAntiApprove()
        {
            InitializeComponent();
            this.gridQualificationControl.GridViewData.FocusedRowChanged += Qualification_FocusedRowChanged;

        }

        private void FrmSingleFirstProviderAntiApprove_Load(object sender, EventArgs e)
        {
            antiApproveID = Guid.NewGuid();

            this.cbxDealerType.Text = "客户";
            this.cbxDealerType.Enabled = false;

            this.cbxDealerStyle.InitSource();
            this.cbxIndustryStyle.InitSource();//SYSCategoryEntityFields.ItemID > 1);

            LoadOperators();

            BindArea();
            BindPrices();
            if (this.Tag != null)
            {
                this.m_id = Convert.ToInt32(this.Tag);

                BFIDealerEntity entity = new BFIDealerEntity { DealerID = m_id.Value };
                entity.Fetch();

                this.ftPanel.SetEntity(entity);

                this.txtDealerCode.Enabled = false;

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
            }
            else
            {
                BindProductStyles();
            }
            RenderRequiredFields();
        }

        private void BindPrices()
        {
            EntityCollection<BFIPriceListEntity> prices = new EntityCollection<BFIPriceListEntity>();
            prices.Fetch(BFIPriceListEntityFields.PriceListType == "销售价格表" & BFIPriceListEntityFields.Active == true);
            if(prices.Count < 7)
            {
                cbxPrice.Properties.DropDownRows = prices.Count;
            }
            cbxPrice.Properties.DataSource = prices;

        }
        private void LoadOperators()
        {
            using (SqlConnection conn = new SqlConnection(GlobalItem.g_DbConnectStrings))
            {
                string sqlBill = @"SELECT EmployeeName FROM dbo.BFI_Employee WHERE PostName = '业务员'";

                SqlDataAdapter sdad = new SqlDataAdapter(sqlBill, conn);
                DataSet ds = new DataSet();
                try
                {
                    sdad.Fill(ds, "Table");
                    for (int i = 0; i < ds.Tables["Table"].Rows.Count; i++)
                    {
                        operators.Add(ds.Tables["Table"].Rows[i]["EmployeeName"].ToString());
                        cboOperator.Properties.Items.Add(ds.Tables["Table"].Rows[i]["EmployeeName"].ToString());
                    }
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
        }

        private void BindArea()
        {
            EntityCollection<BFIDealerEntity> dealers = new EntityCollection<BFIDealerEntity>();
            dealers.Fetch();

            List<string> dealerAreas =
                dealers.Cast<BFIDealerEntity>().AsQueryable<BFIDealerEntity>().Select(p => p.DealerArea).Distinct().ToList();

            EntityCollection<ATCUserAreaEntity> userAreas = new EntityCollection<ATCUserAreaEntity>();
            userAreas.Fetch();
            if (userAreas.Count > 0)
            {
                dealerAreas.AddRange(userAreas.Cast<ATCUserAreaEntity>().AsQueryable().Select(p => p.AreaName).Distinct().ToList());
            }
            List<string> areas = dealerAreas.Distinct().OrderBy(p => p).ToList();
            foreach (var dealerArea in areas)
            {
                txtDealerArea.Properties.Items.Add(dealerArea);
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
        }

        private void BindProductStyles()
        {
            chklbcProductStyle.Items.Clear();
            if (cbxIndustryStyle.Text == "医疗机构")
            {
                layBusinessRange.Text = "诊疗范围";
                layBusinessRange.CustomizationFormText = "诊疗范围";
                gpcRight.Text = "诊疗科目清单";
                EntityCollection<SYSCategoryEntity> categories = new EntityCollection<SYSCategoryEntity>();
                categories.Fetch(SYSCategoryEntityFields.CategoryCode == "MedicalSubject");

                foreach (SYSCategoryEntity c in categories)
                {
                    this.chklbcProductStyle.Items.Add(new ListEntityItem(c, c.ItemName));
                }
            }
            else
            {

                layBusinessRange.Text = "经营范围";
                layBusinessRange.CustomizationFormText = "经营范围";
                gpcRight.Text = "产品类别清单";
                EntityCollection<SYSCategoryEntity> categories = new EntityCollection<SYSCategoryEntity>();
                categories.Fetch(SYSCategoryEntityFields.CategoryCode == "ProductStyle");

                foreach (SYSCategoryEntity c in categories)
                {
                    this.chklbcProductStyle.Items.Add(new ListEntityItem(c, c.ItemName));
                }
            }

            if (null != m_id)
            {
                EntityCollection<BFIBusinessRangeEntity> ranges = new EntityCollection<BFIBusinessRangeEntity>();
                ranges.Fetch(BFIBusinessRangeEntityFields.DealerID == m_id.Value);

                if (ranges.Count > 0)
                {
                    this.chklbcProductStyle.UnCheckAll(); //先全部清空

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
            }
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            if (!this.ftPanel.ValidateIsNullFields()) return;

            //if (null == cbxDealerStyle.SelectedValue)
            //{
            //    XtraMessageBox.Show(cbxDealerStyle.Properties.NullValuePrompt, "警告", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            //    cbxDealerStyle.Focus();
            //    return;
            //}
            if (null == cbxIndustryStyle.SelectedItem)
            {
                XtraMessageBox.Show(cbxIndustryStyle.Properties.NullValuePrompt, "警告", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                cbxIndustryStyle.Focus();
                return;
            }

            if (chklbcProductStyle.CheckedItems.Count == 0)
            {
                XtraMessageBox.Show(string.Format("请选择{0}。", layBusinessRange.CustomizationFormText), "警告", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                chklbcProductStyle.Focus();
                return;
            }
            BFIDealerEntity entity = this.ftPanel.GetEntity() as BFIDealerEntity;
            this.CustomSetEntity(entity);
            List<string> businessRanges = new List<string>();
            foreach (CheckedListBoxItem productStyle in this.chklbcProductStyle.CheckedItems)
            {
                SYSCategoryEntity category = (productStyle.Value as ListEntityItem).Key as SYSCategoryEntity;
                businessRanges.Add(category.ItemName.Trim());
            }
            if (businessRanges.Any())
            {
                entity.BusinessRange = string.Join(",", businessRanges.OrderBy(p => p).ToArray());
            }
            else
            {
                entity.BusinessRange = "";
            }
            if (this.m_id != null)
            {
                BFIDealerEntity oldEntity = new BFIDealerEntity {DealerID = m_id.Value};
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

                        string displayText = layControl.GetItemByControl(field).Text;
                        string controlId = field.Name;
                        string fieldName = field.GetType().GetProperty("EntityField").GetValue(field, null).ToString();
                        needComparedFields.Add(fieldName, displayText);
                        needComparedControls.Add(fieldName, controlId);
                    }
                }
                needComparedFields.Add("RegisterData", layControl.GetItemByControl(dteRegisterData).Text);
                needComparedFields.Add("DealerStyle", layControl.GetItemByControl(cbxDealerStyle).Text);
                needComparedFields.Add("DealerArea", layControl.GetItemByControl(txtDealerArea).Text);
                needComparedFields.Add("IndustryStyle", layControl.GetItemByControl(cbxIndustryStyle).Text);
                needComparedFields.Add("BusinessRange", layControl.GetItemByControl(gpcBusinessRange).Text);
                needComparedControls.Add("RegisterData", dteRegisterData.Name);
                needComparedControls.Add("DealerStyle", cbxDealerStyle.Name);
                needComparedControls.Add("DealerArea", txtDealerArea.Name);
                needComparedControls.Add("IndustryStyle", cbxIndustryStyle.Name);
                needComparedControls.Add("BusinessRange", chklbcProductStyle.Name);
                needComparedFields.Add("SalePriceListID", layControl.GetItemByControl(cbxPrice).Text);
                needComparedControls.Add("SalePriceListID", cbxPrice.Name);
                //needComparedFields.Add("Reservation5", layControl.GetItemByControl(txtOpers).Text);
                //needComparedControls.Add("Reservation5", txtOpers.Name);

                EntityCollection<BFIBusinessRangeEntity> oldRanges = new EntityCollection<BFIBusinessRangeEntity>();
                oldRanges.Fetch(BFIBusinessRangeEntityFields.DealerID == m_id.Value);
                if (oldRanges.Count > 0)
                {
                    List<string> productStyleNames = new List<string>();
                    foreach (BFIBusinessRangeEntity oldRange in oldRanges)
                    {
                        productStyleNames.Add(oldRange.ProductStyleName.Trim());
                    }
                    oldEntity.BusinessRange = string.Join(",", productStyleNames.OrderBy(p => p).ToArray());
                }
                else
                {
                    oldEntity.BusinessRange = "";
                }
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
                        antiApproveEntity.AntiApproveTitle = string.Format("{0} 于 {1} 申请变更首营客户信息",
                            requestPerson, DateTime.Now.ToString("yyyy年M月d日 HH时m分"));
                        antiApproveEntity.DocumentCode = "FirstProvider";
                        antiApproveEntity.AntiApproveItemID = oldEntity.DealerID;
                        antiApproveEntity.AntiApproveItemCode = oldEntity.DealerCode;
                        antiApproveEntity.AntiApproveItemName = oldEntity.DealerName;
                        antiApproveEntity.CreateDate = DateTime.Now;
                        antiApproveEntity.CreateUserID = GlobalItem.g_CurrentUser.UserID;
                        antiApproveEntity.RequestPerson = requestPerson;
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
                            detail.OldValue = difference.Object1Value == "(null)" ? "" : difference.Object1Value.Trim();
                            detail.NewValue = difference.Object2Value == "(null)" ? "" : difference.Object2Value.Trim();
                            detail.FieldType = difference.Object1TypeName;

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
        protected virtual void CustomGetEntity(BFIDealerEntity entity)
        {
            this.cbxDealerType.Text = "客户";

            if (!entity.IsNullField("DealerStyle"))
            {
                this.cbxDealerStyle.Text = entity.DealerStyle;
            }
            if (!entity.IsNullField("DealerArea"))
            {
                this.txtDealerArea.Text = entity.DealerArea;
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


            if(!entity.IsNullField("SalePriceListID"))
            {
                cbxPrice.EditValue = entity.SalePriceListID;
            }

            //if (!entity.IsNullField("Reservation5"))
            //{
            //    opers = entity.Reservation5;
            //    this.cboOperator.Text = entity.Reservation5;
            //}
        }

        /// <summary>
        /// 非文本框赋值
        /// </summary>
        /// <param name="entity">实体</param>
        protected virtual void CustomSetEntity(BFIDealerEntity entity)
        {
            if (this.cbxDealerType.Text.Trim().Length > 0)
            {
                entity.DealerType = this.cbxDealerType.Text.Trim();
            }

            if (this.cbxDealerStyle.SelectedIndex >= 0)
            {
                entity.DealerStyle = this.cbxDealerStyle.Text.Trim();
            }

            if (this.cbxIndustryStyle.SelectedIndex >= 0)
            {
                entity.IndustryStyle = this.cbxIndustryStyle.Text.Trim();
            }

            if (this.dteRegisterData.Text.Trim().Length > 0)
            {
                entity.RegisterData = this.dteRegisterData.DateTime;
            }

            entity.DealerArea = txtDealerArea.Text.Trim();
            entity.SalePriceListID = Convert.ToInt32(cbxPrice.EditValue);

            //if (this.cboOperator.Text != "")
            //{
            //    entity.Reservation5 = this.cboOperator.Text;
            //}
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
                            .FirstOrDefault(p => p.Field<int>("档案ID") == (int) dataRow["QualificationID"]);

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

                view.FormatConditions.AddRange(new DevExpress.XtraGrid.StyleFormatCondition[] {sfcRequiredExpression});
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

        private void cbxIndustryStyle_SelectedIndexChanged(object sender, EventArgs e)
        {
            BindProductStyles();
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

        private void cboOperator_QueryCloseUp(object sender, System.ComponentModel.CancelEventArgs e)
        {
            string txt = cboOperator.SelectedText;

            if (txtOpers.Text == "")
            {
                txtOpers.Text = txt;
            }
            else if (!txtOpers.Text.Contains(txt))
            {
                txtOpers.Text += ("," + txt);
            }
        }

    }
}