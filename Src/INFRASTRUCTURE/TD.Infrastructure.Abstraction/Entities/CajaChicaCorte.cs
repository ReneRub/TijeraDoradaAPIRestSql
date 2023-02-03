using System;
using System.Collections.Generic;

namespace TD.Infrastructure.Abstraction.Entities
{
    public partial class CajaChicaCorte
    {
        public int CveSucursal { get; set; }
        public int CveCorteCaja { get; set; }
        public int CveTipoCorte { get; set; }
        public int CveEmpleado { get; set; }
        public DateTime Fecha { get; set; }
        public DateTime Hora { get; set; }
        public decimal CapitalServicios { get; set; }
        public decimal CapitalProductos { get; set; }
        public decimal CapitalTotal { get; set; }
        public decimal AjustesTarjetas { get; set; }
        public decimal AjustesEfectivo { get; set; }
        public decimal VentaTarjetas { get; set; }
        public decimal VentaEfectivo { get; set; }
        public decimal CajaChica { get; set; }
        public decimal ComprobarTarjetas { get; set; }
        public decimal ComprobarEfectivo { get; set; }
        public short B1000 { get; set; }
        public short B500 { get; set; }
        public short B200 { get; set; }
        public short B100 { get; set; }
        public short B50 { get; set; }
        public short B20 { get; set; }
        public short M100 { get; set; }
        public short M50 { get; set; }
        public short M20 { get; set; }
        public short M10 { get; set; }
        public short M5 { get; set; }
        public short M2 { get; set; }
        public short M1 { get; set; }
        public short Mp5 { get; set; }
        public short Mp20 { get; set; }
        public short Mp10 { get; set; }
        public short Mp05 { get; set; }
        public decimal TotalB { get; set; }
        public decimal TotalM { get; set; }
        public decimal TotalEfectivo { get; set; }
        public decimal DifEfectivo { get; set; }
        public int CantTarjetas { get; set; }
        public decimal TotalTarjetas { get; set; }
        public decimal DifTarjetas { get; set; }
    }
}
