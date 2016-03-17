/*
 *	Build By: Codey Object Relation Mapping
 *	Build Data: 2014-03-04 22:32:22
 *	Build Type: View
 *	Description: AllCuringRecordView
*/

using System;
using System.Collections.Generic;
using System.Data;
using ORMSCore;

namespace DQS.Module.Views
{
	public class AllCuringRecordView : ViewBase
	{
		public int 养护ID
		{
			get { return (int)this.GetValue("养护ID"); } 
			set { this.SetValue("养护ID", value); } 
		}

		public string 养护编号
		{
			get { return (string)this.GetValue("养护编号"); } 
			set { this.SetValue("养护编号", value); } 
		}

		public string 养护人
		{
			get { return (string)this.GetValue("养护人"); } 
			set { this.SetValue("养护人", value); } 
		}

		public DateTime 养护日期
		{
			get { return (DateTime)this.GetValue("养护日期"); } 
			set { this.SetValue("养护日期", value); } 
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

		public string 产品批号
		{
			get { return (string)this.GetValue("产品批号"); } 
			set { this.SetValue("产品批号", value); } 
		}

		public DateTime 生产日期
		{
			get { return (DateTime)this.GetValue("生产日期"); } 
			set { this.SetValue("生产日期", value); } 
		}

		public DateTime 有效期至
		{
			get { return (DateTime)this.GetValue("有效期至"); } 
			set { this.SetValue("有效期至", value); } 
		}

		public int 库存数量
		{
			get { return (int)this.GetValue("库存数量"); } 
			set { this.SetValue("库存数量", value); } 
		}

		public int 合格数量
		{
			get { return (int)this.GetValue("合格数量"); } 
			set { this.SetValue("合格数量", value); } 
		}

		public int 不合格数量
		{
			get { return (int)this.GetValue("不合格数量"); } 
			set { this.SetValue("不合格数量", value); } 
		}

		public string 检查项目
		{
			get { return (string)this.GetValue("检查项目"); } 
			set { this.SetValue("检查项目", value); } 
		}

		public string 质量状况
		{
			get { return (string)this.GetValue("质量状况"); } 
			set { this.SetValue("质量状况", value); } 
		}

		public string 养护措施
		{
			get { return (string)this.GetValue("养护措施"); } 
			set { this.SetValue("养护措施", value); } 
		}

		public string 处理结果
		{
			get { return (string)this.GetValue("处理结果"); } 
			set { this.SetValue("处理结果", value); } 
		}

		public string 规格型号
		{
			get { return (string)this.GetValue("规格型号"); } 
			set { this.SetValue("规格型号", value); } 
		}

		public string 单位
		{
			get { return (string)this.GetValue("单位"); } 
			set { this.SetValue("单位", value); } 
		}

		public string 包装规格
		{
			get { return (string)this.GetValue("包装规格型号"); } 
			set { this.SetValue("包装规格型号", value); } 
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

		public string 生产厂商Spell
		{
			get { return (string)this.GetValue("生产厂商Spell"); } 
			set { this.SetValue("生产厂商Spell", value); } 
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

		public AllCuringRecordView()
		{
			this.ViewName = "vw_AllCuringRecord";
			this.Fields = new Dictionary<string, EntityField>();
			this.Fields.Add("养护ID", AllCuringRecordViewFields.养护ID);
			this.Fields.Add("养护编号", AllCuringRecordViewFields.养护编号);
			this.Fields.Add("养护人", AllCuringRecordViewFields.养护人);
			this.Fields.Add("养护日期", AllCuringRecordViewFields.养护日期);
			this.Fields.Add("产品编号", AllCuringRecordViewFields.产品编号);
			this.Fields.Add("产品名称", AllCuringRecordViewFields.产品名称);
			this.Fields.Add("产品名称Spell", AllCuringRecordViewFields.产品名称Spell);
			this.Fields.Add("产品批号", AllCuringRecordViewFields.产品批号);
			this.Fields.Add("生产日期", AllCuringRecordViewFields.生产日期);
			this.Fields.Add("有效期至", AllCuringRecordViewFields.有效期至);
			this.Fields.Add("库存数量", AllCuringRecordViewFields.库存数量);
			this.Fields.Add("合格数量", AllCuringRecordViewFields.合格数量);
			this.Fields.Add("不合格数量", AllCuringRecordViewFields.不合格数量);
			this.Fields.Add("检查项目", AllCuringRecordViewFields.检查项目);
			this.Fields.Add("质量状况", AllCuringRecordViewFields.质量状况);
			this.Fields.Add("养护措施", AllCuringRecordViewFields.养护措施);
			this.Fields.Add("处理结果", AllCuringRecordViewFields.处理结果);
			this.Fields.Add("规格型号", AllCuringRecordViewFields.规格型号);
			this.Fields.Add("单位", AllCuringRecordViewFields.单位);
			this.Fields.Add("包装规格型号", AllCuringRecordViewFields.包装规格);
			this.Fields.Add("剂型", AllCuringRecordViewFields.剂型);
			this.Fields.Add("产品类别", AllCuringRecordViewFields.产品类别);
			this.Fields.Add("注册证号", AllCuringRecordViewFields.注册证号);
			this.Fields.Add("生产厂商", AllCuringRecordViewFields.生产厂商);
			this.Fields.Add("生产厂商Spell", AllCuringRecordViewFields.生产厂商Spell);
			this.Fields.Add("创建人", AllCuringRecordViewFields.创建人);
			this.Fields.Add("创建日期", AllCuringRecordViewFields.创建日期);
			this.Fields.Add("最后修改人", AllCuringRecordViewFields.最后修改人);
			this.Fields.Add("最后修改时间", AllCuringRecordViewFields.最后修改时间);
			this.Fields.Add("备注", AllCuringRecordViewFields.备注);
		}
	}

	#region AllCuringRecordViewFields

	public class AllCuringRecordViewFields
	{
		public static EntityField 养护ID
		{
			get { return new EntityField("vw_AllCuringRecord", 0, "养护ID", SqlDbType.Int); }
		}

		public static EntityField 养护编号
		{
			get { return new EntityField("vw_AllCuringRecord", 1, "养护编号", SqlDbType.NVarChar); }
		}

		public static EntityField 养护人
		{
			get { return new EntityField("vw_AllCuringRecord", 2, "养护人", SqlDbType.NVarChar); }
		}

		public static EntityField 养护日期
		{
			get { return new EntityField("vw_AllCuringRecord", 3, "养护日期", SqlDbType.DateTime); }
		}

		public static EntityField 产品编号
		{
			get { return new EntityField("vw_AllCuringRecord", 4, "产品编号", SqlDbType.NVarChar); }
		}

		public static EntityField 产品名称
		{
			get { return new EntityField("vw_AllCuringRecord", 5, "产品名称", SqlDbType.NVarChar); }
		}

		public static EntityField 产品名称Spell
		{
			get { return new EntityField("vw_AllCuringRecord", 6, "产品名称Spell", SqlDbType.NVarChar); }
		}

		public static EntityField 产品批号
		{
			get { return new EntityField("vw_AllCuringRecord", 7, "产品批号", SqlDbType.NVarChar); }
		}

		public static EntityField 生产日期
		{
			get { return new EntityField("vw_AllCuringRecord", 8, "生产日期", SqlDbType.DateTime); }
		}

		public static EntityField 有效期至
		{
			get { return new EntityField("vw_AllCuringRecord", 9, "有效期至", SqlDbType.DateTime); }
		}

		public static EntityField 库存数量
		{
			get { return new EntityField("vw_AllCuringRecord", 10, "库存数量", SqlDbType.Int); }
		}

		public static EntityField 合格数量
		{
			get { return new EntityField("vw_AllCuringRecord", 11, "合格数量", SqlDbType.Int); }
		}

		public static EntityField 不合格数量
		{
			get { return new EntityField("vw_AllCuringRecord", 12, "不合格数量", SqlDbType.Int); }
		}

		public static EntityField 检查项目
		{
			get { return new EntityField("vw_AllCuringRecord", 13, "检查项目", SqlDbType.NVarChar); }
		}

		public static EntityField 质量状况
		{
			get { return new EntityField("vw_AllCuringRecord", 14, "质量状况", SqlDbType.NVarChar); }
		}

		public static EntityField 养护措施
		{
			get { return new EntityField("vw_AllCuringRecord", 15, "养护措施", SqlDbType.NVarChar); }
		}

		public static EntityField 处理结果
		{
			get { return new EntityField("vw_AllCuringRecord", 16, "处理结果", SqlDbType.NVarChar); }
		}

		public static EntityField 规格型号
		{
			get { return new EntityField("vw_AllCuringRecord", 17, "规格型号", SqlDbType.NVarChar); }
		}

		public static EntityField 单位
		{
			get { return new EntityField("vw_AllCuringRecord", 18, "单位", SqlDbType.NVarChar); }
		}

		public static EntityField 包装规格
		{
			get { return new EntityField("vw_AllCuringRecord", 19, "包装规格型号", SqlDbType.NVarChar); }
		}

		public static EntityField 剂型
		{
			get { return new EntityField("vw_AllCuringRecord", 20, "剂型", SqlDbType.NVarChar); }
		}

		public static EntityField 产品类别
		{
			get { return new EntityField("vw_AllCuringRecord", 21, "产品类别", SqlDbType.NVarChar); }
		}

		public static EntityField 注册证号
		{
			get { return new EntityField("vw_AllCuringRecord", 22, "注册证号", SqlDbType.NVarChar); }
		}

		public static EntityField 生产厂商
		{
			get { return new EntityField("vw_AllCuringRecord", 23, "生产厂商", SqlDbType.NVarChar); }
		}

		public static EntityField 生产厂商Spell
		{
			get { return new EntityField("vw_AllCuringRecord", 24, "生产厂商Spell", SqlDbType.NVarChar); }
		}

		public static EntityField 创建人
		{
			get { return new EntityField("vw_AllCuringRecord", 25, "创建人", SqlDbType.NVarChar); }
		}

		public static EntityField 创建日期
		{
			get { return new EntityField("vw_AllCuringRecord", 26, "创建日期", SqlDbType.DateTime); }
		}

		public static EntityField 最后修改人
		{
			get { return new EntityField("vw_AllCuringRecord", 27, "最后修改人", SqlDbType.NVarChar); }
		}

		public static EntityField 最后修改时间
		{
			get { return new EntityField("vw_AllCuringRecord", 28, "最后修改时间", SqlDbType.DateTime); }
		}

		public static EntityField 备注
		{
			get { return new EntityField("vw_AllCuringRecord", 29, "备注", SqlDbType.NVarChar); }
		}

	}

	#endregion

}
