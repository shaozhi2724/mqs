using ORMSCore;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;

namespace DQS.Module.Entities
{
    class SYSPromSettingEntity : EntityBase
    {
        public int ID
        {
            get { return (int)this.GetValue("ID"); }
            set { this.SetValue("ID", value); }
        }
        public string PageFunctionCode
        {
            get { return (string)this.GetValue("PageFunctionCode"); }
            set { this.SetValue("PageFunctionCode", value); }
        }
        public string Describe
        {
            get { return (string)this.GetValue("Describe"); }
            set { this.SetValue("Describe", value); }
        }
        public int IsEnable
        {
            get { return (int)this.GetValue("IsEnable"); }
            set { this.SetValue("IsEnable", value); }
        }
        public string Remark
        {
            get { return (string)this.GetValue("Remark"); }
            set { this.SetValue("Remark", value); }
        }

        public SYSPromSettingEntity()
        {
            this.TableName = "SYS_PromSetting";
            this.Fields = new Dictionary<string, EntityField>();
            this.Fields.Add("ID", SYSPromSettingEntityFields.ID);
            this.Fields.Add("PageFunctionCode", SYSPromSettingEntityFields.PageFunctionCode);
            this.Fields.Add("Describe", SYSPromSettingEntityFields.Describe);
            this.Fields.Add("IsEnable", SYSPromSettingEntityFields.IsEnable);
            this.Fields.Add("Remark", SYSPromSettingEntityFields.Remark);
        }
    }
    #region SYSPromSettingEntityFields

    public class SYSPromSettingEntityFields
    {
        public static EntityField ID
        {
            get { return new EntityField("SYS_PromSetting", 0, "ID", SqlDbType.Int, true, true, true, false); }
        }

        public static EntityField PageFunctionCode
        {
            get { return new EntityField("SYS_PromSetting", 1, "PageFunctionCode", SqlDbType.NVarChar, false, false, true, false); }
        }

        public static EntityField Describe
        {
            get { return new EntityField("SYS_PromSetting", 2, "Describe", SqlDbType.NVarChar, false, false, true, false); }
        }
        public static EntityField IsEnable
        {
            get { return new EntityField("SYS_PromSetting", 3, "IsEnable", SqlDbType.Int, true, true, true, false); }
        }

        public static EntityField Remark
        {
            get { return new EntityField("SYS_PromSetting", 4, "Remark", SqlDbType.NVarChar, false, false, true, false); }
        }
    }
    #endregion

    #region SYSPromSettingEntityFields2

    public enum SYSPromSettingEntityFields2
    {
        ID,PageFunctionCode, Describe, IsEnable, Remark
    }
    #endregion
}
