using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using DevExpress.XtraEditors;
using DevExpress.XtraTab;
using DQS.Common;
using DQS.Controls;
using DevExpress.XtraGrid.Views.Grid;
using DevExpress.XtraGrid;

namespace DQS.App
{
    public partial class FrmWarningShow : DevExpress.XtraEditors.XtraForm
    {
        private DataSet m_DataSet;

        public FrmWarningShow(DataSet ds)
        {
            InitializeComponent();
            this.m_DataSet = GlobalMethod.GetWarningData();
        }

        private void FrmWarningShow_Load(object sender, EventArgs e)
        {
            foreach (XtraTabPage page in this.xtcMain.TabPages)
            {
                page.PageVisible = false;
                string pageTitle = page.Text;
                DataTable data = this.m_DataSet.Tables[pageTitle];
                if (data != null)
                {
                    if (data.Rows.Count > 0)
                    {
                        this.BindingData(page, data);
                        page.PageVisible = true;
                    }
                }

            }
        }

        protected void BindingData(Control container, DataTable data)
        {
            foreach (Control c in container.Controls)
            {
                if (c.HasChildren)
                {
                    this.BindingData(c,data);
                }
                if (c is StandardGrid)
                {
                    (c as StandardGrid).DataSource = data;

                    #region 过期高亮显示
                    GridView grid = (c as StandardGrid).GridViewData as GridView;
                    StyleFormatCondition sfcBatchWarning = new StyleFormatCondition();
                    sfcBatchWarning.Appearance.BackColor = Color.Yellow;
                    sfcBatchWarning.Appearance.Options.UseBackColor = true;
                    sfcBatchWarning.ApplyToRow = false;
                    sfcBatchWarning.Column = grid.Columns["过期状态"];
                    sfcBatchWarning.Condition = FormatConditionEnum.Equal;
                    sfcBatchWarning.Value1 = "即将过期";

                    StyleFormatCondition sfcLockWarning = new StyleFormatCondition();
                    sfcLockWarning.Appearance.BackColor = Color.Red;
                    sfcLockWarning.Appearance.Options.UseBackColor = true;
                    sfcLockWarning.ApplyToRow = false;
                    sfcLockWarning.Column = grid.Columns["锁定状态"];
                    sfcLockWarning.Condition = FormatConditionEnum.Equal;
                    sfcLockWarning.Value1 = "已锁定";

                    StyleFormatCondition sfcBatchLose = new StyleFormatCondition();
                    sfcBatchLose.Appearance.BackColor = Color.Red;
                    sfcBatchLose.Appearance.Options.UseBackColor = true;
                    sfcBatchLose.ApplyToRow = false;
                    sfcBatchLose.Column = grid.Columns["过期状态"];
                    sfcBatchLose.Condition = FormatConditionEnum.Equal;
                    sfcBatchLose.Value1 = "已过期";

                    grid.FormatConditions.AddRange(new StyleFormatCondition[] { sfcBatchWarning, sfcLockWarning, sfcBatchLose });
                    #endregion

                }
            }
        }

        private void btnExport_Click(object sender, EventArgs e)
        {
            GridControl gc = new GridControl();

            string name = "";

            foreach (XtraTabPage page in this.xtcMain.TabPages)
            {
                if (page.Focus())
                {
                    name = page.Text;
                    foreach (Control c in page.Controls)
                    {
                        if (c is StandardGrid)
                        {
                            gc = (GridControl)c;
                        }
                    }
                }
            }


            SaveFileDialog saveFileDialog = new SaveFileDialog();

            saveFileDialog.Title = "导出Excel";

            saveFileDialog.FileName = name;

            saveFileDialog.Filter = "Excel文件(*.xls)|*.xls";

            DialogResult dialogResult = saveFileDialog.ShowDialog(this);

            if (dialogResult == DialogResult.OK)
            {

                DevExpress.XtraPrinting.XlsExportOptions options = new DevExpress.XtraPrinting.XlsExportOptions();

                //gridControl1.ExportToXls(saveFileDialog.FileName, options);  

                //gridControl.ExportToExcelOld(saveFileDialog.FileName);

                gc.ExportToXls(saveFileDialog.FileName);

                DevExpress.XtraEditors.XtraMessageBox.Show("保存成功！", "提示", MessageBoxButtons.OK, MessageBoxIcon.Information);

            }  
        }

    }
}