using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Xml;
using System.IO;

namespace DQS.Common
{
    public class PageSetting
    {

        public string PageCode { get; set; }

        public string ViewName { get; set; }

        public string PrimaryField { get; set; }

        public string SortField { get; set; }

        public string SortType { get; set; }

        public int PageSize { get; set; }

        public List<string> EnabledFileds { get; set; }

        public PageSetting()
        {
            
        }
        public PageSetting(string pageCode, string viewName, string primaryField, string sortField, string sortType, int pageSize, List<string> allFileds)
        {
            this.EnabledFileds = new List<string>();
            PageCode = pageCode;
            this.ViewName = viewName;
            this.PrimaryField = primaryField;
            this.SortField = sortField;
            this.SortType = sortType;
            this.PageSize = pageSize;
            try
            {
                XmlDocument document = new XmlDocument();
                string fileName = Path.Combine(AppDomain.CurrentDomain.BaseDirectory, "PageSettings.xml");
                if (!File.Exists(fileName))
                {
                    File.WriteAllText(fileName,@"<?xml version=""1.0"" encoding=""utf-8"" ?>
                                                    <PageSettings>
                                                      <Pages/>
                                                    </PageSettings>");
                }
                document.Load(fileName);

                XmlNode node = document.SelectSingleNode(String.Format("PageSettings/Pages/Page[@PageCode = '{0}']", pageCode));

                if (node == null)
                {
                    //创建所有
                    XmlElement pageNode = document.CreateElement("Page");

                    pageNode.SetAttribute("PageCode", pageCode);
                    pageNode.SetAttribute("ViewName", viewName);
                    pageNode.SetAttribute("PrimaryField", primaryField);
                    pageNode.SetAttribute("SortField", sortField);
                    pageNode.SetAttribute("SortType", sortType);
                    pageNode.SetAttribute("PageSize", pageSize + "");

                    foreach (string filedName in allFileds)
                    {
                        XmlElement filedNode = document.CreateElement("Filed");
                        filedNode.SetAttribute("Name", filedName);
                        filedNode.SetAttribute("IsShow", "true");

                        pageNode.AppendChild(filedNode);
                        this.EnabledFileds.Add(filedName);
                    }

                    document.SelectSingleNode("PageSettings/Pages").AppendChild(pageNode);
                    document.Save(fileName);
                }
                else
                {
                    this.ViewName = node.Attributes["ViewName"].Value;
                    this.PrimaryField = node.Attributes["PrimaryField"].Value;
                    this.SortField = node.Attributes["SortField"].Value;
                    this.SortType = node.Attributes["SortType"].Value;
                    this.PageSize = Convert.ToInt32(node.Attributes["PageSize"].Value);

                    for (int index = 0; index < allFileds.Count; index++)
                    {
                        string field = allFileds[index];
                        XmlNode nodeField = node.SelectSingleNode(string.Format("Filed[@Name='{0}']", field));
                        if (null == nodeField)
                        {
                            XmlElement filedNode = document.CreateElement("Filed");
                            filedNode.SetAttribute("Name", field);
                            filedNode.SetAttribute("IsShow", "true");
                            if (index > 0)
                            {
                                node.InsertAfter(filedNode, node.ChildNodes[index - 1]);
                            }
                            else
                            {
                                node.InsertBefore(filedNode, node.ChildNodes[index + 1]);
                            }
                        }
                    }
                    for (int i = 0; i < node.ChildNodes.Count; i++)
                    {
                        XmlNode filedNode = node.ChildNodes[i];
                        if (!allFileds.Contains(filedNode.Attributes["Name"].Value))
                        {
                            node.RemoveChild(filedNode);
                        }
                    }
                    document.Save(fileName);
                    foreach (XmlNode filedNode in node.ChildNodes)
                    {
                        if (filedNode.Attributes["IsShow"].Value == "true")
                        {
                            string value = filedNode.Attributes["Name"].Value;
                            if (!EnabledFileds.Contains(value))
                            {
                                this.EnabledFileds.Add(value);
                            }
                        }
                    }
                }
            }
            catch (System.Xml.XmlException)
            {
            }
           
        }


        public void GetPageSettings(string pageCode, string viewName)
        {
            try
            {
                XmlDocument document = new XmlDocument();
                string fileName = Path.Combine(AppDomain.CurrentDomain.BaseDirectory, "PageSettings.xml");
                if (!File.Exists(fileName))
                {
                    return;
                }
                document.Load(fileName);

                XmlNode node = document.SelectSingleNode(String.Format("PageSettings/Pages/Page[@PageCode = '{0}']", pageCode));

                if (node != null)
                {
                    this.ViewName = node.Attributes["ViewName"].Value;
                    this.PrimaryField = node.Attributes["PrimaryField"].Value;
                    this.SortField = node.Attributes["SortField"].Value;
                    this.SortType = node.Attributes["SortType"].Value;
                    this.PageSize = Convert.ToInt32(node.Attributes["PageSize"].Value);
                    if (null == EnabledFileds)
                    {
                        EnabledFileds = new List<string>();
                    }
                    foreach (XmlNode filedNode in node.ChildNodes)
                    {
                        if (filedNode.Attributes["IsShow"].Value == "true")
                        {
                            this.EnabledFileds.Add(filedNode.Attributes["Name"].Value);
                        }
                    }
                }
            }
            catch (System.Xml.XmlException)
            {
            }
        }
    }
}
