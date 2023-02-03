using System;
using System.Collections.Generic;

namespace TD.Infrastructure.Abstraction.Entities
{
    public partial class CatEmpleado
    {
        public int CveEmpleado { get; set; }
        public string Alias { get; set; } = null!;
        public string Nombre { get; set; } = null!;
        public string? Usuario { get; set; }
        public string? Password { get; set; }
        public string? Email { get; set; }
        public string? Telefono { get; set; }
        public string? Telefono2 { get; set; }
        public DateTime? FechaNac { get; set; }
        public DateTime? FechaIngreso { get; set; }
        public string? Direccion { get; set; }
        public string? Curp { get; set; }
        public string? Rfc { get; set; }
        public string? SeguroSocial { get; set; }
        public string? CtaBancaria { get; set; }
        public string? DiaDescanso { get; set; }
        public short? CveSucursal { get; set; }
        public int? CveTurno { get; set; }
        public short CveTipoEmpleado { get; set; }
        public short CveStatusEmpleado { get; set; }
        public string? Disponibilidad { get; set; }
        public bool? EsEmpleadoActual { get; set; }
    }
}
