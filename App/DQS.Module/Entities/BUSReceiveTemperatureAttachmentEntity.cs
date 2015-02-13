/*
 *	Build By: Codey Object Relation Mapping
 *	Build Data: 2014-05-02 19:59:49
 *	Build Type: Entity
 *	Description: BUSReceiveTemperatureAttachmentEntity
*/

using System;
using System.Collections.Generic;
using System.Data;
using ORMSCore;

namespace DQS.Module.Entities
{
	public class BUSReceiveTemperatureAttachmentEntity : EntityBase
	{
		public int ReceiveTemperatureAttachmentID
		{
			get { return (int)this.GetValue("ReceiveTemperatureAttachmentID"); } 
			set { this.SetValue("ReceiveTemperatureAttachmentID", value); } 
		}

		public int ReceiveID
		{
			get { return (int)this.GetValue("ReceiveID"); } 
			set { this.SetValue("ReceiveID", value); } 
		}

		public string AttachmentName
		{
			get { return (string)this.GetValue("AttachmentName"); } 
			set { this.SetValue("AttachmentName", value); } 
		}

		public string AttachmentSize
		{
			get { return (string)this.GetValue("AttachmentSize"); } 
			set { this.SetValue("AttachmentSize", value); } 
		}

		public string AttachmentType
		{
			get { return (string)this.GetValue("AttachmentType"); } 
			set { this.SetValue("AttachmentType", value); } 
		}

		public string AttachmentPath
		{
			get { return (string)this.GetValue("AttachmentPath"); } 
			set { this.SetValue("AttachmentPath", value); } 
		}

		public byte[] AttachmentContent
		{
			get { return (byte[])this.GetValue("AttachmentContent"); } 
			set { this.SetValue("AttachmentContent", value); } 
		}

		public string AttachmentRemark
		{
			get { return (string)this.GetValue("AttachmentRemark"); } 
			set { this.SetValue("AttachmentRemark", value); } 
		}

		public Guid CreateUserID
		{
			get { return (Guid)this.GetValue("CreateUserID"); } 
			set { this.SetValue("CreateUserID", value); } 
		}

		public DateTime CreateDate
		{
			get { return (DateTime)this.GetValue("CreateDate"); } 
			set { this.SetValue("CreateDate", value); } 
		}

		public BUSReceiveTemperatureAttachmentEntity()
		{
			this.TableName = "BUS_ReceiveTemperatureAttachment";
			this.Fields = new Dictionary<string, EntityField>();
			this.Fields.Add("ReceiveTemperatureAttachmentID", BUSReceiveTemperatureAttachmentEntityFields.ReceiveTemperatureAttachmentID);
			this.Fields.Add("ReceiveID", BUSReceiveTemperatureAttachmentEntityFields.ReceiveID);
			this.Fields.Add("AttachmentName", BUSReceiveTemperatureAttachmentEntityFields.AttachmentName);
			this.Fields.Add("AttachmentSize", BUSReceiveTemperatureAttachmentEntityFields.AttachmentSize);
			this.Fields.Add("AttachmentType", BUSReceiveTemperatureAttachmentEntityFields.AttachmentType);
			this.Fields.Add("AttachmentPath", BUSReceiveTemperatureAttachmentEntityFields.AttachmentPath);
			this.Fields.Add("AttachmentContent", BUSReceiveTemperatureAttachmentEntityFields.AttachmentContent);
			this.Fields.Add("AttachmentRemark", BUSReceiveTemperatureAttachmentEntityFields.AttachmentRemark);
			this.Fields.Add("CreateUserID", BUSReceiveTemperatureAttachmentEntityFields.CreateUserID);
			this.Fields.Add("CreateDate", BUSReceiveTemperatureAttachmentEntityFields.CreateDate);
		}
	}

	#region BUSReceiveTemperatureAttachmentEntityFields

	public class BUSReceiveTemperatureAttachmentEntityFields
	{
		public static EntityField ReceiveTemperatureAttachmentID
		{
			get { return new EntityField("BUS_ReceiveTemperatureAttachment", 0, "ReceiveTemperatureAttachmentID", SqlDbType.Int, true, true, true, false); }
		}

		public static EntityField ReceiveID
		{
			get { return new EntityField("BUS_ReceiveTemperatureAttachment", 1, "ReceiveID", SqlDbType.Int, false, false, false, false); }
		}

		public static EntityField AttachmentName
		{
			get { return new EntityField("BUS_ReceiveTemperatureAttachment", 2, "AttachmentName", SqlDbType.NVarChar, false, false, false, false); }
		}

		public static EntityField AttachmentSize
		{
			get { return new EntityField("BUS_ReceiveTemperatureAttachment", 3, "AttachmentSize", SqlDbType.NVarChar, false, false, false, true); }
		}

		public static EntityField AttachmentType
		{
			get { return new EntityField("BUS_ReceiveTemperatureAttachment", 4, "AttachmentType", SqlDbType.NVarChar, false, false, false, true); }
		}

		public static EntityField AttachmentPath
		{
			get { return new EntityField("BUS_ReceiveTemperatureAttachment", 5, "AttachmentPath", SqlDbType.NVarChar, false, false, false, true); }
		}

		public static EntityField AttachmentContent
		{
			get { return new EntityField("BUS_ReceiveTemperatureAttachment", 6, "AttachmentContent", SqlDbType.VarBinary, false, false, false, true); }
		}

		public static EntityField AttachmentRemark
		{
			get { return new EntityField("BUS_ReceiveTemperatureAttachment", 7, "AttachmentRemark", SqlDbType.NVarChar, false, false, false, true); }
		}

		public static EntityField CreateUserID
		{
			get { return new EntityField("BUS_ReceiveTemperatureAttachment", 8, "CreateUserID", SqlDbType.UniqueIdentifier, false, false, false, true); }
		}

		public static EntityField CreateDate
		{
			get { return new EntityField("BUS_ReceiveTemperatureAttachment", 9, "CreateDate", SqlDbType.DateTime, false, false, false, true); }
		}

	}

	#endregion

	#region BUSReceiveTemperatureAttachmentEntityFields2

	public enum BUSReceiveTemperatureAttachmentEntityFields2
	{
		ReceiveTemperatureAttachmentID,

		ReceiveID,

		AttachmentName,

		AttachmentSize,

		AttachmentType,

		AttachmentPath,

		AttachmentContent,

		AttachmentRemark,

		CreateUserID,

		CreateDate,

	}

	#endregion

}
