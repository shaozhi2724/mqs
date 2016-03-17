/*
 *	Build By: Codey Object Relation Mapping
 *	Build Data: 2014-03-04 22:32:22
 *	Build Type: View
 *	Description: AllPurchaseDetailView
*/

using System;
using System.Collections.Generic;
using System.Data;
using ORMSCore;

namespace DQS.Module.Views
{
	public class AllPurchaseDetailView : ViewBase
	{
		public int 采购单ID
		{
			get { return (int)this.GetValue("采购单ID"); } 
			set { this.SetValue("采购单ID", value); } 
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

		public AllPurchaseDetailView()
		{
			this.ViewName = "vw_AllPurchaseDetail";
			this.Fields = new Dictionary<string, EntityField>();
			this.Fields.Add("采购单ID", AllPurchaseDetailViewFields.采购单ID);
			this.Fields.Add("产品ID", AllPurchaseDetailViewFields.产品ID);
			this.Fields.Add("产品编号", AllPurchaseDetailViewFields.产品编号);
			this.Fields.Add("产品名称", AllPurchaseDetailViewFields.产品名称);
			this.Fields.Add("生产厂商", AllPurchaseDetailViewFields.生产厂商);
			this.Fields.Add("规格型号", AllPurchaseDetailViewFields.规格型号);
			this.Fields.Add("剂型", AllPurchaseDetailViewFields.剂型);
			this.Fields.Add("产品类别", AllPurchaseDetailViewFields.产品类别);
			this.Fields.Add("单位", AllPurchaseDetailViewFields.单位);
			this.Fields.Add("单价", AllPurchaseDetailViewFields.单价);
			this.Fields.Add("数量", AllPurchaseDetailViewFields.数量);
			this.Fields.Add("金额", AllPurchaseDetailViewFields.金额);
			this.Fields.Add("明细ID", AllPurchaseDetailViewFields.明细ID);
		}
	}

	#region AllPurchaseDetailViewFields

	public class AllPurchaseDetailViewFields
	{
		public static EntityField 采购单ID
		{
			get { return new EntityField("vw_AllPurchaseDetail", 0, "采购单ID", SqlDbType.Int); }
		}

		public static EntityField 产品ID
		{
			get { return new EntityField("vw_AllPurchaseDetail", 1, "产品ID", SqlDbType.Int); }
		}

		public static EntityField 产品编号
		{
			get { return new EntityField("vw_AllPurchaseDetail", 2, "产品编号", SqlDbType.NVarChar); }
		}

		public static EntityField 产品名称
		{
			get { return new EntityField("vw_AllPurchaseDetail", 3, "产品名称", SqlDbType.NVarChar); }
		}

		public static EntityField 生产厂商
		{
			get { return new EntityField("vw_AllPurchaseDetail", 4, "生产厂商", SqlDbType.NVarChar); }
		}

		public static EntityField 规格型号
		{
			get { return new EntityField("vw_AllPurchaseDetail", 5, "规格型号", SqlDbType.NVarChar); }
		}

		public static EntityField 剂型
		{
			get { return new EntityField("vw_AllPurchaseDetail", 6, "剂型", SqlDbType.NVarChar); }
		}

		public static EntityField 产品类别
		{
			get { return new EntityField("vw_AllPurchaseDetail", 7, "产品类别", SqlDbType.NVarChar); }
		}

		public static EntityField 单位
		{
			get { return new EntityField("vw_AllPurchaseDetail", 8, "单位", SqlDbType.NVarChar); }
		}

		public static EntityField 单价
		{
			get { return new EntityField("vw_AllPurchaseDetail", 9, "单价", SqlDbType.Float); }
		}

		public static EntityField 数量
		{
			get { return new EntityField("vw_AllPurchaseDetail", 10, "数量", SqlDbType.Int); }
		}

		public static EntityField 金额
		{
			get { return new EntityField("vw_AllPurchaseDetail", 11, "金额", SqlDbType.Float); }
		}

		public static EntityField 明细ID
		{
			get { return new EntityField("vw_AllPurchaseDetail", 12, "明细ID", SqlDbType.Int); }
		}

	}

	#endregion

}
