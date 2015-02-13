/*
 *	Build By: Codey Object Relation Mapping
 *	Build Data: 2013-08-28 12:02:22
 *	Build Type: Entity
 *	Description: BUSQualityAdvisoryEntity
*/

using System;
using System.Collections.Generic;
using System.Data;
using ORMSCore;

namespace DQS.Module.Entities
{
	public class BUSQualityAdvisoryEntity : EntityBase
	{
		public int AdvisoryID
		{
			get { return (int)this.GetValue("AdvisoryID"); } 
			set { this.SetValue("AdvisoryID", value); } 
		}

		public string AdvisoryCode
		{
			get { return (string)this.GetValue("AdvisoryCode"); } 
			set { this.SetValue("AdvisoryCode", value); } 
		}

		public string Consultant
		{
			get { return (string)this.GetValue("Consultant"); } 
			set { this.SetValue("Consultant", value); } 
		}

		public string ConsultantSpell
		{
			get { return (string)this.GetValue("ConsultantSpell"); } 
			set { this.SetValue("ConsultantSpell", value); } 
		}

		public string ConsultantContact
		{
			get { return (string)this.GetValue("ConsultantContact"); } 
			set { this.SetValue("ConsultantContact", value); } 
		}

		public string AdvisoryCompany
		{
			get { return (string)this.GetValue("AdvisoryCompany"); } 
			set { this.SetValue("AdvisoryCompany", value); } 
		}

		public string CompanySpell
		{
			get { return (string)this.GetValue("CompanySpell"); } 
			set { this.SetValue("CompanySpell", value); } 
		}

		public string ConsultantType
		{
			get { return (string)this.GetValue("ConsultantType"); } 
			set { this.SetValue("ConsultantType", value); } 
		}

		public string AdvisoryStyle
		{
			get { return (string)this.GetValue("AdvisoryStyle"); } 
			set { this.SetValue("AdvisoryStyle", value); } 
		}

		public DateTime AdvisoryDate
		{
			get { return (DateTime)this.GetValue("AdvisoryDate"); } 
			set { this.SetValue("AdvisoryDate", value); } 
		}

		public string Counselor
		{
			get { return (string)this.GetValue("Counselor"); } 
			set { this.SetValue("Counselor", value); } 
		}

		public string CounselorSpell
		{
			get { return (string)this.GetValue("CounselorSpell"); } 
			set { this.SetValue("CounselorSpell", value); } 
		}

		public string ProductList
		{
			get { return (string)this.GetValue("ProductList"); } 
			set { this.SetValue("ProductList", value); } 
		}

		public string AdvisoryContent
		{
			get { return (string)this.GetValue("AdvisoryContent"); } 
			set { this.SetValue("AdvisoryContent", value); } 
		}

		public string AdvisoryReply
		{
			get { return (string)this.GetValue("AdvisoryReply"); } 
			set { this.SetValue("AdvisoryReply", value); } 
		}

