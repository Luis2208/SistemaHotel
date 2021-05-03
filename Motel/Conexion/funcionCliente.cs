using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;
using Motel.Datos;

namespace Motel.Conexion
{
    class funcionCliente
    {
        public static int agregar(vCliente cl)
        {
       

        int retorno = 0;

            try
            {

                MySqlCommand comando = new MySqlCommand(string.Format("INSERT INTO persona (nombre,apaterno,amaterno,tipo_documento,num_documento,direccion,telefono,email)" +
                    "values('{0}','{1}','{2}','{3}','{4}','{5}','{6}','{7}')", cl.Nombre, cl.APATERNO, cl.AMATERNO, cl.TIPO_DOCUMENTO,cl.NUMERO_DOCUMENTO,cl.DIRECCION,cl.TELEFONO,cl.EMAIL), Conexion.obtenerConexion());
                retorno = comando.ExecuteNonQuery();



            }
            catch (MySqlException e)
            {
                System.Windows.Forms.MessageBox.Show("Error al insertar" + e);
            }
            return retorno;
        }


        public static List<vCliente> Buscar(String nombre)
        {
            List<vCliente> lista = new List<vCliente>();
            try
            {
                MySqlCommand comando = new MySqlCommand(String.Format("SELECT idPersona,nombre,apaterno,amaterno,tipo_documento,num_documento,direccion,telefono,email FROM persona WHERE idPersona ='{0}'", nombre), Conexion.obtenerConexion());
                MySqlDataReader read = comando.ExecuteReader();
                while (read.Read())
                {
                    vCliente client = new vCliente();
                    client.IdPersona = read.GetInt32(0);
                    client.Nombre = read.GetString(1);
                    client.APATERNO = read.GetString(2);
                    client.AMATERNO = read.GetString(3);
                    client.TIPO_DOCUMENTO = read.GetString(4);
                    client.NUMERO_DOCUMENTO = read.GetString(5);
                    client.DIRECCION = read.GetString(6);
                    client.TELEFONO = read.GetString(7);
                    client.EMAIL = read.GetString(8);
         
                    lista.Add(client);
                    

                }

            }
            catch (MySqlException E)
            {
                System.Windows.Forms.MessageBox.Show("Error al buscar" + E);
            }
            return lista;
        }

        public static vCliente obtenercliente(int numero)
        {
            vCliente client = new vCliente();
            MySqlConnection conexion = Conexion.obtenerConexion();

            MySqlCommand comando = new MySqlCommand(String.Format("SELECT idPersona,nombre,apaterno,amaterno,tipo_documento,num_documento,direccion,telefono,email FROM persona WHERE idPersona= {0}", numero), conexion);
            MySqlDataReader read = comando.ExecuteReader();
            while (read.Read())
            {
                client.IdPersona = read.GetInt32(0);
                client.Nombre = read.GetString(1);
                client.APATERNO = read.GetString(2);
                client.AMATERNO = read.GetString(3);
                client.TIPO_DOCUMENTO = read.GetString(4);
                client.NUMERO_DOCUMENTO = read.GetString(5);
                client.DIRECCION = read.GetString(6);
                client.TELEFONO = read.GetString(7);
                client.EMAIL = read.GetString(8);
            }
            conexion.Close();
            return client;
        }


        public static int Actualizar(vCliente vCli)
        {
            int retorno = 0;
            MySqlConnection conexion = Conexion.obtenerConexion();
            MySqlCommand comando = new MySqlCommand(string.Format("UPDATE persona SET nombre='{0}',apaterno='{1}',amaterno='{2}',tipo_documento='{3}',num_documento='{4}',direccion='{5}', telefono='{6}',email='{7}' WHERE idPersona={8}", vCli.Nombre, vCli.APATERNO, vCli.AMATERNO, vCli.TIPO_DOCUMENTO, vCli.NUMERO_DOCUMENTO ,vCli.DIRECCION, vCli.TELEFONO, vCli.EMAIL,vCli.IdPersona), conexion);
            retorno = comando.ExecuteNonQuery();
            conexion.Close();
            return retorno;
        }

        public static int Eliminar(int idP)
        {

            int retorno = 0;
            MySqlConnection cone = Conexion.obtenerConexion();

            MySqlCommand comando = new MySqlCommand(string.Format("DELETE FROM persona WHERE idPersona={0}", idP), cone);

            retorno = comando.ExecuteNonQuery();
            cone.Close();
            return retorno;

        }
    }
}
