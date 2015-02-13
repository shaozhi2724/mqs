/*
 *	Build By: Codey Object Relation Mapping
 *	Build Data: 2013-08-30 21:17:11
 *	Build Type: Entity
 *	Description: BFIProductStructureEntity
*/

using System;
using System.Collections.Generic;
using System.Data;
using ORMSCore;

namespace DQS.Module.Entities
{
	public class BFIProductStructureEntity : EntityBase
	{
		public int ProductID
		{
			get { return (int)this.GetValue("ProductID"); } 
			set { this.SetValue("ProductID", value); } 
		}

		public string ProductBarCode
		{
			get { return (string)this.GetValue("ProductBarCode"); } 
			set { this.SetValue("ProductBarCode", value); } 
		}

		public int StructureID
		{
			get { return (int)this.GetValue("StructureID"); } 
			set { this.SetValue("StructureID", value); } 
		}

		public string StructureBarCode
		{
			get { return (string)this.GetValue("StructureBarCode"); } 
			set { this.SetValue("StructureBarCode", value); } 
		}

		public bool IsMultiBatch
		{
			get { return (bool)this.GetValue("IsMultiBatch"); } 
			set { this.SetValue("IsMultiBatch", value); } 
		}

		public string BatchNo
		{
			get { return (string)this.GetValue("BatchNo"); } 
			set { this.SetValue("BatchNo", value); } 
		}

		public int MaxAmount
		{
			get { return (int)this.GetValue("MaxAmount"); } 
			set { this.SetValue("MaxAmount", value); } 
		}

		public int MinAmount
		{
			get { return (int)this.GetValue("MinAmount"); } 
			set { this.SetValue("MinAmount", value); } 
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

		public BFIProductStructureEntity()
		{
			this.TableName = "BFI_ProductStructure";
			this.Fields = new Dictionary<string, EntityField>();
			this.Fields.Add("ProductID", BFIProductStructureEntityFields.ProductID);
			this.Fields.Add("ProductBarCode", BFIProductStructureEntityFields.ProductBarCode);
			this.Fields.Add("StructureID", BFIProductStructureEntityFields.StructureID);
			this.Fields.Add("StructureBarCode", BFIProductStructureEntityFields.StructureBarCode);
			this.Fields.Add("IsMultiBatch", BFIProductStructureEntityFields.IsMultiBatch);
			this.Fields.Add("BatchNo", BFIProductStructureEntityFields.BatchNo);
			this.Fields.Add("MaxAmount", BFIProductStructureEntityFields.MaxAmount);
			this.Fields.Add("MinAmount", BFIProductStructureEntityFields.MinAmount);
			this.Fields.Add("CreateUserID", BFIProductStructureEntityFields.CreateUserID);
			this.Fields.Add("CreateDate", BFIProductStructureEntityFields.CreateDate);
			this.Fields.Add("Reservation1", BFIProductStructureEntityFields.Reservation1);
			this.Fields.Add("Reservation2", BFIProductStructureEntityFields.Reservation2);
			this.Fields.Add("Reservation3", BFIProductStructureEntityFields.Reservation3);
			this.Fields.Add("Reservation4", BFIProductStructureEntityFields.Reservation4);
			this.Fields.Add("Reservation5", BFIProductStructureEntityFields.Reservation5);
		}
	}

	#region BFIProductStructureEntityFields

	public class BFIProductStructureEntityFields
	{
		public static EntityField ProductID
		{
			get { return new EntityField("BFI_ProductStructure", 0, "ProductID", SqlDbType.Int, true, false, true, false); }
		}

		public static EntityField ProductBarCode
		{
			get { return new EntityField("BFI_ProductStructure", 1, "ProductBarCode", SqlDbType.NVarChar, false, false, false, true); }
		}

		public static EntityField StructureID
		{
			get { return new EntityField("BFI_ProductStructure", 2, "StructureID", SqlDbType.Int, true, false, true, false); }
		}

		public static EntityField StructureBarCode
		{
			get { return new EntityField("BFI_ProductStructure", 3, "StructureBarCode", SqlDbType.NVarChar, false, false, false, true); }
		}

		public static EntityField IsMultiBatch
		{
			get { return new EntityField("BFI_ProductStructure", 4, "IsMultiBatch", SqlDbType.Bit, false, false, false, true); }
		}

		public static EntityField BatchNo
		{
			get { return new EntityField("BFI_ProductStructure", 5, "BatchNo", SqlDbType.NVarChar, false, false, false, true); }
		}

		public static EntityField MaxAmount
		{
			get { return new EntityField("BFI_ProductStructure", 6, "MaxAmount", SqlDbType.Int, false, false, false, true); }
		}

		public static EntityField MinAmount
		{
			get { return new EntityField("BFI_ProductStructure", 7, "MinAmount", SqlDbType.Int, false, false, false, true); }
		}

		public static EntityField CreateUserID
		{
			get { return new EntityField("BFI_ProductStructure", 8, "CreateUserID", SqlDbType.UniqueIdentifier, false, false, false, true); }
		}

		public static EntityField CreateDate
		{
			get { return new EntityField("BFI_ProductStructure", 9, "CreateDate", SqlDbType.DateTime, false, false, false, true); }
		}

		public static EntityField Reservation1
		{
			get { return new EntityField("BFI_ProductStructure", 10, "Reservation1", SqlDbType.NVarChar, false, false, false, true); }
		}

		public static EntityField Reservation2
		{
			get { return new EntityField("BFI_ProductStructure", 11, "Reservation2", SqlDbType.NVarChar, false, false, false, true); }
		}

		public static EntityField Reservation3
		{
			get { return new EntityField("BFI_ProductStructure", 12, "Reservation3", SqlDbType.NVarChar, false, false, false, true); }
		}

		public static EntityField Reservation4
		{
			get { return new EntityField("BFI_ProductStructure", 13, "Reservation4", SqlDbType.NVarChar, false, false, false, true); }
		}

		public static EntityField Reservation5
		{
			get { return new EntityField("BFI_ProductStructure", 14, "Reservation5", SqlDbType.NVarChar, false, false, false, true); }
		}

	}

	#endregion

	#region BFIProductStructureEntityFields2

	public enum BFIProductStructureEntityFields2
	{
		ProductID,

		ProductBarCode,

		StructureID,

		StructureBarCode,

		IsMultiBatch,

		BatchNo,

		MaxAmount,

		MinAmount,

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
