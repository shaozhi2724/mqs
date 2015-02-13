using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using DevExpress.XtraEditors;
using System.Windows.Forms;
using ORMSCore;
using System.Reflection;
using DQS.Common;
using DQS.Module.Entities;
using System.Data;
using DevExpress.XtraGrid.Views.Grid;
using System.Drawing;
using DevExpress.XtraGrid;
using DevExpress.XtraBars;
using DevExpress.XtraReports.UserDesigner;
using DevExpress.XtraBars.Docking;
using DevExpress.XtraReports.UI;
using DevExpress.XtraReports.Parameters;
using System.IO;
using System.ComponentModel;
using DQS.Controls.CommonCode;

namespace DQS.Controls
{
    public class DesignerForm : XtraForm
    {
        protected ToolBarPanel toolBarPanel;
        protected XRDesignFormEx xrDesigner;
        protected PanelControl pnlCenter;
        protected XtraReport report;
        protected string filePath = AppDomain.CurrentDomain.BaseDirectory;

        /// <summary>
        /// 配置文件中对应的业务设计名称
        /// </summary>
        [Description("配置文件中对应的业务设计名称")]
        public string OperationName { get; set; }

        /// <summary>
        /// 要设计的报表名称
        /// </summary>
        [Description("要设计的报表名称")]
        public string ReportName { get; set; }

        /// <summary>
        /// 报表
        /// </summary>
        [Browsable(false)]
        public XtraReport Report
        {
            get { return report; }
        }

