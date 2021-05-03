using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data.MySqlClient;
using Motel.Conexion;
using Motel.Datos;


namespace Motel.Formularios
{
    public partial class frmProducto : Form
    {
        public frmProducto()
        {
            InitializeComponent();
        }

        public vProducto ProductoSeleccionado { get; set; }


        private void VerContactos()
        {

            string consulta = "SELECT idProducto,nombre,descripcion,unidad_medida,precio_venta FROM producto";
            MySqlConnection conexion = Conexion.Conexion.obtenerConexion();
            MySqlDataAdapter mda = new MySqlDataAdapter(consulta, conexion);//conectar a la base de datos para hacer la consulta

            DataSet ds = new DataSet();
            mda.Fill(ds);
            dataGridView1.DataSource = ds.Tables[0];
            conexion.Close();

        }

        private void frmProducto_Load(object sender, EventArgs e)
        {

            dataGridView1.Refresh();
            VerContactos();
        }

        private void bttnSalir_Click(object sender, EventArgs e)
        {
            this.Hide();
            frmRegistroProductos b = new frmRegistroProductos();
            b.ShowDialog();
            
        }

        private void bttnBuscar_Click(object sender, EventArgs e)
        {
            dataGridView1.DataSource = FuncionProducto.Buscar(txtBxBuscar.Text);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (dataGridView1.SelectedRows.Count == 1)
            {
                int numero = Convert.ToInt32(dataGridView1.CurrentRow.Cells[0].Value);
                ProductoSeleccionado = FuncionProducto.obtenerProducto(numero);
                this.Close();

            }
            else
            {
                MessageBox.Show("Debe seleccionar una fila");
            }
        }

        private void frmProducto_FormClosed(object sender, FormClosedEventArgs e)
        {
            //Application.Exit();
        }

    }
}
