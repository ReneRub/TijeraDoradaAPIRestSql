using System;
using System.Collections.Generic;

namespace TD.Infrastructure.Abstraction.Entities
{
    public partial class CatEncargado
    {
        public CatEncargado()
        {
            EncargadosXsucursals = new HashSet<EncargadosXsucursal>();
        }

        public int Id { get; set; }
        public string Nombre { get; set; } = null!;
        public string Telefono { get; set; } = null!;
        public bool EstaActivo { get; set; }

        public virtual ICollection<EncargadosXsucursal> EncargadosXsucursals { get; set; }
    }
}
