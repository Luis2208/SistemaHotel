using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Motel.Datos
{
   public  class vPersona
    {
        private int idPersona;
        private String nombre;
        private String apaterno;
        private String amaterno;
        private String tipo_documento;
        private String num_documento;
        private String direccion;
        private String telefono;
        private String email;
        



        public vPersona(int idPersona, string Nombre, string Aparterno, String Amaterno, String Tipo_documento, String Num_documento, String Direccion, String Telefono, String Email)
        {
            this.idPersona = idPersona;
            this.nombre = Nombre;
            this.apaterno = Aparterno;
            this.amaterno = Amaterno;
            this.tipo_documento = Tipo_documento;
            this.num_documento = Num_documento;
            this.direccion = Direccion;
            this.telefono = Telefono;
            this.email = Email;
           
        }

        public vPersona()
        {

        }


        public int IdPersona
        {
            get
            {
                return idPersona;
            }
            set
            {
                idPersona = value;
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

        public String APATERNO
        {
            get
            {
                return apaterno;
            }
            set
            {
                apaterno = value;
            }
        }

        public String AMATERNO
        {
            get
            {
                return amaterno;
            }
            set
            {
                amaterno = value;
            }
        }

        public String TIPO_DOCUMENTO
        {
            get
            {
                return tipo_documento;
            }
            set
            {
                tipo_documento = value;
            }
        }
        public String NUMERO_DOCUMENTO
        {
            get
            {
                return num_documento;
            }
            set
            {
                num_documento = value;
            }
        }
        public String DIRECCION
        {
            get
            {
                return direccion;
            }
            set
            {
                direccion = value;
            }
        }
        public String TELEFONO
        {
            get
            {
                return telefono;
            }
            set
            {
                telefono = value;
            }
        }
        public String EMAIL
        {
            get
            {
                return email;
            }
            set
            {
                email = value;
            }
        }
        
        }

    }

