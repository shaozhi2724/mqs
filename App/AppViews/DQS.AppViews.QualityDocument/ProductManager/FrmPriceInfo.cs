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
    public partial class FrmPriceInfo : StandardForm
    {
        public FrmPriceInfo()
        {
            InitializeComponent();
        }

        private void FrmPriceInfo_Load(object sender, EventArgs e)
        {
            base.InitPage();
        }

        protected override void CustomAdd()
        {
            this.SaveDataLog("新建");
            using (FrmSinglePrice2 frmSinglePrice = new FrmSinglePrice2())
            {
                if (frmSinglePrice.ShowDialog(this) == DialogResult.OK)
                { 
                    base.CustomRefresh();
                }
            }
        }

        protected override void CustomModify()
        {
            this.SaveDataLog("修改");
            object productID = gvData.GetFocusedRowCellValue("产品ID");
            if (productID != null)
            {
                using (FrmSinglePrice2 frmSinglePrice = new FrmSinglePrice2(Convert.ToInt32(productID)))
                {
                    if (frmSinglePrice.ShowDialog(this) == DialogResult.OK)
                    {
                        base.CustomRefresh();
                    }
                }
            }
        }
        protected override void CustomModify(bool isView)
        {
            this.SaveDataLog("修改");
            object productID = gvData.GetFocusedRowCellValue("产品ID");
            if (productID != null)
            {
                using (FrmSinglePrice2 frmSinglePrice = new FrmSinglePrice2(Convert.ToInt32(productID)))
                {
                    if (frmSinglePrice.ShowDialog(this) == DialogResult.OK)
                    {
                        base.CustomRefresh();
                    }
                }
            }
        }

        protected override void CustomDelete()
        {
            this.SaveDataLog("删除");
            object productID = gvData.GetFocusedRowCellValue("产品ID");
            if (productID != null)
            {
                DialogResult result = XtraMessageBox.Show("确定要删除该产品的所有价格信息吗？", "警告", MessageBoxButtons.OKCancel, MessageBoxIcon.Question);
                if (result == DialogResult.OK)
                {
                    BFIProductPriceEntity entity = new BFIProductPriceEntity { ProductID = Convert.ToInt32(productID) };
                    entity.DeleteByCommonly();

                    //刷新
                    base.CustomRefresh();
                }
            }
        }
    }
}