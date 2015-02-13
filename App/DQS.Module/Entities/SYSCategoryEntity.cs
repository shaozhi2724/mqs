/*
 *	Build By: Codey Object Relation Mapping
 *	Build Data: 2013-07-19 19:48:09
 *	Build Type: Entity
 *	Description: SYSCategoryEntity
*/

using System;
using System.Collections.Generic;
using System.Data;
using ORMSCore;

namespace DQS.Module.Entities
{
	public class SYSCategoryEntity : EntityBase
	{
		public string CategoryCode
		{
			get { return (string)this.GetValue("CategoryCode"); } 
			set { this.SetValue("CategoryCode", value); } 
		}

		public string CategoryName
		{
			get { return (string)this.GetValue("CategoryName"); } 
			set { this.SetValue("CategoryName", value); } 
		}

		public string CategoryDescription
		{
			get { return (string)this.GetValue("CategoryDescription"); } 
			set { this.SetValue("CategoryDescription", value); } 
		}

		public int ItemID
		{
			get { return (int)this.GetValue("ItemID"); } 
			set { this.SetValue("ItemID", value); } 
		}

		public string ItemName
		{
			get { return (string)this.GetValue("ItemName"); } 
			set { this.SetValue("ItemName", value); } 
		}

		public string ItemSpell
		{
			get { return (string)this.GetValue("ItemSpell"); } 
			set { this.SetValue("ItemSpell", value); } 
		}

		public int ParentItemID
		{
			get { return (int)this.GetValue("ParentItemID"); } 
			set { this.SetValue("ParentItemID", value); } 
		}

		public string ItemDescription
		{
			get { return (string)this.GetValue("ItemDescription"); } 
			set { this.SetValue("ItemDescription", value); } 
		}

		public bool IsSystemItem
		{
			get { return (bool)this.GetValue("IsSystemItem"); } 
			set { this.SetValue("IsSystemItem", value); } 
		}

		public int StatusSort
		{
			get { return (int)this.GetValue("StatusSort"); } 
			set { this.SetValue("StatusSort", value); } 
		}

		public bool IsEffective
		{
			get { return (bool)this.GetValue("IsEffective"); } 
			set { this.SetValue("IsEffective", value); } 
		}

		public string ItemRemark
		{
			get { return (string)this.GetValue("ItemRemark"); } 
			set { this.SetValue("ItemRemark", value); } 
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

		public SYSCategoryEntity()
		{
			this.TableName = "SYS_Category";
			this.Fields = new Dictionary<string, EntityField>();
			this.Fields.Add("CategoryCode", SYSCategoryEntityFields.CategoryCode);
			this.Fields.Add("CategoryName", SYSCategoryEntityFields.CategoryName);
			this.Fields.Add("CategoryDescription", SYSCategoryEntityFields.CategoryDescription);
			this.Fields.Add("ItemID", SYSCategoryEntityFields.ItemID);
			this.Fields.Add("ItemName", SYSCategoryEntityFields.ItemName);
			this.Fields.Add("ItemSpell", SYSCategoryEntityFields.ItemSpell);
			this.Fields.Add("ParentItemID", SYSCategoryEntityFields.ParentItemID);
			this.Fields.Add("ItemDescription", SYSCategoryEntityFields.ItemDescription);
			this.Fields.Add("IsSystemItem", SYSCategoryEntityFields.IsSystemItem);
			this.Fields.Add("StatusSort", SYSCategoryEntityFields.StatusSort);
			this.Fields.Add("IsEffective", SYSCategoryEntityFields.IsEffective);
			this.Fields.Add("ItemRemark", SYSCategoryEntityFields.ItemRemark);
			this.Fields.Add("Reservation1", SYSCategoryEntityFields.Reservation1);
			this.Fields.Add("Reservation2", SYSCategoryEntityFields.Reservation2);
			this.Fields.Add("Reservation3", SYSCategoryEntityFields.Reservation3);
			this.Fields.Add("Reservation4", SYSCategoryEntityFields.Reservation4);
			this.Fields.Add("Reservation5", SYSCategoryEntityFields.Reservation5);
		}
	}

	#region SYSCategoryEntityFields

	public class SYSCategoryEntityFields
	{
		public static EntityField CategoryCode
		{
			get { return new EntityField("SYS_Category", 0, "CategoryCode", SqlDbType.NVarChar, true, false, true, false); }
		}

		public static EntityField CategoryName
		{
			get { return new EntityField("SYS_Category", 1, "CategoryName", SqlDbType.NVarChar, false, false, false, false); }
		}

		public static EntityField CategoryDescription
		{
			get { return new EntityField("SYS_Category", 2, "CategoryDescription", SqlDbType.NVarChar, false, false, false, true); }
		}

		public static EntityField ItemID
		{
			get { return new EntityField("SYS_Category", 3, "ItemID", SqlDbType.Int, true, false, true, false); }
		}

		public static EntityField ItemName
		{
			get { return new EntityField("SYS_Category", 4, "ItemName", SqlDbType.NVarChar, false, false, false, false); }
		}

		public static EntityField ItemSpell
		{
			get { return new EntityField("SYS_Category", 5, "ItemSpell", SqlDbType.NVarChar, false, false, false, true); }
		}

		public static EntityField ParentItemID
		{
			get { return new EntityField("SYS_Category", 6, "ParentItemID", SqlDbType.Int, false, false, false, true); }
		}

		public static EntityField ItemDescription
		{
			get { return new EntityField("SYS_Category", 7, "ItemDescription", SqlDbType.NVarChar, false, false, false, true); }
		}

		public static EntityField IsSystemItem
		{
			get { return new EntityField("SYS_Category", 8, "IsSystemItem", SqlDbType.Bit, false, false, false, true); }
		}

		public static EntityField StatusSort
		{
			get { return new EntityField("SYS_Category", 9, "StatusSort", SqlDbType.Int, false, false, false, true); }
		}

		public static EntityField IsEffective
		{
			get { return new EntityField("SYS_Category", 10, "IsEffective", SqlDbType.Bit, false, false, false, true); }
		}

		public static EntityField ItemRemark
		{
			get { return new EntityField("SYS_Category", 11, "ItemRemark", SqlDbType.NVarChar, false, false, false, true); }
		}

		public static EntityField Reservation1
		{
			get { return new EntityField("SYS_Category", 12, "Reservation1", SqlDbType.NVarChar, false, false, false, true); }
		}

		public static EntityField Reservation2
		{
			get { return new EntityField("SYS_Category", 13, "Reservation2", SqlDbType.NVarChar, false, false, false, true); }
		}

		public static EntityField Reservation3
		{
			get { return new EntityField("SYS_Category", 14, "Reservation3", SqlDbType.NVarChar, false, false, false, true); }
		}

		public static EntityField Reservation4
		{
			get { return new EntityField("SYS_Category", 15, "Reservation4", SqlDbType.NVarChar, false, false, false, true); }
		}

		public static EntityField Reservation5
		{
			get { return new EntityField("SYS_Category", 16, "Reservation5", SqlDbType.NVarChar, false, false, false, true); }
		}

	}

	#endregion

	#region SYSCategoryEntityFields2

	public enum SYSCategoryEntityFields2
	{
		CategoryCode,

		CategoryName,

		CategoryDescription,

		ItemID,

		ItemName,

		ItemSpell,

		ParentItemID,

		ItemDescription,

		IsSystemItem,

		StatusSort,

		IsEffective,

		ItemRemark,

		Reservation1,

		Reservation2,

		Reservation3,

		Reservation4,

		Reservation5,

	}

	#endregion

}
