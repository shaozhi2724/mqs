﻿/*
 *	Build By: Codey Object Relation Mapping
 *	Build Data: 2013-10-28 14:15:34
 *	Build Type: Entity
 *	Description: BUSProdcutDestroyDetailEntity
*/

using System;
using System.Collections.Generic;
using System.Data;
using ORMSCore;

namespace DQS.Module.Entities
{
	public class BUSProdcutDestroyDetailEntity : EntityBase
	{
		public int DetailID
		{
			get { return (int)this.GetValue("DetailID"); } 
			set { this.SetValue("DetailID", value); } 
		}

		public int DestroyID
		{
			get { return (int)this.GetValue("DestroyID"); } 
			set { this.SetValue("DestroyID", value); } 
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

		public DateTime ProduceDate
		{
			get { return (DateTime)this.GetValue("ProduceDate"); } 
			set { this.SetValue("ProduceDate", value); } 
		}

		public DateTime ValidateDate
		{
			get { return (DateTime)this.GetValue("ValidateDate"); } 
			set { this.SetValue("ValidateDate", value); } 
		}

		public int Amount
		{
			get { return (int)this.GetValue("Amount"); } 
			set { this.SetValue("Amount", value); } 
		}

		public string DetailCause
		{
			get { return (string)this.GetValue("DetailCause"); } 
			set { this.SetValue("DetailCause", value); } 
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

		public BUSProdcutDestroyDetailEntity()
		{
			this.TableName = "BUS_ProdcutDestroyDetail";
			this.Fields = new Dictionary<string, EntityField>();
			this.Fields.Add("DetailID", BUSProdcutDestroyDetailEntityFields.DetailID);
			this.Fields.Add("DestroyID", BUSProdcutDestroyDetailEntityFields.DestroyID);
			this.Fields.Add("ProductID", BUSProdcutDestroyDetailEntityFields.ProductID);
			this.Fields.Add("BatchNo", BUSProdcutDestroyDetailEntityFields.BatchNo);
			this.Fields.Add("ProduceDate", BUSProdcutDestroyDetailEntityFields.ProduceDate);
			this.Fields.Add("ValidateDate", BUSProdcutDestroyDetailEntityFields.ValidateDate);
			this.Fields.Add("Amount", BUSProdcutDestroyDetailEntityFields.Amount);
			this.Fields.Add("DetailCause", BUSProdcutDestroyDetailEntityFields.DetailCause);
			this.Fields.Add("CreateUserID", BUSProdcutDestroyDetailEntityFields.CreateUserID);
			this.Fields.Add("CreateDate", BUSProdcutDestroyDetailEntityFields.CreateDate);
			this.Fields.Add("LastModifyUserID", BUSProdcutDestroyDetailEntityFields.LastModifyUserID);
			this.Fields.Add("LastModifyDate", BUSProdcutDestroyDetailEntityFields.LastModifyDate);
			this.Fields.Add("DetailRemark", BUSProdcutDestroyDetailEntityFields.DetailRemark);
			this.Fields.Add("Reservation1", BUSProdcutDestroyDetailEntityFields.Reservation1);
			this.Fields.Add("Reservation2", BUSProdcutDestroyDetailEntityFields.Reservation2);
			this.Fields.Add("Reservation3", BUSProdcutDestroyDetailEntityFields.Reservation3);
			this.Fields.Add("Reservation4", BUSProdcutDestroyDetailEntityFields.Reservation4);
			this.Fields.Add("Reservation5", BUSProdcutDestroyDetailEntityFields.Reservation5);
			this.Fields.Add("Reservation6", BUSProdcutDestroyDetailEntityFields.Reservation6);
			this.Fields.Add("Reservation7", BUSProdcutDestroyDetailEntityFields.Reservation7);
			this.Fields.Add("Reservation8", BUSProdcutDestroyDetailEntityFields.Reservation8);
			this.Fields.Add("Reservation9", BUSProdcutDestroyDetailEntityFields.Reservation9);
			this.Fields.Add("Reservation10", BUSProdcutDestroyDetailEntityFields.Reservation10);
		}
	}

	#region BUSProdcutDestroyDetailEntityFields

	public class BUSProdcutDestroyDetailEntityFields
	{
		public static EntityField DetailID
		{
			get { return new EntityField("BUS_ProdcutDestroyDetail", 0, "DetailID", SqlDbType.Int, true, true, true, false); }
		}

		public static EntityField DestroyID
		{
			get { return new EntityField("BUS_ProdcutDestroyDetail", 1, "DestroyID", SqlDbType.Int, false, false, false, true); }
		}

		public static EntityField ProductID
		{
			get { return new EntityField("BUS_ProdcutDestroyDetail", 2, "ProductID", SqlDbType.Int, false, false, false, true); }
		}

		public static EntityField BatchNo
		{
			get { return new EntityField("BUS_ProdcutDestroyDetail", 3, "BatchNo", SqlDbType.NVarChar, false, false, false, true); }
		}

		public static EntityField ProduceDate
		{
			get { return new EntityField("BUS_ProdcutDestroyDetail", 4, "ProduceDate", SqlDbType.DateTime, false, false, false, true); }
		}

		public static EntityField ValidateDate
		{
			get { return new EntityField("BUS_ProdcutDestroyDetail", 5, "ValidateDate", SqlDbType.DateTime, false, false, false, true); }
		}

		public static EntityField Amount
		{
			get { return new EntityField("BUS_ProdcutDestroyDetail", 6, "Amount", SqlDbType.Int, false, false, false, true); }
		}

		public static EntityField DetailCause
		{
			get { return new EntityField("BUS_ProdcutDestroyDetail", 7, "DetailCause", SqlDbType.NVarChar, false, false, false, true); }
		}

		public static EntityField CreateUserID
		{
			get { return new EntityField("BUS_ProdcutDestroyDetail", 8, "CreateUserID", SqlDbType.UniqueIdentifier, false, false, false, true); }
		}

		public static EntityField CreateDate
		{
			get { return new EntityField("BUS_ProdcutDestroyDetail", 9, "CreateDate", SqlDbType.DateTime, false, false, false, true); }
		}

		public static EntityField LastModifyUserID
		{
			get { return new EntityField("BUS_ProdcutDestroyDetail", 10, "LastModifyUserID", SqlDbType.UniqueIdentifier, false, false, false, true); }
		}

		public static EntityField LastModifyDate
		{
			get { return new EntityField("BUS_ProdcutDestroyDetail", 11, "LastModifyDate", SqlDbType.DateTime, false, false, false, true); }
		}

		public static EntityField DetailRemark
		{
			get { return new EntityField("BUS_ProdcutDestroyDetail", 12, "DetailRemark", SqlDbType.VarChar, false, false, false, true); }
		}

		public static EntityField Reservation1
		{
			get { return new EntityField("BUS_ProdcutDestroyDetail", 13, "Reservation1", SqlDbType.NVarChar, false, false, false, true); }
		}

		public static EntityField Reservation2
		{
			get { return new EntityField("BUS_ProdcutDestroyDetail", 14, "Reservation2", SqlDbType.NVarChar, false, false, false, true); }
		}

		public static EntityField Reservation3
		{
			get { return new EntityField("BUS_ProdcutDestroyDetail", 15, "Reservation3", SqlDbType.NVarChar, false, false, false, true); }
		}

		public static EntityField Reservation4
		{
			get { return new EntityField("BUS_ProdcutDestroyDetail", 16, "Reservation4", SqlDbType.NVarChar, false, false, false, true); }
		}

		public static EntityField Reservation5
		{
			get { return new EntityField("BUS_ProdcutDestroyDetail", 17, "Reservation5", SqlDbType.NVarChar, false, false, false, true); }
		}

		public static EntityField Reservation6
		{
			get { return new EntityField("BUS_ProdcutDestroyDetail", 18, "Reservation6", SqlDbType.NVarChar, false, false, false, true); }
		}

		public static EntityField Reservation7
		{
			get { return new EntityField("BUS_ProdcutDestroyDetail", 19, "Reservation7", SqlDbType.NVarChar, false, false, false, true); }
		}

		public static EntityField Reservation8
		{
			get { return new EntityField("BUS_ProdcutDestroyDetail", 20, "Reservation8", SqlDbType.NVarChar, false, false, false, true); }
		}

		public static EntityField Reservation9
		{
			get { return new EntityField("BUS_ProdcutDestroyDetail", 21, "Reservation9", SqlDbType.NVarChar, false, false, false, true); }
		}

		public static EntityField Reservation10
		{
			get { return new EntityField("BUS_ProdcutDestroyDetail", 22, "Reservation10", SqlDbType.NVarChar, false, false, false, true); }
		}

	}

	#endregion

	#region BUSProdcutDestroyDetailEntityFields2

	public enum BUSProdcutDestroyDetailEntityFields2
	{
		DetailID,

		DestroyID,

		ProductID,

		BatchNo,

		ProduceDate,

		ValidateDate,

		Amount,

		DetailCause,

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
