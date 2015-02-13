/*
 *	Build By: Codey Object Relation Mapping
 *	Build Data: 2013-08-28 12:02:21
 *	Build Type: Entity
 *	Description: BUSAdverseReactionEntity
*/

using System;
using System.Collections.Generic;
using System.Data;
using ORMSCore;

namespace DQS.Module.Entities
{
	public class BUSAdverseReactionEntity : EntityBase
	{
		public int ReactionID
		{
			get { return (int)this.GetValue("ReactionID"); } 
			set { this.SetValue("ReactionID", value); } 
		}

		public string ReactionCode
		{
			get { return (string)this.GetValue("ReactionCode"); } 
			set { this.SetValue("ReactionCode", value); } 
		}

		public string ReactionUser
		{
			get { return (string)this.GetValue("ReactionUser"); } 
			set { this.SetValue("ReactionUser", value); } 
		}

		public string ReactionUserSpell
		{
			get { return (string)this.GetValue("ReactionUserSpell"); } 
			set { this.SetValue("ReactionUserSpell", value); } 
		}

		public DateTime UseDate
		{
			get { return (DateTime)this.GetValue("UseDate"); } 
			set { this.SetValue("UseDate", value); } 
		}

		public DateTime HappenedDate
		{
			get { return (DateTime)this.GetValue("HappenedDate"); } 
			set { this.SetValue("HappenedDate", value); } 
		}

		public string ReactionUserContact
		{
			get { return (string)this.GetValue("ReactionUserContact"); } 
			set { this.SetValue("ReactionUserContact", value); } 
		}

		public string UserHospital
		{
			get { return (string)this.GetValue("UserHospital"); } 
			set { this.SetValue("UserHospital", value); } 
		}

		public string HospitalSpell
		{
			get { return (string)this.GetValue("HospitalSpell"); } 
			set { this.SetValue("HospitalSpell", value); } 
		}

		public string Operator
		{
			get { return (string)this.GetValue("Operator"); } 
			set { this.SetValue("Operator", value); } 
		}

		public string OperatorSpell
		{
			get { return (string)this.GetValue("OperatorSpell"); } 
			set { this.SetValue("OperatorSpell", value); } 
		}

		public int ProductID
		{
			get { return (int)this.GetValue("ProductID"); } 
			set { this.SetValue("ProductID", value); } 
		}

		public string BatchNo
		{
			get { return (string)this.GetValue("BatchNo"); } 
			set { this.SetValue("BatchNo", value); } 
		}

		public string SymptomContent
		{
			get { return (string)this.GetValue("SymptomContent"); } 
			set { this.SetValue("SymptomContent", value); } 
		}

		public string Investigation
		{
			get { return (string)this.GetValue("Investigation"); } 
			set { this.SetValue("Investigation", value); } 
		}

		public string DealPerson
		{
			get { return (string)this.GetValue("DealPerson"); } 
			set { this.SetValue("DealPerson", value); } 
		}

		public string DealPersonSpell
		{
			get { return (string)this.GetValue("DealPersonSpell"); } 
			set { this.SetValue("DealPersonSpell", value); } 
		}

		public DateTime DealDate
		{
			get { return (DateTime)this.GetValue("DealDate"); } 
			set { this.SetValue("DealDate", value); } 
		}

		public string DealSuggestion
		{
			get { return (string)this.GetValue("DealSuggestion"); } 
			set { this.SetValue("DealSuggestion", value); } 
		}

