namespace TD.Contracts.Dtos.Request
{
    /// <summary>
    /// Branch Request Dto
    /// </summary>
    public class BranchRequestDto
    {
        public string Descripcion { get; set; } = null!;
        public string Direccion { get; set; } = null!;
        public string? Rfc { get; set; }
        public string? RazonSocial { get; set; }
        public string? Telefono { get; set; }
        public DateTime HoraEntrada { get; set; }
        public int CveFranquicia { get; set; }
        public int? CveCiudad { get; set; }
    }
}
