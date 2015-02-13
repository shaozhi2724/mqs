/*
 *	Build By: Codey Object Relation Mapping
 *	Build Data: 2013-07-19 19:48:09
 *	Build Type: Entity
 *	Description: BUSTransportDetailEntity
*/

using System;
using System.Collections.Generic;
using System.Data;
using ORMSCore;

namespace DQS.Module.Entities
{
	public class BUSTransportDetailEntity : EntityBase
	{
		public int DetailID
		{
			get { return (int)this.GetValue("DetailID"); } 
			set { this.SetValue("DetailID", value); } 
		}

		public int TransportID
		{
			get { return (int)this.GetValue("TransportID"); } 
			set { this.SetValue("TransportID", value); } 
		}

		public string RelateBillNo
		{
			get { return (string)this.GetValue("RelateBillNo"); } 
			set { this.SetValue("RelateBillNo", value); } 
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

		public string DetailRemark
		{
			get { return (string)this.GetValue("DetailRemark"); } 
			set { this.SetValue("DetailRemark", value); } 
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

		public BUSTransportDetailEntity()
		{
			this.TableName = "BUS_TransportDetail";
			this.Fields = new Dictionary<string, EntityField>();
			this.Fields.Add("DetailID", BUSTransportDetailEntityFields.DetailID);
			this.Fields.Add("TransportID", BUSTransportDetailEntityFields.TransportID);
			this.Fields.Add("RelateBillNo", BUSTransportDetailEntityFields.RelateBillNo);
			this.Fields.Add("ProductID", BUSTransportDetailEntityFields.ProductID);
			this.Fields.Add("BatchNo", BUSTransportDetailEntityFields.BatchNo);
			this.Fields.Add("Amount", BUSTransportDetailEntityFields.Amount);
			this.Fields.Add("CreateUserID", BUSTransportDetailEntityFields.CreateUserID);
			this.Fields.Add("CreateDate", BUSTransportDetailEntityFields.CreateDate);
			this.Fields.Add("LastModifyUserID", BUSTransportDetailEntityFields.LastModifyUserID);
			this.Fields.Add("LastModifyDate", BUSTransportDetailEntityFields.LastModifyDate);
			this.Fields.Add("DetailRemark", BUSTransportDetailEntityFields.DetailRemark);
			this.Fields.Add("Reservation1", BUSTransportDetailEntityFields.Reservation1);
			this.Fields.Add("Reservation2", BUSTransportDetailEntityFields.Reservation2);
			this.Fields.Add("Reservation3", BUSTransportDetailEntityFields.Reservation3);
			this.Fields.Add("Reservation4", BUSTransportDetailEntityFields.Reservation4);
			this.Fields.Add("Reservation5", BUSTransportDetailEntityFields.Reservation5);
			this.Fields.Add("Reservation6", BUSTransportDetailEntityFields.Reservation6);
			this.Fields.Add("Reservation7", BUSTransportDetailEntityFields.Reservation7);
			this.Fields.Add("Reservation8", BUSTransportDetailEntityFields.Reservation8);
			this.Fields.Add("Reservation9", BUSTransportDetailEntityFields.Reservation9);
			this.Fields.Add("Reservation10", BUSTransportDetailEntityFields.Reservation10);
		}
	}

	#region BUSTransportDetailEntityFields

	public class BUSTransportDetailEntityFields
	{
		public static EntityField DetailID
		{
			get { return new EntityField("BUS_TransportDetail", 0, "DetailID", SqlDbType.Int, true, true, true, false); }
		}

		public static EntityField TransportID
		{
			get { return new EntityField("BUS_TransportDetail", 1, "TransportID", SqlDbType.Int, false, false, false, false); }
		}

		public static EntityField RelateBillNo
		{
			get { return new EntityField("BUS_TransportDetail", 2, "RelateBillNo", SqlDbType.NVarChar, false, false, false, true); }
		}

		public static EntityField ProductID
		{
			get { return new EntityField("BUS_TransportDetail", 3, "ProductID", SqlDbType.Int, false, false, false, false); }
		}

		public static EntityField BatchNo
		{
			get { return new EntityField("BUS_TransportDetail", 4, "BatchNo", SqlDbType.NVarChar, false, false, false, true); }
		}

		public static EntityField Amount
		{
			get { return new EntityField("BUS_TransportDetail", 5, "Amount", SqlDbType.Int, false, false, false, true); }
		}

		public static EntityField CreateUserID
		{
			get { return new EntityField("BUS_TransportDetail", 6, "CreateUserID", SqlDbType.UniqueIdentifier, false, false, false, true); }
		}

		public static EntityField CreateDate
		{
			get { return new EntityField("BUS_TransportDetail", 7, "CreateDate", SqlDbType.DateTime, false, false, false, true); }
		}

		public static EntityField LastModifyUserID
		{
			get { return new EntityField("BUS_TransportDetail", 8, "LastModifyUserID", SqlDbType.UniqueIdentifier, false, false, false, true); }
		}

		public static EntityField LastModifyDate
		{
			get { return new EntityField("BUS_TransportDetail", 9, "LastModifyDate", SqlDbType.DateTime, false, false, false, true); }
		}

		public static EntityField DetailRemark
		{
			get { return new EntityField("BUS_TransportDetail", 10, "DetailRemark", SqlDbType.NVarChar, false, false, false, true); }
		}

		public static EntityField Reservation1
		{
			get { return new EntityField("BUS_TransportDetail", 11, "Reservation1", SqlDbType.NVarChar, false, false, false, true); }
		}

		public static EntityField Reservation2
		{
			get { return new EntityField("BUS_TransportDetail", 12, "Reservation2", SqlDbType.NVarChar, false, false, false, true); }
		}

		public static EntityField Reservation3
		{
			get { return new EntityField("BUS_TransportDetail", 13, "Reservation3", SqlDbType.NVarChar, false, false, false, true); }
		}

		public static EntityField Reservation4
		{
			get { return new EntityField("BUS_TransportDetail", 14, "Reservation4", SqlDbType.NVarChar, false, false, false, true); }
		}

		public static EntityField Reservation5
		{
			get { return new EntityField("BUS_TransportDetail", 15, "Reservation5", SqlDbType.NVarChar, false, false, false, true); }
		}

		public static EntityField Reservation6
		{
			get { return new EntityField("BUS_TransportDetail", 16, "Reservation6", SqlDbType.NVarChar, false, false, false, true); }
		}

		public static EntityField Reservation7
		{
			get { return new EntityField("BUS_TransportDetail", 17, "Reservation7", SqlDbType.NVarChar, false, false, false, true); }
		}

		public static EntityField Reservation8
		{
			get { return new EntityField("BUS_TransportDetail", 18, "Reservation8", SqlDbType.NVarChar, false, false, false, true); }
		}

		public static EntityField Reservation9
		{
			get { return new EntityField("BUS_TransportDetail", 19, "Reservation9", SqlDbType.NVarChar, false, false, false, true); }
		}

		public static EntityField Reservation10
		{
			get { return new EntityField("BUS_TransportDetail", 20, "Reservation10", SqlDbType.NVarChar, false, false, false, true); }
		}

	}

	#endregion

	#region BUSTransportDetailEntityFields2

	public enum BUSTransportDetailEntityFields2
	{
		DetailID,

		TransportID,

		RelateBillNo,

		ProductID,

		BatchNo,

		Amount,

		CreateUserID,

		CreateDate,

		LastModifyUserID,

		LastModifyDate,

		DetailRemark,

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
