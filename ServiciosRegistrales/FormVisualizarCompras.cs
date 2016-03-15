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
    public partial class FormVisualizarCompras : FormStart
    {
        public FormVisualizarCompras() : base()
        {
            InitializeComponent();
            grdCompras.DataSource = GenericBL<Compra>.listTodos(); 
        }

        private void grdCompras_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            DataGridViewRow dr = grdCompras.SelectedRows[0];
            txtFecha.Text = dr.Cells["fecha"].Value.ToString().Substring(0,10);
            if (Int32.Parse(dr.Cells["idProveedor"].Value.ToString()) == 0)
            {
                txtProveedor.Text = "(Gasto general)";
            }
            else
            {
                txtProveedor.Text = GenericBL<Proveedor>.get(Int32.Parse(dr.Cells["idProveedor"].Value.ToString())).razonSocial;
            }
            txtComentarios.Text = dr.Cells["descripcion"].Value.ToString();
            txtGastosExtra.Text = dr.Cells["gastosExtra"].Value.ToString();
            txtMontoTotal.Text = dr.Cells["importe"].Value.ToString();
            txtNroFactura.Text = dr.Cells["nroFactura"].Value.ToString();
            int idCompra = Int32.Parse(dr.Cells["id"].Value.ToString());

            Dictionary<string, object> filtroDetalle = new Dictionary<string, object>();
            filtroDetalle.Add("id_compra", idCompra);
            List<DetalleCompra> detalles = GenericBL<DetalleCompra>.listTodos(filtroDetalle);
            if(detalles.Count > 0)
            {
                cargarGrillaArticulos(detalles);
            }
            else
            {
                List<DetalleCompraFormulario> detallesForm = GenericBL<DetalleCompraFormulario>.listTodos(filtroDetalle);
                if (detallesForm.Count > 0) cargarGrillaFormularios(detallesForm);
                else grdDetalle.DataSource = null;
            }
        }

        private void cargarGrillaArticulos(List<DetalleCompra> detalles)
        {
            DataTable dataGrilla = new DataTable();
            dataGrilla.Columns.Add("Artículo");
            dataGrilla.Columns.Add("Precio unitario");
            dataGrilla.Columns.Add("Cantidad");
            dataGrilla.Columns.Add("IVA");
            dataGrilla.Columns.Add("Importe");
            float montoTotal = 0;
            foreach (DetalleCompra d in detalles)
            {
                DataRow row = dataGrilla.NewRow();
                row["Artículo"] = GenericBL<Articulo>.get(d.idArticulo).codigo;
                row["Precio unitario"] = d.precioUnitario;
                row["Cantidad"] = d.cantidad;
                row["IVA"] = d.iva;
                row["Importe"] = d.importe;
                dataGrilla.Rows.Add(row);
                montoTotal += d.importe;
            }
            grdDetalle.DataSource = dataGrilla;
        }

        private void cargarGrillaFormularios(List<DetalleCompraFormulario> detalles)
        {
            DataTable dataGrilla = new DataTable();
            dataGrilla.Columns.Add("Formulario");
            dataGrilla.Columns.Add("Cantidad");
            dataGrilla.Columns.Add("De número");
            dataGrilla.Columns.Add("A número");
            dataGrilla.Columns.Add("Precio unitario");
            dataGrilla.Columns.Add("Precio total");
            float montoTotal = 0;
            foreach (DetalleCompraFormulario d in detalles)
            {
                DataRow row = dataGrilla.NewRow();
                row["Formulario"] = GenericBL<Articulo>.get(d.idArticulo).codigo;
                row["Precio unitario"] = d.precioUnitario;
                row["Cantidad"] = d.cantidad;
                row["De número"] = d.codInicial;
                row["A número"] = d.codFinal;
                row["Precio total"] = d.importe;
                dataGrilla.Rows.Add(row);
                montoTotal += d.importe;
            }
            grdDetalle.DataSource = dataGrilla;
        }

        private void FormVisualizarCompras_FormClosing(object sender, FormClosingEventArgs e)
        {
            Application.Exit();
        }
    }
}
