/*
 *	Build By: Codey Object Relation Mapping
 *	Build Data: 2014-03-04 22:32:22
 *	Build Type: View
 *	Description: AllStockInView
*/

using System;
using System.Collections.Generic;
using System.Data;
using ORMSCore;

namespace DQS.Module.Views
{
	public class AllStockInView : ViewBase
	{
		public int 入库单ID
		{
			get { return (int)this.GetValue("入库单ID"); } 
			set { this.SetValue("入库单ID", value); } 
		}

		public string 入库单号
		{
			get { return (string)this.GetValue("入库单号"); } 
			set { this.SetValue("入库单号", value); } 
		}

		public string 入库员
		{
			get { return (string)this.GetValue("入库员"); } 
			set { this.SetValue("入库员", value); } 
		}

		public DateTime 入库日期
		{
			get { return (DateTime)this.GetValue("入库日期"); } 
			set { this.SetValue("入库日期", value); } 
		}

		public int 订单ID
		{
			get { return (int)this.GetValue("订单ID"); } 
			set { this.SetValue("订单ID", value); } 
		}

		public string 订单编号
		{
			get { return (string)this.GetValue("订单编号"); } 
			set { this.SetValue("订单编号", value); } 
		}

		public DateTime 下单日期
		{
			get { return (DateTime)this.GetValue("下单日期"); } 
			set { this.SetValue("下单日期", value); } 
		}

		public string 订单类型
		{
			get { return (string)this.GetValue("订单类型"); } 
			set { this.SetValue("订单类型", value); } 
		}

		public string 往来单位名称
		{
			get { return (string)this.GetValue("往来单位名称"); } 
			set { this.SetValue("往来单位名称", value); } 
		}

		public string 创建人
		{
			get { return (string)this.GetValue("创建人"); } 
			set { this.SetValue("创建人", value); } 
		}

		public DateTime 创建日期
		{
			get { return (DateTime)this.GetValue("创建日期"); } 
			set { this.SetValue("创建日期", value); } 
		}

		public string 最后修改人
		{
			get { return (string)this.GetValue("最后修改人"); } 
			set { this.SetValue("最后修改人", value); } 
		}

		public DateTime 最后修改时间
		{
			get { return (DateTime)this.GetValue("最后修改时间"); } 
			set { this.SetValue("最后修改时间", value); } 
		}

		public string 备注
		{
			get { return (string)this.GetValue("备注"); } 
			set { this.SetValue("备注", value); } 
		}

		public AllStockInView()
		{
			this.ViewName = "vw_AllStockIn";
			this.Fields = new Dictionary<string, EntityField>();
			this.Fields.Add("入库单ID", AllStockInViewFields.入库单ID);
			this.Fields.Add("入库单号", AllStockInViewFields.入库单号);
			this.Fields.Add("入库员", AllStockInViewFields.入库员);
			this.Fields.Add("入库日期", AllStockInViewFields.入库日期);
			this.Fields.Add("订单ID", AllStockInViewFields.订单ID);
			this.Fields.Add("订单编号", AllStockInViewFields.订单编号);
			this.Fields.Add("下单日期", AllStockInViewFields.下单日期);
			this.Fields.Add("订单类型", AllStockInViewFields.订单类型);
			this.Fields.Add("往来单位名称", AllStockInViewFields.往来单位名称);
			this.Fields.Add("创建人", AllStockInViewFields.创建人);
			this.Fields.Add("创建日期", AllStockInViewFields.创建日期);
			this.Fields.Add("最后修改人", AllStockInViewFields.最后修改人);
			this.Fields.Add("最后修改时间", AllStockInViewFields.最后修改时间);
			this.Fields.Add("备注", AllStockInViewFields.备注);
		}
	}

	#region AllStockInViewFields

	public class AllStockInViewFields
	{
		public static EntityField 入库单ID
		{
			get { return new EntityField("vw_AllStockIn", 0, "入库单ID", SqlDbType.Int); }
		}

		public static EntityField 入库单号
		{
			get { return new EntityField("vw_AllStockIn", 1, "入库单号", SqlDbType.NVarChar); }
		}

		public static EntityField 入库员
		{
			get { return new EntityField("vw_AllStockIn", 2, "入库员", SqlDbType.NVarChar); }
		}

		public static EntityField 入库日期
		{
			get { return new EntityField("vw_AllStockIn", 3, "入库日期", SqlDbType.DateTime); }
		}

		public static EntityField 订单ID
		{
			get { return new EntityField("vw_AllStockIn", 4, "订单ID", SqlDbType.Int); }
		}

		public static EntityField 订单编号
		{
			get { return new EntityField("vw_AllStockIn", 5, "订单编号", SqlDbType.NVarChar); }
		}

		public static EntityField 下单日期
		{
			get { return new EntityField("vw_AllStockIn", 6, "下单日期", SqlDbType.DateTime); }
		}

		public static EntityField 订单类型
		{
			get { return new EntityField("vw_AllStockIn", 7, "订单类型", SqlDbType.NVarChar); }
		}

		public static EntityField 往来单位名称
		{
			get { return new EntityField("vw_AllStockIn", 8, "往来单位名称", SqlDbType.NVarChar); }
		}

		public static EntityField 创建人
		{
			get { return new EntityField("vw_AllStockIn", 9, "创建人", SqlDbType.NVarChar); }
		}

		public static EntityField 创建日期
		{
			get { return new EntityField("vw_AllStockIn", 10, "创建日期", SqlDbType.DateTime); }
		}

		public static EntityField 最后修改人
		{
			get { return new EntityField("vw_AllStockIn", 11, "最后修改人", SqlDbType.NVarChar); }
		}

		public static EntityField 最后修改时间
		{
			get { return new EntityField("vw_AllStockIn", 12, "最后修改时间", SqlDbType.DateTime); }
		}

		public static EntityField 备注
		{
			get { return new EntityField("vw_AllStockIn", 13, "备注", SqlDbType.NVarChar); }
		}

	}

	#endregion

}
