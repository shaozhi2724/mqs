/*
 *	Build By: Codey Object Relation Mapping
 *	Build Data: 2014-03-04 22:32:22
 *	Build Type: View
 *	Description: AllProdcutDestroyDetailView
*/

using System;
using System.Collections.Generic;
using System.Data;
using ORMSCore;

namespace DQS.Module.Views
{
	public class AllProdcutDestroyDetailView : ViewBase
	{
		public int 记录ID
		{
			get { return (int)this.GetValue("记录ID"); } 
			set { this.SetValue("记录ID", value); } 
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

		public int 数量
		{
			get { return (int)this.GetValue("数量"); } 
			set { this.SetValue("数量", value); } 
		}

		public string 明细原因
		{
			get { return (string)this.GetValue("明细原因"); } 
			set { this.SetValue("明细原因", value); } 
		}

		public string 明细备注
		{
			get { return (string)this.GetValue("明细备注"); } 
			set { this.SetValue("明细备注", value); } 
		}

		public int 明细ID
		{
			get { return (int)this.GetValue("明细ID"); } 
			set { this.SetValue("明细ID", value); } 
		}

		public AllProdcutDestroyDetailView()
		{
			this.ViewName = "vw_AllProdcutDestroyDetail";
			this.Fields = new Dictionary<string, EntityField>();
			this.Fields.Add("记录ID", AllProdcutDestroyDetailViewFields.记录ID);
			this.Fields.Add("药品ID", AllProdcutDestroyDetailViewFields.药品ID);
			this.Fields.Add("药品编号", AllProdcutDestroyDetailViewFields.药品编号);
			this.Fields.Add("药品名称", AllProdcutDestroyDetailViewFields.药品名称);
			this.Fields.Add("生产厂商", AllProdcutDestroyDetailViewFields.生产厂商);
			this.Fields.Add("规格", AllProdcutDestroyDetailViewFields.规格);
			this.Fields.Add("剂型", AllProdcutDestroyDetailViewFields.剂型);
			this.Fields.Add("药品类别", AllProdcutDestroyDetailViewFields.药品类别);
			this.Fields.Add("单位", AllProdcutDestroyDetailViewFields.单位);
			this.Fields.Add("批号", AllProdcutDestroyDetailViewFields.批号);
			this.Fields.Add("生产日期", AllProdcutDestroyDetailViewFields.生产日期);
			this.Fields.Add("有效期至", AllProdcutDestroyDetailViewFields.有效期至);
			this.Fields.Add("数量", AllProdcutDestroyDetailViewFields.数量);
			this.Fields.Add("明细原因", AllProdcutDestroyDetailViewFields.明细原因);
			this.Fields.Add("明细备注", AllProdcutDestroyDetailViewFields.明细备注);
			this.Fields.Add("明细ID", AllProdcutDestroyDetailViewFields.明细ID);
		}
	}

	#region AllProdcutDestroyDetailViewFields

	public class AllProdcutDestroyDetailViewFields
	{
		public static EntityField 记录ID
		{
			get { return new EntityField("vw_AllProdcutDestroyDetail", 0, "记录ID", SqlDbType.Int); }
		}

		public static EntityField 药品ID
		{
			get { return new EntityField("vw_AllProdcutDestroyDetail", 1, "药品ID", SqlDbType.Int); }
		}

		public static EntityField 药品编号
		{
			get { return new EntityField("vw_AllProdcutDestroyDetail", 2, "药品编号", SqlDbType.NVarChar); }
		}

		public static EntityField 药品名称
		{
			get { return new EntityField("vw_AllProdcutDestroyDetail", 3, "药品名称", SqlDbType.NVarChar); }
		}

		public static EntityField 生产厂商
		{
			get { return new EntityField("vw_AllProdcutDestroyDetail", 4, "生产厂商", SqlDbType.NVarChar); }
		}

		public static EntityField 规格
		{
			get { return new EntityField("vw_AllProdcutDestroyDetail", 5, "规格", SqlDbType.NVarChar); }
		}

		public static EntityField 剂型
		{
			get { return new EntityField("vw_AllProdcutDestroyDetail", 6, "剂型", SqlDbType.NVarChar); }
		}

		public static EntityField 药品类别
		{
			get { return new EntityField("vw_AllProdcutDestroyDetail", 7, "药品类别", SqlDbType.NVarChar); }
		}

		public static EntityField 单位
		{
			get { return new EntityField("vw_AllProdcutDestroyDetail", 8, "单位", SqlDbType.NVarChar); }
		}

		public static EntityField 批号
		{
			get { return new EntityField("vw_AllProdcutDestroyDetail", 9, "批号", SqlDbType.NVarChar); }
		}

		public static EntityField 生产日期
		{
			get { return new EntityField("vw_AllProdcutDestroyDetail", 10, "生产日期", SqlDbType.DateTime); }
		}

		public static EntityField 有效期至
		{
			get { return new EntityField("vw_AllProdcutDestroyDetail", 11, "有效期至", SqlDbType.DateTime); }
		}

		public static EntityField 数量
		{
			get { return new EntityField("vw_AllProdcutDestroyDetail", 12, "数量", SqlDbType.Int); }
		}

		public static EntityField 明细原因
		{
			get { return new EntityField("vw_AllProdcutDestroyDetail", 13, "明细原因", SqlDbType.NVarChar); }
		}

		public static EntityField 明细备注
		{
			get { return new EntityField("vw_AllProdcutDestroyDetail", 14, "明细备注", SqlDbType.VarChar); }
		}

		public static EntityField 明细ID
		{
			get { return new EntityField("vw_AllProdcutDestroyDetail", 15, "明细ID", SqlDbType.Int); }
		}

	}

	#endregion

}
