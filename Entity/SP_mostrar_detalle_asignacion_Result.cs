//------------------------------------------------------------------------------
// <auto-generated>
//     Este código se generó a partir de una plantilla.
//
//     Los cambios manuales en este archivo pueden causar un comportamiento inesperado de la aplicación.
//     Los cambios manuales en este archivo se sobrescribirán si se regenera el código.
// </auto-generated>
//------------------------------------------------------------------------------

namespace WebAppCA.Entity
{
    using System;
    
    public partial class SP_mostrar_detalle_asignacion_Result
    {
        public int id_asignacion { get; set; }
        public int id_detalle_asignacion { get; set; }
        public System.DateTime Fecha { get; set; }
        public string Camion { get; set; }
        public Nullable<int> Cajas { get; set; }
        public Nullable<double> KM { get; set; }
        public string Nombre_pais { get; set; }
        public int id_ruta { get; set; }
        public string Ruta { get; set; }
        public string Empleado { get; set; }
        public string Tipo_asignacion { get; set; }
        public string Escala_asignacion { get; set; }
    }
}
