using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using DevExpress.Utils;
using DevExpress.XtraEditors;
using DevExpress.XtraGrid.Views.Grid;
using DQS.Controls;
using DQS.Module.Entities;
using ORMSCore;
using DQS.Common;

namespace DQS.AppViews.QualityDocument.ProductManager
{
    public partial class FrmSingleFirstProduct : DevExpress.XtraEditors.XtraForm
    {
        private int? m_id;

        public FrmSingleFirstProduct()
        {
            InitializeComponent();
        }

        private void FrmSingleFirstProduct_Load(object sender, EventArgs e)
        {
            this.cbxPhysicType.InitSource();
            this.cbxStockCondition.InitSource();
            this.cbxProductStyle.InitSource();
            this.cboPurchaseTax.InitSource();
            this.cboSaleTax.InitSource();
            this.cboPurchaseTax.SelectedValue = 3;
            this.cboSaleTax.SelectedValue = 3;
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
                if (entity.BusinessStatus != 0)
                {
                    btnSave.Enabled = false;
                }
                EntityCollection<ATCApproveEntity> approveEntities = new EntityCollection<ATCApproveEntity>();
                PredicateExpression pe = new PredicateExpression();
                pe.Add(ATCApproveEntityFields.DocumentCode == "FirstProduct");
                pe.Add(ATCApproveEntityFields.BillCode == entity.ProductCode);
                pe.Add(ATCApproveEntityFields.IsApprovaled == 1);
                approveEntities.Fetch(pe);
                if (approveEntities.Count > 0)
                {
                    btnSave.Enabled = false;
                }

                BindGrantedPersons(m_id.Value);
            }
            RenderRequiredFields();
        }

        private void BindGrantedPersons(int productID)
        {
            string sql = string.Format(@"SELECT DISTINCT 
UP.UserName AS [用户名], 
E.EmployeeName AS [员工姓名],
CASE UP.IsBelong WHEN 1 THEN '归属' WHEN 2 THEN '经营' ELSE '' END AS [所属]
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
            //if (null == cbxPhysicType.SelectedValue)
            //{
            //    XtraMessageBox.Show(cbxPhysicType.Properties.NullValuePrompt, "警告", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            //    cbxPhysicType.Focus();
            //    return;
            //}
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
                entity.LastModifyDate = DateTime.Now;
                entity.LastModifyUserID = GlobalItem.g_CurrentUser.UserID;
                entity.Update();

                AddProductCycle(this.m_id.Value);
            }
            else
            {
                if (entity.IsNew())
                {
                    EntityCollection<ATCUserPageEntity> userPages = new EntityCollection<ATCUserPageEntity>();
                    PredicateExpression pe = new PredicateExpression();
                    pe.Add(ATCUserPageEntityFields.UserID == GlobalItem.g_CurrentUser.UserID);
                    pe.Add(ATCUserPageEntityFields.DocumentCode == "FirstProduct");
                    DataTable data = userPages.FetchTable(pe);

                    if (data.Rows.Count <= 0)
                    {
                        XtraMessageBox.Show("系统未设置您的审批流程，无法创建首营产品。", "警告", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                        return;
                    }


                    //按审批顺序排序
                    data.DefaultView.Sort = "ApprovalSort";
                    data = data.DefaultView.ToTable();

                    ATCApproveEntity approveEntity = new ATCApproveEntity();
                    approveEntity.InternalNo = "SYYP" + DateTime.Now.ToString("yyyyMMddHHmmss");
                    approveEntity.DocumentCode = "FirstProduct";
                    approveEntity.BillCode = entity.ProductCode;
                    approveEntity.ApproveTitle = "首营产品，编号：" + entity.ProductCode;
                    approveEntity.ApprovalContent = String.Format("首营产品 {0} 申请审批。", entity.ProductName);
                    approveEntity.CreateUserID = GlobalItem.g_CurrentUser.UserID;
                    approveEntity.CreateDate = DateTime.Now;
                    approveEntity.IsApprovaled = false;



                    entity.CreateDate = DateTime.Now;
                    entity.LastModifyDate = DateTime.Now;
                    entity.CreateUserID = GlobalItem.g_CurrentUser.UserID;
                    entity.LastModifyUserID = GlobalItem.g_CurrentUser.UserID;
                    entity.Save();

                    entity.Fetch();

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
                        notification.FormClass = "FirstProduct";
                        notification.IsRead = false;
                        notification.TargetID = entity.ProductID;
                        notification.TargetCode = entity.ProductCode;
                        notification.ApproveCode = approveCode;
                        notification.Message = string.Format("{0} 于 {1} 申请首营产品（名称 {2}）。请您审批。", userName,
                            DateTime.Now.ToString("yyyy-MM-dd HH:mm:ss"), entity.ProductName);
                        notification.OwnerUserID = approvalUserId;
                        notification.Save();
                    }
                    this.m_id = entity.ProductID;
                    AddProductCycle(this.m_id.Value);
                }
                else
                {
                    XtraMessageBox.Show("产品编号已存在。", "警告", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                    return;
                }
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
            if (this.txtProductSpell.Text.Trim() == "")
            {
                entity.ProductSpell = GlobalMethod.GetAlphabetic(txtProductName.Text.Trim());
            }
            entity.IsUseToChildren = chkBoxUseDescription.Items[0].CheckState == CheckState.Checked ? true : false;
            entity.IsUseToOldPeople = chkBoxUseDescription.Items[1].CheckState == CheckState.Checked ? true : false;
            entity.IsUseToPregnant = chkBoxUseDescription.Items[2].CheckState == CheckState.Checked ? true : false;

            entity.IsForeignDrug = cbxIsForeignDrug.Checked;
        }

        private void AddProductCycle(int productID)
        {
            if (this.cbxProductCycleStyle.SelectedValue != null)
            {

                BUSCuringCycleEntity cycle = new BUSCuringCycleEntity();
                if (cycle.IsNew(BUSCuringCycleEntityFields.ProductID == productID))
                {
                    SYSCategoryEntity cycleStyle = (SYSCategoryEntity)this.cbxProductCycleStyle.GetSelectedItem();
                    cycle.CycleCode = "YHZQ" + DateTime.Now.ToString("yyyyMMddHHmmss");
                    cycle.CycleDays = Convert.ToInt32(cycleStyle.ItemDescription);
                    cycle.ProductID = productID;
                    cycle.CreateDate = DateTime.Now;
                    cycle.LastModifyDate = DateTime.Now;
                    cycle.CreateUserID = GlobalItem.g_CurrentUser.UserID;
                    cycle.LastModifyUserID = GlobalItem.g_CurrentUser.UserID;
                    cycle.Save();
                }

            }
        }



        public void MarkChangedFieds(Guid antiApproveID)
        {
            btnSave.Visible = false;
            //chkCheck.Enabled = false;
            //ftPanel.Enabled = false;
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
            foreach (Control control in layControl2.Controls)
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