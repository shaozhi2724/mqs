/*
 *	Build By: Codey Object Relation Mapping
 *	Build Data: 2014-03-04 22:32:22
 *	Build Type: View
 *	Description: AllWarehouseInBillView
*/

using System;
using System.Collections.Generic;
using System.Data;
using ORMSCore;

namespace DQS.Module.Views
{
	public class AllWarehouseInBillView : ViewBase
	{
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

		public string 状态
		{
			get { return (string)this.GetValue("状态"); } 
			set { this.SetValue("状态", value); } 
		}

		public int 订单类型ID
		{
			get { return (int)this.GetValue("订单类型ID"); } 
			set { this.SetValue("订单类型ID", value); } 
		}

		public string 订单类型
		{
			get { return (string)this.GetValue("订单类型"); } 
			set { this.SetValue("订单类型", value); } 
		}

		public string 订单类型Spell
		{
			get { return (string)this.GetValue("订单类型Spell"); } 
			set { this.SetValue("订单类型Spell", value); } 
		}

		public int 往来单位ID
		{
			get { return (int)this.GetValue("往来单位ID"); } 
			set { this.SetValue("往来单位ID", value); } 
		}

		public string 往来单位编号
		{
			get { return (string)this.GetValue("往来单位编号"); } 
			set { this.SetValue("往来单位编号", value); } 
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

		public AllWarehouseInBillView()
		{
			this.ViewName = "vw_AllWarehouseInBill";
			this.Fields = new Dictionary<string, EntityField>();
			this.Fields.Add("订单ID", AllWarehouseInBillViewFields.订单ID);
			this.Fields.Add("订单编号", AllWarehouseInBillViewFields.订单编号);
			this.Fields.Add("下单日期", AllWarehouseInBillViewFields.下单日期);
			this.Fields.Add("状态", AllWarehouseInBillViewFields.状态);
			this.Fields.Add("订单类型ID", AllWarehouseInBillViewFields.订单类型ID);
			this.Fields.Add("订单类型", AllWarehouseInBillViewFields.订单类型);
			this.Fields.Add("订单类型Spell", AllWarehouseInBillViewFields.订单类型Spell);
			this.Fields.Add("往来单位ID", AllWarehouseInBillViewFields.往来单位ID);
			this.Fields.Add("往来单位编号", AllWarehouseInBillViewFields.往来单位编号);
			this.Fields.Add("往来单位名称", AllWarehouseInBillViewFields.往来单位名称);
			this.Fields.Add("创建人", AllWarehouseInBillViewFields.创建人);
			this.Fields.Add("创建日期", AllWarehouseInBillViewFields.创建日期);
			this.Fields.Add("最后修改人", AllWarehouseInBillViewFields.最后修改人);
			this.Fields.Add("最后修改时间", AllWarehouseInBillViewFields.最后修改时间);
		}
	}

	#region AllWarehouseInBillViewFields

	public class AllWarehouseInBillViewFields
	{
		public static EntityField 订单ID
		{
			get { return new EntityField("vw_AllWarehouseInBill", 0, "订单ID", SqlDbType.Int); }
		}

		public static EntityField 订单编号
		{
			get { return new EntityField("vw_AllWarehouseInBill", 1, "订单编号", SqlDbType.NVarChar); }
		}

		public static EntityField 下单日期
		{
			get { return new EntityField("vw_AllWarehouseInBill", 2, "下单日期", SqlDbType.DateTime); }
		}

		public static EntityField 状态
		{
			get { return new EntityField("vw_AllWarehouseInBill", 3, "状态", SqlDbType.NVarChar); }
		}

		public static EntityField 订单类型ID
		{
			get { return new EntityField("vw_AllWarehouseInBill", 4, "订单类型ID", SqlDbType.Int); }
		}

		public static EntityField 订单类型
		{
			get { return new EntityField("vw_AllWarehouseInBill", 5, "订单类型", SqlDbType.NVarChar); }
		}

		public static EntityField 订单类型Spell
		{
			get { return new EntityField("vw_AllWarehouseInBill", 6, "订单类型Spell", SqlDbType.NVarChar); }
		}

		public static EntityField 往来单位ID
		{
			get { return new EntityField("vw_AllWarehouseInBill", 7, "往来单位ID", SqlDbType.Int); }
		}

		public static EntityField 往来单位编号
		{
			get { return new EntityField("vw_AllWarehouseInBill", 8, "往来单位编号", SqlDbType.NVarChar); }
		}

		public static EntityField 往来单位名称
		{
			get { return new EntityField("vw_AllWarehouseInBill", 9, "往来单位名称", SqlDbType.NVarChar); }
		}

		public static EntityField 创建人
		{
			get { return new EntityField("vw_AllWarehouseInBill", 10, "创建人", SqlDbType.NVarChar); }
		}

		public static EntityField 创建日期
		{
			get { return new EntityField("vw_AllWarehouseInBill", 11, "创建日期", SqlDbType.DateTime); }
		}

		public static EntityField 最后修改人
		{
			get { return new EntityField("vw_AllWarehouseInBill", 12, "最后修改人", SqlDbType.NVarChar); }
		}

		public static EntityField 最后修改时间
		{
			get { return new EntityField("vw_AllWarehouseInBill", 13, "最后修改时间", SqlDbType.DateTime); }
		}

	}

	#endregion

}
