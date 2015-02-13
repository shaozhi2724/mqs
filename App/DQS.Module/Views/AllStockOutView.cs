/*
 *	Build By: Codey Object Relation Mapping
 *	Build Data: 2014-03-04 22:32:22
 *	Build Type: View
 *	Description: AllStockOutView
*/

using System;
using System.Collections.Generic;
using System.Data;
using ORMSCore;

namespace DQS.Module.Views
{
	public class AllStockOutView : ViewBase
	{
		public int 出库单ID
		{
			get { return (int)this.GetValue("出库单ID"); } 
			set { this.SetValue("出库单ID", value); } 
		}

		public string 出库单号
		{
			get { return (string)this.GetValue("出库单号"); } 
			set { this.SetValue("出库单号", value); } 
		}

		public string 出库员
		{
			get { return (string)this.GetValue("出库员"); } 
			set { this.SetValue("出库员", value); } 
		}

		public DateTime 出库日期
		{
			get { return (DateTime)this.GetValue("出库日期"); } 
			set { this.SetValue("出库日期", value); } 
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

		public AllStockOutView()
		{
			this.ViewName = "vw_AllStockOut";
			this.Fields = new Dictionary<string, EntityField>();
			this.Fields.Add("出库单ID", AllStockOutViewFields.出库单ID);
			this.Fields.Add("出库单号", AllStockOutViewFields.出库单号);
			this.Fields.Add("出库员", AllStockOutViewFields.出库员);
			this.Fields.Add("出库日期", AllStockOutViewFields.出库日期);
			this.Fields.Add("订单ID", AllStockOutViewFields.订单ID);
			this.Fields.Add("订单编号", AllStockOutViewFields.订单编号);
			this.Fields.Add("下单日期", AllStockOutViewFields.下单日期);
			this.Fields.Add("订单类型", AllStockOutViewFields.订单类型);
			this.Fields.Add("往来单位名称", AllStockOutViewFields.往来单位名称);
			this.Fields.Add("创建人", AllStockOutViewFields.创建人);
			this.Fields.Add("创建日期", AllStockOutViewFields.创建日期);
			this.Fields.Add("最后修改人", AllStockOutViewFields.最后修改人);
			this.Fields.Add("最后修改时间", AllStockOutViewFields.最后修改时间);
			this.Fields.Add("备注", AllStockOutViewFields.备注);
		}
	}

	#region AllStockOutViewFields

	public class AllStockOutViewFields
	{
		public static EntityField 出库单ID
		{
			get { return new EntityField("vw_AllStockOut", 0, "出库单ID", SqlDbType.Int); }
		}

		public static EntityField 出库单号
		{
			get { return new EntityField("vw_AllStockOut", 1, "出库单号", SqlDbType.NVarChar); }
		}

		public static EntityField 出库员
		{
			get { return new EntityField("vw_AllStockOut", 2, "出库员", SqlDbType.NVarChar); }
		}

		public static EntityField 出库日期
		{
			get { return new EntityField("vw_AllStockOut", 3, "出库日期", SqlDbType.DateTime); }
		}

		public static EntityField 订单ID
		{
			get { return new EntityField("vw_AllStockOut", 4, "订单ID", SqlDbType.Int); }
		}

		public static EntityField 订单编号
		{
			get { return new EntityField("vw_AllStockOut", 5, "订单编号", SqlDbType.NVarChar); }
		}

		public static EntityField 下单日期
		{
			get { return new EntityField("vw_AllStockOut", 6, "下单日期", SqlDbType.DateTime); }
		}

		public static EntityField 订单类型
		{
			get { return new EntityField("vw_AllStockOut", 7, "订单类型", SqlDbType.NVarChar); }
		}

		public static EntityField 往来单位名称
		{
			get { return new EntityField("vw_AllStockOut", 8, "往来单位名称", SqlDbType.NVarChar); }
		}

		public static EntityField 创建人
		{
			get { return new EntityField("vw_AllStockOut", 9, "创建人", SqlDbType.NVarChar); }
		}

		public static EntityField 创建日期
		{
			get { return new EntityField("vw_AllStockOut", 10, "创建日期", SqlDbType.DateTime); }
		}

		public static EntityField 最后修改人
		{
			get { return new EntityField("vw_AllStockOut", 11, "最后修改人", SqlDbType.NVarChar); }
		}

		public static EntityField 最后修改时间
		{
			get { return new EntityField("vw_AllStockOut", 12, "最后修改时间", SqlDbType.DateTime); }
		}

		public static EntityField 备注
		{
			get { return new EntityField("vw_AllStockOut", 13, "备注", SqlDbType.NVarChar); }
		}

	}

	#endregion

}
