namespace ServiciosRegistrales
{
    partial class FormVisualizarVentas
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            this.grdVentas = new System.Windows.Forms.DataGridView();
            this.gpbDatosVenta = new System.Windows.Forms.GroupBox();
            this.txtMontoTotal = new System.Windows.Forms.TextBox();
            this.lblMontoTotal = new System.Windows.Forms.Label();
            this.txtFecha = new System.Windows.Forms.TextBox();
            this.txtComentarios = new System.Windows.Forms.TextBox();
            this.lblComentarios = new System.Windows.Forms.Label();
            this.lblFecha = new System.Windows.Forms.Label();
            this.lblApellidoYNombreCliente = new System.Windows.Forms.Label();
            this.txtDocumento = new System.Windows.Forms.TextBox();
            this.lblDocumento = new System.Windows.Forms.Label();
            this.gpbCliente = new System.Windows.Forms.GroupBox();
            this.txtApellidoYNombre = new System.Windows.Forms.TextBox();
            this.txtNumeroCliente = new System.Windows.Forms.TextBox();
            this.lblNumeroCliente = new System.Windows.Forms.Label();
            this.gpbDetalleVenta = new System.Windows.Forms.GroupBox();
            this.grdDetalles = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.grdVentas)).BeginInit();
            this.gpbDatosVenta.SuspendLayout();
            this.gpbCliente.SuspendLayout();
            this.gpbDetalleVenta.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.grdDetalles)).BeginInit();
            this.SuspendLayout();
            // 
            // grdVentas
            // 
            this.grdVentas.AllowUserToAddRows = false;
            this.grdVentas.AllowUserToDeleteRows = false;
            this.grdVentas.AllowUserToResizeRows = false;
            this.grdVentas.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.grdVentas.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle3.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.grdVentas.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle3;
            this.grdVentas.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.grdVentas.Location = new System.Drawing.Point(528, 34);
            this.grdVentas.Name = "grdVentas";
            this.grdVentas.ReadOnly = true;
            this.grdVentas.RowHeadersVisible = false;
            this.grdVentas.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.grdVentas.Size = new System.Drawing.Size(544, 572);
            this.grdVentas.TabIndex = 0;
            this.grdVentas.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.grdVentas_CellClick);
            // 
            // gpbDatosVenta
            // 
            this.gpbDatosVenta.Controls.Add(this.txtMontoTotal);
            this.gpbDatosVenta.Controls.Add(this.lblMontoTotal);
            this.gpbDatosVenta.Controls.Add(this.txtFecha);
            this.gpbDatosVenta.Controls.Add(this.txtComentarios);
            this.gpbDatosVenta.Controls.Add(this.lblComentarios);
            this.gpbDatosVenta.Controls.Add(this.lblFecha);
            this.gpbDatosVenta.Location = new System.Drawing.Point(12, 25);
            this.gpbDatosVenta.Name = "gpbDatosVenta";
            this.gpbDatosVenta.Size = new System.Drawing.Size(510, 152);
            this.gpbDatosVenta.TabIndex = 1;
            this.gpbDatosVenta.TabStop = false;
            this.gpbDatosVenta.Text = "Datos de la venta";
            // 
            // txtMontoTotal
            // 
            this.txtMontoTotal.Location = new System.Drawing.Point(144, 120);
            this.txtMontoTotal.Name = "txtMontoTotal";
            this.txtMontoTotal.ReadOnly = true;
            this.txtMontoTotal.Size = new System.Drawing.Size(178, 22);
            this.txtMontoTotal.TabIndex = 23;
            // 
            // lblMontoTotal
            // 
            this.lblMontoTotal.AutoSize = true;
            this.lblMontoTotal.Location = new System.Drawing.Point(18, 123);
            this.lblMontoTotal.Name = "lblMontoTotal";
            this.lblMontoTotal.Size = new System.Drawing.Size(76, 16);
            this.lblMontoTotal.TabIndex = 22;
            this.lblMontoTotal.Text = "Monto total:";
            // 
            // txtFecha
            // 
            this.txtFecha.Location = new System.Drawing.Point(144, 28);
            this.txtFecha.Name = "txtFecha";
            this.txtFecha.ReadOnly = true;
            this.txtFecha.Size = new System.Drawing.Size(178, 22);
            this.txtFecha.TabIndex = 21;
            // 
            // txtComentarios
            // 
            this.txtComentarios.Location = new System.Drawing.Point(144, 60);
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
            this.lblComentarios.Location = new System.Drawing.Point(18, 63);
            this.lblComentarios.Name = "lblComentarios";
            this.lblComentarios.Size = new System.Drawing.Size(87, 16);
            this.lblComentarios.TabIndex = 4;
            this.lblComentarios.Text = "Comentarios:";
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
            // lblApellidoYNombreCliente
            // 
            this.lblApellidoYNombreCliente.AutoSize = true;
            this.lblApellidoYNombreCliente.Location = new System.Drawing.Point(11, 86);
            this.lblApellidoYNombreCliente.Name = "lblApellidoYNombreCliente";
            this.lblApellidoYNombreCliente.Size = new System.Drawing.Size(120, 16);
            this.lblApellidoYNombreCliente.TabIndex = 15;
            this.lblApellidoYNombreCliente.Text = "Apellido y nombre:";
            // 
            // txtDocumento
            // 
            this.txtDocumento.Location = new System.Drawing.Point(167, 52);
            this.txtDocumento.Name = "txtDocumento";
            this.txtDocumento.ReadOnly = true;
            this.txtDocumento.Size = new System.Drawing.Size(200, 22);
            this.txtDocumento.TabIndex = 9;
            // 
            // lblDocumento
            // 
            this.lblDocumento.AutoSize = true;
            this.lblDocumento.Location = new System.Drawing.Point(11, 55);
            this.lblDocumento.Name = "lblDocumento";
            this.lblDocumento.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.lblDocumento.Size = new System.Drawing.Size(80, 16);
            this.lblDocumento.TabIndex = 8;
            this.lblDocumento.Text = "Documento:";
            // 
            // gpbCliente
            // 
            this.gpbCliente.Controls.Add(this.txtApellidoYNombre);
            this.gpbCliente.Controls.Add(this.txtNumeroCliente);
            this.gpbCliente.Controls.Add(this.lblNumeroCliente);
            this.gpbCliente.Controls.Add(this.lblDocumento);
            this.gpbCliente.Controls.Add(this.txtDocumento);
            this.gpbCliente.Controls.Add(this.lblApellidoYNombreCliente);
            this.gpbCliente.Location = new System.Drawing.Point(13, 183);
            this.gpbCliente.Name = "gpbCliente";
            this.gpbCliente.Size = new System.Drawing.Size(509, 117);
            this.gpbCliente.TabIndex = 11;
            this.gpbCliente.TabStop = false;
            this.gpbCliente.Text = "Datos del cliente";
            // 
            // txtApellidoYNombre
            // 
            this.txtApellidoYNombre.Location = new System.Drawing.Point(167, 83);
            this.txtApellidoYNombre.Name = "txtApellidoYNombre";
            this.txtApellidoYNombre.ReadOnly = true;
            this.txtApellidoYNombre.Size = new System.Drawing.Size(200, 22);
            this.txtApellidoYNombre.TabIndex = 18;
            // 
            // txtNumeroCliente
            // 
            this.txtNumeroCliente.Location = new System.Drawing.Point(167, 21);
            this.txtNumeroCliente.Name = "txtNumeroCliente";
            this.txtNumeroCliente.ReadOnly = true;
            this.txtNumeroCliente.Size = new System.Drawing.Size(200, 22);
            this.txtNumeroCliente.TabIndex = 17;
            // 
            // lblNumeroCliente
            // 
            this.lblNumeroCliente.AutoSize = true;
            this.lblNumeroCliente.Location = new System.Drawing.Point(11, 24);
            this.lblNumeroCliente.Name = "lblNumeroCliente";
            this.lblNumeroCliente.Size = new System.Drawing.Size(120, 16);
            this.lblNumeroCliente.TabIndex = 16;
            this.lblNumeroCliente.Text = "Número de cliente:";
            // 
            // gpbDetalleVenta
            // 
            this.gpbDetalleVenta.Controls.Add(this.grdDetalles);
            this.gpbDetalleVenta.Location = new System.Drawing.Point(13, 306);
            this.gpbDetalleVenta.Name = "gpbDetalleVenta";
            this.gpbDetalleVenta.Size = new System.Drawing.Size(509, 300);
            this.gpbDetalleVenta.TabIndex = 2;
            this.gpbDetalleVenta.TabStop = false;
            this.gpbDetalleVenta.Text = "Detalles de la venta";
            // 
            // grdDetalles
            // 
            this.grdDetalles.AllowUserToAddRows = false;
            this.grdDetalles.AllowUserToDeleteRows = false;
            this.grdDetalles.AllowUserToResizeRows = false;
            this.grdDetalles.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.grdDetalles.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle4.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle4.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle4.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle4.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle4.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.grdDetalles.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle4;
            this.grdDetalles.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.grdDetalles.Location = new System.Drawing.Point(6, 21);
            this.grdDetalles.Name = "grdDetalles";
            this.grdDetalles.ReadOnly = true;
            this.grdDetalles.RowHeadersVisible = false;
            this.grdDetalles.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.grdDetalles.Size = new System.Drawing.Size(497, 273);
            this.grdDetalles.TabIndex = 12;
            // 
            // FormVisualizarVentas
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1084, 618);
            this.Controls.Add(this.gpbCliente);
            this.Controls.Add(this.gpbDetalleVenta);
            this.Controls.Add(this.gpbDatosVenta);
            this.Controls.Add(this.grdVentas);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Location = new System.Drawing.Point(0, 0);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.MinimumSize = new System.Drawing.Size(1100, 656);
            this.Name = "FormVisualizarVentas";
            this.Text = "Visualización de ventas";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.FormVisualizarVentas_FormClosing);
            this.Controls.SetChildIndex(this.grdVentas, 0);
            this.Controls.SetChildIndex(this.gpbDatosVenta, 0);
            this.Controls.SetChildIndex(this.gpbDetalleVenta, 0);
            this.Controls.SetChildIndex(this.gpbCliente, 0);
            ((System.ComponentModel.ISupportInitialize)(this.grdVentas)).EndInit();
            this.gpbDatosVenta.ResumeLayout(false);
            this.gpbDatosVenta.PerformLayout();
            this.gpbCliente.ResumeLayout(false);
            this.gpbCliente.PerformLayout();
            this.gpbDetalleVenta.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.grdDetalles)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView grdVentas;
        private System.Windows.Forms.GroupBox gpbDatosVenta;
        private System.Windows.Forms.TextBox txtComentarios;
        private System.Windows.Forms.Label lblComentarios;
        private System.Windows.Forms.Label lblFecha;
        private System.Windows.Forms.TextBox txtDocumento;
        private System.Windows.Forms.Label lblDocumento;
        private System.Windows.Forms.Label lblApellidoYNombreCliente;
        private System.Windows.Forms.TextBox txtFecha;
        private System.Windows.Forms.GroupBox gpbCliente;
        private System.Windows.Forms.TextBox txtApellidoYNombre;
        private System.Windows.Forms.TextBox txtNumeroCliente;
        private System.Windows.Forms.Label lblNumeroCliente;
        private System.Windows.Forms.GroupBox gpbDetalleVenta;
        private System.Windows.Forms.TextBox txtMontoTotal;
        private System.Windows.Forms.Label lblMontoTotal;
        private System.Windows.Forms.DataGridView grdDetalles;
    }
}