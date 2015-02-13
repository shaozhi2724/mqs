/*
 *	Build By: Codey Object Relation Mapping
 *	Build Data: 2014-03-04 22:32:22
 *	Build Type: View
 *	Description: AllAttachmentView
*/

using System;
using System.Collections.Generic;
using System.Data;
using ORMSCore;

namespace DQS.Module.Views
{
	public class AllAttachmentView : ViewBase
	{
		public int 附件ID
		{
			get { return (int)this.GetValue("附件ID"); } 
			set { this.SetValue("附件ID", value); } 
		}

		public string 附件名称
		{
			get { return (string)this.GetValue("附件名称"); } 
			set { this.SetValue("附件名称", value); } 
		}

		public int 所属档案ID
		{
			get { return (int)this.GetValue("所属档案ID"); } 
			set { this.SetValue("所属档案ID", value); } 
		}

		public string 附件大小
		{
			get { return (string)this.GetValue("附件大小"); } 
			set { this.SetValue("附件大小", value); } 
		}

		public string 类型
		{
			get { return (string)this.GetValue("类型"); } 
			set { this.SetValue("类型", value); } 
		}

		public string 上传人
		{
			get { return (string)this.GetValue("上传人"); } 
			set { this.SetValue("上传人", value); } 
		}

		public DateTime 上传日期
		{
			get { return (DateTime)this.GetValue("上传日期"); } 
			set { this.SetValue("上传日期", value); } 
		}

		public AllAttachmentView()
		{
			this.ViewName = "vw_AllAttachment";
			this.Fields = new Dictionary<string, EntityField>();
			this.Fields.Add("附件ID", AllAttachmentViewFields.附件ID);
			this.Fields.Add("附件名称", AllAttachmentViewFields.附件名称);
			this.Fields.Add("所属档案ID", AllAttachmentViewFields.所属档案ID);
			this.Fields.Add("附件大小", AllAttachmentViewFields.附件大小);
			this.Fields.Add("类型", AllAttachmentViewFields.类型);
			this.Fields.Add("上传人", AllAttachmentViewFields.上传人);
			this.Fields.Add("上传日期", AllAttachmentViewFields.上传日期);
		}
	}

	#region AllAttachmentViewFields

	public class AllAttachmentViewFields
	{
		public static EntityField 附件ID
		{
			get { return new EntityField("vw_AllAttachment", 0, "附件ID", SqlDbType.Int); }
		}

		public static EntityField 附件名称
		{
			get { return new EntityField("vw_AllAttachment", 1, "附件名称", SqlDbType.NVarChar); }
		}

		public static EntityField 所属档案ID
		{
			get { return new EntityField("vw_AllAttachment", 2, "所属档案ID", SqlDbType.Int); }
		}

		public static EntityField 附件大小
		{
			get { return new EntityField("vw_AllAttachment", 3, "附件大小", SqlDbType.NVarChar); }
		}

		public static EntityField 类型
		{
			get { return new EntityField("vw_AllAttachment", 4, "类型", SqlDbType.NVarChar); }
		}

		public static EntityField 上传人
		{
			get { return new EntityField("vw_AllAttachment", 5, "上传人", SqlDbType.NVarChar); }
		}

		public static EntityField 上传日期
		{
			get { return new EntityField("vw_AllAttachment", 6, "上传日期", SqlDbType.DateTime); }
		}

	}

	#endregion

}
