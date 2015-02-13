/*
 *	Build By: Codey Object Relation Mapping
 *	Build Data: 2014-04-07 16:34:07
 *	Build Type: Entity
 *	Description: BUSDeclinedEntity
*/

using System;
using System.Collections.Generic;
using System.Data;
using ORMSCore;

namespace DQS.Module.Entities
{
	public class BUSDeclinedEntity : EntityBase
	{
		public int DeclinedID
		{
			get { return (int)this.GetValue("DeclinedID"); } 
			set { this.SetValue("DeclinedID", value); } 
		}

		public string DeclinedCode
		{
			get { return (string)this.GetValue("DeclinedCode"); } 
			set { this.SetValue("DeclinedCode", value); } 
		}

		public DateTime DeclinedDate
		{
			get { return (DateTime)this.GetValue("DeclinedDate"); } 
			set { this.SetValue("DeclinedDate", value); } 
		}

		public string DeclinedType
		{
			get { return (string)this.GetValue("DeclinedType"); } 
			set { this.SetValue("DeclinedType", value); } 
		}

		public int DealerID
		{
			get { return (int)this.GetValue("DealerID"); } 
			set { this.SetValue("DealerID", value); } 
		}

		public string DealerCode
		{
			get { return (string)this.GetValue("DealerCode"); } 
			set { this.SetValue("DealerCode", value); } 
		}

		public string DealerName
		{
			get { return (string)this.GetValue("DealerName"); } 
			set { this.SetValue("DealerName", value); } 
		}

		public string DealerSpell
		{
			get { return (string)this.GetValue("DealerSpell"); } 
			set { this.SetValue("DealerSpell", value); } 
		}

		public int TransportID
		{
			get { return (int)this.GetValue("TransportID"); } 
			set { this.SetValue("TransportID", value); } 
		}

		public string TransportCode
		{
			get { return (string)this.GetValue("TransportCode"); } 
			set { this.SetValue("TransportCode", value); } 
		}

		public string PeerCode
		{
			get { return (string)this.GetValue("PeerCode"); } 
			set { this.SetValue("PeerCode", value); } 
		}

		public DateTime PeerDate
		{
			get { return (DateTime)this.GetValue("PeerDate"); } 
			set { this.SetValue("PeerDate", value); } 
		}

		public string CarryCompnay
		{
			get { return (string)this.GetValue("CarryCompnay"); } 
			set { this.SetValue("CarryCompnay", value); } 
		}

		public string CarryCompnaySpell
		{
			get { return (string)this.GetValue("CarryCompnaySpell"); } 
			set { this.SetValue("CarryCompnaySpell", value); } 
		}

		public string CarryPerson
		{
			get { return (string)this.GetValue("CarryPerson"); } 
			set { this.SetValue("CarryPerson", value); } 
		}

		public string CarryPersonSpell
		{
			get { return (string)this.GetValue("CarryPersonSpell"); } 
			set { this.SetValue("CarryPersonSpell", value); } 
		}

		public string CarryPersonContact
		{
			get { return (string)this.GetValue("CarryPersonContact"); } 
			set { this.SetValue("CarryPersonContact", value); } 
		}

		public int BillID
		{
			get { return (int)this.GetValue("BillID"); } 
			set { this.SetValue("BillID", value); } 
		}

		public string BillCode
		{
			get { return (string)this.GetValue("BillCode"); } 
			set { this.SetValue("BillCode", value); } 
		}

		public DateTime BillDate
		{
			get { return (DateTime)this.GetValue("BillDate"); } 
			set { this.SetValue("BillDate", value); } 
		}

		public int BillTypeID
		{
			get { return (int)this.GetValue("BillTypeID"); } 
			set { this.SetValue("BillTypeID", value); } 
		}

		public string BillTypeName
		{
			get { return (string)this.GetValue("BillTypeName"); } 
			set { this.SetValue("BillTypeName", value); } 
		}

		public string BillTypeSpell
		{
			get { return (string)this.GetValue("BillTypeSpell"); } 
			set { this.SetValue("BillTypeSpell", value); } 
		}

		public string DeclinedPerson
		{
			get { return (string)this.GetValue("DeclinedPerson"); } 
			set { this.SetValue("DeclinedPerson", value); } 
		}

