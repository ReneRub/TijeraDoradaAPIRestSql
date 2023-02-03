using System;
using System.Collections.Generic;

namespace TD.Infrastructure.Abstraction.Entities
{
    public partial class LogEnvioWhatsAppPeluquera
    {
        public int OrigenId { get; set; }
        public int EmpleadoId { get; set; }
        public DateTime FechaRegistro { get; set; }
        public DateTime? FechaEnvio { get; set; }
        public bool EstatusId { get; set; }
        public int TipoMsgId { get; set; }
    }
}
