using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.ComponentModel;
using DevExpress.XtraEditors;
using System.Drawing;
using DQS.Common;
using System.Data;
using DQS.Controls.CommonCode;

namespace DQS.Controls
{
    
    public class TextBoxEnterPopupEx : TextBoxPopupEx
    {
        public delegate void OnPopupClosingDelegate(object sender, EventArgs e);

        [Description("弹出窗体关闭时事件")]
        public event OnPopupClosingDelegate PopupClosing;

        public delegate void OnBeforePopupShowEventHandler(object sender, BeforePopupShowArgs e);

        [Description("窗体弹出之前触发的事件")]
        public event OnBeforePopupShowEventHandler BeforePopupShow;

        public delegate void OnMemberValueChangedDelegate(object sender, EventArgs e);

        [Description("MemberValue值改变时事件")]
        public event OnMemberValueChangedDelegate MemberValueChanged;

        public TextBoxEnterPopupEx()
        {
            this.Properties.ReadOnly = true;
            this.BackColor = Color.White;
        }

        protected override void OnKeyDown(KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                if (string.IsNullOrEmpty(FormatQueryString))
                {
                    this.Text = String.Format("控件 {0} 未设置属性 FormatQueryString 。", this.Name);
                    this.ForeColor = Color.Red;
                    this.Select(this.Text.Length, 0);
                    return;

                }

                if (string.IsNullOrEmpty(ViewName))
                {
                    this.Text = String.Format("控件 {0} 未设置属性 ViewName 。", this.Name);
                    this.ForeColor = Color.Red;
                    this.Select(this.Text.Length, 0);
                    return;
                }

                if (string.IsNullOrEmpty(PrimaryField))
                {
                    this.Text = String.Format("控件 {0} 未设置属性 PrimaryField 。", this.Name);
                    this.ForeColor = Color.Red;
                    this.Select(this.Text.Length, 0);
                    return;
                }

                if (string.IsNullOrEmpty(Fields))
                {
                    this.Fields = "*";
                }

                if (this.BeforePopupShow != null)
                {
                    BeforePopupShowArgs args = new BeforePopupShowArgs();
                    this.BeforePopupShow(this, args);
                    if (args.Cancel)
                    {
                        return;
                    }
                }

                using (FrmPopupQuery popup = new FrmPopupQuery(this))
                {
                    if (popup.ShowDialog(this) == DialogResult.OK)
                    {
                        if (this.PopupClosing != null)
                        {
                            this.PopupClosing(this, e);
                        }
                        EditData = popup.EditRow;
                    }
                }
            }
            base.OnKeyDown(e);
        }
        protected override void OnClick(EventArgs e)
        {
            return;
        }
    }
}