		public DateTime ReplyDate
		{
			get { return (DateTime)this.GetValue("ReplyDate"); } 
			set { this.SetValue("ReplyDate", value); } 
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

		public string AdvisoryRemrk
		{
			get { return (string)this.GetValue("AdvisoryRemrk"); } 
			set { this.SetValue("AdvisoryRemrk", value); } 
		}

		public string Reservation1
		{
			get { return (string)this.GetValue("Reservation1"); } 
			set { this.SetValue("Reservation1", value); } 
		}

		public string Reservation2
		{
			get { return (string)this.GetValue("Reservation2"); } 
			set { this.SetValue("Reservation2", value); } 
		}

		public string Reservation3
		{
			get { return (string)this.GetValue("Reservation3"); } 
			set { this.SetValue("Reservation3", value); } 
		}

		public string Reservation4
		{
			get { return (string)this.GetValue("Reservation4"); } 
			set { this.SetValue("Reservation4", value); } 
		}

		public string Reservation5
		{
			get { return (string)this.GetValue("Reservation5"); } 
			set { this.SetValue("Reservation5", value); } 
		}

		public string Reservation6
		{
			get { return (string)this.GetValue("Reservation6"); } 
			set { this.SetValue("Reservation6", value); } 
		}

		public string Reservation7
		{
			get { return (string)this.GetValue("Reservation7"); } 
			set { this.SetValue("Reservation7", value); } 
		}

		public string Reservation8
		{
			get { return (string)this.GetValue("Reservation8"); } 
			set { this.SetValue("Reservation8", value); } 
		}

		public string Reservation9
		{
			get { return (string)this.GetValue("Reservation9"); } 
			set { this.SetValue("Reservation9", value); } 
		}

		public string Reservation10
		{
			get { return (string)this.GetValue("Reservation10"); } 
			set { this.SetValue("Reservation10", value); } 
		}

		public BUSQualityAdvisoryEntity()
		{
			this.TableName = "BUS_QualityAdvisory";
			this.Fields = new Dictionary<string, EntityField>();
			this.Fields.Add("AdvisoryID", BUSQualityAdvisoryEntityFields.AdvisoryID);
			this.Fields.Add("AdvisoryCode", BUSQualityAdvisoryEntityFields.AdvisoryCode);
			this.Fields.Add("Consultant", BUSQualityAdvisoryEntityFields.Consultant);
			this.Fields.Add("ConsultantSpell", BUSQualityAdvisoryEntityFields.ConsultantSpell);
			this.Fields.Add("ConsultantContact", BUSQualityAdvisoryEntityFields.ConsultantContact);
			this.Fields.Add("AdvisoryCompany", BUSQualityAdvisoryEntityFields.AdvisoryCompany);
			this.Fields.Add("CompanySpell", BUSQualityAdvisoryEntityFields.CompanySpell);
			this.Fields.Add("ConsultantType", BUSQualityAdvisoryEntityFields.ConsultantType);
			this.Fields.Add("AdvisoryStyle", BUSQualityAdvisoryEntityFields.AdvisoryStyle);
			this.Fields.Add("AdvisoryDate", BUSQualityAdvisoryEntityFields.AdvisoryDate);
			this.Fields.Add("Counselor", BUSQualityAdvisoryEntityFields.Counselor);
			this.Fields.Add("CounselorSpell", BUSQualityAdvisoryEntityFields.CounselorSpell);
			this.Fields.Add("ProductList", BUSQualityAdvisoryEntityFields.ProductList);
			this.Fields.Add("AdvisoryContent", BUSQualityAdvisoryEntityFields.AdvisoryContent);
			this.Fields.Add("AdvisoryReply", BUSQualityAdvisoryEntityFields.AdvisoryReply);
			this.Fields.Add("ReplyDate", BUSQualityAdvisoryEntityFields.ReplyDate);
			this.Fields.Add("CreateUserID", BUSQualityAdvisoryEntityFields.CreateUserID);
			this.Fields.Add("CreateDate", BUSQualityAdvisoryEntityFields.CreateDate);
			this.Fields.Add("LastModifyUserID", BUSQualityAdvisoryEntityFields.LastModifyUserID);
			this.Fields.Add("LastModifyDate", BUSQualityAdvisoryEntityFields.LastModifyDate);
			this.Fields.Add("AdvisoryRemrk", BUSQualityAdvisoryEntityFields.AdvisoryRemrk);
			this.Fields.Add("Reservation1", BUSQualityAdvisoryEntityFields.Reservation1);
			this.Fields.Add("Reservation2", BUSQualityAdvisoryEntityFields.Reservation2);
			this.Fields.Add("Reservation3", BUSQualityAdvisoryEntityFields.Reservation3);
			this.Fields.Add("Reservation4", BUSQualityAdvisoryEntityFields.Reservation4);
			this.Fields.Add("Reservation5", BUSQualityAdvisoryEntityFields.Reservation5);
			this.Fields.Add("Reservation6", BUSQualityAdvisoryEntityFields.Reservation6);
			this.Fields.Add("Reservation7", BUSQualityAdvisoryEntityFields.Reservation7);
			this.Fields.Add("Reservation8", BUSQualityAdvisoryEntityFields.Reservation8);
			this.Fields.Add("Reservation9", BUSQualityAdvisoryEntityFields.Reservation9);
			this.Fields.Add("Reservation10", BUSQualityAdvisoryEntityFields.Reservation10);
		}
	}

	#region BUSQualityAdvisoryEntityFields

	public class BUSQualityAdvisoryEntityFields
	{
		public static EntityField AdvisoryID
		{
			get { return new EntityField("BUS_QualityAdvisory", 0, "AdvisoryID", SqlDbType.Int, true, true, true, false); }
		}

		public static EntityField AdvisoryCode
		{
			get { return new EntityField("BUS_QualityAdvisory", 1, "AdvisoryCode", SqlDbType.NVarChar, false, false, true, false); }
		}

		public static EntityField Consultant
		{
			get { return new EntityField("BUS_QualityAdvisory", 2, "Consultant", SqlDbType.NVarChar, false, false, false, true); }
		}

		public static EntityField ConsultantSpell
		{
			get { return new EntityField("BUS_QualityAdvisory", 3, "ConsultantSpell", SqlDbType.NVarChar, false, false, false, true); }
		}

		public static EntityField ConsultantContact
		{
			get { return new EntityField("BUS_QualityAdvisory", 4, "ConsultantContact", SqlDbType.NVarChar, false, false, false, true); }
		}

		public static EntityField AdvisoryCompany
		{
			get { return new EntityField("BUS_QualityAdvisory", 5, "AdvisoryCompany", SqlDbType.NVarChar, false, false, false, true); }
		}

		public static EntityField CompanySpell
		{
			get { return new EntityField("BUS_QualityAdvisory", 6, "CompanySpell", SqlDbType.NVarChar, false, false, false, true); }
		}

		public static EntityField ConsultantType
		{
			get { return new EntityField("BUS_QualityAdvisory", 7, "ConsultantType", SqlDbType.NVarChar, false, false, false, true); }
		}

		public static EntityField AdvisoryStyle
		{
			get { return new EntityField("BUS_QualityAdvisory", 8, "AdvisoryStyle", SqlDbType.NVarChar, false, false, false, true); }
		}

