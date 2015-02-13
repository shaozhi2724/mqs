using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using DevExpress.XtraEditors;
using System.Drawing;
using DQS.Module;
using System.Data;
using System.ComponentModel;
using DevExpress.XtraEditors.Controls;

namespace DQS.Controls
{
    public class ComboBoxEx : ComboBoxEdit
    {
        public ComboBoxEx()
        {
            this.Properties.TextEditStyle = TextEditStyles.DisableTextEditor;
        }

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
        /// 要绑定的数据源
        /// </summary>
        [Browsable(false)]
        public DataTable DataSource { get; set; }

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

        /// <summary>
        /// 将数据源绑定到控件上
        /// </summary>
        public void BindSource()
        {
            if (this.DataSource != null)
            {
                if (!string.IsNullOrEmpty(this.MemberText))
                {
                    foreach (DataRow row in this.DataSource.Rows)
                    {
                        this.Properties.Items.Add(row[this.MemberText].ToString());
                    }
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
                if (this.DataSource != null)
                {
                    if (this.SelectedIndex >= 0)
                    {
                        if (!string.IsNullOrEmpty(MemberValue))
                        {
                            if (this.DataSource.Columns.Contains(this.MemberValue))
                            {
                                return this.DataSource.Rows[this.SelectedIndex][this.MemberValue];
                            }
                        }
                        
                    }
                }
                return null;
            }
            set
            {
                if (this.DataSource != null)
                {
                    if (!string.IsNullOrEmpty(this.MemberValue))
                    {
                        for (int i = 0; i < this.DataSource.Rows.Count; i++)
                        {
                            DataRow row = this.DataSource.Rows[i];

                            if (this.DataSource.Columns.Contains(this.MemberValue))
                            {
                                if (row[this.MemberValue].ToString().Trim() == value.ToString().Trim())
                                {
                                    this.SelectedIndex = i;
                                    break;
                                }
                            }
                        }
                    }
                }
            }
        }
        

    }
}
