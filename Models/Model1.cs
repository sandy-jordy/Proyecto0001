using System;
using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity;
using System.Linq;

namespace SIS_CA.Models
{
    public partial class Model1 : DbContext
    {
        public Model1()
            : base("name=AsistenciaEntities")
        {
        }

        public virtual DbSet<Agencia> Agencia { get; set; }
        public virtual DbSet<Asignacion> Asignacion { get; set; }
        public virtual DbSet<Asistencia> Asistencia { get; set; }
        public virtual DbSet<Cargo> Cargo { get; set; }
        public virtual DbSet<Concepto> Concepto { get; set; }
        public virtual DbSet<Detalle_asignacion> Detalle_asignacion { get; set; }
        public virtual DbSet<Empleado> Empleado { get; set; }
        public virtual DbSet<Escala_asignacion> Escala_asignacion { get; set; }
        public virtual DbSet<Pais> Pais { get; set; }
        public virtual DbSet<Ruta> Ruta { get; set; }
        public virtual DbSet<Tipo_asignacion> Tipo_asignacion { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Agencia>()
                .HasMany(e => e.Asignacion)
                .WithRequired(e => e.Agencia)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<Asignacion>()
                .HasMany(e => e.Detalle_asignacion)
                .WithRequired(e => e.Asignacion)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<Cargo>()
                .HasMany(e => e.Empleado)
                .WithRequired(e => e.Cargo)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<Concepto>()
                .HasMany(e => e.Asistencia)
                .WithRequired(e => e.Concepto)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<Empleado>()
                .HasMany(e => e.Asistencia)
                .WithRequired(e => e.Empleado)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<Empleado>()
                .HasMany(e => e.Detalle_asignacion)
                .WithRequired(e => e.Empleado)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<Pais>()
                .HasMany(e => e.Asignacion)
                .WithRequired(e => e.Pais)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<Ruta>()
                .HasMany(e => e.Asignacion)
                .WithRequired(e => e.Ruta)
                .WillCascadeOnDelete(false);
        }
    }
}
