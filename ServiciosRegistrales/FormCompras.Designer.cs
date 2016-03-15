namespace ServiciosRegistrales
{
    partial class FormCompras
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
            this.grdDetalleCompra = new System.Windows.Forms.DataGridView();
            this.gpbDatosCompra = new System.Windows.Forms.GroupBox();
            this.cmbDepositos = new System.Windows.Forms.ComboBox();
            this.lblDepositos = new System.Windows.Forms.Label();
            this.txtGastosExtra = new System.Windows.Forms.TextBox();
            this.lblGastosExtra = new System.Windows.Forms.Label();
            this.txtNroFactura = new System.Windows.Forms.TextBox();
            this.lblNroFactura = new System.Windows.Forms.Label();
            this.lblMontoTotalValor = new System.Windows.Forms.Label();
            this.lblMontoTotal = new System.Windows.Forms.Label();
            this.txtComentarios = new System.Windows.Forms.TextBox();
            this.lblComentarios = new System.Windows.Forms.Label();
            this.cmbProveedores = new System.Windows.Forms.ComboBox();
            this.lblProveedor = new System.Windows.Forms.Label();
            this.dtpFecha = new System.Windows.Forms.DateTimePicker();
            this.lblFecha = new System.Windows.Forms.Label();
            this.gpbNuevoArticulo = new System.Windows.Forms.GroupBox();
            this.cmbIva = new System.Windows.Forms.ComboBox();
            this.lblIva = new System.Windows.Forms.Label();
            this.txtPrecioUnitario = new System.Windows.Forms.TextBox();
            this.lblPrecioUnitario = new System.Windows.Forms.Label();
            this.btnNuevoArticulo = new System.Windows.Forms.Button();
            this.btnEliminarArticulo = new System.Windows.Forms.Button();
            this.btnGuardarArticulo = new System.Windows.Forms.Button();
            this.txtPrecioArticulo = new System.Windows.Forms.TextBox();
            this.lblPrecioArticulo = new System.Windows.Forms.Label();
            this.numericCantidad = new System.Windows.Forms.NumericUpDown();
            this.lblCantidad = new System.Windows.Forms.Label();
            this.cmbArticulos = new System.Windows.Forms.ComboBox();
            this.lblArticulo = new System.Windows.Forms.Label();
            this.btnRegistrarCompra = new System.Windows.Forms.Button();
            this.btnLimpiarDatos = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.grdDetalleCompra)).BeginInit();
            this.gpbDatosCompra.SuspendLayout();
            this.gpbNuevoArticulo.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericCantidad)).BeginInit();
            this.SuspendLayout();
            // 
            // grdDetalleCompra
            // 
            this.grdDetalleCompra.AllowUserToAddRows = false;
            this.grdDetalleCompra.AllowUserToDeleteRows = false;
            this.grdDetalleCompra.AllowUserToResizeRows = false;
            this.grdDetalleCompra.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.grdDetalleCompra.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.grdDetalleCompra.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.grdDetalleCompra.Location = new System.Drawing.Point(528, 34);
            this.grdDetalleCompra.Name = "grdDetalleCompra";
            this.grdDetalleCompra.ReadOnly = true;
            this.grdDetalleCompra.RowHeadersVisible = false;
            this.grdDetalleCompra.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.grdDetalleCompra.Size = new System.Drawing.Size(544, 572);
            this.grdDetalleCompra.TabIndex = 0;
            this.grdDetalleCompra.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.grdDetalleCompra_CellClick);
            // 
            // gpbDatosCompra
            // 
            this.gpbDatosCompra.Controls.Add(this.cmbDepositos);
            this.gpbDatosCompra.Controls.Add(this.lblDepositos);
            this.gpbDatosCompra.Controls.Add(this.txtGastosExtra);
            this.gpbDatosCompra.Controls.Add(this.lblGastosExtra);
            this.gpbDatosCompra.Controls.Add(this.txtNroFactura);
            this.gpbDatosCompra.Controls.Add(this.lblNroFactura);
            this.gpbDatosCompra.Controls.Add(this.lblMontoTotalValor);
            this.gpbDatosCompra.Controls.Add(this.lblMontoTotal);
            this.gpbDatosCompra.Controls.Add(this.txtComentarios);
            this.gpbDatosCompra.Controls.Add(this.lblComentarios);
            this.gpbDatosCompra.Controls.Add(this.cmbProveedores);
            this.gpbDatosCompra.Controls.Add(this.lblProveedor);
            this.gpbDatosCompra.Controls.Add(this.dtpFecha);
            this.gpbDatosCompra.Controls.Add(this.lblFecha);
            this.gpbDatosCompra.Location = new System.Drawing.Point(12, 25);
            this.gpbDatosCompra.Name = "gpbDatosCompra";
            this.gpbDatosCompra.Size = new System.Drawing.Size(510, 287);
            this.gpbDatosCompra.TabIndex = 1;
            this.gpbDatosCompra.TabStop = false;
            this.gpbDatosCompra.Text = "Datos de la compra";
            this.gpbDatosCompra.Enter += new System.EventHandler(this.groupBox1_Enter);
            // 
            // cmbDepositos
            // 
            this.cmbDepositos.DisplayMember = "descripcion";
            this.cmbDepositos.FormattingEnabled = true;
            this.cmbDepositos.Location = new System.Drawing.Point(144, 234);
            this.cmbDepositos.Name = "cmbDepositos";
            this.cmbDepositos.Size = new System.Drawing.Size(200, 24);
            this.cmbDepositos.TabIndex = 18;
            this.cmbDepositos.ValueMember = "id";
            // 
            // lblDepositos
            // 
            this.lblDepositos.AutoSize = true;
            this.lblDepositos.Location = new System.Drawing.Point(18, 238);
            this.lblDepositos.Name = "lblDepositos";
            this.lblDepositos.Size = new System.Drawing.Size(78, 16);
            this.lblDepositos.TabIndex = 17;
            this.lblDepositos.Text = "Guardar en:";
            // 
            // txtGastosExtra
            // 
            this.txtGastosExtra.Location = new System.Drawing.Point(144, 201);
            this.txtGastosExtra.Name = "txtGastosExtra";
            this.txtGastosExtra.Size = new System.Drawing.Size(200, 22);
            this.txtGastosExtra.TabIndex = 16;
            this.txtGastosExtra.Leave += new System.EventHandler(this.txtGastosExtra_Leave);
            // 
            // lblGastosExtra
            // 
            this.lblGastosExtra.AutoSize = true;
            this.lblGastosExtra.Location = new System.Drawing.Point(18, 204);
            this.lblGastosExtra.Name = "lblGastosExtra";
            this.lblGastosExtra.Size = new System.Drawing.Size(118, 16);
            this.lblGastosExtra.TabIndex = 15;
            this.lblGastosExtra.Text = "Gastos generales:";
            // 
            // txtNroFactura
            // 
            this.txtNroFactura.Location = new System.Drawing.Point(144, 167);
            this.txtNroFactura.Name = "txtNroFactura";
            this.txtNroFactura.Size = new System.Drawing.Size(200, 22);
            this.txtNroFactura.TabIndex = 9;
            // 
            // lblNroFactura
            // 
            this.lblNroFactura.AutoSize = true;
            this.lblNroFactura.Location = new System.Drawing.Point(18, 170);
            this.lblNroFactura.Name = "lblNroFactura";
            this.lblNroFactura.Size = new System.Drawing.Size(95, 16);
            this.lblNroFactura.TabIndex = 8;
            this.lblNroFactura.Text = "Nro de factura:";
            // 
            // lblMontoTotalValor
            // 
            this.lblMontoTotalValor.AutoSize = true;
            this.lblMontoTotalValor.Location = new System.Drawing.Point(141, 266);
            this.lblMontoTotalValor.Name = "lblMontoTotalValor";
            this.lblMontoTotalValor.Size = new System.Drawing.Size(15, 16);
            this.lblMontoTotalValor.TabIndex = 7;
            this.lblMontoTotalValor.Text = "0";
            // 
            // lblMontoTotal
            // 
            this.lblMontoTotal.AutoSize = true;
            this.lblMontoTotal.Location = new System.Drawing.Point(18, 265);
            this.lblMontoTotal.Name = "lblMontoTotal";
            this.lblMontoTotal.Size = new System.Drawing.Size(94, 16);
            this.lblMontoTotal.TabIndex = 6;
            this.lblMontoTotal.Text = "Monto total ($):";
            // 
            // txtComentarios
            // 
            this.txtComentarios.Location = new System.Drawing.Point(144, 104);
            this.txtComentarios.MaxLength = 200;
            this.txtComentarios.Multiline = true;
            this.txtComentarios.Name = "txtComentarios";
            this.txtComentarios.Size = new System.Drawing.Size(360, 52);
            this.txtComentarios.TabIndex = 5;
            // 
            // lblComentarios
            // 
            this.lblComentarios.AutoSize = true;
            this.lblComentarios.Location = new System.Drawing.Point(18, 107);
            this.lblComentarios.Name = "lblComentarios";
            this.lblComentarios.Size = new System.Drawing.Size(87, 16);
            this.lblComentarios.TabIndex = 4;
            this.lblComentarios.Text = "Comentarios:";
            // 
            // cmbProveedores
            // 
            this.cmbProveedores.DisplayMember = "razonSocial";
            this.cmbProveedores.FormattingEnabled = true;
            this.cmbProveedores.Location = new System.Drawing.Point(144, 67);
            this.cmbProveedores.Name = "cmbProveedores";
            this.cmbProveedores.Size = new System.Drawing.Size(200, 24);
            this.cmbProveedores.TabIndex = 3;
            this.cmbProveedores.ValueMember = "id";
            // 
            // lblProveedor
            // 
            this.lblProveedor.AutoSize = true;
            this.lblProveedor.Location = new System.Drawing.Point(18, 70);
            this.lblProveedor.Name = "lblProveedor";
            this.lblProveedor.Size = new System.Drawing.Size(75, 16);
            this.lblProveedor.TabIndex = 2;
            this.lblProveedor.Text = "Proveedor:";
            // 
            // dtpFecha
            // 
            this.dtpFecha.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpFecha.Location = new System.Drawing.Point(144, 26);
            this.dtpFecha.Name = "dtpFecha";
            this.dtpFecha.Size = new System.Drawing.Size(200, 22);
            this.dtpFecha.TabIndex = 1;
            // 
            // lblFecha
            // 
            this.lblFecha.AutoSize = true;
            this.lblFecha.Location = new System.Drawing.Point(18, 31);
            this.lblFecha.Name = "lblFecha";
            this.lblFecha.Size = new System.Drawing.Size(49, 16);
            this.lblFecha.TabIndex = 0;
            this.lblFecha.Text = "Fecha:";
            // 
            // gpbNuevoArticulo
            // 
            this.gpbNuevoArticulo.Controls.Add(this.cmbIva);
            this.gpbNuevoArticulo.Controls.Add(this.lblIva);
            this.gpbNuevoArticulo.Controls.Add(this.txtPrecioUnitario);
            this.gpbNuevoArticulo.Controls.Add(this.lblPrecioUnitario);
            this.gpbNuevoArticulo.Controls.Add(this.btnNuevoArticulo);
            this.gpbNuevoArticulo.Controls.Add(this.btnEliminarArticulo);
            this.gpbNuevoArticulo.Controls.Add(this.btnGuardarArticulo);
            this.gpbNuevoArticulo.Controls.Add(this.txtPrecioArticulo);
            this.gpbNuevoArticulo.Controls.Add(this.lblPrecioArticulo);
            this.gpbNuevoArticulo.Controls.Add(this.numericCantidad);
            this.gpbNuevoArticulo.Controls.Add(this.lblCantidad);
            this.gpbNuevoArticulo.Controls.Add(this.cmbArticulos);
            this.gpbNuevoArticulo.Controls.Add(this.lblArticulo);
            this.gpbNuevoArticulo.Location = new System.Drawing.Point(13, 318);
            this.gpbNuevoArticulo.Name = "gpbNuevoArticulo";
            this.gpbNuevoArticulo.Size = new System.Drawing.Size(509, 242);
            this.gpbNuevoArticulo.TabIndex = 2;
            this.gpbNuevoArticulo.TabStop = false;
            this.gpbNuevoArticulo.Text = "Agregar un nuevo artículo";
            // 
            // cmbIva
            // 
            this.cmbIva.DisplayMember = "aumento";
            this.cmbIva.FormattingEnabled = true;
            this.cmbIva.Location = new System.Drawing.Point(272, 79);
            this.cmbIva.Name = "cmbIva";
            this.cmbIva.Size = new System.Drawing.Size(73, 24);
            this.cmbIva.TabIndex = 12;
            this.cmbIva.ValueMember = "aumento";
            this.cmbIva.TextChanged += new System.EventHandler(this.actualizarImporte);
            // 
            // lblIva
            // 
            this.lblIva.AutoSize = true;
            this.lblIva.Location = new System.Drawing.Point(234, 83);
            this.lblIva.Name = "lblIva";
            this.lblIva.Size = new System.Drawing.Size(32, 16);
            this.lblIva.TabIndex = 11;
            this.lblIva.Text = "IVA:";
            // 
            // txtPrecioUnitario
            // 
            this.txtPrecioUnitario.Location = new System.Drawing.Point(143, 115);
            this.txtPrecioUnitario.Name = "txtPrecioUnitario";
            this.txtPrecioUnitario.Size = new System.Drawing.Size(200, 22);
            this.txtPrecioUnitario.TabIndex = 10;
            this.txtPrecioUnitario.TextChanged += new System.EventHandler(this.actualizarImporte);
            this.txtPrecioUnitario.KeyUp += new System.Windows.Forms.KeyEventHandler(this.txtPrecioUnitario_KeyUp);
            this.txtPrecioUnitario.Leave += new System.EventHandler(this.actualizarImporte);
            // 
            // lblPrecioUnitario
            // 
            this.lblPrecioUnitario.AutoSize = true;
            this.lblPrecioUnitario.Location = new System.Drawing.Point(17, 118);
            this.lblPrecioUnitario.Name = "lblPrecioUnitario";
            this.lblPrecioUnitario.Size = new System.Drawing.Size(96, 16);
            this.lblPrecioUnitario.TabIndex = 9;
            this.lblPrecioUnitario.Text = "Precio unitario:";
            // 
            // btnNuevoArticulo
            // 
            this.btnNuevoArticulo.Enabled = false;
            this.btnNuevoArticulo.Location = new System.Drawing.Point(20, 193);
            this.btnNuevoArticulo.Name = "btnNuevoArticulo";
            this.btnNuevoArticulo.Size = new System.Drawing.Size(122, 33);
            this.btnNuevoArticulo.TabIndex = 8;
            this.btnNuevoArticulo.Text = "Insertar nuevo";
            this.btnNuevoArticulo.UseVisualStyleBackColor = true;
            this.btnNuevoArticulo.Click += new System.EventHandler(this.btnNuevoArticulo_Click);
            // 
            // btnEliminarArticulo
            // 
            this.btnEliminarArticulo.Enabled = false;
            this.btnEliminarArticulo.Location = new System.Drawing.Point(191, 193);
            this.btnEliminarArticulo.Name = "btnEliminarArticulo";
            this.btnEliminarArticulo.Size = new System.Drawing.Size(122, 33);
            this.btnEliminarArticulo.TabIndex = 7;
            this.btnEliminarArticulo.Text = "Eliminar";
            this.btnEliminarArticulo.UseVisualStyleBackColor = true;
            this.btnEliminarArticulo.Click += new System.EventHandler(this.btnEliminarArticulo_Click);
            // 
            // btnGuardarArticulo
            // 
            this.btnGuardarArticulo.Location = new System.Drawing.Point(365, 193);
            this.btnGuardarArticulo.Name = "btnGuardarArticulo";
            this.btnGuardarArticulo.Size = new System.Drawing.Size(122, 33);
            this.btnGuardarArticulo.TabIndex = 6;
            this.btnGuardarArticulo.Text = "Guardar artículo";
            this.btnGuardarArticulo.UseVisualStyleBackColor = true;
            this.btnGuardarArticulo.Click += new System.EventHandler(this.btnGuardarArticulo_Click);
            // 
            // txtPrecioArticulo
            // 
            this.txtPrecioArticulo.Location = new System.Drawing.Point(143, 152);
            this.txtPrecioArticulo.Name = "txtPrecioArticulo";
            this.txtPrecioArticulo.ReadOnly = true;
            this.txtPrecioArticulo.Size = new System.Drawing.Size(200, 22);
            this.txtPrecioArticulo.TabIndex = 5;
            // 
            // lblPrecioArticulo
            // 
            this.lblPrecioArticulo.AutoSize = true;
            this.lblPrecioArticulo.Location = new System.Drawing.Point(17, 155);
            this.lblPrecioArticulo.Name = "lblPrecioArticulo";
            this.lblPrecioArticulo.Size = new System.Drawing.Size(78, 16);
            this.lblPrecioArticulo.TabIndex = 4;
            this.lblPrecioArticulo.Text = "Precio total:";
            // 
            // numericCantidad
            // 
            this.numericCantidad.Location = new System.Drawing.Point(143, 81);
            this.numericCantidad.Name = "numericCantidad";
            this.numericCantidad.Size = new System.Drawing.Size(75, 22);
            this.numericCantidad.TabIndex = 3;
            this.numericCantidad.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.numericCantidad.ValueChanged += new System.EventHandler(this.actualizarImporte);
            // 
            // lblCantidad
            // 
            this.lblCantidad.AutoSize = true;
            this.lblCantidad.Location = new System.Drawing.Point(17, 83);
            this.lblCantidad.Name = "lblCantidad";
            this.lblCantidad.Size = new System.Drawing.Size(65, 16);
            this.lblCantidad.TabIndex = 2;
            this.lblCantidad.Text = "Cantidad:";
            // 
            // cmbArticulos
            // 
            this.cmbArticulos.DisplayMember = "codigo";
            this.cmbArticulos.FormattingEnabled = true;
            this.cmbArticulos.Location = new System.Drawing.Point(143, 33);
            this.cmbArticulos.Name = "cmbArticulos";
            this.cmbArticulos.Size = new System.Drawing.Size(200, 24);
            this.cmbArticulos.TabIndex = 1;
            this.cmbArticulos.ValueMember = "id";
            // 
            // lblArticulo
            // 
            this.lblArticulo.AutoSize = true;
            this.lblArticulo.Location = new System.Drawing.Point(17, 36);
            this.lblArticulo.Name = "lblArticulo";
            this.lblArticulo.Size = new System.Drawing.Size(55, 16);
            this.lblArticulo.TabIndex = 0;
            this.lblArticulo.Text = "Artículo:";
            // 
            // btnRegistrarCompra
            // 
            this.btnRegistrarCompra.Location = new System.Drawing.Point(337, 563);
            this.btnRegistrarCompra.Name = "btnRegistrarCompra";
            this.btnRegistrarCompra.Size = new System.Drawing.Size(163, 43);
            this.btnRegistrarCompra.TabIndex = 7;
            this.btnRegistrarCompra.Text = "Registrar compra";
            this.btnRegistrarCompra.UseVisualStyleBackColor = true;
            this.btnRegistrarCompra.Click += new System.EventHandler(this.btnRegistrarCompra_Click);
            // 
            // btnLimpiarDatos
            // 
            this.btnLimpiarDatos.Location = new System.Drawing.Point(139, 563);
            this.btnLimpiarDatos.Name = "btnLimpiarDatos";
            this.btnLimpiarDatos.Size = new System.Drawing.Size(163, 43);
            this.btnLimpiarDatos.TabIndex = 8;
            this.btnLimpiarDatos.Text = "Limpiar datos";
            this.btnLimpiarDatos.UseVisualStyleBackColor = true;
            this.btnLimpiarDatos.Click += new System.EventHandler(this.btnLimpiarDatos_Click);
            // 
            // FormCompras
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1084, 618);
            this.Controls.Add(this.btnLimpiarDatos);
            this.Controls.Add(this.btnRegistrarCompra);
            this.Controls.Add(this.gpbNuevoArticulo);
            this.Controls.Add(this.gpbDatosCompra);
            this.Controls.Add(this.grdDetalleCompra);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Location = new System.Drawing.Point(0, 0);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.MinimumSize = new System.Drawing.Size(1100, 656);
            this.Name = "FormCompras";
            this.Text = "Administración de compras";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.FormCompras_FormClosing);
            this.Controls.SetChildIndex(this.grdDetalleCompra, 0);
            this.Controls.SetChildIndex(this.gpbDatosCompra, 0);
            this.Controls.SetChildIndex(this.gpbNuevoArticulo, 0);
            this.Controls.SetChildIndex(this.btnRegistrarCompra, 0);
            this.Controls.SetChildIndex(this.btnLimpiarDatos, 0);
            ((System.ComponentModel.ISupportInitialize)(this.grdDetalleCompra)).EndInit();
            this.gpbDatosCompra.ResumeLayout(false);
            this.gpbDatosCompra.PerformLayout();
            this.gpbNuevoArticulo.ResumeLayout(false);
            this.gpbNuevoArticulo.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericCantidad)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView grdDetalleCompra;
        private System.Windows.Forms.GroupBox gpbDatosCompra;
        private System.Windows.Forms.GroupBox gpbNuevoArticulo;
        private System.Windows.Forms.Label lblMontoTotalValor;
        private System.Windows.Forms.Label lblMontoTotal;
        private System.Windows.Forms.TextBox txtComentarios;
        private System.Windows.Forms.Label lblComentarios;
        private System.Windows.Forms.ComboBox cmbProveedores;
        private System.Windows.Forms.Label lblProveedor;
        private System.Windows.Forms.DateTimePicker dtpFecha;
        private System.Windows.Forms.Label lblFecha;
        private System.Windows.Forms.Button btnNuevoArticulo;
        private System.Windows.Forms.Button btnEliminarArticulo;
        private System.Windows.Forms.Button btnGuardarArticulo;
        private System.Windows.Forms.TextBox txtPrecioArticulo;
        private System.Windows.Forms.Label lblPrecioArticulo;
        private System.Windows.Forms.NumericUpDown numericCantidad;
        private System.Windows.Forms.Label lblCantidad;
        private System.Windows.Forms.ComboBox cmbArticulos;
        private System.Windows.Forms.Label lblArticulo;
        private System.Windows.Forms.Button btnRegistrarCompra;
        private System.Windows.Forms.Button btnLimpiarDatos;
        private System.Windows.Forms.TextBox txtNroFactura;
        private System.Windows.Forms.Label lblNroFactura;
        private System.Windows.Forms.ComboBox cmbIva;
        private System.Windows.Forms.Label lblIva;
        private System.Windows.Forms.TextBox txtPrecioUnitario;
        private System.Windows.Forms.Label lblPrecioUnitario;
        private System.Windows.Forms.TextBox txtGastosExtra;
        private System.Windows.Forms.Label lblGastosExtra;
        private System.Windows.Forms.ComboBox cmbDepositos;
        private System.Windows.Forms.Label lblDepositos;
    }
}