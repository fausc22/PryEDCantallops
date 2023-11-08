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
    public partial class frmRepaso : Form
    {
        public frmRepaso()
        {
            InitializeComponent();
            
        }
        clsBaseDatos objBD = new clsBaseDatos();
        private void frmRepaso_Load(object sender, EventArgs e)
        {
                //            Union
                //Diferencia
                //Interseccion
                //Proyección Simple
                //Proyección Multiatributo
                //Juntar
                //Selección Simple
                //Selección Multiatributo con operador AND
                //Selección Multiatributo con operador OR
                //Selección Multiatributo por convulsion
                cmbListar.SelectedIndex = 0;
        }

        private void btnListar_Click(object sender, EventArgs e)
        {
            String varSQL;
            if (cmbListar.Text == "Union")
            {
                txtListar.Text = cmbListar.Text + ": " +
                    "Libros de origen Sudamericano (Argentina, Colombia, Brasil)";
                varSQL = "SELECT * FROM libro WHERE IdPais = 8 " +
                "UNION SELECT * FROM libro WHERE IdPais = 24 " +
                "UNION SELECT * FROM libro WHERE IdPais = 26";
                objBD.Listar(dgvListar, varSQL);
            } else
            {
                if (cmbListar.Text == "Diferencia")
                {
                    txtListar.Text = cmbListar.Text + ": " +
                    "Paises que no tienen libros";
                    varSQL = "SELECT * FROM pais WHERE " +
                        "idpais not in " +
                        "(select idpais from libro )";
                    objBD.Listar(dgvListar, varSQL);
                }
                else
                {
                    if (cmbListar.Text == "Interseccion")
                    {
                        txtListar.Text = cmbListar.Text + ": " +
                    "Libros de origen Ruso";
                        varSQL = "SELECT * FROM libro " +
                         "WHERE idIdioma = 2 AND " +
                            "idLibro in " +
                            "(SELECT idLibro FROM libro WHERE IdPais = 3 ) " +
                            "ORDER BY 1 ASC ";
                        objBD.Listar(dgvListar, varSQL);
                    }
                    else
                    {
                        if (cmbListar.Text == "Proyección Simple")
                        {
                            txtListar.Text = cmbListar.Text + ": " +
                            "Todos los libros por titulo";
                            varSQL = "SELECT TITULO FROM LIBRO ORDER BY 1 DESC";
                            objBD.Listar(dgvListar, varSQL);
                        }
                        else
                        {
                            if (cmbListar.Text == "Proyección Multiatributo")
                            {
                                txtListar.Text = cmbListar.Text + ": " +
                                "Todos los libros por titulo y año ordenados por año de forma ascendente";
                                varSQL = "SELECT TITULO, AÑO FROM LIBRO ORDER BY AÑO ASC";
                                objBD.Listar(dgvListar, varSQL);
                            }
                            else
                            {
                                if (cmbListar.Text == "Juntar")
                                {
                                    txtListar.Text = cmbListar.Text + ": " +
                                    "Todos los libros por idioma";
                                    varSQL = "SELECT * FROM Libro, Idioma " +
                                     "WHERE Libro.IdIdioma = Idioma.IdIdioma";
                                    objBD.Listar(dgvListar, varSQL);
                                }
                                else
                                {
                                    if(cmbListar.Text == "Selección Simple")
                                    {
                                        txtListar.Text = cmbListar.Text + ": " +
                                        "Todos los libros";
                                        varSQL = "SELECT * FROM Libro";
                                        objBD.Listar(dgvListar, varSQL);
                                    }
                                    else
                                    {
                                        if (cmbListar.Text == "Selección Multiatributo con operador AND")
                                        {
                                            txtListar.Text = cmbListar.Text + ": " +
                                            "Todos los libros de Estados Unidos y en idioma Ingles";
                                            varSQL = "SELECT * FROM Libro WHERE IdPais = 4 AND IdIdioma = 1";
                                            objBD.Listar(dgvListar, varSQL);
                                        }
                                        else
                                        {
                                            if (cmbListar.Text == "Selección Multiatributo con operador OR")
                                            {
                                                txtListar.Text = cmbListar.Text + ": " +
                                                "Todos los libros de Alemania o en idioma Ingles";
                                                varSQL = "SELECT * FROM Libro WHERE IdPais = 5 OR IdIdioma = 1";
                                                objBD.Listar(dgvListar, varSQL);
                                            }
                                            else
                                            {
                                                if (cmbListar.Text == "Selección Multiatributo por convulsion")
                                                {
                                                    txtListar.Text = cmbListar.Text + ": " +
                                                    "Todos los libros de autores e idiomas";
                                                    varSQL = "SELECT * FROM Libro WHERE IdAutor > 10 " +
                                                            "INTERSECT SELECT * FROM Libro WHERE IdIdioma > 5"; ;
                                                    objBD.Listar(dgvListar, varSQL);
                                                }
                                            }
                                        }
                                    }
                                }
                            }
                        }
                    }
                }
            }
        }
    }
}
