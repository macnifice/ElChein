using System;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;

namespace ElChein.Model;

public partial class ElCheinContext : DbContext
{
    public ElCheinContext()
    {
    }

    public ElCheinContext(DbContextOptions<ElCheinContext> options)
        : base(options)
    {
    }

    public virtual DbSet<Pant> Pants { get; set; }

    public virtual DbSet<Shirt> Shirts { get; set; }

    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
#warning To protect potentially sensitive information in your connection string, you should move it out of source code. You can avoid scaffolding the connection string by using the Name= syntax to read it from configuration - see https://go.microsoft.com/fwlink/?linkid=2131148. For more guidance on storing connection strings, see http://go.microsoft.com/fwlink/?LinkId=723263.
        => optionsBuilder.UseSqlServer("Data Source=DESKTOP-A30C9EP\\SQLEXPRESS;Initial Catalog=ElChein;Trusted_Connection=True;TrustServerCertificate=True;");

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
