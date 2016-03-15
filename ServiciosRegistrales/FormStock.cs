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
    public partial class FormStock : FormStart
    {
        private List<Articulo> articulos;
        private List<Articulo> formularios;
        private List<Deposito> depositos;
        private List<StockArticulo> stockArticulos;
        private List<StockFormulario> stockFormularios;
        private Estado estadoArticulos;
        private Estado estadoFormularios;
        private int idStockArticulo;
        private int idStockFormulario;

        public FormStock() : base()
        {
            InitializeComponent();
            //Cargar los combos de articulos
            Dictionary<string, object> filtroTipo = new Dictionary<string, object>();
            filtroTipo.Add("es_formulario", 0);
            articulos = GenericBL<Articulo>.listActivos(filtroTipo);
            cmbCodigoArticulos.DataSource = articulos;
            filtroTipo["es_formulario"] = 1;
            formularios = GenericBL<Articulo>.listActivos(filtroTipo);
            cmbCodigoFormularios.DataSource = formularios;
            //Cargar los combos de depositos
            depositos = GenericBL<Deposito>.listActivos();
            cmbDepositosArticulos.DataSource = GenericBL<Deposito>.listActivos();
            cmbDepositosFormularios.DataSource = GenericBL<Deposito>.listActivos();
            cmbMoverDepositosArticulos.DataSource = GenericBL<Deposito>.listActivos();
            cmbMoverDepositosFormularios.DataSource = GenericBL<Deposito>.listActivos();
            this.idStockArticulo = GenericBL<StockArticulo>.getNextId();
            this.idStockFormulario = GenericBL<StockFormulario>.getNextId();
            this.estadoArticulos = Estado.NUEVO;
            this.estadoFormularios = Estado.NUEVO;
            refreshArticulos();
            refreshFormularios();
        }

        //------------------------------------ARTICULOS-----------------------------------

        private void refreshArticulos()
        {
            stockArticulos = GenericBL<StockArticulo>.listTodos();
            DataTable dt = new DataTable();
            dt.Columns.Add("id");
            dt.Columns.Add("idArticulo");
            dt.Columns.Add("Código");
            dt.Columns.Add("idDeposito");
            dt.Columns.Add("En depósito");
            dt.Columns.Add("Cantidad");
            DataRow dr;
            foreach (StockArticulo sa in stockArticulos)
            {
                dr = dt.NewRow();
                dr["id"] = sa.id;
                dr["idArticulo"] = sa.idArticulo;
                foreach (Articulo a in articulos)
                {
                    if (sa.idArticulo == a.id) dr["Código"] = a.codigo;
                }
                dr["idDeposito"] = sa.idDeposito;
                foreach (Deposito d in depositos)
                {
                    if (sa.idDeposito == d.id) dr["En depósito"] = d.descripcion;
                }
                dr["Cantidad"] = sa.cantidad;
                dt.Rows.Add(dr);
            }
            grdArticulos.DataSource = dt;
            grdArticulos.Columns["id"].Visible = false;
            grdArticulos.Columns["idArticulo"].Visible = false;
            grdArticulos.Columns["idDeposito"].Visible = false;
        }

        private Boolean checkErrorArticulos()
        {
            Boolean errorFlag = false;
            string error = "Hubo un error en los datos ingresados.\n";
            try
            {
                int a = Int32.Parse(numericArticulos.Value.ToString());
            }
            catch
            {
                errorFlag = true;
                error += "La cantidad no es un valor entero.\n";
            }
            foreach (StockArticulo sa in stockArticulos)
            {
                if(this.estadoArticulos == Estado.NUEVO && sa.idArticulo == Int32.Parse(cmbCodigoArticulos.SelectedValue.ToString()) && sa.idDeposito == Int32.Parse(cmbDepositosArticulos.SelectedValue.ToString()))
                {
                    errorFlag = true;
                    error += "Ya existe el registro de stock de ese artículo en ese depósito. Seleccionelo de la grilla por favor.\n";
                }
            }
            if(this.estadoArticulos == Estado.MODIFICAR)
            {
                if (numericMoverArticulos.Value <= 0)
                {
                    errorFlag = true;
                    error += "Seleccione al menos una unidad para trasladar.";
                }
                if(numericArticulos.Value < numericMoverArticulos.Value)
                {
                    errorFlag = true;
                    error += "No posee tantas unidades para trasladar.";
                }
                if (Int32.Parse(cmbDepositosArticulos.SelectedValue.ToString()) == Int32.Parse(cmbMoverDepositosArticulos.SelectedValue.ToString()))
                {
                    errorFlag = true;
                    error += "El depósito origen y el destino son iguales.";
                }
            }
            
            if (errorFlag)
            {
                MessageBox.Show(error, "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            return errorFlag;
        }

        private void limpiarCamposArticulos()
        {
            cmbCodigoArticulos.SelectedIndex = 0;
            cmbCodigoArticulos.Enabled = true;
            numericArticulos.Value = 0;
            numericArticulos.Enabled = true;
            cmbDepositosArticulos.SelectedIndex = 0;
            cmbDepositosArticulos.Enabled = true;
            cmbMoverDepositosArticulos.SelectedIndex = 0;
            cmbMoverDepositosArticulos.Enabled = false;
            numericMoverArticulos.Value = 0;
            numericMoverArticulos.Enabled = false;
            btnQuitarArticulos.Enabled = false;
            btnAgregarArticulo.Enabled = false;
            this.idStockArticulo = GenericBL<StockArticulo>.getNextId();
            this.estadoArticulos = Estado.NUEVO;
        }

        private void btnConfirmarMovArticulos_Click(object sender, EventArgs e)
        {
            if (checkErrorArticulos()) return;
            StockArticulo sa = new StockArticulo();
            sa.id = this.idStockArticulo;
            sa.idArticulo = Int32.Parse(cmbCodigoArticulos.SelectedValue.ToString());
            sa.idDeposito = Int32.Parse(cmbDepositosArticulos.SelectedValue.ToString());
            sa.cantidad = Int32.Parse(numericArticulos.Value.ToString());
            if (this.estadoArticulos == Estado.NUEVO)
            {
                GenericBL<StockArticulo>.insert(sa);
                this.idStockArticulo = GenericBL<StockArticulo>.getNextId();
            }
            else
            {
                sa.cantidad -= Int32.Parse(numericMoverArticulos.Value.ToString());
                GenericBL<StockArticulo>.update(sa);
                Boolean modificado = false;
                foreach (StockArticulo sart in stockArticulos)
                {
                    if (sart.idArticulo == Int32.Parse(cmbCodigoArticulos.SelectedValue.ToString()) && sart.idDeposito == Int32.Parse(cmbMoverDepositosArticulos.SelectedValue.ToString()))
                    {
                        sart.cantidad += Int32.Parse(numericMoverArticulos.Value.ToString());
                        GenericBL<StockArticulo>.update(sart);
                        modificado = true;
                    }
                }
                if (!modificado)
                {
                    StockArticulo sart = new StockArticulo();
                    sart.id = GenericBL<StockArticulo>.getNextId();
                    sart.idArticulo = Int32.Parse(cmbCodigoArticulos.SelectedValue.ToString());
                    sart.idDeposito = Int32.Parse(cmbMoverDepositosArticulos.SelectedValue.ToString());
                    sart.cantidad = Int32.Parse(numericMoverArticulos.Value.ToString());
                    GenericBL<StockArticulo>.insert(sart);
                }
            }
            refreshArticulos();
            limpiarCamposArticulos();
        }

        private void grdArticulos_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            this.idStockArticulo = Int32.Parse(grdArticulos.SelectedRows[0].Cells["id"].Value.ToString());
            cmbCodigoArticulos.SelectedIndex = cmbCodigoArticulos.FindStringExact(grdArticulos.SelectedRows[0].Cells["Código"].Value.ToString());
            cmbDepositosArticulos.SelectedIndex = cmbDepositosArticulos.FindStringExact(grdArticulos.SelectedRows[0].Cells["En depósito"].Value.ToString());
            numericArticulos.Value = Int32.Parse(grdArticulos.SelectedRows[0].Cells["cantidad"].Value.ToString());
            cmbMoverDepositosArticulos.Enabled = true;
            numericMoverArticulos.Enabled = true;
            btnQuitarArticulos.Enabled = true;
            btnAgregarArticulo.Enabled = true;
            cmbCodigoArticulos.Enabled = false;
            cmbDepositosArticulos.Enabled = false;
            numericArticulos.Enabled = false;
            this.estadoArticulos = Estado.MODIFICAR;
        }

        private void btnAgregarArticulo_Click(object sender, EventArgs e)
        {
            limpiarCamposArticulos();
        }

        private void btnQuitarArticulos_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("¿Está seguro que desea eliminar el stock de ese artículo en ese depósito?", "Confirmación",
    MessageBoxButtons.YesNo, MessageBoxIcon.Question,
    MessageBoxDefaultButton.Button1) != System.Windows.Forms.DialogResult.Yes) return;
            StockArticulo sa = new StockArticulo();
            sa.id = this.idStockArticulo;
            GenericBL<StockArticulo>.delete(sa);
            refreshArticulos();
            limpiarCamposArticulos();
        }

        //------------------------------------FORMULARIOS-----------------------------------

        private void refreshFormularios()
        {
            stockFormularios = GenericBL<StockFormulario>.listTodos();
            DataTable dt = new DataTable();
            dt.Columns.Add("id");
            dt.Columns.Add("idFormulario");
            dt.Columns.Add("Formulario");
            dt.Columns.Add("idDeposito");
            dt.Columns.Add("En depósito");
            dt.Columns.Add("Cantidad");
            dt.Columns.Add("Desde");
            dt.Columns.Add("Hasta");
            DataRow dr;
            foreach (StockFormulario sf in stockFormularios)
            {
                dr = dt.NewRow();
                dr["id"] = sf.id;
                dr["idFormulario"] = sf.idArticulo;
                foreach (Articulo a in formularios) if (sf.idArticulo == a.id) dr["Formulario"] = a.codigo;
                dr["idDeposito"] = sf.idDeposito;
                foreach (Deposito d in depositos) if (sf.idDeposito == d.id) dr["En depósito"] = d.descripcion;
                dr["Cantidad"] = sf.cantidad;
                dr["Desde"] = sf.proxCodigo;
                dr["Hasta"] = sf.proxCodigo + sf.cantidad -1;
                dt.Rows.Add(dr);
            }
            grdFormularios.DataSource = dt;
            grdFormularios.Columns["id"].Visible = false;
            grdFormularios.Columns["idFormulario"].Visible = false;
            grdFormularios.Columns["idDeposito"].Visible = false;
        }

        private Boolean checkErrorFormularios()
        {
            Boolean errorFlag = false;
            string error = "Hubo un error en los datos ingresados.\n";
            try
            {
                int a = Int32.Parse(numericFormularios.Value.ToString());
                long b = long.Parse(txtDesde.Text);
            }
            catch
            {
                errorFlag = true;
                error += "La cantidad o el número desde no es un valor entero.\n";
            }
            if (this.estadoFormularios == Estado.MODIFICAR)
            {
                if (numericMoverFormulario.Value <= 0)
                {
                    errorFlag = true;
                    error += "Seleccione al menos una unidad para trasladar.\n";
                }
                if (numericFormularios.Value < numericMoverFormulario.Value)
                {
                    errorFlag = true;
                    error += "No posee tantas unidades para trasladar.\n";
                }
                if (Int32.Parse(cmbDepositosFormularios.SelectedValue.ToString()) == Int32.Parse(cmbMoverDepositosFormularios.SelectedValue.ToString()))
                {
                    errorFlag = true;
                    error += "El depósito origen y el destino son iguales.\n";
                }
                if(long.Parse(txtDesdeMover.Text) < long.Parse(txtDesde.Text) || long.Parse(txtHasta.Text) < long.Parse(txtHastaMover.Text))
                {
                    errorFlag = true;
                    error += "Los números para mover no están en el rango especificado.";
                }
            }

            if (errorFlag)
            {
                MessageBox.Show(error, "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            return errorFlag;
        }

        private void txtDesde_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = !char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar);
        }

        private void txtDesde_Leave(object sender, EventArgs e)
        {
            actualizarHasta();
        }

        private void numericFormularios_ValueChanged(object sender, EventArgs e)
        {
            actualizarHasta();
        }

        private void txtDesde_KeyUp(object sender, KeyEventArgs e)
        {
            actualizarHasta();
        }

        private void actualizarHasta()
        {
            long desde = 0;
            try
            {
                desde = long.Parse(txtDesde.Text);
            }
            catch
            {
                txtHasta.Text = "";
                return;
            }
            txtHasta.Text = desde + numericFormularios.Value - 1 + "";
        }

        private void numericMoverFormulario_ValueChanged(object sender, EventArgs e)
        {
            actualizarHastaMover();
        }

        private void txtDesdeMover_KeyPress(object sender, KeyPressEventArgs e)
        {
            actualizarHastaMover();
        }

        private void txtDesdeMover_KeyUp(object sender, KeyEventArgs e)
        {
            actualizarHastaMover();
        }

        private void txtDesdeMover_Leave(object sender, EventArgs e)
        {
            actualizarHastaMover();
        }

        private void actualizarHastaMover()
        {
            long desde = 0;
            try
            {
                desde = long.Parse(txtDesdeMover.Text);
            }
            catch
            {
                txtHastaMover.Text = "";
                return;
            }
            txtHastaMover.Text = desde + numericMoverFormulario.Value - 1 + "";
        }

        private void limpiarCamposFormularios()
        {
            cmbCodigoFormularios.SelectedIndex = 0;
            cmbCodigoFormularios.Enabled = true;
            numericFormularios.Value = 0;
            numericFormularios.Enabled = true;
            cmbDepositosFormularios.SelectedIndex = 0;
            cmbDepositosFormularios.Enabled = true;
            txtDesde.Text = "";
            txtDesde.ReadOnly = false;
            txtHasta.Text = "";
            cmbMoverDepositosFormularios.SelectedIndex = 0;
            cmbMoverDepositosFormularios.Enabled = false;
            numericMoverFormulario.Value = 0;
            numericMoverFormulario.Enabled = false;
            txtDesdeMover.Text = "";
            txtDesdeMover.ReadOnly = true;
            txtHastaMover.Text = "";
            btnQuitarFormulario.Enabled = false;
            btnAgregarFormulario.Enabled = false;
            this.estadoFormularios = Estado.NUEVO;
        }

        private void btnConfirmarFormulario_Click(object sender, EventArgs e)
        {
            if (checkErrorFormularios()) return;
            StockFormulario sf = new StockFormulario();
            sf.id = this.idStockFormulario;
            sf.idArticulo = Int32.Parse(cmbCodigoFormularios.SelectedValue.ToString());
            sf.idDeposito = Int32.Parse(cmbDepositosFormularios.SelectedValue.ToString());
            sf.cantidad = Int32.Parse(numericFormularios.Value.ToString());
            sf.proxCodigo = long.Parse(txtDesde.Text);
            if (this.estadoFormularios == Estado.NUEVO)
            {
                GenericBL<StockFormulario>.insert(sf);
                this.idStockFormulario = GenericBL<StockFormulario>.getNextId();
            }
            else
            {
                if(long.Parse(txtDesdeMover.Text) == long.Parse(txtDesde.Text))
                {
                    sf.cantidad -= (Int32.Parse(numericMoverFormulario.Value.ToString()));
                    sf.proxCodigo = long.Parse(txtHastaMover.Text) + 1;
                    GenericBL<StockFormulario>.update(sf);
                    StockFormulario sform = new StockFormulario();
                    sform.id = GenericBL<StockFormulario>.getNextId();
                    sform.idArticulo = sf.idArticulo;
                    sform.idDeposito = Int32.Parse(cmbMoverDepositosFormularios.SelectedValue.ToString());
                    sform.cantidad = Int32.Parse(numericMoverFormulario.Value.ToString());
                    sform.proxCodigo = long.Parse(txtDesdeMover.Text);
                    GenericBL<StockFormulario>.insert(sform);
                } 
                else if(long.Parse(txtHastaMover.Text) == long.Parse(txtHasta.Text))
                {
                    sf.cantidad -= Int32.Parse(numericMoverFormulario.Value.ToString());
                    GenericBL<StockFormulario>.update(sf);
                    StockFormulario sform = new StockFormulario();
                    sform.id = GenericBL<StockFormulario>.getNextId();
                    sform.idArticulo = sf.idArticulo;
                    sform.idDeposito = Int32.Parse(cmbMoverDepositosFormularios.SelectedValue.ToString());
                    sform.cantidad = Int32.Parse(numericMoverFormulario.Value.ToString());
                    sform.proxCodigo = long.Parse(txtDesdeMover.Text);
                    GenericBL<StockFormulario>.insert(sform);

                }
                else
                {
                    sf.cantidad = (int)(long.Parse(txtDesdeMover.Text) - long.Parse(txtDesde.Text));
                    GenericBL<StockFormulario>.update(sf);
                    StockFormulario sform = new StockFormulario();
                    sform.id = GenericBL<StockFormulario>.getNextId();
                    sform.idArticulo = sf.idArticulo;
                    sform.idDeposito = Int32.Parse(cmbMoverDepositosFormularios.SelectedValue.ToString());
                    sform.cantidad = Int32.Parse(numericMoverFormulario.Value.ToString());
                    sform.proxCodigo = long.Parse(txtDesdeMover.Text);
                    GenericBL<StockFormulario>.insert(sform);
                    sf.proxCodigo = long.Parse(txtHastaMover.Text) + 1;
                    sf.id = GenericBL<StockFormulario>.getNextId();
                    sf.cantidad = (int)(long.Parse(txtHasta.Text) - long.Parse(txtHastaMover.Text));
                    GenericBL<StockFormulario>.insert(sf);
                }
            }
            refreshFormularios();
            limpiarCamposFormularios();
            
        }

        private void numericUpDown1_ValueChanged(object sender, EventArgs e)
        {

        }

        private void gpStockFormularios_Enter(object sender, EventArgs e)
        {

        }

        private void FormStock_FormClosing(object sender, FormClosingEventArgs e)
        {
            Application.Exit();
        }

        private void btnAgregarFormulario_Click(object sender, EventArgs e)
        {
            limpiarCamposFormularios();
        }

        private void grdFormularios_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            this.idStockFormulario = Int32.Parse(grdFormularios.SelectedRows[0].Cells["id"].Value.ToString());
            cmbCodigoFormularios.SelectedIndex = cmbCodigoFormularios.FindStringExact(grdFormularios.SelectedRows[0].Cells["Formulario"].Value.ToString());
            cmbDepositosFormularios.SelectedIndex = cmbDepositosFormularios.FindStringExact(grdFormularios.SelectedRows[0].Cells["En depósito"].Value.ToString());
            numericFormularios.Value = Int32.Parse(grdFormularios.SelectedRows[0].Cells["Cantidad"].Value.ToString());
            txtDesde.Text = grdFormularios.SelectedRows[0].Cells["Desde"].Value.ToString();
            txtHasta.Text = grdFormularios.SelectedRows[0].Cells["Hasta"].Value.ToString();
            cmbMoverDepositosFormularios.Enabled = true;
            numericMoverFormulario.Enabled = true;
            btnQuitarFormulario.Enabled = true;
            btnAgregarFormulario.Enabled = true;
            txtDesdeMover.ReadOnly = false;
            cmbCodigoFormularios.Enabled = false;
            cmbDepositosFormularios.Enabled = false;
            numericFormularios.Enabled = false;
            txtDesde.ReadOnly = true;
            this.estadoFormularios = Estado.MODIFICAR;
        }

        private void btnQuitarFormulario_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("¿Está seguro que desea eliminar el stock de ese formulario en ese depósito?", "Confirmación",
    MessageBoxButtons.YesNo, MessageBoxIcon.Question,
    MessageBoxDefaultButton.Button1) != System.Windows.Forms.DialogResult.Yes) return;
            StockFormulario sf = new StockFormulario();
            sf.id = this.idStockFormulario;
            GenericBL<StockFormulario>.delete(sf);
            refreshFormularios();
            limpiarCamposFormularios();
        }
  
    }
}
