/*
 *	Build By: Codey Object Relation Mapping
 *	Build Data: 2013-09-18 10:43:15
 *	Build Type: Entity
 *	Description: BUSReceiveAcceptConditionEntity
*/

using System;
using System.Collections.Generic;
using System.Data;
using ORMSCore;

namespace DQS.Module.Entities
{
	public class BUSReceiveAcceptConditionEntity : EntityBase
	{
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

		public int ConditionTypeID
		{
			get { return (int)this.GetValue("ConditionTypeID"); } 
			set { this.SetValue("ConditionTypeID", value); } 
		}

		public string ConditionTypeName
		{
			get { return (string)this.GetValue("ConditionTypeName"); } 
			set { this.SetValue("ConditionTypeName", value); } 
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

		public string ConditionRemark
		{
			get { return (string)this.GetValue("ConditionRemark"); } 
			set { this.SetValue("ConditionRemark", value); } 
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

		public BUSReceiveAcceptConditionEntity()
		{
			this.TableName = "BUS_ReceiveAcceptCondition";
			this.Fields = new Dictionary<string, EntityField>();
			this.Fields.Add("ConditionID", BUSReceiveAcceptConditionEntityFields.ConditionID);
			this.Fields.Add("ConditionCode", BUSReceiveAcceptConditionEntityFields.ConditionCode);
			this.Fields.Add("ConditionName", BUSReceiveAcceptConditionEntityFields.ConditionName);
			this.Fields.Add("ConditionContent", BUSReceiveAcceptConditionEntityFields.ConditionContent);
			this.Fields.Add("ConditionMethod", BUSReceiveAcceptConditionEntityFields.ConditionMethod);
			this.Fields.Add("ConditionTypeID", BUSReceiveAcceptConditionEntityFields.ConditionTypeID);
			this.Fields.Add("ConditionTypeName", BUSReceiveAcceptConditionEntityFields.ConditionTypeName);
			this.Fields.Add("CreateUserID", BUSReceiveAcceptConditionEntityFields.CreateUserID);
			this.Fields.Add("CreateDate", BUSReceiveAcceptConditionEntityFields.CreateDate);
			this.Fields.Add("LastModifyUserID", BUSReceiveAcceptConditionEntityFields.LastModifyUserID);
			this.Fields.Add("LastModifyDate", BUSReceiveAcceptConditionEntityFields.LastModifyDate);
			this.Fields.Add("ConditionRemark", BUSReceiveAcceptConditionEntityFields.ConditionRemark);
			this.Fields.Add("Reservation1", BUSReceiveAcceptConditionEntityFields.Reservation1);
			this.Fields.Add("Reservation2", BUSReceiveAcceptConditionEntityFields.Reservation2);
			this.Fields.Add("Reservation3", BUSReceiveAcceptConditionEntityFields.Reservation3);
			this.Fields.Add("Reservation4", BUSReceiveAcceptConditionEntityFields.Reservation4);
			this.Fields.Add("Reservation5", BUSReceiveAcceptConditionEntityFields.Reservation5);
			this.Fields.Add("Reservation6", BUSReceiveAcceptConditionEntityFields.Reservation6);
			this.Fields.Add("Reservation7", BUSReceiveAcceptConditionEntityFields.Reservation7);
			this.Fields.Add("Reservation8", BUSReceiveAcceptConditionEntityFields.Reservation8);
			this.Fields.Add("Reservation9", BUSReceiveAcceptConditionEntityFields.Reservation9);
			this.Fields.Add("Reservation10", BUSReceiveAcceptConditionEntityFields.Reservation10);
		}
	}

	#region BUSReceiveAcceptConditionEntityFields

	public class BUSReceiveAcceptConditionEntityFields
	{
		public static EntityField ConditionID
		{
			get { return new EntityField("BUS_ReceiveAcceptCondition", 0, "ConditionID", SqlDbType.Int, true, true, true, false); }
		}

		public static EntityField ConditionCode
		{
			get { return new EntityField("BUS_ReceiveAcceptCondition", 1, "ConditionCode", SqlDbType.NVarChar, false, false, true, false); }
		}

		public static EntityField ConditionName
		{
			get { return new EntityField("BUS_ReceiveAcceptCondition", 2, "ConditionName", SqlDbType.NVarChar, false, false, false, false); }
		}

		public static EntityField ConditionContent
		{
			get { return new EntityField("BUS_ReceiveAcceptCondition", 3, "ConditionContent", SqlDbType.NVarChar, false, false, false, true); }
		}

		public static EntityField ConditionMethod
		{
			get { return new EntityField("BUS_ReceiveAcceptCondition", 4, "ConditionMethod", SqlDbType.NVarChar, false, false, false, true); }
		}

		public static EntityField ConditionTypeID
		{
			get { return new EntityField("BUS_ReceiveAcceptCondition", 5, "ConditionTypeID", SqlDbType.Int, false, false, false, true); }
		}

		public static EntityField ConditionTypeName
		{
			get { return new EntityField("BUS_ReceiveAcceptCondition", 6, "ConditionTypeName", SqlDbType.NVarChar, false, false, false, true); }
		}

		public static EntityField CreateUserID
		{
			get { return new EntityField("BUS_ReceiveAcceptCondition", 7, "CreateUserID", SqlDbType.UniqueIdentifier, false, false, false, true); }
		}

		public static EntityField CreateDate
		{
			get { return new EntityField("BUS_ReceiveAcceptCondition", 8, "CreateDate", SqlDbType.DateTime, false, false, false, true); }
		}

		public static EntityField LastModifyUserID
		{
			get { return new EntityField("BUS_ReceiveAcceptCondition", 9, "LastModifyUserID", SqlDbType.UniqueIdentifier, false, false, false, true); }
		}

		public static EntityField LastModifyDate
		{
			get { return new EntityField("BUS_ReceiveAcceptCondition", 10, "LastModifyDate", SqlDbType.DateTime, false, false, false, true); }
		}

		public static EntityField ConditionRemark
		{
			get { return new EntityField("BUS_ReceiveAcceptCondition", 11, "ConditionRemark", SqlDbType.NVarChar, false, false, false, true); }
		}

		public static EntityField Reservation1
		{
			get { return new EntityField("BUS_ReceiveAcceptCondition", 12, "Reservation1", SqlDbType.NVarChar, false, false, false, true); }
		}

		public static EntityField Reservation2
		{
			get { return new EntityField("BUS_ReceiveAcceptCondition", 13, "Reservation2", SqlDbType.NVarChar, false, false, false, true); }
		}

		public static EntityField Reservation3
		{
			get { return new EntityField("BUS_ReceiveAcceptCondition", 14, "Reservation3", SqlDbType.NVarChar, false, false, false, true); }
		}

		public static EntityField Reservation4
		{
			get { return new EntityField("BUS_ReceiveAcceptCondition", 15, "Reservation4", SqlDbType.NVarChar, false, false, false, true); }
		}

		public static EntityField Reservation5
		{
			get { return new EntityField("BUS_ReceiveAcceptCondition", 16, "Reservation5", SqlDbType.NVarChar, false, false, false, true); }
		}

		public static EntityField Reservation6
		{
			get { return new EntityField("BUS_ReceiveAcceptCondition", 17, "Reservation6", SqlDbType.NVarChar, false, false, false, true); }
		}

		public static EntityField Reservation7
		{
			get { return new EntityField("BUS_ReceiveAcceptCondition", 18, "Reservation7", SqlDbType.NVarChar, false, false, false, true); }
		}

		public static EntityField Reservation8
		{
			get { return new EntityField("BUS_ReceiveAcceptCondition", 19, "Reservation8", SqlDbType.NVarChar, false, false, false, true); }
		}

		public static EntityField Reservation9
		{
			get { return new EntityField("BUS_ReceiveAcceptCondition", 20, "Reservation9", SqlDbType.NVarChar, false, false, false, true); }
		}

		public static EntityField Reservation10
		{
			get { return new EntityField("BUS_ReceiveAcceptCondition", 21, "Reservation10", SqlDbType.NVarChar, false, false, false, true); }
		}

	}

	#endregion

	#region BUSReceiveAcceptConditionEntityFields2

	public enum BUSReceiveAcceptConditionEntityFields2
	{
		ConditionID,

		ConditionCode,

		ConditionName,

		ConditionContent,

		ConditionMethod,

		ConditionTypeID,

		ConditionTypeName,

		CreateUserID,

		CreateDate,

		LastModifyUserID,

		LastModifyDate,

		ConditionRemark,

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
