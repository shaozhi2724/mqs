using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace DQS.AppViews.Operation.PurchaseAndSaleManager
{
    public partial class FrmError : Form
    {
        string _error;
        public FrmError()
        {
            InitializeComponent();
        }
        public FrmError(string error)
        {
            _error = error;
            InitializeComponent();
        }

        private void FrmError_Load(object sender, EventArgs e)
        {
            text.Text = _error;
        }
    }
}
