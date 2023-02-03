using System;
using System.Collections.Generic;

namespace TD.Infrastructure.Abstraction.Entities
{
    public partial class TiempodeEspera
    {
        public DateTime Fecha { get; set; }
        public int CveSucursal { get; set; }
        public int HoraIni { get; set; }
        public int HoraFin { get; set; }
        public int Clientes { get; set; }
        public int DuracionTotal { get; set; }
        public int TiempoPromedio { get; set; }
    }
}
