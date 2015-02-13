/*
 *	Build By: Codey Object Relation Mapping
 *	Build Data: 2013-07-19 19:48:09
 *	Build Type: Entity
 *	Description: SYSMenuEntity
*/

using System;
using System.Collections.Generic;
using System.Data;
using ORMSCore;

namespace DQS.Module.Entities
{
	public class SYSMenuEntity : EntityBase
	{
		public string MenuCode
		{
			get { return (string)this.GetValue("MenuCode"); } 
			set { this.SetValue("MenuCode", value); } 
		}

		public string MenuName
		{
			get { return (string)this.GetValue("MenuName"); } 
			set { this.SetValue("MenuName", value); } 
		}

		public string MenuTitle
		{
			get { return (string)this.GetValue("MenuTitle"); } 
			set { this.SetValue("MenuTitle", value); } 
		}

		public string SubTitle
		{
			get { return (string)this.GetValue("SubTitle"); } 
			set { this.SetValue("SubTitle", value); } 
		}

		public bool IsEnabled
		{
			get { return (bool)this.GetValue("IsEnabled"); } 
			set { this.SetValue("IsEnabled", value); } 
		}

		public string ParentCode
		{
			get { return (string)this.GetValue("ParentCode"); } 
			set { this.SetValue("ParentCode", value); } 
		}

		public int LevelNo
		{
			get { return (int)this.GetValue("LevelNo"); } 
			set { this.SetValue("LevelNo", value); } 
		}

		public int SortNumber
		{
			get { return (int)this.GetValue("SortNumber"); } 
			set { this.SetValue("SortNumber", value); } 
		}

		public string MenuUrl
		{
			get { return (string)this.GetValue("MenuUrl"); } 
			set { this.SetValue("MenuUrl", value); } 
		}

		public string MenuFullClass
		{
			get { return (string)this.GetValue("MenuFullClass"); } 
			set { this.SetValue("MenuFullClass", value); } 
		}

		public string PageCode
		{
			get { return (string)this.GetValue("PageCode"); } 
			set { this.SetValue("PageCode", value); } 
		}

