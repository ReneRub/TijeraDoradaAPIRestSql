using System;
using System.Collections.Generic;

namespace TD.Infrastructure.Abstraction.Entities
{
    public partial class VentasDetalleTemp
    {
        public int CveSucursal { get; set; }
        public int CveVenta { get; set; }
        public int CveVentaDetalle { get; set; }
        public int CveEmpleado { get; set; }
        public int CveProdServ { get; set; }
        public int Cantidad { get; set; }
        public decimal Precio { get; set; }
        public decimal PrecioAplicado { get; set; }
        public string CorteGratis { get; set; } = null!;
    }
}
