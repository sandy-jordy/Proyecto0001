namespace WebAppCA.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("USUARIO")]
    public partial class USUARIO
    {
        [Key]
        [Column(Order = 0)]
        public int IdUsuario { get; set; }

        [StringLength(60)]
        public string Nombres { get; set; }

        [StringLength(60)]
        public string Apellidos { get; set; }

        [StringLength(60)]
        public string Correo { get; set; }

        [StringLength(100)]
        public string Clave { get; set; }

        [Key]
        [Column(Order = 1)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int IdSucursal { get; set; }

        [Key]
        [Column(Order = 2)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int IdRol { get; set; }

        public bool? Activo { get; set; }

        public DateTime? FechaRegistro { get; set; }
    }
}
