using System;
using System.Collections.Generic;

namespace TD.Infrastructure.Abstraction.Entities
{
    public partial class VentasStatus
    {
        public int CveStatusVenta { get; set; }
        public string Nombre { get; set; } = null!;
    }
}
