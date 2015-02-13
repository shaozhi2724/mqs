/*
 *	Build By: Codey Object Relation Mapping
 *	Build Data: 2014-03-04 22:32:22
 *	Build Type: View
 *	Description: AllProductPriceStyleView
*/

using System;
using System.Collections.Generic;
using System.Data;
using ORMSCore;

namespace DQS.Module.Views
{
	public class AllProductPriceStyleView : ViewBase
	{
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

		public string 分类类型
		{
			get { return (string)this.GetValue("分类类型"); } 
			set { this.SetValue("分类类型", value); } 
		}

		public string 分类描述
		{
			get { return (string)this.GetValue("分类描述"); } 
			set { this.SetValue("分类描述", value); } 
		}

		public string 备注
		{
			get { return (string)this.GetValue("备注"); } 
			set { this.SetValue("备注", value); } 
		}

		public AllProductPriceStyleView()
		{
			this.ViewName = "vw_AllProductPriceStyle";
			this.Fields = new Dictionary<string, EntityField>();
			this.Fields.Add("分类ID", AllProductPriceStyleViewFields.分类ID);
			this.Fields.Add("价格分类", AllProductPriceStyleViewFields.价格分类);
			this.Fields.Add("价格分类Spell", AllProductPriceStyleViewFields.价格分类Spell);
			this.Fields.Add("分类类型", AllProductPriceStyleViewFields.分类类型);
			this.Fields.Add("分类描述", AllProductPriceStyleViewFields.分类描述);
			this.Fields.Add("备注", AllProductPriceStyleViewFields.备注);
		}
	}

	#region AllProductPriceStyleViewFields

	public class AllProductPriceStyleViewFields
	{
		public static EntityField 分类ID
		{
			get { return new EntityField("vw_AllProductPriceStyle", 0, "分类ID", SqlDbType.Int); }
		}

		public static EntityField 价格分类
		{
			get { return new EntityField("vw_AllProductPriceStyle", 1, "价格分类", SqlDbType.NVarChar); }
		}

		public static EntityField 价格分类Spell
		{
			get { return new EntityField("vw_AllProductPriceStyle", 2, "价格分类Spell", SqlDbType.NVarChar); }
		}

		public static EntityField 分类类型
		{
			get { return new EntityField("vw_AllProductPriceStyle", 3, "分类类型", SqlDbType.VarChar); }
		}

		public static EntityField 分类描述
		{
			get { return new EntityField("vw_AllProductPriceStyle", 4, "分类描述", SqlDbType.NVarChar); }
		}

		public static EntityField 备注
		{
			get { return new EntityField("vw_AllProductPriceStyle", 5, "备注", SqlDbType.NVarChar); }
		}

	}

	#endregion

}
