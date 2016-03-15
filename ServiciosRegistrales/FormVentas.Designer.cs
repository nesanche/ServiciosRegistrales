namespace ServiciosRegistrales
{
    partial class FormVentas
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            this.grdDetalleVenta = new System.Windows.Forms.DataGridView();
            this.gpbDatosVenta = new System.Windows.Forms.GroupBox();
            this.btnBuscarCliente = new System.Windows.Forms.Button();
            this.chkCliente = new System.Windows.Forms.CheckBox();
            this.lblApellidoYNombreCliente = new System.Windows.Forms.Label();
            this.txtDocumento = new System.Windows.Forms.TextBox();
            this.lblDocumento = new System.Windows.Forms.Label();
            this.txtComentarios = new System.Windows.Forms.TextBox();
            this.lblComentarios = new System.Windows.Forms.Label();
            this.dtpFecha = new System.Windows.Forms.DateTimePicker();
            this.lblFecha = new System.Windows.Forms.Label();
            this.gpbNuevoArticulo = new System.Windows.Forms.GroupBox();
            this.txtCodHasta = new System.Windows.Forms.TextBox();
            this.lblCodHasta = new System.Windows.Forms.Label();
            this.txtCodDesde = new System.Windows.Forms.TextBox();
            this.lblCodDesde = new System.Windows.Forms.Label();
            this.cmbLista = new System.Windows.Forms.ComboBox();
            this.lblLista = new System.Windows.Forms.Label();
            this.lblDisponibles = new System.Windows.Forms.Label();
            this.txtCantDeposito = new System.Windows.Forms.TextBox();
            this.cmbDeposito = new System.Windows.Forms.ComboBox();
            this.txtCodArticulo = new System.Windows.Forms.TextBox();
            this.lblDescripcionArticulo = new System.Windows.Forms.Label();
            this.lblEnDeposito = new System.Windows.Forms.Label();
            this.txtPrecioUnitario = new System.Windows.Forms.TextBox();
            this.lblPrecioUnitario = new System.Windows.Forms.Label();
            this.btnNuevoArticulo = new System.Windows.Forms.Button();
            this.btnEliminarArticulo = new System.Windows.Forms.Button();
            this.btnGuardarArticulo = new System.Windows.Forms.Button();
            this.txtPrecioArticulo = new System.Windows.Forms.TextBox();
            this.lblPrecioArticulo = new System.Windows.Forms.Label();
            this.numericCantidad = new System.Windows.Forms.NumericUpDown();
            this.lblCantidad = new System.Windows.Forms.Label();
            this.lblArticulo = new System.Windows.Forms.Label();
            this.btnRegistrarVenta = new System.Windows.Forms.Button();
            this.btnLimpiarDatos = new System.Windows.Forms.Button();
            this.lblMontoTotal = new System.Windows.Forms.Label();
            this.lblMontoTotalValor = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.grdDetalleVenta)).BeginInit();
            this.gpbDatosVenta.SuspendLayout();
            this.gpbNuevoArticulo.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericCantidad)).BeginInit();
            this.SuspendLayout();
            // 
            // grdDetalleVenta
            // 
            this.grdDetalleVenta.AllowUserToAddRows = false;
            this.grdDetalleVenta.AllowUserToDeleteRows = false;
            this.grdDetalleVenta.AllowUserToResizeRows = false;
            this.grdDetalleVenta.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.grdDetalleVenta.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle3.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.grdDetalleVenta.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle3;
            this.grdDetalleVenta.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.grdDetalleVenta.Location = new System.Drawing.Point(528, 34);
            this.grdDetalleVenta.Name = "grdDetalleVenta";
            this.grdDetalleVenta.ReadOnly = true;
            this.grdDetalleVenta.RowHeadersVisible = false;
            this.grdDetalleVenta.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.grdDetalleVenta.Size = new System.Drawing.Size(544, 572);
            this.grdDetalleVenta.TabIndex = 0;
            this.grdDetalleVenta.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.grdDetalleVenta_CellClick);
            // 
            // gpbDatosVenta
            // 
            this.gpbDatosVenta.Controls.Add(this.btnBuscarCliente);
            this.gpbDatosVenta.Controls.Add(this.chkCliente);
            this.gpbDatosVenta.Controls.Add(this.lblApellidoYNombreCliente);
            this.gpbDatosVenta.Controls.Add(this.txtDocumento);
            this.gpbDatosVenta.Controls.Add(this.lblDocumento);
            this.gpbDatosVenta.Controls.Add(this.txtComentarios);
            this.gpbDatosVenta.Controls.Add(this.lblComentarios);
            this.gpbDatosVenta.Controls.Add(this.dtpFecha);
            this.gpbDatosVenta.Controls.Add(this.lblFecha);
            this.gpbDatosVenta.Location = new System.Drawing.Point(12, 25);
            this.gpbDatosVenta.Name = "gpbDatosVenta";
            this.gpbDatosVenta.Size = new System.Drawing.Size(510, 235);
            this.gpbDatosVenta.TabIndex = 1;
            this.gpbDatosVenta.TabStop = false;
            this.gpbDatosVenta.Text = "Datos de la venta";
            // 
            // btnBuscarCliente
            // 
            this.btnBuscarCliente.Enabled = false;
            this.btnBuscarCliente.Location = new System.Drawing.Point(366, 167);
            this.btnBuscarCliente.Name = "btnBuscarCliente";
            this.btnBuscarCliente.Size = new System.Drawing.Size(78, 23);
            this.btnBuscarCliente.TabIndex = 20;
            this.btnBuscarCliente.Text = "Buscar";
            this.btnBuscarCliente.UseVisualStyleBackColor = true;
            this.btnBuscarCliente.Click += new System.EventHandler(this.btnBuscarCliente_Click);
            // 
            // chkCliente
            // 
            this.chkCliente.AutoSize = true;
            this.chkCliente.Location = new System.Drawing.Point(21, 126);
            this.chkCliente.Name = "chkCliente";
            this.chkCliente.Size = new System.Drawing.Size(241, 20);
            this.chkCliente.TabIndex = 19;
            this.chkCliente.Text = "Necesito saber los datos del cliente";
            this.chkCliente.UseVisualStyleBackColor = true;
            this.chkCliente.CheckedChanged += new System.EventHandler(this.chkCliente_CheckedChanged);
            // 
            // lblApellidoYNombreCliente
            // 
            this.lblApellidoYNombreCliente.AutoSize = true;
            this.lblApellidoYNombreCliente.Location = new System.Drawing.Point(18, 204);
            this.lblApellidoYNombreCliente.Name = "lblApellidoYNombreCliente";
            this.lblApellidoYNombreCliente.Size = new System.Drawing.Size(117, 16);
            this.lblApellidoYNombreCliente.TabIndex = 15;
            this.lblApellidoYNombreCliente.Text = "Apellido y nombre";
            // 
            // txtDocumento
            // 
            this.txtDocumento.Location = new System.Drawing.Point(144, 167);
            this.txtDocumento.Name = "txtDocumento";
            this.txtDocumento.ReadOnly = true;
            this.txtDocumento.Size = new System.Drawing.Size(200, 22);
            this.txtDocumento.TabIndex = 9;
            this.txtDocumento.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtDocumento_KeyPress);
            // 
            // lblDocumento
            // 
            this.lblDocumento.AutoSize = true;
            this.lblDocumento.Location = new System.Drawing.Point(18, 170);
            this.lblDocumento.Name = "lblDocumento";
            this.lblDocumento.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.lblDocumento.Size = new System.Drawing.Size(80, 16);
            this.lblDocumento.TabIndex = 8;
            this.lblDocumento.Text = "Documento:";
            // 
            // txtComentarios
            // 
            this.txtComentarios.Location = new System.Drawing.Point(144, 60);
            this.txtComentarios.MaxLength = 200;
            this.txtComentarios.Multiline = true;
            this.txtComentarios.Name = "txtComentarios";
            this.txtComentarios.Size = new System.Drawing.Size(360, 52);
            this.txtComentarios.TabIndex = 5;
            // 
            // lblComentarios
            // 
            this.lblComentarios.AutoSize = true;
            this.lblComentarios.Location = new System.Drawing.Point(18, 63);
            this.lblComentarios.Name = "lblComentarios";
            this.lblComentarios.Size = new System.Drawing.Size(87, 16);
            this.lblComentarios.TabIndex = 4;
            this.lblComentarios.Text = "Comentarios:";
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
            this.gpbNuevoArticulo.Controls.Add(this.txtCodHasta);
            this.gpbNuevoArticulo.Controls.Add(this.lblCodHasta);
            this.gpbNuevoArticulo.Controls.Add(this.txtCodDesde);
            this.gpbNuevoArticulo.Controls.Add(this.lblCodDesde);
            this.gpbNuevoArticulo.Controls.Add(this.cmbLista);
            this.gpbNuevoArticulo.Controls.Add(this.lblLista);
            this.gpbNuevoArticulo.Controls.Add(this.lblDisponibles);
            this.gpbNuevoArticulo.Controls.Add(this.txtCantDeposito);
            this.gpbNuevoArticulo.Controls.Add(this.cmbDeposito);
            this.gpbNuevoArticulo.Controls.Add(this.txtCodArticulo);
            this.gpbNuevoArticulo.Controls.Add(this.lblDescripcionArticulo);
            this.gpbNuevoArticulo.Controls.Add(this.lblEnDeposito);
            this.gpbNuevoArticulo.Controls.Add(this.txtPrecioUnitario);
            this.gpbNuevoArticulo.Controls.Add(this.lblPrecioUnitario);
            this.gpbNuevoArticulo.Controls.Add(this.btnNuevoArticulo);
            this.gpbNuevoArticulo.Controls.Add(this.btnEliminarArticulo);
            this.gpbNuevoArticulo.Controls.Add(this.btnGuardarArticulo);
            this.gpbNuevoArticulo.Controls.Add(this.txtPrecioArticulo);
            this.gpbNuevoArticulo.Controls.Add(this.lblPrecioArticulo);
            this.gpbNuevoArticulo.Controls.Add(this.numericCantidad);
            this.gpbNuevoArticulo.Controls.Add(this.lblCantidad);
            this.gpbNuevoArticulo.Controls.Add(this.lblArticulo);
            this.gpbNuevoArticulo.Location = new System.Drawing.Point(13, 266);
            this.gpbNuevoArticulo.Name = "gpbNuevoArticulo";
            this.gpbNuevoArticulo.Size = new System.Drawing.Size(509, 262);
            this.gpbNuevoArticulo.TabIndex = 2;
            this.gpbNuevoArticulo.TabStop = false;
            this.gpbNuevoArticulo.Text = "Agregar un nuevo artículo";
            // 
            // txtCodHasta
            // 
            this.txtCodHasta.Location = new System.Drawing.Point(348, 113);
            this.txtCodHasta.Name = "txtCodHasta";
            this.txtCodHasta.ReadOnly = true;
            this.txtCodHasta.Size = new System.Drawing.Size(137, 22);
            this.txtCodHasta.TabIndex = 23;
            this.txtCodHasta.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // lblCodHasta
            // 
            this.lblCodHasta.AutoSize = true;
            this.lblCodHasta.Location = new System.Drawing.Point(274, 113);
            this.lblCodHasta.Name = "lblCodHasta";
            this.lblCodHasta.Size = new System.Drawing.Size(47, 16);
            this.lblCodHasta.TabIndex = 22;
            this.lblCodHasta.Text = "Hasta:";
            // 
            // txtCodDesde
            // 
            this.txtCodDesde.Location = new System.Drawing.Point(92, 113);
            this.txtCodDesde.Name = "txtCodDesde";
            this.txtCodDesde.ReadOnly = true;
            this.txtCodDesde.Size = new System.Drawing.Size(111, 22);
            this.txtCodDesde.TabIndex = 21;
            this.txtCodDesde.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // lblCodDesde
            // 
            this.lblCodDesde.AutoSize = true;
            this.lblCodDesde.Location = new System.Drawing.Point(11, 116);
            this.lblCodDesde.Name = "lblCodDesde";
            this.lblCodDesde.Size = new System.Drawing.Size(52, 16);
            this.lblCodDesde.TabIndex = 20;
            this.lblCodDesde.Text = "Desde:";
            // 
            // cmbLista
            // 
            this.cmbLista.DisplayMember = "nombre";
            this.cmbLista.FormattingEnabled = true;
            this.cmbLista.Location = new System.Drawing.Point(391, 149);
            this.cmbLista.Name = "cmbLista";
            this.cmbLista.Size = new System.Drawing.Size(95, 24);
            this.cmbLista.TabIndex = 19;
            this.cmbLista.ValueMember = "id";
            this.cmbLista.SelectedIndexChanged += new System.EventHandler(this.actualizarPrecio);
            // 
            // lblLista
            // 
            this.lblLista.AutoSize = true;
            this.lblLista.Location = new System.Drawing.Point(274, 153);
            this.lblLista.Name = "lblLista";
            this.lblLista.Size = new System.Drawing.Size(106, 16);
            this.lblLista.TabIndex = 18;
            this.lblLista.Text = "Lista de precios:";
            // 
            // lblDisponibles
            // 
            this.lblDisponibles.AutoSize = true;
            this.lblDisponibles.Location = new System.Drawing.Point(274, 76);
            this.lblDisponibles.Name = "lblDisponibles";
            this.lblDisponibles.Size = new System.Drawing.Size(109, 16);
            this.lblDisponibles.TabIndex = 17;
            this.lblDisponibles.Text = "Hay disponibles:";
            // 
            // txtCantDeposito
            // 
            this.txtCantDeposito.Location = new System.Drawing.Point(394, 73);
            this.txtCantDeposito.Name = "txtCantDeposito";
            this.txtCantDeposito.ReadOnly = true;
            this.txtCantDeposito.Size = new System.Drawing.Size(92, 22);
            this.txtCantDeposito.TabIndex = 16;
            this.txtCantDeposito.Text = "0";
            this.txtCantDeposito.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // cmbDeposito
            // 
            this.cmbDeposito.DisplayMember = "descripcion";
            this.cmbDeposito.FormattingEnabled = true;
            this.cmbDeposito.Location = new System.Drawing.Point(115, 73);
            this.cmbDeposito.Name = "cmbDeposito";
            this.cmbDeposito.Size = new System.Drawing.Size(141, 24);
            this.cmbDeposito.TabIndex = 15;
            this.cmbDeposito.ValueMember = "id";
            this.cmbDeposito.SelectedIndexChanged += new System.EventHandler(this.cmbDeposito_SelectedIndexChanged);
            // 
            // txtCodArticulo
            // 
            this.txtCodArticulo.Location = new System.Drawing.Point(92, 33);
            this.txtCodArticulo.Name = "txtCodArticulo";
            this.txtCodArticulo.Size = new System.Drawing.Size(80, 22);
            this.txtCodArticulo.TabIndex = 14;
            this.txtCodArticulo.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtCodArticulo_KeyPress);
            this.txtCodArticulo.KeyUp += new System.Windows.Forms.KeyEventHandler(this.txtCodArticulo_KeyDown);
            // 
            // lblDescripcionArticulo
            // 
            this.lblDescripcionArticulo.AutoSize = true;
            this.lblDescripcionArticulo.Location = new System.Drawing.Point(188, 36);
            this.lblDescripcionArticulo.Name = "lblDescripcionArticulo";
            this.lblDescripcionArticulo.Size = new System.Drawing.Size(162, 16);
            this.lblDescripcionArticulo.TabIndex = 13;
            this.lblDescripcionArticulo.Text = "<Descripción del artículo>";
            // 
            // lblEnDeposito
            // 
            this.lblEnDeposito.AutoSize = true;
            this.lblEnDeposito.Location = new System.Drawing.Point(11, 76);
            this.lblEnDeposito.Name = "lblEnDeposito";
            this.lblEnDeposito.Size = new System.Drawing.Size(83, 16);
            this.lblEnDeposito.TabIndex = 11;
            this.lblEnDeposito.Text = "En depósito:";
            // 
            // txtPrecioUnitario
            // 
            this.txtPrecioUnitario.Location = new System.Drawing.Point(143, 188);
            this.txtPrecioUnitario.Name = "txtPrecioUnitario";
            this.txtPrecioUnitario.ReadOnly = true;
            this.txtPrecioUnitario.Size = new System.Drawing.Size(96, 22);
            this.txtPrecioUnitario.TabIndex = 10;
            this.txtPrecioUnitario.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // lblPrecioUnitario
            // 
            this.lblPrecioUnitario.AutoSize = true;
            this.lblPrecioUnitario.Location = new System.Drawing.Point(11, 191);
            this.lblPrecioUnitario.Name = "lblPrecioUnitario";
            this.lblPrecioUnitario.Size = new System.Drawing.Size(96, 16);
            this.lblPrecioUnitario.TabIndex = 9;
            this.lblPrecioUnitario.Text = "Precio unitario:";
            // 
            // btnNuevoArticulo
            // 
            this.btnNuevoArticulo.Enabled = false;
            this.btnNuevoArticulo.Location = new System.Drawing.Point(20, 218);
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
            this.btnEliminarArticulo.Location = new System.Drawing.Point(191, 218);
            this.btnEliminarArticulo.Name = "btnEliminarArticulo";
            this.btnEliminarArticulo.Size = new System.Drawing.Size(122, 33);
            this.btnEliminarArticulo.TabIndex = 7;
            this.btnEliminarArticulo.Text = "Eliminar";
            this.btnEliminarArticulo.UseVisualStyleBackColor = true;
            this.btnEliminarArticulo.Click += new System.EventHandler(this.btnEliminarArticulo_Click);
            // 
            // btnGuardarArticulo
            // 
            this.btnGuardarArticulo.Location = new System.Drawing.Point(365, 218);
            this.btnGuardarArticulo.Name = "btnGuardarArticulo";
            this.btnGuardarArticulo.Size = new System.Drawing.Size(122, 33);
            this.btnGuardarArticulo.TabIndex = 6;
            this.btnGuardarArticulo.Text = "Guardar artículo";
            this.btnGuardarArticulo.UseVisualStyleBackColor = true;
            this.btnGuardarArticulo.Click += new System.EventHandler(this.btnGuardarArticulo_Click);
            // 
            // txtPrecioArticulo
            // 
            this.txtPrecioArticulo.Location = new System.Drawing.Point(391, 188);
            this.txtPrecioArticulo.Name = "txtPrecioArticulo";
            this.txtPrecioArticulo.ReadOnly = true;
            this.txtPrecioArticulo.Size = new System.Drawing.Size(96, 22);
            this.txtPrecioArticulo.TabIndex = 5;
            this.txtPrecioArticulo.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // lblPrecioArticulo
            // 
            this.lblPrecioArticulo.AutoSize = true;
            this.lblPrecioArticulo.Location = new System.Drawing.Point(274, 191);
            this.lblPrecioArticulo.Name = "lblPrecioArticulo";
            this.lblPrecioArticulo.Size = new System.Drawing.Size(78, 16);
            this.lblPrecioArticulo.TabIndex = 4;
            this.lblPrecioArticulo.Text = "Precio total:";
            // 
            // numericCantidad
            // 
            this.numericCantidad.Location = new System.Drawing.Point(92, 152);
            this.numericCantidad.Name = "numericCantidad";
            this.numericCantidad.Size = new System.Drawing.Size(80, 22);
            this.numericCantidad.TabIndex = 3;
            this.numericCantidad.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.numericCantidad.ValueChanged += new System.EventHandler(this.actualizarPrecio);
            // 
            // lblCantidad
            // 
            this.lblCantidad.AutoSize = true;
            this.lblCantidad.Location = new System.Drawing.Point(11, 154);
            this.lblCantidad.Name = "lblCantidad";
            this.lblCantidad.Size = new System.Drawing.Size(65, 16);
            this.lblCantidad.TabIndex = 2;
            this.lblCantidad.Text = "Cantidad:";
            // 
            // lblArticulo
            // 
            this.lblArticulo.AutoSize = true;
            this.lblArticulo.Location = new System.Drawing.Point(11, 36);
            this.lblArticulo.Name = "lblArticulo";
            this.lblArticulo.Size = new System.Drawing.Size(55, 16);
            this.lblArticulo.TabIndex = 0;
            this.lblArticulo.Text = "Artículo:";
            // 
            // btnRegistrarVenta
            // 
            this.btnRegistrarVenta.Location = new System.Drawing.Point(337, 563);
            this.btnRegistrarVenta.Name = "btnRegistrarVenta";
            this.btnRegistrarVenta.Size = new System.Drawing.Size(163, 43);
            this.btnRegistrarVenta.TabIndex = 7;
            this.btnRegistrarVenta.Text = "Registrar venta";
            this.btnRegistrarVenta.UseVisualStyleBackColor = true;
            this.btnRegistrarVenta.Click += new System.EventHandler(this.btnRegistrarVenta_Click);
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
            // lblMontoTotal
            // 
            this.lblMontoTotal.AutoSize = true;
            this.lblMontoTotal.Location = new System.Drawing.Point(30, 541);
            this.lblMontoTotal.Name = "lblMontoTotal";
            this.lblMontoTotal.Size = new System.Drawing.Size(89, 16);
            this.lblMontoTotal.TabIndex = 9;
            this.lblMontoTotal.Text = "Monto total:  $";
            // 
            // lblMontoTotalValor
            // 
            this.lblMontoTotalValor.AutoSize = true;
            this.lblMontoTotalValor.Location = new System.Drawing.Point(125, 541);
            this.lblMontoTotalValor.Name = "lblMontoTotalValor";
            this.lblMontoTotalValor.Size = new System.Drawing.Size(15, 16);
            this.lblMontoTotalValor.TabIndex = 10;
            this.lblMontoTotalValor.Text = "0";
            // 
            // FormVentas
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1084, 618);
            this.Controls.Add(this.lblMontoTotalValor);
            this.Controls.Add(this.lblMontoTotal);
            this.Controls.Add(this.btnLimpiarDatos);
            this.Controls.Add(this.btnRegistrarVenta);
            this.Controls.Add(this.gpbNuevoArticulo);
            this.Controls.Add(this.gpbDatosVenta);
            this.Controls.Add(this.grdDetalleVenta);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Location = new System.Drawing.Point(0, 0);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.MinimumSize = new System.Drawing.Size(1100, 656);
            this.Name = "FormVentas";
            this.Text = "Administración de ventas";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.FormVentas_FormClosing);
            this.Controls.SetChildIndex(this.grdDetalleVenta, 0);
            this.Controls.SetChildIndex(this.gpbDatosVenta, 0);
            this.Controls.SetChildIndex(this.gpbNuevoArticulo, 0);
            this.Controls.SetChildIndex(this.btnRegistrarVenta, 0);
            this.Controls.SetChildIndex(this.btnLimpiarDatos, 0);
            this.Controls.SetChildIndex(this.lblMontoTotal, 0);
            this.Controls.SetChildIndex(this.lblMontoTotalValor, 0);
            ((System.ComponentModel.ISupportInitialize)(this.grdDetalleVenta)).EndInit();
            this.gpbDatosVenta.ResumeLayout(false);
            this.gpbDatosVenta.PerformLayout();
            this.gpbNuevoArticulo.ResumeLayout(false);
            this.gpbNuevoArticulo.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericCantidad)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView grdDetalleVenta;
        private System.Windows.Forms.GroupBox gpbDatosVenta;
        private System.Windows.Forms.GroupBox gpbNuevoArticulo;
        private System.Windows.Forms.TextBox txtComentarios;
        private System.Windows.Forms.Label lblComentarios;
        private System.Windows.Forms.DateTimePicker dtpFecha;
        private System.Windows.Forms.Label lblFecha;
        private System.Windows.Forms.Button btnNuevoArticulo;
        private System.Windows.Forms.Button btnEliminarArticulo;
        private System.Windows.Forms.Button btnGuardarArticulo;
        private System.Windows.Forms.TextBox txtPrecioArticulo;
        private System.Windows.Forms.Label lblPrecioArticulo;
        private System.Windows.Forms.NumericUpDown numericCantidad;
        private System.Windows.Forms.Label lblCantidad;
        private System.Windows.Forms.Label lblArticulo;
        private System.Windows.Forms.Button btnRegistrarVenta;
        private System.Windows.Forms.Button btnLimpiarDatos;
        private System.Windows.Forms.TextBox txtDocumento;
        private System.Windows.Forms.Label lblDocumento;
        private System.Windows.Forms.Label lblEnDeposito;
        private System.Windows.Forms.TextBox txtPrecioUnitario;
        private System.Windows.Forms.Label lblPrecioUnitario;
        private System.Windows.Forms.Label lblApellidoYNombreCliente;
        private System.Windows.Forms.CheckBox chkCliente;
        private System.Windows.Forms.Button btnBuscarCliente;
        private System.Windows.Forms.TextBox txtCodArticulo;
        private System.Windows.Forms.Label lblDescripcionArticulo;
        private System.Windows.Forms.Label lblMontoTotal;
        private System.Windows.Forms.Label lblMontoTotalValor;
        private System.Windows.Forms.Label lblDisponibles;
        private System.Windows.Forms.TextBox txtCantDeposito;
        private System.Windows.Forms.ComboBox cmbDeposito;
        private System.Windows.Forms.ComboBox cmbLista;
        private System.Windows.Forms.Label lblLista;
        private System.Windows.Forms.TextBox txtCodHasta;
        private System.Windows.Forms.Label lblCodHasta;
        private System.Windows.Forms.TextBox txtCodDesde;
        private System.Windows.Forms.Label lblCodDesde;
    }
}