		public int IconIndex
		{
			get { return (int)this.GetValue("IconIndex"); } 
			set { this.SetValue("IconIndex", value); } 
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

		public int SmallImageIndex
		{
			get { return (int)this.GetValue("SmallImageIndex"); } 
			set { this.SetValue("SmallImageIndex", value); } 
		}

		public string SmallImageName
		{
			get { return (string)this.GetValue("SmallImageName"); } 
			set { this.SetValue("SmallImageName", value); } 
		}

		public string SmallImageUrl
		{
			get { return (string)this.GetValue("SmallImageUrl"); } 
			set { this.SetValue("SmallImageUrl", value); } 
		}

		public byte[] SmallImageData
		{
			get { return (byte[])this.GetValue("SmallImageData"); } 
			set { this.SetValue("SmallImageData", value); } 
		}

		public int LargeImageIndex
		{
			get { return (int)this.GetValue("LargeImageIndex"); } 
			set { this.SetValue("LargeImageIndex", value); } 
		}

		public string LargeImageName
		{
			get { return (string)this.GetValue("LargeImageName"); } 
			set { this.SetValue("LargeImageName", value); } 
		}

		public string LargeImageUrl
		{
			get { return (string)this.GetValue("LargeImageUrl"); } 
			set { this.SetValue("LargeImageUrl", value); } 
		}

		public byte[] LargeImageData
		{
			get { return (byte[])this.GetValue("LargeImageData"); } 
			set { this.SetValue("LargeImageData", value); } 
		}

		public string MenuDescription
		{
			get { return (string)this.GetValue("MenuDescription"); } 
			set { this.SetValue("MenuDescription", value); } 
		}

		public string MenuRemark
		{
			get { return (string)this.GetValue("MenuRemark"); } 
			set { this.SetValue("MenuRemark", value); } 
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

		public SYSMenuEntity()
		{
			this.TableName = "SYS_Menu";
			this.Fields = new Dictionary<string, EntityField>();
			this.Fields.Add("MenuCode", SYSMenuEntityFields.MenuCode);
			this.Fields.Add("MenuName", SYSMenuEntityFields.MenuName);
			this.Fields.Add("MenuTitle", SYSMenuEntityFields.MenuTitle);
			this.Fields.Add("SubTitle", SYSMenuEntityFields.SubTitle);
			this.Fields.Add("IsEnabled", SYSMenuEntityFields.IsEnabled);
			this.Fields.Add("ParentCode", SYSMenuEntityFields.ParentCode);
			this.Fields.Add("LevelNo", SYSMenuEntityFields.LevelNo);
			this.Fields.Add("SortNumber", SYSMenuEntityFields.SortNumber);
			this.Fields.Add("MenuUrl", SYSMenuEntityFields.MenuUrl);
			this.Fields.Add("MenuFullClass", SYSMenuEntityFields.MenuFullClass);
			this.Fields.Add("PageCode", SYSMenuEntityFields.PageCode);
			this.Fields.Add("IconIndex", SYSMenuEntityFields.IconIndex);
			this.Fields.Add("IconName", SYSMenuEntityFields.IconName);
			this.Fields.Add("IconUrl", SYSMenuEntityFields.IconUrl);
			this.Fields.Add("IconData", SYSMenuEntityFields.IconData);
			this.Fields.Add("SmallImageIndex", SYSMenuEntityFields.SmallImageIndex);
			this.Fields.Add("SmallImageName", SYSMenuEntityFields.SmallImageName);
			this.Fields.Add("SmallImageUrl", SYSMenuEntityFields.SmallImageUrl);
			this.Fields.Add("SmallImageData", SYSMenuEntityFields.SmallImageData);
			this.Fields.Add("LargeImageIndex", SYSMenuEntityFields.LargeImageIndex);
			this.Fields.Add("LargeImageName", SYSMenuEntityFields.LargeImageName);
			this.Fields.Add("LargeImageUrl", SYSMenuEntityFields.LargeImageUrl);
			this.Fields.Add("LargeImageData", SYSMenuEntityFields.LargeImageData);
			this.Fields.Add("MenuDescription", SYSMenuEntityFields.MenuDescription);
			this.Fields.Add("MenuRemark", SYSMenuEntityFields.MenuRemark);
			this.Fields.Add("Reservation1", SYSMenuEntityFields.Reservation1);
			this.Fields.Add("Reservation2", SYSMenuEntityFields.Reservation2);
			this.Fields.Add("Reservation3", SYSMenuEntityFields.Reservation3);
			this.Fields.Add("Reservation4", SYSMenuEntityFields.Reservation4);
			this.Fields.Add("Reservation5", SYSMenuEntityFields.Reservation5);
		}
	}

	#region SYSMenuEntityFields

	public class SYSMenuEntityFields
	{
		public static EntityField MenuCode
		{
			get { return new EntityField("SYS_Menu", 0, "MenuCode", SqlDbType.NVarChar, true, false, true, false); }
		}

		public static EntityField MenuName
		{
			get { return new EntityField("SYS_Menu", 1, "MenuName", SqlDbType.NVarChar, false, false, false, false); }
		}

		public static EntityField MenuTitle
		{
			get { return new EntityField("SYS_Menu", 2, "MenuTitle", SqlDbType.NVarChar, false, false, false, true); }
		}

		public static EntityField SubTitle
		{
			get { return new EntityField("SYS_Menu", 3, "SubTitle", SqlDbType.NVarChar, false, false, false, true); }
		}

		public static EntityField IsEnabled
		{
			get { return new EntityField("SYS_Menu", 4, "IsEnabled", SqlDbType.Bit, false, false, false, false); }
		}

		public static EntityField ParentCode
		{
			get { return new EntityField("SYS_Menu", 5, "ParentCode", SqlDbType.NVarChar, false, false, false, true); }
		}

		public static EntityField LevelNo
		{
			get { return new EntityField("SYS_Menu", 6, "LevelNo", SqlDbType.Int, false, false, false, true); }
		}

		public static EntityField SortNumber
		{
			get { return new EntityField("SYS_Menu", 7, "SortNumber", SqlDbType.Int, false, false, false, true); }
		}

		public static EntityField MenuUrl
		{
			get { return new EntityField("SYS_Menu", 8, "MenuUrl", SqlDbType.NVarChar, false, false, false, true); }
		}

		public static EntityField MenuFullClass
		{
			get { return new EntityField("SYS_Menu", 9, "MenuFullClass", SqlDbType.NVarChar, false, false, false, true); }
		}

		public static EntityField PageCode
		{
			get { return new EntityField("SYS_Menu", 10, "PageCode", SqlDbType.NVarChar, false, false, false, true); }
		}

		public static EntityField IconIndex
		{
			get { return new EntityField("SYS_Menu", 11, "IconIndex", SqlDbType.Int, false, false, false, true); }
		}

		public static EntityField IconName
		{
			get { return new EntityField("SYS_Menu", 12, "IconName", SqlDbType.NVarChar, false, false, false, true); }
		}

		public static EntityField IconUrl
		{
			get { return new EntityField("SYS_Menu", 13, "IconUrl", SqlDbType.NVarChar, false, false, false, true); }
		}

		public static EntityField IconData
		{
			get { return new EntityField("SYS_Menu", 14, "IconData", SqlDbType.Image, false, false, false, true); }
		}

		public static EntityField SmallImageIndex
		{
			get { return new EntityField("SYS_Menu", 15, "SmallImageIndex", SqlDbType.Int, false, false, false, true); }
		}

		public static EntityField SmallImageName
		{
			get { return new EntityField("SYS_Menu", 16, "SmallImageName", SqlDbType.NVarChar, false, false, false, true); }
		}

		public static EntityField SmallImageUrl
		{
			get { return new EntityField("SYS_Menu", 17, "SmallImageUrl", SqlDbType.NVarChar, false, false, false, true); }
		}

		public static EntityField SmallImageData
		{
			get { return new EntityField("SYS_Menu", 18, "SmallImageData", SqlDbType.Image, false, false, false, true); }
		}

		public static EntityField LargeImageIndex
		{
			get { return new EntityField("SYS_Menu", 19, "LargeImageIndex", SqlDbType.Int, false, false, false, true); }
		}

		public static EntityField LargeImageName
		{
			get { return new EntityField("SYS_Menu", 20, "LargeImageName", SqlDbType.NVarChar, false, false, false, true); }
		}

		public static EntityField LargeImageUrl
		{
			get { return new EntityField("SYS_Menu", 21, "LargeImageUrl", SqlDbType.NVarChar, false, false, false, true); }
		}

		public static EntityField LargeImageData
		{
			get { return new EntityField("SYS_Menu", 22, "LargeImageData", SqlDbType.Image, false, false, false, true); }
		}

		public static EntityField MenuDescription
		{
			get { return new EntityField("SYS_Menu", 23, "MenuDescription", SqlDbType.NVarChar, false, false, false, true); }
		}

		public static EntityField MenuRemark
		{
			get { return new EntityField("SYS_Menu", 24, "MenuRemark", SqlDbType.NVarChar, false, false, false, true); }
		}

		public static EntityField Reservation1
		{
			get { return new EntityField("SYS_Menu", 25, "Reservation1", SqlDbType.NVarChar, false, false, false, true); }
		}

		public static EntityField Reservation2
		{
			get { return new EntityField("SYS_Menu", 26, "Reservation2", SqlDbType.NVarChar, false, false, false, true); }
		}

		public static EntityField Reservation3
		{
			get { return new EntityField("SYS_Menu", 27, "Reservation3", SqlDbType.NVarChar, false, false, false, true); }
		}

		public static EntityField Reservation4
		{
			get { return new EntityField("SYS_Menu", 28, "Reservation4", SqlDbType.NVarChar, false, false, false, true); }
		}

		public static EntityField Reservation5
		{
			get { return new EntityField("SYS_Menu", 29, "Reservation5", SqlDbType.NVarChar, false, false, false, true); }
		}

	}

	#endregion

	#region SYSMenuEntityFields2

	public enum SYSMenuEntityFields2
	{
		MenuCode,

		MenuName,

		MenuTitle,

		SubTitle,

		IsEnabled,

		ParentCode,

		LevelNo,

		SortNumber,

		MenuUrl,

		MenuFullClass,

		PageCode,

		IconIndex,

		IconName,

		IconUrl,

		IconData,

		SmallImageIndex,

		SmallImageName,

		SmallImageUrl,

		SmallImageData,

		LargeImageIndex,

		LargeImageName,

		LargeImageUrl,

		LargeImageData,

		MenuDescription,

		MenuRemark,

		Reservation1,

		Reservation2,

		Reservation3,

		Reservation4,

		Reservation5,

	}

	#endregion

}
