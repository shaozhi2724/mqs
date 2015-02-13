/*
 *	Build By: Codey Object Relation Mapping
 *	Build Data: 2014-03-04 22:32:22
 *	Build Type: View
 *	Description: AllWarehouseStructureView
*/

using System;
using System.Collections.Generic;
using System.Data;
using ORMSCore;

namespace DQS.Module.Views
{
	public class AllWarehouseStructureView : ViewBase
	{
		public int StructureID
		{
			get { return (int)this.GetValue("StructureID"); } 
			set { this.SetValue("StructureID", value); } 
		}

		public int WarehouseID
		{
			get { return (int)this.GetValue("WarehouseID"); } 
			set { this.SetValue("WarehouseID", value); } 
		}

		public string StructureCode
		{
			get { return (string)this.GetValue("StructureCode"); } 
			set { this.SetValue("StructureCode", value); } 
		}

		public string StructureCode2
		{
			get { return (string)this.GetValue("StructureCode2"); } 
			set { this.SetValue("StructureCode2", value); } 
		}

		public string ParentStructureCode
		{
			get { return (string)this.GetValue("ParentStructureCode"); } 
			set { this.SetValue("ParentStructureCode", value); } 
		}

		public string ParentStructureCode2
		{
			get { return (string)this.GetValue("ParentStructureCode2"); } 
			set { this.SetValue("ParentStructureCode2", value); } 
		}

		public string StructureName
		{
			get { return (string)this.GetValue("StructureName"); } 
			set { this.SetValue("StructureName", value); } 
		}

		public string StructureType
		{
			get { return (string)this.GetValue("StructureType"); } 
			set { this.SetValue("StructureType", value); } 
		}

		public string StructureLocation
		{
			get { return (string)this.GetValue("StructureLocation"); } 
			set { this.SetValue("StructureLocation", value); } 
		}

		public string StructureLeader
		{
			get { return (string)this.GetValue("StructureLeader"); } 
			set { this.SetValue("StructureLeader", value); } 
		}

		public string LeaderPhone
		{
			get { return (string)this.GetValue("LeaderPhone"); } 
			set { this.SetValue("LeaderPhone", value); } 
		}

		public string StructureSpace
		{
			get { return (string)this.GetValue("StructureSpace"); } 
			set { this.SetValue("StructureSpace", value); } 
		}

		public string StructureVolume
		{
			get { return (string)this.GetValue("StructureVolume"); } 
			set { this.SetValue("StructureVolume", value); } 
		}

		public bool IsMinStructure
		{
			get { return (bool)this.GetValue("IsMinStructure"); } 
			set { this.SetValue("IsMinStructure", value); } 
		}

		public string StructureBarCode
		{
			get { return (string)this.GetValue("StructureBarCode"); } 
			set { this.SetValue("StructureBarCode", value); } 
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

		public string StructureRemark
		{
			get { return (string)this.GetValue("StructureRemark"); } 
			set { this.SetValue("StructureRemark", value); } 
		}

		public AllWarehouseStructureView()
		{
			this.ViewName = "vw_AllWarehouseStructure";
			this.Fields = new Dictionary<string, EntityField>();
			this.Fields.Add("StructureID", AllWarehouseStructureViewFields.StructureID);
			this.Fields.Add("WarehouseID", AllWarehouseStructureViewFields.WarehouseID);
			this.Fields.Add("StructureCode", AllWarehouseStructureViewFields.StructureCode);
			this.Fields.Add("StructureCode2", AllWarehouseStructureViewFields.StructureCode2);
			this.Fields.Add("ParentStructureCode", AllWarehouseStructureViewFields.ParentStructureCode);
			this.Fields.Add("ParentStructureCode2", AllWarehouseStructureViewFields.ParentStructureCode2);
			this.Fields.Add("StructureName", AllWarehouseStructureViewFields.StructureName);
			this.Fields.Add("StructureType", AllWarehouseStructureViewFields.StructureType);
			this.Fields.Add("StructureLocation", AllWarehouseStructureViewFields.StructureLocation);
			this.Fields.Add("StructureLeader", AllWarehouseStructureViewFields.StructureLeader);
			this.Fields.Add("LeaderPhone", AllWarehouseStructureViewFields.LeaderPhone);
			this.Fields.Add("StructureSpace", AllWarehouseStructureViewFields.StructureSpace);
			this.Fields.Add("StructureVolume", AllWarehouseStructureViewFields.StructureVolume);
			this.Fields.Add("IsMinStructure", AllWarehouseStructureViewFields.IsMinStructure);
			this.Fields.Add("StructureBarCode", AllWarehouseStructureViewFields.StructureBarCode);
			this.Fields.Add("CreateUserID", AllWarehouseStructureViewFields.CreateUserID);
			this.Fields.Add("CreateDate", AllWarehouseStructureViewFields.CreateDate);
			this.Fields.Add("LastModifyUserID", AllWarehouseStructureViewFields.LastModifyUserID);
			this.Fields.Add("LastModifyDate", AllWarehouseStructureViewFields.LastModifyDate);
			this.Fields.Add("StructureRemark", AllWarehouseStructureViewFields.StructureRemark);
		}
	}

