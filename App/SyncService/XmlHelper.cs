using System;
using System.IO;
using System.Text;
using System.Xml;
using System.Xml.Serialization;

namespace SyncService
{
    public class XmlHelper
    {
        #region 反序列化
        /// <summary>
        /// 反序列化
        /// </summary>
        /// <param name="type">类型</param>
        /// <param name="xml">XML字符串</param>
        /// <returns></returns>
        public static object Deserialize(Type type, string xml)
        {
            try
            {
                using(StringReader reader = new StringReader(xml))
                {
                    XmlSerializer serializer = new XmlSerializer(type);
                    return serializer.Deserialize(reader);
                }
            }
            catch(Exception)
            {
                return null;
            }
        }
        /// <summary>
        /// 反序列化
        /// </summary>
        /// <param name="type">类型</param>
        /// <param name="stream">流对象</param>
        /// <returns></returns>
        public static object Deserialize(Type type, Stream stream)
        {
            XmlSerializer serializer = new XmlSerializer(type);
            return serializer.Deserialize(stream);
        }
        #endregion

        #region 序列化XML文件
        /// <summary>
        /// 序列化XML文件
        /// </summary>
        /// <param name="type">类型</param>
        /// <param name="obj">对象</param>
        /// <returns></returns>
        public static string Serializer(Type type, object obj)
        {
            StringBuilder xmlStringBuilder = new StringBuilder();

            //不生成XML声明
            var settings = new XmlWriterSettings
            {
                OmitXmlDeclaration = true
            };

            //不生成XML名称空间
            XmlSerializerNamespaces ns = new XmlSerializerNamespaces();

            //Add an empty namespace and empty value
            ns.Add("", "");

            //创建序列化对象
            XmlSerializer serializer = new XmlSerializer(type);

            using(var writer = XmlWriter.Create(xmlStringBuilder, settings))
            {
                serializer.Serialize(writer, obj, ns);
            }
            return xmlStringBuilder.ToString();
        }
        #endregion



        #region 获取对应XML节点的值

        /// <summary>
        /// 摘要:获取对应XML节点的值
        /// </summary>
        /// <param name="root">XML节点的标记</param>
        /// <param name="xml">XML内容</param>
        /// <returns>返回获取对应XML节点的值</returns>
        public static string XmlAnalysis(string root, string xml)
        {
            if(!string.IsNullOrWhiteSpace(root))
            {
                try
                {
                    XmlDocument doc = new XmlDocument();
                    doc.LoadXml(xml);
                    if(doc.DocumentElement != null)
                    {
                        var xmlNode = doc.DocumentElement.SelectSingleNode(root);
                        if(xmlNode != null)
                        {
                            return xmlNode.InnerXml.Trim();
                        }
                    }
                    return "";
                }
                catch(Exception)
                {
                    // ignored
                }
            }
            return "";
        }
        #endregion


    }
}
