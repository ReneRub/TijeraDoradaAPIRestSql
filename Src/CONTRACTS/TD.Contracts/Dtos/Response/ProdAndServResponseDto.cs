namespace TD.Contracts.Dtos.Response
{
    /// <summary>
    /// ProdAndServResponseDto
    /// </summary>
    public class ProdAndServResponseDto
    {
        public int CveProdServ { get; set; }
        public string? NombreCorto { get; set; }
        public string Descripcion { get; set; }
        public decimal Precio { get; set; }
        public string Proveedor { get; set; }
    }
}
