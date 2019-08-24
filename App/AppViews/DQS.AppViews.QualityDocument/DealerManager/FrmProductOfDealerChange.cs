using DQS.Controls;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace DQS.AppViews.QualityDocument.DealerManager
{
    public partial class FrmProductOfDealerChange : StandardForm
    {
        public FrmProductOfDealerChange()
        {
            InitializeComponent();
        }

        private void FrmProductOfDealerChange_Load(object sender, EventArgs e)
        {
            base.InitPage();
        }

        protected override void CustomApprove()
        {
            object id = this.gvData.GetFocusedRowCellValue("变更ID");
            object dealerid = this.gvData.GetFocusedRowCellValue("单位ID");
            object status = this.gvData.GetFocusedRowCellValue("状态");
            if (id != null && id != DBNull.Value)
            {
                using (FrmSingleProductOfDealerChange frm = new FrmSingleProductOfDealerChange(Convert.ToInt32(id),Convert.ToInt32(dealerid), status.ToString() == "" ? true : false))
                {
                    DialogResult dt = frm.ShowDialog();
                    if (dt == DialogResult.Yes)
                    {
                        this.pageNavigator.ShowData();
                    }
                }
            }
        }
    }
}
