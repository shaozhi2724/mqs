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
    
    public class TextBoxPopupMultipleEx : TextBoxEx
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

        public TextBoxPopupMultipleEx()
        {
            this.Properties.ReadOnly = true;
            this.BackColor = Color.White;
        }

        /// <summary>
        /// 弹出窗体查询的转换字符串
        /// </summary>
        [Description("弹出窗体查询的转换字符串")]
        public string FormatQueryString { get; set; }

        /// <summary>
        /// 弹出窗体要显示的视图名称
        /// </summary>
        [Description("弹出窗体要显示的视图名称")]
        public string ViewName { get; set; }

        /// <summary>
        /// 视图中的主键，ROW_NUMBER分页使用
        /// </summary>
        [Description("视图中的主键，ROW_NUMBER分页使用")]
        public string PrimaryField { get; set; }

        /// <summary>
        /// 要显示的字段，以','号分隔，可由'*'号代替
        /// </summary>
        [Description("要显示的字段，以','号分隔，可由'*'号代替")]
        public string Fields { get; set; }

        /// <summary>
        /// 查询条件,以'AND'分隔
        /// </summary>
        [Description("查询条件,以'AND'分隔")]
        public string Filter { get; set; }

        /// <summary>
        /// 每页大小
        /// </summary>
        [Description("每页大小")]
        public int PageSize
        {
            get;
            set;
        }

        [Description("分组字段名称")]
        public string GroupColumn
        {
            get;
            set;
        }

        /// <summary>
        /// 要显示的Text
        /// </summary>
        [Description("要显示的Text")]
        public string MemberText { get; set; }

        /// <summary>
        /// 要获取的Value
        /// </summary>
        [Description("要获取的Value")]
        public string MemberValue { get; set; }

        [Browsable(false)]
        internal object[] EditValue2 { get; set; }

        /// <summary>
        /// 控件的编辑数据
        /// </summary>
        [Browsable(false)]
        public DataRow[] EditData { get; set; }

        protected override void OnClick(EventArgs e)
        {
            if (string.IsNullOrEmpty(this.FormatQueryString))
            {
                this.Text = String.Format("控件 {0} 未设置属性 FormatQueryString 。", this.Name);
                this.ForeColor = Color.Red;
                this.Select(this.Text.Length, 0);
                return;

            }

            if (string.IsNullOrEmpty(this.ViewName))
            {
                this.Text = String.Format("控件 {0} 未设置属性 ViewName 。", this.Name);
                this.ForeColor = Color.Red;
                this.Select(this.Text.Length, 0);
                return;
            }

            if (string.IsNullOrEmpty(this.PrimaryField))
            {
                this.Text = String.Format("控件 {0} 未设置属性 PrimaryField 。", this.Name);
                this.ForeColor = Color.Red;
                this.Select(this.Text.Length, 0);
                return;
            }

            if (string.IsNullOrEmpty(this.Fields))
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

            using (FrmPopupQueryMultiple popup = new FrmPopupQueryMultiple(this))
            {
                if(!string.IsNullOrWhiteSpace(GroupColumn))
                {
                    popup.GroupColumn = GroupColumn;
                }
                if (popup.ShowDialog(this) == DialogResult.OK)
                {
                    if (this.PopupClosing != null)
                    {
                        this.PopupClosing(this, e);
                    }
                    this.EditData = popup.EditRows;
                }
            }

            base.OnClick(e);
        }

        public void SetMemberValue(object value)
        {
            if (!string.IsNullOrEmpty(this.MemberValue))
            {
                if (string.IsNullOrEmpty(this.ViewName) || string.IsNullOrEmpty(this.MemberText) || string.IsNullOrEmpty(this.MemberValue))
                {
                    return;
                }
                List<DataRow> dataRows = new List<DataRow>();
                DataRowCollection rows = GlobalMethod.GetPopupRows(this.ViewName, string.IsNullOrEmpty(this.Fields) ? "*" : this.Fields, this.MemberValue, value.ToString());
                foreach (DataRow row in rows)
                {
                    dataRows.Add(row);
                }
                this.EditData = dataRows.ToArray();
                List<string> values = new List<string>();
                if (this.EditData != null)
                {
                    values = dataRows.Select(p => p[MemberText].ToString()).ToList();
                    this.Text = string.Join(",", values); //(this.EditData as DataRow)[MemberText].ToString();
                }
                //this.Text = GlobalMethod.GetPopupText(this.ViewName, this.MemberText, this.MemberValue, value.ToString());
                this.EditValue2 = values.ToArray();

                if (this.MemberValueChanged != null)
                {
                    this.MemberValueChanged(this, new EventArgs());
                }
            }
        }

        /// <summary>
        /// 获取控件选择的Value
        /// </summary>
        [Browsable(false)]
        public virtual object SelectedValue
        {
            get
            {
                return this.EditValue2;
            }
        }
    }
}
