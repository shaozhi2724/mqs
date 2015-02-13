/*
 *	Build By: Codey Object Relation Mapping
 *	Build Data: 2013-08-19 10:13:13
 *	Build Type: Entity
 *	Description: SYSPageEntity
*/

using System;
using System.Collections.Generic;
using System.Data;
using ORMSCore;

namespace DQS.Module.Entities
{
	public class SYSPageEntity : EntityBase
	{
		public string PageCode
		{
			get { return (string)this.GetValue("PageCode"); } 
			set { this.SetValue("PageCode", value); } 
		}

		public string PageName
		{
			get { return (string)this.GetValue("PageName"); } 
			set { this.SetValue("PageName", value); } 
		}

		public string PageTitle
		{
			get { return (string)this.GetValue("PageTitle"); } 
			set { this.SetValue("PageTitle", value); } 
		}

		public string SubTitle
		{
			get { return (string)this.GetValue("SubTitle"); } 
			set { this.SetValue("SubTitle", value); } 
		}

		public int SortNumber
		{
			get { return (int)this.GetValue("SortNumber"); } 
			set { this.SetValue("SortNumber", value); } 
		}

		public string PageUrl
		{
			get { return (string)this.GetValue("PageUrl"); } 
			set { this.SetValue("PageUrl", value); } 
		}

		public string PageFullClass
		{
			get { return (string)this.GetValue("PageFullClass"); } 
			set { this.SetValue("PageFullClass", value); } 
		}

		public string DbTableName
		{
			get { return (string)this.GetValue("DbTableName"); } 
			set { this.SetValue("DbTableName", value); } 
		}

		public string EntityName
		{
			get { return (string)this.GetValue("EntityName"); } 
			set { this.SetValue("EntityName", value); } 
		}

		public string TablePrimaryField
		{
			get { return (string)this.GetValue("TablePrimaryField"); } 
			set { this.SetValue("TablePrimaryField", value); } 
		}

		public string SingleFullClass
		{
            get { return this.GetValue("SingleFullClass") != DBNull.Value ? (string)this.GetValue("SingleFullClass") : string.Empty; } 
			set { this.SetValue("SingleFullClass", value); } 
		}

		public string DocumentCode
		{
			get { return (string)this.GetValue("DocumentCode"); } 
			set { this.SetValue("DocumentCode", value); } 
		}

		public string DbViewName
		{
			get { return (string)this.GetValue("DbViewName"); } 
			set { this.SetValue("DbViewName", value); } 
		}

		public string ViewPrimaryField
		{
			get { return (string)this.GetValue("ViewPrimaryField"); } 
			set { this.SetValue("ViewPrimaryField", value); } 
		}

		public bool IsPagination
		{
			get { return (bool)this.GetValue("IsPagination"); } 
			set { this.SetValue("IsPagination", value); } 
		}

		public string IconName
		{
			get { return (string)this.GetValue("IconName"); } 
			set { this.SetValue("IconName", value); } 
		}

		public string IconUrl
		{
			get { return (string)this.GetValue("IconUrl"); } 
			set { this.SetValue("IconUrl", value); } 
		}

		public byte[] IconData
		{
			get { return (byte[])this.GetValue("IconData"); } 
			set { this.SetValue("IconData", value); } 
		}

		public string PageDescription
		{
			get { return (string)this.GetValue("PageDescription"); } 
			set { this.SetValue("PageDescription", value); } 
		}

		public string PageRemark
		{
			get { return (string)this.GetValue("PageRemark"); } 
			set { this.SetValue("PageRemark", value); } 
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

		public SYSPageEntity()
		{
			this.TableName = "SYS_Page";
			this.Fields = new Dictionary<string, EntityField>();
			this.Fields.Add("PageCode", SYSPageEntityFields.PageCode);
			this.Fields.Add("PageName", SYSPageEntityFields.PageName);
			this.Fields.Add("PageTitle", SYSPageEntityFields.PageTitle);
			this.Fields.Add("SubTitle", SYSPageEntityFields.SubTitle);
			this.Fields.Add("SortNumber", SYSPageEntityFields.SortNumber);
			this.Fields.Add("PageUrl", SYSPageEntityFields.PageUrl);
			this.Fields.Add("PageFullClass", SYSPageEntityFields.PageFullClass);
			this.Fields.Add("DbTableName", SYSPageEntityFields.DbTableName);
			this.Fields.Add("EntityName", SYSPageEntityFields.EntityName);
			this.Fields.Add("TablePrimaryField", SYSPageEntityFields.TablePrimaryField);
			this.Fields.Add("SingleFullClass", SYSPageEntityFields.SingleFullClass);
			this.Fields.Add("DocumentCode", SYSPageEntityFields.DocumentCode);
			this.Fields.Add("DbViewName", SYSPageEntityFields.DbViewName);
			this.Fields.Add("ViewPrimaryField", SYSPageEntityFields.ViewPrimaryField);
			this.Fields.Add("IsPagination", SYSPageEntityFields.IsPagination);
			this.Fields.Add("IconName", SYSPageEntityFields.IconName);
			this.Fields.Add("IconUrl", SYSPageEntityFields.IconUrl);
			this.Fields.Add("IconData", SYSPageEntityFields.IconData);
			this.Fields.Add("PageDescription", SYSPageEntityFields.PageDescription);
			this.Fields.Add("PageRemark", SYSPageEntityFields.PageRemark);
			this.Fields.Add("Reservation1", SYSPageEntityFields.Reservation1);
			this.Fields.Add("Reservation2", SYSPageEntityFields.Reservation2);
			this.Fields.Add("Reservation3", SYSPageEntityFields.Reservation3);
			this.Fields.Add("Reservation4", SYSPageEntityFields.Reservation4);
			this.Fields.Add("Reservation5", SYSPageEntityFields.Reservation5);
		}
	}

