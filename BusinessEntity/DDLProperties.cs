using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace BusinessEntity
{
    [AttributeUsage(AttributeTargets.Property)]
    public class DDLProperties : System.Attribute
    {
        public string name;
        public System.Data.SqlDbType type;
        public bool isPk = false;
        public bool isIdentity = false;
        public bool insertable = true;
        public bool updatable = true;
    }
}
