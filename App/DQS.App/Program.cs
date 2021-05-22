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

        /// <summary>
        /// 应用程序的主入口点。
        /// </summary>
        [STAThread]
        private static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            //Application.Run(new FrmCreateXml());  //唐县定时生成xml文件
            Application.Run(new FrmHG());
        }
    }
}
