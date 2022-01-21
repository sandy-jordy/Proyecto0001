using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Web;

namespace SIS_CA.Datos
{
    public class DEmpleados
    {
        private conexion conexion = new conexion();
        SqlDataReader leer;
        DataTable tabla = new DataTable();
        SqlCommand comando = new SqlCommand();
        public DataTable Mostrar()
        {

            comando.Connection = conexion.AbrirConexion();
            comando.CommandText = "SP_mostrar_empleado";
            comando.CommandType = CommandType.StoredProcedure;
            leer = comando.ExecuteReader();
            tabla.Load(leer);
            conexion.CerrarConexion();
            return tabla;

        }
        public void Insertar_empleado(int id_empleado,string Pnombre, string Snombre, string Papellido, string Sapellido,
            string fecha_ingreso, int id_cargo, string estado)
        {
            comando.Connection = conexion.AbrirConexion();
            comando.CommandText = "SP_insertar_empleado";
            comando.CommandType = CommandType.StoredProcedure;
            comando.Parameters.AddWithValue("@id_empleado", id_empleado);
            comando.Parameters.AddWithValue("@primer_n", Pnombre);
            comando.Parameters.AddWithValue("@segundo_n", Snombre);
            comando.Parameters.AddWithValue("@pri_apellido", Papellido);
            comando.Parameters.AddWithValue("@seg_apellido", Sapellido);
            comando.Parameters.AddWithValue("@fecha_ingreso", fecha_ingreso);
            comando.Parameters.AddWithValue("@id_cargo", id_cargo);
            comando.Parameters.AddWithValue("@estado", estado);

            comando.ExecuteNonQuery();
            comando.Parameters.Clear();
            conexion.CerrarConexion();
        }
        
    }
}