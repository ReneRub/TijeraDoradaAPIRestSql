using System;
using System.Collections.Generic;

namespace TD.Infrastructure.Abstraction.Entities
{
    public partial class LogEnvioWhatsApp
    {
        public int VentaId { get; set; }
        public DateTime FechaRegistro { get; set; }
        public DateTime? FechaEnvio { get; set; }
        public bool EstatusId { get; set; }
        public int TipoMsgId { get; set; }
    }
}
