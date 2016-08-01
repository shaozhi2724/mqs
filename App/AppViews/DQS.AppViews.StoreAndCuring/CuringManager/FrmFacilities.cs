﻿using DevExpress.XtraEditors;
using DQS.Common;
using DQS.Controls;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace DQS.AppViews.StoreAndCuring.CuringManager
{
    public partial class FrmFacilities : StandardForm
    {
        public FrmFacilities()
        {
            InitializeComponent();
        }

        private void FrmFacilities_Load(object sender, EventArgs e)
        {
            this.pageNavigator.SortField = "设备ID";
            this.pageNavigator.SortType = "DESC";
            base.InitPage();
        }
        protected override void CustomDelete()
        {
            object id = this.gvData.GetFocusedRowCellValue("设备ID");
            if (id != null && id != DBNull.Value)
            {
                DialogResult dr = XtraMessageBox.Show("是否删除？", "提示", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (dr == DialogResult.Yes)
                {
                    DeleFacilities((int)id);
                }
            }
            this.pageNavigator.ShowData();
        }

        private void DeleFacilities(int id)
        {
            using (SqlConnection conn = new SqlConnection(GlobalItem.g_DbConnectStrings))
            {
                string sql = @"DELETE BFI_Facilities WHERE ID = {0}";
                sql = string.Format(sql,id);
                try
                {
                    conn.Open();
                    SqlCommand comm = new SqlCommand(sql, conn);
                    comm.ExecuteNonQuery();
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.ToString());
                }
                finally
                {
                    conn.Close();
                }
            }
        }
    }
}