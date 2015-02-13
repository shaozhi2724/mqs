/*
 *	Build By: Codey Object Relation Mapping
 *	Build Data: 2014-06-12 17:07:50
 *	Build Type: Entity
 *	Description: ATCAntiApproveDetailEntity
*/

using System;
using System.Collections.Generic;
using System.Data;
using ORMSCore;

namespace DQS.Module.Entities
{
	public class ATCAntiApproveDetailEntity : EntityBase
	{
		public int DetailID
		{
			get { return (int)this.GetValue("DetailID"); } 
			set { this.SetValue("DetailID", value); } 
		}

		public Guid AntiApproveID
		{
			get { return (Guid)this.GetValue("AntiApproveID"); } 
			set { this.SetValue("AntiApproveID", value); } 
		}

		public string FieldName
		{
			get { return (string)this.GetValue("FieldName"); } 
			set { this.SetValue("FieldName", value); } 
		}

		public string DisplayText
		{
			get { return (string)this.GetValue("DisplayText"); } 
			set { this.SetValue("DisplayText", value); } 
		}

		public string FieldType
		{
			get { return (string)this.GetValue("FieldType"); } 
			set { this.SetValue("FieldType", value); } 
		}

		public string ControlName
		{
			get { return (string)this.GetValue("ControlName"); } 
			set { this.SetValue("ControlName", value); } 
		}

		public string OldValue
		{
			get { return (string)this.GetValue("OldValue"); } 
			set { this.SetValue("OldValue", value); } 
		}

		public string NewValue
		{
			get { return (string)this.GetValue("NewValue"); } 
			set { this.SetValue("NewValue", value); } 
		}

		public ATCAntiApproveDetailEntity()
		{
			this.TableName = "ATC_AntiApproveDetail";
			this.Fields = new Dictionary<string, EntityField>();
			this.Fields.Add("DetailID", ATCAntiApproveDetailEntityFields.DetailID);
			this.Fields.Add("AntiApproveID", ATCAntiApproveDetailEntityFields.AntiApproveID);
			this.Fields.Add("FieldName", ATCAntiApproveDetailEntityFields.FieldName);
			this.Fields.Add("DisplayText", ATCAntiApproveDetailEntityFields.DisplayText);
			this.Fields.Add("FieldType", ATCAntiApproveDetailEntityFields.FieldType);
			this.Fields.Add("ControlName", ATCAntiApproveDetailEntityFields.ControlName);
			this.Fields.Add("OldValue", ATCAntiApproveDetailEntityFields.OldValue);
			this.Fields.Add("NewValue", ATCAntiApproveDetailEntityFields.NewValue);
		}
	}

	#region ATCAntiApproveDetailEntityFields

	public class ATCAntiApproveDetailEntityFields
	{
		public static EntityField DetailID
		{
			get { return new EntityField("ATC_AntiApproveDetail", 0, "DetailID", SqlDbType.Int, true, true, true, false); }
		}

		public static EntityField AntiApproveID
		{
			get { return new EntityField("ATC_AntiApproveDetail", 1, "AntiApproveID", SqlDbType.UniqueIdentifier, false, false, false, false); }
		}

		public static EntityField FieldName
		{
			get { return new EntityField("ATC_AntiApproveDetail", 2, "FieldName", SqlDbType.NVarChar, false, false, false, false); }
		}

		public static EntityField DisplayText
		{
			get { return new EntityField("ATC_AntiApproveDetail", 3, "DisplayText", SqlDbType.NVarChar, false, false, false, false); }
		}

		public static EntityField FieldType
		{
			get { return new EntityField("ATC_AntiApproveDetail", 4, "FieldType", SqlDbType.NVarChar, false, false, false, false); }
		}

		public static EntityField ControlName
		{
			get { return new EntityField("ATC_AntiApproveDetail", 5, "ControlName", SqlDbType.NVarChar, false, false, false, false); }
		}

		public static EntityField OldValue
		{
			get { return new EntityField("ATC_AntiApproveDetail", 6, "OldValue", SqlDbType.NVarChar, false, false, false, false); }
		}

		public static EntityField NewValue
		{
			get { return new EntityField("ATC_AntiApproveDetail", 7, "NewValue", SqlDbType.NVarChar, false, false, false, false); }
		}

	}

	#endregion

	#region ATCAntiApproveDetailEntityFields2

	public enum ATCAntiApproveDetailEntityFields2
	{
		DetailID,

		AntiApproveID,

		FieldName,

		DisplayText,

		FieldType,

		ControlName,

		OldValue,

		NewValue,

	}

	#endregion

}
