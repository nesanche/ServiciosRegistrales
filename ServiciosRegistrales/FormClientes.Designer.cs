namespace ServiciosRegistrales
{
    partial class FormClientes
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
            this.lblApellido = new System.Windows.Forms.Label();
            this.txtApellido = new System.Windows.Forms.TextBox();
            this.gbDatosCliente = new System.Windows.Forms.GroupBox();
            this.txtId = new System.Windows.Forms.TextBox();
            this.lblIdCliente = new System.Windows.Forms.Label();
            this.dtpFechaNacimiento = new System.Windows.Forms.DateTimePicker();
            this.lblDocumento = new System.Windows.Forms.Label();
            this.txtDocumento = new System.Windows.Forms.TextBox();
            this.lblDomicilio = new System.Windows.Forms.Label();
            this.txtDomicilio = new System.Windows.Forms.TextBox();
            this.lblTelefono = new System.Windows.Forms.Label();
            this.txtTelefono = new System.Windows.Forms.TextBox();
            this.lblMail = new System.Windows.Forms.Label();
            this.txtMail = new System.Windows.Forms.TextBox();
            this.lblFechaNacimiento = new System.Windows.Forms.Label();
            this.lblNombre = new System.Windows.Forms.Label();
            this.txtNombre = new System.Windows.Forms.TextBox();
            this.grdClientes = new System.Windows.Forms.DataGridView();
            this.btnGuardar = new System.Windows.Forms.Button();
            this.btnEliminar = new System.Windows.Forms.Button();
            this.btnNuevo = new System.Windows.Forms.Button();
            this.btnBuscar = new System.Windows.Forms.Button();
            this.txtBuscar = new System.Windows.Forms.TextBox();
            this.btnLimpiarFiltro = new System.Windows.Forms.Button();
            this.lblInstruccionesBusqueda = new System.Windows.Forms.Label();
            this.id = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.campoBaja = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.documento = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.apellido = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nombre = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.fechaNacimiento = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.mail = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.telefono = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.domicilio = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.gbDatosCliente.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.grdClientes)).BeginInit();
            this.SuspendLayout();
            // 
            // lblApellido
            // 
            this.lblApellido.AutoSize = true;
            this.lblApellido.Location = new System.Drawing.Point(29, 106);
            this.lblApellido.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblApellido.Name = "lblApellido";
            this.lblApellido.Size = new System.Drawing.Size(61, 16);
            this.lblApellido.TabIndex = 1;
            this.lblApellido.Text = "Apellido:";
            // 
            // txtApellido
            // 
            this.txtApellido.Location = new System.Drawing.Point(207, 103);
            this.txtApellido.Margin = new System.Windows.Forms.Padding(4);
            this.txtApellido.Name = "txtApellido";
            this.txtApellido.Size = new System.Drawing.Size(263, 22);
            this.txtApellido.TabIndex = 2;
            // 
            // gbDatosCliente
            // 
            this.gbDatosCliente.AutoSize = true;
            this.gbDatosCliente.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.gbDatosCliente.Controls.Add(this.txtId);
            this.gbDatosCliente.Controls.Add(this.lblIdCliente);
            this.gbDatosCliente.Controls.Add(this.dtpFechaNacimiento);
            this.gbDatosCliente.Controls.Add(this.lblDocumento);
            this.gbDatosCliente.Controls.Add(this.txtDocumento);
            this.gbDatosCliente.Controls.Add(this.lblDomicilio);
            this.gbDatosCliente.Controls.Add(this.txtDomicilio);
            this.gbDatosCliente.Controls.Add(this.lblTelefono);
            this.gbDatosCliente.Controls.Add(this.txtTelefono);
            this.gbDatosCliente.Controls.Add(this.lblMail);
            this.gbDatosCliente.Controls.Add(this.txtMail);
            this.gbDatosCliente.Controls.Add(this.lblFechaNacimiento);
            this.gbDatosCliente.Controls.Add(this.lblNombre);
            this.gbDatosCliente.Controls.Add(this.txtNombre);
            this.gbDatosCliente.Controls.Add(this.lblApellido);
            this.gbDatosCliente.Controls.Add(this.txtApellido);
            this.gbDatosCliente.Dock = System.Windows.Forms.DockStyle.Top;
            this.gbDatosCliente.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gbDatosCliente.Location = new System.Drawing.Point(0, 24);
            this.gbDatosCliente.Margin = new System.Windows.Forms.Padding(4);
            this.gbDatosCliente.Name = "gbDatosCliente";
            this.gbDatosCliente.Padding = new System.Windows.Forms.Padding(4);
            this.gbDatosCliente.Size = new System.Drawing.Size(1084, 196);
            this.gbDatosCliente.TabIndex = 3;
            this.gbDatosCliente.TabStop = false;
            this.gbDatosCliente.Text = "Datos del cliente";
            // 
            // txtId
            // 
            this.txtId.Location = new System.Drawing.Point(207, 22);
            this.txtId.Name = "txtId";
            this.txtId.ReadOnly = true;
            this.txtId.Size = new System.Drawing.Size(263, 22);
            this.txtId.TabIndex = 15;
            // 
            // lblIdCliente
            // 
            this.lblIdCliente.AutoSize = true;
            this.lblIdCliente.Location = new System.Drawing.Point(29, 26);
            this.lblIdCliente.Name = "lblIdCliente";
            this.lblIdCliente.Size = new System.Drawing.Size(94, 16);
            this.lblIdCliente.TabIndex = 14;
            this.lblIdCliente.Text = "Nro de cliente:";
            // 
            // dtpFechaNacimiento
            // 
            this.dtpFechaNacimiento.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.dtpFechaNacimiento.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpFechaNacimiento.Location = new System.Drawing.Point(773, 20);
            this.dtpFechaNacimiento.Name = "dtpFechaNacimiento";
            this.dtpFechaNacimiento.Size = new System.Drawing.Size(280, 22);
            this.dtpFechaNacimiento.TabIndex = 4;
            // 
            // lblDocumento
            // 
            this.lblDocumento.AutoSize = true;
            this.lblDocumento.Location = new System.Drawing.Point(29, 63);
            this.lblDocumento.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblDocumento.Name = "lblDocumento";
            this.lblDocumento.Size = new System.Drawing.Size(80, 16);
            this.lblDocumento.TabIndex = 13;
            this.lblDocumento.Text = "Documento:";
            // 
            // txtDocumento
            // 
            this.txtDocumento.Location = new System.Drawing.Point(207, 60);
            this.txtDocumento.Margin = new System.Windows.Forms.Padding(4);
            this.txtDocumento.Name = "txtDocumento";
            this.txtDocumento.Size = new System.Drawing.Size(263, 22);
            this.txtDocumento.TabIndex = 1;
            this.txtDocumento.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtDocumento_KeyPress);
            // 
            // lblDomicilio
            // 
            this.lblDomicilio.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.lblDomicilio.AutoSize = true;
            this.lblDomicilio.Location = new System.Drawing.Point(595, 151);
            this.lblDomicilio.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblDomicilio.Name = "lblDomicilio";
            this.lblDomicilio.Size = new System.Drawing.Size(67, 16);
            this.lblDomicilio.TabIndex = 11;
            this.lblDomicilio.Text = "Domicilio:";
            // 
            // txtDomicilio
            // 
            this.txtDomicilio.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.txtDomicilio.Location = new System.Drawing.Point(773, 151);
            this.txtDomicilio.Margin = new System.Windows.Forms.Padding(4);
            this.txtDomicilio.MaxLength = 200;
            this.txtDomicilio.Name = "txtDomicilio";
            this.txtDomicilio.Size = new System.Drawing.Size(280, 22);
            this.txtDomicilio.TabIndex = 7;
            // 
            // lblTelefono
            // 
            this.lblTelefono.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.lblTelefono.AutoSize = true;
            this.lblTelefono.Location = new System.Drawing.Point(595, 109);
            this.lblTelefono.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblTelefono.Name = "lblTelefono";
            this.lblTelefono.Size = new System.Drawing.Size(65, 16);
            this.lblTelefono.TabIndex = 9;
            this.lblTelefono.Text = "Teléfono:";
            // 
            // txtTelefono
            // 
            this.txtTelefono.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.txtTelefono.Location = new System.Drawing.Point(773, 106);
            this.txtTelefono.Margin = new System.Windows.Forms.Padding(4);
            this.txtTelefono.Name = "txtTelefono";
            this.txtTelefono.Size = new System.Drawing.Size(280, 22);
            this.txtTelefono.TabIndex = 6;
            this.txtTelefono.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtTelefono_KeyPress);
            // 
            // lblMail
            // 
            this.lblMail.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.lblMail.AutoSize = true;
            this.lblMail.Location = new System.Drawing.Point(595, 63);
            this.lblMail.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblMail.Name = "lblMail";
            this.lblMail.Size = new System.Drawing.Size(36, 16);
            this.lblMail.TabIndex = 7;
            this.lblMail.Text = "Mail:";
            // 
            // txtMail
            // 
            this.txtMail.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.txtMail.Location = new System.Drawing.Point(773, 63);
            this.txtMail.Margin = new System.Windows.Forms.Padding(4);
            this.txtMail.Name = "txtMail";
            this.txtMail.Size = new System.Drawing.Size(280, 22);
            this.txtMail.TabIndex = 5;
            // 
            // lblFechaNacimiento
            // 
            this.lblFechaNacimiento.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.lblFechaNacimiento.AutoSize = true;
            this.lblFechaNacimiento.Location = new System.Drawing.Point(595, 25);
            this.lblFechaNacimiento.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblFechaNacimiento.Name = "lblFechaNacimiento";
            this.lblFechaNacimiento.Size = new System.Drawing.Size(136, 16);
            this.lblFechaNacimiento.TabIndex = 5;
            this.lblFechaNacimiento.Text = "Fecha de nacimiento:";
            // 
            // lblNombre
            // 
            this.lblNombre.AutoSize = true;
            this.lblNombre.Location = new System.Drawing.Point(29, 151);
            this.lblNombre.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblNombre.Name = "lblNombre";
            this.lblNombre.Size = new System.Drawing.Size(60, 16);
            this.lblNombre.TabIndex = 3;
            this.lblNombre.Text = "Nombre:";
            // 
            // txtNombre
            // 
            this.txtNombre.Location = new System.Drawing.Point(207, 148);
            this.txtNombre.Margin = new System.Windows.Forms.Padding(4);
            this.txtNombre.Name = "txtNombre";
            this.txtNombre.Size = new System.Drawing.Size(263, 22);
            this.txtNombre.TabIndex = 3;
            // 
            // grdClientes
            // 
            this.grdClientes.AllowUserToAddRows = false;
            this.grdClientes.AllowUserToDeleteRows = false;
            this.grdClientes.AllowUserToResizeRows = false;
            this.grdClientes.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.grdClientes.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.grdClientes.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.grdClientes.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.id,
            this.campoBaja,
            this.documento,
            this.apellido,
            this.nombre,
            this.fechaNacimiento,
            this.mail,
            this.telefono,
            this.domicilio});
            this.grdClientes.Location = new System.Drawing.Point(20, 291);
            this.grdClientes.Margin = new System.Windows.Forms.Padding(4);
            this.grdClientes.Name = "grdClientes";
            this.grdClientes.ReadOnly = true;
            this.grdClientes.RowHeadersVisible = false;
            this.grdClientes.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.grdClientes.Size = new System.Drawing.Size(1050, 254);
            this.grdClientes.TabIndex = 14;
            this.grdClientes.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.grdClientes_CellContentClick);
            this.grdClientes.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.grdClientes_CellContentClick);
            this.grdClientes.ColumnHeaderMouseClick += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.grdClientes_ColumnHeaderMouseClick);
            this.grdClientes.DataBindingComplete += new System.Windows.Forms.DataGridViewBindingCompleteEventHandler(this.grdClientes_DataBindingComplete);
            // 
            // btnGuardar
            // 
            this.btnGuardar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnGuardar.Location = new System.Drawing.Point(918, 567);
            this.btnGuardar.Margin = new System.Windows.Forms.Padding(4);
            this.btnGuardar.Name = "btnGuardar";
            this.btnGuardar.Size = new System.Drawing.Size(153, 28);
            this.btnGuardar.TabIndex = 8;
            this.btnGuardar.Text = "Guardar cambios";
            this.btnGuardar.UseVisualStyleBackColor = true;
            this.btnGuardar.Click += new System.EventHandler(this.btnGuardar_Click);
            // 
            // btnEliminar
            // 
            this.btnEliminar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnEliminar.Enabled = false;
            this.btnEliminar.Location = new System.Drawing.Point(787, 567);
            this.btnEliminar.Margin = new System.Windows.Forms.Padding(4);
            this.btnEliminar.Name = "btnEliminar";
            this.btnEliminar.Size = new System.Drawing.Size(100, 28);
            this.btnEliminar.TabIndex = 23;
            this.btnEliminar.Text = "Eliminar";
            this.btnEliminar.UseVisualStyleBackColor = true;
            this.btnEliminar.Click += new System.EventHandler(this.btnEliminar_Click);
            // 
            // btnNuevo
            // 
            this.btnNuevo.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnNuevo.Enabled = false;
            this.btnNuevo.Location = new System.Drawing.Point(612, 567);
            this.btnNuevo.Margin = new System.Windows.Forms.Padding(4);
            this.btnNuevo.Name = "btnNuevo";
            this.btnNuevo.Size = new System.Drawing.Size(141, 28);
            this.btnNuevo.TabIndex = 24;
            this.btnNuevo.Text = "Ingresar Nuevo";
            this.btnNuevo.UseVisualStyleBackColor = true;
            this.btnNuevo.Click += new System.EventHandler(this.btnNuevo_Click);
            // 
            // btnBuscar
            // 
            this.btnBuscar.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnBuscar.Location = new System.Drawing.Point(207, 255);
            this.btnBuscar.Margin = new System.Windows.Forms.Padding(4);
            this.btnBuscar.Name = "btnBuscar";
            this.btnBuscar.Size = new System.Drawing.Size(109, 28);
            this.btnBuscar.TabIndex = 9;
            this.btnBuscar.Text = "Buscar";
            this.btnBuscar.UseVisualStyleBackColor = true;
            this.btnBuscar.Click += new System.EventHandler(this.btnBuscar_Click);
            // 
            // txtBuscar
            // 
            this.txtBuscar.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtBuscar.Location = new System.Drawing.Point(341, 255);
            this.txtBuscar.Margin = new System.Windows.Forms.Padding(4);
            this.txtBuscar.Name = "txtBuscar";
            this.txtBuscar.Size = new System.Drawing.Size(257, 22);
            this.txtBuscar.TabIndex = 12;
            // 
            // btnLimpiarFiltro
            // 
            this.btnLimpiarFiltro.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLimpiarFiltro.Location = new System.Drawing.Point(16, 255);
            this.btnLimpiarFiltro.Margin = new System.Windows.Forms.Padding(4);
            this.btnLimpiarFiltro.Name = "btnLimpiarFiltro";
            this.btnLimpiarFiltro.Size = new System.Drawing.Size(183, 28);
            this.btnLimpiarFiltro.TabIndex = 10;
            this.btnLimpiarFiltro.Text = "Limpiar búsqueda";
            this.btnLimpiarFiltro.UseVisualStyleBackColor = true;
            this.btnLimpiarFiltro.Click += new System.EventHandler(this.btnLimpiarFiltro_Click);
            // 
            // lblInstruccionesBusqueda
            // 
            this.lblInstruccionesBusqueda.AutoSize = true;
            this.lblInstruccionesBusqueda.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblInstruccionesBusqueda.Location = new System.Drawing.Point(625, 258);
            this.lblInstruccionesBusqueda.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblInstruccionesBusqueda.Name = "lblInstruccionesBusqueda";
            this.lblInstruccionesBusqueda.Size = new System.Drawing.Size(354, 16);
            this.lblInstruccionesBusqueda.TabIndex = 11;
            this.lblInstruccionesBusqueda.Text = "Ingrese el  apellido y presione \"Buscar\" para filtrar la grilla.";
            // 
            // id
            // 
            this.id.DataPropertyName = "id";
            this.id.HeaderText = "Número";
            this.id.Name = "id";
            this.id.ReadOnly = true;
            // 
            // campoBaja
            // 
            this.campoBaja.DataPropertyName = "campoBaja";
            this.campoBaja.HeaderText = "Campo Baja";
            this.campoBaja.Name = "campoBaja";
            this.campoBaja.ReadOnly = true;
            this.campoBaja.Visible = false;
            // 
            // documento
            // 
            this.documento.DataPropertyName = "documento";
            this.documento.HeaderText = "Documento";
            this.documento.Name = "documento";
            this.documento.ReadOnly = true;
            // 
            // apellido
            // 
            this.apellido.DataPropertyName = "apellido";
            this.apellido.HeaderText = "Apellido";
            this.apellido.Name = "apellido";
            this.apellido.ReadOnly = true;
            // 
            // nombre
            // 
            this.nombre.DataPropertyName = "nombre";
            this.nombre.HeaderText = "Nombre";
            this.nombre.Name = "nombre";
            this.nombre.ReadOnly = true;
            // 
            // fechaNacimiento
            // 
            this.fechaNacimiento.DataPropertyName = "fechaNacimiento";
            this.fechaNacimiento.HeaderText = "Fecha de Nacimiento";
            this.fechaNacimiento.Name = "fechaNacimiento";
            this.fechaNacimiento.ReadOnly = true;
            // 
            // mail
            // 
            this.mail.DataPropertyName = "mail";
            this.mail.HeaderText = "Mail";
            this.mail.Name = "mail";
            this.mail.ReadOnly = true;
            // 
            // telefono
            // 
            this.telefono.DataPropertyName = "telefono";
            this.telefono.HeaderText = "Teléfono";
            this.telefono.Name = "telefono";
            this.telefono.ReadOnly = true;
            // 
            // domicilio
            // 
            this.domicilio.DataPropertyName = "domicilio";
            this.domicilio.HeaderText = "Domicilio";
            this.domicilio.Name = "domicilio";
            this.domicilio.ReadOnly = true;
            // 
            // FormClientes
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1084, 618);
            this.Controls.Add(this.lblInstruccionesBusqueda);
            this.Controls.Add(this.btnLimpiarFiltro);
            this.Controls.Add(this.txtBuscar);
            this.Controls.Add(this.btnBuscar);
            this.Controls.Add(this.btnNuevo);
            this.Controls.Add(this.btnEliminar);
            this.Controls.Add(this.btnGuardar);
            this.Controls.Add(this.grdClientes);
            this.Controls.Add(this.gbDatosCliente);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Location = new System.Drawing.Point(0, 0);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.MinimumSize = new System.Drawing.Size(1100, 656);
            this.Name = "FormClientes";
            this.Text = "Administración de clientes";
            this.WindowState = System.Windows.Forms.FormWindowState.Normal;
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.FormClientes_FormClosing);
            this.Controls.SetChildIndex(this.gbDatosCliente, 0);
            this.Controls.SetChildIndex(this.grdClientes, 0);
            this.Controls.SetChildIndex(this.btnGuardar, 0);
            this.Controls.SetChildIndex(this.btnEliminar, 0);
            this.Controls.SetChildIndex(this.btnNuevo, 0);
            this.Controls.SetChildIndex(this.btnBuscar, 0);
            this.Controls.SetChildIndex(this.txtBuscar, 0);
            this.Controls.SetChildIndex(this.btnLimpiarFiltro, 0);
            this.Controls.SetChildIndex(this.lblInstruccionesBusqueda, 0);
            this.gbDatosCliente.ResumeLayout(false);
            this.gbDatosCliente.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.grdClientes)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblApellido;
        private System.Windows.Forms.TextBox txtApellido;
        private System.Windows.Forms.GroupBox gbDatosCliente;
        private System.Windows.Forms.Label lblDomicilio;
        private System.Windows.Forms.TextBox txtDomicilio;
        private System.Windows.Forms.Label lblTelefono;
        private System.Windows.Forms.TextBox txtTelefono;
        private System.Windows.Forms.Label lblMail;
        private System.Windows.Forms.TextBox txtMail;
        private System.Windows.Forms.Label lblFechaNacimiento;
        private System.Windows.Forms.Label lblNombre;
        private System.Windows.Forms.TextBox txtNombre;
        private System.Windows.Forms.DataGridView grdClientes;
        private System.Windows.Forms.Button btnGuardar;
        private System.Windows.Forms.Button btnEliminar;
        private System.Windows.Forms.Button btnNuevo;
        private System.Windows.Forms.Button btnBuscar;
        private System.Windows.Forms.TextBox txtBuscar;
        private System.Windows.Forms.Button btnLimpiarFiltro;
        private System.Windows.Forms.Label lblInstruccionesBusqueda;
        private System.Windows.Forms.DateTimePicker dtpFechaNacimiento;
        private System.Windows.Forms.Label lblDocumento;
        private System.Windows.Forms.TextBox txtDocumento;
        private System.Windows.Forms.TextBox txtId;
        private System.Windows.Forms.Label lblIdCliente;
        private System.Windows.Forms.DataGridViewTextBoxColumn id;
        private System.Windows.Forms.DataGridViewTextBoxColumn campoBaja;
        private System.Windows.Forms.DataGridViewTextBoxColumn documento;
        private System.Windows.Forms.DataGridViewTextBoxColumn apellido;
        private System.Windows.Forms.DataGridViewTextBoxColumn nombre;
        private System.Windows.Forms.DataGridViewTextBoxColumn fechaNacimiento;
        private System.Windows.Forms.DataGridViewTextBoxColumn mail;
        private System.Windows.Forms.DataGridViewTextBoxColumn telefono;
        private System.Windows.Forms.DataGridViewTextBoxColumn domicilio;
    }
}