/*
 *	Build By: Codey Object Relation Mapping
 *	Build Data: 2014-07-22 21:39:04
 *	Build Type: Entity
 *	Description: SYSMedicalProductCategoryEntity
*/

using System;
using System.Collections.Generic;
using System.Data;
using ORMSCore;

namespace DQS.Module.Entities
{
	public class SYSMedicalProductCategoryEntity : EntityBase
	{
		public int MedicalProductCategoryID
		{
			get { return (int)this.GetValue("MedicalProductCategoryID"); } 
			set { this.SetValue("MedicalProductCategoryID", value); } 
		}

		public string MedicalSubjectName
		{
			get { return (string)this.GetValue("MedicalSubjectName"); } 
			set { this.SetValue("MedicalSubjectName", value); } 
		}

		public string ProductStyleName
		{
			get { return (string)this.GetValue("ProductStyleName"); } 
			set { this.SetValue("ProductStyleName", value); } 
		}

		public string Remark
		{
			get { return (string)this.GetValue("Remark"); } 
			set { this.SetValue("Remark", value); } 
		}

		public SYSMedicalProductCategoryEntity()
		{
			this.TableName = "SYS_MedicalProductCategory";
			this.Fields = new Dictionary<string, EntityField>();
			this.Fields.Add("MedicalProductCategoryID", SYSMedicalProductCategoryEntityFields.MedicalProductCategoryID);
			this.Fields.Add("MedicalSubjectName", SYSMedicalProductCategoryEntityFields.MedicalSubjectName);
			this.Fields.Add("ProductStyleName", SYSMedicalProductCategoryEntityFields.ProductStyleName);
			this.Fields.Add("Remark", SYSMedicalProductCategoryEntityFields.Remark);
		}
	}

	#region SYSMedicalProductCategoryEntityFields

	public class SYSMedicalProductCategoryEntityFields
	{
		public static EntityField MedicalProductCategoryID
		{
			get { return new EntityField("SYS_MedicalProductCategory", 0, "MedicalProductCategoryID", SqlDbType.Int, true, true, true, false); }
		}

		public static EntityField MedicalSubjectName
		{
			get { return new EntityField("SYS_MedicalProductCategory", 1, "MedicalSubjectName", SqlDbType.NVarChar, false, false, false, false); }
		}

		public static EntityField ProductStyleName
		{
			get { return new EntityField("SYS_MedicalProductCategory", 2, "ProductStyleName", SqlDbType.NVarChar, false, false, false, false); }
		}

		public static EntityField Remark
		{
			get { return new EntityField("SYS_MedicalProductCategory", 3, "Remark", SqlDbType.NVarChar, false, false, false, true); }
		}

	}

	#endregion

	#region SYSMedicalProductCategoryEntityFields2

	public enum SYSMedicalProductCategoryEntityFields2
	{
		MedicalProductCategoryID,

		MedicalSubjectName,

		ProductStyleName,

		Remark,

	}

	#endregion

}
