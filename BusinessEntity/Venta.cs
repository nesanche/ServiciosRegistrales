using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessEntity
{
    [Serializable]
    [DDLTable(name = "VENTAS")]
    [DDLId(name = "id", nameProperty = "id", type = System.Data.SqlDbType.Int)]
    [DDLOrderBy(orderby = "fecha DESC")]
    public class Venta
    {
        int v_id;

        [DDLProperties(name = "ID", isIdentity = false, type = System.Data.SqlDbType.Int)]
        public int id
        {
            get { return v_id; }
            set { v_id = value; }
        }

        DateTime v_fecha;

        [DDLProperties(name = "FECHA", isIdentity = false, type = System.Data.SqlDbType.Date)]
        public DateTime fecha
        {
            get { return v_fecha; }
            set { v_fecha = value; }
        }

        float v_importe;

        [DDLProperties(name = "IMPORTE", isIdentity = false, type = System.Data.SqlDbType.Float)]
        public float importe
        {
            get { return v_importe; }
            set { v_importe = value; }
        }

        string v_descripcion;

        [DDLProperties(name = "DESCRIPCION", isIdentity = false, type = System.Data.SqlDbType.VarChar)]
        public string descripcion
        {
            get { return v_descripcion; }
            set { v_descripcion = value; }
        }

        int v_idCliente;

        [DDLProperties(name = "ID_CLIENTE", isIdentity = false, type = System.Data.SqlDbType.Int)]
        public int idCliente
        {
            get { return v_idCliente; }
            set { v_idCliente = value; }
        }
    }
}
