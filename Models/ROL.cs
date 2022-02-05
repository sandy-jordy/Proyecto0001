namespace WebAppCA.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("ROL")]
    public partial class ROL
    {
        [Key]
        public int IdRol { get; set; }

        [StringLength(60)]
        public string Descripcion { get; set; }

        public bool? Activo { get; set; }

        public DateTime? FechaRegistro { get; set; }
    }
}
