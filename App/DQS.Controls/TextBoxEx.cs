using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using DevExpress.XtraEditors;
using System.Drawing;
using System.ComponentModel;

namespace DQS.Controls
{
    public class TextBoxEx : TextEdit
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
        /// 文本框是否为空验证
        /// </summary>
        [Description("文本框是否为空验证")]
        public bool IsNullValidate { get; set; }

        /// <summary>
        /// 文本框为空后提示的字符串
        /// </summary>
        [Description("文本框为空后提示的字符串")]
        public string IsNullString { get; set; }

        /// <summary>
        /// 文本框汉字内容是否需要转换成首字母
        /// </summary>
        [Description("文本框汉字内容是否需要转换成首字母")]
        public bool IsTransferAlphabetic { get; set; }

        /// <summary>
        /// 文本框汉字内容转换成首字母需要赋值的字段
        /// </summary>
        [Description("文本框汉字内容转换成首字母需要赋值的字段")]
        public string AlphabeticFiled { get; set; }

        /// <summary>
        /// 是否只能输入数字
        /// </summary>
        [Description("是否只能输入数字")]
        public bool IsIntegerOnly { get; set; }

        protected override void OnKeyPress(System.Windows.Forms.KeyPressEventArgs e)
        {
            if (this.IsIntegerOnly)
            {
                if ((e.KeyChar < '0' || e.KeyChar > '9') && e.KeyChar != (char)8 && e.KeyChar != (char)46)
                {
                    e.Handled = true;
                }
                else
                {
                    e.Handled = false;
                }
            }
            base.OnKeyPress(e);
        }
    }
}
