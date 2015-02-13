using System;
using System.Data;
using DevExpress.XtraEditors;
using System.ComponentModel;
using System.IO;
using System.Windows.Forms;
using DevExpress.XtraGrid;
using DevExpress.XtraGrid.Views.Grid;
using DevExpress.XtraReports.Parameters;
using DevExpress.XtraReports.UI;
using DQS.Controls.CommonCode;

namespace DQS.Controls
{
    public class StiPrintButtonEx : SimpleButton
    {
        /// <summary>
        /// OperationSettings 配置文件中的 OperationName
        /// </summary>
        [Description("OperationSettings 配置文件中的 OperationName")]
        public string OperationName { get; set; }

        /// <summary>
        /// 要设计的报表名称
        /// </summary>
        [Description("要设计的报表名称")]
        public string ReportName { get; set; }


        public delegate void OnBeforePrint(EventArgs e);

        [Description("点击之前出发的事件")]
        public event OnBeforePrint BeforePrint;


        protected override void OnClick(EventArgs e)
        {
            if (this.BeforePrint != null)
            {
                BeforePrint(e);
                string s = this.Tag.ToString();
                if (s == "false")
                {
                    return;
                }
            }
            string fileName = Path.Combine(AppDomain.CurrentDomain.BaseDirectory, ReportName + ".mrt");
            if (File.Exists(fileName))
            {
                Form parentForm = this.FindForm();
                if (parentForm != null && parentForm.Tag != null)
                {
                    PrintPreviewForm printPreview = new PrintPreviewForm(fileName, Convert.ToInt32(parentForm.Tag));
                    printPreview.ShowDialog(this);
                }
                else
                {
                    XtraMessageBox.Show("请保存后再打印。", "警告", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                    return;
                }
            }
            else
            {
                fileName = Path.Combine(AppDomain.CurrentDomain.BaseDirectory, ReportName + ".repx");

                XtraReport report = new XtraReport();
                report.LoadLayout(fileName);

                DataTable data = OperationReportSetting.GetReportDateSource(this.OperationName);
                data.Rows.Clear();

                Form parentForm = this.FindForm();

                //设置数据集数据;
                this.SetDataSource(parentForm, data);

                report.DataSource = data;

                //设置参数数据
                foreach (Parameter p in report.Parameters)
                {
                    this.SetParameterValue(parentForm, p);
                    p.Visible = false;
                }

                report.ShowPreview();

                base.OnClick(e);
            }
            base.OnClick(e);
        }

        //查找GridView
        protected void SetDataSource(Control container, DataTable data)
        {
            foreach (Control c in container.Controls)
            {
                if (c is GridControl)
                {
                    if (c is PopupGrid)
                    {
                        if ((c as PopupGrid).OperationName != this.OperationName)
                        {
                            continue;
                        }
                    }
                    GridView gv = (c as GridControl).Views[0] as GridView;

                    for (int i = 0; i < gv.RowCount; i++)
                    {
                        object firstValue = gv.GetRowCellValue(i, gv.Columns[0]);

                        //不是空数据行的数据才添加的数据集中
                        if (firstValue != null && firstValue != DBNull.Value)
                        {
                            DataRow row = data.NewRow();

                            foreach (DataColumn col in data.Columns)
                            {
                                object gvValue = gv.GetRowCellValue(i, col.ColumnName);
                                if (null != gvValue && DBNull.Value != gvValue)
                                {
                                    row[col] = gvValue;
                                }
                            }
                            data.Rows.Add(row);
                        }

                    }
                    return;
                }

                if (c.HasChildren)
                {
                    this.SetDataSource(c, data);
                }
            }
        }

        //查找控件名称与参数描述对应的控件
        protected void SetParameterValue(Control container, Parameter p)
        {
            foreach (Control c in container.Controls)
            {
                if (c.Name == p.Description)
                {
                    if (p.Name == "订单总额")
                    {
                        if(!string.IsNullOrEmpty(c.Text))
                        {
                            var chineseNumber = ConvertToChinese(decimal.Parse(c.Text.Trim()));
                            p.Value = chineseNumber;
                        }
                    }
                    else
                    {
                        p.Value = c.Text;
                    }
                    return;
                }

                if (c.HasChildren)
                {
                    this.SetParameterValue(c, p);
                }
            }
        }
        public static string ConvertToChinese(decimal x)
        {
            string s = x.ToString("#L#E#D#C#K#E#D#C#J#E#D#C#I#E#D#C#H#E#D#C#G#E#D#C#F#E#D#C#.0B0A");
            string d = System.Text.RegularExpressions.Regex.Replace(s, @"((?<=-|^)[^1-9]*)|((?'z'0)[0A-E]*((?=[1-9])|(?'-z'(?=[F-L.]|$))))|((?'b'[F-L])(?'z'0)[0A-L]*((?=[1-9])|(?'-z'(?=[.]|$))))", "${b}${z}");
            var result = System.Text.RegularExpressions.Regex.Replace(d, ".", m => "负元空零壹贰叁肆伍陆柒捌玖空空空空空空空分角拾佰仟万亿兆京垓秭穰"[m.Value[0] - '-'].ToString());
            if (result.EndsWith("元"))
            {
                result += "整";
            }
            return result;
        }
    }
}
