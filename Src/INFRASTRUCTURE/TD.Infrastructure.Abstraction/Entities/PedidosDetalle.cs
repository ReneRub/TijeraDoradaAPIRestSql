using System;
using System.Collections.Generic;

namespace TD.Infrastructure.Abstraction.Entities
{
    public partial class PedidosDetalle
    {
        public int CvePedido { get; set; }
        public int CveProdServ { get; set; }
        public int Cantidad { get; set; }
        public int? Autorizada { get; set; }
        public int? PorSurtir { get; set; }
        public int? Entregados { get; set; }
    }
}
