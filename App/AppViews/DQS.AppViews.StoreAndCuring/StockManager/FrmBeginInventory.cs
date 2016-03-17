using DevExpress.XtraEditors;
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
    public partial class FrmBeginInventory : StandardForm
    {
        public FrmBeginInventory()
        {
            InitializeComponent();
        }
        
        private void FrmBeginInventory_Load(object sender, EventArgs e)
        {
            base.InitPage();
        }

        protected override void CustomAdd()
        {
            object id = this.gvData.GetFocusedRowCellValue("产品ID");
            if (id != null && id != DBNull.Value)
            {
                XtraMessageBox.Show("期初不能新增、修改、删除", "系统提示", MessageBoxButtons.OK, MessageBoxIcon.Stop);
                return;
                //base.CustomAdd();
            }
            base.CustomAdd();
        }
    }
}
