/*
 *	Build By: Codey Object Relation Mapping
 *	Build Data: 2013-07-19 19:48:09
 *	Build Type: Entity
 *	Description: ATCConstitutionEntity
*/

using System;
using System.Collections.Generic;
using System.Data;
using ORMSCore;

namespace DQS.Module.Entities
{
	public class ATCConstitutionEntity : EntityBase
	{
		public int ConstitutionID
		{
			get { return (int)this.GetValue("ConstitutionID"); } 
			set { this.SetValue("ConstitutionID", value); } 
		}

		public string ConstitutionCode
		{
			get { return (string)this.GetValue("ConstitutionCode"); } 
			set { this.SetValue("ConstitutionCode", value); } 
		}

		public string ConstitutionTitle
		{
			get { return (string)this.GetValue("ConstitutionTitle"); } 
			set { this.SetValue("ConstitutionTitle", value); } 
		}

		public string PageCode
		{
			get { return (string)this.GetValue("PageCode"); } 
			set { this.SetValue("PageCode", value); } 
		}

		public string ConstitutionContent
		{
			get { return (string)this.GetValue("ConstitutionContent"); } 
			set { this.SetValue("ConstitutionContent", value); } 
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

		public string ConstitutionRemark
		{
			get { return (string)this.GetValue("ConstitutionRemark"); } 
			set { this.SetValue("ConstitutionRemark", value); } 
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

		public ATCConstitutionEntity()
		{
			this.TableName = "ATC_Constitution";
			this.Fields = new Dictionary<string, EntityField>();
			this.Fields.Add("ConstitutionID", ATCConstitutionEntityFields.ConstitutionID);
			this.Fields.Add("ConstitutionCode", ATCConstitutionEntityFields.ConstitutionCode);
			this.Fields.Add("ConstitutionTitle", ATCConstitutionEntityFields.ConstitutionTitle);
			this.Fields.Add("PageCode", ATCConstitutionEntityFields.PageCode);
			this.Fields.Add("ConstitutionContent", ATCConstitutionEntityFields.ConstitutionContent);
			this.Fields.Add("CreateUserID", ATCConstitutionEntityFields.CreateUserID);
			this.Fields.Add("CreateDate", ATCConstitutionEntityFields.CreateDate);
			this.Fields.Add("LastModifyUserID", ATCConstitutionEntityFields.LastModifyUserID);
			this.Fields.Add("LastModifyDate", ATCConstitutionEntityFields.LastModifyDate);
			this.Fields.Add("ConstitutionRemark", ATCConstitutionEntityFields.ConstitutionRemark);
			this.Fields.Add("Reservation1", ATCConstitutionEntityFields.Reservation1);
			this.Fields.Add("Reservation2", ATCConstitutionEntityFields.Reservation2);
			this.Fields.Add("Reservation3", ATCConstitutionEntityFields.Reservation3);
			this.Fields.Add("Reservation4", ATCConstitutionEntityFields.Reservation4);
			this.Fields.Add("Reservation5", ATCConstitutionEntityFields.Reservation5);
		}
	}

	#region ATCConstitutionEntityFields

	public class ATCConstitutionEntityFields
	{
		public static EntityField ConstitutionID
		{
			get { return new EntityField("ATC_Constitution", 0, "ConstitutionID", SqlDbType.Int, true, true, true, false); }
		}

		public static EntityField ConstitutionCode
		{
			get { return new EntityField("ATC_Constitution", 1, "ConstitutionCode", SqlDbType.NVarChar, false, false, true, false); }
		}

		public static EntityField ConstitutionTitle
		{
			get { return new EntityField("ATC_Constitution", 2, "ConstitutionTitle", SqlDbType.NVarChar, false, false, false, false); }
		}

		public static EntityField PageCode
		{
			get { return new EntityField("ATC_Constitution", 3, "PageCode", SqlDbType.NVarChar, false, false, false, false); }
		}

		public static EntityField ConstitutionContent
		{
			get { return new EntityField("ATC_Constitution", 4, "ConstitutionContent", SqlDbType.Text, false, false, false, false); }
		}

		public static EntityField CreateUserID
		{
			get { return new EntityField("ATC_Constitution", 5, "CreateUserID", SqlDbType.UniqueIdentifier, false, false, false, true); }
		}

		public static EntityField CreateDate
		{
			get { return new EntityField("ATC_Constitution", 6, "CreateDate", SqlDbType.DateTime, false, false, false, true); }
		}

		public static EntityField LastModifyUserID
		{
			get { return new EntityField("ATC_Constitution", 7, "LastModifyUserID", SqlDbType.UniqueIdentifier, false, false, false, true); }
		}

		public static EntityField LastModifyDate
		{
			get { return new EntityField("ATC_Constitution", 8, "LastModifyDate", SqlDbType.DateTime, false, false, false, true); }
		}

		public static EntityField ConstitutionRemark
		{
			get { return new EntityField("ATC_Constitution", 9, "ConstitutionRemark", SqlDbType.NVarChar, false, false, false, true); }
		}

		public static EntityField Reservation1
		{
			get { return new EntityField("ATC_Constitution", 10, "Reservation1", SqlDbType.NVarChar, false, false, false, true); }
		}

		public static EntityField Reservation2
		{
			get { return new EntityField("ATC_Constitution", 11, "Reservation2", SqlDbType.NVarChar, false, false, false, true); }
		}

		public static EntityField Reservation3
		{
			get { return new EntityField("ATC_Constitution", 12, "Reservation3", SqlDbType.NVarChar, false, false, false, true); }
		}

		public static EntityField Reservation4
		{
			get { return new EntityField("ATC_Constitution", 13, "Reservation4", SqlDbType.NVarChar, false, false, false, true); }
		}

		public static EntityField Reservation5
		{
			get { return new EntityField("ATC_Constitution", 14, "Reservation5", SqlDbType.NVarChar, false, false, false, true); }
		}

	}

	#endregion

	#region ATCConstitutionEntityFields2

	public enum ATCConstitutionEntityFields2
	{
		ConstitutionID,

		ConstitutionCode,

		ConstitutionTitle,

		PageCode,

		ConstitutionContent,

		CreateUserID,

		CreateDate,

		LastModifyUserID,

		LastModifyDate,

		ConstitutionRemark,

		Reservation1,

		Reservation2,

		Reservation3,

		Reservation4,

		Reservation5,

	}

	#endregion

}
