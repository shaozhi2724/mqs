using System;
using System.Configuration;
using System.Data;
using System.IO;
using Stimulsoft.Report;
using Stimulsoft.Report.Dictionary;

namespace DQS.Controls
{
    public partial class PrintPreviewForm : DevExpress.XtraEditors.XtraForm
    {
        private StiReport stiReport;
        public PrintPreviewForm()
        {
            InitializeComponent();

            StiReport.ClearReportCache();

            stiViewer.ApplyStyle(StiGlobalGuiStyle.Office2007Silver);
        }

        public PrintPreviewForm(string reportFile, int id):this()
        {

            stiReport = new StiReport();
            stiReport.Load(reportFile);
            
            stiReport["BillID"] = id;
            //string reportScriptFile = Path.Combine(AppDomain.CurrentDomain.BaseDirectory, "ReportFunction.cs");
            //stiReport.Script = string.Format("{0}\n{1}", stiReport.Script, File.ReadAllText(reportScriptFile));

            stiReport.Dictionary.Databases["DQS"] = new StiSqlDatabase("DQS",
                ConfigurationManager.ConnectionStrings["DbConnectStrings"].ConnectionString);
            stiReport.Save(reportFile);
            stiReport.Compile();
            stiReport.Render(false);
            stiViewer.Report = stiReport;
            this.stiViewer.Refresh();
        }
        public PrintPreviewForm(StiReport report)
            : this()
        {
            report.Compile();
            report.Render(false);
            stiViewer.Report = report;
            this.stiViewer.Refresh();
        }

        public PrintPreviewForm(string reportFile, string operationName)
            : this()
        {

            stiReport = new StiReport();
            stiReport.Load(reportFile);
            if (this.Tag != null)
            {
                stiReport["BillID"] = Convert.ToInt32(this.Tag);
            }
            stiReport.Dictionary.Databases["DQS"] = new StiSqlDatabase("DQS",
                ConfigurationManager.ConnectionStrings["DbConnectStrings"].ConnectionString);
            stiReport.Save(reportFile);
            string reportScriptFile = Path.Combine(AppDomain.CurrentDomain.BaseDirectory, "ReportFunction.cs");
            stiReport.Script = string.Format("{0}\n{1}", stiReport.Script, File.ReadAllText(reportScriptFile));

            stiReport.Compile();
            stiReport.Render(false);
            this.stiViewer.Refresh();
        }

        public PrintPreviewForm(string reportFile, DataTable dataTable)
            : this()
        {

            stiReport = new StiReport();
            stiReport.Load(reportFile);

            stiReport.Dictionary.Databases["DQS"] = new StiSqlDatabase("DQS",
                ConfigurationManager.ConnectionStrings["DbConnectStrings"].ConnectionString);
            stiReport.Save(reportFile);
            stiReport.Compile();
            stiReport.Render(false);
            this.stiViewer.Refresh();
        }

        public void Print()
        {
            stiReport.Print(true);
        }
        public void Print(StiReport report)
        {
            string reportScriptFile = Path.Combine(AppDomain.CurrentDomain.BaseDirectory, "ReportFunction.cs");
            report.Script = string.Format("{0}\n{1}", report.Script, File.ReadAllText(reportScriptFile));

            report.Compile();
            report.Render(false);
            report.Print(true);
        }
    }
}