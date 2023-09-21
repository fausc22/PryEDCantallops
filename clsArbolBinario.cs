using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using System.Windows;
using System.Windows.Forms;

namespace PryEDCantallops
{
    class clsArbolBinario
    {
        private clsNodo PrimerNodo;

        public clsNodo Raiz
        {
            get { return PrimerNodo; }
            set { PrimerNodo = value; }
        }

        public void Agregar(clsNodo Nvo)
        {
            Nvo.Izquierdo = null;
            Nvo.Derecho = null;
            if (Raiz == null)
            {
                Raiz = Nvo;
            }
            else
            {
                clsNodo NodoPadre = Raiz;
                clsNodo Aux = Raiz;
                while (Aux != null)
                {
                    NodoPadre = Aux;
                    if (Nvo.Codigo < Aux.Codigo)
                    {
                        Aux = Aux.Izquierdo;
                    }
                    else
                    {
                        Aux = Aux.Derecho;
                    }
                }
                if (Nvo.Codigo < NodoPadre.Codigo)
                {
                    NodoPadre.Izquierdo = Nvo;
                }
                else
                {
                    NodoPadre.Derecho = Nvo;
                }
            }
        }

        private void InOrdenAsc(DataGridView dgv, clsNodo R)
        {
            if (R.Izquierdo != null) InOrdenAsc(dgv, R.Izquierdo);
            dgv.Rows.Add(R.Codigo, R.Nombre, R.Tramite);
            if (R.Derecho != null) InOrdenAsc(dgv, R.Derecho);
        }

        public void RecorrerIn(DataGridView Grilla)
        {
            Grilla.Rows.Clear();
            InOrdenAsc(Grilla, Raiz);
        }

        private void PreOrdenAsc(DataGridView dgv, clsNodo R)
        {
            dgv.Rows.Add(R.Codigo, R.Nombre, R.Tramite);
            if (R.Izquierdo != null) PreOrdenAsc(dgv, R.Izquierdo);
            if (R.Derecho != null) PreOrdenAsc(dgv, R.Derecho);
        }

        public void RecorrerPre(DataGridView Grilla)
        {
            Grilla.Rows.Clear();
            PreOrdenAsc(Grilla, Raiz);
        }

        private void PostOrdenAsc(DataGridView dgv, clsNodo R)
        {
            if (R.Izquierdo != null) PostOrdenAsc(dgv, R.Izquierdo);
            if (R.Derecho != null) PostOrdenAsc(dgv, R.Derecho);
            dgv.Rows.Add(R.Codigo, R.Nombre, R.Tramite);
        }

        public void RecorrerPost(DataGridView Grilla)
        {
            Grilla.Rows.Clear();
            PostOrdenAsc(Grilla, Raiz);
        }

      
        


        public void ExportarIn(DataGridView Grilla)
        {
            try
            {
                using (StreamWriter writer = new StreamWriter("arbolInOrden.txt", false))
                {
                    foreach (DataGridViewRow row in Grilla.Rows)
                    {
                        foreach (DataGridViewCell cell in row.Cells)
                        {
                            // Escribe el valor de la celda en el archivo de texto
                            writer.Write(cell.Value.ToString() + "\t");
                        }
                        writer.WriteLine(); // Salta a la siguiente línea
                    }
                }
                MessageBox.Show("Datos guardados en el archivo de texto correctamente.");










            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al guardar los datos: " + ex.Message);
            }

        }

        public void ExportarPre(DataGridView Grilla)
        {
            try
            {
                using (StreamWriter writer = new StreamWriter("arbolPreOrden.txt", false))
                {
                    foreach (DataGridViewRow row in Grilla.Rows)
                    {
                        foreach (DataGridViewCell cell in row.Cells)
                        {
                            // Escribe el valor de la celda en el archivo de texto
                            writer.Write(cell.Value.ToString() + "\t");
                        }
                        writer.WriteLine(); // Salta a la siguiente línea
                    }
                }
                MessageBox.Show("Datos guardados en el archivo de texto correctamente.");










            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al guardar los datos: " + ex.Message);
            }

        }

        public void ExportarPost(DataGridView Grilla)
        {
            try
            {
                using (StreamWriter writer = new StreamWriter("arbolPostOrden.txt", false))
                {
                    foreach (DataGridViewRow row in Grilla.Rows)
                    {
                        foreach (DataGridViewCell cell in row.Cells)
                        {
                            // Escribe el valor de la celda en el archivo de texto
                            writer.Write(cell.Value.ToString() + "\t");
                        }
                        writer.WriteLine(); // Salta a la siguiente línea
                    }
                }
                MessageBox.Show("Datos guardados en el archivo de texto correctamente.");










            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al guardar los datos: " + ex.Message);
            }

        }


    }
}
