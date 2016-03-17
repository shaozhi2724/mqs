
using System;
using System.Collections.Generic;
using System.Data;
using ORMSCore;

namespace DQS.Module.Entities
{
    public class BFIEnterpriseAttachmentEntity:EntityBase
    {
		public int EnterpriseAttachmentID
		{
			get { return (int)this.GetValue("EnterpriseAttachmentID"); } 
			set { this.SetValue("EnterpriseAttachmentID", value); } 
		}

		public int EnterpriseID
		{
			get { return (int)this.GetValue("EnterpriseID"); } 
			set { this.SetValue("EnterpriseID", value); } 
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

        public BFIEnterpriseAttachmentEntity()
		{
			this.TableName = "BFI_EnterpriseAttachment";
			this.Fields = new Dictionary<string, EntityField>();
            this.Fields.Add("EnterpriseAttachmentID", BFIEnterpriseAttachmentEntityFields.EnterpriseAttachmentID);
            this.Fields.Add("EnterpriseID", BFIEnterpriseAttachmentEntityFields.EnterpriseID);
            this.Fields.Add("AttachmentName", BFIEnterpriseAttachmentEntityFields.AttachmentName);
            this.Fields.Add("AttachmentSize", BFIEnterpriseAttachmentEntityFields.AttachmentSize);
            this.Fields.Add("AttachmentType", BFIEnterpriseAttachmentEntityFields.AttachmentType);
            this.Fields.Add("AttachmentPath", BFIEnterpriseAttachmentEntityFields.AttachmentPath);
            this.Fields.Add("AttachmentContent", BFIEnterpriseAttachmentEntityFields.AttachmentContent);
            this.Fields.Add("AttachmentRemark", BFIEnterpriseAttachmentEntityFields.AttachmentRemark);
            this.Fields.Add("CreateUserID", BFIEnterpriseAttachmentEntityFields.CreateUserID);
            this.Fields.Add("CreateDate", BFIEnterpriseAttachmentEntityFields.CreateDate);
		}
	}

    #region BFIEnterpriseAttachmentEntityFields

    public class BFIEnterpriseAttachmentEntityFields
	{
        public static EntityField EnterpriseAttachmentID
		{
            get { return new EntityField("BFI_EnterpriseAttachment", 0, "EnterpriseAttachmentID", SqlDbType.Int, true, true, true, false); }
		}

        public static EntityField EnterpriseID
		{
            get { return new EntityField("BFI_EnterpriseAttachment", 1, "EnterpriseID", SqlDbType.Int, false, false, false, false); }
		}

		public static EntityField AttachmentName
		{
            get { return new EntityField("BFI_EnterpriseAttachment", 2, "AttachmentName", SqlDbType.NVarChar, false, false, false, false); }
		}

		public static EntityField AttachmentSize
		{
            get { return new EntityField("BFI_EnterpriseAttachment", 3, "AttachmentSize", SqlDbType.NVarChar, false, false, false, true); }
		}

		public static EntityField AttachmentType
		{
            get { return new EntityField("BFI_EnterpriseAttachment", 4, "AttachmentType", SqlDbType.NVarChar, false, false, false, true); }
		}

		public static EntityField AttachmentPath
		{
            get { return new EntityField("BFI_EnterpriseAttachment", 5, "AttachmentPath", SqlDbType.NVarChar, false, false, false, true); }
		}

		public static EntityField AttachmentContent
		{
            get { return new EntityField("BFI_EnterpriseAttachment", 6, "AttachmentContent", SqlDbType.VarBinary, false, false, false, true); }
		}

		public static EntityField AttachmentRemark
		{
            get { return new EntityField("BFI_EnterpriseAttachment", 7, "AttachmentRemark", SqlDbType.NVarChar, false, false, false, true); }
		}

		public static EntityField CreateUserID
		{
            get { return new EntityField("BFI_EnterpriseAttachment", 8, "CreateUserID", SqlDbType.UniqueIdentifier, false, false, false, true); }
		}

		public static EntityField CreateDate
		{
            get { return new EntityField("BFI_EnterpriseAttachment", 9, "CreateDate", SqlDbType.DateTime, false, false, false, true); }
		}

	}

	#endregion

    #region BFIEnterpriseAttachmentEntityFields2

    public enum BFIEnterpriseAttachmentEntityFields2
	{
        EnterpriseAttachmentID,

        EnterpriseID,

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
