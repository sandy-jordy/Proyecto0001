namespace WebAppCA.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("Empleado")]
    public partial class Empleado
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public Empleado()
        {
            Asistencia = new HashSet<Asistencia>();
            Detalle_asignacion = new HashSet<Detalle_asignacion>();
        }

        [Key]
        public int id_empleado { get; set; }

        [Required]
        [StringLength(90)]
        public string Primer_nombre { get; set; }

        [StringLength(90)]
        public string Segundo_nombre { get; set; }

        [Required]
        [StringLength(90)]
        public string Primer_apellido { get; set; }

        [StringLength(90)]
        public string Segundo_apellido { get; set; }

        public DateTime? Fecha_ingreso { get; set; }

        public int id_cargo { get; set; }

        public int id_agencia { get; set; }

        [StringLength(50)]
        public string Estado { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Asistencia> Asistencia { get; set; }

        public virtual Cargo Cargo { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Detalle_asignacion> Detalle_asignacion { get; set; }
    }
}
