/*
 *	Build By: Codey Object Relation Mapping
 *	Build Data: 2013-10-25 12:13:47
 *	Build Type: Entity
 *	Description: BUSCuringPlanEntity
*/

using System;
using System.Collections.Generic;
using System.Data;
using ORMSCore;

namespace DQS.Module.Entities
{
	public class BUSCuringPlanEntity : EntityBase
	{
		public int PlanID
		{
			get { return (int)this.GetValue("PlanID"); } 
			set { this.SetValue("PlanID", value); } 
		}

		public string PlanCode
		{
			get { return (string)this.GetValue("PlanCode"); } 
			set { this.SetValue("PlanCode", value); } 
		}

		public DateTime CuringDate
		{
			get { return (DateTime)this.GetValue("CuringDate"); } 
			set { this.SetValue("CuringDate", value); } 
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

		public string CuringMan
		{
			get { return (string)this.GetValue("CuringMan"); } 
			set { this.SetValue("CuringMan", value); } 
		}

		public string CuringManSpell
		{
			get { return (string)this.GetValue("CuringManSpell"); } 
			set { this.SetValue("CuringManSpell", value); } 
		}

		public bool IsDeal
		{
			get { return (bool)this.GetValue("IsDeal"); } 
			set { this.SetValue("IsDeal", value); } 
		}

		public bool IsPrint
		{
			get { return (bool)this.GetValue("IsPrint"); } 
			set { this.SetValue("IsPrint", value); } 
		}

		public string PrinterName
		{
			get { return (string)this.GetValue("PrinterName"); } 
			set { this.SetValue("PrinterName", value); } 
		}

		public string PrinterSpell
		{
			get { return (string)this.GetValue("PrinterSpell"); } 
			set { this.SetValue("PrinterSpell", value); } 
		}

		public DateTime PrintDate
		{
			get { return (DateTime)this.GetValue("PrintDate"); } 
			set { this.SetValue("PrintDate", value); } 
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

		public string PlanRemrk
		{
			get { return (string)this.GetValue("PlanRemrk"); } 
			set { this.SetValue("PlanRemrk", value); } 
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

		public BUSCuringPlanEntity()
		{
			this.TableName = "BUS_CuringPlan";
			this.Fields = new Dictionary<string, EntityField>();
			this.Fields.Add("PlanID", BUSCuringPlanEntityFields.PlanID);
			this.Fields.Add("PlanCode", BUSCuringPlanEntityFields.PlanCode);
			this.Fields.Add("CuringDate", BUSCuringPlanEntityFields.CuringDate);
			this.Fields.Add("ProductID", BUSCuringPlanEntityFields.ProductID);
			this.Fields.Add("BatchNo", BUSCuringPlanEntityFields.BatchNo);
			this.Fields.Add("Amount", BUSCuringPlanEntityFields.Amount);
			this.Fields.Add("CuringMan", BUSCuringPlanEntityFields.CuringMan);
			this.Fields.Add("CuringManSpell", BUSCuringPlanEntityFields.CuringManSpell);
			this.Fields.Add("IsDeal", BUSCuringPlanEntityFields.IsDeal);
			this.Fields.Add("IsPrint", BUSCuringPlanEntityFields.IsPrint);
			this.Fields.Add("PrinterName", BUSCuringPlanEntityFields.PrinterName);
			this.Fields.Add("PrinterSpell", BUSCuringPlanEntityFields.PrinterSpell);
			this.Fields.Add("PrintDate", BUSCuringPlanEntityFields.PrintDate);
			this.Fields.Add("StatusID", BUSCuringPlanEntityFields.StatusID);
			this.Fields.Add("StatusName", BUSCuringPlanEntityFields.StatusName);
			this.Fields.Add("CreateUserID", BUSCuringPlanEntityFields.CreateUserID);
			this.Fields.Add("CreateDate", BUSCuringPlanEntityFields.CreateDate);
			this.Fields.Add("LastModifyUserID", BUSCuringPlanEntityFields.LastModifyUserID);
			this.Fields.Add("LastModifyDate", BUSCuringPlanEntityFields.LastModifyDate);
			this.Fields.Add("PlanRemrk", BUSCuringPlanEntityFields.PlanRemrk);
			this.Fields.Add("Reservation1", BUSCuringPlanEntityFields.Reservation1);
			this.Fields.Add("Reservation2", BUSCuringPlanEntityFields.Reservation2);
			this.Fields.Add("Reservation3", BUSCuringPlanEntityFields.Reservation3);
			this.Fields.Add("Reservation4", BUSCuringPlanEntityFields.Reservation4);
			this.Fields.Add("Reservation5", BUSCuringPlanEntityFields.Reservation5);
			this.Fields.Add("Reservation6", BUSCuringPlanEntityFields.Reservation6);
			this.Fields.Add("Reservation7", BUSCuringPlanEntityFields.Reservation7);
			this.Fields.Add("Reservation8", BUSCuringPlanEntityFields.Reservation8);
			this.Fields.Add("Reservation9", BUSCuringPlanEntityFields.Reservation9);
			this.Fields.Add("Reservation10", BUSCuringPlanEntityFields.Reservation10);
		}
	}

	#region BUSCuringPlanEntityFields

	public class BUSCuringPlanEntityFields
	{
		public static EntityField PlanID
		{
			get { return new EntityField("BUS_CuringPlan", 0, "PlanID", SqlDbType.Int, true, true, true, false); }
		}

		public static EntityField PlanCode
		{
			get { return new EntityField("BUS_CuringPlan", 1, "PlanCode", SqlDbType.NVarChar, false, false, true, false); }
		}

		public static EntityField CuringDate
		{
			get { return new EntityField("BUS_CuringPlan", 2, "CuringDate", SqlDbType.DateTime, false, false, false, false); }
		}

		public static EntityField ProductID
		{
			get { return new EntityField("BUS_CuringPlan", 3, "ProductID", SqlDbType.Int, false, false, false, false); }
		}

		public static EntityField BatchNo
		{
			get { return new EntityField("BUS_CuringPlan", 4, "BatchNo", SqlDbType.NVarChar, false, false, false, true); }
		}

		public static EntityField Amount
		{
			get { return new EntityField("BUS_CuringPlan", 5, "Amount", SqlDbType.Int, false, false, false, true); }
		}

		public static EntityField CuringMan
		{
			get { return new EntityField("BUS_CuringPlan", 6, "CuringMan", SqlDbType.NVarChar, false, false, false, true); }
		}

		public static EntityField CuringManSpell
		{
			get { return new EntityField("BUS_CuringPlan", 7, "CuringManSpell", SqlDbType.NVarChar, false, false, false, true); }
		}

		public static EntityField IsDeal
		{
			get { return new EntityField("BUS_CuringPlan", 8, "IsDeal", SqlDbType.Bit, false, false, false, true); }
		}

		public static EntityField IsPrint
		{
			get { return new EntityField("BUS_CuringPlan", 9, "IsPrint", SqlDbType.Bit, false, false, false, true); }
		}

		public static EntityField PrinterName
		{
			get { return new EntityField("BUS_CuringPlan", 10, "PrinterName", SqlDbType.NVarChar, false, false, false, true); }
		}

		public static EntityField PrinterSpell
		{
			get { return new EntityField("BUS_CuringPlan", 11, "PrinterSpell", SqlDbType.NVarChar, false, false, false, true); }
		}

		public static EntityField PrintDate
		{
			get { return new EntityField("BUS_CuringPlan", 12, "PrintDate", SqlDbType.DateTime, false, false, false, true); }
		}

		public static EntityField StatusID
		{
			get { return new EntityField("BUS_CuringPlan", 13, "StatusID", SqlDbType.Int, false, false, false, true); }
		}

		public static EntityField StatusName
		{
			get { return new EntityField("BUS_CuringPlan", 14, "StatusName", SqlDbType.NVarChar, false, false, false, true); }
		}

		public static EntityField CreateUserID
		{
			get { return new EntityField("BUS_CuringPlan", 15, "CreateUserID", SqlDbType.UniqueIdentifier, false, false, false, true); }
		}

		public static EntityField CreateDate
		{
			get { return new EntityField("BUS_CuringPlan", 16, "CreateDate", SqlDbType.DateTime, false, false, false, true); }
		}

		public static EntityField LastModifyUserID
		{
			get { return new EntityField("BUS_CuringPlan", 17, "LastModifyUserID", SqlDbType.UniqueIdentifier, false, false, false, true); }
		}

		public static EntityField LastModifyDate
		{
			get { return new EntityField("BUS_CuringPlan", 18, "LastModifyDate", SqlDbType.DateTime, false, false, false, true); }
		}

		public static EntityField PlanRemrk
		{
			get { return new EntityField("BUS_CuringPlan", 19, "PlanRemrk", SqlDbType.NVarChar, false, false, false, true); }
		}

		public static EntityField Reservation1
		{
			get { return new EntityField("BUS_CuringPlan", 20, "Reservation1", SqlDbType.NVarChar, false, false, false, true); }
		}

		public static EntityField Reservation2
		{
			get { return new EntityField("BUS_CuringPlan", 21, "Reservation2", SqlDbType.NVarChar, false, false, false, true); }
		}

		public static EntityField Reservation3
		{
			get { return new EntityField("BUS_CuringPlan", 22, "Reservation3", SqlDbType.NVarChar, false, false, false, true); }
		}

		public static EntityField Reservation4
		{
			get { return new EntityField("BUS_CuringPlan", 23, "Reservation4", SqlDbType.NVarChar, false, false, false, true); }
		}

		public static EntityField Reservation5
		{
			get { return new EntityField("BUS_CuringPlan", 24, "Reservation5", SqlDbType.NVarChar, false, false, false, true); }
		}

		public static EntityField Reservation6
		{
			get { return new EntityField("BUS_CuringPlan", 25, "Reservation6", SqlDbType.NVarChar, false, false, false, true); }
		}

		public static EntityField Reservation7
		{
			get { return new EntityField("BUS_CuringPlan", 26, "Reservation7", SqlDbType.NVarChar, false, false, false, true); }
		}

		public static EntityField Reservation8
		{
			get { return new EntityField("BUS_CuringPlan", 27, "Reservation8", SqlDbType.NVarChar, false, false, false, true); }
		}

		public static EntityField Reservation9
		{
			get { return new EntityField("BUS_CuringPlan", 28, "Reservation9", SqlDbType.NVarChar, false, false, false, true); }
		}

		public static EntityField Reservation10
		{
			get { return new EntityField("BUS_CuringPlan", 29, "Reservation10", SqlDbType.NVarChar, false, false, false, true); }
		}

	}

	#endregion

	#region BUSCuringPlanEntityFields2

	public enum BUSCuringPlanEntityFields2
	{
		PlanID,

		PlanCode,

		CuringDate,

		ProductID,

		BatchNo,

		Amount,

		CuringMan,

		CuringManSpell,

		IsDeal,

		IsPrint,

		PrinterName,

		PrinterSpell,

		PrintDate,

		StatusID,

		StatusName,

		CreateUserID,

		CreateDate,

		LastModifyUserID,

		LastModifyDate,

		PlanRemrk,

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
