using System;
using System.Collections.Generic;

namespace TD.Infrastructure.Abstraction.Entities
{
    public partial class CatProdServ
    {
        public int CveProdServ { get; set; }
        public int CveFamilia { get; set; }
        public int CveProveedor { get; set; }
        public string? NombreCorto { get; set; }
        public string Descripcion { get; set; } = null!;
        public decimal Precio { get; set; }
        public int Existencia { get; set; }
        public DateTime? FechaUltVta { get; set; }
        public DateTime? FechaUltComp { get; set; }
        public int ExistenciaIni { get; set; }
        public DateTime FechaExistenciaIni { get; set; }
        public short CveStatus { get; set; }

        public virtual CatProdServImagen? CatProdServImagen { get; set; }
    }
}
