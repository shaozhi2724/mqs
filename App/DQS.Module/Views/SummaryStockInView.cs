/*
 *	Build By: Codey Object Relation Mapping
 *	Build Data: 2014-03-04 22:32:22
 *	Build Type: View
 *	Description: SummaryStockInView
*/

using System;
using System.Collections.Generic;
using System.Data;
using ORMSCore;

namespace DQS.Module.Views
{
	public class SummaryStockInView : ViewBase
	{
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

		public string 产品名称Spell
		{
			get { return (string)this.GetValue("产品名称Spell"); } 
			set { this.SetValue("产品名称Spell", value); } 
		}

		public string 规格型号
		{
			get { return (string)this.GetValue("规格型号"); } 
			set { this.SetValue("规格型号", value); } 
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

		public string 注册证号
		{
			get { return (string)this.GetValue("注册证号"); } 
			set { this.SetValue("注册证号", value); } 
		}

		public string 包装规格
		{
			get { return (string)this.GetValue("包装规格型号"); } 
			set { this.SetValue("包装规格型号", value); } 
		}

		public string 单位
		{
			get { return (string)this.GetValue("单位"); } 
			set { this.SetValue("单位", value); } 
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

		public int 入库总量
		{
			get { return (int)this.GetValue("入库总量"); } 
			set { this.SetValue("入库总量", value); } 
		}

		public SummaryStockInView()
		{
			this.ViewName = "vw_SummaryStockIn";
			this.Fields = new Dictionary<string, EntityField>();
			this.Fields.Add("产品ID", SummaryStockInViewFields.产品ID);
			this.Fields.Add("产品编号", SummaryStockInViewFields.产品编号);
			this.Fields.Add("产品名称", SummaryStockInViewFields.产品名称);
			this.Fields.Add("产品名称Spell", SummaryStockInViewFields.产品名称Spell);
			this.Fields.Add("规格型号", SummaryStockInViewFields.规格型号);
			this.Fields.Add("生产厂商", SummaryStockInViewFields.生产厂商);
			this.Fields.Add("生产厂商Spell", SummaryStockInViewFields.生产厂商Spell);
			this.Fields.Add("注册证号", SummaryStockInViewFields.注册证号);
			this.Fields.Add("包装规格型号", SummaryStockInViewFields.包装规格);
			this.Fields.Add("单位", SummaryStockInViewFields.单位);
			this.Fields.Add("剂型", SummaryStockInViewFields.剂型);
			this.Fields.Add("产品类别", SummaryStockInViewFields.产品类别);
			this.Fields.Add("入库总量", SummaryStockInViewFields.入库总量);
		}
	}

	#region SummaryStockInViewFields

	public class SummaryStockInViewFields
	{
		public static EntityField 产品ID
		{
			get { return new EntityField("vw_SummaryStockIn", 0, "产品ID", SqlDbType.Int); }
		}

		public static EntityField 产品编号
		{
			get { return new EntityField("vw_SummaryStockIn", 1, "产品编号", SqlDbType.NVarChar); }
		}

		public static EntityField 产品名称
		{
			get { return new EntityField("vw_SummaryStockIn", 2, "产品名称", SqlDbType.NVarChar); }
		}

		public static EntityField 产品名称Spell
		{
			get { return new EntityField("vw_SummaryStockIn", 3, "产品名称Spell", SqlDbType.NVarChar); }
		}

		public static EntityField 规格型号
		{
			get { return new EntityField("vw_SummaryStockIn", 4, "规格型号", SqlDbType.NVarChar); }
		}

		public static EntityField 生产厂商
		{
			get { return new EntityField("vw_SummaryStockIn", 5, "生产厂商", SqlDbType.NVarChar); }
		}

		public static EntityField 生产厂商Spell
		{
			get { return new EntityField("vw_SummaryStockIn", 6, "生产厂商Spell", SqlDbType.NVarChar); }
		}

		public static EntityField 注册证号
		{
			get { return new EntityField("vw_SummaryStockIn", 7, "注册证号", SqlDbType.NVarChar); }
		}

		public static EntityField 包装规格
		{
			get { return new EntityField("vw_SummaryStockIn", 8, "包装规格型号", SqlDbType.NVarChar); }
		}

		public static EntityField 单位
		{
			get { return new EntityField("vw_SummaryStockIn", 9, "单位", SqlDbType.NVarChar); }
		}

		public static EntityField 剂型
		{
			get { return new EntityField("vw_SummaryStockIn", 10, "剂型", SqlDbType.NVarChar); }
		}

		public static EntityField 产品类别
		{
			get { return new EntityField("vw_SummaryStockIn", 11, "产品类别", SqlDbType.NVarChar); }
		}

		public static EntityField 入库总量
		{
			get { return new EntityField("vw_SummaryStockIn", 12, "入库总量", SqlDbType.Int); }
		}

	}

	#endregion

}
