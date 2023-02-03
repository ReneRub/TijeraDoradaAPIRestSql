using TD.Common;
using TD.Contracts.Dtos.Request;
using TD.Contracts.Dtos.Response;

namespace TD.Core.Abstraction.Services
{
    public interface IFamilyService
    {
        Task<StandardResponse<List<FamilyResponseDto>>> GetAllFamilies();
        Task<StandardResponse<bool>> UpdateFamily(int id, familyRequestDto family);
        Task<StandardResponse<bool>> CreateFamily(familyRequestDto family);
    }
}
