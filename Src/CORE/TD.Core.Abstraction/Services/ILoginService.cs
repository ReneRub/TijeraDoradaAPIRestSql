using TD.Contracts.Dtos.Request;
using TD.Contracts.Dtos.Response;

namespace TD.Core.Abstraction.Services
{
    public interface ILoginService
    {
        Task<List<LoginResponseDto>> GetAccess(LoginRequestDto Credentials);
    }
}
