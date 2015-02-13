using DevExpress.XtraEditors;
using DevExpress.XtraGrid.Views.Grid;
using DQS.Common;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace DQS.App
{
    public partial class FrmApproveNotifications : XtraUserControl
    {
        public FrmApproveNotifications()
        {
            InitializeComponent();
        }
        private void FrmApproveNotifications_Load(object sender, EventArgs e)
        {
            BindInProcessNotifications();
        }

        private void BindProcessedNotifications()
        {
            DataTable dataTable = new DataTable();
            using (SqlConnection connection = new SqlConnection(GlobalItem.g_DbConnectStrings))
            {
                var sql = @"SELECT 
                            D.DocumentName AS 类型,
                            TargetCode AS 项目编号,
                            [CreateUserName] AS 申请人,
                            [CreateDate] AS 申请时间,
                            [ReadTime] AS 处理时间
                            FROM [dbo].[ATC_ApproveNotification] AS AP
                            LEFT JOIN dbo.SYS_Document AS D
                            ON AP.FormClass=D.DocumentCode 
                            WHERE IsRead=1 AND OwnerUserID='" + GlobalItem.g_CurrentUser.UserID + "' ORDER BY ReadTime DESC";
                using (SqlCommand command = new SqlCommand(sql, connection))
                {
                    if (connection.State != ConnectionState.Open)
                    {
                        connection.Open();
                    }

                    dataTable.Clear();
                    dataTable.Load(command.ExecuteReader(CommandBehavior.CloseConnection));
                    gridProcessed.DataSource = dataTable;
                    (gridProcessed.MainView as GridView).BestFitColumns();
                }
            }
        }

        private void BindInProcessNotifications()
        {
            DataTable dataTable = new DataTable();
            using (SqlConnection connection = new SqlConnection(GlobalItem.g_DbConnectStrings))
            {
                var sql = @"SELECT 
                            D.DocumentName AS 类型,
                            TargetCode AS 项目编号,
                            [CreateUserName] AS 申请人,
                            [CreateDate] AS 申请时间
                            FROM [dbo].[ATC_ApproveNotification] AS AP
                            LEFT JOIN dbo.SYS_Document AS D
                            ON AP.FormClass=D.DocumentCode 
                            WHERE IsRead=0 AND OwnerUserID='" + GlobalItem.g_CurrentUser.UserID + "' ORDER BY ApproveNotificationID DESC";
                using (SqlCommand command = new SqlCommand(sql, connection))
                {
                    if (connection.State != ConnectionState.Open)
                    {
                        connection.Open();
                    }

                    dataTable.Clear();
                    dataTable.Load(command.ExecuteReader(CommandBehavior.CloseConnection));
                    gridNotProcess.DataSource = dataTable;
                    (gridNotProcess.MainView as GridView).BestFitColumns();
                }
            }
        }

        private void xtcMain_SelectedPageChanged(object sender, DevExpress.XtraTab.TabPageChangedEventArgs e)
        {
            if (e.Page.Text == "已处理消息")
            {
                BindProcessedNotifications();
            }
            else
            {
                BindInProcessNotifications();
            }
        }
    }
}
