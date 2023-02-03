using System.Threading.Tasks;
using TD.Common;
using TD.Contracts.Dtos.Request;
using TD.Contracts.Dtos.Response;

namespace TD.Core.Abstraction.Services
{
    public interface IBranchService
    {
        Task<StandardResponse<List<BranchResponseDto>>> GetAllBranches();
        Task<StandardResponse<bool>> UpdateBranch(int id, BranchRequestDto branch);
        Task<StandardResponse<bool>> CreateBranch(BranchRequestDto branch);
    }
}
