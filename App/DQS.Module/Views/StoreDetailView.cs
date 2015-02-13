/*
 *	Build By: Codey Object Relation Mapping
 *	Build Data: 2014-03-04 22:32:22
 *	Build Type: View
 *	Description: StoreDetailView
*/

using System;
using System.Collections.Generic;
using System.Data;
using ORMSCore;

namespace DQS.Module.Views
{
	public class StoreDetailView : ViewBase
	{
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

		public string 生产厂商Spell
		{
			get { return (string)this.GetValue("生产厂商Spell"); } 
			set { this.SetValue("生产厂商Spell", value); } 
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

		public string 过期状态
		{
			get { return (string)this.GetValue("过期状态"); } 
			set { this.SetValue("过期状态", value); } 
		}

		public StoreDetailView()
		{
			this.ViewName = "vw_StoreDetail";
			this.Fields = new Dictionary<string, EntityField>();
			this.Fields.Add("药品ID", StoreDetailViewFields.药品ID);
			this.Fields.Add("药品编号", StoreDetailViewFields.药品编号);
			this.Fields.Add("药品名称", StoreDetailViewFields.药品名称);
			this.Fields.Add("药品名称Spell", StoreDetailViewFields.药品名称Spell);
			this.Fields.Add("生产厂商", StoreDetailViewFields.生产厂商);
			this.Fields.Add("生产厂商Spell", StoreDetailViewFields.生产厂商Spell);
			this.Fields.Add("规格", StoreDetailViewFields.规格);
			this.Fields.Add("剂型", StoreDetailViewFields.剂型);
			this.Fields.Add("药品类别", StoreDetailViewFields.药品类别);
			this.Fields.Add("单位", StoreDetailViewFields.单位);
			this.Fields.Add("批号", StoreDetailViewFields.批号);
			this.Fields.Add("生产日期", StoreDetailViewFields.生产日期);
			this.Fields.Add("有效期至", StoreDetailViewFields.有效期至);
			this.Fields.Add("库存数量", StoreDetailViewFields.库存数量);
			this.Fields.Add("过期状态", StoreDetailViewFields.过期状态);
		}
	}

	#region StoreDetailViewFields

	public class StoreDetailViewFields
	{
		public static EntityField 药品ID
		{
			get { return new EntityField("vw_StoreDetail", 0, "药品ID", SqlDbType.Int); }
		}

		public static EntityField 药品编号
		{
			get { return new EntityField("vw_StoreDetail", 1, "药品编号", SqlDbType.NVarChar); }
		}

		public static EntityField 药品名称
		{
			get { return new EntityField("vw_StoreDetail", 2, "药品名称", SqlDbType.NVarChar); }
		}

		public static EntityField 药品名称Spell
		{
			get { return new EntityField("vw_StoreDetail", 3, "药品名称Spell", SqlDbType.NVarChar); }
		}

		public static EntityField 生产厂商
		{
			get { return new EntityField("vw_StoreDetail", 4, "生产厂商", SqlDbType.NVarChar); }
		}

		public static EntityField 生产厂商Spell
		{
			get { return new EntityField("vw_StoreDetail", 5, "生产厂商Spell", SqlDbType.NVarChar); }
		}

		public static EntityField 规格
		{
			get { return new EntityField("vw_StoreDetail", 6, "规格", SqlDbType.NVarChar); }
		}

		public static EntityField 剂型
		{
			get { return new EntityField("vw_StoreDetail", 7, "剂型", SqlDbType.NVarChar); }
		}

		public static EntityField 药品类别
		{
			get { return new EntityField("vw_StoreDetail", 8, "药品类别", SqlDbType.NVarChar); }
		}

		public static EntityField 单位
		{
			get { return new EntityField("vw_StoreDetail", 9, "单位", SqlDbType.NVarChar); }
		}

		public static EntityField 批号
		{
			get { return new EntityField("vw_StoreDetail", 10, "批号", SqlDbType.NVarChar); }
		}

		public static EntityField 生产日期
		{
			get { return new EntityField("vw_StoreDetail", 11, "生产日期", SqlDbType.DateTime); }
		}

		public static EntityField 有效期至
		{
			get { return new EntityField("vw_StoreDetail", 12, "有效期至", SqlDbType.DateTime); }
		}

		public static EntityField 库存数量
		{
			get { return new EntityField("vw_StoreDetail", 13, "库存数量", SqlDbType.Int); }
		}

		public static EntityField 过期状态
		{
			get { return new EntityField("vw_StoreDetail", 14, "过期状态", SqlDbType.VarChar); }
		}

	}

	#endregion

}
