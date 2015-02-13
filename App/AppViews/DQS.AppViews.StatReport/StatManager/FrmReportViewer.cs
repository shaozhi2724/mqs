using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Configuration;
using System.Data;
using System.Drawing;
using System.IO;
using System.Text;
using System.Threading;
using System.Windows.Forms;
using DevExpress.Utils;
using DevExpress.XtraBars;
using DevExpress.XtraEditors;
using DQS.Common;
using DQS.Controls;
using DQS.Module.Entities;
using Stimulsoft.Base.Localization;
using Stimulsoft.Controls.Win.DotNetBar;
using Stimulsoft.Report;
using Stimulsoft.Report.Dictionary;

namespace DQS.AppViews.StatReport.StatManager
{
    public partial class FrmReportViewer : XtraForm
    {
        private SYSPageEntity sysPage;
        private StiReport stiReport;
        private string reportFile;

        public FrmReportViewer()
        {
            InitializeComponent();
            StiReport.ClearReportCache();
            SetReportViewer();
        }

        private void SetReportViewer()
        {
            stiViewer.ApplyStyle(StiGlobalGuiStyle.Office2007Silver);
            stiViewer.ToolBar.ImageSize = eBarImageSize.Medium;
            stiViewer.ToolBar.Font = stiViewer.Font;
            //隐藏全屏按钮
            stiViewer.ShowFullScreen = false;
            //去掉参数按钮
            var tbParameters = stiViewer.ToolBar.GetItem("tbParameters");
            if (null != tbParameters)
            {
                stiViewer.ToolBar.Items.Remove(tbParameters);
            }
            foreach (var control in stiViewer.ToolBar.Items)
            {
                if (control is ButtonItem)
                {
                    var buttonItem = ((ButtonItem) control);
                    buttonItem.Size = new Size(135, 92);
                    buttonItem.ImagePosition = eImagePosition.Top;
                    switch (buttonItem.Text)
                    {
                        case "打印":
                            buttonItem.Image = global::DQS.Controls.Properties.Resources.打印;
                            break;
                        case "保存":
                            buttonItem.Image = global::DQS.Controls.Properties.Resources.保存;
                            break;
                    }
                }
            }
            //添加“查询”按钮
            ButtonItem tbQuery = new Stimulsoft.Controls.Win.DotNetBar.ButtonItem();
            tbQuery.BeginGroup = true;
            tbQuery.ImagePosition = eImagePosition.Top;
            tbQuery.ButtonStyle = eButtonStyle.ImageAndText;
            tbQuery.Image = global::DQS.Controls.Properties.Resources.查询;
            tbQuery.Name = "tbQuery";
            tbQuery.Size = new Size(135, 92);
            tbQuery.PopupPositionAdjusted = false;
            tbQuery.Text = "查询";
            tbQuery.Click += new System.EventHandler(this.tbQuery_Click);
            stiViewer.ToolBar.Items.Insert(0,tbQuery);
            stiViewer.ToolBar.BackColor = toolBarPanel.BackColor;
            stiViewer.ToolBar.HideFloatingInactive = true;
            stiViewer.ToolBar.DockedBorderStyle = eBorderType.None;
            stiViewer.ToolBar.CanMove = false;
            stiViewer.PanelDialogs.Show();
        }

        private void tbQuery_Click(object sender, EventArgs e)
        {
            this.CustomQuery();
        }

        private void FrmStatReport_Load(object sender, EventArgs e)
        {
            string pageName = this.Tag.ToString();
            //设置数据
            sysPage = GlobalMethod.GetFormPage(pageName);
            if (sysPage != null)
            {
                string fileName = sysPage.PageName + ".mrt";
                reportFile = Path.Combine(AppDomain.CurrentDomain.BaseDirectory, fileName);
                stiViewer.Refresh();
            }
        }

        public void CustomQuery()
        {
            ViewReport();
        }

        private void ViewReport()
        {
            if (!File.Exists(reportFile))
            {
                XtraMessageBox.Show(String.Format("文件 {0} 不存在！", Path.GetFileName(reportFile)), "系统错误", MessageBoxButtons.OK,
                    MessageBoxIcon.Error);
                return;
            }
            stiReport = new StiReport();
            stiReport.Load(reportFile);
            stiReport["UserID"] = GlobalItem.g_CurrentUser.UserID.ToString();
            if (!stiReport.Script.Contains("public class ReportFunction"))
            {
                string reportScriptFile = Path.Combine(AppDomain.CurrentDomain.BaseDirectory, "ReportFunction.cs");
                stiReport.Script = string.Format("{0}\n{1}", stiReport.Script, File.ReadAllText(reportScriptFile));
            }

            stiReport.Dictionary.Databases["DQS"] = new StiSqlDatabase("DQS",
                ConfigurationManager.ConnectionStrings["DbConnectStrings"].ConnectionString);
            stiReport.Save(reportFile);
            stiReport.Compile();
            stiReport.Render(false);
            stiViewer.Report = stiReport;
            this.stiViewer.Refresh();
        }
    }
}