/*
 *	Build By: Codey Object Relation Mapping
 *	Build Data: 2013-07-19 19:48:09
 *	Build Type: Entity
 *	Description: BFIQualificationAttachmentEntity
*/

using System;
using System.Collections.Generic;
using System.Data;
using ORMSCore;

namespace DQS.Module.Entities
{
	public class BFIQualificationAttachmentEntity : EntityBase
	{
		public int AttachmentID
		{
			get { return (int)this.GetValue("AttachmentID"); } 
			set { this.SetValue("AttachmentID", value); } 
		}

		public string AttachmentName
		{
			get { return (string)this.GetValue("AttachmentName"); } 
			set { this.SetValue("AttachmentName", value); } 
		}

		public int QualificationID
		{
			get { return (int)this.GetValue("QualificationID"); } 
			set { this.SetValue("QualificationID", value); } 
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

		public string AttachmentRemark
		{
			get { return (string)this.GetValue("AttachmentRemark"); } 
			set { this.SetValue("AttachmentRemark", value); } 
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

		public string Reservation1
		{
			get { return (string)this.GetValue("Reservation1"); } 
			set { this.SetValue("Reservation1", value); } 
		}

		public string Reservation2
		{
			get { return (string)this.GetValue("Reservation2"); } 
			set { this.SetValue("Reservation2", value); } 
		}

		public string Reservation3
		{
			get { return (string)this.GetValue("Reservation3"); } 
			set { this.SetValue("Reservation3", value); } 
		}

		public string Reservation4
		{
			get { return (string)this.GetValue("Reservation4"); } 
			set { this.SetValue("Reservation4", value); } 
		}

		public string Reservation5
		{
			get { return (string)this.GetValue("Reservation5"); } 
			set { this.SetValue("Reservation5", value); } 
		}

		public string Reservation6
		{
			get { return (string)this.GetValue("Reservation6"); } 
			set { this.SetValue("Reservation6", value); } 
		}

		public string Reservation7
		{
			get { return (string)this.GetValue("Reservation7"); } 
			set { this.SetValue("Reservation7", value); } 
		}

		public string Reservation8
		{
			get { return (string)this.GetValue("Reservation8"); } 
			set { this.SetValue("Reservation8", value); } 
		}

		public string Reservation9
		{
			get { return (string)this.GetValue("Reservation9"); } 
			set { this.SetValue("Reservation9", value); } 
		}

		public string Reservation10
		{
			get { return (string)this.GetValue("Reservation10"); } 
			set { this.SetValue("Reservation10", value); } 
		}

		public BFIQualificationAttachmentEntity()
		{
			this.TableName = "BFI_QualificationAttachment";
			this.Fields = new Dictionary<string, EntityField>();
			this.Fields.Add("AttachmentID", BFIQualificationAttachmentEntityFields.AttachmentID);
			this.Fields.Add("AttachmentName", BFIQualificationAttachmentEntityFields.AttachmentName);
			this.Fields.Add("QualificationID", BFIQualificationAttachmentEntityFields.QualificationID);
			this.Fields.Add("AttachmentSize", BFIQualificationAttachmentEntityFields.AttachmentSize);
			this.Fields.Add("AttachmentType", BFIQualificationAttachmentEntityFields.AttachmentType);
			this.Fields.Add("CreateUserID", BFIQualificationAttachmentEntityFields.CreateUserID);
			this.Fields.Add("CreateDate", BFIQualificationAttachmentEntityFields.CreateDate);
			this.Fields.Add("AttachmentRemark", BFIQualificationAttachmentEntityFields.AttachmentRemark);
			this.Fields.Add("AttachmentPath", BFIQualificationAttachmentEntityFields.AttachmentPath);
			this.Fields.Add("AttachmentContent", BFIQualificationAttachmentEntityFields.AttachmentContent);
			this.Fields.Add("Reservation1", BFIQualificationAttachmentEntityFields.Reservation1);
			this.Fields.Add("Reservation2", BFIQualificationAttachmentEntityFields.Reservation2);
			this.Fields.Add("Reservation3", BFIQualificationAttachmentEntityFields.Reservation3);
			this.Fields.Add("Reservation4", BFIQualificationAttachmentEntityFields.Reservation4);
			this.Fields.Add("Reservation5", BFIQualificationAttachmentEntityFields.Reservation5);
			this.Fields.Add("Reservation6", BFIQualificationAttachmentEntityFields.Reservation6);
			this.Fields.Add("Reservation7", BFIQualificationAttachmentEntityFields.Reservation7);
			this.Fields.Add("Reservation8", BFIQualificationAttachmentEntityFields.Reservation8);
			this.Fields.Add("Reservation9", BFIQualificationAttachmentEntityFields.Reservation9);
			this.Fields.Add("Reservation10", BFIQualificationAttachmentEntityFields.Reservation10);
		}
	}

	#region BFIQualificationAttachmentEntityFields

	public class BFIQualificationAttachmentEntityFields
	{
		public static EntityField AttachmentID
		{
			get { return new EntityField("BFI_QualificationAttachment", 0, "AttachmentID", SqlDbType.Int, true, true, true, false); }
		}

		public static EntityField AttachmentName
		{
			get { return new EntityField("BFI_QualificationAttachment", 1, "AttachmentName", SqlDbType.NVarChar, false, false, false, false); }
		}

		public static EntityField QualificationID
		{
			get { return new EntityField("BFI_QualificationAttachment", 2, "QualificationID", SqlDbType.Int, false, false, false, false); }
		}

		public static EntityField AttachmentSize
		{
			get { return new EntityField("BFI_QualificationAttachment", 3, "AttachmentSize", SqlDbType.NVarChar, false, false, false, true); }
		}

		public static EntityField AttachmentType
		{
			get { return new EntityField("BFI_QualificationAttachment", 4, "AttachmentType", SqlDbType.NVarChar, false, false, false, true); }
		}

		public static EntityField CreateUserID
		{
			get { return new EntityField("BFI_QualificationAttachment", 5, "CreateUserID", SqlDbType.UniqueIdentifier, false, false, false, true); }
		}

		public static EntityField CreateDate
		{
			get { return new EntityField("BFI_QualificationAttachment", 6, "CreateDate", SqlDbType.DateTime, false, false, false, true); }
		}

		public static EntityField AttachmentRemark
		{
			get { return new EntityField("BFI_QualificationAttachment", 7, "AttachmentRemark", SqlDbType.NVarChar, false, false, false, true); }
		}

		public static EntityField AttachmentPath
		{
			get { return new EntityField("BFI_QualificationAttachment", 8, "AttachmentPath", SqlDbType.NVarChar, false, false, false, true); }
		}

		public static EntityField AttachmentContent
		{
			get { return new EntityField("BFI_QualificationAttachment", 9, "AttachmentContent", SqlDbType.VarBinary, false, false, false, true); }
		}

		public static EntityField Reservation1
		{
			get { return new EntityField("BFI_QualificationAttachment", 10, "Reservation1", SqlDbType.NVarChar, false, false, false, true); }
		}

		public static EntityField Reservation2
		{
			get { return new EntityField("BFI_QualificationAttachment", 11, "Reservation2", SqlDbType.NVarChar, false, false, false, true); }
		}

		public static EntityField Reservation3
		{
			get { return new EntityField("BFI_QualificationAttachment", 12, "Reservation3", SqlDbType.NVarChar, false, false, false, true); }
		}

		public static EntityField Reservation4
		{
			get { return new EntityField("BFI_QualificationAttachment", 13, "Reservation4", SqlDbType.NVarChar, false, false, false, true); }
		}

		public static EntityField Reservation5
		{
			get { return new EntityField("BFI_QualificationAttachment", 14, "Reservation5", SqlDbType.NVarChar, false, false, false, true); }
		}

		public static EntityField Reservation6
		{
			get { return new EntityField("BFI_QualificationAttachment", 15, "Reservation6", SqlDbType.NVarChar, false, false, false, true); }
		}

		public static EntityField Reservation7
		{
			get { return new EntityField("BFI_QualificationAttachment", 16, "Reservation7", SqlDbType.NVarChar, false, false, false, true); }
		}

		public static EntityField Reservation8
		{
			get { return new EntityField("BFI_QualificationAttachment", 17, "Reservation8", SqlDbType.NVarChar, false, false, false, true); }
		}

		public static EntityField Reservation9
		{
			get { return new EntityField("BFI_QualificationAttachment", 18, "Reservation9", SqlDbType.NVarChar, false, false, false, true); }
		}

		public static EntityField Reservation10
		{
			get { return new EntityField("BFI_QualificationAttachment", 19, "Reservation10", SqlDbType.NVarChar, false, false, false, true); }
		}

	}

	#endregion

	#region BFIQualificationAttachmentEntityFields2

	public enum BFIQualificationAttachmentEntityFields2
	{
		AttachmentID,

		AttachmentName,

		QualificationID,

		AttachmentSize,

		AttachmentType,

		CreateUserID,

		CreateDate,

		AttachmentRemark,

		AttachmentPath,

		AttachmentContent,

		Reservation1,

		Reservation2,

		Reservation3,

		Reservation4,

		Reservation5,

		Reservation6,

		Reservation7,

		Reservation8,

		Reservation9,

		Reservation10,

	}

	#endregion

}
