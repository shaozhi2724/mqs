/*
 *	Build By: Codey Object Relation Mapping
 *	Build Data: 2014-03-02 13:00:18
 *	Build Type: Entity
 *	Description: BFISalesmanEntity
*/

using System;
using System.Collections.Generic;
using System.Data;
using ORMSCore;

namespace DQS.Module.Entities
{
	public class BFISalesmanEntity : EntityBase
	{
		public int SalesmanID
		{
			get { return (int)this.GetValue("SalesmanID"); } 
			set { this.SetValue("SalesmanID", value); } 
		}

		public string SalesmanCode
		{
			get { return (string)this.GetValue("SalesmanCode"); } 
			set { this.SetValue("SalesmanCode", value); } 
		}

		public string SalesmanName
		{
			get { return (string)this.GetValue("SalesmanName"); } 
			set { this.SetValue("SalesmanName", value); } 
		}

		public string SalesmanSpell
		{
			get { return (string)this.GetValue("SalesmanSpell"); } 
			set { this.SetValue("SalesmanSpell", value); } 
		}

		public int DealerID
		{
			get { return (int)this.GetValue("DealerID"); } 
			set { this.SetValue("DealerID", value); } 
		}

		public string DealerName
		{
			get { return (string)this.GetValue("DealerName"); } 
			set { this.SetValue("DealerName", value); } 
		}

		public string DealerSpell
		{
			get { return (string)this.GetValue("DealerSpell"); } 
			set { this.SetValue("DealerSpell", value); } 
		}

		public string Sex
		{
			get { return (string)this.GetValue("Sex"); } 
			set { this.SetValue("Sex", value); } 
		}

		public string Nation
		{
			get { return (string)this.GetValue("Nation"); } 
			set { this.SetValue("Nation", value); } 
		}

		public DateTime Birthday
		{
			get { return (DateTime)this.GetValue("Birthday"); } 
			set { this.SetValue("Birthday", value); } 
		}

		public string IDCardNo
		{
			get { return (string)this.GetValue("IDCardNo"); } 
			set { this.SetValue("IDCardNo", value); } 
		}

		public string MobilePhone
		{
			get { return (string)this.GetValue("MobilePhone"); } 
			set { this.SetValue("MobilePhone", value); } 
		}

		public string HomePhone
		{
			get { return (string)this.GetValue("HomePhone"); } 
			set { this.SetValue("HomePhone", value); } 
		}

		public string Email
		{
			get { return (string)this.GetValue("Email"); } 
			set { this.SetValue("Email", value); } 
		}

		public string CurrentAddress
		{
			get { return (string)this.GetValue("CurrentAddress"); } 
			set { this.SetValue("CurrentAddress", value); } 
		}

		public string Education
		{
			get { return (string)this.GetValue("Education"); } 
			set { this.SetValue("Education", value); } 
		}

		public string Degree
		{
			get { return (string)this.GetValue("Degree"); } 
			set { this.SetValue("Degree", value); } 
		}

		public string FinishSchool
		{
			get { return (string)this.GetValue("FinishSchool"); } 
			set { this.SetValue("FinishSchool", value); } 
		}

		public string Specialty
		{
			get { return (string)this.GetValue("Specialty"); } 
			set { this.SetValue("Specialty", value); } 
		}

		public string SchoolLimit
		{
			get { return (string)this.GetValue("SchoolLimit"); } 
			set { this.SetValue("SchoolLimit", value); } 
		}

		public DateTime FinishSchoolDate
		{
			get { return (DateTime)this.GetValue("FinishSchoolDate"); } 
			set { this.SetValue("FinishSchoolDate", value); } 
		}

		public string CertificateList
		{
			get { return (string)this.GetValue("CertificateList"); } 
			set { this.SetValue("CertificateList", value); } 
		}

		public int SalesJobID
		{
			get { return (int)this.GetValue("SalesJobID"); } 
			set { this.SetValue("SalesJobID", value); } 
		}

		public string SalesJobName
		{
			get { return (string)this.GetValue("SalesJobName"); } 
			set { this.SetValue("SalesJobName", value); } 
		}

		public string SalesArea
		{
			get { return (string)this.GetValue("SalesArea"); } 
			set { this.SetValue("SalesArea", value); } 
		}

