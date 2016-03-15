using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace BusinessEntity
{
    [AttributeUsage(AttributeTargets.All, AllowMultiple = true)]
    
    public class DDLId : System.Attribute
    {
        public string name;
        public string nameProperty;       
        public System.Data.SqlDbType type;
    }
}
