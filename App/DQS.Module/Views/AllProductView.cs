/*
 *	Build By: Codey Object Relation Mapping
 *	Build Data: 2014-03-04 22:32:22
 *	Build Type: View
 *	Description: AllProductView
*/

using System;
using System.Collections.Generic;
using System.Data;
using ORMSCore;

namespace DQS.Module.Views
{
	public class AllProductView : ViewBase
	{
		public int 药品ID
		{
			get { return (int)this.GetValue("药品ID"); } 
			set { this.SetValue("药品ID", value); } 
		}

		public string 药品编号
		{
			get { return (string)this.GetValue("药品编号"); } 
			set { this.SetValue("药品编号", value); } 
		}

		public string 药品名称
		{
			get { return (string)this.GetValue("药品名称"); } 
			set { this.SetValue("药品名称", value); } 
		}

		public string 药品名称Spell
		{
			get { return (string)this.GetValue("药品名称Spell"); } 
			set { this.SetValue("药品名称Spell", value); } 
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

		public string 规格
		{
			get { return (string)this.GetValue("规格"); } 
			set { this.SetValue("规格", value); } 
		}

		public string 单位
		{
			get { return (string)this.GetValue("单位"); } 
			set { this.SetValue("单位", value); } 
		}

		public string 包装规格
		{
			get { return (string)this.GetValue("包装规格"); } 
			set { this.SetValue("包装规格", value); } 
		}

		public string 剂型
		{
			get { return (string)this.GetValue("剂型"); } 
			set { this.SetValue("剂型", value); } 
		}

		public string 药品类别
		{
			get { return (string)this.GetValue("药品类别"); } 
			set { this.SetValue("药品类别", value); } 
		}

		public string 批准文号
		{
			get { return (string)this.GetValue("批准文号"); } 
			set { this.SetValue("批准文号", value); } 
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

		public bool 是否是电子监管药品
		{
			get { return (bool)this.GetValue("是否是电子监管药品"); } 
			set { this.SetValue("是否是电子监管药品", value); } 
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

		public string 注册证号
		{
			get { return (string)this.GetValue("注册证号"); } 
			set { this.SetValue("注册证号", value); } 
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

		public string 包装比例
		{
			get { return (string)this.GetValue("包装比例"); } 
			set { this.SetValue("包装比例", value); } 
		}

		public int 整货位最多存放数量
		{
			get { return (int)this.GetValue("整货位最多存放数量"); } 
			set { this.SetValue("整货位最多存放数量", value); } 
		}

		public int 零货位最多存放数量
		{
			get { return (int)this.GetValue("零货位最多存放数量"); } 
			set { this.SetValue("零货位最多存放数量", value); } 
		}

		public int 零货位最小存放数量
		{
			get { return (int)this.GetValue("零货位最小存放数量"); } 
			set { this.SetValue("零货位最小存放数量", value); } 
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

		public string 药品备注
		{
			get { return (string)this.GetValue("药品备注"); } 
			set { this.SetValue("药品备注", value); } 
		}

		public AllProductView()
		{
			this.ViewName = "vw_AllProduct";
			this.Fields = new Dictionary<string, EntityField>();
			this.Fields.Add("药品ID", AllProductViewFields.药品ID);
			this.Fields.Add("药品编号", AllProductViewFields.药品编号);
			this.Fields.Add("药品名称", AllProductViewFields.药品名称);
			this.Fields.Add("药品名称Spell", AllProductViewFields.药品名称Spell);
			this.Fields.Add("通用名称", AllProductViewFields.通用名称);
			this.Fields.Add("商品名称", AllProductViewFields.商品名称);
			this.Fields.Add("英文名称", AllProductViewFields.英文名称);
			this.Fields.Add("汉语拼音", AllProductViewFields.汉语拼音);
			this.Fields.Add("商品条码", AllProductViewFields.商品条码);
			this.Fields.Add("规格", AllProductViewFields.规格);
			this.Fields.Add("单位", AllProductViewFields.单位);
			this.Fields.Add("包装规格", AllProductViewFields.包装规格);
			this.Fields.Add("剂型", AllProductViewFields.剂型);
			this.Fields.Add("药品类别", AllProductViewFields.药品类别);
			this.Fields.Add("批准文号", AllProductViewFields.批准文号);
			this.Fields.Add("生产厂商", AllProductViewFields.生产厂商);
			this.Fields.Add("厂商Spell", AllProductViewFields.厂商Spell);
			this.Fields.Add("生产地址", AllProductViewFields.生产地址);
			this.Fields.Add("邮政编码", AllProductViewFields.邮政编码);
			this.Fields.Add("电话", AllProductViewFields.电话);
			this.Fields.Add("传真", AllProductViewFields.传真);
			this.Fields.Add("联系人", AllProductViewFields.联系人);
			this.Fields.Add("联系人Spell", AllProductViewFields.联系人Spell);
			this.Fields.Add("联系人电话", AllProductViewFields.联系人电话);
			this.Fields.Add("是否是电子监管药品", AllProductViewFields.是否是电子监管药品);
			this.Fields.Add("监管标识条码", AllProductViewFields.监管标识条码);
			this.Fields.Add("库存下限预警数量", AllProductViewFields.库存下限预警数量);
			this.Fields.Add("批号提前预警天数", AllProductViewFields.批号提前预警天数);
			this.Fields.Add("验收时效", AllProductViewFields.验收时效);
			this.Fields.Add("适应症", AllProductViewFields.适应症);
			this.Fields.Add("用法用量", AllProductViewFields.用法用量);
			this.Fields.Add("不良反应", AllProductViewFields.不良反应);
			this.Fields.Add("禁忌", AllProductViewFields.禁忌);
			this.Fields.Add("注意事项", AllProductViewFields.注意事项);
			this.Fields.Add("贮藏条件", AllProductViewFields.贮藏条件);
			this.Fields.Add("是否是孕妇及哺乳期妇女用药", AllProductViewFields.是否是孕妇及哺乳期妇女用药);
			this.Fields.Add("是否是儿童用药", AllProductViewFields.是否是儿童用药);
			this.Fields.Add("是否是老年用药", AllProductViewFields.是否是老年用药);
			this.Fields.Add("成分", AllProductViewFields.成分);
			this.Fields.Add("性状", AllProductViewFields.性状);
			this.Fields.Add("药物相互作用", AllProductViewFields.药物相互作用);
			this.Fields.Add("药物过量", AllProductViewFields.药物过量);
			this.Fields.Add("临床试验", AllProductViewFields.临床试验);
			this.Fields.Add("药理毒理", AllProductViewFields.药理毒理);
			this.Fields.Add("药代动力学", AllProductViewFields.药代动力学);
			this.Fields.Add("执行标准", AllProductViewFields.执行标准);
			this.Fields.Add("注册证号", AllProductViewFields.注册证号);
			this.Fields.Add("说明书内容", AllProductViewFields.说明书内容);
			this.Fields.Add("说明书修订日期", AllProductViewFields.说明书修订日期);
			this.Fields.Add("包装比例", AllProductViewFields.包装比例);
			this.Fields.Add("整货位最多存放数量", AllProductViewFields.整货位最多存放数量);
			this.Fields.Add("零货位最多存放数量", AllProductViewFields.零货位最多存放数量);
			this.Fields.Add("零货位最小存放数量", AllProductViewFields.零货位最小存放数量);
			this.Fields.Add("创建人", AllProductViewFields.创建人);
			this.Fields.Add("创建日期", AllProductViewFields.创建日期);
			this.Fields.Add("最后修改人", AllProductViewFields.最后修改人);
			this.Fields.Add("最后修改时间", AllProductViewFields.最后修改时间);
			this.Fields.Add("药品备注", AllProductViewFields.药品备注);
		}
	}

	#region AllProductViewFields

	public class AllProductViewFields
	{
		public static EntityField 药品ID
		{
			get { return new EntityField("vw_AllProduct", 0, "药品ID", SqlDbType.Int); }
		}

		public static EntityField 药品编号
		{
			get { return new EntityField("vw_AllProduct", 1, "药品编号", SqlDbType.NVarChar); }
		}

		public static EntityField 药品名称
		{
			get { return new EntityField("vw_AllProduct", 2, "药品名称", SqlDbType.NVarChar); }
		}

		public static EntityField 药品名称Spell
		{
			get { return new EntityField("vw_AllProduct", 3, "药品名称Spell", SqlDbType.NVarChar); }
		}

		public static EntityField 通用名称
		{
			get { return new EntityField("vw_AllProduct", 4, "通用名称", SqlDbType.NVarChar); }
		}

		public static EntityField 商品名称
		{
			get { return new EntityField("vw_AllProduct", 5, "商品名称", SqlDbType.NVarChar); }
		}

		public static EntityField 英文名称
		{
			get { return new EntityField("vw_AllProduct", 6, "英文名称", SqlDbType.NVarChar); }
		}

		public static EntityField 汉语拼音
		{
			get { return new EntityField("vw_AllProduct", 7, "汉语拼音", SqlDbType.NVarChar); }
		}

		public static EntityField 商品条码
		{
			get { return new EntityField("vw_AllProduct", 8, "商品条码", SqlDbType.NVarChar); }
		}

		public static EntityField 规格
		{
			get { return new EntityField("vw_AllProduct", 9, "规格", SqlDbType.NVarChar); }
		}

		public static EntityField 单位
		{
			get { return new EntityField("vw_AllProduct", 10, "单位", SqlDbType.NVarChar); }
		}

		public static EntityField 包装规格
		{
			get { return new EntityField("vw_AllProduct", 11, "包装规格", SqlDbType.NVarChar); }
		}

		public static EntityField 剂型
		{
			get { return new EntityField("vw_AllProduct", 12, "剂型", SqlDbType.NVarChar); }
		}

		public static EntityField 药品类别
		{
			get { return new EntityField("vw_AllProduct", 13, "药品类别", SqlDbType.NVarChar); }
		}

		public static EntityField 批准文号
		{
			get { return new EntityField("vw_AllProduct", 14, "批准文号", SqlDbType.NVarChar); }
		}

		public static EntityField 生产厂商
		{
			get { return new EntityField("vw_AllProduct", 15, "生产厂商", SqlDbType.NVarChar); }
		}

		public static EntityField 厂商Spell
		{
			get { return new EntityField("vw_AllProduct", 16, "厂商Spell", SqlDbType.NVarChar); }
		}

		public static EntityField 生产地址
		{
			get { return new EntityField("vw_AllProduct", 17, "生产地址", SqlDbType.NVarChar); }
		}

		public static EntityField 邮政编码
		{
			get { return new EntityField("vw_AllProduct", 18, "邮政编码", SqlDbType.NVarChar); }
		}

		public static EntityField 电话
		{
			get { return new EntityField("vw_AllProduct", 19, "电话", SqlDbType.NVarChar); }
		}

		public static EntityField 传真
		{
			get { return new EntityField("vw_AllProduct", 20, "传真", SqlDbType.NVarChar); }
		}

		public static EntityField 联系人
		{
			get { return new EntityField("vw_AllProduct", 21, "联系人", SqlDbType.NVarChar); }
		}

		public static EntityField 联系人Spell
		{
			get { return new EntityField("vw_AllProduct", 22, "联系人Spell", SqlDbType.NVarChar); }
		}

		public static EntityField 联系人电话
		{
			get { return new EntityField("vw_AllProduct", 23, "联系人电话", SqlDbType.NVarChar); }
		}

		public static EntityField 是否是电子监管药品
		{
			get { return new EntityField("vw_AllProduct", 24, "是否是电子监管药品", SqlDbType.Bit); }
		}

		public static EntityField 监管标识条码
		{
			get { return new EntityField("vw_AllProduct", 25, "监管标识条码", SqlDbType.NVarChar); }
		}

		public static EntityField 库存下限预警数量
		{
			get { return new EntityField("vw_AllProduct", 26, "库存下限预警数量", SqlDbType.Int); }
		}

		public static EntityField 批号提前预警天数
		{
			get { return new EntityField("vw_AllProduct", 27, "批号提前预警天数", SqlDbType.Int); }
		}

		public static EntityField 验收时效
		{
			get { return new EntityField("vw_AllProduct", 28, "验收时效", SqlDbType.NVarChar); }
		}

		public static EntityField 适应症
		{
			get { return new EntityField("vw_AllProduct", 29, "适应症", SqlDbType.NVarChar); }
		}

		public static EntityField 用法用量
		{
			get { return new EntityField("vw_AllProduct", 30, "用法用量", SqlDbType.NVarChar); }
		}

		public static EntityField 不良反应
		{
			get { return new EntityField("vw_AllProduct", 31, "不良反应", SqlDbType.NVarChar); }
		}

		public static EntityField 禁忌
		{
			get { return new EntityField("vw_AllProduct", 32, "禁忌", SqlDbType.NVarChar); }
		}

		public static EntityField 注意事项
		{
			get { return new EntityField("vw_AllProduct", 33, "注意事项", SqlDbType.NVarChar); }
		}

		public static EntityField 贮藏条件
		{
			get { return new EntityField("vw_AllProduct", 34, "贮藏条件", SqlDbType.NVarChar); }
		}

		public static EntityField 是否是孕妇及哺乳期妇女用药
		{
			get { return new EntityField("vw_AllProduct", 35, "是否是孕妇及哺乳期妇女用药", SqlDbType.Bit); }
		}

		public static EntityField 是否是儿童用药
		{
			get { return new EntityField("vw_AllProduct", 36, "是否是儿童用药", SqlDbType.Bit); }
		}

		public static EntityField 是否是老年用药
		{
			get { return new EntityField("vw_AllProduct", 37, "是否是老年用药", SqlDbType.Bit); }
		}

		public static EntityField 成分
		{
			get { return new EntityField("vw_AllProduct", 38, "成分", SqlDbType.NVarChar); }
		}

		public static EntityField 性状
		{
			get { return new EntityField("vw_AllProduct", 39, "性状", SqlDbType.NVarChar); }
		}

		public static EntityField 药物相互作用
		{
			get { return new EntityField("vw_AllProduct", 40, "药物相互作用", SqlDbType.NVarChar); }
		}

		public static EntityField 药物过量
		{
			get { return new EntityField("vw_AllProduct", 41, "药物过量", SqlDbType.NVarChar); }
		}

		public static EntityField 临床试验
		{
			get { return new EntityField("vw_AllProduct", 42, "临床试验", SqlDbType.NVarChar); }
		}

		public static EntityField 药理毒理
		{
			get { return new EntityField("vw_AllProduct", 43, "药理毒理", SqlDbType.NVarChar); }
		}

		public static EntityField 药代动力学
		{
			get { return new EntityField("vw_AllProduct", 44, "药代动力学", SqlDbType.NVarChar); }
		}

		public static EntityField 执行标准
		{
			get { return new EntityField("vw_AllProduct", 45, "执行标准", SqlDbType.NVarChar); }
		}

		public static EntityField 注册证号
		{
			get { return new EntityField("vw_AllProduct", 46, "注册证号", SqlDbType.NVarChar); }
		}

		public static EntityField 说明书内容
		{
			get { return new EntityField("vw_AllProduct", 47, "说明书内容", SqlDbType.NVarChar); }
		}

		public static EntityField 说明书修订日期
		{
			get { return new EntityField("vw_AllProduct", 48, "说明书修订日期", SqlDbType.DateTime); }
		}

		public static EntityField 包装比例
		{
			get { return new EntityField("vw_AllProduct", 49, "包装比例", SqlDbType.NVarChar); }
		}

		public static EntityField 整货位最多存放数量
		{
			get { return new EntityField("vw_AllProduct", 50, "整货位最多存放数量", SqlDbType.Int); }
		}

		public static EntityField 零货位最多存放数量
		{
			get { return new EntityField("vw_AllProduct", 51, "零货位最多存放数量", SqlDbType.Int); }
		}

		public static EntityField 零货位最小存放数量
		{
			get { return new EntityField("vw_AllProduct", 52, "零货位最小存放数量", SqlDbType.Int); }
		}

		public static EntityField 创建人
		{
			get { return new EntityField("vw_AllProduct", 53, "创建人", SqlDbType.NVarChar); }
		}

		public static EntityField 创建日期
		{
			get { return new EntityField("vw_AllProduct", 54, "创建日期", SqlDbType.DateTime); }
		}

		public static EntityField 最后修改人
		{
			get { return new EntityField("vw_AllProduct", 55, "最后修改人", SqlDbType.NVarChar); }
		}

		public static EntityField 最后修改时间
		{
			get { return new EntityField("vw_AllProduct", 56, "最后修改时间", SqlDbType.DateTime); }
		}

		public static EntityField 药品备注
		{
			get { return new EntityField("vw_AllProduct", 57, "药品备注", SqlDbType.NVarChar); }
		}

	}

	#endregion

}
