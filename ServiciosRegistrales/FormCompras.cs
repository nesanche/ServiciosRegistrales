using System;
using System.Collections.Generic;
using System.Collections;
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
    public partial class FormCompras : FormStart
    {
        private DataTable dataGrilla;
        private LinkedList<DetalleCompra> detalles;
        private int idCompra;
        private int indexSelected;

        public FormCompras() : base()
        {
            InitializeComponent();
            this.idCompra = GenericBL<Compra>.getNextId();
            dataGrilla = new DataTable();
            dataGrilla.Columns.Add("Artículo");
            dataGrilla.Columns.Add("Precio unitario");
            dataGrilla.Columns.Add("Cantidad");
            dataGrilla.Columns.Add("IVA");
            dataGrilla.Columns.Add("Importe");
            DataTable iva = new DataTable();
            iva.Columns.Add("aumento");
            DataRow dr = iva.NewRow();
            dr["aumento"] = "10,5";
            iva.Rows.Add(dr);
            dr = iva.NewRow();
            dr["aumento"] = "21";
            iva.Rows.Add(dr);
            cmbIva.DataSource = iva;
            cmbDepositos.DataSource = GenericBL<Deposito>.listActivos();
            grdDetalleCompra.DataSource = dataGrilla;
            detalles = new LinkedList<DetalleCompra>();
            Dictionary<string, object> filtro = new Dictionary<string, object>();
            filtro.Add("tipo_proveedor", "Otros");
            cmbProveedores.DataSource = GenericBL<Proveedor>.listActivos(filtro);
            filtro = new Dictionary<string, object>();
            filtro.Add("es_formulario", 0);
            cmbArticulos.DataSource = GenericBL<Articulo>.listActivos(filtro);
            this.estado = Estado.NUEVO;
        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void FormCompras_FormClosing(object sender, FormClosingEventArgs e)
        {
            Application.Exit();
        }

        private void actualizarImporte(object sender, EventArgs e)
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
            txtPrecioArticulo.Text = precioUnitario * (float)(numericCantidad.Value) * (100 + float.Parse(cmbIva.SelectedValue.ToString())) / 100 + ""; 
        }

        private void btnGuardarArticulo_Click(object sender, EventArgs e)
        {
            DetalleCompra d = new DetalleCompra();
            d.idCompra = this.idCompra;
            d.idArticulo = Int32.Parse(cmbArticulos.SelectedValue.ToString());
            d.cantidad = Int32.Parse(numericCantidad.Value.ToString());
            d.iva = float.Parse(cmbIva.SelectedValue.ToString());
            try
            {
                d.precioUnitario = float.Parse(txtPrecioUnitario.Text);
            }
            catch
            {
                MessageBox.Show("El precio unitario está en formato incorrecto", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            d.importe = float.Parse(txtPrecioArticulo.Text);
            if (this.estado == Estado.NUEVO)
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
            dataGrilla.Columns.Add("Artículo");
            dataGrilla.Columns.Add("Precio unitario");
            dataGrilla.Columns.Add("Cantidad");
            dataGrilla.Columns.Add("IVA");
            dataGrilla.Columns.Add("Importe");
            float montoTotal = 0;
            foreach(DetalleCompra d in detalles) 
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
            grdDetalleCompra.DataSource = dataGrilla;

            float gastosExtra = 0;
            try
            {
                gastosExtra = float.Parse(txtGastosExtra.Text);
            }
            catch 
            { }
            montoTotal += gastosExtra;
            lblMontoTotalValor.Text = montoTotal.ToString();
        }

        private void limpiarTodo()
        {
            this.idCompra = GenericBL<Compra>.getNextId();
            dataGrilla = new DataTable();
            dataGrilla.Columns.Add("Artículo");
            dataGrilla.Columns.Add("Precio unitario");
            dataGrilla.Columns.Add("Cantidad");
            dataGrilla.Columns.Add("IVA");
            dataGrilla.Columns.Add("Importe");
            grdDetalleCompra.DataSource = dataGrilla;
            detalles = new LinkedList<DetalleCompra>();
            this.estado = Estado.NUEVO;
            txtComentarios.Text = "";
            txtPrecioArticulo.Text = "";
            txtNroFactura.Text = "";
            lblMontoTotalValor.Text = "0";
            txtGastosExtra.Text = "";
            txtPrecioUnitario.Text = "";
            dtpFecha.Value = DateTime.Today;
            btnNuevoArticulo.Enabled = false;
            btnEliminarArticulo.Enabled = false;
        }

        private void grdDetalleCompra_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (grdDetalleCompra.RowCount == 0) return;
            int index = grdDetalleCompra.SelectedRows[0].Index;
            this.indexSelected = index;
            DetalleCompra d = detalles.ElementAt(index);
            cmbArticulos.SelectedValue = d.idArticulo;
            cmbIva.SelectedValue = d.iva;
            txtPrecioUnitario.Text = d.precioUnitario.ToString();
            numericCantidad.Value = d.cantidad;
            txtPrecioArticulo.Text = d.importe.ToString();
            btnNuevoArticulo.Enabled = true;
            btnEliminarArticulo.Enabled = true;
            this.estado = Estado.MODIFICAR;
        }

        private void btnNuevoArticulo_Click(object sender, EventArgs e)
        {
            numericCantidad.Value = 0;
            txtPrecioArticulo.Text = "";
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
            if (txtComentarios.Text == "" || txtComentarios.Text == " ")
            {
                c.descripcion = "<sin comentarios>";
            }
            else
            {
                c.descripcion = txtComentarios.Text;
            }
            c.importe = float.Parse(lblMontoTotalValor.Text);
            c.fecha = dtpFecha.Value;
            GenericBL<Compra>.insert(c);

            foreach (DetalleCompra d in detalles)
            {
                d.id = GenericBL<DetalleCompra>.getNextId();
                GenericBL<DetalleCompra>.insert(d);
                Dictionary<string, object> filtroStock = new Dictionary<string, object>();
                filtroStock.Add("id_articulo", d.idArticulo);
                filtroStock.Add("id_deposito", Int32.Parse(cmbDepositos.SelectedValue.ToString()));
                List<StockArticulo> stocks = GenericBL<StockArticulo>.listTodos(filtroStock);
                if(stocks.Count > 0)
                {
                    foreach(StockArticulo sa in stocks)
                    {
                        sa.cantidad += d.cantidad;
                        GenericBL<StockArticulo>.update(sa);
                    }
                }
                else
                {
                    StockArticulo sa = new StockArticulo();
                    sa.id = GenericBL<StockArticulo>.getNextId();
                    sa.idDeposito = Int32.Parse(cmbDepositos.SelectedValue.ToString());
                    sa.idArticulo = d.idArticulo;
                    sa.cantidad = d.cantidad;
                    GenericBL<StockArticulo>.insert(sa);
                }           
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

        private void txtPrecioUnitario_KeyUp(object sender, KeyEventArgs e)
        {
            actualizarImporte(null, null);
        }

        private void txtGastosExtra_Leave(object sender, EventArgs e)
        {
            actualizarGrilla();
        }
    }
}
