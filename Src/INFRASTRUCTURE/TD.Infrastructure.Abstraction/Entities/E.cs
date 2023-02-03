using System;
using System.Collections.Generic;

namespace TD.Infrastructure.Abstraction.Entities
{
    public partial class E
    {
        public int CveEs { get; set; }
        public int CveUsuario { get; set; }
        public string Tipo { get; set; } = null!;
        public int CveSucursal { get; set; }
        public string Factura { get; set; } = null!;
        public int CveProveedor { get; set; }
        public DateTime Fecha { get; set; }
        public string Comentarios { get; set; } = null!;
    }
}
