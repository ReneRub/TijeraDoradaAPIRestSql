using System;
using System.Collections.Generic;

namespace TD.Infrastructure.Abstraction.Entities
{
    public partial class TempEnvioWhatsApp
    {
        public int Id { get; set; }
        public string? Nombres { get; set; }
        public string? ApeidoPaterno { get; set; }
        public string? ApeidoMaterno { get; set; }
        public string? Correo { get; set; }
        public DateTime FecUltVta { get; set; }
        public string? Celular { get; set; }
        public short Cortes { get; set; }
        public string? Msg { get; set; }
        public int Enviado { get; set; }
        public DateTime? FechaEnvio { get; set; }
        public int SucUltVta { get; set; }
    }
}
