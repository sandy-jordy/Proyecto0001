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
    
    public partial class SP_mostrar_empleados_Activos_Result
    {
        public int id_empleado { get; set; }
        public string Empleado { get; set; }
        public Nullable<System.DateTime> Fecha_ingreso { get; set; }
        public string Nombre_cargo { get; set; }
        public string Estado { get; set; }
        public int id_agencia { get; set; }
        public Nullable<System.DateTime> fecha_asis { get; set; }
        public Nullable<int> id_asistencia { get; set; }
        public Nullable<int> id_concepto { get; set; }
        public string concepto { get; set; }
    }
}
