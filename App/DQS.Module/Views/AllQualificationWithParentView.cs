/*
 *	Build By: Codey Object Relation Mapping
 *	Build Data: 2014-03-04 22:32:22
 *	Build Type: View
 *	Description: AllQualificationWithParentView
*/

using System;
using System.Collections.Generic;
using System.Data;
using ORMSCore;

namespace DQS.Module.Views
{
	public class AllQualificationWithParentView : ViewBase
	{
		public string 证书所属
		{
			get { return (string)this.GetValue("证书所属"); } 
			set { this.SetValue("证书所属", value); } 
		}

		public string 所属名称
		{
			get { return (string)this.GetValue("所属名称"); } 
			set { this.SetValue("所属名称", value); } 
		}

		public int 档案ID
		{
			get { return (int)this.GetValue("档案ID"); } 
			set { this.SetValue("档案ID", value); } 
		}

		public string 档案编号
		{
			get { return (string)this.GetValue("档案编号"); } 
			set { this.SetValue("档案编号", value); } 
		}

		public string 档案名称
		{
			get { return (string)this.GetValue("档案名称"); } 
			set { this.SetValue("档案名称", value); } 
		}

		public string 证书类型
		{
			get { return (string)this.GetValue("证书类型"); } 
			set { this.SetValue("证书类型", value); } 
		}

		public string 证书编号
		{
			get { return (string)this.GetValue("证书编号"); } 
			set { this.SetValue("证书编号", value); } 
		}

		public string 发证机关
		{
			get { return (string)this.GetValue("发证机关"); } 
			set { this.SetValue("发证机关", value); } 
		}

		public DateTime 发证日期
		{
			get { return (DateTime)this.GetValue("发证日期"); } 
			set { this.SetValue("发证日期", value); } 
		}

		public DateTime 到期日期
		{
			get { return (DateTime)this.GetValue("到期日期"); } 
			set { this.SetValue("到期日期", value); } 
		}

		public string 到期状态
		{
			get { return (string)this.GetValue("到期状态"); } 
			set { this.SetValue("到期状态", value); } 
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

		public DateTime 修改时间
		{
			get { return (DateTime)this.GetValue("修改时间"); } 
			set { this.SetValue("修改时间", value); } 
		}

		public string 备注
		{
			get { return (string)this.GetValue("备注"); } 
			set { this.SetValue("备注", value); } 
		}

		public int 所属ID
		{
			get { return (int)this.GetValue("所属ID"); } 
			set { this.SetValue("所属ID", value); } 
		}

		public string 所属表ID
		{
			get { return (string)this.GetValue("所属表ID"); } 
			set { this.SetValue("所属表ID", value); } 
		}

		public string 所属列名ID
		{
			get { return (string)this.GetValue("所属列名ID"); } 
			set { this.SetValue("所属列名ID", value); } 
		}

		public AllQualificationWithParentView()
		{
			this.ViewName = "vw_AllQualificationWithParent";
			this.Fields = new Dictionary<string, EntityField>();
			this.Fields.Add("证书所属", AllQualificationWithParentViewFields.证书所属);
			this.Fields.Add("所属名称", AllQualificationWithParentViewFields.所属名称);
			this.Fields.Add("档案ID", AllQualificationWithParentViewFields.档案ID);
			this.Fields.Add("档案编号", AllQualificationWithParentViewFields.档案编号);
			this.Fields.Add("档案名称", AllQualificationWithParentViewFields.档案名称);
			this.Fields.Add("证书类型", AllQualificationWithParentViewFields.证书类型);
			this.Fields.Add("证书编号", AllQualificationWithParentViewFields.证书编号);
			this.Fields.Add("发证机关", AllQualificationWithParentViewFields.发证机关);
			this.Fields.Add("发证日期", AllQualificationWithParentViewFields.发证日期);
			this.Fields.Add("到期日期", AllQualificationWithParentViewFields.到期日期);
			this.Fields.Add("到期状态", AllQualificationWithParentViewFields.到期状态);
			this.Fields.Add("创建人", AllQualificationWithParentViewFields.创建人);
			this.Fields.Add("创建日期", AllQualificationWithParentViewFields.创建日期);
			this.Fields.Add("最后修改人", AllQualificationWithParentViewFields.最后修改人);
			this.Fields.Add("修改时间", AllQualificationWithParentViewFields.修改时间);
			this.Fields.Add("备注", AllQualificationWithParentViewFields.备注);
			this.Fields.Add("所属ID", AllQualificationWithParentViewFields.所属ID);
			this.Fields.Add("所属表ID", AllQualificationWithParentViewFields.所属表ID);
			this.Fields.Add("所属列名ID", AllQualificationWithParentViewFields.所属列名ID);
		}
	}

