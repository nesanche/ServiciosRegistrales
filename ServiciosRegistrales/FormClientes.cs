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
using System.Text.RegularExpressions;
namespace ServiciosRegistrales
{
    public partial class FormClientes : FormStart
    {

        public FormClientes() : base()
        {
            InitializeComponent();
            grdClientes.DataSource = GenericBL<Cliente>.listActivos();
            this.estado = Estado.NUEVO;
            txtId.Text = GenericBL<Cliente>.getNextId().ToString();
        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            if (checkErrorObligatorios()) return;
            Cliente c = new Cliente();
            c.id = Int32.Parse(txtId.Text);
            c.documento = long.Parse(txtDocumento.Text);
            c.apellido = txtApellido.Text;
            c.nombre = txtNombre.Text;
            c.mail = txtMail.Text;
            c.telefono = txtTelefono.Text;
            c.domicilio = txtDomicilio.Text;
            c.fechaNacimiento = dtpFechaNacimiento.Value;
            if (this.estado == Estado.NUEVO)
            {
                GenericBL<Cliente>.insert(c);
                MessageBox.Show("¡El nuevo cliente se agregó correctamente!", "Cliente agregado", MessageBoxButtons.OK,
                 MessageBoxIcon.Information);
            }
            else
            {
               GenericBL<Cliente>.update(c);
               MessageBox.Show("¡El cliente se modificó correctamente!", "Cliente modificado", MessageBoxButtons.OK,
                MessageBoxIcon.Information);
            }
            grdClientes.DataSource = GenericBL<Cliente>.listActivos();
            limpiarCampos();
        }

        private Boolean checkErrorObligatorios()
        {
            string error = "Ocurrió un error en los datos ingresados:\n\n";
            Boolean errorFlag = false;
            if (txtDocumento.Text == "")
            {
                errorFlag = true;
                error += "El documento es obligatorio.\n";
            }
            if (txtApellido.Text == "")
            {
                errorFlag = true;
                error += "El apellido es obligatorio.\n";
            }
            if (txtNombre.Text == "")
            {
                errorFlag = true;
                error += "El nombre es obligatorio.\n";
            }
            Regex emailRegex = new Regex(@"^([\w\.\-]+)@([\w\-]+)((\.(\w){2,3})+)$");
            if (txtMail.Text == "")
            {
                errorFlag = true;
                error += "El mail es obligatorio.\n";
            } else if (!emailRegex.IsMatch(txtMail.Text)) {
                errorFlag = true;
                error += "El mail está en formato incorrecto.\n";
            }           
            if (txtTelefono.Text == "")
            {
                errorFlag = true;
                error += "El teléfono es obligatorio.\n";
            }
            if (txtDomicilio.Text == "")
            {
                errorFlag = true;
                error += "El domicilio es obligatorio.\n";
            }
            if (errorFlag)
            {
                MessageBox.Show(error,"Hubo un error en los datos ingresados", MessageBoxButtons.OK,
            MessageBoxIcon.Warning);
            }
            return errorFlag;
        }

        private void limpiarCampos()
        {
            txtId.Text = GenericBL<Cliente>.getNextId().ToString();
            txtDocumento.Text = "";
            txtApellido.Text = "";
            txtNombre.Text = "";
            txtMail.Text = "";
            txtDomicilio.Text = "";
            txtTelefono.Text = "";
            dtpFechaNacimiento.Value = DateTime.Today;
            this.estado = Estado.NUEVO;
            btnNuevo.Enabled = false;
            btnEliminar.Enabled = false;
        }


