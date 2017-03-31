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
using DevExpress.XtraEditors.Controls;
using DQS.Common;

namespace DQS.AppViews.QualityDocument.ProductManager
{
    public partial class FrmSingleProduct : DevExpress.XtraEditors.XtraForm
    {
        private int? m_id;

        public FrmSingleProduct()
        {
            InitializeComponent();
        }

        private void FrmSingleProduct_Load(object sender, EventArgs e)
        {
            this.cbxProductType.InitSource();
            this.cbxPhysicType.InitSource();
            this.cbxStockCondition.InitSource();
            this.cbxProductStyle.InitSource();
            this.cboPurchaseTax.InitSource();
            this.cboSaleTax.InitSource();
            this.cbxProductCycleStyle.InitSource();
            cbxIsForeignDrug.Checked = false;
            tabGrantedPerson.PageVisible = GlobalItem.g_CurrentUser.UserCode == "admin" || GlobalItem.g_CurrentUser.UserCode == "root" ? true : false;
            if (this.Tag != null)
            {
                this.m_id = Convert.ToInt32(this.Tag);

                BFIProductEntity entity = new BFIProductEntity { ProductID = m_id.Value };
                entity.Fetch();

                this.ftPanel.SetEntity(entity);

                this.txtProductCode.Enabled = false;

                this.CustomGetEntity(entity);

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
            if (null == cbxProductType.SelectedValue)
            {
                XtraMessageBox.Show(cbxProductType.Properties.NullValuePrompt, "警告", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                cbxProductType.Focus();
                return;
            }
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
            if (null == cbbProductStatus.EditValue)
            {
                XtraMessageBox.Show(cbbProductStatus.Properties.NullValuePrompt, "警告", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                cbbProductStatus.Focus();
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
                    entity.CreateDate = DateTime.Now;
                    entity.LastModifyDate = DateTime.Now;
                    entity.CreateUserID = GlobalItem.g_CurrentUser.UserID;
                    entity.LastModifyUserID = GlobalItem.g_CurrentUser.UserID;
                    entity.Save();

                    entity.Fetch();
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
            if (!entity.IsNullField("Reservation1"))
            {
                this.cbxProductType.SelectedValue = entity.Reservation1;
            }
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

            if (!entity.IsNullField("ProductStatus"))
            {
                this.cbbProductStatus.Text = entity.ProductStatus;
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
            if (this.cbxProductType.SelectedValue != null)
            {
                entity.Reservation1 = this.cbxProductType.SelectedValue.ToString();
                entity.Reservation2 = this.cbxProductType.Text.Trim();
            }
            if (this.cbxPhysicType.SelectedValue != null)
            {
                entity.PhysicTypeID = Convert.ToInt32(this.cbxPhysicType.SelectedValue);
                entity.PhysicType = this.cbxPhysicType.Text.Trim();
            }

            if (this.cbbProductStatus.Text.Trim() != "")
            {
                entity.ProductStatus = this.cbbProductStatus.Text.Trim();
            }

            if (this.cbxProductCycleStyle.SelectedValue != null)
            {
                entity.CycleType = this.cbxProductCycleStyle.Text.Trim();
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
    }
}