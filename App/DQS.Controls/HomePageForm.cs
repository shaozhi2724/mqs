using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using DevExpress.XtraEditors;
using System.Data;
using System.Windows.Forms;

namespace DQS.Controls
{
    public class HomePageForm : XtraForm
    {
        /// <summary>
        /// 设置没有权限的菜单按钮灰显
        /// </summary>
        /// <param name="data"></param>
        public void SetMenuAuthority(DataTable data)
        {
            foreach (Control c in this.Controls)
            {
                if (c is ToolButton)
                {
                    ToolButton b = c as ToolButton;
                    DataRow[] rows = data.Select(String.Format("MenuCode = '{0}'", b.MenuCode));
                    if (rows.Length == 0)
                    {
                        b.Enabled = false;
                    }
                }
            }
        }
    }
}
