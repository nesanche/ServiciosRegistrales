using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessEntity
{
    [Serializable]
    [DDLTable(name = "DETALLE_VENTAS")]
    [DDLId(name = "id", nameProperty = "id", type = System.Data.SqlDbType.Int)]
    [DDLOrderBy(orderby = "id_venta")]
    public class DetalleVenta
    {
        int d_id;

        [DDLProperties(name = "ID", isIdentity = false, type = System.Data.SqlDbType.Int)]
        public int id
        {
            get { return d_id; }
            set { d_id = value; }
        }

        int d_idVenta;

        [DDLProperties(name = "ID_VENTA", isIdentity = false, type = System.Data.SqlDbType.Int)]
        public int idVenta
        {
            get { return d_idVenta; }
            set { d_idVenta = value; }
        }

        int d_idArticulo;

        [DDLProperties(name = "ID_ARTICULO", isIdentity = false, type = System.Data.SqlDbType.Int)]
        public int idArticulo
        {
            get { return d_idArticulo; }
            set { d_idArticulo = value; }
        }

        int d_cantidad;

        [DDLProperties(name = "CANTIDAD", isIdentity = false, type = System.Data.SqlDbType.Int)]
        public int cantidad
        {
            get { return d_cantidad; }
            set { d_cantidad = value; }
        }

        float d_precioUnitario;

        [DDLProperties(name = "PRECIO_UNITARIO", isIdentity = false, type = System.Data.SqlDbType.Float)]
        public float precioUnitario
        {
            get { return d_precioUnitario; }
            set { d_precioUnitario = value; }
        }

        float d_importe;

        [DDLProperties(name = "IMPORTE", isIdentity = false, type = System.Data.SqlDbType.Float)]
        public float importe
        {
            get { return d_importe; }
            set { d_importe = value; }
        }

        int d_lista;

        [DDLProperties(name = "LISTA", isIdentity = false, type = System.Data.SqlDbType.Int)]
        public int lista
        {
            get { return d_lista; }
            set { d_lista = value; }
        }

        long d_codDesde;

        [DDLProperties(name = "COD_DESDE", isIdentity = false, type = System.Data.SqlDbType.BigInt)]
        public long codDesde
        {
            get { return d_codDesde; }
            set { d_codDesde = value; }
        }

        long d_codHasta;

        [DDLProperties(name = "COD_HASTA", isIdentity = false, type = System.Data.SqlDbType.BigInt)]
        public long codHasta
        {
            get { return d_codHasta; }
            set { d_codHasta = value; }
        }

    }
}
