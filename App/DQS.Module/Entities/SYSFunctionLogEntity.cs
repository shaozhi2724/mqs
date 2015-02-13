/*
 *	Build By: Codey Object Relation Mapping
 *	Build Data: 2013-07-19 19:48:09
 *	Build Type: Entity
 *	Description: SYSFunctionLogEntity
*/

using System;
using System.Collections.Generic;
using System.Data;
using ORMSCore;

namespace DQS.Module.Entities
{
	public class SYSFunctionLogEntity : EntityBase
	{
		public int LogID
		{
			get { return (int)this.GetValue("LogID"); } 
			set { this.SetValue("LogID", value); } 
		}

		public string LogFrom
		{
			get { return (string)this.GetValue("LogFrom"); } 
			set { this.SetValue("LogFrom", value); } 
		}

		public string LogUser
		{
			get { return (string)this.GetValue("LogUser"); } 
			set { this.SetValue("LogUser", value); } 
		}

		public DateTime LogDate
		{
			get { return (DateTime)this.GetValue("LogDate"); } 
			set { this.SetValue("LogDate", value); } 
		}

		public string FunctionName
		{
			get { return (string)this.GetValue("FunctionName"); } 
			set { this.SetValue("FunctionName", value); } 
		}

		public string FunctionView
		{
			get { return (string)this.GetValue("FunctionView"); } 
			set { this.SetValue("FunctionView", value); } 
		}

		public string FunctionContent
		{
			get { return (string)this.GetValue("FunctionContent"); } 
			set { this.SetValue("FunctionContent", value); } 
		}

		public string FunctionPC
		{
			get { return (string)this.GetValue("FunctionPC"); } 
			set { this.SetValue("FunctionPC", value); } 
		}

		public string LogType
		{
			get { return (string)this.GetValue("LogType"); } 
			set { this.SetValue("LogType", value); } 
		}

		public string LogRemark
		{
			get { return (string)this.GetValue("LogRemark"); } 
			set { this.SetValue("LogRemark", value); } 
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

		public SYSFunctionLogEntity()
		{
			this.TableName = "SYS_FunctionLog";
			this.Fields = new Dictionary<string, EntityField>();
			this.Fields.Add("LogID", SYSFunctionLogEntityFields.LogID);
			this.Fields.Add("LogFrom", SYSFunctionLogEntityFields.LogFrom);
			this.Fields.Add("LogUser", SYSFunctionLogEntityFields.LogUser);
			this.Fields.Add("LogDate", SYSFunctionLogEntityFields.LogDate);
			this.Fields.Add("FunctionName", SYSFunctionLogEntityFields.FunctionName);
			this.Fields.Add("FunctionView", SYSFunctionLogEntityFields.FunctionView);
			this.Fields.Add("FunctionContent", SYSFunctionLogEntityFields.FunctionContent);
			this.Fields.Add("FunctionPC", SYSFunctionLogEntityFields.FunctionPC);
			this.Fields.Add("LogType", SYSFunctionLogEntityFields.LogType);
			this.Fields.Add("LogRemark", SYSFunctionLogEntityFields.LogRemark);
			this.Fields.Add("Reservation1", SYSFunctionLogEntityFields.Reservation1);
			this.Fields.Add("Reservation2", SYSFunctionLogEntityFields.Reservation2);
			this.Fields.Add("Reservation3", SYSFunctionLogEntityFields.Reservation3);
			this.Fields.Add("Reservation4", SYSFunctionLogEntityFields.Reservation4);
			this.Fields.Add("Reservation5", SYSFunctionLogEntityFields.Reservation5);
		}
	}

	#region SYSFunctionLogEntityFields

	public class SYSFunctionLogEntityFields
	{
		public static EntityField LogID
		{
			get { return new EntityField("SYS_FunctionLog", 0, "LogID", SqlDbType.Int, true, true, true, false); }
		}

		public static EntityField LogFrom
		{
			get { return new EntityField("SYS_FunctionLog", 1, "LogFrom", SqlDbType.NVarChar, false, false, false, false); }
		}

		public static EntityField LogUser
		{
			get { return new EntityField("SYS_FunctionLog", 2, "LogUser", SqlDbType.NVarChar, false, false, false, false); }
		}

		public static EntityField LogDate
		{
			get { return new EntityField("SYS_FunctionLog", 3, "LogDate", SqlDbType.DateTime, false, false, false, false); }
		}

		public static EntityField FunctionName
		{
			get { return new EntityField("SYS_FunctionLog", 4, "FunctionName", SqlDbType.NVarChar, false, false, false, false); }
		}

		public static EntityField FunctionView
		{
			get { return new EntityField("SYS_FunctionLog", 5, "FunctionView", SqlDbType.NVarChar, false, false, false, true); }
		}

		public static EntityField FunctionContent
		{
			get { return new EntityField("SYS_FunctionLog", 6, "FunctionContent", SqlDbType.NVarChar, false, false, false, false); }
		}

		public static EntityField FunctionPC
		{
			get { return new EntityField("SYS_FunctionLog", 7, "FunctionPC", SqlDbType.NVarChar, false, false, false, true); }
		}

		public static EntityField LogType
		{
			get { return new EntityField("SYS_FunctionLog", 8, "LogType", SqlDbType.NVarChar, false, false, false, false); }
		}

		public static EntityField LogRemark
		{
			get { return new EntityField("SYS_FunctionLog", 9, "LogRemark", SqlDbType.NVarChar, false, false, false, true); }
		}

		public static EntityField Reservation1
		{
			get { return new EntityField("SYS_FunctionLog", 10, "Reservation1", SqlDbType.NVarChar, false, false, false, true); }
		}

		public static EntityField Reservation2
		{
			get { return new EntityField("SYS_FunctionLog", 11, "Reservation2", SqlDbType.NVarChar, false, false, false, true); }
		}

		public static EntityField Reservation3
		{
			get { return new EntityField("SYS_FunctionLog", 12, "Reservation3", SqlDbType.NVarChar, false, false, false, true); }
		}

		public static EntityField Reservation4
		{
			get { return new EntityField("SYS_FunctionLog", 13, "Reservation4", SqlDbType.NVarChar, false, false, false, true); }
		}

		public static EntityField Reservation5
		{
			get { return new EntityField("SYS_FunctionLog", 14, "Reservation5", SqlDbType.NVarChar, false, false, false, true); }
		}

	}

	#endregion

	#region SYSFunctionLogEntityFields2

	public enum SYSFunctionLogEntityFields2
	{
		LogID,

		LogFrom,

		LogUser,

		LogDate,

		FunctionName,

		FunctionView,

		FunctionContent,

		FunctionPC,

		LogType,

		LogRemark,

		Reservation1,

		Reservation2,

		Reservation3,

		Reservation4,

		Reservation5,

	}

	#endregion

}
