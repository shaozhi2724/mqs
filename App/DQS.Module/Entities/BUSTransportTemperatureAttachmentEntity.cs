/*
 *	Build By: Codey Object Relation Mapping
 *	Build Data: 2014-05-08 14:39:02
 *	Build Type: Entity
 *	Description: BUSTransportTemperatureAttachmentEntity
*/

using System;
using System.Collections.Generic;
using System.Data;
using ORMSCore;

namespace DQS.Module.Entities
{
	public class BUSTransportTemperatureAttachmentEntity : EntityBase
	{
		public int TransportTemperatureAttachmentID
		{
			get { return (int)this.GetValue("TransportTemperatureAttachmentID"); } 
			set { this.SetValue("TransportTemperatureAttachmentID", value); } 
		}

		public int TransportID
		{
			get { return (int)this.GetValue("TransportID"); } 
			set { this.SetValue("TransportID", value); } 
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

		public BUSTransportTemperatureAttachmentEntity()
		{
			this.TableName = "BUS_TransportTemperatureAttachment";
			this.Fields = new Dictionary<string, EntityField>();
			this.Fields.Add("TransportTemperatureAttachmentID", BUSTransportTemperatureAttachmentEntityFields.TransportTemperatureAttachmentID);
			this.Fields.Add("TransportID", BUSTransportTemperatureAttachmentEntityFields.TransportID);
			this.Fields.Add("AttachmentName", BUSTransportTemperatureAttachmentEntityFields.AttachmentName);
			this.Fields.Add("AttachmentSize", BUSTransportTemperatureAttachmentEntityFields.AttachmentSize);
			this.Fields.Add("AttachmentType", BUSTransportTemperatureAttachmentEntityFields.AttachmentType);
			this.Fields.Add("AttachmentPath", BUSTransportTemperatureAttachmentEntityFields.AttachmentPath);
			this.Fields.Add("AttachmentContent", BUSTransportTemperatureAttachmentEntityFields.AttachmentContent);
			this.Fields.Add("AttachmentRemark", BUSTransportTemperatureAttachmentEntityFields.AttachmentRemark);
			this.Fields.Add("CreateUserID", BUSTransportTemperatureAttachmentEntityFields.CreateUserID);
			this.Fields.Add("CreateDate", BUSTransportTemperatureAttachmentEntityFields.CreateDate);
		}
	}

	#region BUSTransportTemperatureAttachmentEntityFields

	public class BUSTransportTemperatureAttachmentEntityFields
	{
		public static EntityField TransportTemperatureAttachmentID
		{
			get { return new EntityField("BUS_TransportTemperatureAttachment", 0, "TransportTemperatureAttachmentID", SqlDbType.Int, true, true, true, false); }
		}

		public static EntityField TransportID
		{
			get { return new EntityField("BUS_TransportTemperatureAttachment", 1, "TransportID", SqlDbType.Int, false, false, false, false); }
		}

		public static EntityField AttachmentName
		{
			get { return new EntityField("BUS_TransportTemperatureAttachment", 2, "AttachmentName", SqlDbType.NVarChar, false, false, false, false); }
		}

		public static EntityField AttachmentSize
		{
			get { return new EntityField("BUS_TransportTemperatureAttachment", 3, "AttachmentSize", SqlDbType.NVarChar, false, false, false, true); }
		}

		public static EntityField AttachmentType
		{
			get { return new EntityField("BUS_TransportTemperatureAttachment", 4, "AttachmentType", SqlDbType.NVarChar, false, false, false, true); }
		}

		public static EntityField AttachmentPath
		{
			get { return new EntityField("BUS_TransportTemperatureAttachment", 5, "AttachmentPath", SqlDbType.NVarChar, false, false, false, true); }
		}

		public static EntityField AttachmentContent
		{
			get { return new EntityField("BUS_TransportTemperatureAttachment", 6, "AttachmentContent", SqlDbType.VarBinary, false, false, false, true); }
		}

		public static EntityField AttachmentRemark
		{
			get { return new EntityField("BUS_TransportTemperatureAttachment", 7, "AttachmentRemark", SqlDbType.NVarChar, false, false, false, true); }
		}

		public static EntityField CreateUserID
		{
			get { return new EntityField("BUS_TransportTemperatureAttachment", 8, "CreateUserID", SqlDbType.UniqueIdentifier, false, false, false, true); }
		}

		public static EntityField CreateDate
		{
			get { return new EntityField("BUS_TransportTemperatureAttachment", 9, "CreateDate", SqlDbType.DateTime, false, false, false, true); }
		}

	}

	#endregion

	#region BUSTransportTemperatureAttachmentEntityFields2

	public enum BUSTransportTemperatureAttachmentEntityFields2
	{
		TransportTemperatureAttachmentID,

		TransportID,

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
