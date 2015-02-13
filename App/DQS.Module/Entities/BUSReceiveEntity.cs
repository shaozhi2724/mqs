/*
 *	Build By: Codey Object Relation Mapping
 *	Build Data: 2014-05-02 16:00:15
 *	Build Type: Entity
 *	Description: BUSReceiveEntity
*/

using System;
using System.Collections.Generic;
using System.Data;
using ORMSCore;

namespace DQS.Module.Entities
{
	public class BUSReceiveEntity : EntityBase
	{
		public int ReceiveID
		{
			get { return (int)this.GetValue("ReceiveID"); } 
			set { this.SetValue("ReceiveID", value); } 
		}

		public string ReceiveCode
		{
			get { return (string)this.GetValue("ReceiveCode"); } 
			set { this.SetValue("ReceiveCode", value); } 
		}

		public DateTime ReceiveDate
		{
			get { return (DateTime)this.GetValue("ReceiveDate"); } 
			set { this.SetValue("ReceiveDate", value); } 
		}

		public int ReceiveStatusID
		{
			get { return (int)this.GetValue("ReceiveStatusID"); } 
			set { this.SetValue("ReceiveStatusID", value); } 
		}

		public string ReceiveStatus
		{
			get { return (string)this.GetValue("ReceiveStatus"); } 
			set { this.SetValue("ReceiveStatus", value); } 
		}

