using System;
using System.Collections.Generic;

namespace TD.Infrastructure.Abstraction.Entities
{
    public partial class UbicacionXsucursal
    {
        public int SucursalId { get; set; }
        public decimal Latitud { get; set; }
        public decimal Longitud { get; set; }
    }
}
