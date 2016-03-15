namespace ServiciosRegistrales
{
    partial class FormVisualizarCompras
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
            this.grdCompras = new System.Windows.Forms.DataGridView();
            this.id = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.idProveedor = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.fecha = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.descripcion = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.gastosExtra = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.importe = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nroFactura = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.gpbDatosCompra = new System.Windows.Forms.GroupBox();
            this.txtMontoTotal = new System.Windows.Forms.TextBox();
            this.txtFecha = new System.Windows.Forms.TextBox();
            this.txtProveedor = new System.Windows.Forms.TextBox();
            this.txtGastosExtra = new System.Windows.Forms.TextBox();
            this.lblGastosExtra = new System.Windows.Forms.Label();
            this.txtNroFactura = new System.Windows.Forms.TextBox();
            this.lblNroFactura = new System.Windows.Forms.Label();
            this.lblMontoTotal = new System.Windows.Forms.Label();
            this.txtComentarios = new System.Windows.Forms.TextBox();
            this.lblComentarios = new System.Windows.Forms.Label();
            this.lblProveedor = new System.Windows.Forms.Label();
            this.lblFecha = new System.Windows.Forms.Label();
            this.gpbNuevoArticulo = new System.Windows.Forms.GroupBox();
            this.grdDetalle = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.grdCompras)).BeginInit();
            this.gpbDatosCompra.SuspendLayout();
            this.gpbNuevoArticulo.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.grdDetalle)).BeginInit();
            this.SuspendLayout();
            // 
            // grdCompras
            // 
            this.grdCompras.AllowUserToAddRows = false;
            this.grdCompras.AllowUserToDeleteRows = false;
            this.grdCompras.AllowUserToResizeRows = false;
            this.grdCompras.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.grdCompras.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.grdCompras.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.grdCompras.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.id,
            this.idProveedor,
            this.fecha,
            this.descripcion,
            this.gastosExtra,
            this.importe,
            this.nroFactura});
            this.grdCompras.Location = new System.Drawing.Point(528, 34);
            this.grdCompras.Name = "grdCompras";
            this.grdCompras.ReadOnly = true;
            this.grdCompras.RowHeadersVisible = false;
            this.grdCompras.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.grdCompras.Size = new System.Drawing.Size(544, 572);
            this.grdCompras.TabIndex = 0;
            this.grdCompras.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.grdCompras_CellClick);
            // 
            // id
            // 
            this.id.DataPropertyName = "id";
            this.id.HeaderText = "id";
            this.id.Name = "id";
            this.id.ReadOnly = true;
            this.id.Visible = false;
            // 
            // idProveedor
            // 
            this.idProveedor.DataPropertyName = "idProveedor";
            this.idProveedor.HeaderText = "idProveedor";
            this.idProveedor.Name = "idProveedor";
            this.idProveedor.ReadOnly = true;
            this.idProveedor.Visible = false;
            // 
            // fecha
            // 
            this.fecha.DataPropertyName = "fecha";
            this.fecha.HeaderText = "Fecha de compra";
            this.fecha.Name = "fecha";
            this.fecha.ReadOnly = true;
            // 
            // descripcion
            // 
            this.descripcion.DataPropertyName = "descripcion";
            this.descripcion.HeaderText = "Descripción";
            this.descripcion.Name = "descripcion";
            this.descripcion.ReadOnly = true;
            // 
            // gastosExtra
            // 
            this.gastosExtra.DataPropertyName = "gastosExtra";
            this.gastosExtra.HeaderText = "gastosExtra";
            this.gastosExtra.Name = "gastosExtra";
            this.gastosExtra.ReadOnly = true;
            this.gastosExtra.Visible = false;
            // 
            // importe
            // 
            this.importe.DataPropertyName = "importe";
            this.importe.HeaderText = "Importe";
            this.importe.Name = "importe";
            this.importe.ReadOnly = true;
            // 
            // nroFactura
            // 
            this.nroFactura.DataPropertyName = "nroFactura";
            this.nroFactura.HeaderText = "Nro Factura";
            this.nroFactura.Name = "nroFactura";
            this.nroFactura.ReadOnly = true;
            // 
            // gpbDatosCompra
            // 
            this.gpbDatosCompra.Controls.Add(this.txtMontoTotal);
            this.gpbDatosCompra.Controls.Add(this.txtFecha);
            this.gpbDatosCompra.Controls.Add(this.txtProveedor);
            this.gpbDatosCompra.Controls.Add(this.txtGastosExtra);
            this.gpbDatosCompra.Controls.Add(this.lblGastosExtra);
            this.gpbDatosCompra.Controls.Add(this.txtNroFactura);
            this.gpbDatosCompra.Controls.Add(this.lblNroFactura);
            this.gpbDatosCompra.Controls.Add(this.lblMontoTotal);
            this.gpbDatosCompra.Controls.Add(this.txtComentarios);
            this.gpbDatosCompra.Controls.Add(this.lblComentarios);
            this.gpbDatosCompra.Controls.Add(this.lblProveedor);
            this.gpbDatosCompra.Controls.Add(this.lblFecha);
            this.gpbDatosCompra.Location = new System.Drawing.Point(12, 25);
            this.gpbDatosCompra.Name = "gpbDatosCompra";
            this.gpbDatosCompra.Size = new System.Drawing.Size(510, 287);
            this.gpbDatosCompra.TabIndex = 1;
            this.gpbDatosCompra.TabStop = false;
            this.gpbDatosCompra.Text = "Datos de la compra";
            // 
            // txtMontoTotal
            // 
            this.txtMontoTotal.Location = new System.Drawing.Point(144, 245);
            this.txtMontoTotal.Name = "txtMontoTotal";
            this.txtMontoTotal.ReadOnly = true;
            this.txtMontoTotal.Size = new System.Drawing.Size(200, 22);
            this.txtMontoTotal.TabIndex = 21;
            // 
            // txtFecha
            // 
            this.txtFecha.Location = new System.Drawing.Point(144, 28);
            this.txtFecha.Name = "txtFecha";
            this.txtFecha.ReadOnly = true;
            this.txtFecha.Size = new System.Drawing.Size(200, 22);
            this.txtFecha.TabIndex = 20;
            // 
            // txtProveedor
            // 
            this.txtProveedor.Location = new System.Drawing.Point(144, 67);
            this.txtProveedor.Name = "txtProveedor";
            this.txtProveedor.ReadOnly = true;
            this.txtProveedor.Size = new System.Drawing.Size(200, 22);
            this.txtProveedor.TabIndex = 19;
            // 
            // txtGastosExtra
            // 
            this.txtGastosExtra.Location = new System.Drawing.Point(144, 208);
            this.txtGastosExtra.Name = "txtGastosExtra";
            this.txtGastosExtra.ReadOnly = true;
            this.txtGastosExtra.Size = new System.Drawing.Size(200, 22);
            this.txtGastosExtra.TabIndex = 16;
            // 
            // lblGastosExtra
            // 
            this.lblGastosExtra.AutoSize = true;
            this.lblGastosExtra.Location = new System.Drawing.Point(18, 211);
            this.lblGastosExtra.Name = "lblGastosExtra";
            this.lblGastosExtra.Size = new System.Drawing.Size(118, 16);
            this.lblGastosExtra.TabIndex = 15;
            this.lblGastosExtra.Text = "Gastos generales:";
            // 
            // txtNroFactura
            // 
            this.txtNroFactura.Location = new System.Drawing.Point(144, 169);
            this.txtNroFactura.Name = "txtNroFactura";
            this.txtNroFactura.ReadOnly = true;
            this.txtNroFactura.Size = new System.Drawing.Size(200, 22);
            this.txtNroFactura.TabIndex = 9;
            // 
            // lblNroFactura
            // 
            this.lblNroFactura.AutoSize = true;
            this.lblNroFactura.Location = new System.Drawing.Point(18, 172);
            this.lblNroFactura.Name = "lblNroFactura";
            this.lblNroFactura.Size = new System.Drawing.Size(95, 16);
            this.lblNroFactura.TabIndex = 8;
            this.lblNroFactura.Text = "Nro de factura:";
            // 
            // lblMontoTotal
            // 
            this.lblMontoTotal.AutoSize = true;
            this.lblMontoTotal.Location = new System.Drawing.Point(19, 248);
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
            this.txtComentarios.ReadOnly = true;
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
            // lblProveedor
            // 
            this.lblProveedor.AutoSize = true;
            this.lblProveedor.Location = new System.Drawing.Point(18, 70);
            this.lblProveedor.Name = "lblProveedor";
            this.lblProveedor.Size = new System.Drawing.Size(75, 16);
            this.lblProveedor.TabIndex = 2;
            this.lblProveedor.Text = "Proveedor:";
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
            this.gpbNuevoArticulo.Controls.Add(this.grdDetalle);
            this.gpbNuevoArticulo.Location = new System.Drawing.Point(13, 318);
            this.gpbNuevoArticulo.Name = "gpbNuevoArticulo";
            this.gpbNuevoArticulo.Size = new System.Drawing.Size(509, 288);
            this.gpbNuevoArticulo.TabIndex = 2;
            this.gpbNuevoArticulo.TabStop = false;
            this.gpbNuevoArticulo.Text = "Detalles de la compra";
            // 
            // grdDetalle
            // 
            this.grdDetalle.AllowUserToAddRows = false;
            this.grdDetalle.AllowUserToDeleteRows = false;
            this.grdDetalle.AllowUserToResizeRows = false;
            this.grdDetalle.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.grdDetalle.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.grdDetalle.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.grdDetalle.Location = new System.Drawing.Point(15, 21);
            this.grdDetalle.Name = "grdDetalle";
            this.grdDetalle.ReadOnly = true;
            this.grdDetalle.RowHeadersVisible = false;
            this.grdDetalle.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.grdDetalle.Size = new System.Drawing.Size(488, 261);
            this.grdDetalle.TabIndex = 9;
            // 
            // FormVisualizarCompras
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1084, 618);
            this.Controls.Add(this.gpbNuevoArticulo);
            this.Controls.Add(this.gpbDatosCompra);
            this.Controls.Add(this.grdCompras);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Location = new System.Drawing.Point(0, 0);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.MinimumSize = new System.Drawing.Size(1100, 656);
            this.Name = "FormVisualizarCompras";
            this.Text = "Visualización de compras";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.FormVisualizarCompras_FormClosing);
            this.Controls.SetChildIndex(this.grdCompras, 0);
            this.Controls.SetChildIndex(this.gpbDatosCompra, 0);
            this.Controls.SetChildIndex(this.gpbNuevoArticulo, 0);
            ((System.ComponentModel.ISupportInitialize)(this.grdCompras)).EndInit();
            this.gpbDatosCompra.ResumeLayout(false);
            this.gpbDatosCompra.PerformLayout();
            this.gpbNuevoArticulo.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.grdDetalle)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.DataGridView grdCompras;
        private System.Windows.Forms.GroupBox gpbDatosCompra;
        private System.Windows.Forms.GroupBox gpbNuevoArticulo;
        private System.Windows.Forms.Label lblMontoTotal;
        private System.Windows.Forms.TextBox txtComentarios;
        private System.Windows.Forms.Label lblComentarios;
        private System.Windows.Forms.Label lblProveedor;
        private System.Windows.Forms.Label lblFecha;
        private System.Windows.Forms.TextBox txtNroFactura;
        private System.Windows.Forms.Label lblNroFactura;
        private System.Windows.Forms.TextBox txtGastosExtra;
        private System.Windows.Forms.Label lblGastosExtra;
        private System.Windows.Forms.DataGridView grdDetalle;
        private System.Windows.Forms.TextBox txtFecha;
        private System.Windows.Forms.TextBox txtProveedor;
        private System.Windows.Forms.TextBox txtMontoTotal;
        private System.Windows.Forms.DataGridViewTextBoxColumn id;
        private System.Windows.Forms.DataGridViewTextBoxColumn idProveedor;
        private System.Windows.Forms.DataGridViewTextBoxColumn fecha;
        private System.Windows.Forms.DataGridViewTextBoxColumn descripcion;
        private System.Windows.Forms.DataGridViewTextBoxColumn gastosExtra;
        private System.Windows.Forms.DataGridViewTextBoxColumn importe;
        private System.Windows.Forms.DataGridViewTextBoxColumn nroFactura;
    }
}