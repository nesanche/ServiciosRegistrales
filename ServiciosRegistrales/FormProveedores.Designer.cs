namespace ServiciosRegistrales
{
    partial class FormProveedores
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
            this.lblDomicilio = new System.Windows.Forms.Label();
            this.txtDomicilio = new System.Windows.Forms.TextBox();
            this.gbDatosProveedor = new System.Windows.Forms.GroupBox();
            this.txtComentarios = new System.Windows.Forms.TextBox();
            this.lblComentarios = new System.Windows.Forms.Label();
            this.cmbTipo = new System.Windows.Forms.ComboBox();
            this.lblTipo = new System.Windows.Forms.Label();
            this.txtContacto = new System.Windows.Forms.TextBox();
            this.lblContacto = new System.Windows.Forms.Label();
            this.lblRazonSocial = new System.Windows.Forms.Label();
            this.txtRazonSocial = new System.Windows.Forms.TextBox();
            this.lblCuit = new System.Windows.Forms.Label();
            this.txtCuit = new System.Windows.Forms.TextBox();
            this.lblUrl = new System.Windows.Forms.Label();
            this.txtUrl = new System.Windows.Forms.TextBox();
            this.lblMail = new System.Windows.Forms.Label();
            this.txtMail = new System.Windows.Forms.TextBox();
            this.lblTelefono = new System.Windows.Forms.Label();
            this.txtTelefono = new System.Windows.Forms.TextBox();
            this.grdProveedores = new System.Windows.Forms.DataGridView();
            this.btnGuardar = new System.Windows.Forms.Button();
            this.btnEliminar = new System.Windows.Forms.Button();
            this.btnNuevo = new System.Windows.Forms.Button();
            this.btnBuscar = new System.Windows.Forms.Button();
            this.txtBuscar = new System.Windows.Forms.TextBox();
            this.btnLimpiarFiltro = new System.Windows.Forms.Button();
            this.lblInstruccionesBusqueda = new System.Windows.Forms.Label();
            this.id = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.campoBaja = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.razonSocial = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.domicilio = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.telefono = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.contacto = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tipoProveedor = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.mail = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.url = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cuit = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.comentarios = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.gbDatosProveedor.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.grdProveedores)).BeginInit();
            this.SuspendLayout();
            // 
            // lblDomicilio
            // 
            this.lblDomicilio.AutoSize = true;
            this.lblDomicilio.Location = new System.Drawing.Point(29, 76);
            this.lblDomicilio.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblDomicilio.Name = "lblDomicilio";
            this.lblDomicilio.Size = new System.Drawing.Size(64, 16);
            this.lblDomicilio.TabIndex = 1;
            this.lblDomicilio.Text = "Domicilio";
            // 
            // txtDomicilio
            // 
            this.txtDomicilio.Location = new System.Drawing.Point(207, 73);
            this.txtDomicilio.Margin = new System.Windows.Forms.Padding(4);
            this.txtDomicilio.Name = "txtDomicilio";
            this.txtDomicilio.Size = new System.Drawing.Size(263, 22);
            this.txtDomicilio.TabIndex = 2;
            // 
            // gbDatosProveedor
            // 
            this.gbDatosProveedor.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.gbDatosProveedor.Controls.Add(this.txtComentarios);
            this.gbDatosProveedor.Controls.Add(this.lblComentarios);
            this.gbDatosProveedor.Controls.Add(this.cmbTipo);
            this.gbDatosProveedor.Controls.Add(this.lblTipo);
            this.gbDatosProveedor.Controls.Add(this.txtContacto);
            this.gbDatosProveedor.Controls.Add(this.lblContacto);
            this.gbDatosProveedor.Controls.Add(this.lblRazonSocial);
            this.gbDatosProveedor.Controls.Add(this.txtRazonSocial);
            this.gbDatosProveedor.Controls.Add(this.lblCuit);
            this.gbDatosProveedor.Controls.Add(this.txtCuit);
            this.gbDatosProveedor.Controls.Add(this.lblUrl);
            this.gbDatosProveedor.Controls.Add(this.txtUrl);
            this.gbDatosProveedor.Controls.Add(this.lblMail);
            this.gbDatosProveedor.Controls.Add(this.txtMail);
            this.gbDatosProveedor.Controls.Add(this.lblTelefono);
            this.gbDatosProveedor.Controls.Add(this.txtTelefono);
            this.gbDatosProveedor.Controls.Add(this.lblDomicilio);
            this.gbDatosProveedor.Controls.Add(this.txtDomicilio);
            this.gbDatosProveedor.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gbDatosProveedor.Location = new System.Drawing.Point(0, 28);
            this.gbDatosProveedor.Margin = new System.Windows.Forms.Padding(4);
            this.gbDatosProveedor.Name = "gbDatosProveedor";
            this.gbDatosProveedor.Padding = new System.Windows.Forms.Padding(4);
            this.gbDatosProveedor.Size = new System.Drawing.Size(1084, 219);
            this.gbDatosProveedor.TabIndex = 3;
            this.gbDatosProveedor.TabStop = false;
            this.gbDatosProveedor.Text = "Datos del proveedor";
            // 
            // txtComentarios
            // 
            this.txtComentarios.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.txtComentarios.Location = new System.Drawing.Point(776, 154);
            this.txtComentarios.MaxLength = 150;
            this.txtComentarios.Multiline = true;
            this.txtComentarios.Name = "txtComentarios";
            this.txtComentarios.Size = new System.Drawing.Size(280, 53);
            this.txtComentarios.TabIndex = 9;
            // 
            // lblComentarios
            // 
            this.lblComentarios.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.lblComentarios.AutoSize = true;
            this.lblComentarios.Location = new System.Drawing.Point(666, 160);
            this.lblComentarios.Name = "lblComentarios";
            this.lblComentarios.Size = new System.Drawing.Size(87, 16);
            this.lblComentarios.TabIndex = 18;
            this.lblComentarios.Text = "Comentarios:";
            // 
            // cmbTipo
            // 
            this.cmbTipo.DisplayMember = "Categoria";
            this.cmbTipo.FormattingEnabled = true;
            this.cmbTipo.Location = new System.Drawing.Point(207, 188);
            this.cmbTipo.Name = "cmbTipo";
            this.cmbTipo.Size = new System.Drawing.Size(263, 24);
            this.cmbTipo.TabIndex = 5;
            this.cmbTipo.ValueMember = "Categoria";
            // 
            // lblTipo
            // 
            this.lblTipo.AutoSize = true;
            this.lblTipo.Location = new System.Drawing.Point(29, 191);
            this.lblTipo.Name = "lblTipo";
            this.lblTipo.Size = new System.Drawing.Size(124, 16);
            this.lblTipo.TabIndex = 16;
            this.lblTipo.Text = "Tipo de proveedor:";
            // 
            // txtContacto
            // 
            this.txtContacto.Location = new System.Drawing.Point(207, 154);
            this.txtContacto.Name = "txtContacto";
            this.txtContacto.Size = new System.Drawing.Size(263, 22);
            this.txtContacto.TabIndex = 4;
            // 
            // lblContacto
            // 
            this.lblContacto.AutoSize = true;
            this.lblContacto.Location = new System.Drawing.Point(29, 157);
            this.lblContacto.Name = "lblContacto";
            this.lblContacto.Size = new System.Drawing.Size(64, 16);
            this.lblContacto.TabIndex = 14;
            this.lblContacto.Text = "Contacto:";
            // 
            // lblRazonSocial
            // 
            this.lblRazonSocial.AutoSize = true;
            this.lblRazonSocial.Location = new System.Drawing.Point(29, 32);
            this.lblRazonSocial.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblRazonSocial.Name = "lblRazonSocial";
            this.lblRazonSocial.Size = new System.Drawing.Size(91, 16);
            this.lblRazonSocial.TabIndex = 13;
            this.lblRazonSocial.Text = "Razón Social:";
            // 
            // txtRazonSocial
            // 
            this.txtRazonSocial.Location = new System.Drawing.Point(207, 29);
            this.txtRazonSocial.Margin = new System.Windows.Forms.Padding(4);
            this.txtRazonSocial.Name = "txtRazonSocial";
            this.txtRazonSocial.Size = new System.Drawing.Size(263, 22);
            this.txtRazonSocial.TabIndex = 1;
            // 
            // lblCuit
            // 
            this.lblCuit.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.lblCuit.AutoSize = true;
            this.lblCuit.Location = new System.Drawing.Point(666, 119);
            this.lblCuit.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblCuit.Name = "lblCuit";
            this.lblCuit.Size = new System.Drawing.Size(42, 16);
            this.lblCuit.TabIndex = 11;
            this.lblCuit.Text = "CUIT:";
            // 
            // txtCuit
            // 
            this.txtCuit.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.txtCuit.Location = new System.Drawing.Point(776, 116);
            this.txtCuit.Margin = new System.Windows.Forms.Padding(4);
            this.txtCuit.Name = "txtCuit";
            this.txtCuit.Size = new System.Drawing.Size(280, 22);
            this.txtCuit.TabIndex = 8;
            // 
            // lblUrl
            // 
            this.lblUrl.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.lblUrl.AutoSize = true;
            this.lblUrl.Location = new System.Drawing.Point(666, 76);
            this.lblUrl.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblUrl.Name = "lblUrl";
            this.lblUrl.Size = new System.Drawing.Size(38, 16);
            this.lblUrl.TabIndex = 9;
            this.lblUrl.Text = "URL:";
            // 
            // txtUrl
            // 
            this.txtUrl.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.txtUrl.Location = new System.Drawing.Point(776, 73);
            this.txtUrl.Margin = new System.Windows.Forms.Padding(4);
            this.txtUrl.Name = "txtUrl";
            this.txtUrl.Size = new System.Drawing.Size(280, 22);
            this.txtUrl.TabIndex = 7;
            // 
            // lblMail
            // 
            this.lblMail.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.lblMail.AutoSize = true;
            this.lblMail.Location = new System.Drawing.Point(666, 32);
            this.lblMail.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblMail.Name = "lblMail";
            this.lblMail.Size = new System.Drawing.Size(36, 16);
            this.lblMail.TabIndex = 7;
            this.lblMail.Text = "Mail:";
            // 
            // txtMail
            // 
            this.txtMail.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.txtMail.Location = new System.Drawing.Point(776, 29);
            this.txtMail.Margin = new System.Windows.Forms.Padding(4);
            this.txtMail.Name = "txtMail";
            this.txtMail.Size = new System.Drawing.Size(280, 22);
            this.txtMail.TabIndex = 6;
            // 
            // lblTelefono
            // 
            this.lblTelefono.AutoSize = true;
            this.lblTelefono.Location = new System.Drawing.Point(29, 119);
            this.lblTelefono.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblTelefono.Name = "lblTelefono";
            this.lblTelefono.Size = new System.Drawing.Size(65, 16);
            this.lblTelefono.TabIndex = 5;
            this.lblTelefono.Text = "Teléfono:";
            // 
            // txtTelefono
            // 
            this.txtTelefono.Location = new System.Drawing.Point(207, 116);
            this.txtTelefono.Margin = new System.Windows.Forms.Padding(4);
            this.txtTelefono.Name = "txtTelefono";
            this.txtTelefono.Size = new System.Drawing.Size(263, 22);
            this.txtTelefono.TabIndex = 3;
            // 
            // grdProveedores
            // 
            this.grdProveedores.AllowUserToAddRows = false;
            this.grdProveedores.AllowUserToDeleteRows = false;
            this.grdProveedores.AllowUserToResizeRows = false;
            this.grdProveedores.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.grdProveedores.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.grdProveedores.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.grdProveedores.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.id,
            this.campoBaja,
            this.razonSocial,
            this.domicilio,
            this.telefono,
            this.contacto,
            this.tipoProveedor,
            this.mail,
            this.url,
            this.cuit,
            this.comentarios});
            this.grdProveedores.Location = new System.Drawing.Point(20, 291);
            this.grdProveedores.Margin = new System.Windows.Forms.Padding(4);
            this.grdProveedores.Name = "grdProveedores";
            this.grdProveedores.ReadOnly = true;
            this.grdProveedores.RowHeadersVisible = false;
            this.grdProveedores.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.grdProveedores.ShowEditingIcon = false;
            this.grdProveedores.Size = new System.Drawing.Size(1050, 254);
            this.grdProveedores.TabIndex = 14;
            this.grdProveedores.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.grdProveedores_CellContentClick);
            this.grdProveedores.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.grdProveedores_CellContentClick);
            // 
            // btnGuardar
            // 
            this.btnGuardar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnGuardar.Location = new System.Drawing.Point(918, 567);
            this.btnGuardar.Margin = new System.Windows.Forms.Padding(4);
            this.btnGuardar.Name = "btnGuardar";
            this.btnGuardar.Size = new System.Drawing.Size(153, 28);
            this.btnGuardar.TabIndex = 10;
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
            this.btnEliminar.TabIndex = 6;
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
            this.btnNuevo.TabIndex = 7;
            this.btnNuevo.Text = "Ingresar Nuevo";
            this.btnNuevo.UseVisualStyleBackColor = true;
            this.btnNuevo.Click += new System.EventHandler(this.btnNuevo_Click_1);
            // 
            // btnBuscar
            // 
            this.btnBuscar.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnBuscar.Location = new System.Drawing.Point(207, 255);
            this.btnBuscar.Margin = new System.Windows.Forms.Padding(4);
            this.btnBuscar.Name = "btnBuscar";
            this.btnBuscar.Size = new System.Drawing.Size(109, 28);
            this.btnBuscar.TabIndex = 8;
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
            this.txtBuscar.TabIndex = 9;
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
            this.lblInstruccionesBusqueda.Size = new System.Drawing.Size(374, 16);
            this.lblInstruccionesBusqueda.TabIndex = 11;
            this.lblInstruccionesBusqueda.Text = "Ingrese la razón social y presione \"Buscar\" para filtrar la grilla.";
            // 
            // id
            // 
            this.id.DataPropertyName = "id";
            this.id.HeaderText = "ID";
            this.id.Name = "id";
            this.id.ReadOnly = true;
            // 
            // campoBaja
            // 
            this.campoBaja.DataPropertyName = "campoBaja";
            this.campoBaja.HeaderText = "campo baja";
            this.campoBaja.Name = "campoBaja";
            this.campoBaja.ReadOnly = true;
            this.campoBaja.Visible = false;
            // 
            // razonSocial
            // 
            this.razonSocial.DataPropertyName = "razonSocial";
            this.razonSocial.HeaderText = "Razón Social";
            this.razonSocial.Name = "razonSocial";
            this.razonSocial.ReadOnly = true;
            // 
            // domicilio
            // 
            this.domicilio.DataPropertyName = "domicilio";
            this.domicilio.HeaderText = "Domicilio";
            this.domicilio.Name = "domicilio";
            this.domicilio.ReadOnly = true;
            // 
            // telefono
            // 
            this.telefono.DataPropertyName = "telefono";
            this.telefono.HeaderText = "Teléfono";
            this.telefono.Name = "telefono";
            this.telefono.ReadOnly = true;
            // 
            // contacto
            // 
            this.contacto.DataPropertyName = "contacto";
            this.contacto.HeaderText = "Contacto";
            this.contacto.Name = "contacto";
            this.contacto.ReadOnly = true;
            // 
            // tipoProveedor
            // 
            this.tipoProveedor.DataPropertyName = "tipoProveedor";
            this.tipoProveedor.HeaderText = "Tipo";
            this.tipoProveedor.Name = "tipoProveedor";
            this.tipoProveedor.ReadOnly = true;
            // 
            // mail
            // 
            this.mail.DataPropertyName = "mail";
            this.mail.HeaderText = "Mail";
            this.mail.Name = "mail";
            this.mail.ReadOnly = true;
            // 
            // url
            // 
            this.url.DataPropertyName = "url";
            this.url.HeaderText = "URL";
            this.url.Name = "url";
            this.url.ReadOnly = true;
            // 
            // cuit
            // 
            this.cuit.DataPropertyName = "cuit";
            this.cuit.HeaderText = "CUIT";
            this.cuit.Name = "cuit";
            this.cuit.ReadOnly = true;
            // 
            // comentarios
            // 
            this.comentarios.DataPropertyName = "comentarios";
            this.comentarios.HeaderText = "Comentarios";
            this.comentarios.Name = "comentarios";
            this.comentarios.ReadOnly = true;
            // 
            // FormProveedores
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
            this.Controls.Add(this.grdProveedores);
            this.Controls.Add(this.gbDatosProveedor);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Location = new System.Drawing.Point(0, 0);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.MinimumSize = new System.Drawing.Size(1100, 656);
            this.Name = "FormProveedores";
            this.Text = "Administración de proveedores";
            this.WindowState = System.Windows.Forms.FormWindowState.Normal;
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.FormProveedores_FormClosing);
            this.Controls.SetChildIndex(this.gbDatosProveedor, 0);
            this.Controls.SetChildIndex(this.grdProveedores, 0);
            this.Controls.SetChildIndex(this.btnGuardar, 0);
            this.Controls.SetChildIndex(this.btnEliminar, 0);
            this.Controls.SetChildIndex(this.btnNuevo, 0);
            this.Controls.SetChildIndex(this.btnBuscar, 0);
            this.Controls.SetChildIndex(this.txtBuscar, 0);
            this.Controls.SetChildIndex(this.btnLimpiarFiltro, 0);
            this.Controls.SetChildIndex(this.lblInstruccionesBusqueda, 0);
            this.gbDatosProveedor.ResumeLayout(false);
            this.gbDatosProveedor.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.grdProveedores)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label lblDomicilio;
        private System.Windows.Forms.TextBox txtDomicilio;
        private System.Windows.Forms.GroupBox gbDatosProveedor;
        private System.Windows.Forms.Label lblCuit;
        private System.Windows.Forms.TextBox txtCuit;
        private System.Windows.Forms.Label lblUrl;
        private System.Windows.Forms.TextBox txtUrl;
        private System.Windows.Forms.Label lblMail;
        private System.Windows.Forms.TextBox txtMail;
        private System.Windows.Forms.TextBox txtTelefono;
        private System.Windows.Forms.DataGridView grdProveedores;
        private System.Windows.Forms.Button btnGuardar;
        private System.Windows.Forms.Button btnEliminar;
        private System.Windows.Forms.Button btnNuevo;
        private System.Windows.Forms.Button btnBuscar;
        private System.Windows.Forms.TextBox txtBuscar;
        private System.Windows.Forms.Button btnLimpiarFiltro;
        private System.Windows.Forms.Label lblInstruccionesBusqueda;
        private System.Windows.Forms.Label lblRazonSocial;
        private System.Windows.Forms.TextBox txtRazonSocial;
        private System.Windows.Forms.Label lblTelefono;
        private System.Windows.Forms.TextBox txtComentarios;
        private System.Windows.Forms.Label lblComentarios;
        private System.Windows.Forms.ComboBox cmbTipo;
        private System.Windows.Forms.Label lblTipo;
        private System.Windows.Forms.TextBox txtContacto;
        private System.Windows.Forms.Label lblContacto;
        private System.Windows.Forms.DataGridViewTextBoxColumn id;
        private System.Windows.Forms.DataGridViewTextBoxColumn campoBaja;
        private System.Windows.Forms.DataGridViewTextBoxColumn razonSocial;
        private System.Windows.Forms.DataGridViewTextBoxColumn domicilio;
        private System.Windows.Forms.DataGridViewTextBoxColumn telefono;
        private System.Windows.Forms.DataGridViewTextBoxColumn contacto;
        private System.Windows.Forms.DataGridViewTextBoxColumn tipoProveedor;
        private System.Windows.Forms.DataGridViewTextBoxColumn mail;
        private System.Windows.Forms.DataGridViewTextBoxColumn url;
        private System.Windows.Forms.DataGridViewTextBoxColumn cuit;
        private System.Windows.Forms.DataGridViewTextBoxColumn comentarios;
    }
}