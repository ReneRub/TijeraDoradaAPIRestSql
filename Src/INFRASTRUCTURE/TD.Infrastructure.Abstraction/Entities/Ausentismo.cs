using System;
using System.Collections.Generic;

namespace TD.Infrastructure.Abstraction.Entities
{
    public partial class Ausentismo
    {
        public DateTime Fecha { get; set; }
        public int CveSucursal { get; set; }
        public int HoraIni { get; set; }
        public int HoraFin { get; set; }
        public int Cantidad { get; set; }
    }
}
