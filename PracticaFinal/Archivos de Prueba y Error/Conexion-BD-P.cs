using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Data;

namespace PracticaFinal
{
    public class Conexion_BD_P
    {
        public SqlConnection Conexion = new SqlConnection("Data Source=DESKTOP-HDS1ACQ\\SQLEXPRESS;Initial Catalog=SellPoint; Integrated Security= true");

        public SqlConnection Abrir()
        {
            if (Conexion.State == ConnectionState.Closed)
                Conexion.Open();
            return Conexion;
        }

        public SqlConnection Cerrar()
        {
            if (Conexion.State == ConnectionState.Open)
                Conexion.Close();
            return Conexion;
        }
    }
}
