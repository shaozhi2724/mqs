﻿using DevExpress.XtraEditors;
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
    public partial class FrmSingleFacilitiesService : StandardForm
    {
        public FrmSingleFacilitiesService()
        {
            InitializeComponent();
        }

        private void FrmSingleFacilitiesService_Load(object sender, EventArgs e)
        {
            base.InitPage();
        }

        protected override void CustomModify()
        {
            this.SaveDataLog("修改");
            object id = this.gvData.GetFocusedRowCellValue("维修ID");
            object fid = this.gvData.GetFocusedRowCellValue("设备ID");
            if (id != null && id != DBNull.Value)
            {
                using (FrmFacilitiesService verification = new FrmFacilitiesService(Convert.ToInt32(id), Convert.ToInt32(fid)))
                {
                    if (verification.ShowDialog(this) == DialogResult.OK)
                    {
                        base.CustomRefresh();
                    }
                }
            }
            else
            {
                XtraMessageBox.Show("请选择设备。", "提示", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }
    }
}
