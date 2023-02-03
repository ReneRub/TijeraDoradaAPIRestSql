using System;
using System.Collections.Generic;

namespace TD.Infrastructure.Abstraction.Entities
{
    public partial class EstatusCita
    {
        public int EstatusCitaId { get; set; }
        public string Descripcion { get; set; } = null!;
    }
}
