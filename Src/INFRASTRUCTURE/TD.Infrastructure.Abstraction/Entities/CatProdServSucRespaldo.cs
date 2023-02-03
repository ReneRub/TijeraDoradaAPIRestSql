using System;
using System.Collections.Generic;

namespace TD.Infrastructure.Abstraction.Entities
{
    public partial class CatProdServSucRespaldo
    {
        public int CveSucursal { get; set; }
        public int CveProdServ { get; set; }
        public int Existencia { get; set; }
        public DateTime? FechaUltVta { get; set; }
        public DateTime? FechaUltComp { get; set; }
        public int ExistenciaIni { get; set; }
        public DateTime FechaExistenciaIni { get; set; }
    }
}
