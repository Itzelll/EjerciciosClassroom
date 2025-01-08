using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata;
using MVC_Contratos.Models.Entidades;

// Code scaffolded by EF Core assumes nullable reference types (NRTs) are not used or disabled.
// If you have enabled NRTs for your project, then un-comment the following line:
// #nullable disable

namespace MVC_Contratos.Models.Context
{
    public partial class EstadiosContext : DbContext
    {
        public EstadiosContext()
        {
        }

        public EstadiosContext(DbContextOptions<EstadiosContext> options)
            : base(options)
        {
        }

        public virtual DbSet<Clientes> Clientes { get; set; }
        public virtual DbSet<Contratos> Contratos { get; set; }
        public virtual DbSet<GruposComerciales> GruposComerciales { get; set; }
        public virtual DbSet<TiposContratos> TiposContratos { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (!optionsBuilder.IsConfigured)
            {
#warning To protect potentially sensitive information in your connection string, you should move it out of source code. See http://go.microsoft.com/fwlink/?LinkId=723263 for guidance on storing connection strings.
                optionsBuilder.UseSqlServer(@"Server=localhost\SQLEXPRESS01;Database=ContratosEnergia;Trusted_Connection=True;TrustServerCertificate=true;");
            }
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Clientes>(entity =>
            {
                entity.Property(e => e.Id).HasColumnName("id");

                entity.Property(e => e.Direccion)
                    .HasColumnName("direccion")
                    .HasMaxLength(500);

                entity.Property(e => e.Email)
                    .HasColumnName("email")
                    .HasMaxLength(100);

                entity.Property(e => e.Grupo).HasColumnName("grupo");

                entity.Property(e => e.Nombre)
                    .HasColumnName("nombre")
                    .HasMaxLength(200)
                    .IsUnicode(false);

                entity.Property(e => e.Telefono)
                    .HasColumnName("telefono")
                    .HasMaxLength(10);

                entity.HasOne(d => d.GrupoNavigation)
                    .WithMany(p => p.Clientes)
                    .HasForeignKey(d => d.Grupo)
                    .HasConstraintName("FK__Clientes__grupo__45F365D3");
            });

            modelBuilder.Entity<Contratos>(entity =>
            {
                entity.Property(e => e.Id).HasColumnName("id");

                entity.Property(e => e.Cliente).HasColumnName("cliente");

                entity.Property(e => e.Descripcion)
                    .HasColumnName("descripcion")
                    .HasMaxLength(200);

                entity.Property(e => e.FechaFinal)
                    .HasColumnName("fechaFinal")
                    .HasColumnType("date");

                entity.Property(e => e.FechaInicio)
                    .HasColumnName("fechaInicio")
                    .HasColumnType("date");

                entity.Property(e => e.Monto)
                    .HasColumnName("monto")
                    .HasColumnType("decimal(18, 2)");

                entity.Property(e => e.TipoContrato).HasColumnName("tipoContrato");

                entity.HasOne(d => d.Clientes)
                    .WithMany(p => p.Contratos)
                    .HasForeignKey(d => d.Cliente)
                    .HasConstraintName("FK__Contratos__clien__48CFD27E");

                entity.HasOne(d => d.TiposContratos)
                    .WithMany(p => p.Contratos)
                    .HasForeignKey(d => d.TipoContrato)
                    .HasConstraintName("FK__Contratos__tipoC__49C3F6B7");
            });

            modelBuilder.Entity<GruposComerciales>(entity =>
            {
                entity.Property(e => e.Id).HasColumnName("id");

                entity.Property(e => e.Direccion)
                    .HasColumnName("direccion")
                    .HasMaxLength(500);

                entity.Property(e => e.Email)
                    .HasColumnName("email")
                    .HasMaxLength(100);

                entity.Property(e => e.Nombre)
                    .HasColumnName("nombre")
                    .HasMaxLength(200)
                    .IsUnicode(false);

                entity.Property(e => e.Rfc)
                    .HasColumnName("RFC")
                    .HasMaxLength(13);

                entity.Property(e => e.Telefono)
                    .HasColumnName("telefono")
                    .HasMaxLength(10);
            });

            modelBuilder.Entity<TiposContratos>(entity =>
            {
                entity.Property(e => e.Id).HasColumnName("id");

                entity.Property(e => e.Descripcion)
                    .HasColumnName("descripcion")
                    .HasMaxLength(500);
            });

            OnModelCreatingPartial(modelBuilder);
        }

        partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
    }
}