        public DesignerForm()
        {
            InitializeComponent();
        }

        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(DesignerForm));
            this.toolBarPanel = new DQS.Controls.ToolBarPanel();
            this.xrDesigner = new DevExpress.XtraReports.UserDesigner.XRDesignFormEx();
            this.pnlCenter = new DevExpress.XtraEditors.PanelControl();
            ((System.ComponentModel.ISupportInitialize)(this.toolBarPanel)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pnlCenter)).BeginInit();
            this.SuspendLayout();
            // 
            // toolBarPanel
            // 
            this.toolBarPanel.Dock = System.Windows.Forms.DockStyle.Top;
            this.toolBarPanel.Location = new System.Drawing.Point(0, 0);
            this.toolBarPanel.Name = "toolBarPanel";
            this.toolBarPanel.Size = new System.Drawing.Size(814, 28);
            this.toolBarPanel.TabIndex = 0;
            this.toolBarPanel.ToolButtonClicked += new DQS.Controls.ToolBarPanel.OnToolButtonClicked(this.toolBarPanel_ToolButtonClicked);
            // 
            // xrDesigner
            // 
            this.xrDesigner.ClientSize = new System.Drawing.Size(0, 0);
            this.xrDesigner.Icon = ((System.Drawing.Icon)(resources.GetObject("xrDesigner.Icon")));
            this.xrDesigner.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.xrDesigner.Name = "xrDesigner";
            this.xrDesigner.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Hide;
            this.xrDesigner.StartPosition = System.Windows.Forms.FormStartPosition.Manual;
            this.xrDesigner.Text = "Report Designer";
            this.xrDesigner.Visible = false;
            this.xrDesigner.WindowState = System.Windows.Forms.FormWindowState.Minimized;
            // 
            // pnlCenter
            // 
            this.pnlCenter.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlCenter.Location = new System.Drawing.Point(0, 28);
            this.pnlCenter.Name = "pnlCenter";
            this.pnlCenter.Size = new System.Drawing.Size(814, 454);
            this.pnlCenter.TabIndex = 1;
            // 
            // DesignerForm
            // 
            this.ClientSize = new System.Drawing.Size(814, 482);
            this.Controls.Add(this.pnlCenter);
            this.Controls.Add(this.toolBarPanel);
            this.Name = "DesignerForm";
            this.Text = "设计模版窗体";
            ((System.ComponentModel.ISupportInitialize)(this.toolBarPanel)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pnlCenter)).EndInit();
            this.ResumeLayout(false);

        }

        private void toolBarPanel_ToolButtonClicked(object sender, ItemClickEventArgs e)
        {
            switch (e.Item.Caption.Trim())
            {
                case "保存":
                    this.CustomSave();
                    break;
                case "预览":
                    this.CustomPreview();
                    break;
                default:
                    break;
            }
        }

        /// <summary>
        /// 自定义保存
        /// </summary>
        protected virtual void CustomSave()
        {
            string fileName = Path.Combine(this.filePath, this.ReportName + ".repx");
            this.report.SaveLayout(fileName);
            XtraMessageBox.Show("保存成功!", "系统提示", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        /// <summary>
        /// 自定义预览
        /// </summary>
        protected virtual void CustomPreview()
        {

            try
            {
                xrDesigner.DesignPanel.CloseReport();

                //不显示参数的Submit框
                foreach (Parameter p in this.report.Parameters)
                {
                    if (p.Visible)
                    {
                        p.Visible = false;
                    }
                }

                using (PreviewForm preForm = new PreviewForm())
                {
                    report.CreateDocument();
                    preForm.printControl.PrintingSystem = report.PrintingSystem;
                    preForm.ShowDialog();
                }

                xrDesigner.DesignPanel.OpenReport(this.report);
            }
            catch (Exception ex)
            {
                XtraMessageBox.Show(ex.Message, "系统错误", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        protected void InitPage()
        {
            this.report = this.GetReport();

            #region 查询页面对应的功能

            //查询页面对应的功能
            if (GlobalItem.g_Functions != null)
            {
                if (GlobalItem.g_Functions.Rows.Count > 0)
                {
                    EntityCollection<SYSPageFunctionEntity> pageFunctions = new EntityCollection<SYSPageFunctionEntity>();
                    pageFunctions.Fetch(SYSPageFunctionEntityFields.PageCode == this.Name);

                    if (pageFunctions.Count > 0)
                    {
                        foreach (DataRow functionRow in GlobalItem.g_Functions.Rows)
                        {
                            foreach (SYSPageFunctionEntity pageFunction in pageFunctions)
                            {
                                string functionCode = functionRow["FunctionCode"].ToString();
                                if (functionCode == pageFunction.FunctionCode)
                                {
                                    string functionName = functionRow["FunctionName"].ToString();
                                    string imageName = functionRow["ImageName"].ToString();
                                    this.toolBarPanel.AddTool(functionName, imageName);
                                }
                            }
                        }

                    }
                }
            }

            #endregion

            #region 设置设计窗体参数

            xrDesigner.DesignBarManager.Bars[0].Visible = false;
            xrDesigner.DesignDockManager.Panels["groupAndSortDockPanel1"].Visibility = DockVisibility.AutoHide;
            xrDesigner.DesignDockManager.Panels["errorListDockPanel1"].Visibility = DockVisibility.AutoHide;
            xrDesigner.DesignPanel.SetCommandVisibility(new ReportCommand[]{ 
                        ReportCommand.NewReport, 
                        ReportCommand.SaveFileAs, 
                        ReportCommand.NewReportWizard,
                        ReportCommand.ShowScriptsTab,
                        ReportCommand.OpenFile,
                        ReportCommand.SaveFile}, CommandVisibility.None);

            #endregion

            xrDesigner.OpenReport(this.report);

            xrDesigner.FormBorderStyle = FormBorderStyle.None;
            xrDesigner.ShowInTaskbar = false;
            xrDesigner.Show();
            xrDesigner.TopLevel = false;
            xrDesigner.Dock = DockStyle.Fill;

            this.pnlCenter.Controls.Add(xrDesigner);


        }

        private XtraReport GetReport()
        {
            this.report = new XtraReport();

            if (string.IsNullOrEmpty(this.ReportName))
            {
                throw new Exception("未设置报表名称!");
            }

            this.report.Name = this.ReportName;

            string fileName = Path.Combine(this.filePath, this.ReportName + ".repx");

            //若存在则加载配置
            if (File.Exists(fileName))
            {
                this.report.LoadLayout(fileName);
            }

            if (!string.IsNullOrEmpty(this.OperationName))
            {
                List<Parameter> parameters = OperationReportSetting.GetReportParameters(this.OperationName);
                //report.Parameters.Clear();
                foreach (Parameter p in parameters)
                {
                    if (report.Parameters.Count(g => g.Name == p.Name) < 1)
                    {
                        report.Parameters.Add(p);

                        p.Visible = false;
                    }
                }

                report.DataSource = OperationReportSetting.GetReportDateSource(this.OperationName);

            }

            return report;
        }
    }
}
