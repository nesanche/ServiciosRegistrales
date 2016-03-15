namespace ServiciosRegistrales
{
    partial class FormGastosGenerales
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
            this.lblInstrucciones = new System.Windows.Forms.Label();
            this.lblGasto = new System.Windows.Forms.Label();
            this.txtGasto = new System.Windows.Forms.TextBox();
            this.lblDescripcion = new System.Windows.Forms.Label();
            this.txtDescripcion = new System.Windows.Forms.TextBox();
            this.btnConfirmar = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.dtpFecha = new System.Windows.Forms.DateTimePicker();
            this.txtNroFactura = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // lblInstrucciones
            // 
            this.lblInstrucciones.AutoSize = true;
            this.lblInstrucciones.Location = new System.Drawing.Point(25, 19);
            this.lblInstrucciones.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblInstrucciones.Name = "lblInstrucciones";
            this.lblInstrucciones.Size = new System.Drawing.Size(320, 32);
            this.lblInstrucciones.TabIndex = 0;
            this.lblInstrucciones.Text = "Ingrese el monto de su gasto general, la fecha y una \r\ndescripción al respecto. E" +
    "j: Pago de la luz";
            // 
            // lblGasto
            // 
            this.lblGasto.AutoSize = true;
            this.lblGasto.Location = new System.Drawing.Point(24, 79);
            this.lblGasto.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblGasto.Name = "lblGasto";
            this.lblGasto.Size = new System.Drawing.Size(183, 16);
            this.lblGasto.TabIndex = 1;
            this.lblGasto.Text = "Gasto (Expresado en pesos):";
            // 
            // txtGasto
            // 
            this.txtGasto.Location = new System.Drawing.Point(215, 76);
            this.txtGasto.Margin = new System.Windows.Forms.Padding(4);
            this.txtGasto.Name = "txtGasto";
            this.txtGasto.Size = new System.Drawing.Size(130, 22);
            this.txtGasto.TabIndex = 2;
            // 
            // lblDescripcion
            // 
            this.lblDescripcion.AutoSize = true;
            this.lblDescripcion.Location = new System.Drawing.Point(24, 174);
            this.lblDescripcion.Name = "lblDescripcion";
            this.lblDescripcion.Size = new System.Drawing.Size(80, 16);
            this.lblDescripcion.TabIndex = 3;
            this.lblDescripcion.Text = "Descripción";
            // 
            // txtDescripcion
            // 
            this.txtDescripcion.Location = new System.Drawing.Point(27, 202);
            this.txtDescripcion.MaxLength = 200;
            this.txtDescripcion.Multiline = true;
            this.txtDescripcion.Name = "txtDescripcion";
            this.txtDescripcion.Size = new System.Drawing.Size(334, 80);
            this.txtDescripcion.TabIndex = 4;
            // 
            // btnConfirmar
            // 
            this.btnConfirmar.Location = new System.Drawing.Point(151, 288);
            this.btnConfirmar.Name = "btnConfirmar";
            this.btnConfirmar.Size = new System.Drawing.Size(75, 23);
            this.btnConfirmar.TabIndex = 5;
            this.btnConfirmar.Text = "Confirmar";
            this.btnConfirmar.UseVisualStyleBackColor = true;
            this.btnConfirmar.Click += new System.EventHandler(this.btnConfirmar_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(25, 115);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(49, 16);
            this.label1.TabIndex = 6;
            this.label1.Text = "Fecha:";
            // 
            // dtpFecha
            // 
            this.dtpFecha.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpFecha.Location = new System.Drawing.Point(215, 110);
            this.dtpFecha.Name = "dtpFecha";
            this.dtpFecha.Size = new System.Drawing.Size(130, 22);
            this.dtpFecha.TabIndex = 7;
            // 
            // txtNroFactura
            // 
            this.txtNroFactura.Location = new System.Drawing.Point(216, 143);
            this.txtNroFactura.Margin = new System.Windows.Forms.Padding(4);
            this.txtNroFactura.Name = "txtNroFactura";
            this.txtNroFactura.Size = new System.Drawing.Size(130, 22);
            this.txtNroFactura.TabIndex = 9;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(25, 146);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(95, 16);
            this.label2.TabIndex = 8;
            this.label2.Text = "Nro de factura:";
            // 
            // FormGastosGenerales
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(386, 316);
            this.Controls.Add(this.txtNroFactura);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.dtpFecha);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnConfirmar);
            this.Controls.Add(this.txtDescripcion);
            this.Controls.Add(this.lblDescripcion);
            this.Controls.Add(this.txtGasto);
            this.Controls.Add(this.lblGasto);
            this.Controls.Add(this.lblInstrucciones);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(402, 354);
            this.MinimizeBox = false;
            this.MinimumSize = new System.Drawing.Size(402, 354);
            this.Name = "FormGastosGenerales";
            this.ShowInTaskbar = false;
            this.Text = "Registro de gastos generales";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblInstrucciones;
        private System.Windows.Forms.Label lblGasto;
        private System.Windows.Forms.TextBox txtGasto;
        private System.Windows.Forms.Label lblDescripcion;
        private System.Windows.Forms.TextBox txtDescripcion;
        private System.Windows.Forms.Button btnConfirmar;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DateTimePicker dtpFecha;
        private System.Windows.Forms.TextBox txtNroFactura;
        private System.Windows.Forms.Label label2;
    }
}