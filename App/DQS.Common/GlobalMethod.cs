﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using DQS.Module.Entities;
using System.Data.SqlClient;
using System.Data;
using System.Security.Cryptography;
using System.IO;

namespace DQS.Common
{
    public class GlobalMethod
    {
        
        #region 控件用

        public static SYSPageEntity GetFormPage(string pageCode)
        {
            SYSPageEntity page = new SYSPageEntity { PageCode = pageCode };
            page.Fetch();
            return page;
        }

        /// <summary>
        /// 获取控件弹出要显示的Text
        /// </summary>
        /// <param name="viewName">视图名</param>
        /// <param name="memberText">Text字段名</param>
        /// <param name="memberValue">Value字段名</param>
        /// <param name="editValue">Value实际值</param>
        /// <returns>显示的Text</returns>
        public static string GetPopupText(string viewName, string memberText, string memberValue, string editValue)
        {

            if (viewName == "vw_BusinessStoreDetailForSale")
            {
                ATCUserEntity user = new ATCUserEntity { UserID = GlobalItem.g_CurrentUser.UserID };
                user.Fetch();
                if (null != user && !user.UseInternalProductPrice)
                {
                    viewName = "vw_BusinessStoreDetailForOutSale";
                }
            }
            string querySql = String.Format("SELECT [{0}] FROM [{1}] WHERE [{2}] = '{3}'", memberText, viewName, memberValue, editValue);
            using (DataSet dataSet = new DataSet())
            {
                using (SqlDataAdapter adapter = new SqlDataAdapter(querySql, GlobalItem.g_DbConnectStrings))
                {
                    adapter.Fill(dataSet);
                }
                if (dataSet.Tables[0].Rows.Count > 0)
                {
                    return dataSet.Tables[0].Rows[0][0].ToString();
                }
            }
            return "";
        }

        /// <summary>
        /// 获取控件弹出的行数据
        /// </summary>
        /// <param name="viewName">视图名</param>
        /// <param name="memberText">Text字段名</param>
        /// <param name="memberValue">Value字段名</param>
        /// <param name="editValue">Value实际值</param>
        /// <returns>显示的Text</returns>
        public static DataRow GetPopupRow(string viewName, string fields, string memberValue, string editValue)
        {

            if (viewName == "vw_BusinessStoreDetailForSale")
            {
                ATCUserEntity user = new ATCUserEntity { UserID = GlobalItem.g_CurrentUser.UserID };
                user.Fetch();
                if (null != user && !user.UseInternalProductPrice)
                {
                    viewName = "vw_BusinessStoreDetailForOutSale";
                }
            }
            string querySql = String.Format("SELECT {0} FROM [{1}] WHERE [{2}] = '{3}'", fields, viewName, memberValue, editValue);
            using (DataSet dataSet = new DataSet())
            {
                using (SqlDataAdapter adapter = new SqlDataAdapter(querySql, GlobalItem.g_DbConnectStrings))
                {
                    adapter.Fill(dataSet);
                }
                if (dataSet.Tables[0].Rows.Count > 0)
                {
                    return dataSet.Tables[0].Rows[0];
                }
            }
            return null;
        }
        /// <summary>
        /// 获取控件弹出的行数据
        /// </summary>
        /// <param name="viewName">视图名</param>
        /// <param name="memberText">Text字段名</param>
        /// <param name="memberValue">Value字段名</param>
        /// <param name="editValue">Value实际值</param>
        /// <returns>显示的Text</returns>
        public static DataRowCollection GetPopupRows(string viewName, string fields, string memberValue, string editValue)
        {

            if (viewName == "vw_BusinessStoreDetailForSale")
            {
                ATCUserEntity user = new ATCUserEntity { UserID = GlobalItem.g_CurrentUser.UserID };
                user.Fetch();
                if (null != user && !user.UseInternalProductPrice)
                {
                    viewName = "vw_BusinessStoreDetailForOutSale";
                }
            }
            string querySql = String.Format("SELECT {0} FROM [{1}] WHERE [{2}] = '{3}'", fields, viewName, memberValue, editValue);
            using (DataSet dataSet = new DataSet())
            {
                using (SqlDataAdapter adapter = new SqlDataAdapter(querySql, GlobalItem.g_DbConnectStrings))
                {
                    adapter.Fill(dataSet);
                }
                if (dataSet.Tables[0].Rows.Count > 0)
                {
                    return dataSet.Tables[0].Rows;
                }
            }
            return null;
        }