		public static EntityField AdvisoryDate
		{
			get { return new EntityField("BUS_QualityAdvisory", 9, "AdvisoryDate", SqlDbType.DateTime, false, false, false, true); }
		}

		public static EntityField Counselor
		{
			get { return new EntityField("BUS_QualityAdvisory", 10, "Counselor", SqlDbType.NVarChar, false, false, false, true); }
		}

		public static EntityField CounselorSpell
		{
			get { return new EntityField("BUS_QualityAdvisory", 11, "CounselorSpell", SqlDbType.NVarChar, false, false, false, true); }
		}

		public static EntityField ProductList
		{
			get { return new EntityField("BUS_QualityAdvisory", 12, "ProductList", SqlDbType.NVarChar, false, false, false, true); }
		}

		public static EntityField AdvisoryContent
		{
			get { return new EntityField("BUS_QualityAdvisory", 13, "AdvisoryContent", SqlDbType.NVarChar, false, false, false, true); }
		}

		public static EntityField AdvisoryReply
		{
			get { return new EntityField("BUS_QualityAdvisory", 14, "AdvisoryReply", SqlDbType.NVarChar, false, false, false, true); }
		}

		public static EntityField ReplyDate
		{
			get { return new EntityField("BUS_QualityAdvisory", 15, "ReplyDate", SqlDbType.DateTime, false, false, false, true); }
		}

		public static EntityField CreateUserID
		{
			get { return new EntityField("BUS_QualityAdvisory", 16, "CreateUserID", SqlDbType.UniqueIdentifier, false, false, false, true); }
		}

		public static EntityField CreateDate
		{
			get { return new EntityField("BUS_QualityAdvisory", 17, "CreateDate", SqlDbType.DateTime, false, false, false, true); }
		}

		public static EntityField LastModifyUserID
		{
			get { return new EntityField("BUS_QualityAdvisory", 18, "LastModifyUserID", SqlDbType.UniqueIdentifier, false, false, false, true); }
		}

		public static EntityField LastModifyDate
		{
			get { return new EntityField("BUS_QualityAdvisory", 19, "LastModifyDate", SqlDbType.DateTime, false, false, false, true); }
		}

		public static EntityField AdvisoryRemrk
		{
			get { return new EntityField("BUS_QualityAdvisory", 20, "AdvisoryRemrk", SqlDbType.NVarChar, false, false, false, true); }
		}

		public static EntityField Reservation1
		{
			get { return new EntityField("BUS_QualityAdvisory", 21, "Reservation1", SqlDbType.NVarChar, false, false, false, true); }
		}

		public static EntityField Reservation2
		{
			get { return new EntityField("BUS_QualityAdvisory", 22, "Reservation2", SqlDbType.NVarChar, false, false, false, true); }
		}

		public static EntityField Reservation3
		{
			get { return new EntityField("BUS_QualityAdvisory", 23, "Reservation3", SqlDbType.NVarChar, false, false, false, true); }
		}

		public static EntityField Reservation4
		{
			get { return new EntityField("BUS_QualityAdvisory", 24, "Reservation4", SqlDbType.NVarChar, false, false, false, true); }
		}

		public static EntityField Reservation5
		{
			get { return new EntityField("BUS_QualityAdvisory", 25, "Reservation5", SqlDbType.NVarChar, false, false, false, true); }
		}

		public static EntityField Reservation6
		{
			get { return new EntityField("BUS_QualityAdvisory", 26, "Reservation6", SqlDbType.NVarChar, false, false, false, true); }
		}

		public static EntityField Reservation7
		{
			get { return new EntityField("BUS_QualityAdvisory", 27, "Reservation7", SqlDbType.NVarChar, false, false, false, true); }
		}

		public static EntityField Reservation8
		{
			get { return new EntityField("BUS_QualityAdvisory", 28, "Reservation8", SqlDbType.NVarChar, false, false, false, true); }
		}

		public static EntityField Reservation9
		{
			get { return new EntityField("BUS_QualityAdvisory", 29, "Reservation9", SqlDbType.NVarChar, false, false, false, true); }
		}

		public static EntityField Reservation10
		{
			get { return new EntityField("BUS_QualityAdvisory", 30, "Reservation10", SqlDbType.NVarChar, false, false, false, true); }
		}

	}

	#endregion

	#region BUSQualityAdvisoryEntityFields2

	public enum BUSQualityAdvisoryEntityFields2
	{
		AdvisoryID,

		AdvisoryCode,

		Consultant,

		ConsultantSpell,

		ConsultantContact,

		AdvisoryCompany,

		CompanySpell,

		ConsultantType,

		AdvisoryStyle,

		AdvisoryDate,

		Counselor,

		CounselorSpell,

		ProductList,

		AdvisoryContent,

		AdvisoryReply,

		ReplyDate,

		CreateUserID,

		CreateDate,

		LastModifyUserID,

		LastModifyDate,

		AdvisoryRemrk,

		Reservation1,

		Reservation2,

		Reservation3,

		Reservation4,

		Reservation5,

		Reservation6,

		Reservation7,

		Reservation8,

		Reservation9,

		Reservation10,

	}

	#endregion

}
