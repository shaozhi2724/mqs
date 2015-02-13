using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using DevExpress.XtraEditors;

namespace DQS.AppViews.WarehouseIn.WarehouseInManager
{
    public partial class FrmSingleSampling : DevExpress.XtraEditors.XtraForm
    {
        private int? m_id;

        public FrmSingleSampling()
        {
            InitializeComponent();
        }

        private void FrmSingleSampling_Load(object sender, EventArgs e)
        {
            this.popupGridSampling.InitGrid();

            if (this.Tag != null)
            {
                this.m_id = Convert.ToInt32(this.Tag);

                this.popupGridSampling.SetGridData(m_id.Value, true);
            }
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}