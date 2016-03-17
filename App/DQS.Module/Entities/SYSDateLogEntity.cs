/*
 *	Build By: Codey Object Relation Mapping
 *	Build Data: 2015-10-17 19:48:09
 *	Build Type: Entity
 *	Description: SYSDateLogEntity
*/

using System;
using System.Collections.Generic;
using System.Data;
using ORMSCore;

namespace DQS.Module.Entities
{
    public class SYSDateLogEntity : EntityBase
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

        public SYSDateLogEntity()
        {
            this.TableName = "SYS_DateLog";
            this.Fields = new Dictionary<string, EntityField>();
            this.Fields.Add("ID", SYSDateLogEntityFields.ID);
            this.Fields.Add("UserName", SYSDateLogEntityFields.UserName);
            this.Fields.Add("Operate", SYSDateLogEntityFields.Operate);
            this.Fields.Add("OperateDate", SYSDateLogEntityFields.OperateDate);
        }
    }

    #region SYSDateLogEntityFields

    public class SYSDateLogEntityFields
    {
        public static EntityField ID
        {
            get { return new EntityField("SYS_DateLog", 0, "ID", SqlDbType.Int, true, true, true, false); }
        }

        public static EntityField UserName
        {
            get { return new EntityField("SYS_DateLog", 1, "UserName", SqlDbType.NVarChar, false, false, false, true); }
        }

        public static EntityField Operate
        {
            get { return new EntityField("SYS_DateLog", 2, "Operate", SqlDbType.NVarChar, false, false, false, true); }
        }

        public static EntityField OperateDate
        {
            get { return new EntityField("SYS_DateLog", 3, "OperateDate", SqlDbType.DateTime, false, false, false, true); }
        }

    }

    #endregion

    #region SYSDateLogEntityFields2

    public enum SYSDateLogEntityFields2
    {

        ID,

        UserName,

        Operate,

        OperateDate

    }

    #endregion

}
