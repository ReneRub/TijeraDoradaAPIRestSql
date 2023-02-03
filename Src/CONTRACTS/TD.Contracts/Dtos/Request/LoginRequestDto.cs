namespace TD.Contracts.Dtos.Request
{
    /// <summary>
    /// Class to get Access
    /// </summary>
    public class LoginRequestDto
    {
        /// <summary>
        /// Gets or sets UserName
        /// </summary>
        public string? UserName { get; set; }

        /// <summary>
        /// Gets or sets Password
        /// </summary>
        public string? Password { get; set; }
    }
}
