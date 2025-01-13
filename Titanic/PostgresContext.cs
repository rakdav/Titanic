using System;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;

namespace Titanic;

public partial class PostgresContext : DbContext
{
    public PostgresContext()
    {
    }

    public PostgresContext(DbContextOptions<PostgresContext> options)
        : base(options)
    {
    }

    public virtual DbSet<Titanic> Titanics { get; set; }

    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
#warning To protect potentially sensitive information in your connection string, you should move it out of source code. You can avoid scaffolding the connection string by using the Name= syntax to read it from configuration - see https://go.microsoft.com/fwlink/?linkid=2131148. For more guidance on storing connection strings, see https://go.microsoft.com/fwlink/?LinkId=723263.
        => optionsBuilder.UseNpgsql("Host=localhost;Port=5432;Database=postgres;Username=postgres;Password=postgres");

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        modelBuilder.HasPostgresExtension("pg_catalog", "adminpack");

        modelBuilder.Entity<Titanic>(entity =>
        {
            entity.HasKey(e => e.Passengerid).HasName("titanic_pk");

            entity.ToTable("titanic");

            entity.Property(e => e.Passengerid).HasColumnName("passengerid");
            entity.Property(e => e.Age).HasColumnName("age");
            entity.Property(e => e.Cabin)
                .HasMaxLength(20)
                .HasColumnName("cabin");
            entity.Property(e => e.Embarced)
                .HasMaxLength(1)
                .HasColumnName("embarced");
            entity.Property(e => e.Fare).HasColumnName("fare");
            entity.Property(e => e.Parch).HasColumnName("parch");
            entity.Property(e => e.Passenger)
                .HasMaxLength(100)
                .HasColumnName("passenger");
            entity.Property(e => e.Pclass).HasColumnName("pclass");
            entity.Property(e => e.Sex)
                .HasMaxLength(6)
                .HasColumnName("sex");
            entity.Property(e => e.Sibsp).HasColumnName("sibsp");
            entity.Property(e => e.Survived).HasColumnName("survived");
            entity.Property(e => e.Ticket)
                .HasMaxLength(30)
                .HasColumnName("ticket");
        });

        OnModelCreatingPartial(modelBuilder);
    }

    partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
}
