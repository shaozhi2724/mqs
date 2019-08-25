using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using DevExpress.XtraEditors;
using DQS.Controls;
using DQS.Module.Entities;
using DQS.AppViews.QualityDocument.DealerManager;

namespace DQS.AppViews.QualityDocument.EnterpriseManager
{
    public partial class FrmDepartmentInfo : StandardForm
    {
        public FrmDepartmentInfo()
        {
            InitializeComponent();
        }

        private void FrmDepartmentInfo_Load(object sender, EventArgs e)
        {
            base.InitPage();
        }
        protected override void CustomProductForDealer()
        {
            this.SaveDataLog("关联产品");
            using (FrmProductOfDealer pod = new FrmProductOfDealer())
            {
                object id = gvData.GetFocusedRowCellValue("部门ID");
                if (id != null)
                {
                    pod.SearchID = Convert.ToInt32(id);
                    pod.frmType = "Department";
                    pod.SelectSql = "SELECT ProductID FROM BUS_DepartmentVSProduct WHERE DepartmentID = ";
                    pod.DelSql = "sp_DelDepartmentVSProduct";
                    pod.InSql = "sp_SaveDepartmentVSProduct";
                }
                pod.ShowDialog();
            }
        }

        //protected override void CustomQuery()
        //{
        //    List<string> filters = new List<string>();
        //    if (this.txtCode.Text.Trim().Length > 0)
        //    {
        //        filters.Add(String.Format("[部门编号] = '{0}' ", this.txtCode.Text.Trim()));
        //    }
        //    if (this.txtName.Text.Trim().Length > 0)
        //    {
        //        filters.Add(String.Format("[部门名称] LIKE '%{0}%' OR [部门名称Spell] LIKE '%{0}%'", this.txtName.Text.Trim()));
        //    }
        //    if (this.dteStart.Text.Trim().Length > 0)
        //    {
        //        filters.Add(String.Format("[创建日期] >= '{0} 00:00:00'", this.dteStart.Text.Trim()));
        //    }
        //    if (this.dteEnd.Text.Trim().Length > 0)
        //    {
        //        filters.Add(String.Format("[创建日期] <= '{0} 23:59:59'", this.dteEnd.Text.Trim()));
        //    }

        //    this.pageNavigator.Filter = string.Join(" AND ",filters.ToArray());
        //    this.pageNavigator.ShowData();

        //    base.CustomQuery();
        //}
    }
}