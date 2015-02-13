/*
 *	Build By: Codey Object Relation Mapping
 *	Build Data: 2014-04-30 11:55:05
 *	Build Type: Entity
 *	Description: BFITransportCompanyEntity
*/

using System;
using System.Collections.Generic;
using System.Data;
using ORMSCore;

namespace DQS.Module.Entities
{
	public class BFITransportCompanyEntity : EntityBase
	{
		public int TransportCompanyID
		{
			get { return (int)this.GetValue("TransportCompanyID"); } 
			set { this.SetValue("TransportCompanyID", value); } 
		}

		public string TransportCompanyName
		{
			get { return (string)this.GetValue("TransportCompanyName"); } 
			set { this.SetValue("TransportCompanyName", value); } 
		}

		public BFITransportCompanyEntity()
		{
			this.TableName = "BFI_TransportCompany";
			this.Fields = new Dictionary<string, EntityField>();
			this.Fields.Add("TransportCompanyID", BFITransportCompanyEntityFields.TransportCompanyID);
			this.Fields.Add("TransportCompanyName", BFITransportCompanyEntityFields.TransportCompanyName);
		}
	}

	#region BFITransportCompanyEntityFields

	public class BFITransportCompanyEntityFields
	{
		public static EntityField TransportCompanyID
		{
			get { return new EntityField("BFI_TransportCompany", 0, "TransportCompanyID", SqlDbType.Int, true, true, true, false); }
		}

		public static EntityField TransportCompanyName
		{
			get { return new EntityField("BFI_TransportCompany", 1, "TransportCompanyName", SqlDbType.NVarChar, false, false, false, false); }
		}

	}

	#endregion

	#region BFITransportCompanyEntityFields2

	public enum BFITransportCompanyEntityFields2
	{
		TransportCompanyID,

		TransportCompanyName,

	}

	#endregion

}
