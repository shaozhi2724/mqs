/*
 *	Build By: Codey Object Relation Mapping
 *	Build Data: 2014-03-04 22:32:22
 *	Build Type: View
 *	Description: AllStockOutDeatilView
*/

using System;
using System.Collections.Generic;
using System.Data;
using ORMSCore;

namespace DQS.Module.Views
{
	public class AllStockOutDeatilView : ViewBase
	{
		public int 出库单ID
		{
			get { return (int)this.GetValue("出库单ID"); } 
			set { this.SetValue("出库单ID", value); } 
		}

		public int 订单ID
		{
			get { return (int)this.GetValue("订单ID"); } 
			set { this.SetValue("订单ID", value); } 
		}

		public int 产品ID
		{
			get { return (int)this.GetValue("产品ID"); } 
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

		public string 生产厂商
		{
			get { return (string)this.GetValue("生产厂商"); } 
			set { this.SetValue("生产厂商", value); } 
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

		public int 订单数量
		{
			get { return (int)this.GetValue("订单数量"); } 
			set { this.SetValue("订单数量", value); } 
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

		public int 出库数量
		{
			get { return (int)this.GetValue("出库数量"); } 
			set { this.SetValue("出库数量", value); } 
		}

		public int 明细ID
		{
			get { return (int)this.GetValue("明细ID"); } 
			set { this.SetValue("明细ID", value); } 
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

		public AllStockOutDeatilView()
		{
			this.ViewName = "vw_AllStockOutDeatil";
			this.Fields = new Dictionary<string, EntityField>();
			this.Fields.Add("出库单ID", AllStockOutDeatilViewFields.出库单ID);
			this.Fields.Add("订单ID", AllStockOutDeatilViewFields.订单ID);
			this.Fields.Add("产品ID", AllStockOutDeatilViewFields.产品ID);
			this.Fields.Add("产品编号", AllStockOutDeatilViewFields.产品编号);
			this.Fields.Add("产品名称", AllStockOutDeatilViewFields.产品名称);
			this.Fields.Add("生产厂商", AllStockOutDeatilViewFields.生产厂商);
			this.Fields.Add("规格型号", AllStockOutDeatilViewFields.规格型号);
			this.Fields.Add("剂型", AllStockOutDeatilViewFields.剂型);
			this.Fields.Add("产品类别", AllStockOutDeatilViewFields.产品类别);
			this.Fields.Add("单位", AllStockOutDeatilViewFields.单位);
			this.Fields.Add("订单数量", AllStockOutDeatilViewFields.订单数量);
			this.Fields.Add("批号", AllStockOutDeatilViewFields.批号);
			this.Fields.Add("生产日期", AllStockOutDeatilViewFields.生产日期);
			this.Fields.Add("有效期至", AllStockOutDeatilViewFields.有效期至);
			this.Fields.Add("出库数量", AllStockOutDeatilViewFields.出库数量);
			this.Fields.Add("明细ID", AllStockOutDeatilViewFields.明细ID);
			this.Fields.Add("货位编号", AllStockOutDeatilViewFields.货位编号);
			this.Fields.Add("货位名称", AllStockOutDeatilViewFields.货位名称);
			this.Fields.Add("货位位置", AllStockOutDeatilViewFields.货位位置);
		}
	}

	#region AllStockOutDeatilViewFields

	public class AllStockOutDeatilViewFields
	{
		public static EntityField 出库单ID
		{
			get { return new EntityField("vw_AllStockOutDeatil", 0, "出库单ID", SqlDbType.Int); }
		}

		public static EntityField 订单ID
		{
			get { return new EntityField("vw_AllStockOutDeatil", 1, "订单ID", SqlDbType.Int); }
		}

		public static EntityField 产品ID
		{
			get { return new EntityField("vw_AllStockOutDeatil", 2, "产品ID", SqlDbType.Int); }
		}

		public static EntityField 产品编号
		{
			get { return new EntityField("vw_AllStockOutDeatil", 3, "产品编号", SqlDbType.NVarChar); }
		}

		public static EntityField 产品名称
		{
			get { return new EntityField("vw_AllStockOutDeatil", 4, "产品名称", SqlDbType.NVarChar); }
		}

		public static EntityField 生产厂商
		{
			get { return new EntityField("vw_AllStockOutDeatil", 5, "生产厂商", SqlDbType.NVarChar); }
		}

		public static EntityField 规格型号
		{
			get { return new EntityField("vw_AllStockOutDeatil", 6, "规格型号", SqlDbType.NVarChar); }
		}

		public static EntityField 剂型
		{
			get { return new EntityField("vw_AllStockOutDeatil", 7, "剂型", SqlDbType.NVarChar); }
		}

		public static EntityField 产品类别
		{
			get { return new EntityField("vw_AllStockOutDeatil", 8, "产品类别", SqlDbType.NVarChar); }
		}

		public static EntityField 单位
		{
			get { return new EntityField("vw_AllStockOutDeatil", 9, "单位", SqlDbType.NVarChar); }
		}

		public static EntityField 订单数量
		{
			get { return new EntityField("vw_AllStockOutDeatil", 10, "订单数量", SqlDbType.Int); }
		}

		public static EntityField 批号
		{
			get { return new EntityField("vw_AllStockOutDeatil", 11, "批号", SqlDbType.NVarChar); }
		}

		public static EntityField 生产日期
		{
			get { return new EntityField("vw_AllStockOutDeatil", 12, "生产日期", SqlDbType.DateTime); }
		}

		public static EntityField 有效期至
		{
			get { return new EntityField("vw_AllStockOutDeatil", 13, "有效期至", SqlDbType.DateTime); }
		}

		public static EntityField 出库数量
		{
			get { return new EntityField("vw_AllStockOutDeatil", 14, "出库数量", SqlDbType.Int); }
		}

		public static EntityField 明细ID
		{
			get { return new EntityField("vw_AllStockOutDeatil", 15, "明细ID", SqlDbType.Int); }
		}

		public static EntityField 货位编号
		{
			get { return new EntityField("vw_AllStockOutDeatil", 16, "货位编号", SqlDbType.NVarChar); }
		}

		public static EntityField 货位名称
		{
			get { return new EntityField("vw_AllStockOutDeatil", 17, "货位名称", SqlDbType.NVarChar); }
		}

		public static EntityField 货位位置
		{
			get { return new EntityField("vw_AllStockOutDeatil", 18, "货位位置", SqlDbType.NVarChar); }
		}

	}

	#endregion

}
