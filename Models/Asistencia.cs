namespace WebAppCA.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("Asistencia")]
    public partial class Asistencia
    {
        [Key]
        public int id_asistencia { get; set; }

        public int id_empleado { get; set; }

        public int id_concepto { get; set; }

        [Column(TypeName = "date")]
        public DateTime Fecha_asistencia { get; set; }

        public virtual Concepto Concepto { get; set; }

        public virtual Empleado Empleado { get; set; }
    }
}
