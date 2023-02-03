using TD.Common;
using TD.Contracts.Dtos.Request;
using TD.Contracts.Dtos.Response;

namespace TD.Core.Abstraction.Services
{
    public interface IFranchiseService
    {
        Task<StandardResponse<List<FranchiseResponseDto>>> GetAllFranchises();
        Task<StandardResponse<bool>> UpdateFranchise(int id, FranchiseRequestDto franchise);
        Task<StandardResponse<bool>> CreateFranchise(FranchiseRequestDto franchise);
    }
}
