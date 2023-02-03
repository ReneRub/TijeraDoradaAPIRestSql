using System;
using System.Collections.Generic;

namespace TD.Infrastructure.Abstraction.Entities
{
    public partial class Descuento
    {
        public int CveDescuento { get; set; }
        public int CveProdServ { get; set; }
        public DateTime FechaIni { get; set; }
        public DateTime FechaFin { get; set; }
        public double Descuento1 { get; set; }
        public DateTime? Horaini { get; set; }
        public DateTime? Horafin { get; set; }
    }
}
