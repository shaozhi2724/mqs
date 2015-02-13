/*
 *	Build By: Codey Object Relation Mapping
 *	Build Data: 2013-08-29 12:53:12
 *	Build Type: Entity
 *	Description: BFIBusinessRangeEntity
*/

using System;
using System.Collections.Generic;
using System.Data;
using ORMSCore;

namespace DQS.Module.Entities
{
	public class BFIBusinessRangeEntity : EntityBase
	{
		public int RangeID
		{
			get { return (int)this.GetValue("RangeID"); } 
			set { this.SetValue("RangeID", value); } 
		}

		public int EnterpriseID
		{
			get { return (int)this.GetValue("EnterpriseID"); } 
			set { this.SetValue("EnterpriseID", value); } 
		}

		public int DealerID
		{
			get { return (int)this.GetValue("DealerID"); } 
			set { this.SetValue("DealerID", value); } 
		}

		public int ProductStyleID
		{
			get { return (int)this.GetValue("ProductStyleID"); } 
			set { this.SetValue("ProductStyleID", value); } 
		}

		public string ProductStyleName
		{
			get { return (string)this.GetValue("ProductStyleName"); } 
			set { this.SetValue("ProductStyleName", value); } 
		}

		public int RangeStyle
		{
			get { return (int)this.GetValue("RangeStyle"); } 
			set { this.SetValue("RangeStyle", value); } 
		}

