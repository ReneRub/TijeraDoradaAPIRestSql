using System;
using System.Collections.Generic;

namespace TD.Infrastructure.Abstraction.Entities
{
    public partial class CajaChicaAjuste
    {
        public int CveAjuste { get; set; }
        public int CveSucursal { get; set; }
        public int CveEmpleado { get; set; }
        public int CveTipoAjuste { get; set; }
        public DateTime Fecha { get; set; }
        public DateTime Hora { get; set; }
        public decimal Importe { get; set; }
        public string Autorizo { get; set; } = null!;
        public string Comentarios { get; set; } = null!;
    }
}
