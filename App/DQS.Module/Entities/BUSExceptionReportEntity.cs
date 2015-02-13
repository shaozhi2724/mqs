/*
 *	Build By: Codey Object Relation Mapping
 *	Build Data: 2013-10-28 14:15:34
 *	Build Type: Entity
 *	Description: BUSExceptionReportEntity
*/

using System;
using System.Collections.Generic;
using System.Data;
using ORMSCore;

namespace DQS.Module.Entities
{
	public class BUSExceptionReportEntity : EntityBase
	{
		public int ExceptionID
		{
			get { return (int)this.GetValue("ExceptionID"); } 
			set { this.SetValue("ExceptionID", value); } 
		}

		public string ExceptionCode
		{
			get { return (string)this.GetValue("ExceptionCode"); } 
			set { this.SetValue("ExceptionCode", value); } 
		}

		public string Finder
		{
			get { return (string)this.GetValue("Finder"); } 
			set { this.SetValue("Finder", value); } 
		}

		public string FinderSpell
		{
			get { return (string)this.GetValue("FinderSpell"); } 
			set { this.SetValue("FinderSpell", value); } 
		}

		public DateTime FinderDate
		{
			get { return (DateTime)this.GetValue("FinderDate"); } 
			set { this.SetValue("FinderDate", value); } 
		}

		public string ExceptionContent
		{
			get { return (string)this.GetValue("ExceptionContent"); } 
			set { this.SetValue("ExceptionContent", value); } 
		}

