using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessEntity
{
    [Serializable]
    [DDLTable(name = "CLIENTES")]
    [DDLId(name = "id", nameProperty = "id", type = System.Data.SqlDbType.Int)]
    [DDLOrderBy(orderby = "apellido")]
    public class Cliente
    {
        int c_id;

        [DDLProperties(name = "id", isIdentity = false, type = System.Data.SqlDbType.Int)]
        public int id
        {
            get { return c_id; }
            set { c_id = value; }
        }
        
        long c_documento;

        [DDLProperties(name = "documento", isIdentity = false, type = System.Data.SqlDbType.BigInt)]
        public long documento
        {
            get { return c_documento; }
            set { c_documento = value; }
        }

        string c_apellido;

        [DDLProperties(name = "apellido", isIdentity = false, type = System.Data.SqlDbType.VarChar)]
        public string apellido
        {
            get { return c_apellido; }
            set { c_apellido = value; }
        }

        string c_nombre;

        [DDLProperties(name = "nombre", isIdentity = false, type = System.Data.SqlDbType.VarChar)]
        public string nombre
        {
            get { return c_nombre; }
            set { c_nombre = value; }
        }

        string c_telefono;

        [DDLProperties(name = "telefono", isIdentity = false, type = System.Data.SqlDbType.VarChar)]
        public string telefono
        {
            get { return c_telefono; }
            set { c_telefono = value; }
        }

        string c_mail;

        [DDLProperties(name = "mail", isIdentity = false, type = System.Data.SqlDbType.VarChar)]
        public string mail
        {
            get { return c_mail; }
            set { c_mail = value; }
        }

        string c_domicilio;

        [DDLProperties(name = "domicilio", isIdentity = false, type = System.Data.SqlDbType.VarChar)]
        public string domicilio
        {
            get { return c_domicilio; }
            set { c_domicilio = value; }
        }

        DateTime c_fechaNacimiento;

        [DDLProperties(name = "fecha_nacimiento", isIdentity = false, type = System.Data.SqlDbType.VarChar)]
        public DateTime fechaNacimiento
        {
            get { return c_fechaNacimiento; }
            set { c_fechaNacimiento = value; }
        }

        int c_campoBaja;
        [DDLProperties(name = "campo_baja", isIdentity = false, type = System.Data.SqlDbType.Int)]
        public int campoBaja
        {
            get { return c_campoBaja; }
            set { c_campoBaja = value; }
        }

    }
}
