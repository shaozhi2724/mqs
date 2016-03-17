﻿/*
 *	Build By: Codey Object Relation Mapping
 *	Build Data: 2014-03-04 22:32:22
 *	Build Type: View
 *	Description: AllSaleBackDetailView
*/

using System;
using System.Collections.Generic;
using System.Data;
using ORMSCore;

namespace DQS.Module.Views
{
	public class AllSaleBackDetailView : ViewBase
	{
		public int 销售退货单ID
		{
			get { return (int)this.GetValue("销售退货单ID"); } 
			set { this.SetValue("销售退货单ID", value); } 
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

		public double 单价
		{
			get { return (double)this.GetValue("单价"); } 
			set { this.SetValue("单价", value); } 
		}

		public int 数量
		{
			get { return (int)this.GetValue("数量"); } 
			set { this.SetValue("数量", value); } 
		}

		public double 金额
		{
			get { return (double)this.GetValue("金额"); } 
			set { this.SetValue("金额", value); } 
		}

		public int 明细ID
		{
			get { return (int)this.GetValue("明细ID"); } 
			set { this.SetValue("明细ID", value); } 
		}

		public AllSaleBackDetailView()
		{
			this.ViewName = "vw_AllSaleBackDetail";
			this.Fields = new Dictionary<string, EntityField>();
			this.Fields.Add("销售退货单ID", AllSaleBackDetailViewFields.销售退货单ID);
			this.Fields.Add("产品ID", AllSaleBackDetailViewFields.产品ID);
			this.Fields.Add("产品编号", AllSaleBackDetailViewFields.产品编号);
			this.Fields.Add("产品名称", AllSaleBackDetailViewFields.产品名称);
			this.Fields.Add("生产厂商", AllSaleBackDetailViewFields.生产厂商);
			this.Fields.Add("规格型号", AllSaleBackDetailViewFields.规格型号);
			this.Fields.Add("剂型", AllSaleBackDetailViewFields.剂型);
			this.Fields.Add("产品类别", AllSaleBackDetailViewFields.产品类别);
			this.Fields.Add("单位", AllSaleBackDetailViewFields.单位);
			this.Fields.Add("批号", AllSaleBackDetailViewFields.批号);
			this.Fields.Add("生产日期", AllSaleBackDetailViewFields.生产日期);
			this.Fields.Add("有效期至", AllSaleBackDetailViewFields.有效期至);
			this.Fields.Add("单价", AllSaleBackDetailViewFields.单价);
			this.Fields.Add("数量", AllSaleBackDetailViewFields.数量);
			this.Fields.Add("金额", AllSaleBackDetailViewFields.金额);
			this.Fields.Add("明细ID", AllSaleBackDetailViewFields.明细ID);
		}
	}

	#region AllSaleBackDetailViewFields

	public class AllSaleBackDetailViewFields
	{
		public static EntityField 销售退货单ID
		{
			get { return new EntityField("vw_AllSaleBackDetail", 0, "销售退货单ID", SqlDbType.Int); }
		}

		public static EntityField 产品ID
		{
			get { return new EntityField("vw_AllSaleBackDetail", 1, "产品ID", SqlDbType.Int); }
		}

		public static EntityField 产品编号
		{
			get { return new EntityField("vw_AllSaleBackDetail", 2, "产品编号", SqlDbType.NVarChar); }
		}

		public static EntityField 产品名称
		{
			get { return new EntityField("vw_AllSaleBackDetail", 3, "产品名称", SqlDbType.NVarChar); }
		}

		public static EntityField 生产厂商
		{
			get { return new EntityField("vw_AllSaleBackDetail", 4, "生产厂商", SqlDbType.NVarChar); }
		}

		public static EntityField 规格型号
		{
			get { return new EntityField("vw_AllSaleBackDetail", 5, "规格型号", SqlDbType.NVarChar); }
		}

		public static EntityField 剂型
		{
			get { return new EntityField("vw_AllSaleBackDetail", 6, "剂型", SqlDbType.NVarChar); }
		}

		public static EntityField 产品类别
		{
			get { return new EntityField("vw_AllSaleBackDetail", 7, "产品类别", SqlDbType.NVarChar); }
		}

		public static EntityField 单位
		{
			get { return new EntityField("vw_AllSaleBackDetail", 8, "单位", SqlDbType.NVarChar); }
		}

		public static EntityField 批号
		{
			get { return new EntityField("vw_AllSaleBackDetail", 9, "批号", SqlDbType.NVarChar); }
		}

		public static EntityField 生产日期
		{
			get { return new EntityField("vw_AllSaleBackDetail", 10, "生产日期", SqlDbType.DateTime); }
		}

		public static EntityField 有效期至
		{
			get { return new EntityField("vw_AllSaleBackDetail", 11, "有效期至", SqlDbType.DateTime); }
		}

		public static EntityField 单价
		{
			get { return new EntityField("vw_AllSaleBackDetail", 12, "单价", SqlDbType.Float); }
		}

		public static EntityField 数量
		{
			get { return new EntityField("vw_AllSaleBackDetail", 13, "数量", SqlDbType.Int); }
		}

		public static EntityField 金额
		{
			get { return new EntityField("vw_AllSaleBackDetail", 14, "金额", SqlDbType.Float); }
		}

		public static EntityField 明细ID
		{
			get { return new EntityField("vw_AllSaleBackDetail", 15, "明细ID", SqlDbType.Int); }
		}

	}

	#endregion

}
