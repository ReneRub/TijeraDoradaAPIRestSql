using System;
using System.Collections.Generic;

namespace TD.Infrastructure.Abstraction.Entities
{
    public partial class CatFranquicia
    {
        public CatFranquicia()
        {
            CatSucursales = new HashSet<CatSucursale>();
        }

        public int CveFranquicia { get; set; }
        public string Descripcion { get; set; } = null!;
        public string UsuarioCreador { get; set; } = null!;
        public DateTime FechaCreacion { get; set; }
        public bool EstaActivo { get; set; }

        public virtual ICollection<CatSucursale> CatSucursales { get; set; }
    }
}
