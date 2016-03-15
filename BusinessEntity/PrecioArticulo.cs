using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace BusinessEntity
{
    [Serializable]
    [DDLTable(name = "PRECIOS_ARTICULOS")]
    [DDLId(name = "id", nameProperty = "id", type = System.Data.SqlDbType.Int)]
    [DDLOrderBy(orderby = "cod_articulo")]
    public class PrecioArticulo
    {
        int p_id;

        [DDLProperties(name = "id", isIdentity = false, type = System.Data.SqlDbType.Int)]
        public int id
        {
            get { return p_id; }
            set { p_id = value; }
        }

        string p_codArticulo;

        [DDLProperties(name = "cod_articulo", isIdentity = false, type = System.Data.SqlDbType.VarChar)]
        public string codArticulo
        {
            get { return p_codArticulo; }
            set { p_codArticulo = value; }
        }

        float p_lista1;

        [DDLProperties(name = "lista_1", isIdentity = false, type = System.Data.SqlDbType.Float)]
        public float lista1
        {
            get { return p_lista1; }
            set { p_lista1 = value; }
        }

        float p_lista2;

        [DDLProperties(name = "lista_2", isIdentity = false, type = System.Data.SqlDbType.Float)]
        public float lista2
        {
            get { return p_lista2; }
            set { p_lista2 = value; }
        }

        float p_lista3;

        [DDLProperties(name = "lista_3", isIdentity = false, type = System.Data.SqlDbType.Float)]
        public float lista3
        {
            get { return p_lista3; }
            set { p_lista3 = value; }
        }

        float p_lista4;

        [DDLProperties(name = "lista_4", isIdentity = false, type = System.Data.SqlDbType.Float)]
        public float lista4
        {
            get { return p_lista4; }
            set { p_lista4 = value; }
        }

        float p_lista5;

        [DDLProperties(name = "lista_5", isIdentity = false, type = System.Data.SqlDbType.Float)]
        public float lista5
        {
            get { return p_lista5; }
            set { p_lista5 = value; }
        }

        public float getPrecio(int lista)
        {
            switch(lista)
            {
                case 1: return lista1;
                case 2: return lista2;
                case 3: return lista3;
                case 4: return lista4;
                case 5: return lista5;
            }
            return 0;
        }
    }
}
