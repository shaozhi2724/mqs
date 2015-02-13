/*
 *	Build By: Codey Object Relation Mapping
 *	Build Data: 2013-07-19 19:48:09
 *	Build Type: Entity
 *	Description: BUSTransportCarEntity
*/

using System;
using System.Collections.Generic;
using System.Data;
using ORMSCore;

namespace DQS.Module.Entities
{
	public class BUSTransportCarEntity : EntityBase
	{
		public int CarID
		{
			get { return (int)this.GetValue("CarID"); } 
			set { this.SetValue("CarID", value); } 
		}

		public string CarCode
		{
			get { return (string)this.GetValue("CarCode"); } 
			set { this.SetValue("CarCode", value); } 
		}

		public string CarNo
		{
			get { return (string)this.GetValue("CarNo"); } 
			set { this.SetValue("CarNo", value); } 
		}

		public string CarName
		{
			get { return (string)this.GetValue("CarName"); } 
			set { this.SetValue("CarName", value); } 
		}

		public string CarColor
		{
			get { return (string)this.GetValue("CarColor"); } 
			set { this.SetValue("CarColor", value); } 
		}

		public string CarType
		{
			get { return (string)this.GetValue("CarType"); } 
			set { this.SetValue("CarType", value); } 
		}

		public string EngineNo
		{
			get { return (string)this.GetValue("EngineNo"); } 
			set { this.SetValue("EngineNo", value); } 
		}

		public string FrameNo
		{
			get { return (string)this.GetValue("FrameNo"); } 
			set { this.SetValue("FrameNo", value); } 
		}

		public DateTime BuyDate
		{
			get { return (DateTime)this.GetValue("BuyDate"); } 
			set { this.SetValue("BuyDate", value); } 
		}

		public string CarOwner
		{
			get { return (string)this.GetValue("CarOwner"); } 
			set { this.SetValue("CarOwner", value); } 
		}

		public string OwnerSpell
		{
			get { return (string)this.GetValue("OwnerSpell"); } 
			set { this.SetValue("OwnerSpell", value); } 
		}

		public string OwnerContact
		{
			get { return (string)this.GetValue("OwnerContact"); } 
			set { this.SetValue("OwnerContact", value); } 
		}

		public string TransportNo
		{
			get { return (string)this.GetValue("TransportNo"); } 
			set { this.SetValue("TransportNo", value); } 
		}

		public string CarStyle
		{
			get { return (string)this.GetValue("CarStyle"); } 
			set { this.SetValue("CarStyle", value); } 
		}

		public int EnterpriceID
		{
			get { return (int)this.GetValue("EnterpriceID"); } 
			set { this.SetValue("EnterpriceID", value); } 
		}

