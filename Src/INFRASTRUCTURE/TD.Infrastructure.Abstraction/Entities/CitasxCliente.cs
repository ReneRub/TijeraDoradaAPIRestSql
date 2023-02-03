using System;
using System.Collections.Generic;

namespace TD.Infrastructure.Abstraction.Entities
{
    public partial class CitasxCliente
    {
        public int CitaId { get; set; }
        public int SucursalId { get; set; }
        public int ClienteId { get; set; }
        public DateTime Fecha { get; set; }
        public TimeSpan Hora { get; set; }
        public int EstatusCitaId { get; set; }
        public int? EmpleadoId { get; set; }
        public DateTime? FechaCreacion { get; set; }
        public DateTime? FechaConfirmacion { get; set; }
        public DateTime? FechaModificacion { get; set; }
    }
}
