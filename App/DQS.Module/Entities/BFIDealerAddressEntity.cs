/*
 *	Build By: Codey Object Relation Mapping
 *	Build Data: 2014-04-29 14:51:25
 *	Build Type: Entity
 *	Description: BFIDealerAddressEntity
*/

using System;
using System.Collections.Generic;
using System.Data;
using ORMSCore;

namespace DQS.Module.Entities
{
	public class BFIDealerAddressEntity : EntityBase
	{
		public int DealerAddressID
		{
			get { return (int)this.GetValue("DealerAddressID"); } 
			set { this.SetValue("DealerAddressID", value); } 
		}

		public int DealerID
		{
			get { return (int)this.GetValue("DealerID"); } 
			set { this.SetValue("DealerID", value); } 
		}

		public string DealerAddressType
		{
			get { return (string)this.GetValue("DealerAddressType"); } 
			set { this.SetValue("DealerAddressType", value); } 
		}

		public string DealerAddress
		{
			get { return (string)this.GetValue("DealerAddress"); } 
			set { this.SetValue("DealerAddress", value); } 
		}

		public BFIDealerAddressEntity()
		{
			this.TableName = "BFI_DealerAddress";
			this.Fields = new Dictionary<string, EntityField>();
			this.Fields.Add("DealerAddressID", BFIDealerAddressEntityFields.DealerAddressID);
			this.Fields.Add("DealerID", BFIDealerAddressEntityFields.DealerID);
			this.Fields.Add("DealerAddressType", BFIDealerAddressEntityFields.DealerAddressType);
			this.Fields.Add("DealerAddress", BFIDealerAddressEntityFields.DealerAddress);
		}
	}

	#region BFIDealerAddressEntityFields

	public class BFIDealerAddressEntityFields
	{
		public static EntityField DealerAddressID
		{
			get { return new EntityField("BFI_DealerAddress", 0, "DealerAddressID", SqlDbType.Int, true, true, true, false); }
		}

		public static EntityField DealerID
		{
			get { return new EntityField("BFI_DealerAddress", 1, "DealerID", SqlDbType.Int, false, false, false, false); }
		}

		public static EntityField DealerAddressType
		{
			get { return new EntityField("BFI_DealerAddress", 2, "DealerAddressType", SqlDbType.NVarChar, false, false, false, false); }
		}

		public static EntityField DealerAddress
		{
			get { return new EntityField("BFI_DealerAddress", 3, "DealerAddress", SqlDbType.NVarChar, false, false, false, false); }
		}

	}

	#endregion

	#region BFIDealerAddressEntityFields2

	public enum BFIDealerAddressEntityFields2
	{
		DealerAddressID,

		DealerID,

		DealerAddressType,

		DealerAddress,

	}

	#endregion

}