		public string RangeStyleName
		{
			get { return (string)this.GetValue("RangeStyleName"); } 
			set { this.SetValue("RangeStyleName", value); } 
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

		public string RangeRemark
		{
			get { return (string)this.GetValue("RangeRemark"); } 
			set { this.SetValue("RangeRemark", value); } 
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

		public BFIBusinessRangeEntity()
		{
			this.TableName = "BFI_BusinessRange";
			this.Fields = new Dictionary<string, EntityField>();
			this.Fields.Add("RangeID", BFIBusinessRangeEntityFields.RangeID);
			this.Fields.Add("EnterpriseID", BFIBusinessRangeEntityFields.EnterpriseID);
			this.Fields.Add("DealerID", BFIBusinessRangeEntityFields.DealerID);
			this.Fields.Add("ProductStyleID", BFIBusinessRangeEntityFields.ProductStyleID);
			this.Fields.Add("ProductStyleName", BFIBusinessRangeEntityFields.ProductStyleName);
			this.Fields.Add("RangeStyle", BFIBusinessRangeEntityFields.RangeStyle);
			this.Fields.Add("RangeStyleName", BFIBusinessRangeEntityFields.RangeStyleName);
			this.Fields.Add("CreateUserID", BFIBusinessRangeEntityFields.CreateUserID);
			this.Fields.Add("CreateDate", BFIBusinessRangeEntityFields.CreateDate);
			this.Fields.Add("LastModifyUserID", BFIBusinessRangeEntityFields.LastModifyUserID);
			this.Fields.Add("LastModifyDate", BFIBusinessRangeEntityFields.LastModifyDate);
			this.Fields.Add("RangeRemark", BFIBusinessRangeEntityFields.RangeRemark);
			this.Fields.Add("Reservation1", BFIBusinessRangeEntityFields.Reservation1);
			this.Fields.Add("Reservation2", BFIBusinessRangeEntityFields.Reservation2);
			this.Fields.Add("Reservation3", BFIBusinessRangeEntityFields.Reservation3);
			this.Fields.Add("Reservation4", BFIBusinessRangeEntityFields.Reservation4);
			this.Fields.Add("Reservation5", BFIBusinessRangeEntityFields.Reservation5);
			this.Fields.Add("Reservation6", BFIBusinessRangeEntityFields.Reservation6);
			this.Fields.Add("Reservation7", BFIBusinessRangeEntityFields.Reservation7);
			this.Fields.Add("Reservation8", BFIBusinessRangeEntityFields.Reservation8);
			this.Fields.Add("Reservation9", BFIBusinessRangeEntityFields.Reservation9);
			this.Fields.Add("Reservation10", BFIBusinessRangeEntityFields.Reservation10);
		}
	}

	#region BFIBusinessRangeEntityFields

	public class BFIBusinessRangeEntityFields
	{
		public static EntityField RangeID
		{
			get { return new EntityField("BFI_BusinessRange", 0, "RangeID", SqlDbType.Int, true, true, true, false); }
		}

		public static EntityField EnterpriseID
		{
			get { return new EntityField("BFI_BusinessRange", 1, "EnterpriseID", SqlDbType.Int, false, false, false, true); }
		}

		public static EntityField DealerID
		{
			get { return new EntityField("BFI_BusinessRange", 2, "DealerID", SqlDbType.Int, false, false, false, true); }
		}

		public static EntityField ProductStyleID
		{
			get { return new EntityField("BFI_BusinessRange", 3, "ProductStyleID", SqlDbType.Int, false, false, false, true); }
		}

		public static EntityField ProductStyleName
		{
			get { return new EntityField("BFI_BusinessRange", 4, "ProductStyleName", SqlDbType.NVarChar, false, false, false, true); }
		}

		public static EntityField RangeStyle
		{
			get { return new EntityField("BFI_BusinessRange", 5, "RangeStyle", SqlDbType.Int, false, false, false, true); }
		}

		public static EntityField RangeStyleName
		{
			get { return new EntityField("BFI_BusinessRange", 6, "RangeStyleName", SqlDbType.NVarChar, false, false, false, true); }
		}

		public static EntityField CreateUserID
		{
			get { return new EntityField("BFI_BusinessRange", 7, "CreateUserID", SqlDbType.UniqueIdentifier, false, false, false, true); }
		}

		public static EntityField CreateDate
		{
			get { return new EntityField("BFI_BusinessRange", 8, "CreateDate", SqlDbType.DateTime, false, false, false, true); }
		}

		public static EntityField LastModifyUserID
		{
			get { return new EntityField("BFI_BusinessRange", 9, "LastModifyUserID", SqlDbType.UniqueIdentifier, false, false, false, true); }
		}

		public static EntityField LastModifyDate
		{
			get { return new EntityField("BFI_BusinessRange", 10, "LastModifyDate", SqlDbType.DateTime, false, false, false, true); }
		}

		public static EntityField RangeRemark
		{
			get { return new EntityField("BFI_BusinessRange", 11, "RangeRemark", SqlDbType.NVarChar, false, false, false, true); }
		}

		public static EntityField Reservation1
		{
			get { return new EntityField("BFI_BusinessRange", 12, "Reservation1", SqlDbType.NVarChar, false, false, false, true); }
		}

		public static EntityField Reservation2
		{
			get { return new EntityField("BFI_BusinessRange", 13, "Reservation2", SqlDbType.NVarChar, false, false, false, true); }
		}

		public static EntityField Reservation3
		{
			get { return new EntityField("BFI_BusinessRange", 14, "Reservation3", SqlDbType.NVarChar, false, false, false, true); }
		}

		public static EntityField Reservation4
		{
			get { return new EntityField("BFI_BusinessRange", 15, "Reservation4", SqlDbType.NVarChar, false, false, false, true); }
		}

		public static EntityField Reservation5
		{
			get { return new EntityField("BFI_BusinessRange", 16, "Reservation5", SqlDbType.NVarChar, false, false, false, true); }
		}

		public static EntityField Reservation6
		{
			get { return new EntityField("BFI_BusinessRange", 17, "Reservation6", SqlDbType.NVarChar, false, false, false, true); }
		}

		public static EntityField Reservation7
		{
			get { return new EntityField("BFI_BusinessRange", 18, "Reservation7", SqlDbType.NVarChar, false, false, false, true); }
		}

		public static EntityField Reservation8
		{
			get { return new EntityField("BFI_BusinessRange", 19, "Reservation8", SqlDbType.NVarChar, false, false, false, true); }
		}

		public static EntityField Reservation9
		{
			get { return new EntityField("BFI_BusinessRange", 20, "Reservation9", SqlDbType.NVarChar, false, false, false, true); }
		}

		public static EntityField Reservation10
		{
			get { return new EntityField("BFI_BusinessRange", 21, "Reservation10", SqlDbType.NVarChar, false, false, false, true); }
		}

	}

	#endregion

	#region BFIBusinessRangeEntityFields2

	public enum BFIBusinessRangeEntityFields2
	{
		RangeID,

		EnterpriseID,

		DealerID,

		ProductStyleID,

		ProductStyleName,

		RangeStyle,

		RangeStyleName,

		CreateUserID,

		CreateDate,

		LastModifyUserID,

		LastModifyDate,

		RangeRemark,

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
