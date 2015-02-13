/*
 *	Build By: Codey Object Relation Mapping
 *	Build Data: 2014-05-02 16:08:07
 *	Build Type: Entity
 *	Description: BFITransportToolEntity
*/

using System;
using System.Collections.Generic;
using System.Data;
using ORMSCore;

namespace DQS.Module.Entities
{
	public class BFITransportToolEntity : EntityBase
	{
		public int TransportToolID
		{
			get { return (int)this.GetValue("TransportToolID"); } 
			set { this.SetValue("TransportToolID", value); } 
		}

		public string TransportToolName
		{
			get { return (string)this.GetValue("TransportToolName"); } 
			set { this.SetValue("TransportToolName", value); } 
		}

		public BFITransportToolEntity()
		{
			this.TableName = "BFI_TransportTool";
			this.Fields = new Dictionary<string, EntityField>();
			this.Fields.Add("TransportToolID", BFITransportToolEntityFields.TransportToolID);
			this.Fields.Add("TransportToolName", BFITransportToolEntityFields.TransportToolName);
		}
	}

	#region BFITransportToolEntityFields

	public class BFITransportToolEntityFields
	{
		public static EntityField TransportToolID
		{
			get { return new EntityField("BFI_TransportTool", 0, "TransportToolID", SqlDbType.Int, true, true, true, false); }
		}

		public static EntityField TransportToolName
		{
			get { return new EntityField("BFI_TransportTool", 1, "TransportToolName", SqlDbType.NVarChar, false, false, false, false); }
		}

	}

	#endregion

	#region BFITransportToolEntityFields2

	public enum BFITransportToolEntityFields2
	{
		TransportToolID,

		TransportToolName,

	}

	#endregion

}
