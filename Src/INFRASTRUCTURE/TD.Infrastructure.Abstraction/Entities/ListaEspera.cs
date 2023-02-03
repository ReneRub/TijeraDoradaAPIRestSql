using System;
using System.Collections.Generic;

namespace TD.Infrastructure.Abstraction.Entities
{
    public partial class ListaEspera
    {
        public int CveSucursal { get; set; }
        public int CveListaEspera { get; set; }
        public int CveCliente { get; set; }
        public DateTime Fecha { get; set; }
        public DateTime Hora { get; set; }
        public int CveStatusLista { get; set; }
        public int? CveEmpleado { get; set; }
        public int? Acompanantes { get; set; }

        public virtual CatSucursale CveSucursalNavigation { get; set; } = null!;
    }
}
