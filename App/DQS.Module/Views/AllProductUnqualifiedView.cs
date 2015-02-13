/*
 *	Build By: Codey Object Relation Mapping
 *	Build Data: 2014-03-04 22:32:22
 *	Build Type: View
 *	Description: AllProductUnqualifiedView
*/

using System;
using System.Collections.Generic;
using System.Data;
using ORMSCore;

namespace DQS.Module.Views
{
	public class AllProductUnqualifiedView : ViewBase
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

		public string 不合格品原因
		{
			get { return (string)this.GetValue("不合格品原因"); } 
			set { this.SetValue("不合格品原因", value); } 
		}

		public string 责任部门人
		{
			get { return (string)this.GetValue("责任部门人"); } 
			set { this.SetValue("责任部门人", value); } 
		}

		public string 处理意见
		{
			get { return (string)this.GetValue("处理意见"); } 
			set { this.SetValue("处理意见", value); } 
		}

		public bool 是否削减库存
		{
			get { return (bool)this.GetValue("是否削减库存"); } 
			set { this.SetValue("是否削减库存", value); } 
		}

		public string 处理状态
		{
			get { return (string)this.GetValue("处理状态"); } 
			set { this.SetValue("处理状态", value); } 
		}

		public string 创建人
		{
			get { return (string)this.GetValue("创建人"); } 
			set { this.SetValue("创建人", value); } 
		}

		public DateTime 创建时间
		{
			get { return (DateTime)this.GetValue("创建时间"); } 
			set { this.SetValue("创建时间", value); } 
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

		public AllProductUnqualifiedView()
		{
			this.ViewName = "vw_AllProductUnqualified";
			this.Fields = new Dictionary<string, EntityField>();
			this.Fields.Add("记录ID", AllProductUnqualifiedViewFields.记录ID);
			this.Fields.Add("记录编号", AllProductUnqualifiedViewFields.记录编号);
			this.Fields.Add("不合格品原因", AllProductUnqualifiedViewFields.不合格品原因);
			this.Fields.Add("责任部门人", AllProductUnqualifiedViewFields.责任部门人);
			this.Fields.Add("处理意见", AllProductUnqualifiedViewFields.处理意见);
			this.Fields.Add("是否削减库存", AllProductUnqualifiedViewFields.是否削减库存);
			this.Fields.Add("处理状态", AllProductUnqualifiedViewFields.处理状态);
			this.Fields.Add("创建人", AllProductUnqualifiedViewFields.创建人);
			this.Fields.Add("创建时间", AllProductUnqualifiedViewFields.创建时间);
			this.Fields.Add("最后修改人", AllProductUnqualifiedViewFields.最后修改人);
			this.Fields.Add("最后修改时间", AllProductUnqualifiedViewFields.最后修改时间);
			this.Fields.Add("备注", AllProductUnqualifiedViewFields.备注);
		}
	}

	#region AllProductUnqualifiedViewFields

	public class AllProductUnqualifiedViewFields
	{
		public static EntityField 记录ID
		{
			get { return new EntityField("vw_AllProductUnqualified", 0, "记录ID", SqlDbType.Int); }
		}

		public static EntityField 记录编号
		{
			get { return new EntityField("vw_AllProductUnqualified", 1, "记录编号", SqlDbType.NVarChar); }
		}

		public static EntityField 不合格品原因
		{
			get { return new EntityField("vw_AllProductUnqualified", 2, "不合格品原因", SqlDbType.NVarChar); }
		}

		public static EntityField 责任部门人
		{
			get { return new EntityField("vw_AllProductUnqualified", 3, "责任部门人", SqlDbType.NVarChar); }
		}

		public static EntityField 处理意见
		{
			get { return new EntityField("vw_AllProductUnqualified", 4, "处理意见", SqlDbType.NVarChar); }
		}

		public static EntityField 是否削减库存
		{
			get { return new EntityField("vw_AllProductUnqualified", 5, "是否削减库存", SqlDbType.Bit); }
		}

		public static EntityField 处理状态
		{
			get { return new EntityField("vw_AllProductUnqualified", 6, "处理状态", SqlDbType.NVarChar); }
		}

		public static EntityField 创建人
		{
			get { return new EntityField("vw_AllProductUnqualified", 7, "创建人", SqlDbType.NVarChar); }
		}

		public static EntityField 创建时间
		{
			get { return new EntityField("vw_AllProductUnqualified", 8, "创建时间", SqlDbType.DateTime); }
		}

		public static EntityField 最后修改人
		{
			get { return new EntityField("vw_AllProductUnqualified", 9, "最后修改人", SqlDbType.NVarChar); }
		}

		public static EntityField 最后修改时间
		{
			get { return new EntityField("vw_AllProductUnqualified", 10, "最后修改时间", SqlDbType.DateTime); }
		}

		public static EntityField 备注
		{
			get { return new EntityField("vw_AllProductUnqualified", 11, "备注", SqlDbType.NVarChar); }
		}

	}

	#endregion

}
