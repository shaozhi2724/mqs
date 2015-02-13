/*
 *	Build By: Codey Object Relation Mapping
 *	Build Data: 2014-03-04 22:32:22
 *	Build Type: View
 *	Description: AllDbBackupsView
*/

using System;
using System.Collections.Generic;
using System.Data;
using ORMSCore;

namespace DQS.Module.Views
{
	public class AllDbBackupsView : ViewBase
	{
		public int 备份ID
		{
			get { return (int)this.GetValue("备份ID"); } 
			set { this.SetValue("备份ID", value); } 
		}

		public string 备份人
		{
			get { return (string)this.GetValue("备份人"); } 
			set { this.SetValue("备份人", value); } 
		}

		public DateTime 备份时间
		{
			get { return (DateTime)this.GetValue("备份时间"); } 
			set { this.SetValue("备份时间", value); } 
		}

		public string 文件名
		{
			get { return (string)this.GetValue("文件名"); } 
			set { this.SetValue("文件名", value); } 
		}

		public string 路径
		{
			get { return (string)this.GetValue("路径"); } 
			set { this.SetValue("路径", value); } 
		}

		public string 目标机器
		{
			get { return (string)this.GetValue("目标机器"); } 
			set { this.SetValue("目标机器", value); } 
		}

		public string 大小
		{
			get { return (string)this.GetValue("大小"); } 
			set { this.SetValue("大小", value); } 
		}

		public string 还原数据库名称
		{
			get { return (string)this.GetValue("还原数据库名称"); } 
			set { this.SetValue("还原数据库名称", value); } 
		}

		public string 原因
		{
			get { return (string)this.GetValue("原因"); } 
			set { this.SetValue("原因", value); } 
		}

		public string 备注
		{
			get { return (string)this.GetValue("备注"); } 
			set { this.SetValue("备注", value); } 
		}

		public AllDbBackupsView()
		{
			this.ViewName = "vw_AllDbBackups";
			this.Fields = new Dictionary<string, EntityField>();
			this.Fields.Add("备份ID", AllDbBackupsViewFields.备份ID);
			this.Fields.Add("备份人", AllDbBackupsViewFields.备份人);
			this.Fields.Add("备份时间", AllDbBackupsViewFields.备份时间);
			this.Fields.Add("文件名", AllDbBackupsViewFields.文件名);
			this.Fields.Add("路径", AllDbBackupsViewFields.路径);
			this.Fields.Add("目标机器", AllDbBackupsViewFields.目标机器);
			this.Fields.Add("大小", AllDbBackupsViewFields.大小);
			this.Fields.Add("还原数据库名称", AllDbBackupsViewFields.还原数据库名称);
			this.Fields.Add("原因", AllDbBackupsViewFields.原因);
			this.Fields.Add("备注", AllDbBackupsViewFields.备注);
		}
	}

	#region AllDbBackupsViewFields

	public class AllDbBackupsViewFields
	{
		public static EntityField 备份ID
		{
			get { return new EntityField("vw_AllDbBackups", 0, "备份ID", SqlDbType.Int); }
		}

		public static EntityField 备份人
		{
			get { return new EntityField("vw_AllDbBackups", 1, "备份人", SqlDbType.NVarChar); }
		}

		public static EntityField 备份时间
		{
			get { return new EntityField("vw_AllDbBackups", 2, "备份时间", SqlDbType.DateTime); }
		}

		public static EntityField 文件名
		{
			get { return new EntityField("vw_AllDbBackups", 3, "文件名", SqlDbType.NVarChar); }
		}

		public static EntityField 路径
		{
			get { return new EntityField("vw_AllDbBackups", 4, "路径", SqlDbType.NVarChar); }
		}

		public static EntityField 目标机器
		{
			get { return new EntityField("vw_AllDbBackups", 5, "目标机器", SqlDbType.NVarChar); }
		}

		public static EntityField 大小
		{
			get { return new EntityField("vw_AllDbBackups", 6, "大小", SqlDbType.NVarChar); }
		}

		public static EntityField 还原数据库名称
		{
			get { return new EntityField("vw_AllDbBackups", 7, "还原数据库名称", SqlDbType.NVarChar); }
		}

		public static EntityField 原因
		{
			get { return new EntityField("vw_AllDbBackups", 8, "原因", SqlDbType.NVarChar); }
		}

		public static EntityField 备注
		{
			get { return new EntityField("vw_AllDbBackups", 9, "备注", SqlDbType.NVarChar); }
		}

	}

	#endregion

}
