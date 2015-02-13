/*
 *	Build By: Codey Object Relation Mapping
 *	Build Data: 2014-01-23 20:54:11
 *	Build Type: Entity
 *	Description: BFIQualificationAttributeEntity
*/

using System;
using System.Collections.Generic;
using System.Data;
using ORMSCore;

namespace DQS.Module.Entities
{
	public class BFIQualificationAttributeEntity : EntityBase
	{
		public int AttributeID
		{
			get { return (int)this.GetValue("AttributeID"); } 
			set { this.SetValue("AttributeID", value); } 
		}

		public string AttributeName
		{
			get { return (string)this.GetValue("AttributeName"); } 
			set { this.SetValue("AttributeName", value); } 
		}

		public string AttributeValue
		{
			get { return (string)this.GetValue("AttributeValue"); } 
			set { this.SetValue("AttributeValue", value); } 
		}

		public int QualificationID
		{
			get { return (int)this.GetValue("QualificationID"); } 
			set { this.SetValue("QualificationID", value); } 
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

		public Guid LastModifyUserID
		{
			get { return (Guid)this.GetValue("LastModifyUserID"); } 
			set { this.SetValue("LastModifyUserID", value); } 
		}

		public DateTime LastModifyDate
		{
			get { return (DateTime)this.GetValue("LastModifyDate"); } 
			set { this.SetValue("LastModifyDate", value); } 
		}

		public string AttributeRemark
		{
			get { return (string)this.GetValue("AttributeRemark"); } 
			set { this.SetValue("AttributeRemark", value); } 
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

		public BFIQualificationAttributeEntity()
		{
			this.TableName = "BFI_QualificationAttribute";
			this.Fields = new Dictionary<string, EntityField>();
			this.Fields.Add("AttributeID", BFIQualificationAttributeEntityFields.AttributeID);
			this.Fields.Add("AttributeName", BFIQualificationAttributeEntityFields.AttributeName);
			this.Fields.Add("AttributeValue", BFIQualificationAttributeEntityFields.AttributeValue);
			this.Fields.Add("QualificationID", BFIQualificationAttributeEntityFields.QualificationID);
			this.Fields.Add("CreateUserID", BFIQualificationAttributeEntityFields.CreateUserID);
			this.Fields.Add("CreateDate", BFIQualificationAttributeEntityFields.CreateDate);
			this.Fields.Add("LastModifyUserID", BFIQualificationAttributeEntityFields.LastModifyUserID);
			this.Fields.Add("LastModifyDate", BFIQualificationAttributeEntityFields.LastModifyDate);
			this.Fields.Add("AttributeRemark", BFIQualificationAttributeEntityFields.AttributeRemark);
			this.Fields.Add("Reservation1", BFIQualificationAttributeEntityFields.Reservation1);
			this.Fields.Add("Reservation2", BFIQualificationAttributeEntityFields.Reservation2);
			this.Fields.Add("Reservation3", BFIQualificationAttributeEntityFields.Reservation3);
			this.Fields.Add("Reservation4", BFIQualificationAttributeEntityFields.Reservation4);
			this.Fields.Add("Reservation5", BFIQualificationAttributeEntityFields.Reservation5);
			this.Fields.Add("Reservation6", BFIQualificationAttributeEntityFields.Reservation6);
			this.Fields.Add("Reservation7", BFIQualificationAttributeEntityFields.Reservation7);
			this.Fields.Add("Reservation8", BFIQualificationAttributeEntityFields.Reservation8);
			this.Fields.Add("Reservation9", BFIQualificationAttributeEntityFields.Reservation9);
			this.Fields.Add("Reservation10", BFIQualificationAttributeEntityFields.Reservation10);
		}
	}

	#region BFIQualificationAttributeEntityFields

	public class BFIQualificationAttributeEntityFields
	{
		public static EntityField AttributeID
		{
			get { return new EntityField("BFI_QualificationAttribute", 0, "AttributeID", SqlDbType.Int, true, true, true, false); }
		}

		public static EntityField AttributeName
		{
			get { return new EntityField("BFI_QualificationAttribute", 1, "AttributeName", SqlDbType.NVarChar, false, false, false, false); }
		}

		public static EntityField AttributeValue
		{
			get { return new EntityField("BFI_QualificationAttribute", 2, "AttributeValue", SqlDbType.NVarChar, false, false, false, false); }
		}

		public static EntityField QualificationID
		{
			get { return new EntityField("BFI_QualificationAttribute", 3, "QualificationID", SqlDbType.Int, false, false, false, false); }
		}

		public static EntityField CreateUserID
		{
			get { return new EntityField("BFI_QualificationAttribute", 4, "CreateUserID", SqlDbType.UniqueIdentifier, false, false, false, true); }
		}

		public static EntityField CreateDate
		{
			get { return new EntityField("BFI_QualificationAttribute", 5, "CreateDate", SqlDbType.DateTime, false, false, false, true); }
		}

		public static EntityField LastModifyUserID
		{
			get { return new EntityField("BFI_QualificationAttribute", 6, "LastModifyUserID", SqlDbType.UniqueIdentifier, false, false, false, true); }
		}

		public static EntityField LastModifyDate
		{
			get { return new EntityField("BFI_QualificationAttribute", 7, "LastModifyDate", SqlDbType.DateTime, false, false, false, true); }
		}

		public static EntityField AttributeRemark
		{
			get { return new EntityField("BFI_QualificationAttribute", 8, "AttributeRemark", SqlDbType.NVarChar, false, false, false, true); }
		}

		public static EntityField Reservation1
		{
			get { return new EntityField("BFI_QualificationAttribute", 9, "Reservation1", SqlDbType.NVarChar, false, false, false, true); }
		}

		public static EntityField Reservation2
		{
			get { return new EntityField("BFI_QualificationAttribute", 10, "Reservation2", SqlDbType.NVarChar, false, false, false, true); }
		}

		public static EntityField Reservation3
		{
			get { return new EntityField("BFI_QualificationAttribute", 11, "Reservation3", SqlDbType.NVarChar, false, false, false, true); }
		}

		public static EntityField Reservation4
		{
			get { return new EntityField("BFI_QualificationAttribute", 12, "Reservation4", SqlDbType.NVarChar, false, false, false, true); }
		}

		public static EntityField Reservation5
		{
			get { return new EntityField("BFI_QualificationAttribute", 13, "Reservation5", SqlDbType.NVarChar, false, false, false, true); }
		}

		public static EntityField Reservation6
		{
			get { return new EntityField("BFI_QualificationAttribute", 14, "Reservation6", SqlDbType.NVarChar, false, false, false, true); }
		}

		public static EntityField Reservation7
		{
			get { return new EntityField("BFI_QualificationAttribute", 15, "Reservation7", SqlDbType.NVarChar, false, false, false, true); }
		}

		public static EntityField Reservation8
		{
			get { return new EntityField("BFI_QualificationAttribute", 16, "Reservation8", SqlDbType.NVarChar, false, false, false, true); }
		}

		public static EntityField Reservation9
		{
			get { return new EntityField("BFI_QualificationAttribute", 17, "Reservation9", SqlDbType.NVarChar, false, false, false, true); }
		}

		public static EntityField Reservation10
		{
			get { return new EntityField("BFI_QualificationAttribute", 18, "Reservation10", SqlDbType.NVarChar, false, false, false, true); }
		}

	}

	#endregion

	#region BFIQualificationAttributeEntityFields2

	public enum BFIQualificationAttributeEntityFields2
	{
		AttributeID,

		AttributeName,

		AttributeValue,

		QualificationID,

		CreateUserID,

		CreateDate,

		LastModifyUserID,

		LastModifyDate,

		AttributeRemark,

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
