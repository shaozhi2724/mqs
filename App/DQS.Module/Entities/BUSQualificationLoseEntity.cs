/*
 *	Build By: Codey Object Relation Mapping
 *	Build Data: 2013-07-19 19:48:09
 *	Build Type: Entity
 *	Description: BUSQualificationLoseEntity
*/

using System;
using System.Collections.Generic;
using System.Data;
using ORMSCore;

namespace DQS.Module.Entities
{
	public class BUSQualificationLoseEntity : EntityBase
	{
		public int LoseID
		{
			get { return (int)this.GetValue("LoseID"); } 
			set { this.SetValue("LoseID", value); } 
		}

		public string LoseType
		{
			get { return (string)this.GetValue("LoseType"); } 
			set { this.SetValue("LoseType", value); } 
		}

		public string LoseName
		{
			get { return (string)this.GetValue("LoseName"); } 
			set { this.SetValue("LoseName", value); } 
		}

		public string LoseSpell
		{
			get { return (string)this.GetValue("LoseSpell"); } 
			set { this.SetValue("LoseSpell", value); } 
		}

		public string QualificationCode
		{
			get { return (string)this.GetValue("QualificationCode"); } 
			set { this.SetValue("QualificationCode", value); } 
		}

		public string QualificationName
		{
			get { return (string)this.GetValue("QualificationName"); } 
			set { this.SetValue("QualificationName", value); } 
		}

		public string QualificationSpell
		{
			get { return (string)this.GetValue("QualificationSpell"); } 
			set { this.SetValue("QualificationSpell", value); } 
		}

		public string CertificateStyle
		{
			get { return (string)this.GetValue("CertificateStyle"); } 
			set { this.SetValue("CertificateStyle", value); } 
		}

		public string CertificateSpell
		{
			get { return (string)this.GetValue("CertificateSpell"); } 
			set { this.SetValue("CertificateSpell", value); } 
		}

		public string CertificateNo
		{
			get { return (string)this.GetValue("CertificateNo"); } 
			set { this.SetValue("CertificateNo", value); } 
		}

		public string LoseStatus
		{
			get { return (string)this.GetValue("LoseStatus"); } 
			set { this.SetValue("LoseStatus", value); } 
		}

