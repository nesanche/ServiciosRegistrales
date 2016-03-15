using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessEntity
{
    [Serializable]
    [DDLTable(name = "Personas")]
    [DDLId(name = "dni", nameProperty = "dni", type = System.Data.SqlDbType.BigInt)]
    [DDLOrderBy(orderby = "apellido")]
    public class Personas
    {
        long p_dni;

        [DDLProperties(name = "dni", isIdentity = false, type = System.Data.SqlDbType.BigInt)]
        public long dni
        {
            get { return p_dni; }
            set { p_dni = value; }
        }

        string p_apellido;

        [DDLProperties(name = "apellido", isIdentity = false, type = System.Data.SqlDbType.VarChar)]
        public string apellido
        {
            get { return p_apellido; }
            set { p_apellido = value; }
        }

        string p_nombre;

        [DDLProperties(name = "nombre", isIdentity = false, type = System.Data.SqlDbType.VarChar)]
        public string nombre
        {
            get { return p_nombre; }
            set { p_nombre = value; }
        }

        string p_nombrePadre;

        [DDLProperties(name = "nombrePadre", isIdentity = false, type = System.Data.SqlDbType.VarChar)]
        public string nombrePadre
        {
            get { return p_nombrePadre; }
            set { p_nombrePadre = value; }
        }

        string p_nombreMadre;

        [DDLProperties(name = "nombreMadre", isIdentity = false, type = System.Data.SqlDbType.VarChar)]
        public string nombreMadre
        {
            get { return p_nombreMadre; }
            set { p_nombreMadre = value; }
        }

        string p_domicilio;

        [DDLProperties(name = "domicilio", isIdentity = false, type = System.Data.SqlDbType.VarChar)]
        public string domicilio
        {
            get { return p_domicilio; }
            set { p_domicilio = value; }
        }

        string p_localidad;

        [DDLProperties(name = "localidad", isIdentity = false, type = System.Data.SqlDbType.VarChar)]
        public string localidad
        {
            get { return p_localidad; }
            set { p_localidad = value; }
        }

        string p_telefono;

        [DDLProperties(name = "telefono", isIdentity = false, type = System.Data.SqlDbType.VarChar)]
        public string telefono
        {
            get { return p_telefono; }
            set { p_telefono = value; }
        }

        string p_mail;

        [DDLProperties(name = "mail", isIdentity = false, type = System.Data.SqlDbType.VarChar)]
        public string mail
        {
            get { return p_mail; }
            set { p_mail = value; }
        }

    }
}
