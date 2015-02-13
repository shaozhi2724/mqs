using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;
using System.Runtime.Serialization;

namespace DQS.Controls
{
    public class DataEditTable:DataTable
    {
        public DataEditTable()
        {
           
        }
        public DataEditTable(string tableName)
            : base(tableName)
        {
            
        }
        public DataEditTable(string tableName, string tableNamespace)
            : base(tableName, tableNamespace)
        {
            
        }
        protected DataEditTable(System.Runtime.Serialization.SerializationInfo info, System.Runtime.Serialization.StreamingContext context)
            : base(info, context)
        {
            
        }

    }

    public class EditColumn : DataColumn
    {
        public EditColumn()
        {
            
        }
        public EditColumn(string columnName)
            : base(columnName)
        {
            
        }
        public EditColumn(string columnName, Type dataType)
            : base(columnName, dataType)
        {
            
        }
        public EditColumn(string columnName, Type dataType, string expr)
            : base(columnName, dataType, expr)
        {
            
        }
        public EditColumn(string columnName, Type dataType, string expr, MappingType type)
            : base(columnName, dataType, expr, type)
        {
            
        }

        
        
    }
}
