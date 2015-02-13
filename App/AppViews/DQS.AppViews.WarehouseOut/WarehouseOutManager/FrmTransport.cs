using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using DevExpress.XtraEditors;
using DQS.Controls;

namespace DQS.AppViews.WarehouseOut.WarehouseOutManager
{
    public partial class FrmTransport : StandardForm
    {
        public FrmTransport()
        {
            InitializeComponent();
        }

        private void FrmTransport_Load(object sender, EventArgs e)
        {
            this.pageNavigator.SortField = "创建日期";
            this.pageNavigator.SortType = "DESC";
            base.InitPage();
            CustomGroup();
        }

        protected override void CustomModify()
        {
            base.CustomModify();

            CustomGroup();
        }

        protected override void CustomAdd()
        {
            base.CustomAdd();

            CustomGroup();
        }

        protected override void CustomExport()
        {
            base.CustomExport();

            CustomGroup();
        }

        protected override void CustomHighQuery()
        {
            base.CustomHighQuery();

            CustomGroup();
        }

        protected override void CustomRefresh()
        {
            base.CustomRefresh();

            CustomGroup();
        }

        protected override void CustomReset()
        {
            base.CustomReset();

            CustomGroup();
        }

        protected override void CustomView()
        {
            base.CustomView();

            CustomGroup();
        }

        protected override void CustomQuery()
        {
            base.CustomQuery();

            CustomGroup();
        }

        private void CustomGroup()
        {
            base.gvData.OptionsView.ShowGroupPanel = true;
            base.gvData.OptionsView.ShowGroupedColumns = true;
            base.gvData.Columns["运输单号"].GroupIndex = 0;
            base.gvData.ExpandAllGroups();
            base.gvData.BestFitColumns();
        }
    }
}