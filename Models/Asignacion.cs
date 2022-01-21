namespace SIS_CA.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("Asignacion")]
    public partial class Asignacion
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public Asignacion()
        {
            Detalle_asignacion = new HashSet<Detalle_asignacion>();
        }

        [Key]
        public int id_asignacion { get; set; }

        public int id_agencia { get; set; }

        public int id_ruta { get; set; }

        public int id_pais { get; set; }

        [Column(TypeName = "date")]
        public DateTime Fecha { get; set; }

        [StringLength(30)]
        public string Camion { get; set; }

        public int? Cajas { get; set; }

        public double? KM { get; set; }

        public virtual Agencia Agencia { get; set; }

        public virtual Pais Pais { get; set; }

        public virtual Ruta Ruta { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Detalle_asignacion> Detalle_asignacion { get; set; }
    }
}
