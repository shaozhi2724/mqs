/*
 *	Build By: Codey Object Relation Mapping
 *	Build Data: 2014-04-13 10:37:27
 *	Build Type: Entity
 *	Description: BUSTransportRecordEntity
*/

using System;
using System.Collections.Generic;
using System.Data;
using ORMSCore;

namespace DQS.Module.Entities
{
	public class BUSTransportRecordEntity : EntityBase
	{
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

		public string RelateCompany
		{
			get { return (string)this.GetValue("RelateCompany"); } 
			set { this.SetValue("RelateCompany", value); } 
		}

		public string RelateCompanySpell
		{
			get { return (string)this.GetValue("RelateCompanySpell"); } 
			set { this.SetValue("RelateCompanySpell", value); } 
		}

		public string RelateAddress
		{
			get { return (string)this.GetValue("RelateAddress"); } 
			set { this.SetValue("RelateAddress", value); } 
		}

		public string RelatePerson
		{
			get { return (string)this.GetValue("RelatePerson"); } 
			set { this.SetValue("RelatePerson", value); } 
		}

		public string RelatePersonSpell
		{
			get { return (string)this.GetValue("RelatePersonSpell"); } 
			set { this.SetValue("RelatePersonSpell", value); } 
		}

		public string RelatePersonContact
		{
			get { return (string)this.GetValue("RelatePersonContact"); } 
			set { this.SetValue("RelatePersonContact", value); } 
		}

		public int TransportStatusID
		{
			get { return (int)this.GetValue("TransportStatusID"); } 
			set { this.SetValue("TransportStatusID", value); } 
		}

		public string TransportStatus
		{
			get { return (string)this.GetValue("TransportStatus"); } 
			set { this.SetValue("TransportStatus", value); } 
		}

		public string TransportType
		{
			get { return (string)this.GetValue("TransportType"); } 
			set { this.SetValue("TransportType", value); } 
		}

		public string TransportStyle
		{
			get { return (string)this.GetValue("TransportStyle"); } 
			set { this.SetValue("TransportStyle", value); } 
		}

		public string ShippingAddress
		{
			get { return (string)this.GetValue("ShippingAddress"); } 
			set { this.SetValue("ShippingAddress", value); } 
		}

		public string CommissionedManagers
		{
			get { return (string)this.GetValue("CommissionedManagers"); } 
			set { this.SetValue("CommissionedManagers", value); } 
		}

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

		public string DeliveryPerson
		{
			get { return (string)this.GetValue("DeliveryPerson"); } 
			set { this.SetValue("DeliveryPerson", value); } 
		}

		public string DeliverySpell
		{
			get { return (string)this.GetValue("DeliverySpell"); } 
			set { this.SetValue("DeliverySpell", value); } 
		}

		public string DeliveryContact
		{
			get { return (string)this.GetValue("DeliveryContact"); } 
			set { this.SetValue("DeliveryContact", value); } 
		}

		public DateTime StartTime
		{
			get { return (DateTime)this.GetValue("StartTime"); } 
			set { this.SetValue("StartTime", value); } 
		}

		public DateTime ArriveTime
		{
			get { return (DateTime)this.GetValue("ArriveTime"); } 
			set { this.SetValue("ArriveTime", value); } 
		}

