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
    public partial class FormDepositos : Form
    {
        enum Estado
        {
            NUEVO, MODIFICAR
        }

        private int idDeposito;
        private Estado estado;

        public FormDepositos()
        {
            InitializeComponent();
            List<Deposito> list = GenericBL<Deposito>.listActivos();
            Deposito d = new Deposito();
            d.id = 0;
            d.descripcion = "- - - - -";
            list.Insert(0, d);
            cmbDepositos.DataSource = list;
            this.estado = Estado.NUEVO;
            this.idDeposito = GenericBL<Deposito>.getNextId();
        }

        private void cmbDepositos_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cmbDepositos.SelectedValue.ToString() == "0")
            {
                txtDescripcion.Text = "";
            }
            else
            {
                txtDescripcion.Text = cmbDepositos.GetItemText(cmbDepositos.SelectedItem);
                this.estado = Estado.MODIFICAR;
                btnNuevo.Enabled = true;
                btnEliminar.Enabled = true;
            }
            this.idDeposito = (int)cmbDepositos.SelectedValue;
          
        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            if(txtDescripcion.Text == "")
            {
                MessageBox.Show("El campo descripción es obligatorio", "Descripción obligatoria", MessageBoxButtons.OK,
            MessageBoxIcon.Warning);
                return;
            }
            if (cmbDepositos.SelectedValue.ToString() == "0" && this.estado == Estado.MODIFICAR)
            {
                MessageBox.Show("Selecione un depósito por favor", "Depósito obligatorio", MessageBoxButtons.OK,
            MessageBoxIcon.Warning);
                return;
            }
            Deposito d = new Deposito();
            d.id = this.idDeposito;
            d.descripcion = txtDescripcion.Text;
            if (this.estado == Estado.NUEVO)
            {
                GenericBL<Deposito>.insert(d);
                MessageBox.Show("¡El nuevo depósito se agregó correctamente!", "Depósito agregado", MessageBoxButtons.OK,
                 MessageBoxIcon.Information);
            }
            else
            {
                GenericBL<Deposito>.update(d);
                MessageBox.Show("El depósito se modificó correctamente.", "Depósito modificado", MessageBoxButtons.OK,
                 MessageBoxIcon.Information);
            }
            this.estado = Estado.NUEVO;
            List<Deposito> list = GenericBL<Deposito>.listActivos();
            Deposito dep = new Deposito();
            dep.id = 0;
            dep.descripcion = "- - - - -";
            list.Insert(0, dep);
            cmbDepositos.DataSource = list;
            cmbDepositos.SelectedIndex = 0;
            btnNuevo.Enabled = false;
            btnEliminar.Enabled = false;
        }

        private void btnNuevo_Click(object sender, EventArgs e)
        {
            this.estado = Estado.NUEVO;
            btnNuevo.Enabled = false;
            btnEliminar.Enabled = false;
            txtDescripcion.Text = "";
            cmbDepositos.SelectedIndex = 0;
            this.idDeposito = GenericBL<Deposito>.getNextId();
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            Deposito d = new Deposito();
            d.id = this.idDeposito;
            d.descripcion = txtDescripcion.Text;
            d.campoBaja = 1;
            GenericBL<Deposito>.update(d);
            this.estado = Estado.NUEVO;
            btnNuevo.Enabled = false;
            btnEliminar.Enabled = false;
            List<Deposito> list = GenericBL<Deposito>.listActivos();
            Deposito dep = new Deposito();
            dep.id = 0;
            dep.descripcion = "- - - - -";
            list.Insert(0, d);
            cmbDepositos.DataSource = list;
            cmbDepositos.SelectedIndex = 0;
            MessageBox.Show("El depósito se eliminó correctamente", "Depósito eliminado", MessageBoxButtons.OK,
                 MessageBoxIcon.Information);
        }


    }
}
