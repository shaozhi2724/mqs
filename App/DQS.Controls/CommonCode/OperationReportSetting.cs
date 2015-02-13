using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.IO;
using System.Xml;
using DevExpress.XtraReports.Parameters;
using System.Data;

namespace DQS.Controls.CommonCode
{
    public class OperationReportSetting
    {
        private static XmlDocument m_OpDocument;

        static OperationReportSetting()
        {
            if (File.Exists("OperationSettings.xml"))
            {
                m_OpDocument = new XmlDocument();
                m_OpDocument.Load("OperationSettings.xml");
            }
        }

        /// <summary>
        /// 获取报表的参数列表
        /// </summary>
        /// <param name="opName">报表对应的业务名称</param>
        /// <returns>参数集合</returns>
        public static List<Parameter> GetReportParameters(string opName)
        {
            List<Parameter> parameters = new List<Parameter>();

            if (!string.IsNullOrEmpty(opName))
            {
                if (m_OpDocument != null)
                {
                    try
                    {
                        XmlNode opNode = m_OpDocument.SelectSingleNode(String.Format("OperationSettings/Operation[@Name = '{0}']/Report/Parameters", opName));
                        if (opNode != null)
                        {
                            if (opNode.ChildNodes.Count > 0)
                            {
                                foreach (XmlNode node in opNode.ChildNodes)
                                {
                                    if (node.Attributes != null)
                                    {
                                        Parameter parameter = new Parameter();
                                        if (node.Attributes["Name"] != null) parameter.Name = node.Attributes["Name"].Value;
                                        if (node.Attributes["ParameterType"] != null) parameter.ParameterType = GetParameterType(node.Attributes["ParameterType"].Value);
                                        if (node.Attributes["TestValue"] != null) parameter.Value = node.Attributes["TestValue"].Value;

                                        //使用参数的 Description 属性来保存它对应的控件名称
                                        if (node.Attributes["ValueToControl"] != null) parameter.Description = node.Attributes["ValueToControl"].Value;

                                        parameters.Add(parameter);
                                    }
                                }
                            }
                        }
                    }
                    catch (Exception ex)
                    {
                        throw ex;
                    }
                }
            }

            return parameters;
        }

        /// <summary>
        /// 获取报表的数据源
        /// </summary>
        /// <param name="opName">报表对应的业务名称</param>
        /// <returns>数据集</returns>
        public static DataTable GetReportDateSource(string opName)
        {
            DataTable data = new DataTable("数据源");
            if (!string.IsNullOrEmpty(opName))
            {
                if (m_OpDocument != null)
                {
                    try
                    {
                        XmlNode opNode = m_OpDocument.SelectSingleNode(String.Format("OperationSettings/Operation[@Name = '{0}']/Report/Deatils", opName));
                        if (opNode != null)
                        {
                            if (opNode.ChildNodes.Count > 0)
                            {
                                //添加列
                                foreach (XmlNode node in opNode.ChildNodes)
                                {
                                    if (node.Attributes != null)
                                    {
                                        DataColumn col = new DataColumn();
                                        if (node.Attributes["Name"] != null)
                                        {
                                            col.ColumnName = node.Attributes["Name"].Value;
                                            col.Caption = node.Attributes["Name"].Value;
                                        }
                                        if (node.Attributes["DataType"] != null) col.DataType = Type.GetType(node.Attributes["DataType"].Value);
                                        if (node.Attributes["DefaultValue"] != null) col.DefaultValue = node.Attributes["DefaultValue"].Value;
                                        
                                        data.Columns.Add(col);
                                    }
                                }

                                DataRow row = data.NewRow();//以默认数据添加一行数据
                                data.Rows.Add(row);
                            }
                        }
                    }
                    catch (Exception ex)
                    {
                        throw ex;
                    }
                }
            }

            return data;
        }

        /// <summary>
        /// 获取报表对应的视图名称
        /// </summary>
        /// <param name="opName">报表对应的业务名称</param>
        /// <returns>视图名称</returns>
        public static string GetReportViewName(string opName)
        {
            if (string.IsNullOrEmpty(opName)) return null;

            if (m_OpDocument != null)
            {
                try
                {
                    XmlNode opNode = m_OpDocument.SelectSingleNode(String.Format("OperationSettings/Operation[@Name = '{0}']/Grid", opName));
                    if (opNode != null)
                    {
                        if (opNode.Attributes != null)
                        {
                            if (opNode.Attributes["ViewName"] != null)
                            {
                                string viewName = opNode.Attributes["ViewName"].Value;
                                return viewName;
                            }
                        }
                    }
                }
                catch (Exception ex)
                {
                    throw ex;
                }
            }

            return "";
        }

        private static ParameterType GetParameterType(string typeString)
        {
            switch (typeString)
            {
                case "String":
                    return ParameterType.String;
                case "Int32":
                    return ParameterType.Int32;
                case "Float":
                    return ParameterType.Float;
                case "Double":
                    return ParameterType.Double;
                case "Decimal":
                    return ParameterType.Decimal;
                case "DateTime":
                    return ParameterType.DateTime;
                case "Boolean":
                    return ParameterType.Boolean;
                default:
                    return ParameterType.String;
            }
        }
    }
}
