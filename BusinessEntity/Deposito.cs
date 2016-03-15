using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessEntity
{
    [Serializable]
    [DDLTable(name = "DEPOSITOS")]
    [DDLId(name = "id", nameProperty = "id", type = System.Data.SqlDbType.Int)]
    [DDLOrderBy(orderby = "descripcion")]
    public class Deposito
    {
        int d_id;

        [DDLProperties(name = "ID", isIdentity = false, type = System.Data.SqlDbType.Int)]
        public int id
        {
            get { return d_id; }
            set { d_id = value; }
        }

        string d_descripcion;

        [DDLProperties(name = "DESCRIPCION", isIdentity = false, type = System.Data.SqlDbType.VarChar)]
        public string descripcion
        {
            get { return d_descripcion; }
            set { d_descripcion = value; }
        }

        int d_campoBaja;
        [DDLProperties(name = "campo_baja", isIdentity = false, type = System.Data.SqlDbType.Int)]
        public int campoBaja
        {
            get { return d_campoBaja; }
            set { d_campoBaja = value; }
        }
    }
}
