using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Configuration;
namespace ServiciosRegistrales
{
    public partial class FormStart : Form
    {
        protected enum Estado
        {
            NUEVO, MODIFICAR
        }
        protected Estado estado;
        public FormStart()
        {
            InitializeComponent();
            this.Text = "Servicios Registrales v 1.0";
        }

        private void cargarModificarClientesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if(this.GetType() == typeof(FormClientes)) return;
            FormClientes form = new FormClientes();
            Hide();
            form.ShowDialog();
        }

        private void cargarModificarProveedoresToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (this.GetType() == typeof(FormProveedores)) return;
            FormProveedores form = new FormProveedores();
            Hide();
            form.ShowDialog();
        }

        private void cargarModificarArtículosToolStripMenuItem_Click(object sender, EventArgs e)
        {
        }

        private void cargarModificarDepósitosDeStockToolStripMenuItem_Click(object sender, EventArgs e)
        {
        }

        private void gastosGeneralesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FormGastosGenerales form = new FormGastosGenerales();
            form.ShowDialog();
        }

        private void registrarNuevaCompraToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (this.GetType() == typeof(FormCompras)) return;
            FormCompras form = new FormCompras();
            Hide();
            form.ShowDialog();
        }

        private void datosGeneralesDeArtículosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (this.GetType() == typeof(FormArticulos)) return;
            FormArticulos form = new FormArticulos();
            Hide();
            form.ShowDialog();
        }

        private void administrarDepósitosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FormDepositos form = new FormDepositos();
            form.ShowDialog();
        }

        private void listasDePreciosToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            if (this.GetType() == typeof(FormListaDePrecios)) return;
            FormListaDePrecios form = new FormListaDePrecios();
            Hide();
            form.ShowDialog();

        }

        private void admninistrarStockDisponibleToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (this.GetType() == typeof(FormStock)) return;
            FormStock form = new FormStock();
            Hide();
            form.ShowDialog();
        }

        private void registrarNuevaCompraDeFormulariosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (this.GetType() == typeof(FormComprasFormularios)) return;
            FormComprasFormularios form = new FormComprasFormularios();
            Hide();
            form.ShowDialog();
        }

        private void visualizarÚltimasComprasToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (this.GetType() == typeof(FormVisualizarCompras)) return;
            FormVisualizarCompras form = new FormVisualizarCompras();
            Hide();
            form.ShowDialog();
        }

        private void registrarNuevaVentaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (this.GetType() == typeof(FormVentas)) return;
            FormVentas form = new FormVentas();
            Hide();
            form.ShowDialog();
        }

        private void visualizarÚltimasVentasToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (this.GetType() == typeof(FormVisualizarVentas)) return;
            FormVisualizarVentas form = new FormVisualizarVentas();
            Hide();
            form.ShowDialog();
        }

        private void buscarBaseDeDatosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            OpenFileDialog choofdlog = new OpenFileDialog();
            choofdlog.Filter = "All Files (*.*)|*.*";
            choofdlog.FilterIndex = 1;
            choofdlog.Multiselect = false;
            if (choofdlog.ShowDialog() != DialogResult.OK) return;

            System.IO.FileInfo fInfo = new System.IO.FileInfo(choofdlog.FileName);
            string fullName = fInfo.FullName;
            System.IO.File.WriteAllText("database.txt", fullName);
        }
    }
}
