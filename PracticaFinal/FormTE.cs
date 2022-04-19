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
    public partial class FormTE : Form
    {
        private ConexionDB ConectarDB = new ConexionDB();
        SqlDataReader leer;
        DataTable tabla = new DataTable();
        SqlCommand comando = new SqlCommand();

        public DataTable MostrarTE()
        {
            comando.Connection = ConectarDB.AbrirConexion();
            comando.CommandText = "TiposEntidadesPC";
            comando.CommandType = CommandType.StoredProcedure;
            leer = comando.ExecuteReader();
            tabla.Load(leer);
            ConectarDB.CerrarConexion();
            return tabla;

        }

        public FormTE()
        {
            InitializeComponent();
        }

        private void FormTE_Load(object sender, EventArgs e)
        {
            MostrarTablaTE();
        }
        private void MostrarTablaTE()
        {
            dataGridView1.DataSource = MostrarTE();
        }

    }
}
