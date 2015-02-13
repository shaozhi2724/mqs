using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using DevExpress.XtraEditors;
using System.Drawing;
using System.ComponentModel;
using DQS.Module;
using ORMSCore;
using DQS.Module.Entities;
using System.Reflection;
using DevExpress.XtraEditors.Controls;

namespace DQS.Controls
{
    public class ComboBoxEntityEx : ComboBoxEdit
    {
        private EntityCollection<EntityBase> m_Entities;

        /// <summary>
        /// 要显示的实体
        /// </summary>
        [Description("要显示的实体")]
        public EntityType2 EntityType { get; set; }

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

        public ComboBoxEntityEx()
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
            if (!string.IsNullOrEmpty(this.MemberText))
            {
                string fullClass = String.Format("DQS.Module.Entities.{0}, DQS.Module", this.EntityType);
                EntityBase entity = Activator.CreateInstance(Type.GetType(fullClass)) as EntityBase;
                m_Entities = new EntityCollection<EntityBase>(entity);
                m_Entities.Fetch();

                foreach (EntityBase e in m_Entities)
                {
                    this.Properties.Items.Add(e.ToString(this.MemberText));
                }
            }
        }

        public void InitSource(Predicate predicate)
        {
            if (!string.IsNullOrEmpty(this.MemberText))
            {
                string fullClass = String.Format("DQS.Module.Entities.{0}, DQS.Module", this.EntityType);
                EntityBase entity = Activator.CreateInstance(Type.GetType(fullClass)) as EntityBase;
                m_Entities = new EntityCollection<EntityBase>(entity);
                m_Entities.Fetch(predicate);

                foreach (EntityBase e in m_Entities)
                {
                    this.Properties.Items.Add(e.ToString(this.MemberText));
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
                if (this.m_Entities != null)
                {
                    if (this.SelectedIndex >= 0)
                    {
                        if (!string.IsNullOrEmpty(this.MemberValue))
                        {
                            EntityBase entity = this.m_Entities[this.SelectedIndex] as EntityBase;
                            if (!entity.IsNullField(this.MemberValue))
                            {
                                PropertyInfo property = entity.GetType().GetProperty(this.MemberValue);
                                return property.GetValue(entity, null).ToString();
                            }
                        }
                    }
                }
                return null;
            }
            set
            {
                if (this.m_Entities != null)
                {
                    if (!string.IsNullOrEmpty(this.MemberValue))
                    {
                        for (int i = 0; i < this.m_Entities.Count; i++)
                        {
                            EntityBase entity = this.m_Entities[i] as EntityBase;

                            PropertyInfo property = entity.GetType().GetProperty(this.MemberValue);

                            if (!entity.IsNullField(this.MemberValue))
                            {
                                if (property.GetValue(entity, null).ToString().Trim() == value.ToString().Trim())
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

        /// <summary>
        /// 获取控件选择的Item
        /// </summary>
        /// <returns>Item</returns>
        public virtual object GetSelectedItem()
        {
            if (this.SelectedIndex >= 0)
            {
                return this.m_Entities[this.SelectedIndex];
            }

            return null;
        }
    }
}
