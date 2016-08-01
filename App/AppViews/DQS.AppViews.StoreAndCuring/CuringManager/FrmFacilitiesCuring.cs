using DQS.Controls;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace DQS.AppViews.StoreAndCuring.CuringManager
{
    public partial class FrmFacilitiesCuring : StandardForm
    {
        public FrmFacilitiesCuring()
        {
            InitializeComponent();
        }

        private void FrmFacilitiesCuring_Load(object sender, EventArgs e)
        {
            this.pageNavigator.SortField = "设备ID";
            this.pageNavigator.SortType = "DESC";
            base.InitPage();
        }
    }
}