        /// <summary>
        /// 获取视图数据
        /// </summary>
        /// <param name="viewName">视图名称</param>
        /// <param name="keyField">主字段</param>
        /// <param name="keyValue">字段值</param>
        /// <returns>数据集</returns>
        public static DataTable GetViewData(string viewName, string keyField, object keyValue)
        {

            if (viewName == "vw_BusinessStoreDetailForSale")
            {
                ATCUserEntity user = new ATCUserEntity { UserID = GlobalItem.g_CurrentUser.UserID };
                user.Fetch();
                if (null != user && !user.UseInternalProductPrice)
                {
                    viewName = "vw_BusinessStoreDetailForOutSale";
                }
            }
            string querySql = "";
            if (viewName == "vw_AllPurchaseDetail" || viewName == "vw_AllReceiveDetail" || viewName == "vw_AllAcceptDetail" || viewName == "vw_AllStockInDeatil" || viewName == "vw_AllWarehouseInBillDetail" || viewName == "vw_AllWarehouseInBillDetailForAccept" || viewName == "vw_AllWarehouseInBillDetailForStoreIn")
            {
                querySql = String.Format("SELECT * FROM [{0}] WHERE [{1}] = '{2}' ORDER BY 序号", viewName, keyField, keyValue);
            }
            else
            {
                querySql = String.Format("SELECT * FROM [{0}] WHERE [{1}] = '{2}'", viewName, keyField, keyValue);
            }
            
            using (DataSet dataSet = new DataSet())
            {
                using (SqlDataAdapter adapter = new SqlDataAdapter(querySql, GlobalItem.g_DbConnectStrings))
                {
                    adapter.Fill(dataSet);
                }
                return dataSet.Tables[0];
            }
        }

        /// <summary>
        /// 获取视图数据
        /// </summary>
        /// <param name="viewName">视图名称</param>
        /// <param name="filter">查询条件</param>
        /// <returns>数据集</returns>
        public static DataTable GetViewData(string viewName, string filter)
        {

            if (viewName == "vw_BusinessStoreDetailForSale")
            {
                ATCUserEntity user = new ATCUserEntity { UserID = GlobalItem.g_CurrentUser.UserID };
                user.Fetch();
                if (null != user && !user.UseInternalProductPrice)
                {
                    viewName = "vw_BusinessStoreDetailForOutSale";
                }
            }
            string querySql = String.Format("SELECT * FROM [{0}]{1}", viewName, string.IsNullOrEmpty(filter) ? "" : " WHERE " + filter);
            using (DataSet dataSet = new DataSet())
            {
                using (SqlDataAdapter adapter = new SqlDataAdapter(querySql, GlobalItem.g_DbConnectStrings))
                {
                    adapter.Fill(dataSet);
                }
                return dataSet.Tables[0];
            }
        }

