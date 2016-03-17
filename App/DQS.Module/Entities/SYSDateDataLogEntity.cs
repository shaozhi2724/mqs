/*
 *	Build By: Codey Object Relation Mapping
 *	Build Data: 2015-11-16 19:48:09
 *	Build Type: Entity
 *	Description: SYSDateDataLogEntity
*/

using System;
using System.Collections.Generic;
using System.Data;
using ORMSCore;

namespace DQS.Module.Entities
{
    public class SYSDateDataLogEntity : EntityBase
    {
        public int ID
        {
            get { return (int)this.GetValue("ID"); }
            set { this.SetValue("ID", value); }
        }

        public string UserName
        {
            get { return (string)this.GetValue("UserName"); }
            set { this.SetValue("UserName", value); }
        }

        public string ModuleEntities
        {
            get { return (string)this.GetValue("ModuleEntities"); }
            set { this.SetValue("ModuleEntities", value); }
        }

        public string Operate
        {
            get { return (string)this.GetValue("Operate"); }
            set { this.SetValue("Operate", value); }
        }

        public DateTime OperateDate
        {
            get { return (DateTime)this.GetValue("OperateDate"); }
            set { this.SetValue("OperateDate", value); }
        }

        public SYSDateDataLogEntity()
        {
            this.TableName = "SYS_DateDataLog";
            this.Fields = new Dictionary<string, EntityField>();
            this.Fields.Add("ID", SYSDateDataLogEntityFields.ID);
            this.Fields.Add("UserName", SYSDateDataLogEntityFields.UserName);
            this.Fields.Add("ModuleEntities", SYSDateDataLogEntityFields.ModuleEntities);
            this.Fields.Add("Operate", SYSDateDataLogEntityFields.Operate);
            this.Fields.Add("OperateDate", SYSDateDataLogEntityFields.OperateDate);
        }
    }

    #region SYSDateDataLogEntityFields

    public class SYSDateDataLogEntityFields
    {
        public static EntityField ID
        {
            get { return new EntityField("SYS_DateDataLog", 0, "ID", SqlDbType.Int, true, true, true, false); }
        }

        public static EntityField UserName
        {
            get { return new EntityField("SYS_DateDataLog", 1, "UserName", SqlDbType.NVarChar, false, false, false, true); }
        }

        public static EntityField ModuleEntities
        {
            get { return new EntityField("SYS_DateDataLog", 2, "ModuleEntities", SqlDbType.NVarChar, false, false, false, true); }
        }

        public static EntityField Operate
        {
            get { return new EntityField("SYS_DateDataLog", 3, "Operate", SqlDbType.NVarChar, false, false, false, true); }
        }

        public static EntityField OperateDate
        {
            get { return new EntityField("SYS_DateDataLog", 4, "OperateDate", SqlDbType.DateTime, false, false, false, true); }
        }

    }

    #endregion

    #region SYSDateDataLogEntityFields2

    public enum SYSDateDataLogEntityFields2
    {

        ID,

        UserName,

        ModuleEntities,

        Operate,

        OperateDate

    }
    #endregion
}
