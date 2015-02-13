/*
 *	Build By: Codey Object Relation Mapping
 *	Build Data: 2013-07-21 10:04:49
 *	Build Type: Entity
 *	Description: SYSFunctionEntity
*/

using System;
using System.Collections.Generic;
using System.Data;
using ORMSCore;

namespace DQS.Module.Entities
{
	public class SYSFunctionEntity : EntityBase
	{
		public string FunctionCode
		{
			get { return (string)this.GetValue("FunctionCode"); } 
			set { this.SetValue("FunctionCode", value); } 
		}

		public string FunctionName
		{
			get { return (string)this.GetValue("FunctionName"); } 
			set { this.SetValue("FunctionName", value); } 
		}

		public int FunctionSort
		{
			get { return (int)this.GetValue("FunctionSort"); } 
			set { this.SetValue("FunctionSort", value); } 
		}

		public int ImageIndex
		{
			get { return (int)this.GetValue("ImageIndex"); } 
			set { this.SetValue("ImageIndex", value); } 
		}

		public string ImageName
		{
			get { return (string)this.GetValue("ImageName"); } 
			set { this.SetValue("ImageName", value); } 
		}

		public string ImageUrl
		{
			get { return (string)this.GetValue("ImageUrl"); } 
			set { this.SetValue("ImageUrl", value); } 
		}

		public byte[] ImageData
		{
			get { return (byte[])this.GetValue("ImageData"); } 
			set { this.SetValue("ImageData", value); } 
		}

		public string FunctionDescription
		{
			get { return (string)this.GetValue("FunctionDescription"); } 
			set { this.SetValue("FunctionDescription", value); } 
		}

		public string FunctionRemark
		{
			get { return (string)this.GetValue("FunctionRemark"); } 
			set { this.SetValue("FunctionRemark", value); } 
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

		public SYSFunctionEntity()
		{
			this.TableName = "SYS_Function";
			this.Fields = new Dictionary<string, EntityField>();
			this.Fields.Add("FunctionCode", SYSFunctionEntityFields.FunctionCode);
			this.Fields.Add("FunctionName", SYSFunctionEntityFields.FunctionName);
			this.Fields.Add("FunctionSort", SYSFunctionEntityFields.FunctionSort);
			this.Fields.Add("ImageIndex", SYSFunctionEntityFields.ImageIndex);
			this.Fields.Add("ImageName", SYSFunctionEntityFields.ImageName);
			this.Fields.Add("ImageUrl", SYSFunctionEntityFields.ImageUrl);
			this.Fields.Add("ImageData", SYSFunctionEntityFields.ImageData);
			this.Fields.Add("FunctionDescription", SYSFunctionEntityFields.FunctionDescription);
			this.Fields.Add("FunctionRemark", SYSFunctionEntityFields.FunctionRemark);
			this.Fields.Add("Reservation1", SYSFunctionEntityFields.Reservation1);
			this.Fields.Add("Reservation2", SYSFunctionEntityFields.Reservation2);
			this.Fields.Add("Reservation3", SYSFunctionEntityFields.Reservation3);
			this.Fields.Add("Reservation4", SYSFunctionEntityFields.Reservation4);
			this.Fields.Add("Reservation5", SYSFunctionEntityFields.Reservation5);
		}
	}

	#region SYSFunctionEntityFields

	public class SYSFunctionEntityFields
	{
		public static EntityField FunctionCode
		{
			get { return new EntityField("SYS_Function", 0, "FunctionCode", SqlDbType.NVarChar, true, false, true, false); }
		}

		public static EntityField FunctionName
		{
			get { return new EntityField("SYS_Function", 1, "FunctionName", SqlDbType.NVarChar, false, false, false, false); }
		}

		public static EntityField FunctionSort
		{
			get { return new EntityField("SYS_Function", 2, "FunctionSort", SqlDbType.Int, false, false, false, true); }
		}

		public static EntityField ImageIndex
		{
			get { return new EntityField("SYS_Function", 3, "ImageIndex", SqlDbType.Int, false, false, false, true); }
		}

		public static EntityField ImageName
		{
			get { return new EntityField("SYS_Function", 4, "ImageName", SqlDbType.NVarChar, false, false, false, true); }
		}

		public static EntityField ImageUrl
		{
			get { return new EntityField("SYS_Function", 5, "ImageUrl", SqlDbType.NVarChar, false, false, false, true); }
		}

		public static EntityField ImageData
		{
			get { return new EntityField("SYS_Function", 6, "ImageData", SqlDbType.Image, false, false, false, true); }
		}

		public static EntityField FunctionDescription
		{
			get { return new EntityField("SYS_Function", 7, "FunctionDescription", SqlDbType.NVarChar, false, false, false, true); }
		}

		public static EntityField FunctionRemark
		{
			get { return new EntityField("SYS_Function", 8, "FunctionRemark", SqlDbType.NVarChar, false, false, false, true); }
		}

		public static EntityField Reservation1
		{
			get { return new EntityField("SYS_Function", 9, "Reservation1", SqlDbType.NVarChar, false, false, false, true); }
		}

		public static EntityField Reservation2
		{
			get { return new EntityField("SYS_Function", 10, "Reservation2", SqlDbType.NVarChar, false, false, false, true); }
		}

		public static EntityField Reservation3
		{
			get { return new EntityField("SYS_Function", 11, "Reservation3", SqlDbType.NVarChar, false, false, false, true); }
		}

		public static EntityField Reservation4
		{
			get { return new EntityField("SYS_Function", 12, "Reservation4", SqlDbType.NVarChar, false, false, false, true); }
		}

		public static EntityField Reservation5
		{
			get { return new EntityField("SYS_Function", 13, "Reservation5", SqlDbType.NVarChar, false, false, false, true); }
		}

	}

	#endregion

	#region SYSFunctionEntityFields2

	public enum SYSFunctionEntityFields2
	{
		FunctionCode,

		FunctionName,

		FunctionSort,

		ImageIndex,

		ImageName,

		ImageUrl,

		ImageData,

		FunctionDescription,

		FunctionRemark,

		Reservation1,

		Reservation2,

		Reservation3,

		Reservation4,

		Reservation5,

	}

	#endregion

}
