using System;
using System.Collections.Generic;

namespace TD.Infrastructure.Abstraction.Entities
{
    public partial class CatTurno
    {
        public int CveTurnos { get; set; }
        public string Nombre { get; set; } = null!;
        public DateTime HoraIni { get; set; }
        public DateTime HoraFin { get; set; }
        public string Afecta { get; set; } = null!;
    }
}
