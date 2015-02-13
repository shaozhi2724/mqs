/*
 *	Build By: Codey Object Relation Mapping
 *	Build Data: 2014-03-04 22:32:22
 *	Build Type: View
 *	Description: AllStructureForProductView
*/

using System;
using System.Collections.Generic;
using System.Data;
using ORMSCore;

namespace DQS.Module.Views
{
	public class AllStructureForProductView : ViewBase
	{
		public int 存储ID
		{
			get { return (int)this.GetValue("存储ID"); } 
			set { this.SetValue("存储ID", value); } 
		}

		public string 存储编号
		{
			get { return (string)this.GetValue("存储编号"); } 
			set { this.SetValue("存储编号", value); } 
		}

		public string 存储名称
		{
			get { return (string)this.GetValue("存储名称"); } 
			set { this.SetValue("存储名称", value); } 
		}

		public string 存储名称Spell
		{
			get { return (string)this.GetValue("存储名称Spell"); } 
			set { this.SetValue("存储名称Spell", value); } 
		}

		public string 所属仓库
		{
			get { return (string)this.GetValue("所属仓库"); } 
			set { this.SetValue("所属仓库", value); } 
		}

		public string 存储类型
		{
			get { return (string)this.GetValue("存储类型"); } 
			set { this.SetValue("存储类型", value); } 
		}

		public string 存储位置
		{
			get { return (string)this.GetValue("存储位置"); } 
			set { this.SetValue("存储位置", value); } 
		}

		public string 条码
		{
			get { return (string)this.GetValue("条码"); } 
			set { this.SetValue("条码", value); } 
		}

		public AllStructureForProductView()
		{
			this.ViewName = "vw_AllStructureForProduct";
			this.Fields = new Dictionary<string, EntityField>();
			this.Fields.Add("存储ID", AllStructureForProductViewFields.存储ID);
			this.Fields.Add("存储编号", AllStructureForProductViewFields.存储编号);
			this.Fields.Add("存储名称", AllStructureForProductViewFields.存储名称);
			this.Fields.Add("存储名称Spell", AllStructureForProductViewFields.存储名称Spell);
			this.Fields.Add("所属仓库", AllStructureForProductViewFields.所属仓库);
			this.Fields.Add("存储类型", AllStructureForProductViewFields.存储类型);
			this.Fields.Add("存储位置", AllStructureForProductViewFields.存储位置);
			this.Fields.Add("条码", AllStructureForProductViewFields.条码);
		}
	}

	#region AllStructureForProductViewFields

	public class AllStructureForProductViewFields
	{
		public static EntityField 存储ID
		{
			get { return new EntityField("vw_AllStructureForProduct", 0, "存储ID", SqlDbType.Int); }
		}

		public static EntityField 存储编号
		{
			get { return new EntityField("vw_AllStructureForProduct", 1, "存储编号", SqlDbType.NVarChar); }
		}

		public static EntityField 存储名称
		{
			get { return new EntityField("vw_AllStructureForProduct", 2, "存储名称", SqlDbType.NVarChar); }
		}

		public static EntityField 存储名称Spell
		{
			get { return new EntityField("vw_AllStructureForProduct", 3, "存储名称Spell", SqlDbType.NVarChar); }
		}

		public static EntityField 所属仓库
		{
			get { return new EntityField("vw_AllStructureForProduct", 4, "所属仓库", SqlDbType.NVarChar); }
		}

		public static EntityField 存储类型
		{
			get { return new EntityField("vw_AllStructureForProduct", 5, "存储类型", SqlDbType.NVarChar); }
		}

		public static EntityField 存储位置
		{
			get { return new EntityField("vw_AllStructureForProduct", 6, "存储位置", SqlDbType.NVarChar); }
		}

		public static EntityField 条码
		{
			get { return new EntityField("vw_AllStructureForProduct", 7, "条码", SqlDbType.NVarChar); }
		}

	}

	#endregion

}
