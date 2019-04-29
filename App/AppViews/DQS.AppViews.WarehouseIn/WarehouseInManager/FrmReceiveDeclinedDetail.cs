using DevExpress.XtraEditors;
using DQS.Module.Entities;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace DQS.AppViews.WarehouseIn.WarehouseInManager
{
    public partial class FrmReceiveDeclinedDetail : XtraForm
    {
        public FrmReceiveDeclinedDetail()
        {
            InitializeComponent();
        }

        public int _productid;
        public String batchno;

        public FrmReceiveDeclinedDetail(int productid)
        {
            _productid = productid;
            InitializeComponent();
        }

        private void btnOK_Click(object sender, EventArgs e)
        {
            if (txtbatchno.Text == "")
            {
                MessageBox.Show("批号必填");
                return;
            }
            batchno = txtbatchno.Text;
            this.DialogResult = DialogResult.OK;
        }

        private void FrmReceiveDeclinedDetail_Load(object sender, EventArgs e)
        {
            BFIProductEntity entity = new BFIProductEntity { ProductID = _productid };
            entity.Fetch();
            lblinfo.Text = "请填写品种:"+entity.ProductName+" 拒收的批号:";
        }
    }
}
