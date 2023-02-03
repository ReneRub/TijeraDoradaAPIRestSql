using System;
using System.Collections.Generic;

namespace TD.Infrastructure.Abstraction.Entities
{
    public partial class ChecaTurno
    {
        public int CveSucursal { get; set; }
        public int CveEmpleado { get; set; }
        public DateTime Fecha { get; set; }
        public DateTime Hora { get; set; }
        public string Es { get; set; } = null!;
        public int CveEstilistaCubre { get; set; }
        public string Permiso { get; set; } = null!;
    }
}
