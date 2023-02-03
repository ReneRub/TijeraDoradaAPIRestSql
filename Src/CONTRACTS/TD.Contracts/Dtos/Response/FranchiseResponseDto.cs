namespace TD.Contracts.Dtos.Response
{
    /// <summary>
    /// FranchiseResponseDto
    /// </summary>
    public class FranchiseResponseDto
    {
        public int CveFranquicia { get; set; }
        public string Descripcion { get; set; }
        public string UsuarioCreador { get; set; }
        public DateTime FechaCreacion { get; set; }
        public bool EstaActivo { get; set; }
    }
}
