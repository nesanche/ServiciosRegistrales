namespace ServiciosRegistrales
{
    partial class FormArticulos
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
            this.lblDescripcion = new System.Windows.Forms.Label();
            this.txtDescripcion = new System.Windows.Forms.TextBox();
            this.gbDatosArticulo = new System.Windows.Forms.GroupBox();
            this.chkFormulario = new System.Windows.Forms.CheckBox();
            this.lblCodigo = new System.Windows.Forms.Label();
            this.txtCodigo = new System.Windows.Forms.TextBox();
            this.grdArticulos = new System.Windows.Forms.DataGridView();
            this.btnGuardar = new System.Windows.Forms.Button();
            this.btnEliminar = new System.Windows.Forms.Button();
            this.btnNuevo = new System.Windows.Forms.Button();
            this.btnBuscar = new System.Windows.Forms.Button();
            this.txtBuscar = new System.Windows.Forms.TextBox();
            this.btnLimpiarFiltro = new System.Windows.Forms.Button();
            this.lblInstruccionesBusqueda = new System.Windows.Forms.Label();
            this.id = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.campoBaja = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.codigoArticulo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.descripcion = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.esFormulario = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.gbDatosArticulo.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.grdArticulos)).BeginInit();
            this.SuspendLayout();
            // 
            // lblDescripcion
            // 
            this.lblDescripcion.AutoSize = true;
            this.lblDescripcion.Location = new System.Drawing.Point(29, 91);
            this.lblDescripcion.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblDescripcion.Name = "lblDescripcion";
            this.lblDescripcion.Size = new System.Drawing.Size(83, 16);
            this.lblDescripcion.TabIndex = 1;
            this.lblDescripcion.Text = "Descripción:";
            // 
            // txtDescripcion
            // 
            this.txtDescripcion.Location = new System.Drawing.Point(207, 88);
            this.txtDescripcion.Margin = new System.Windows.Forms.Padding(4);
            this.txtDescripcion.Name = "txtDescripcion";
            this.txtDescripcion.Size = new System.Drawing.Size(263, 22);
            this.txtDescripcion.TabIndex = 2;
            // 
            // gbDatosArticulo
            // 
            this.gbDatosArticulo.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.gbDatosArticulo.Controls.Add(this.chkFormulario);
            this.gbDatosArticulo.Controls.Add(this.lblCodigo);
            this.gbDatosArticulo.Controls.Add(this.txtCodigo);
            this.gbDatosArticulo.Controls.Add(this.lblDescripcion);
            this.gbDatosArticulo.Controls.Add(this.txtDescripcion);
            this.gbDatosArticulo.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gbDatosArticulo.Location = new System.Drawing.Point(0, 28);
            this.gbDatosArticulo.Margin = new System.Windows.Forms.Padding(4);
            this.gbDatosArticulo.Name = "gbDatosArticulo";
            this.gbDatosArticulo.Padding = new System.Windows.Forms.Padding(4);
            this.gbDatosArticulo.Size = new System.Drawing.Size(1084, 198);
            this.gbDatosArticulo.TabIndex = 3;
            this.gbDatosArticulo.TabStop = false;
            this.gbDatosArticulo.Text = "Datos del artículo";
            // 
            // chkFormulario
            // 
            this.chkFormulario.AutoSize = true;
            this.chkFormulario.Location = new System.Drawing.Point(32, 148);
            this.chkFormulario.Name = "chkFormulario";
            this.chkFormulario.Size = new System.Drawing.Size(269, 20);
            this.chkFormulario.TabIndex = 3;
            this.chkFormulario.Text = "Es un formulario del registro al automotor";
            this.chkFormulario.UseVisualStyleBackColor = true;
            this.chkFormulario.CheckedChanged += new System.EventHandler(this.chkFormulario_CheckedChanged);
            // 
            // lblCodigo
            // 
            this.lblCodigo.AutoSize = true;
            this.lblCodigo.Location = new System.Drawing.Point(29, 32);
            this.lblCodigo.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblCodigo.Name = "lblCodigo";
            this.lblCodigo.Size = new System.Drawing.Size(120, 16);
            this.lblCodigo.TabIndex = 13;
            this.lblCodigo.Text = "Código de artículo:";
            // 
            // txtCodigo
            // 
            this.txtCodigo.Location = new System.Drawing.Point(207, 29);
            this.txtCodigo.Margin = new System.Windows.Forms.Padding(4);
            this.txtCodigo.MaxLength = 6;
            this.txtCodigo.Name = "txtCodigo";
            this.txtCodigo.Size = new System.Drawing.Size(263, 22);
            this.txtCodigo.TabIndex = 1;
            this.txtCodigo.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtCodigo_KeyPress);
            // 
            // grdArticulos
            // 
            this.grdArticulos.AllowUserToAddRows = false;
            this.grdArticulos.AllowUserToDeleteRows = false;
            this.grdArticulos.AllowUserToResizeRows = false;
            this.grdArticulos.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.grdArticulos.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.grdArticulos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.grdArticulos.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.id,
            this.campoBaja,
            this.codigoArticulo,
            this.descripcion,
            this.esFormulario});
            this.grdArticulos.Location = new System.Drawing.Point(20, 291);
            this.grdArticulos.Margin = new System.Windows.Forms.Padding(4);
            this.grdArticulos.MultiSelect = false;
            this.grdArticulos.Name = "grdArticulos";
            this.grdArticulos.ReadOnly = true;
            this.grdArticulos.RowHeadersVisible = false;
            this.grdArticulos.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.grdArticulos.ShowEditingIcon = false;
            this.grdArticulos.Size = new System.Drawing.Size(1050, 254);
            this.grdArticulos.TabIndex = 4;
            this.grdArticulos.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.grdArticulos_CellContentClick);
            this.grdArticulos.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.grdArticulos_CellContentClick);
            // 
            // btnGuardar
            // 
            this.btnGuardar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnGuardar.Location = new System.Drawing.Point(918, 567);
            this.btnGuardar.Margin = new System.Windows.Forms.Padding(4);
            this.btnGuardar.Name = "btnGuardar";
            this.btnGuardar.Size = new System.Drawing.Size(153, 28);
            this.btnGuardar.TabIndex = 4;
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
            this.btnEliminar.Click += new System.EventHandler(this.btnEliminar_Click_1);
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
            this.lblInstruccionesBusqueda.Size = new System.Drawing.Size(372, 16);
            this.lblInstruccionesBusqueda.TabIndex = 11;
            this.lblInstruccionesBusqueda.Text = "Ingrese la descripción y presione \"Buscar\" para filtrar la grilla.";
            // 
            // id
            // 
            this.id.DataPropertyName = "id";
            this.id.HeaderText = "ID";
            this.id.Name = "id";
            this.id.ReadOnly = true;
            this.id.Visible = false;
            // 
            // campoBaja
            // 
            this.campoBaja.DataPropertyName = "campoBaja";
            this.campoBaja.HeaderText = "Campo baja";
            this.campoBaja.Name = "campoBaja";
            this.campoBaja.ReadOnly = true;
            this.campoBaja.Visible = false;
            // 
            // codigoArticulo
            // 
            this.codigoArticulo.DataPropertyName = "codigo";
            this.codigoArticulo.HeaderText = "Código de artículo";
            this.codigoArticulo.Name = "codigoArticulo";
            this.codigoArticulo.ReadOnly = true;
            // 
            // descripcion
            // 
            this.descripcion.DataPropertyName = "descripcion";
            this.descripcion.HeaderText = "Descripción";
            this.descripcion.Name = "descripcion";
            this.descripcion.ReadOnly = true;
            // 
            // esFormulario
            // 
            this.esFormulario.DataPropertyName = "esFormulario";
            this.esFormulario.HeaderText = "¿Es Formulario? 1: Si, 0: No";
            this.esFormulario.Name = "esFormulario";
            this.esFormulario.ReadOnly = true;
            // 
            // FormArticulos
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
            this.Controls.Add(this.grdArticulos);
            this.Controls.Add(this.gbDatosArticulo);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Location = new System.Drawing.Point(0, 0);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.MinimumSize = new System.Drawing.Size(1100, 656);
            this.Name = "FormArticulos";
            this.Text = "Administración de artículos - Servicios Registrales v 1.0";
            this.WindowState = System.Windows.Forms.FormWindowState.Normal;
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.FormArticulos_FormClosing);
            this.Controls.SetChildIndex(this.gbDatosArticulo, 0);
            this.Controls.SetChildIndex(this.grdArticulos, 0);
            this.Controls.SetChildIndex(this.btnGuardar, 0);
            this.Controls.SetChildIndex(this.btnEliminar, 0);
            this.Controls.SetChildIndex(this.btnNuevo, 0);
            this.Controls.SetChildIndex(this.btnBuscar, 0);
            this.Controls.SetChildIndex(this.txtBuscar, 0);
            this.Controls.SetChildIndex(this.btnLimpiarFiltro, 0);
            this.Controls.SetChildIndex(this.lblInstruccionesBusqueda, 0);
            this.gbDatosArticulo.ResumeLayout(false);
            this.gbDatosArticulo.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.grdArticulos)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label lblDescripcion;
        private System.Windows.Forms.TextBox txtDescripcion;
        private System.Windows.Forms.GroupBox gbDatosArticulo;
        private System.Windows.Forms.DataGridView grdArticulos;
        private System.Windows.Forms.Button btnGuardar;
        private System.Windows.Forms.Button btnEliminar;
        private System.Windows.Forms.Button btnNuevo;
        private System.Windows.Forms.Button btnBuscar;
        private System.Windows.Forms.TextBox txtBuscar;
        private System.Windows.Forms.Button btnLimpiarFiltro;
        private System.Windows.Forms.Label lblInstruccionesBusqueda;
        private System.Windows.Forms.Label lblCodigo;
        private System.Windows.Forms.TextBox txtCodigo;
        private System.Windows.Forms.CheckBox chkFormulario;
        private System.Windows.Forms.DataGridViewTextBoxColumn id;
        private System.Windows.Forms.DataGridViewTextBoxColumn campoBaja;
        private System.Windows.Forms.DataGridViewTextBoxColumn codigoArticulo;
        private System.Windows.Forms.DataGridViewTextBoxColumn descripcion;
        private System.Windows.Forms.DataGridViewTextBoxColumn esFormulario;
    }
}