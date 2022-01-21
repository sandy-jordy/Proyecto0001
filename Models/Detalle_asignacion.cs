namespace SIS_CA.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class Detalle_asignacion
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int id_detalle_asignacion { get; set; }

        public int id_asignacion { get; set; }

        public int id_empleado { get; set; }

        public int? id_tipo_asignacion { get; set; }

        public int? id_escala_asignacion { get; set; }

        public virtual Asignacion Asignacion { get; set; }

        public virtual Empleado Empleado { get; set; }

        public virtual Escala_asignacion Escala_asignacion { get; set; }

        public virtual Tipo_asignacion Tipo_asignacion { get; set; }
    }
}
