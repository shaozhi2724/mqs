using DQS.Common;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;

namespace DQS.AppViews.Operation
{
    public static class GetSettingValue
    {
        public static bool GetSettingValueFor(string PageFunctionCode)
        {
            string sql = "SELECT IsEnable FROM dbo.SYS_PromSetting WHERE PageFunctionCode = '" + PageFunctionCode + "'";
            bool isenable = true;
            using (SqlConnection conn = new SqlConnection(GlobalItem.g_DbConnectStrings))
            {
                conn.Open(); //连接数据库
                try
                {
                    SqlCommand cmd = new SqlCommand(sql, conn);
                    int enablevalue = int.Parse(cmd.ExecuteScalar().ToString());
                    isenable = enablevalue == 1 ? true : false;
                }
                catch (Exception ex)
                {
                    isenable = false;
                }
                finally
                {
                    conn.Close();
                }
            }
            return isenable;
        }
    }
}
