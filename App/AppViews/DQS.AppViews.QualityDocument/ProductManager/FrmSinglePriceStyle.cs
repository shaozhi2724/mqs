using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using DevExpress.XtraEditors;
using DQS.Module.Entities;
using DQS.Common;

namespace DQS.AppViews.QualityDocument.ProductManager
{
    public partial class FrmSinglePriceStyle : DevExpress.XtraEditors.XtraForm
    {
        private int? m_id;

        public FrmSinglePriceStyle()
        {
            InitializeComponent();
        }

        private void FrmSinglePriceStyle_Load(object sender, EventArgs e)
        {
            this.txtStyleID.Enabled = false;

            if (this.Tag != null)
            {
                this.m_id = Convert.ToInt32(this.Tag);
                
                SYSCategoryEntity entity = new SYSCategoryEntity { ItemID = m_id.Value, CategoryCode = "PriceStyle" };
                entity.Fetch();

                this.CustomGetEntity(entity);

            }
            else
            {
                this.txtStyleID.Text = (Convert.ToInt32(GlobalMethod.GetNewPriceID())+1)+"";
            }
        }

        private void btnSave_Click(object sender, EventArgs e)
        {

            if (this.txtStyleName.Text.Trim().Length == 0)
            {
                XtraMessageBox.Show("分类名称不能为空。", "警告", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                this.txtStyleName.Focus();
                return;
            }

            SYSCategoryEntity entity = new SYSCategoryEntity();
            this.CustomSetEntity(entity);

            if (this.m_id != null)
            {
                entity.Update();
            }
            else
            {
                if (entity.IsNew(SYSCategoryEntityFields.ItemName == this.txtStyleName.Text.Trim()))
                {
                    entity.Save();
                }
                else
                {
                    XtraMessageBox.Show("分类名称已存在。", "警告", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                    this.txtStyleName.Focus();
                    this.txtStyleName.Select(this.txtStyleName.Text.Length, 0);
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
        protected virtual void CustomGetEntity(SYSCategoryEntity entity)
        {
            if (!entity.IsNullField("ItemID"))
            {
                this.txtStyleID.Text = entity.ItemID.ToString();
            }

            if (!entity.IsNullField("ItemName"))
            {
                this.txtStyleName.Text = entity.ItemName;
            }

            if (!entity.IsNullField("ItemDescription"))
            {
                this.txtStyleDescription.Text = entity.ItemDescription;
            }

            if (!entity.IsNullField("ItemRemark"))
            {
                this.txtRemark.Text = entity.ItemRemark;
            }
        }

        /// <summary>
        /// 非文本框赋值
        /// </summary>
        /// <param name="entity">实体</param>
        protected virtual void CustomSetEntity(SYSCategoryEntity entity)
        {
            entity.CategoryCode = "PriceStyle";
            entity.CategoryName = "价格分类";
            entity.CategoryDescription = "企业经营过程中不同价格的分类。";
            entity.ItemID = Convert.ToInt32(this.txtStyleID.Text.Trim());
            entity.ItemName = this.txtStyleName.Text.Trim();
            entity.ItemSpell = GlobalMethod.GetAlphabetic(this.txtStyleName.Text.Trim());
            entity.ItemDescription = this.txtStyleDescription.Text.Trim();
            entity.ItemRemark = this.txtRemark.Text.Trim();
            entity.IsSystemItem = false;
            entity.StatusSort = entity.ItemID;
            entity.IsEffective = true;
        }
    }
}