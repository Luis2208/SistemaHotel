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
    public partial class frmRegistroProductos : Form
    {
        public frmRegistroProductos()
        {
            InitializeComponent();
        }

        public vProducto ProductoSeleccionado { get; set; }
        public vProducto ProductoActual { get; set; }
        Principal fra = new Principal();

        private String accion = "guardar";


        void inhabilitar()
        {
            txtBxID.Visible = false;
            cboBxUnidad.Enabled = false;
            txtNombre.Enabled = false;
            richTxtBxDescripcion.Enabled = false;
            txtBxPrecioVenta.Enabled = false;

            bttnGuardar.Enabled = false;
            bttnCancelar.Enabled = false;
            bttnBuscar.Enabled = false;
            bttnActualizar.Enabled = false;
            bttnEliminar.Enabled = false;
        }

        void habilitar()
        {
            txtBxID.Visible = false;
            cboBxUnidad.Enabled = true;
            txtNombre.Enabled = true;
            richTxtBxDescripcion.Enabled = true;
            txtBxPrecioVenta.Enabled = true;


            bttnGuardar.Enabled = true;
            bttnCancelar.Enabled = true;
            bttnBuscar.Enabled = true;
            bttnActualizar.Enabled = true;
            bttnEliminar.Enabled = true;
        }

        private void bttnNuevo_Click(object sender, EventArgs e)
        {
            habilitar();
            bttnGuardar.Text = "Guardar";
            accion = "guardar";
        }

        private void bttnGuardar_Click(object sender, EventArgs e)
        {
            if (txtNombre.Text.Length == 0)
            {
                MessageBox.Show("Debes ingresar un Nombre al producto");
                txtNombre.Focus();
                return;
            }
            if (cboBxUnidad.Text.Length == 0)
            {
                MessageBox.Show("Debes ingresar una unidad de medida");
                cboBxUnidad.Focus();
                return;
            }
            if (richTxtBxDescripcion.Text.Length == 0)
            {
                MessageBox.Show("Debes ingresar una descripción para el producto");
                richTxtBxDescripcion.Focus();
                return;
            }
            if (txtBxPrecioVenta.Text.Length == 0)
            {
                MessageBox.Show("Debes ingresar un precio de venta para el producto");
                txtBxPrecioVenta.Focus();
                return;
            }


            vProducto dts = new vProducto();
            dts.Nombre = txtNombre.Text;
            dts.Desripcion = richTxtBxDescripcion.Text;
            dts.Unidad_Medida = cboBxUnidad.SelectedItem.ToString();
            dts.Precio_Venta = txtBxPrecioVenta.Text;


            if (accion.Equals("guardar"))
            {
                int result = FuncionProducto.agregar(dts);
                if (result > 0)
                {
                    MessageBox.Show("Producto Guardado con Exito!", "Guardado", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    txtBxID.Text = "";
                    txtNombre.Text = "";
                    richTxtBxDescripcion.Text = "";
                    txtBxPrecioVenta.Text = "";
                    cboBxUnidad.SelectedIndex = 0;
                }
            }
        }


        private void frmRegistroProductos_Load(object sender, EventArgs e)
        {
            inhabilitar();

        }

        private void bttnCancelar_Click(object sender, EventArgs e)
        {
            DialogResult res = MessageBox.Show("Desea dejar de registrar Productos", "title", MessageBoxButtons.YesNo);
            if (res == DialogResult.Yes)
            { 
                this.Hide();
                fra.Show();
            }
        }

        private void bttnBuscar_Click(object sender, EventArgs e)
        {
            frmProducto m = new frmProducto();
            m.ShowDialog();
            try
            {
                ProductoActual = m.ProductoSeleccionado;
                txtNombre.Text = m.ProductoSeleccionado.Nombre;
                richTxtBxDescripcion.Text = m.ProductoSeleccionado.Desripcion;
                cboBxUnidad.Text = m.ProductoSeleccionado.Unidad_Medida;
                txtBxPrecioVenta.Text = m.ProductoSeleccionado.Precio_Venta;

            }
            catch
            {

            }
        }

        private void bttnActualizar_Click(object sender, EventArgs e)
        {
            vProducto vx= new vProducto();
            vx.Nombre = txtNombre.Text;
            vx.Desripcion = richTxtBxDescripcion.Text;
            vx.Unidad_Medida = cboBxUnidad.Text;
            vx.Precio_Venta = txtBxPrecioVenta.Text;
            vx.IdProducto = ProductoActual.IdProducto;

            if (FuncionProducto.Actualizar(vx) > 0)
            {
                MessageBox.Show("Los datos del producto se actualizaron", "Datos actualizados", MessageBoxButtons.OK, MessageBoxIcon.Information);
                txtBxID.Text = "";
                txtNombre.Text = "";
                richTxtBxDescripcion.Text = "";
                cboBxUnidad.SelectedIndex = 0;
                txtBxPrecioVenta.Text = "";
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
                if (FuncionProducto.Eliminar(ProductoActual.IdProducto) > 0)
                {
                    MessageBox.Show("Producto Eliminado Correctamente", "Eliminado", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    txtBxID.Text = "";
                    txtNombre.Text = "";
                    richTxtBxDescripcion.Text = "";
                    txtBxPrecioVenta.Text = "";
                    cboBxUnidad.SelectedIndex = 0;
                }
                else
                {
                    MessageBox.Show("No se pudo Eliminar correctamente", "Producto no Eliminado", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                }
                
            }
        }

        private void txtNombre_KeyPress(object sender, KeyPressEventArgs e)
        {
            Validar.LetrasOnly(e);
        }

        private void richTxtBxDescripcion_KeyPress(object sender, KeyPressEventArgs e)
        {
            Validar.LetrasOnly(e);
        }

        private void txtBxPrecioVenta_KeyPress(object sender, KeyPressEventArgs e)
        {
            Validar.DecimalOnly(e);
        }
    }
}