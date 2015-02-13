/*
 *	Build By: Codey Object Relation Mapping
 *	Build Data: 2014-03-04 22:32:22
 *	Build Type: View
 *	Description: AllSaleBackView
*/

using System;
using System.Collections.Generic;
using System.Data;
using ORMSCore;

namespace DQS.Module.Views
{
	public class AllSaleBackView : ViewBase
	{
		public int 退货单ID
		{
			get { return (int)this.GetValue("退货单ID"); } 
			set { this.SetValue("退货单ID", value); } 
		}

		public string 退货单编号
		{
			get { return (string)this.GetValue("退货单编号"); } 
			set { this.SetValue("退货单编号", value); } 
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

		public string 收货地址
		{
			get { return (string)this.GetValue("收货地址"); } 
			set { this.SetValue("收货地址", value); } 
		}

		public string 收货人
		{
			get { return (string)this.GetValue("收货人"); } 
			set { this.SetValue("收货人", value); } 
		}

		public string 收货人电话
		{
			get { return (string)this.GetValue("收货人电话"); } 
			set { this.SetValue("收货人电话", value); } 
		}

		public double 订单总额
		{
			get { return (double)this.GetValue("订单总额"); } 
			set { this.SetValue("订单总额", value); } 
		}

		public string 付款方式
		{
			get { return (string)this.GetValue("付款方式"); } 
			set { this.SetValue("付款方式", value); } 
		}

		public string 配送方式
		{
			get { return (string)this.GetValue("配送方式"); } 
			set { this.SetValue("配送方式", value); } 
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

		public AllSaleBackView()
		{
			this.ViewName = "vw_AllSaleBack";
			this.Fields = new Dictionary<string, EntityField>();
			this.Fields.Add("退货单ID", AllSaleBackViewFields.退货单ID);
			this.Fields.Add("退货单编号", AllSaleBackViewFields.退货单编号);
			this.Fields.Add("下单日期", AllSaleBackViewFields.下单日期);
			this.Fields.Add("状态", AllSaleBackViewFields.状态);
			this.Fields.Add("往来单位编号", AllSaleBackViewFields.往来单位编号);
			this.Fields.Add("往来单位名称", AllSaleBackViewFields.往来单位名称);
			this.Fields.Add("收货地址", AllSaleBackViewFields.收货地址);
			this.Fields.Add("收货人", AllSaleBackViewFields.收货人);
			this.Fields.Add("收货人电话", AllSaleBackViewFields.收货人电话);
			this.Fields.Add("订单总额", AllSaleBackViewFields.订单总额);
			this.Fields.Add("付款方式", AllSaleBackViewFields.付款方式);
			this.Fields.Add("配送方式", AllSaleBackViewFields.配送方式);
			this.Fields.Add("创建人", AllSaleBackViewFields.创建人);
			this.Fields.Add("创建日期", AllSaleBackViewFields.创建日期);
			this.Fields.Add("最后修改人", AllSaleBackViewFields.最后修改人);
			this.Fields.Add("最后修改时间", AllSaleBackViewFields.最后修改时间);
			this.Fields.Add("备注", AllSaleBackViewFields.备注);
		}
	}

	#region AllSaleBackViewFields

	public class AllSaleBackViewFields
	{
		public static EntityField 退货单ID
		{
			get { return new EntityField("vw_AllSaleBack", 0, "退货单ID", SqlDbType.Int); }
		}

		public static EntityField 退货单编号
		{
			get { return new EntityField("vw_AllSaleBack", 1, "退货单编号", SqlDbType.NVarChar); }
		}

		public static EntityField 下单日期
		{
			get { return new EntityField("vw_AllSaleBack", 2, "下单日期", SqlDbType.DateTime); }
		}

		public static EntityField 状态
		{
			get { return new EntityField("vw_AllSaleBack", 3, "状态", SqlDbType.NVarChar); }
		}

		public static EntityField 往来单位编号
		{
			get { return new EntityField("vw_AllSaleBack", 4, "往来单位编号", SqlDbType.NVarChar); }
		}

		public static EntityField 往来单位名称
		{
			get { return new EntityField("vw_AllSaleBack", 5, "往来单位名称", SqlDbType.NVarChar); }
		}

		public static EntityField 收货地址
		{
			get { return new EntityField("vw_AllSaleBack", 6, "收货地址", SqlDbType.NVarChar); }
		}

		public static EntityField 收货人
		{
			get { return new EntityField("vw_AllSaleBack", 7, "收货人", SqlDbType.NVarChar); }
		}

		public static EntityField 收货人电话
		{
			get { return new EntityField("vw_AllSaleBack", 8, "收货人电话", SqlDbType.NVarChar); }
		}

		public static EntityField 订单总额
		{
			get { return new EntityField("vw_AllSaleBack", 9, "订单总额", SqlDbType.Float); }
		}

		public static EntityField 付款方式
		{
			get { return new EntityField("vw_AllSaleBack", 10, "付款方式", SqlDbType.NVarChar); }
		}

		public static EntityField 配送方式
		{
			get { return new EntityField("vw_AllSaleBack", 11, "配送方式", SqlDbType.NVarChar); }
		}

		public static EntityField 创建人
		{
			get { return new EntityField("vw_AllSaleBack", 12, "创建人", SqlDbType.NVarChar); }
		}

		public static EntityField 创建日期
		{
			get { return new EntityField("vw_AllSaleBack", 13, "创建日期", SqlDbType.DateTime); }
		}

		public static EntityField 最后修改人
		{
			get { return new EntityField("vw_AllSaleBack", 14, "最后修改人", SqlDbType.NVarChar); }
		}

		public static EntityField 最后修改时间
		{
			get { return new EntityField("vw_AllSaleBack", 15, "最后修改时间", SqlDbType.DateTime); }
		}

		public static EntityField 备注
		{
			get { return new EntityField("vw_AllSaleBack", 16, "备注", SqlDbType.NVarChar); }
		}

	}

	#endregion

}
