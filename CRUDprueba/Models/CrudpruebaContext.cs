using System;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;

namespace CRUDprueba.Models;

public partial class CrudpruebaContext : DbContext
{
    public CrudpruebaContext()
    {

    }

    public CrudpruebaContext(DbContextOptions<CrudpruebaContext> options)
        : base(options)
    {

    }

    public virtual DbSet<Cliente> Clientes { get; set; }

    public virtual DbSet<Vendedor> Vendedores { get; set; }
    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        => optionsBuilder.UseSqlServer("Server=DESKTOP-4RGQT6N\\SQLEXPRESS;Database=CRUDprueba;Trusted_Connection=True;TrustServerCertificate=True;");

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        modelBuilder.Entity<Cliente>(entity =>
        {
            entity.Property(e => e.Id).HasColumnName("ID");
            entity.Property(e => e.Apellido)
                .HasMaxLength(100)
                .IsFixedLength();
            entity.Property(e => e.Correo)
                .HasMaxLength(100)
                .IsFixedLength();
            entity.Property(e => e.Nombre)
                .HasMaxLength(100)
                .IsFixedLength();
        });


        OnModelCreatingPartial(modelBuilder);
    }

    partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
}