        private void txtDocumento_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = !char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar);
        }

        private void txtTelefono_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = !char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar);
        }

        private void grdClientes_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            txtId.Text = grdClientes.SelectedRows[0].Cells["id"].Value.ToString();
            txtDocumento.Text = grdClientes.SelectedRows[0].Cells["documento"].Value.ToString();
            txtApellido.Text = grdClientes.SelectedRows[0].Cells["apellido"].Value.ToString();
            txtNombre.Text = grdClientes.SelectedRows[0].Cells["nombre"].Value.ToString();
            dtpFechaNacimiento.Value = DateTime.Parse(grdClientes.SelectedRows[0].Cells["fechaNacimiento"].Value.ToString());
            txtMail.Text = grdClientes.SelectedRows[0].Cells["mail"].Value.ToString();
            txtTelefono.Text = grdClientes.SelectedRows[0].Cells["telefono"].Value.ToString();
            txtDomicilio.Text = grdClientes.SelectedRows[0].Cells["domicilio"].Value.ToString();
            this.estado = Estado.MODIFICAR;
            btnNuevo.Enabled = true;
            btnEliminar.Enabled = true;
        }

        private void btnNuevo_Click(object sender, EventArgs e)
        {
            limpiarCampos();
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("¿Está seguro que desea eliminar el cliente?", "Confirmación",
    MessageBoxButtons.YesNo, MessageBoxIcon.Question,
    MessageBoxDefaultButton.Button1) != System.Windows.Forms.DialogResult.Yes) return;
            Cliente c = new Cliente();
            c.id = Int32.Parse(txtId.Text);
            c.documento = long.Parse(txtDocumento.Text);
            c.apellido = txtApellido.Text;
            c.nombre = txtNombre.Text;
            c.mail = txtMail.Text;
            c.telefono = txtTelefono.Text;
            c.domicilio = txtDomicilio.Text;
            c.fechaNacimiento = dtpFechaNacimiento.Value;
            c.campoBaja = 1;
            GenericBL<Cliente>.update(c);
            grdClientes.DataSource = GenericBL<Cliente>.listActivos();
            limpiarCampos();
            MessageBox.Show("El cliente se eliminó correctamente.", "Cliente eliminado", MessageBoxButtons.OK,
                 MessageBoxIcon.Information);
        }

        private void FormClientes_FormClosing(object sender, FormClosingEventArgs e)
        {
            Application.Exit();
        }

        private void grdClientes_ColumnHeaderMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            /*DataGridViewColumn newColumn = grdClientes.Columns[e.ColumnIndex];
            DataGridViewColumn oldColumn = grdClientes.SortedColumn;
            ListSortDirection direction;

            // If oldColumn is null, then the DataGridView is not sorted. 
            if (oldColumn != null)
            {
                // Sort the same column again, reversing the SortOrder. 
                if (oldColumn == newColumn &&
                    grdClientes.SortOrder == SortOrder.Ascending)
                {
                    direction = ListSortDirection.Descending;
                }
                else
                {
                    // Sort a new column and remove the old SortGlyph.
                    direction = ListSortDirection.Ascending;
                    oldColumn.HeaderCell.SortGlyphDirection = SortOrder.None;
                }
            }
            else
            {
                direction = ListSortDirection.Ascending;
            }

            // Sort the selected column.
            grdClientes.Sort(newColumn, direction);
            newColumn.HeaderCell.SortGlyphDirection = direction == ListSortDirection.Ascending ? SortOrder.Ascending : SortOrder.Descending;
        */}

        private void grdClientes_DataBindingComplete(object sender, DataGridViewBindingCompleteEventArgs e)
        {
            /*// Put each of the columns into programmatic sort mode. 
            foreach (DataGridViewColumn column in grdClientes.Columns)
            {
                column.SortMode = DataGridViewColumnSortMode.Programmatic;
            }*/
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
            filtro.Add("apellido", txtBuscar.Text );
            grdClientes.DataSource = GenericBL<Cliente>.listActivos(filtro);
        }

        private void btnLimpiarFiltro_Click(object sender, EventArgs e)
        {
            grdClientes.DataSource = GenericBL<Cliente>.listActivos();
            txtBuscar.Text = "";
        }
    }
}
