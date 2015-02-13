/*
 *	Build By: Codey Object Relation Mapping
 *	Build Data: 2014-03-04 22:32:22
 *	Build Type: View
 *	Description: AllInventoryDetailView
*/

using System;
using System.Collections.Generic;
using System.Data;
using ORMSCore;

namespace DQS.Module.Views
{
	public class AllInventoryDetailView : ViewBase
	{
		public int 盘点ID
		{
			get { return (int)this.GetValue("盘点ID"); } 
			set { this.SetValue("盘点ID", value); } 
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

		public string 药品名称Spell
		{
			get { return (string)this.GetValue("药品名称Spell"); } 
			set { this.SetValue("药品名称Spell", value); } 
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

		public int 盘点数量
		{
			get { return (int)this.GetValue("盘点数量"); } 
			set { this.SetValue("盘点数量", value); } 
		}

		public int 差异数量
		{
			get { return (int)this.GetValue("差异数量"); } 
			set { this.SetValue("差异数量", value); } 
		}

		public string 盘点结果
		{
			get { return (string)this.GetValue("盘点结果"); } 
			set { this.SetValue("盘点结果", value); } 
		}

		public int 明细ID
		{
			get { return (int)this.GetValue("明细ID"); } 
			set { this.SetValue("明细ID", value); } 
		}

		public AllInventoryDetailView()
		{
			this.ViewName = "vw_AllInventoryDetail";
			this.Fields = new Dictionary<string, EntityField>();
			this.Fields.Add("盘点ID", AllInventoryDetailViewFields.盘点ID);
			this.Fields.Add("药品ID", AllInventoryDetailViewFields.药品ID);
			this.Fields.Add("药品编号", AllInventoryDetailViewFields.药品编号);
			this.Fields.Add("药品名称", AllInventoryDetailViewFields.药品名称);
			this.Fields.Add("药品名称Spell", AllInventoryDetailViewFields.药品名称Spell);
			this.Fields.Add("生产厂商", AllInventoryDetailViewFields.生产厂商);
			this.Fields.Add("规格", AllInventoryDetailViewFields.规格);
			this.Fields.Add("剂型", AllInventoryDetailViewFields.剂型);
			this.Fields.Add("药品类别", AllInventoryDetailViewFields.药品类别);
			this.Fields.Add("单位", AllInventoryDetailViewFields.单位);
			this.Fields.Add("批号", AllInventoryDetailViewFields.批号);
			this.Fields.Add("生产日期", AllInventoryDetailViewFields.生产日期);
			this.Fields.Add("有效期至", AllInventoryDetailViewFields.有效期至);
			this.Fields.Add("库存数量", AllInventoryDetailViewFields.库存数量);
			this.Fields.Add("盘点数量", AllInventoryDetailViewFields.盘点数量);
			this.Fields.Add("差异数量", AllInventoryDetailViewFields.差异数量);
			this.Fields.Add("盘点结果", AllInventoryDetailViewFields.盘点结果);
			this.Fields.Add("明细ID", AllInventoryDetailViewFields.明细ID);
		}
	}

	#region AllInventoryDetailViewFields

	public class AllInventoryDetailViewFields
	{
		public static EntityField 盘点ID
		{
			get { return new EntityField("vw_AllInventoryDetail", 0, "盘点ID", SqlDbType.Int); }
		}

		public static EntityField 药品ID
		{
			get { return new EntityField("vw_AllInventoryDetail", 1, "药品ID", SqlDbType.Int); }
		}

		public static EntityField 药品编号
		{
			get { return new EntityField("vw_AllInventoryDetail", 2, "药品编号", SqlDbType.NVarChar); }
		}

		public static EntityField 药品名称
		{
			get { return new EntityField("vw_AllInventoryDetail", 3, "药品名称", SqlDbType.NVarChar); }
		}

		public static EntityField 药品名称Spell
		{
			get { return new EntityField("vw_AllInventoryDetail", 4, "药品名称Spell", SqlDbType.NVarChar); }
		}

		public static EntityField 生产厂商
		{
			get { return new EntityField("vw_AllInventoryDetail", 5, "生产厂商", SqlDbType.NVarChar); }
		}

		public static EntityField 规格
		{
			get { return new EntityField("vw_AllInventoryDetail", 6, "规格", SqlDbType.NVarChar); }
		}

		public static EntityField 剂型
		{
			get { return new EntityField("vw_AllInventoryDetail", 7, "剂型", SqlDbType.NVarChar); }
		}

		public static EntityField 药品类别
		{
			get { return new EntityField("vw_AllInventoryDetail", 8, "药品类别", SqlDbType.NVarChar); }
		}

		public static EntityField 单位
		{
			get { return new EntityField("vw_AllInventoryDetail", 9, "单位", SqlDbType.NVarChar); }
		}

		public static EntityField 批号
		{
			get { return new EntityField("vw_AllInventoryDetail", 10, "批号", SqlDbType.NVarChar); }
		}

		public static EntityField 生产日期
		{
			get { return new EntityField("vw_AllInventoryDetail", 11, "生产日期", SqlDbType.DateTime); }
		}

		public static EntityField 有效期至
		{
			get { return new EntityField("vw_AllInventoryDetail", 12, "有效期至", SqlDbType.DateTime); }
		}

		public static EntityField 库存数量
		{
			get { return new EntityField("vw_AllInventoryDetail", 13, "库存数量", SqlDbType.Int); }
		}

		public static EntityField 盘点数量
		{
			get { return new EntityField("vw_AllInventoryDetail", 14, "盘点数量", SqlDbType.Int); }
		}

		public static EntityField 差异数量
		{
			get { return new EntityField("vw_AllInventoryDetail", 15, "差异数量", SqlDbType.Int); }
		}

		public static EntityField 盘点结果
		{
			get { return new EntityField("vw_AllInventoryDetail", 16, "盘点结果", SqlDbType.NVarChar); }
		}

		public static EntityField 明细ID
		{
			get { return new EntityField("vw_AllInventoryDetail", 17, "明细ID", SqlDbType.Int); }
		}

	}

	#endregion

}
