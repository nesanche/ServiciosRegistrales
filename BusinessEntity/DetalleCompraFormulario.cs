using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace BusinessEntity
{
    [Serializable]
    [DDLTable(name = "DETALLE_COMPRAS_FORM")]
    [DDLId(name = "id", nameProperty = "id", type = System.Data.SqlDbType.Int)]
    [DDLOrderBy(orderby = "id_compra")]
    public class DetalleCompraFormulario
    {
        int d_id;

        [DDLProperties(name = "ID", isIdentity = false, type = System.Data.SqlDbType.Int)]
        public int id
        {
            get { return d_id; }
            set { d_id = value; }
        }

        int d_idCompra;

        [DDLProperties(name = "ID_COMPRA", isIdentity = false, type = System.Data.SqlDbType.Int)]
        public int idCompra
        {
            get { return d_idCompra; }
            set { d_idCompra = value; }
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

        long d_codInicial;

        [DDLProperties(name = "COD_INICIAL", isIdentity = false, type = System.Data.SqlDbType.BigInt)]
        public long codInicial
        {
            get { return d_codInicial; }
            set { d_codInicial = value; }
        }

        long d_codFinal;

        [DDLProperties(name = "COD_FINAL", isIdentity = false, type = System.Data.SqlDbType.BigInt)]
        public long codFinal
        {
            get { return d_codFinal; }
            set { d_codFinal = value; }
        }


    }
}
