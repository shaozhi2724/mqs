/*
 *	Build By: Codey Object Relation Mapping
 *	Build Data: 2014-04-13 10:37:27
 *	Build Type: View
 *	Description: AllTransportView
*/

using System;
using System.Collections.Generic;
using System.Data;
using ORMSCore;

namespace DQS.Module.Views
{
	public class AllTransportView : ViewBase
	{
		public int 运输ID
		{
			get { return (int)this.GetValue("运输ID"); } 
			set { this.SetValue("运输ID", value); } 
		}

		public string 运输单号
		{
			get { return (string)this.GetValue("运输单号"); } 
			set { this.SetValue("运输单号", value); } 
		}

		public string 送货人
		{
			get { return (string)this.GetValue("送货人"); } 
			set { this.SetValue("送货人", value); } 
		}

		public string 订单编号
		{
			get { return (string)this.GetValue("订单编号"); } 
			set { this.SetValue("订单编号", value); } 
		}

		public string 收货单位
		{
			get { return (string)this.GetValue("收货单位"); } 
			set { this.SetValue("收货单位", value); } 
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

		public string 收货人联系方式
		{
			get { return (string)this.GetValue("收货人联系方式"); } 
			set { this.SetValue("收货人联系方式", value); } 
		}

		public string 发货地址
		{
			get { return (string)this.GetValue("发货地址"); } 
			set { this.SetValue("发货地址", value); } 
		}

		public string 委托经办人
		{
			get { return (string)this.GetValue("委托经办人"); } 
			set { this.SetValue("委托经办人", value); } 
		}

		public string 运输方式
		{
			get { return (string)this.GetValue("运输方式"); } 
			set { this.SetValue("运输方式", value); } 
		}

		public string 承运单位
		{
			get { return (string)this.GetValue("承运单位"); } 
			set { this.SetValue("承运单位", value); } 
		}

		public string 承运单位spell
		{
			get { return (string)this.GetValue("承运单位spell"); } 
			set { this.SetValue("承运单位spell", value); } 
		}

		public string 运输车辆号
		{
			get { return (string)this.GetValue("运输车辆号"); } 
			set { this.SetValue("运输车辆号", value); } 
		}

		public DateTime 起运时间
		{
			get { return (DateTime)this.GetValue("起运时间"); } 
			set { this.SetValue("起运时间", value); } 
		}

		public DateTime 到达时间
		{
			get { return (DateTime)this.GetValue("到达时间"); } 
			set { this.SetValue("到达时间", value); } 
		}

		public string 状态
		{
			get { return (string)this.GetValue("状态"); } 
			set { this.SetValue("状态", value); } 
		}

		public double 最低运输时限
		{
			get { return (double)this.GetValue("最低运输时限"); } 
			set { this.SetValue("最低运输时限", value); } 
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

		public string 备注
		{
			get { return (string)this.GetValue("备注"); } 
			set { this.SetValue("备注", value); } 
		}

		public AllTransportView()
		{
			this.ViewName = "vw_AllTransport";
			this.Fields = new Dictionary<string, EntityField>();
			this.Fields.Add("运输ID", AllTransportViewFields.运输ID);
			this.Fields.Add("运输单号", AllTransportViewFields.运输单号);
			this.Fields.Add("送货人", AllTransportViewFields.送货人);
			this.Fields.Add("订单编号", AllTransportViewFields.订单编号);
			this.Fields.Add("收货单位", AllTransportViewFields.收货单位);
			this.Fields.Add("收货地址", AllTransportViewFields.收货地址);
			this.Fields.Add("收货人", AllTransportViewFields.收货人);
			this.Fields.Add("收货人联系方式", AllTransportViewFields.收货人联系方式);
			this.Fields.Add("发货地址", AllTransportViewFields.发货地址);
			this.Fields.Add("委托经办人", AllTransportViewFields.委托经办人);
			this.Fields.Add("运输方式", AllTransportViewFields.运输方式);
			this.Fields.Add("承运单位", AllTransportViewFields.承运单位);
			this.Fields.Add("承运单位spell", AllTransportViewFields.承运单位spell);
			this.Fields.Add("运输车辆号", AllTransportViewFields.运输车辆号);
			this.Fields.Add("起运时间", AllTransportViewFields.起运时间);
			this.Fields.Add("到达时间", AllTransportViewFields.到达时间);
			this.Fields.Add("状态", AllTransportViewFields.状态);
			this.Fields.Add("最低运输时限", AllTransportViewFields.最低运输时限);
			this.Fields.Add("创建人", AllTransportViewFields.创建人);
			this.Fields.Add("创建日期", AllTransportViewFields.创建日期);
			this.Fields.Add("备注", AllTransportViewFields.备注);
		}
	}

	#region AllTransportViewFields

	public class AllTransportViewFields
	{
		public static EntityField 运输ID
		{
			get { return new EntityField("vw_AllTransport", 0, "运输ID", SqlDbType.Int); }
		}

		public static EntityField 运输单号
		{
			get { return new EntityField("vw_AllTransport", 1, "运输单号", SqlDbType.NVarChar); }
		}

		public static EntityField 送货人
		{
			get { return new EntityField("vw_AllTransport", 2, "送货人", SqlDbType.NVarChar); }
		}

		public static EntityField 订单编号
		{
			get { return new EntityField("vw_AllTransport", 3, "订单编号", SqlDbType.NVarChar); }
		}

		public static EntityField 收货单位
		{
			get { return new EntityField("vw_AllTransport", 4, "收货单位", SqlDbType.NVarChar); }
		}

		public static EntityField 收货地址
		{
			get { return new EntityField("vw_AllTransport", 5, "收货地址", SqlDbType.NVarChar); }
		}

		public static EntityField 收货人
		{
			get { return new EntityField("vw_AllTransport", 6, "收货人", SqlDbType.NVarChar); }
		}

		public static EntityField 收货人联系方式
		{
			get { return new EntityField("vw_AllTransport", 7, "收货人联系方式", SqlDbType.NVarChar); }
		}

		public static EntityField 发货地址
		{
			get { return new EntityField("vw_AllTransport", 8, "发货地址", SqlDbType.NVarChar); }
		}

		public static EntityField 委托经办人
		{
			get { return new EntityField("vw_AllTransport", 9, "委托经办人", SqlDbType.NVarChar); }
		}

		public static EntityField 运输方式
		{
			get { return new EntityField("vw_AllTransport", 10, "运输方式", SqlDbType.NVarChar); }
		}

		public static EntityField 承运单位
		{
			get { return new EntityField("vw_AllTransport", 11, "承运单位", SqlDbType.NVarChar); }
		}

		public static EntityField 承运单位spell
		{
			get { return new EntityField("vw_AllTransport", 12, "承运单位spell", SqlDbType.NVarChar); }
		}

		public static EntityField 运输车辆号
		{
			get { return new EntityField("vw_AllTransport", 13, "运输车辆号", SqlDbType.NVarChar); }
		}

		public static EntityField 起运时间
		{
			get { return new EntityField("vw_AllTransport", 14, "起运时间", SqlDbType.DateTime); }
		}

		public static EntityField 到达时间
		{
			get { return new EntityField("vw_AllTransport", 15, "到达时间", SqlDbType.DateTime); }
		}

		public static EntityField 状态
		{
			get { return new EntityField("vw_AllTransport", 16, "状态", SqlDbType.NVarChar); }
		}

		public static EntityField 最低运输时限
		{
			get { return new EntityField("vw_AllTransport", 17, "最低运输时限", SqlDbType.Float); }
		}

		public static EntityField 创建人
		{
			get { return new EntityField("vw_AllTransport", 18, "创建人", SqlDbType.NVarChar); }
		}

		public static EntityField 创建日期
		{
			get { return new EntityField("vw_AllTransport", 19, "创建日期", SqlDbType.DateTime); }
		}

		public static EntityField 备注
		{
			get { return new EntityField("vw_AllTransport", 20, "备注", SqlDbType.NVarChar); }
		}

	}

	#endregion

}
