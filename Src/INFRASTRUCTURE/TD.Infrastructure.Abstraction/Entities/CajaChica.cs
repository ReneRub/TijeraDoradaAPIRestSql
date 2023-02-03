using System;
using System.Collections.Generic;

namespace TD.Infrastructure.Abstraction.Entities
{
    public partial class CajaChica
    {
        public int CveSucursal { get; set; }
        public DateTime FechaRegistro { get; set; }
        public DateTime? FechaCambios { get; set; }
        public decimal ImporteIni { get; set; }
        public decimal ImporteActual { get; set; }
        public decimal ImporteIdeal { get; set; }
    }
}
