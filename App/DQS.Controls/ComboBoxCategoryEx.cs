using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using DevExpress.XtraEditors;
using DevExpress.XtraEditors.Controls;
using System.Drawing;
using ORMSCore;
using DQS.Module.Entities;
using System.ComponentModel;

namespace DQS.Controls
{
    public class ComboBoxCategoryEx : ComboBoxEdit
    {
        private EntityCollection<SYSCategoryEntity> m_Categories;

        /// <summary>
        /// 要显示的类别编号
        /// </summary>
        [Description("要显示的类别编号")]
        public string CategoryCode { get; set; }


        public ComboBoxCategoryEx()
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

        public void InitSource()
        {
            if (!string.IsNullOrEmpty(this.CategoryCode))
            {
                this.Properties.Items.Clear();
                m_Categories = new EntityCollection<SYSCategoryEntity>();
                m_Categories.Fetch(SYSCategoryEntityFields.CategoryCode == this.CategoryCode);
                if(AddFirstDefaultItem)
                {
                    this.Properties.Items.Add(FirstDefaultItemText);
                }
                foreach (SYSCategoryEntity e in m_Categories)
                {
                    this.Properties.Items.Add(e.ItemName);
                }
            }
        }

        public void InitSource(Predicate filter)
        {
            if (!string.IsNullOrEmpty(this.CategoryCode))
            {
                m_Categories = new EntityCollection<SYSCategoryEntity>();
                PredicateExpression pe = new PredicateExpression();
                pe.Add(SYSCategoryEntityFields.CategoryCode == this.CategoryCode);
                pe.Add(filter);
                m_Categories.Fetch(pe);
                if(AddFirstDefaultItem)
                {
                    this.Properties.Items.Add(FirstDefaultItemText);
                }
                foreach (SYSCategoryEntity e in m_Categories)
                {
                    this.Properties.Items.Add(e.ItemName);
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
                if (this.m_Categories != null)
                {
                    if (!AddFirstDefaultItem)
                    {
                        if (this.SelectedIndex >= 0)
                        {
                            if (!string.IsNullOrEmpty(this.CategoryCode))
                            {
                                SYSCategoryEntity entity = this.m_Categories[this.SelectedIndex] as SYSCategoryEntity;
                                return entity.ItemID;
                            }
                        }
                    }
                    else
                    {
                        if (this.SelectedIndex > 0)
                        {
                            if (!string.IsNullOrEmpty(this.CategoryCode))
                            {
                                SYSCategoryEntity entity = this.m_Categories[this.SelectedIndex - 1] as SYSCategoryEntity;
                                return entity.ItemID;
                            }
                        }
                    }
                }
                return null;
            }
            set
            {
                if (this.m_Categories != null)
                {
                    if (!string.IsNullOrEmpty(this.CategoryCode))
                    {
                        for (int i = 0; i < this.m_Categories.Count; i++)
                        {
                            SYSCategoryEntity entity = this.m_Categories[i] as SYSCategoryEntity;

                            if (entity.ItemID.ToString() == value.ToString())
                            {
                                this.SelectedIndex = i;
                                break;
                            }

                            if(entity.ItemName == value.ToString())
                            {
                                this.SelectedIndex = i;
                                break;
                            }

                        }
                    }
                }
            }
        }

        /// <summary>
        /// 获取控件选择的Item
        /// </summary>
        /// <returns>Item</returns>
        public virtual object GetSelectedItem()
        {
            if (!AddFirstDefaultItem)
            {
                if (this.SelectedIndex >= 0)
                {
                    return this.m_Categories[this.SelectedIndex];
                }
            }
            else
            {
                if(this.SelectedIndex > 0)
                {
                    return this.m_Categories[this.SelectedIndex - 1];
                }
            }
            return null;
        }


        /// <summary>
        /// 要转换的查询字符串
        /// </summary>
        [Description("要转换的查询字符串")]
        public string FormatQueryString
        {
            get;
            set;
        }
        /// <summary>
        /// 是否在第一项加全部选项
        /// </summary>
        [Description("是否在第一项加全部选项")]
        public bool AddFirstDefaultItem
        {
            get;
            set;
        }
        /// <summary>
        /// 默认第一项文本
        /// </summary>
        [Description("默认第一项文本")]
        public string FirstDefaultItemText
        {
            get;
            set;
        }
    }
}
