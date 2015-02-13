/*
 *	Build By: Codey Object Relation Mapping
 *	Build Data: 2015-01-25 18:11:10
 *	Build Type: Entity
 *	Description: BFIPriceListVersionEntity
*/

using System;
using System.Collections.Generic;
using System.Data;
using ORMSCore;

namespace DQS.Module.Entities
{
	public class BFIPriceListVersionEntity : EntityBase
	{
		public int PriceListVersionID
		{
			get { return (int)this.GetValue("PriceListVersionID"); } 
			set { this.SetValue("PriceListVersionID", value); } 
		}

		public int PriceListID
		{
			get { return (int)this.GetValue("PriceListID"); } 
			set { this.SetValue("PriceListID", value); } 
		}

		public int CompanyID
		{
			get { return (int)this.GetValue("CompanyID"); } 
			set { this.SetValue("CompanyID", value); } 
		}

		public string PriceListVersionName
		{
			get { return (string)this.GetValue("PriceListVersionName"); } 
			set { this.SetValue("PriceListVersionName", value); } 
		}

		public DateTime StartDate
		{
			get { return (DateTime)this.GetValue("StartDate"); } 
			set { this.SetValue("StartDate", value); } 
		}

		public DateTime EndDate
		{
			get { return (DateTime)this.GetValue("EndDate"); } 
			set { this.SetValue("EndDate", value); } 
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

		public BFIPriceListVersionEntity()
		{
			this.TableName = "BFI_PriceListVersion";
			this.Fields = new Dictionary<string, EntityField>();
			this.Fields.Add("PriceListVersionID", BFIPriceListVersionEntityFields.PriceListVersionID);
			this.Fields.Add("PriceListID", BFIPriceListVersionEntityFields.PriceListID);
			this.Fields.Add("CompanyID", BFIPriceListVersionEntityFields.CompanyID);
			this.Fields.Add("PriceListVersionName", BFIPriceListVersionEntityFields.PriceListVersionName);
			this.Fields.Add("StartDate", BFIPriceListVersionEntityFields.StartDate);
			this.Fields.Add("EndDate", BFIPriceListVersionEntityFields.EndDate);
			this.Fields.Add("Active", BFIPriceListVersionEntityFields.Active);
			this.Fields.Add("CreateUserID", BFIPriceListVersionEntityFields.CreateUserID);
			this.Fields.Add("CreateDate", BFIPriceListVersionEntityFields.CreateDate);
			this.Fields.Add("LastModifyUserID", BFIPriceListVersionEntityFields.LastModifyUserID);
			this.Fields.Add("LastModifyDate", BFIPriceListVersionEntityFields.LastModifyDate);
		}
	}

	#region BFIPriceListVersionEntityFields

	public class BFIPriceListVersionEntityFields
	{
		public static EntityField PriceListVersionID
		{
			get { return new EntityField("BFI_PriceListVersion", 0, "PriceListVersionID", SqlDbType.Int, true, true, true, false); }
		}

		public static EntityField PriceListID
		{
			get { return new EntityField("BFI_PriceListVersion", 1, "PriceListID", SqlDbType.Int, false, false, false, false); }
		}

		public static EntityField CompanyID
		{
			get { return new EntityField("BFI_PriceListVersion", 2, "CompanyID", SqlDbType.Int, false, false, false, true); }
		}

		public static EntityField PriceListVersionName
		{
			get { return new EntityField("BFI_PriceListVersion", 3, "PriceListVersionName", SqlDbType.NVarChar, false, false, true, false); }
		}

		public static EntityField StartDate
		{
			get { return new EntityField("BFI_PriceListVersion", 4, "StartDate", SqlDbType.DateTime, false, false, false, true); }
		}

		public static EntityField EndDate
		{
			get { return new EntityField("BFI_PriceListVersion", 5, "EndDate", SqlDbType.DateTime, false, false, false, true); }
		}

		public static EntityField Active
		{
			get { return new EntityField("BFI_PriceListVersion", 6, "Active", SqlDbType.Bit, false, false, false, true); }
		}

		public static EntityField CreateUserID
		{
			get { return new EntityField("BFI_PriceListVersion", 7, "CreateUserID", SqlDbType.UniqueIdentifier, false, false, false, true); }
		}

		public static EntityField CreateDate
		{
			get { return new EntityField("BFI_PriceListVersion", 8, "CreateDate", SqlDbType.DateTime, false, false, false, true); }
		}

		public static EntityField LastModifyUserID
		{
			get { return new EntityField("BFI_PriceListVersion", 9, "LastModifyUserID", SqlDbType.UniqueIdentifier, false, false, false, true); }
		}

		public static EntityField LastModifyDate
		{
			get { return new EntityField("BFI_PriceListVersion", 10, "LastModifyDate", SqlDbType.DateTime, false, false, false, true); }
		}

	}

	#endregion

	#region BFIPriceListVersionEntityFields2

	public enum BFIPriceListVersionEntityFields2
	{
		PriceListVersionID,

		PriceListID,

		CompanyID,

		PriceListVersionName,

		StartDate,

		EndDate,

		Active,

		CreateUserID,

		CreateDate,

		LastModifyUserID,

		LastModifyDate,

	}

	#endregion

}
