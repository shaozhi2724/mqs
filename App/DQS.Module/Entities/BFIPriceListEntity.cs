/*
 *	Build By: Codey Object Relation Mapping
 *	Build Data: 2015-01-25 18:11:10
 *	Build Type: Entity
 *	Description: BFIPriceListEntity
*/

using System;
using System.Collections.Generic;
using System.Data;
using ORMSCore;

namespace DQS.Module.Entities
{
	public class BFIPriceListEntity : EntityBase
	{
		public int PriceListID
		{
			get { return (int)this.GetValue("PriceListID"); } 
			set { this.SetValue("PriceListID", value); } 
		}

		public string PriceListType
		{
			get { return (string)this.GetValue("PriceListType"); } 
			set { this.SetValue("PriceListType", value); } 
		}

		public string PriceListName
		{
			get { return (string)this.GetValue("PriceListName"); } 
			set { this.SetValue("PriceListName", value); } 
		}

		public int CompanyID
		{
			get { return (int)this.GetValue("CompanyID"); } 
			set { this.SetValue("CompanyID", value); } 
		}

		public bool Active
		{
			get { return (bool)this.GetValue("Active"); } 
			set { this.SetValue("Active", value); } 
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

		public BFIPriceListEntity()
		{
			this.TableName = "BFI_PriceList";
			this.Fields = new Dictionary<string, EntityField>();
			this.Fields.Add("PriceListID", BFIPriceListEntityFields.PriceListID);
			this.Fields.Add("PriceListType", BFIPriceListEntityFields.PriceListType);
			this.Fields.Add("PriceListName", BFIPriceListEntityFields.PriceListName);
			this.Fields.Add("CompanyID", BFIPriceListEntityFields.CompanyID);
			this.Fields.Add("Active", BFIPriceListEntityFields.Active);
			this.Fields.Add("CreateUserID", BFIPriceListEntityFields.CreateUserID);
			this.Fields.Add("CreateDate", BFIPriceListEntityFields.CreateDate);
			this.Fields.Add("LastModifyUserID", BFIPriceListEntityFields.LastModifyUserID);
			this.Fields.Add("LastModifyDate", BFIPriceListEntityFields.LastModifyDate);
		}
	}

	#region BFIPriceListEntityFields

	public class BFIPriceListEntityFields
	{
		public static EntityField PriceListID
		{
			get { return new EntityField("BFI_PriceList", 0, "PriceListID", SqlDbType.Int, true, true, true, false); }
		}

		public static EntityField PriceListType
		{
			get { return new EntityField("BFI_PriceList", 1, "PriceListType", SqlDbType.NVarChar, false, false, true, true); }
		}

		public static EntityField PriceListName
		{
			get { return new EntityField("BFI_PriceList", 2, "PriceListName", SqlDbType.NVarChar, false, false, true, true); }
		}

		public static EntityField CompanyID
		{
			get { return new EntityField("BFI_PriceList", 3, "CompanyID", SqlDbType.Int, false, false, false, true); }
		}

		public static EntityField Active
		{
			get { return new EntityField("BFI_PriceList", 4, "Active", SqlDbType.Bit, false, false, false, true); }
		}

		public static EntityField CreateUserID
		{
			get { return new EntityField("BFI_PriceList", 5, "CreateUserID", SqlDbType.UniqueIdentifier, false, false, false, true); }
		}

		public static EntityField CreateDate
		{
			get { return new EntityField("BFI_PriceList", 6, "CreateDate", SqlDbType.DateTime, false, false, false, true); }
		}

		public static EntityField LastModifyUserID
		{
			get { return new EntityField("BFI_PriceList", 7, "LastModifyUserID", SqlDbType.UniqueIdentifier, false, false, false, true); }
		}

		public static EntityField LastModifyDate
		{
			get { return new EntityField("BFI_PriceList", 8, "LastModifyDate", SqlDbType.DateTime, false, false, false, true); }
		}

	}

	#endregion

	#region BFIPriceListEntityFields2

	public enum BFIPriceListEntityFields2
	{
		PriceListID,

		PriceListType,

		PriceListName,

		CompanyID,

		Active,

		CreateUserID,

		CreateDate,

		LastModifyUserID,

		LastModifyDate,

	}

	#endregion

}
