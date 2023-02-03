using System;
using System.Collections.Generic;

namespace TD.Infrastructure.Abstraction.Entities
{
    public partial class TempPedido
    {
        public int CveSucursal { get; set; }
        public int CveProdServ { get; set; }
        public int Cantidad { get; set; }
    }
}
