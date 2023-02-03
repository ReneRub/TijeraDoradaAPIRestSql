using System;
using System.Collections.Generic;

namespace TD.Infrastructure.Abstraction.Entities
{
    public partial class LogConsultasApp
    {
        public int ClienteId { get; set; }
        public DateTime? FechaConsulta { get; set; }
        public string? Celular { get; set; }
        public short NumeroServicios { get; set; }
        public string? Latitud { get; set; }
        public string? Longitud { get; set; }
    }
}
