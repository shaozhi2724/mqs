using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using DevExpress.XtraEditors;
using ORMSCore;
using DQS.Module;
using System.ComponentModel;
using System.Reflection;
using System.Windows.Forms;
using DQS.Common;

namespace DQS.Controls
{
    /// <summary>
    /// 字段文本框列表呈现面板
    /// </summary>
    public class FieldTextBoxPanel : PanelControl
    {

        private List<TextBoxEx> m_TextBoxFields;

        /// <summary>
        /// 字段文本框列表
        /// </summary>
        [Browsable(false)]
        public List<TextBoxEx> TextBoxFields
        {
            get
            {
                this.m_TextBoxFields.Clear();
                this.GetChildText(this);
                return m_TextBoxFields;
            }
        }

        /// <summary>
        /// 设定 Panel 所要操作的实体
        /// </summary>
        [Description("设定 Panel 所要操作的实体")]
        public EntityType2 TypeOfEntity { get; set; }

        public FieldTextBoxPanel()
        {
            m_TextBoxFields = new List<TextBoxEx>();
        }

        public EntityBase GetEntity()
        {
            if (!string.IsNullOrEmpty(TypeOfEntity.ToString()))
            {
                try
                {
                    EntityBase entityBase = Activator.CreateInstance(Type.GetType(String.Format("DQS.Module.Entities.{0},DQS.Module", TypeOfEntity))) as EntityBase;

                    this.m_TextBoxFields.Clear();
                    this.GetChildText(this);//遍历自定义TextBox

                    foreach (TextBoxEx field in this.m_TextBoxFields)
                    {
                        if (field.GetType().GetProperty("EntityField") != null)
                        {
                            if (field.IsIntegerOnly && field.Text.Trim().Length == 0)
                            {
                                field.Text = "0";
                            }
                            //try
                            //{
                            string fieldName = field.GetType().GetProperty("EntityField").GetValue(field, null).ToString();
                            PropertyInfo property = entityBase.GetType().GetProperty(fieldName);
                            if (null != property)
                            {
                                if (property.PropertyType.Name == "DateTime" && field.Text.Trim() == "") { continue; }
                                property.SetValue(entityBase, Convert.ChangeType(field.Text.Trim(), property.PropertyType), null);
                            }

                            if (field.IsTransferAlphabetic)
                            {
                                if (!string.IsNullOrEmpty(field.AlphabeticFiled))
                                {
                                    if (field.Text.Trim().Length > 0)
                                    {
                                        property = entityBase.GetType().GetProperty(field.AlphabeticFiled);
                                        if (property != null)
                                        {
                                            property.SetValue(entityBase, Convert.ChangeType(GlobalMethod.GetAlphabetic(field.Text.Trim()), property.PropertyType), null);
                                        }
                                    }
                                }
                            }
                            //}
                            //catch (Exception ex)
                            //{

                            //    throw new Exception(field.Name + ex.Message);
                            //}
                        }
                    }
                    return entityBase;
                }
                catch (Exception ex)
                {
                    XtraMessageBox.Show(ex.Message, "转换错误");
                }
            }
            return null;
        }

        public void SetEntity(EntityBase entity)
        {
            try
            {
                this.m_TextBoxFields.Clear();
                this.GetChildText(this);//遍历自定义TextBox

                foreach (TextBoxEx field in this.m_TextBoxFields)
                {
                    if (field.GetType().GetProperty("EntityField") != null)
                    {
                        string fieldName = field.GetType().GetProperty("EntityField").GetValue(field, null).ToString();
                        if (!entity.IsNullField(fieldName))
                        {
                            PropertyInfo property = entity.GetType().GetProperty(fieldName);
                            try
                            {
                                object fieldValue = property.GetValue(entity, null);
                                if (null != fieldValue)
                                {
                                    field.Text = fieldValue.ToString();
                                }
                                else
                                {
                                    field.Text = "";
                                }
                            }
                            catch(Exception)
                            {

                            }
                        }
                        else
                        {
                            field.Text = "";
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                XtraMessageBox.Show(ex.Message, "转换错误");
            }
        }

        public bool ValidateIsNullFields()
        {
            try
            {
                this.m_TextBoxFields.Clear();
                this.GetChildText(this);//遍历自定义TextBox
                var textBoxes = m_TextBoxFields.OrderBy(p => p.TabIndex).ToList();
                foreach (TextBoxEx field in textBoxes)
                {
                    if (field.IsNullValidate)
                    {
                        if (field.Text.Trim().Length == 0)
                        {
                            if (!string.IsNullOrEmpty(field.IsNullString))
                            {
                                XtraMessageBox.Show(field.IsNullString, "警告", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                                field.Focus();
                                return false;
                            }
                        }
                    }
                }

                return true;
            }
            catch (Exception ex)
            {
                XtraMessageBox.Show(ex.Message, "转换错误");
                return false;
            }
        }

        protected void GetChildText(Control container)
        {
            foreach (Control c in container.Controls)
            {
                if (c.HasChildren)
                {
                    this.GetChildText(c);
                }

                if (c is TextBoxEx)
                {
                    this.m_TextBoxFields.Add(c as TextBoxEx);
                }
            }
        }
    }
}
