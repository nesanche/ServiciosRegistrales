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
    public partial class FormProveedores : FormStart
    {
        private int idProveedor; 

        public FormProveedores() : base()
        {
            InitializeComponent();

            grdProveedores.DataSource = GenericBL<Proveedor>.listActivos();
            this.idProveedor = GenericBL<Proveedor>.getNextId();
            DataTable dt = new DataTable();
            dt.Columns.Add("Categoria");
            DataRow dr = dt.NewRow();
            dr["Categoria"] = "Formularios";
            dt.Rows.Add(dr);
            dr = dt.NewRow();
            dr["Categoria"] = "Otros";
            dt.Rows.Add(dr);
            cmbTipo.DataSource = dt;
            cmbTipo.SelectedIndex = 0;
        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            if (checkErrorObligatorios()) return;
            Proveedor p = new Proveedor();
            p.cuit = txtCuit.Text;
            p.domicilio = txtDomicilio.Text;
            p.mail = txtMail.Text;
            p.razonSocial = txtRazonSocial.Text;
            p.telefono = txtTelefono.Text;
            p.url = txtUrl.Text;
            p.id = idProveedor;
            p.contacto = txtContacto.Text;
            p.tipoProveedor = cmbTipo.SelectedValue.ToString();
            p.comentarios = (txtComentarios.Text == "") ? "<sin comentarios>" : txtComentarios.Text;
            if (this.estado == Estado.NUEVO)
            {
                GenericBL<Proveedor>.insert(p);
                MessageBox.Show("¡El nuevo proveedor se agregó correctamente!", "Proveedor agregado", MessageBoxButtons.OK,
                 MessageBoxIcon.Information);
            }
            else
            {
                GenericBL<Proveedor>.update(p);
                MessageBox.Show("¡El proveedor se modificó correctamente!", "Proveedor modificado", MessageBoxButtons.OK,
                 MessageBoxIcon.Information);
            }
            grdProveedores.DataSource = GenericBL<Proveedor>.listActivos();
            limpiarCampos();

        }

        private Boolean checkErrorObligatorios()
        {
            string error = "Ocurrió un error en los datos ingresados:\n\n";
            Boolean errorFlag = false;
            if (txtRazonSocial.Text == "")
            {
                errorFlag = true;
                error += "La razón social es obligatoria.\n";
            }
            if (txtDomicilio.Text == "")
            {
                errorFlag = true;
                error += "El domicilio es obligatorio.\n";
            }
            if (txtContacto.Text == "")
            {
                errorFlag = true;
                error += "El dato de contacto es obligatorio.\n";
            }
            if (txtUrl.Text == "")
            {
                errorFlag = true;
                error += "La URL es obligatoria.\n";
            }
            if (txtMail.Text == "")
            {
                errorFlag = true;
                error += "El email es obligatorio.\n";
            }
            if (txtCuit.Text == "")
            {
                errorFlag = true;
                error += "El CUIT es obligatorio.\n";
            }
            if (txtTelefono.Text == "")
            {
                errorFlag = true;
                error += "El teléfono es obligatorio.\n";
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
            txtCuit.Text = "";
            txtDomicilio.Text = "";
            txtMail.Text = "";
            txtRazonSocial.Text = "";
            txtTelefono.Text = "";
            txtUrl.Text = "";
            txtContacto.Text = "";
            txtComentarios.Text = "";
            this.estado = Estado.NUEVO;
            btnNuevo.Enabled = false;
            btnEliminar.Enabled = false;
            this.idProveedor = GenericBL<Proveedor>.getNextId(); 
        }

        private void txtTelefono_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = !char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar);
        }

        private void grdProveedores_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            this.idProveedor = Int32.Parse(grdProveedores.SelectedRows[0].Cells["id"].Value.ToString());
            txtRazonSocial.Text = grdProveedores.SelectedRows[0].Cells["razonSocial"].Value.ToString();
            txtDomicilio.Text = grdProveedores.SelectedRows[0].Cells["domicilio"].Value.ToString();
            txtTelefono.Text = grdProveedores.SelectedRows[0].Cells["telefono"].Value.ToString();
            txtMail.Text = grdProveedores.SelectedRows[0].Cells["mail"].Value.ToString();
            txtUrl.Text = grdProveedores.SelectedRows[0].Cells["url"].Value.ToString();
            txtCuit.Text = grdProveedores.SelectedRows[0].Cells["cuit"].Value.ToString();
            txtContacto.Text = grdProveedores.SelectedRows[0].Cells["contacto"].Value.ToString();
            txtComentarios.Text = grdProveedores.SelectedRows[0].Cells["comentarios"].Value.ToString();
            cmbTipo.SelectedValue = grdProveedores.SelectedRows[0].Cells["tipoProveedor"].Value.ToString();
            this.estado = Estado.MODIFICAR;
            btnNuevo.Enabled = true;
            btnEliminar.Enabled = true;
        }


        private void btnEliminar_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("¿Está seguro que desea eliminar el proveedor?", "Confirmación",
    MessageBoxButtons.YesNo, MessageBoxIcon.Question,
    MessageBoxDefaultButton.Button1) != System.Windows.Forms.DialogResult.Yes) return;
            Proveedor p = new Proveedor();
            p.cuit = txtCuit.Text;
            p.domicilio = txtDomicilio.Text;
            p.mail = txtMail.Text;
            p.razonSocial = txtRazonSocial.Text;
            p.telefono = txtTelefono.Text;
            p.url = txtUrl.Text;
            p.id = idProveedor;
            p.contacto = txtContacto.Text;
            p.tipoProveedor = cmbTipo.SelectedValue.ToString();
            p.campoBaja = 1;
            GenericBL<Proveedor>.update(p);
            grdProveedores.DataSource = GenericBL<Proveedor>.listActivos();
            limpiarCampos();
            MessageBox.Show("El proveedor se eliminó correctamente", "Proveedor eliminado", MessageBoxButtons.OK,
                 MessageBoxIcon.Information);
        }

        private void btnNuevo_Click_1(object sender, EventArgs e)
        {
            limpiarCampos();
        }

        private void FormProveedores_FormClosing(object sender, FormClosingEventArgs e)
        {
            Application.Exit();
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
            filtro.Add("razon_social", txtBuscar.Text);
            grdProveedores.DataSource = GenericBL<Proveedor>.listActivos(filtro);
        }

        private void btnLimpiarFiltro_Click(object sender, EventArgs e)
        {
            grdProveedores.DataSource = GenericBL<Proveedor>.listActivos();
            txtBuscar.Text = "";
        }

        

        
    }
}
