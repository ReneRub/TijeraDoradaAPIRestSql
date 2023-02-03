using System;
using System.Collections.Generic;

namespace TD.Infrastructure.Abstraction.Entities
{
    public partial class PedidosSucursal
    {
        public int CvePedido { get; set; }
        public int CveEmpleado { get; set; }
        public int CveSucursal { get; set; }
        public DateTime Fecha { get; set; }
        public short CveStatus { get; set; }
    }
}
