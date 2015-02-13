/*
 *	Build By: Codey Object Relation Mapping
 *	Build Data: 2013-10-25 12:13:47
 *	Build Type: Entity
 *	Description: BUSCuringCycleEntity
*/

using System;
using System.Collections.Generic;
using System.Data;
using ORMSCore;

namespace DQS.Module.Entities
{
	public class BUSCuringCycleEntity : EntityBase
	{
		public int CycleID
		{
			get { return (int)this.GetValue("CycleID"); } 
			set { this.SetValue("CycleID", value); } 
		}

		public string CycleCode
		{
			get { return (string)this.GetValue("CycleCode"); } 
			set { this.SetValue("CycleCode", value); } 
		}

		public int ProductID
		{
			get { return (int)this.GetValue("ProductID"); } 
			set { this.SetValue("ProductID", value); } 
		}

		public int CycleDays
		{
			get { return (int)this.GetValue("CycleDays"); } 
			set { this.SetValue("CycleDays", value); } 
		}

		public int PrePlanDays
		{
			get { return (int)this.GetValue("PrePlanDays"); } 
			set { this.SetValue("PrePlanDays", value); } 
		}

		public DateTime NextCycleDate
		{
			get { return (DateTime)this.GetValue("NextCycleDate"); } 
			set { this.SetValue("NextCycleDate", value); } 
		}

		public int PreAlarmDays
		{
			get { return (int)this.GetValue("PreAlarmDays"); } 
			set { this.SetValue("PreAlarmDays", value); } 
		}

