/*
 *	Build By: Codey Object Relation Mapping
 *	Build Data: 2014-03-04 22:32:22
 *	Build Type: View
 *	Description: AllPurchaseView
*/

using System;
using System.Collections.Generic;
using System.Data;
using ORMSCore;

namespace DQS.Module.Views
{
	public class AllPurchaseView : ViewBase
	{
		public int 采购单ID
		{
			get { return (int)this.GetValue("采购单ID"); } 
			set { this.SetValue("采购单ID", value); } 
		}

		public string 采购单号
		{
			get { return (string)this.GetValue("采购单号"); } 
			set { this.SetValue("采购单号", value); } 
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

		public AllPurchaseView()
		{
			this.ViewName = "vw_AllPurchase";
			this.Fields = new Dictionary<string, EntityField>();
			this.Fields.Add("采购单ID", AllPurchaseViewFields.采购单ID);
			this.Fields.Add("采购单号", AllPurchaseViewFields.采购单号);
			this.Fields.Add("下单日期", AllPurchaseViewFields.下单日期);
			this.Fields.Add("状态", AllPurchaseViewFields.状态);
			this.Fields.Add("往来单位编号", AllPurchaseViewFields.往来单位编号);
			this.Fields.Add("往来单位名称", AllPurchaseViewFields.往来单位名称);
			this.Fields.Add("往来单位Spell", AllPurchaseViewFields.往来单位Spell);
			this.Fields.Add("联系人", AllPurchaseViewFields.联系人);
			this.Fields.Add("联系方式", AllPurchaseViewFields.联系方式);
			this.Fields.Add("配送方式", AllPurchaseViewFields.配送方式);
			this.Fields.Add("付款方式", AllPurchaseViewFields.付款方式);
			this.Fields.Add("订单总额", AllPurchaseViewFields.订单总额);
			this.Fields.Add("发票号", AllPurchaseViewFields.发票号);
			this.Fields.Add("业务员", AllPurchaseViewFields.业务员);
			this.Fields.Add("合同号", AllPurchaseViewFields.合同号);
			this.Fields.Add("创建人", AllPurchaseViewFields.创建人);
			this.Fields.Add("创建日期", AllPurchaseViewFields.创建日期);
			this.Fields.Add("最后修改人", AllPurchaseViewFields.最后修改人);
			this.Fields.Add("最后修改时间", AllPurchaseViewFields.最后修改时间);
			this.Fields.Add("备注", AllPurchaseViewFields.备注);
		}
	}

	#region AllPurchaseViewFields

	public class AllPurchaseViewFields
	{
		public static EntityField 采购单ID
		{
			get { return new EntityField("vw_AllPurchase", 0, "采购单ID", SqlDbType.Int); }
		}

		public static EntityField 采购单号
		{
			get { return new EntityField("vw_AllPurchase", 1, "采购单号", SqlDbType.NVarChar); }
		}

		public static EntityField 下单日期
		{
			get { return new EntityField("vw_AllPurchase", 2, "下单日期", SqlDbType.DateTime); }
		}

		public static EntityField 状态
		{
			get { return new EntityField("vw_AllPurchase", 3, "状态", SqlDbType.NVarChar); }
		}

		public static EntityField 往来单位编号
		{
			get { return new EntityField("vw_AllPurchase", 4, "往来单位编号", SqlDbType.NVarChar); }
		}

		public static EntityField 往来单位名称
		{
			get { return new EntityField("vw_AllPurchase", 5, "往来单位名称", SqlDbType.NVarChar); }
		}

		public static EntityField 往来单位Spell
		{
			get { return new EntityField("vw_AllPurchase", 6, "往来单位Spell", SqlDbType.NVarChar); }
		}

		public static EntityField 联系人
		{
			get { return new EntityField("vw_AllPurchase", 7, "联系人", SqlDbType.NVarChar); }
		}

		public static EntityField 联系方式
		{
			get { return new EntityField("vw_AllPurchase", 8, "联系方式", SqlDbType.NVarChar); }
		}

		public static EntityField 配送方式
		{
			get { return new EntityField("vw_AllPurchase", 9, "配送方式", SqlDbType.NVarChar); }
		}

		public static EntityField 付款方式
		{
			get { return new EntityField("vw_AllPurchase", 10, "付款方式", SqlDbType.NVarChar); }
		}

		public static EntityField 订单总额
		{
			get { return new EntityField("vw_AllPurchase", 11, "订单总额", SqlDbType.Float); }
		}

		public static EntityField 发票号
		{
			get { return new EntityField("vw_AllPurchase", 12, "发票号", SqlDbType.NVarChar); }
		}

		public static EntityField 业务员
		{
			get { return new EntityField("vw_AllPurchase", 13, "业务员", SqlDbType.NVarChar); }
		}

		public static EntityField 合同号
		{
			get { return new EntityField("vw_AllPurchase", 14, "合同号", SqlDbType.NVarChar); }
		}

		public static EntityField 创建人
		{
			get { return new EntityField("vw_AllPurchase", 15, "创建人", SqlDbType.NVarChar); }
		}

		public static EntityField 创建日期
		{
			get { return new EntityField("vw_AllPurchase", 16, "创建日期", SqlDbType.DateTime); }
		}

		public static EntityField 最后修改人
		{
			get { return new EntityField("vw_AllPurchase", 17, "最后修改人", SqlDbType.NVarChar); }
		}

		public static EntityField 最后修改时间
		{
			get { return new EntityField("vw_AllPurchase", 18, "最后修改时间", SqlDbType.DateTime); }
		}

		public static EntityField 备注
		{
			get { return new EntityField("vw_AllPurchase", 19, "备注", SqlDbType.NVarChar); }
		}

	}

	#endregion

}
