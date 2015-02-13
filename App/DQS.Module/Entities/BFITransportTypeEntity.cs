/*
 *	Build By: Codey Object Relation Mapping
 *	Build Data: 2014-04-30 11:55:05
 *	Build Type: Entity
 *	Description: BFITransportTypeEntity
*/

using System;
using System.Collections.Generic;
using System.Data;
using ORMSCore;

namespace DQS.Module.Entities
{
	public class BFITransportTypeEntity : EntityBase
	{
		public int TransportTypeID
		{
			get { return (int)this.GetValue("TransportTypeID"); } 
			set { this.SetValue("TransportTypeID", value); } 
		}

		public string TransportTypeName
		{
			get { return (string)this.GetValue("TransportTypeName"); } 
			set { this.SetValue("TransportTypeName", value); } 
		}

		public BFITransportTypeEntity()
		{
			this.TableName = "BFI_TransportType";
			this.Fields = new Dictionary<string, EntityField>();
			this.Fields.Add("TransportTypeID", BFITransportTypeEntityFields.TransportTypeID);
			this.Fields.Add("TransportTypeName", BFITransportTypeEntityFields.TransportTypeName);
		}
	}

	#region BFITransportTypeEntityFields

	public class BFITransportTypeEntityFields
	{
		public static EntityField TransportTypeID
		{
			get { return new EntityField("BFI_TransportType", 0, "TransportTypeID", SqlDbType.Int, true, true, true, false); }
		}

		public static EntityField TransportTypeName
		{
			get { return new EntityField("BFI_TransportType", 1, "TransportTypeName", SqlDbType.NVarChar, false, false, false, false); }
		}

	}

	#endregion

	#region BFITransportTypeEntityFields2

	public enum BFITransportTypeEntityFields2
	{
		TransportTypeID,

		TransportTypeName,

	}

	#endregion

}
