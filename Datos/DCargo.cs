using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Web;

namespace SIS_CA.Datos
{
    public class DCargo
    {
        private conexion conexion = new conexion();
        SqlDataReader leer;
        DataTable tabla = new DataTable();
        SqlCommand comando = new SqlCommand();
        public DataTable Mostrar()
        {

            comando.Connection = conexion.AbrirConexion();
            comando.CommandText = "SP_Mostrar_cargo";
            comando.CommandType = CommandType.StoredProcedure;
            leer = comando.ExecuteReader();
            tabla.Load(leer);
            conexion.CerrarConexion();
            return tabla;

        }
    }
}