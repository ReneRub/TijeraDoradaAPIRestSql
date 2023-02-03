using System;
using System.Collections.Generic;

namespace TD.Infrastructure.Abstraction.Entities
{
    public partial class ContratoRecibo
    {
        public int? ContratoId { get; set; }
        public int? ReciboId { get; set; }
        public DateTime? FechaRecibo { get; set; }
        public double? ImporteFacturacion { get; set; }
        public double? Recargos { get; set; }
    }
}
