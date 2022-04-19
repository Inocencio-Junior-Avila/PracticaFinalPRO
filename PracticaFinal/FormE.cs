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
    public partial class FormGGE : Form
    {
        private ConexionDB ConectarDB = new ConexionDB();
        SqlDataReader leer;
        DataTable tabla = new DataTable();
        SqlCommand comando = new SqlCommand();
        public DataTable MostrarGE()
        {
            comando.Connection = ConectarDB.AbrirConexion();
            comando.CommandText = "GrupoEDCUPC";
            comando.CommandType = CommandType.StoredProcedure;
            leer = comando.ExecuteReader();
            tabla.Load(leer);
            ConectarDB.CerrarConexion();
            return tabla;

        }

        private void limpiarForm()
        {
            textDescripcion.Clear();
            textStatus.Clear();
            textNoEliminable.Clear();
        }

        public FormGGE()
        {
            InitializeComponent();
        }

        private void FormGGE_Load(object sender, EventArgs e)
        {

            MostrarTablaGE();
        }

        private void MostrarTablaGE()
        {
            dataGridView1.DataSource = MostrarGE();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            SqlConnection con = new SqlConnection("Data Source=DESKTOP-HDS1ACQ\\SQLEXPRESS;Initial Catalog=SellPoint; Integrated Security= true");
            con.Open();
            string ID = textID.Text;
            string Nombre = textDescripcion.Text;
            string Correo = textStatus.Text;
            string Telefono = textNoEliminable.Text;

            SqlCommand query = new SqlCommand("Insert into GrupoEDCU (ID,Nombre,Correo,telefono) values("+ID+",'" + Nombre + "','" + Correo + "','" + Telefono + "')", con);
            int r = query.ExecuteNonQuery();

            if (r > 0)
            {
                MessageBox.Show("Datos Guardados.");
            }
            else
            {
                MessageBox.Show("No se pudieron guardar");
            }

            con.Close();
            limpiarForm();
        }

        private void button_Modificar_Click(object sender, EventArgs e)
        {
            SqlConnection con = new SqlConnection("Data Source=DESKTOP-HDS1ACQ\\SQLEXPRESS;Initial Catalog=SellPoint; Integrated Security= true");
            con.Open();
            string ID = textID.Text;
            string Nombre = textDescripcion.Text;
            string Correo = textStatus.Text;
            string Telefono = textNoEliminable.Text;

            SqlCommand query = new SqlCommand("update GruposEntidades set Descripcion='" + Nombre + "',Status='" + Correo + "',NoEliminable'" + Telefono + "'where codigo='"+ ID + "'", con);
            int r = query.ExecuteNonQuery();

            if (r > 0)
            {
                MessageBox.Show("Datos Modificados.");
            }
            else
            {
                MessageBox.Show("No se pudieron Modificar");
            }

            con.Close();
            limpiarForm();
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
