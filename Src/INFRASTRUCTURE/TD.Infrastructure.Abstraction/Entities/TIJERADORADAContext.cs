using System;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata;

namespace TD.Infrastructure.Abstraction.Entities
{
    public partial class TIJERADORADAContext : DbContext
    {
        public TIJERADORADAContext()
        {
        }

        public TIJERADORADAContext(DbContextOptions<TIJERADORADAContext> options)
            : base(options)
        {
        }

        public virtual DbSet<AlmacenDetalleE> AlmacenDetalleEs { get; set; } = null!;
        public virtual DbSet<AlmacenE> AlmacenEs { get; set; } = null!;
        public virtual DbSet<Ausentismo> Ausentismos { get; set; } = null!;
        public virtual DbSet<BitacoraFiscal> BitacoraFiscals { get; set; } = null!;
        public virtual DbSet<BitacoraTempFecha> BitacoraTempFechas { get; set; } = null!;
        public virtual DbSet<BitacoraTempFolio> BitacoraTempFolios { get; set; } = null!;
        public virtual DbSet<CajaChica> CajaChicas { get; set; } = null!;
        public virtual DbSet<CajaChicaAjuste> CajaChicaAjustes { get; set; } = null!;
        public virtual DbSet<CajaChicaAjustesTipo> CajaChicaAjustesTipos { get; set; } = null!;
        public virtual DbSet<CajaChicaCorte> CajaChicaCortes { get; set; } = null!;
        public virtual DbSet<CajaChicaTipoCorte> CajaChicaTipoCortes { get; set; } = null!;
        public virtual DbSet<CajerasXsucursal> CajerasXsucursals { get; set; } = null!;
        public virtual DbSet<CatCiudad> CatCiudads { get; set; } = null!;
        public virtual DbSet<CatCliente> CatClientes { get; set; } = null!;
        public virtual DbSet<CatClientes2> CatClientes2s { get; set; } = null!;
        public virtual DbSet<CatClientesAntesMen> CatClientesAntesMens { get; set; } = null!;
        public virtual DbSet<CatClientesAntesMensPlanet> CatClientesAntesMensPlanets { get; set; } = null!;
        public virtual DbSet<CatClientesAntesPlazaFiestum> CatClientesAntesPlazaFiesta { get; set; } = null!;
        public virtual DbSet<CatClientesHistorico> CatClientesHistoricos { get; set; } = null!;
        public virtual DbSet<CatColonia> CatColonias { get; set; } = null!;
        public virtual DbSet<CatEmpleado> CatEmpleados { get; set; } = null!;
        public virtual DbSet<CatEmpleadosHijo> CatEmpleadosHijos { get; set; } = null!;
        public virtual DbSet<CatEmpleadosStatus> CatEmpleadosStatuses { get; set; } = null!;
        public virtual DbSet<CatEmpleadosTipo> CatEmpleadosTipos { get; set; } = null!;
        public virtual DbSet<CatEncargado> CatEncargados { get; set; } = null!;
        public virtual DbSet<CatFamilia> CatFamilias { get; set; } = null!;
        public virtual DbSet<CatFamiliasTipo> CatFamiliasTipos { get; set; } = null!;
        public virtual DbSet<CatFranquicia> CatFranquicias { get; set; } = null!;
        public virtual DbSet<CatProdServ> CatProdServs { get; set; } = null!;
        public virtual DbSet<CatProdServImagen> CatProdServImagens { get; set; } = null!;
        public virtual DbSet<CatProdServSuc> CatProdServSucs { get; set; } = null!;
        public virtual DbSet<CatProdServSucRespaldo> CatProdServSucRespaldos { get; set; } = null!;
        public virtual DbSet<CatProveedore> CatProveedores { get; set; } = null!;
        public virtual DbSet<CatPuedeAlmacenar> CatPuedeAlmacenars { get; set; } = null!;
        public virtual DbSet<CatPuedeVender> CatPuedeVenders { get; set; } = null!;
        public virtual DbSet<CatSucursale> CatSucursales { get; set; } = null!;
        public virtual DbSet<CatSucursalesXempleado> CatSucursalesXempleados { get; set; } = null!;
        public virtual DbSet<CatTurno> CatTurnos { get; set; } = null!;
        public virtual DbSet<CatTurnosSuc> CatTurnosSucs { get; set; } = null!;
        public virtual DbSet<ChecaFalta> ChecaFaltas { get; set; } = null!;
        public virtual DbSet<ChecaPermiso> ChecaPermisos { get; set; } = null!;
        public virtual DbSet<ChecaRetraso> ChecaRetrasos { get; set; } = null!;
        public virtual DbSet<ChecaTurno> ChecaTurnos { get; set; } = null!;
        public virtual DbSet<CitasxCliente> CitasxClientes { get; set; } = null!;
        public virtual DbSet<ClienteCumpleColonium> ClienteCumpleColonia { get; set; } = null!;
        public virtual DbSet<ClientesFinalDiana> ClientesFinalDianas { get; set; } = null!;
        public virtual DbSet<ClientesJr> ClientesJrs { get; set; } = null!;
        public virtual DbSet<Clientesconcel> Clientesconcels { get; set; } = null!;
        public virtual DbSet<Clientetemporal> Clientetemporals { get; set; } = null!;
        public virtual DbSet<ConceptosFacturado> ConceptosFacturados { get; set; } = null!;
        public virtual DbSet<Configuracion> Configuracions { get; set; } = null!;
        public virtual DbSet<ContactosFacebook> ContactosFacebooks { get; set; } = null!;
        public virtual DbSet<ContratoRecibo> ContratoRecibos { get; set; } = null!;
        public virtual DbSet<Ctevtum> Ctevta { get; set; } = null!;
        public virtual DbSet<Descuento> Descuentos { get; set; } = null!;
        public virtual DbSet<DescuentosEspeciale> DescuentosEspeciales { get; set; } = null!;
        public virtual DbSet<E> Es { get; set; } = null!;
        public virtual DbSet<EncargadosXsucursal> EncargadosXsucursals { get; set; } = null!;
        public virtual DbSet<EnvioSm> EnvioSms { get; set; } = null!;
        public virtual DbSet<EnvioWhatsApp> EnvioWhatsApps { get; set; } = null!;
        public virtual DbSet<Esdetalle> Esdetalles { get; set; } = null!;
        public virtual DbSet<EsdetallesTemp> EsdetallesTemps { get; set; } = null!;
        public virtual DbSet<EstatusCita> EstatusCitas { get; set; } = null!;
        public virtual DbSet<Estemp> Estemps { get; set; } = null!;
        public virtual DbSet<Horario> Horarios { get; set; } = null!;
        public virtual DbSet<HorarioXsucursal> HorarioXsucursals { get; set; } = null!;
        public virtual DbSet<ListaEspera> ListaEsperas { get; set; } = null!;
        public virtual DbSet<ListaEsperaStatus> ListaEsperaStatuses { get; set; } = null!;
        public virtual DbSet<LogConsultasApp> LogConsultasApps { get; set; } = null!;
        public virtual DbSet<LogEnvioWhatsApp> LogEnvioWhatsApps { get; set; } = null!;
        public virtual DbSet<LogEnvioWhatsAppPeluquera> LogEnvioWhatsAppPeluqueras { get; set; } = null!;
        public virtual DbSet<LogSmsenvio> LogSmsenvios { get; set; } = null!;
        public virtual DbSet<Logcpu> Logcpus { get; set; } = null!;
        public virtual DbSet<MinutosParaEnviar> MinutosParaEnviars { get; set; } = null!;
        public virtual DbSet<NoHizoCorte> NoHizoCortes { get; set; } = null!;
        public virtual DbSet<Noticia> Noticias { get; set; } = null!;
        public virtual DbSet<NotificacionesEstatus> NotificacionesEstatuses { get; set; } = null!;
        public virtual DbSet<NotificacionesxToken> NotificacionesxTokens { get; set; } = null!;
        public virtual DbSet<PedidosDetalle> PedidosDetalles { get; set; } = null!;
        public virtual DbSet<PedidosStatus> PedidosStatuses { get; set; } = null!;
        public virtual DbSet<PedidosSucursal> PedidosSucursals { get; set; } = null!;
        public virtual DbSet<PinCliente> PinClientes { get; set; } = null!;
        public virtual DbSet<PrinterDocument> PrinterDocuments { get; set; } = null!;
        public virtual DbSet<PrinterItem> PrinterItems { get; set; } = null!;
        public virtual DbSet<Recargo> Recargos { get; set; } = null!;
        public virtual DbSet<TarjetasAsignada> TarjetasAsignadas { get; set; } = null!;
        public virtual DbSet<TempEnvioWhatsApp> TempEnvioWhatsApps { get; set; } = null!;
        public virtual DbSet<TempPedido> TempPedidos { get; set; } = null!;
        public virtual DbSet<TiempodeEspera> TiempodeEsperas { get; set; } = null!;
        public virtual DbSet<TipoMsg> TipoMsgs { get; set; } = null!;
        public virtual DbSet<TokenxCliente> TokenxClientes { get; set; } = null!;
        public virtual DbSet<UbicacionXsucursal> UbicacionXsucursals { get; set; } = null!;
        public virtual DbSet<UltimoReciboContrato> UltimoReciboContratos { get; set; } = null!;
        public virtual DbSet<Venta> Ventas { get; set; } = null!;
        public virtual DbSet<VentasDetalle> VentasDetalles { get; set; } = null!;
        public virtual DbSet<VentasDetalleFiscal> VentasDetalleFiscals { get; set; } = null!;
        public virtual DbSet<VentasDetalleTemp> VentasDetalleTemps { get; set; } = null!;
        public virtual DbSet<VentasFiscal> VentasFiscals { get; set; } = null!;
        public virtual DbSet<VentasStatus> VentasStatuses { get; set; } = null!;
        public virtual DbSet<VentasTest> VentasTests { get; set; } = null!;
        public virtual DbSet<Ztemporal> Ztemporals { get; set; } = null!;

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (!optionsBuilder.IsConfigured)
            {
#warning To protect potentially sensitive information in your connection string, you should move it out of source code. You can avoid scaffolding the connection string by using the Name= syntax to read it from configuration - see https://go.microsoft.com/fwlink/?linkid=2131148. For more guidance on storing connection strings, see http://go.microsoft.com/fwlink/?LinkId=723263.
                optionsBuilder.UseSqlServer("Data Source=localhost;Initial Catalog=TIJERADORADA;Integrated Security=True");
            }
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<AlmacenDetalleE>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("AlmacenDetalleES");

