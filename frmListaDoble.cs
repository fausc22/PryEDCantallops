using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PryEDCantallops
{
    public partial class frmListaDoble : Form
    {
        public frmListaDoble()
        {
            InitializeComponent();
        }

        clsListaDoble FilaDePersonas = new clsListaDoble();
        private void btnAgregar_Click(object sender, EventArgs e)
        {
            clsNodo ObjNodo = new clsNodo();
            ObjNodo.Codigo = Convert.ToInt32(txtCodigo.Text);
            ObjNodo.Nombre = txtNombre.Text;
            ObjNodo.Tramite = txtTramite.Text;
            FilaDePersonas.Agregar(ObjNodo);
            FilaDePersonas.RecorrerAsc(dgvLista);
            FilaDePersonas.RecorrerAsc(lstLista);
            FilaDePersonas.RecorrerAsc();
            FilaDePersonas.Recorrer(cmbEliminar);
            txtCodigo.Text = "";
            txtNombre.Text = "";
            txtTramite.Text = "";
            btnAgregar.Enabled = false;
        }

        private void txtTramite_TextChanged(object sender, EventArgs e)
        {
            if (txtCodigo.Text != null && txtNombre.Text != null && txtTramite.Text != null)
            {
                btnAgregar.Enabled = true;
            }
        }

        private void optAscendente_CheckedChanged(object sender, EventArgs e)
        {
            if (optAscendente.Checked)
            {
                FilaDePersonas.RecorrerAsc(dgvLista);
                FilaDePersonas.RecorrerAsc(lstLista);
                FilaDePersonas.RecorrerAsc();
            }
        }

        private void optDescendente_CheckedChanged(object sender, EventArgs e)
        {
            if (optDescendente.Checked)
            {
                FilaDePersonas.RecorrerDes(dgvLista);
                FilaDePersonas.RecorrerDes(lstLista);
                FilaDePersonas.RecorrerDes();
            }
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            if (FilaDePersonas.Primero != null)
            {
                Int32 x = Convert.ToInt32(cmbEliminar.Text);
                FilaDePersonas.Eliminar(x);
                FilaDePersonas.RecorrerAsc(dgvLista);
                FilaDePersonas.RecorrerAsc(lstLista);
                FilaDePersonas.Recorrer(cmbEliminar);
                FilaDePersonas.RecorrerAsc();
            }
            else
            {
                MessageBox.Show("La lista está vacía");
            }
            btnEliminar.Enabled = false;
        }

        private void cmbEliminar_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cmbEliminar.SelectedIndex != -1)
            {
                btnEliminar.Enabled = true;
            }
        }

        private void frmListaDoble_Load(object sender, EventArgs e)
        {

        }
    }
}
