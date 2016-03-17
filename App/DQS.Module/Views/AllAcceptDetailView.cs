/*
 *	Build By: Codey Object Relation Mapping
 *	Build Data: 2014-03-04 22:32:22
 *	Build Type: View
 *	Description: AllAcceptDetailView
*/

using System;
using System.Collections.Generic;
using System.Data;
using ORMSCore;

namespace DQS.Module.Views
{
	public class AllAcceptDetailView : ViewBase
	{
		public int 验收单ID
		{
			get { return (int)this.GetValue("验收单ID"); } 
			set { this.SetValue("验收单ID", value); } 
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

		public int 收货数量
		{
			get { return (int)this.GetValue("收货数量"); } 
			set { this.SetValue("收货数量", value); } 
		}

		public int 验收合格数量
		{
			get { return (int)this.GetValue("验收合格数量"); } 
			set { this.SetValue("验收合格数量", value); } 
		}

		public int 验收不合格数量
		{
			get { return (int)this.GetValue("验收不合格数量"); } 
			set { this.SetValue("验收不合格数量", value); } 
		}

		public string 验收状况
		{
			get { return (string)this.GetValue("验收状况"); } 
			set { this.SetValue("验收状况", value); } 
		}

		public string 验收结果
		{
			get { return (string)this.GetValue("验收结果"); } 
			set { this.SetValue("验收结果", value); } 
		}

		public int 订单ID
		{
			get { return (int)this.GetValue("订单ID"); } 
			set { this.SetValue("订单ID", value); } 
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

		public AllAcceptDetailView()
		{
			this.ViewName = "vw_AllAcceptDetail";
			this.Fields = new Dictionary<string, EntityField>();
			this.Fields.Add("验收单ID", AllAcceptDetailViewFields.验收单ID);
			this.Fields.Add("产品ID", AllAcceptDetailViewFields.产品ID);
			this.Fields.Add("产品编号", AllAcceptDetailViewFields.产品编号);
			this.Fields.Add("产品名称", AllAcceptDetailViewFields.产品名称);
			this.Fields.Add("生产厂商", AllAcceptDetailViewFields.生产厂商);
			this.Fields.Add("规格型号", AllAcceptDetailViewFields.规格型号);
			this.Fields.Add("剂型", AllAcceptDetailViewFields.剂型);
			this.Fields.Add("产品类别", AllAcceptDetailViewFields.产品类别);
			this.Fields.Add("单位", AllAcceptDetailViewFields.单位);
			this.Fields.Add("批号", AllAcceptDetailViewFields.批号);
			this.Fields.Add("生产日期", AllAcceptDetailViewFields.生产日期);
			this.Fields.Add("有效期至", AllAcceptDetailViewFields.有效期至);
			this.Fields.Add("订单数量", AllAcceptDetailViewFields.订单数量);
			this.Fields.Add("收货数量", AllAcceptDetailViewFields.收货数量);
			this.Fields.Add("验收合格数量", AllAcceptDetailViewFields.验收合格数量);
			this.Fields.Add("验收不合格数量", AllAcceptDetailViewFields.验收不合格数量);
			this.Fields.Add("验收状况", AllAcceptDetailViewFields.验收状况);
			this.Fields.Add("验收结果", AllAcceptDetailViewFields.验收结果);
			this.Fields.Add("订单ID", AllAcceptDetailViewFields.订单ID);
			this.Fields.Add("货位编号", AllAcceptDetailViewFields.货位编号);
			this.Fields.Add("货位名称", AllAcceptDetailViewFields.货位名称);
			this.Fields.Add("货位位置", AllAcceptDetailViewFields.货位位置);
		}
	}

	#region AllAcceptDetailViewFields

	public class AllAcceptDetailViewFields
	{
		public static EntityField 验收单ID
		{
			get { return new EntityField("vw_AllAcceptDetail", 0, "验收单ID", SqlDbType.Int); }
		}

		public static EntityField 产品ID
		{
			get { return new EntityField("vw_AllAcceptDetail", 1, "产品ID", SqlDbType.Int); }
		}

		public static EntityField 产品编号
		{
			get { return new EntityField("vw_AllAcceptDetail", 2, "产品编号", SqlDbType.NVarChar); }
		}

		public static EntityField 产品名称
		{
			get { return new EntityField("vw_AllAcceptDetail", 3, "产品名称", SqlDbType.NVarChar); }
		}

		public static EntityField 生产厂商
		{
			get { return new EntityField("vw_AllAcceptDetail", 4, "生产厂商", SqlDbType.NVarChar); }
		}

		public static EntityField 规格型号
		{
			get { return new EntityField("vw_AllAcceptDetail", 5, "规格型号", SqlDbType.NVarChar); }
		}

		public static EntityField 剂型
		{
			get { return new EntityField("vw_AllAcceptDetail", 6, "剂型", SqlDbType.NVarChar); }
		}

		public static EntityField 产品类别
		{
			get { return new EntityField("vw_AllAcceptDetail", 7, "产品类别", SqlDbType.NVarChar); }
		}

		public static EntityField 单位
		{
			get { return new EntityField("vw_AllAcceptDetail", 8, "单位", SqlDbType.NVarChar); }
		}

		public static EntityField 批号
		{
			get { return new EntityField("vw_AllAcceptDetail", 9, "批号", SqlDbType.NVarChar); }
		}

		public static EntityField 生产日期
		{
			get { return new EntityField("vw_AllAcceptDetail", 10, "生产日期", SqlDbType.DateTime); }
		}

		public static EntityField 有效期至
		{
			get { return new EntityField("vw_AllAcceptDetail", 11, "有效期至", SqlDbType.DateTime); }
		}

		public static EntityField 订单数量
		{
			get { return new EntityField("vw_AllAcceptDetail", 12, "订单数量", SqlDbType.Int); }
		}

		public static EntityField 收货数量
		{
			get { return new EntityField("vw_AllAcceptDetail", 13, "收货数量", SqlDbType.Int); }
		}

		public static EntityField 验收合格数量
		{
			get { return new EntityField("vw_AllAcceptDetail", 14, "验收合格数量", SqlDbType.Int); }
		}

		public static EntityField 验收不合格数量
		{
			get { return new EntityField("vw_AllAcceptDetail", 15, "验收不合格数量", SqlDbType.Int); }
		}

		public static EntityField 验收状况
		{
			get { return new EntityField("vw_AllAcceptDetail", 16, "验收状况", SqlDbType.NVarChar); }
		}

		public static EntityField 验收结果
		{
			get { return new EntityField("vw_AllAcceptDetail", 17, "验收结果", SqlDbType.NVarChar); }
		}

		public static EntityField 订单ID
		{
			get { return new EntityField("vw_AllAcceptDetail", 18, "订单ID", SqlDbType.Int); }
		}

		public static EntityField 货位编号
		{
			get { return new EntityField("vw_AllAcceptDetail", 19, "货位编号", SqlDbType.NVarChar); }
		}

		public static EntityField 货位名称
		{
			get { return new EntityField("vw_AllAcceptDetail", 20, "货位名称", SqlDbType.NVarChar); }
		}

		public static EntityField 货位位置
		{
			get { return new EntityField("vw_AllAcceptDetail", 21, "货位位置", SqlDbType.NVarChar); }
		}

	}

	#endregion

}
