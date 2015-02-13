/*
 *	Build By: Codey Object Relation Mapping
 *	Build Data: 2014-03-04 22:32:22
 *	Build Type: View
 *	Description: AllAttributeView
*/

using System;
using System.Collections.Generic;
using System.Data;
using ORMSCore;

namespace DQS.Module.Views
{
	public class AllAttributeView : ViewBase
	{
		public int 属性ID
		{
			get { return (int)this.GetValue("属性ID"); } 
			set { this.SetValue("属性ID", value); } 
		}

		public string 属性名称
		{
			get { return (string)this.GetValue("属性名称"); } 
			set { this.SetValue("属性名称", value); } 
		}

		public string 属性内容
		{
			get { return (string)this.GetValue("属性内容"); } 
			set { this.SetValue("属性内容", value); } 
		}

		public int 所属档案ID
		{
			get { return (int)this.GetValue("所属档案ID"); } 
			set { this.SetValue("所属档案ID", value); } 
		}

		public AllAttributeView()
		{
			this.ViewName = "vw_AllAttribute";
			this.Fields = new Dictionary<string, EntityField>();
			this.Fields.Add("属性ID", AllAttributeViewFields.属性ID);
			this.Fields.Add("属性名称", AllAttributeViewFields.属性名称);
			this.Fields.Add("属性内容", AllAttributeViewFields.属性内容);
			this.Fields.Add("所属档案ID", AllAttributeViewFields.所属档案ID);
		}
	}

	#region AllAttributeViewFields

	public class AllAttributeViewFields
	{
		public static EntityField 属性ID
		{
			get { return new EntityField("vw_AllAttribute", 0, "属性ID", SqlDbType.Int); }
		}

		public static EntityField 属性名称
		{
			get { return new EntityField("vw_AllAttribute", 1, "属性名称", SqlDbType.NVarChar); }
		}

		public static EntityField 属性内容
		{
			get { return new EntityField("vw_AllAttribute", 2, "属性内容", SqlDbType.NVarChar); }
		}

		public static EntityField 所属档案ID
		{
			get { return new EntityField("vw_AllAttribute", 3, "所属档案ID", SqlDbType.Int); }
		}

	}

	#endregion

}
