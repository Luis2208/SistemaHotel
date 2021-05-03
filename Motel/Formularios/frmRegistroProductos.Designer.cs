namespace Motel.Formularios
{
    partial class frmRegistroProductos
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.lblRegistroProdu = new System.Windows.Forms.Label();
            this.Registro = new System.Windows.Forms.Panel();
            this.bttnEliminar = new System.Windows.Forms.Button();
            this.bttnActualizar = new System.Windows.Forms.Button();
            this.bttnBuscar = new System.Windows.Forms.Button();
            this.bttnCancelar = new System.Windows.Forms.Button();
            this.bttnGuardar = new System.Windows.Forms.Button();
            this.bttnNuevo = new System.Windows.Forms.Button();
            this.cboBxUnidad = new System.Windows.Forms.ComboBox();
            this.lblUnidadMedida = new System.Windows.Forms.Label();
            this.txtBxPrecioVenta = new System.Windows.Forms.TextBox();
            this.lblPrecioVenta = new System.Windows.Forms.Label();
            this.richTxtBxDescripcion = new System.Windows.Forms.RichTextBox();
            this.lblDescripcion = new System.Windows.Forms.Label();
            this.txtNombre = new System.Windows.Forms.TextBox();
            this.lblNombre = new System.Windows.Forms.Label();
            this.txtBxID = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.Registro.SuspendLayout();
            this.SuspendLayout();
            // 
            // lblRegistroProdu
            // 
            this.lblRegistroProdu.AutoSize = true;
            this.lblRegistroProdu.Font = new System.Drawing.Font("Calibri", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblRegistroProdu.ForeColor = System.Drawing.Color.Black;
            this.lblRegistroProdu.Location = new System.Drawing.Point(12, 9);
            this.lblRegistroProdu.Name = "lblRegistroProdu";
            this.lblRegistroProdu.Size = new System.Drawing.Size(227, 29);
            this.lblRegistroProdu.TabIndex = 5;
            this.lblRegistroProdu.Text = "Registro de Productos";
            // 
            // Registro
            // 
            this.Registro.AccessibleDescription = "";
            this.Registro.AccessibleName = "";
            this.Registro.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.Registro.Controls.Add(this.bttnEliminar);
            this.Registro.Controls.Add(this.bttnActualizar);
            this.Registro.Controls.Add(this.bttnBuscar);
            this.Registro.Controls.Add(this.bttnCancelar);
            this.Registro.Controls.Add(this.bttnGuardar);
            this.Registro.Controls.Add(this.bttnNuevo);
            this.Registro.Controls.Add(this.cboBxUnidad);
            this.Registro.Controls.Add(this.lblUnidadMedida);
            this.Registro.Controls.Add(this.txtBxPrecioVenta);
            this.Registro.Controls.Add(this.lblPrecioVenta);
            this.Registro.Controls.Add(this.richTxtBxDescripcion);
            this.Registro.Controls.Add(this.lblDescripcion);
            this.Registro.Controls.Add(this.txtNombre);
            this.Registro.Controls.Add(this.lblNombre);
            this.Registro.Controls.Add(this.txtBxID);
            this.Registro.Location = new System.Drawing.Point(12, 54);
            this.Registro.Name = "Registro";
            this.Registro.Size = new System.Drawing.Size(551, 463);
            this.Registro.TabIndex = 4;
            // 
            // bttnEliminar
            // 
            this.bttnEliminar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.bttnEliminar.ForeColor = System.Drawing.Color.White;
            this.bttnEliminar.Image = global::Motel.Properties.Resources.Eliminar;
            this.bttnEliminar.ImageAlign = System.Drawing.ContentAlignment.TopLeft;
            this.bttnEliminar.Location = new System.Drawing.Point(342, 410);
            this.bttnEliminar.Name = "bttnEliminar";
            this.bttnEliminar.Size = new System.Drawing.Size(82, 42);
            this.bttnEliminar.TabIndex = 6;
            this.bttnEliminar.Text = "Eliminar";
            this.bttnEliminar.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.bttnEliminar.UseVisualStyleBackColor = false;
            this.bttnEliminar.Click += new System.EventHandler(this.bttnEliminar_Click);
            // 
            // bttnActualizar
            // 
            this.bttnActualizar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.bttnActualizar.ForeColor = System.Drawing.Color.White;
            this.bttnActualizar.Image = global::Motel.Properties.Resources.actualizar;
            this.bttnActualizar.ImageAlign = System.Drawing.ContentAlignment.TopLeft;
            this.bttnActualizar.Location = new System.Drawing.Point(232, 409);
            this.bttnActualizar.Name = "bttnActualizar";
            this.bttnActualizar.Size = new System.Drawing.Size(90, 45);
            this.bttnActualizar.TabIndex = 19;
            this.bttnActualizar.Text = "Actualizar";
            this.bttnActualizar.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.bttnActualizar.UseVisualStyleBackColor = false;
            this.bttnActualizar.Click += new System.EventHandler(this.bttnActualizar_Click);
            // 
            // bttnBuscar
            // 
            this.bttnBuscar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.bttnBuscar.ForeColor = System.Drawing.Color.White;
            this.bttnBuscar.Image = global::Motel.Properties.Resources.Buscar;
            this.bttnBuscar.ImageAlign = System.Drawing.ContentAlignment.TopLeft;
            this.bttnBuscar.Location = new System.Drawing.Point(126, 409);
            this.bttnBuscar.Name = "bttnBuscar";
            this.bttnBuscar.Size = new System.Drawing.Size(87, 45);
            this.bttnBuscar.TabIndex = 18;
            this.bttnBuscar.Text = "Buscar";
            this.bttnBuscar.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.bttnBuscar.UseVisualStyleBackColor = false;
            this.bttnBuscar.Click += new System.EventHandler(this.bttnBuscar_Click);
            // 
            // bttnCancelar
            // 
            this.bttnCancelar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.bttnCancelar.ForeColor = System.Drawing.Color.White;
            this.bttnCancelar.Image = global::Motel.Properties.Resources.Cancelar;
            this.bttnCancelar.ImageAlign = System.Drawing.ContentAlignment.TopLeft;
            this.bttnCancelar.Location = new System.Drawing.Point(441, 409);
            this.bttnCancelar.Name = "bttnCancelar";
            this.bttnCancelar.Size = new System.Drawing.Size(87, 45);
            this.bttnCancelar.TabIndex = 17;
            this.bttnCancelar.Text = "Cancelar";
            this.bttnCancelar.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.bttnCancelar.UseVisualStyleBackColor = false;
            this.bttnCancelar.Click += new System.EventHandler(this.bttnCancelar_Click);
            // 
            // bttnGuardar
            // 
            this.bttnGuardar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.bttnGuardar.ForeColor = System.Drawing.Color.White;
            this.bttnGuardar.Image = global::Motel.Properties.Resources.Guardar;
            this.bttnGuardar.ImageAlign = System.Drawing.ContentAlignment.TopLeft;
            this.bttnGuardar.Location = new System.Drawing.Point(25, 409);
            this.bttnGuardar.Name = "bttnGuardar";
            this.bttnGuardar.Size = new System.Drawing.Size(86, 45);
            this.bttnGuardar.TabIndex = 16;
            this.bttnGuardar.Text = "Guardar";
            this.bttnGuardar.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.bttnGuardar.UseVisualStyleBackColor = false;
            this.bttnGuardar.Click += new System.EventHandler(this.bttnGuardar_Click);
            // 
            // bttnNuevo
            // 
            this.bttnNuevo.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.bttnNuevo.ForeColor = System.Drawing.Color.White;
            this.bttnNuevo.Image = global::Motel.Properties.Resources.nuevo;
            this.bttnNuevo.ImageAlign = System.Drawing.ContentAlignment.TopLeft;
            this.bttnNuevo.Location = new System.Drawing.Point(24, 349);
            this.bttnNuevo.Name = "bttnNuevo";
            this.bttnNuevo.Size = new System.Drawing.Size(81, 45);
            this.bttnNuevo.TabIndex = 15;
            this.bttnNuevo.Text = "Nuevo";
            this.bttnNuevo.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.bttnNuevo.UseVisualStyleBackColor = false;
            this.bttnNuevo.Click += new System.EventHandler(this.bttnNuevo_Click);
            // 
            // cboBxUnidad
            // 
            this.cboBxUnidad.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboBxUnidad.FormattingEnabled = true;
            this.cboBxUnidad.Items.AddRange(new object[] {
            "KG",
            "UNI",
            "LT",
            "MIN",
            "GLO"});
            this.cboBxUnidad.Location = new System.Drawing.Point(114, 233);
            this.cboBxUnidad.Name = "cboBxUnidad";
            this.cboBxUnidad.Size = new System.Drawing.Size(121, 21);
            this.cboBxUnidad.TabIndex = 12;
            // 
            // lblUnidadMedida
            // 
            this.lblUnidadMedida.AutoSize = true;
            this.lblUnidadMedida.Location = new System.Drawing.Point(9, 233);
            this.lblUnidadMedida.Name = "lblUnidadMedida";
            this.lblUnidadMedida.Size = new System.Drawing.Size(97, 13);
            this.lblUnidadMedida.TabIndex = 11;
            this.lblUnidadMedida.Text = "Unidad de Medida:";
            // 
            // txtBxPrecioVenta
            // 
            this.txtBxPrecioVenta.Location = new System.Drawing.Point(107, 285);
            this.txtBxPrecioVenta.Name = "txtBxPrecioVenta";
            this.txtBxPrecioVenta.Size = new System.Drawing.Size(93, 20);
            this.txtBxPrecioVenta.TabIndex = 10;
            this.txtBxPrecioVenta.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtBxPrecioVenta_KeyPress);
            // 
            // lblPrecioVenta
            // 
            this.lblPrecioVenta.AutoSize = true;
            this.lblPrecioVenta.Location = new System.Drawing.Point(22, 285);
            this.lblPrecioVenta.Name = "lblPrecioVenta";
            this.lblPrecioVenta.Size = new System.Drawing.Size(71, 13);
            this.lblPrecioVenta.TabIndex = 9;
            this.lblPrecioVenta.Text = "Precio Venta:";
            // 
            // richTxtBxDescripcion
            // 
            this.richTxtBxDescripcion.Location = new System.Drawing.Point(107, 122);
            this.richTxtBxDescripcion.Name = "richTxtBxDescripcion";
            this.richTxtBxDescripcion.Size = new System.Drawing.Size(215, 65);
            this.richTxtBxDescripcion.TabIndex = 6;
            this.richTxtBxDescripcion.Text = "";
            this.richTxtBxDescripcion.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.richTxtBxDescripcion_KeyPress);
            // 
            // lblDescripcion
            // 
            this.lblDescripcion.AutoSize = true;
            this.lblDescripcion.Location = new System.Drawing.Point(22, 125);
            this.lblDescripcion.Name = "lblDescripcion";
            this.lblDescripcion.Size = new System.Drawing.Size(66, 13);
            this.lblDescripcion.TabIndex = 5;
            this.lblDescripcion.Text = "Descripción:";
            // 
            // txtNombre
            // 
            this.txtNombre.Location = new System.Drawing.Point(107, 61);
            this.txtNombre.Name = "txtNombre";
            this.txtNombre.Size = new System.Drawing.Size(215, 20);
            this.txtNombre.TabIndex = 2;
            this.txtNombre.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtNombre_KeyPress);
            // 
            // lblNombre
            // 
            this.lblNombre.AutoSize = true;
            this.lblNombre.Location = new System.Drawing.Point(21, 61);
            this.lblNombre.Name = "lblNombre";
            this.lblNombre.Size = new System.Drawing.Size(47, 13);
            this.lblNombre.TabIndex = 1;
            this.lblNombre.Text = "Nombre:";
            // 
            // txtBxID
            // 
            this.txtBxID.Location = new System.Drawing.Point(203, 13);
            this.txtBxID.Name = "txtBxID";
            this.txtBxID.Size = new System.Drawing.Size(97, 20);
            this.txtBxID.TabIndex = 0;
            this.txtBxID.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Cooper Black", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Purple;
            this.label1.Location = new System.Drawing.Point(127, -42);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(146, 27);
            this.label1.TabIndex = 3;
            this.label1.Text = "Habitacion";
            // 
            // frmRegistroProductos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(569, 529);
            this.ControlBox = false;
            this.Controls.Add(this.lblRegistroProdu);
            this.Controls.Add(this.Registro);
            this.Controls.Add(this.label1);
            this.Name = "frmRegistroProductos";
            this.Text = "frmRegistroProductos";
            this.Load += new System.EventHandler(this.frmRegistroProductos_Load);
            this.Registro.ResumeLayout(false);
            this.Registro.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblRegistroProdu;
        private System.Windows.Forms.Panel Registro;
        private System.Windows.Forms.Button bttnActualizar;
        private System.Windows.Forms.Button bttnBuscar;
        private System.Windows.Forms.Button bttnCancelar;
        private System.Windows.Forms.Button bttnGuardar;
        private System.Windows.Forms.Button bttnNuevo;
        private System.Windows.Forms.ComboBox cboBxUnidad;
        private System.Windows.Forms.Label lblUnidadMedida;
        private System.Windows.Forms.TextBox txtBxPrecioVenta;
        private System.Windows.Forms.Label lblPrecioVenta;
        private System.Windows.Forms.RichTextBox richTxtBxDescripcion;
        private System.Windows.Forms.Label lblDescripcion;
        private System.Windows.Forms.TextBox txtNombre;
        private System.Windows.Forms.Label lblNombre;
        private System.Windows.Forms.TextBox txtBxID;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button bttnEliminar;
    }
}