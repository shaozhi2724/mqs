using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Xml;
using System.IO;
using ORMSCore;
using System.Data;

namespace DQS.Controls.CommonCode
{
    public class OperationGridSetting
    {
        private static XmlDocument m_OpDocument;

        static OperationGridSetting()
        {
            if (File.Exists("OperationSettings.xml"))
            {
                m_OpDocument = new XmlDocument();
                m_OpDocument.Load("OperationSettings.xml");
            }
        }

        /// <summary>
        /// 获取业务表格对应的实体
        /// </summary>
        /// <param name="opName">业务名称</param>
        /// <returns>实体</returns>
        public static EntityBase GetEntityByName(string opName)
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
                            if (opNode.Attributes["EntityName"] != null)
                            {
                                string entityName = opNode.Attributes["EntityName"].Value;

                                EntityBase entity = Activator.CreateInstance(Type.GetType(String.Format("DQS.Module.Entities.{0}, DQS.Module", entityName))) as EntityBase;

                                return entity;
                            }
                        }
                    }
                }
                catch (Exception ex)
                {
                    throw ex;
                }
            }

            return null;
        }

        /// <summary>
        /// 获取业务表格对应的实体类型字符串
        /// </summary>
        /// <param name="opName">业务名称</param>
        /// <returns>实体类型字符串</returns>
        public static string GetEntityNameByOpName(string opName)
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
                            if (opNode.Attributes["EntityName"] != null)
                            {
                                string entityName = opNode.Attributes["EntityName"].Value;

                                return String.Format("DQS.Module.Entities.{0}, DQS.Module", entityName);
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

        /// <summary>
        /// 获取业务表格对应的所有列
        /// </summary>
        /// <param name="opName">业务名称</param>
        /// <returns>列集合</returns>
        public static List<OperationGridColumn> GetColumns(string opName)
        {
            List<OperationGridColumn> columns = new List<OperationGridColumn>();

            if (!string.IsNullOrEmpty(opName))
            {
                if (m_OpDocument != null)
                {
                    try
                    {
                        XmlNode opNode = m_OpDocument.SelectSingleNode(String.Format("OperationSettings/Operation[@Name = '{0}']/Grid/Columns", opName));
                        if (opNode != null)
                        {
                            if (opNode.ChildNodes.Count > 0)
                            {
                                foreach (XmlNode node in opNode.ChildNodes)
                                {
                                    if (node.Attributes != null)
                                    {
                                        OperationGridColumn col = new OperationGridColumn();

                                        if (node.Attributes["Name"] != null) col.ColumnName = node.Attributes["Name"].Value;
                                        if (node.Attributes["EntityField"] != null) col.EntityField = node.Attributes["EntityField"].Value;
                                        if (node.Attributes["FieldType"] != null) col.FieldType = node.Attributes["FieldType"].Value;
                                        if (node.Attributes["Visible"] != null) col.Visible = Convert.ToBoolean(node.Attributes["Visible"].Value);
                                        if (node.Attributes["Nullable"] != null) col.Nullable = Convert.ToBoolean(node.Attributes["Nullable"].Value);
                                        if (node.Attributes["AllowEdit"] != null) col.AllowEdit = Convert.ToBoolean(node.Attributes["AllowEdit"].Value);
                                        if (node.Attributes["PopupField"] != null) col.PopupField = node.Attributes["PopupField"].Value;
                                        if (node.Attributes["PopupForm"] != null)
                                        {
                                            col.PopupFormString = node.Attributes["PopupForm"].Value;
                                            col.PopupForm = GetPopupForm(opName, col.PopupFormString);
                                        }
                                        columns.Add(col);
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

            return columns;
        }

        /// <summary>
        /// 获取业务表格的空数据，填充行使用
        /// </summary>
        /// <param name="opName">业务名称</param>
        /// <returns>空数据</returns>
        public static DataTable GetEmptyData(string opName)
        {
            DataTable data = new DataTable();

            if (!string.IsNullOrEmpty(opName))
            {
                if (m_OpDocument != null)
                {
                    try
                    {
                        XmlNode opNode = m_OpDocument.SelectSingleNode(String.Format("OperationSettings/Operation[@Name = '{0}']/Grid/Columns", opName));
                        if (opNode != null)
                        {
                            if (opNode.ChildNodes.Count > 0)
                            {

                                foreach (XmlNode node in opNode.ChildNodes)
                                {
                                    if (node.Attributes != null)
                                    {
                                        if (node.Attributes["Name"] != null)
                                        {
                                            DataColumn col = new DataColumn(node.Attributes["Name"].Value);

                                            if (node.Attributes["FieldType"] != null)
                                            {
                                                col.DataType = Type.GetType(node.Attributes["FieldType"].Value);
                                            }

                                            data.Columns.Add(col);
                                        }
                                    }
                                }
                            }
                        }

                        opNode = m_OpDocument.SelectSingleNode(String.Format("OperationSettings/Operation[@Name = '{0}']/Grid", opName));
                        if (opNode != null)
                        {
                            if (opNode.Attributes != null)
                            {
                                if (opNode.Attributes["EmptyRows"] != null)
                                {
                                    int dataRows = Convert.ToInt32(opNode.Attributes["EmptyRows"].Value);
                                    for (int i = 0; i < dataRows; i++)
                                    {
                                        DataRow row = data.NewRow();

                                        data.Rows.Add(row);
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

            return data;
        }

        /// <summary>
        /// 获取业务表格列中对应的弹出窗体参数
        /// </summary>
        /// <param name="opName">业务名称</param>
        /// <param name="formName">窗体名称</param>
        /// <returns>窗体参数</returns>
        private static OperationPopupForm GetPopupForm(string opName, string formName)
        {
            if (string.IsNullOrEmpty(opName) || string.IsNullOrEmpty(formName)) return null;

            if (m_OpDocument != null)
            {
                try
                {
                    XmlNode opNode = m_OpDocument.SelectSingleNode(String.Format("OperationSettings/Operation[@Name = '{0}']/Grid/PopupForms/PopupForm[@Name = '{1}']", opName, formName));
                    if (opNode != null)
                    {
                        OperationPopupForm form = new OperationPopupForm();
                        if (opNode.Attributes != null)
                        {
                            if (opNode.Attributes["Name"] != null)
                            {
                                form.Name = opNode.Attributes["Name"].Value;
                            }

                            if (opNode.Attributes["PopStyle"] != null)
                            {
                                form.PopStyle = opNode.Attributes["PopStyle"].Value;
                            }

                            if (opNode.Attributes["AllowMultipleSelection"] != null)
                            {
                                form.AllowMultipleSelection = bool.TrueString == opNode.Attributes["AllowMultipleSelection"].Value;
                            }
                            if (opNode.Attributes["GroupFieldName"] != null)
                            {
                                if (!string.IsNullOrWhiteSpace(opNode.Attributes["GroupFieldName"].Value))
                                {
                                    form.GroupFieldName = opNode.Attributes["GroupFieldName"].Value;
                                }
                            }
                        }

                        if (opNode.ChildNodes.Count > 0)
                        {
                            
                            foreach (XmlNode node in opNode.ChildNodes)
                            {
                                if (node.Name == "FormatQueryString") form.FormatQueryString = node.InnerText;
                                if (node.Name == "ViewName") form.ViewName = node.InnerText;
                                if (node.Name == "PrimaryField") form.PrimaryField = node.InnerText;
                                if (node.Name == "Fields") form.Fields = node.InnerText;
                                if (node.Name == "Filter") form.Filter = node.InnerText;
                                if (node.Name == "PageSize") form.PageSize = node.InnerText == "" ? 100 : Convert.ToInt32(node.InnerText);
                            }

                            return form;
                        }
                    }
                }
                catch (Exception ex)
                {
                    throw ex;
                }
            }

            return null;
        }

        /// <summary>
        /// 获取表格的视图参数
        /// </summary>
        /// <param name="opName">业务名称</param>
        /// <returns>参数数组(两位数组，第一个是视图名称，第二个是视图主查询字段)</returns>
        public static string[] GetGridViewParams(string opName)
        {
            if (string.IsNullOrEmpty(opName)) return null;

            if (m_OpDocument != null)
            {
                try
                {
                    XmlNode opNode = m_OpDocument.SelectSingleNode(String.Format("OperationSettings/Operation[@Name = '{0}']/Grid", opName));
                    if (opNode != null)
                    {
                        string[] viewParam = new string[2];
                        if (opNode.Attributes != null)
                        {
                            if (opNode.Attributes["ViewName"] != null)
                            {
                                viewParam[0] = opNode.Attributes["ViewName"].Value;
                            }

                            if (opNode.Attributes["KeyField"] != null)
                            {
                                viewParam[1] = opNode.Attributes["KeyField"].Value;
                            }
                        }
                        return viewParam;
                    }
                }
                catch (Exception ex)
                {
                    throw ex;
                }
            }

            return null;
        }

    }
}