		public bool IsDeal
		{
			get { return (bool)this.GetValue("IsDeal"); } 
			set { this.SetValue("IsDeal", value); } 
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

		public int ExceptionStatusID
		{
			get { return (int)this.GetValue("ExceptionStatusID"); } 
			set { this.SetValue("ExceptionStatusID", value); } 
		}

		public string ExceptionStatus
		{
			get { return (string)this.GetValue("ExceptionStatus"); } 
			set { this.SetValue("ExceptionStatus", value); } 
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

		public string ExceptionRemark
		{
			get { return (string)this.GetValue("ExceptionRemark"); } 
			set { this.SetValue("ExceptionRemark", value); } 
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

		public BUSExceptionReportEntity()
		{
			this.TableName = "BUS_ExceptionReport";
			this.Fields = new Dictionary<string, EntityField>();
			this.Fields.Add("ExceptionID", BUSExceptionReportEntityFields.ExceptionID);
			this.Fields.Add("ExceptionCode", BUSExceptionReportEntityFields.ExceptionCode);
			this.Fields.Add("Finder", BUSExceptionReportEntityFields.Finder);
			this.Fields.Add("FinderSpell", BUSExceptionReportEntityFields.FinderSpell);
			this.Fields.Add("FinderDate", BUSExceptionReportEntityFields.FinderDate);
			this.Fields.Add("ExceptionContent", BUSExceptionReportEntityFields.ExceptionContent);
			this.Fields.Add("IsDeal", BUSExceptionReportEntityFields.IsDeal);
			this.Fields.Add("DealPerson", BUSExceptionReportEntityFields.DealPerson);
			this.Fields.Add("DealPersonSpell", BUSExceptionReportEntityFields.DealPersonSpell);
			this.Fields.Add("DealDate", BUSExceptionReportEntityFields.DealDate);
			this.Fields.Add("DealSuggestion", BUSExceptionReportEntityFields.DealSuggestion);
			this.Fields.Add("DealResult", BUSExceptionReportEntityFields.DealResult);
			this.Fields.Add("ExceptionStatusID", BUSExceptionReportEntityFields.ExceptionStatusID);
			this.Fields.Add("ExceptionStatus", BUSExceptionReportEntityFields.ExceptionStatus);
			this.Fields.Add("CreateUserID", BUSExceptionReportEntityFields.CreateUserID);
			this.Fields.Add("CreateDate", BUSExceptionReportEntityFields.CreateDate);
			this.Fields.Add("LastModifyUserID", BUSExceptionReportEntityFields.LastModifyUserID);
			this.Fields.Add("LastModifyDate", BUSExceptionReportEntityFields.LastModifyDate);
			this.Fields.Add("ExceptionRemark", BUSExceptionReportEntityFields.ExceptionRemark);
			this.Fields.Add("Reservation1", BUSExceptionReportEntityFields.Reservation1);
			this.Fields.Add("Reservation2", BUSExceptionReportEntityFields.Reservation2);
			this.Fields.Add("Reservation3", BUSExceptionReportEntityFields.Reservation3);
			this.Fields.Add("Reservation4", BUSExceptionReportEntityFields.Reservation4);
			this.Fields.Add("Reservation5", BUSExceptionReportEntityFields.Reservation5);
			this.Fields.Add("Reservation6", BUSExceptionReportEntityFields.Reservation6);
			this.Fields.Add("Reservation7", BUSExceptionReportEntityFields.Reservation7);
			this.Fields.Add("Reservation8", BUSExceptionReportEntityFields.Reservation8);
			this.Fields.Add("Reservation9", BUSExceptionReportEntityFields.Reservation9);
			this.Fields.Add("Reservation10", BUSExceptionReportEntityFields.Reservation10);
		}
	}

	#region BUSExceptionReportEntityFields

	public class BUSExceptionReportEntityFields
	{
		public static EntityField ExceptionID
		{
			get { return new EntityField("BUS_ExceptionReport", 0, "ExceptionID", SqlDbType.Int, true, true, true, false); }
		}

		public static EntityField ExceptionCode
		{
			get { return new EntityField("BUS_ExceptionReport", 1, "ExceptionCode", SqlDbType.NVarChar, false, false, true, false); }
		}

		public static EntityField Finder
		{
			get { return new EntityField("BUS_ExceptionReport", 2, "Finder", SqlDbType.NVarChar, false, false, false, true); }
		}

		public static EntityField FinderSpell
		{
			get { return new EntityField("BUS_ExceptionReport", 3, "FinderSpell", SqlDbType.NVarChar, false, false, false, true); }
		}

		public static EntityField FinderDate
		{
			get { return new EntityField("BUS_ExceptionReport", 4, "FinderDate", SqlDbType.DateTime, false, false, false, true); }
		}

		public static EntityField ExceptionContent
		{
			get { return new EntityField("BUS_ExceptionReport", 5, "ExceptionContent", SqlDbType.NVarChar, false, false, false, true); }
		}

		public static EntityField IsDeal
		{
			get { return new EntityField("BUS_ExceptionReport", 6, "IsDeal", SqlDbType.Bit, false, false, false, true); }
		}

		public static EntityField DealPerson
		{
			get { return new EntityField("BUS_ExceptionReport", 7, "DealPerson", SqlDbType.NVarChar, false, false, false, true); }
		}

		public static EntityField DealPersonSpell
		{
			get { return new EntityField("BUS_ExceptionReport", 8, "DealPersonSpell", SqlDbType.NVarChar, false, false, false, true); }
		}

		public static EntityField DealDate
		{
			get { return new EntityField("BUS_ExceptionReport", 9, "DealDate", SqlDbType.DateTime, false, false, false, true); }
		}

		public static EntityField DealSuggestion
		{
			get { return new EntityField("BUS_ExceptionReport", 10, "DealSuggestion", SqlDbType.NVarChar, false, false, false, true); }
		}

		public static EntityField DealResult
		{
			get { return new EntityField("BUS_ExceptionReport", 11, "DealResult", SqlDbType.NVarChar, false, false, false, true); }
		}

		public static EntityField ExceptionStatusID
		{
			get { return new EntityField("BUS_ExceptionReport", 12, "ExceptionStatusID", SqlDbType.Int, false, false, false, true); }
		}

		public static EntityField ExceptionStatus
		{
			get { return new EntityField("BUS_ExceptionReport", 13, "ExceptionStatus", SqlDbType.NVarChar, false, false, false, true); }
		}

		public static EntityField CreateUserID
		{
			get { return new EntityField("BUS_ExceptionReport", 14, "CreateUserID", SqlDbType.UniqueIdentifier, false, false, false, true); }
		}

		public static EntityField CreateDate
		{
			get { return new EntityField("BUS_ExceptionReport", 15, "CreateDate", SqlDbType.DateTime, false, false, false, true); }
		}

		public static EntityField LastModifyUserID
		{
			get { return new EntityField("BUS_ExceptionReport", 16, "LastModifyUserID", SqlDbType.UniqueIdentifier, false, false, false, true); }
		}

		public static EntityField LastModifyDate
		{
			get { return new EntityField("BUS_ExceptionReport", 17, "LastModifyDate", SqlDbType.DateTime, false, false, false, true); }
		}

		public static EntityField ExceptionRemark
		{
			get { return new EntityField("BUS_ExceptionReport", 18, "ExceptionRemark", SqlDbType.NVarChar, false, false, false, true); }
		}

		public static EntityField Reservation1
		{
			get { return new EntityField("BUS_ExceptionReport", 19, "Reservation1", SqlDbType.NVarChar, false, false, false, true); }
		}

		public static EntityField Reservation2
		{
			get { return new EntityField("BUS_ExceptionReport", 20, "Reservation2", SqlDbType.NVarChar, false, false, false, true); }
		}

		public static EntityField Reservation3
		{
			get { return new EntityField("BUS_ExceptionReport", 21, "Reservation3", SqlDbType.NVarChar, false, false, false, true); }
		}

		public static EntityField Reservation4
		{
			get { return new EntityField("BUS_ExceptionReport", 22, "Reservation4", SqlDbType.NVarChar, false, false, false, true); }
		}

		public static EntityField Reservation5
		{
			get { return new EntityField("BUS_ExceptionReport", 23, "Reservation5", SqlDbType.NVarChar, false, false, false, true); }
		}

		public static EntityField Reservation6
		{
			get { return new EntityField("BUS_ExceptionReport", 24, "Reservation6", SqlDbType.NVarChar, false, false, false, true); }
		}

		public static EntityField Reservation7
		{
			get { return new EntityField("BUS_ExceptionReport", 25, "Reservation7", SqlDbType.NVarChar, false, false, false, true); }
		}

		public static EntityField Reservation8
		{
			get { return new EntityField("BUS_ExceptionReport", 26, "Reservation8", SqlDbType.NVarChar, false, false, false, true); }
		}

		public static EntityField Reservation9
		{
			get { return new EntityField("BUS_ExceptionReport", 27, "Reservation9", SqlDbType.NVarChar, false, false, false, true); }
		}

		public static EntityField Reservation10
		{
			get { return new EntityField("BUS_ExceptionReport", 28, "Reservation10", SqlDbType.NVarChar, false, false, false, true); }
		}

	}

	#endregion

	#region BUSExceptionReportEntityFields2

	public enum BUSExceptionReportEntityFields2
	{
		ExceptionID,

		ExceptionCode,

		Finder,

		FinderSpell,

		FinderDate,

		ExceptionContent,

		IsDeal,

		DealPerson,

		DealPersonSpell,

		DealDate,

		DealSuggestion,

		DealResult,

		ExceptionStatusID,

		ExceptionStatus,

		CreateUserID,

		CreateDate,

		LastModifyUserID,

		LastModifyDate,

		ExceptionRemark,

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
