using System;
using System.Collections.Generic;

namespace TD.Infrastructure.Abstraction.Entities
{
    public partial class Configuracion
    {
        public int CveEmpresa { get; set; }
        public string Nombre { get; set; } = null!;
        public string Email { get; set; } = null!;
        public int CveCiudad { get; set; }
        public double? Comision { get; set; }
        public int? ComisionProd { get; set; }
    }
}
