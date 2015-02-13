using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Configuration;
using System.Data;
using System.Drawing;
using System.IO;
using System.Text;
using System.Windows.Forms;
using DevExpress.XtraEditors;
using DQS.Controls;
using Stimulsoft.Report;
using Stimulsoft.Report.Dictionary;

namespace DQS.AppViews.StoreAndCuring.CuringManager
{
    public partial class FrmCuringRecord : StandardForm
    {
        public FrmCuringRecord()
        {
            InitializeComponent();
        }

        private void FrmCuringRecord_Load(object sender, EventArgs e)
        {
            base.InitPage();
        }
        protected override void CustomPrint()
        {
            StiReport.ClearReportCache();
            string reportFile = Path.Combine(AppDomain.CurrentDomain.BaseDirectory, "养护记录.mrt");
            StiReport report = new StiReport();
            report.ReportFile = reportFile;
            report.Load(reportFile);
            report.Dictionary.Databases["DQS"] = new StiSqlDatabase("DQS",
                ConfigurationManager.ConnectionStrings["DbConnectStrings"].ConnectionString);
            report.Save(reportFile);
            report["药品名称"] = txtProductName.Text.Trim();
            report["生产厂商"] = txtProducerName.Text.Trim();
            report["开始日期"] = dteStart.Text;
            report["结束日期"] = dteEnd.Text;
            report["养护ID"] = gvData.GetFocusedRowCellValue("养护ID");

            string reportScriptFile = Path.Combine(AppDomain.CurrentDomain.BaseDirectory, "ReportFunction.cs");
            report.Script = string.Format("{0}\n{1}", report.Script, File.ReadAllText(reportScriptFile));

            report.Compile();
            report.Render(false);
            report.Print(true);
        }
    }
}