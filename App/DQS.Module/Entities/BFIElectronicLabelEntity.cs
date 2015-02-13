/*
 *	Build By: Codey Object Relation Mapping
 *	Build Data: 2013-07-19 19:48:09
 *	Build Type: Entity
 *	Description: BFIElectronicLabelEntity
*/

using System;
using System.Collections.Generic;
using System.Data;
using ORMSCore;

namespace DQS.Module.Entities
{
	public class BFIElectronicLabelEntity : EntityBase
	{
		public int LabelID
		{
			get { return (int)this.GetValue("LabelID"); } 
			set { this.SetValue("LabelID", value); } 
		}

		public string LabelCode
		{
			get { return (string)this.GetValue("LabelCode"); } 
			set { this.SetValue("LabelCode", value); } 
		}

		public string LabelName
		{
			get { return (string)this.GetValue("LabelName"); } 
			set { this.SetValue("LabelName", value); } 
		}

		public string LabelSpell
		{
			get { return (string)this.GetValue("LabelSpell"); } 
			set { this.SetValue("LabelSpell", value); } 
		}

		public string LabelType
		{
			get { return (string)this.GetValue("LabelType"); } 
			set { this.SetValue("LabelType", value); } 
		}

		public string LabelPortName
		{
			get { return (string)this.GetValue("LabelPortName"); } 
			set { this.SetValue("LabelPortName", value); } 
		}

		public string LabelAddress
		{
			get { return (string)this.GetValue("LabelAddress"); } 
			set { this.SetValue("LabelAddress", value); } 
		}

