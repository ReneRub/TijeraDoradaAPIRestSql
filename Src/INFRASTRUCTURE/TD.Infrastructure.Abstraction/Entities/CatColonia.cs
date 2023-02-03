using System;
using System.Collections.Generic;

namespace TD.Infrastructure.Abstraction.Entities
{
    public partial class CatColonia
    {
        public int CveCiudad { get; set; }
        public int CveColonia { get; set; }
        public string Nombre { get; set; } = null!;
    }
}
