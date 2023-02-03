using System;
using System.Collections.Generic;

namespace TD.Infrastructure.Abstraction.Entities
{
    public partial class CatEmpleadosStatus
    {
        public short CveStatusEmpleado { get; set; }
        public string Descripcion { get; set; } = null!;
    }
}
