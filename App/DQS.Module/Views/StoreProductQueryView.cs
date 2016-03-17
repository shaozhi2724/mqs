/*
 *	Build By: Codey Object Relation Mapping
 *	Build Data: 2014-03-04 22:32:22
 *	Build Type: View
 *	Description: StoreProductQueryView
*/

using System;
using System.Collections.Generic;
using System.Data;
using ORMSCore;

namespace DQS.Module.Views
{
	public class StoreProductQueryView : ViewBase
	{
		public int 产品ID
		{
			get { return (int)this.GetValue("产品ID"); } 
			set { this.SetValue("产品ID", value); } 
		}

		public string 货位编号
		{
			get { return (string)this.GetValue("货位编号"); } 
			set { this.SetValue("货位编号", value); } 
		}

		public string 货位名称
		{
			get { return (string)this.GetValue("货位名称"); } 
			set { this.SetValue("货位名称", value); } 
		}

		public string 货位位置
		{
			get { return (string)this.GetValue("货位位置"); } 
			set { this.SetValue("货位位置", value); } 
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

		public string 产品名称Spell
		{
			get { return (string)this.GetValue("产品名称Spell"); } 
			set { this.SetValue("产品名称Spell", value); } 
		}

		public string 生产厂商
		{
			get { return (string)this.GetValue("生产厂商"); } 
			set { this.SetValue("生产厂商", value); } 
		}

		public string 生产厂商Spell
		{
			get { return (string)this.GetValue("生产厂商Spell"); } 
			set { this.SetValue("生产厂商Spell", value); } 
		}

		public string 规格型号
		{
			get { return (string)this.GetValue("规格型号"); } 
			set { this.SetValue("规格型号", value); } 
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

		public string 单位
		{
			get { return (string)this.GetValue("单位"); } 
			set { this.SetValue("单位", value); } 
		}

		public string 批号
		{
			get { return (string)this.GetValue("批号"); } 
			set { this.SetValue("批号", value); } 
		}

		public DateTime 生产日期
		{
			get { return (DateTime)this.GetValue("生产日期"); } 
			set { this.SetValue("生产日期", value); } 
		}

		public DateTime 有效期至
		{
			get { return (DateTime)this.GetValue("有效期至"); } 
			set { this.SetValue("有效期至", value); } 
		}

		public int 订单数量
		{
			get { return (int)this.GetValue("订单数量"); } 
			set { this.SetValue("订单数量", value); } 
		}

		public StoreProductQueryView()
		{
			this.ViewName = "vw_StoreProductQuery";
			this.Fields = new Dictionary<string, EntityField>();
			this.Fields.Add("产品ID", StoreProductQueryViewFields.产品ID);
			this.Fields.Add("货位编号", StoreProductQueryViewFields.货位编号);
			this.Fields.Add("货位名称", StoreProductQueryViewFields.货位名称);
			this.Fields.Add("货位位置", StoreProductQueryViewFields.货位位置);
			this.Fields.Add("产品编号", StoreProductQueryViewFields.产品编号);
			this.Fields.Add("产品名称", StoreProductQueryViewFields.产品名称);
			this.Fields.Add("产品名称Spell", StoreProductQueryViewFields.产品名称Spell);
			this.Fields.Add("生产厂商", StoreProductQueryViewFields.生产厂商);
			this.Fields.Add("生产厂商Spell", StoreProductQueryViewFields.生产厂商Spell);
			this.Fields.Add("规格型号", StoreProductQueryViewFields.规格型号);
			this.Fields.Add("剂型", StoreProductQueryViewFields.剂型);
			this.Fields.Add("产品类别", StoreProductQueryViewFields.产品类别);
			this.Fields.Add("单位", StoreProductQueryViewFields.单位);
			this.Fields.Add("批号", StoreProductQueryViewFields.批号);
			this.Fields.Add("生产日期", StoreProductQueryViewFields.生产日期);
			this.Fields.Add("有效期至", StoreProductQueryViewFields.有效期至);
			this.Fields.Add("订单数量", StoreProductQueryViewFields.订单数量);
		}
	}

	#region StoreProductQueryViewFields

	public class StoreProductQueryViewFields
	{
		public static EntityField 产品ID
		{
			get { return new EntityField("vw_StoreProductQuery", 0, "产品ID", SqlDbType.Int); }
		}

		public static EntityField 货位编号
		{
			get { return new EntityField("vw_StoreProductQuery", 1, "货位编号", SqlDbType.NVarChar); }
		}

		public static EntityField 货位名称
		{
			get { return new EntityField("vw_StoreProductQuery", 2, "货位名称", SqlDbType.NVarChar); }
		}

		public static EntityField 货位位置
		{
			get { return new EntityField("vw_StoreProductQuery", 3, "货位位置", SqlDbType.NVarChar); }
		}

		public static EntityField 产品编号
		{
			get { return new EntityField("vw_StoreProductQuery", 4, "产品编号", SqlDbType.NVarChar); }
		}

		public static EntityField 产品名称
		{
			get { return new EntityField("vw_StoreProductQuery", 5, "产品名称", SqlDbType.NVarChar); }
		}

		public static EntityField 产品名称Spell
		{
			get { return new EntityField("vw_StoreProductQuery", 6, "产品名称Spell", SqlDbType.NVarChar); }
		}

		public static EntityField 生产厂商
		{
			get { return new EntityField("vw_StoreProductQuery", 7, "生产厂商", SqlDbType.NVarChar); }
		}

		public static EntityField 生产厂商Spell
		{
			get { return new EntityField("vw_StoreProductQuery", 8, "生产厂商Spell", SqlDbType.NVarChar); }
		}

		public static EntityField 规格型号
		{
			get { return new EntityField("vw_StoreProductQuery", 9, "规格型号", SqlDbType.NVarChar); }
		}

		public static EntityField 剂型
		{
			get { return new EntityField("vw_StoreProductQuery", 10, "剂型", SqlDbType.NVarChar); }
		}

		public static EntityField 产品类别
		{
			get { return new EntityField("vw_StoreProductQuery", 11, "产品类别", SqlDbType.NVarChar); }
		}

		public static EntityField 单位
		{
			get { return new EntityField("vw_StoreProductQuery", 12, "单位", SqlDbType.NVarChar); }
		}

		public static EntityField 批号
		{
			get { return new EntityField("vw_StoreProductQuery", 13, "批号", SqlDbType.NVarChar); }
		}

		public static EntityField 生产日期
		{
			get { return new EntityField("vw_StoreProductQuery", 14, "生产日期", SqlDbType.DateTime); }
		}

		public static EntityField 有效期至
		{
			get { return new EntityField("vw_StoreProductQuery", 15, "有效期至", SqlDbType.DateTime); }
		}

		public static EntityField 订单数量
		{
			get { return new EntityField("vw_StoreProductQuery", 16, "订单数量", SqlDbType.Int); }
		}

	}

	#endregion

}
