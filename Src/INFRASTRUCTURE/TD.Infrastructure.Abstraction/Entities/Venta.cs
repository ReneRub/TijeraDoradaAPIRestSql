using System;
using System.Collections.Generic;

namespace TD.Infrastructure.Abstraction.Entities
{
    public partial class Venta
    {
        public int CveSucursal { get; set; }
        public int CveVenta { get; set; }
        public int CveEmpleado { get; set; }
        public DateTime Fecha { get; set; }
        public DateTime Hora { get; set; }
        public int CveCliente { get; set; }
        public decimal Subtotal { get; set; }
        public decimal Descuento { get; set; }
        public decimal Iva { get; set; }
        public decimal Total { get; set; }
        public decimal Pago { get; set; }
        public string Tarjeta { get; set; } = null!;
        public decimal Cambio { get; set; }
        public string CveStatusVenta { get; set; } = null!;
        public DateTime? HoraCancelacion { get; set; }
        public int Id { get; set; }
    }
}
