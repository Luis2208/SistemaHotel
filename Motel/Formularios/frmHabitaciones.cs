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
using Motel.Datos;
using Motel.Conexion;

namespace Motel.Formularios
{
    public partial class frmHabitaciones : Form
    {



        public frmHabitaciones()
        {
            InitializeComponent();

        }
        public vhabitacion habitacionSeleccionada { get; set; }
        public vhabitacion habitacionActual { get; set; }
        Principal fra = new Principal();

        private String accion = "guardar";


        void inhabilitar()
        {
            txtBxID.Visible = false;
            cmbPiso.Enabled = false;
            txtNumero.Enabled = false;
            richTxtBxDescripcion.Enabled = false;
            richTxtBxCaracte.Enabled = false;
            txtBxPrecioDiario.Enabled = false;
            cboBxEstado.Enabled = false;
            cboBxHabitacion.Enabled = false;

            bttnGuardar.Enabled = false;
            bttnCancelar.Enabled = false;
            bttnBuscar.Enabled = false;
            bttnActualizar.Enabled = false;
            bttnEliminar.Enabled = false;

            //txtBxID.Text = "";
            //txtBxPrecioDiario.Text = "";
            //richTxtBxCaracte.Text = "";
            //richTxtBxDescripcion.Text = "";
            //txtNumero.Text = "";//de aquí hacia abajo se agregaron
            //cmbPiso.Text = "";
            //cboBxEstado.Text = "";
            //cboBxHabitacion.Text = "";
        }

        void habilitar()
        {
            txtBxID.Visible = false;
            cmbPiso.Enabled = true;
            txtNumero.Enabled = true;
            richTxtBxDescripcion.Enabled = true;
            richTxtBxCaracte.Enabled = true;
            txtBxPrecioDiario.Enabled = true;
            cboBxEstado.Enabled = true;
            cboBxHabitacion.Enabled = true;

            bttnGuardar.Enabled = true;
            bttnCancelar.Enabled = true;
            bttnBuscar.Enabled = true;
            bttnActualizar.Enabled = true;
            bttnEliminar.Enabled = true;


        }


        private void bttnNuevo_Click(object sender, EventArgs e)
        {
            //Conexion.Conexion.obtenerConexion();
            //MessageBox.Show("La conexion se realizó");
            habilitar();
            bttnGuardar.Text = "Guardar";
            accion = "guardar";
        }

