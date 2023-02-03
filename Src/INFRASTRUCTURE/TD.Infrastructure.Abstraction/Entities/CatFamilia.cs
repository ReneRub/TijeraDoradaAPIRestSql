using System;
using System.Collections.Generic;

namespace TD.Infrastructure.Abstraction.Entities
{
    public partial class CatFamilia
    {
        public int CveFamilia { get; set; }
        public string Descripcion { get; set; } = null!;
        public int? CveTipoFamilia { get; set; }
    }
}
