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
    public partial class FormArticulos : FormStart
    {
        private int idArticulo;

        public FormArticulos() : base()
        {
            InitializeComponent();
            grdArticulos.DataSource = GenericBL<Articulo>.listActivos();
            this.estado = Estado.NUEVO;
            idArticulo = GenericBL<Articulo>.getNextId();
        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            if (checkErrorObligatorios()) return;
            Articulo a = new Articulo();
            a.id = idArticulo;
            a.codigo = txtCodigo.Text;
            a.descripcion = txtDescripcion.Text;
            a.esFormulario = (chkFormulario.Checked) ? 1 : 0;
            
            if (this.estado == Estado.NUEVO)
            {
                GenericBL<Articulo>.insert(a);
                PrecioArticulo p = new PrecioArticulo();
                p.id = GenericBL<PrecioArticulo>.getNextId();
                p.codArticulo = a.codigo;
                GenericBL<PrecioArticulo>.insert(p);
                MessageBox.Show("¡El artículo se agregó correctamente!", "Artículo agregado", MessageBoxButtons.OK,
                 MessageBoxIcon.Information);
            }
            else
            {
                GenericBL<Articulo>.update(a);
                MessageBox.Show("¡El artículo se modificó correctamente!", "Artículo modificado", MessageBoxButtons.OK,
                 MessageBoxIcon.Information);
            }
            grdArticulos.DataSource = GenericBL<Articulo>.listActivos();
            limpiarCampos();
        }

        private Boolean checkErrorObligatorios()
        {
            string error = "Ocurrió un error en los datos ingresados:\n\n";
            Boolean errorFlag = false;
            if (txtDescripcion.Text == "")
            {
                errorFlag = true;
                error += "La descripción es obligatoria.\n";
            }
            if (txtCodigo.Text == "")
            {
                errorFlag = true;
                error += "El código es obligatorio.\n";
            }
            else if(this.estado == Estado.NUEVO)
            {
                Dictionary<string, object> d = new Dictionary<string, object>();
                d.Add("codigo", txtCodigo.Text);
                List<Articulo> list = GenericBL<Articulo>.listActivos(d);
                if (list.Count > 0)
                {
                    errorFlag = true;
                    error += "Ya existe un artículo con ese código.";
                }
            }
            if (errorFlag)
            {
                MessageBox.Show(error, "Hubo un error en los datos ingresados", MessageBoxButtons.OK,
            MessageBoxIcon.Warning);
            }
            return errorFlag;
        }

        private void limpiarCampos()
        {
            txtDescripcion.Text = "";
            txtCodigo.Text = "";
            txtCodigo.ReadOnly = false;
            chkFormulario.Checked = false;
            this.estado = Estado.NUEVO;
            btnNuevo.Enabled = false;
            btnEliminar.Enabled = false;
            idArticulo = GenericBL<Articulo>.getNextId();
        }

        private void chkFormulario_CheckedChanged(object sender, EventArgs e)
        {
            
        }



        private void grdArticulos_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            idArticulo = Int32.Parse(grdArticulos.SelectedRows[0].Cells["id"].Value.ToString());
            txtCodigo.Text = grdArticulos.SelectedRows[0].Cells["codigoArticulo"].Value.ToString();
            txtDescripcion.Text = grdArticulos.SelectedRows[0].Cells["descripcion"].Value.ToString();
            chkFormulario.Checked = (grdArticulos.SelectedRows[0].Cells["esFormulario"].Value.ToString() == "1");
            this.estado = Estado.MODIFICAR;
            txtCodigo.ReadOnly = true;
            btnNuevo.Enabled = true;
            btnEliminar.Enabled = true;

        }

        private void btnNuevo_Click_1(object sender, EventArgs e)
        {
            limpiarCampos();
        }

        private void btnEliminar_Click_1(object sender, EventArgs e)
        {
            if (MessageBox.Show("¿Está seguro que desea eliminar el artículo?", "Confirmación",
               MessageBoxButtons.YesNo, MessageBoxIcon.Question,
               MessageBoxDefaultButton.Button1) != System.Windows.Forms.DialogResult.Yes) return;
            Articulo a = new Articulo();
            a.id = idArticulo;
            a.codigo = txtCodigo.Text;
            a.descripcion = txtDescripcion.Text;
            a.esFormulario = (chkFormulario.Checked) ? 1 : 0;
            a.campoBaja = 1;
            GenericBL<Articulo>.update(a);
            Dictionary<string, object> d = new Dictionary<string, object>();
            d.Add("cod_articulo", a.codigo);
            List<PrecioArticulo> precios = GenericBL<PrecioArticulo>.listTodos(d);
            GenericBL<PrecioArticulo>.delete(precios.ElementAt(0));
            grdArticulos.DataSource = GenericBL<Articulo>.listActivos();
            limpiarCampos();
            MessageBox.Show("El artículo fue eliminado correctamente", "Artículo eliminado", MessageBoxButtons.OK,
                 MessageBoxIcon.Information);
        }
        
        private void FormArticulos_FormClosing(object sender, FormClosingEventArgs e)
        {
            System.Windows.Forms.Application.Exit();
        }

        private void btnBuscar_Click(object sender, EventArgs e)
        {
            if (txtBuscar.Text == "")
            {
                MessageBox.Show("Por favor ingrese algo en el campo de búsqueda", "Atención", MessageBoxButtons.OK,
                 MessageBoxIcon.Warning);
                return;
            }
            Dictionary<string, object> filtro = new Dictionary<string, object>();
            filtro.Add("descripcion", txtBuscar.Text);
            grdArticulos.DataSource = GenericBL<Articulo>.listActivos(filtro);
        }

        private void btnLimpiarFiltro_Click(object sender, EventArgs e)
        {
            grdArticulos.DataSource = GenericBL<Articulo>.listActivos();
            txtBuscar.Text = "";
        }

        private void txtCodigo_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.KeyChar = Char.ToUpper(e.KeyChar);
        }


    }
}
