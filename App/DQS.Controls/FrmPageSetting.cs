using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using DevExpress.XtraEditors;
using System.Xml;
using System.IO;

namespace DQS.Controls
{
    public partial class FrmPageSetting : XtraForm
    {
        private string m_PageCode;

        /// <summary>
        /// 页面名
        /// </summary>
        public string PageCode { get; set; }

        /// <summary>
        /// 视图名
        /// </summary>
        public string ViewName { get; set; }

        /// <summary>
        /// 主键列
        /// </summary>
        public string PrimaryField { get; set; }

        /// <summary>
        /// 排序字段
        /// </summary>
        public string SortField { get; set; }

        /// <summary>
        /// 排序类型
        /// </summary>
        public string SortType { get; set; }

        /// <summary>
        /// 分页大小
        /// </summary>
        public int PageSize { get; set; }

        /// <summary>
        /// 可见性列
        /// </summary>
        public List<string> EnabledFileds { get; set; }

        private DataTable m_FieldData;

        private XmlDocument m_Document;

        public FrmPageSetting(string pageCode, string viewName, string primaryField, string sortField, string sortType, int pageSize, List<string> allFileds)
        {
            InitializeComponent();

            this.m_PageCode = pageCode;
            this.EnabledFileds = new List<string>();

            try
            {
                m_Document = new XmlDocument();
                string fileName = Path.Combine(AppDomain.CurrentDomain.BaseDirectory, "PageSettings.xml");
                m_Document.Load(fileName);

                XmlNode node = m_Document.SelectSingleNode(String.Format("PageSettings/Pages/Page[@PageCode = '{0}']", pageCode));

                if (node == null)
                {
                    //创建所有
                    XmlElement pageNode = m_Document.CreateElement("Page");

                    pageNode.SetAttribute("PageCode", pageCode);
                    pageNode.SetAttribute("ViewName", viewName);
                    pageNode.SetAttribute("PrimaryField", primaryField);
                    pageNode.SetAttribute("SortField", sortField);
                    pageNode.SetAttribute("SortType", sortType);
                    pageNode.SetAttribute("PageSize", pageSize + "");

                    this.txtPageSize.Text = pageSize + "";

                    this.InitFieldData();

                    foreach (string filedName in allFileds)
                    {
                        XmlElement filedNode = m_Document.CreateElement("Filed");
                        filedNode.SetAttribute("Name", filedName);
                        filedNode.SetAttribute("IsShow", "true");
                        pageNode.AppendChild(filedNode);

                        DataRow row = this.m_FieldData.NewRow();
                        row["IsShow"] = true;
                        row["FieldName"] = filedName;
                        this.m_FieldData.Rows.Add(row);

                        if (filedName != "序号")
                        {
                            this.cbbSortField.Properties.Items.Add(filedName);
                        }
                    }

                    m_Document.SelectSingleNode("PageSettings/Pages").AppendChild(pageNode);
                    m_Document.Save(fileName);

                    this.gvControl.DataSource = this.m_FieldData;
                }
                else
                {
                    this.ViewName = node.Attributes["ViewName"].Value;
                    this.PrimaryField = node.Attributes["PrimaryField"].Value;
                    this.SortField = node.Attributes["SortField"].Value;
                    this.SortType = node.Attributes["SortType"].Value;
                    this.PageSize = Convert.ToInt32(node.Attributes["PageSize"].Value);

                    this.cbbSortField.Text = this.SortField;

                    if (this.SortType == "DESC")
                    {
                        this.cbbSortType.SelectedIndex = 1;
                        //this.cbbSortType.Text = this.SortType;
                    }

                    
                    
                    this.txtPageSize.Text = this.PageSize + "";

                    this.InitFieldData();



                    foreach (XmlNode fieldNode in node.ChildNodes)
                    {
                        DataRow row = this.m_FieldData.NewRow();
                        string isShow = fieldNode.Attributes["IsShow"].Value;
                        string fieldName = fieldNode.Attributes["Name"].Value;
                        if (isShow == "true")
                        {
                            row["IsShow"] = true;
                            this.EnabledFileds.Add(fieldName);
                        }
                        else
                        {
                            row["IsShow"] = false;
                        }
                        row["FieldName"] = fieldName;
                        this.m_FieldData.Rows.Add(row);

                        //添加排序字段
                        if (fieldName != "序号")
                        {
                            this.cbbSortField.Properties.Items.Add(fieldName);
                        }
                    }

                    this.gvControl.DataSource = this.m_FieldData;
                }
            }
            catch (Exception ex)
            {
                XtraMessageBox.Show(ex.Message, "初始化失败");
            }
        }

        private void InitFieldData()
        {
            this.m_FieldData = new DataTable();
            this.m_FieldData.Columns.Add("IsShow", Type.GetType("System.Boolean"));
            this.m_FieldData.Columns.Add("FieldName", Type.GetType("System.String"));
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            XmlNode node = m_Document.SelectSingleNode(String.Format("PageSettings/Pages/Page[@PageCode = '{0}']", m_PageCode));
            if (node != null)
            {
                if (this.cbbSortField.Text.Trim().Length > 0)
                {
                    this.SortField = this.cbbSortField.Text.Trim();
                    node.Attributes["SortField"].Value = this.cbbSortField.Text.Trim();
                }

                if (this.cbbSortType.Text.Trim().Length > 0)
                {
                    if (this.cbbSortType.Text.Trim() == "降序")
                    {
                        this.SortType = "DESC";
                        node.Attributes["SortType"].Value = "DESC";
                    }
                    else
                    {
                        this.SortType = "ASC";
                        node.Attributes["SortType"].Value = "ASC";
                    }
                }

                if (this.txtPageSize.Text.Trim().Length > 0)
                {
                    try
                    {
                        this.PageSize = Convert.ToInt32(this.txtPageSize.Text.Trim());
                        node.Attributes["PageSize"].Value = Convert.ToInt32(this.txtPageSize.Text.Trim()) + "";
                    }
                    catch (Exception ex)
                    {
                        XtraMessageBox.Show(ex.Message, "每页记录数输入有误");
                        return;
                    }
                }

                this.EnabledFileds.Clear();

                for (int i = 0; i < gvData.RowCount; i++)
                {
                    DataRow row = gvData.GetDataRow(i);

                    //若是ID，则不判断是否选中
                    if (row.ItemArray[1].ToString().Contains("ID"))
                    {
                        this.EnabledFileds.Add(row.ItemArray[1].ToString());
                        node.ChildNodes[i].Attributes["IsShow"].Value = "true";
                        continue;
                    }

                    string isShow = row.ItemArray[0].ToString().ToLower();

                    if (isShow == "true")
                    {
                        this.EnabledFileds.Add(row.ItemArray[1].ToString());
                    }

                    node.ChildNodes[i].Attributes["IsShow"].Value = isShow;
                }

                string fileName = Path.Combine(AppDomain.CurrentDomain.BaseDirectory, "PageSettings.xml");
                m_Document.Save(fileName);



                DialogResult = DialogResult.OK;
            }
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Close();
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

        private void chkChoose_CheckedChanged(object sender, EventArgs e)
        {
            if (chkChoose.Checked)
            {
                //全选
                for (int i = 0; i < gvData.RowCount; i++)
                {
                    gvData.SetRowCellValue(i, colIsShow, true);
                }
                chkChoose.Text = "反选";
            }
            else
            { 
                //反选
                for (int i = 0; i < gvData.RowCount; i++)
                {
                    gvData.SetRowCellValue(i, colIsShow, false);
                }
                chkChoose.Text = "全选";
            }
        }
    }
}