using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ASECS
{
    public class Conexion_BD
    {
        public MySqlConnection conexion;

        public void Crear_Conexion()
        {
            string connec = "Server=localhost;database=asecs;uid=root;pwd=cisco";
            conexion = new MySqlConnection(connec);
            conexion.Open();
        }

        public void Cerrar_Conexion()
        {
            conexion.Close();
        }

        public MySqlConnection Obtener_Conexion()
        {
            return conexion;
        }
    }
}