		public string DeclinedPersonSpell
		{
			get { return (string)this.GetValue("DeclinedPersonSpell"); } 
			set { this.SetValue("DeclinedPersonSpell", value); } 
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

		public string DeclinedRemark
		{
			get { return (string)this.GetValue("DeclinedRemark"); } 
			set { this.SetValue("DeclinedRemark", value); } 
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

		public BUSDeclinedEntity()
		{
			this.TableName = "BUS_Declined";
			this.Fields = new Dictionary<string, EntityField>();
			this.Fields.Add("DeclinedID", BUSDeclinedEntityFields.DeclinedID);
			this.Fields.Add("DeclinedCode", BUSDeclinedEntityFields.DeclinedCode);
			this.Fields.Add("DeclinedDate", BUSDeclinedEntityFields.DeclinedDate);
			this.Fields.Add("DeclinedType", BUSDeclinedEntityFields.DeclinedType);
			this.Fields.Add("DealerID", BUSDeclinedEntityFields.DealerID);
			this.Fields.Add("DealerCode", BUSDeclinedEntityFields.DealerCode);
			this.Fields.Add("DealerName", BUSDeclinedEntityFields.DealerName);
			this.Fields.Add("DealerSpell", BUSDeclinedEntityFields.DealerSpell);
			this.Fields.Add("TransportID", BUSDeclinedEntityFields.TransportID);
			this.Fields.Add("TransportCode", BUSDeclinedEntityFields.TransportCode);
			this.Fields.Add("PeerCode", BUSDeclinedEntityFields.PeerCode);
			this.Fields.Add("PeerDate", BUSDeclinedEntityFields.PeerDate);
			this.Fields.Add("CarryCompnay", BUSDeclinedEntityFields.CarryCompnay);
			this.Fields.Add("CarryCompnaySpell", BUSDeclinedEntityFields.CarryCompnaySpell);
			this.Fields.Add("CarryPerson", BUSDeclinedEntityFields.CarryPerson);
			this.Fields.Add("CarryPersonSpell", BUSDeclinedEntityFields.CarryPersonSpell);
			this.Fields.Add("CarryPersonContact", BUSDeclinedEntityFields.CarryPersonContact);
			this.Fields.Add("BillID", BUSDeclinedEntityFields.BillID);
			this.Fields.Add("BillCode", BUSDeclinedEntityFields.BillCode);
			this.Fields.Add("BillDate", BUSDeclinedEntityFields.BillDate);
			this.Fields.Add("BillTypeID", BUSDeclinedEntityFields.BillTypeID);
			this.Fields.Add("BillTypeName", BUSDeclinedEntityFields.BillTypeName);
			this.Fields.Add("BillTypeSpell", BUSDeclinedEntityFields.BillTypeSpell);
			this.Fields.Add("DeclinedPerson", BUSDeclinedEntityFields.DeclinedPerson);
			this.Fields.Add("DeclinedPersonSpell", BUSDeclinedEntityFields.DeclinedPersonSpell);
			this.Fields.Add("CreateUserID", BUSDeclinedEntityFields.CreateUserID);
			this.Fields.Add("CreateDate", BUSDeclinedEntityFields.CreateDate);
			this.Fields.Add("LastModifyUserID", BUSDeclinedEntityFields.LastModifyUserID);
			this.Fields.Add("LastModifyDate", BUSDeclinedEntityFields.LastModifyDate);
			this.Fields.Add("DeclinedRemark", BUSDeclinedEntityFields.DeclinedRemark);
			this.Fields.Add("Reservation1", BUSDeclinedEntityFields.Reservation1);
			this.Fields.Add("Reservation2", BUSDeclinedEntityFields.Reservation2);
			this.Fields.Add("Reservation3", BUSDeclinedEntityFields.Reservation3);
			this.Fields.Add("Reservation4", BUSDeclinedEntityFields.Reservation4);
			this.Fields.Add("Reservation5", BUSDeclinedEntityFields.Reservation5);
			this.Fields.Add("Reservation6", BUSDeclinedEntityFields.Reservation6);
			this.Fields.Add("Reservation7", BUSDeclinedEntityFields.Reservation7);
			this.Fields.Add("Reservation8", BUSDeclinedEntityFields.Reservation8);
			this.Fields.Add("Reservation9", BUSDeclinedEntityFields.Reservation9);
			this.Fields.Add("Reservation10", BUSDeclinedEntityFields.Reservation10);
		}
	}

	#region BUSDeclinedEntityFields

	public class BUSDeclinedEntityFields
	{
		public static EntityField DeclinedID
		{
			get { return new EntityField("BUS_Declined", 0, "DeclinedID", SqlDbType.Int, true, true, true, false); }
		}

		public static EntityField DeclinedCode
		{
			get { return new EntityField("BUS_Declined", 1, "DeclinedCode", SqlDbType.NVarChar, false, false, true, false); }
		}

		public static EntityField DeclinedDate
		{
			get { return new EntityField("BUS_Declined", 2, "DeclinedDate", SqlDbType.DateTime, false, false, false, true); }
		}

		public static EntityField DeclinedType
		{
			get { return new EntityField("BUS_Declined", 3, "DeclinedType", SqlDbType.NVarChar, false, false, false, true); }
		}

		public static EntityField DealerID
		{
			get { return new EntityField("BUS_Declined", 4, "DealerID", SqlDbType.Int, false, false, false, true); }
		}

		public static EntityField DealerCode
		{
			get { return new EntityField("BUS_Declined", 5, "DealerCode", SqlDbType.NVarChar, false, false, false, true); }
		}

		public static EntityField DealerName
		{
			get { return new EntityField("BUS_Declined", 6, "DealerName", SqlDbType.NVarChar, false, false, false, true); }
		}

		public static EntityField DealerSpell
		{
			get { return new EntityField("BUS_Declined", 7, "DealerSpell", SqlDbType.NVarChar, false, false, false, true); }
		}

		public static EntityField TransportID
		{
			get { return new EntityField("BUS_Declined", 8, "TransportID", SqlDbType.Int, false, false, false, true); }
		}

		public static EntityField TransportCode
		{
			get { return new EntityField("BUS_Declined", 9, "TransportCode", SqlDbType.NVarChar, false, false, false, true); }
		}

		public static EntityField PeerCode
		{
			get { return new EntityField("BUS_Declined", 10, "PeerCode", SqlDbType.NVarChar, false, false, false, true); }
		}

		public static EntityField PeerDate
		{
			get { return new EntityField("BUS_Declined", 11, "PeerDate", SqlDbType.DateTime, false, false, false, true); }
		}

		public static EntityField CarryCompnay
		{
			get { return new EntityField("BUS_Declined", 12, "CarryCompnay", SqlDbType.NVarChar, false, false, false, true); }
		}

		public static EntityField CarryCompnaySpell
		{
			get { return new EntityField("BUS_Declined", 13, "CarryCompnaySpell", SqlDbType.NVarChar, false, false, false, true); }
		}

		public static EntityField CarryPerson
		{
			get { return new EntityField("BUS_Declined", 14, "CarryPerson", SqlDbType.NVarChar, false, false, false, true); }
		}

		public static EntityField CarryPersonSpell
		{
			get { return new EntityField("BUS_Declined", 15, "CarryPersonSpell", SqlDbType.NVarChar, false, false, false, true); }
		}

		public static EntityField CarryPersonContact
		{
			get { return new EntityField("BUS_Declined", 16, "CarryPersonContact", SqlDbType.NVarChar, false, false, false, true); }
		}

		public static EntityField BillID
		{
			get { return new EntityField("BUS_Declined", 17, "BillID", SqlDbType.Int, false, false, false, true); }
		}

		public static EntityField BillCode
		{
			get { return new EntityField("BUS_Declined", 18, "BillCode", SqlDbType.NVarChar, false, false, false, true); }
		}

		public static EntityField BillDate
		{
			get { return new EntityField("BUS_Declined", 19, "BillDate", SqlDbType.DateTime, false, false, false, true); }
		}

		public static EntityField BillTypeID
		{
			get { return new EntityField("BUS_Declined", 20, "BillTypeID", SqlDbType.Int, false, false, false, true); }
		}

		public static EntityField BillTypeName
		{
			get { return new EntityField("BUS_Declined", 21, "BillTypeName", SqlDbType.NVarChar, false, false, false, true); }
		}

		public static EntityField BillTypeSpell
		{
			get { return new EntityField("BUS_Declined", 22, "BillTypeSpell", SqlDbType.NVarChar, false, false, false, true); }
		}

		public static EntityField DeclinedPerson
		{
			get { return new EntityField("BUS_Declined", 23, "DeclinedPerson", SqlDbType.NVarChar, false, false, false, true); }
		}

		public static EntityField DeclinedPersonSpell
		{
			get { return new EntityField("BUS_Declined", 24, "DeclinedPersonSpell", SqlDbType.NVarChar, false, false, false, true); }
		}

		public static EntityField CreateUserID
		{
			get { return new EntityField("BUS_Declined", 25, "CreateUserID", SqlDbType.UniqueIdentifier, false, false, false, true); }
		}

		public static EntityField CreateDate
		{
			get { return new EntityField("BUS_Declined", 26, "CreateDate", SqlDbType.DateTime, false, false, false, true); }
		}

		public static EntityField LastModifyUserID
		{
			get { return new EntityField("BUS_Declined", 27, "LastModifyUserID", SqlDbType.UniqueIdentifier, false, false, false, true); }
		}

		public static EntityField LastModifyDate
		{
			get { return new EntityField("BUS_Declined", 28, "LastModifyDate", SqlDbType.DateTime, false, false, false, true); }
		}

		public static EntityField DeclinedRemark
		{
			get { return new EntityField("BUS_Declined", 29, "DeclinedRemark", SqlDbType.NVarChar, false, false, false, true); }
		}

		public static EntityField Reservation1
		{
			get { return new EntityField("BUS_Declined", 30, "Reservation1", SqlDbType.NVarChar, false, false, false, true); }
		}

		public static EntityField Reservation2
		{
			get { return new EntityField("BUS_Declined", 31, "Reservation2", SqlDbType.NVarChar, false, false, false, true); }
		}

		public static EntityField Reservation3
		{
			get { return new EntityField("BUS_Declined", 32, "Reservation3", SqlDbType.NVarChar, false, false, false, true); }
		}

		public static EntityField Reservation4
		{
			get { return new EntityField("BUS_Declined", 33, "Reservation4", SqlDbType.NVarChar, false, false, false, true); }
		}

		public static EntityField Reservation5
		{
			get { return new EntityField("BUS_Declined", 34, "Reservation5", SqlDbType.NVarChar, false, false, false, true); }
		}

		public static EntityField Reservation6
		{
			get { return new EntityField("BUS_Declined", 35, "Reservation6", SqlDbType.NVarChar, false, false, false, true); }
		}

		public static EntityField Reservation7
		{
			get { return new EntityField("BUS_Declined", 36, "Reservation7", SqlDbType.NVarChar, false, false, false, true); }
		}

		public static EntityField Reservation8
		{
			get { return new EntityField("BUS_Declined", 37, "Reservation8", SqlDbType.NVarChar, false, false, false, true); }
		}

		public static EntityField Reservation9
		{
			get { return new EntityField("BUS_Declined", 38, "Reservation9", SqlDbType.NVarChar, false, false, false, true); }
		}

		public static EntityField Reservation10
		{
			get { return new EntityField("BUS_Declined", 39, "Reservation10", SqlDbType.NVarChar, false, false, false, true); }
		}

	}

	#endregion

	#region BUSDeclinedEntityFields2

	public enum BUSDeclinedEntityFields2
	{
		DeclinedID,

		DeclinedCode,

		DeclinedDate,

		DeclinedType,

		DealerID,

		DealerCode,

		DealerName,

		DealerSpell,

		TransportID,

		TransportCode,

		PeerCode,

		PeerDate,

		CarryCompnay,

		CarryCompnaySpell,

		CarryPerson,

		CarryPersonSpell,

		CarryPersonContact,

		BillID,

		BillCode,

		BillDate,

		BillTypeID,

		BillTypeName,

		BillTypeSpell,

		DeclinedPerson,

		DeclinedPersonSpell,

		CreateUserID,

		CreateDate,

		LastModifyUserID,

		LastModifyDate,

		DeclinedRemark,

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
