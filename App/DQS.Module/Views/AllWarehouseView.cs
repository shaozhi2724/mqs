/*
 *	Build By: Codey Object Relation Mapping
 *	Build Data: 2014-03-04 22:32:22
 *	Build Type: View
 *	Description: AllWarehouseView
*/

using System;
using System.Collections.Generic;
using System.Data;
using ORMSCore;

namespace DQS.Module.Views
{
	public class AllWarehouseView : ViewBase
	{
		public int 仓库ID
		{
			get { return (int)this.GetValue("仓库ID"); } 
			set { this.SetValue("仓库ID", value); } 
		}

		public string 仓库编号
		{
			get { return (string)this.GetValue("仓库编号"); } 
			set { this.SetValue("仓库编号", value); } 
		}

		public string 仓库名称
		{
			get { return (string)this.GetValue("仓库名称"); } 
			set { this.SetValue("仓库名称", value); } 
		}

		public string 仓库名称Spell
		{
			get { return (string)this.GetValue("仓库名称Spell"); } 
			set { this.SetValue("仓库名称Spell", value); } 
		}

		public string 仓库用途
		{
			get { return (string)this.GetValue("仓库用途"); } 
			set { this.SetValue("仓库用途", value); } 
		}

		public string 仓库类型
		{
			get { return (string)this.GetValue("仓库类型"); } 
			set { this.SetValue("仓库类型", value); } 
		}

		public string 仓库电话
		{
			get { return (string)this.GetValue("仓库电话"); } 
			set { this.SetValue("仓库电话", value); } 
		}

		public string 邮编
		{
			get { return (string)this.GetValue("邮编"); } 
			set { this.SetValue("邮编", value); } 
		}

		public string 传真
		{
			get { return (string)this.GetValue("传真"); } 
			set { this.SetValue("传真", value); } 
		}

		public string 异地仓库
		{
			get { return (string)this.GetValue("异地仓库"); } 
			set { this.SetValue("异地仓库", value); } 
		}

		public string 仓库地址
		{
			get { return (string)this.GetValue("仓库地址"); } 
			set { this.SetValue("仓库地址", value); } 
		}

		public string 仓库负责人
		{
			get { return (string)this.GetValue("仓库负责人"); } 
			set { this.SetValue("仓库负责人", value); } 
		}

		public string 负责人电话
		{
			get { return (string)this.GetValue("负责人电话"); } 
			set { this.SetValue("负责人电话", value); } 
		}

		public string 业务联系人
		{
			get { return (string)this.GetValue("业务联系人"); } 
			set { this.SetValue("业务联系人", value); } 
		}

		public string 业务联系电话
		{
			get { return (string)this.GetValue("业务联系电话"); } 
			set { this.SetValue("业务联系电话", value); } 
		}

		public string 占地面积
		{
			get { return (string)this.GetValue("占地面积"); } 
			set { this.SetValue("占地面积", value); } 
		}

		public string 仓库容积
		{
			get { return (string)this.GetValue("仓库容积"); } 
			set { this.SetValue("仓库容积", value); } 
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

		public AllWarehouseView()
		{
			this.ViewName = "vw_AllWarehouse";
			this.Fields = new Dictionary<string, EntityField>();
			this.Fields.Add("仓库ID", AllWarehouseViewFields.仓库ID);
			this.Fields.Add("仓库编号", AllWarehouseViewFields.仓库编号);
			this.Fields.Add("仓库名称", AllWarehouseViewFields.仓库名称);
			this.Fields.Add("仓库名称Spell", AllWarehouseViewFields.仓库名称Spell);
			this.Fields.Add("仓库用途", AllWarehouseViewFields.仓库用途);
			this.Fields.Add("仓库类型", AllWarehouseViewFields.仓库类型);
			this.Fields.Add("仓库电话", AllWarehouseViewFields.仓库电话);
			this.Fields.Add("邮编", AllWarehouseViewFields.邮编);
			this.Fields.Add("传真", AllWarehouseViewFields.传真);
			this.Fields.Add("异地仓库", AllWarehouseViewFields.异地仓库);
			this.Fields.Add("仓库地址", AllWarehouseViewFields.仓库地址);
			this.Fields.Add("仓库负责人", AllWarehouseViewFields.仓库负责人);
			this.Fields.Add("负责人电话", AllWarehouseViewFields.负责人电话);
			this.Fields.Add("业务联系人", AllWarehouseViewFields.业务联系人);
			this.Fields.Add("业务联系电话", AllWarehouseViewFields.业务联系电话);
			this.Fields.Add("占地面积", AllWarehouseViewFields.占地面积);
			this.Fields.Add("仓库容积", AllWarehouseViewFields.仓库容积);
			this.Fields.Add("创建人", AllWarehouseViewFields.创建人);
			this.Fields.Add("创建日期", AllWarehouseViewFields.创建日期);
			this.Fields.Add("最后修改人", AllWarehouseViewFields.最后修改人);
			this.Fields.Add("最后修改时间", AllWarehouseViewFields.最后修改时间);
			this.Fields.Add("备注", AllWarehouseViewFields.备注);
		}
	}

