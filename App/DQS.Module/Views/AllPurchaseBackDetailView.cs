/*
 *	Build By: Codey Object Relation Mapping
 *	Build Data: 2014-03-04 22:32:22
 *	Build Type: View
 *	Description: AllPurchaseBackDetailView
*/

using System;
using System.Collections.Generic;
using System.Data;
using ORMSCore;

namespace DQS.Module.Views
{
	public class AllPurchaseBackDetailView : ViewBase
	{
		public int 采购退货单ID
		{
			get { return (int)this.GetValue("采购退货单ID"); } 
			set { this.SetValue("采购退货单ID", value); } 
		}

		public int 药品ID
		{
			get { return (int)this.GetValue("药品ID"); } 
			set { this.SetValue("药品ID", value); } 
		}

		public string 药品编号
		{
			get { return (string)this.GetValue("药品编号"); } 
			set { this.SetValue("药品编号", value); } 
		}

		public string 药品名称
		{
			get { return (string)this.GetValue("药品名称"); } 
			set { this.SetValue("药品名称", value); } 
		}

		public string 生产厂商
		{
			get { return (string)this.GetValue("生产厂商"); } 
			set { this.SetValue("生产厂商", value); } 
		}

		public string 规格
		{
			get { return (string)this.GetValue("规格"); } 
			set { this.SetValue("规格", value); } 
		}

		public string 剂型
		{
			get { return (string)this.GetValue("剂型"); } 
			set { this.SetValue("剂型", value); } 
		}

		public string 药品类别
		{
			get { return (string)this.GetValue("药品类别"); } 
			set { this.SetValue("药品类别", value); } 
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

		public int 库存数量
		{
			get { return (int)this.GetValue("库存数量"); } 
			set { this.SetValue("库存数量", value); } 
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

		public AllPurchaseBackDetailView()
		{
			this.ViewName = "vw_AllPurchaseBackDetail";
			this.Fields = new Dictionary<string, EntityField>();
			this.Fields.Add("采购退货单ID", AllPurchaseBackDetailViewFields.采购退货单ID);
			this.Fields.Add("药品ID", AllPurchaseBackDetailViewFields.药品ID);
			this.Fields.Add("药品编号", AllPurchaseBackDetailViewFields.药品编号);
			this.Fields.Add("药品名称", AllPurchaseBackDetailViewFields.药品名称);
			this.Fields.Add("生产厂商", AllPurchaseBackDetailViewFields.生产厂商);
			this.Fields.Add("规格", AllPurchaseBackDetailViewFields.规格);
			this.Fields.Add("剂型", AllPurchaseBackDetailViewFields.剂型);
			this.Fields.Add("药品类别", AllPurchaseBackDetailViewFields.药品类别);
			this.Fields.Add("单位", AllPurchaseBackDetailViewFields.单位);
			this.Fields.Add("批号", AllPurchaseBackDetailViewFields.批号);
			this.Fields.Add("生产日期", AllPurchaseBackDetailViewFields.生产日期);
			this.Fields.Add("有效期至", AllPurchaseBackDetailViewFields.有效期至);
			this.Fields.Add("库存数量", AllPurchaseBackDetailViewFields.库存数量);
			this.Fields.Add("单价", AllPurchaseBackDetailViewFields.单价);
			this.Fields.Add("数量", AllPurchaseBackDetailViewFields.数量);
			this.Fields.Add("金额", AllPurchaseBackDetailViewFields.金额);
			this.Fields.Add("明细ID", AllPurchaseBackDetailViewFields.明细ID);
		}
	}

	#region AllPurchaseBackDetailViewFields

	public class AllPurchaseBackDetailViewFields
	{
		public static EntityField 采购退货单ID
		{
			get { return new EntityField("vw_AllPurchaseBackDetail", 0, "采购退货单ID", SqlDbType.Int); }
		}

		public static EntityField 药品ID
		{
			get { return new EntityField("vw_AllPurchaseBackDetail", 1, "药品ID", SqlDbType.Int); }
		}

		public static EntityField 药品编号
		{
			get { return new EntityField("vw_AllPurchaseBackDetail", 2, "药品编号", SqlDbType.NVarChar); }
		}

		public static EntityField 药品名称
		{
			get { return new EntityField("vw_AllPurchaseBackDetail", 3, "药品名称", SqlDbType.NVarChar); }
		}

		public static EntityField 生产厂商
		{
			get { return new EntityField("vw_AllPurchaseBackDetail", 4, "生产厂商", SqlDbType.NVarChar); }
		}

		public static EntityField 规格
		{
			get { return new EntityField("vw_AllPurchaseBackDetail", 5, "规格", SqlDbType.NVarChar); }
		}

		public static EntityField 剂型
		{
			get { return new EntityField("vw_AllPurchaseBackDetail", 6, "剂型", SqlDbType.NVarChar); }
		}

		public static EntityField 药品类别
		{
			get { return new EntityField("vw_AllPurchaseBackDetail", 7, "药品类别", SqlDbType.NVarChar); }
		}

		public static EntityField 单位
		{
			get { return new EntityField("vw_AllPurchaseBackDetail", 8, "单位", SqlDbType.NVarChar); }
		}

		public static EntityField 批号
		{
			get { return new EntityField("vw_AllPurchaseBackDetail", 9, "批号", SqlDbType.NVarChar); }
		}

		public static EntityField 生产日期
		{
			get { return new EntityField("vw_AllPurchaseBackDetail", 10, "生产日期", SqlDbType.DateTime); }
		}

		public static EntityField 有效期至
		{
			get { return new EntityField("vw_AllPurchaseBackDetail", 11, "有效期至", SqlDbType.DateTime); }
		}

		public static EntityField 库存数量
		{
			get { return new EntityField("vw_AllPurchaseBackDetail", 12, "库存数量", SqlDbType.Int); }
		}

		public static EntityField 单价
		{
			get { return new EntityField("vw_AllPurchaseBackDetail", 13, "单价", SqlDbType.Float); }
		}

		public static EntityField 数量
		{
			get { return new EntityField("vw_AllPurchaseBackDetail", 14, "数量", SqlDbType.Int); }
		}

		public static EntityField 金额
		{
			get { return new EntityField("vw_AllPurchaseBackDetail", 15, "金额", SqlDbType.Float); }
		}

		public static EntityField 明细ID
		{
			get { return new EntityField("vw_AllPurchaseBackDetail", 16, "明细ID", SqlDbType.Int); }
		}

	}

	#endregion

}
