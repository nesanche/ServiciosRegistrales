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
    public partial class FormVisualizarVentas : FormStart
    {
        private List<Venta> ventas = GenericBL<Venta>.listTodos();

        public FormVisualizarVentas() : base()
        {
            InitializeComponent();
            actualizarGrillaVentas();
            actualizarGrillaDetalles(new List<DetalleVenta>());
        }

        private void actualizarGrillaVentas()
        {
            DataTable dt = new DataTable();
            dt.Columns.Add("id");
            dt.Columns.Add("Fecha");
            dt.Columns.Add("idCliente");
            dt.Columns.Add("Cliente");
            dt.Columns.Add("Importe");
            dt.Columns.Add("Comentarios");
            DataRow dr;
            foreach(Venta v in ventas)
            {
                dr = dt.NewRow();
                dr["id"] = v.id;
                dr["Fecha"] = String.Format("{0: dd/MM/yyyy}", v.fecha);
                dr["idCliente"] = v.idCliente;
                if(v.idCliente != -1)
                {
                    Cliente c = GenericBL<Cliente>.get(v.idCliente);
                    dr["Cliente"] = c.apellido + ", " + c.nombre;
                }
                else
                {
                    dr["Cliente"] = "desconocido";
                }
                dr["Importe"] = "$ " + v.importe;
                dr["Comentarios"] = v.descripcion;
                dt.Rows.Add(dr);
            }
            grdVentas.DataSource = dt;
            grdVentas.Columns["id"].Visible = false;
            grdVentas.Columns["idCliente"].Visible = false;
        }

        private void actualizarGrillaDetalles(List<DetalleVenta> detalles)
        {
            DataTable dataTable = new DataTable();
            dataTable.Columns.Add("Artículo");
            dataTable.Columns.Add("Cantidad");
            dataTable.Columns.Add("De número");
            dataTable.Columns.Add("A número");
            dataTable.Columns.Add("Precio unitario");
            dataTable.Columns.Add("Importe");
            DataRow dr;
            foreach (DetalleVenta d in detalles)
            {
                dr = dataTable.NewRow();
                dr["Artículo"] = GenericBL<Articulo>.get(d.idArticulo).codigo;
                dr["Cantidad"] = d.cantidad;
                dr["De número"] = (d.codDesde == 0) ? "----" : d.codDesde.ToString();
                dr["A número"] = (d.codHasta == 0) ? "----" : d.codHasta.ToString();
                dr["Precio unitario"] = "$ " + d.precioUnitario;
                dr["Importe"] = "$ " + d.importe;
                dataTable.Rows.Add(dr);
            }
            grdDetalles.DataSource = dataTable;
        }

        private void grdVentas_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (grdVentas.Rows.Count == 0) return;
            txtFecha.Text = grdVentas.SelectedRows[0].Cells["Fecha"].Value.ToString().Substring(0,10);
            txtComentarios.Text = grdVentas.SelectedRows[0].Cells["Comentarios"].Value.ToString();
            txtMontoTotal.Text = grdVentas.SelectedRows[0].Cells["Importe"].Value.ToString();
            if(grdVentas.SelectedRows[0].Cells["idCliente"].Value.ToString() != "-1")
            {
                 Cliente c = GenericBL<Cliente>.get(Int32.Parse(grdVentas.SelectedRows[0].Cells["idCliente"].Value.ToString()));
                 txtNumeroCliente.Text = c.id.ToString();
                 txtDocumento.Text = c.documento.ToString();
                 txtApellidoYNombre.Text = grdVentas.SelectedRows[0].Cells["Cliente"].Value.ToString();
            }
            else
            {
                txtDocumento.Text = txtApellidoYNombre.Text = txtNumeroCliente.Text = "------";
            }
            Dictionary<string, object> filtroDetalle = new Dictionary<string, object>();
            filtroDetalle.Add("id_venta", Int32.Parse(grdVentas.SelectedRows[0].Cells["id"].Value.ToString()));
            List<DetalleVenta> detalles = GenericBL<DetalleVenta>.listTodos(filtroDetalle);
            actualizarGrillaDetalles(detalles);
        }

        private void FormVisualizarVentas_FormClosing(object sender, FormClosingEventArgs e)
        {
            Application.Exit();
        }
    }
}