        private void bttnGuardar_Click(object sender, EventArgs e)
        {
            if (txtNumero.Text.Length == 0)
            {
                MessageBox.Show("Debes ingresar un número de Habitación");
                txtNumero.Focus();
                return;
            }
            if (cmbPiso.Text.Length == 0)
            {
                MessageBox.Show("Debes ingresar Piso de Habitación");
                cmbPiso.Focus();
                return;
            }
            if (richTxtBxDescripcion.Text.Length == 0)
            {
                MessageBox.Show("Debes ingresar una descripción para la Habitación");
                richTxtBxDescripcion.Focus();
                return;
            }
            if (richTxtBxCaracte.Text.Length == 0)
            {
                MessageBox.Show("Debes ingresar una caracteristicas para la Habitación");
                richTxtBxCaracte.Focus();
                return;
            }
            if (txtBxPrecioDiario.Text.Length == 0)
            {
                MessageBox.Show("Debes ingresar un precio diario para la Habitación");
                txtBxPrecioDiario.Focus();
                return;
            }
            if (cboBxEstado.Text.Length == 0)
            {
                MessageBox.Show("Debes ingresar un Estado de la Habitación");
                cboBxEstado.Focus();
                return;
            }
            if (cboBxHabitacion.Text.Length == 0)
            {
                MessageBox.Show("Debes ingresar Categoria");
                cboBxHabitacion.Focus();
                return;
            }

            vhabitacion dts = new vhabitacion();
            dts.Numero = txtNumero.Text;
            dts.Piso = cmbPiso.SelectedItem.ToString();
            dts.Descripcion = richTxtBxDescripcion.Text;
            dts.Caracteristicas = richTxtBxCaracte.Text;
            dts.Precio_Diario = txtBxPrecioDiario.Text;
            dts.Estado = cboBxEstado.SelectedItem.ToString();
            dts.Tipo_Habitacion = cboBxHabitacion.SelectedItem.ToString();

            if (accion.Equals("guardar"))
            {
                int result = funcionHabitacion.agregar(dts);
                if (result > 0)
                {
                    MessageBox.Show("Habitacion Guardada con Exito!", "Guardado", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    txtBxID.Text = "";
                    txtBxPrecioDiario.Text = "";
                    richTxtBxCaracte.Text = "";
                    richTxtBxDescripcion.Text = "";
                    txtNumero.Text = "";
                    cmbPiso.SelectedIndex = 0;
                    cboBxEstado.SelectedIndex = 0;
                    cboBxHabitacion.SelectedIndex = 0;
                }
            }
            //else if (accion.Equals("editar"))
            //{
            //    dts.IdHabitación = int.Parse(txtBxID.Text);

            //    if()
            //}



            //if(result > 0)
            //{
            //   MessageBox.Show("Habitacion Guardada con Exito!", "Guardado", MessageBoxButtons.OK, MessageBoxIcon.Information);

            // }
            // else
            // {
            //     MessageBox.Show("No se agregó la habitacion");
            // }



        }

        private void frmHabitaciones_Load(object sender, EventArgs e)
        {
            inhabilitar();
        }

        private void bttnCancelar_Click(object sender, EventArgs e)
        {
            DialogResult res = MessageBox.Show("Desea dejar de registrar Habitaciones", "title", MessageBoxButtons.YesNo);
            if (res == DialogResult.Yes)
                this.Hide();
            fra.Show();

        }

        private void bttnBuscar_Click(object sender, EventArgs e)
        {
            frmRegistros m = new frmRegistros();
            m.ShowDialog();
            try
            {
                habitacionActual = m.habitacionSeleccionada;
                txtNumero.Text = m.habitacionSeleccionada.Numero;
                cmbPiso.Text = m.habitacionSeleccionada.Piso;
                richTxtBxDescripcion.Text = m.habitacionSeleccionada.Descripcion;
                richTxtBxCaracte.Text = m.habitacionSeleccionada.Caracteristicas;
                txtBxPrecioDiario.Text = m.habitacionSeleccionada.Precio_Diario;
                cboBxEstado.Text = m.habitacionSeleccionada.Estado;
                cboBxHabitacion.Text = m.habitacionSeleccionada.Tipo_Habitacion;
            }
            catch
            {

            }


            /*try
            {
                txtNumero.Text = m.habitacionSeleccionada.Numero;
                cmbPiso.Text = m.habitacionSeleccionada.Piso;
                richTxtBxDescripcion.Text = m.habitacionSeleccionada.Descripcion;
                richTxtBxCaracte.Text = m.habitacionSeleccionada.Caracteristicas;
                txtBxPrecioDiario.Text = m.habitacionSeleccionada.Precio_Diario;
                cboBxEstado.Text = m.habitacionSeleccionada.Estado;
                cboBxHabitacion.Text = m.habitacionSeleccionada.Tipo_Habitacion;
            }
            catch
            {

            }*/
        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void bttnActualizar_Click(object sender, EventArgs e)
        {
            vhabitacion v = new vhabitacion();
            v.Numero = txtNumero.Text;
            v.Piso = cmbPiso.Text;
            v.Descripcion = richTxtBxDescripcion.Text;
            v.Caracteristicas = richTxtBxCaracte.Text;
            v.Precio_Diario = txtBxPrecioDiario.Text;
            v.Estado = cboBxEstado.Text;
            v.Tipo_Habitacion = cboBxHabitacion.Text;
            v.IdHabitación = habitacionActual.IdHabitación;

            if (funcionHabitacion.Actualizar(v) > 0)
            {
                MessageBox.Show("Los datos de la habitacion se actualizaron", "Datos actualizados", MessageBoxButtons.OK, MessageBoxIcon.Information);
                txtBxID.Text = "";
                txtBxPrecioDiario.Text = "";
                richTxtBxCaracte.Text = "";
                richTxtBxDescripcion.Text = "";
                txtNumero.Text = "";
                cmbPiso.SelectedIndex = 0;
                cboBxEstado.SelectedIndex = 0;
                cboBxHabitacion.SelectedIndex = 0;
            }
            else
            {
                MessageBox.Show("No se pudo actualizar", "Error al actualizar", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
        }

        private void bttnEliminar_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("¿Está seguro que desea eliminar el registro de la tabla?", "Confirmar", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                if (funcionHabitacion.Eliminar(habitacionActual.IdHabitación) > 0)
                {
                    MessageBox.Show("Habitación Eliminada Correctamente", "Eliminado", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    txtBxID.Text = "";
                    txtBxPrecioDiario.Text = "";
                    richTxtBxCaracte.Text = "";
                    richTxtBxDescripcion.Text = "";
                    txtNumero.Text = "";
                    cmbPiso.SelectedIndex = 0;
                    cboBxEstado.SelectedIndex = 0;
                    cboBxHabitacion.SelectedIndex = 0;
                }
                else
                {
                    MessageBox.Show("No se pudo Eliminar correctamente", "Habitación no Eliminada", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                }
            }
        }

        private void txtNumero_KeyPress(object sender, KeyPressEventArgs e)
        {
            Validar.NumberOnly(e);
        }

        private void richTxtBxDescripcion_KeyPress(object sender, KeyPressEventArgs e)
        {
            Validar.LetrasOnly(e);
        }

        private void richTxtBxCaracte_KeyPress(object sender, KeyPressEventArgs e)
        {
            Validar.LetrasOnly(e);
        }

        private void txtBxPrecioDiario_KeyPress(object sender, KeyPressEventArgs e)
        {
            Validar.DecimalOnly(e);
        }
    }
}
