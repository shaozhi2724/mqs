/*
 *	Build By: Codey Object Relation Mapping
 *	Build Data: 2013-09-22 17:27:36
 *	Build Type: Entity
 *	Description: BUSAcceptEntity
*/

using System;
using System.Collections.Generic;
using System.Data;
using ORMSCore;

namespace DQS.Module.Entities
{
	public class BUSAcceptEntity : EntityBase
	{
		public int AcceptID
		{
			get { return (int)this.GetValue("AcceptID"); } 
			set { this.SetValue("AcceptID", value); } 
		}

		public string AcceptCode
		{
			get { return (string)this.GetValue("AcceptCode"); } 
			set { this.SetValue("AcceptCode", value); } 
		}

		public DateTime AcceptDate
		{
			get { return (DateTime)this.GetValue("AcceptDate"); } 
			set { this.SetValue("AcceptDate", value); } 
		}

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

		public string AcceptPerson
		{
			get { return (string)this.GetValue("AcceptPerson"); } 
			set { this.SetValue("AcceptPerson", value); } 
		}

		public string AcceptPersonSpell
		{
			get { return (string)this.GetValue("AcceptPersonSpell"); } 
			set { this.SetValue("AcceptPersonSpell", value); } 
		}

		public string AcceptSolution
		{
			get { return (string)this.GetValue("AcceptSolution"); } 
			set { this.SetValue("AcceptSolution", value); } 
		}

