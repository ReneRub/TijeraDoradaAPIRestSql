namespace TD.Contracts.Dtos.Response
{
    /// <summary>
    /// BranchResponseDto
    /// </summary>
    public class BranchResponseDto
    {
        public int CveSucursal { get; set; }
        public string Descripcion { get; set; }
        public string Direccion { get; set; }
        public string? Telefono { get; set; }
        public string Ciudad { get; set; }
        public DateTime HoraEntrada { get; set; }
    }
}
