/*
 *	Build By: Codey Object Relation Mapping
 *	Build Data: 2014-03-04 22:32:22
 *	Build Type: View
 *	Description: ProductSummaryAmountView
*/

using System;
using System.Collections.Generic;
using System.Data;
using ORMSCore;

namespace DQS.Module.Views
{
	public class ProductSummaryAmountView : ViewBase
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

		public int 库存总量
		{
			get { return (int)this.GetValue("库存总量"); } 
			set { this.SetValue("库存总量", value); } 
		}

		public ProductSummaryAmountView()
		{
			this.ViewName = "vw_ProductSummaryAmount";
			this.Fields = new Dictionary<string, EntityField>();
			this.Fields.Add("药品ID", ProductSummaryAmountViewFields.药品ID);
			this.Fields.Add("药品编号", ProductSummaryAmountViewFields.药品编号);
			this.Fields.Add("药品名称", ProductSummaryAmountViewFields.药品名称);
			this.Fields.Add("药品名称Spell", ProductSummaryAmountViewFields.药品名称Spell);
			this.Fields.Add("生产厂商", ProductSummaryAmountViewFields.生产厂商);
			this.Fields.Add("规格", ProductSummaryAmountViewFields.规格);
			this.Fields.Add("剂型", ProductSummaryAmountViewFields.剂型);
			this.Fields.Add("药品类别", ProductSummaryAmountViewFields.药品类别);
			this.Fields.Add("单位", ProductSummaryAmountViewFields.单位);
			this.Fields.Add("库存总量", ProductSummaryAmountViewFields.库存总量);
		}
	}

	#region ProductSummaryAmountViewFields

	public class ProductSummaryAmountViewFields
	{
		public static EntityField 药品ID
		{
			get { return new EntityField("vw_ProductSummaryAmount", 0, "药品ID", SqlDbType.Int); }
		}

		public static EntityField 药品编号
		{
			get { return new EntityField("vw_ProductSummaryAmount", 1, "药品编号", SqlDbType.NVarChar); }
		}

		public static EntityField 药品名称
		{
			get { return new EntityField("vw_ProductSummaryAmount", 2, "药品名称", SqlDbType.NVarChar); }
		}

		public static EntityField 药品名称Spell
		{
			get { return new EntityField("vw_ProductSummaryAmount", 3, "药品名称Spell", SqlDbType.NVarChar); }
		}

		public static EntityField 生产厂商
		{
			get { return new EntityField("vw_ProductSummaryAmount", 4, "生产厂商", SqlDbType.NVarChar); }
		}

		public static EntityField 规格
		{
			get { return new EntityField("vw_ProductSummaryAmount", 5, "规格", SqlDbType.NVarChar); }
		}

		public static EntityField 剂型
		{
			get { return new EntityField("vw_ProductSummaryAmount", 6, "剂型", SqlDbType.NVarChar); }
		}

		public static EntityField 药品类别
		{
			get { return new EntityField("vw_ProductSummaryAmount", 7, "药品类别", SqlDbType.NVarChar); }
		}

		public static EntityField 单位
		{
			get { return new EntityField("vw_ProductSummaryAmount", 8, "单位", SqlDbType.NVarChar); }
		}

		public static EntityField 库存总量
		{
			get { return new EntityField("vw_ProductSummaryAmount", 9, "库存总量", SqlDbType.Int); }
		}

	}

	#endregion

}
