/*
 *	Build By: Codey Object Relation Mapping
 *	Build Data: 2013-07-19 19:48:09
 *	Build Type: Entity
 *	Description: SYSConfigureEntity
*/

using System;
using System.Collections.Generic;
using System.Data;
using ORMSCore;

namespace DQS.Module.Entities
{
	public class SYSConfigureEntity : EntityBase
	{
		public int ConfigID
		{
			get { return (int)this.GetValue("ConfigID"); } 
			set { this.SetValue("ConfigID", value); } 
		}

		public string ConfigKey
		{
			get { return (string)this.GetValue("ConfigKey"); } 
			set { this.SetValue("ConfigKey", value); } 
		}

		public string ConfigValue
		{
			get { return (string)this.GetValue("ConfigValue"); } 
			set { this.SetValue("ConfigValue", value); } 
		}

		public string ConfigType
		{
			get { return (string)this.GetValue("ConfigType"); } 
			set { this.SetValue("ConfigType", value); } 
		}

		public string ConfigAttribute
		{
			get { return (string)this.GetValue("ConfigAttribute"); } 
			set { this.SetValue("ConfigAttribute", value); } 
		}

		public string ConfigApplication
		{
			get { return (string)this.GetValue("ConfigApplication"); } 
			set { this.SetValue("ConfigApplication", value); } 
		}

		public string ConfigRemark
		{
			get { return (string)this.GetValue("ConfigRemark"); } 
			set { this.SetValue("ConfigRemark", value); } 
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

		public SYSConfigureEntity()
		{
			this.TableName = "SYS_Configure";
			this.Fields = new Dictionary<string, EntityField>();
			this.Fields.Add("ConfigID", SYSConfigureEntityFields.ConfigID);
			this.Fields.Add("ConfigKey", SYSConfigureEntityFields.ConfigKey);
			this.Fields.Add("ConfigValue", SYSConfigureEntityFields.ConfigValue);
			this.Fields.Add("ConfigType", SYSConfigureEntityFields.ConfigType);
			this.Fields.Add("ConfigAttribute", SYSConfigureEntityFields.ConfigAttribute);
			this.Fields.Add("ConfigApplication", SYSConfigureEntityFields.ConfigApplication);
			this.Fields.Add("ConfigRemark", SYSConfigureEntityFields.ConfigRemark);
			this.Fields.Add("Reservation1", SYSConfigureEntityFields.Reservation1);
			this.Fields.Add("Reservation2", SYSConfigureEntityFields.Reservation2);
			this.Fields.Add("Reservation3", SYSConfigureEntityFields.Reservation3);
			this.Fields.Add("Reservation4", SYSConfigureEntityFields.Reservation4);
			this.Fields.Add("Reservation5", SYSConfigureEntityFields.Reservation5);
		}
	}

	#region SYSConfigureEntityFields

	public class SYSConfigureEntityFields
	{
		public static EntityField ConfigID
		{
			get { return new EntityField("SYS_Configure", 0, "ConfigID", SqlDbType.Int, true, true, true, false); }
		}

		public static EntityField ConfigKey
		{
			get { return new EntityField("SYS_Configure", 1, "ConfigKey", SqlDbType.NVarChar, false, false, true, false); }
		}

		public static EntityField ConfigValue
		{
			get { return new EntityField("SYS_Configure", 2, "ConfigValue", SqlDbType.NVarChar, false, false, false, false); }
		}

		public static EntityField ConfigType
		{
			get { return new EntityField("SYS_Configure", 3, "ConfigType", SqlDbType.NVarChar, false, false, false, false); }
		}

		public static EntityField ConfigAttribute
		{
			get { return new EntityField("SYS_Configure", 4, "ConfigAttribute", SqlDbType.NVarChar, false, false, false, true); }
		}

		public static EntityField ConfigApplication
		{
			get { return new EntityField("SYS_Configure", 5, "ConfigApplication", SqlDbType.NVarChar, false, false, false, true); }
		}

		public static EntityField ConfigRemark
		{
			get { return new EntityField("SYS_Configure", 6, "ConfigRemark", SqlDbType.NVarChar, false, false, false, true); }
		}

		public static EntityField Reservation1
		{
			get { return new EntityField("SYS_Configure", 7, "Reservation1", SqlDbType.NVarChar, false, false, false, true); }
		}

		public static EntityField Reservation2
		{
			get { return new EntityField("SYS_Configure", 8, "Reservation2", SqlDbType.NVarChar, false, false, false, true); }
		}

		public static EntityField Reservation3
		{
			get { return new EntityField("SYS_Configure", 9, "Reservation3", SqlDbType.NVarChar, false, false, false, true); }
		}

		public static EntityField Reservation4
		{
			get { return new EntityField("SYS_Configure", 10, "Reservation4", SqlDbType.NVarChar, false, false, false, true); }
		}

		public static EntityField Reservation5
		{
			get { return new EntityField("SYS_Configure", 11, "Reservation5", SqlDbType.NVarChar, false, false, false, true); }
		}

	}

	#endregion

	#region SYSConfigureEntityFields2

	public enum SYSConfigureEntityFields2
	{
		ConfigID,

		ConfigKey,

		ConfigValue,

		ConfigType,

		ConfigAttribute,

		ConfigApplication,

		ConfigRemark,

		Reservation1,

		Reservation2,

		Reservation3,

		Reservation4,

		Reservation5,

	}

	#endregion

}