		public string LoseDate
		{
			get { return (string)this.GetValue("LoseDate"); } 
			set { this.SetValue("LoseDate", value); } 
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

		public string LoseRemrk
		{
			get { return (string)this.GetValue("LoseRemrk"); } 
			set { this.SetValue("LoseRemrk", value); } 
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

		public BUSQualificationLoseEntity()
		{
			this.TableName = "BUS_QualificationLose";
			this.Fields = new Dictionary<string, EntityField>();
			this.Fields.Add("LoseID", BUSQualificationLoseEntityFields.LoseID);
			this.Fields.Add("LoseType", BUSQualificationLoseEntityFields.LoseType);
			this.Fields.Add("LoseName", BUSQualificationLoseEntityFields.LoseName);
			this.Fields.Add("LoseSpell", BUSQualificationLoseEntityFields.LoseSpell);
			this.Fields.Add("QualificationCode", BUSQualificationLoseEntityFields.QualificationCode);
			this.Fields.Add("QualificationName", BUSQualificationLoseEntityFields.QualificationName);
			this.Fields.Add("QualificationSpell", BUSQualificationLoseEntityFields.QualificationSpell);
			this.Fields.Add("CertificateStyle", BUSQualificationLoseEntityFields.CertificateStyle);
			this.Fields.Add("CertificateSpell", BUSQualificationLoseEntityFields.CertificateSpell);
			this.Fields.Add("CertificateNo", BUSQualificationLoseEntityFields.CertificateNo);
			this.Fields.Add("LoseStatus", BUSQualificationLoseEntityFields.LoseStatus);
			this.Fields.Add("LoseDate", BUSQualificationLoseEntityFields.LoseDate);
			this.Fields.Add("CreateUserID", BUSQualificationLoseEntityFields.CreateUserID);
			this.Fields.Add("CreateDate", BUSQualificationLoseEntityFields.CreateDate);
			this.Fields.Add("LastModifyUserID", BUSQualificationLoseEntityFields.LastModifyUserID);
			this.Fields.Add("LastModifyDate", BUSQualificationLoseEntityFields.LastModifyDate);
			this.Fields.Add("LoseRemrk", BUSQualificationLoseEntityFields.LoseRemrk);
			this.Fields.Add("Reservation1", BUSQualificationLoseEntityFields.Reservation1);
			this.Fields.Add("Reservation2", BUSQualificationLoseEntityFields.Reservation2);
			this.Fields.Add("Reservation3", BUSQualificationLoseEntityFields.Reservation3);
			this.Fields.Add("Reservation4", BUSQualificationLoseEntityFields.Reservation4);
			this.Fields.Add("Reservation5", BUSQualificationLoseEntityFields.Reservation5);
			this.Fields.Add("Reservation6", BUSQualificationLoseEntityFields.Reservation6);
			this.Fields.Add("Reservation7", BUSQualificationLoseEntityFields.Reservation7);
			this.Fields.Add("Reservation8", BUSQualificationLoseEntityFields.Reservation8);
			this.Fields.Add("Reservation9", BUSQualificationLoseEntityFields.Reservation9);
			this.Fields.Add("Reservation10", BUSQualificationLoseEntityFields.Reservation10);
		}
	}

	#region BUSQualificationLoseEntityFields

	public class BUSQualificationLoseEntityFields
	{
		public static EntityField LoseID
		{
			get { return new EntityField("BUS_QualificationLose", 0, "LoseID", SqlDbType.Int, true, false, true, false); }
		}

		public static EntityField LoseType
		{
			get { return new EntityField("BUS_QualificationLose", 1, "LoseType", SqlDbType.NVarChar, false, false, false, false); }
		}

		public static EntityField LoseName
		{
			get { return new EntityField("BUS_QualificationLose", 2, "LoseName", SqlDbType.NVarChar, false, false, false, false); }
		}

		public static EntityField LoseSpell
		{
			get { return new EntityField("BUS_QualificationLose", 3, "LoseSpell", SqlDbType.NVarChar, false, false, false, true); }
		}

		public static EntityField QualificationCode
		{
			get { return new EntityField("BUS_QualificationLose", 4, "QualificationCode", SqlDbType.NVarChar, false, false, false, true); }
		}

		public static EntityField QualificationName
		{
			get { return new EntityField("BUS_QualificationLose", 5, "QualificationName", SqlDbType.NVarChar, false, false, false, true); }
		}

		public static EntityField QualificationSpell
		{
			get { return new EntityField("BUS_QualificationLose", 6, "QualificationSpell", SqlDbType.NVarChar, false, false, false, true); }
		}

		public static EntityField CertificateStyle
		{
			get { return new EntityField("BUS_QualificationLose", 7, "CertificateStyle", SqlDbType.NVarChar, false, false, false, true); }
		}

		public static EntityField CertificateSpell
		{
			get { return new EntityField("BUS_QualificationLose", 8, "CertificateSpell", SqlDbType.NVarChar, false, false, false, true); }
		}

		public static EntityField CertificateNo
		{
			get { return new EntityField("BUS_QualificationLose", 9, "CertificateNo", SqlDbType.NVarChar, false, false, false, true); }
		}

		public static EntityField LoseStatus
		{
			get { return new EntityField("BUS_QualificationLose", 10, "LoseStatus", SqlDbType.NVarChar, false, false, false, true); }
		}

		public static EntityField LoseDate
		{
			get { return new EntityField("BUS_QualificationLose", 11, "LoseDate", SqlDbType.NVarChar, false, false, false, true); }
		}

		public static EntityField CreateUserID
		{
			get { return new EntityField("BUS_QualificationLose", 12, "CreateUserID", SqlDbType.UniqueIdentifier, false, false, false, true); }
		}

		public static EntityField CreateDate
		{
			get { return new EntityField("BUS_QualificationLose", 13, "CreateDate", SqlDbType.DateTime, false, false, false, true); }
		}

		public static EntityField LastModifyUserID
		{
			get { return new EntityField("BUS_QualificationLose", 14, "LastModifyUserID", SqlDbType.UniqueIdentifier, false, false, false, true); }
		}

		public static EntityField LastModifyDate
		{
			get { return new EntityField("BUS_QualificationLose", 15, "LastModifyDate", SqlDbType.DateTime, false, false, false, true); }
		}

		public static EntityField LoseRemrk
		{
			get { return new EntityField("BUS_QualificationLose", 16, "LoseRemrk", SqlDbType.NVarChar, false, false, false, true); }
		}

		public static EntityField Reservation1
		{
			get { return new EntityField("BUS_QualificationLose", 17, "Reservation1", SqlDbType.NVarChar, false, false, false, true); }
		}

		public static EntityField Reservation2
		{
			get { return new EntityField("BUS_QualificationLose", 18, "Reservation2", SqlDbType.NVarChar, false, false, false, true); }
		}

		public static EntityField Reservation3
		{
			get { return new EntityField("BUS_QualificationLose", 19, "Reservation3", SqlDbType.NVarChar, false, false, false, true); }
		}

		public static EntityField Reservation4
		{
			get { return new EntityField("BUS_QualificationLose", 20, "Reservation4", SqlDbType.NVarChar, false, false, false, true); }
		}

		public static EntityField Reservation5
		{
			get { return new EntityField("BUS_QualificationLose", 21, "Reservation5", SqlDbType.NVarChar, false, false, false, true); }
		}

		public static EntityField Reservation6
		{
			get { return new EntityField("BUS_QualificationLose", 22, "Reservation6", SqlDbType.NVarChar, false, false, false, true); }
		}

		public static EntityField Reservation7
		{
			get { return new EntityField("BUS_QualificationLose", 23, "Reservation7", SqlDbType.NVarChar, false, false, false, true); }
		}

		public static EntityField Reservation8
		{
			get { return new EntityField("BUS_QualificationLose", 24, "Reservation8", SqlDbType.NVarChar, false, false, false, true); }
		}

		public static EntityField Reservation9
		{
			get { return new EntityField("BUS_QualificationLose", 25, "Reservation9", SqlDbType.NVarChar, false, false, false, true); }
		}

		public static EntityField Reservation10
		{
			get { return new EntityField("BUS_QualificationLose", 26, "Reservation10", SqlDbType.NVarChar, false, false, false, true); }
		}

	}

	#endregion

	#region BUSQualificationLoseEntityFields2

	public enum BUSQualificationLoseEntityFields2
	{
		LoseID,

		LoseType,

		LoseName,

		LoseSpell,

		QualificationCode,

		QualificationName,

		QualificationSpell,

		CertificateStyle,

		CertificateSpell,

		CertificateNo,

		LoseStatus,

		LoseDate,

		CreateUserID,

		CreateDate,

		LastModifyUserID,

		LastModifyDate,

		LoseRemrk,

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
