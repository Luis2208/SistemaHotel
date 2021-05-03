using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;
using Motel.Datos;

namespace Motel.Conexion
{
    class FuncionProducto
    {


        public static int agregar(vProducto pd)
        {
            int retorno = 0;

            try
            {

                MySqlCommand comando = new MySqlCommand(string.Format("INSERT INTO producto (nombre,descripcion,unidad_medida,precio_venta)" +
                    "values('{0}','{1}','{2}','{3}')", pd.Nombre, pd.Desripcion, pd.Unidad_Medida, pd.Precio_Venta), Conexion.obtenerConexion());
                retorno = comando.ExecuteNonQuery();



            }
            catch (MySqlException e)
            {
                System.Windows.Forms.MessageBox.Show("Error al insertar" + e);
            }
            return retorno;
        }

        public static List<vProducto> Buscar(String nombre)
        {
            List<vProducto> lista = new List<vProducto>();
            try
            {
                MySqlCommand comando = new MySqlCommand(String.Format("SELECT idProducto,nombre,descripcion,unidad_medida,precio_venta FROM producto WHERE idProducto ='{0}'", nombre), Conexion.obtenerConexion());
                MySqlDataReader read = comando.ExecuteReader();
                while (read.Read())
                {
                    vProducto produ = new vProducto();
                    produ.IdProducto = read.GetInt32(0);
                    produ.Nombre = read.GetString(1);
                    produ.Desripcion = read.GetString(2);
                    produ.Unidad_Medida = read.GetString(3);
                    produ.Precio_Venta = read.GetString(4);


                    lista.Add(produ);
                }

            }
            catch (MySqlException E)
            {
                System.Windows.Forms.MessageBox.Show("Error al buscar" + E);
            }
            return lista;
        }

        public static vProducto obtenerProducto(int numero)
        {
            vProducto produ = new vProducto();
            MySqlConnection conexion = Conexion.obtenerConexion();

            MySqlCommand comando = new MySqlCommand(String.Format("SELECT idProducto,nombre,descripcion,unidad_medida,precio_venta FROM producto WHERE idProducto= {0}", numero), conexion);
            MySqlDataReader read = comando.ExecuteReader();
            while (read.Read())
            {
                produ.IdProducto = read.GetInt32(0);
                produ.Nombre = read.GetString(1);
                produ.Desripcion = read.GetString(2);
                produ.Unidad_Medida = read.GetString(3);
                produ.Precio_Venta = read.GetString(4);

            }
            conexion.Close();
            return produ;
        }


        public static int Actualizar(vProducto vProdu)
        {
            int retorno = 0;
            MySqlConnection conexion = Conexion.obtenerConexion();
            MySqlCommand comando = new MySqlCommand(string.Format("UPDATE producto SET nombre='{0}',descripcion='{1}',unidad_medida='{2}',precio_venta='{3}' WHERE idProducto={4}", vProdu.Nombre, vProdu.Desripcion, vProdu.Unidad_Medida, vProdu.Precio_Venta, vProdu.IdProducto), conexion);
            retorno = comando.ExecuteNonQuery();
            conexion.Close();
            return retorno;
        }

        public static int Eliminar(int PId)
        {

            int retorno = 0;
            MySqlConnection cone = Conexion.obtenerConexion();

            MySqlCommand comando = new MySqlCommand(string.Format("DELETE FROM producto WHERE idProducto={0}", PId), cone);

            retorno = comando.ExecuteNonQuery();
            cone.Close();
            return retorno;

        }



    }
}
