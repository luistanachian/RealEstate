﻿using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata;
using RealEstate.Models.Entity;

namespace RealEstate.Dao.Context
{
    public partial class RealEstateContext : DbContext
    {
        public RealEstateContext()
        {
        }

        public RealEstateContext(DbContextOptions<RealEstateContext> options)
            : base(options)
        {
        }

        public virtual DbSet<DireccionBarrios> DireccionBarrios { get; set; }
        public virtual DbSet<DireccionEstados> DireccionEstados { get; set; }
        public virtual DbSet<DireccionLocalidades> DireccionLocalidades { get; set; }
        public virtual DbSet<Monedas> Monedas { get; set; }
        public virtual DbSet<Publicaciones> Publicaciones { get; set; }
        public virtual DbSet<PublicacionesPlanes> PublicacionesPlanes { get; set; }
        public virtual DbSet<TiposPropiedades> TiposPropiedades { get; set; }
        public virtual DbSet<Usuarios> Usuarios { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (!optionsBuilder.IsConfigured)
            {
#warning To protect potentially sensitive information in your connection string, you should move it out of source code. See http://go.microsoft.com/fwlink/?LinkId=723263 for guidance on storing connection strings.
                optionsBuilder.UseSqlServer("Server=DESKTOP-SP1256D\\SQLEXPRESS; Database=RealEstate; Trusted_Connection=True");
            }
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<DireccionBarrios>(entity =>
            {
                entity.HasKey(e => e.IdBarrio);

                entity.ToTable("Direccion_Barrios");

                entity.Property(e => e.IdBarrio).HasColumnName("idBarrio");

                entity.Property(e => e.Barrio)
                    .IsRequired()
                    .HasColumnName("barrio")
                    .HasMaxLength(100);
            });

            modelBuilder.Entity<DireccionEstados>(entity =>
            {
                entity.HasKey(e => e.IdEstado);

                entity.ToTable("Direccion_Estados");

                entity.Property(e => e.IdEstado).HasColumnName("idEstado");

                entity.Property(e => e.Estado)
                    .IsRequired()
                    .HasColumnName("estado")
                    .HasMaxLength(100);
            });

            modelBuilder.Entity<DireccionLocalidades>(entity =>
            {
                entity.HasKey(e => e.IdLocalidad);

                entity.ToTable("Direccion_Localidades");

                entity.Property(e => e.IdLocalidad).HasColumnName("idLocalidad");

                entity.Property(e => e.IdEstado).HasColumnName("idEstado");

                entity.Property(e => e.Localidad)
                    .IsRequired()
                    .HasColumnName("localidad")
                    .HasMaxLength(100);

            });

            modelBuilder.Entity<Monedas>(entity =>
            {
                entity.HasKey(e => e.IdMoneda);

                entity.Property(e => e.IdMoneda).HasColumnName("idMoneda");

                entity.Property(e => e.Moneda)
                    .IsRequired()
                    .HasColumnName("moneda")
                    .HasMaxLength(20);
            });

            modelBuilder.Entity<Publicaciones>(entity =>
            {
                entity.HasKey(e => e.IdPub);

                entity.Property(e => e.IdPub)
                    .HasColumnName("idPub")
                    .HasMaxLength(32);

                entity.Property(e => e.CantAmbientes).HasColumnName("cantAmbientes");

                entity.Property(e => e.CantBalcones).HasColumnName("cantBalcones");

                entity.Property(e => e.CantBaños).HasColumnName("cantBaños");

                entity.Property(e => e.CantCocheras).HasColumnName("cantCocheras");

                entity.Property(e => e.CantHabitaciones).HasColumnName("cantHabitaciones");

                entity.Property(e => e.CicloCantidad).HasColumnName("cicloCantidad");

                entity.Property(e => e.CicloDiario).HasColumnName("cicloDiario");

                entity.Property(e => e.CicloMensual).HasColumnName("cicloMensual");

                entity.Property(e => e.CicloSemanal).HasColumnName("cicloSemanal");

                entity.Property(e => e.CountContactados).HasColumnName("countContactados");

                entity.Property(e => e.CountVistas).HasColumnName("countVistas");

                entity.Property(e => e.Descripcion)
                    .HasColumnName("descripcion")
                    .HasMaxLength(500);

                entity.Property(e => e.DirCalle)
                    .HasColumnName("dirCalle")
                    .HasMaxLength(50);

                entity.Property(e => e.DirLatitud)
                    .HasColumnName("dirLatitud")
                    .HasMaxLength(50);

                entity.Property(e => e.DirLocal)
                    .HasColumnName("dirLocal")
                    .HasMaxLength(50);

                entity.Property(e => e.DirLongitud)
                    .HasColumnName("dirLongitud")
                    .HasMaxLength(50);

                entity.Property(e => e.DirPiso)
                    .HasColumnName("dirPiso")
                    .HasMaxLength(50);

                entity.Property(e => e.Expensas)
                    .HasColumnName("expensas")
                    .HasColumnType("decimal(18, 4)");

                entity.Property(e => e.FechaInicio)
                    .HasColumnName("fechaInicio")
                    .HasColumnType("date");

                entity.Property(e => e.FechaVencimiento)
                    .HasColumnName("fechaVencimiento")
                    .HasColumnType("date");

                entity.Property(e => e.IdBarrio).HasColumnName("idBarrio");

                entity.Property(e => e.IdMoneda).HasColumnName("idMoneda");

                entity.Property(e => e.IdPlan).HasColumnName("idPlan");

                entity.Property(e => e.IdTipoPropiedad).HasColumnName("idTipoPropiedad");

                entity.Property(e => e.IdUsuario)
                    .IsRequired()
                    .HasColumnName("idUsuario")
                    .HasMaxLength(32);

                entity.Property(e => e.Impuestos)
                    .HasColumnName("impuestos")
                    .HasColumnType("decimal(18, 4)");

                entity.Property(e => e.Monto)
                    .HasColumnName("monto")
                    .HasColumnType("decimal(18, 4)");

                entity.Property(e => e.PermiteMascotas).HasColumnName("permiteMascotas");

                entity.Property(e => e.PermiteNiños).HasColumnName("permiteNiños");

                entity.Property(e => e.SrvAgua).HasColumnName("srvAgua");

                entity.Property(e => e.SrvElectricidad).HasColumnName("srvElectricidad");

                entity.Property(e => e.SrvGas).HasColumnName("srvGas");

                entity.Property(e => e.SrvInternet).HasColumnName("srvInternet");

                entity.Property(e => e.SrvTelefonico).HasColumnName("srvTelefonico");

            });

            modelBuilder.Entity<PublicacionesPlanes>(entity =>
            {
                entity.HasKey(e => e.IdPlan);

                entity.ToTable("Publicaciones_Planes");

                entity.Property(e => e.IdPlan).HasColumnName("idPlan");

                entity.Property(e => e.Descripcion)
                    .IsRequired()
                    .HasColumnName("descripcion")
                    .HasMaxLength(500);

                entity.Property(e => e.Destacado).HasColumnName("destacado");

                entity.Property(e => e.Dias).HasColumnName("dias");

                entity.Property(e => e.IdMoneda)
                    .IsRequired()
                    .HasColumnName("idMoneda")
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.Monto)
                    .HasColumnName("monto")
                    .HasColumnType("decimal(18, 4)");

                entity.Property(e => e.Nombre)
                    .IsRequired()
                    .HasColumnName("nombre")
                    .HasMaxLength(20);

                entity.Property(e => e.SuperDestacado).HasColumnName("superDestacado");

                entity.Property(e => e.Visibilidad)
                    .IsRequired()
                    .HasColumnName("visibilidad")
                    .HasMaxLength(10);
            });

