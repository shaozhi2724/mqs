using System;
using System.Collections.Generic;
using System.Data;
using ORMSCore;

namespace DQS.Module.Entities
{
    public class BFIPersonRangeEntity : EntityBase
    {
        public int RangeID
        {
            get { return (int)this.GetValue("RangeID"); }
            set { this.SetValue("RangeID", value); }
        }
        public string PersonType
        {
            get { return (string)this.GetValue("PersonType"); }
            set { this.SetValue("PersonType", value); }
        }
        public int PersonID
        {
            get { return (int)this.GetValue("PersonID"); }
            set { this.SetValue("PersonID", value); }
        }
        public string CheckType
        {
            get { return (string)this.GetValue("CheckType"); }
            set { this.SetValue("CheckType", value); }
        }
        public string CheckValue
        {
            get { return (string)this.GetValue("CheckValue"); }
            set { this.SetValue("CheckValue", value); }
        }
        public string Remark
        {
            get { return (string)this.GetValue("Remark"); }
            set { this.SetValue("Remark", value); }
        }

        public Guid CreateUserID
        {
            get { return (Guid)this.GetValue("CreateUserID"); }
            set { this.SetValue("CreateUserID", value); }
        }

        public DateTime CreateDate
        {
            get { return (DateTime)this.GetValue("CreateDate"); }
            set { this.SetValue("CreateDate", value); }
        }

        public Guid LastModifyUserID
        {
            get { return (Guid)this.GetValue("LastModifyUserID"); }
            set { this.SetValue("LastModifyUserID", value); }
        }

        public DateTime LastModifyDate
        {
            get { return (DateTime)this.GetValue("LastModifyDate"); }
            set { this.SetValue("LastModifyDate", value); }
        }

        public BFIPersonRangeEntity()
        {
            this.TableName = "BFI_PersonRange";
            this.Fields = new Dictionary<string, EntityField>();
            this.Fields.Add("RangeID", BFIPersonRangeEntityFields.RangeID);
            this.Fields.Add("PersonType", BFIPersonRangeEntityFields.PersonType);
            this.Fields.Add("PersonID", BFIPersonRangeEntityFields.PersonID);
            this.Fields.Add("CheckType", BFIPersonRangeEntityFields.CheckType);
            this.Fields.Add("CheckValue", BFIPersonRangeEntityFields.CheckValue);
            this.Fields.Add("Remark", BFIPersonRangeEntityFields.Remark);
            this.Fields.Add("CreateUserID", BFIPersonRangeEntityFields.CreateUserID);
            this.Fields.Add("CreateDate", BFIPersonRangeEntityFields.CreateDate);
            this.Fields.Add("LastModifyUserID", BFIPersonRangeEntityFields.LastModifyUserID);
            this.Fields.Add("LastModifyDate", BFIPersonRangeEntityFields.LastModifyDate);
        }
    }

    #region BFIPersonRangeEntityFields

    public class BFIPersonRangeEntityFields
    {
        public static EntityField RangeID
        {
            get { return new EntityField("BFI_PersonRange", 0, "RangeID", SqlDbType.Int, true, true, true, false); }
        }

        public static EntityField PersonType
        {
            get { return new EntityField("BFI_PersonRange", 1, "PersonType", SqlDbType.NVarChar, false, false, false, true); }
        }

        public static EntityField PersonID
        {
            get { return new EntityField("BFI_PersonRange", 2, "PersonID", SqlDbType.Int, false, false, false, true); }
        }

        public static EntityField CheckType
        {
            get { return new EntityField("BFI_PersonRange", 3, "CheckType", SqlDbType.NVarChar, false, false, false, true); }
        }

        public static EntityField CheckValue
        {
            get { return new EntityField("BFI_PersonRange", 4, "CheckValue", SqlDbType.NVarChar, false, false, false, true); }
        }

        public static EntityField Remark
        {
            get { return new EntityField("BFI_PersonRange", 5, "Remark", SqlDbType.NVarChar, false, false, false, true); }
        }

        public static EntityField CreateUserID
        {
            get { return new EntityField("BFI_PersonRange", 6, "CreateUserID", SqlDbType.UniqueIdentifier, false, false, false, true); }
        }

        public static EntityField CreateDate
        {
            get { return new EntityField("BFI_PersonRange", 7, "CreateDate", SqlDbType.DateTime, false, false, false, true); }
        }

        public static EntityField LastModifyUserID
        {
            get { return new EntityField("BFI_PersonRange", 8, "LastModifyUserID", SqlDbType.UniqueIdentifier, false, false, false, true); }
        }

        public static EntityField LastModifyDate
        {
            get { return new EntityField("BFI_PersonRange", 9, "LastModifyDate", SqlDbType.DateTime, false, false, false, true); }
        }
    }

    #endregion

    #region BFIPersonRangeEntityFields2

    public enum BFIPersonRangeEntityFields2
    {
        RangeID,
        PersonType,
        PersonID,
        CheckType,
        CheckValue,
        Remark,
        CreateUserID,
        CreateDate,
        LastModifyUserID,
        LastModifyDate
    }

    #endregion
}
