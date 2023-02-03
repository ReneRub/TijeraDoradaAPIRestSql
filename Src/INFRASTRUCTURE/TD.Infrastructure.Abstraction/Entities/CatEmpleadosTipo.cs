using System;
using System.Collections.Generic;

namespace TD.Infrastructure.Abstraction.Entities
{
    public partial class CatEmpleadosTipo
    {
        public short CveTipoEmpleado { get; set; }
        public string Descripcion { get; set; } = null!;
    }
}
