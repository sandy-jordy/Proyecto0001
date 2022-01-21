namespace SIS_CA.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("Agencia")]
    public partial class Agencia
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public Agencia()
        {
            Asignacion = new HashSet<Asignacion>();
        }

        [Key]
        public int id_agencia { get; set; }

        [Required]
        [StringLength(25)]
        public string Nombre_agencia { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Asignacion> Asignacion { get; set; }
    }
}
