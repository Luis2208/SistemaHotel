using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Motel.Datos;
using MySql.Data.MySqlClient;
using Motel.Conexion;

namespace Motel.Formularios
{
    public partial class FrmClientes : Form
    {
        public FrmClientes()
        {
            InitializeComponent();
        }

        public vCliente ClienteSeleccionado { get; set; }


        private void VerContactos()
        {

            string consulta = "SELECT idPersona,nombre,apaterno,amaterno,tipo_documento, num_documento,direccion,telefono,email FROM persona";
            MySqlConnection conexion = Conexion.Conexion.obtenerConexion();
            MySqlDataAdapter mda = new MySqlDataAdapter(consulta, conexion);//conectar a la base de datos para hacer la consulta

            DataSet ds = new DataSet();
            mda.Fill(ds);
            dataGridView3.DataSource = ds.Tables[0];
            conexion.Close();

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void bttnBuscar_Click(object sender, EventArgs e)
        {
            dataGridView3.DataSource = funcionCliente.Buscar(txtBxBuscar.Text);
        }

        private void FrmClientes_Load(object sender, EventArgs e)
        {
            dataGridView3.Refresh();
            VerContactos();
        }

        private void bttnSalir_Click(object sender, EventArgs e)
        {
            this.Hide();
            FrmCliente b = new FrmCliente();
            b.ShowDialog();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if(dataGridView3.SelectedRows.Count == 1)
            {
                int numero = Convert.ToInt32(dataGridView3.CurrentRow.Cells[0].Value);
                ClienteSeleccionado = funcionCliente.obtenercliente(numero);
                this.Close();

            }
            else
            {
                MessageBox.Show("Debe seleccionar una fila");
            }
        }

        private void FrmClientes_FormClosed(object sender, FormClosedEventArgs e)
        {
            //Application.Exit();
        }
    }
}
