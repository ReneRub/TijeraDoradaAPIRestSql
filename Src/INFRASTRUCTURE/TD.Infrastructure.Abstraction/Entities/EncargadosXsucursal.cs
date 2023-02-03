using System;
using System.Collections.Generic;

namespace TD.Infrastructure.Abstraction.Entities
{
    public partial class EncargadosXsucursal
    {
        public int Id { get; set; }
        public int EncargadoId { get; set; }
        public int SucursalId { get; set; }
        public bool EstaActivo { get; set; }

        public virtual CatEncargado Encargado { get; set; } = null!;
    }
}