		public string DealResult
		{
			get { return (string)this.GetValue("DealResult"); } 
			set { this.SetValue("DealResult", value); } 
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

		public string ReactionRemrk
		{
			get { return (string)this.GetValue("ReactionRemrk"); } 
			set { this.SetValue("ReactionRemrk", value); } 
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

		public BUSAdverseReactionEntity()
		{
			this.TableName = "BUS_AdverseReaction";
			this.Fields = new Dictionary<string, EntityField>();
			this.Fields.Add("ReactionID", BUSAdverseReactionEntityFields.ReactionID);
			this.Fields.Add("ReactionCode", BUSAdverseReactionEntityFields.ReactionCode);
			this.Fields.Add("ReactionUser", BUSAdverseReactionEntityFields.ReactionUser);
			this.Fields.Add("ReactionUserSpell", BUSAdverseReactionEntityFields.ReactionUserSpell);
			this.Fields.Add("UseDate", BUSAdverseReactionEntityFields.UseDate);
			this.Fields.Add("HappenedDate", BUSAdverseReactionEntityFields.HappenedDate);
			this.Fields.Add("ReactionUserContact", BUSAdverseReactionEntityFields.ReactionUserContact);
			this.Fields.Add("UserHospital", BUSAdverseReactionEntityFields.UserHospital);
			this.Fields.Add("HospitalSpell", BUSAdverseReactionEntityFields.HospitalSpell);
			this.Fields.Add("Operator", BUSAdverseReactionEntityFields.Operator);
			this.Fields.Add("OperatorSpell", BUSAdverseReactionEntityFields.OperatorSpell);
			this.Fields.Add("ProductID", BUSAdverseReactionEntityFields.ProductID);
			this.Fields.Add("BatchNo", BUSAdverseReactionEntityFields.BatchNo);
			this.Fields.Add("SymptomContent", BUSAdverseReactionEntityFields.SymptomContent);
			this.Fields.Add("Investigation", BUSAdverseReactionEntityFields.Investigation);
			this.Fields.Add("DealPerson", BUSAdverseReactionEntityFields.DealPerson);
			this.Fields.Add("DealPersonSpell", BUSAdverseReactionEntityFields.DealPersonSpell);
			this.Fields.Add("DealDate", BUSAdverseReactionEntityFields.DealDate);
			this.Fields.Add("DealSuggestion", BUSAdverseReactionEntityFields.DealSuggestion);
			this.Fields.Add("DealResult", BUSAdverseReactionEntityFields.DealResult);
			this.Fields.Add("CreateUserID", BUSAdverseReactionEntityFields.CreateUserID);
			this.Fields.Add("CreateDate", BUSAdverseReactionEntityFields.CreateDate);
			this.Fields.Add("LastModifyUserID", BUSAdverseReactionEntityFields.LastModifyUserID);
			this.Fields.Add("LastModifyDate", BUSAdverseReactionEntityFields.LastModifyDate);
			this.Fields.Add("ReactionRemrk", BUSAdverseReactionEntityFields.ReactionRemrk);
			this.Fields.Add("Reservation1", BUSAdverseReactionEntityFields.Reservation1);
			this.Fields.Add("Reservation2", BUSAdverseReactionEntityFields.Reservation2);
			this.Fields.Add("Reservation3", BUSAdverseReactionEntityFields.Reservation3);
			this.Fields.Add("Reservation4", BUSAdverseReactionEntityFields.Reservation4);
			this.Fields.Add("Reservation5", BUSAdverseReactionEntityFields.Reservation5);
			this.Fields.Add("Reservation6", BUSAdverseReactionEntityFields.Reservation6);
			this.Fields.Add("Reservation7", BUSAdverseReactionEntityFields.Reservation7);
			this.Fields.Add("Reservation8", BUSAdverseReactionEntityFields.Reservation8);
			this.Fields.Add("Reservation9", BUSAdverseReactionEntityFields.Reservation9);
			this.Fields.Add("Reservation10", BUSAdverseReactionEntityFields.Reservation10);
		}
	}

	#region BUSAdverseReactionEntityFields

	public class BUSAdverseReactionEntityFields
	{
		public static EntityField ReactionID
		{
			get { return new EntityField("BUS_AdverseReaction", 0, "ReactionID", SqlDbType.Int, true, true, true, false); }
		}

		public static EntityField ReactionCode
		{
			get { return new EntityField("BUS_AdverseReaction", 1, "ReactionCode", SqlDbType.NVarChar, false, false, true, false); }
		}

		public static EntityField ReactionUser
		{
			get { return new EntityField("BUS_AdverseReaction", 2, "ReactionUser", SqlDbType.NVarChar, false, false, false, true); }
		}

		public static EntityField ReactionUserSpell
		{
			get { return new EntityField("BUS_AdverseReaction", 3, "ReactionUserSpell", SqlDbType.NVarChar, false, false, false, true); }
		}

		public static EntityField UseDate
		{
			get { return new EntityField("BUS_AdverseReaction", 4, "UseDate", SqlDbType.DateTime, false, false, false, true); }
		}

		public static EntityField HappenedDate
		{
			get { return new EntityField("BUS_AdverseReaction", 5, "HappenedDate", SqlDbType.DateTime, false, false, false, true); }
		}

		public static EntityField ReactionUserContact
		{
			get { return new EntityField("BUS_AdverseReaction", 6, "ReactionUserContact", SqlDbType.NVarChar, false, false, false, true); }
		}

		public static EntityField UserHospital
		{
			get { return new EntityField("BUS_AdverseReaction", 7, "UserHospital", SqlDbType.NVarChar, false, false, false, true); }
		}

		public static EntityField HospitalSpell
		{
			get { return new EntityField("BUS_AdverseReaction", 8, "HospitalSpell", SqlDbType.NVarChar, false, false, false, true); }
		}

		public static EntityField Operator
		{
			get { return new EntityField("BUS_AdverseReaction", 9, "Operator", SqlDbType.NVarChar, false, false, false, true); }
		}

		public static EntityField OperatorSpell
		{
			get { return new EntityField("BUS_AdverseReaction", 10, "OperatorSpell", SqlDbType.NVarChar, false, false, false, true); }
		}

		public static EntityField ProductID
		{
			get { return new EntityField("BUS_AdverseReaction", 11, "ProductID", SqlDbType.Int, false, false, false, true); }
		}

		public static EntityField BatchNo
		{
			get { return new EntityField("BUS_AdverseReaction", 12, "BatchNo", SqlDbType.NVarChar, false, false, false, true); }
		}

		public static EntityField SymptomContent
		{
			get { return new EntityField("BUS_AdverseReaction", 13, "SymptomContent", SqlDbType.NVarChar, false, false, false, true); }
		}

		public static EntityField Investigation
		{
			get { return new EntityField("BUS_AdverseReaction", 14, "Investigation", SqlDbType.NVarChar, false, false, false, true); }
		}

		public static EntityField DealPerson
		{
			get { return new EntityField("BUS_AdverseReaction", 15, "DealPerson", SqlDbType.NVarChar, false, false, false, true); }
		}

		public static EntityField DealPersonSpell
		{
			get { return new EntityField("BUS_AdverseReaction", 16, "DealPersonSpell", SqlDbType.NVarChar, false, false, false, true); }
		}

		public static EntityField DealDate
		{
			get { return new EntityField("BUS_AdverseReaction", 17, "DealDate", SqlDbType.DateTime, false, false, false, true); }
		}

		public static EntityField DealSuggestion
		{
			get { return new EntityField("BUS_AdverseReaction", 18, "DealSuggestion", SqlDbType.NVarChar, false, false, false, true); }
		}

		public static EntityField DealResult
		{
			get { return new EntityField("BUS_AdverseReaction", 19, "DealResult", SqlDbType.NVarChar, false, false, false, true); }
		}

		public static EntityField CreateUserID
		{
			get { return new EntityField("BUS_AdverseReaction", 20, "CreateUserID", SqlDbType.UniqueIdentifier, false, false, false, true); }
		}

		public static EntityField CreateDate
		{
			get { return new EntityField("BUS_AdverseReaction", 21, "CreateDate", SqlDbType.DateTime, false, false, false, true); }
		}

		public static EntityField LastModifyUserID
		{
			get { return new EntityField("BUS_AdverseReaction", 22, "LastModifyUserID", SqlDbType.UniqueIdentifier, false, false, false, true); }
		}

		public static EntityField LastModifyDate
		{
			get { return new EntityField("BUS_AdverseReaction", 23, "LastModifyDate", SqlDbType.DateTime, false, false, false, true); }
		}

		public static EntityField ReactionRemrk
		{
			get { return new EntityField("BUS_AdverseReaction", 24, "ReactionRemrk", SqlDbType.NVarChar, false, false, false, true); }
		}

		public static EntityField Reservation1
		{
			get { return new EntityField("BUS_AdverseReaction", 25, "Reservation1", SqlDbType.NVarChar, false, false, false, true); }
		}

		public static EntityField Reservation2
		{
			get { return new EntityField("BUS_AdverseReaction", 26, "Reservation2", SqlDbType.NVarChar, false, false, false, true); }
		}

		public static EntityField Reservation3
		{
			get { return new EntityField("BUS_AdverseReaction", 27, "Reservation3", SqlDbType.NVarChar, false, false, false, true); }
		}

		public static EntityField Reservation4
		{
			get { return new EntityField("BUS_AdverseReaction", 28, "Reservation4", SqlDbType.NVarChar, false, false, false, true); }
		}

		public static EntityField Reservation5
		{
			get { return new EntityField("BUS_AdverseReaction", 29, "Reservation5", SqlDbType.NVarChar, false, false, false, true); }
		}

		public static EntityField Reservation6
		{
			get { return new EntityField("BUS_AdverseReaction", 30, "Reservation6", SqlDbType.NVarChar, false, false, false, true); }
		}

		public static EntityField Reservation7
		{
			get { return new EntityField("BUS_AdverseReaction", 31, "Reservation7", SqlDbType.NVarChar, false, false, false, true); }
		}

		public static EntityField Reservation8
		{
			get { return new EntityField("BUS_AdverseReaction", 32, "Reservation8", SqlDbType.NVarChar, false, false, false, true); }
		}

		public static EntityField Reservation9
		{
			get { return new EntityField("BUS_AdverseReaction", 33, "Reservation9", SqlDbType.NVarChar, false, false, false, true); }
		}

		public static EntityField Reservation10
		{
			get { return new EntityField("BUS_AdverseReaction", 34, "Reservation10", SqlDbType.NVarChar, false, false, false, true); }
		}

	}

	#endregion

	#region BUSAdverseReactionEntityFields2

	public enum BUSAdverseReactionEntityFields2
	{
		ReactionID,

		ReactionCode,

		ReactionUser,

		ReactionUserSpell,

		UseDate,

		HappenedDate,

		ReactionUserContact,

		UserHospital,

		HospitalSpell,

		Operator,

		OperatorSpell,

		ProductID,

		BatchNo,

		SymptomContent,

		Investigation,

		DealPerson,

		DealPersonSpell,

		DealDate,

		DealSuggestion,

		DealResult,

		CreateUserID,

		CreateDate,

		LastModifyUserID,

		LastModifyDate,

		ReactionRemrk,

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
