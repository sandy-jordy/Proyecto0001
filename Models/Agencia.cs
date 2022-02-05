namespace WebAppCA.Models
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
            Ruta = new HashSet<Ruta>();
        }

        [Key]
        public int id_agencia { get; set; }

        public int id_pais { get; set; }

        [Required]
        [StringLength(25)]
        public string Nombre_agencia { get; set; }

        public virtual Pais Pais { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Ruta> Ruta { get; set; }
    }
}
