using System;
using System.Collections.Generic;

namespace TD.Infrastructure.Abstraction.Entities
{
    public partial class TarjetasAsignada
    {
        public string Foliotarjeta { get; set; } = null!;
        public int CveCliente { get; set; }
        public bool EstaActivo { get; set; }
        public DateTime FechaRegistro { get; set; }
        public int CveEmpleadoRegistro { get; set; }
        public int TarjetasAsignadasId { get; set; }
    }
}
