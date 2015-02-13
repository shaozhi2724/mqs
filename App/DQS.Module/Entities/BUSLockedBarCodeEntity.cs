/*
 *	Build By: Codey Object Relation Mapping
 *	Build Data: 2013-07-19 19:48:09
 *	Build Type: Entity
 *	Description: BUSLockedBarCodeEntity
*/

using System;
using System.Collections.Generic;
using System.Data;
using ORMSCore;

namespace DQS.Module.Entities
{
	public class BUSLockedBarCodeEntity : EntityBase
	{
		public int BarID
		{
			get { return (int)this.GetValue("BarID"); } 
			set { this.SetValue("BarID", value); } 
		}

		public string BarCode
		{
			get { return (string)this.GetValue("BarCode"); } 
			set { this.SetValue("BarCode", value); } 
		}

		public int LockedID
		{
			get { return (int)this.GetValue("LockedID"); } 
			set { this.SetValue("LockedID", value); } 
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

		public BUSLockedBarCodeEntity()
		{
			this.TableName = "BUS_LockedBarCode";
			this.Fields = new Dictionary<string, EntityField>();
			this.Fields.Add("BarID", BUSLockedBarCodeEntityFields.BarID);
			this.Fields.Add("BarCode", BUSLockedBarCodeEntityFields.BarCode);
			this.Fields.Add("LockedID", BUSLockedBarCodeEntityFields.LockedID);
			this.Fields.Add("CreateUserID", BUSLockedBarCodeEntityFields.CreateUserID);
			this.Fields.Add("CreateDate", BUSLockedBarCodeEntityFields.CreateDate);
			this.Fields.Add("Reservation1", BUSLockedBarCodeEntityFields.Reservation1);
			this.Fields.Add("Reservation2", BUSLockedBarCodeEntityFields.Reservation2);
			this.Fields.Add("Reservation3", BUSLockedBarCodeEntityFields.Reservation3);
			this.Fields.Add("Reservation4", BUSLockedBarCodeEntityFields.Reservation4);
			this.Fields.Add("Reservation5", BUSLockedBarCodeEntityFields.Reservation5);
		}
	}

	#region BUSLockedBarCodeEntityFields

	public class BUSLockedBarCodeEntityFields
	{
		public static EntityField BarID
		{
			get { return new EntityField("BUS_LockedBarCode", 0, "BarID", SqlDbType.Int, true, false, true, false); }
		}

		public static EntityField BarCode
		{
			get { return new EntityField("BUS_LockedBarCode", 1, "BarCode", SqlDbType.NVarChar, false, false, true, false); }
		}

		public static EntityField LockedID
		{
			get { return new EntityField("BUS_LockedBarCode", 2, "LockedID", SqlDbType.Int, false, false, false, false); }
		}

		public static EntityField CreateUserID
		{
			get { return new EntityField("BUS_LockedBarCode", 3, "CreateUserID", SqlDbType.UniqueIdentifier, false, false, false, true); }
		}

		public static EntityField CreateDate
		{
			get { return new EntityField("BUS_LockedBarCode", 4, "CreateDate", SqlDbType.DateTime, false, false, false, true); }
		}

		public static EntityField Reservation1
		{
			get { return new EntityField("BUS_LockedBarCode", 5, "Reservation1", SqlDbType.NVarChar, false, false, false, true); }
		}

		public static EntityField Reservation2
		{
			get { return new EntityField("BUS_LockedBarCode", 6, "Reservation2", SqlDbType.NVarChar, false, false, false, true); }
		}

		public static EntityField Reservation3
		{
			get { return new EntityField("BUS_LockedBarCode", 7, "Reservation3", SqlDbType.NVarChar, false, false, false, true); }
		}

		public static EntityField Reservation4
		{
			get { return new EntityField("BUS_LockedBarCode", 8, "Reservation4", SqlDbType.NVarChar, false, false, false, true); }
		}

		public static EntityField Reservation5
		{
			get { return new EntityField("BUS_LockedBarCode", 9, "Reservation5", SqlDbType.NVarChar, false, false, false, true); }
		}

	}

	#endregion

	#region BUSLockedBarCodeEntityFields2

	public enum BUSLockedBarCodeEntityFields2
	{
		BarID,

		BarCode,

		LockedID,

		CreateUserID,

		CreateDate,

		Reservation1,

		Reservation2,

		Reservation3,

		Reservation4,

		Reservation5,

	}

	#endregion

}