		public string AcceptResult
		{
			get { return (string)this.GetValue("AcceptResult"); } 
			set { this.SetValue("AcceptResult", value); } 
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

		public string AcceptRemark
		{
			get { return (string)this.GetValue("AcceptRemark"); } 
			set { this.SetValue("AcceptRemark", value); } 
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

		public BUSAcceptEntity()
		{
			this.TableName = "BUS_Accept";
			this.Fields = new Dictionary<string, EntityField>();
			this.Fields.Add("AcceptID", BUSAcceptEntityFields.AcceptID);
			this.Fields.Add("AcceptCode", BUSAcceptEntityFields.AcceptCode);
			this.Fields.Add("AcceptDate", BUSAcceptEntityFields.AcceptDate);
			this.Fields.Add("ReceiveID", BUSAcceptEntityFields.ReceiveID);
			this.Fields.Add("ReceiveCode", BUSAcceptEntityFields.ReceiveCode);
			this.Fields.Add("BillID", BUSAcceptEntityFields.BillID);
			this.Fields.Add("BillCode", BUSAcceptEntityFields.BillCode);
			this.Fields.Add("BillDate", BUSAcceptEntityFields.BillDate);
			this.Fields.Add("BillTypeID", BUSAcceptEntityFields.BillTypeID);
			this.Fields.Add("BillTypeName", BUSAcceptEntityFields.BillTypeName);
			this.Fields.Add("BillTypeSpell", BUSAcceptEntityFields.BillTypeSpell);
			this.Fields.Add("DealerID", BUSAcceptEntityFields.DealerID);
			this.Fields.Add("DealerCode", BUSAcceptEntityFields.DealerCode);
			this.Fields.Add("DealerName", BUSAcceptEntityFields.DealerName);
			this.Fields.Add("DealerSpell", BUSAcceptEntityFields.DealerSpell);
			this.Fields.Add("AcceptPerson", BUSAcceptEntityFields.AcceptPerson);
			this.Fields.Add("AcceptPersonSpell", BUSAcceptEntityFields.AcceptPersonSpell);
			this.Fields.Add("AcceptSolution", BUSAcceptEntityFields.AcceptSolution);
			this.Fields.Add("AcceptResult", BUSAcceptEntityFields.AcceptResult);
			this.Fields.Add("CreateUserID", BUSAcceptEntityFields.CreateUserID);
			this.Fields.Add("CreateDate", BUSAcceptEntityFields.CreateDate);
			this.Fields.Add("LastModifyUserID", BUSAcceptEntityFields.LastModifyUserID);
			this.Fields.Add("LastModifyDate", BUSAcceptEntityFields.LastModifyDate);
			this.Fields.Add("AcceptRemark", BUSAcceptEntityFields.AcceptRemark);
			this.Fields.Add("Reservation1", BUSAcceptEntityFields.Reservation1);
			this.Fields.Add("Reservation2", BUSAcceptEntityFields.Reservation2);
			this.Fields.Add("Reservation3", BUSAcceptEntityFields.Reservation3);
			this.Fields.Add("Reservation4", BUSAcceptEntityFields.Reservation4);
			this.Fields.Add("Reservation5", BUSAcceptEntityFields.Reservation5);
			this.Fields.Add("Reservation6", BUSAcceptEntityFields.Reservation6);
			this.Fields.Add("Reservation7", BUSAcceptEntityFields.Reservation7);
			this.Fields.Add("Reservation8", BUSAcceptEntityFields.Reservation8);
			this.Fields.Add("Reservation9", BUSAcceptEntityFields.Reservation9);
			this.Fields.Add("Reservation10", BUSAcceptEntityFields.Reservation10);
		}
	}

	#region BUSAcceptEntityFields

	public class BUSAcceptEntityFields
	{
		public static EntityField AcceptID
		{
			get { return new EntityField("BUS_Accept", 0, "AcceptID", SqlDbType.Int, true, true, true, false); }
		}

		public static EntityField AcceptCode
		{
			get { return new EntityField("BUS_Accept", 1, "AcceptCode", SqlDbType.NVarChar, false, false, true, false); }
		}

		public static EntityField AcceptDate
		{
			get { return new EntityField("BUS_Accept", 2, "AcceptDate", SqlDbType.DateTime, false, false, false, true); }
		}

		public static EntityField ReceiveID
		{
			get { return new EntityField("BUS_Accept", 3, "ReceiveID", SqlDbType.Int, false, false, false, true); }
		}

		public static EntityField ReceiveCode
		{
			get { return new EntityField("BUS_Accept", 4, "ReceiveCode", SqlDbType.NVarChar, false, false, false, true); }
		}

		public static EntityField BillID
		{
			get { return new EntityField("BUS_Accept", 5, "BillID", SqlDbType.Int, false, false, false, true); }
		}

		public static EntityField BillCode
		{
			get { return new EntityField("BUS_Accept", 6, "BillCode", SqlDbType.NVarChar, false, false, false, true); }
		}

		public static EntityField BillDate
		{
			get { return new EntityField("BUS_Accept", 7, "BillDate", SqlDbType.DateTime, false, false, false, true); }
		}

		public static EntityField BillTypeID
		{
			get { return new EntityField("BUS_Accept", 8, "BillTypeID", SqlDbType.Int, false, false, false, true); }
		}

		public static EntityField BillTypeName
		{
			get { return new EntityField("BUS_Accept", 9, "BillTypeName", SqlDbType.NVarChar, false, false, false, true); }
		}

		public static EntityField BillTypeSpell
		{
			get { return new EntityField("BUS_Accept", 10, "BillTypeSpell", SqlDbType.NVarChar, false, false, false, true); }
		}

		public static EntityField DealerID
		{
			get { return new EntityField("BUS_Accept", 11, "DealerID", SqlDbType.Int, false, false, false, true); }
		}

		public static EntityField DealerCode
		{
			get { return new EntityField("BUS_Accept", 12, "DealerCode", SqlDbType.NVarChar, false, false, false, true); }
		}

		public static EntityField DealerName
		{
			get { return new EntityField("BUS_Accept", 13, "DealerName", SqlDbType.NVarChar, false, false, false, true); }
		}

		public static EntityField DealerSpell
		{
			get { return new EntityField("BUS_Accept", 14, "DealerSpell", SqlDbType.NVarChar, false, false, false, true); }
		}

		public static EntityField AcceptPerson
		{
			get { return new EntityField("BUS_Accept", 15, "AcceptPerson", SqlDbType.NVarChar, false, false, false, true); }
		}

		public static EntityField AcceptPersonSpell
		{
			get { return new EntityField("BUS_Accept", 16, "AcceptPersonSpell", SqlDbType.NVarChar, false, false, false, true); }
		}

		public static EntityField AcceptSolution
		{
			get { return new EntityField("BUS_Accept", 17, "AcceptSolution", SqlDbType.NVarChar, false, false, false, true); }
		}

		public static EntityField AcceptResult
		{
			get { return new EntityField("BUS_Accept", 18, "AcceptResult", SqlDbType.NVarChar, false, false, false, true); }
		}

		public static EntityField CreateUserID
		{
			get { return new EntityField("BUS_Accept", 19, "CreateUserID", SqlDbType.UniqueIdentifier, false, false, false, true); }
		}

		public static EntityField CreateDate
		{
			get { return new EntityField("BUS_Accept", 20, "CreateDate", SqlDbType.DateTime, false, false, false, true); }
		}

		public static EntityField LastModifyUserID
		{
			get { return new EntityField("BUS_Accept", 21, "LastModifyUserID", SqlDbType.UniqueIdentifier, false, false, false, true); }
		}

		public static EntityField LastModifyDate
		{
			get { return new EntityField("BUS_Accept", 22, "LastModifyDate", SqlDbType.DateTime, false, false, false, true); }
		}

		public static EntityField AcceptRemark
		{
			get { return new EntityField("BUS_Accept", 23, "AcceptRemark", SqlDbType.NVarChar, false, false, false, true); }
		}

		public static EntityField Reservation1
		{
			get { return new EntityField("BUS_Accept", 24, "Reservation1", SqlDbType.NVarChar, false, false, false, true); }
		}

		public static EntityField Reservation2
		{
			get { return new EntityField("BUS_Accept", 25, "Reservation2", SqlDbType.NVarChar, false, false, false, true); }
		}

		public static EntityField Reservation3
		{
			get { return new EntityField("BUS_Accept", 26, "Reservation3", SqlDbType.NVarChar, false, false, false, true); }
		}

		public static EntityField Reservation4
		{
			get { return new EntityField("BUS_Accept", 27, "Reservation4", SqlDbType.NVarChar, false, false, false, true); }
		}

		public static EntityField Reservation5
		{
			get { return new EntityField("BUS_Accept", 28, "Reservation5", SqlDbType.NVarChar, false, false, false, true); }
		}

		public static EntityField Reservation6
		{
			get { return new EntityField("BUS_Accept", 29, "Reservation6", SqlDbType.NVarChar, false, false, false, true); }
		}

		public static EntityField Reservation7
		{
			get { return new EntityField("BUS_Accept", 30, "Reservation7", SqlDbType.NVarChar, false, false, false, true); }
		}

		public static EntityField Reservation8
		{
			get { return new EntityField("BUS_Accept", 31, "Reservation8", SqlDbType.NVarChar, false, false, false, true); }
		}

		public static EntityField Reservation9
		{
			get { return new EntityField("BUS_Accept", 32, "Reservation9", SqlDbType.NVarChar, false, false, false, true); }
		}

		public static EntityField Reservation10
		{
			get { return new EntityField("BUS_Accept", 33, "Reservation10", SqlDbType.NVarChar, false, false, false, true); }
		}

	}

	#endregion

	#region BUSAcceptEntityFields2

	public enum BUSAcceptEntityFields2
	{
		AcceptID,

		AcceptCode,

		AcceptDate,

		ReceiveID,

		ReceiveCode,

		BillID,

		BillCode,

		BillDate,

		BillTypeID,

		BillTypeName,

		BillTypeSpell,

		DealerID,

		DealerCode,

		DealerName,

		DealerSpell,

		AcceptPerson,

		AcceptPersonSpell,

		AcceptSolution,

		AcceptResult,

		CreateUserID,

		CreateDate,

		LastModifyUserID,

		LastModifyDate,

		AcceptRemark,

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
