/*
 *	Build By: Codey Object Relation Mapping
 *	Build Data: 2014-03-04 22:32:22
 *	Build Type: View
 *	Description: AllProductPriceView
*/

using System;
using System.Collections.Generic;
using System.Data;
using ORMSCore;

namespace DQS.Module.Views
{
	public class AllProductPriceView : ViewBase
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

		public double 价格元
		{
			get { return (double)this.GetValue("价格(元)"); } 
			set { this.SetValue("价格(元)", value); } 
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

		public string 注册证号
		{
			get { return (string)this.GetValue("注册证号"); } 
			set { this.SetValue("注册证号", value); } 
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

		public AllProductPriceView()
		{
			this.ViewName = "vw_AllProductPrice";
			this.Fields = new Dictionary<string, EntityField>();
			this.Fields.Add("产品ID", AllProductPriceViewFields.产品ID);
			this.Fields.Add("产品编号", AllProductPriceViewFields.产品编号);
			this.Fields.Add("产品名称", AllProductPriceViewFields.产品名称);
			this.Fields.Add("产品名称Spell", AllProductPriceViewFields.产品名称Spell);
			this.Fields.Add("分类ID", AllProductPriceViewFields.分类ID);
			this.Fields.Add("价格分类", AllProductPriceViewFields.价格分类);
			this.Fields.Add("价格分类Spell", AllProductPriceViewFields.价格分类Spell);
			this.Fields.Add("价格(元)", AllProductPriceViewFields.价格元);
			this.Fields.Add("规格型号", AllProductPriceViewFields.规格型号);
			this.Fields.Add("剂型", AllProductPriceViewFields.剂型);
			this.Fields.Add("产品类别", AllProductPriceViewFields.产品类别);
			this.Fields.Add("注册证号", AllProductPriceViewFields.注册证号);
			this.Fields.Add("生产厂商", AllProductPriceViewFields.生产厂商);
			this.Fields.Add("创建人", AllProductPriceViewFields.创建人);
			this.Fields.Add("创建日期", AllProductPriceViewFields.创建日期);
			this.Fields.Add("最后修改人", AllProductPriceViewFields.最后修改人);
			this.Fields.Add("最后修改时间", AllProductPriceViewFields.最后修改时间);
			this.Fields.Add("备注", AllProductPriceViewFields.备注);
		}
	}

	#region AllProductPriceViewFields

	public class AllProductPriceViewFields
	{
		public static EntityField 产品ID
		{
			get { return new EntityField("vw_AllProductPrice", 0, "产品ID", SqlDbType.Int); }
		}

		public static EntityField 产品编号
		{
			get { return new EntityField("vw_AllProductPrice", 1, "产品编号", SqlDbType.NVarChar); }
		}

		public static EntityField 产品名称
		{
			get { return new EntityField("vw_AllProductPrice", 2, "产品名称", SqlDbType.NVarChar); }
		}

		public static EntityField 产品名称Spell
		{
			get { return new EntityField("vw_AllProductPrice", 3, "产品名称Spell", SqlDbType.NVarChar); }
		}

		public static EntityField 分类ID
		{
			get { return new EntityField("vw_AllProductPrice", 4, "分类ID", SqlDbType.Int); }
		}

		public static EntityField 价格分类
		{
			get { return new EntityField("vw_AllProductPrice", 5, "价格分类", SqlDbType.NVarChar); }
		}

		public static EntityField 价格分类Spell
		{
			get { return new EntityField("vw_AllProductPrice", 6, "价格分类Spell", SqlDbType.NVarChar); }
		}

		public static EntityField 价格元
		{
			get { return new EntityField("vw_AllProductPrice", 7, "价格(元)", SqlDbType.Float); }
		}

		public static EntityField 规格型号
		{
			get { return new EntityField("vw_AllProductPrice", 8, "规格型号", SqlDbType.NVarChar); }
		}

		public static EntityField 剂型
		{
			get { return new EntityField("vw_AllProductPrice", 9, "剂型", SqlDbType.NVarChar); }
		}

		public static EntityField 产品类别
		{
			get { return new EntityField("vw_AllProductPrice", 10, "产品类别", SqlDbType.NVarChar); }
		}

		public static EntityField 注册证号
		{
			get { return new EntityField("vw_AllProductPrice", 11, "注册证号", SqlDbType.NVarChar); }
		}

		public static EntityField 生产厂商
		{
			get { return new EntityField("vw_AllProductPrice", 12, "生产厂商", SqlDbType.NVarChar); }
		}

		public static EntityField 创建人
		{
			get { return new EntityField("vw_AllProductPrice", 13, "创建人", SqlDbType.NVarChar); }
		}

		public static EntityField 创建日期
		{
			get { return new EntityField("vw_AllProductPrice", 14, "创建日期", SqlDbType.DateTime); }
		}

		public static EntityField 最后修改人
		{
			get { return new EntityField("vw_AllProductPrice", 15, "最后修改人", SqlDbType.NVarChar); }
		}

		public static EntityField 最后修改时间
		{
			get { return new EntityField("vw_AllProductPrice", 16, "最后修改时间", SqlDbType.DateTime); }
		}

		public static EntityField 备注
		{
			get { return new EntityField("vw_AllProductPrice", 17, "备注", SqlDbType.NVarChar); }
		}

	}

	#endregion

}