		public int AfterAlarmDays
		{
			get { return (int)this.GetValue("AfterAlarmDays"); } 
			set { this.SetValue("AfterAlarmDays", value); } 
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

		public string CycleRemrk
		{
			get { return (string)this.GetValue("CycleRemrk"); } 
			set { this.SetValue("CycleRemrk", value); } 
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

		public BUSCuringCycleEntity()
		{
			this.TableName = "BUS_CuringCycle";
			this.Fields = new Dictionary<string, EntityField>();
			this.Fields.Add("CycleID", BUSCuringCycleEntityFields.CycleID);
			this.Fields.Add("CycleCode", BUSCuringCycleEntityFields.CycleCode);
			this.Fields.Add("ProductID", BUSCuringCycleEntityFields.ProductID);
			this.Fields.Add("CycleDays", BUSCuringCycleEntityFields.CycleDays);
			this.Fields.Add("PrePlanDays", BUSCuringCycleEntityFields.PrePlanDays);
			this.Fields.Add("NextCycleDate", BUSCuringCycleEntityFields.NextCycleDate);
			this.Fields.Add("PreAlarmDays", BUSCuringCycleEntityFields.PreAlarmDays);
			this.Fields.Add("AfterAlarmDays", BUSCuringCycleEntityFields.AfterAlarmDays);
			this.Fields.Add("CreateUserID", BUSCuringCycleEntityFields.CreateUserID);
			this.Fields.Add("CreateDate", BUSCuringCycleEntityFields.CreateDate);
			this.Fields.Add("LastModifyUserID", BUSCuringCycleEntityFields.LastModifyUserID);
			this.Fields.Add("LastModifyDate", BUSCuringCycleEntityFields.LastModifyDate);
			this.Fields.Add("CycleRemrk", BUSCuringCycleEntityFields.CycleRemrk);
			this.Fields.Add("Reservation1", BUSCuringCycleEntityFields.Reservation1);
			this.Fields.Add("Reservation2", BUSCuringCycleEntityFields.Reservation2);
			this.Fields.Add("Reservation3", BUSCuringCycleEntityFields.Reservation3);
			this.Fields.Add("Reservation4", BUSCuringCycleEntityFields.Reservation4);
			this.Fields.Add("Reservation5", BUSCuringCycleEntityFields.Reservation5);
			this.Fields.Add("Reservation6", BUSCuringCycleEntityFields.Reservation6);
			this.Fields.Add("Reservation7", BUSCuringCycleEntityFields.Reservation7);
			this.Fields.Add("Reservation8", BUSCuringCycleEntityFields.Reservation8);
			this.Fields.Add("Reservation9", BUSCuringCycleEntityFields.Reservation9);
			this.Fields.Add("Reservation10", BUSCuringCycleEntityFields.Reservation10);
		}
	}

	#region BUSCuringCycleEntityFields

	public class BUSCuringCycleEntityFields
	{
		public static EntityField CycleID
		{
			get { return new EntityField("BUS_CuringCycle", 0, "CycleID", SqlDbType.Int, true, true, true, false); }
		}

		public static EntityField CycleCode
		{
			get { return new EntityField("BUS_CuringCycle", 1, "CycleCode", SqlDbType.NVarChar, false, false, true, false); }
		}

		public static EntityField ProductID
		{
			get { return new EntityField("BUS_CuringCycle", 2, "ProductID", SqlDbType.Int, false, false, false, false); }
		}

		public static EntityField CycleDays
		{
			get { return new EntityField("BUS_CuringCycle", 3, "CycleDays", SqlDbType.Int, false, false, false, false); }
		}

		public static EntityField PrePlanDays
		{
			get { return new EntityField("BUS_CuringCycle", 4, "PrePlanDays", SqlDbType.Int, false, false, false, true); }
		}

		public static EntityField NextCycleDate
		{
			get { return new EntityField("BUS_CuringCycle", 5, "NextCycleDate", SqlDbType.DateTime, false, false, false, true); }
		}

		public static EntityField PreAlarmDays
		{
			get { return new EntityField("BUS_CuringCycle", 6, "PreAlarmDays", SqlDbType.Int, false, false, false, true); }
		}

		public static EntityField AfterAlarmDays
		{
			get { return new EntityField("BUS_CuringCycle", 7, "AfterAlarmDays", SqlDbType.Int, false, false, false, true); }
		}

		public static EntityField CreateUserID
		{
			get { return new EntityField("BUS_CuringCycle", 8, "CreateUserID", SqlDbType.UniqueIdentifier, false, false, false, true); }
		}

		public static EntityField CreateDate
		{
			get { return new EntityField("BUS_CuringCycle", 9, "CreateDate", SqlDbType.DateTime, false, false, false, true); }
		}

		public static EntityField LastModifyUserID
		{
			get { return new EntityField("BUS_CuringCycle", 10, "LastModifyUserID", SqlDbType.UniqueIdentifier, false, false, false, true); }
		}

		public static EntityField LastModifyDate
		{
			get { return new EntityField("BUS_CuringCycle", 11, "LastModifyDate", SqlDbType.DateTime, false, false, false, true); }
		}

		public static EntityField CycleRemrk
		{
			get { return new EntityField("BUS_CuringCycle", 12, "CycleRemrk", SqlDbType.NVarChar, false, false, false, true); }
		}

		public static EntityField Reservation1
		{
			get { return new EntityField("BUS_CuringCycle", 13, "Reservation1", SqlDbType.NVarChar, false, false, false, true); }
		}

		public static EntityField Reservation2
		{
			get { return new EntityField("BUS_CuringCycle", 14, "Reservation2", SqlDbType.NVarChar, false, false, false, true); }
		}

		public static EntityField Reservation3
		{
			get { return new EntityField("BUS_CuringCycle", 15, "Reservation3", SqlDbType.NVarChar, false, false, false, true); }
		}

		public static EntityField Reservation4
		{
			get { return new EntityField("BUS_CuringCycle", 16, "Reservation4", SqlDbType.NVarChar, false, false, false, true); }
		}

		public static EntityField Reservation5
		{
			get { return new EntityField("BUS_CuringCycle", 17, "Reservation5", SqlDbType.NVarChar, false, false, false, true); }
		}

		public static EntityField Reservation6
		{
			get { return new EntityField("BUS_CuringCycle", 18, "Reservation6", SqlDbType.NVarChar, false, false, false, true); }
		}

		public static EntityField Reservation7
		{
			get { return new EntityField("BUS_CuringCycle", 19, "Reservation7", SqlDbType.NVarChar, false, false, false, true); }
		}

		public static EntityField Reservation8
		{
			get { return new EntityField("BUS_CuringCycle", 20, "Reservation8", SqlDbType.NVarChar, false, false, false, true); }
		}

		public static EntityField Reservation9
		{
			get { return new EntityField("BUS_CuringCycle", 21, "Reservation9", SqlDbType.NVarChar, false, false, false, true); }
		}

		public static EntityField Reservation10
		{
			get { return new EntityField("BUS_CuringCycle", 22, "Reservation10", SqlDbType.NVarChar, false, false, false, true); }
		}

	}

	#endregion

	#region BUSCuringCycleEntityFields2

	public enum BUSCuringCycleEntityFields2
	{
		CycleID,

		CycleCode,

		ProductID,

		CycleDays,

		PrePlanDays,

		NextCycleDate,

		PreAlarmDays,

		AfterAlarmDays,

		CreateUserID,

		CreateDate,

		LastModifyUserID,

		LastModifyDate,

		CycleRemrk,

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
