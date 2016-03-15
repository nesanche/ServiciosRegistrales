using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace BusinessEntity
{
    [AttributeUsage(AttributeTargets.Class, AllowMultiple = false)]
    public class DDLOrderBy : System.Attribute
    {
        public string orderby;
    }
}
