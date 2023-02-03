using System;
using System.Collections.Generic;

namespace TD.Infrastructure.Abstraction.Entities
{
    public partial class PinCliente
    {
        public int? CveCliente { get; set; }
        public string? Celular { get; set; }
        public int? PinActual { get; set; }
        public int? PinAnterior { get; set; }
        public DateTime? FechaUltimoEnvio { get; set; }
        public int? CantidadPin { get; set; }
    }
}
