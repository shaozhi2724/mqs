/*
 *	Build By: Codey Object Relation Mapping
 *	Build Data: 2014-03-04 22:32:22
 *	Build Type: View
 *	Description: AllFirstProductView
*/

using System;
using System.Collections.Generic;
using System.Data;
using ORMSCore;

namespace DQS.Module.Views
{
	public class AllFirstProductView : ViewBase
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

		public string 通用名称
		{
			get { return (string)this.GetValue("通用名称"); } 
			set { this.SetValue("通用名称", value); } 
		}

		public string 商品名称
		{
			get { return (string)this.GetValue("商品名称"); } 
			set { this.SetValue("商品名称", value); } 
		}

		public string 英文名称
		{
			get { return (string)this.GetValue("英文名称"); } 
			set { this.SetValue("英文名称", value); } 
		}

		public string 汉语拼音
		{
			get { return (string)this.GetValue("汉语拼音"); } 
			set { this.SetValue("汉语拼音", value); } 
		}

		public string 商品条码
		{
			get { return (string)this.GetValue("商品条码"); } 
			set { this.SetValue("商品条码", value); } 
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

		public string 厂商Spell
		{
			get { return (string)this.GetValue("厂商Spell"); } 
			set { this.SetValue("厂商Spell", value); } 
		}

		public string 生产地址
		{
			get { return (string)this.GetValue("生产地址"); } 
			set { this.SetValue("生产地址", value); } 
		}

		public string 邮政编码
		{
			get { return (string)this.GetValue("邮政编码"); } 
			set { this.SetValue("邮政编码", value); } 
		}

		public string 电话
		{
			get { return (string)this.GetValue("电话"); } 
			set { this.SetValue("电话", value); } 
		}

		public string 传真
		{
			get { return (string)this.GetValue("传真"); } 
			set { this.SetValue("传真", value); } 
		}

		public string 联系人
		{
			get { return (string)this.GetValue("联系人"); } 
			set { this.SetValue("联系人", value); } 
		}

		public string 联系人Spell
		{
			get { return (string)this.GetValue("联系人Spell"); } 
			set { this.SetValue("联系人Spell", value); } 
		}

		public string 联系人电话
		{
			get { return (string)this.GetValue("联系人电话"); } 
			set { this.SetValue("联系人电话", value); } 
		}

		public bool 是否是电子监管产品
		{
			get { return (bool)this.GetValue("是否是电子监管产品"); } 
			set { this.SetValue("是否是电子监管产品", value); } 
		}

		public string 监管标识条码
		{
			get { return (string)this.GetValue("监管标识条码"); } 
			set { this.SetValue("监管标识条码", value); } 
		}

		public int 库存下限预警数量
		{
			get { return (int)this.GetValue("库存下限预警数量"); } 
			set { this.SetValue("库存下限预警数量", value); } 
		}

		public int 批号提前预警天数
		{
			get { return (int)this.GetValue("批号提前预警天数"); } 
			set { this.SetValue("批号提前预警天数", value); } 
		}

		public string 验收时效
		{
			get { return (string)this.GetValue("验收时效"); } 
			set { this.SetValue("验收时效", value); } 
		}

		public string 适应症
		{
			get { return (string)this.GetValue("适应症"); } 
			set { this.SetValue("适应症", value); } 
		}

		public string 用法用量
		{
			get { return (string)this.GetValue("用法用量"); } 
			set { this.SetValue("用法用量", value); } 
		}

		public string 不良反应
		{
			get { return (string)this.GetValue("不良反应"); } 
			set { this.SetValue("不良反应", value); } 
		}

		public string 禁忌
		{
			get { return (string)this.GetValue("禁忌"); } 
			set { this.SetValue("禁忌", value); } 
		}

		public string 注意事项
		{
			get { return (string)this.GetValue("注意事项"); } 
			set { this.SetValue("注意事项", value); } 
		}

		public string 贮藏条件
		{
			get { return (string)this.GetValue("贮藏条件"); } 
			set { this.SetValue("贮藏条件", value); } 
		}

		public bool 是否是孕妇及哺乳期妇女用药
		{
			get { return (bool)this.GetValue("是否是孕妇及哺乳期妇女用药"); } 
			set { this.SetValue("是否是孕妇及哺乳期妇女用药", value); } 
		}

		public bool 是否是儿童用药
		{
			get { return (bool)this.GetValue("是否是儿童用药"); } 
			set { this.SetValue("是否是儿童用药", value); } 
		}

		public bool 是否是老年用药
		{
			get { return (bool)this.GetValue("是否是老年用药"); } 
			set { this.SetValue("是否是老年用药", value); } 
		}

		public string 成分
		{
			get { return (string)this.GetValue("成分"); } 
			set { this.SetValue("成分", value); } 
		}

		public string 性状
		{
			get { return (string)this.GetValue("性状"); } 
			set { this.SetValue("性状", value); } 
		}

		public string 药物相互作用
		{
			get { return (string)this.GetValue("药物相互作用"); } 
			set { this.SetValue("药物相互作用", value); } 
		}

		public string 药物过量
		{
			get { return (string)this.GetValue("药物过量"); } 
			set { this.SetValue("药物过量", value); } 
		}

		public string 临床试验
		{
			get { return (string)this.GetValue("临床试验"); } 
			set { this.SetValue("临床试验", value); } 
		}

		public string 药理毒理
		{
			get { return (string)this.GetValue("药理毒理"); } 
			set { this.SetValue("药理毒理", value); } 
		}

		public string 药代动力学
		{
			get { return (string)this.GetValue("药代动力学"); } 
			set { this.SetValue("药代动力学", value); } 
		}

		public string 执行标准
		{
			get { return (string)this.GetValue("执行标准"); } 
			set { this.SetValue("执行标准", value); } 
		}

		public string 注册商标
		{
            get { return (string)this.GetValue("注册商标"); }
            set { this.SetValue("注册商标", value); } 
		}

		public string 说明书内容
		{
			get { return (string)this.GetValue("说明书内容"); } 
			set { this.SetValue("说明书内容", value); } 
		}

		public DateTime 说明书修订日期
		{
			get { return (DateTime)this.GetValue("说明书修订日期"); } 
			set { this.SetValue("说明书修订日期", value); } 
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

		public string 产品备注
		{
			get { return (string)this.GetValue("产品备注"); } 
			set { this.SetValue("产品备注", value); } 
		}

		public AllFirstProductView()
		{
			this.ViewName = "vw_AllFirstProduct";
			this.Fields = new Dictionary<string, EntityField>();
			this.Fields.Add("产品ID", AllFirstProductViewFields.产品ID);
			this.Fields.Add("产品编号", AllFirstProductViewFields.产品编号);
			this.Fields.Add("产品名称", AllFirstProductViewFields.产品名称);
			this.Fields.Add("产品名称Spell", AllFirstProductViewFields.产品名称Spell);
			this.Fields.Add("通用名称", AllFirstProductViewFields.通用名称);
			this.Fields.Add("商品名称", AllFirstProductViewFields.商品名称);
			this.Fields.Add("英文名称", AllFirstProductViewFields.英文名称);
			this.Fields.Add("汉语拼音", AllFirstProductViewFields.汉语拼音);
			this.Fields.Add("商品条码", AllFirstProductViewFields.商品条码);
			this.Fields.Add("规格型号", AllFirstProductViewFields.规格型号);
			this.Fields.Add("单位", AllFirstProductViewFields.单位);
			this.Fields.Add("包装规格型号", AllFirstProductViewFields.包装规格);
			this.Fields.Add("剂型", AllFirstProductViewFields.剂型);
			this.Fields.Add("产品类别", AllFirstProductViewFields.产品类别);
			this.Fields.Add("注册证号", AllFirstProductViewFields.注册证号);
			this.Fields.Add("生产厂商", AllFirstProductViewFields.生产厂商);
			this.Fields.Add("厂商Spell", AllFirstProductViewFields.厂商Spell);
			this.Fields.Add("生产地址", AllFirstProductViewFields.生产地址);
			this.Fields.Add("邮政编码", AllFirstProductViewFields.邮政编码);
			this.Fields.Add("电话", AllFirstProductViewFields.电话);
			this.Fields.Add("传真", AllFirstProductViewFields.传真);
			this.Fields.Add("联系人", AllFirstProductViewFields.联系人);
			this.Fields.Add("联系人Spell", AllFirstProductViewFields.联系人Spell);
			this.Fields.Add("联系人电话", AllFirstProductViewFields.联系人电话);
			this.Fields.Add("是否是电子监管产品", AllFirstProductViewFields.是否是电子监管产品);
			this.Fields.Add("监管标识条码", AllFirstProductViewFields.监管标识条码);
			this.Fields.Add("库存下限预警数量", AllFirstProductViewFields.库存下限预警数量);
			this.Fields.Add("批号提前预警天数", AllFirstProductViewFields.批号提前预警天数);
			this.Fields.Add("验收时效", AllFirstProductViewFields.验收时效);
			this.Fields.Add("适应症", AllFirstProductViewFields.适应症);
			this.Fields.Add("用法用量", AllFirstProductViewFields.用法用量);
			this.Fields.Add("不良反应", AllFirstProductViewFields.不良反应);
			this.Fields.Add("禁忌", AllFirstProductViewFields.禁忌);
			this.Fields.Add("注意事项", AllFirstProductViewFields.注意事项);
			this.Fields.Add("贮藏条件", AllFirstProductViewFields.贮藏条件);
			this.Fields.Add("是否是孕妇及哺乳期妇女用药", AllFirstProductViewFields.是否是孕妇及哺乳期妇女用药);
			this.Fields.Add("是否是儿童用药", AllFirstProductViewFields.是否是儿童用药);
			this.Fields.Add("是否是老年用药", AllFirstProductViewFields.是否是老年用药);
			this.Fields.Add("成分", AllFirstProductViewFields.成分);
			this.Fields.Add("性状", AllFirstProductViewFields.性状);
			this.Fields.Add("药物相互作用", AllFirstProductViewFields.药物相互作用);
			this.Fields.Add("药物过量", AllFirstProductViewFields.药物过量);
			this.Fields.Add("临床试验", AllFirstProductViewFields.临床试验);
			this.Fields.Add("药理毒理", AllFirstProductViewFields.药理毒理);
			this.Fields.Add("药代动力学", AllFirstProductViewFields.药代动力学);
			this.Fields.Add("执行标准", AllFirstProductViewFields.执行标准);
			this.Fields.Add("注册证号", AllFirstProductViewFields.注册证号);
			this.Fields.Add("说明书内容", AllFirstProductViewFields.说明书内容);
			this.Fields.Add("说明书修订日期", AllFirstProductViewFields.说明书修订日期);
			this.Fields.Add("创建人", AllFirstProductViewFields.创建人);
			this.Fields.Add("创建日期", AllFirstProductViewFields.创建日期);
			this.Fields.Add("最后修改人", AllFirstProductViewFields.最后修改人);
			this.Fields.Add("最后修改时间", AllFirstProductViewFields.最后修改时间);
			this.Fields.Add("产品备注", AllFirstProductViewFields.产品备注);
		}
	}

	#region AllFirstProductViewFields

	public class AllFirstProductViewFields
	{
		public static EntityField 产品ID
		{
			get { return new EntityField("vw_AllFirstProduct", 0, "产品ID", SqlDbType.Int); }
		}

		public static EntityField 产品编号
		{
			get { return new EntityField("vw_AllFirstProduct", 1, "产品编号", SqlDbType.NVarChar); }
		}

		public static EntityField 产品名称
		{
			get { return new EntityField("vw_AllFirstProduct", 2, "产品名称", SqlDbType.NVarChar); }
		}

		public static EntityField 产品名称Spell
		{
			get { return new EntityField("vw_AllFirstProduct", 3, "产品名称Spell", SqlDbType.NVarChar); }
		}

		public static EntityField 通用名称
		{
			get { return new EntityField("vw_AllFirstProduct", 4, "通用名称", SqlDbType.NVarChar); }
		}

		public static EntityField 商品名称
		{
			get { return new EntityField("vw_AllFirstProduct", 5, "商品名称", SqlDbType.NVarChar); }
		}

		public static EntityField 英文名称
		{
			get { return new EntityField("vw_AllFirstProduct", 6, "英文名称", SqlDbType.NVarChar); }
		}

		public static EntityField 汉语拼音
		{
			get { return new EntityField("vw_AllFirstProduct", 7, "汉语拼音", SqlDbType.NVarChar); }
		}

		public static EntityField 商品条码
		{
			get { return new EntityField("vw_AllFirstProduct", 8, "商品条码", SqlDbType.NVarChar); }
		}

		public static EntityField 规格型号
		{
			get { return new EntityField("vw_AllFirstProduct", 9, "规格型号", SqlDbType.NVarChar); }
		}

		public static EntityField 单位
		{
			get { return new EntityField("vw_AllFirstProduct", 10, "单位", SqlDbType.NVarChar); }
		}

		public static EntityField 包装规格
		{
			get { return new EntityField("vw_AllFirstProduct", 11, "包装规格型号", SqlDbType.NVarChar); }
		}

		public static EntityField 剂型
		{
			get { return new EntityField("vw_AllFirstProduct", 12, "剂型", SqlDbType.NVarChar); }
		}

		public static EntityField 产品类别
		{
			get { return new EntityField("vw_AllFirstProduct", 13, "产品类别", SqlDbType.NVarChar); }
		}

		public static EntityField 注册证号
		{
			get { return new EntityField("vw_AllFirstProduct", 14, "注册证号", SqlDbType.NVarChar); }
		}

		public static EntityField 生产厂商
		{
			get { return new EntityField("vw_AllFirstProduct", 15, "生产厂商", SqlDbType.NVarChar); }
		}

		public static EntityField 厂商Spell
		{
			get { return new EntityField("vw_AllFirstProduct", 16, "厂商Spell", SqlDbType.NVarChar); }
		}

		public static EntityField 生产地址
		{
			get { return new EntityField("vw_AllFirstProduct", 17, "生产地址", SqlDbType.NVarChar); }
		}

		public static EntityField 邮政编码
		{
			get { return new EntityField("vw_AllFirstProduct", 18, "邮政编码", SqlDbType.NVarChar); }
		}

		public static EntityField 电话
		{
			get { return new EntityField("vw_AllFirstProduct", 19, "电话", SqlDbType.NVarChar); }
		}

		public static EntityField 传真
		{
			get { return new EntityField("vw_AllFirstProduct", 20, "传真", SqlDbType.NVarChar); }
		}

		public static EntityField 联系人
		{
			get { return new EntityField("vw_AllFirstProduct", 21, "联系人", SqlDbType.NVarChar); }
		}

		public static EntityField 联系人Spell
		{
			get { return new EntityField("vw_AllFirstProduct", 22, "联系人Spell", SqlDbType.NVarChar); }
		}

		public static EntityField 联系人电话
		{
			get { return new EntityField("vw_AllFirstProduct", 23, "联系人电话", SqlDbType.NVarChar); }
		}

		public static EntityField 是否是电子监管产品
		{
			get { return new EntityField("vw_AllFirstProduct", 24, "是否是电子监管产品", SqlDbType.Bit); }
		}

		public static EntityField 监管标识条码
		{
			get { return new EntityField("vw_AllFirstProduct", 25, "监管标识条码", SqlDbType.NVarChar); }
		}

		public static EntityField 库存下限预警数量
		{
			get { return new EntityField("vw_AllFirstProduct", 26, "库存下限预警数量", SqlDbType.Int); }
		}

		public static EntityField 批号提前预警天数
		{
			get { return new EntityField("vw_AllFirstProduct", 27, "批号提前预警天数", SqlDbType.Int); }
		}

		public static EntityField 验收时效
		{
			get { return new EntityField("vw_AllFirstProduct", 28, "验收时效", SqlDbType.NVarChar); }
		}

		public static EntityField 适应症
		{
			get { return new EntityField("vw_AllFirstProduct", 29, "适应症", SqlDbType.NVarChar); }
		}

		public static EntityField 用法用量
		{
			get { return new EntityField("vw_AllFirstProduct", 30, "用法用量", SqlDbType.NVarChar); }
		}

		public static EntityField 不良反应
		{
			get { return new EntityField("vw_AllFirstProduct", 31, "不良反应", SqlDbType.NVarChar); }
		}

		public static EntityField 禁忌
		{
			get { return new EntityField("vw_AllFirstProduct", 32, "禁忌", SqlDbType.NVarChar); }
		}

		public static EntityField 注意事项
		{
			get { return new EntityField("vw_AllFirstProduct", 33, "注意事项", SqlDbType.NVarChar); }
		}

		public static EntityField 贮藏条件
		{
			get { return new EntityField("vw_AllFirstProduct", 34, "贮藏条件", SqlDbType.NVarChar); }
		}

		public static EntityField 是否是孕妇及哺乳期妇女用药
		{
			get { return new EntityField("vw_AllFirstProduct", 35, "是否是孕妇及哺乳期妇女用药", SqlDbType.Bit); }
		}

		public static EntityField 是否是儿童用药
		{
			get { return new EntityField("vw_AllFirstProduct", 36, "是否是儿童用药", SqlDbType.Bit); }
		}

		public static EntityField 是否是老年用药
		{
			get { return new EntityField("vw_AllFirstProduct", 37, "是否是老年用药", SqlDbType.Bit); }
		}

		public static EntityField 成分
		{
			get { return new EntityField("vw_AllFirstProduct", 38, "成分", SqlDbType.NVarChar); }
		}

		public static EntityField 性状
		{
			get { return new EntityField("vw_AllFirstProduct", 39, "性状", SqlDbType.NVarChar); }
		}

		public static EntityField 药物相互作用
		{
			get { return new EntityField("vw_AllFirstProduct", 40, "药物相互作用", SqlDbType.NVarChar); }
		}

		public static EntityField 药物过量
		{
			get { return new EntityField("vw_AllFirstProduct", 41, "药物过量", SqlDbType.NVarChar); }
		}

		public static EntityField 临床试验
		{
			get { return new EntityField("vw_AllFirstProduct", 42, "临床试验", SqlDbType.NVarChar); }
		}

		public static EntityField 药理毒理
		{
			get { return new EntityField("vw_AllFirstProduct", 43, "药理毒理", SqlDbType.NVarChar); }
		}

		public static EntityField 药代动力学
		{
			get { return new EntityField("vw_AllFirstProduct", 44, "药代动力学", SqlDbType.NVarChar); }
		}

		public static EntityField 执行标准
		{
			get { return new EntityField("vw_AllFirstProduct", 45, "执行标准", SqlDbType.NVarChar); }
		}

		public static EntityField 注册商标
		{
            get { return new EntityField("vw_AllFirstProduct", 46, "注册商标", SqlDbType.NVarChar); }
		}

		public static EntityField 说明书内容
		{
			get { return new EntityField("vw_AllFirstProduct", 47, "说明书内容", SqlDbType.NVarChar); }
		}

		public static EntityField 说明书修订日期
		{
			get { return new EntityField("vw_AllFirstProduct", 48, "说明书修订日期", SqlDbType.DateTime); }
		}

		public static EntityField 创建人
		{
			get { return new EntityField("vw_AllFirstProduct", 49, "创建人", SqlDbType.NVarChar); }
		}

		public static EntityField 创建日期
		{
			get { return new EntityField("vw_AllFirstProduct", 50, "创建日期", SqlDbType.DateTime); }
		}

		public static EntityField 最后修改人
		{
			get { return new EntityField("vw_AllFirstProduct", 51, "最后修改人", SqlDbType.NVarChar); }
		}

		public static EntityField 最后修改时间
		{
			get { return new EntityField("vw_AllFirstProduct", 52, "最后修改时间", SqlDbType.DateTime); }
		}

		public static EntityField 产品备注
		{
			get { return new EntityField("vw_AllFirstProduct", 53, "产品备注", SqlDbType.NVarChar); }
		}

	}

	#endregion

}
