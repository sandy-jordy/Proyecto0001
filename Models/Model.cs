using System;
using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity;
using System.Linq;

namespace WebAppCA.Models
{
    public partial class Model : DbContext
    {
        public Model()
            : base("name=Model1")
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
        public virtual DbSet<ROL> ROL { get; set; }
        public virtual DbSet<USUARIO> USUARIO { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Agencia>()
                .HasMany(e => e.Ruta)
                .WithRequired(e => e.Agencia)
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
                .Property(e => e.Primer_nombre)
                .IsUnicode(false);

            modelBuilder.Entity<Empleado>()
                .Property(e => e.Segundo_nombre)
                .IsUnicode(false);

            modelBuilder.Entity<Empleado>()
                .Property(e => e.Primer_apellido)
                .IsUnicode(false);

            modelBuilder.Entity<Empleado>()
                .Property(e => e.Segundo_apellido)
                .IsUnicode(false);

            modelBuilder.Entity<Empleado>()
                .Property(e => e.Estado)
                .IsUnicode(false);

            modelBuilder.Entity<Empleado>()
                .HasMany(e => e.Asistencia)
                .WithRequired(e => e.Empleado)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<Empleado>()
                .HasMany(e => e.Detalle_asignacion)
                .WithRequired(e => e.Empleado)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<Pais>()
                .HasMany(e => e.Agencia)
                .WithRequired(e => e.Pais)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<Ruta>()
                .HasMany(e => e.Asignacion)
                .WithRequired(e => e.Ruta)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<ROL>()
                .Property(e => e.Descripcion)
                .IsUnicode(false);

            modelBuilder.Entity<USUARIO>()
                .Property(e => e.Nombres)
                .IsUnicode(false);

            modelBuilder.Entity<USUARIO>()
                .Property(e => e.Apellidos)
                .IsUnicode(false);

            modelBuilder.Entity<USUARIO>()
                .Property(e => e.Correo)
                .IsUnicode(false);

            modelBuilder.Entity<USUARIO>()
                .Property(e => e.Clave)
                .IsUnicode(false);
        }
    }
}
