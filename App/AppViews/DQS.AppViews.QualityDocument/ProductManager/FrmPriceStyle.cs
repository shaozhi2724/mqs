using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using DevExpress.XtraEditors;
using DQS.Controls;
using DQS.Module.Entities;

namespace DQS.AppViews.QualityDocument.ProductManager
{
    public partial class FrmPriceStyle : StandardForm
    {
        public FrmPriceStyle()
        {
            InitializeComponent();
        }

        private void FrmPriceStyle_Load(object sender, EventArgs e)
        {
            base.InitPage();
        }

        protected override void CustomModify()
        {
            object itemType = gvData.GetFocusedRowCellValue("分类类型");
            if (itemType != null)
            {
                if (itemType.ToString() == "系统")
                {
                    XtraMessageBox.Show("系统分类无法编辑。", "警告", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                    return;
                }
                else
                {
                    base.CustomModify();
                }
            }
        }

        protected override void CustomDelete()
        {
            object itemType = gvData.GetFocusedRowCellValue("分类类型");
            if (itemType != null)
            {
                if (itemType.ToString() == "系统")
                {
                    XtraMessageBox.Show("系统分类无法删除。", "警告", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                    return;
                }
                else
                {
                    DialogResult result = XtraMessageBox.Show("确定要删除该信息吗？", "警告", MessageBoxButtons.OKCancel, MessageBoxIcon.Question);
                    if (result == DialogResult.OK)
                    {
                        SYSCategoryEntity entity = new SYSCategoryEntity();
                        object itemID = gvData.GetFocusedRowCellValue("分类ID");
                        if (itemID != null)
                        {
                            entity.ItemID = Convert.ToInt32(itemID);
                            entity.CategoryCode = "PriceStyle";
                            entity.Delete();

                            //刷新
                            base.CustomRefresh();
                        }
                    }
                }
            }
        }

        private void txtPriceStyleName_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)13)
            {
                base.CustomQuery();
            }
        }
    }
}