using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Motel.Datos
{
    public class vhabitacion
    {
        private int idHabitación;
        private String numero;
        private String piso;
        private String descripcion;
        private String caracteristicas;
        private String precio_diario;
        private String estado;
        private String tipo_habitacion;


        public vhabitacion(int idHabitación, String numero, String piso, String descripcion, String caracteristicas, String precio_diario, String estado, String tipo_habitacion)
        {
            this.idHabitación = idHabitación;
            this.numero = numero;
            this.piso = piso;
            this.descripcion = descripcion;
            this.caracteristicas = caracteristicas;
            this.precio_diario = precio_diario;
            this.estado = estado;
            this.tipo_habitacion = tipo_habitacion;
        }

        public vhabitacion()
        {

        }

        public int IdHabitación
        {
            get
            {
                return idHabitación;
            }
            set
            {
                idHabitación = value;
            }
        }

        public String Numero
        {
            get
            {
                return numero;
            }
            set
            {
                numero = value;
            }
        }

        public String Piso
        {
            get
            {
                return piso;
            }
            set
            {
                piso = value;
            }
        }

        public String Descripcion
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

        public String Caracteristicas
        {
            get
            {
                return caracteristicas;
            }
            set
            {
                caracteristicas = value;
            }
        }

        public String Precio_Diario
        {
            get
            {
                return precio_diario;
            }
            set
            {
                precio_diario = value;
            }
        }

        public String Estado
        {
            get
            {
                return estado;
            }
            set
            {
                estado = value;
            }
        }

        public String Tipo_Habitacion
        {
            get
            {
                return  tipo_habitacion;
            }
            set
            {
                tipo_habitacion = value;
            }
        }
    }
}
