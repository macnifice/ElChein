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

            entity.Property(e => e.Color)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.IdPants).ValueGeneratedOnAdd();
            entity.Property(e => e.Material)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.Price).HasColumnType("decimal(18, 2)");
            entity.Property(e => e.Size)
                .HasMaxLength(50)
                .IsUnicode(false);
        });

        modelBuilder.Entity<Shirt>(entity =>
        {
            entity
                .HasNoKey()
                .ToTable("Shirt");

            entity.Property(e => e.Color)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.IdShirt).ValueGeneratedOnAdd();
            entity.Property(e => e.Material)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.Price).HasColumnType("decimal(18, 2)");
            entity.Property(e => e.Size)
                .HasMaxLength(50)
                .IsUnicode(false);
        });

        OnModelCreatingPartial(modelBuilder);
    }

    partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
}
