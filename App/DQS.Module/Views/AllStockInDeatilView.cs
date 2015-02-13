﻿/*
 *	Build By: Codey Object Relation Mapping
 *	Build Data: 2014-03-04 22:32:22
 *	Build Type: View
 *	Description: AllStockInDeatilView
*/

using System;
using System.Collections.Generic;
using System.Data;
using ORMSCore;

namespace DQS.Module.Views
{
	public class AllStockInDeatilView : ViewBase
	{
		public int 入库单ID
		{
			get { return (int)this.GetValue("入库单ID"); } 
			set { this.SetValue("入库单ID", value); } 
		}

		public int 药品ID
		{
			get { return (int)this.GetValue("药品ID"); } 
			set { this.SetValue("药品ID", value); } 
		}

		public string 药品编号
		{
			get { return (string)this.GetValue("药品编号"); } 
			set { this.SetValue("药品编号", value); } 
		}

		public string 药品名称
		{
			get { return (string)this.GetValue("药品名称"); } 
			set { this.SetValue("药品名称", value); } 
		}

		public string 生产厂商
		{
			get { return (string)this.GetValue("生产厂商"); } 
			set { this.SetValue("生产厂商", value); } 
		}

		public string 规格
		{
			get { return (string)this.GetValue("规格"); } 
			set { this.SetValue("规格", value); } 
		}

		public string 剂型
		{
			get { return (string)this.GetValue("剂型"); } 
			set { this.SetValue("剂型", value); } 
		}

		public string 药品类别
		{
			get { return (string)this.GetValue("药品类别"); } 
			set { this.SetValue("药品类别", value); } 
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

		public int 验收合格数量
		{
			get { return (int)this.GetValue("验收合格数量"); } 
			set { this.SetValue("验收合格数量", value); } 
		}

		public int 入库数量
		{
			get { return (int)this.GetValue("入库数量"); } 
			set { this.SetValue("入库数量", value); } 
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

		public AllStockInDeatilView()
		{
			this.ViewName = "vw_AllStockInDeatil";
			this.Fields = new Dictionary<string, EntityField>();
			this.Fields.Add("入库单ID", AllStockInDeatilViewFields.入库单ID);
			this.Fields.Add("药品ID", AllStockInDeatilViewFields.药品ID);
			this.Fields.Add("药品编号", AllStockInDeatilViewFields.药品编号);
			this.Fields.Add("药品名称", AllStockInDeatilViewFields.药品名称);
			this.Fields.Add("生产厂商", AllStockInDeatilViewFields.生产厂商);
			this.Fields.Add("规格", AllStockInDeatilViewFields.规格);
			this.Fields.Add("剂型", AllStockInDeatilViewFields.剂型);
			this.Fields.Add("药品类别", AllStockInDeatilViewFields.药品类别);
			this.Fields.Add("单位", AllStockInDeatilViewFields.单位);
			this.Fields.Add("批号", AllStockInDeatilViewFields.批号);
			this.Fields.Add("生产日期", AllStockInDeatilViewFields.生产日期);
			this.Fields.Add("有效期至", AllStockInDeatilViewFields.有效期至);
			this.Fields.Add("订单数量", AllStockInDeatilViewFields.订单数量);
			this.Fields.Add("验收合格数量", AllStockInDeatilViewFields.验收合格数量);
			this.Fields.Add("入库数量", AllStockInDeatilViewFields.入库数量);
			this.Fields.Add("明细ID", AllStockInDeatilViewFields.明细ID);
			this.Fields.Add("货位编号", AllStockInDeatilViewFields.货位编号);
			this.Fields.Add("货位名称", AllStockInDeatilViewFields.货位名称);
			this.Fields.Add("货位位置", AllStockInDeatilViewFields.货位位置);
		}
	}

	#region AllStockInDeatilViewFields

	public class AllStockInDeatilViewFields
	{
		public static EntityField 入库单ID
		{
			get { return new EntityField("vw_AllStockInDeatil", 0, "入库单ID", SqlDbType.Int); }
		}

		public static EntityField 药品ID
		{
			get { return new EntityField("vw_AllStockInDeatil", 1, "药品ID", SqlDbType.Int); }
		}

		public static EntityField 药品编号
		{
			get { return new EntityField("vw_AllStockInDeatil", 2, "药品编号", SqlDbType.NVarChar); }
		}

		public static EntityField 药品名称
		{
			get { return new EntityField("vw_AllStockInDeatil", 3, "药品名称", SqlDbType.NVarChar); }
		}

		public static EntityField 生产厂商
		{
			get { return new EntityField("vw_AllStockInDeatil", 4, "生产厂商", SqlDbType.NVarChar); }
		}

		public static EntityField 规格
		{
			get { return new EntityField("vw_AllStockInDeatil", 5, "规格", SqlDbType.NVarChar); }
		}

		public static EntityField 剂型
		{
			get { return new EntityField("vw_AllStockInDeatil", 6, "剂型", SqlDbType.NVarChar); }
		}

		public static EntityField 药品类别
		{
			get { return new EntityField("vw_AllStockInDeatil", 7, "药品类别", SqlDbType.NVarChar); }
		}

		public static EntityField 单位
		{
			get { return new EntityField("vw_AllStockInDeatil", 8, "单位", SqlDbType.NVarChar); }
		}

		public static EntityField 批号
		{
			get { return new EntityField("vw_AllStockInDeatil", 9, "批号", SqlDbType.NVarChar); }
		}

		public static EntityField 生产日期
		{
			get { return new EntityField("vw_AllStockInDeatil", 10, "生产日期", SqlDbType.DateTime); }
		}

		public static EntityField 有效期至
		{
			get { return new EntityField("vw_AllStockInDeatil", 11, "有效期至", SqlDbType.DateTime); }
		}

		public static EntityField 订单数量
		{
			get { return new EntityField("vw_AllStockInDeatil", 12, "订单数量", SqlDbType.Int); }
		}

		public static EntityField 验收合格数量
		{
			get { return new EntityField("vw_AllStockInDeatil", 13, "验收合格数量", SqlDbType.Int); }
		}

		public static EntityField 入库数量
		{
			get { return new EntityField("vw_AllStockInDeatil", 14, "入库数量", SqlDbType.Int); }
		}

		public static EntityField 明细ID
		{
			get { return new EntityField("vw_AllStockInDeatil", 15, "明细ID", SqlDbType.Int); }
		}

		public static EntityField 货位编号
		{
			get { return new EntityField("vw_AllStockInDeatil", 16, "货位编号", SqlDbType.NVarChar); }
		}

		public static EntityField 货位名称
		{
			get { return new EntityField("vw_AllStockInDeatil", 17, "货位名称", SqlDbType.NVarChar); }
		}

		public static EntityField 货位位置
		{
			get { return new EntityField("vw_AllStockInDeatil", 18, "货位位置", SqlDbType.NVarChar); }
		}

	}

	#endregion

}
