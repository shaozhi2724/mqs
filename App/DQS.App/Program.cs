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

        #if RockeyLicense

        private static RockeyLicenseManager _rockeyLicenseManager;

        public static RockeyLicenseManager RockeyLicenseManager
        {
            get { return _rockeyLicenseManager; }
            set { _rockeyLicenseManager = value; }
        }

        #endif

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

            string featureName = "MQS";
            string passCode = "_bokesys_com_";
            bool isThrowLicenseException = true;
            int licenseCheckTimes = 0;
            string reportScriptFile = Path.Combine(AppDomain.CurrentDomain.BaseDirectory, "ReportFunction.cs");
            if (!File.Exists(reportScriptFile))
            {
                File.AppendAllText(reportScriptFile, Resources.ReportFunction);
            }

            //if (Process.GetProcessesByName(Process.GetCurrentProcess().ProcessName).Length > 1)
            //{
            //    XtraMessageBox.Show("DQS质量安全管理系统正在运行中,不能重复启动.", "系统提示", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            //}
            //else
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
#elif RockeyLicense
                #region 加密锁授权方式
                string pid = Settings.Default.PID_Rockey;
                string pin = Settings.Default.PIN_Rockey;
                _rockeyLicenseManager = new RockeyLicenseManager(pid, pin);
                if (_rockeyLicenseManager.Find())
                {
                    _rockeyLicenseManager.Open();
                    if (!_rockeyLicenseManager.IsOpened)
                    {
                        XtraMessageBox.Show("未检测到密钥锁连接，请检查后重试！", "系统错误", MessageBoxButtons.OK, MessageBoxIcon.Error, MessageBoxDefaultButton.Button1);

                        Application.Exit();
                        return;
                    }
                }
                else
                {
                    XtraMessageBox.Show("未检测到密钥锁，请插入密钥锁后重试！", "系统错误", MessageBoxButtons.OK, MessageBoxIcon.Error, MessageBoxDefaultButton.Button1);

                    Application.Exit();
                    return;
                }

                Application.Run(new FrmLogin());
                if (GlobalItem.g_IsLoginIn)
                {
                    Application.Run(new FrmMain());
                }

                #endregion
#elif SoftFileLicense
                #region 软授权方式
                if (!File.Exists(_licensePath))
                {
                    //DQS还未注册，请联系
                    if (DialogResult.OK ==
                        XtraMessageBox.Show("MQS还未注册，请联系软件提供商并提供注册标识", "系统错误", MessageBoxButtons.OK,
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
#else
                Application.Run(new FrmLogin());
                if (GlobalItem.g_IsLoginIn)
                {
                    Application.Run(new FrmMain());
                }
#endif
            }

        }

        static void Application_ApplicationExit(object sender, EventArgs e)
        {
            #if SenseLockLicense
            if (SENSE4CONTEXT.HasValue)
            {
                //SenseLockKeyManager.Close(SENSE4CONTEXT.Value);
            }
            #endif
        }

        
            #if SenseLockLicense
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
#endif

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
