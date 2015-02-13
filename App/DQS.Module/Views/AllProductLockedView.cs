/*
 *	Build By: Codey Object Relation Mapping
 *	Build Data: 2014-03-04 22:32:22
 *	Build Type: View
 *	Description: AllProductLockedView
*/

using System;
using System.Collections.Generic;
using System.Data;
using ORMSCore;

namespace DQS.Module.Views
{
	public class AllProductLockedView : ViewBase
	{
		public int 记录ID
		{
			get { return (int)this.GetValue("记录ID"); } 
			set { this.SetValue("记录ID", value); } 
		}

		public string 记录编号
		{
			get { return (string)this.GetValue("记录编号"); } 
			set { this.SetValue("记录编号", value); } 
		}

		public string 锁定人
		{
			get { return (string)this.GetValue("锁定人"); } 
			set { this.SetValue("锁定人", value); } 
		}

		public DateTime 锁定时间
		{
			get { return (DateTime)this.GetValue("锁定时间"); } 
			set { this.SetValue("锁定时间", value); } 
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

		public bool 是否锁定批次
		{
			get { return (bool)this.GetValue("是否锁定批次"); } 
			set { this.SetValue("是否锁定批次", value); } 
		}

		public string 锁定的批号
		{
			get { return (string)this.GetValue("锁定的批号"); } 
			set { this.SetValue("锁定的批号", value); } 
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

		public int 锁定的数量
		{
			get { return (int)this.GetValue("锁定的数量"); } 
			set { this.SetValue("锁定的数量", value); } 
		}

		public bool 是否解除锁定
		{
			get { return (bool)this.GetValue("是否解除锁定"); } 
			set { this.SetValue("是否解除锁定", value); } 
		}

		public string 解除人
		{
			get { return (string)this.GetValue("解除人"); } 
			set { this.SetValue("解除人", value); } 
		}

		public string 处理结果
		{
			get { return (string)this.GetValue("处理结果"); } 
			set { this.SetValue("处理结果", value); } 
		}

		public DateTime 解除时间
		{
			get { return (DateTime)this.GetValue("解除时间"); } 
			set { this.SetValue("解除时间", value); } 
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

		public string 最后修改人
		{
			get { return (string)this.GetValue("最后修改人"); } 
			set { this.SetValue("最后修改人", value); } 
		}

		public DateTime 最后修改时间
		{
			get { return (DateTime)this.GetValue("最后修改时间"); } 
			set { this.SetValue("最后修改时间", value); } 
		}

		public string 备注
		{
			get { return (string)this.GetValue("备注"); } 
			set { this.SetValue("备注", value); } 
		}

		public AllProductLockedView()
		{
			this.ViewName = "vw_AllProductLocked";
			this.Fields = new Dictionary<string, EntityField>();
			this.Fields.Add("记录ID", AllProductLockedViewFields.记录ID);
			this.Fields.Add("记录编号", AllProductLockedViewFields.记录编号);
			this.Fields.Add("锁定人", AllProductLockedViewFields.锁定人);
			this.Fields.Add("锁定时间", AllProductLockedViewFields.锁定时间);
			this.Fields.Add("药品编号", AllProductLockedViewFields.药品编号);
			this.Fields.Add("药品名称", AllProductLockedViewFields.药品名称);
			this.Fields.Add("药品名称Spell", AllProductLockedViewFields.药品名称Spell);
			this.Fields.Add("生产厂商", AllProductLockedViewFields.生产厂商);
			this.Fields.Add("规格", AllProductLockedViewFields.规格);
			this.Fields.Add("剂型", AllProductLockedViewFields.剂型);
			this.Fields.Add("药品类别", AllProductLockedViewFields.药品类别);
			this.Fields.Add("单位", AllProductLockedViewFields.单位);
			this.Fields.Add("是否锁定批次", AllProductLockedViewFields.是否锁定批次);
			this.Fields.Add("锁定的批号", AllProductLockedViewFields.锁定的批号);
			this.Fields.Add("生产日期", AllProductLockedViewFields.生产日期);
			this.Fields.Add("有效期至", AllProductLockedViewFields.有效期至);
			this.Fields.Add("锁定的数量", AllProductLockedViewFields.锁定的数量);
			this.Fields.Add("是否解除锁定", AllProductLockedViewFields.是否解除锁定);
			this.Fields.Add("解除人", AllProductLockedViewFields.解除人);
			this.Fields.Add("处理结果", AllProductLockedViewFields.处理结果);
			this.Fields.Add("解除时间", AllProductLockedViewFields.解除时间);
			this.Fields.Add("创建人", AllProductLockedViewFields.创建人);
			this.Fields.Add("创建日期", AllProductLockedViewFields.创建日期);
			this.Fields.Add("最后修改人", AllProductLockedViewFields.最后修改人);
			this.Fields.Add("最后修改时间", AllProductLockedViewFields.最后修改时间);
			this.Fields.Add("备注", AllProductLockedViewFields.备注);
		}
	}

	#region AllProductLockedViewFields

	public class AllProductLockedViewFields
	{
		public static EntityField 记录ID
		{
			get { return new EntityField("vw_AllProductLocked", 0, "记录ID", SqlDbType.Int); }
		}

		public static EntityField 记录编号
		{
			get { return new EntityField("vw_AllProductLocked", 1, "记录编号", SqlDbType.NVarChar); }
		}

		public static EntityField 锁定人
		{
			get { return new EntityField("vw_AllProductLocked", 2, "锁定人", SqlDbType.NVarChar); }
		}

		public static EntityField 锁定时间
		{
			get { return new EntityField("vw_AllProductLocked", 3, "锁定时间", SqlDbType.DateTime); }
		}

		public static EntityField 药品编号
		{
			get { return new EntityField("vw_AllProductLocked", 4, "药品编号", SqlDbType.NVarChar); }
		}

		public static EntityField 药品名称
		{
			get { return new EntityField("vw_AllProductLocked", 5, "药品名称", SqlDbType.NVarChar); }
		}

		public static EntityField 药品名称Spell
		{
			get { return new EntityField("vw_AllProductLocked", 6, "药品名称Spell", SqlDbType.NVarChar); }
		}

		public static EntityField 生产厂商
		{
			get { return new EntityField("vw_AllProductLocked", 7, "生产厂商", SqlDbType.NVarChar); }
		}

		public static EntityField 规格
		{
			get { return new EntityField("vw_AllProductLocked", 8, "规格", SqlDbType.NVarChar); }
		}

		public static EntityField 剂型
		{
			get { return new EntityField("vw_AllProductLocked", 9, "剂型", SqlDbType.NVarChar); }
		}

		public static EntityField 药品类别
		{
			get { return new EntityField("vw_AllProductLocked", 10, "药品类别", SqlDbType.NVarChar); }
		}

		public static EntityField 单位
		{
			get { return new EntityField("vw_AllProductLocked", 11, "单位", SqlDbType.NVarChar); }
		}

		public static EntityField 是否锁定批次
		{
			get { return new EntityField("vw_AllProductLocked", 12, "是否锁定批次", SqlDbType.Bit); }
		}

		public static EntityField 锁定的批号
		{
			get { return new EntityField("vw_AllProductLocked", 13, "锁定的批号", SqlDbType.NVarChar); }
		}

		public static EntityField 生产日期
		{
			get { return new EntityField("vw_AllProductLocked", 14, "生产日期", SqlDbType.DateTime); }
		}

		public static EntityField 有效期至
		{
			get { return new EntityField("vw_AllProductLocked", 15, "有效期至", SqlDbType.DateTime); }
		}

		public static EntityField 锁定的数量
		{
			get { return new EntityField("vw_AllProductLocked", 16, "锁定的数量", SqlDbType.Int); }
		}

		public static EntityField 是否解除锁定
		{
			get { return new EntityField("vw_AllProductLocked", 17, "是否解除锁定", SqlDbType.Bit); }
		}

		public static EntityField 解除人
		{
			get { return new EntityField("vw_AllProductLocked", 18, "解除人", SqlDbType.NVarChar); }
		}

		public static EntityField 处理结果
		{
			get { return new EntityField("vw_AllProductLocked", 19, "处理结果", SqlDbType.NVarChar); }
		}

		public static EntityField 解除时间
		{
			get { return new EntityField("vw_AllProductLocked", 20, "解除时间", SqlDbType.DateTime); }
		}

		public static EntityField 创建人
		{
			get { return new EntityField("vw_AllProductLocked", 21, "创建人", SqlDbType.NVarChar); }
		}

		public static EntityField 创建日期
		{
			get { return new EntityField("vw_AllProductLocked", 22, "创建日期", SqlDbType.DateTime); }
		}

		public static EntityField 最后修改人
		{
			get { return new EntityField("vw_AllProductLocked", 23, "最后修改人", SqlDbType.NVarChar); }
		}

		public static EntityField 最后修改时间
		{
			get { return new EntityField("vw_AllProductLocked", 24, "最后修改时间", SqlDbType.DateTime); }
		}

		public static EntityField 备注
		{
			get { return new EntityField("vw_AllProductLocked", 25, "备注", SqlDbType.NVarChar); }
		}

	}

	#endregion

}
