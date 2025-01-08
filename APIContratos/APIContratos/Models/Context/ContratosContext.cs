using System;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata;
using APIContratos.Models.Entities;

namespace APIContratos.Models.Context
{
    public partial class ContratosContext : DbContext
    {
        public ContratosContext()
        {
        }

        public ContratosContext(DbContextOptions<ContratosContext> options)
            : base(options)
        {
        }

        public virtual DbSet<Cliente> Clientes { get; set; } = null!;
        public virtual DbSet<Contrato> Contratos { get; set; } = null!;
        public virtual DbSet<GruposComerciale> GruposComerciales { get; set; } = null!;
        public virtual DbSet<TiposContrato> TiposContratos { get; set; } = null!;

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Cliente>(entity =>
            {
                entity.Property(e => e.Id).HasColumnName("id");

                entity.Property(e => e.Direccion)
                    .HasMaxLength(500)
                    .HasColumnName("direccion");

                entity.Property(e => e.Email)
                    .HasMaxLength(100)
                    .HasColumnName("email");

                entity.Property(e => e.Grupo).HasColumnName("grupo");

                entity.Property(e => e.Nombre)
                    .HasMaxLength(200)
                    .IsUnicode(false)
                    .HasColumnName("nombre");

                entity.Property(e => e.Telefono)
                    .HasMaxLength(10)
                    .HasColumnName("telefono");

                entity.HasOne(d => d.GrupoNavigation)
                    .WithMany(p => p.Clientes)
                    .HasForeignKey(d => d.Grupo)
                    .HasConstraintName("FK__Clientes__grupo__3B75D760");
            });

            modelBuilder.Entity<Contrato>(entity =>
            {
                entity.Property(e => e.Id).HasColumnName("id");

                entity.Property(e => e.Cliente).HasColumnName("cliente");

                entity.Property(e => e.Descripcion)
                    .HasMaxLength(200)
                    .HasColumnName("descripcion");

                entity.Property(e => e.FechaFinal)
                    .HasColumnType("date")
                    .HasColumnName("fechaFinal");

                entity.Property(e => e.FechaInicio)
                    .HasColumnType("date")
                    .HasColumnName("fechaInicio");

                entity.Property(e => e.Monto)
                    .HasColumnType("decimal(18, 2)")
                    .HasColumnName("monto");

                entity.Property(e => e.TipoContrato).HasColumnName("tipoContrato");

                entity.HasOne(d => d.ClienteNavigation)
                    .WithMany(p => p.Contratos)
                    .HasForeignKey(d => d.Cliente)
                    .HasConstraintName("FK__Contratos__clien__6FE99F9F");

                entity.HasOne(d => d.TipoContratoNavigation)
                    .WithMany(p => p.Contratos)
                    .HasForeignKey(d => d.TipoContrato)
                    .HasConstraintName("FK__Contratos__tipoC__70DDC3D8");
            });

            modelBuilder.Entity<GruposComerciale>(entity =>
            {
                entity.Property(e => e.Id).HasColumnName("id");

                entity.Property(e => e.Direccion)
                    .HasMaxLength(500)
                    .HasColumnName("direccion");

                entity.Property(e => e.Email)
                    .HasMaxLength(100)
                    .HasColumnName("email");

                entity.Property(e => e.Nombre)
                    .HasMaxLength(200)
                    .IsUnicode(false)
                    .HasColumnName("nombre");

                entity.Property(e => e.Rfc)
                    .HasMaxLength(13)
                    .HasColumnName("RFC");

                entity.Property(e => e.Telefono)
                    .HasMaxLength(10)
                    .HasColumnName("telefono");
            });

            modelBuilder.Entity<TiposContrato>(entity =>
            {
                entity.Property(e => e.Id).HasColumnName("id");

                entity.Property(e => e.Descripcion)
                    .HasMaxLength(500)
                    .HasColumnName("descripcion");
            });

            OnModelCreatingPartial(modelBuilder);
        }

        partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
    }
}
