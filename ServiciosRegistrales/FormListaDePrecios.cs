using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using BusinessLayer;
using BusinessEntity;

namespace ServiciosRegistrales
{
    public partial class FormListaDePrecios : FormStart
    {
        private List<PrecioArticulo> precios;
        private PrecioArticulo precioActual;
        public FormListaDePrecios() : base()
        {
            InitializeComponent();
            precios = GenericBL<PrecioArticulo>.listTodos();
            if (precios.Count == 0)
            {
                MessageBox.Show("No hay artículos cargados para que pueda comenzar con esta sección. Por favor cargue al menos uno y luego podrá ingresar aquí.", "Faltan artículos", MessageBoxButtons.OK, MessageBoxIcon.Information);
                this.Hide();
            }
            cmbArticulos.DataSource = precios;
            grdPrecios.DataSource = precios;
            cmbArticulos.SelectedIndex = 0;
            refresh();
        }

        private void refresh()
        {
            precioActual = precios.ElementAt(cmbArticulos.SelectedIndex);
            txtLista1.Text = precioActual.lista1.ToString();
            txtLista2.Text = precioActual.lista2.ToString();
            txtLista3.Text = precioActual.lista3.ToString();
            txtLista4.Text = precioActual.lista4.ToString();
            txtLista5.Text = precioActual.lista5.ToString();
        }

        private void cmbArticulos_SelectedIndexChanged(object sender, EventArgs e)
        {
            refresh();
        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            try
            {
                precioActual.lista1 = float.Parse(txtLista1.Text);
                precioActual.lista2 = float.Parse(txtLista2.Text);
                precioActual.lista3 = float.Parse(txtLista3.Text);
                precioActual.lista4 = float.Parse(txtLista4.Text);
                precioActual.lista5 = float.Parse(txtLista5.Text);
            }
            catch
            {
                MessageBox.Show("Uno de sus precios está en formato incorrecto", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            GenericBL<PrecioArticulo>.update(precioActual);
            precios = GenericBL<PrecioArticulo>.listTodos();
            cmbArticulos.DataSource = precios;
            grdPrecios.DataSource = precios;
            cmbArticulos.SelectedIndex = 0;
            refresh();
            MessageBox.Show("Cambios guardados correctamente", "Cambios guardados", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }
    }
}
