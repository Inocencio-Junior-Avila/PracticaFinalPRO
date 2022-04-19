using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Data;

namespace PracticaFinal
{
    public class ConexionDB
    {
        string cadena = "Data Source=DESKTOP-HDS1ACQ\\SQLEXPRESS;Initial Catalog=SellPoint; Integrated Security= true";
        public SqlConnection ConectarDB = new SqlConnection();

        public ConexionDB()
        {
            ConectarDB.ConnectionString = cadena;
        }

        public SqlConnection AbrirConexion()
        {
            if (ConectarDB.State == ConnectionState.Closed)
                ConectarDB.Open();
            return ConectarDB;
        }

        public SqlConnection CerrarConexion()
        {
            if (ConectarDB.State == ConnectionState.Open)
                ConectarDB.Close();
            return ConectarDB;
        }

        /*public void Abrir()
        {
            try
            {
                ConectarDB.Open();
                Console.WriteLine("Conexion abierta");
            }
            catch (Exception ex)
            {
                Console.WriteLine("Error al abrir la Base de Datos " + ex.Message);
            }
        }
        public void Cerrar()
        {
            ConectarDB.Close();
        }*/

    }
}
