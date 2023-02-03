using System;
using System.Collections.Generic;

namespace TD.Infrastructure.Abstraction.Entities
{
    public partial class CajaChicaAjustesTipo
    {
        public int CveTipoAjuste { get; set; }
        public string Descripcion { get; set; } = null!;
    }
}
