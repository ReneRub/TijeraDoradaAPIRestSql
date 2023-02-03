using TD.Contracts.Dtos.Request;
using TD.Contracts.Dtos.Response;

namespace TD.Infrastructure.Abstraction.Repositories
{
    /// <summary>
    /// ILoginRepository
    /// </summary>
    public interface ILoginRepository
    {
        Task<List<LoginResponseDto>> GetAccessLogin(LoginRequestDto Credentials);
    }
}
