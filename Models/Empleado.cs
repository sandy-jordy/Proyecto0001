namespace SIS_CA.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;
    using System.Linq;

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
        [StringLength(15)]
        public string Primer_nombre { get; set; }

        [StringLength(15)]
        public string Segundo_nombre { get; set; }

        [Required]
        [StringLength(15)]
        public string Primer_apellido { get; set; }

        [StringLength(15)]
        public string Segundo_apellido { get; set; }

        [Column(TypeName = "date")]
        public DateTime Fecha_ingreso { get; set; }

        public int id_cargo { get; set; }

        [Required]
        [StringLength(10)]
        public string Estado { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Asistencia> Asistencia { get; set; }

        public virtual Cargo Cargo { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Detalle_asignacion> Detalle_asignacion { get; set; }

        public List<Empleado> Listar()
        {
            var Empleado = new List<Empleado>();
            string cadena = "select * from Empleado";
            try
            {
                using (var contenedor = new Model1())
                {
                    Empleado = contenedor.Database.SqlQuery<Empleado>(cadena).ToList();
                }
            }
            catch (Exception)
            {

                throw;
            }
            return Empleado;

            
        }

        public Boolean Insertar(string Primer_nombre, string Segundo_nombre, string Primer_apellido, string Segundo_apellido, DateTime Fecha_ingreso, int id_cargo, string estado)
        {
            bool estado1 = false;
            try
            {
                using (var cnx=new Model1())
                {
                    string cadena = "insert into Empleado(Primer_nombre,Segundo_nombre,Primer_apellido,Segundo_apellido,Fecha_ingreso,id_cargo,Estado) values('" + Primer_nombre + "','" + Segundo_nombre + "','" + Primer_apellido + "','" + Segundo_apellido + "','" + Fecha_ingreso + "','" + id_cargo + "','" + Estado + "')";
                    int r = cnx.Database.ExecuteSqlCommand(cadena);
                    if (r==1)
                    {
                        estado1 = true;
                    }

                }

            }
            catch (Exception)
            {
                estado1 = false;

                throw;
            }
            return estado1;
        }

    }
}
