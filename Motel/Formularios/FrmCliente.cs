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
using Motel.Conexion;


namespace Motel.Formularios
{
    public partial class FrmCliente : Form
    {
        public FrmCliente()
        {
            InitializeComponent();
            inhabilitar();
        }
        public vCliente ClienteSeleccionado { get; set; }
        public vCliente ClienteActual { get; set; }
        Principal fra = new Principal();
        private String accion = "guardar";

        void inhabilitar()
        {
            txtBxIDCliente.Visible = false;
            txtNombreCliente.Enabled = false;
            txtAPaternoCliente.Enabled = false;
            txtAMaternoCliente.Enabled = false;
            cboBxTipoDocCliente.Enabled = false;
            txtNumDocCliente.Enabled = false;
            txtBxDireccionCliente.Enabled = false;
            txtBxTelCliente.Enabled = false;
            txtBxEmailCliente.Enabled = false;

            bttnGuardarCliente.Enabled = false;
            bttnCancelarCliente.Enabled = false;
            bttnBuscarCliente.Enabled = false;
            bttnActualizarCliente.Enabled = false;
            bttnEliminar.Enabled = false;
        }

        void habilitar()
        {
            txtBxIDCliente.Visible = false;
            txtNombreCliente.Enabled = true;
            txtAPaternoCliente.Enabled = true;
            txtAMaternoCliente.Enabled = true;
            cboBxTipoDocCliente.Enabled = true;
            txtNumDocCliente.Enabled = true;
            txtBxDireccionCliente.Enabled = true;
            txtBxTelCliente.Enabled = true;
            txtBxEmailCliente.Enabled = true;

            bttnGuardarCliente.Enabled = true;
            bttnCancelarCliente.Enabled = true;
            bttnBuscarCliente.Enabled = true;
            bttnActualizarCliente.Enabled = true;
            bttnEliminar.Enabled = true;
        }


        private void bttnNuevo_Click(object sender, EventArgs e)
        {
            habilitar();
            bttnGuardarCliente.Text = "Guardar";
            accion = "guardar";
        }

        private void bttnGuardarCliente_Click(object sender, EventArgs e)
        {
            if (txtNombreCliente.Text.Length == 0)
            {
                MessageBox.Show("Debes ingresar un Nombre al cliente");
                txtNombreCliente.Focus();
                return;
            }
            if (txtAPaternoCliente.Text.Length == 0)
            {
                MessageBox.Show("Debes ingresarun Apelido Paterno");
                txtAPaternoCliente.Focus();
                return;
            }
            if (txtAMaternoCliente.Text.Length == 0)
            {
                MessageBox.Show("Debes ingresarun Apelido Materno");
                txtAMaternoCliente.Focus();
                return;
            }

            if (cboBxTipoDocCliente.Text.Length == 0)
            {
                MessageBox.Show("Debes ingresar un tipo de documentacion");
                cboBxTipoDocCliente.Focus();
                return;
            }
            if (txtNumDocCliente.Text.Length == 0)
            {
                MessageBox.Show("Debes ingresar el numero de documentos del clinete");
                txtNumDocCliente.Focus();
                return;
            }
            if (txtBxDireccionCliente.Text.Length == 0)
            {
                MessageBox.Show("Debes ingresar la direccion del cliente");
                txtBxDireccionCliente.Focus();
                return;
            }
            if (txtBxTelCliente.Text.Length == 0)
            {
                MessageBox.Show("Debes ingresar el telefono del cliente");
                txtBxTelCliente.Focus();
                return;
            }
            if (txtBxEmailCliente.Text.Length == 0)
            {
                MessageBox.Show("Debes ingresar el email del cliente");
                txtBxEmailCliente.Focus();
                return;
            }

            vCliente dts = new vCliente();
            dts.Nombre = txtNombreCliente.Text;
            dts.APATERNO = txtAPaternoCliente.Text;
            dts.AMATERNO = txtAMaternoCliente.Text;
            dts.TIPO_DOCUMENTO = cboBxTipoDocCliente.SelectedItem.ToString();
            dts.NUMERO_DOCUMENTO = txtNumDocCliente.Text;
            dts.DIRECCION = txtBxDireccionCliente.Text;
            dts.TELEFONO = txtBxTelCliente.Text;
            dts.EMAIL = txtBxEmailCliente.Text;



            if (accion.Equals("guardar"))
            {
                int result = funcionCliente.agregar(dts);
                if (result > 0)
                {
                    MessageBox.Show("Cliente Guardado con Exito!", "Guardado", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    txtBxIDCliente.Text = "";
                    txtNombreCliente.Text = "";
                    txtAPaternoCliente.Text = "";
                    txtAMaternoCliente.Text = "";
                    cboBxTipoDocCliente.SelectedIndex = 0;
                    txtNumDocCliente.Text = "";
                    txtBxDireccionCliente.Text = "";
                    txtBxTelCliente.Text = "";
                    txtBxEmailCliente.Text = "";
                }
            }
        }

        private void FrmCliente_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }

