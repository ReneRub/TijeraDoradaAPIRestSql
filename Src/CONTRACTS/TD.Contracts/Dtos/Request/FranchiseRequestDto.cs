namespace TD.Contracts.Dtos.Request
{
    /// <summary>
    /// FranchiseRequestDto
    /// </summary>
    public class FranchiseRequestDto
    {
        public string Descripcion { get; set; } = null!;
        public string UsuarioCreador { get; set; } = null!;
        public bool EstaActivo { get; set; }
    }
}