	#region SYSPageEntityFields

	public class SYSPageEntityFields
	{
		public static EntityField PageCode
		{
			get { return new EntityField("SYS_Page", 0, "PageCode", SqlDbType.NVarChar, true, false, true, false); }
		}

		public static EntityField PageName
		{
			get { return new EntityField("SYS_Page", 1, "PageName", SqlDbType.NVarChar, false, false, false, false); }
		}

		public static EntityField PageTitle
		{
			get { return new EntityField("SYS_Page", 2, "PageTitle", SqlDbType.NVarChar, false, false, false, true); }
		}

		public static EntityField SubTitle
		{
			get { return new EntityField("SYS_Page", 3, "SubTitle", SqlDbType.NVarChar, false, false, false, true); }
		}

		public static EntityField SortNumber
		{
			get { return new EntityField("SYS_Page", 4, "SortNumber", SqlDbType.Int, false, false, false, true); }
		}

		public static EntityField PageUrl
		{
			get { return new EntityField("SYS_Page", 5, "PageUrl", SqlDbType.NVarChar, false, false, false, true); }
		}

		public static EntityField PageFullClass
		{
			get { return new EntityField("SYS_Page", 6, "PageFullClass", SqlDbType.NVarChar, false, false, false, true); }
		}

		public static EntityField DbTableName
		{
			get { return new EntityField("SYS_Page", 7, "DbTableName", SqlDbType.NVarChar, false, false, false, true); }
		}

		public static EntityField EntityName
		{
			get { return new EntityField("SYS_Page", 8, "EntityName", SqlDbType.NVarChar, false, false, false, true); }
		}

		public static EntityField TablePrimaryField
		{
			get { return new EntityField("SYS_Page", 9, "TablePrimaryField", SqlDbType.NVarChar, false, false, false, true); }
		}

		public static EntityField SingleFullClass
		{
			get { return new EntityField("SYS_Page", 10, "SingleFullClass", SqlDbType.NVarChar, false, false, false, true); }
		}

		public static EntityField DocumentCode
		{
			get { return new EntityField("SYS_Page", 11, "DocumentCode", SqlDbType.NVarChar, false, false, false, true); }
		}

		public static EntityField DbViewName
		{
			get { return new EntityField("SYS_Page", 12, "DbViewName", SqlDbType.NVarChar, false, false, false, true); }
		}

		public static EntityField ViewPrimaryField
		{
			get { return new EntityField("SYS_Page", 13, "ViewPrimaryField", SqlDbType.VarChar, false, false, false, true); }
		}

		public static EntityField IsPagination
		{
			get { return new EntityField("SYS_Page", 14, "IsPagination", SqlDbType.Bit, false, false, false, true); }
		}

		public static EntityField IconName
		{
			get { return new EntityField("SYS_Page", 15, "IconName", SqlDbType.NVarChar, false, false, false, true); }
		}

		public static EntityField IconUrl
		{
			get { return new EntityField("SYS_Page", 16, "IconUrl", SqlDbType.NVarChar, false, false, false, true); }
		}

		public static EntityField IconData
		{
			get { return new EntityField("SYS_Page", 17, "IconData", SqlDbType.Image, false, false, false, true); }
		}

		public static EntityField PageDescription
		{
			get { return new EntityField("SYS_Page", 18, "PageDescription", SqlDbType.NVarChar, false, false, false, true); }
		}

		public static EntityField PageRemark
		{
			get { return new EntityField("SYS_Page", 19, "PageRemark", SqlDbType.NVarChar, false, false, false, true); }
		}

		public static EntityField Reservation1
		{
			get { return new EntityField("SYS_Page", 20, "Reservation1", SqlDbType.NVarChar, false, false, false, true); }
		}

		public static EntityField Reservation2
		{
			get { return new EntityField("SYS_Page", 21, "Reservation2", SqlDbType.NVarChar, false, false, false, true); }
		}

		public static EntityField Reservation3
		{
			get { return new EntityField("SYS_Page", 22, "Reservation3", SqlDbType.NVarChar, false, false, false, true); }
		}

		public static EntityField Reservation4
		{
			get { return new EntityField("SYS_Page", 23, "Reservation4", SqlDbType.NVarChar, false, false, false, true); }
		}

		public static EntityField Reservation5
		{
			get { return new EntityField("SYS_Page", 24, "Reservation5", SqlDbType.NVarChar, false, false, false, true); }
		}

	}

	#endregion

	#region SYSPageEntityFields2

	public enum SYSPageEntityFields2
	{
		PageCode,

		PageName,

		PageTitle,

		SubTitle,

		SortNumber,

		PageUrl,

		PageFullClass,

		DbTableName,

		EntityName,

		TablePrimaryField,

		SingleFullClass,

		DocumentCode,

		DbViewName,

		ViewPrimaryField,

		IsPagination,

		IconName,

		IconUrl,

		IconData,

		PageDescription,

		PageRemark,

		Reservation1,

		Reservation2,

		Reservation3,

		Reservation4,

		Reservation5,

	}

	#endregion

}
