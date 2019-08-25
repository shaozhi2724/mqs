using DevExpress.XtraEditors;
using DQS.Controls;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace DQS.AppViews.StoreAndCuring.StockManager
{
    public partial class FrmYgcgTj : StandardForm
    {
        public FrmYgcgTj()
        {
            InitializeComponent();
        }

        private void FrmYgcgTj_Load(object sender, EventArgs e)
        {
            base.InitPage();
        }
        protected override void CustomModify()
        {
            this.SaveDataLog("修改");
            object id = this.gvData.GetFocusedRowCellValue("入库ID");
            if (id != null && id != DBNull.Value)
            {
                using (FrmChangePrice cp = new FrmChangePrice(Convert.ToInt32(id),true))
                {
                    if (cp.ShowDialog(this) == DialogResult.Yes)
                    {
                        base.CustomRefresh();
                    }
                }
            }
            else
            {
                XtraMessageBox.Show("请选择调价。", "提示", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        protected override void CustomPrint()
        {
            this.SaveDataLog("打印");
            object id = this.gvData.GetFocusedRowCellValue("入库ID");
            if (id != null)
            {
                string fileName = Path.Combine(AppDomain.CurrentDomain.BaseDirectory + "阳光采购库存调价.mrt");
                if (File.Exists(fileName))
                {
                    PrintPreviewForm printPreview = new PrintPreviewForm(fileName, Convert.ToInt32(id));
                    printPreview.ShowDialog(this);
                }
                else
                {
                    XtraMessageBox.Show("找不到文件。", "系统提示", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }
            }
        }
    }
}
