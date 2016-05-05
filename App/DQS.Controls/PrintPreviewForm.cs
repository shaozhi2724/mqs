using System;
using System.Configuration;
using System.Data;
using System.IO;
using Stimulsoft.Report;
using Stimulsoft.Report.Dictionary;
using System.Data.SqlClient;
using DQS.Common;

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
            string rf = reportFile.Substring(reportFile.Length - 7, 3);
            if (rf == "销售单")
            {
                if (stiReport.Pages.Count >= 3)
                {
                    stiReport.Pages[1].Enabled = CheckCludeStrMa(id);
                    stiReport.Pages[2].Enabled = CheckCludeStrLeng(id);
                }
            }

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

        private bool CheckCludeStrMa(int BillID)
        {
            string sql = "EXEC sp_IncludeStrMa {0}";
            sql = string.Format(sql, BillID);
            using (SqlConnection conn = new SqlConnection(GlobalItem.g_DbConnectStrings))
            {
                conn.Open(); //连接数据库
                //必须为SqlCommand指定数据库连接和登记的事务
                SqlCommand cmd = new SqlCommand(sql, conn);
                try
                {
                    int returnValue = Convert.ToInt32(cmd.ExecuteScalar());
                    if (returnValue == 0)
                    {
                        return false;
                    }
                }
                catch (Exception ex)
                {

                }
                finally
                {
                    conn.Close();
                }
            }
            return true;
        }

        private bool CheckCludeStrLeng(int BillID)
        {
            string sql = "EXEC sp_IncludeStrLeng {0}";
            sql = string.Format(sql, BillID);
            using (SqlConnection conn = new SqlConnection(GlobalItem.g_DbConnectStrings))
            {
                conn.Open(); //连接数据库
                //必须为SqlCommand指定数据库连接和登记的事务
                SqlCommand cmd = new SqlCommand(sql, conn);
                try
                {
                    int returnValue = Convert.ToInt32(cmd.ExecuteScalar());
                    if (returnValue == 0)
                    {
                        return false;
                    }
                }
                catch (Exception ex)
                {

                }
                finally
                {
                    conn.Close();
                }
            }
            return true;
        }
    }
}