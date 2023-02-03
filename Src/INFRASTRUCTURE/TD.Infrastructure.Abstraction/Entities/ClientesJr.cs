using System;
using System.Collections.Generic;

namespace TD.Infrastructure.Abstraction.Entities
{
    public partial class ClientesJr
    {
        public int CveCliente { get; set; }
        public string Apepat { get; set; } = null!;
        public string Apemat { get; set; } = null!;
        public string Nombres { get; set; } = null!;
        public int CveCiudad { get; set; }
        public int CveColonia { get; set; }
        public string? Telefono { get; set; }
        public string? Email { get; set; }
        public DateTime FechaRegistro { get; set; }
        public int CveSucursal { get; set; }
        public short Sellos { get; set; }
        public short CortesGratis { get; set; }
        public decimal VentasAcum { get; set; }
        public DateTime? FechaUltVta { get; set; }
        public DateTime FecUltVta { get; set; }
        public int SucUltVta { get; set; }
        public DateTime FecUltEnv { get; set; }
    }
}
