using System;
using System.Collections.Generic;

namespace TD.Infrastructure.Abstraction.Entities
{
    public partial class ChecaPermiso
    {
        public int CveSucursal { get; set; }
        public int CveEstilista { get; set; }
        public DateTime FechaIni { get; set; }
        public DateTime HoraIni { get; set; }
        public DateTime FechaFin { get; set; }
        public DateTime HoraFin { get; set; }
        public string Aurotizo { get; set; } = null!;
        public string Comentarios { get; set; } = null!;
        public int CveEstilistaCubre { get; set; }
    }
}
