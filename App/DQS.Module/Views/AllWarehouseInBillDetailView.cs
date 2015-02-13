/*
 *	Build By: Codey Object Relation Mapping
 *	Build Data: 2014-03-04 22:32:22
 *	Build Type: View
 *	Description: AllWarehouseInBillDetailView
*/

using System;
using System.Collections.Generic;
using System.Data;
using ORMSCore;

namespace DQS.Module.Views
{
	public class AllWarehouseInBillDetailView : ViewBase
	{
		public int 订单ID
		{
			get { return (int)this.GetValue("订单ID"); } 
			set { this.SetValue("订单ID", value); } 
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

		public AllWarehouseInBillDetailView()
		{
			this.ViewName = "vw_AllWarehouseInBillDetail";
			this.Fields = new Dictionary<string, EntityField>();
			this.Fields.Add("订单ID", AllWarehouseInBillDetailViewFields.订单ID);
			this.Fields.Add("药品ID", AllWarehouseInBillDetailViewFields.药品ID);
			this.Fields.Add("药品编号", AllWarehouseInBillDetailViewFields.药品编号);
			this.Fields.Add("药品名称", AllWarehouseInBillDetailViewFields.药品名称);
			this.Fields.Add("生产厂商", AllWarehouseInBillDetailViewFields.生产厂商);
			this.Fields.Add("规格", AllWarehouseInBillDetailViewFields.规格);
			this.Fields.Add("剂型", AllWarehouseInBillDetailViewFields.剂型);
			this.Fields.Add("药品类别", AllWarehouseInBillDetailViewFields.药品类别);
			this.Fields.Add("单位", AllWarehouseInBillDetailViewFields.单位);
			this.Fields.Add("批号", AllWarehouseInBillDetailViewFields.批号);
			this.Fields.Add("生产日期", AllWarehouseInBillDetailViewFields.生产日期);
			this.Fields.Add("有效期至", AllWarehouseInBillDetailViewFields.有效期至);
			this.Fields.Add("订单数量", AllWarehouseInBillDetailViewFields.订单数量);
			this.Fields.Add("明细ID", AllWarehouseInBillDetailViewFields.明细ID);
		}
	}

	#region AllWarehouseInBillDetailViewFields

	public class AllWarehouseInBillDetailViewFields
	{
		public static EntityField 订单ID
		{
			get { return new EntityField("vw_AllWarehouseInBillDetail", 0, "订单ID", SqlDbType.Int); }
		}

		public static EntityField 药品ID
		{
			get { return new EntityField("vw_AllWarehouseInBillDetail", 1, "药品ID", SqlDbType.Int); }
		}

		public static EntityField 药品编号
		{
			get { return new EntityField("vw_AllWarehouseInBillDetail", 2, "药品编号", SqlDbType.NVarChar); }
		}

		public static EntityField 药品名称
		{
			get { return new EntityField("vw_AllWarehouseInBillDetail", 3, "药品名称", SqlDbType.NVarChar); }
		}

		public static EntityField 生产厂商
		{
			get { return new EntityField("vw_AllWarehouseInBillDetail", 4, "生产厂商", SqlDbType.NVarChar); }
		}

		public static EntityField 规格
		{
			get { return new EntityField("vw_AllWarehouseInBillDetail", 5, "规格", SqlDbType.NVarChar); }
		}

		public static EntityField 剂型
		{
			get { return new EntityField("vw_AllWarehouseInBillDetail", 6, "剂型", SqlDbType.NVarChar); }
		}

		public static EntityField 药品类别
		{
			get { return new EntityField("vw_AllWarehouseInBillDetail", 7, "药品类别", SqlDbType.NVarChar); }
		}

		public static EntityField 单位
		{
			get { return new EntityField("vw_AllWarehouseInBillDetail", 8, "单位", SqlDbType.NVarChar); }
		}

		public static EntityField 批号
		{
			get { return new EntityField("vw_AllWarehouseInBillDetail", 9, "批号", SqlDbType.NVarChar); }
		}

		public static EntityField 生产日期
		{
			get { return new EntityField("vw_AllWarehouseInBillDetail", 10, "生产日期", SqlDbType.DateTime); }
		}

		public static EntityField 有效期至
		{
			get { return new EntityField("vw_AllWarehouseInBillDetail", 11, "有效期至", SqlDbType.DateTime); }
		}

		public static EntityField 订单数量
		{
			get { return new EntityField("vw_AllWarehouseInBillDetail", 12, "订单数量", SqlDbType.Int); }
		}

		public static EntityField 明细ID
		{
			get { return new EntityField("vw_AllWarehouseInBillDetail", 13, "明细ID", SqlDbType.Int); }
		}

	}

	#endregion

}
