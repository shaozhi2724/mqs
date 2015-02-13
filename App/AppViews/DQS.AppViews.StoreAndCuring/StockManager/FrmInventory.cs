using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using DevExpress.XtraEditors;
using DQS.Controls;

namespace DQS.AppViews.StoreAndCuring.StockManager
{
    public partial class FrmInventory : StandardForm
    {
        public FrmInventory()
        {
            InitializeComponent();
        }

        private void FrmInventory_Load(object sender, EventArgs e)
        {
            base.InitPage();
        }
    }
}