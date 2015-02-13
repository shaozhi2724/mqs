/*
 *	Build By: Codey Object Relation Mapping
 *	Build Data: 2013-08-28 12:02:22
 *	Build Type: Entity
 *	Description: BUSQualityComplaintEntity
*/

using System;
using System.Collections.Generic;
using System.Data;
using ORMSCore;

namespace DQS.Module.Entities
{
	public class BUSQualityComplaintEntity : EntityBase
	{
		public int ComplaintID
		{
			get { return (int)this.GetValue("ComplaintID"); } 
			set { this.SetValue("ComplaintID", value); } 
		}

		public string ComplaintCode
		{
			get { return (string)this.GetValue("ComplaintCode"); } 
			set { this.SetValue("ComplaintCode", value); } 
		}

		public string ComplaintPerson
		{
			get { return (string)this.GetValue("ComplaintPerson"); } 
			set { this.SetValue("ComplaintPerson", value); } 
		}

		public string ComplaintSpell
		{
			get { return (string)this.GetValue("ComplaintSpell"); } 
			set { this.SetValue("ComplaintSpell", value); } 
		}

		public string ComplaintContact
		{
			get { return (string)this.GetValue("ComplaintContact"); } 
			set { this.SetValue("ComplaintContact", value); } 
		}

		public string ComplaintCompany
		{
			get { return (string)this.GetValue("ComplaintCompany"); } 
			set { this.SetValue("ComplaintCompany", value); } 
		}

		public string CompanySpell
		{
			get { return (string)this.GetValue("CompanySpell"); } 
			set { this.SetValue("CompanySpell", value); } 
		}

		public string ComplaintType
		{
			get { return (string)this.GetValue("ComplaintType"); } 
			set { this.SetValue("ComplaintType", value); } 
		}

		public string ComplaintStyle
		{
			get { return (string)this.GetValue("ComplaintStyle"); } 
			set { this.SetValue("ComplaintStyle", value); } 
		}