		public string ReceiveStatusSpell
		{
			get { return (string)this.GetValue("ReceiveStatusSpell"); } 
			set { this.SetValue("ReceiveStatusSpell", value); } 
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
        public string DealerAddress
		{
            get { return (string)this.GetValue("DealerAddress"); }
            set { this.SetValue("DealerAddress", value); } 
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

		public string TransportTool
		{
			get { return (string)this.GetValue("TransportTool"); } 
			set { this.SetValue("TransportTool", value); } 
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

		public string ReceivePerson
		{
			get { return (string)this.GetValue("ReceivePerson"); } 
			set { this.SetValue("ReceivePerson", value); } 
		}

		public string ReceivePersonSpell
		{
			get { return (string)this.GetValue("ReceivePersonSpell"); } 
			set { this.SetValue("ReceivePersonSpell", value); } 
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

		public string ReceiveRemark
		{
			get { return (string)this.GetValue("ReceiveRemark"); } 
			set { this.SetValue("ReceiveRemark", value); } 
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

		public BUSReceiveEntity()
		{
			this.TableName = "BUS_Receive";
			this.Fields = new Dictionary<string, EntityField>();
			this.Fields.Add("ReceiveID", BUSReceiveEntityFields.ReceiveID);
			this.Fields.Add("ReceiveCode", BUSReceiveEntityFields.ReceiveCode);
			this.Fields.Add("ReceiveDate", BUSReceiveEntityFields.ReceiveDate);
			this.Fields.Add("ReceiveStatusID", BUSReceiveEntityFields.ReceiveStatusID);
			this.Fields.Add("ReceiveStatus", BUSReceiveEntityFields.ReceiveStatus);
			this.Fields.Add("ReceiveStatusSpell", BUSReceiveEntityFields.ReceiveStatusSpell);
			this.Fields.Add("DealerID", BUSReceiveEntityFields.DealerID);
			this.Fields.Add("DealerCode", BUSReceiveEntityFields.DealerCode);
			this.Fields.Add("DealerName", BUSReceiveEntityFields.DealerName);
			this.Fields.Add("DealerSpell", BUSReceiveEntityFields.DealerSpell);
            this.Fields.Add("DealerAddress", BUSReceiveEntityFields.DealerAddress);
			this.Fields.Add("TransportID", BUSReceiveEntityFields.TransportID);
			this.Fields.Add("TransportCode", BUSReceiveEntityFields.TransportCode);
			this.Fields.Add("TransportTool", BUSReceiveEntityFields.TransportTool);
			this.Fields.Add("PeerCode", BUSReceiveEntityFields.PeerCode);
			this.Fields.Add("PeerDate", BUSReceiveEntityFields.PeerDate);
			this.Fields.Add("CarryCompnay", BUSReceiveEntityFields.CarryCompnay);
			this.Fields.Add("CarryCompnaySpell", BUSReceiveEntityFields.CarryCompnaySpell);
			this.Fields.Add("CarryPerson", BUSReceiveEntityFields.CarryPerson);
			this.Fields.Add("CarryPersonSpell", BUSReceiveEntityFields.CarryPersonSpell);
			this.Fields.Add("CarryPersonContact", BUSReceiveEntityFields.CarryPersonContact);
			this.Fields.Add("BillID", BUSReceiveEntityFields.BillID);
			this.Fields.Add("BillCode", BUSReceiveEntityFields.BillCode);
			this.Fields.Add("BillDate", BUSReceiveEntityFields.BillDate);
			this.Fields.Add("BillTypeID", BUSReceiveEntityFields.BillTypeID);
			this.Fields.Add("BillTypeName", BUSReceiveEntityFields.BillTypeName);
			this.Fields.Add("BillTypeSpell", BUSReceiveEntityFields.BillTypeSpell);
			this.Fields.Add("ReceivePerson", BUSReceiveEntityFields.ReceivePerson);
			this.Fields.Add("ReceivePersonSpell", BUSReceiveEntityFields.ReceivePersonSpell);
			this.Fields.Add("CreateUserID", BUSReceiveEntityFields.CreateUserID);
			this.Fields.Add("CreateDate", BUSReceiveEntityFields.CreateDate);
			this.Fields.Add("LastModifyUserID", BUSReceiveEntityFields.LastModifyUserID);
			this.Fields.Add("LastModifyDate", BUSReceiveEntityFields.LastModifyDate);
			this.Fields.Add("ReceiveRemark", BUSReceiveEntityFields.ReceiveRemark);
			this.Fields.Add("Reservation1", BUSReceiveEntityFields.Reservation1);
			this.Fields.Add("Reservation2", BUSReceiveEntityFields.Reservation2);
			this.Fields.Add("Reservation3", BUSReceiveEntityFields.Reservation3);
			this.Fields.Add("Reservation4", BUSReceiveEntityFields.Reservation4);
			this.Fields.Add("Reservation5", BUSReceiveEntityFields.Reservation5);
			this.Fields.Add("Reservation6", BUSReceiveEntityFields.Reservation6);
			this.Fields.Add("Reservation7", BUSReceiveEntityFields.Reservation7);
			this.Fields.Add("Reservation8", BUSReceiveEntityFields.Reservation8);
			this.Fields.Add("Reservation9", BUSReceiveEntityFields.Reservation9);
			this.Fields.Add("Reservation10", BUSReceiveEntityFields.Reservation10);
		}
	}

	#region BUSReceiveEntityFields

	public class BUSReceiveEntityFields
	{
		public static EntityField ReceiveID
		{
			get { return new EntityField("BUS_Receive", 0, "ReceiveID", SqlDbType.Int, true, true, true, false); }
		}

		public static EntityField ReceiveCode
		{
			get { return new EntityField("BUS_Receive", 1, "ReceiveCode", SqlDbType.NVarChar, false, false, true, false); }
		}

		public static EntityField ReceiveDate
		{
			get { return new EntityField("BUS_Receive", 2, "ReceiveDate", SqlDbType.DateTime, false, false, false, true); }
		}

		public static EntityField ReceiveStatusID
		{
			get { return new EntityField("BUS_Receive", 3, "ReceiveStatusID", SqlDbType.Int, false, false, false, true); }
		}

		public static EntityField ReceiveStatus
		{
			get { return new EntityField("BUS_Receive", 4, "ReceiveStatus", SqlDbType.NVarChar, false, false, false, true); }
		}

		public static EntityField ReceiveStatusSpell
		{
			get { return new EntityField("BUS_Receive", 5, "ReceiveStatusSpell", SqlDbType.NVarChar, false, false, false, true); }
		}

		public static EntityField DealerID
		{
			get { return new EntityField("BUS_Receive", 6, "DealerID", SqlDbType.Int, false, false, false, true); }
		}

		public static EntityField DealerCode
		{
			get { return new EntityField("BUS_Receive", 7, "DealerCode", SqlDbType.NVarChar, false, false, false, true); }
		}

		public static EntityField DealerName
		{
			get { return new EntityField("BUS_Receive", 8, "DealerName", SqlDbType.NVarChar, false, false, false, true); }
		}

		public static EntityField DealerSpell
		{
			get { return new EntityField("BUS_Receive", 9, "DealerSpell", SqlDbType.NVarChar, false, false, false, true); }
		}

        public static EntityField DealerAddress
		{
            get { return new EntityField("BUS_Receive", 10, "DealerAddress", SqlDbType.NVarChar, false, false, false, true); }
		}

		public static EntityField TransportID
		{
			get { return new EntityField("BUS_Receive", 11, "TransportID", SqlDbType.Int, false, false, false, true); }
		}

		public static EntityField TransportCode
		{
			get { return new EntityField("BUS_Receive", 12, "TransportCode", SqlDbType.NVarChar, false, false, false, true); }
		}

		public static EntityField TransportTool
		{
			get { return new EntityField("BUS_Receive", 13, "TransportTool", SqlDbType.NVarChar, false, false, false, true); }
		}

		public static EntityField PeerCode
		{
			get { return new EntityField("BUS_Receive", 14, "PeerCode", SqlDbType.NVarChar, false, false, false, true); }
		}

		public static EntityField PeerDate
		{
			get { return new EntityField("BUS_Receive", 15, "PeerDate", SqlDbType.DateTime, false, false, false, true); }
		}

		public static EntityField CarryCompnay
		{
			get { return new EntityField("BUS_Receive", 16, "CarryCompnay", SqlDbType.NVarChar, false, false, false, true); }
		}

		public static EntityField CarryCompnaySpell
		{
			get { return new EntityField("BUS_Receive", 17, "CarryCompnaySpell", SqlDbType.NVarChar, false, false, false, true); }
		}

		public static EntityField CarryPerson
		{
			get { return new EntityField("BUS_Receive", 18, "CarryPerson", SqlDbType.NVarChar, false, false, false, true); }
		}

		public static EntityField CarryPersonSpell
		{
			get { return new EntityField("BUS_Receive", 19, "CarryPersonSpell", SqlDbType.NVarChar, false, false, false, true); }
		}

		public static EntityField CarryPersonContact
		{
			get { return new EntityField("BUS_Receive", 20, "CarryPersonContact", SqlDbType.NVarChar, false, false, false, true); }
		}

		public static EntityField BillID
		{
			get { return new EntityField("BUS_Receive", 21, "BillID", SqlDbType.Int, false, false, false, true); }
		}

		public static EntityField BillCode
		{
			get { return new EntityField("BUS_Receive", 22, "BillCode", SqlDbType.NVarChar, false, false, false, true); }
		}

		public static EntityField BillDate
		{
			get { return new EntityField("BUS_Receive", 23, "BillDate", SqlDbType.DateTime, false, false, false, true); }
		}

		public static EntityField BillTypeID
		{
			get { return new EntityField("BUS_Receive", 24, "BillTypeID", SqlDbType.Int, false, false, false, true); }
		}

		public static EntityField BillTypeName
		{
			get { return new EntityField("BUS_Receive", 25, "BillTypeName", SqlDbType.NVarChar, false, false, false, true); }
		}

		public static EntityField BillTypeSpell
		{
			get { return new EntityField("BUS_Receive", 26, "BillTypeSpell", SqlDbType.NVarChar, false, false, false, true); }
		}

		public static EntityField ReceivePerson
		{
			get { return new EntityField("BUS_Receive", 27, "ReceivePerson", SqlDbType.NVarChar, false, false, false, true); }
		}

		public static EntityField ReceivePersonSpell
		{
			get { return new EntityField("BUS_Receive", 28, "ReceivePersonSpell", SqlDbType.NVarChar, false, false, false, true); }
		}

		public static EntityField CreateUserID
		{
			get { return new EntityField("BUS_Receive", 29, "CreateUserID", SqlDbType.UniqueIdentifier, false, false, false, true); }
		}

		public static EntityField CreateDate
		{
			get { return new EntityField("BUS_Receive", 30, "CreateDate", SqlDbType.DateTime, false, false, false, true); }
		}

		public static EntityField LastModifyUserID
		{
			get { return new EntityField("BUS_Receive", 31, "LastModifyUserID", SqlDbType.UniqueIdentifier, false, false, false, true); }
		}

		public static EntityField LastModifyDate
		{
			get { return new EntityField("BUS_Receive", 32, "LastModifyDate", SqlDbType.DateTime, false, false, false, true); }
		}

		public static EntityField ReceiveRemark
		{
			get { return new EntityField("BUS_Receive", 33, "ReceiveRemark", SqlDbType.NVarChar, false, false, false, true); }
		}

		public static EntityField Reservation1
		{
			get { return new EntityField("BUS_Receive", 34, "Reservation1", SqlDbType.NVarChar, false, false, false, true); }
		}

		public static EntityField Reservation2
		{
			get { return new EntityField("BUS_Receive", 35, "Reservation2", SqlDbType.NVarChar, false, false, false, true); }
		}

		public static EntityField Reservation3
		{
			get { return new EntityField("BUS_Receive", 36, "Reservation3", SqlDbType.NVarChar, false, false, false, true); }
		}

		public static EntityField Reservation4
		{
			get { return new EntityField("BUS_Receive", 37, "Reservation4", SqlDbType.NVarChar, false, false, false, true); }
		}

		public static EntityField Reservation5
		{
			get { return new EntityField("BUS_Receive", 38, "Reservation5", SqlDbType.NVarChar, false, false, false, true); }
		}

		public static EntityField Reservation6
		{
			get { return new EntityField("BUS_Receive", 39, "Reservation6", SqlDbType.NVarChar, false, false, false, true); }
		}

		public static EntityField Reservation7
		{
			get { return new EntityField("BUS_Receive", 40, "Reservation7", SqlDbType.NVarChar, false, false, false, true); }
		}

		public static EntityField Reservation8
		{
			get { return new EntityField("BUS_Receive", 41, "Reservation8", SqlDbType.NVarChar, false, false, false, true); }
		}

		public static EntityField Reservation9
		{
			get { return new EntityField("BUS_Receive", 42, "Reservation9", SqlDbType.NVarChar, false, false, false, true); }
		}

		public static EntityField Reservation10
		{
			get { return new EntityField("BUS_Receive", 43, "Reservation10", SqlDbType.NVarChar, false, false, false, true); }
		}

	}

	#endregion

	#region BUSReceiveEntityFields2

	public enum BUSReceiveEntityFields2
	{
		ReceiveID,

		ReceiveCode,

		ReceiveDate,

		ReceiveStatusID,

		ReceiveStatus,

		ReceiveStatusSpell,

		DealerID,

		DealerCode,

		DealerName,

		DealerSpell,

        DealerAddress,

		TransportID,

		TransportCode,

		TransportTool,

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

		ReceivePerson,

		ReceivePersonSpell,

		CreateUserID,

		CreateDate,

		LastModifyUserID,

		LastModifyDate,

		ReceiveRemark,

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
