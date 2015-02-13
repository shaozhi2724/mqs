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
using DQS.Module.Entities;
using ORMSCore;

namespace DQS.AppViews.QualityDocument.ProductManager
{
    public partial class FrmProductInfoChangeRequest : StandardForm
    {
        public FrmProductInfoChangeRequest()
        {
            InitializeComponent();
        }

        private void FrmProductInfoChangeRequest_Load(object sender, EventArgs e)
        {
            this.pageNavigator.SortField = "申请日期";
            this.pageNavigator.SortType = "DESC";
            base.InitPage();


            //#region 禁用高亮显示

            //StyleFormatCondition sfcBatchWarning = new StyleFormatCondition();
            //sfcBatchWarning.Appearance.BackColor = Color.Red;
            //sfcBatchWarning.Appearance.Options.UseBackColor = true;
            //sfcBatchWarning.ApplyToRow = true;
            //sfcBatchWarning.Column = this.gvData.Columns["状态"];
            //sfcBatchWarning.Condition = FormatConditionEnum.Equal;
            //sfcBatchWarning.Value1 = "禁用";

            //this.gvData.FormatConditions.AddRange(new DevExpress.XtraGrid.StyleFormatCondition[] { sfcBatchWarning });

            //#endregion
        }

        protected override void CustomApprove()
        {
            object id = gvData.GetFocusedRowCellValue("变更ID");
            if (id != null)
            {
                ATCAntiApproveEntity entity = new ATCAntiApproveEntity();
                entity.AntiApproveID = new Guid(id.ToString());
                entity.Fetch();
                int statusID = entity.StatusID;
                string statusName = entity.StatusName;

                if (statusID == 1)
                {
                    FrmSingleFirstProductChange doc = new FrmSingleFirstProductChange(false);
                    doc.Tag = id;
                    DialogResult dr = doc.ShowDialog(this);
                    if (dr != DialogResult.Cancel)
                    {
                        this.pageNavigator.ShowData();
                    }
                }
                else
                {
                    XtraMessageBox.Show(string.Format("此变更请求最新状态为：{0}，请不要重复操作", statusName), "错误", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                    return;
                }
            }
        }

    }
}