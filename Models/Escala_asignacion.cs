namespace WebAppCA.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class Escala_asignacion
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public Escala_asignacion()
        {
            Detalle_asignacion = new HashSet<Detalle_asignacion>();
        }

        [Key]
        public int id_escala_asignacion { get; set; }

        [Column("Escala_asignacion")]
        [Required]
        [StringLength(15)]
        public string Escala_asignacion1 { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Detalle_asignacion> Detalle_asignacion { get; set; }
    }
}