            modelBuilder.Entity<TiposPropiedades>(entity =>
            {
                entity.HasKey(e => e.IdTipoPropiedad);

                entity.Property(e => e.IdTipoPropiedad).HasColumnName("idTipoPropiedad");

                entity.Property(e => e.TipoPropiedad)
                    .IsRequired()
                    .HasColumnName("tipoPropiedad")
                    .HasMaxLength(50);
            });

            modelBuilder.Entity<Usuarios>(entity =>
            {
                entity.HasKey(e => e.IdUsuario);

                entity.Property(e => e.IdUsuario)
                    .HasColumnName("idUsuario")
                    .HasMaxLength(32);

                entity.Property(e => e.Clave)
                    .IsRequired()
                    .HasColumnName("clave")
                    .HasMaxLength(16);

                entity.Property(e => e.CountMeGusta).HasColumnName("countMeGusta");

                entity.Property(e => e.Descripcion)
                    .HasColumnName("descripcion")
                    .HasMaxLength(500);

                entity.Property(e => e.DirCalle)
                    .HasColumnName("dirCalle")
                    .HasMaxLength(50);

                entity.Property(e => e.DirLatitud)
                    .HasColumnName("dirLatitud")
                    .HasMaxLength(50);

                entity.Property(e => e.DirLocal)
                    .HasColumnName("dirLocal")
                    .HasMaxLength(50);

                entity.Property(e => e.DirLongitud)
                    .HasColumnName("dirLongitud")
                    .HasMaxLength(50);

                entity.Property(e => e.DirPiso)
                    .HasColumnName("dirPiso")
                    .HasMaxLength(50);

                entity.Property(e => e.Documento1)
                    .IsRequired()
                    .HasColumnName("documento1")
                    .HasMaxLength(20);

                entity.Property(e => e.Documento2)
                    .HasColumnName("documento2")
                    .HasMaxLength(20);

                entity.Property(e => e.Documento3)
                    .HasColumnName("documento3")
                    .HasMaxLength(20);

                entity.Property(e => e.Dueño).HasColumnName("dueño");

                entity.Property(e => e.Email)
                    .IsRequired()
                    .HasColumnName("email")
                    .HasMaxLength(50);

                entity.Property(e => e.EmailContacto)
                    .IsRequired()
                    .HasColumnName("emailContacto")
                    .HasMaxLength(50);

                entity.Property(e => e.IdBarrio).HasColumnName("idBarrio");

                entity.Property(e => e.Nombre)
                    .IsRequired()
                    .HasColumnName("nombre")
                    .HasMaxLength(50);

                entity.Property(e => e.Telefono1)
                    .IsRequired()
                    .HasColumnName("telefono1")
                    .HasMaxLength(20);

                entity.Property(e => e.Telefono2)
                    .HasColumnName("telefono2")
                    .HasMaxLength(20);

                entity.Property(e => e.Telefono3)
                    .HasColumnName("telefono3")
                    .HasMaxLength(20);

                entity.Property(e => e.UrlFacebook)
                    .HasColumnName("urlFacebook")
                    .HasMaxLength(500);

                entity.Property(e => e.UrlInstagram)
                    .HasColumnName("urlInstagram")
                    .HasMaxLength(500);

                entity.Property(e => e.Whatsapp)
                    .HasColumnName("whatsapp")
                    .HasMaxLength(20);


            });

            OnModelCreatingPartial(modelBuilder);
        }

        partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
    }
}