                entity.Property(e => e.CveEs).HasColumnName("CveES");
            });

            modelBuilder.Entity<AlmacenE>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("AlmacenES");

                entity.Property(e => e.Comentarios)
                    .HasMaxLength(300)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.CveEs).HasColumnName("CveES");

                entity.Property(e => e.Fecha).HasColumnType("datetime");
            });

            modelBuilder.Entity<Ausentismo>(entity =>
            {
                entity.HasNoKey();

                entity.Property(e => e.Fecha).HasColumnType("datetime");
            });

            modelBuilder.Entity<BitacoraFiscal>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("BitacoraFiscal");

                entity.Property(e => e.FechaAnterior).HasColumnType("datetime");

                entity.Property(e => e.FechaEjecucion).HasColumnType("datetime");

                entity.Property(e => e.FechaVentaFin).HasColumnType("datetime");

                entity.Property(e => e.FechaVentaIni).HasColumnType("datetime");

                entity.Property(e => e.ImporteFiscal).HasColumnType("money");

                entity.Property(e => e.ImporteOriginal).HasColumnType("money");

                entity.Property(e => e.Terminado)
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .IsFixedLength();
            });

            modelBuilder.Entity<BitacoraTempFecha>(entity =>
            {
                entity.HasNoKey();

                entity.Property(e => e.Fecha)
                    .HasColumnType("datetime")
                    .HasColumnName("fecha");
            });

            modelBuilder.Entity<BitacoraTempFolio>(entity =>
            {
                entity.HasNoKey();

                entity.Property(e => e.Importe).HasColumnType("money");
            });

            modelBuilder.Entity<CajaChica>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("CajaChica");

                entity.Property(e => e.FechaCambios).HasColumnType("datetime");

                entity.Property(e => e.FechaRegistro).HasColumnType("datetime");

                entity.Property(e => e.ImporteActual).HasColumnType("money");

                entity.Property(e => e.ImporteIdeal).HasColumnType("money");

                entity.Property(e => e.ImporteIni).HasColumnType("money");
            });

            modelBuilder.Entity<CajaChicaAjuste>(entity =>
            {
                entity.HasNoKey();

                entity.Property(e => e.Autorizo)
                    .HasMaxLength(60)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.Comentarios)
                    .HasMaxLength(300)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.Fecha).HasColumnType("datetime");

                entity.Property(e => e.Hora).HasColumnType("datetime");

                entity.Property(e => e.Importe).HasColumnType("money");
            });

            modelBuilder.Entity<CajaChicaAjustesTipo>(entity =>
            {
                entity.HasNoKey();

                entity.Property(e => e.Descripcion)
                    .HasMaxLength(60)
                    .IsUnicode(false)
                    .IsFixedLength();
            });

            modelBuilder.Entity<CajaChicaCorte>(entity =>
            {
                entity.HasNoKey();

                entity.Property(e => e.AjustesEfectivo).HasColumnType("money");

                entity.Property(e => e.AjustesTarjetas).HasColumnType("money");

                entity.Property(e => e.CajaChica).HasColumnType("money");

                entity.Property(e => e.CapitalProductos).HasColumnType("money");

                entity.Property(e => e.CapitalServicios).HasColumnType("money");

                entity.Property(e => e.CapitalTotal).HasColumnType("money");

                entity.Property(e => e.ComprobarEfectivo).HasColumnType("money");

                entity.Property(e => e.ComprobarTarjetas).HasColumnType("money");

                entity.Property(e => e.DifEfectivo).HasColumnType("money");

                entity.Property(e => e.DifTarjetas).HasColumnType("money");

                entity.Property(e => e.Fecha).HasColumnType("datetime");

                entity.Property(e => e.Hora).HasColumnType("datetime");

                entity.Property(e => e.Mp05).HasColumnName("MP05");

                entity.Property(e => e.Mp10).HasColumnName("MP10");

                entity.Property(e => e.Mp20).HasColumnName("MP20");

                entity.Property(e => e.Mp5).HasColumnName("MP5");

                entity.Property(e => e.TotalB).HasColumnType("money");

                entity.Property(e => e.TotalEfectivo).HasColumnType("money");

                entity.Property(e => e.TotalM).HasColumnType("money");

                entity.Property(e => e.TotalTarjetas).HasColumnType("money");

                entity.Property(e => e.VentaEfectivo).HasColumnType("money");

                entity.Property(e => e.VentaTarjetas).HasColumnType("money");
            });

            modelBuilder.Entity<CajaChicaTipoCorte>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("CajaChicaTipoCorte");

                entity.Property(e => e.Nombre)
                    .HasMaxLength(60)
                    .IsUnicode(false)
                    .IsFixedLength();
            });

            modelBuilder.Entity<CajerasXsucursal>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("CajerasXSucursal");

                entity.Property(e => e.Celular)
                    .HasMaxLength(10)
                    .IsUnicode(false)
                    .HasColumnName("CELULAR");

                entity.Property(e => e.EmpleadoId).HasColumnName("EmpleadoID");

                entity.Property(e => e.Id)
                    .ValueGeneratedOnAdd()
                    .HasColumnName("id");

                entity.Property(e => e.SucursalId).HasColumnName("SucursalID");
            });

            modelBuilder.Entity<CatCiudad>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("CatCiudad");

                entity.Property(e => e.Nombre)
                    .HasMaxLength(200)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<CatCliente>(entity =>
            {
                entity.HasNoKey();

                entity.Property(e => e.Apemat)
                    .HasMaxLength(60)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.Apepat)
                    .HasMaxLength(60)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.Email)
                    .HasMaxLength(60)
                    .IsUnicode(false)
                    .HasColumnName("email")
                    .IsFixedLength();

                entity.Property(e => e.FechaRegistro).HasColumnType("datetime");

                entity.Property(e => e.FechaUltVta).HasColumnType("datetime");

                entity.Property(e => e.Nombres)
                    .HasMaxLength(30)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.Telefono)
                    .HasMaxLength(10)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.VentasAcum).HasColumnType("money");
            });

            modelBuilder.Entity<CatClientes2>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("CatClientes2");

                entity.Property(e => e.Apemat)
                    .HasMaxLength(60)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.Apepat)
                    .HasMaxLength(20)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.Email)
                    .HasMaxLength(60)
                    .IsUnicode(false)
                    .HasColumnName("email")
                    .IsFixedLength();

                entity.Property(e => e.FechaRegistro).HasColumnType("datetime");

                entity.Property(e => e.FechaUltVta).HasColumnType("datetime");

                entity.Property(e => e.Nombres)
                    .HasMaxLength(30)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.Telefono)
                    .HasMaxLength(10)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.VentasAcum).HasColumnType("money");
            });

            modelBuilder.Entity<CatClientesAntesMen>(entity =>
            {
                entity.HasNoKey();

                entity.Property(e => e.Apemat)
                    .HasMaxLength(60)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.Apepat)
                    .HasMaxLength(60)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.Email)
                    .HasMaxLength(60)
                    .IsUnicode(false)
                    .HasColumnName("email")
                    .IsFixedLength();

                entity.Property(e => e.FechaRegistro).HasColumnType("datetime");

                entity.Property(e => e.FechaUltVta).HasColumnType("datetime");

                entity.Property(e => e.Nombres)
                    .HasMaxLength(30)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.Telefono)
                    .HasMaxLength(10)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.VentasAcum).HasColumnType("money");
            });

            modelBuilder.Entity<CatClientesAntesMensPlanet>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("CatClientesAntesMensPlanet");

                entity.Property(e => e.Apemat)
                    .HasMaxLength(60)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.Apepat)
                    .HasMaxLength(20)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.Email)
                    .HasMaxLength(60)
                    .IsUnicode(false)
                    .HasColumnName("email")
                    .IsFixedLength();

                entity.Property(e => e.FechaRegistro).HasColumnType("datetime");

                entity.Property(e => e.FechaUltVta).HasColumnType("datetime");

                entity.Property(e => e.Nombres)
                    .HasMaxLength(30)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.Telefono)
                    .HasMaxLength(10)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.VentasAcum).HasColumnType("money");
            });

            modelBuilder.Entity<CatClientesAntesPlazaFiestum>(entity =>
            {
                entity.HasNoKey();

                entity.Property(e => e.Apemat)
                    .HasMaxLength(60)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.Apepat)
                    .HasMaxLength(20)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.Email)
                    .HasMaxLength(60)
                    .IsUnicode(false)
                    .HasColumnName("email")
                    .IsFixedLength();

                entity.Property(e => e.FechaRegistro).HasColumnType("datetime");

                entity.Property(e => e.FechaUltVta).HasColumnType("datetime");

                entity.Property(e => e.Nombres)
                    .HasMaxLength(30)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.Telefono)
                    .HasMaxLength(10)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.VentasAcum).HasColumnType("money");
            });

            modelBuilder.Entity<CatClientesHistorico>(entity =>
            {
                entity.HasNoKey();

                entity.Property(e => e.Apemat)
                    .HasMaxLength(60)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.Apepat)
                    .HasMaxLength(20)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.Email)
                    .HasMaxLength(60)
                    .IsUnicode(false)
                    .HasColumnName("email")
                    .IsFixedLength();

                entity.Property(e => e.FechaRegistro).HasColumnType("datetime");

                entity.Property(e => e.FechaUltVta).HasColumnType("datetime");

                entity.Property(e => e.Nombres)
                    .HasMaxLength(30)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.Telefono)
                    .HasMaxLength(10)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.VentasAcum).HasColumnType("money");
            });

            modelBuilder.Entity<CatColonia>(entity =>
            {
                entity.HasNoKey();

                entity.Property(e => e.Nombre)
                    .HasMaxLength(60)
                    .IsUnicode(false)
                    .IsFixedLength();
            });

            modelBuilder.Entity<CatEmpleado>(entity =>
            {
                entity.HasKey(e => e.CveEmpleado)
                    .HasName("PK__CatEmple__5CC2E01F0C9D7AEB");

                entity.Property(e => e.CveEmpleado).ValueGeneratedNever();

                entity.Property(e => e.Alias)
                    .HasMaxLength(20)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.CtaBancaria)
                    .HasMaxLength(20)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.Curp)
                    .HasMaxLength(20)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.DiaDescanso)
                    .HasMaxLength(10)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.Direccion)
                    .HasMaxLength(60)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.Disponibilidad)
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.Email)
                    .HasMaxLength(60)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.EsEmpleadoActual)
                    .HasColumnName("esEmpleadoActual")
                    .HasDefaultValueSql("((1))");

                entity.Property(e => e.FechaIngreso).HasColumnType("datetime");

                entity.Property(e => e.FechaNac).HasColumnType("datetime");

                entity.Property(e => e.Nombre)
                    .HasMaxLength(60)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.Password)
                    .HasMaxLength(10)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.Rfc)
                    .HasMaxLength(15)
                    .IsUnicode(false)
                    .HasColumnName("RFC")
                    .IsFixedLength();

                entity.Property(e => e.SeguroSocial)
                    .HasMaxLength(15)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.Telefono)
                    .HasMaxLength(10)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.Telefono2)
                    .HasMaxLength(10)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.Usuario)
                    .HasMaxLength(10)
                    .IsUnicode(false)
                    .IsFixedLength();
            });

            modelBuilder.Entity<CatEmpleadosHijo>(entity =>
            {
                entity.HasNoKey();

                entity.Property(e => e.CveHijo)
                    .HasMaxLength(10)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.Guarderia)
                    .HasMaxLength(60)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.Hijo)
                    .HasMaxLength(60)
                    .IsUnicode(false)
                    .IsFixedLength();
            });

            modelBuilder.Entity<CatEmpleadosStatus>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("CatEmpleadosStatus");

                entity.Property(e => e.Descripcion)
                    .HasMaxLength(30)
                    .IsUnicode(false)
                    .IsFixedLength();
            });

            modelBuilder.Entity<CatEmpleadosTipo>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("CatEmpleadosTipo");

                entity.Property(e => e.Descripcion)
                    .HasMaxLength(30)
                    .IsUnicode(false)
                    .IsFixedLength();
            });

            modelBuilder.Entity<CatEncargado>(entity =>
            {
                entity.Property(e => e.Id).HasColumnName("id");

                entity.Property(e => e.EstaActivo).HasColumnName("estaActivo");

                entity.Property(e => e.Nombre)
                    .HasMaxLength(100)
                    .IsUnicode(false)
                    .HasColumnName("nombre");

                entity.Property(e => e.Telefono)
                    .HasMaxLength(10)
                    .IsUnicode(false)
                    .HasColumnName("telefono");
            });

            modelBuilder.Entity<CatFamilia>(entity =>
            {
                entity.HasKey(e => e.CveFamilia)
                    .HasName("PK__CatFamil__F972F2BDB05BC87E");

                entity.Property(e => e.CveFamilia).ValueGeneratedNever();

                entity.Property(e => e.Descripcion)
                    .HasMaxLength(60)
                    .IsUnicode(false)
                    .IsFixedLength();
            });

            modelBuilder.Entity<CatFamiliasTipo>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("CatFamiliasTipo");

                entity.Property(e => e.Nombre)
                    .HasMaxLength(60)
                    .IsUnicode(false)
                    .IsFixedLength();
            });

            modelBuilder.Entity<CatFranquicia>(entity =>
            {
                entity.HasKey(e => e.CveFranquicia)
                    .HasName("PK__CatFranq__55833CC8F7909219");

                entity.Property(e => e.CveFranquicia).ValueGeneratedNever();

                entity.Property(e => e.Descripcion)
                    .HasMaxLength(60)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.FechaCreacion).HasColumnType("datetime");

                entity.Property(e => e.UsuarioCreador)
                    .HasMaxLength(60)
                    .IsUnicode(false)
                    .IsFixedLength();
            });

            modelBuilder.Entity<CatProdServ>(entity =>
            {
                entity.HasKey(e => e.CveProdServ)
                    .IsClustered(false);

                entity.ToTable("CatProdServ");

                entity.Property(e => e.CveProdServ).ValueGeneratedNever();

                entity.Property(e => e.Descripcion)
                    .HasMaxLength(60)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.FechaExistenciaIni).HasColumnType("datetime");

                entity.Property(e => e.FechaUltComp).HasColumnType("datetime");

                entity.Property(e => e.FechaUltVta).HasColumnType("datetime");

                entity.Property(e => e.NombreCorto)
                    .HasMaxLength(5)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.Precio).HasColumnType("money");
            });

            modelBuilder.Entity<CatProdServImagen>(entity =>
            {
                entity.HasKey(e => e.CveProdServ);

                entity.ToTable("CatProdServImagen");

                entity.Property(e => e.CveProdServ).ValueGeneratedNever();

                entity.Property(e => e.RutaImagen)
                    .HasMaxLength(5000)
                    .IsUnicode(false)
                    .HasColumnName("rutaImagen");

                entity.HasOne(d => d.CveProdServNavigation)
                    .WithOne(p => p.CatProdServImagen)
                    .HasForeignKey<CatProdServImagen>(d => d.CveProdServ)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_CatProdServImagen_CatProdServImagen");
            });

            modelBuilder.Entity<CatProdServSuc>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("CatProdServSuc");

                entity.Property(e => e.FechaExistenciaIni).HasColumnType("datetime");

                entity.Property(e => e.FechaUltComp).HasColumnType("datetime");

                entity.Property(e => e.FechaUltVta).HasColumnType("datetime");
            });

            modelBuilder.Entity<CatProdServSucRespaldo>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("CatProdServSucRespaldo");

                entity.Property(e => e.FechaExistenciaIni).HasColumnType("datetime");

                entity.Property(e => e.FechaUltComp).HasColumnType("datetime");

                entity.Property(e => e.FechaUltVta).HasColumnType("datetime");
            });

            modelBuilder.Entity<CatProveedore>(entity =>
            {
                entity.HasNoKey();

                entity.Property(e => e.Contacto)
                    .HasMaxLength(60)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.Nombre)
                    .HasMaxLength(60)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.Telefono)
                    .HasMaxLength(60)
                    .IsUnicode(false)
                    .IsFixedLength();
            });

            modelBuilder.Entity<CatPuedeAlmacenar>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("CatPuedeAlmacenar");
            });

            modelBuilder.Entity<CatPuedeVender>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("CatPuedeVender");
            });

            modelBuilder.Entity<CatSucursale>(entity =>
            {
                entity.HasKey(e => e.CveSucursal)
                    .HasName("PK__CatSucur__A8BEA9C5E663CF0C");

                entity.Property(e => e.CveSucursal).ValueGeneratedNever();

                entity.Property(e => e.Descripcion)
                    .HasMaxLength(60)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.Direccion)
                    .HasMaxLength(60)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.HoraEntrada).HasColumnType("datetime");

                entity.Property(e => e.RazonSocial)
                    .HasMaxLength(70)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.Rfc)
                    .HasMaxLength(15)
                    .IsUnicode(false)
                    .HasColumnName("RFC")
                    .IsFixedLength();

                entity.Property(e => e.Telefono)
                    .HasMaxLength(10)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.HasOne(d => d.CveFranquiciaNavigation)
                    .WithMany(p => p.CatSucursales)
                    .HasForeignKey(d => d.CveFranquicia)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK__CatSucurs__CveFr__6E8B6712");
            });

            modelBuilder.Entity<CatSucursalesXempleado>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("CatSucursalesXEmpleado");
            });

            modelBuilder.Entity<CatTurno>(entity =>
            {
                entity.HasNoKey();

                entity.Property(e => e.Afecta)
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.HoraFin).HasColumnType("datetime");

                entity.Property(e => e.HoraIni).HasColumnType("datetime");

                entity.Property(e => e.Nombre)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .IsFixedLength();
            });

            modelBuilder.Entity<CatTurnosSuc>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("CatTurnosSuc");
            });

            modelBuilder.Entity<ChecaFalta>(entity =>
            {
                entity.HasNoKey();

                entity.Property(e => e.Fecha).HasColumnType("datetime");
            });

            modelBuilder.Entity<ChecaPermiso>(entity =>
            {
                entity.HasNoKey();

                entity.Property(e => e.Aurotizo)
                    .HasMaxLength(60)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.Comentarios)
                    .HasMaxLength(200)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.FechaFin).HasColumnType("datetime");

                entity.Property(e => e.FechaIni).HasColumnType("datetime");

                entity.Property(e => e.HoraFin).HasColumnType("datetime");

                entity.Property(e => e.HoraIni).HasColumnType("datetime");
            });

            modelBuilder.Entity<ChecaRetraso>(entity =>
            {
                entity.HasNoKey();

                entity.Property(e => e.Fecha).HasColumnType("datetime");

                entity.Property(e => e.Hora).HasColumnType("datetime");
            });

            modelBuilder.Entity<ChecaTurno>(entity =>
            {
                entity.HasNoKey();

                entity.Property(e => e.Es)
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .HasColumnName("ES")
                    .IsFixedLength();

                entity.Property(e => e.Fecha).HasColumnType("datetime");

                entity.Property(e => e.Hora).HasColumnType("datetime");

                entity.Property(e => e.Permiso)
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .IsFixedLength();
            });

            modelBuilder.Entity<CitasxCliente>(entity =>
            {
                entity.HasKey(e => e.CitaId);

                entity.ToTable("CitasxCliente");

                entity.Property(e => e.CitaId).HasColumnName("CitaID");

                entity.Property(e => e.ClienteId).HasColumnName("ClienteID");

                entity.Property(e => e.EmpleadoId)
                    .HasColumnName("EmpleadoID")
                    .HasDefaultValueSql("((0))");

                entity.Property(e => e.EstatusCitaId).HasColumnName("EstatusCitaID");

                entity.Property(e => e.Fecha).HasColumnType("datetime");

                entity.Property(e => e.FechaConfirmacion)
                    .HasColumnType("datetime")
                    .HasColumnName("fechaConfirmacion");

                entity.Property(e => e.FechaCreacion)
                    .HasColumnType("datetime")
                    .HasColumnName("fechaCreacion")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.FechaModificacion)
                    .HasColumnType("datetime")
                    .HasColumnName("fechaModificacion");

                entity.Property(e => e.SucursalId).HasColumnName("SucursalID");
            });

            modelBuilder.Entity<ClienteCumpleColonium>(entity =>
            {
                entity.HasKey(e => e.ClienteId)
                    .HasName("PK__ClienteC__71ABD0A740058253");

                entity.Property(e => e.ClienteId)
                    .ValueGeneratedNever()
                    .HasColumnName("ClienteID");

                entity.Property(e => e.CodigoPostal)
                    .HasMaxLength(5)
                    .IsUnicode(false);

                entity.Property(e => e.Colonia)
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.FechaNacimiento).HasColumnType("date");

                entity.Property(e => e.Latitud)
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.Longitud)
                    .HasMaxLength(20)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<ClientesFinalDiana>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("ClientesFinalDiana");

                entity.Property(e => e.Apemat).HasMaxLength(255);

                entity.Property(e => e.Apepat).HasMaxLength(255);

                entity.Property(e => e.DirCli).HasMaxLength(255);

                entity.Property(e => e.NomCli).HasMaxLength(255);

                entity.Property(e => e.Nombres).HasMaxLength(255);
            });

            modelBuilder.Entity<ClientesJr>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("ClientesJR");

                entity.Property(e => e.Apemat)
                    .HasMaxLength(60)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.Apepat)
                    .HasMaxLength(60)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.Email)
                    .HasMaxLength(60)
                    .IsUnicode(false)
                    .HasColumnName("email")
                    .IsFixedLength();

                entity.Property(e => e.FecUltEnv).HasColumnType("datetime");

                entity.Property(e => e.FecUltVta).HasColumnType("datetime");

                entity.Property(e => e.FechaRegistro).HasColumnType("datetime");

                entity.Property(e => e.FechaUltVta).HasColumnType("datetime");

                entity.Property(e => e.Nombres)
                    .HasMaxLength(30)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.Telefono)
                    .HasMaxLength(10)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.VentasAcum).HasColumnType("money");
            });

            modelBuilder.Entity<Clientesconcel>(entity =>
            {
                entity.ToTable("clientesconcel");

                entity.Property(e => e.Id).HasColumnName("id");

                entity.Property(e => e.ApeMat)
                    .HasMaxLength(60)
                    .IsUnicode(false);

                entity.Property(e => e.ApePat)
                    .HasMaxLength(60)
                    .IsUnicode(false);

                entity.Property(e => e.Celular)
                    .HasMaxLength(10)
                    .IsUnicode(false);

                entity.Property(e => e.FechaRegistro).HasColumnType("datetime");

                entity.Property(e => e.Nombre)
                    .HasMaxLength(30)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<Clientetemporal>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("clientetemporal");

                entity.Property(e => e.Idviejo).HasColumnName("idviejo");
            });

            modelBuilder.Entity<ConceptosFacturado>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("conceptosFacturados");

                entity.Property(e => e.ImporteFacturacion).HasColumnName("importeFacturacion");

                entity.Property(e => e.ReciboId).HasColumnName("ReciboID");
            });

            modelBuilder.Entity<Configuracion>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("Configuracion");

                entity.Property(e => e.Email)
                    .HasMaxLength(60)
                    .IsUnicode(false)
                    .HasColumnName("email")
                    .IsFixedLength();

                entity.Property(e => e.Nombre)
                    .HasMaxLength(60)
                    .IsUnicode(false)
                    .IsFixedLength();
            });

            modelBuilder.Entity<ContactosFacebook>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("ContactosFacebook");

                entity.Property(e => e.Celular)
                    .HasMaxLength(10)
                    .IsUnicode(false)
                    .HasColumnName("celular");

                entity.Property(e => e.Nombre)
                    .HasMaxLength(60)
                    .IsUnicode(false)
                    .HasColumnName("nombre");
            });

            modelBuilder.Entity<ContratoRecibo>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("contratoRecibo");

                entity.Property(e => e.ContratoId).HasColumnName("contratoID");

                entity.Property(e => e.FechaRecibo)
                    .HasColumnType("date")
                    .HasColumnName("fechaRecibo");

                entity.Property(e => e.ImporteFacturacion).HasColumnName("importeFacturacion");

                entity.Property(e => e.Recargos).HasColumnName("recargos");

                entity.Property(e => e.ReciboId).HasColumnName("ReciboID");
            });

            modelBuilder.Entity<Ctevtum>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("ctevta");

                entity.Property(e => e.Celular)
                    .HasMaxLength(10)
                    .IsUnicode(false)
                    .HasColumnName("celular");

                entity.Property(e => e.Cvecliente).HasColumnName("cvecliente");

                entity.Property(e => e.Fecha).HasColumnType("datetime");

                entity.Property(e => e.Hora).HasColumnType("datetime");

                entity.Property(e => e.Nombre)
                    .HasMaxLength(30)
                    .IsUnicode(false);

                entity.Property(e => e.Total).HasColumnType("money");
            });

            modelBuilder.Entity<Descuento>(entity =>
            {
                entity.HasNoKey();

                entity.Property(e => e.Descuento1).HasColumnName("Descuento");

                entity.Property(e => e.FechaFin).HasColumnType("datetime");

                entity.Property(e => e.FechaIni).HasColumnType("datetime");

                entity.Property(e => e.Horafin)
                    .HasColumnType("datetime")
                    .HasColumnName("horafin");

                entity.Property(e => e.Horaini)
                    .HasColumnType("datetime")
                    .HasColumnName("horaini");
            });

            modelBuilder.Entity<DescuentosEspeciale>(entity =>
            {
                entity.HasNoKey();
            });

            modelBuilder.Entity<E>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("ES");

                entity.Property(e => e.Comentarios)
                    .HasMaxLength(500)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.CveEs).HasColumnName("CveES");

                entity.Property(e => e.Factura)
                    .HasMaxLength(10)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.Fecha).HasColumnType("datetime");

                entity.Property(e => e.Tipo)
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .IsFixedLength();
            });

            modelBuilder.Entity<EncargadosXsucursal>(entity =>
            {
                entity.ToTable("EncargadosXSucursal");

                entity.Property(e => e.Id).HasColumnName("id");

                entity.Property(e => e.EncargadoId).HasColumnName("encargadoId");

                entity.Property(e => e.EstaActivo).HasColumnName("estaActivo");

                entity.Property(e => e.SucursalId).HasColumnName("sucursalId");

                entity.HasOne(d => d.Encargado)
                    .WithMany(p => p.EncargadosXsucursals)
                    .HasForeignKey(d => d.EncargadoId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_EncargadosXSucursal_CatEncargados");
            });

            modelBuilder.Entity<EnvioSm>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("EnvioSMS");

                entity.Property(e => e.Apemat)
                    .HasMaxLength(60)
                    .IsUnicode(false)
                    .HasColumnName("APEMAT");

                entity.Property(e => e.Apepat)
                    .HasMaxLength(60)
                    .IsUnicode(false)
                    .HasColumnName("APEPAT");

                entity.Property(e => e.Celular)
                    .HasMaxLength(10)
                    .IsUnicode(false)
                    .HasColumnName("CELULAR")
                    .IsFixedLength();

                entity.Property(e => e.Correo)
                    .HasMaxLength(60)
                    .IsUnicode(false)
                    .HasColumnName("CORREO");

                entity.Property(e => e.FecUltVta).HasColumnType("datetime");

                entity.Property(e => e.Id)
                    .ValueGeneratedOnAdd()
                    .HasColumnName("ID");

                entity.Property(e => e.Msg)
                    .HasMaxLength(160)
                    .IsUnicode(false)
                    .HasColumnName("MSG");

                entity.Property(e => e.Nombre)
                    .HasMaxLength(30)
                    .IsUnicode(false)
                    .HasColumnName("NOMBRE");

                entity.Property(e => e.Servicios).HasColumnName("SERVICIOS");
            });

            modelBuilder.Entity<EnvioWhatsApp>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("EnvioWhatsApp");

                entity.Property(e => e.Apemat)
                    .HasMaxLength(60)
                    .IsUnicode(false)
                    .HasColumnName("APEMAT");

                entity.Property(e => e.Apepat)
                    .HasMaxLength(60)
                    .IsUnicode(false)
                    .HasColumnName("APEPAT");

                entity.Property(e => e.Celular)
                    .HasMaxLength(10)
                    .IsUnicode(false)
                    .HasColumnName("CELULAR")
                    .IsFixedLength();

                entity.Property(e => e.Correo)
                    .HasMaxLength(60)
                    .IsUnicode(false)
                    .HasColumnName("CORREO");

                entity.Property(e => e.FecUltVta).HasColumnType("datetime");

                entity.Property(e => e.FechaEnvio).HasColumnType("datetime");

                entity.Property(e => e.Id)
                    .ValueGeneratedOnAdd()
                    .HasColumnName("ID");

                entity.Property(e => e.Msg)
                    .HasMaxLength(600)
                    .IsUnicode(false)
                    .HasColumnName("MSG");

                entity.Property(e => e.Nombre)
                    .HasMaxLength(30)
                    .IsUnicode(false)
                    .HasColumnName("NOMBRE");

                entity.Property(e => e.Servicios).HasColumnName("SERVICIOS");
            });

            modelBuilder.Entity<Esdetalle>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("ESDetalles");

                entity.Property(e => e.CveEs).HasColumnName("CveES");
            });

            modelBuilder.Entity<EsdetallesTemp>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("ESDetallesTemp");

                entity.Property(e => e.CveEs).HasColumnName("CveES");
            });

            modelBuilder.Entity<EstatusCita>(entity =>
            {
                entity.Property(e => e.EstatusCitaId).HasColumnName("EstatusCitaID");

                entity.Property(e => e.Descripcion).HasMaxLength(30);
            });

            modelBuilder.Entity<Estemp>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("ESTemp");

                entity.Property(e => e.Comentarios)
                    .HasMaxLength(500)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.CveEs).HasColumnName("CveES");

                entity.Property(e => e.Factura)
                    .HasMaxLength(10)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.Fecha).HasColumnType("datetime");

                entity.Property(e => e.Tipo)
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .IsFixedLength();
            });

            modelBuilder.Entity<Horario>(entity =>
            {
                entity.HasNoKey();

                entity.Property(e => e.EmpleadoId).HasColumnName("EmpleadoID");

                entity.Property(e => e.Fecha).HasColumnType("date");

                entity.Property(e => e.HorarioId)
                    .ValueGeneratedOnAdd()
                    .HasColumnName("HorarioID");

                entity.Property(e => e.SucursalId).HasColumnName("SucursalID");
            });

            modelBuilder.Entity<HorarioXsucursal>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("HorarioXSucursal");

                entity.Property(e => e.SucursalId).HasColumnName("SucursalID");
            });

            modelBuilder.Entity<ListaEspera>(entity =>
            {
                entity.HasKey(e => new { e.CveSucursal, e.CveListaEspera });

                entity.ToTable("ListaEspera");

                entity.Property(e => e.Fecha).HasColumnType("datetime");

                entity.Property(e => e.Hora).HasColumnType("datetime");

                entity.HasOne(d => d.CveSucursalNavigation)
                    .WithMany(p => p.ListaEsperas)
                    .HasForeignKey(d => d.CveSucursal)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK__ListaEspe__CveSu__6F7F8B4B");
            });

            modelBuilder.Entity<ListaEsperaStatus>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("ListaEsperaStatus");

                entity.Property(e => e.Decripcion)
                    .HasMaxLength(20)
                    .IsUnicode(false)
                    .IsFixedLength();
            });

            modelBuilder.Entity<LogConsultasApp>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("LogConsultasAPP");

                entity.Property(e => e.Celular)
                    .HasMaxLength(10)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.ClienteId).HasColumnName("ClienteID");

                entity.Property(e => e.FechaConsulta).HasColumnType("datetime");

                entity.Property(e => e.Latitud).HasMaxLength(20);

                entity.Property(e => e.Longitud).HasMaxLength(20);
            });

            modelBuilder.Entity<LogEnvioWhatsApp>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("LogEnvioWhatsApp");

                entity.Property(e => e.EstatusId).HasColumnName("EstatusID");

                entity.Property(e => e.FechaEnvio).HasColumnType("datetime");

                entity.Property(e => e.FechaRegistro).HasColumnType("datetime");

                entity.Property(e => e.TipoMsgId).HasColumnName("TipoMsgID");

                entity.Property(e => e.VentaId).HasColumnName("VentaID");
            });

            modelBuilder.Entity<LogEnvioWhatsAppPeluquera>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("LogEnvioWhatsAppPeluquera");

                entity.Property(e => e.EmpleadoId).HasColumnName("EmpleadoID");

                entity.Property(e => e.EstatusId).HasColumnName("EstatusID");

                entity.Property(e => e.FechaEnvio).HasColumnType("datetime");

                entity.Property(e => e.FechaRegistro).HasColumnType("datetime");

                entity.Property(e => e.OrigenId).HasColumnName("OrigenID");

                entity.Property(e => e.TipoMsgId).HasColumnName("TipoMsgID");
            });

            modelBuilder.Entity<LogSmsenvio>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("LogSMSEnvios");

                entity.Property(e => e.Custom)
                    .HasMaxLength(120)
                    .HasColumnName("custom");

                entity.Property(e => e.DlrDate)
                    .HasColumnType("datetime")
                    .HasColumnName("dlr_date");

                entity.Property(e => e.Fecha)
                    .HasColumnType("datetime")
                    .HasColumnName("fecha");

                entity.Property(e => e.From)
                    .HasMaxLength(60)
                    .HasColumnName("from");

                entity.Property(e => e.SmsDate)
                    .HasColumnType("datetime")
                    .HasColumnName("sms_date");

                entity.Property(e => e.SmsId)
                    .HasMaxLength(40)
                    .HasColumnName("sms_id");

                entity.Property(e => e.Status)
                    .HasMaxLength(10)
                    .HasColumnName("status");

                entity.Property(e => e.To)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("to");
            });

            modelBuilder.Entity<Logcpu>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("LOGCPU");

                entity.Property(e => e.Imei)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("IMEI");

                entity.Property(e => e.Info)
                    .IsUnicode(false)
                    .HasColumnName("INFO");
            });

            modelBuilder.Entity<MinutosParaEnviar>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("MinutosParaEnviar");

                entity.Property(e => e.Minutos).HasColumnName("MINUTOS");
            });

            modelBuilder.Entity<NoHizoCorte>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("NoHizoCorte");

                entity.Property(e => e.Fecha).HasColumnType("datetime");
            });

            modelBuilder.Entity<Noticia>(entity =>
            {
                entity.HasNoKey();

                entity.Property(e => e.Abstract)
                    .HasMaxLength(300)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.Archivo)
                    .HasMaxLength(200)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.Articulo)
                    .HasMaxLength(8000)
                    .IsUnicode(false);

                entity.Property(e => e.Fecha).HasColumnType("datetime");

                entity.Property(e => e.FechaCambios).HasColumnType("datetime");

                entity.Property(e => e.Imagen)
                    .HasMaxLength(200)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.Titulo)
                    .HasMaxLength(60)
                    .IsUnicode(false)
                    .IsFixedLength();
            });

            modelBuilder.Entity<NotificacionesEstatus>(entity =>
            {
                entity.HasKey(e => e.EstatusId)
                    .HasName("PK__Notifica__DE10F58D7EF6D905");

                entity.ToTable("NotificacionesEstatus");

                entity.Property(e => e.Descripcion)
                    .HasMaxLength(255)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<NotificacionesxToken>(entity =>
            {
                entity.HasKey(e => e.NotificationId)
                    .HasName("PK__Notifica__20CF2E1216CE6296");

                entity.ToTable("NotificacionesxToken");

                entity.Property(e => e.Descriptions)
                    .HasMaxLength(255)
                    .IsUnicode(false);

                entity.Property(e => e.FechaEnvio).HasColumnType("datetime");

                entity.Property(e => e.FechaLeido).HasColumnType("datetime");

                entity.Property(e => e.NameAlert)
                    .HasMaxLength(255)
                    .IsUnicode(false);

                entity.Property(e => e.Screen)
                    .HasMaxLength(255)
                    .IsUnicode(false);

                entity.Property(e => e.TipoMsgId).HasColumnName("TipoMsgID");

                entity.Property(e => e.Title)
                    .HasMaxLength(255)
                    .IsUnicode(false)
                    .HasColumnName("title");

                entity.HasOne(d => d.Estatus)
                    .WithMany(p => p.NotificacionesxTokens)
                    .HasForeignKey(d => d.EstatusId)
                    .HasConstraintName("FK__Notificac__Estat__18B6AB08");

                entity.HasOne(d => d.TipoMsg)
                    .WithMany(p => p.NotificacionesxTokens)
                    .HasForeignKey(d => d.TipoMsgId)
                    .HasConstraintName("FK__Notificac__TipoM__19AACF41");

                entity.HasOne(d => d.Token)
                    .WithMany(p => p.NotificacionesxTokens)
                    .HasForeignKey(d => d.TokenId)
                    .HasConstraintName("FK__Notificac__Token__1A9EF37A");
            });

            modelBuilder.Entity<PedidosDetalle>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("PedidosDetalle");
            });

            modelBuilder.Entity<PedidosStatus>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("PedidosStatus");

                entity.Property(e => e.Descripcion)
                    .HasMaxLength(30)
                    .IsUnicode(false)
                    .IsFixedLength();
            });

            modelBuilder.Entity<PedidosSucursal>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("PedidosSucursal");

                entity.Property(e => e.Fecha).HasColumnType("datetime");
            });

            modelBuilder.Entity<PinCliente>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("pinCliente");

                entity.Property(e => e.CantidadPin).HasColumnName("cantidadPin");

                entity.Property(e => e.Celular)
                    .HasMaxLength(30)
                    .IsUnicode(false)
                    .HasColumnName("celular");

                entity.Property(e => e.FechaUltimoEnvio)
                    .HasColumnType("datetime")
                    .HasColumnName("fechaUltimoEnvio");

                entity.Property(e => e.PinActual).HasColumnName("pinActual");

                entity.Property(e => e.PinAnterior).HasColumnName("pinAnterior");
            });

            modelBuilder.Entity<PrinterDocument>(entity =>
            {
                entity.ToTable("PrinterDocument");

                entity.Property(e => e.Id).ValueGeneratedNever();
            });

            modelBuilder.Entity<PrinterItem>(entity =>
            {
                entity.Property(e => e.Id).ValueGeneratedNever();

                entity.Property(e => e.Address).HasMaxLength(30);
            });

            modelBuilder.Entity<Recargo>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("recargos");

                entity.Property(e => e.Recargos).HasColumnName("recargos");

                entity.Property(e => e.ReciboId).HasColumnName("ReciboID");
            });

            modelBuilder.Entity<TarjetasAsignada>(entity =>
            {
                entity.HasKey(e => e.TarjetasAsignadasId)
                    .HasName("PK_tarjetasAsignadasID")
                    .IsClustered(false);

                entity.ToTable("tarjetasAsignadas");

                entity.HasIndex(e => e.Foliotarjeta, "Idx_FolioTarjeta");

                entity.Property(e => e.TarjetasAsignadasId).HasColumnName("tarjetasAsignadasID");

                entity.Property(e => e.CveCliente).HasColumnName("cveCliente");

                entity.Property(e => e.CveEmpleadoRegistro).HasColumnName("cveEmpleadoRegistro");

                entity.Property(e => e.EstaActivo).HasColumnName("estaActivo");

                entity.Property(e => e.FechaRegistro)
                    .HasColumnType("datetime")
                    .HasColumnName("fechaRegistro");

                entity.Property(e => e.Foliotarjeta)
                    .HasMaxLength(90)
                    .HasColumnName("foliotarjeta");
            });

            modelBuilder.Entity<TempEnvioWhatsApp>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("TempEnvioWhatsApp");

                entity.Property(e => e.ApeidoMaterno)
                    .HasMaxLength(60)
                    .IsUnicode(false);

                entity.Property(e => e.ApeidoPaterno)
                    .HasMaxLength(60)
                    .IsUnicode(false);

                entity.Property(e => e.Celular)
                    .HasMaxLength(10)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.Correo)
                    .HasMaxLength(60)
                    .IsUnicode(false)
                    .HasColumnName("CORREO");

                entity.Property(e => e.FecUltVta).HasColumnType("datetime");

                entity.Property(e => e.FechaEnvio).HasColumnType("datetime");

                entity.Property(e => e.Id).HasColumnName("ID");

                entity.Property(e => e.Msg)
                    .IsUnicode(false)
                    .HasColumnName("MSG");

                entity.Property(e => e.Nombres)
                    .HasMaxLength(30)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<TempPedido>(entity =>
            {
                entity.HasNoKey();
            });

            modelBuilder.Entity<TiempodeEspera>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("TiempodeEspera");

                entity.Property(e => e.Fecha).HasColumnType("datetime");
            });

            modelBuilder.Entity<TipoMsg>(entity =>
            {
                entity.ToTable("TipoMSG");

                entity.Property(e => e.TipoMsgId).HasColumnName("TipoMsgID");

                entity.Property(e => e.Descripcion).HasMaxLength(20);
            });

            modelBuilder.Entity<TokenxCliente>(entity =>
            {
                entity.HasKey(e => e.TokenId)
                    .HasName("PK__TokenxCl__658FEEEA503BEA1C");

                entity.ToTable("TokenxCliente");

                entity.Property(e => e.Activo).HasColumnName("activo");

                entity.Property(e => e.ClienteId)
                    .HasMaxLength(255)
                    .IsUnicode(false)
                    .HasColumnName("ClienteID");

                entity.Property(e => e.TokenFireB)
                    .HasMaxLength(255)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<UbicacionXsucursal>(entity =>
            {
                entity.HasKey(e => e.SucursalId);

                entity.ToTable("UbicacionXSucursal");

                entity.Property(e => e.SucursalId)
                    .ValueGeneratedNever()
                    .HasColumnName("SucursalID");

                entity.Property(e => e.Latitud).HasColumnType("decimal(10, 7)");

                entity.Property(e => e.Longitud).HasColumnType("decimal(10, 7)");
            });

            modelBuilder.Entity<UltimoReciboContrato>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("ultimoReciboContrato");

                entity.Property(e => e.ContratoId).HasColumnName("contratoID");

                entity.Property(e => e.ReciboId).HasColumnName("ReciboID");
            });

            modelBuilder.Entity<Venta>(entity =>
            {
                entity.HasKey(e => new { e.CveSucursal, e.CveVenta, e.Id });

                entity.Property(e => e.Id)
                    .ValueGeneratedOnAdd()
                    .HasColumnName("ID");

                entity.Property(e => e.Cambio).HasColumnType("money");

                entity.Property(e => e.CveStatusVenta)
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.Descuento).HasColumnType("money");

                entity.Property(e => e.Fecha).HasColumnType("datetime");

                entity.Property(e => e.Hora).HasColumnType("datetime");

                entity.Property(e => e.HoraCancelacion).HasColumnType("datetime");

                entity.Property(e => e.Iva)
                    .HasColumnType("money")
                    .HasColumnName("IVA");

                entity.Property(e => e.Pago).HasColumnType("money");

                entity.Property(e => e.Subtotal).HasColumnType("money");

                entity.Property(e => e.Tarjeta)
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.Total).HasColumnType("money");
            });

            modelBuilder.Entity<VentasDetalle>(entity =>
            {
                entity.HasKey(e => new { e.CveVentaDetalle, e.Id });

                entity.ToTable("VentasDetalle");

                entity.Property(e => e.Id)
                    .ValueGeneratedOnAdd()
                    .HasColumnName("ID");

                entity.Property(e => e.CorteGratis)
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.Precio).HasColumnType("money");

                entity.Property(e => e.PrecioAplicado).HasColumnType("money");
            });

            modelBuilder.Entity<VentasDetalleFiscal>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("VentasDetalleFiscal");

                entity.Property(e => e.CorteGratis)
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.Precio).HasColumnType("money");

                entity.Property(e => e.PrecioAplicado).HasColumnType("money");
            });

            modelBuilder.Entity<VentasDetalleTemp>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("VentasDetalleTemp");

                entity.Property(e => e.CorteGratis)
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.Precio).HasColumnType("money");

                entity.Property(e => e.PrecioAplicado).HasColumnType("money");
            });

            modelBuilder.Entity<VentasFiscal>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("VentasFiscal");

                entity.Property(e => e.Cambio).HasColumnType("money");

                entity.Property(e => e.CveStatusVenta)
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.Descuento).HasColumnType("money");

                entity.Property(e => e.Fecha).HasColumnType("datetime");

                entity.Property(e => e.Hora).HasColumnType("datetime");

                entity.Property(e => e.HoraCancelacion).HasColumnType("datetime");

                entity.Property(e => e.Iva)
                    .HasColumnType("money")
                    .HasColumnName("IVA");

                entity.Property(e => e.Pago).HasColumnType("money");

                entity.Property(e => e.Subtotal).HasColumnType("money");

                entity.Property(e => e.Tarjeta)
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.Total).HasColumnType("money");
            });

            modelBuilder.Entity<VentasStatus>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("VentasStatus");

                entity.Property(e => e.Nombre)
                    .HasMaxLength(60)
                    .IsUnicode(false)
                    .IsFixedLength();
            });

            modelBuilder.Entity<VentasTest>(entity =>
            {
                entity.HasKey(e => new { e.CveSucursal, e.CveVenta, e.Id });

                entity.ToTable("VentasTEST");

                entity.Property(e => e.Id)
                    .ValueGeneratedOnAdd()
                    .HasColumnName("ID");

                entity.Property(e => e.Cambio).HasColumnType("money");

                entity.Property(e => e.CveStatusVenta)
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.Descuento).HasColumnType("money");

                entity.Property(e => e.Fecha).HasColumnType("datetime");

                entity.Property(e => e.Hora).HasColumnType("datetime");

                entity.Property(e => e.HoraCancelacion).HasColumnType("datetime");

                entity.Property(e => e.Iva)
                    .HasColumnType("money")
                    .HasColumnName("IVA");

                entity.Property(e => e.Pago).HasColumnType("money");

                entity.Property(e => e.Subtotal).HasColumnType("money");

                entity.Property(e => e.Tarjeta)
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.Total).HasColumnType("money");
            });

            modelBuilder.Entity<Ztemporal>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("ZTemporal");

                entity.Property(e => e.Nombre)
                    .HasMaxLength(60)
                    .IsUnicode(false)
                    .IsFixedLength();
            });

            OnModelCreatingPartial(modelBuilder);
        }

        partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
    }
}
