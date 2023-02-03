namespace TD.Contracts.Dtos.Request
{
    /// <summary>
    /// CustomerRequestDto
    /// </summary>
    public class CustomerRequestDto
    {
        public string Apepat { get; set; } = null!;
        public string Apemat { get; set; } = null!;
        public string Nombres { get; set; } = null!;
        public int CveCiudad { get; set; }
        public int CveColonia { get; set; }
        public string? Telefono { get; set; }
        public string? Email { get; set; }
        public DateTime FechaRegistro { get; set; }
        public int CveSucursal { get; set; }
        public short Sellos { get; set; }
        public short CortesGratis { get; set; }
        public decimal VentasAcum { get; set; }
        public DateTime? FechaUltVta { get; set; }
    }
}
