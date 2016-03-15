using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessEntity
{
    [Serializable]
    [DDLTable(name = "PROVEEDORES")]
    [DDLId(name = "id", nameProperty = "id", type = System.Data.SqlDbType.Int)]
    [DDLOrderBy(orderby = "razon_social")]
    public class Proveedor
    {
        int p_id;

        [DDLProperties(name = "ID", isIdentity = false, type = System.Data.SqlDbType.Int)]
        public int id
        {
            get { return p_id; }
            set { p_id = value; }
        }

        string p_razonSocial;

        [DDLProperties(name = "RAZON_SOCIAL", isIdentity = false, type = System.Data.SqlDbType.VarChar)]
        public string razonSocial
        {
            get { return p_razonSocial; }
            set { p_razonSocial = value; }
        }

        string p_domicilio;

        [DDLProperties(name = "DOMICILIO", isIdentity = false, type = System.Data.SqlDbType.VarChar)]
        public string domicilio
        {
            get { return p_domicilio; }
            set { p_domicilio = value; }
        }

        string p_telefono;

        [DDLProperties(name = "TELEFONO", isIdentity = false, type = System.Data.SqlDbType.VarChar)]
        public string telefono
        {
            get { return p_telefono; }
            set { p_telefono = value; }
        }

        string p_mail;

        [DDLProperties(name = "MAIL", isIdentity = false, type = System.Data.SqlDbType.VarChar)]
        public string mail
        {
            get { return p_mail; }
            set { p_mail = value; }
        }

        string p_url;

        [DDLProperties(name = "URL", isIdentity = false, type = System.Data.SqlDbType.VarChar)]
        public string url
        {
            get { return p_url; }
            set { p_url = value; }
        }

        string p_cuit;

        [DDLProperties(name = "CUIT", isIdentity = false, type = System.Data.SqlDbType.VarChar)]
        public string cuit
        {
            get { return p_cuit; }
            set { p_cuit = value; }
        }

        string p_contacto;
 
        [DDLProperties(name = "contacto", isIdentity = false, type = System.Data.SqlDbType.VarChar)]
        public string contacto
        {
            get { return p_contacto; }
            set { p_contacto = value; }
        }

        string p_comentarios;

        [DDLProperties(name = "comentarios", isIdentity = false, type = System.Data.SqlDbType.VarChar)]
        public string comentarios
        {
            get { return p_comentarios; }
            set { p_comentarios = value; }
        }

        string p_tipoProveedor;

        [DDLProperties(name = "tipo_proveedor", isIdentity = false, type = System.Data.SqlDbType.VarChar)]
        public string tipoProveedor
        {
            get { return p_tipoProveedor; }
            set { p_tipoProveedor = value; }
        }

        int p_campoBaja;
        [DDLProperties(name = "campo_baja", isIdentity = false, type = System.Data.SqlDbType.Int)]
        public int campoBaja
        {
            get { return p_campoBaja; }
            set { p_campoBaja = value; }
        }
    }
}
