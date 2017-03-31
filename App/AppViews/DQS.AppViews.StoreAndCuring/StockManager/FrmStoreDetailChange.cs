using DQS.Controls;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace DQS.AppViews.StoreAndCuring.StockManager
{
    public partial class FrmStoreDetailChange : StandardForm
    {
        public FrmStoreDetailChange()
        {
            InitializeComponent();
        }

        private void FrmStoreDetailChange_Load(object sender, EventArgs e)
        {
            base.InitPage();
        }

        protected override void CustomApprove()
        {
            object id = this.gvData.GetFocusedRowCellValue("更改ID");
            object status = this.gvData.GetFocusedRowCellValue("状态");
            if (id != null && id != DBNull.Value)
            {
                using (FrmSingleStoreDetailChange frm = new FrmSingleStoreDetailChange(Convert.ToInt32(id), status.ToString() == "" ? true : false))
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
