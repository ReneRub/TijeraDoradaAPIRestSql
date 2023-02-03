using System;
using System.Collections.Generic;

namespace TD.Infrastructure.Abstraction.Entities
{
    public partial class AlmacenE
    {
        public int CveEs { get; set; }
        public int CveEmpleado { get; set; }
        public DateTime Fecha { get; set; }
        public int? CveProveedor { get; set; }
        public int? Factura { get; set; }
        public string? Comentarios { get; set; }
        public short CveTipo { get; set; }
    }
}
