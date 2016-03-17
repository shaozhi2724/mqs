/*
 *	Build By: Codey Object Relation Mapping
 *	Build Data: 2014-03-04 22:32:22
 *	Build Type: View
 *	Description: AllWarehouseOutBillDetailView
*/

using System;
using System.Collections.Generic;
using System.Data;
using ORMSCore;

namespace DQS.Module.Views
{
	public class AllWarehouseOutBillDetailView : ViewBase
	{
		public int 订单ID
		{
			get { return (int)this.GetValue("订单ID"); } 
			set { this.SetValue("订单ID", value); } 
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

		public int 订单数量
		{
			get { return (int)this.GetValue("订单数量"); } 
			set { this.SetValue("订单数量", value); } 
		}

		public int 明细ID
		{
			get { return (int)this.GetValue("明细ID"); } 
			set { this.SetValue("明细ID", value); } 
		}

		public string 货位编号
		{
			get { return (string)this.GetValue("货位编号"); } 
			set { this.SetValue("货位编号", value); } 
		}

		public string 货位名称
		{
			get { return (string)this.GetValue("货位名称"); } 
			set { this.SetValue("货位名称", value); } 
		}

		public string 货位位置
		{
			get { return (string)this.GetValue("货位位置"); } 
			set { this.SetValue("货位位置", value); } 
		}

		public AllWarehouseOutBillDetailView()
		{
			this.ViewName = "vw_AllWarehouseOutBillDetail";
			this.Fields = new Dictionary<string, EntityField>();
			this.Fields.Add("订单ID", AllWarehouseOutBillDetailViewFields.订单ID);
			this.Fields.Add("产品ID", AllWarehouseOutBillDetailViewFields.产品ID);
			this.Fields.Add("产品编号", AllWarehouseOutBillDetailViewFields.产品编号);
			this.Fields.Add("产品名称", AllWarehouseOutBillDetailViewFields.产品名称);
			this.Fields.Add("生产厂商", AllWarehouseOutBillDetailViewFields.生产厂商);
			this.Fields.Add("规格型号", AllWarehouseOutBillDetailViewFields.规格型号);
			this.Fields.Add("剂型", AllWarehouseOutBillDetailViewFields.剂型);
			this.Fields.Add("产品类别", AllWarehouseOutBillDetailViewFields.产品类别);
			this.Fields.Add("单位", AllWarehouseOutBillDetailViewFields.单位);
			this.Fields.Add("批号", AllWarehouseOutBillDetailViewFields.批号);
			this.Fields.Add("生产日期", AllWarehouseOutBillDetailViewFields.生产日期);
			this.Fields.Add("有效期至", AllWarehouseOutBillDetailViewFields.有效期至);
			this.Fields.Add("订单数量", AllWarehouseOutBillDetailViewFields.订单数量);
			this.Fields.Add("明细ID", AllWarehouseOutBillDetailViewFields.明细ID);
			this.Fields.Add("货位编号", AllWarehouseOutBillDetailViewFields.货位编号);
			this.Fields.Add("货位名称", AllWarehouseOutBillDetailViewFields.货位名称);
			this.Fields.Add("货位位置", AllWarehouseOutBillDetailViewFields.货位位置);
		}
	}

	#region AllWarehouseOutBillDetailViewFields

	public class AllWarehouseOutBillDetailViewFields
	{
		public static EntityField 订单ID
		{
			get { return new EntityField("vw_AllWarehouseOutBillDetail", 0, "订单ID", SqlDbType.Int); }
		}

		public static EntityField 产品ID
		{
			get { return new EntityField("vw_AllWarehouseOutBillDetail", 1, "产品ID", SqlDbType.Int); }
		}

		public static EntityField 产品编号
		{
			get { return new EntityField("vw_AllWarehouseOutBillDetail", 2, "产品编号", SqlDbType.NVarChar); }
		}

		public static EntityField 产品名称
		{
			get { return new EntityField("vw_AllWarehouseOutBillDetail", 3, "产品名称", SqlDbType.NVarChar); }
		}

		public static EntityField 生产厂商
		{
			get { return new EntityField("vw_AllWarehouseOutBillDetail", 4, "生产厂商", SqlDbType.NVarChar); }
		}

		public static EntityField 规格型号
		{
			get { return new EntityField("vw_AllWarehouseOutBillDetail", 5, "规格型号", SqlDbType.NVarChar); }
		}

		public static EntityField 剂型
		{
			get { return new EntityField("vw_AllWarehouseOutBillDetail", 6, "剂型", SqlDbType.NVarChar); }
		}

		public static EntityField 产品类别
		{
			get { return new EntityField("vw_AllWarehouseOutBillDetail", 7, "产品类别", SqlDbType.NVarChar); }
		}

		public static EntityField 单位
		{
			get { return new EntityField("vw_AllWarehouseOutBillDetail", 8, "单位", SqlDbType.NVarChar); }
		}

		public static EntityField 批号
		{
			get { return new EntityField("vw_AllWarehouseOutBillDetail", 9, "批号", SqlDbType.NVarChar); }
		}

		public static EntityField 生产日期
		{
			get { return new EntityField("vw_AllWarehouseOutBillDetail", 10, "生产日期", SqlDbType.DateTime); }
		}

		public static EntityField 有效期至
		{
			get { return new EntityField("vw_AllWarehouseOutBillDetail", 11, "有效期至", SqlDbType.DateTime); }
		}

		public static EntityField 订单数量
		{
			get { return new EntityField("vw_AllWarehouseOutBillDetail", 12, "订单数量", SqlDbType.Int); }
		}

		public static EntityField 明细ID
		{
			get { return new EntityField("vw_AllWarehouseOutBillDetail", 13, "明细ID", SqlDbType.Int); }
		}

		public static EntityField 货位编号
		{
			get { return new EntityField("vw_AllWarehouseOutBillDetail", 14, "货位编号", SqlDbType.NVarChar); }
		}

		public static EntityField 货位名称
		{
			get { return new EntityField("vw_AllWarehouseOutBillDetail", 15, "货位名称", SqlDbType.NVarChar); }
		}

		public static EntityField 货位位置
		{
			get { return new EntityField("vw_AllWarehouseOutBillDetail", 16, "货位位置", SqlDbType.NVarChar); }
		}

	}

	#endregion

}
