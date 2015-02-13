/*
 *	Build By: Codey Object Relation Mapping
 *	Build Data: 2013-07-19 19:48:09
 *	Build Type: Entity
 *	Description: BUSReceiveInspectionEntity
*/

using System;
using System.Collections.Generic;
using System.Data;
using ORMSCore;

namespace DQS.Module.Entities
{
	public class BUSReceiveInspectionEntity : EntityBase
	{
		public int InspectionID
		{
			get { return (int)this.GetValue("InspectionID"); } 
			set { this.SetValue("InspectionID", value); } 
		}

		public string InspectionCode
		{
			get { return (string)this.GetValue("InspectionCode"); } 
			set { this.SetValue("InspectionCode", value); } 
		}

		public int ReceiveID
		{
			get { return (int)this.GetValue("ReceiveID"); } 
			set { this.SetValue("ReceiveID", value); } 
		}

		public int ConditionID
		{
			get { return (int)this.GetValue("ConditionID"); } 
			set { this.SetValue("ConditionID", value); } 
		}

		public string ConditionCode
		{
			get { return (string)this.GetValue("ConditionCode"); } 
			set { this.SetValue("ConditionCode", value); } 
		}

		public string ConditionName
		{
			get { return (string)this.GetValue("ConditionName"); } 
			set { this.SetValue("ConditionName", value); } 
		}

		public string ConditionContent
		{
			get { return (string)this.GetValue("ConditionContent"); } 
			set { this.SetValue("ConditionContent", value); } 
		}

		public string ConditionMethod
		{
			get { return (string)this.GetValue("ConditionMethod"); } 
			set { this.SetValue("ConditionMethod", value); } 
		}

		public string ConditionSolution
		{
			get { return (string)this.GetValue("ConditionSolution"); } 
			set { this.SetValue("ConditionSolution", value); } 
		}

