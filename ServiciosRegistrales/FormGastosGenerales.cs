using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using BusinessEntity;
using BusinessLayer;

namespace ServiciosRegistrales
{
    public partial class FormGastosGenerales : Form
    {
        public FormGastosGenerales()
        {
            InitializeComponent();
        }

        private void btnConfirmar_Click(object sender, EventArgs e)
        {
            float gasto;
            if (txtGasto.Text == "" || txtDescripcion.Text == "")
            {
                MessageBox.Show("Los campos gastos y descripción son obligatorios", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            else
            {
                try
                {
                    gasto = float.Parse(txtGasto.Text);
                }
                catch
                {
                    MessageBox.Show("El campo gasto está en un formato incorrecto. Por favor ingrese un número.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }
            }
            if (MessageBox.Show("¿Está seguro que desea ingresar el gasto? Los cambios no podrán deshacerse.", "Confirmación",
               MessageBoxButtons.YesNo, MessageBoxIcon.Question,
               MessageBoxDefaultButton.Button1) != System.Windows.Forms.DialogResult.Yes) return;
            Compra c = new Compra();
            c.id = GenericBL<Compra>.getNextId();
            c.descripcion = txtDescripcion.Text;
            c.fecha = dtpFecha.Value;
            c.importe = gasto;
            c.idProveedor = 0;
            c.nroFactura = (txtNroFactura.Text == "" || txtNroFactura.Text == " ") ? "Sin especificar" : txtNroFactura.Text;
            GenericBL<Compra>.insert(c);
            txtGasto.Text = "";
            txtDescripcion.Text = "";
            txtNroFactura.Text = "";
            dtpFecha.Value = DateTime.Today;
            MessageBox.Show("¡El gasto fue ingresado correctamente!", "Gasto ingresado", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }
    }
}
