/*
 *	Build By: Codey Object Relation Mapping
 *	Build Data: 2013-10-29 18:01:00
 *	Build Type: Entity
 *	Description: BUSProdcutDestroyEntity
*/

using System;
using System.Collections.Generic;
using System.Data;
using ORMSCore;

namespace DQS.Module.Entities
{
	public class BUSProdcutDestroyEntity : EntityBase
	{
		public int DestroyID
		{
			get { return (int)this.GetValue("DestroyID"); } 
			set { this.SetValue("DestroyID", value); } 
		}

		public string DestroyCode
		{
			get { return (string)this.GetValue("DestroyCode"); } 
			set { this.SetValue("DestroyCode", value); } 
		}

		public string DestroyCause
		{
			get { return (string)this.GetValue("DestroyCause"); } 
			set { this.SetValue("DestroyCause", value); } 
		}

		public string DestroyProcedure
		{
			get { return (string)this.GetValue("DestroyProcedure"); } 
			set { this.SetValue("DestroyProcedure", value); } 
		}

		public string DestroyResult
		{
			get { return (string)this.GetValue("DestroyResult"); } 
			set { this.SetValue("DestroyResult", value); } 
		}

		public DateTime DestroyDate
		{
			get { return (DateTime)this.GetValue("DestroyDate"); } 
			set { this.SetValue("DestroyDate", value); } 
		}

		public int UnqualifiedID
		{
			get { return (int)this.GetValue("UnqualifiedID"); } 
			set { this.SetValue("UnqualifiedID", value); } 
		}

		public string UnqualifiedCode
		{
			get { return (string)this.GetValue("UnqualifiedCode"); } 
			set { this.SetValue("UnqualifiedCode", value); } 
		}

		public string Transactor
		{
			get { return (string)this.GetValue("Transactor"); } 
			set { this.SetValue("Transactor", value); } 
		}

		public string TransactorSpell
		{
			get { return (string)this.GetValue("TransactorSpell"); } 
			set { this.SetValue("TransactorSpell", value); } 
		}

		public int DestroyStatusID
		{
			get { return (int)this.GetValue("DestroyStatusID"); } 
			set { this.SetValue("DestroyStatusID", value); } 
		}

