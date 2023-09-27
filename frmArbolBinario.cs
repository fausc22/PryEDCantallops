﻿using System;
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
    public partial class frmArbolBinario : Form
    {
        public frmArbolBinario()
        {
            InitializeComponent();
        }

        clsArbolBinario ObjArbol = new clsArbolBinario();

        private void btnAgregar_Click(object sender, EventArgs e)
        {
            clsNodo Persona = new clsNodo();
            Persona.Codigo = Convert.ToInt32(txtCodigo.Text);
            Persona.Nombre = txtNombre.Text;
            Persona.Tramite = txtTramite.Text;

            ObjArbol.Agregar(Persona);
            ObjArbol.RecorrerIn(dgvLista);
            ObjArbol.Recorrer(treeView1);
            ObjArbol.Recorrer(cmbEliminar);

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

        private void frmArbolBinario_Load(object sender, EventArgs e)
        {

        }

        private void optIn_CheckedChanged(object sender, EventArgs e)
        {
            ObjArbol.RecorrerIn(dgvLista);
        }

        private void optPre_CheckedChanged(object sender, EventArgs e)
        {
            ObjArbol.RecorrerPre(dgvLista);
        }

        private void optPost_CheckedChanged(object sender, EventArgs e)
        {
            ObjArbol.RecorrerPost(dgvLista);
        }

        private void btnExportar_Click(object sender, EventArgs e)
        {
            if (optIn.Checked)
            {
                ObjArbol.ExportarIn(dgvLista);
            }
            else
            {
                if (optPre.Checked)
                {
                    ObjArbol.ExportarPre(dgvLista);
                }
                else
                {
                    if (optPost.Checked)
                    {
                        ObjArbol.ExportarPost(dgvLista);
                    }
                    else
                    {
                        MessageBox.Show("Seleccione una opcion de ordenamiento", "", MessageBoxButtons.OK); 
                    }
                }
            }
        }

        private void btnEquilibrar_Click(object sender, EventArgs e)
        {
            ObjArbol.Equilibrar();
            ObjArbol.RecorrerIn(dgvLista);
            ObjArbol.Recorrer(treeView1);
            ObjArbol.Recorrer(cmbEliminar);
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            ObjArbol.Eliminar(Convert.ToInt32(cmbEliminar.Text));
            ObjArbol.RecorrerIn(dgvLista);
            ObjArbol.Recorrer(treeView1);
            ObjArbol.Recorrer(cmbEliminar);
            btnEliminar.Enabled = false;
        }

        private void cmbEliminar_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cmbEliminar.SelectedIndex != -1)
            {
                btnEliminar.Enabled = true;
            }
        }
    }
}
