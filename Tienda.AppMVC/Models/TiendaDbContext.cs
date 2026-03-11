using System;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;

namespace Tienda.AppMVC.Models;

public partial class TiendaDbContext : DbContext
{
    public TiendaDbContext()
    {
    }

    public TiendaDbContext(DbContextOptions<TiendaDbContext> options)
        : base(options)
    {
    }

    public virtual DbSet<Categoria> Categorias { get; set; }

    public virtual DbSet<Cliente> Clientes { get; set; }

    public virtual DbSet<Configuracione> Configuraciones { get; set; }

    public virtual DbSet<Cupone> Cupones { get; set; }

    public virtual DbSet<LogsActividad> LogsActividads { get; set; }

    public virtual DbSet<PreguntasFrecuente> PreguntasFrecuentes { get; set; }

    public virtual DbSet<Product> Products { get; set; }

    public virtual DbSet<Sucursale> Sucursales { get; set; }

    public virtual DbSet<Suscriptore> Suscriptores { get; set; }

    public DbSet<Servicio> Servicios { get; set; }


    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        modelBuilder.Entity<Categoria>(entity =>
        {
            entity.HasKey(e => e.CategoriaId).HasName("PK__Categori__F353C1C5EE16082D");

            entity.Property(e => e.CategoriaId).HasColumnName("CategoriaID");
            entity.Property(e => e.Descripcion).HasMaxLength(255);
            entity.Property(e => e.FechaCreacion)
                .HasDefaultValueSql("(getdate())")
                .HasColumnType("datetime");
            entity.Property(e => e.Nombre).HasMaxLength(100);
        });

        modelBuilder.Entity<Cliente>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PK__Clientes__3214EC07B2BF5BDA");

            entity.HasIndex(e => e.DocumentoIdentidad, "UQ__Clientes__049E81A949DD7579").IsUnique();

            entity.HasIndex(e => e.Email, "UQ__Clientes__A9D105348340D9B9").IsUnique();

            entity.Property(e => e.Apellido).HasMaxLength(100);
            entity.Property(e => e.DocumentoIdentidad)
                .HasMaxLength(20)
                .IsUnicode(false);
            entity.Property(e => e.Email).HasMaxLength(150);
            entity.Property(e => e.Estado).HasDefaultValue(true);
            entity.Property(e => e.FechaRegistro)
                .HasDefaultValueSql("(getdate())")
                .HasColumnType("datetime");
            entity.Property(e => e.Nombre).HasMaxLength(100);
            entity.Property(e => e.Telefono)
                .HasMaxLength(20)
                .IsUnicode(false);
        });

        modelBuilder.Entity<Configuracione>(entity =>
        {
            entity.HasKey(e => e.ConfigId).HasName("PK__Configur__C3BC333C80C8CD70");

            entity.HasIndex(e => e.Clave, "UQ__Configur__E8181E11557B35F2").IsUnique();

            entity.Property(e => e.ConfigId).HasColumnName("ConfigID");
            entity.Property(e => e.Clave).HasMaxLength(100);
            entity.Property(e => e.Descripcion).HasMaxLength(250);
        });

        modelBuilder.Entity<Cupone>(entity =>
        {
            entity.HasKey(e => e.CuponId).HasName("PK__Cupones__C43568B79EF42497");

            entity.HasIndex(e => e.CodigoCupon, "UQ__Cupones__BA82F46DB1333928").IsUnique();

            entity.Property(e => e.CuponId).HasColumnName("CuponID");
            entity.Property(e => e.CodigoCupon)
                .HasMaxLength(20)
                .IsUnicode(false);
            entity.Property(e => e.FechaExpiracion).HasColumnType("datetime");
        });

        modelBuilder.Entity<LogsActividad>(entity =>
        {
            entity.HasKey(e => e.LogId).HasName("PK__LogsActi__5E5499A8A0A97BD3");

            entity.ToTable("LogsActividad");

            entity.Property(e => e.LogId).HasColumnName("LogID");
            entity.Property(e => e.FechaHora)
                .HasDefaultValueSql("(getdate())")
                .HasColumnType("datetime");
            entity.Property(e => e.Nivel).HasMaxLength(50);
        });

        modelBuilder.Entity<PreguntasFrecuente>(entity =>
        {
            entity.HasKey(e => e.FaqId).HasName("PK__Pregunta__9C741C23840F56D6");

            entity.Property(e => e.FaqId).HasColumnName("FaqID");
            entity.Property(e => e.Pregunta).HasMaxLength(255);
        });

        modelBuilder.Entity<Product>(entity =>
        {
            entity.HasKey(e => e.ProductoId).HasName("PK__Producto__A430AE8354EA8329");

            entity.Property(e => e.ProductoId).HasColumnName("ProductoID");
            entity.Property(e => e.CategoriaId).HasColumnName("CategoriaID");
            entity.Property(e => e.Fecha)
                .HasDefaultValueSql("(getdate())", "DF__Productos__Fecha__3C69FB99")
                .HasColumnType("datetime");
            entity.Property(e => e.Nombre).HasMaxLength(100);
            entity.Property(e => e.Precio).HasColumnType("decimal(18, 2)");

            entity.HasOne(d => d.Categoria).WithMany(p => p.Products)
                .HasForeignKey(d => d.CategoriaId)
                .OnDelete(DeleteBehavior.SetNull)
                .HasConstraintName("FK_Categoria_Producto");
        });

        modelBuilder.Entity<Sucursale>(entity =>
        {
            entity.HasKey(e => e.SucursalId).HasName("PK__Sucursal__6CB482814329FCED");

            entity.Property(e => e.SucursalId).HasColumnName("SucursalID");
            entity.Property(e => e.Ciudad).HasMaxLength(100);
            entity.Property(e => e.NombreSucursal).HasMaxLength(100);
            entity.Property(e => e.TelefonoContacto)
                .HasMaxLength(20)
                .IsUnicode(false);
        });

        modelBuilder.Entity<Suscriptore>(entity =>
        {
            entity.HasKey(e => e.SuscriptorId).HasName("PK__Suscript__03ED7092B8882DA3");

            entity.HasIndex(e => e.Email, "UQ__Suscript__A9D10534FB95360C").IsUnique();

            entity.Property(e => e.SuscriptorId).HasColumnName("SuscriptorID");
            entity.Property(e => e.Activo).HasDefaultValue(true);
            entity.Property(e => e.Email).HasMaxLength(150);
            entity.Property(e => e.FechaSuscripcion).HasDefaultValueSql("(getdate())");
        });

        OnModelCreatingPartial(modelBuilder);
    }

    partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
}