		public string SalesRange
		{
			get { return (string)this.GetValue("SalesRange"); } 
			set { this.SetValue("SalesRange", value); } 
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

		public string SalesmanRemark
		{
			get { return (string)this.GetValue("SalesmanRemark"); } 
			set { this.SetValue("SalesmanRemark", value); } 
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

		public BFISalesmanEntity()
		{
			this.TableName = "BFI_Salesman";
			this.Fields = new Dictionary<string, EntityField>();
			this.Fields.Add("SalesmanID", BFISalesmanEntityFields.SalesmanID);
			this.Fields.Add("SalesmanCode", BFISalesmanEntityFields.SalesmanCode);
			this.Fields.Add("SalesmanName", BFISalesmanEntityFields.SalesmanName);
			this.Fields.Add("SalesmanSpell", BFISalesmanEntityFields.SalesmanSpell);
			this.Fields.Add("DealerID", BFISalesmanEntityFields.DealerID);
			this.Fields.Add("DealerName", BFISalesmanEntityFields.DealerName);
			this.Fields.Add("DealerSpell", BFISalesmanEntityFields.DealerSpell);
			this.Fields.Add("Sex", BFISalesmanEntityFields.Sex);
			this.Fields.Add("Nation", BFISalesmanEntityFields.Nation);
			this.Fields.Add("Birthday", BFISalesmanEntityFields.Birthday);
			this.Fields.Add("IDCardNo", BFISalesmanEntityFields.IDCardNo);
			this.Fields.Add("MobilePhone", BFISalesmanEntityFields.MobilePhone);
			this.Fields.Add("HomePhone", BFISalesmanEntityFields.HomePhone);
			this.Fields.Add("Email", BFISalesmanEntityFields.Email);
			this.Fields.Add("CurrentAddress", BFISalesmanEntityFields.CurrentAddress);
			this.Fields.Add("Education", BFISalesmanEntityFields.Education);
			this.Fields.Add("Degree", BFISalesmanEntityFields.Degree);
			this.Fields.Add("FinishSchool", BFISalesmanEntityFields.FinishSchool);
			this.Fields.Add("Specialty", BFISalesmanEntityFields.Specialty);
			this.Fields.Add("SchoolLimit", BFISalesmanEntityFields.SchoolLimit);
			this.Fields.Add("FinishSchoolDate", BFISalesmanEntityFields.FinishSchoolDate);
			this.Fields.Add("CertificateList", BFISalesmanEntityFields.CertificateList);
			this.Fields.Add("SalesJobID", BFISalesmanEntityFields.SalesJobID);
			this.Fields.Add("SalesJobName", BFISalesmanEntityFields.SalesJobName);
			this.Fields.Add("SalesArea", BFISalesmanEntityFields.SalesArea);
			this.Fields.Add("SalesRange", BFISalesmanEntityFields.SalesRange);
			this.Fields.Add("CreateUserID", BFISalesmanEntityFields.CreateUserID);
			this.Fields.Add("CreateDate", BFISalesmanEntityFields.CreateDate);
			this.Fields.Add("LastModifyUserID", BFISalesmanEntityFields.LastModifyUserID);
			this.Fields.Add("LastModifyDate", BFISalesmanEntityFields.LastModifyDate);
			this.Fields.Add("SalesmanRemark", BFISalesmanEntityFields.SalesmanRemark);
			this.Fields.Add("Reservation1", BFISalesmanEntityFields.Reservation1);
			this.Fields.Add("Reservation2", BFISalesmanEntityFields.Reservation2);
			this.Fields.Add("Reservation3", BFISalesmanEntityFields.Reservation3);
			this.Fields.Add("Reservation4", BFISalesmanEntityFields.Reservation4);
			this.Fields.Add("Reservation5", BFISalesmanEntityFields.Reservation5);
			this.Fields.Add("Reservation6", BFISalesmanEntityFields.Reservation6);
			this.Fields.Add("Reservation7", BFISalesmanEntityFields.Reservation7);
			this.Fields.Add("Reservation8", BFISalesmanEntityFields.Reservation8);
			this.Fields.Add("Reservation9", BFISalesmanEntityFields.Reservation9);
			this.Fields.Add("Reservation10", BFISalesmanEntityFields.Reservation10);
		}
	}

	#region BFISalesmanEntityFields

	public class BFISalesmanEntityFields
	{
		public static EntityField SalesmanID
		{
			get { return new EntityField("BFI_Salesman", 0, "SalesmanID", SqlDbType.Int, true, true, true, false); }
		}

		public static EntityField SalesmanCode
		{
			get { return new EntityField("BFI_Salesman", 1, "SalesmanCode", SqlDbType.NVarChar, false, false, true, false); }
		}

		public static EntityField SalesmanName
		{
			get { return new EntityField("BFI_Salesman", 2, "SalesmanName", SqlDbType.NVarChar, false, false, false, false); }
		}

		public static EntityField SalesmanSpell
		{
			get { return new EntityField("BFI_Salesman", 3, "SalesmanSpell", SqlDbType.NVarChar, false, false, false, true); }
		}

		public static EntityField DealerID
		{
			get { return new EntityField("BFI_Salesman", 4, "DealerID", SqlDbType.Int, false, false, false, true); }
		}

		public static EntityField DealerName
		{
			get { return new EntityField("BFI_Salesman", 5, "DealerName", SqlDbType.NVarChar, false, false, false, true); }
		}

		public static EntityField DealerSpell
		{
			get { return new EntityField("BFI_Salesman", 6, "DealerSpell", SqlDbType.NVarChar, false, false, false, true); }
		}

		public static EntityField Sex
		{
			get { return new EntityField("BFI_Salesman", 7, "Sex", SqlDbType.NVarChar, false, false, false, true); }
		}

		public static EntityField Nation
		{
			get { return new EntityField("BFI_Salesman", 8, "Nation", SqlDbType.NVarChar, false, false, false, true); }
		}

		public static EntityField Birthday
		{
			get { return new EntityField("BFI_Salesman", 9, "Birthday", SqlDbType.DateTime, false, false, false, true); }
		}

		public static EntityField IDCardNo
		{
			get { return new EntityField("BFI_Salesman", 10, "IDCardNo", SqlDbType.NChar, false, false, false, true); }
		}

		public static EntityField MobilePhone
		{
			get { return new EntityField("BFI_Salesman", 11, "MobilePhone", SqlDbType.NVarChar, false, false, false, true); }
		}

		public static EntityField HomePhone
		{
			get { return new EntityField("BFI_Salesman", 12, "HomePhone", SqlDbType.NVarChar, false, false, false, true); }
		}

		public static EntityField Email
		{
			get { return new EntityField("BFI_Salesman", 13, "Email", SqlDbType.NVarChar, false, false, false, true); }
		}

		public static EntityField CurrentAddress
		{
			get { return new EntityField("BFI_Salesman", 14, "CurrentAddress", SqlDbType.NVarChar, false, false, false, true); }
		}

		public static EntityField Education
		{
			get { return new EntityField("BFI_Salesman", 15, "Education", SqlDbType.NVarChar, false, false, false, true); }
		}

		public static EntityField Degree
		{
			get { return new EntityField("BFI_Salesman", 16, "Degree", SqlDbType.NVarChar, false, false, false, true); }
		}

		public static EntityField FinishSchool
		{
			get { return new EntityField("BFI_Salesman", 17, "FinishSchool", SqlDbType.NVarChar, false, false, false, true); }
		}

		public static EntityField Specialty
		{
			get { return new EntityField("BFI_Salesman", 18, "Specialty", SqlDbType.NVarChar, false, false, false, true); }
		}

		public static EntityField SchoolLimit
		{
			get { return new EntityField("BFI_Salesman", 19, "SchoolLimit", SqlDbType.NVarChar, false, false, false, true); }
		}

		public static EntityField FinishSchoolDate
		{
			get { return new EntityField("BFI_Salesman", 20, "FinishSchoolDate", SqlDbType.DateTime, false, false, false, true); }
		}

		public static EntityField CertificateList
		{
			get { return new EntityField("BFI_Salesman", 21, "CertificateList", SqlDbType.NVarChar, false, false, false, true); }
		}

		public static EntityField SalesJobID
		{
			get { return new EntityField("BFI_Salesman", 22, "SalesJobID", SqlDbType.Int, false, false, false, true); }
		}

		public static EntityField SalesJobName
		{
			get { return new EntityField("BFI_Salesman", 23, "SalesJobName", SqlDbType.NVarChar, false, false, false, true); }
		}

		public static EntityField SalesArea
		{
			get { return new EntityField("BFI_Salesman", 24, "SalesArea", SqlDbType.NVarChar, false, false, false, true); }
		}

		public static EntityField SalesRange
		{
			get { return new EntityField("BFI_Salesman", 25, "SalesRange", SqlDbType.NVarChar, false, false, false, true); }
		}

		public static EntityField CreateUserID
		{
			get { return new EntityField("BFI_Salesman", 26, "CreateUserID", SqlDbType.UniqueIdentifier, false, false, false, true); }
		}

		public static EntityField CreateDate
		{
			get { return new EntityField("BFI_Salesman", 27, "CreateDate", SqlDbType.DateTime, false, false, false, true); }
		}

		public static EntityField LastModifyUserID
		{
			get { return new EntityField("BFI_Salesman", 28, "LastModifyUserID", SqlDbType.UniqueIdentifier, false, false, false, true); }
		}

		public static EntityField LastModifyDate
		{
			get { return new EntityField("BFI_Salesman", 29, "LastModifyDate", SqlDbType.DateTime, false, false, false, true); }
		}

		public static EntityField SalesmanRemark
		{
			get { return new EntityField("BFI_Salesman", 30, "SalesmanRemark", SqlDbType.NVarChar, false, false, false, true); }
		}

		public static EntityField Reservation1
		{
			get { return new EntityField("BFI_Salesman", 31, "Reservation1", SqlDbType.NVarChar, false, false, false, true); }
		}

		public static EntityField Reservation2
		{
			get { return new EntityField("BFI_Salesman", 32, "Reservation2", SqlDbType.NVarChar, false, false, false, true); }
		}

		public static EntityField Reservation3
		{
			get { return new EntityField("BFI_Salesman", 33, "Reservation3", SqlDbType.NVarChar, false, false, false, true); }
		}

		public static EntityField Reservation4
		{
			get { return new EntityField("BFI_Salesman", 34, "Reservation4", SqlDbType.NVarChar, false, false, false, true); }
		}

		public static EntityField Reservation5
		{
			get { return new EntityField("BFI_Salesman", 35, "Reservation5", SqlDbType.NVarChar, false, false, false, true); }
		}

		public static EntityField Reservation6
		{
			get { return new EntityField("BFI_Salesman", 36, "Reservation6", SqlDbType.NVarChar, false, false, false, true); }
		}

		public static EntityField Reservation7
		{
			get { return new EntityField("BFI_Salesman", 37, "Reservation7", SqlDbType.NVarChar, false, false, false, true); }
		}

		public static EntityField Reservation8
		{
			get { return new EntityField("BFI_Salesman", 38, "Reservation8", SqlDbType.NVarChar, false, false, false, true); }
		}

		public static EntityField Reservation9
		{
			get { return new EntityField("BFI_Salesman", 39, "Reservation9", SqlDbType.NVarChar, false, false, false, true); }
		}

		public static EntityField Reservation10
		{
			get { return new EntityField("BFI_Salesman", 40, "Reservation10", SqlDbType.NVarChar, false, false, false, true); }
		}

	}

	#endregion

	#region BFISalesmanEntityFields2

	public enum BFISalesmanEntityFields2
	{
		SalesmanID,

		SalesmanCode,

		SalesmanName,

		SalesmanSpell,

		DealerID,

		DealerName,

		DealerSpell,

		Sex,

		Nation,

		Birthday,

		IDCardNo,

		MobilePhone,

		HomePhone,

		Email,

		CurrentAddress,

		Education,

		Degree,

		FinishSchool,

		Specialty,

		SchoolLimit,

		FinishSchoolDate,

		CertificateList,

		SalesJobID,

		SalesJobName,

		SalesArea,

		SalesRange,

		CreateUserID,

		CreateDate,

		LastModifyUserID,

		LastModifyDate,

		SalesmanRemark,

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
