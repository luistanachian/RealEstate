using System;
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

                entity.Property(e => e.IdBarrio)
                    .HasColumnName("idBarrio")
                    .HasMaxLength(7);

                entity.Property(e => e.Barrio)
                    .IsRequired()
                    .HasColumnName("barrio")
                    .HasMaxLength(50);

                entity.Property(e => e.IdLocalidad)
                    .IsRequired()
                    .HasColumnName("idLocalidad")
                    .HasMaxLength(5);

                entity.HasOne(d => d.IdLocalidadNavigation)
                    .WithMany(p => p.DireccionBarrios)
                    .HasForeignKey(d => d.IdLocalidad)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_Direccion_Barrios_Direccion_Localidades");
            });

            modelBuilder.Entity<DireccionEstados>(entity =>
            {
                entity.HasKey(e => e.IdEstado);

                entity.ToTable("Direccion_Estados");

                entity.Property(e => e.IdEstado)
                    .HasColumnName("idEstado")
                    .HasMaxLength(3);

                entity.Property(e => e.Estado)
                    .IsRequired()
                    .HasColumnName("estado")
                    .HasMaxLength(50);
            });

            modelBuilder.Entity<DireccionLocalidades>(entity =>
            {
                entity.HasKey(e => e.IdLocalidad);

                entity.ToTable("Direccion_Localidades");

                entity.Property(e => e.IdLocalidad)
                    .HasColumnName("idLocalidad")
                    .HasMaxLength(5);

                entity.Property(e => e.IdEstado)
                    .IsRequired()
                    .HasColumnName("idEstado")
                    .HasMaxLength(3);

                entity.Property(e => e.Localidad)
                    .IsRequired()
                    .HasColumnName("localidad")
                    .HasMaxLength(50);

                entity.HasOne(d => d.IdEstadoNavigation)
                    .WithMany(p => p.DireccionLocalidades)
                    .HasForeignKey(d => d.IdEstado)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_Direccion_Localidades_Direccion_Estados");
            });

            modelBuilder.Entity<Monedas>(entity =>
            {
                entity.HasKey(e => e.IdMoneda);

                entity.Property(e => e.IdMoneda)
                    .HasColumnName("idMoneda")
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .IsFixedLength();

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

                entity.Property(e => e.IdBarrio)
                    .IsRequired()
                    .HasColumnName("idBarrio")
                    .HasMaxLength(7);

                entity.Property(e => e.IdMoneda)
                    .IsRequired()
                    .HasColumnName("idMoneda")
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.IdPlan)
                    .IsRequired()
                    .HasColumnName("idPlan")
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.IdTipoPropiedad)
                    .IsRequired()
                    .HasColumnName("idTipoPropiedad")
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .IsFixedLength();

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

                entity.HasOne(d => d.IdBarrioNavigation)
                    .WithMany(p => p.Publicaciones)
                    .HasForeignKey(d => d.IdBarrio)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_Publicaciones_Direccion_Barrios");

                entity.HasOne(d => d.IdMonedaNavigation)
                    .WithMany(p => p.Publicaciones)
                    .HasForeignKey(d => d.IdMoneda)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_Publicaciones_Monedas");

                entity.HasOne(d => d.IdPlanNavigation)
                    .WithMany(p => p.Publicaciones)
                    .HasForeignKey(d => d.IdPlan)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_Publicaciones_Publicaciones_Planes");

                entity.HasOne(d => d.IdTipoPropiedadNavigation)
                    .WithMany(p => p.Publicaciones)
                    .HasForeignKey(d => d.IdTipoPropiedad)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_Publicaciones_TiposPropiedades");

                entity.HasOne(d => d.IdUsuarioNavigation)
                    .WithMany(p => p.Publicaciones)
                    .HasForeignKey(d => d.IdUsuario)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_Publicaciones_Usuarios");
            });

            modelBuilder.Entity<PublicacionesPlanes>(entity =>
            {
                entity.HasKey(e => e.IdPlan);

                entity.ToTable("Publicaciones_Planes");

                entity.Property(e => e.IdPlan)
                    .HasColumnName("idPlan")
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .IsFixedLength();

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

                entity.Property(e => e.IdTipoPropiedad)
                    .HasColumnName("idTipoPropiedad")
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .IsFixedLength();

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

                entity.Property(e => e.IdBarrio)
                    .IsRequired()
                    .HasColumnName("idBarrio")
                    .HasMaxLength(7);

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

                entity.HasOne(d => d.IdBarrioNavigation)
                    .WithMany(p => p.Usuarios)
                    .HasForeignKey(d => d.IdBarrio)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_Usuarios_Direccion_Barrios");
            });

            OnModelCreatingPartial(modelBuilder);
        }

        partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
    }
}
