/*
 *	Build By: Codey Object Relation Mapping
 *	Build Data: 2014-03-04 22:32:22
 *	Build Type: View
 *	Description: AllQualificationView
*/

using System;
using System.Collections.Generic;
using System.Data;
using ORMSCore;

namespace DQS.Module.Views
{
	public class AllQualificationView : ViewBase
	{
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

		public AllQualificationView()
		{
			this.ViewName = "vw_AllQualification";
			this.Fields = new Dictionary<string, EntityField>();
			this.Fields.Add("档案ID", AllQualificationViewFields.档案ID);
			this.Fields.Add("档案编号", AllQualificationViewFields.档案编号);
			this.Fields.Add("档案名称", AllQualificationViewFields.档案名称);
			this.Fields.Add("证书类型", AllQualificationViewFields.证书类型);
			this.Fields.Add("证书编号", AllQualificationViewFields.证书编号);
			this.Fields.Add("发证机关", AllQualificationViewFields.发证机关);
			this.Fields.Add("发证日期", AllQualificationViewFields.发证日期);
			this.Fields.Add("到期日期", AllQualificationViewFields.到期日期);
			this.Fields.Add("到期状态", AllQualificationViewFields.到期状态);
			this.Fields.Add("创建人", AllQualificationViewFields.创建人);
			this.Fields.Add("创建日期", AllQualificationViewFields.创建日期);
			this.Fields.Add("最后修改人", AllQualificationViewFields.最后修改人);
			this.Fields.Add("修改时间", AllQualificationViewFields.修改时间);
			this.Fields.Add("备注", AllQualificationViewFields.备注);
			this.Fields.Add("所属ID", AllQualificationViewFields.所属ID);
			this.Fields.Add("所属表ID", AllQualificationViewFields.所属表ID);
			this.Fields.Add("所属列名ID", AllQualificationViewFields.所属列名ID);
		}
	}

	#region AllQualificationViewFields

	public class AllQualificationViewFields
	{
		public static EntityField 档案ID
		{
			get { return new EntityField("vw_AllQualification", 0, "档案ID", SqlDbType.Int); }
		}

		public static EntityField 档案编号
		{
			get { return new EntityField("vw_AllQualification", 1, "档案编号", SqlDbType.NVarChar); }
		}

		public static EntityField 档案名称
		{
			get { return new EntityField("vw_AllQualification", 2, "档案名称", SqlDbType.NVarChar); }
		}

		public static EntityField 证书类型
		{
			get { return new EntityField("vw_AllQualification", 3, "证书类型", SqlDbType.NVarChar); }
		}

		public static EntityField 证书编号
		{
			get { return new EntityField("vw_AllQualification", 4, "证书编号", SqlDbType.NVarChar); }
		}

		public static EntityField 发证机关
		{
			get { return new EntityField("vw_AllQualification", 5, "发证机关", SqlDbType.NVarChar); }
		}

		public static EntityField 发证日期
		{
			get { return new EntityField("vw_AllQualification", 6, "发证日期", SqlDbType.DateTime); }
		}

		public static EntityField 到期日期
		{
			get { return new EntityField("vw_AllQualification", 7, "到期日期", SqlDbType.DateTime); }
		}

		public static EntityField 到期状态
		{
			get { return new EntityField("vw_AllQualification", 8, "到期状态", SqlDbType.VarChar); }
		}

		public static EntityField 创建人
		{
			get { return new EntityField("vw_AllQualification", 9, "创建人", SqlDbType.NVarChar); }
		}

		public static EntityField 创建日期
		{
			get { return new EntityField("vw_AllQualification", 10, "创建日期", SqlDbType.DateTime); }
		}

		public static EntityField 最后修改人
		{
			get { return new EntityField("vw_AllQualification", 11, "最后修改人", SqlDbType.NVarChar); }
		}

		public static EntityField 修改时间
		{
			get { return new EntityField("vw_AllQualification", 12, "修改时间", SqlDbType.DateTime); }
		}

		public static EntityField 备注
		{
			get { return new EntityField("vw_AllQualification", 13, "备注", SqlDbType.NVarChar); }
		}

		public static EntityField 所属ID
		{
			get { return new EntityField("vw_AllQualification", 14, "所属ID", SqlDbType.Int); }
		}

		public static EntityField 所属表ID
		{
			get { return new EntityField("vw_AllQualification", 15, "所属表ID", SqlDbType.NVarChar); }
		}

		public static EntityField 所属列名ID
		{
			get { return new EntityField("vw_AllQualification", 16, "所属列名ID", SqlDbType.NVarChar); }
		}

	}

	#endregion

}
