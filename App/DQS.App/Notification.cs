using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Security.Permissions;
using System.Text;
using DQS.Common;

namespace DQS.App
{
    public class Notification
    {
        SqlDependency dependency = null;
        DataTable dataTable = new DataTable();

        public void Initialization()
        {
            SqlDependency.Stop(GlobalItem.g_DbConnectStrings);
            SqlDependency.Start(GlobalItem.g_DbConnectStrings);
        }

        public DataTable GetData(Action<object, SqlNotificationEventArgs> handler)
        {
            using (SqlConnection connection = new SqlConnection(GlobalItem.g_DbConnectStrings))
            {
                var sql = "SELECT [ApproveNotificationID],[OwnerUserID],[Message],[CreateUserID],[CreateUserName],[IsRead],[ReadTime],FormClass,TargetID FROM [dbo].[ATC_ApproveNotification] WHERE IsRead=0 AND OwnerUserID='" + GlobalItem.g_CurrentUser.UserID + "' ORDER BY ApproveNotificationID DESC";
                using (SqlCommand command = new SqlCommand(sql, connection))
                {

                    dependency = new SqlDependency();
                    command.Notification = null;

                    dependency.AddCommandDependency(command);
                    dependency.OnChange += new OnChangeEventHandler(handler);

                    if (connection.State != ConnectionState.Open)
                    {
                        connection.Open();
                    }

                    var ON_PARAMETERS = @"SET ANSI_NULLS, ANSI_PADDING, ANSI_WARNINGS, CONCAT_NULL_YIELDS_NULL, QUOTED_IDENTIFIER, ARITHABORT ON";
                    var OFF_PARAMETERS = @"SET NUMERIC_ROUNDABORT OFF";
                    var cmd_ON_PARAMETERS = new SqlCommand(ON_PARAMETERS, connection);
                    var cmd_OFF_PARAMETERS = new SqlCommand(OFF_PARAMETERS, connection);
                    cmd_ON_PARAMETERS.ExecuteNonQuery();
                    cmd_OFF_PARAMETERS.ExecuteNonQuery();

                    dataTable.Clear();
                    dataTable.Load(command.ExecuteReader(CommandBehavior.CloseConnection));
                    dependency = null;
                    return dataTable;
                }
            }
        }

        public void Termination()
        {
            SqlDependency.Stop(GlobalItem.g_DbConnectStrings);
        }

        public bool CanRequestNotifications()
        {
            try
            {
                SqlClientPermission perm = new SqlClientPermission(PermissionState.Unrestricted);
                perm.Demand();
                return true;
            }
            catch
            {
                return false;
            }
        }
    }
}
