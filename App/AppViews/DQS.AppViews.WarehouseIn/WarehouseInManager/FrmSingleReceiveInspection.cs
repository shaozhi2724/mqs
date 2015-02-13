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
    public partial class FrmSingleReceiveInspection : DevExpress.XtraEditors.XtraForm
    {
        public FrmSingleReceiveInspection()
        {
            InitializeComponent();
        }

        private void FrmSingleReceiveInspection_Load(object sender, EventArgs e)
        {
            DataTable data = new DataTable();
            data.Columns.Add("检验项目编号");
            data.Columns.Add("检验项目名称");
            data.Columns.Add("检验项目内容");
            data.Columns.Add("检验方式方法");
            data.Columns.Add("检验情况");
            data.Columns.Add("检验结果");
            data.Columns.Add("处理结果");
            data.Columns.Add("备注");

            gvData.PopulateColumns(data);
            gvData.OptionsView.ColumnAutoWidth = true;

            for (int i = 0; i < 100; i++)
            {
                DataRow row = data.NewRow();
                data.Rows.Add(row);
            }

            gvControl.DataSource = data;
        }

        private void gvData_CustomDrawRowIndicator(object sender, DevExpress.XtraGrid.Views.Grid.RowIndicatorCustomDrawEventArgs e)
        {
            if (e.Info.IsRowIndicator)
            {
                if (e.RowHandle >= 0)
                {
                    e.Info.DisplayText = (e.RowHandle + 1).ToString();
                }
            }
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.OK;
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}