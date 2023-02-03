using System;
using System.Collections.Generic;

namespace TD.Infrastructure.Abstraction.Entities
{
    public partial class EnvioWhatsApp
    {
        public int Id { get; set; }
        public int CveCliente { get; set; }
        public string? Nombre { get; set; }
        public string? Apepat { get; set; }
        public string? Apemat { get; set; }
        public string? Correo { get; set; }
        public DateTime? FecUltVta { get; set; }
        public string? Celular { get; set; }
        public short Servicios { get; set; }
        public string Msg { get; set; } = null!;
        public int Enviado { get; set; }
        public DateTime? FechaEnvio { get; set; }
    }
}