        /// <summary>
        /// 获取新的价格分类ID
        /// </summary>
        /// <returns></returns>
        public static string GetNewPriceID()
        {
            using (DataSet dataSet = new DataSet())
            {
                using (SqlDataAdapter adapter = new SqlDataAdapter("SELECT MAX(ItemID) AS ID FROM SYS_Category WHERE CategoryCode = 'PriceStyle'", GlobalItem.g_DbConnectStrings))
                {
                    adapter.Fill(dataSet);
                }
                if (dataSet.Tables[0].Rows.Count > 0)
                {
                    return dataSet.Tables[0].Rows[0][0].ToString();
                }
            }
            return "-1";
        }
        /// <summary>
        /// 获取新的单据编号
        /// </summary>
        /// <returns></returns>
        public static string GetNewSaleBillCode(string prefix, string uiCode)
        {
            string code = string.Empty;
            using (SqlConnection connection = new SqlConnection(GlobalItem.g_DbConnectStrings))
            {
                if (connection.State != ConnectionState.Open)
                {
                    connection.Open();
                }
                var command =
                    new SqlCommand("SET NOCOUNT ON; INSERT INTO [dbo].[BUS_SaleBillCode]([Prefix],[UICode]) VALUES(@Prefix,@UICode);SELECT TOP 1 Prefix+BillCode FROM [dbo].[BUS_SaleBillCode] WHERE UICode=@UICode ORDER BY BillCode DESC",
                        connection);
                command.Parameters.Add("@Prefix",SqlDbType.VarChar,10).Value=prefix;
                command.Parameters.Add("@UICode",SqlDbType.NVarChar,60).Value=uiCode;
                code = (string) command.ExecuteScalar();
                connection.Close();
            }
            return code;
        }
        /// <summary>
        /// 获取新的单据编号
        /// </summary>
        /// <returns></returns>
        public static string GenSaleBillCode(string prefix)
        {
            string code = string.Empty;
            using (SqlConnection connection = new SqlConnection(GlobalItem.g_DbConnectStrings))
            {
                if (connection.State != ConnectionState.Open)
                {
                    connection.Open();
                }
                var command =
                    new SqlCommand("SET NOCOUNT ON; DECLARE @UICODE NVARCHAR(50)=CONVERT(VARCHAR(50), GETDATE(), 25);INSERT INTO [dbo].[BUS_SaleBillCode]([Prefix],[UICode]) VALUES(@Prefix,@UICode);SELECT TOP 1 Prefix+BillCode FROM [dbo].[BUS_SaleBillCode] WHERE UICode=@UICode ORDER BY BillCode DESC",
                        connection);
                command.Parameters.Add("@Prefix",SqlDbType.VarChar,10).Value=prefix;
                code = (string) command.ExecuteScalar();
                connection.Close();
            }
            return code;
        }

        /// <summary>
        /// 获取新的单据编号
        /// </summary>
        /// <returns></returns>
        public static string GetNewPurchaseBillCode(string prefix, string uiCode)
        {
            string code = string.Empty;
            using (SqlConnection connection = new SqlConnection(GlobalItem.g_DbConnectStrings))
            {
                if (connection.State != ConnectionState.Open)
                {
                    connection.Open();
                }
                var command =
                    new SqlCommand("SET NOCOUNT ON; INSERT INTO [dbo].[BUS_PurchaseBillCode]([Prefix],[UICode]) VALUES(@Prefix,@UICode);SELECT TOP 1 Prefix+BillCode FROM [dbo].[BUS_PurchaseBillCode] WHERE UICode=@UICode ORDER BY BillCode DESC",
                        connection);
                command.Parameters.Add("@Prefix",SqlDbType.VarChar,10).Value=prefix;
                command.Parameters.Add("@UICode",SqlDbType.NVarChar,60).Value=uiCode;
                code = (string) command.ExecuteScalar();
                connection.Close();
            }
            return code;
        }
        /// <summary>
        /// 获取新的单据编号
        /// </summary>
        /// <returns></returns>
        public static string GenPurchaseBillCode(string prefix)
        {
            string code = string.Empty;
            using (SqlConnection connection = new SqlConnection(GlobalItem.g_DbConnectStrings))
            {
                if (connection.State != ConnectionState.Open)
                {
                    connection.Open();
                }
                var command =
                    new SqlCommand("SET NOCOUNT ON; DECLARE @UICODE NVARCHAR(50)=CONVERT(VARCHAR(50), GETDATE(), 25);INSERT INTO [dbo].[BUS_PurchaseBillCode]([Prefix],[UICode]) VALUES(@Prefix,@UICODE);SELECT TOP 1 Prefix+BillCode FROM [dbo].[BUS_PurchaseBillCode] WHERE UICode=@UICode ORDER BY BillCode DESC",
                        connection);
                command.Parameters.Add("@Prefix",SqlDbType.VarChar,10).Value=prefix;
                code = (string) command.ExecuteScalar();
                connection.Close();
            }
            return code;
        }

        #endregion

        #region 登录加密