		public int ParentLabelID
		{
			get { return (int)this.GetValue("ParentLabelID"); } 
			set { this.SetValue("ParentLabelID", value); } 
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

		public string LabelRemark
		{
			get { return (string)this.GetValue("LabelRemark"); } 
			set { this.SetValue("LabelRemark", value); } 
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

		public BFIElectronicLabelEntity()
		{
			this.TableName = "BFI_ElectronicLabel";
			this.Fields = new Dictionary<string, EntityField>();
			this.Fields.Add("LabelID", BFIElectronicLabelEntityFields.LabelID);
			this.Fields.Add("LabelCode", BFIElectronicLabelEntityFields.LabelCode);
			this.Fields.Add("LabelName", BFIElectronicLabelEntityFields.LabelName);
			this.Fields.Add("LabelSpell", BFIElectronicLabelEntityFields.LabelSpell);
			this.Fields.Add("LabelType", BFIElectronicLabelEntityFields.LabelType);
			this.Fields.Add("LabelPortName", BFIElectronicLabelEntityFields.LabelPortName);
			this.Fields.Add("LabelAddress", BFIElectronicLabelEntityFields.LabelAddress);
			this.Fields.Add("ParentLabelID", BFIElectronicLabelEntityFields.ParentLabelID);
			this.Fields.Add("CreateUserID", BFIElectronicLabelEntityFields.CreateUserID);
			this.Fields.Add("CreateDate", BFIElectronicLabelEntityFields.CreateDate);
			this.Fields.Add("LastModifyUserID", BFIElectronicLabelEntityFields.LastModifyUserID);
			this.Fields.Add("LastModifyDate", BFIElectronicLabelEntityFields.LastModifyDate);
			this.Fields.Add("LabelRemark", BFIElectronicLabelEntityFields.LabelRemark);
			this.Fields.Add("Reservation1", BFIElectronicLabelEntityFields.Reservation1);
			this.Fields.Add("Reservation2", BFIElectronicLabelEntityFields.Reservation2);
			this.Fields.Add("Reservation3", BFIElectronicLabelEntityFields.Reservation3);
			this.Fields.Add("Reservation4", BFIElectronicLabelEntityFields.Reservation4);
			this.Fields.Add("Reservation5", BFIElectronicLabelEntityFields.Reservation5);
			this.Fields.Add("Reservation6", BFIElectronicLabelEntityFields.Reservation6);
			this.Fields.Add("Reservation7", BFIElectronicLabelEntityFields.Reservation7);
			this.Fields.Add("Reservation8", BFIElectronicLabelEntityFields.Reservation8);
			this.Fields.Add("Reservation9", BFIElectronicLabelEntityFields.Reservation9);
			this.Fields.Add("Reservation10", BFIElectronicLabelEntityFields.Reservation10);
		}
	}

	#region BFIElectronicLabelEntityFields

	public class BFIElectronicLabelEntityFields
	{
		public static EntityField LabelID
		{
			get { return new EntityField("BFI_ElectronicLabel", 0, "LabelID", SqlDbType.Int, true, true, true, false); }
		}

		public static EntityField LabelCode
		{
			get { return new EntityField("BFI_ElectronicLabel", 1, "LabelCode", SqlDbType.NVarChar, false, false, false, false); }
		}

		public static EntityField LabelName
		{
			get { return new EntityField("BFI_ElectronicLabel", 2, "LabelName", SqlDbType.NVarChar, false, false, false, false); }
		}

		public static EntityField LabelSpell
		{
			get { return new EntityField("BFI_ElectronicLabel", 3, "LabelSpell", SqlDbType.NVarChar, false, false, false, true); }
		}

		public static EntityField LabelType
		{
			get { return new EntityField("BFI_ElectronicLabel", 4, "LabelType", SqlDbType.NVarChar, false, false, false, true); }
		}

		public static EntityField LabelPortName
		{
			get { return new EntityField("BFI_ElectronicLabel", 5, "LabelPortName", SqlDbType.NVarChar, false, false, false, true); }
		}

		public static EntityField LabelAddress
		{
			get { return new EntityField("BFI_ElectronicLabel", 6, "LabelAddress", SqlDbType.NVarChar, false, false, false, true); }
		}

		public static EntityField ParentLabelID
		{
			get { return new EntityField("BFI_ElectronicLabel", 7, "ParentLabelID", SqlDbType.Int, false, false, false, true); }
		}

		public static EntityField CreateUserID
		{
			get { return new EntityField("BFI_ElectronicLabel", 8, "CreateUserID", SqlDbType.UniqueIdentifier, false, false, false, true); }
		}

		public static EntityField CreateDate
		{
			get { return new EntityField("BFI_ElectronicLabel", 9, "CreateDate", SqlDbType.DateTime, false, false, false, true); }
		}

		public static EntityField LastModifyUserID
		{
			get { return new EntityField("BFI_ElectronicLabel", 10, "LastModifyUserID", SqlDbType.UniqueIdentifier, false, false, false, true); }
		}

		public static EntityField LastModifyDate
		{
			get { return new EntityField("BFI_ElectronicLabel", 11, "LastModifyDate", SqlDbType.DateTime, false, false, false, true); }
		}

		public static EntityField LabelRemark
		{
			get { return new EntityField("BFI_ElectronicLabel", 12, "LabelRemark", SqlDbType.NVarChar, false, false, false, true); }
		}

		public static EntityField Reservation1
		{
			get { return new EntityField("BFI_ElectronicLabel", 13, "Reservation1", SqlDbType.NVarChar, false, false, false, true); }
		}

		public static EntityField Reservation2
		{
			get { return new EntityField("BFI_ElectronicLabel", 14, "Reservation2", SqlDbType.NVarChar, false, false, false, true); }
		}

		public static EntityField Reservation3
		{
			get { return new EntityField("BFI_ElectronicLabel", 15, "Reservation3", SqlDbType.NVarChar, false, false, false, true); }
		}

		public static EntityField Reservation4
		{
			get { return new EntityField("BFI_ElectronicLabel", 16, "Reservation4", SqlDbType.NVarChar, false, false, false, true); }
		}

		public static EntityField Reservation5
		{
			get { return new EntityField("BFI_ElectronicLabel", 17, "Reservation5", SqlDbType.NVarChar, false, false, false, true); }
		}

		public static EntityField Reservation6
		{
			get { return new EntityField("BFI_ElectronicLabel", 18, "Reservation6", SqlDbType.NVarChar, false, false, false, true); }
		}

		public static EntityField Reservation7
		{
			get { return new EntityField("BFI_ElectronicLabel", 19, "Reservation7", SqlDbType.NVarChar, false, false, false, true); }
		}

		public static EntityField Reservation8
		{
			get { return new EntityField("BFI_ElectronicLabel", 20, "Reservation8", SqlDbType.NVarChar, false, false, false, true); }
		}

		public static EntityField Reservation9
		{
			get { return new EntityField("BFI_ElectronicLabel", 21, "Reservation9", SqlDbType.NVarChar, false, false, false, true); }
		}

		public static EntityField Reservation10
		{
			get { return new EntityField("BFI_ElectronicLabel", 22, "Reservation10", SqlDbType.NVarChar, false, false, false, true); }
		}

	}

	#endregion

	#region BFIElectronicLabelEntityFields2

	public enum BFIElectronicLabelEntityFields2
	{
		LabelID,

		LabelCode,

		LabelName,

		LabelSpell,

		LabelType,

		LabelPortName,

		LabelAddress,

		ParentLabelID,

		CreateUserID,

		CreateDate,

		LastModifyUserID,

		LastModifyDate,

		LabelRemark,

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
