using System;
using System.Collections.Generic;

namespace TD.Infrastructure.Abstraction.Entities
{
    public partial class ListaEsperaStatus
    {
        public int CveStatusLista { get; set; }
        public string Decripcion { get; set; } = null!;
    }
}
