/*
 *	Build By: Codey Object Relation Mapping
 *	Build Data: 2013-07-31 11:25:37
 *	Build Type: Entity
 *	Description: SYSDocumentEntity
*/

using System;
using System.Collections.Generic;
using System.Data;
using ORMSCore;

namespace DQS.Module.Entities
{
	public class SYSDocumentEntity : EntityBase
	{
		public string DocumentCode
		{
			get { return (string)this.GetValue("DocumentCode"); } 
			set { this.SetValue("DocumentCode", value); } 
		}

		public string DocumentName
		{
			get { return (string)this.GetValue("DocumentName"); } 
			set { this.SetValue("DocumentName", value); } 
		}

		public bool IsNeedApproval
		{
			get { return (bool)this.GetValue("IsNeedApproval"); } 
			set { this.SetValue("IsNeedApproval", value); } 
		}

		public int SortNumber
		{
			get { return (int)this.GetValue("SortNumber"); } 
			set { this.SetValue("SortNumber", value); } 
		}

		public string DbTableName
		{
			get { return (string)this.GetValue("DbTableName"); } 
			set { this.SetValue("DbTableName", value); } 
		}

		public string CodeFieldName
		{
			get { return (string)this.GetValue("CodeFieldName"); } 
			set { this.SetValue("CodeFieldName", value); } 
		}

		public string DocumentDescription
		{
			get { return (string)this.GetValue("DocumentDescription"); } 
			set { this.SetValue("DocumentDescription", value); } 
		}

		public string DocumentRemark
		{
			get { return (string)this.GetValue("DocumentRemark"); } 
			set { this.SetValue("DocumentRemark", value); } 
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

		public SYSDocumentEntity()
		{
			this.TableName = "SYS_Document";
			this.Fields = new Dictionary<string, EntityField>();
			this.Fields.Add("DocumentCode", SYSDocumentEntityFields.DocumentCode);
			this.Fields.Add("DocumentName", SYSDocumentEntityFields.DocumentName);
			this.Fields.Add("IsNeedApproval", SYSDocumentEntityFields.IsNeedApproval);
			this.Fields.Add("SortNumber", SYSDocumentEntityFields.SortNumber);
			this.Fields.Add("DbTableName", SYSDocumentEntityFields.DbTableName);
			this.Fields.Add("CodeFieldName", SYSDocumentEntityFields.CodeFieldName);
			this.Fields.Add("DocumentDescription", SYSDocumentEntityFields.DocumentDescription);
			this.Fields.Add("DocumentRemark", SYSDocumentEntityFields.DocumentRemark);
			this.Fields.Add("Reservation1", SYSDocumentEntityFields.Reservation1);
			this.Fields.Add("Reservation2", SYSDocumentEntityFields.Reservation2);
			this.Fields.Add("Reservation3", SYSDocumentEntityFields.Reservation3);
			this.Fields.Add("Reservation4", SYSDocumentEntityFields.Reservation4);
			this.Fields.Add("Reservation5", SYSDocumentEntityFields.Reservation5);
		}
	}

	#region SYSDocumentEntityFields

	public class SYSDocumentEntityFields
	{
		public static EntityField DocumentCode
		{
			get { return new EntityField("SYS_Document", 0, "DocumentCode", SqlDbType.NVarChar, true, false, true, false); }
		}

		public static EntityField DocumentName
		{
			get { return new EntityField("SYS_Document", 1, "DocumentName", SqlDbType.NVarChar, false, false, false, false); }
		}

		public static EntityField IsNeedApproval
		{
			get { return new EntityField("SYS_Document", 2, "IsNeedApproval", SqlDbType.Bit, false, false, false, false); }
		}

		public static EntityField SortNumber
		{
			get { return new EntityField("SYS_Document", 3, "SortNumber", SqlDbType.Int, false, false, false, true); }
		}

		public static EntityField DbTableName
		{
			get { return new EntityField("SYS_Document", 4, "DbTableName", SqlDbType.NVarChar, false, false, false, true); }
		}

		public static EntityField CodeFieldName
		{
			get { return new EntityField("SYS_Document", 5, "CodeFieldName", SqlDbType.NVarChar, false, false, false, true); }
		}

		public static EntityField DocumentDescription
		{
			get { return new EntityField("SYS_Document", 6, "DocumentDescription", SqlDbType.NVarChar, false, false, false, true); }
		}

		public static EntityField DocumentRemark
		{
			get { return new EntityField("SYS_Document", 7, "DocumentRemark", SqlDbType.NVarChar, false, false, false, true); }
		}

		public static EntityField Reservation1
		{
			get { return new EntityField("SYS_Document", 8, "Reservation1", SqlDbType.NVarChar, false, false, false, true); }
		}

		public static EntityField Reservation2
		{
			get { return new EntityField("SYS_Document", 9, "Reservation2", SqlDbType.NVarChar, false, false, false, true); }
		}

		public static EntityField Reservation3
		{
			get { return new EntityField("SYS_Document", 10, "Reservation3", SqlDbType.NVarChar, false, false, false, true); }
		}

		public static EntityField Reservation4
		{
			get { return new EntityField("SYS_Document", 11, "Reservation4", SqlDbType.NVarChar, false, false, false, true); }
		}

		public static EntityField Reservation5
		{
			get { return new EntityField("SYS_Document", 12, "Reservation5", SqlDbType.NVarChar, false, false, false, true); }
		}

	}

	#endregion

	#region SYSDocumentEntityFields2

	public enum SYSDocumentEntityFields2
	{
		DocumentCode,

		DocumentName,

		IsNeedApproval,

		SortNumber,

		DbTableName,

		CodeFieldName,

		DocumentDescription,

		DocumentRemark,

		Reservation1,

		Reservation2,

		Reservation3,

		Reservation4,

		Reservation5,

	}

	#endregion

}
