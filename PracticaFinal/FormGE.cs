using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace PracticaFinal
{
    public partial class FormGE : Form
    {
        private ConexionDB ConectarDB = new ConexionDB();
        SqlDataReader leer;
        DataTable tabla = new DataTable();
        SqlCommand comando = new SqlCommand();

        public DataTable MostrarE()
        {
            comando.Connection = ConectarDB.AbrirConexion();
            comando.CommandText = "EntidadesPC1";
            comando.CommandType = CommandType.StoredProcedure;
            leer = comando.ExecuteReader();
            tabla.Load(leer);
            ConectarDB.CerrarConexion();
            return tabla;

        }

        public FormGE()
        {
            InitializeComponent();
        }

        private void FormGE_Load(object sender, EventArgs e)
        {
            MostrarTablaE();
        }
        private void MostrarTablaE()
        {
            dataGridView1.DataSource = MostrarE();
        }
    }
}