        /// <summary>
        /// 获取MD5加密字符串
        /// </summary>
        /// <param name="input">要加进加密的字符串</param>
        /// <returns>加密后的字符串</returns>
        public static string GetEncryptPassword(string input)
        {
            using (MD5 md5 = new MD5CryptoServiceProvider())
            {
                byte[] bytes_md5_in = UTF8Encoding.Default.GetBytes(input);
                byte[] bytes_md5_out = md5.ComputeHash(bytes_md5_in);
                return BitConverter.ToString(bytes_md5_out).Replace("-", "");
            }
        }

        #endregion

        #region 电子证书

        /// <summary>
        /// 下载附件
        /// </summary>
        /// <param name="attachmentID">附件ID</param>
        /// <param name="fullName">下载后的附件名称</param>
        public static void DownAttachment(int attachmentID, string fullName)
        {
            try
            {
                SqlDataReader dataReader = null;
                using (SqlConnection connection = new SqlConnection { ConnectionString = GlobalItem.g_DbConnectStrings })
                {
                    using (SqlCommand command = new SqlCommand { Connection = connection })
                    {
                        connection.Open();
                        command.CommandText = "SELECT AttachmentContent FROM BFI_QualificationAttachment WHERE AttachmentID = " + attachmentID;
                        dataReader = command.ExecuteReader();
                        byte[] file = null;

                        if (dataReader.Read())
                        {
                            file = (byte[])dataReader[0];
                        }
                        if (dataReader != null)
                        {
                            dataReader.Close();
                        }

                        connection.Close();

                        FileStream stream;
                        FileInfo fInfo = new FileInfo(fullName);
                        stream = fInfo.OpenWrite();
                        stream.Write(file, 0, file.Length);
                        stream.Close();
                    }
                }
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        /// <summary>
        /// 下载附件
        /// </summary>
        /// <param name="tableName">表名称</param>
        /// <param name="primaryKeyName">主键名称</param>
        /// <param name="attachmentID">附件ID</param>
        /// <param name="fullName">下载后的附件名称</param>
        /// <param name="contentFieldName">附件内容字段名称</param>
        public static void DownAttachment(string tableName, string contentFieldName, string primaryKeyName, int attachmentID, string fullName)
        {
            try
            {
                SqlDataReader dataReader = null;
                using (SqlConnection connection = new SqlConnection { ConnectionString = GlobalItem.g_DbConnectStrings })
                {
                    using (SqlCommand command = new SqlCommand { Connection = connection })
                    {
                        connection.Open();
                        command.CommandText = string.Format("SELECT {0} FROM {1} WHERE {2} = {3}", contentFieldName, tableName, primaryKeyName, attachmentID);
                        dataReader = command.ExecuteReader();
                        byte[] file = null;

                        if (dataReader.Read())
                        {
                            file = (byte[])dataReader[0];
                        }
                        if (dataReader != null)
                        {
                            dataReader.Close();
                        }

                        connection.Close();

                        FileStream stream;
                        FileInfo fInfo = new FileInfo(fullName);
                        stream = fInfo.OpenWrite();
                        stream.Write(file, 0, file.Length);
                        stream.Close();
                    }
                }
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        /// <summary>
        /// 转换文件大小
        /// </summary>
        /// <param name="fileSize">要转换的文件长度</param>
        /// <returns>文件大小</returns>
        public static string FormatFileSize(long fileSize)
        {
            if (fileSize < 0)
            {
                throw new ArgumentOutOfRangeException("fileSize");
            }
            else if (fileSize >= 1024 * 1024 * 1024)
            {
                return string.Format("{0:########0.00} GB", ((Double)fileSize) / (1024 * 1024 * 1024));
            }
            else if (fileSize >= 1024 * 1024)
            {
                return string.Format("{0:####0.00} MB", ((Double)fileSize) / (1024 * 1024));
            }
            else if (fileSize >= 1024)
            {
                return string.Format("{0:####0.00} KB", ((Double)fileSize) / 1024);
            }
            else
            {
                return string.Format("{0} 字节", fileSize);
            }
        }

        #endregion

        #region 汉字转换

        /// <summary>
        /// 获取汉字字符串各字符的首字母拼音
        /// </summary>
        /// <param name="chineseStr">汉字字符串</param>
        /// <returns>首字母拼音字符串</returns>
        public static string GetAlphabetic(string chineseStr)
        {
            string capstr = string.Empty;
            byte[] ZW = new byte[2];
            long chineseStr_int;
            string charStr, chinaStr = "";
            for (int i = 0; i <= chineseStr.Length - 1; i++)
            {
                charStr = chineseStr.Substring(i, 1).ToString();
                ZW = Encoding.Default.GetBytes(charStr);
                //得到汉字符的字节数组
                if (ZW.Length == 2)
                {
                    int i1 = (short)(ZW[0]);
                    int i2 = (short)(ZW[1]);
                    chineseStr_int = i1 * 256 + i2;
                    if ((chineseStr_int >= 45217) && (chineseStr_int <= 45252))
                    {
                        chinaStr = "a";
                    }
                    else if ((chineseStr_int >= 45253) && (chineseStr_int <= 45760))
                    {
                        chinaStr = "b";
                    }
                    else if ((chineseStr_int >= 45761) && (chineseStr_int <= 46317))
                    {
                        chinaStr = "c";

                    }
                    else if ((chineseStr_int >= 46318) && (chineseStr_int <= 46825))
                    {
                        chinaStr = "d";
                    }
                    else if ((chineseStr_int >= 46826) && (chineseStr_int <= 47009))
                    {
                        chinaStr = "e";
                    }
                    else if ((chineseStr_int >= 47010) && (chineseStr_int <= 47296))
                    {
                        chinaStr = "f";
                    }
                    else if ((chineseStr_int >= 47297) && (chineseStr_int <= 47613))
                    {
                        chinaStr = "g";
                    }
                    else if ((chineseStr_int >= 47614) && (chineseStr_int <= 48118))
                    {

                        chinaStr = "h";
                    }
                    else if ((chineseStr_int >= 48119) && (chineseStr_int <= 49061))
                    {
                        chinaStr = "j";
                    }
                    else if ((chineseStr_int >= 49062) && (chineseStr_int <= 49323))
                    {
                        chinaStr = "k";
                    }
                    else if ((chineseStr_int >= 49324) && (chineseStr_int <= 49895))
                    {
                        chinaStr = "l";
                    }
                    else if ((chineseStr_int >= 49896) && (chineseStr_int <= 50370))
                    {
                        chinaStr = "m";
                    }

                    else if ((chineseStr_int >= 50371) && (chineseStr_int <= 50613))
                    {
                        chinaStr = "n";

                    }
                    else if ((chineseStr_int >= 50614) && (chineseStr_int <= 50621))
                    {
                        chinaStr = "o";
                    }
                    else if ((chineseStr_int >= 50622) && (chineseStr_int <= 50905))
                    {
                        chinaStr = "p";

                    }
                    else if ((chineseStr_int >= 50906) && (chineseStr_int <= 51386))
                    {
                        chinaStr = "q";

                    }
                    else if ((chineseStr_int >= 51387) && (chineseStr_int <= 51445))
                    {
                        chinaStr = "r";
                    }
                    else if ((chineseStr_int >= 51446) && (chineseStr_int <= 52217))
                    {
                        chinaStr = "s";
                    }
                    else if ((chineseStr_int >= 52218) && (chineseStr_int <= 52697))
                    {
                        chinaStr = "t";
                    }
                    else if ((chineseStr_int >= 52698) && (chineseStr_int <= 52979))
                    {
                        chinaStr = "w";
                    }
                    else if ((chineseStr_int >= 52980) && (chineseStr_int <= 53640))
                    {
                        chinaStr = "x";
                    }
                    else if ((chineseStr_int >= 53689) && (chineseStr_int <= 54480))
                    {
                        chinaStr = "y";
                    }
                    else if ((chineseStr_int >= 54481) && (chineseStr_int <= 55289))
                    {
                        chinaStr = "z";
                    }
                    capstr = capstr + chinaStr;
                }
                else
                {
                    capstr = capstr + charStr;
                }
            }
            return capstr;
        }



        public static string GetPYString(string str)
        {
            string tempStr = "";
            foreach (char c in str)
            {
                if ((int)c >= 33 && (int)c <= 126)
                {//字母和符号原样保留 
                    tempStr += c.ToString();
                }
                else
                {//累加拼音声母 
                    tempStr += GetPYChar(c.ToString());
                }
            }
            return tempStr;
        }
 
        /// 
        /// 取单个字符的拼音声母 
        /// 
        /// 要转换的单个汉字 
        /// 拼音声母 
        public static string GetPYChar(string c)
        {
            byte[] array = new byte[2];
            array = System.Text.Encoding.Default.GetBytes(c);
            int i = (short)(array[0] - '\0') * 256 + ((short)(array[1] - '\0'));
            if (i < 0xB0A1) return "*";
            if (i < 0xB0C5) return "a";
            if (i < 0xB2C1) return "b";
            if (i < 0xB4EE) return "c";
            if (i < 0xB6EA) return "d";
            if (i < 0xB7A2) return "e";
            if (i < 0xB8C1) return "f";
            if (i < 0xB9FE) return "g";
            if (i < 0xBBF7) return "h";
            if (i < 0xBFA6) return "g";
            if (i < 0xC0AC) return "k";
            if (i < 0xC2E8) return "l";
            if (i < 0xC4C3) return "m";
            if (i < 0xC5B6) return "n";
            if (i < 0xC5BE) return "o";
            if (i < 0xC6DA) return "p";
            if (i < 0xC8BB) return "q";
            if (i < 0xC8F6) return "r";
            if (i < 0xCBFA) return "s";
            if (i < 0xCDDA) return "t";
            if (i < 0xCEF4) return "w";
            if (i < 0xD1B9) return "x";
            if (i < 0xD4D1) return "y";
            if (i < 0xD7FA) return "z";
            return "*";
        }


        #endregion

        public static DataTable GetReviewByProduct(int productID,string batchNo,int dealerID,int departmentid)
        {
            string querySql = "";
            if (departmentid == 0)
            {
                querySql = String.Format("SELECT DISTINCT(复核ID),复核单号,复核日期,复核人员,销售单号,往来单位名称,业务员,备注 FROM vw_AllSaleBackReview WHERE 往来单位ID = '{0}' AND 产品ID = '{1}' AND [批号] = '{2}'", dealerID, productID, batchNo);
            }
            else
            {
                querySql = String.Format("SELECT DISTINCT(复核ID),复核单号,复核日期,复核人员,销售单号,往来单位名称,业务员,备注 FROM vw_AllSaleBackReview WHERE 往来单位ID = '{0}' AND 所属部门ID = {1} AND 产品ID = '{2}' AND [批号] = '{3}'", dealerID, departmentid, productID, batchNo);
            }
            using (DataSet dataSet = new DataSet())
            {
                using (SqlDataAdapter adapter = new SqlDataAdapter(querySql, GlobalItem.g_DbConnectStrings))
                {
                    adapter.Fill(dataSet);
                }
                return dataSet.Tables[0];
            }
        }
        /// <summary>
        /// 采购退回入库记录
        /// </summary>
        /// <param name="productID"></param>
        /// <param name="batchNo"></param>
        /// <returns></returns>
        public static DataTable GetStoreInByProduct(int productID,string batchNo ,int instoreid)
        {
            string querySql = "";
            if (instoreid == 0)
            {
                querySql = String.Format("SELECT DISTINCT(入库单ID),入库单编号,入库日期,入库员,订单ID,采购单编号,采购员,往来单位ID,往来单位编码,往来单位名称,往来单位地址,采购员	FROM vw_AllStoreInRecord WHERE 产品ID = '{0}' AND [批号] = '{1}'", productID, batchNo);
            }
            else
            {
                string sql = "SELECT InStoreCode,StoreTypeName FROM dbo.BUS_InStoreDetail WHERE InStoreID = " + instoreid;
                using (SqlConnection conn = new SqlConnection(GlobalItem.g_DbConnectStrings))
                {
                    SqlDataAdapter sdad = new SqlDataAdapter(sql, conn);
                    DataSet ds = new DataSet();
                    conn.Open();

                    sdad.Fill(ds, "Table");
                    string instorecode = ds.Tables["Table"].Rows[0]["InStoreCode"].ToString();
                    string type = ds.Tables["Table"].Rows[0]["StoreTypeName"].ToString();
                    if (type != "采购进货")
                    {
                        querySql = String.Format("SELECT DISTINCT(入库单ID),入库单编号,入库日期,入库员,订单ID,采购单编号,采购员,往来单位ID,往来单位编码,往来单位名称,往来单位地址,采购员	FROM vw_AllStoreInRecord WHERE 产品ID = '{0}' AND [批号] = '{1}'", productID, batchNo);
                    }
                    else
                    {
                        querySql = String.Format("SELECT DISTINCT(入库单ID),入库单编号,入库日期,入库员,订单ID,采购单编号,采购员,往来单位ID,往来单位编码,往来单位名称,往来单位地址,采购员	FROM vw_AllStoreInRecord WHERE 产品ID = '{0}' AND [批号] = '{1}' AND 入库单编号 = '{2}'", productID, batchNo, instorecode);
                    }
                }
            }
            using (DataSet dataSet = new DataSet())
            {
                using (SqlDataAdapter adapter = new SqlDataAdapter(querySql, GlobalItem.g_DbConnectStrings))
                {
                    adapter.Fill(dataSet);
                }
                return dataSet.Tables[0];
            }
        }
        /// <summary>
        /// 采购退回入库记录明细
        /// </summary>
        /// <param name="storeID"></param>
        /// <returns></returns>
        public static DataTable GetStoreInByProduct(int storeID)
        {
            string querySql = String.Format("SELECT 产品ID,产品编号, 产品名称, 生产厂商, 包装规格型号, 包装比例, 注册证号, 存储条件, 类别, 单位, [批号], 生产日期, 有效期至,单价,数量 FROM dbo.vw_AllStoreInRecord WHERE 入库单ID = '{0}'", storeID);
            using (DataSet dataSet = new DataSet())
            {
                using (SqlDataAdapter adapter = new SqlDataAdapter(querySql, GlobalItem.g_DbConnectStrings))
                {
                    adapter.Fill(dataSet);
                }
                return dataSet.Tables[0];
            }
        }

        public static DataTable GetReviewDetialByProduct(string reviewCode)
        {
            string querySql = String.Format("SELECT 产品ID, 产品编号, 产品名称, 生产厂商, 规格型号, 包装规格型号, 包装比例,业务员, 注册证号, 贮藏条件, 产品类别, 单位, [批号], 生产日期, 有效期至, 出库数量, 复核数量, 单价, 入库ID,批发价,零售价 FROM vw_AllSaleBackReview WHERE 复核单号 = '{0}'", reviewCode);
            using (DataSet dataSet = new DataSet())
            {
                using (SqlDataAdapter adapter = new SqlDataAdapter(querySql, GlobalItem.g_DbConnectStrings))
                {
                    adapter.Fill(dataSet);
                }
                return dataSet.Tables[0];
            }
        }

        public static DataSet GetWarningData()
        {
            string querySql = "SELECT * FROM vw_StoreDetail WHERE 过期状态 IN ('已过期','即将过期')";
            using (DataSet dataSet = new DataSet())
            {
                using (SqlDataAdapter adapter = new SqlDataAdapter(querySql, GlobalItem.g_DbConnectStrings))
                {
                    adapter.Fill(dataSet,"产品效期预警");
                }

                querySql = "SELECT * FROM vw_StoreDetail WHERE 锁定状态='已锁定'";
                using (SqlDataAdapter adapter = new SqlDataAdapter(querySql, GlobalItem.g_DbConnectStrings))
                {
                    adapter.Fill(dataSet, "产品锁定预警");
                }

                querySql = "SELECT 供应商编号, 供应商名称, 档案编号, 档案名称, 证书类型, 证书编号, 发证机关, 发证日期, 到期日期, 到期状态 FROM vw_DealerQualificationWithParent WHERE 到期状态 IN ('已过期','即将过期')";
                using (SqlDataAdapter adapter = new SqlDataAdapter(querySql, GlobalItem.g_DbConnectStrings))
                {
                    adapter.Fill(dataSet, "供应商电子档案到期预警");
                }

                querySql = "SELECT 客户编号, 客户名称, 档案编号, 档案名称, 证书类型, 证书编号, 发证机关, 发证日期, 到期日期, 到期状态 FROM vw_ProviderQualificationWithParent WHERE 到期状态 IN ('已过期','即将过期')";
                using (SqlDataAdapter adapter = new SqlDataAdapter(querySql, GlobalItem.g_DbConnectStrings))
                {
                    adapter.Fill(dataSet, "客户电子档案到期预警");
                }

                querySql = "SELECT 产品编号, 产品名称,包装规格,生产厂商, 档案编号, 档案名称, 证书类型, 证书编号, 发证机关, 发证日期, 到期日期, 到期状态 FROM vw_ProductQualificationWithParent WHERE 到期状态 IN ('已过期','即将过期')";
                using (SqlDataAdapter adapter = new SqlDataAdapter(querySql, GlobalItem.g_DbConnectStrings))
                {
                    adapter.Fill(dataSet, "产品电子档案到期预警");
                }

                querySql = "SELECT OldLicenseValidateDate AS 原到期日期, NewLicenseValidateDate AS 新到期日期, ActionName AS 状态, LockDate AS 锁定日期, UnLockDate AS 解锁日期, CreateUserName AS 操作人 FROM dbo.BFI_EnterpriseLicenseLockHistory ORDER BY EnterpriseLicenseLockHistoryID DESC";
                using (SqlDataAdapter adapter = new SqlDataAdapter(querySql, GlobalItem.g_DbConnectStrings))
                {
                    adapter.Fill(dataSet, "本企业营业执照到期日锁定记录");
                }

                querySql = "SELECT OldLicenseValidateDate AS 原到期日期, NewLicenseValidateDate AS 新到期日期, ActionName AS 状态, LockDate AS 锁定日期, UnLockDate AS 解锁日期, CreateUserName AS 操作人 FROM dbo.BFI_EnterpriseTradeLicenseLockHistory ORDER BY EnterpriseTradeLicenseLockHistoryID DESC";
                using (SqlDataAdapter adapter = new SqlDataAdapter(querySql, GlobalItem.g_DbConnectStrings))
                {
                    adapter.Fill(dataSet, "本企业经营许可证到期日锁定记录");
                }

                querySql = "SELECT CONVERT(NVARCHAR(60),GSPValidateDate,23) GSP到期日期, CASE WHEN GSPValidateDate > GETDATE() THEN '即将过期'ELSE '已过期' END AS 过期状态 FROM dbo.BFI_Enterprise WHERE DATEADD(MONTH,1,GETDATE()) > GSPValidateDate";
                using (SqlDataAdapter adapter = new SqlDataAdapter(querySql, GlobalItem.g_DbConnectStrings))
                {
                    adapter.Fill(dataSet, "本企业GSP到期日预警");
                }

                querySql = "SELECT CONVERT(NVARCHAR(60),TradeLicenseValidateDate,23) 经营许可证到期日期, CASE WHEN TradeLicenseValidateDate > GETDATE() THEN '即将过期'ELSE '已过期' END AS 过期状态 FROM dbo.BFI_Enterprise WHERE DATEADD(MONTH,1,GETDATE()) > TradeLicenseValidateDate";
                using (SqlDataAdapter adapter = new SqlDataAdapter(querySql, GlobalItem.g_DbConnectStrings))
                {
                    adapter.Fill(dataSet, "本企业经营许可证到期日预警");
                }

                querySql = "SELECT * FROM vw_Transport";
                using (SqlDataAdapter adapter = new SqlDataAdapter(querySql, GlobalItem.g_DbConnectStrings))
                {
                    adapter.Fill(dataSet, "运输时限预警");
                }
                return dataSet;
            }
        }
        //全局销退允许不选复核单标记 - 用于非本系统销售数据退货
        public static bool AllowNoReviewSaleBack { get; set; }


        //全局采退允许不选出库单标记 - 用于非本系统采购数据退货
        public static bool AllowNoStoreInPurchaseBack { get; set; }
    }
}
