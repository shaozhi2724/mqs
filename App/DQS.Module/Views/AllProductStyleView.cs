/*
 *	Build By: Codey Object Relation Mapping
 *	Build Data: 2014-03-04 22:32:22
 *	Build Type: View
 *	Description: AllProductStyleView
*/

using System;
using System.Collections.Generic;
using System.Data;
using ORMSCore;

namespace DQS.Module.Views
{
	public class AllProductStyleView : ViewBase
	{
		public string 分类ID
		{
			get { return (string)this.GetValue("分类ID"); } 
			set { this.SetValue("分类ID", value); } 
		}

		public string 价格分类
		{
			get { return (string)this.GetValue("价格分类"); } 
			set { this.SetValue("价格分类", value); } 
		}

		public string 分类类型
		{
			get { return (string)this.GetValue("分类类型"); } 
			set { this.SetValue("分类类型", value); } 
		}

		public string 创建人
		{
			get { return (string)this.GetValue("创建人"); } 
			set { this.SetValue("创建人", value); } 
		}

		public string 创建日期
		{
			get { return (string)this.GetValue("创建日期"); } 
			set { this.SetValue("创建日期", value); } 
		}

		public string 最后修改人
		{
			get { return (string)this.GetValue("最后修改人"); } 
			set { this.SetValue("最后修改人", value); } 
		}

		public string 最后修改时间
		{
			get { return (string)this.GetValue("最后修改时间"); } 
			set { this.SetValue("最后修改时间", value); } 
		}

		public string 备注
		{
			get { return (string)this.GetValue("备注"); } 
			set { this.SetValue("备注", value); } 
		}

		public AllProductStyleView()
		{
			this.ViewName = "vw_AllProductStyle";
			this.Fields = new Dictionary<string, EntityField>();
			this.Fields.Add("分类ID", AllProductStyleViewFields.分类ID);
			this.Fields.Add("价格分类", AllProductStyleViewFields.价格分类);
			this.Fields.Add("分类类型", AllProductStyleViewFields.分类类型);
			this.Fields.Add("创建人", AllProductStyleViewFields.创建人);
			this.Fields.Add("创建日期", AllProductStyleViewFields.创建日期);
			this.Fields.Add("最后修改人", AllProductStyleViewFields.最后修改人);
			this.Fields.Add("最后修改时间", AllProductStyleViewFields.最后修改时间);
			this.Fields.Add("备注", AllProductStyleViewFields.备注);
		}
	}

	#region AllProductStyleViewFields

	public class AllProductStyleViewFields
	{
		public static EntityField 分类ID
		{
			get { return new EntityField("vw_AllProductStyle", 0, "分类ID", SqlDbType.VarChar); }
		}

		public static EntityField 价格分类
		{
			get { return new EntityField("vw_AllProductStyle", 1, "价格分类", SqlDbType.VarChar); }
		}

		public static EntityField 分类类型
		{
			get { return new EntityField("vw_AllProductStyle", 2, "分类类型", SqlDbType.VarChar); }
		}

		public static EntityField 创建人
		{
			get { return new EntityField("vw_AllProductStyle", 3, "创建人", SqlDbType.VarChar); }
		}

		public static EntityField 创建日期
		{
			get { return new EntityField("vw_AllProductStyle", 4, "创建日期", SqlDbType.VarChar); }
		}

		public static EntityField 最后修改人
		{
			get { return new EntityField("vw_AllProductStyle", 5, "最后修改人", SqlDbType.VarChar); }
		}

		public static EntityField 最后修改时间
		{
			get { return new EntityField("vw_AllProductStyle", 6, "最后修改时间", SqlDbType.VarChar); }
		}

		public static EntityField 备注
		{
			get { return new EntityField("vw_AllProductStyle", 7, "备注", SqlDbType.VarChar); }
		}

	}

	#endregion

}
