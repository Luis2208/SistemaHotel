namespace Motel.Formularios
{
    partial class frmHabitaciones
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
            this.label1 = new System.Windows.Forms.Label();
            this.Registro = new System.Windows.Forms.Panel();
            this.bttnEliminar = new System.Windows.Forms.Button();
            this.bttnActualizar = new System.Windows.Forms.Button();
            this.bttnBuscar = new System.Windows.Forms.Button();
            this.bttnCancelar = new System.Windows.Forms.Button();
            this.bttnGuardar = new System.Windows.Forms.Button();
            this.bttnNuevo = new System.Windows.Forms.Button();
            this.cboBxHabitacion = new System.Windows.Forms.ComboBox();
            this.lblHabitacion = new System.Windows.Forms.Label();
            this.cboBxEstado = new System.Windows.Forms.ComboBox();
            this.lblEstado = new System.Windows.Forms.Label();
            this.txtBxPrecioDiario = new System.Windows.Forms.TextBox();
            this.lblPrecio = new System.Windows.Forms.Label();
            this.richTxtBxCaracte = new System.Windows.Forms.RichTextBox();
            this.lblCara = new System.Windows.Forms.Label();
            this.richTxtBxDescripcion = new System.Windows.Forms.RichTextBox();
            this.lblDescripcion = new System.Windows.Forms.Label();
            this.cmbPiso = new System.Windows.Forms.ComboBox();
            this.lblPiso = new System.Windows.Forms.Label();
            this.txtNumero = new System.Windows.Forms.TextBox();
            this.lblNumero = new System.Windows.Forms.Label();
            this.txtBxID = new System.Windows.Forms.TextBox();
            this.lblRegistro = new System.Windows.Forms.Label();
            this.txtBx = new System.Windows.Forms.TextBox();
            this.Registro.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Cooper Black", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Purple;
            this.label1.Location = new System.Drawing.Point(14, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(146, 27);
            this.label1.TabIndex = 0;
            this.label1.Text = "Habitacion";
            // 
            // Registro
            // 
            this.Registro.AccessibleDescription = "";
            this.Registro.AccessibleName = "";
            this.Registro.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(224)))), ((int)(((byte)(192)))));
            this.Registro.Controls.Add(this.bttnEliminar);
            this.Registro.Controls.Add(this.bttnActualizar);
            this.Registro.Controls.Add(this.bttnBuscar);
            this.Registro.Controls.Add(this.bttnCancelar);
            this.Registro.Controls.Add(this.bttnGuardar);
            this.Registro.Controls.Add(this.bttnNuevo);
            this.Registro.Controls.Add(this.cboBxHabitacion);
            this.Registro.Controls.Add(this.lblHabitacion);
            this.Registro.Controls.Add(this.cboBxEstado);
            this.Registro.Controls.Add(this.lblEstado);
            this.Registro.Controls.Add(this.txtBxPrecioDiario);
            this.Registro.Controls.Add(this.lblPrecio);
            this.Registro.Controls.Add(this.richTxtBxCaracte);
            this.Registro.Controls.Add(this.lblCara);
            this.Registro.Controls.Add(this.richTxtBxDescripcion);
            this.Registro.Controls.Add(this.lblDescripcion);
            this.Registro.Controls.Add(this.cmbPiso);
            this.Registro.Controls.Add(this.lblPiso);
            this.Registro.Controls.Add(this.txtNumero);
            this.Registro.Controls.Add(this.lblNumero);
            this.Registro.Controls.Add(this.txtBxID);
            this.Registro.Location = new System.Drawing.Point(12, 81);
            this.Registro.Name = "Registro";
            this.Registro.Size = new System.Drawing.Size(551, 463);
            this.Registro.TabIndex = 1;
            // 
            // bttnEliminar
            // 
            this.bttnEliminar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.bttnEliminar.ForeColor = System.Drawing.Color.White;
            this.bttnEliminar.Image = global::Motel.Properties.Resources.Eliminar;
            this.bttnEliminar.ImageAlign = System.Drawing.ContentAlignment.TopLeft;
            this.bttnEliminar.Location = new System.Drawing.Point(345, 412);
            this.bttnEliminar.Name = "bttnEliminar";
            this.bttnEliminar.Size = new System.Drawing.Size(90, 42);
            this.bttnEliminar.TabIndex = 20;
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
            this.bttnBuscar.Location = new System.Drawing.Point(128, 409);
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
            this.bttnCancelar.Location = new System.Drawing.Point(453, 412);
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
            this.bttnGuardar.Location = new System.Drawing.Point(20, 409);
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
            this.bttnNuevo.Location = new System.Drawing.Point(432, 3);
            this.bttnNuevo.Name = "bttnNuevo";
            this.bttnNuevo.Size = new System.Drawing.Size(81, 45);
            this.bttnNuevo.TabIndex = 15;
            this.bttnNuevo.Text = "Nuevo";
            this.bttnNuevo.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.bttnNuevo.UseVisualStyleBackColor = false;
            this.bttnNuevo.Click += new System.EventHandler(this.bttnNuevo_Click);
            // 
            // cboBxHabitacion
            // 
            this.cboBxHabitacion.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboBxHabitacion.FormattingEnabled = true;
            this.cboBxHabitacion.Items.AddRange(new object[] {
            "Individual",
            "Matrimonial",
            "Familiar",
            "Presidencial"});
            this.cboBxHabitacion.Location = new System.Drawing.Point(107, 365);
            this.cboBxHabitacion.Name = "cboBxHabitacion";
            this.cboBxHabitacion.Size = new System.Drawing.Size(121, 21);
            this.cboBxHabitacion.TabIndex = 14;
            // 
            // lblHabitacion
            // 
            this.lblHabitacion.AutoSize = true;
            this.lblHabitacion.Location = new System.Drawing.Point(21, 373);
            this.lblHabitacion.Name = "lblHabitacion";
            this.lblHabitacion.Size = new System.Drawing.Size(85, 13);
            this.lblHabitacion.TabIndex = 13;
            this.lblHabitacion.Text = "Tipo Habitacion:";
            // 
            // cboBxEstado
            // 
            this.cboBxEstado.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboBxEstado.FormattingEnabled = true;
            this.cboBxEstado.Items.AddRange(new object[] {
            "Disponible",
            "Ocupado",
            "Mantenimiento"});
            this.cboBxEstado.Location = new System.Drawing.Point(107, 333);
            this.cboBxEstado.Name = "cboBxEstado";
            this.cboBxEstado.Size = new System.Drawing.Size(121, 21);
            this.cboBxEstado.TabIndex = 12;
            // 
            // lblEstado
            // 
            this.lblEstado.AutoSize = true;
            this.lblEstado.Location = new System.Drawing.Point(21, 341);
            this.lblEstado.Name = "lblEstado";
            this.lblEstado.Size = new System.Drawing.Size(43, 13);
            this.lblEstado.TabIndex = 11;
            this.lblEstado.Text = "Estado:";
            // 
            // txtBxPrecioDiario
            // 
            this.txtBxPrecioDiario.Location = new System.Drawing.Point(107, 285);
            this.txtBxPrecioDiario.Name = "txtBxPrecioDiario";
            this.txtBxPrecioDiario.Size = new System.Drawing.Size(93, 20);
            this.txtBxPrecioDiario.TabIndex = 10;
            this.txtBxPrecioDiario.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtBxPrecioDiario_KeyPress);
            // 
            // lblPrecio
            // 
            this.lblPrecio.AutoSize = true;
            this.lblPrecio.Location = new System.Drawing.Point(22, 285);
            this.lblPrecio.Name = "lblPrecio";
            this.lblPrecio.Size = new System.Drawing.Size(70, 13);
            this.lblPrecio.TabIndex = 9;
            this.lblPrecio.Text = "Precio Diario:";
            // 
            // richTxtBxCaracte
            // 
            this.richTxtBxCaracte.Location = new System.Drawing.Point(107, 216);
            this.richTxtBxCaracte.Name = "richTxtBxCaracte";
            this.richTxtBxCaracte.Size = new System.Drawing.Size(215, 43);
            this.richTxtBxCaracte.TabIndex = 8;
            this.richTxtBxCaracte.Text = "";
            this.richTxtBxCaracte.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.richTxtBxCaracte_KeyPress);
            // 
            // lblCara
            // 
            this.lblCara.AutoSize = true;
            this.lblCara.Location = new System.Drawing.Point(21, 216);
            this.lblCara.Name = "lblCara";
            this.lblCara.Size = new System.Drawing.Size(79, 13);
            this.lblCara.TabIndex = 7;
            this.lblCara.Text = "Caracteristicas:";
            // 
            // richTxtBxDescripcion
            // 
            this.richTxtBxDescripcion.Location = new System.Drawing.Point(107, 143);
            this.richTxtBxDescripcion.Name = "richTxtBxDescripcion";
            this.richTxtBxDescripcion.Size = new System.Drawing.Size(215, 43);
            this.richTxtBxDescripcion.TabIndex = 6;
            this.richTxtBxDescripcion.Text = "";
            this.richTxtBxDescripcion.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.richTxtBxDescripcion_KeyPress);
            // 
            // lblDescripcion
            // 
            this.lblDescripcion.AutoSize = true;
            this.lblDescripcion.Location = new System.Drawing.Point(21, 146);
            this.lblDescripcion.Name = "lblDescripcion";
            this.lblDescripcion.Size = new System.Drawing.Size(66, 13);
            this.lblDescripcion.TabIndex = 5;
            this.lblDescripcion.Text = "Descripción:";
            // 
            // cmbPiso
            // 
            this.cmbPiso.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbPiso.FormattingEnabled = true;
            this.cmbPiso.Items.AddRange(new object[] {
            "1",
            "2",
            "3",
            "4"});
            this.cmbPiso.Location = new System.Drawing.Point(107, 95);
            this.cmbPiso.Name = "cmbPiso";
            this.cmbPiso.Size = new System.Drawing.Size(121, 21);
            this.cmbPiso.TabIndex = 4;
            // 
            // lblPiso
            // 
            this.lblPiso.AutoSize = true;
            this.lblPiso.Location = new System.Drawing.Point(21, 103);
            this.lblPiso.Name = "lblPiso";
            this.lblPiso.Size = new System.Drawing.Size(30, 13);
            this.lblPiso.TabIndex = 3;
            this.lblPiso.Text = "Piso:";
            // 
            // txtNumero
            // 
            this.txtNumero.Location = new System.Drawing.Point(107, 61);
            this.txtNumero.Name = "txtNumero";
            this.txtNumero.Size = new System.Drawing.Size(215, 20);
            this.txtNumero.TabIndex = 2;
            this.txtNumero.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtNumero_KeyPress);
            // 
            // lblNumero
            // 
            this.lblNumero.AutoSize = true;
            this.lblNumero.Location = new System.Drawing.Point(21, 61);
            this.lblNumero.Name = "lblNumero";
            this.lblNumero.Size = new System.Drawing.Size(47, 13);
            this.lblNumero.TabIndex = 1;
            this.lblNumero.Text = "Número:";
            // 
            // txtBxID
            // 
            this.txtBxID.Location = new System.Drawing.Point(203, 13);
            this.txtBxID.Name = "txtBxID";
            this.txtBxID.Size = new System.Drawing.Size(97, 20);
            this.txtBxID.TabIndex = 0;
            this.txtBxID.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // lblRegistro
            // 
            this.lblRegistro.AutoSize = true;
            this.lblRegistro.Font = new System.Drawing.Font("Calibri", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblRegistro.ForeColor = System.Drawing.Color.Black;
            this.lblRegistro.Location = new System.Drawing.Point(14, 51);
            this.lblRegistro.Name = "lblRegistro";
            this.lblRegistro.Size = new System.Drawing.Size(257, 29);
            this.lblRegistro.TabIndex = 2;
            this.lblRegistro.Text = "Registro de Habitaciones";
            // 
            // txtBx
            // 
            this.txtBx.Location = new System.Drawing.Point(82, 13);
            this.txtBx.Name = "txtBx";
            this.txtBx.Size = new System.Drawing.Size(100, 20);
            this.txtBx.TabIndex = 2;
            // 
            // frmHabitaciones
            // 
            this.AccessibleDescription = "Registro de Habitaciones";
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.ClientSize = new System.Drawing.Size(564, 556);
            this.ControlBox = false;
            this.Controls.Add(this.lblRegistro);
            this.Controls.Add(this.Registro);
            this.Controls.Add(this.label1);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frmHabitaciones";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "frmHabitaciones";
            this.Load += new System.EventHandler(this.frmHabitaciones_Load);
            this.Registro.ResumeLayout(false);
            this.Registro.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel Registro;
        private System.Windows.Forms.Label lblNumero;
        private System.Windows.Forms.TextBox txtBxID;
        private System.Windows.Forms.Label lblRegistro;
        private System.Windows.Forms.TextBox txtNumero;
        private System.Windows.Forms.RichTextBox richTxtBxDescripcion;
        private System.Windows.Forms.Label lblDescripcion;
        private System.Windows.Forms.ComboBox cmbPiso;
        private System.Windows.Forms.Label lblPiso;
        private System.Windows.Forms.Button bttnCancelar;
        private System.Windows.Forms.Button bttnGuardar;
        private System.Windows.Forms.Button bttnNuevo;
        private System.Windows.Forms.ComboBox cboBxHabitacion;
        private System.Windows.Forms.Label lblHabitacion;
        private System.Windows.Forms.ComboBox cboBxEstado;
        private System.Windows.Forms.Label lblEstado;
        private System.Windows.Forms.TextBox txtBxPrecioDiario;
        private System.Windows.Forms.Label lblPrecio;
        private System.Windows.Forms.RichTextBox richTxtBxCaracte;
        private System.Windows.Forms.Label lblCara;
        private System.Windows.Forms.TextBox txtBx;
        private System.Windows.Forms.Button bttnBuscar;
        private System.Windows.Forms.Button bttnActualizar;
        private System.Windows.Forms.Button bttnEliminar;
    }
}