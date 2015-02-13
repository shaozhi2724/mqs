/*
 *	Build By: Codey Object Relation Mapping
 *	Build Data: 2014-05-02 22:01:19
 *	Build Type: Entity
 *	Description: BUSAcceptAttachmentEntity
*/

using System;
using System.Collections.Generic;
using System.Data;
using ORMSCore;

namespace DQS.Module.Entities
{
	public class BUSAcceptAttachmentEntity : EntityBase
	{
		public int AcceptAttachmentID
		{
			get { return (int)this.GetValue("AcceptAttachmentID"); } 
			set { this.SetValue("AcceptAttachmentID", value); } 
		}

		public int AcceptID
		{
			get { return (int)this.GetValue("AcceptID"); } 
			set { this.SetValue("AcceptID", value); } 
		}

		public int ProductID
		{
			get { return (int)this.GetValue("ProductID"); } 
			set { this.SetValue("ProductID", value); } 
		}

		public string BatchNo
		{
			get { return (string)this.GetValue("BatchNo"); } 
			set { this.SetValue("BatchNo", value); } 
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

		public BUSAcceptAttachmentEntity()
		{
			this.TableName = "BUS_AcceptAttachment";
			this.Fields = new Dictionary<string, EntityField>();
			this.Fields.Add("AcceptAttachmentID", BUSAcceptAttachmentEntityFields.AcceptAttachmentID);
			this.Fields.Add("AcceptID", BUSAcceptAttachmentEntityFields.AcceptID);
			this.Fields.Add("ProductID", BUSAcceptAttachmentEntityFields.ProductID);
			this.Fields.Add("BatchNo", BUSAcceptAttachmentEntityFields.BatchNo);
			this.Fields.Add("AttachmentName", BUSAcceptAttachmentEntityFields.AttachmentName);
			this.Fields.Add("AttachmentSize", BUSAcceptAttachmentEntityFields.AttachmentSize);
			this.Fields.Add("AttachmentType", BUSAcceptAttachmentEntityFields.AttachmentType);
			this.Fields.Add("AttachmentPath", BUSAcceptAttachmentEntityFields.AttachmentPath);
			this.Fields.Add("AttachmentContent", BUSAcceptAttachmentEntityFields.AttachmentContent);
			this.Fields.Add("AttachmentRemark", BUSAcceptAttachmentEntityFields.AttachmentRemark);
			this.Fields.Add("CreateUserID", BUSAcceptAttachmentEntityFields.CreateUserID);
			this.Fields.Add("CreateDate", BUSAcceptAttachmentEntityFields.CreateDate);
		}
	}

	#region BUSAcceptAttachmentEntityFields

	public class BUSAcceptAttachmentEntityFields
	{
		public static EntityField AcceptAttachmentID
		{
			get { return new EntityField("BUS_AcceptAttachment", 0, "AcceptAttachmentID", SqlDbType.Int, true, true, true, false); }
		}

		public static EntityField AcceptID
		{
			get { return new EntityField("BUS_AcceptAttachment", 1, "AcceptID", SqlDbType.Int, false, false, false, false); }
		}

		public static EntityField ProductID
		{
			get { return new EntityField("BUS_AcceptAttachment", 2, "ProductID", SqlDbType.Int, false, false, false, false); }
		}

		public static EntityField BatchNo
		{
			get { return new EntityField("BUS_AcceptAttachment", 3, "BatchNo", SqlDbType.NVarChar, false, false, false, false); }
		}

		public static EntityField AttachmentName
		{
			get { return new EntityField("BUS_AcceptAttachment", 4, "AttachmentName", SqlDbType.NVarChar, false, false, false, false); }
		}

		public static EntityField AttachmentSize
		{
			get { return new EntityField("BUS_AcceptAttachment", 5, "AttachmentSize", SqlDbType.NVarChar, false, false, false, true); }
		}

		public static EntityField AttachmentType
		{
			get { return new EntityField("BUS_AcceptAttachment", 6, "AttachmentType", SqlDbType.NVarChar, false, false, false, true); }
		}

		public static EntityField AttachmentPath
		{
			get { return new EntityField("BUS_AcceptAttachment", 7, "AttachmentPath", SqlDbType.NVarChar, false, false, false, true); }
		}

		public static EntityField AttachmentContent
		{
			get { return new EntityField("BUS_AcceptAttachment", 8, "AttachmentContent", SqlDbType.VarBinary, false, false, false, true); }
		}

		public static EntityField AttachmentRemark
		{
			get { return new EntityField("BUS_AcceptAttachment", 9, "AttachmentRemark", SqlDbType.NVarChar, false, false, false, true); }
		}

		public static EntityField CreateUserID
		{
			get { return new EntityField("BUS_AcceptAttachment", 10, "CreateUserID", SqlDbType.UniqueIdentifier, false, false, false, true); }
		}

		public static EntityField CreateDate
		{
			get { return new EntityField("BUS_AcceptAttachment", 11, "CreateDate", SqlDbType.DateTime, false, false, false, true); }
		}

	}

	#endregion

	#region BUSAcceptAttachmentEntityFields2

	public enum BUSAcceptAttachmentEntityFields2
	{
		AcceptAttachmentID,

		AcceptID,

		ProductID,

		BatchNo,

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
