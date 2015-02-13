using System;
using System.Collections.Generic;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Windows.Forms;
using DevExpress.Utils;
using System.Threading;
using System.Diagnostics;
using DevExpress.XtraEditors;
using DevExpress.XtraRichEdit.Model.History;
using DQS.App.Licenser;
using DQS.App.Properties;
using DQS.Common;

namespace DQS.App
{
    static class Program
    {
        static readonly string _licensePath = Path.Combine(AppDomain.CurrentDomain.BaseDirectory, "DQS.lic");

        /// <summary>
        /// 应用程序的主入口点。
        /// </summary>
        [STAThread]
        private static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.ApplicationExit += Application_ApplicationExit;
            System.Threading.Thread.CurrentThread.CurrentUICulture = new System.Globalization.CultureInfo("zh-CN");
            DevExpress.Utils.AppearanceObject.DefaultFont = new Font("微软雅黑", 9F);
            DevExpress.UserSkins.BonusSkins.Register();
            DevExpress.UserSkins.OfficeSkins.Register();
            DevExpress.Skins.SkinManager.EnableFormSkins();
            DevExpress.Skins.SkinManager.EnableMdiFormSkins();
            // 设置皮肤
            DevExpress.LookAndFeel.UserLookAndFeel.Default.SetSkinStyle("McSkin");

            Updater.UpdateUpdater();

            string featureName = "DQS";
            string passCode = "bokesys.com";
            bool isThrowLicenseException = true;
            int licenseCheckTimes = 0;
            string reportScriptFile = Path.Combine(AppDomain.CurrentDomain.BaseDirectory, "ReportFunction.cs");
            if (!File.Exists(reportScriptFile))
            {
                File.AppendAllText(reportScriptFile, Resources.ReportFunction);
            }

            if (Process.GetProcessesByName(Process.GetCurrentProcess().ProcessName).Length > 1)
            {
                XtraMessageBox.Show("DQS质量安全管理系统正在运行中,不能重复启动.", "系统提示", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
            else
            {

#if SenseLockLicense
                string message = string.Empty;
                if (!Program.CheckLicense(ref message))
                {
                    XtraMessageBox.Show(message, "系统错误", MessageBoxButtons.OK, MessageBoxIcon.Error);

                    Application.Exit();
                }
                else
                {
                    Application.Run(new FrmLogin());
                    if (GlobalItem.g_IsLoginIn)
                    {
                        Application.Run(new FrmMain());
                    }
                }
#else
                #region 软授权方式
                if (!File.Exists(_licensePath))
                {
                    //DQS还未注册，请联系
                    if (DialogResult.OK ==
                        XtraMessageBox.Show("DQS还未注册，请联系软件提供商并提供注册标识", "系统错误", MessageBoxButtons.OK,
                            MessageBoxIcon.Error))
                    {
                        licenseCheckTimes += 1;
                        CheckLicense(featureName, passCode, isThrowLicenseException, licenseCheckTimes);
                    }
                }
                else
                {
                    licenseCheckTimes += 1;
                    bool isValid = false;
                    try
                    {
                        isValid = new DQSLicenseManager().IsValid(_licensePath,
                            featureName,
                            passCode,
                            isThrowLicenseException);
                    }
                    catch (Exception)
                    {
                        CheckLicense(featureName, passCode, isThrowLicenseException, licenseCheckTimes);
                    }
                    if (isValid)
                    {
                        Application.Run(new FrmLogin());
                        if (GlobalItem.g_IsLoginIn)
                        {
                            Application.Run(new FrmMain());
                        }
                    }
                }

                #endregion
#endif
            }

        }

        static void Application_ApplicationExit(object sender, EventArgs e)
        {
            if (SENSE4CONTEXT.HasValue)
            {
                //SenseLockKeyManager.Close(SENSE4CONTEXT.Value);
            }
        }


        public static SenseLockKeyManager.SENSE4_CONTEXT? SENSE4CONTEXT = null;

        public static bool CheckLicense(ref string message)
        {
            try
            {
                SENSE4CONTEXT = SenseLockKeyManager.Open();
                return true;
            }
            catch (Exception ex)
            {
                message = ex.Message;
            }
            return false;
        }

        private static void CheckLicense(string featureName, string passCode, bool isThrowLicenseException,
            int licenseCheckTimes)
        {

            if (licenseCheckTimes == 4)
            {
                XtraMessageBox.Show("注册文件检测超过三次，系统将自动退出！", "系统错误", MessageBoxButtons.OK, MessageBoxIcon.Error);
                Application.Exit();
            }
            else
            {
                if (DialogResult.OK == new FrmLicenserIdentification().ShowDialog())
                {
                    licenseCheckTimes += 1;
                    try
                    {
                        bool isValid = new DQSLicenseManager().IsValid(_licensePath,
                            featureName,
                            passCode,
                            isThrowLicenseException);
                        if (isValid)
                        {
                            Application.Run(new FrmLogin());
                            if (GlobalItem.g_IsLoginIn)
                            {
                                Application.Run(new FrmMain());
                            }
                        }

                    }
                    catch (Exception ex)
                    {
                        if (ex is DQSLicenseManager.LicenseException)
                        {
                            CheckLicense(featureName, passCode, isThrowLicenseException, licenseCheckTimes);
                        }
                    }
                }
            }

        }
    }
}
