using System;
using System.Collections.Generic;

namespace TD.Infrastructure.Abstraction.Entities
{
    public partial class PedidosStatus
    {
        public short CveStatus { get; set; }
        public string Descripcion { get; set; } = null!;
    }
}
