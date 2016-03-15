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
    public partial class FormVentas : FormStart
    {
        private List<Articulo> articulos = GenericBL<Articulo>.listActivos();
        private LinkedList<DetalleConDeposito> detalles;
        private int idVenta;
        private int index;
        private Cliente cliente;

        public FormVentas() : base()
        {
            InitializeComponent();
            cmbDeposito.DataSource = GenericBL<Deposito>.listActivos();
            idVenta = GenericBL<Venta>.getNextId();
            DataTable dt = new DataTable();
            dt.Columns.Add("id");
            dt.Columns.Add("nombre");
            DataRow dr;
            for(int i=1; i<=5; i++)
            {
                dr = dt.NewRow();
                dr["id"] = i;
                dr["nombre"] = "Lista " + i;
                dt.Rows.Add(dr);
            }
            cmbLista.DataSource = dt;
            string[] codigos = new string[articulos.Count];
            int j = 0;
            foreach(Articulo a in articulos)
            {
                codigos[j] = a.codigo;
                j++;
            }
            var source = new AutoCompleteStringCollection();
            source.AddRange(codigos);
            txtCodArticulo.AutoCompleteMode = AutoCompleteMode.SuggestAppend;
            txtCodArticulo.AutoCompleteCustomSource = source;
            txtCodArticulo.AutoCompleteSource = AutoCompleteSource.CustomSource;
            detalles = new LinkedList<DetalleConDeposito>();
            actualizarGrilla();
            this.estado = Estado.NUEVO;
        }

        private void actualizarStock()
        {
            Boolean found = false;
            foreach (Articulo a in articulos)
            {
                if (found) break;
                if (a.codigo.Equals(txtCodArticulo.Text,StringComparison.OrdinalIgnoreCase))
                {
                    found = true;
                    lblDescripcionArticulo.Text = a.descripcion;
                    Dictionary<string, object> stock = new Dictionary<string, object>();
                    stock.Add("id_deposito", cmbDeposito.SelectedValue);
                    stock.Add("id_articulo", a.id);
                    numericCantidad.Value = 0;
                    if (a.esFormulario == 1)
                    {
                        List<StockFormulario> stockForm = GenericBL<StockFormulario>.listTodos(stock);
                        if (stockForm.Count == 0)
                        {
                            txtCantDeposito.Text = "0";
                            txtCodDesde.Text = "----";
                            txtCodHasta.Text = "----";
                            numericCantidad.Maximum = 0;
                        }
                        else
                        {
                            StockFormulario stockF = stockForm.ElementAt(0);
                            txtCantDeposito.Text = stockF.cantidad.ToString();
                            txtCodDesde.Text = stockF.proxCodigo.ToString();
                            txtCodHasta.Text = stockF.proxCodigo + stockF.cantidad - 1 + "";
                            numericCantidad.Maximum = stockF.cantidad;
                        }
                    }
                    else
                    {
                        List<StockArticulo> stockArt = GenericBL<StockArticulo>.listTodos(stock);
                        txtCodDesde.Text = "----";
                        txtCodHasta.Text = "----";
                        if (stockArt.Count == 0)
                        {
                            txtCantDeposito.Text = "0";
                            numericCantidad.Maximum = 0;
                        }
                        else
                        {
                            StockArticulo stockA = stockArt.ElementAt(0);
                            txtCantDeposito.Text = stockA.cantidad.ToString();
                            numericCantidad.Maximum = stockA.cantidad;
                        }
                    }
                }
                else
                {
                    lblDescripcionArticulo.Text = "<Descripción del artículo>";
                    txtCantDeposito.Text = "";
                    txtCodDesde.Text = "----";
                    txtCodHasta.Text = "----";
                    numericCantidad.Value = 0;
                    numericCantidad.Maximum = 0;
                }
            }
        }

        private void actualizarPrecio(object sender, EventArgs e)
        {
            bool found = false;
            foreach(Articulo a in articulos)
            {
                if (found) break;
                if(a.codigo.Equals(txtCodArticulo.Text))
                {
                    found = true;
                    Dictionary<string, object> filtroPrecio = new Dictionary<string, object>();
                    filtroPrecio.Add("cod_articulo", a.codigo);
                    List<PrecioArticulo> precios = GenericBL<PrecioArticulo>.listTodos(filtroPrecio);
                    PrecioArticulo precio = precios.ElementAt(0);
                    txtPrecioUnitario.Text = precio.getPrecio(Int32.Parse(cmbLista.SelectedValue.ToString())) + "";
                    txtPrecioArticulo.Text = (precio.getPrecio(Int32.Parse(cmbLista.SelectedValue.ToString())) * (float)numericCantidad.Value) + "";
                }
                else
                {
                    txtPrecioArticulo.Text = "0";
                    txtPrecioUnitario.Text = "0";
                }
            }
        }

        private void actualizarGrilla()
        {
            DataTable dataTable = new DataTable();
            dataTable.Columns.Add("Artículo");
            dataTable.Columns.Add("Cantidad");
            dataTable.Columns.Add("De depósito");
            dataTable.Columns.Add("De número");
            dataTable.Columns.Add("A número");
            dataTable.Columns.Add("Lista");
            dataTable.Columns.Add("Precio unitario");
            dataTable.Columns.Add("Importe");
            DataRow dr;
            float montoTotal = 0;
            foreach(DetalleConDeposito d in detalles)
            {
                dr = dataTable.NewRow();
                dr["Artículo"] = GenericBL<Articulo>.get(d.detalle.idArticulo).codigo;
                dr["Cantidad"] = d.detalle.cantidad;
                dr["De depósito"] = GenericBL<Deposito>.get(d.idDeposito).descripcion;
                dr["De número"] = (d.detalle.codDesde == 0) ? "----" : d.detalle.codDesde.ToString();
                dr["A número"] = (d.detalle.codHasta == 0) ? "----" : d.detalle.codHasta.ToString();
                dr["Lista"] = d.detalle.lista;
                dr["Precio unitario"] = "$ " + d.detalle.precioUnitario;
                dr["Importe"] = "$ " + d.detalle.importe;
                dataTable.Rows.Add(dr);
                montoTotal += d.detalle.importe;
            }
            grdDetalleVenta.DataSource = dataTable;
            lblMontoTotalValor.Text = montoTotal.ToString();
        }

        private void limpiarCamposArticulos()
        {
            txtCodArticulo.Text = "";
            lblDescripcionArticulo.Text = "<Descripción del artículo>";
            txtCantDeposito.Text = "0";
            txtCodDesde.Text = "----";
            txtCodHasta.Text = "----";
            numericCantidad.Value = 0;
            txtPrecioArticulo.Text = "0";
            txtPrecioUnitario.Text = "0";
            btnNuevoArticulo.Enabled = false;
            btnEliminarArticulo.Enabled = false;
            this.estado = Estado.NUEVO;
        }

        private void limpiarTodo()
        {
            dtpFecha.Value = DateTime.Today;
            txtComentarios.Text = "";
            chkCliente.Checked = false;
            txtDocumento.Text = "";
            this.cliente = null;
            lblApellidoYNombreCliente.Text = "Apellido y nombre";
            this.detalles = new LinkedList<DetalleConDeposito>();
            actualizarGrilla();
            limpiarCamposArticulos();
            actualizarStock();
            actualizarPrecio(null, null);
        }

        private void txtCodArticulo_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.KeyChar = Char.ToUpper(e.KeyChar);
        }

        private void txtCodArticulo_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Return)
            {
                actualizarStock();
                actualizarPrecio(null, null);
            }
        }

        private void cmbDeposito_SelectedIndexChanged(object sender, EventArgs e)
        {
            actualizarStock();
            actualizarPrecio(sender, e);
        }

        private void chkCliente_CheckedChanged(object sender, EventArgs e)
        {
            if(chkCliente.Checked)
            {
                txtDocumento.ReadOnly = false;
                btnBuscarCliente.Enabled = true;
            }
            else
            {
                txtDocumento.Text = "";
                txtDocumento.ReadOnly = true;
                btnBuscarCliente.Enabled = false;
                lblApellidoYNombreCliente.Text = "Apellido y nombre";
                this.cliente = null;
            }
        }

        private void FormVentas_FormClosing(object sender, FormClosingEventArgs e)
        {
            Application.Exit();
        }

        private void btnBuscarCliente_Click(object sender, EventArgs e)
        {
            Dictionary<string, object> filtroDoc = new Dictionary<string, object>();
            filtroDoc.Add("documento", long.Parse(txtDocumento.Text));
            List<Cliente> clientes = GenericBL<Cliente>.listActivos(filtroDoc);
            if(clientes.Count == 0)
            {
                MessageBox.Show("No se ha encontrado un cliente con ese documento.", "Cliente no encontrado", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                this.cliente = clientes.ElementAt(0);
                lblApellidoYNombreCliente.Text = cliente.apellido + ", " + cliente.nombre;
            }
        }

        private void txtDocumento_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = !char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar);
        }

        private void btnGuardarArticulo_Click(object sender, EventArgs e)
        {
            DetalleVenta detalleVenta = new DetalleVenta();
            bool found = false;
            foreach (Articulo a in articulos)
            {
                if (a.codigo.Equals(txtCodArticulo.Text))
                {
                    detalleVenta.idArticulo = a.id;
                    found = true;
                }
            }
            if(!found)
            {
                MessageBox.Show("Debe seleccionar un artículo antes", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            foreach(DetalleConDeposito d in detalles)
            {
                if(detalleVenta.idArticulo == d.detalle.idArticulo && Int32.Parse(cmbDeposito.SelectedValue.ToString()) == d.idDeposito)
                {
                    MessageBox.Show("Ya ha cargado en la venta ese artículo en ese depósito. Para modificar los datos seleccione el registro en la grilla por favor.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }
            }
            try
            {
                detalleVenta.cantidad = Int32.Parse(numericCantidad.Value.ToString());
            }
            catch
            {
                detalleVenta.cantidad = 0;
            }
            if(detalleVenta.cantidad <= 0)
            {
                MessageBox.Show("Debe seleccionar un número entero mayor que 0 para la cantidad.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            detalleVenta.codDesde = (txtCodDesde.Text == "----") ? 0 : long.Parse(txtCodDesde.Text);
            detalleVenta.codHasta = (txtCodDesde.Text == "----") ? 0 : long.Parse(txtCodDesde.Text) + detalleVenta.cantidad - 1;
            detalleVenta.idVenta = idVenta;
            detalleVenta.precioUnitario = float.Parse(txtPrecioUnitario.Text);
            detalleVenta.importe = float.Parse(txtPrecioArticulo.Text);
            detalleVenta.lista = Int32.Parse(cmbLista.SelectedValue.ToString());
            if(this.estado == Estado.NUEVO)
            {
                this.detalles.AddLast(new DetalleConDeposito(detalleVenta, Int32.Parse(cmbDeposito.SelectedValue.ToString())));
            }
            else
            {
                var currentNode = detalles.First;
                int i = 0;
                while (currentNode != null)
                {
                    if (i == index)
                    {
                        currentNode.Value = new DetalleConDeposito(detalleVenta, Int32.Parse(cmbDeposito.SelectedValue.ToString()));
                        break;
                    }
                    else
                    {
                        currentNode = currentNode.Next;
                    }
                    i++;
                }
            }       
            actualizarGrilla();
            limpiarCamposArticulos();
        }

        private void grdDetalleVenta_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (grdDetalleVenta.RowCount == 0) return;
            index = grdDetalleVenta.SelectedRows[0].Index;
            DetalleConDeposito d = detalles.ElementAt(index);
            Articulo a = GenericBL<Articulo>.get(d.detalle.idArticulo);
            txtCodArticulo.Text = a.codigo;
            lblDescripcionArticulo.Text = a.descripcion;
            cmbDeposito.SelectedValue = d.idDeposito;
            actualizarStock();
            numericCantidad.Value = d.detalle.cantidad;
            cmbLista.SelectedValue = d.detalle.lista;
            actualizarPrecio(null, null);
            btnNuevoArticulo.Enabled = true;
            btnEliminarArticulo.Enabled = true;
            this.estado = Estado.MODIFICAR;
        }

        private void btnNuevoArticulo_Click(object sender, EventArgs e)
        {
            limpiarCamposArticulos();
        }

        private void btnEliminarArticulo_Click(object sender, EventArgs e)
        {
            var currentNode = detalles.First;
            int i = 0;
            while (currentNode != null)
            {
                if (i == index)
                {
                    var toRemove = currentNode;
                    currentNode = currentNode.Next;
                    detalles.Remove(toRemove);
                    break;
                }
                else
                {
                    currentNode = currentNode.Next;
                }
                i++;
            }
            actualizarGrilla();
            limpiarCamposArticulos();
        }

        private void btnLimpiarDatos_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("¿Está seguro que desea limpiar los datos? Deberá volver a empezar.", "Confirmación",
              MessageBoxButtons.YesNo, MessageBoxIcon.Question,
              MessageBoxDefaultButton.Button1) != System.Windows.Forms.DialogResult.Yes) return;
            limpiarTodo();
        }

        private void btnRegistrarVenta_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("¿Está seguro que desea ingresar la venta? Revise los datos ya que los cambios no podrán deshacerse.", "Confirmación",
              MessageBoxButtons.YesNo, MessageBoxIcon.Question,
              MessageBoxDefaultButton.Button1) != System.Windows.Forms.DialogResult.Yes) return;
            if(this.detalles.Count == 0)
            {
                MessageBox.Show("Ingrese al menos un artículo para vender.", "Faltan artículos", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            if(chkCliente.Checked && this.cliente == null)
            {
                MessageBox.Show("No ha ingresado un cliente. Si no necesita los datos destilde la opción 'Necesito los datos del cliente'", "Faltan artículos", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            Venta v = new Venta();
            v.id = idVenta;
            v.descripcion = (txtComentarios.Text == "") ? "<sin comentarios>" : txtComentarios.Text;
            v.fecha = dtpFecha.Value;
            v.idCliente = (this.cliente == null) ? -1 : this.cliente.id;
            v.importe = float.Parse(lblMontoTotalValor.Text);
            GenericBL<Venta>.insert(v);

            foreach(DetalleConDeposito d in detalles)
            {
                DetalleVenta detalleVenta = d.detalle;
                detalleVenta.id = GenericBL<DetalleVenta>.getNextId();
                GenericBL<DetalleVenta>.insert(detalleVenta);
                Dictionary<string, object> filtroStockArticulo = new Dictionary<string, object>();
                filtroStockArticulo.Add("id_articulo", detalleVenta.idArticulo);
                filtroStockArticulo.Add("id_deposito", d.idDeposito);
                List<StockArticulo> stockArt = GenericBL<StockArticulo>.listTodos(filtroStockArticulo);
                if(stockArt.Count > 0)
                {
                    StockArticulo stockA = stockArt.ElementAt(0);
                    stockA.cantidad -= detalleVenta.cantidad;
                    GenericBL<StockArticulo>.update(stockA);
                }
                else
                {
                    List<StockFormulario> stockForm = GenericBL<StockFormulario>.listTodos(filtroStockArticulo);
                    if (stockForm.Count == 0) break;
                    StockFormulario stockF = stockForm.ElementAt(0);
                    stockF.cantidad -= detalleVenta.cantidad;
                    stockF.proxCodigo += detalleVenta.cantidad;
                    GenericBL<StockFormulario>.update(stockF);
                }
            }
            limpiarTodo();
            MessageBox.Show("¡La venta ha sido cargada con éxito!", "¡Listo!", MessageBoxButtons.OK, MessageBoxIcon.Information);
            idVenta = GenericBL<Venta>.getNextId();
        }

        private class DetalleConDeposito
        {
            public DetalleVenta detalle;
            public int idDeposito;

            public DetalleConDeposito(DetalleVenta d, int idDep)
            {
                this.detalle = d;
                this.idDeposito = idDep;
            }
        }




    }
}