	#region AllQualificationWithParentViewFields

	public class AllQualificationWithParentViewFields
	{
		public static EntityField 证书所属
		{
			get { return new EntityField("vw_AllQualificationWithParent", 0, "证书所属", SqlDbType.NVarChar); }
		}

		public static EntityField 所属名称
		{
			get { return new EntityField("vw_AllQualificationWithParent", 1, "所属名称", SqlDbType.NVarChar); }
		}

		public static EntityField 档案ID
		{
			get { return new EntityField("vw_AllQualificationWithParent", 2, "档案ID", SqlDbType.Int); }
		}

		public static EntityField 档案编号
		{
			get { return new EntityField("vw_AllQualificationWithParent", 3, "档案编号", SqlDbType.NVarChar); }
		}

		public static EntityField 档案名称
		{
			get { return new EntityField("vw_AllQualificationWithParent", 4, "档案名称", SqlDbType.NVarChar); }
		}

		public static EntityField 证书类型
		{
			get { return new EntityField("vw_AllQualificationWithParent", 5, "证书类型", SqlDbType.NVarChar); }
		}

		public static EntityField 证书编号
		{
			get { return new EntityField("vw_AllQualificationWithParent", 6, "证书编号", SqlDbType.NVarChar); }
		}

		public static EntityField 发证机关
		{
			get { return new EntityField("vw_AllQualificationWithParent", 7, "发证机关", SqlDbType.NVarChar); }
		}

		public static EntityField 发证日期
		{
			get { return new EntityField("vw_AllQualificationWithParent", 8, "发证日期", SqlDbType.DateTime); }
		}

		public static EntityField 到期日期
		{
			get { return new EntityField("vw_AllQualificationWithParent", 9, "到期日期", SqlDbType.DateTime); }
		}

		public static EntityField 到期状态
		{
			get { return new EntityField("vw_AllQualificationWithParent", 10, "到期状态", SqlDbType.VarChar); }
		}

		public static EntityField 创建人
		{
			get { return new EntityField("vw_AllQualificationWithParent", 11, "创建人", SqlDbType.NVarChar); }
		}

		public static EntityField 创建日期
		{
			get { return new EntityField("vw_AllQualificationWithParent", 12, "创建日期", SqlDbType.DateTime); }
		}

		public static EntityField 最后修改人
		{
			get { return new EntityField("vw_AllQualificationWithParent", 13, "最后修改人", SqlDbType.NVarChar); }
		}

		public static EntityField 修改时间
		{
			get { return new EntityField("vw_AllQualificationWithParent", 14, "修改时间", SqlDbType.DateTime); }
		}

		public static EntityField 备注
		{
			get { return new EntityField("vw_AllQualificationWithParent", 15, "备注", SqlDbType.NVarChar); }
		}

		public static EntityField 所属ID
		{
			get { return new EntityField("vw_AllQualificationWithParent", 16, "所属ID", SqlDbType.Int); }
		}

		public static EntityField 所属表ID
		{
			get { return new EntityField("vw_AllQualificationWithParent", 17, "所属表ID", SqlDbType.NVarChar); }
		}

		public static EntityField 所属列名ID
		{
			get { return new EntityField("vw_AllQualificationWithParent", 18, "所属列名ID", SqlDbType.NVarChar); }
		}

	}

	#endregion

}
