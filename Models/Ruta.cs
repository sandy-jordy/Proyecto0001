namespace WebAppCA.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("Ruta")]
    public partial class Ruta
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public Ruta()
        {
            Asignacion = new HashSet<Asignacion>();
        }

        [Key]
        public int id_ruta { get; set; }

        public int id_agencia { get; set; }

        [Column("Ruta")]
        [Required]
        [StringLength(20)]
        public string Ruta1 { get; set; }

        public virtual Agencia Agencia { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Asignacion> Asignacion { get; set; }
    }
}
