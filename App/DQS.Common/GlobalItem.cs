using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;
using DQS.Module.Entities;
using ORMSCore;
using System.Configuration;

namespace DQS.Common
{
    public class GlobalItem
    {
        public static DataTable g_Functions;

        public static string g_DbConnectStrings;

        public static ATCUserEntity g_CurrentUser;

        public static BFIEmployeeEntity g_CurrentEmployee;

        public static bool g_IsLoginIn;

        static GlobalItem()
        {
            GlobalItem.g_DbConnectStrings = ConfigurationManager.ConnectionStrings["DbConnectStrings"].ConnectionString;
            CommonSettings.DbConnectStrings = g_DbConnectStrings;
            try
            {
                EntityCollection<SYSFunctionEntity> functions = new EntityCollection<SYSFunctionEntity>();
                DataTable data = functions.FetchTable();
                data.DefaultView.Sort = "FunctionSort";
                g_Functions = data.DefaultView.ToTable();
            }
            catch (Exception)
            {

            }
        }
    }
}