	#region AllWarehouseStructureViewFields

	public class AllWarehouseStructureViewFields
	{
		public static EntityField StructureID
		{
			get { return new EntityField("vw_AllWarehouseStructure", 0, "StructureID", SqlDbType.Int); }
		}

		public static EntityField WarehouseID
		{
			get { return new EntityField("vw_AllWarehouseStructure", 1, "WarehouseID", SqlDbType.Int); }
		}

		public static EntityField StructureCode
		{
			get { return new EntityField("vw_AllWarehouseStructure", 2, "StructureCode", SqlDbType.NVarChar); }
		}

		public static EntityField StructureCode2
		{
			get { return new EntityField("vw_AllWarehouseStructure", 3, "StructureCode2", SqlDbType.NVarChar); }
		}

		public static EntityField ParentStructureCode
		{
			get { return new EntityField("vw_AllWarehouseStructure", 4, "ParentStructureCode", SqlDbType.NVarChar); }
		}

		public static EntityField ParentStructureCode2
		{
			get { return new EntityField("vw_AllWarehouseStructure", 5, "ParentStructureCode2", SqlDbType.NVarChar); }
		}

		public static EntityField StructureName
		{
			get { return new EntityField("vw_AllWarehouseStructure", 6, "StructureName", SqlDbType.NVarChar); }
		}

		public static EntityField StructureType
		{
			get { return new EntityField("vw_AllWarehouseStructure", 7, "StructureType", SqlDbType.NVarChar); }
		}

		public static EntityField StructureLocation
		{
			get { return new EntityField("vw_AllWarehouseStructure", 8, "StructureLocation", SqlDbType.NVarChar); }
		}

		public static EntityField StructureLeader
		{
			get { return new EntityField("vw_AllWarehouseStructure", 9, "StructureLeader", SqlDbType.NVarChar); }
		}

		public static EntityField LeaderPhone
		{
			get { return new EntityField("vw_AllWarehouseStructure", 10, "LeaderPhone", SqlDbType.NVarChar); }
		}

		public static EntityField StructureSpace
		{
			get { return new EntityField("vw_AllWarehouseStructure", 11, "StructureSpace", SqlDbType.NVarChar); }
		}

		public static EntityField StructureVolume
		{
			get { return new EntityField("vw_AllWarehouseStructure", 12, "StructureVolume", SqlDbType.NVarChar); }
		}

		public static EntityField IsMinStructure
		{
			get { return new EntityField("vw_AllWarehouseStructure", 13, "IsMinStructure", SqlDbType.Bit); }
		}

		public static EntityField StructureBarCode
		{
			get { return new EntityField("vw_AllWarehouseStructure", 14, "StructureBarCode", SqlDbType.NVarChar); }
		}

		public static EntityField CreateUserID
		{
			get { return new EntityField("vw_AllWarehouseStructure", 15, "CreateUserID", SqlDbType.UniqueIdentifier); }
		}

		public static EntityField CreateDate
		{
			get { return new EntityField("vw_AllWarehouseStructure", 16, "CreateDate", SqlDbType.DateTime); }
		}

		public static EntityField LastModifyUserID
		{
			get { return new EntityField("vw_AllWarehouseStructure", 17, "LastModifyUserID", SqlDbType.UniqueIdentifier); }
		}

		public static EntityField LastModifyDate
		{
			get { return new EntityField("vw_AllWarehouseStructure", 18, "LastModifyDate", SqlDbType.DateTime); }
		}

		public static EntityField StructureRemark
		{
			get { return new EntityField("vw_AllWarehouseStructure", 19, "StructureRemark", SqlDbType.NVarChar); }
		}

	}

	#endregion

}
