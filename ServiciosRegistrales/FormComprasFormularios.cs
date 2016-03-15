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
    public partial class FormComprasFormularios : FormStart
    {
        private DataTable dataGrilla;
        private LinkedList<DetalleCompraFormulario> detalles;
        private int idCompra;
        private int indexSelected;

        public FormComprasFormularios() : base()
        {
            InitializeComponent();
            this.idCompra = GenericBL<Compra>.getNextId();
            dataGrilla = new DataTable();
            dataGrilla.Columns.Add("Formulario");
            dataGrilla.Columns.Add("Cantidad");
            dataGrilla.Columns.Add("De número");
            dataGrilla.Columns.Add("A número");
            dataGrilla.Columns.Add("Precio unitario");
            dataGrilla.Columns.Add("Precio total");
            cmbDepositos.DataSource = GenericBL<Deposito>.listActivos();
            grdDetalleCompra.DataSource = dataGrilla;
            detalles = new LinkedList<DetalleCompraFormulario>();
            Dictionary<string, object> filtro = new Dictionary<string, object>();
            filtro.Add("tipo_proveedor", "Formularios");
            cmbProveedores.DataSource = GenericBL<Proveedor>.listActivos(filtro);
            filtro = new Dictionary<string, object>();
            filtro.Add("es_formulario", 1);
            cmbArticulos.DataSource = GenericBL<Articulo>.listActivos(filtro);
            this.estado = Estado.NUEVO;
        }

        private void FormComprasFormularios_FormClosing(object sender, FormClosingEventArgs e)
        {
            Application.Exit();
        }

        private void actualizarImporte(object sendes, EventArgs e)
        {
            float precioUnitario = 0;
            try
            {
                precioUnitario = float.Parse(txtPrecioUnitario.Text);
            }
            catch
            {
                txtPrecioArticulo.Text = "";
                return;
            }
            txtPrecioArticulo.Text = precioUnitario * (float)(numericCantidad.Value) + "";

        }

        private void btnGuardarArticulo_Click(object sender, EventArgs e)
        {
            DetalleCompraFormulario d = new DetalleCompraFormulario();
            d.idCompra = this.idCompra;
            d.idArticulo = Int32.Parse(cmbArticulos.SelectedValue.ToString());
            d.cantidad = Int32.Parse(numericCantidad.Value.ToString());
            try
            {
                d.precioUnitario = float.Parse(txtPrecioUnitario.Text);
                d.codInicial = long.Parse(txtCodigoDesde.Text);
            }
            catch
            {
                MessageBox.Show("El precio unitario o el código inicial están en formato incorrecto", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            d.codFinal = d.codInicial + d.cantidad - 1;
            d.importe = float.Parse(txtPrecioArticulo.Text);
            if(this.estado == Estado.NUEVO)
            {
                this.detalles.AddLast(d);
            }
            else
            {
                var currentNode = detalles.First;
                int i = 0;
                while (currentNode != null)
                {
                    if (i == indexSelected)
                    {
                        currentNode.Value = d;
                        break;
                    }
                    else
                    {
                        currentNode = currentNode.Next;
                    }
                    i++;
                }
            }
            numericCantidad.Value = 0;
            txtPrecioArticulo.Text = "";
            txtPrecioUnitario.Text = "";
            btnNuevoArticulo.Enabled = false;
            btnEliminarArticulo.Enabled = false;
            this.estado = Estado.NUEVO;
            actualizarGrilla();
        }

        private void actualizarGrilla()
        {
            dataGrilla = new DataTable();
            dataGrilla.Columns.Add("Formulario");
            dataGrilla.Columns.Add("Cantidad");
            dataGrilla.Columns.Add("De número");
            dataGrilla.Columns.Add("A número");
            dataGrilla.Columns.Add("Precio unitario");
            dataGrilla.Columns.Add("Precio total");
            float montoTotal = 0;
            foreach(DetalleCompraFormulario d in detalles)
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
            grdDetalleCompra.DataSource = dataGrilla;
            float gastosExtra = 0;
            try
            {
                gastosExtra = float.Parse(txtGastosExtra.Text);
            }
            catch { }
            montoTotal += gastosExtra;
            lblMontoTotalValor.Text = montoTotal.ToString();
        }

        private void limpiarTodo()
        {
            this.idCompra = GenericBL<Compra>.getNextId();
            dataGrilla = new DataTable();
            dataGrilla.Columns.Add("Formulario");
            dataGrilla.Columns.Add("Cantidad");
            dataGrilla.Columns.Add("De número");
            dataGrilla.Columns.Add("A número");
            dataGrilla.Columns.Add("Precio unitario");
            dataGrilla.Columns.Add("Precio total");
            grdDetalleCompra.DataSource = dataGrilla;
            detalles = new LinkedList<DetalleCompraFormulario>();
            txtComentarios.Text = "";
            txtPrecioArticulo.Text = "";
            txtNroFactura.Text = "";
            lblMontoTotalValor.Text = "0";
            txtGastosExtra.Text = "";
            txtPrecioUnitario.Text = "";
            txtCodigoDesde.Text = "";
            dtpFecha.Value = DateTime.Today;
            btnNuevoArticulo.Enabled = false;
            btnEliminarArticulo.Enabled = false;
        }

        private void grdDetalleCompra_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (grdDetalleCompra.RowCount == 0) return;
            int index = grdDetalleCompra.SelectedRows[0].Index;
            this.indexSelected = index;
            DetalleCompraFormulario d = detalles.ElementAt(index);
            cmbArticulos.SelectedValue = d.idArticulo;
            txtPrecioUnitario.Text = d.precioUnitario.ToString();
            numericCantidad.Value = d.cantidad;
            txtCodigoDesde.Text = d.codInicial.ToString();
            btnNuevoArticulo.Enabled = true;
            btnEliminarArticulo.Enabled = true;
            this.estado = Estado.MODIFICAR;
        }

        private void btnNuevoArticulo_Click(object sender, EventArgs e)
        {
            numericCantidad.Value = 0;
            txtPrecioArticulo.Text = "";
            txtCodigoDesde.Text = "";
            btnNuevoArticulo.Enabled = false;
            btnEliminarArticulo.Enabled = false;
            this.estado = Estado.NUEVO;
        }

        private void btnEliminarArticulo_Click(object sender, EventArgs e)
        {
            var currentNode = detalles.First;
            int i = 0;
            while (currentNode != null)
            {
                if (i == indexSelected)
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
            numericCantidad.Value = 0;
            txtPrecioArticulo.Text = "";
            txtCodigoDesde.Text = "";
            btnNuevoArticulo.Enabled = false;
            btnEliminarArticulo.Enabled = false;
            this.estado = Estado.NUEVO;
            actualizarGrilla();
        }

        private void btnRegistrarCompra_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("¿Está seguro que desea ingresar la compra? Revise los datos ya que los cambios no podrán deshacerse.", "Confirmación",
             MessageBoxButtons.YesNo, MessageBoxIcon.Question,
             MessageBoxDefaultButton.Button1) != System.Windows.Forms.DialogResult.Yes) return;
            Compra c = new Compra();
            if(txtNroFactura.Text == "")
            {
                MessageBox.Show("El número de factura es obligatorio.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            float gastosGenerales = 0;
            try
            {
                gastosGenerales = float.Parse(txtGastosExtra.Text);
            }
            catch { }
            c.gastosExtra = gastosGenerales;
            c.nroFactura = txtNroFactura.Text;
            c.id = idCompra;
            c.idProveedor = Int32.Parse(cmbProveedores.SelectedValue.ToString());
            c.descripcion = (txtComentarios.Text == "" || txtComentarios.Text == " ") ? "<sin comentarios>" : txtComentarios.Text;
            c.importe = float.Parse(lblMontoTotalValor.Text);
            c.fecha = dtpFecha.Value;
            GenericBL<Compra>.insert(c);

            foreach(DetalleCompraFormulario d in detalles)
            {
                d.id = GenericBL<DetalleCompraFormulario>.getNextId();
                GenericBL<DetalleCompraFormulario>.insert(d);
                StockFormulario sf = new StockFormulario();
                sf.id = GenericBL<StockFormulario>.getNextId();
                sf.idDeposito = Int32.Parse(cmbDepositos.SelectedValue.ToString());
                sf.idArticulo = d.idArticulo;
                sf.cantidad = d.cantidad;
                sf.proxCodigo = d.codInicial;
                GenericBL<StockFormulario>.insert(sf);
            }
            limpiarTodo();
            MessageBox.Show("¡La compra fue registrada con éxito! Puede revisarla en 'Visualización de compras'", "Compra realizada", MessageBoxButtons.OK, MessageBoxIcon.Information);
            idCompra = GenericBL<Compra>.getNextId();
        }

        private void btnLimpiarDatos_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("¿Está seguro que desea limpiar los datos? Deberá ingresar TODOS los datos de la compra nuevamente.", "Confirmación",
             MessageBoxButtons.YesNo, MessageBoxIcon.Question,
             MessageBoxDefaultButton.Button1) != System.Windows.Forms.DialogResult.Yes) return;
            limpiarTodo();
        }

        private void txtGastosExtra_Leave(object sender, EventArgs e)
        {
            actualizarGrilla();
        }

        private void txtPrecioUnitario_KeyUp(object sender, KeyEventArgs e)
        {
            actualizarImporte(null, null);
        }




    }
}
