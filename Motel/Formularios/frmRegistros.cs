using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Motel.Conexion;
using MySql.Data.MySqlClient;
using Motel.Datos;

namespace Motel.Formularios
{
    public partial class frmRegistros : Form
    {
        public frmRegistros()
        {
            InitializeComponent();
        }

        public vhabitacion habitacionSeleccionada { get; set; }

        private void VerContactos()
        {

            string consulta = "SELECT idHabitación,numero,piso,descripcion,caracteristicas,precio_diario,estado,tipo_habitacion FROM habitación";
            MySqlConnection conexion = Conexion.Conexion.obtenerConexion();
            MySqlDataAdapter mda = new MySqlDataAdapter(consulta, conexion);//conectar a la base de datos para hacer la consulta

            DataSet ds = new DataSet();
            mda.Fill(ds);
            dataGridView1.DataSource = ds.Tables[0];
            conexion.Close();

        }
        private void frmRegistros_Load(object sender, EventArgs e)
        {
            dataGridView1.Refresh();
            VerContactos();
        }

        private void bttnSalir_Click(object sender, EventArgs e)
        {
            this.Hide();
            frmHabitaciones b = new frmHabitaciones();
            b.ShowDialog();
       
        }

        private void bttnBuscar_Click(object sender, EventArgs e)
        {
            dataGridView1.DataSource = funcionHabitacion.Buscar(txtBxBuscar.Text);

        }

        private void bttnAceptar_Click(object sender, EventArgs e)
        {
            if(dataGridView1.SelectedRows.Count == 1)
            {
                int numero = Convert.ToInt32(dataGridView1.CurrentRow.Cells[0].Value);
                habitacionSeleccionada = funcionHabitacion.obtenerHabitacion(numero);
                this.Close();

            }
            else
            {
                MessageBox.Show("Debe seleccionar una fila");
            }
        }

        private void frmRegistros_FormClosed(object sender, FormClosedEventArgs e)
        {
            //Application.Exit();
        }

        
    }
}
