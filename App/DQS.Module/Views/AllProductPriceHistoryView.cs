/*
 *	Build By: Codey Object Relation Mapping
 *	Build Data: 2014-03-04 22:32:22
 *	Build Type: View
 *	Description: AllProductPriceHistoryView
*/

using System;
using System.Collections.Generic;
using System.Data;
using ORMSCore;

namespace DQS.Module.Views
{
	public class AllProductPriceHistoryView : ViewBase
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

		public int 分类ID
		{
			get { return (int)this.GetValue("分类ID"); } 
			set { this.SetValue("分类ID", value); } 
		}

		public string 价格分类
		{
			get { return (string)this.GetValue("价格分类"); } 
			set { this.SetValue("价格分类", value); } 
		}

		public string 价格分类Spell
		{
			get { return (string)this.GetValue("价格分类Spell"); } 
			set { this.SetValue("价格分类Spell", value); } 
		}

		public double 旧价格元
		{
			get { return (double)this.GetValue("旧价格(元)"); } 
			set { this.SetValue("旧价格(元)", value); } 
		}

		public double 新价格元
		{
			get { return (double)this.GetValue("新价格(元)"); } 
			set { this.SetValue("新价格(元)", value); } 
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

		public string 批准文号
		{
			get { return (string)this.GetValue("批准文号"); } 
			set { this.SetValue("批准文号", value); } 
		}

		public string 生产厂商
		{
			get { return (string)this.GetValue("生产厂商"); } 
			set { this.SetValue("生产厂商", value); } 
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

		public AllProductPriceHistoryView()
		{
			this.ViewName = "vw_AllProductPriceHistory";
			this.Fields = new Dictionary<string, EntityField>();
			this.Fields.Add("药品ID", AllProductPriceHistoryViewFields.药品ID);
			this.Fields.Add("药品编号", AllProductPriceHistoryViewFields.药品编号);
			this.Fields.Add("药品名称", AllProductPriceHistoryViewFields.药品名称);
			this.Fields.Add("药品名称Spell", AllProductPriceHistoryViewFields.药品名称Spell);
			this.Fields.Add("分类ID", AllProductPriceHistoryViewFields.分类ID);
			this.Fields.Add("价格分类", AllProductPriceHistoryViewFields.价格分类);
			this.Fields.Add("价格分类Spell", AllProductPriceHistoryViewFields.价格分类Spell);
			this.Fields.Add("旧价格(元)", AllProductPriceHistoryViewFields.旧价格元);
			this.Fields.Add("新价格(元)", AllProductPriceHistoryViewFields.新价格元);
			this.Fields.Add("规格", AllProductPriceHistoryViewFields.规格);
			this.Fields.Add("剂型", AllProductPriceHistoryViewFields.剂型);
			this.Fields.Add("药品类别", AllProductPriceHistoryViewFields.药品类别);
			this.Fields.Add("批准文号", AllProductPriceHistoryViewFields.批准文号);
			this.Fields.Add("生产厂商", AllProductPriceHistoryViewFields.生产厂商);
			this.Fields.Add("创建人", AllProductPriceHistoryViewFields.创建人);
			this.Fields.Add("创建日期", AllProductPriceHistoryViewFields.创建日期);
			this.Fields.Add("最后修改人", AllProductPriceHistoryViewFields.最后修改人);
			this.Fields.Add("最后修改时间", AllProductPriceHistoryViewFields.最后修改时间);
			this.Fields.Add("备注", AllProductPriceHistoryViewFields.备注);
		}
	}

	#region AllProductPriceHistoryViewFields

	public class AllProductPriceHistoryViewFields
	{
		public static EntityField 药品ID
		{
			get { return new EntityField("vw_AllProductPriceHistory", 0, "药品ID", SqlDbType.Int); }
		}

		public static EntityField 药品编号
		{
			get { return new EntityField("vw_AllProductPriceHistory", 1, "药品编号", SqlDbType.NVarChar); }
		}

		public static EntityField 药品名称
		{
			get { return new EntityField("vw_AllProductPriceHistory", 2, "药品名称", SqlDbType.NVarChar); }
		}

		public static EntityField 药品名称Spell
		{
			get { return new EntityField("vw_AllProductPriceHistory", 3, "药品名称Spell", SqlDbType.NVarChar); }
		}

		public static EntityField 分类ID
		{
			get { return new EntityField("vw_AllProductPriceHistory", 4, "分类ID", SqlDbType.Int); }
		}

		public static EntityField 价格分类
		{
			get { return new EntityField("vw_AllProductPriceHistory", 5, "价格分类", SqlDbType.NVarChar); }
		}

		public static EntityField 价格分类Spell
		{
			get { return new EntityField("vw_AllProductPriceHistory", 6, "价格分类Spell", SqlDbType.NVarChar); }
		}

		public static EntityField 旧价格元
		{
			get { return new EntityField("vw_AllProductPriceHistory", 7, "旧价格(元)", SqlDbType.Float); }
		}

		public static EntityField 新价格元
		{
			get { return new EntityField("vw_AllProductPriceHistory", 8, "新价格(元)", SqlDbType.Float); }
		}

		public static EntityField 规格
		{
			get { return new EntityField("vw_AllProductPriceHistory", 9, "规格", SqlDbType.NVarChar); }
		}

		public static EntityField 剂型
		{
			get { return new EntityField("vw_AllProductPriceHistory", 10, "剂型", SqlDbType.NVarChar); }
		}

		public static EntityField 药品类别
		{
			get { return new EntityField("vw_AllProductPriceHistory", 11, "药品类别", SqlDbType.NVarChar); }
		}

		public static EntityField 批准文号
		{
			get { return new EntityField("vw_AllProductPriceHistory", 12, "批准文号", SqlDbType.NVarChar); }
		}

		public static EntityField 生产厂商
		{
			get { return new EntityField("vw_AllProductPriceHistory", 13, "生产厂商", SqlDbType.NVarChar); }
		}

		public static EntityField 创建人
		{
			get { return new EntityField("vw_AllProductPriceHistory", 14, "创建人", SqlDbType.NVarChar); }
		}

		public static EntityField 创建日期
		{
			get { return new EntityField("vw_AllProductPriceHistory", 15, "创建日期", SqlDbType.DateTime); }
		}

		public static EntityField 最后修改人
		{
			get { return new EntityField("vw_AllProductPriceHistory", 16, "最后修改人", SqlDbType.NVarChar); }
		}

		public static EntityField 最后修改时间
		{
			get { return new EntityField("vw_AllProductPriceHistory", 17, "最后修改时间", SqlDbType.DateTime); }
		}

		public static EntityField 备注
		{
			get { return new EntityField("vw_AllProductPriceHistory", 18, "备注", SqlDbType.NVarChar); }
		}

	}

	#endregion

}
