using System;
using System.Collections.Generic;

namespace TD.Infrastructure.Abstraction.Entities
{
    public partial class CatSucursale
    {
        public CatSucursale()
        {
            ListaEsperas = new HashSet<ListaEspera>();
        }

        public int CveSucursal { get; set; }
        public string Descripcion { get; set; } = null!;
        public string Direccion { get; set; } = null!;
        public string? Rfc { get; set; }
        public string? RazonSocial { get; set; }
        public string? Telefono { get; set; }
        public DateTime HoraEntrada { get; set; }
        public int CveFranquicia { get; set; }
        public int? CveCiudad { get; set; }

        public virtual CatFranquicia CveFranquiciaNavigation { get; set; } = null!;
        public virtual ICollection<ListaEspera> ListaEsperas { get; set; }
    }
}