		public string DestroyStatus
		{
			get { return (string)this.GetValue("DestroyStatus"); } 
			set { this.SetValue("DestroyStatus", value); } 
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

		public string DestroyRemark
		{
			get { return (string)this.GetValue("DestroyRemark"); } 
			set { this.SetValue("DestroyRemark", value); } 
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

		public BUSProdcutDestroyEntity()
		{
			this.TableName = "BUS_ProdcutDestroy";
			this.Fields = new Dictionary<string, EntityField>();
			this.Fields.Add("DestroyID", BUSProdcutDestroyEntityFields.DestroyID);
			this.Fields.Add("DestroyCode", BUSProdcutDestroyEntityFields.DestroyCode);
			this.Fields.Add("DestroyCause", BUSProdcutDestroyEntityFields.DestroyCause);
			this.Fields.Add("DestroyProcedure", BUSProdcutDestroyEntityFields.DestroyProcedure);
			this.Fields.Add("DestroyResult", BUSProdcutDestroyEntityFields.DestroyResult);
			this.Fields.Add("DestroyDate", BUSProdcutDestroyEntityFields.DestroyDate);
			this.Fields.Add("UnqualifiedID", BUSProdcutDestroyEntityFields.UnqualifiedID);
			this.Fields.Add("UnqualifiedCode", BUSProdcutDestroyEntityFields.UnqualifiedCode);
			this.Fields.Add("Transactor", BUSProdcutDestroyEntityFields.Transactor);
			this.Fields.Add("TransactorSpell", BUSProdcutDestroyEntityFields.TransactorSpell);
			this.Fields.Add("DestroyStatusID", BUSProdcutDestroyEntityFields.DestroyStatusID);
			this.Fields.Add("DestroyStatus", BUSProdcutDestroyEntityFields.DestroyStatus);
			this.Fields.Add("CreateUserID", BUSProdcutDestroyEntityFields.CreateUserID);
			this.Fields.Add("CreateDate", BUSProdcutDestroyEntityFields.CreateDate);
			this.Fields.Add("LastModifyUserID", BUSProdcutDestroyEntityFields.LastModifyUserID);
			this.Fields.Add("LastModifyDate", BUSProdcutDestroyEntityFields.LastModifyDate);
			this.Fields.Add("DestroyRemark", BUSProdcutDestroyEntityFields.DestroyRemark);
			this.Fields.Add("Reservation1", BUSProdcutDestroyEntityFields.Reservation1);
			this.Fields.Add("Reservation2", BUSProdcutDestroyEntityFields.Reservation2);
			this.Fields.Add("Reservation3", BUSProdcutDestroyEntityFields.Reservation3);
			this.Fields.Add("Reservation4", BUSProdcutDestroyEntityFields.Reservation4);
			this.Fields.Add("Reservation5", BUSProdcutDestroyEntityFields.Reservation5);
			this.Fields.Add("Reservation6", BUSProdcutDestroyEntityFields.Reservation6);
			this.Fields.Add("Reservation7", BUSProdcutDestroyEntityFields.Reservation7);
			this.Fields.Add("Reservation8", BUSProdcutDestroyEntityFields.Reservation8);
			this.Fields.Add("Reservation9", BUSProdcutDestroyEntityFields.Reservation9);
			this.Fields.Add("Reservation10", BUSProdcutDestroyEntityFields.Reservation10);
		}
	}

	#region BUSProdcutDestroyEntityFields

	public class BUSProdcutDestroyEntityFields
	{
		public static EntityField DestroyID
		{
			get { return new EntityField("BUS_ProdcutDestroy", 0, "DestroyID", SqlDbType.Int, true, true, true, false); }
		}

		public static EntityField DestroyCode
		{
			get { return new EntityField("BUS_ProdcutDestroy", 1, "DestroyCode", SqlDbType.NVarChar, false, false, true, false); }
		}

		public static EntityField DestroyCause
		{
			get { return new EntityField("BUS_ProdcutDestroy", 2, "DestroyCause", SqlDbType.NVarChar, false, false, false, true); }
		}

		public static EntityField DestroyProcedure
		{
			get { return new EntityField("BUS_ProdcutDestroy", 3, "DestroyProcedure", SqlDbType.NVarChar, false, false, false, true); }
		}

		public static EntityField DestroyResult
		{
			get { return new EntityField("BUS_ProdcutDestroy", 4, "DestroyResult", SqlDbType.NVarChar, false, false, false, true); }
		}

		public static EntityField DestroyDate
		{
			get { return new EntityField("BUS_ProdcutDestroy", 5, "DestroyDate", SqlDbType.DateTime, false, false, false, true); }
		}

		public static EntityField UnqualifiedID
		{
			get { return new EntityField("BUS_ProdcutDestroy", 6, "UnqualifiedID", SqlDbType.Int, false, false, false, true); }
		}

		public static EntityField UnqualifiedCode
		{
			get { return new EntityField("BUS_ProdcutDestroy", 7, "UnqualifiedCode", SqlDbType.NVarChar, false, false, false, true); }
		}

		public static EntityField Transactor
		{
			get { return new EntityField("BUS_ProdcutDestroy", 8, "Transactor", SqlDbType.NVarChar, false, false, false, true); }
		}

		public static EntityField TransactorSpell
		{
			get { return new EntityField("BUS_ProdcutDestroy", 9, "TransactorSpell", SqlDbType.NVarChar, false, false, false, true); }
		}

		public static EntityField DestroyStatusID
		{
			get { return new EntityField("BUS_ProdcutDestroy", 10, "DestroyStatusID", SqlDbType.Int, false, false, false, true); }
		}

		public static EntityField DestroyStatus
		{
			get { return new EntityField("BUS_ProdcutDestroy", 11, "DestroyStatus", SqlDbType.NVarChar, false, false, false, true); }
		}

		public static EntityField CreateUserID
		{
			get { return new EntityField("BUS_ProdcutDestroy", 12, "CreateUserID", SqlDbType.UniqueIdentifier, false, false, false, true); }
		}

		public static EntityField CreateDate
		{
			get { return new EntityField("BUS_ProdcutDestroy", 13, "CreateDate", SqlDbType.DateTime, false, false, false, true); }
		}

		public static EntityField LastModifyUserID
		{
			get { return new EntityField("BUS_ProdcutDestroy", 14, "LastModifyUserID", SqlDbType.UniqueIdentifier, false, false, false, true); }
		}

		public static EntityField LastModifyDate
		{
			get { return new EntityField("BUS_ProdcutDestroy", 15, "LastModifyDate", SqlDbType.DateTime, false, false, false, true); }
		}

		public static EntityField DestroyRemark
		{
			get { return new EntityField("BUS_ProdcutDestroy", 16, "DestroyRemark", SqlDbType.NVarChar, false, false, false, true); }
		}

		public static EntityField Reservation1
		{
			get { return new EntityField("BUS_ProdcutDestroy", 17, "Reservation1", SqlDbType.NVarChar, false, false, false, true); }
		}

		public static EntityField Reservation2
		{
			get { return new EntityField("BUS_ProdcutDestroy", 18, "Reservation2", SqlDbType.NVarChar, false, false, false, true); }
		}

		public static EntityField Reservation3
		{
			get { return new EntityField("BUS_ProdcutDestroy", 19, "Reservation3", SqlDbType.NVarChar, false, false, false, true); }
		}

		public static EntityField Reservation4
		{
			get { return new EntityField("BUS_ProdcutDestroy", 20, "Reservation4", SqlDbType.NVarChar, false, false, false, true); }
		}

		public static EntityField Reservation5
		{
			get { return new EntityField("BUS_ProdcutDestroy", 21, "Reservation5", SqlDbType.NVarChar, false, false, false, true); }
		}

		public static EntityField Reservation6
		{
			get { return new EntityField("BUS_ProdcutDestroy", 22, "Reservation6", SqlDbType.NVarChar, false, false, false, true); }
		}

		public static EntityField Reservation7
		{
			get { return new EntityField("BUS_ProdcutDestroy", 23, "Reservation7", SqlDbType.NVarChar, false, false, false, true); }
		}

		public static EntityField Reservation8
		{
			get { return new EntityField("BUS_ProdcutDestroy", 24, "Reservation8", SqlDbType.NVarChar, false, false, false, true); }
		}

		public static EntityField Reservation9
		{
			get { return new EntityField("BUS_ProdcutDestroy", 25, "Reservation9", SqlDbType.NVarChar, false, false, false, true); }
		}

		public static EntityField Reservation10
		{
			get { return new EntityField("BUS_ProdcutDestroy", 26, "Reservation10", SqlDbType.NVarChar, false, false, false, true); }
		}

	}

	#endregion

	#region BUSProdcutDestroyEntityFields2

	public enum BUSProdcutDestroyEntityFields2
	{
		DestroyID,

		DestroyCode,

		DestroyCause,

		DestroyProcedure,

		DestroyResult,

		DestroyDate,

		UnqualifiedID,

		UnqualifiedCode,

		Transactor,

		TransactorSpell,

		DestroyStatusID,

		DestroyStatus,

		CreateUserID,

		CreateDate,

		LastModifyUserID,

		LastModifyDate,

		DestroyRemark,

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
