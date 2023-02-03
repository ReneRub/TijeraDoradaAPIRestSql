using System;
using System.Collections.Generic;

namespace TD.Infrastructure.Abstraction.Entities
{
    public partial class CatEmpleadosHijo
    {
        public int CveEmpleado { get; set; }
        public string CveHijo { get; set; } = null!;
        public string Hijo { get; set; } = null!;
        public short Edad { get; set; }
        public string? Guarderia { get; set; }
    }
}
