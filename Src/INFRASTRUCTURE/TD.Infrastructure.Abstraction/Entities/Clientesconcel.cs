using System;
using System.Collections.Generic;

namespace TD.Infrastructure.Abstraction.Entities
{
    public partial class Clientesconcel
    {
        public int Id { get; set; }
        public int CveSucursal { get; set; }
        public int CveCliente { get; set; }
        public string? Nombre { get; set; }
        public string? ApePat { get; set; }
        public string? ApeMat { get; set; }
        public int CveCiudad { get; set; }
        public int CveColonia { get; set; }
        public DateTime FechaRegistro { get; set; }
        public short Sellos { get; set; }
        public string? Celular { get; set; }
    }
}
