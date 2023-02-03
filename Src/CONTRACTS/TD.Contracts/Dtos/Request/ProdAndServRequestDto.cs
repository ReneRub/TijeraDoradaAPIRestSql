namespace TD.Contracts.Dtos.Request
{
    /// <summary>
    /// ProdAndServRequestDto
    /// </summary>
    public class ProdAndServRequestDto
    {
        public int CveFamilia { get; set; }
        public int CveProveedor { get; set; }
        public string? NombreCorto { get; set; }
        public string Descripcion { get; set; } = null!;
        public decimal Precio { get; set; }
        public int Existencia { get; set; }
        public short CveStatus { get; set; }
    }
}
