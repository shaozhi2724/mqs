/*
 *	Build By: Codey Object Relation Mapping
 *	Build Data: 2014-03-04 22:32:22
 *	Build Type: View
 *	Description: AllPurchaseBackView
*/

using System;
using System.Collections.Generic;
using System.Data;
using ORMSCore;

namespace DQS.Module.Views
{
	public class AllPurchaseBackView : ViewBase
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

		public AllPurchaseBackView()
		{
			this.ViewName = "vw_AllPurchaseBack";
			this.Fields = new Dictionary<string, EntityField>();
			this.Fields.Add("退货单ID", AllPurchaseBackViewFields.退货单ID);
			this.Fields.Add("退货单编号", AllPurchaseBackViewFields.退货单编号);
			this.Fields.Add("下单日期", AllPurchaseBackViewFields.下单日期);
			this.Fields.Add("状态", AllPurchaseBackViewFields.状态);
			this.Fields.Add("往来单位编号", AllPurchaseBackViewFields.往来单位编号);
			this.Fields.Add("往来单位名称", AllPurchaseBackViewFields.往来单位名称);
			this.Fields.Add("收货地址", AllPurchaseBackViewFields.收货地址);
			this.Fields.Add("收货人", AllPurchaseBackViewFields.收货人);
			this.Fields.Add("收货人电话", AllPurchaseBackViewFields.收货人电话);
			this.Fields.Add("订单总额", AllPurchaseBackViewFields.订单总额);
			this.Fields.Add("付款方式", AllPurchaseBackViewFields.付款方式);
			this.Fields.Add("配送方式", AllPurchaseBackViewFields.配送方式);
			this.Fields.Add("创建人", AllPurchaseBackViewFields.创建人);
			this.Fields.Add("创建日期", AllPurchaseBackViewFields.创建日期);
			this.Fields.Add("最后修改人", AllPurchaseBackViewFields.最后修改人);
			this.Fields.Add("最后修改时间", AllPurchaseBackViewFields.最后修改时间);
			this.Fields.Add("备注", AllPurchaseBackViewFields.备注);
		}
	}

	#region AllPurchaseBackViewFields

	public class AllPurchaseBackViewFields
	{
		public static EntityField 退货单ID
		{
			get { return new EntityField("vw_AllPurchaseBack", 0, "退货单ID", SqlDbType.Int); }
		}

		public static EntityField 退货单编号
		{
			get { return new EntityField("vw_AllPurchaseBack", 1, "退货单编号", SqlDbType.NVarChar); }
		}

		public static EntityField 下单日期
		{
			get { return new EntityField("vw_AllPurchaseBack", 2, "下单日期", SqlDbType.DateTime); }
		}

		public static EntityField 状态
		{
			get { return new EntityField("vw_AllPurchaseBack", 3, "状态", SqlDbType.NVarChar); }
		}

		public static EntityField 往来单位编号
		{
			get { return new EntityField("vw_AllPurchaseBack", 4, "往来单位编号", SqlDbType.NVarChar); }
		}

		public static EntityField 往来单位名称
		{
			get { return new EntityField("vw_AllPurchaseBack", 5, "往来单位名称", SqlDbType.NVarChar); }
		}

		public static EntityField 收货地址
		{
			get { return new EntityField("vw_AllPurchaseBack", 6, "收货地址", SqlDbType.NVarChar); }
		}

		public static EntityField 收货人
		{
			get { return new EntityField("vw_AllPurchaseBack", 7, "收货人", SqlDbType.NVarChar); }
		}

		public static EntityField 收货人电话
		{
			get { return new EntityField("vw_AllPurchaseBack", 8, "收货人电话", SqlDbType.NVarChar); }
		}

		public static EntityField 订单总额
		{
			get { return new EntityField("vw_AllPurchaseBack", 9, "订单总额", SqlDbType.Float); }
		}

		public static EntityField 付款方式
		{
			get { return new EntityField("vw_AllPurchaseBack", 10, "付款方式", SqlDbType.NVarChar); }
		}

		public static EntityField 配送方式
		{
			get { return new EntityField("vw_AllPurchaseBack", 11, "配送方式", SqlDbType.NVarChar); }
		}

		public static EntityField 创建人
		{
			get { return new EntityField("vw_AllPurchaseBack", 12, "创建人", SqlDbType.NVarChar); }
		}

		public static EntityField 创建日期
		{
			get { return new EntityField("vw_AllPurchaseBack", 13, "创建日期", SqlDbType.DateTime); }
		}

		public static EntityField 最后修改人
		{
			get { return new EntityField("vw_AllPurchaseBack", 14, "最后修改人", SqlDbType.NVarChar); }
		}

		public static EntityField 最后修改时间
		{
			get { return new EntityField("vw_AllPurchaseBack", 15, "最后修改时间", SqlDbType.DateTime); }
		}

		public static EntityField 备注
		{
			get { return new EntityField("vw_AllPurchaseBack", 16, "备注", SqlDbType.NVarChar); }
		}

	}

	#endregion

}
