using System;
using System.Collections.Generic;

namespace TD.Infrastructure.Abstraction.Entities
{
    public partial class CajerasXsucursal
    {
        public int Id { get; set; }
        public int SucursalId { get; set; }
        public int EmpleadoId { get; set; }
        public string Celular { get; set; } = null!;
    }
}
