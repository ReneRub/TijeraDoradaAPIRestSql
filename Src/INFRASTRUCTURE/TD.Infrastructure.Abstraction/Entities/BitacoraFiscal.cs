using System;
using System.Collections.Generic;

namespace TD.Infrastructure.Abstraction.Entities
{
    public partial class BitacoraFiscal
    {
        public int CveBitacora { get; set; }
        public int? CveSucursal { get; set; }
        public DateTime? FechaAnterior { get; set; }
        public DateTime? FechaEjecucion { get; set; }
        public DateTime? FechaVentaIni { get; set; }
        public DateTime? FechaVentaFin { get; set; }
        public int? FolioOriginalIni { get; set; }
        public int? FolioOriginalFin { get; set; }
        public int? FolioFiscalIni { get; set; }
        public int? FolioFiscalFin { get; set; }
        public int? Porciento { get; set; }
        public decimal? ImporteOriginal { get; set; }
        public decimal? ImporteFiscal { get; set; }
        public string? Terminado { get; set; }
    }
}
