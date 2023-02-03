namespace TD.Contracts.Dtos.Request
{
    /// <summary>
    /// WaitingList RequestDto
    /// </summary>
    public class WaitingListRequestDto
    {
        public int CveSucursal { get; set; }
        public int CveListaEspera { get; set; }
        public int CveCliente { get; set; }
        public string Fecha { get; set; }
        public string Hora { get; set; }
    }
}
