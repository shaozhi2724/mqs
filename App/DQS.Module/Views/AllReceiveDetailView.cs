/*
 *	Build By: Codey Object Relation Mapping
 *	Build Data: 2014-03-04 22:32:22
 *	Build Type: View
 *	Description: AllReceiveDetailView
*/

using System;
using System.Collections.Generic;
using System.Data;
using ORMSCore;

namespace DQS.Module.Views
{
	public class AllReceiveDetailView : ViewBase
	{
		public int 收货单ID
		{
			get { return (int)this.GetValue("收货单ID"); } 
			set { this.SetValue("收货单ID", value); } 
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

		public int 收货数量
		{
			get { return (int)this.GetValue("收货数量"); } 
			set { this.SetValue("收货数量", value); } 
		}

		public int 明细ID
		{
			get { return (int)this.GetValue("明细ID"); } 
			set { this.SetValue("明细ID", value); } 
		}

		public AllReceiveDetailView()
		{
			this.ViewName = "vw_AllReceiveDetail";
			this.Fields = new Dictionary<string, EntityField>();
			this.Fields.Add("收货单ID", AllReceiveDetailViewFields.收货单ID);
			this.Fields.Add("产品ID", AllReceiveDetailViewFields.产品ID);
			this.Fields.Add("产品编号", AllReceiveDetailViewFields.产品编号);
			this.Fields.Add("产品名称", AllReceiveDetailViewFields.产品名称);
			this.Fields.Add("生产厂商", AllReceiveDetailViewFields.生产厂商);
			this.Fields.Add("规格型号", AllReceiveDetailViewFields.规格型号);
			this.Fields.Add("剂型", AllReceiveDetailViewFields.剂型);
			this.Fields.Add("产品类别", AllReceiveDetailViewFields.产品类别);
			this.Fields.Add("单位", AllReceiveDetailViewFields.单位);
			this.Fields.Add("订单数量", AllReceiveDetailViewFields.订单数量);
			this.Fields.Add("收货数量", AllReceiveDetailViewFields.收货数量);
			this.Fields.Add("明细ID", AllReceiveDetailViewFields.明细ID);
		}
	}

	#region AllReceiveDetailViewFields

	public class AllReceiveDetailViewFields
	{
		public static EntityField 收货单ID
		{
			get { return new EntityField("vw_AllReceiveDetail", 0, "收货单ID", SqlDbType.Int); }
		}

		public static EntityField 产品ID
		{
			get { return new EntityField("vw_AllReceiveDetail", 1, "产品ID", SqlDbType.Int); }
		}

		public static EntityField 产品编号
		{
			get { return new EntityField("vw_AllReceiveDetail", 2, "产品编号", SqlDbType.NVarChar); }
		}

		public static EntityField 产品名称
		{
			get { return new EntityField("vw_AllReceiveDetail", 3, "产品名称", SqlDbType.NVarChar); }
		}

		public static EntityField 生产厂商
		{
			get { return new EntityField("vw_AllReceiveDetail", 4, "生产厂商", SqlDbType.NVarChar); }
		}

		public static EntityField 规格型号
		{
			get { return new EntityField("vw_AllReceiveDetail", 5, "规格型号", SqlDbType.NVarChar); }
		}

		public static EntityField 剂型
		{
			get { return new EntityField("vw_AllReceiveDetail", 6, "剂型", SqlDbType.NVarChar); }
		}

		public static EntityField 产品类别
		{
			get { return new EntityField("vw_AllReceiveDetail", 7, "产品类别", SqlDbType.NVarChar); }
		}

		public static EntityField 单位
		{
			get { return new EntityField("vw_AllReceiveDetail", 8, "单位", SqlDbType.NVarChar); }
		}

		public static EntityField 订单数量
		{
			get { return new EntityField("vw_AllReceiveDetail", 9, "订单数量", SqlDbType.Int); }
		}

		public static EntityField 收货数量
		{
			get { return new EntityField("vw_AllReceiveDetail", 10, "收货数量", SqlDbType.Int); }
		}

		public static EntityField 明细ID
		{
			get { return new EntityField("vw_AllReceiveDetail", 11, "明细ID", SqlDbType.Int); }
		}

	}

	#endregion

}
