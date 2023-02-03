using System;
using System.Collections.Generic;

namespace TD.Infrastructure.Abstraction.Entities
{
    public partial class ClienteCumpleColonium
    {
        public int ClienteId { get; set; }
        public DateTime? FechaNacimiento { get; set; }
        public string Colonia { get; set; } = null!;
        public string Latitud { get; set; } = null!;
        public string Longitud { get; set; } = null!;
        public string? CodigoPostal { get; set; }
    }
}