		public string ConditionResult
		{
			get { return (string)this.GetValue("ConditionResult"); } 
			set { this.SetValue("ConditionResult", value); } 
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

		public string InspectionRemark
		{
			get { return (string)this.GetValue("InspectionRemark"); } 
			set { this.SetValue("InspectionRemark", value); } 
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

		public BUSReceiveInspectionEntity()
		{
			this.TableName = "BUS_ReceiveInspection";
			this.Fields = new Dictionary<string, EntityField>();
			this.Fields.Add("InspectionID", BUSReceiveInspectionEntityFields.InspectionID);
			this.Fields.Add("InspectionCode", BUSReceiveInspectionEntityFields.InspectionCode);
			this.Fields.Add("ReceiveID", BUSReceiveInspectionEntityFields.ReceiveID);
			this.Fields.Add("ConditionID", BUSReceiveInspectionEntityFields.ConditionID);
			this.Fields.Add("ConditionCode", BUSReceiveInspectionEntityFields.ConditionCode);
			this.Fields.Add("ConditionName", BUSReceiveInspectionEntityFields.ConditionName);
			this.Fields.Add("ConditionContent", BUSReceiveInspectionEntityFields.ConditionContent);
			this.Fields.Add("ConditionMethod", BUSReceiveInspectionEntityFields.ConditionMethod);
			this.Fields.Add("ConditionSolution", BUSReceiveInspectionEntityFields.ConditionSolution);
			this.Fields.Add("ConditionResult", BUSReceiveInspectionEntityFields.ConditionResult);
			this.Fields.Add("DealResult", BUSReceiveInspectionEntityFields.DealResult);
			this.Fields.Add("CreateUserID", BUSReceiveInspectionEntityFields.CreateUserID);
			this.Fields.Add("CreateDate", BUSReceiveInspectionEntityFields.CreateDate);
			this.Fields.Add("LastModifyUserID", BUSReceiveInspectionEntityFields.LastModifyUserID);
			this.Fields.Add("LastModifyDate", BUSReceiveInspectionEntityFields.LastModifyDate);
			this.Fields.Add("InspectionRemark", BUSReceiveInspectionEntityFields.InspectionRemark);
			this.Fields.Add("Reservation1", BUSReceiveInspectionEntityFields.Reservation1);
			this.Fields.Add("Reservation2", BUSReceiveInspectionEntityFields.Reservation2);
			this.Fields.Add("Reservation3", BUSReceiveInspectionEntityFields.Reservation3);
			this.Fields.Add("Reservation4", BUSReceiveInspectionEntityFields.Reservation4);
			this.Fields.Add("Reservation5", BUSReceiveInspectionEntityFields.Reservation5);
			this.Fields.Add("Reservation6", BUSReceiveInspectionEntityFields.Reservation6);
			this.Fields.Add("Reservation7", BUSReceiveInspectionEntityFields.Reservation7);
			this.Fields.Add("Reservation8", BUSReceiveInspectionEntityFields.Reservation8);
			this.Fields.Add("Reservation9", BUSReceiveInspectionEntityFields.Reservation9);
			this.Fields.Add("Reservation10", BUSReceiveInspectionEntityFields.Reservation10);
		}
	}

	#region BUSReceiveInspectionEntityFields

	public class BUSReceiveInspectionEntityFields
	{
		public static EntityField InspectionID
		{
			get { return new EntityField("BUS_ReceiveInspection", 0, "InspectionID", SqlDbType.Int, true, false, true, false); }
		}

		public static EntityField InspectionCode
		{
			get { return new EntityField("BUS_ReceiveInspection", 1, "InspectionCode", SqlDbType.NVarChar, false, false, true, false); }
		}

		public static EntityField ReceiveID
		{
			get { return new EntityField("BUS_ReceiveInspection", 2, "ReceiveID", SqlDbType.Int, false, false, false, false); }
		}

		public static EntityField ConditionID
		{
			get { return new EntityField("BUS_ReceiveInspection", 3, "ConditionID", SqlDbType.Int, false, false, false, true); }
		}

		public static EntityField ConditionCode
		{
			get { return new EntityField("BUS_ReceiveInspection", 4, "ConditionCode", SqlDbType.NVarChar, false, false, false, true); }
		}

		public static EntityField ConditionName
		{
			get { return new EntityField("BUS_ReceiveInspection", 5, "ConditionName", SqlDbType.NVarChar, false, false, false, true); }
		}

		public static EntityField ConditionContent
		{
			get { return new EntityField("BUS_ReceiveInspection", 6, "ConditionContent", SqlDbType.NVarChar, false, false, false, true); }
		}

		public static EntityField ConditionMethod
		{
			get { return new EntityField("BUS_ReceiveInspection", 7, "ConditionMethod", SqlDbType.NVarChar, false, false, false, true); }
		}

		public static EntityField ConditionSolution
		{
			get { return new EntityField("BUS_ReceiveInspection", 8, "ConditionSolution", SqlDbType.NVarChar, false, false, false, true); }
		}

		public static EntityField ConditionResult
		{
			get { return new EntityField("BUS_ReceiveInspection", 9, "ConditionResult", SqlDbType.NVarChar, false, false, false, true); }
		}

		public static EntityField DealResult
		{
			get { return new EntityField("BUS_ReceiveInspection", 10, "DealResult", SqlDbType.NVarChar, false, false, false, true); }
		}

		public static EntityField CreateUserID
		{
			get { return new EntityField("BUS_ReceiveInspection", 11, "CreateUserID", SqlDbType.UniqueIdentifier, false, false, false, true); }
		}

		public static EntityField CreateDate
		{
			get { return new EntityField("BUS_ReceiveInspection", 12, "CreateDate", SqlDbType.DateTime, false, false, false, true); }
		}

		public static EntityField LastModifyUserID
		{
			get { return new EntityField("BUS_ReceiveInspection", 13, "LastModifyUserID", SqlDbType.UniqueIdentifier, false, false, false, true); }
		}

		public static EntityField LastModifyDate
		{
			get { return new EntityField("BUS_ReceiveInspection", 14, "LastModifyDate", SqlDbType.DateTime, false, false, false, true); }
		}

		public static EntityField InspectionRemark
		{
			get { return new EntityField("BUS_ReceiveInspection", 15, "InspectionRemark", SqlDbType.NVarChar, false, false, false, true); }
		}

		public static EntityField Reservation1
		{
			get { return new EntityField("BUS_ReceiveInspection", 16, "Reservation1", SqlDbType.NVarChar, false, false, false, true); }
		}

		public static EntityField Reservation2
		{
			get { return new EntityField("BUS_ReceiveInspection", 17, "Reservation2", SqlDbType.NVarChar, false, false, false, true); }
		}

		public static EntityField Reservation3
		{
			get { return new EntityField("BUS_ReceiveInspection", 18, "Reservation3", SqlDbType.NVarChar, false, false, false, true); }
		}

		public static EntityField Reservation4
		{
			get { return new EntityField("BUS_ReceiveInspection", 19, "Reservation4", SqlDbType.NVarChar, false, false, false, true); }
		}

		public static EntityField Reservation5
		{
			get { return new EntityField("BUS_ReceiveInspection", 20, "Reservation5", SqlDbType.NVarChar, false, false, false, true); }
		}

		public static EntityField Reservation6
		{
			get { return new EntityField("BUS_ReceiveInspection", 21, "Reservation6", SqlDbType.NVarChar, false, false, false, true); }
		}

		public static EntityField Reservation7
		{
			get { return new EntityField("BUS_ReceiveInspection", 22, "Reservation7", SqlDbType.NVarChar, false, false, false, true); }
		}

		public static EntityField Reservation8
		{
			get { return new EntityField("BUS_ReceiveInspection", 23, "Reservation8", SqlDbType.NVarChar, false, false, false, true); }
		}

		public static EntityField Reservation9
		{
			get { return new EntityField("BUS_ReceiveInspection", 24, "Reservation9", SqlDbType.NVarChar, false, false, false, true); }
		}

		public static EntityField Reservation10
		{
			get { return new EntityField("BUS_ReceiveInspection", 25, "Reservation10", SqlDbType.NVarChar, false, false, false, true); }
		}

	}

	#endregion

	#region BUSReceiveInspectionEntityFields2

	public enum BUSReceiveInspectionEntityFields2
	{
		InspectionID,

		InspectionCode,

		ReceiveID,

		ConditionID,

		ConditionCode,

		ConditionName,

		ConditionContent,

		ConditionMethod,

		ConditionSolution,

		ConditionResult,

		DealResult,

		CreateUserID,

		CreateDate,

		LastModifyUserID,

		LastModifyDate,

		InspectionRemark,

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
