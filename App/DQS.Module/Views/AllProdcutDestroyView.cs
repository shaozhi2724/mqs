/*
 *	Build By: Codey Object Relation Mapping
 *	Build Data: 2014-03-04 22:32:22
 *	Build Type: View
 *	Description: AllProdcutDestroyView
*/

using System;
using System.Collections.Generic;
using System.Data;
using ORMSCore;

namespace DQS.Module.Views
{
	public class AllProdcutDestroyView : ViewBase
	{
		public int 销毁ID
		{
			get { return (int)this.GetValue("销毁ID"); } 
			set { this.SetValue("销毁ID", value); } 
		}

		public string 销毁编号
		{
			get { return (string)this.GetValue("销毁编号"); } 
			set { this.SetValue("销毁编号", value); } 
		}

		public string 不合格记录编号
		{
			get { return (string)this.GetValue("不合格记录编号"); } 
			set { this.SetValue("不合格记录编号", value); } 
		}

		public string 销毁原因
		{
			get { return (string)this.GetValue("销毁原因"); } 
			set { this.SetValue("销毁原因", value); } 
		}

		public string 销毁过程
		{
			get { return (string)this.GetValue("销毁过程"); } 
			set { this.SetValue("销毁过程", value); } 
		}

		public string 销毁结果
		{
			get { return (string)this.GetValue("销毁结果"); } 
			set { this.SetValue("销毁结果", value); } 
		}

		public DateTime 销毁时间
		{
			get { return (DateTime)this.GetValue("销毁时间"); } 
			set { this.SetValue("销毁时间", value); } 
		}

		public string 办理人
		{
			get { return (string)this.GetValue("办理人"); } 
			set { this.SetValue("办理人", value); } 
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

		public AllProdcutDestroyView()
		{
			this.ViewName = "vw_AllProdcutDestroy";
			this.Fields = new Dictionary<string, EntityField>();
			this.Fields.Add("销毁ID", AllProdcutDestroyViewFields.销毁ID);
			this.Fields.Add("销毁编号", AllProdcutDestroyViewFields.销毁编号);
			this.Fields.Add("不合格记录编号", AllProdcutDestroyViewFields.不合格记录编号);
			this.Fields.Add("销毁原因", AllProdcutDestroyViewFields.销毁原因);
			this.Fields.Add("销毁过程", AllProdcutDestroyViewFields.销毁过程);
			this.Fields.Add("销毁结果", AllProdcutDestroyViewFields.销毁结果);
			this.Fields.Add("销毁时间", AllProdcutDestroyViewFields.销毁时间);
			this.Fields.Add("办理人", AllProdcutDestroyViewFields.办理人);
			this.Fields.Add("创建人", AllProdcutDestroyViewFields.创建人);
			this.Fields.Add("创建日期", AllProdcutDestroyViewFields.创建日期);
			this.Fields.Add("最后修改人", AllProdcutDestroyViewFields.最后修改人);
			this.Fields.Add("最后修改时间", AllProdcutDestroyViewFields.最后修改时间);
			this.Fields.Add("备注", AllProdcutDestroyViewFields.备注);
		}
	}

	#region AllProdcutDestroyViewFields

	public class AllProdcutDestroyViewFields
	{
		public static EntityField 销毁ID
		{
			get { return new EntityField("vw_AllProdcutDestroy", 0, "销毁ID", SqlDbType.Int); }
		}

		public static EntityField 销毁编号
		{
			get { return new EntityField("vw_AllProdcutDestroy", 1, "销毁编号", SqlDbType.NVarChar); }
		}

		public static EntityField 不合格记录编号
		{
			get { return new EntityField("vw_AllProdcutDestroy", 2, "不合格记录编号", SqlDbType.NVarChar); }
		}

		public static EntityField 销毁原因
		{
			get { return new EntityField("vw_AllProdcutDestroy", 3, "销毁原因", SqlDbType.NVarChar); }
		}

		public static EntityField 销毁过程
		{
			get { return new EntityField("vw_AllProdcutDestroy", 4, "销毁过程", SqlDbType.NVarChar); }
		}

		public static EntityField 销毁结果
		{
			get { return new EntityField("vw_AllProdcutDestroy", 5, "销毁结果", SqlDbType.NVarChar); }
		}

		public static EntityField 销毁时间
		{
			get { return new EntityField("vw_AllProdcutDestroy", 6, "销毁时间", SqlDbType.DateTime); }
		}

		public static EntityField 办理人
		{
			get { return new EntityField("vw_AllProdcutDestroy", 7, "办理人", SqlDbType.NVarChar); }
		}

		public static EntityField 创建人
		{
			get { return new EntityField("vw_AllProdcutDestroy", 8, "创建人", SqlDbType.NVarChar); }
		}

		public static EntityField 创建日期
		{
			get { return new EntityField("vw_AllProdcutDestroy", 9, "创建日期", SqlDbType.DateTime); }
		}

		public static EntityField 最后修改人
		{
			get { return new EntityField("vw_AllProdcutDestroy", 10, "最后修改人", SqlDbType.NVarChar); }
		}

		public static EntityField 最后修改时间
		{
			get { return new EntityField("vw_AllProdcutDestroy", 11, "最后修改时间", SqlDbType.DateTime); }
		}

		public static EntityField 备注
		{
			get { return new EntityField("vw_AllProdcutDestroy", 12, "备注", SqlDbType.NVarChar); }
		}

	}

	#endregion

}
