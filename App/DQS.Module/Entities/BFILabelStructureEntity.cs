﻿/*
 *	Build By: Codey Object Relation Mapping
 *	Build Data: 2013-07-19 19:48:09
 *	Build Type: Entity
 *	Description: BFILabelStructureEntity
*/

using System;
using System.Collections.Generic;
using System.Data;
using ORMSCore;

namespace DQS.Module.Entities
{
	public class BFILabelStructureEntity : EntityBase
	{
		public int LabelID
		{
			get { return (int)this.GetValue("LabelID"); } 
			set { this.SetValue("LabelID", value); } 
		}

		public int StructureID
		{
			get { return (int)this.GetValue("StructureID"); } 
			set { this.SetValue("StructureID", value); } 
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

		public BFILabelStructureEntity()
		{
			this.TableName = "BFI_LabelStructure";
			this.Fields = new Dictionary<string, EntityField>();
			this.Fields.Add("LabelID", BFILabelStructureEntityFields.LabelID);
			this.Fields.Add("StructureID", BFILabelStructureEntityFields.StructureID);
			this.Fields.Add("CreateUserID", BFILabelStructureEntityFields.CreateUserID);
			this.Fields.Add("CreateDate", BFILabelStructureEntityFields.CreateDate);
			this.Fields.Add("Reservation1", BFILabelStructureEntityFields.Reservation1);
			this.Fields.Add("Reservation2", BFILabelStructureEntityFields.Reservation2);
			this.Fields.Add("Reservation3", BFILabelStructureEntityFields.Reservation3);
			this.Fields.Add("Reservation4", BFILabelStructureEntityFields.Reservation4);
			this.Fields.Add("Reservation5", BFILabelStructureEntityFields.Reservation5);
		}
	}

	#region BFILabelStructureEntityFields

	public class BFILabelStructureEntityFields
	{
		public static EntityField LabelID
		{
			get { return new EntityField("BFI_LabelStructure", 0, "LabelID", SqlDbType.Int, true, false, true, false); }
		}

		public static EntityField StructureID
		{
			get { return new EntityField("BFI_LabelStructure", 1, "StructureID", SqlDbType.Int, true, false, true, false); }
		}

		public static EntityField CreateUserID
		{
			get { return new EntityField("BFI_LabelStructure", 2, "CreateUserID", SqlDbType.UniqueIdentifier, false, false, false, true); }
		}

		public static EntityField CreateDate
		{
			get { return new EntityField("BFI_LabelStructure", 3, "CreateDate", SqlDbType.DateTime, false, false, false, true); }
		}

		public static EntityField Reservation1
		{
			get { return new EntityField("BFI_LabelStructure", 4, "Reservation1", SqlDbType.NVarChar, false, false, false, true); }
		}

		public static EntityField Reservation2
		{
			get { return new EntityField("BFI_LabelStructure", 5, "Reservation2", SqlDbType.NVarChar, false, false, false, true); }
		}

		public static EntityField Reservation3
		{
			get { return new EntityField("BFI_LabelStructure", 6, "Reservation3", SqlDbType.NVarChar, false, false, false, true); }
		}

		public static EntityField Reservation4
		{
			get { return new EntityField("BFI_LabelStructure", 7, "Reservation4", SqlDbType.NVarChar, false, false, false, true); }
		}

		public static EntityField Reservation5
		{
			get { return new EntityField("BFI_LabelStructure", 8, "Reservation5", SqlDbType.NVarChar, false, false, false, true); }
		}

	}

	#endregion

	#region BFILabelStructureEntityFields2

	public enum BFILabelStructureEntityFields2
	{
		LabelID,

		StructureID,

		CreateUserID,

		CreateDate,

		Reservation1,

		Reservation2,

		Reservation3,

		Reservation4,

		Reservation5,

	}

	#endregion

}
