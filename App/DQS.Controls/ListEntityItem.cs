using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using ORMSCore;

namespace DQS.Controls
{
    public class ListEntityItem
    {
        public EntityBase Key { get; set; }

        public object Value { get; set; }

        public ListEntityItem(EntityBase key, object value)
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
