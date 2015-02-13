/*
 *	Build By: Codey Object Relation Mapping
 *	Build Data: 2014-03-04 22:32:22
 *	Build Type: View
 *	Description: AllSaleView
*/

using System;
using System.Collections.Generic;
using System.Data;
using ORMSCore;

namespace DQS.Module.Views
{
	public class AllSaleView : ViewBase
	{
		public int 销售单ID
		{
			get { return (int)this.GetValue("销售单ID"); } 
			set { this.SetValue("销售单ID", value); } 
		}

		public string 销售单号
		{
			get { return (string)this.GetValue("销售单号"); } 
			set { this.SetValue("销售单号", value); } 
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

		public string 往来单位Spell
		{
			get { return (string)this.GetValue("往来单位Spell"); } 
			set { this.SetValue("往来单位Spell", value); } 
		}

		public string 收货地址
		{
			get { return (string)this.GetValue("收货地址"); } 
			set { this.SetValue("收货地址", value); } 
		}

		public string 联系人
		{
			get { return (string)this.GetValue("联系人"); } 
			set { this.SetValue("联系人", value); } 
		}

		public string 联系方式
		{
			get { return (string)this.GetValue("联系方式"); } 
			set { this.SetValue("联系方式", value); } 
		}

		public string 配送方式
		{
			get { return (string)this.GetValue("配送方式"); } 
			set { this.SetValue("配送方式", value); } 
		}

		public string 付款方式
		{
			get { return (string)this.GetValue("付款方式"); } 
			set { this.SetValue("付款方式", value); } 
		}

		public double 订单总额
		{
			get { return (double)this.GetValue("订单总额"); } 
			set { this.SetValue("订单总额", value); } 
		}

		public string 发票号
		{
			get { return (string)this.GetValue("发票号"); } 
			set { this.SetValue("发票号", value); } 
		}

		public string 业务员
		{
			get { return (string)this.GetValue("业务员"); } 
			set { this.SetValue("业务员", value); } 
		}

		public string 合同号
		{
			get { return (string)this.GetValue("合同号"); } 
			set { this.SetValue("合同号", value); } 
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

		public AllSaleView()
		{
			this.ViewName = "vw_AllSale";
			this.Fields = new Dictionary<string, EntityField>();
			this.Fields.Add("销售单ID", AllSaleViewFields.销售单ID);
			this.Fields.Add("销售单号", AllSaleViewFields.销售单号);
			this.Fields.Add("下单日期", AllSaleViewFields.下单日期);
			this.Fields.Add("状态", AllSaleViewFields.状态);
			this.Fields.Add("往来单位编号", AllSaleViewFields.往来单位编号);
			this.Fields.Add("往来单位名称", AllSaleViewFields.往来单位名称);
			this.Fields.Add("往来单位Spell", AllSaleViewFields.往来单位Spell);
			this.Fields.Add("收货地址", AllSaleViewFields.收货地址);
			this.Fields.Add("联系人", AllSaleViewFields.联系人);
			this.Fields.Add("联系方式", AllSaleViewFields.联系方式);
			this.Fields.Add("配送方式", AllSaleViewFields.配送方式);
			this.Fields.Add("付款方式", AllSaleViewFields.付款方式);
			this.Fields.Add("订单总额", AllSaleViewFields.订单总额);
			this.Fields.Add("发票号", AllSaleViewFields.发票号);
			this.Fields.Add("业务员", AllSaleViewFields.业务员);
			this.Fields.Add("合同号", AllSaleViewFields.合同号);
			this.Fields.Add("创建人", AllSaleViewFields.创建人);
			this.Fields.Add("创建日期", AllSaleViewFields.创建日期);
			this.Fields.Add("最后修改人", AllSaleViewFields.最后修改人);
			this.Fields.Add("最后修改时间", AllSaleViewFields.最后修改时间);
			this.Fields.Add("备注", AllSaleViewFields.备注);
		}
	}

	#region AllSaleViewFields

	public class AllSaleViewFields
	{
		public static EntityField 销售单ID
		{
			get { return new EntityField("vw_AllSale", 0, "销售单ID", SqlDbType.Int); }
		}

		public static EntityField 销售单号
		{
			get { return new EntityField("vw_AllSale", 1, "销售单号", SqlDbType.NVarChar); }
		}

		public static EntityField 下单日期
		{
			get { return new EntityField("vw_AllSale", 2, "下单日期", SqlDbType.DateTime); }
		}

		public static EntityField 状态
		{
			get { return new EntityField("vw_AllSale", 3, "状态", SqlDbType.NVarChar); }
		}

		public static EntityField 往来单位编号
		{
			get { return new EntityField("vw_AllSale", 4, "往来单位编号", SqlDbType.NVarChar); }
		}

		public static EntityField 往来单位名称
		{
			get { return new EntityField("vw_AllSale", 5, "往来单位名称", SqlDbType.NVarChar); }
		}

		public static EntityField 往来单位Spell
		{
			get { return new EntityField("vw_AllSale", 6, "往来单位Spell", SqlDbType.NVarChar); }
		}

		public static EntityField 收货地址
		{
			get { return new EntityField("vw_AllSale", 7, "收货地址", SqlDbType.NVarChar); }
		}

		public static EntityField 联系人
		{
			get { return new EntityField("vw_AllSale", 8, "联系人", SqlDbType.NVarChar); }
		}

		public static EntityField 联系方式
		{
			get { return new EntityField("vw_AllSale", 9, "联系方式", SqlDbType.NVarChar); }
		}

		public static EntityField 配送方式
		{
			get { return new EntityField("vw_AllSale", 10, "配送方式", SqlDbType.NVarChar); }
		}

		public static EntityField 付款方式
		{
			get { return new EntityField("vw_AllSale", 11, "付款方式", SqlDbType.NVarChar); }
		}

		public static EntityField 订单总额
		{
			get { return new EntityField("vw_AllSale", 12, "订单总额", SqlDbType.Float); }
		}

		public static EntityField 发票号
		{
			get { return new EntityField("vw_AllSale", 13, "发票号", SqlDbType.NVarChar); }
		}

		public static EntityField 业务员
		{
			get { return new EntityField("vw_AllSale", 14, "业务员", SqlDbType.NVarChar); }
		}

		public static EntityField 合同号
		{
			get { return new EntityField("vw_AllSale", 15, "合同号", SqlDbType.NVarChar); }
		}

		public static EntityField 创建人
		{
			get { return new EntityField("vw_AllSale", 16, "创建人", SqlDbType.NVarChar); }
		}

		public static EntityField 创建日期
		{
			get { return new EntityField("vw_AllSale", 17, "创建日期", SqlDbType.DateTime); }
		}

		public static EntityField 最后修改人
		{
			get { return new EntityField("vw_AllSale", 18, "最后修改人", SqlDbType.NVarChar); }
		}

		public static EntityField 最后修改时间
		{
			get { return new EntityField("vw_AllSale", 19, "最后修改时间", SqlDbType.DateTime); }
		}

		public static EntityField 备注
		{
			get { return new EntityField("vw_AllSale", 20, "备注", SqlDbType.NVarChar); }
		}

	}

	#endregion

}
