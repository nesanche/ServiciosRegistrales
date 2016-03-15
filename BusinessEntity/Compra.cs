using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessEntity
{
    [Serializable]
    [DDLTable(name = "COMPRAS")]
    [DDLId(name = "id", nameProperty = "id", type = System.Data.SqlDbType.Int)]
    [DDLOrderBy(orderby = "fecha DESC")]
    public class Compra
    {
        int c_id;

        [DDLProperties(name = "ID", isIdentity = false, type = System.Data.SqlDbType.Int)]
        public int id
        {
            get { return c_id; }
            set { c_id = value; }
        }

        int c_idProveedor;

        [DDLProperties(name = "ID_PROVEEDOR", isIdentity = false, type = System.Data.SqlDbType.Int)]
        public int idProveedor
        {
            get { return c_idProveedor; }
            set { c_idProveedor = value; }
        }

        DateTime c_fecha;

        [DDLProperties(name = "FECHA", isIdentity = false, type = System.Data.SqlDbType.Date)]
        public DateTime fecha
        {
            get { return c_fecha; }
            set { c_fecha = value; }
        }

        float c_importe;

        [DDLProperties(name = "IMPORTE", isIdentity = false, type = System.Data.SqlDbType.Float)]
        public float importe
        {
            get { return c_importe; }
            set { c_importe = value; }
        }

        float c_gastosExtra;

        [DDLProperties(name = "GASTOS_EXTRA", isIdentity = false, type = System.Data.SqlDbType.Float)]
        public float gastosExtra
        {
            get { return c_gastosExtra; }
            set { c_gastosExtra = value; }
        }

        string c_descripcion;

        [DDLProperties(name = "DESCRIPCION", isIdentity = false, type = System.Data.SqlDbType.VarChar)]
        public string descripcion
        {
            get { return c_descripcion; }
            set { c_descripcion = value; }
        }

        string c_nroFactura;

        [DDLProperties(name = "NRO_FACTURA", isIdentity = false, type = System.Data.SqlDbType.VarChar)]
        public string nroFactura
        {
            get { return c_nroFactura; }
            set { c_nroFactura = value; }
        }
    }
}
