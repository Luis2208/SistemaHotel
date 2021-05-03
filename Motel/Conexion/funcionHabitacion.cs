using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Motel.Datos;
using MySql.Data.MySqlClient;
using System.Data;
using Motel.Formularios;

namespace Motel.Conexion
{
    class funcionHabitacion
    {

        public static int agregar(vhabitacion dts)
        {
            int retorno = 0;
            
            try
            {

                MySqlCommand comando = new MySqlCommand(string.Format("INSERT INTO habitación (numero,piso,descripcion,caracteristicas,precio_diario,estado,tipo_habitacion)" +
                    "values('{0}','{1}','{2}','{3}','{4}','{5}','{6}')", dts.Numero, dts.Piso, dts.Descripcion, dts.Caracteristicas, dts.Precio_Diario, dts.Estado, dts.Tipo_Habitacion), Conexion.obtenerConexion());
                retorno = comando.ExecuteNonQuery();
               
                

            }
            catch (MySqlException e)
            {
                System.Windows.Forms.MessageBox.Show("Error al insertar" + e);
            }
            return retorno;
        }

        public static List<vhabitacion> Buscar(String numero)
        {
            List<vhabitacion> lista = new List<vhabitacion>();
            try
            {
                MySqlCommand comando = new MySqlCommand(String.Format("SELECT idHabitación,numero,piso,descripcion,caracteristicas,precio_diario,estado,tipo_habitacion FROM habitación WHERE idHabitación ='{0}'",numero),Conexion.obtenerConexion());
                MySqlDataReader read = comando.ExecuteReader();
                while (read.Read())
                {
                    vhabitacion habitacion = new vhabitacion();
                    habitacion.IdHabitación = read.GetInt32(0);
                    habitacion.Numero = read.GetString(1);
                    habitacion.Piso = read.GetString(2);
                    habitacion.Descripcion = read.GetString(3);
                    habitacion.Caracteristicas = read.GetString(4);
                    habitacion.Precio_Diario = read.GetString(5);
                    habitacion.Estado = read.GetString(6);
                    habitacion.Tipo_Habitacion = read.GetString(7);

                    lista.Add(habitacion);
                }

            }
            catch(MySqlException E)
            {
                System.Windows.Forms.MessageBox.Show("Error al buscar" + E);
            }
            return lista;
        }

        public static vhabitacion obtenerHabitacion(int numero)
        {
            vhabitacion habita = new vhabitacion();
            MySqlConnection conexion = Conexion.obtenerConexion();

            MySqlCommand comando = new MySqlCommand(String.Format("SELECT idHabitación,numero,piso,descripcion,caracteristicas,precio_diario,estado,tipo_habitacion FROM habitación WHERE idHabitación= {0}", numero),conexion);
            MySqlDataReader read = comando.ExecuteReader();
            while (read.Read())
            {
                habita.IdHabitación = read.GetInt32(0);
                habita.Numero = read.GetString(1);
                habita.Piso = read.GetString(2);
                habita.Descripcion = read.GetString(3);
                habita.Caracteristicas = read.GetString(4);
                habita.Precio_Diario = read.GetString(5);
                habita.Estado = read.GetString(6);
                habita.Tipo_Habitacion = read.GetString(7);
            }
            conexion.Close();
            return habita;
        }


        public static int Actualizar(vhabitacion vHabita)
        {
            int retorno = 0;
            MySqlConnection conexion = Conexion.obtenerConexion();
            MySqlCommand comando = new MySqlCommand(string.Format("UPDATE habitación SET numero='{0}',piso='{1}',descripcion='{2}',caracteristicas='{3}',precio_diario='{4}',estado='{5}',tipo_habitacion='{6}' WHERE idHabitación={7}", vHabita.Numero,vHabita.Piso,vHabita.Descripcion,vHabita.Caracteristicas,vHabita.Precio_Diario,vHabita.Estado,vHabita.Tipo_Habitacion,vHabita.IdHabitación ),conexion);
            retorno = comando.ExecuteNonQuery();
            conexion.Close();
            return retorno;
        }

        public static int Eliminar(int PId)
        {

            int retorno = 0;
            MySqlConnection cone = Conexion.obtenerConexion();

            MySqlCommand comando = new MySqlCommand(string.Format("DELETE FROM habitación WHERE idHabitación={0}", PId), cone);

            retorno = comando.ExecuteNonQuery();
            cone.Close();
            return retorno;

        }

    }
}
