using System;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;

namespace PruebaTecnicaBack.Models;

public partial class PruebatecnicaContext : DbContext
{
    public PruebatecnicaContext()
    {
    }

    public PruebatecnicaContext(DbContextOptions<PruebatecnicaContext> options)
        : base(options)
    {
    }

    public virtual DbSet<Contract> Contracts { get; set; }

    public virtual DbSet<Item> Items { get; set; }

    public virtual DbSet<Pedido> Pedidos { get; set; }

    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder) { }

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        modelBuilder
            .UseCollation("utf8mb4_0900_ai_ci")
            .HasCharSet("utf8mb4");

        modelBuilder.Entity<Contract>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PRIMARY");

            entity.ToTable("contract");

            entity.Property(e => e.ColegioLocalidad).HasMaxLength(255);
            entity.Property(e => e.ColegioNivel).HasMaxLength(255);
            entity.Property(e => e.ColegioNombre).HasMaxLength(255);
            entity.Property(e => e.CourseCode).HasMaxLength(255);
            entity.Property(e => e.FechaAlta).HasColumnType("datetime");
            entity.Property(e => e.FechaEntrega).HasColumnType("datetime");
            entity.Property(e => e.MedioEntrega).HasMaxLength(255);
            entity.Property(e => e.Total).HasPrecision(6, 2);
        });

        modelBuilder.Entity<Item>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PRIMARY");

            entity.ToTable("item");

            entity.Property(e => e.Nombre).HasMaxLength(255);
            entity.Property(e => e.Precio).HasPrecision(6, 2);
        });

        modelBuilder.Entity<Pedido>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PRIMARY");

            entity.ToTable("pedido");

            entity.HasIndex(e => e.ContractId, "ContractId");

            entity.HasIndex(e => e.ItemId, "ItemId");

            entity.Property(e => e.CreateDate).HasColumnType("datetime");
            entity.Property(e => e.CreatedBy).HasMaxLength(255);
            entity.Property(e => e.UpdateDate).HasColumnType("datetime");

            entity.HasOne(d => d.Contract).WithMany(p => p.Pedidos)
                .HasForeignKey(d => d.ContractId)
                .HasConstraintName("pedido_ibfk_1");

            entity.HasOne(d => d.Item).WithMany(p => p.Pedidos)
                .HasForeignKey(d => d.ItemId)
                .HasConstraintName("pedido_ibfk_2");
        });

        OnModelCreatingPartial(modelBuilder);
    }

    partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
}
