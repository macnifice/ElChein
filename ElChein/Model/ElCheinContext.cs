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
        => optionsBuilder.UseSqlServer("Server=DESKTOP-S8BJVI6\\SQLEXPRESS;Database=ElChein;Trusted_Connection=True;TrustServerCertificate=True;");

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
