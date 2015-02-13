using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;

namespace DQS.Controls
{
    public class ListDataRowItem
    {
        public DataRow Key { get; set; }

        public object Value { get; set; }

        public ListDataRowItem(DataRow key, object value)
        {
            this.Key = key;
            Value = value;
        }

        public override string ToString()
        {
            return this.Value.ToString();
        }
    }
}
