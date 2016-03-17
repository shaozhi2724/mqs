/*
 *	Build By: Codey Object Relation Mapping
 *	Build Data: 2014-03-04 22:32:22
 *	Build Type: View
 *	Description: ProductQueryView
*/

using System;
using System.Collections.Generic;
using System.Data;
using ORMSCore;

namespace DQS.Module.Views
{
	public class ProductQueryView : ViewBase
	{
		public string 货位ID
		{
			get { return (string)this.GetValue("货位ID"); } 
			set { this.SetValue("货位ID", value); } 
		}

		public string 货位
		{
			get { return (string)this.GetValue("货位"); } 
			set { this.SetValue("货位", value); } 
		}

		public string 货位类型
		{
			get { return (string)this.GetValue("货位类型"); } 
			set { this.SetValue("货位类型", value); } 
		}

		public string 货区
		{
			get { return (string)this.GetValue("货区"); } 
			set { this.SetValue("货区", value); } 
		}

		public string 产品ID
		{
			get { return (string)this.GetValue("产品ID"); } 
			set { this.SetValue("产品ID", value); } 
		}

		public string 产品编号
		{
			get { return (string)this.GetValue("产品编号"); } 
			set { this.SetValue("产品编号", value); } 
		}

		public string 产品名称
		{
			get { return (string)this.GetValue("产品名称"); } 
			set { this.SetValue("产品名称", value); } 
		}

		public string 规格型号
		{
			get { return (string)this.GetValue("规格型号"); } 
			set { this.SetValue("规格型号", value); } 
		}

		public string 生产厂家
		{
			get { return (string)this.GetValue("生产厂家"); } 
			set { this.SetValue("生产厂家", value); } 
		}

		public string 注册证号
		{
			get { return (string)this.GetValue("注册证号"); } 
			set { this.SetValue("注册证号", value); } 
		}

		public string 包装规格
		{
			get { return (string)this.GetValue("包装规格型号"); } 
			set { this.SetValue("包装规格型号", value); } 
		}

		public string 单位
		{
			get { return (string)this.GetValue("单位"); } 
			set { this.SetValue("单位", value); } 
		}

		public string 剂型
		{
			get { return (string)this.GetValue("剂型"); } 
			set { this.SetValue("剂型", value); } 
		}

		public string 产品类别
		{
			get { return (string)this.GetValue("产品类别"); } 
			set { this.SetValue("产品类别", value); } 
		}

		public string 数量
		{
			get { return (string)this.GetValue("数量"); } 
			set { this.SetValue("数量", value); } 
		}

		public ProductQueryView()
		{
			this.ViewName = "vw_ProductQuery";
			this.Fields = new Dictionary<string, EntityField>();
			this.Fields.Add("货位ID", ProductQueryViewFields.货位ID);
			this.Fields.Add("货位", ProductQueryViewFields.货位);
			this.Fields.Add("货位类型", ProductQueryViewFields.货位类型);
			this.Fields.Add("货区", ProductQueryViewFields.货区);
			this.Fields.Add("产品ID", ProductQueryViewFields.产品ID);
			this.Fields.Add("产品编号", ProductQueryViewFields.产品编号);
			this.Fields.Add("产品名称", ProductQueryViewFields.产品名称);
			this.Fields.Add("规格型号", ProductQueryViewFields.规格型号);
			this.Fields.Add("生产厂家", ProductQueryViewFields.生产厂家);
			this.Fields.Add("注册证号", ProductQueryViewFields.注册证号);
			this.Fields.Add("包装规格型号", ProductQueryViewFields.包装规格);
			this.Fields.Add("单位", ProductQueryViewFields.单位);
			this.Fields.Add("剂型", ProductQueryViewFields.剂型);
			this.Fields.Add("产品类别", ProductQueryViewFields.产品类别);
			this.Fields.Add("数量", ProductQueryViewFields.数量);
		}
	}

	#region ProductQueryViewFields

	public class ProductQueryViewFields
	{
		public static EntityField 货位ID
		{
			get { return new EntityField("vw_ProductQuery", 0, "货位ID", SqlDbType.VarChar); }
		}

		public static EntityField 货位
		{
			get { return new EntityField("vw_ProductQuery", 1, "货位", SqlDbType.VarChar); }
		}

		public static EntityField 货位类型
		{
			get { return new EntityField("vw_ProductQuery", 2, "货位类型", SqlDbType.VarChar); }
		}

		public static EntityField 货区
		{
			get { return new EntityField("vw_ProductQuery", 3, "货区", SqlDbType.VarChar); }
		}

		public static EntityField 产品ID
		{
			get { return new EntityField("vw_ProductQuery", 4, "产品ID", SqlDbType.VarChar); }
		}

		public static EntityField 产品编号
		{
			get { return new EntityField("vw_ProductQuery", 5, "产品编号", SqlDbType.VarChar); }
		}

		public static EntityField 产品名称
		{
			get { return new EntityField("vw_ProductQuery", 6, "产品名称", SqlDbType.VarChar); }
		}

		public static EntityField 规格型号
		{
			get { return new EntityField("vw_ProductQuery", 7, "规格型号", SqlDbType.VarChar); }
		}

		public static EntityField 生产厂家
		{
			get { return new EntityField("vw_ProductQuery", 8, "生产厂家", SqlDbType.VarChar); }
		}

		public static EntityField 注册证号
		{
			get { return new EntityField("vw_ProductQuery", 9, "注册证号", SqlDbType.VarChar); }
		}

		public static EntityField 包装规格
		{
			get { return new EntityField("vw_ProductQuery", 10, "包装规格型号", SqlDbType.VarChar); }
		}

		public static EntityField 单位
		{
			get { return new EntityField("vw_ProductQuery", 11, "单位", SqlDbType.VarChar); }
		}

		public static EntityField 剂型
		{
			get { return new EntityField("vw_ProductQuery", 12, "剂型", SqlDbType.VarChar); }
		}

		public static EntityField 产品类别
		{
			get { return new EntityField("vw_ProductQuery", 13, "产品类别", SqlDbType.VarChar); }
		}

		public static EntityField 数量
		{
			get { return new EntityField("vw_ProductQuery", 14, "数量", SqlDbType.VarChar); }
		}

	}

	#endregion

}
