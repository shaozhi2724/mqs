/*
 *	Build By: Codey Object Relation Mapping
 *	Build Data: 2014-07-24 21:17:37
 *	Build Type: Entity
 *	Description: ATCUserProductEntity
*/

using System;
using System.Collections.Generic;
using System.Data;
using ORMSCore;

namespace DQS.Module.Entities
{
	public class ATCUserProductEntity : EntityBase
	{
		public long UserProductID
		{
			get { return (long)this.GetValue("UserProductID"); } 
			set { this.SetValue("UserProductID", value); } 
		}

		public Guid UserID
		{
			get { return (Guid)this.GetValue("UserID"); } 
			set { this.SetValue("UserID", value); } 
		}

		public string UserName
		{
			get { return (string)this.GetValue("UserName"); } 
			set { this.SetValue("UserName", value); } 
		}

		public int ProductCategoryID
		{
			get { return (int)this.GetValue("ProductCategoryID"); } 
			set { this.SetValue("ProductCategoryID", value); } 
		}

		public string ProductCategoryName
		{
			get { return (string)this.GetValue("ProductCategoryName"); } 
			set { this.SetValue("ProductCategoryName", value); } 
		}

		public int ProductID
		{
			get { return (int)this.GetValue("ProductID"); } 
			set { this.SetValue("ProductID", value); } 
		}

		public string ProductName
		{
			get { return (string)this.GetValue("ProductName"); } 
			set { this.SetValue("ProductName", value); } 
		}

		public ATCUserProductEntity()
		{
			this.TableName = "ATC_UserProduct";
			this.Fields = new Dictionary<string, EntityField>();
			this.Fields.Add("UserProductID", ATCUserProductEntityFields.UserProductID);
			this.Fields.Add("UserID", ATCUserProductEntityFields.UserID);
			this.Fields.Add("UserName", ATCUserProductEntityFields.UserName);
			this.Fields.Add("ProductCategoryID", ATCUserProductEntityFields.ProductCategoryID);
			this.Fields.Add("ProductCategoryName", ATCUserProductEntityFields.ProductCategoryName);
			this.Fields.Add("ProductID", ATCUserProductEntityFields.ProductID);
			this.Fields.Add("ProductName", ATCUserProductEntityFields.ProductName);
		}
	}

	#region ATCUserProductEntityFields

	public class ATCUserProductEntityFields
	{
		public static EntityField UserProductID
		{
			get { return new EntityField("ATC_UserProduct", 0, "UserProductID", SqlDbType.BigInt, true, true, true, false); }
		}

		public static EntityField UserID
		{
			get { return new EntityField("ATC_UserProduct", 1, "UserID", SqlDbType.UniqueIdentifier, false, false, false, false); }
		}

		public static EntityField UserName
		{
			get { return new EntityField("ATC_UserProduct", 2, "UserName", SqlDbType.NVarChar, false, false, false, false); }
		}

		public static EntityField ProductCategoryID
		{
			get { return new EntityField("ATC_UserProduct", 3, "ProductCategoryID", SqlDbType.Int, false, false, false, false); }
		}

		public static EntityField ProductCategoryName
		{
			get { return new EntityField("ATC_UserProduct", 4, "ProductCategoryName", SqlDbType.NVarChar, false, false, false, false); }
		}

		public static EntityField ProductID
		{
			get { return new EntityField("ATC_UserProduct", 5, "ProductID", SqlDbType.Int, false, false, false, false); }
		}

		public static EntityField ProductName
		{
			get { return new EntityField("ATC_UserProduct", 6, "ProductName", SqlDbType.NVarChar, false, false, false, false); }
		}

	}

	#endregion

	#region ATCUserProductEntityFields2

	public enum ATCUserProductEntityFields2
	{
		UserProductID,

		UserID,

		UserName,

		ProductCategoryID,

		ProductCategoryName,

		ProductID,

		ProductName,

	}

	#endregion

}
