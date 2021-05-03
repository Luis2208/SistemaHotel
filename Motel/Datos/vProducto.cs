using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;
using Motel.Conexion;

namespace Motel.Datos
{
     public class vProducto
    {

        private int idProducto;
        private String nombre;
        private String descripcion;
        private String unidad_medida;
        private String precio_venta;


        public vProducto(int idProducto, String nombre, String descripcion, String unidad_medida, String precio_venta)
        {
            this.idProducto = idProducto;
            this.nombre = nombre;
            this.descripcion = descripcion;
            this.unidad_medida = unidad_medida;
            this.precio_venta = precio_venta;


        }

        public vProducto()
        {

        }

        public int IdProducto
        {
            get
            {
                return idProducto;
            }
            set
            {
                idProducto = value;
            }
        }

        public String Nombre
        {
            get
            {
                return nombre;
            }
            set
            {
                nombre = value;
            }
        }

        public String Desripcion
        {
            get
            {
                return descripcion;
            }
            set
            {
                descripcion = value;
            }
        }

        public String Unidad_Medida
        {
            get
            {
                return unidad_medida;
            }
            set
            {
                unidad_medida = value;
            }
        }

        public String Precio_Venta
        {
            get
            {
                return precio_venta;
            }
            set
            {
                precio_venta = value;
            }
        }




    }
}
