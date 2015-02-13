/*
 *	Build By: Codey Object Relation Mapping
 *	Build Data: 2013-07-19 19:48:09
 *	Build Type: Entity
 *	Description: SYSPageFunctionEntity
*/

using System;
using System.Collections.Generic;
using System.Data;
using ORMSCore;

namespace DQS.Module.Entities
{
	public class SYSPageFunctionEntity : EntityBase
	{
		public string PageCode
		{
			get { return (string)this.GetValue("PageCode"); } 
			set { this.SetValue("PageCode", value); } 
		}

		public string FunctionCode
		{
			get { return (string)this.GetValue("FunctionCode"); } 
			set { this.SetValue("FunctionCode", value); } 
		}

		public int ImageIndex
		{
			get { return (int)this.GetValue("ImageIndex"); } 
			set { this.SetValue("ImageIndex", value); } 
		}

		public string ImageName
		{
			get { return (string)this.GetValue("ImageName"); } 
			set { this.SetValue("ImageName", value); } 
		}

		public string ImageUrl
		{
			get { return (string)this.GetValue("ImageUrl"); } 
			set { this.SetValue("ImageUrl", value); } 
		}

		public byte[] ImageData
		{
			get { return (byte[])this.GetValue("ImageData"); } 
			set { this.SetValue("ImageData", value); } 
		}

		public string FunctionDescription
		{
			get { return (string)this.GetValue("FunctionDescription"); } 
			set { this.SetValue("FunctionDescription", value); } 
		}

		public bool IsPopupPage
		{
			get { return (bool)this.GetValue("IsPopupPage"); } 
			set { this.SetValue("IsPopupPage", value); } 
		}

		public string PopupPageCode
		{
			get { return (string)this.GetValue("PopupPageCode"); } 
			set { this.SetValue("PopupPageCode", value); } 
		}

		public string PageFunctionRemark
		{
			get { return (string)this.GetValue("PageFunctionRemark"); } 
			set { this.SetValue("PageFunctionRemark", value); } 
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

		public SYSPageFunctionEntity()
		{
			this.TableName = "SYS_PageFunction";
			this.Fields = new Dictionary<string, EntityField>();
			this.Fields.Add("PageCode", SYSPageFunctionEntityFields.PageCode);
			this.Fields.Add("FunctionCode", SYSPageFunctionEntityFields.FunctionCode);
			this.Fields.Add("ImageIndex", SYSPageFunctionEntityFields.ImageIndex);
			this.Fields.Add("ImageName", SYSPageFunctionEntityFields.ImageName);
			this.Fields.Add("ImageUrl", SYSPageFunctionEntityFields.ImageUrl);
			this.Fields.Add("ImageData", SYSPageFunctionEntityFields.ImageData);
			this.Fields.Add("FunctionDescription", SYSPageFunctionEntityFields.FunctionDescription);
			this.Fields.Add("IsPopupPage", SYSPageFunctionEntityFields.IsPopupPage);
			this.Fields.Add("PopupPageCode", SYSPageFunctionEntityFields.PopupPageCode);
			this.Fields.Add("PageFunctionRemark", SYSPageFunctionEntityFields.PageFunctionRemark);
			this.Fields.Add("Reservation1", SYSPageFunctionEntityFields.Reservation1);
			this.Fields.Add("Reservation2", SYSPageFunctionEntityFields.Reservation2);
			this.Fields.Add("Reservation3", SYSPageFunctionEntityFields.Reservation3);
			this.Fields.Add("Reservation4", SYSPageFunctionEntityFields.Reservation4);
			this.Fields.Add("Reservation5", SYSPageFunctionEntityFields.Reservation5);
		}
	}

	#region SYSPageFunctionEntityFields

	public class SYSPageFunctionEntityFields
	{
		public static EntityField PageCode
		{
			get { return new EntityField("SYS_PageFunction", 0, "PageCode", SqlDbType.NVarChar, true, false, true, false); }
		}

		public static EntityField FunctionCode
		{
			get { return new EntityField("SYS_PageFunction", 1, "FunctionCode", SqlDbType.NVarChar, false, false, false, false); }
		}

		public static EntityField ImageIndex
		{
			get { return new EntityField("SYS_PageFunction", 2, "ImageIndex", SqlDbType.Int, false, false, false, true); }
		}

		public static EntityField ImageName
		{
			get { return new EntityField("SYS_PageFunction", 3, "ImageName", SqlDbType.NVarChar, false, false, false, true); }
		}

		public static EntityField ImageUrl
		{
			get { return new EntityField("SYS_PageFunction", 4, "ImageUrl", SqlDbType.NVarChar, false, false, false, true); }
		}

		public static EntityField ImageData
		{
			get { return new EntityField("SYS_PageFunction", 5, "ImageData", SqlDbType.Image, false, false, false, true); }
		}

		public static EntityField FunctionDescription
		{
			get { return new EntityField("SYS_PageFunction", 6, "FunctionDescription", SqlDbType.NVarChar, false, false, false, true); }
		}

		public static EntityField IsPopupPage
		{
			get { return new EntityField("SYS_PageFunction", 7, "IsPopupPage", SqlDbType.Bit, false, false, false, false); }
		}

		public static EntityField PopupPageCode
		{
			get { return new EntityField("SYS_PageFunction", 8, "PopupPageCode", SqlDbType.NVarChar, false, false, false, true); }
		}

		public static EntityField PageFunctionRemark
		{
			get { return new EntityField("SYS_PageFunction", 9, "PageFunctionRemark", SqlDbType.NVarChar, false, false, false, true); }
		}

		public static EntityField Reservation1
		{
			get { return new EntityField("SYS_PageFunction", 10, "Reservation1", SqlDbType.NVarChar, false, false, false, true); }
		}

		public static EntityField Reservation2
		{
			get { return new EntityField("SYS_PageFunction", 11, "Reservation2", SqlDbType.NVarChar, false, false, false, true); }
		}

		public static EntityField Reservation3
		{
			get { return new EntityField("SYS_PageFunction", 12, "Reservation3", SqlDbType.NVarChar, false, false, false, true); }
		}

		public static EntityField Reservation4
		{
			get { return new EntityField("SYS_PageFunction", 13, "Reservation4", SqlDbType.NVarChar, false, false, false, true); }
		}

		public static EntityField Reservation5
		{
			get { return new EntityField("SYS_PageFunction", 14, "Reservation5", SqlDbType.NVarChar, false, false, false, true); }
		}

	}

	#endregion

	#region SYSPageFunctionEntityFields2

	public enum SYSPageFunctionEntityFields2
	{
		PageCode,

		FunctionCode,

		ImageIndex,

		ImageName,

		ImageUrl,

		ImageData,

		FunctionDescription,

		IsPopupPage,

		PopupPageCode,

		PageFunctionRemark,

		Reservation1,

		Reservation2,

		Reservation3,

		Reservation4,

		Reservation5,

	}

	#endregion

}
