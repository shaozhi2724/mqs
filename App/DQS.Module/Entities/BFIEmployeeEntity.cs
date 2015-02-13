/*
 *	Build By: Codey Object Relation Mapping
 *	Build Data: 2013-08-22 16:13:06
 *	Build Type: Entity
 *	Description: BFIEmployeeEntity
*/

using System;
using System.Collections.Generic;
using System.Data;
using ORMSCore;

namespace DQS.Module.Entities
{
	public class BFIEmployeeEntity : EntityBase
	{
		public int EmployeeID
		{
			get { return (int)this.GetValue("EmployeeID"); } 
			set { this.SetValue("EmployeeID", value); } 
		}

		public string EmployeeCode
		{
			get { return (string)this.GetValue("EmployeeCode"); } 
			set { this.SetValue("EmployeeCode", value); } 
		}

		public string EmployeeName
		{
			get { return (string)this.GetValue("EmployeeName"); } 
			set { this.SetValue("EmployeeName", value); } 
		}

		public string EmployeeSpell
		{
			get { return (string)this.GetValue("EmployeeSpell"); } 
			set { this.SetValue("EmployeeSpell", value); } 
		}

		public string FormerName
		{
			get { return (string)this.GetValue("FormerName"); } 
			set { this.SetValue("FormerName", value); } 
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

		public int DepartmentID
		{
			get { return (int)this.GetValue("DepartmentID"); } 
			set { this.SetValue("DepartmentID", value); } 
		}

		public string PostName
		{
			get { return (string)this.GetValue("PostName"); } 
			set { this.SetValue("PostName", value); } 
		}

		public DateTime EntryDate
		{
			get { return (DateTime)this.GetValue("EntryDate"); } 
			set { this.SetValue("EntryDate", value); } 
		}

		public string PoliticalStatus
		{
			get { return (string)this.GetValue("PoliticalStatus"); } 
			set { this.SetValue("PoliticalStatus", value); } 
		}

		public string MaritalStatus
		{
			get { return (string)this.GetValue("MaritalStatus"); } 
			set { this.SetValue("MaritalStatus", value); } 
		}

		public string BirthPlace
		{
			get { return (string)this.GetValue("BirthPlace"); } 
			set { this.SetValue("BirthPlace", value); } 
		}

		public string ResidencePlace
		{
			get { return (string)this.GetValue("ResidencePlace"); } 
			set { this.SetValue("ResidencePlace", value); } 
		}

		public string CurrentAddress
		{
			get { return (string)this.GetValue("CurrentAddress"); } 
			set { this.SetValue("CurrentAddress", value); } 
		}

		public string EmergencyPerson
		{
			get { return (string)this.GetValue("EmergencyPerson"); } 
			set { this.SetValue("EmergencyPerson", value); } 
		}

		public string EmergencyPhone
		{
			get { return (string)this.GetValue("EmergencyPhone"); } 
			set { this.SetValue("EmergencyPhone", value); } 
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

		public string EmployeeRemark
		{
			get { return (string)this.GetValue("EmployeeRemark"); } 
			set { this.SetValue("EmployeeRemark", value); } 
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

		public BFIEmployeeEntity()
		{
			this.TableName = "BFI_Employee";
			this.Fields = new Dictionary<string, EntityField>();
			this.Fields.Add("EmployeeID", BFIEmployeeEntityFields.EmployeeID);
			this.Fields.Add("EmployeeCode", BFIEmployeeEntityFields.EmployeeCode);
			this.Fields.Add("EmployeeName", BFIEmployeeEntityFields.EmployeeName);
			this.Fields.Add("EmployeeSpell", BFIEmployeeEntityFields.EmployeeSpell);
			this.Fields.Add("FormerName", BFIEmployeeEntityFields.FormerName);
			this.Fields.Add("Sex", BFIEmployeeEntityFields.Sex);
			this.Fields.Add("Nation", BFIEmployeeEntityFields.Nation);
			this.Fields.Add("Birthday", BFIEmployeeEntityFields.Birthday);
			this.Fields.Add("IDCardNo", BFIEmployeeEntityFields.IDCardNo);
			this.Fields.Add("MobilePhone", BFIEmployeeEntityFields.MobilePhone);
			this.Fields.Add("HomePhone", BFIEmployeeEntityFields.HomePhone);
			this.Fields.Add("Email", BFIEmployeeEntityFields.Email);
			this.Fields.Add("DepartmentID", BFIEmployeeEntityFields.DepartmentID);
			this.Fields.Add("PostName", BFIEmployeeEntityFields.PostName);
			this.Fields.Add("EntryDate", BFIEmployeeEntityFields.EntryDate);
			this.Fields.Add("PoliticalStatus", BFIEmployeeEntityFields.PoliticalStatus);
			this.Fields.Add("MaritalStatus", BFIEmployeeEntityFields.MaritalStatus);
			this.Fields.Add("BirthPlace", BFIEmployeeEntityFields.BirthPlace);
			this.Fields.Add("ResidencePlace", BFIEmployeeEntityFields.ResidencePlace);
			this.Fields.Add("CurrentAddress", BFIEmployeeEntityFields.CurrentAddress);
			this.Fields.Add("EmergencyPerson", BFIEmployeeEntityFields.EmergencyPerson);
			this.Fields.Add("EmergencyPhone", BFIEmployeeEntityFields.EmergencyPhone);
			this.Fields.Add("Education", BFIEmployeeEntityFields.Education);
			this.Fields.Add("Degree", BFIEmployeeEntityFields.Degree);
			this.Fields.Add("FinishSchool", BFIEmployeeEntityFields.FinishSchool);
			this.Fields.Add("Specialty", BFIEmployeeEntityFields.Specialty);
			this.Fields.Add("SchoolLimit", BFIEmployeeEntityFields.SchoolLimit);
			this.Fields.Add("FinishSchoolDate", BFIEmployeeEntityFields.FinishSchoolDate);
			this.Fields.Add("CertificateList", BFIEmployeeEntityFields.CertificateList);
			this.Fields.Add("CreateUserID", BFIEmployeeEntityFields.CreateUserID);
			this.Fields.Add("CreateDate", BFIEmployeeEntityFields.CreateDate);
			this.Fields.Add("LastModifyUserID", BFIEmployeeEntityFields.LastModifyUserID);
			this.Fields.Add("LastModifyDate", BFIEmployeeEntityFields.LastModifyDate);
			this.Fields.Add("EmployeeRemark", BFIEmployeeEntityFields.EmployeeRemark);
			this.Fields.Add("Reservation1", BFIEmployeeEntityFields.Reservation1);
			this.Fields.Add("Reservation2", BFIEmployeeEntityFields.Reservation2);
			this.Fields.Add("Reservation3", BFIEmployeeEntityFields.Reservation3);
			this.Fields.Add("Reservation4", BFIEmployeeEntityFields.Reservation4);
			this.Fields.Add("Reservation5", BFIEmployeeEntityFields.Reservation5);
			this.Fields.Add("Reservation6", BFIEmployeeEntityFields.Reservation6);
			this.Fields.Add("Reservation7", BFIEmployeeEntityFields.Reservation7);
			this.Fields.Add("Reservation8", BFIEmployeeEntityFields.Reservation8);
			this.Fields.Add("Reservation9", BFIEmployeeEntityFields.Reservation9);
			this.Fields.Add("Reservation10", BFIEmployeeEntityFields.Reservation10);
		}
	}

	#region BFIEmployeeEntityFields

	public class BFIEmployeeEntityFields
	{
		public static EntityField EmployeeID
		{
			get { return new EntityField("BFI_Employee", 0, "EmployeeID", SqlDbType.Int, true, true, true, false); }
		}

		public static EntityField EmployeeCode
		{
			get { return new EntityField("BFI_Employee", 1, "EmployeeCode", SqlDbType.NVarChar, false, false, true, false); }
		}

		public static EntityField EmployeeName
		{
			get { return new EntityField("BFI_Employee", 2, "EmployeeName", SqlDbType.NVarChar, false, false, false, false); }
		}

		public static EntityField EmployeeSpell
		{
			get { return new EntityField("BFI_Employee", 3, "EmployeeSpell", SqlDbType.NVarChar, false, false, false, true); }
		}

		public static EntityField FormerName
		{
			get { return new EntityField("BFI_Employee", 4, "FormerName", SqlDbType.NVarChar, false, false, false, true); }
		}

		public static EntityField Sex
		{
			get { return new EntityField("BFI_Employee", 5, "Sex", SqlDbType.NVarChar, false, false, false, true); }
		}

		public static EntityField Nation
		{
			get { return new EntityField("BFI_Employee", 6, "Nation", SqlDbType.NVarChar, false, false, false, true); }
		}

		public static EntityField Birthday
		{
			get { return new EntityField("BFI_Employee", 7, "Birthday", SqlDbType.DateTime, false, false, false, true); }
		}

		public static EntityField IDCardNo
		{
			get { return new EntityField("BFI_Employee", 8, "IDCardNo", SqlDbType.NChar, false, false, false, true); }
		}

		public static EntityField MobilePhone
		{
			get { return new EntityField("BFI_Employee", 9, "MobilePhone", SqlDbType.NVarChar, false, false, false, true); }
		}

		public static EntityField HomePhone
		{
			get { return new EntityField("BFI_Employee", 10, "HomePhone", SqlDbType.NVarChar, false, false, false, true); }
		}

		public static EntityField Email
		{
			get { return new EntityField("BFI_Employee", 11, "Email", SqlDbType.NVarChar, false, false, false, true); }
		}

		public static EntityField DepartmentID
		{
			get { return new EntityField("BFI_Employee", 12, "DepartmentID", SqlDbType.Int, false, false, false, true); }
		}

		public static EntityField PostName
		{
			get { return new EntityField("BFI_Employee", 13, "PostName", SqlDbType.NVarChar, false, false, false, true); }
		}

		public static EntityField EntryDate
		{
			get { return new EntityField("BFI_Employee", 14, "EntryDate", SqlDbType.DateTime, false, false, false, true); }
		}

		public static EntityField PoliticalStatus
		{
			get { return new EntityField("BFI_Employee", 15, "PoliticalStatus", SqlDbType.NVarChar, false, false, false, true); }
		}

		public static EntityField MaritalStatus
		{
			get { return new EntityField("BFI_Employee", 16, "MaritalStatus", SqlDbType.NVarChar, false, false, false, true); }
		}

		public static EntityField BirthPlace
		{
			get { return new EntityField("BFI_Employee", 17, "BirthPlace", SqlDbType.NVarChar, false, false, false, true); }
		}

		public static EntityField ResidencePlace
		{
			get { return new EntityField("BFI_Employee", 18, "ResidencePlace", SqlDbType.NVarChar, false, false, false, true); }
		}

		public static EntityField CurrentAddress
		{
			get { return new EntityField("BFI_Employee", 19, "CurrentAddress", SqlDbType.NVarChar, false, false, false, true); }
		}

		public static EntityField EmergencyPerson
		{
			get { return new EntityField("BFI_Employee", 20, "EmergencyPerson", SqlDbType.NVarChar, false, false, false, true); }
		}

		public static EntityField EmergencyPhone
		{
			get { return new EntityField("BFI_Employee", 21, "EmergencyPhone", SqlDbType.NVarChar, false, false, false, true); }
		}

		public static EntityField Education
		{
			get { return new EntityField("BFI_Employee", 22, "Education", SqlDbType.NVarChar, false, false, false, true); }
		}

		public static EntityField Degree
		{
			get { return new EntityField("BFI_Employee", 23, "Degree", SqlDbType.NVarChar, false, false, false, true); }
		}

		public static EntityField FinishSchool
		{
			get { return new EntityField("BFI_Employee", 24, "FinishSchool", SqlDbType.NVarChar, false, false, false, true); }
		}

		public static EntityField Specialty
		{
			get { return new EntityField("BFI_Employee", 25, "Specialty", SqlDbType.NVarChar, false, false, false, true); }
		}

		public static EntityField SchoolLimit
		{
			get { return new EntityField("BFI_Employee", 26, "SchoolLimit", SqlDbType.NVarChar, false, false, false, true); }
		}

		public static EntityField FinishSchoolDate
		{
			get { return new EntityField("BFI_Employee", 27, "FinishSchoolDate", SqlDbType.DateTime, false, false, false, true); }
		}

		public static EntityField CertificateList
		{
			get { return new EntityField("BFI_Employee", 28, "CertificateList", SqlDbType.NVarChar, false, false, false, true); }
		}

		public static EntityField CreateUserID
		{
			get { return new EntityField("BFI_Employee", 29, "CreateUserID", SqlDbType.UniqueIdentifier, false, false, false, true); }
		}

		public static EntityField CreateDate
		{
			get { return new EntityField("BFI_Employee", 30, "CreateDate", SqlDbType.DateTime, false, false, false, true); }
		}

		public static EntityField LastModifyUserID
		{
			get { return new EntityField("BFI_Employee", 31, "LastModifyUserID", SqlDbType.UniqueIdentifier, false, false, false, true); }
		}

		public static EntityField LastModifyDate
		{
			get { return new EntityField("BFI_Employee", 32, "LastModifyDate", SqlDbType.DateTime, false, false, false, true); }
		}

		public static EntityField EmployeeRemark
		{
			get { return new EntityField("BFI_Employee", 33, "EmployeeRemark", SqlDbType.NVarChar, false, false, false, true); }
		}

		public static EntityField Reservation1
		{
			get { return new EntityField("BFI_Employee", 34, "Reservation1", SqlDbType.NVarChar, false, false, false, true); }
		}

		public static EntityField Reservation2
		{
			get { return new EntityField("BFI_Employee", 35, "Reservation2", SqlDbType.NVarChar, false, false, false, true); }
		}

		public static EntityField Reservation3
		{
			get { return new EntityField("BFI_Employee", 36, "Reservation3", SqlDbType.NVarChar, false, false, false, true); }
		}

		public static EntityField Reservation4
		{
			get { return new EntityField("BFI_Employee", 37, "Reservation4", SqlDbType.NVarChar, false, false, false, true); }
		}

		public static EntityField Reservation5
		{
			get { return new EntityField("BFI_Employee", 38, "Reservation5", SqlDbType.NVarChar, false, false, false, true); }
		}

		public static EntityField Reservation6
		{
			get { return new EntityField("BFI_Employee", 39, "Reservation6", SqlDbType.NVarChar, false, false, false, true); }
		}

		public static EntityField Reservation7
		{
			get { return new EntityField("BFI_Employee", 40, "Reservation7", SqlDbType.NVarChar, false, false, false, true); }
		}

		public static EntityField Reservation8
		{
			get { return new EntityField("BFI_Employee", 41, "Reservation8", SqlDbType.NVarChar, false, false, false, true); }
		}

		public static EntityField Reservation9
		{
			get { return new EntityField("BFI_Employee", 42, "Reservation9", SqlDbType.NVarChar, false, false, false, true); }
		}

		public static EntityField Reservation10
		{
			get { return new EntityField("BFI_Employee", 43, "Reservation10", SqlDbType.NVarChar, false, false, false, true); }
		}

	}

	#endregion

	#region BFIEmployeeEntityFields2

	public enum BFIEmployeeEntityFields2
	{
		EmployeeID,

		EmployeeCode,

		EmployeeName,

		EmployeeSpell,

		FormerName,

		Sex,

		Nation,

		Birthday,

		IDCardNo,

		MobilePhone,

		HomePhone,

		Email,

		DepartmentID,

		PostName,

		EntryDate,

		PoliticalStatus,

		MaritalStatus,

		BirthPlace,

		ResidencePlace,

		CurrentAddress,

		EmergencyPerson,

		EmergencyPhone,

		Education,

		Degree,

		FinishSchool,

		Specialty,

		SchoolLimit,

		FinishSchoolDate,

		CertificateList,

		CreateUserID,

		CreateDate,

		LastModifyUserID,

		LastModifyDate,

		EmployeeRemark,

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
