namespace TD.Contracts.Dtos.Response
{
    /// <summary>
    /// LoginResponseDto
    /// </summary>
    public class LoginResponseDto
    {
        public string Name { get; set; }

        public int CveEmpleado { get; set; }

        public int CveSucursal { get; set; }

        public int CveTipoEmpleado { get; set; }

        public string? Descripcion { get; set; }
    }
}
