using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using DevExpress.XtraEditors;
using System.Drawing;
using System.ComponentModel;

namespace DQS.Controls
{
    public class TextBoxQueryEx : TextEdit
    {
        protected override void OnGotFocus(EventArgs e)
        {
            this.BackColor = Color.Azure;
            base.OnGotFocus(e);
        }

        protected override void OnLostFocus(EventArgs e)
        {
            this.BackColor = Color.White;
            base.OnLostFocus(e);
        }

        /// <summary>
        /// 要转换的查询字符串
        /// </summary>
        [Description("要转换的查询字符串")]
        public string FormatQueryString { get; set; }

    }
}
