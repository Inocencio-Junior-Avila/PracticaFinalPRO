using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Data;

namespace PracticaFinal
{
    public class CargasDeTablas
    {
        private ConexionDB conexion = new ConexionDB();
        SqlDataReader leer;
        DataTable tabla = new DataTable();
        SqlCommand comando = new SqlCommand();

        public DataTable MostrarGE()
        {
            comando.Connection = conexion.AbrirConexion();
            comando.CommandText = "GruposEntidadesPC";
            comando.CommandType = CommandType.StoredProcedure;
            leer = comando.ExecuteReader();
            tabla.Load(leer);
            conexion.CerrarConexion();
            return tabla;

        }

        public void InsertarGE(string Descripcion, string Status, string NoEliminable)
        {
            comando.Connection = conexion.AbrirConexion();
            comando.CommandText = "Insert into GruposEntidades values('" + Descripcion+ "','" +Status+ "','" +NoEliminable+ "')";
            comando.CommandType = CommandType.Text;
            comando.ExecuteNonQuery();
        }
    }
}