		public string Duration
		{
			get { return (string)this.GetValue("Duration"); } 
			set { this.SetValue("Duration", value); } 
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

		public string RecordType
		{
			get { return (string)this.GetValue("RecordType"); } 
			set { this.SetValue("RecordType", value); } 
		}

		public double MinTimeLimit
		{
			get { return (double)this.GetValue("MinTimeLimit"); } 
			set { this.SetValue("MinTimeLimit", value); } 
		}

		public bool IsOutLimit
		{
			get { return (bool)this.GetValue("IsOutLimit"); } 
			set { this.SetValue("IsOutLimit", value); } 
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

		public string TransportRemark
		{
			get { return (string)this.GetValue("TransportRemark"); } 
			set { this.SetValue("TransportRemark", value); } 
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

		public BUSTransportRecordEntity()
		{
			this.TableName = "BUS_TransportRecord";
			this.Fields = new Dictionary<string, EntityField>();
			this.Fields.Add("TransportID", BUSTransportRecordEntityFields.TransportID);
			this.Fields.Add("TransportCode", BUSTransportRecordEntityFields.TransportCode);
			this.Fields.Add("BillID", BUSTransportRecordEntityFields.BillID);
			this.Fields.Add("BillCode", BUSTransportRecordEntityFields.BillCode);
			this.Fields.Add("DealerID", BUSTransportRecordEntityFields.DealerID);
			this.Fields.Add("DealerCode", BUSTransportRecordEntityFields.DealerCode);
			this.Fields.Add("RelateCompany", BUSTransportRecordEntityFields.RelateCompany);
			this.Fields.Add("RelateCompanySpell", BUSTransportRecordEntityFields.RelateCompanySpell);
			this.Fields.Add("RelateAddress", BUSTransportRecordEntityFields.RelateAddress);
			this.Fields.Add("RelatePerson", BUSTransportRecordEntityFields.RelatePerson);
			this.Fields.Add("RelatePersonSpell", BUSTransportRecordEntityFields.RelatePersonSpell);
			this.Fields.Add("RelatePersonContact", BUSTransportRecordEntityFields.RelatePersonContact);
			this.Fields.Add("TransportStatusID", BUSTransportRecordEntityFields.TransportStatusID);
			this.Fields.Add("TransportStatus", BUSTransportRecordEntityFields.TransportStatus);
			this.Fields.Add("TransportType", BUSTransportRecordEntityFields.TransportType);
			this.Fields.Add("TransportStyle", BUSTransportRecordEntityFields.TransportStyle);
			this.Fields.Add("ShippingAddress", BUSTransportRecordEntityFields.ShippingAddress);
			this.Fields.Add("CommissionedManagers", BUSTransportRecordEntityFields.CommissionedManagers);
			this.Fields.Add("CarID", BUSTransportRecordEntityFields.CarID);
			this.Fields.Add("CarCode", BUSTransportRecordEntityFields.CarCode);
			this.Fields.Add("DeliveryPerson", BUSTransportRecordEntityFields.DeliveryPerson);
			this.Fields.Add("DeliverySpell", BUSTransportRecordEntityFields.DeliverySpell);
			this.Fields.Add("DeliveryContact", BUSTransportRecordEntityFields.DeliveryContact);
			this.Fields.Add("StartTime", BUSTransportRecordEntityFields.StartTime);
			this.Fields.Add("ArriveTime", BUSTransportRecordEntityFields.ArriveTime);
			this.Fields.Add("Duration", BUSTransportRecordEntityFields.Duration);
			this.Fields.Add("CarryCompnay", BUSTransportRecordEntityFields.CarryCompnay);
			this.Fields.Add("CarryCompnaySpell", BUSTransportRecordEntityFields.CarryCompnaySpell);
			this.Fields.Add("RecordType", BUSTransportRecordEntityFields.RecordType);
			this.Fields.Add("MinTimeLimit", BUSTransportRecordEntityFields.MinTimeLimit);
			this.Fields.Add("IsOutLimit", BUSTransportRecordEntityFields.IsOutLimit);
			this.Fields.Add("CreateUserID", BUSTransportRecordEntityFields.CreateUserID);
			this.Fields.Add("CreateDate", BUSTransportRecordEntityFields.CreateDate);
			this.Fields.Add("LastModifyUserID", BUSTransportRecordEntityFields.LastModifyUserID);
			this.Fields.Add("LastModifyDate", BUSTransportRecordEntityFields.LastModifyDate);
			this.Fields.Add("TransportRemark", BUSTransportRecordEntityFields.TransportRemark);
			this.Fields.Add("Reservation1", BUSTransportRecordEntityFields.Reservation1);
			this.Fields.Add("Reservation2", BUSTransportRecordEntityFields.Reservation2);
			this.Fields.Add("Reservation3", BUSTransportRecordEntityFields.Reservation3);
			this.Fields.Add("Reservation4", BUSTransportRecordEntityFields.Reservation4);
			this.Fields.Add("Reservation5", BUSTransportRecordEntityFields.Reservation5);
			this.Fields.Add("Reservation6", BUSTransportRecordEntityFields.Reservation6);
			this.Fields.Add("Reservation7", BUSTransportRecordEntityFields.Reservation7);
			this.Fields.Add("Reservation8", BUSTransportRecordEntityFields.Reservation8);
			this.Fields.Add("Reservation9", BUSTransportRecordEntityFields.Reservation9);
			this.Fields.Add("Reservation10", BUSTransportRecordEntityFields.Reservation10);
		}
	}

	#region BUSTransportRecordEntityFields

	public class BUSTransportRecordEntityFields
	{
		public static EntityField TransportID
		{
			get { return new EntityField("BUS_TransportRecord", 0, "TransportID", SqlDbType.Int, true, true, true, false); }
		}

		public static EntityField TransportCode
		{
			get { return new EntityField("BUS_TransportRecord", 1, "TransportCode", SqlDbType.NVarChar, false, false, false, false); }
		}

		public static EntityField BillID
		{
			get { return new EntityField("BUS_TransportRecord", 2, "BillID", SqlDbType.Int, false, false, false, true); }
		}

		public static EntityField BillCode
		{
			get { return new EntityField("BUS_TransportRecord", 3, "BillCode", SqlDbType.NVarChar, false, false, false, true); }
		}

		public static EntityField DealerID
		{
			get { return new EntityField("BUS_TransportRecord", 4, "DealerID", SqlDbType.Int, false, false, false, true); }
		}

		public static EntityField DealerCode
		{
			get { return new EntityField("BUS_TransportRecord", 5, "DealerCode", SqlDbType.NVarChar, false, false, false, true); }
		}

		public static EntityField RelateCompany
		{
			get { return new EntityField("BUS_TransportRecord", 6, "RelateCompany", SqlDbType.NVarChar, false, false, false, true); }
		}

		public static EntityField RelateCompanySpell
		{
			get { return new EntityField("BUS_TransportRecord", 7, "RelateCompanySpell", SqlDbType.NVarChar, false, false, false, true); }
		}

		public static EntityField RelateAddress
		{
			get { return new EntityField("BUS_TransportRecord", 8, "RelateAddress", SqlDbType.NVarChar, false, false, false, true); }
		}

		public static EntityField RelatePerson
		{
			get { return new EntityField("BUS_TransportRecord", 9, "RelatePerson", SqlDbType.NVarChar, false, false, false, true); }
		}

		public static EntityField RelatePersonSpell
		{
			get { return new EntityField("BUS_TransportRecord", 10, "RelatePersonSpell", SqlDbType.NVarChar, false, false, false, true); }
		}

		public static EntityField RelatePersonContact
		{
			get { return new EntityField("BUS_TransportRecord", 11, "RelatePersonContact", SqlDbType.NVarChar, false, false, false, true); }
		}

		public static EntityField TransportStatusID
		{
			get { return new EntityField("BUS_TransportRecord", 12, "TransportStatusID", SqlDbType.Int, false, false, false, true); }
		}

		public static EntityField TransportStatus
		{
			get { return new EntityField("BUS_TransportRecord", 13, "TransportStatus", SqlDbType.NVarChar, false, false, false, true); }
		}

		public static EntityField TransportType
		{
			get { return new EntityField("BUS_TransportRecord", 14, "TransportType", SqlDbType.NVarChar, false, false, false, true); }
		}

		public static EntityField TransportStyle
		{
			get { return new EntityField("BUS_TransportRecord", 15, "TransportStyle", SqlDbType.NVarChar, false, false, false, true); }
		}

		public static EntityField ShippingAddress
		{
			get { return new EntityField("BUS_TransportRecord", 16, "ShippingAddress", SqlDbType.NVarChar, false, false, false, true); }
		}

		public static EntityField CommissionedManagers
		{
			get { return new EntityField("BUS_TransportRecord", 17, "CommissionedManagers", SqlDbType.NVarChar, false, false, false, true); }
		}

		public static EntityField CarID
		{
			get { return new EntityField("BUS_TransportRecord", 18, "CarID", SqlDbType.Int, false, false, false, true); }
		}

		public static EntityField CarCode
		{
			get { return new EntityField("BUS_TransportRecord", 19, "CarCode", SqlDbType.NVarChar, false, false, false, true); }
		}

		public static EntityField DeliveryPerson
		{
			get { return new EntityField("BUS_TransportRecord", 20, "DeliveryPerson", SqlDbType.NVarChar, false, false, false, true); }
		}

		public static EntityField DeliverySpell
		{
			get { return new EntityField("BUS_TransportRecord", 21, "DeliverySpell", SqlDbType.NVarChar, false, false, false, true); }
		}

		public static EntityField DeliveryContact
		{
			get { return new EntityField("BUS_TransportRecord", 22, "DeliveryContact", SqlDbType.NVarChar, false, false, false, true); }
		}

		public static EntityField StartTime
		{
			get { return new EntityField("BUS_TransportRecord", 23, "StartTime", SqlDbType.DateTime, false, false, false, true); }
		}

		public static EntityField ArriveTime
		{
			get { return new EntityField("BUS_TransportRecord", 24, "ArriveTime", SqlDbType.DateTime, false, false, false, true); }
		}

		public static EntityField Duration
		{
			get { return new EntityField("BUS_TransportRecord", 25, "Duration", SqlDbType.NVarChar, false, false, false, true); }
		}

		public static EntityField CarryCompnay
		{
			get { return new EntityField("BUS_TransportRecord", 26, "CarryCompnay", SqlDbType.NVarChar, false, false, false, true); }
		}

		public static EntityField CarryCompnaySpell
		{
			get { return new EntityField("BUS_TransportRecord", 27, "CarryCompnaySpell", SqlDbType.NVarChar, false, false, false, true); }
		}

		public static EntityField RecordType
		{
			get { return new EntityField("BUS_TransportRecord", 28, "RecordType", SqlDbType.NVarChar, false, false, false, true); }
		}

		public static EntityField MinTimeLimit
		{
			get { return new EntityField("BUS_TransportRecord", 29, "MinTimeLimit", SqlDbType.Float, false, false, false, true); }
		}

		public static EntityField IsOutLimit
		{
			get { return new EntityField("BUS_TransportRecord", 30, "IsOutLimit", SqlDbType.Bit, false, false, false, true); }
		}

		public static EntityField CreateUserID
		{
			get { return new EntityField("BUS_TransportRecord", 31, "CreateUserID", SqlDbType.UniqueIdentifier, false, false, false, true); }
		}

		public static EntityField CreateDate
		{
			get { return new EntityField("BUS_TransportRecord", 32, "CreateDate", SqlDbType.DateTime, false, false, false, true); }
		}

		public static EntityField LastModifyUserID
		{
			get { return new EntityField("BUS_TransportRecord", 33, "LastModifyUserID", SqlDbType.UniqueIdentifier, false, false, false, true); }
		}

		public static EntityField LastModifyDate
		{
			get { return new EntityField("BUS_TransportRecord", 34, "LastModifyDate", SqlDbType.DateTime, false, false, false, true); }
		}

		public static EntityField TransportRemark
		{
			get { return new EntityField("BUS_TransportRecord", 35, "TransportRemark", SqlDbType.NVarChar, false, false, false, true); }
		}

		public static EntityField Reservation1
		{
			get { return new EntityField("BUS_TransportRecord", 36, "Reservation1", SqlDbType.NVarChar, false, false, false, true); }
		}

		public static EntityField Reservation2
		{
			get { return new EntityField("BUS_TransportRecord", 37, "Reservation2", SqlDbType.NVarChar, false, false, false, true); }
		}

		public static EntityField Reservation3
		{
			get { return new EntityField("BUS_TransportRecord", 38, "Reservation3", SqlDbType.NVarChar, false, false, false, true); }
		}

		public static EntityField Reservation4
		{
			get { return new EntityField("BUS_TransportRecord", 39, "Reservation4", SqlDbType.NVarChar, false, false, false, true); }
		}

		public static EntityField Reservation5
		{
			get { return new EntityField("BUS_TransportRecord", 40, "Reservation5", SqlDbType.NVarChar, false, false, false, true); }
		}

		public static EntityField Reservation6
		{
			get { return new EntityField("BUS_TransportRecord", 41, "Reservation6", SqlDbType.NVarChar, false, false, false, true); }
		}

		public static EntityField Reservation7
		{
			get { return new EntityField("BUS_TransportRecord", 42, "Reservation7", SqlDbType.NVarChar, false, false, false, true); }
		}

		public static EntityField Reservation8
		{
			get { return new EntityField("BUS_TransportRecord", 43, "Reservation8", SqlDbType.NVarChar, false, false, false, true); }
		}

		public static EntityField Reservation9
		{
			get { return new EntityField("BUS_TransportRecord", 44, "Reservation9", SqlDbType.NVarChar, false, false, false, true); }
		}

		public static EntityField Reservation10
		{
			get { return new EntityField("BUS_TransportRecord", 45, "Reservation10", SqlDbType.NVarChar, false, false, false, true); }
		}

	}

	#endregion

	#region BUSTransportRecordEntityFields2

	public enum BUSTransportRecordEntityFields2
	{
		TransportID,

		TransportCode,

		BillID,

		BillCode,

		DealerID,

		DealerCode,

		RelateCompany,

		RelateCompanySpell,

		RelateAddress,

		RelatePerson,

		RelatePersonSpell,

		RelatePersonContact,

		TransportStatusID,

		TransportStatus,

		TransportType,

		TransportStyle,

		ShippingAddress,

		CommissionedManagers,

		CarID,

		CarCode,

		DeliveryPerson,

		DeliverySpell,

		DeliveryContact,

		StartTime,

		ArriveTime,

		Duration,

		CarryCompnay,

		CarryCompnaySpell,

		RecordType,

		MinTimeLimit,

		IsOutLimit,

		CreateUserID,

		CreateDate,

		LastModifyUserID,

		LastModifyDate,

		TransportRemark,

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
