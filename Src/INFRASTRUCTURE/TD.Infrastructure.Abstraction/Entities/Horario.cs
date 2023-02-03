using System;
using System.Collections.Generic;

namespace TD.Infrastructure.Abstraction.Entities
{
    public partial class Horario
    {
        public int HorarioId { get; set; }
        public int SucursalId { get; set; }
        public int EmpleadoId { get; set; }
        public DateTime Fecha { get; set; }
        public TimeSpan HoraInicio { get; set; }
        public TimeSpan HoraFin { get; set; }
    }
}
