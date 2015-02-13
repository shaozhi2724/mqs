/*
 *	Build By: Codey Object Relation Mapping
 *	Build Data: 2014-10-14 13:59:30
 *	Build Type: Entity
 *	Description: ATCUserAreaEntity
*/

using System;
using System.Collections.Generic;
using System.Data;
using ORMSCore;

namespace DQS.Module.Entities
{
	public class ATCUserAreaEntity : EntityBase
	{
		public long UserAreaID
		{
			get { return (long)this.GetValue("UserAreaID"); } 
			set { this.SetValue("UserAreaID", value); } 
		}

		public Guid UserID
		{
			get { return (Guid)this.GetValue("UserID"); } 
			set { this.SetValue("UserID", value); } 
		}

		public string UserName
		{
			get { return (string)this.GetValue("UserName"); } 
			set { this.SetValue("UserName", value); } 
		}

		public string AreaName
		{
			get { return (string)this.GetValue("AreaName"); } 
			set { this.SetValue("AreaName", value); } 
		}

		public ATCUserAreaEntity()
		{
			this.TableName = "ATC_UserArea";
			this.Fields = new Dictionary<string, EntityField>();
			this.Fields.Add("UserAreaID", ATCUserAreaEntityFields.UserAreaID);
			this.Fields.Add("UserID", ATCUserAreaEntityFields.UserID);
			this.Fields.Add("UserName", ATCUserAreaEntityFields.UserName);
			this.Fields.Add("AreaName", ATCUserAreaEntityFields.AreaName);
		}
	}

	#region ATCUserAreaEntityFields

	public class ATCUserAreaEntityFields
	{
		public static EntityField UserAreaID
		{
			get { return new EntityField("ATC_UserArea", 0, "UserAreaID", SqlDbType.BigInt, true, true, true, false); }
		}

		public static EntityField UserID
		{
			get { return new EntityField("ATC_UserArea", 1, "UserID", SqlDbType.UniqueIdentifier, false, false, false, false); }
		}

		public static EntityField UserName
		{
			get { return new EntityField("ATC_UserArea", 2, "UserName", SqlDbType.NVarChar, false, false, false, false); }
		}

		public static EntityField AreaName
		{
			get { return new EntityField("ATC_UserArea", 3, "AreaName", SqlDbType.NVarChar, false, false, false, false); }
		}

	}

	#endregion

	#region ATCUserAreaEntityFields2

	public enum ATCUserAreaEntityFields2
	{
		UserAreaID,

		UserID,

		UserName,

		AreaName,

	}

	#endregion

}
