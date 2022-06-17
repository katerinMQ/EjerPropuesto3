using System;
using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity;
using System.Linq;

namespace EjerPropuesto3_TM_A.Models
{
    public partial class ModeloEjercicio3 : DbContext
    {
        public ModeloEjercicio3()
            : base("name=ModeloEjercicio3")
        {
        }

        public virtual DbSet<CRITERIO> CRITERIO { get; set; }
        public virtual DbSet<CRITERIO_CURSO> CRITERIO_CURSO { get; set; }
        public virtual DbSet<CURSO> CURSO { get; set; }
        public virtual DbSet<PLAN_ESTUDIO> PLAN_ESTUDIO { get; set; }
        public virtual DbSet<REGISTRO> REGISTRO { get; set; }
        public virtual DbSet<REGISTRO_CRITERIO> REGISTRO_CRITERIO { get; set; }
        public virtual DbSet<RESULTADO> RESULTADO { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Entity<CRITERIO>()
                .Property(e => e.NOMBRE)
                .IsUnicode(false);

            modelBuilder.Entity<CRITERIO>()
                .HasMany(e => e.CRITERIO_CURSO)
                .WithRequired(e => e.CRITERIO)
                .HasForeignKey(e => e.IDCRITERIO)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<CRITERIO>()
                .HasMany(e => e.REGISTRO_CRITERIO)
                .WithRequired(e => e.CRITERIO)
                .HasForeignKey(e => e.IDCRITERIO)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<CRITERIO_CURSO>()
                .Property(e => e.CODIGO)
                .IsUnicode(false);

            modelBuilder.Entity<CRITERIO_CURSO>()
                .Property(e => e.PORCENTAJEOBTENIDO)
                .HasPrecision(8, 2);

            modelBuilder.Entity<CURSO>()
                .Property(e => e.NOMBRE)
                .IsUnicode(false);

            modelBuilder.Entity<CURSO>()
                .Property(e => e.CICLO)
                .IsUnicode(false);

            modelBuilder.Entity<CURSO>()
                .HasMany(e => e.CRITERIO_CURSO)
                .WithRequired(e => e.CURSO)
                .HasForeignKey(e => e.IDCURSO)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<PLAN_ESTUDIO>()
                .Property(e => e.NOMBRE)
                .IsUnicode(false);

            modelBuilder.Entity<PLAN_ESTUDIO>()
                .HasMany(e => e.CURSO)
                .WithOptional(e => e.PLAN_ESTUDIO)
                .HasForeignKey(e => e.IDPLANESTUDIO);

            modelBuilder.Entity<REGISTRO>()
                .Property(e => e.CODIGO)
                .IsUnicode(false);

            modelBuilder.Entity<REGISTRO_CRITERIO>()
                .Property(e => e.CODIGO)
                .IsUnicode(false);

            modelBuilder.Entity<REGISTRO_CRITERIO>()
                .Property(e => e.IDRESULTADO)
                .IsUnicode(false);

            modelBuilder.Entity<RESULTADO>()
                .Property(e => e.NOMBRE)
                .IsUnicode(false);

            modelBuilder.Entity<RESULTADO>()
                .HasMany(e => e.CRITERIO)
                .WithOptional(e => e.RESULTADO)
                .HasForeignKey(e => e.IDRESULTADO);

            modelBuilder.Entity<RESULTADO>()
                .HasMany(e => e.REGISTRO)
                .WithOptional(e => e.RESULTADO)
                .HasForeignKey(e => e.IDRESULTADO);
        }
    }
}
