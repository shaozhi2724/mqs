using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using DevExpress.XtraBars;
using DevExpress.XtraEditors;
using DQS.Controls;
using DevExpress.XtraGrid;

namespace DQS.AppViews.QualityDocument.ProductManager
{
    public partial class FrmProductInfo : StandardForm
    {
        public FrmProductInfo()
        {
            InitializeComponent();
        }

        private void FrmProductInfo_Load(object sender, EventArgs e)
        {
           
            base.InitPage();

            #region 禁用高亮显示

            StyleFormatCondition sfcBatchWarning = new StyleFormatCondition();
            sfcBatchWarning.Appearance.BackColor = Color.Red;
            sfcBatchWarning.Appearance.Options.UseBackColor = true;
            sfcBatchWarning.ApplyToRow = true;
            sfcBatchWarning.Column = this.gvData.Columns["状态"];
            sfcBatchWarning.Condition = FormatConditionEnum.Equal;
            sfcBatchWarning.Value1 = "禁用";

            this.gvData.FormatConditions.AddRange(new DevExpress.XtraGrid.StyleFormatCondition[] { sfcBatchWarning });

            #endregion
        }

        protected override void CustomQualification()
        {
            this.SaveDataLog("电子档案");
            object id = gvData.GetFocusedRowCellValue("产品ID");
            if (id != null)
            {
                using (FrmQualification frmQualification = new FrmQualification(Convert.ToInt32(id), "BFI_Product", "ProductID", "ProductCertificate"))
                {
                    frmQualification.VisbleBarItem();
                    var barItems = toolBarPanel.barManager.Items;
                    foreach (BarItem barItem in barItems)
                    {
                        switch (barItem.Caption.Trim())
                        {
                            case "新建":
                                frmQualification.barBtnNew.Visibility = BarItemVisibility.Always;
                                frmQualification.barBtnUpAttachment.Visibility = BarItemVisibility.Always;
                                frmQualification.barDeleteAttachment.Visibility = BarItemVisibility.Always;
                                frmQualification.barBtnNewAttribute.Visibility = BarItemVisibility.Always;
                                frmQualification.barBtnDeleteAttribute.Visibility = BarItemVisibility.Always;
                                break;
                            case "修改":
                                frmQualification.barBtnModify.Visibility = BarItemVisibility.Always;

                                frmQualification.barBtnUpAttachment.Visibility = BarItemVisibility.Always;
                                frmQualification.barDeleteAttachment.Visibility = BarItemVisibility.Always;
                                frmQualification.barBtnNewAttribute.Visibility = BarItemVisibility.Always;
                                frmQualification.barBtnDeleteAttribute.Visibility = BarItemVisibility.Always;
                                break;
                            case "删除":
                                frmQualification.barBtnDelete.Visibility = BarItemVisibility.Always;
                                break;
                        }
                    }
                    frmQualification.ShowDialog();
                }
            }
            
            base.CustomQualification();
        }
    }
}