	#region AllWarehouseViewFields

	public class AllWarehouseViewFields
	{
		public static EntityField 仓库ID
		{
			get { return new EntityField("vw_AllWarehouse", 0, "仓库ID", SqlDbType.Int); }
		}

		public static EntityField 仓库编号
		{
			get { return new EntityField("vw_AllWarehouse", 1, "仓库编号", SqlDbType.NVarChar); }
		}

		public static EntityField 仓库名称
		{
			get { return new EntityField("vw_AllWarehouse", 2, "仓库名称", SqlDbType.NVarChar); }
		}

		public static EntityField 仓库名称Spell
		{
			get { return new EntityField("vw_AllWarehouse", 3, "仓库名称Spell", SqlDbType.NVarChar); }
		}

		public static EntityField 仓库用途
		{
			get { return new EntityField("vw_AllWarehouse", 4, "仓库用途", SqlDbType.NVarChar); }
		}

		public static EntityField 仓库类型
		{
			get { return new EntityField("vw_AllWarehouse", 5, "仓库类型", SqlDbType.NVarChar); }
		}

		public static EntityField 仓库电话
		{
			get { return new EntityField("vw_AllWarehouse", 6, "仓库电话", SqlDbType.NVarChar); }
		}

		public static EntityField 邮编
		{
			get { return new EntityField("vw_AllWarehouse", 7, "邮编", SqlDbType.NVarChar); }
		}

		public static EntityField 传真
		{
			get { return new EntityField("vw_AllWarehouse", 8, "传真", SqlDbType.NVarChar); }
		}

		public static EntityField 异地仓库
		{
			get { return new EntityField("vw_AllWarehouse", 9, "异地仓库", SqlDbType.NVarChar); }
		}

		public static EntityField 仓库地址
		{
			get { return new EntityField("vw_AllWarehouse", 10, "仓库地址", SqlDbType.NVarChar); }
		}

		public static EntityField 仓库负责人
		{
			get { return new EntityField("vw_AllWarehouse", 11, "仓库负责人", SqlDbType.NVarChar); }
		}

		public static EntityField 负责人电话
		{
			get { return new EntityField("vw_AllWarehouse", 12, "负责人电话", SqlDbType.NVarChar); }
		}

		public static EntityField 业务联系人
		{
			get { return new EntityField("vw_AllWarehouse", 13, "业务联系人", SqlDbType.NVarChar); }
		}

		public static EntityField 业务联系电话
		{
			get { return new EntityField("vw_AllWarehouse", 14, "业务联系电话", SqlDbType.NVarChar); }
		}

		public static EntityField 占地面积
		{
			get { return new EntityField("vw_AllWarehouse", 15, "占地面积", SqlDbType.NVarChar); }
		}

		public static EntityField 仓库容积
		{
			get { return new EntityField("vw_AllWarehouse", 16, "仓库容积", SqlDbType.NVarChar); }
		}

		public static EntityField 创建人
		{
			get { return new EntityField("vw_AllWarehouse", 17, "创建人", SqlDbType.NVarChar); }
		}

		public static EntityField 创建日期
		{
			get { return new EntityField("vw_AllWarehouse", 18, "创建日期", SqlDbType.DateTime); }
		}

		public static EntityField 最后修改人
		{
			get { return new EntityField("vw_AllWarehouse", 19, "最后修改人", SqlDbType.NVarChar); }
		}

		public static EntityField 最后修改时间
		{
			get { return new EntityField("vw_AllWarehouse", 20, "最后修改时间", SqlDbType.DateTime); }
		}

		public static EntityField 备注
		{
			get { return new EntityField("vw_AllWarehouse", 21, "备注", SqlDbType.NVarChar); }
		}

	}

	#endregion

}