		public DateTime ComplaintDate
		{
			get { return (DateTime)this.GetValue("ComplaintDate"); } 
			set { this.SetValue("ComplaintDate", value); } 
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

		public int Amount
		{
			get { return (int)this.GetValue("Amount"); } 
			set { this.SetValue("Amount", value); } 
		}

		public string ComplaintContent
		{
			get { return (string)this.GetValue("ComplaintContent"); } 
			set { this.SetValue("ComplaintContent", value); } 
		}

		public string ComplaintSuggestion
		{
			get { return (string)this.GetValue("ComplaintSuggestion"); } 
			set { this.SetValue("ComplaintSuggestion", value); } 
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

		public string ComplaintRemrk
		{
			get { return (string)this.GetValue("ComplaintRemrk"); } 
			set { this.SetValue("ComplaintRemrk", value); } 
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

		public BUSQualityComplaintEntity()
		{
			this.TableName = "BUS_QualityComplaint";
			this.Fields = new Dictionary<string, EntityField>();
			this.Fields.Add("ComplaintID", BUSQualityComplaintEntityFields.ComplaintID);
			this.Fields.Add("ComplaintCode", BUSQualityComplaintEntityFields.ComplaintCode);
			this.Fields.Add("ComplaintPerson", BUSQualityComplaintEntityFields.ComplaintPerson);
			this.Fields.Add("ComplaintSpell", BUSQualityComplaintEntityFields.ComplaintSpell);
			this.Fields.Add("ComplaintContact", BUSQualityComplaintEntityFields.ComplaintContact);
			this.Fields.Add("ComplaintCompany", BUSQualityComplaintEntityFields.ComplaintCompany);
			this.Fields.Add("CompanySpell", BUSQualityComplaintEntityFields.CompanySpell);
			this.Fields.Add("ComplaintType", BUSQualityComplaintEntityFields.ComplaintType);
			this.Fields.Add("ComplaintStyle", BUSQualityComplaintEntityFields.ComplaintStyle);
			this.Fields.Add("ComplaintDate", BUSQualityComplaintEntityFields.ComplaintDate);
			this.Fields.Add("Operator", BUSQualityComplaintEntityFields.Operator);
			this.Fields.Add("OperatorSpell", BUSQualityComplaintEntityFields.OperatorSpell);
			this.Fields.Add("ProductID", BUSQualityComplaintEntityFields.ProductID);
			this.Fields.Add("BatchNo", BUSQualityComplaintEntityFields.BatchNo);
			this.Fields.Add("Amount", BUSQualityComplaintEntityFields.Amount);
			this.Fields.Add("ComplaintContent", BUSQualityComplaintEntityFields.ComplaintContent);
			this.Fields.Add("ComplaintSuggestion", BUSQualityComplaintEntityFields.ComplaintSuggestion);
			this.Fields.Add("DealPerson", BUSQualityComplaintEntityFields.DealPerson);
			this.Fields.Add("DealPersonSpell", BUSQualityComplaintEntityFields.DealPersonSpell);
			this.Fields.Add("DealDate", BUSQualityComplaintEntityFields.DealDate);
			this.Fields.Add("DealSuggestion", BUSQualityComplaintEntityFields.DealSuggestion);
			this.Fields.Add("DealResult", BUSQualityComplaintEntityFields.DealResult);
			this.Fields.Add("CreateUserID", BUSQualityComplaintEntityFields.CreateUserID);
			this.Fields.Add("CreateDate", BUSQualityComplaintEntityFields.CreateDate);
			this.Fields.Add("LastModifyUserID", BUSQualityComplaintEntityFields.LastModifyUserID);
			this.Fields.Add("LastModifyDate", BUSQualityComplaintEntityFields.LastModifyDate);
			this.Fields.Add("ComplaintRemrk", BUSQualityComplaintEntityFields.ComplaintRemrk);
			this.Fields.Add("Reservation1", BUSQualityComplaintEntityFields.Reservation1);
			this.Fields.Add("Reservation2", BUSQualityComplaintEntityFields.Reservation2);
			this.Fields.Add("Reservation3", BUSQualityComplaintEntityFields.Reservation3);
			this.Fields.Add("Reservation4", BUSQualityComplaintEntityFields.Reservation4);
			this.Fields.Add("Reservation5", BUSQualityComplaintEntityFields.Reservation5);
			this.Fields.Add("Reservation6", BUSQualityComplaintEntityFields.Reservation6);
			this.Fields.Add("Reservation7", BUSQualityComplaintEntityFields.Reservation7);
			this.Fields.Add("Reservation8", BUSQualityComplaintEntityFields.Reservation8);
			this.Fields.Add("Reservation9", BUSQualityComplaintEntityFields.Reservation9);
			this.Fields.Add("Reservation10", BUSQualityComplaintEntityFields.Reservation10);
		}
	}

	#region BUSQualityComplaintEntityFields

	public class BUSQualityComplaintEntityFields
	{
		public static EntityField ComplaintID
		{
			get { return new EntityField("BUS_QualityComplaint", 0, "ComplaintID", SqlDbType.Int, true, true, true, false); }
		}

		public static EntityField ComplaintCode
		{
			get { return new EntityField("BUS_QualityComplaint", 1, "ComplaintCode", SqlDbType.NVarChar, false, false, true, false); }
		}

		public static EntityField ComplaintPerson
		{
			get { return new EntityField("BUS_QualityComplaint", 2, "ComplaintPerson", SqlDbType.NVarChar, false, false, false, true); }
		}

		public static EntityField ComplaintSpell
		{
			get { return new EntityField("BUS_QualityComplaint", 3, "ComplaintSpell", SqlDbType.NVarChar, false, false, false, true); }
		}

		public static EntityField ComplaintContact
		{
			get { return new EntityField("BUS_QualityComplaint", 4, "ComplaintContact", SqlDbType.NVarChar, false, false, false, true); }
		}

		public static EntityField ComplaintCompany
		{
			get { return new EntityField("BUS_QualityComplaint", 5, "ComplaintCompany", SqlDbType.NVarChar, false, false, false, true); }
		}

		public static EntityField CompanySpell
		{
			get { return new EntityField("BUS_QualityComplaint", 6, "CompanySpell", SqlDbType.NVarChar, false, false, false, true); }
		}

		public static EntityField ComplaintType
		{
			get { return new EntityField("BUS_QualityComplaint", 7, "ComplaintType", SqlDbType.NVarChar, false, false, false, true); }
		}

		public static EntityField ComplaintStyle
		{
			get { return new EntityField("BUS_QualityComplaint", 8, "ComplaintStyle", SqlDbType.NVarChar, false, false, false, true); }
		}

		public static EntityField ComplaintDate
		{
			get { return new EntityField("BUS_QualityComplaint", 9, "ComplaintDate", SqlDbType.DateTime, false, false, false, true); }
		}

		public static EntityField Operator
		{
			get { return new EntityField("BUS_QualityComplaint", 10, "Operator", SqlDbType.NVarChar, false, false, false, true); }
		}

		public static EntityField OperatorSpell
		{
			get { return new EntityField("BUS_QualityComplaint", 11, "OperatorSpell", SqlDbType.NVarChar, false, false, false, true); }
		}

		public static EntityField ProductID
		{
			get { return new EntityField("BUS_QualityComplaint", 12, "ProductID", SqlDbType.Int, false, false, false, true); }
		}

		public static EntityField BatchNo
		{
			get { return new EntityField("BUS_QualityComplaint", 13, "BatchNo", SqlDbType.NVarChar, false, false, false, true); }
		}

		public static EntityField Amount
		{
			get { return new EntityField("BUS_QualityComplaint", 14, "Amount", SqlDbType.Int, false, false, false, true); }
		}

		public static EntityField ComplaintContent
		{
			get { return new EntityField("BUS_QualityComplaint", 15, "ComplaintContent", SqlDbType.NVarChar, false, false, false, true); }
		}

		public static EntityField ComplaintSuggestion
		{
			get { return new EntityField("BUS_QualityComplaint", 16, "ComplaintSuggestion", SqlDbType.NVarChar, false, false, false, true); }
		}

		public static EntityField DealPerson
		{
			get { return new EntityField("BUS_QualityComplaint", 17, "DealPerson", SqlDbType.NVarChar, false, false, false, true); }
		}

		public static EntityField DealPersonSpell
		{
			get { return new EntityField("BUS_QualityComplaint", 18, "DealPersonSpell", SqlDbType.NVarChar, false, false, false, true); }
		}

		public static EntityField DealDate
		{
			get { return new EntityField("BUS_QualityComplaint", 19, "DealDate", SqlDbType.DateTime, false, false, false, true); }
		}

		public static EntityField DealSuggestion
		{
			get { return new EntityField("BUS_QualityComplaint", 20, "DealSuggestion", SqlDbType.NVarChar, false, false, false, true); }
		}

		public static EntityField DealResult
		{
			get { return new EntityField("BUS_QualityComplaint", 21, "DealResult", SqlDbType.NVarChar, false, false, false, true); }
		}

		public static EntityField CreateUserID
		{
			get { return new EntityField("BUS_QualityComplaint", 22, "CreateUserID", SqlDbType.UniqueIdentifier, false, false, false, true); }
		}

		public static EntityField CreateDate
		{
			get { return new EntityField("BUS_QualityComplaint", 23, "CreateDate", SqlDbType.DateTime, false, false, false, true); }
		}

		public static EntityField LastModifyUserID
		{
			get { return new EntityField("BUS_QualityComplaint", 24, "LastModifyUserID", SqlDbType.UniqueIdentifier, false, false, false, true); }
		}

		public static EntityField LastModifyDate
		{
			get { return new EntityField("BUS_QualityComplaint", 25, "LastModifyDate", SqlDbType.DateTime, false, false, false, true); }
		}

		public static EntityField ComplaintRemrk
		{
			get { return new EntityField("BUS_QualityComplaint", 26, "ComplaintRemrk", SqlDbType.NVarChar, false, false, false, true); }
		}

		public static EntityField Reservation1
		{
			get { return new EntityField("BUS_QualityComplaint", 27, "Reservation1", SqlDbType.NVarChar, false, false, false, true); }
		}

		public static EntityField Reservation2
		{
			get { return new EntityField("BUS_QualityComplaint", 28, "Reservation2", SqlDbType.NVarChar, false, false, false, true); }
		}

		public static EntityField Reservation3
		{
			get { return new EntityField("BUS_QualityComplaint", 29, "Reservation3", SqlDbType.NVarChar, false, false, false, true); }
		}

		public static EntityField Reservation4
		{
			get { return new EntityField("BUS_QualityComplaint", 30, "Reservation4", SqlDbType.NVarChar, false, false, false, true); }
		}

		public static EntityField Reservation5
		{
			get { return new EntityField("BUS_QualityComplaint", 31, "Reservation5", SqlDbType.NVarChar, false, false, false, true); }
		}

		public static EntityField Reservation6
		{
			get { return new EntityField("BUS_QualityComplaint", 32, "Reservation6", SqlDbType.NVarChar, false, false, false, true); }
		}

		public static EntityField Reservation7
		{
			get { return new EntityField("BUS_QualityComplaint", 33, "Reservation7", SqlDbType.NVarChar, false, false, false, true); }
		}

		public static EntityField Reservation8
		{
			get { return new EntityField("BUS_QualityComplaint", 34, "Reservation8", SqlDbType.NVarChar, false, false, false, true); }
		}

		public static EntityField Reservation9
		{
			get { return new EntityField("BUS_QualityComplaint", 35, "Reservation9", SqlDbType.NVarChar, false, false, false, true); }
		}

		public static EntityField Reservation10
		{
			get { return new EntityField("BUS_QualityComplaint", 36, "Reservation10", SqlDbType.NVarChar, false, false, false, true); }
		}

	}

	#endregion

	#region BUSQualityComplaintEntityFields2

	public enum BUSQualityComplaintEntityFields2
	{
		ComplaintID,

		ComplaintCode,

		ComplaintPerson,

		ComplaintSpell,

		ComplaintContact,

		ComplaintCompany,

		CompanySpell,

		ComplaintType,

		ComplaintStyle,

		ComplaintDate,

		Operator,

		OperatorSpell,

		ProductID,

		BatchNo,

		Amount,

		ComplaintContent,

		ComplaintSuggestion,

		DealPerson,

		DealPersonSpell,

		DealDate,

		DealSuggestion,

		DealResult,

		CreateUserID,

		CreateDate,

		LastModifyUserID,

		LastModifyDate,

		ComplaintRemrk,

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
