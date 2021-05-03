using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;

namespace Motel.Conexion
{
    class Conexion
    {
        
        public static MySqlConnection obtenerConexion()
        {
            MySqlConnection conexion = new MySqlConnection("server=127.0.0.1;database=basereserva;User Id=root;Password=");
            conexion.Open();
            return conexion;
        }
    }
}
