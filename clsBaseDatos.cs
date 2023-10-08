using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.OleDb;
using System.Windows.Forms;

namespace PryEDCantallops
{
    class clsBaseDatos
    {
        private OleDbConnection conn = new OleDbConnection();
        private OleDbCommand cmd = new OleDbCommand();
        private OleDbDataAdapter adapter = new OleDbDataAdapter();
        private string CadenaConexion = "Provider=Microsoft.Jet.OLEDB.4.0;Data Source=Libreria.mdb";

        public void Listar(DataGridView grilla)
        {
            try
            {
                conn.ConnectionString = CadenaConexion;
                conn.Open();

                cmd.Connection = conn;
                cmd.CommandType = CommandType.Text;
                cmd.CommandText = "SELECT * FROM LIBRO";

                DataSet DS = new DataSet();
                adapter = new OleDbDataAdapter(cmd);
                adapter.Fill(DS, "Tabla1");

                grilla.DataSource = null;
                grilla.DataSource = DS.Tables["Tabla1"];

                conn.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                conn.Close();
            }
        }

        public void Listar(DataGridView grilla, String varInstruccionSQL)
        {
            try
            {
                conn.ConnectionString = CadenaConexion;
                conn.Open();

                cmd.Connection = conn;
                cmd.CommandType = CommandType.Text;
                cmd.CommandText = varInstruccionSQL;

                DataSet DS = new DataSet();
                adapter = new OleDbDataAdapter(cmd);
                adapter.Fill(DS, "Resultado");

                grilla.DataSource = null;
                grilla.DataSource = DS.Tables["Resultado"];

                conn.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                conn.Close();

            }

        }
    }
}
