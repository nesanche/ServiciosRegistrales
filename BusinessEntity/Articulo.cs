using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessEntity
{
    [Serializable]
    [DDLTable(name = "ARTICULOS")]
    [DDLId(name = "ID", nameProperty = "id", type = System.Data.SqlDbType.Int)]
    [DDLOrderBy(orderby = "codigo")]
    public class Articulo
    {
        int a_id;

        [DDLProperties(name = "ID", isIdentity = false, type = System.Data.SqlDbType.Int)]
        public int id
        {
            get { return a_id; }
            set { a_id = value; }
        }

        string a_codigo;

        [DDLProperties(name = "codigo", isIdentity = false, type = System.Data.SqlDbType.VarChar)]
        public string codigo
        {
            get { return a_codigo; }
            set { a_codigo = value; }
        }

        string a_descripcion;

        [DDLProperties(name = "DESCRIPCION", isIdentity = false, type = System.Data.SqlDbType.VarChar)]
        public string descripcion
        {
            get { return a_descripcion; }
            set { a_descripcion = value; }
        }

        int a_esFormulario;

        [DDLProperties(name = "ES_FORMULARIO", isIdentity = false, type = System.Data.SqlDbType.Int)]
        public int esFormulario
        {
            get { return a_esFormulario; }
            set { a_esFormulario = value; }
        }

        int a_campoBaja;
        [DDLProperties(name = "campo_baja", isIdentity = false, type = System.Data.SqlDbType.Int)]
        public int campoBaja
        {
            get { return a_campoBaja; }
            set { a_campoBaja = value; }
        }
    }
}
