using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data.SqlClient;
using System.Data;

namespace SIS_CA.Datos
{
    public class conexion
    {

        private SqlConnection Conexion = new SqlConnection("Data Source=DESKTOP-1AM46KO;Initial Catalog=Control_de_asistencia;Integrated Security=True");
        public SqlConnection AbrirConexion()
        {
            if (Conexion.State == ConnectionState.Closed)
                Conexion.Open();
            return Conexion;
        }
        public SqlConnection CerrarConexion()
        {
            if (Conexion.State == ConnectionState.Open)
                Conexion.Close();
            return Conexion;
        }
    }
}