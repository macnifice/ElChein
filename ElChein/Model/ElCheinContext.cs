using System;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;

namespace ElChein.Model;

public partial class ElCheinContext : DbContext
{

    public ElCheinContext(DbContextOptions<ElCheinContext> options)
        : base(options)
    {
    }

    public virtual DbSet<Pant> Pants { get; set; }

    public virtual DbSet<Shirt> Shirts { get; set; }

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        modelBuilder.Entity<Pant>(entity =>
        {
            entity
                .HasNoKey()
                .ToTable("Pant");

            entity.Property(e => e.Brand)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.Color)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.Genere)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.IdPants).ValueGeneratedOnAdd();
            entity.Property(e => e.Image)
                .HasMaxLength(150)
                .IsUnicode(false);
            entity.Property(e => e.Material)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.Name)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.Price).HasColumnType("decimal(18, 2)");
            entity.Property(e => e.Type)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.Xl).HasColumnName("XL");
            entity.Property(e => e.Xxl).HasColumnName("XXL");
        });

        modelBuilder.Entity<Shirt>(entity =>
        {
            entity
                .HasNoKey()
                .ToTable("Shirt");

            entity.Property(e => e.Brand)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.Color)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.Description)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.Genere)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.IdShirt).ValueGeneratedOnAdd();
            entity.Property(e => e.Image)
                .HasMaxLength(150)
                .IsUnicode(false);
            entity.Property(e => e.Material)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.Name)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.Price).HasColumnType("decimal(18, 2)");
            entity.Property(e => e.Size)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.Type)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.Xl).HasColumnName("XL");
            entity.Property(e => e.Xxl).HasColumnName("XXL");
        });

        OnModelCreatingPartial(modelBuilder);
    }

    partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
}
