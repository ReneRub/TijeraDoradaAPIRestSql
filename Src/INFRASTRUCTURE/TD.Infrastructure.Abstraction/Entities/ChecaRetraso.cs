using System;
using System.Collections.Generic;

namespace TD.Infrastructure.Abstraction.Entities
{
    public partial class ChecaRetraso
    {
        public int CveEstilista { get; set; }
        public DateTime Fecha { get; set; }
        public DateTime Hora { get; set; }
    }
}
