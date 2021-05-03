using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Motel.Datos
{
       public class vCliente : vPersona
    {
        private String codigo_cliente;

        public vCliente()
        {

        }
        public vCliente(String codigo_cliente)
        {
            this.codigo_cliente = codigo_cliente;

        }
       
        public String CODIGO_CLIENTE
        {
            get
            {
                return codigo_cliente;
            }
            set
            {
                codigo_cliente = value;
            }
        }
    }
}