		public int DealerID
		{
			get { return (int)this.GetValue("DealerID"); } 
			set { this.SetValue("DealerID", value); } 
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

		public string CarRemark
		{
			get { return (string)this.GetValue("CarRemark"); } 
			set { this.SetValue("CarRemark", value); } 
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

		public BUSTransportCarEntity()
		{
			this.TableName = "BUS_TransportCar";
			this.Fields = new Dictionary<string, EntityField>();
			this.Fields.Add("CarID", BUSTransportCarEntityFields.CarID);
			this.Fields.Add("CarCode", BUSTransportCarEntityFields.CarCode);
			this.Fields.Add("CarNo", BUSTransportCarEntityFields.CarNo);
			this.Fields.Add("CarName", BUSTransportCarEntityFields.CarName);
			this.Fields.Add("CarColor", BUSTransportCarEntityFields.CarColor);
			this.Fields.Add("CarType", BUSTransportCarEntityFields.CarType);
			this.Fields.Add("EngineNo", BUSTransportCarEntityFields.EngineNo);
			this.Fields.Add("FrameNo", BUSTransportCarEntityFields.FrameNo);
			this.Fields.Add("BuyDate", BUSTransportCarEntityFields.BuyDate);
			this.Fields.Add("CarOwner", BUSTransportCarEntityFields.CarOwner);
			this.Fields.Add("OwnerSpell", BUSTransportCarEntityFields.OwnerSpell);
			this.Fields.Add("OwnerContact", BUSTransportCarEntityFields.OwnerContact);
			this.Fields.Add("TransportNo", BUSTransportCarEntityFields.TransportNo);
			this.Fields.Add("CarStyle", BUSTransportCarEntityFields.CarStyle);
			this.Fields.Add("EnterpriceID", BUSTransportCarEntityFields.EnterpriceID);
			this.Fields.Add("DealerID", BUSTransportCarEntityFields.DealerID);
			this.Fields.Add("CreateUserID", BUSTransportCarEntityFields.CreateUserID);
			this.Fields.Add("CreateDate", BUSTransportCarEntityFields.CreateDate);
			this.Fields.Add("LastModifyUserID", BUSTransportCarEntityFields.LastModifyUserID);
			this.Fields.Add("LastModifyDate", BUSTransportCarEntityFields.LastModifyDate);
			this.Fields.Add("CarRemark", BUSTransportCarEntityFields.CarRemark);
			this.Fields.Add("Reservation1", BUSTransportCarEntityFields.Reservation1);
			this.Fields.Add("Reservation2", BUSTransportCarEntityFields.Reservation2);
			this.Fields.Add("Reservation3", BUSTransportCarEntityFields.Reservation3);
			this.Fields.Add("Reservation4", BUSTransportCarEntityFields.Reservation4);
			this.Fields.Add("Reservation5", BUSTransportCarEntityFields.Reservation5);
			this.Fields.Add("Reservation6", BUSTransportCarEntityFields.Reservation6);
			this.Fields.Add("Reservation7", BUSTransportCarEntityFields.Reservation7);
			this.Fields.Add("Reservation8", BUSTransportCarEntityFields.Reservation8);
			this.Fields.Add("Reservation9", BUSTransportCarEntityFields.Reservation9);
			this.Fields.Add("Reservation10", BUSTransportCarEntityFields.Reservation10);
		}
	}

	#region BUSTransportCarEntityFields

	public class BUSTransportCarEntityFields
	{
		public static EntityField CarID
		{
			get { return new EntityField("BUS_TransportCar", 0, "CarID", SqlDbType.Int, true, true, true, false); }
		}

		public static EntityField CarCode
		{
			get { return new EntityField("BUS_TransportCar", 1, "CarCode", SqlDbType.NVarChar, false, false, true, false); }
		}

		public static EntityField CarNo
		{
			get { return new EntityField("BUS_TransportCar", 2, "CarNo", SqlDbType.NVarChar, false, false, true, false); }
		}

		public static EntityField CarName
		{
			get { return new EntityField("BUS_TransportCar", 3, "CarName", SqlDbType.NVarChar, false, false, false, true); }
		}

		public static EntityField CarColor
		{
			get { return new EntityField("BUS_TransportCar", 4, "CarColor", SqlDbType.NVarChar, false, false, false, true); }
		}

		public static EntityField CarType
		{
			get { return new EntityField("BUS_TransportCar", 5, "CarType", SqlDbType.NVarChar, false, false, false, true); }
		}

		public static EntityField EngineNo
		{
			get { return new EntityField("BUS_TransportCar", 6, "EngineNo", SqlDbType.NVarChar, false, false, false, true); }
		}

		public static EntityField FrameNo
		{
			get { return new EntityField("BUS_TransportCar", 7, "FrameNo", SqlDbType.NVarChar, false, false, false, true); }
		}

		public static EntityField BuyDate
		{
			get { return new EntityField("BUS_TransportCar", 8, "BuyDate", SqlDbType.DateTime, false, false, false, true); }
		}

		public static EntityField CarOwner
		{
			get { return new EntityField("BUS_TransportCar", 9, "CarOwner", SqlDbType.NVarChar, false, false, false, true); }
		}

		public static EntityField OwnerSpell
		{
			get { return new EntityField("BUS_TransportCar", 10, "OwnerSpell", SqlDbType.NVarChar, false, false, false, true); }
		}

		public static EntityField OwnerContact
		{
			get { return new EntityField("BUS_TransportCar", 11, "OwnerContact", SqlDbType.NVarChar, false, false, false, true); }
		}

		public static EntityField TransportNo
		{
			get { return new EntityField("BUS_TransportCar", 12, "TransportNo", SqlDbType.NVarChar, false, false, false, true); }
		}

		public static EntityField CarStyle
		{
			get { return new EntityField("BUS_TransportCar", 13, "CarStyle", SqlDbType.NVarChar, false, false, false, true); }
		}

		public static EntityField EnterpriceID
		{
			get { return new EntityField("BUS_TransportCar", 14, "EnterpriceID", SqlDbType.Int, false, false, false, true); }
		}

		public static EntityField DealerID
		{
			get { return new EntityField("BUS_TransportCar", 15, "DealerID", SqlDbType.Int, false, false, false, true); }
		}

		public static EntityField CreateUserID
		{
			get { return new EntityField("BUS_TransportCar", 16, "CreateUserID", SqlDbType.UniqueIdentifier, false, false, false, true); }
		}

		public static EntityField CreateDate
		{
			get { return new EntityField("BUS_TransportCar", 17, "CreateDate", SqlDbType.DateTime, false, false, false, true); }
		}

		public static EntityField LastModifyUserID
		{
			get { return new EntityField("BUS_TransportCar", 18, "LastModifyUserID", SqlDbType.UniqueIdentifier, false, false, false, true); }
		}

		public static EntityField LastModifyDate
		{
			get { return new EntityField("BUS_TransportCar", 19, "LastModifyDate", SqlDbType.DateTime, false, false, false, true); }
		}

		public static EntityField CarRemark
		{
			get { return new EntityField("BUS_TransportCar", 20, "CarRemark", SqlDbType.NVarChar, false, false, false, true); }
		}

		public static EntityField Reservation1
		{
			get { return new EntityField("BUS_TransportCar", 21, "Reservation1", SqlDbType.NVarChar, false, false, false, true); }
		}

		public static EntityField Reservation2
		{
			get { return new EntityField("BUS_TransportCar", 22, "Reservation2", SqlDbType.NVarChar, false, false, false, true); }
		}

		public static EntityField Reservation3
		{
			get { return new EntityField("BUS_TransportCar", 23, "Reservation3", SqlDbType.NVarChar, false, false, false, true); }
		}

		public static EntityField Reservation4
		{
			get { return new EntityField("BUS_TransportCar", 24, "Reservation4", SqlDbType.NVarChar, false, false, false, true); }
		}

		public static EntityField Reservation5
		{
			get { return new EntityField("BUS_TransportCar", 25, "Reservation5", SqlDbType.NVarChar, false, false, false, true); }
		}

		public static EntityField Reservation6
		{
			get { return new EntityField("BUS_TransportCar", 26, "Reservation6", SqlDbType.NVarChar, false, false, false, true); }
		}

		public static EntityField Reservation7
		{
			get { return new EntityField("BUS_TransportCar", 27, "Reservation7", SqlDbType.NVarChar, false, false, false, true); }
		}

		public static EntityField Reservation8
		{
			get { return new EntityField("BUS_TransportCar", 28, "Reservation8", SqlDbType.NVarChar, false, false, false, true); }
		}

		public static EntityField Reservation9
		{
			get { return new EntityField("BUS_TransportCar", 29, "Reservation9", SqlDbType.NVarChar, false, false, false, true); }
		}

		public static EntityField Reservation10
		{
			get { return new EntityField("BUS_TransportCar", 30, "Reservation10", SqlDbType.NVarChar, false, false, false, true); }
		}

	}

	#endregion

	#region BUSTransportCarEntityFields2

	public enum BUSTransportCarEntityFields2
	{
		CarID,

		CarCode,

		CarNo,

		CarName,

		CarColor,

		CarType,

		EngineNo,

		FrameNo,

		BuyDate,

		CarOwner,

		OwnerSpell,

		OwnerContact,

		TransportNo,

		CarStyle,

		EnterpriceID,

		DealerID,

		CreateUserID,

		CreateDate,

		LastModifyUserID,

		LastModifyDate,

		CarRemark,

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
