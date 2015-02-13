/*
 *	Build By: Codey Object Relation Mapping
 *	Build Data: 2014-04-28 15:12:54
 *	Build Type: Entity
 *	Description: BFIEnterpriseAddressEntity
*/

using System;
using System.Collections.Generic;
using System.Data;
using ORMSCore;

namespace DQS.Module.Entities
{
	public class BFIEnterpriseAddressEntity : EntityBase
	{
		public int EnterpriseAddressID
		{
			get { return (int)this.GetValue("EnterpriseAddressID"); } 
			set { this.SetValue("EnterpriseAddressID", value); } 
		}

		public string EnterpriseAddressType
		{
			get { return (string)this.GetValue("EnterpriseAddressType"); } 
			set { this.SetValue("EnterpriseAddressType", value); } 
		}

		public string EnterpriseAddress
		{
			get { return (string)this.GetValue("EnterpriseAddress"); } 
			set { this.SetValue("EnterpriseAddress", value); } 
		}

		public BFIEnterpriseAddressEntity()
		{
			this.TableName = "BFI_EnterpriseAddress";
			this.Fields = new Dictionary<string, EntityField>();
			this.Fields.Add("EnterpriseAddressID", BFIEnterpriseAddressEntityFields.EnterpriseAddressID);
			this.Fields.Add("EnterpriseAddressType", BFIEnterpriseAddressEntityFields.EnterpriseAddressType);
			this.Fields.Add("EnterpriseAddress", BFIEnterpriseAddressEntityFields.EnterpriseAddress);
		}
	}

	#region BFIEnterpriseAddressEntityFields

	public class BFIEnterpriseAddressEntityFields
	{
		public static EntityField EnterpriseAddressID
		{
			get { return new EntityField("BFI_EnterpriseAddress", 0, "EnterpriseAddressID", SqlDbType.Int, true, true, true, false); }
		}

		public static EntityField EnterpriseAddressType
		{
			get { return new EntityField("BFI_EnterpriseAddress", 1, "EnterpriseAddressType", SqlDbType.NVarChar, false, false, false, false); }
		}

		public static EntityField EnterpriseAddress
		{
			get { return new EntityField("BFI_EnterpriseAddress", 2, "EnterpriseAddress", SqlDbType.NVarChar, false, false, false, false); }
		}

	}

	#endregion

	#region BFIEnterpriseAddressEntityFields2

	public enum BFIEnterpriseAddressEntityFields2
	{
		EnterpriseAddressID,

		EnterpriseAddressType,

		EnterpriseAddress,

	}

	#endregion

}
