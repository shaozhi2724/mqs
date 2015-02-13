using System;
using System.Drawing;
using System.Windows.Forms;
using DevExpress.XtraEditors;

namespace DQS.Updater
{
    static class Program
    {
        [STAThread]
        static void Main(string[] args)
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            System.Threading.Thread.CurrentThread.CurrentUICulture = new System.Globalization.CultureInfo("zh-CN");
            DevExpress.Utils.AppearanceObject.DefaultFont = new Font("微软雅黑", 9F);
            DevExpress.UserSkins.BonusSkins.Register();
            DevExpress.UserSkins.OfficeSkins.Register();
            DevExpress.Skins.SkinManager.EnableFormSkins();
            DevExpress.Skins.SkinManager.EnableMdiFormSkins();
            // 设置皮肤
            DevExpress.LookAndFeel.UserLookAndFeel.Default.SetSkinStyle("McSkin");
            if (args.Length != 2)
            {
                XtraMessageBox.Show("升级程序未发现必需清单和可执行参数。", "升级错误", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            // TODO : better error messages
            var f = new UpdateForm();
            f.Manifest = args[0];
            f.Executible = args[1];
            Application.Run(f);
        }
    }
}
