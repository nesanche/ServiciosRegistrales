using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessEntity
{
    [Serializable]
    [DDLTable(name = "STOCK_ARTICULOS")]
    [DDLId(name = "ID", nameProperty = "id", type = System.Data.SqlDbType.Int)]
    [DDLOrderBy(orderby = "id_articulo")]
    public class StockArticulo
    {
        int s_id;

        [DDLProperties(name = "ID", isIdentity = false, type = System.Data.SqlDbType.Int)]
        public int id
        {
            get { return s_id; }
            set { s_id = value; }
        }

        int s_idArticulo;

        [DDLProperties(name = "ID_ARTICULO", isIdentity = false, type = System.Data.SqlDbType.Int)]
        public int idArticulo
        {
            get { return s_idArticulo; }
            set { s_idArticulo = value; }
        }

        int s_idDeposito;

        [DDLProperties(name = "ID_DEPOSITO", isIdentity = false, type = System.Data.SqlDbType.Int)]
        public int idDeposito
        {
            get { return s_idDeposito; }
            set { s_idDeposito = value; }
        }

        int s_cantidad;

        [DDLProperties(name = "CANTIDAD", isIdentity = false, type = System.Data.SqlDbType.Int)]
        public int cantidad
        {
            get { return s_cantidad; }
            set { s_cantidad = value; }
        }
    }
}
