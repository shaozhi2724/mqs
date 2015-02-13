using ORMSCore;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;

namespace DQS.Module.Entities
{
    public class WMSRegulatoryCodeEntity: EntityBase
	{

		public string Code
		{
			get { return (string)this.GetValue("Code"); } 
			set { this.SetValue("Code", value); } 
		}

		public string CorpCode
		{
			get { return (string)this.GetValue("CorpCode"); } 
			set { this.SetValue("CorpCode", value); } 
		}

		public string ReviewCode
		{
			get { return (string)this.GetValue("ReviewCode"); } 
			set { this.SetValue("ReviewCode", value); } 
		}

		public int StatusID
		{
			get { return (int)this.GetValue("StatusID"); } 
			set { this.SetValue("StatusID", value); } 
		}

		public string StatusName
		{
			get { return (string)this.GetValue("StatusName"); } 
			set { this.SetValue("StatusName", value); } 
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

		public DateTime RelationDate
		{
			get { return (DateTime)this.GetValue("RelationDate"); } 
			set { this.SetValue("RelationDate", value); } 
		}

		public DateTime ExportDate
		{
			get { return (DateTime)this.GetValue("ExportDate"); } 
			set { this.SetValue("ExportDate", value); } 
		}


        public WMSRegulatoryCodeEntity()
		{
            this.TableName = "WMS_RegulatoryCode";
			this.Fields = new Dictionary<string, EntityField>();
            this.Fields.Add("Code", WMSRegulatoryCodeEntityFields.Code);
            this.Fields.Add("CorpCode", WMSRegulatoryCodeEntityFields.CorpCode);
            this.Fields.Add("ReviewCode", WMSRegulatoryCodeEntityFields.ReviewCode);
            this.Fields.Add("StatusID", WMSRegulatoryCodeEntityFields.StatusID);
            this.Fields.Add("StatusName", WMSRegulatoryCodeEntityFields.StatusName);
            this.Fields.Add("CreateUserID", WMSRegulatoryCodeEntityFields.CreateUserID);
            this.Fields.Add("CreateDate", WMSRegulatoryCodeEntityFields.CreateDate);
            this.Fields.Add("RelationDate", WMSRegulatoryCodeEntityFields.RelationDate);
            this.Fields.Add("ExportDate", WMSRegulatoryCodeEntityFields.ExportDate);
		}
	}

    #region WMSRegulatoryCodeEntityFields

    public class WMSRegulatoryCodeEntityFields
	{

        public static EntityField Code
		{
            get { return new EntityField("WMS_RegulatoryCode", 1, "Code", SqlDbType.NVarChar, true, true, true, false); }
		}

        public static EntityField CorpCode
		{
            get { return new EntityField("WMS_RegulatoryCode", 2, "CorpCode", SqlDbType.NVarChar, false, false, false, true); }
		}

        public static EntityField ReviewCode
		{
            get { return new EntityField("WMS_RegulatoryCode", 3, "ReviewCode", SqlDbType.NVarChar, false, false, false, true); }
		}

        public static EntityField StatusID
		{
            get { return new EntityField("WMS_RegulatoryCode", 4, "StatusID", SqlDbType.Int, false, false, false, true); }
		}

        public static EntityField StatusName
		{
            get { return new EntityField("WMS_RegulatoryCode", 5, "StatusName", SqlDbType.NVarChar, false, false, false, true); }
		}

		public static EntityField CreateUserID
		{
            get { return new EntityField("WMS_RegulatoryCode", 6, "CreateUserID", SqlDbType.UniqueIdentifier, false, false, false, true); }
		}

		public static EntityField CreateDate
		{
            get { return new EntityField("WMS_RegulatoryCode", 7, "CreateDate", SqlDbType.DateTime, false, false, false, true); }
		}

        public static EntityField RelationDate
		{
            get { return new EntityField("WMS_RegulatoryCode", 8, "RelationDate", SqlDbType.DateTime, false, false, false, true); }
		}

        public static EntityField ExportDate
		{
            get { return new EntityField("WMS_RegulatoryCode", 9, "ExportDate", SqlDbType.DateTime, false, false, false, true); }
		}
	}

	#endregion

    #region WMSRegulatoryCodeEntityFields2

    public enum WMSRegulatoryCode2
	{
        Code,

        CorpCode,
        
        ReviewCode,
        
        StatusID,
        
        StatusName,
        
        CreateUserID,
        
        CreateDate,
        
        RelationDate,
        
        ExportDate,

	}

	#endregion

}
