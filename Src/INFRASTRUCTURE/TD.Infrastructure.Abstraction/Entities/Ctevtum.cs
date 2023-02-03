using System;
using System.Collections.Generic;

namespace TD.Infrastructure.Abstraction.Entities
{
    public partial class Ctevtum
    {
        public int Cvecliente { get; set; }
        public string? Nombre { get; set; }
        public string? Celular { get; set; }
        public int CveSucursal { get; set; }
        public int CveVenta { get; set; }
        public DateTime Fecha { get; set; }
        public DateTime Hora { get; set; }
        public decimal Total { get; set; }
    }
}
