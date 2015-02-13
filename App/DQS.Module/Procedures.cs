/*
 *	Build By: Codey Object Relation Mapping
 *	Build Data: 2013-07-19 19:48:09
 *	Build Type: Procedures
 *	Description: All method of procedures.
*/

using System;
using System.Data;
using System.Data.SqlClient;
using ORMSCore;

namespace DQS.Module
{
	public class Procedures
	{
		/// <summary>
		/// 存储过程：sp_Pagination
		/// </summary>
		public static DataSet Pagination(string pFields, string pViewName, string pPrimaryField, string pSortField, string pSortType, int pPageSize, int pPageIndex, string pFilter, ref int pPageCount, ref int pRecordCount)
		{
			SqlParameter param_Fields = new SqlParameter("@Fields", SqlDbType.VarChar) { Value = pFields };

			SqlParameter param_ViewName = new SqlParameter("@ViewName", SqlDbType.VarChar) { Value = pViewName };

			SqlParameter param_PrimaryField = new SqlParameter("@PrimaryField", SqlDbType.VarChar) { Value = pPrimaryField };

			SqlParameter param_SortField = new SqlParameter("@SortField", SqlDbType.VarChar) { Value = pSortField };

			SqlParameter param_SortType = new SqlParameter("@SortType", SqlDbType.VarChar) { Value = pSortType };

			SqlParameter param_PageSize = new SqlParameter("@PageSize", SqlDbType.Int) { Value = pPageSize };

			SqlParameter param_PageIndex = new SqlParameter("@PageIndex", SqlDbType.Int) { Value = pPageIndex };

			SqlParameter param_Filter = new SqlParameter("@Filter", SqlDbType.VarChar) { Value = pFilter };

			SqlParameter param_PageCount = new SqlParameter("@PageCount", SqlDbType.Int) { Value = pPageCount , Direction = ParameterDirection.Output};

			SqlParameter param_RecordCount = new SqlParameter("@RecordCount", SqlDbType.Int) { Value = pRecordCount , Direction = ParameterDirection.Output};

			DataSet result = ExecuteSQLProcedure.ExecuteReturnDataSet("sp_Pagination", param_Fields, param_ViewName, param_PrimaryField, param_SortField, param_SortType, param_PageSize, param_PageIndex, param_Filter, param_PageCount, param_RecordCount);

			pPageCount = (int)param_PageCount.Value;

			pRecordCount = (int)param_RecordCount.Value;

			return result;

		}

	}
}