        private void bttnCancelarCliente_Click(object sender, EventArgs e)
        {
            DialogResult res = MessageBox.Show("Desea dejar de registrar Productos", "title", MessageBoxButtons.YesNo);
            if (res == DialogResult.Yes)
                this.Hide();
            fra.Show();
        }

        private void bttnBuscarCliente_Click(object sender, EventArgs e)
        {
            FrmClientes m = new FrmClientes();
            m.ShowDialog();
            try
            {
                ClienteActual = m.ClienteSeleccionado;
                txtNombreCliente.Text = m.ClienteSeleccionado.Nombre;
                txtAPaternoCliente.Text = m.ClienteSeleccionado.APATERNO;
                txtAMaternoCliente.Text = m.ClienteSeleccionado.AMATERNO;
                cboBxTipoDocCliente.Text = m.ClienteSeleccionado.TIPO_DOCUMENTO;
                txtNumDocCliente.Text = m.ClienteSeleccionado.NUMERO_DOCUMENTO;
                txtBxDireccionCliente.Text = m.ClienteSeleccionado.DIRECCION;
                txtBxTelCliente.Text = m.ClienteSeleccionado.TELEFONO;
                txtBxEmailCliente.Text = m.ClienteSeleccionado.EMAIL;

            }
            catch
            {

            }
        }

        private void bttnActualizarCliente_Click(object sender, EventArgs e)
        {
            vCliente v = new vCliente();
            v.Nombre = txtNombreCliente.Text;
            v.APATERNO = txtAPaternoCliente.Text;
            v.AMATERNO = txtAMaternoCliente.Text;
            v.TIPO_DOCUMENTO = cboBxTipoDocCliente.Text;
            v.NUMERO_DOCUMENTO = txtNumDocCliente.Text;
            v.DIRECCION = txtBxDireccionCliente.Text;
            v.TELEFONO = txtBxTelCliente.Text;
            v.EMAIL = txtBxEmailCliente.Text;
            v.IdPersona = ClienteActual.IdPersona;

            if (funcionCliente.Actualizar(v) > 0)
            {
                MessageBox.Show("Los datos deL cliente se actualizaron", "Datos actualizados", MessageBoxButtons.OK, MessageBoxIcon.Information);
                txtNombreCliente.Text = "";
                txtAPaternoCliente.Text = "";
                txtAMaternoCliente.Text = "";
                cboBxTipoDocCliente.SelectedIndex = 0;
                txtNumDocCliente.Text = "";
                txtBxDireccionCliente.Text = "";
                txtBxTelCliente.Text = "";
                txtBxEmailCliente.Text = "";
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
                if (funcionCliente.Eliminar(ClienteActual.IdPersona) > 0)
                {
                    MessageBox.Show("Cliente Eliminado Correctamente", "Eliminado", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    txtNombreCliente.Text = "";
                    txtAPaternoCliente.Text = "";
                    txtAMaternoCliente.Text = "";
                    cboBxTipoDocCliente.SelectedIndex = 0;
                    txtNumDocCliente.Text = "";
                    txtBxDireccionCliente.Text = "";
                    txtBxTelCliente.Text = "";
                    txtBxEmailCliente.Text = "";
                }
                else
                {
                    MessageBox.Show("No se pudo Eliminar correctamente", "Cliente no Eliminado", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                }
            }
        }

        private void txtNombreCliente_KeyPress(object sender, KeyPressEventArgs e)
        {
            Validar.LetrasOnly(e);
        }

        private void txtAPaternoCliente_KeyPress(object sender, KeyPressEventArgs e)
        {
            Validar.LetrasOnly(e);
        }

        private void txtAMaternoCliente_KeyPress(object sender, KeyPressEventArgs e)
        {
            Validar.LetrasOnly(e);
        }

        private void txtNumDocCliente_KeyPress(object sender, KeyPressEventArgs e)
        {
            Validar.NumberOnly(e);
        }

        private void txtBxTelCliente_KeyPress(object sender, KeyPressEventArgs e)
        {
            Validar.NumberOnly(e);
        }
    }
}
