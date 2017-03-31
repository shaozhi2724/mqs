using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using DevExpress.Utils;
using DevExpress.XtraEditors;
using DQS.Controls;
using DQS.Module.Entities;
using DQS.Common;
using ORMSCore;
using System.Data.SqlClient;

namespace DQS.AppViews.QualityDocument.ProviderManager
{
    public partial class FrmSingleProvider : DevExpress.XtraEditors.XtraForm
    {
        private int? m_id;
        List<string> operators = new List<string>();

        //string opers = "";

        public FrmSingleProvider()
        {
            InitializeComponent();
        }

        private void FrmSingleProvider_Load(object sender, EventArgs e)
        {
            //this.cbxDealerType.InitSource();

            this.cbxDealerType.Text = "客户";
            this.cbxDealerType.Enabled = false;

            this.cbxDealerStyle.InitSource();
            this.cbxIndustryStyle.InitSource();//SYSCategoryEntityFields.ItemID > 1);

            LoadOperators();

            BindArea();
            if (this.Tag != null)
            {
                this.m_id = Convert.ToInt32(this.Tag);

                BFIDealerEntity entity = new BFIDealerEntity { DealerID = m_id.Value };
                entity.Fetch();

                this.ftPanel.SetEntity(entity);

                this.txtDealerCode.Enabled = false;

                this.CustomGetEntity(entity);
            }
            RenderRequiredFields();
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

        private void btnSave_Click(object sender, EventArgs e)
        {
            if (!this.ftPanel.ValidateIsNullFields()) return;

            //if (null == cbxDealerStyle.SelectedValue)
            //{
            //    XtraMessageBox.Show(cbxDealerStyle.Properties.NullValuePrompt, "警告", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            //    cbxDealerStyle.Focus();
            //    return;
            //}
            if (null == cbxIndustryStyle.SelectedValue)
            {
                XtraMessageBox.Show(cbxIndustryStyle.Properties.NullValuePrompt, "警告", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                cbxIndustryStyle.Focus();
                return;
            }
            BFIDealerEntity entity = this.ftPanel.GetEntity() as BFIDealerEntity;
            this.CustomSetEntity(entity);

            if (this.m_id != null)
            {
                entity.LastModifyDate = DateTime.Now;
                entity.LastModifyUserID = GlobalItem.g_CurrentUser.UserID;
                entity.Update();
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
                }
                else
                {
                    XtraMessageBox.Show("往来单位编号已存在。", "警告", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
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
        protected virtual void CustomGetEntity(BFIDealerEntity entity)
        {
            //if (!entity.IsNullField("DealerType"))
            //{
            //    this.cbxDealerType.Text = entity.DealerType;
            //}

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
            }

            if (!entity.IsNullField("RegisterData") && entity.RegisterData.HasValue)
            {
                this.dteRegisterData.DateTime = entity.RegisterData.Value;
            }

            if (!entity.IsNullField("DealerStatus"))
            {
                this.cbbDealerStatus.Text = entity.DealerStatus;
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

            if (this.cbbDealerStatus.Text.Trim() != "")
            {
                entity.DealerStatus = this.cbbDealerStatus.Text.Trim();
            }

            entity.DealerArea = txtDealerArea.Text.Trim();

            //if (this.cboOperator.Text != "")
            //{
            //    entity.Reservation5 = this.cboOperator.Text;
            //}
            //else
            //{
            //    entity.Reservation5 = "";
            //}
        }

        private void cboOperator_QueryCloseUp(object sender, System.ComponentModel.CancelEventArgs e)
        {
            string txt = cboOperator.SelectedText;
            //opers = cboOperator.EditValue.ToString();

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